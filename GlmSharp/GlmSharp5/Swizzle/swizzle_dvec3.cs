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
    /// Temporary vector of type double with 3 components, used for implementing swizzling for dvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_dvec3
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_dvec3.
        /// </summary>
        internal swizzle_dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns dvec3.xx swizzling.
        /// </summary>
        public dvec2 xx => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec3.rr swizzling (equivalent to dvec3.xx).
        /// </summary>
        public dvec2 rr => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec3.xxx swizzling.
        /// </summary>
        public dvec3 xxx => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec3.rrr swizzling (equivalent to dvec3.xxx).
        /// </summary>
        public dvec3 rrr => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec3.xxxx swizzling.
        /// </summary>
        public dvec4 xxxx => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.rrrr swizzling (equivalent to dvec3.xxxx).
        /// </summary>
        public dvec4 rrrr => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.xxxxx swizzling.
        /// </summary>
        public dvec5 xxxxx => new dvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.rrrrr swizzling (equivalent to dvec3.xxxxx).
        /// </summary>
        public dvec5 rrrrr => new dvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.xxxxy swizzling.
        /// </summary>
        public dvec5 xxxxy => new dvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.rrrrg swizzling (equivalent to dvec3.xxxxy).
        /// </summary>
        public dvec5 rrrrg => new dvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.xxxxz swizzling.
        /// </summary>
        public dvec5 xxxxz => new dvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.rrrrb swizzling (equivalent to dvec3.xxxxz).
        /// </summary>
        public dvec5 rrrrb => new dvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.xxxy swizzling.
        /// </summary>
        public dvec4 xxxy => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.rrrg swizzling (equivalent to dvec3.xxxy).
        /// </summary>
        public dvec4 rrrg => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.xxxyx swizzling.
        /// </summary>
        public dvec5 xxxyx => new dvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.rrrgr swizzling (equivalent to dvec3.xxxyx).
        /// </summary>
        public dvec5 rrrgr => new dvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.xxxyy swizzling.
        /// </summary>
        public dvec5 xxxyy => new dvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.rrrgg swizzling (equivalent to dvec3.xxxyy).
        /// </summary>
        public dvec5 rrrgg => new dvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.xxxyz swizzling.
        /// </summary>
        public dvec5 xxxyz => new dvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.rrrgb swizzling (equivalent to dvec3.xxxyz).
        /// </summary>
        public dvec5 rrrgb => new dvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.xxxz swizzling.
        /// </summary>
        public dvec4 xxxz => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.rrrb swizzling (equivalent to dvec3.xxxz).
        /// </summary>
        public dvec4 rrrb => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.xxxzx swizzling.
        /// </summary>
        public dvec5 xxxzx => new dvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.rrrbr swizzling (equivalent to dvec3.xxxzx).
        /// </summary>
        public dvec5 rrrbr => new dvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.xxxzy swizzling.
        /// </summary>
        public dvec5 xxxzy => new dvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.rrrbg swizzling (equivalent to dvec3.xxxzy).
        /// </summary>
        public dvec5 rrrbg => new dvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.xxxzz swizzling.
        /// </summary>
        public dvec5 xxxzz => new dvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.rrrbb swizzling (equivalent to dvec3.xxxzz).
        /// </summary>
        public dvec5 rrrbb => new dvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.xxy swizzling.
        /// </summary>
        public dvec3 xxy => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec3.rrg swizzling (equivalent to dvec3.xxy).
        /// </summary>
        public dvec3 rrg => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec3.xxyx swizzling.
        /// </summary>
        public dvec4 xxyx => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.rrgr swizzling (equivalent to dvec3.xxyx).
        /// </summary>
        public dvec4 rrgr => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.xxyxx swizzling.
        /// </summary>
        public dvec5 xxyxx => new dvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.rrgrr swizzling (equivalent to dvec3.xxyxx).
        /// </summary>
        public dvec5 rrgrr => new dvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.xxyxy swizzling.
        /// </summary>
        public dvec5 xxyxy => new dvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.rrgrg swizzling (equivalent to dvec3.xxyxy).
        /// </summary>
        public dvec5 rrgrg => new dvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.xxyxz swizzling.
        /// </summary>
        public dvec5 xxyxz => new dvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.rrgrb swizzling (equivalent to dvec3.xxyxz).
        /// </summary>
        public dvec5 rrgrb => new dvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.xxyy swizzling.
        /// </summary>
        public dvec4 xxyy => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.rrgg swizzling (equivalent to dvec3.xxyy).
        /// </summary>
        public dvec4 rrgg => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.xxyyx swizzling.
        /// </summary>
        public dvec5 xxyyx => new dvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.rrggr swizzling (equivalent to dvec3.xxyyx).
        /// </summary>
        public dvec5 rrggr => new dvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.xxyyy swizzling.
        /// </summary>
        public dvec5 xxyyy => new dvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.rrggg swizzling (equivalent to dvec3.xxyyy).
        /// </summary>
        public dvec5 rrggg => new dvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.xxyyz swizzling.
        /// </summary>
        public dvec5 xxyyz => new dvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.rrggb swizzling (equivalent to dvec3.xxyyz).
        /// </summary>
        public dvec5 rrggb => new dvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.xxyz swizzling.
        /// </summary>
        public dvec4 xxyz => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.rrgb swizzling (equivalent to dvec3.xxyz).
        /// </summary>
        public dvec4 rrgb => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.xxyzx swizzling.
        /// </summary>
        public dvec5 xxyzx => new dvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.rrgbr swizzling (equivalent to dvec3.xxyzx).
        /// </summary>
        public dvec5 rrgbr => new dvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.xxyzy swizzling.
        /// </summary>
        public dvec5 xxyzy => new dvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.rrgbg swizzling (equivalent to dvec3.xxyzy).
        /// </summary>
        public dvec5 rrgbg => new dvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.xxyzz swizzling.
        /// </summary>
        public dvec5 xxyzz => new dvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.rrgbb swizzling (equivalent to dvec3.xxyzz).
        /// </summary>
        public dvec5 rrgbb => new dvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.xxz swizzling.
        /// </summary>
        public dvec3 xxz => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec3.rrb swizzling (equivalent to dvec3.xxz).
        /// </summary>
        public dvec3 rrb => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec3.xxzx swizzling.
        /// </summary>
        public dvec4 xxzx => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.rrbr swizzling (equivalent to dvec3.xxzx).
        /// </summary>
        public dvec4 rrbr => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.xxzxx swizzling.
        /// </summary>
        public dvec5 xxzxx => new dvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.rrbrr swizzling (equivalent to dvec3.xxzxx).
        /// </summary>
        public dvec5 rrbrr => new dvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.xxzxy swizzling.
        /// </summary>
        public dvec5 xxzxy => new dvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.rrbrg swizzling (equivalent to dvec3.xxzxy).
        /// </summary>
        public dvec5 rrbrg => new dvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.xxzxz swizzling.
        /// </summary>
        public dvec5 xxzxz => new dvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.rrbrb swizzling (equivalent to dvec3.xxzxz).
        /// </summary>
        public dvec5 rrbrb => new dvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.xxzy swizzling.
        /// </summary>
        public dvec4 xxzy => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.rrbg swizzling (equivalent to dvec3.xxzy).
        /// </summary>
        public dvec4 rrbg => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.xxzyx swizzling.
        /// </summary>
        public dvec5 xxzyx => new dvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.rrbgr swizzling (equivalent to dvec3.xxzyx).
        /// </summary>
        public dvec5 rrbgr => new dvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.xxzyy swizzling.
        /// </summary>
        public dvec5 xxzyy => new dvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.rrbgg swizzling (equivalent to dvec3.xxzyy).
        /// </summary>
        public dvec5 rrbgg => new dvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.xxzyz swizzling.
        /// </summary>
        public dvec5 xxzyz => new dvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.rrbgb swizzling (equivalent to dvec3.xxzyz).
        /// </summary>
        public dvec5 rrbgb => new dvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.xxzz swizzling.
        /// </summary>
        public dvec4 xxzz => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.rrbb swizzling (equivalent to dvec3.xxzz).
        /// </summary>
        public dvec4 rrbb => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.xxzzx swizzling.
        /// </summary>
        public dvec5 xxzzx => new dvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.rrbbr swizzling (equivalent to dvec3.xxzzx).
        /// </summary>
        public dvec5 rrbbr => new dvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.xxzzy swizzling.
        /// </summary>
        public dvec5 xxzzy => new dvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.rrbbg swizzling (equivalent to dvec3.xxzzy).
        /// </summary>
        public dvec5 rrbbg => new dvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.xxzzz swizzling.
        /// </summary>
        public dvec5 xxzzz => new dvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.rrbbb swizzling (equivalent to dvec3.xxzzz).
        /// </summary>
        public dvec5 rrbbb => new dvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.xy swizzling.
        /// </summary>
        public dvec2 xy => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec3.rg swizzling (equivalent to dvec3.xy).
        /// </summary>
        public dvec2 rg => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec3.xyx swizzling.
        /// </summary>
        public dvec3 xyx => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec3.rgr swizzling (equivalent to dvec3.xyx).
        /// </summary>
        public dvec3 rgr => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec3.xyxx swizzling.
        /// </summary>
        public dvec4 xyxx => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.rgrr swizzling (equivalent to dvec3.xyxx).
        /// </summary>
        public dvec4 rgrr => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.xyxxx swizzling.
        /// </summary>
        public dvec5 xyxxx => new dvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.rgrrr swizzling (equivalent to dvec3.xyxxx).
        /// </summary>
        public dvec5 rgrrr => new dvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.xyxxy swizzling.
        /// </summary>
        public dvec5 xyxxy => new dvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.rgrrg swizzling (equivalent to dvec3.xyxxy).
        /// </summary>
        public dvec5 rgrrg => new dvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.xyxxz swizzling.
        /// </summary>
        public dvec5 xyxxz => new dvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.rgrrb swizzling (equivalent to dvec3.xyxxz).
        /// </summary>
        public dvec5 rgrrb => new dvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.xyxy swizzling.
        /// </summary>
        public dvec4 xyxy => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.rgrg swizzling (equivalent to dvec3.xyxy).
        /// </summary>
        public dvec4 rgrg => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.xyxyx swizzling.
        /// </summary>
        public dvec5 xyxyx => new dvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.rgrgr swizzling (equivalent to dvec3.xyxyx).
        /// </summary>
        public dvec5 rgrgr => new dvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.xyxyy swizzling.
        /// </summary>
        public dvec5 xyxyy => new dvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.rgrgg swizzling (equivalent to dvec3.xyxyy).
        /// </summary>
        public dvec5 rgrgg => new dvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.xyxyz swizzling.
        /// </summary>
        public dvec5 xyxyz => new dvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.rgrgb swizzling (equivalent to dvec3.xyxyz).
        /// </summary>
        public dvec5 rgrgb => new dvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.xyxz swizzling.
        /// </summary>
        public dvec4 xyxz => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.rgrb swizzling (equivalent to dvec3.xyxz).
        /// </summary>
        public dvec4 rgrb => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.xyxzx swizzling.
        /// </summary>
        public dvec5 xyxzx => new dvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.rgrbr swizzling (equivalent to dvec3.xyxzx).
        /// </summary>
        public dvec5 rgrbr => new dvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.xyxzy swizzling.
        /// </summary>
        public dvec5 xyxzy => new dvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.rgrbg swizzling (equivalent to dvec3.xyxzy).
        /// </summary>
        public dvec5 rgrbg => new dvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.xyxzz swizzling.
        /// </summary>
        public dvec5 xyxzz => new dvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.rgrbb swizzling (equivalent to dvec3.xyxzz).
        /// </summary>
        public dvec5 rgrbb => new dvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.xyy swizzling.
        /// </summary>
        public dvec3 xyy => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec3.rgg swizzling (equivalent to dvec3.xyy).
        /// </summary>
        public dvec3 rgg => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec3.xyyx swizzling.
        /// </summary>
        public dvec4 xyyx => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.rggr swizzling (equivalent to dvec3.xyyx).
        /// </summary>
        public dvec4 rggr => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.xyyxx swizzling.
        /// </summary>
        public dvec5 xyyxx => new dvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.rggrr swizzling (equivalent to dvec3.xyyxx).
        /// </summary>
        public dvec5 rggrr => new dvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.xyyxy swizzling.
        /// </summary>
        public dvec5 xyyxy => new dvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.rggrg swizzling (equivalent to dvec3.xyyxy).
        /// </summary>
        public dvec5 rggrg => new dvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.xyyxz swizzling.
        /// </summary>
        public dvec5 xyyxz => new dvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.rggrb swizzling (equivalent to dvec3.xyyxz).
        /// </summary>
        public dvec5 rggrb => new dvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.xyyy swizzling.
        /// </summary>
        public dvec4 xyyy => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.rggg swizzling (equivalent to dvec3.xyyy).
        /// </summary>
        public dvec4 rggg => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.xyyyx swizzling.
        /// </summary>
        public dvec5 xyyyx => new dvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.rgggr swizzling (equivalent to dvec3.xyyyx).
        /// </summary>
        public dvec5 rgggr => new dvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.xyyyy swizzling.
        /// </summary>
        public dvec5 xyyyy => new dvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.rgggg swizzling (equivalent to dvec3.xyyyy).
        /// </summary>
        public dvec5 rgggg => new dvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.xyyyz swizzling.
        /// </summary>
        public dvec5 xyyyz => new dvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.rgggb swizzling (equivalent to dvec3.xyyyz).
        /// </summary>
        public dvec5 rgggb => new dvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.xyyz swizzling.
        /// </summary>
        public dvec4 xyyz => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.rggb swizzling (equivalent to dvec3.xyyz).
        /// </summary>
        public dvec4 rggb => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.xyyzx swizzling.
        /// </summary>
        public dvec5 xyyzx => new dvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.rggbr swizzling (equivalent to dvec3.xyyzx).
        /// </summary>
        public dvec5 rggbr => new dvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.xyyzy swizzling.
        /// </summary>
        public dvec5 xyyzy => new dvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.rggbg swizzling (equivalent to dvec3.xyyzy).
        /// </summary>
        public dvec5 rggbg => new dvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.xyyzz swizzling.
        /// </summary>
        public dvec5 xyyzz => new dvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.rggbb swizzling (equivalent to dvec3.xyyzz).
        /// </summary>
        public dvec5 rggbb => new dvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.xyz swizzling.
        /// </summary>
        public dvec3 xyz => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec3.rgb swizzling (equivalent to dvec3.xyz).
        /// </summary>
        public dvec3 rgb => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec3.xyzx swizzling.
        /// </summary>
        public dvec4 xyzx => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.rgbr swizzling (equivalent to dvec3.xyzx).
        /// </summary>
        public dvec4 rgbr => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.xyzxx swizzling.
        /// </summary>
        public dvec5 xyzxx => new dvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.rgbrr swizzling (equivalent to dvec3.xyzxx).
        /// </summary>
        public dvec5 rgbrr => new dvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.xyzxy swizzling.
        /// </summary>
        public dvec5 xyzxy => new dvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.rgbrg swizzling (equivalent to dvec3.xyzxy).
        /// </summary>
        public dvec5 rgbrg => new dvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.xyzxz swizzling.
        /// </summary>
        public dvec5 xyzxz => new dvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.rgbrb swizzling (equivalent to dvec3.xyzxz).
        /// </summary>
        public dvec5 rgbrb => new dvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.xyzy swizzling.
        /// </summary>
        public dvec4 xyzy => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.rgbg swizzling (equivalent to dvec3.xyzy).
        /// </summary>
        public dvec4 rgbg => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.xyzyx swizzling.
        /// </summary>
        public dvec5 xyzyx => new dvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.rgbgr swizzling (equivalent to dvec3.xyzyx).
        /// </summary>
        public dvec5 rgbgr => new dvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.xyzyy swizzling.
        /// </summary>
        public dvec5 xyzyy => new dvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.rgbgg swizzling (equivalent to dvec3.xyzyy).
        /// </summary>
        public dvec5 rgbgg => new dvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.xyzyz swizzling.
        /// </summary>
        public dvec5 xyzyz => new dvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.rgbgb swizzling (equivalent to dvec3.xyzyz).
        /// </summary>
        public dvec5 rgbgb => new dvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.xyzz swizzling.
        /// </summary>
        public dvec4 xyzz => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.rgbb swizzling (equivalent to dvec3.xyzz).
        /// </summary>
        public dvec4 rgbb => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.xyzzx swizzling.
        /// </summary>
        public dvec5 xyzzx => new dvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.rgbbr swizzling (equivalent to dvec3.xyzzx).
        /// </summary>
        public dvec5 rgbbr => new dvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.xyzzy swizzling.
        /// </summary>
        public dvec5 xyzzy => new dvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.rgbbg swizzling (equivalent to dvec3.xyzzy).
        /// </summary>
        public dvec5 rgbbg => new dvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.xyzzz swizzling.
        /// </summary>
        public dvec5 xyzzz => new dvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.rgbbb swizzling (equivalent to dvec3.xyzzz).
        /// </summary>
        public dvec5 rgbbb => new dvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.xz swizzling.
        /// </summary>
        public dvec2 xz => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec3.rb swizzling (equivalent to dvec3.xz).
        /// </summary>
        public dvec2 rb => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec3.xzx swizzling.
        /// </summary>
        public dvec3 xzx => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec3.rbr swizzling (equivalent to dvec3.xzx).
        /// </summary>
        public dvec3 rbr => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec3.xzxx swizzling.
        /// </summary>
        public dvec4 xzxx => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.rbrr swizzling (equivalent to dvec3.xzxx).
        /// </summary>
        public dvec4 rbrr => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.xzxxx swizzling.
        /// </summary>
        public dvec5 xzxxx => new dvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.rbrrr swizzling (equivalent to dvec3.xzxxx).
        /// </summary>
        public dvec5 rbrrr => new dvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.xzxxy swizzling.
        /// </summary>
        public dvec5 xzxxy => new dvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.rbrrg swizzling (equivalent to dvec3.xzxxy).
        /// </summary>
        public dvec5 rbrrg => new dvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.xzxxz swizzling.
        /// </summary>
        public dvec5 xzxxz => new dvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.rbrrb swizzling (equivalent to dvec3.xzxxz).
        /// </summary>
        public dvec5 rbrrb => new dvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.xzxy swizzling.
        /// </summary>
        public dvec4 xzxy => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.rbrg swizzling (equivalent to dvec3.xzxy).
        /// </summary>
        public dvec4 rbrg => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.xzxyx swizzling.
        /// </summary>
        public dvec5 xzxyx => new dvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.rbrgr swizzling (equivalent to dvec3.xzxyx).
        /// </summary>
        public dvec5 rbrgr => new dvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.xzxyy swizzling.
        /// </summary>
        public dvec5 xzxyy => new dvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.rbrgg swizzling (equivalent to dvec3.xzxyy).
        /// </summary>
        public dvec5 rbrgg => new dvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.xzxyz swizzling.
        /// </summary>
        public dvec5 xzxyz => new dvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.rbrgb swizzling (equivalent to dvec3.xzxyz).
        /// </summary>
        public dvec5 rbrgb => new dvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.xzxz swizzling.
        /// </summary>
        public dvec4 xzxz => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.rbrb swizzling (equivalent to dvec3.xzxz).
        /// </summary>
        public dvec4 rbrb => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.xzxzx swizzling.
        /// </summary>
        public dvec5 xzxzx => new dvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.rbrbr swizzling (equivalent to dvec3.xzxzx).
        /// </summary>
        public dvec5 rbrbr => new dvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.xzxzy swizzling.
        /// </summary>
        public dvec5 xzxzy => new dvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.rbrbg swizzling (equivalent to dvec3.xzxzy).
        /// </summary>
        public dvec5 rbrbg => new dvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.xzxzz swizzling.
        /// </summary>
        public dvec5 xzxzz => new dvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.rbrbb swizzling (equivalent to dvec3.xzxzz).
        /// </summary>
        public dvec5 rbrbb => new dvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.xzy swizzling.
        /// </summary>
        public dvec3 xzy => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec3.rbg swizzling (equivalent to dvec3.xzy).
        /// </summary>
        public dvec3 rbg => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec3.xzyx swizzling.
        /// </summary>
        public dvec4 xzyx => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.rbgr swizzling (equivalent to dvec3.xzyx).
        /// </summary>
        public dvec4 rbgr => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.xzyxx swizzling.
        /// </summary>
        public dvec5 xzyxx => new dvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.rbgrr swizzling (equivalent to dvec3.xzyxx).
        /// </summary>
        public dvec5 rbgrr => new dvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.xzyxy swizzling.
        /// </summary>
        public dvec5 xzyxy => new dvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.rbgrg swizzling (equivalent to dvec3.xzyxy).
        /// </summary>
        public dvec5 rbgrg => new dvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.xzyxz swizzling.
        /// </summary>
        public dvec5 xzyxz => new dvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.rbgrb swizzling (equivalent to dvec3.xzyxz).
        /// </summary>
        public dvec5 rbgrb => new dvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.xzyy swizzling.
        /// </summary>
        public dvec4 xzyy => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.rbgg swizzling (equivalent to dvec3.xzyy).
        /// </summary>
        public dvec4 rbgg => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.xzyyx swizzling.
        /// </summary>
        public dvec5 xzyyx => new dvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.rbggr swizzling (equivalent to dvec3.xzyyx).
        /// </summary>
        public dvec5 rbggr => new dvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.xzyyy swizzling.
        /// </summary>
        public dvec5 xzyyy => new dvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.rbggg swizzling (equivalent to dvec3.xzyyy).
        /// </summary>
        public dvec5 rbggg => new dvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.xzyyz swizzling.
        /// </summary>
        public dvec5 xzyyz => new dvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.rbggb swizzling (equivalent to dvec3.xzyyz).
        /// </summary>
        public dvec5 rbggb => new dvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.xzyz swizzling.
        /// </summary>
        public dvec4 xzyz => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.rbgb swizzling (equivalent to dvec3.xzyz).
        /// </summary>
        public dvec4 rbgb => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.xzyzx swizzling.
        /// </summary>
        public dvec5 xzyzx => new dvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.rbgbr swizzling (equivalent to dvec3.xzyzx).
        /// </summary>
        public dvec5 rbgbr => new dvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.xzyzy swizzling.
        /// </summary>
        public dvec5 xzyzy => new dvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.rbgbg swizzling (equivalent to dvec3.xzyzy).
        /// </summary>
        public dvec5 rbgbg => new dvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.xzyzz swizzling.
        /// </summary>
        public dvec5 xzyzz => new dvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.rbgbb swizzling (equivalent to dvec3.xzyzz).
        /// </summary>
        public dvec5 rbgbb => new dvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.xzz swizzling.
        /// </summary>
        public dvec3 xzz => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec3.rbb swizzling (equivalent to dvec3.xzz).
        /// </summary>
        public dvec3 rbb => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec3.xzzx swizzling.
        /// </summary>
        public dvec4 xzzx => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.rbbr swizzling (equivalent to dvec3.xzzx).
        /// </summary>
        public dvec4 rbbr => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.xzzxx swizzling.
        /// </summary>
        public dvec5 xzzxx => new dvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.rbbrr swizzling (equivalent to dvec3.xzzxx).
        /// </summary>
        public dvec5 rbbrr => new dvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.xzzxy swizzling.
        /// </summary>
        public dvec5 xzzxy => new dvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.rbbrg swizzling (equivalent to dvec3.xzzxy).
        /// </summary>
        public dvec5 rbbrg => new dvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.xzzxz swizzling.
        /// </summary>
        public dvec5 xzzxz => new dvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.rbbrb swizzling (equivalent to dvec3.xzzxz).
        /// </summary>
        public dvec5 rbbrb => new dvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.xzzy swizzling.
        /// </summary>
        public dvec4 xzzy => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.rbbg swizzling (equivalent to dvec3.xzzy).
        /// </summary>
        public dvec4 rbbg => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.xzzyx swizzling.
        /// </summary>
        public dvec5 xzzyx => new dvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.rbbgr swizzling (equivalent to dvec3.xzzyx).
        /// </summary>
        public dvec5 rbbgr => new dvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.xzzyy swizzling.
        /// </summary>
        public dvec5 xzzyy => new dvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.rbbgg swizzling (equivalent to dvec3.xzzyy).
        /// </summary>
        public dvec5 rbbgg => new dvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.xzzyz swizzling.
        /// </summary>
        public dvec5 xzzyz => new dvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.rbbgb swizzling (equivalent to dvec3.xzzyz).
        /// </summary>
        public dvec5 rbbgb => new dvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.xzzz swizzling.
        /// </summary>
        public dvec4 xzzz => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.rbbb swizzling (equivalent to dvec3.xzzz).
        /// </summary>
        public dvec4 rbbb => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.xzzzx swizzling.
        /// </summary>
        public dvec5 xzzzx => new dvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.rbbbr swizzling (equivalent to dvec3.xzzzx).
        /// </summary>
        public dvec5 rbbbr => new dvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.xzzzy swizzling.
        /// </summary>
        public dvec5 xzzzy => new dvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.rbbbg swizzling (equivalent to dvec3.xzzzy).
        /// </summary>
        public dvec5 rbbbg => new dvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.xzzzz swizzling.
        /// </summary>
        public dvec5 xzzzz => new dvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns dvec3.rbbbb swizzling (equivalent to dvec3.xzzzz).
        /// </summary>
        public dvec5 rbbbb => new dvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns dvec3.yx swizzling.
        /// </summary>
        public dvec2 yx => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec3.gr swizzling (equivalent to dvec3.yx).
        /// </summary>
        public dvec2 gr => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec3.yxx swizzling.
        /// </summary>
        public dvec3 yxx => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec3.grr swizzling (equivalent to dvec3.yxx).
        /// </summary>
        public dvec3 grr => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec3.yxxx swizzling.
        /// </summary>
        public dvec4 yxxx => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.grrr swizzling (equivalent to dvec3.yxxx).
        /// </summary>
        public dvec4 grrr => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.yxxxx swizzling.
        /// </summary>
        public dvec5 yxxxx => new dvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.grrrr swizzling (equivalent to dvec3.yxxxx).
        /// </summary>
        public dvec5 grrrr => new dvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.yxxxy swizzling.
        /// </summary>
        public dvec5 yxxxy => new dvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.grrrg swizzling (equivalent to dvec3.yxxxy).
        /// </summary>
        public dvec5 grrrg => new dvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.yxxxz swizzling.
        /// </summary>
        public dvec5 yxxxz => new dvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.grrrb swizzling (equivalent to dvec3.yxxxz).
        /// </summary>
        public dvec5 grrrb => new dvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.yxxy swizzling.
        /// </summary>
        public dvec4 yxxy => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.grrg swizzling (equivalent to dvec3.yxxy).
        /// </summary>
        public dvec4 grrg => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.yxxyx swizzling.
        /// </summary>
        public dvec5 yxxyx => new dvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.grrgr swizzling (equivalent to dvec3.yxxyx).
        /// </summary>
        public dvec5 grrgr => new dvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.yxxyy swizzling.
        /// </summary>
        public dvec5 yxxyy => new dvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.grrgg swizzling (equivalent to dvec3.yxxyy).
        /// </summary>
        public dvec5 grrgg => new dvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.yxxyz swizzling.
        /// </summary>
        public dvec5 yxxyz => new dvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.grrgb swizzling (equivalent to dvec3.yxxyz).
        /// </summary>
        public dvec5 grrgb => new dvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.yxxz swizzling.
        /// </summary>
        public dvec4 yxxz => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.grrb swizzling (equivalent to dvec3.yxxz).
        /// </summary>
        public dvec4 grrb => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.yxxzx swizzling.
        /// </summary>
        public dvec5 yxxzx => new dvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.grrbr swizzling (equivalent to dvec3.yxxzx).
        /// </summary>
        public dvec5 grrbr => new dvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.yxxzy swizzling.
        /// </summary>
        public dvec5 yxxzy => new dvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.grrbg swizzling (equivalent to dvec3.yxxzy).
        /// </summary>
        public dvec5 grrbg => new dvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.yxxzz swizzling.
        /// </summary>
        public dvec5 yxxzz => new dvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.grrbb swizzling (equivalent to dvec3.yxxzz).
        /// </summary>
        public dvec5 grrbb => new dvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.yxy swizzling.
        /// </summary>
        public dvec3 yxy => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec3.grg swizzling (equivalent to dvec3.yxy).
        /// </summary>
        public dvec3 grg => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec3.yxyx swizzling.
        /// </summary>
        public dvec4 yxyx => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.grgr swizzling (equivalent to dvec3.yxyx).
        /// </summary>
        public dvec4 grgr => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.yxyxx swizzling.
        /// </summary>
        public dvec5 yxyxx => new dvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.grgrr swizzling (equivalent to dvec3.yxyxx).
        /// </summary>
        public dvec5 grgrr => new dvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.yxyxy swizzling.
        /// </summary>
        public dvec5 yxyxy => new dvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.grgrg swizzling (equivalent to dvec3.yxyxy).
        /// </summary>
        public dvec5 grgrg => new dvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.yxyxz swizzling.
        /// </summary>
        public dvec5 yxyxz => new dvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.grgrb swizzling (equivalent to dvec3.yxyxz).
        /// </summary>
        public dvec5 grgrb => new dvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.yxyy swizzling.
        /// </summary>
        public dvec4 yxyy => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.grgg swizzling (equivalent to dvec3.yxyy).
        /// </summary>
        public dvec4 grgg => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.yxyyx swizzling.
        /// </summary>
        public dvec5 yxyyx => new dvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.grggr swizzling (equivalent to dvec3.yxyyx).
        /// </summary>
        public dvec5 grggr => new dvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.yxyyy swizzling.
        /// </summary>
        public dvec5 yxyyy => new dvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.grggg swizzling (equivalent to dvec3.yxyyy).
        /// </summary>
        public dvec5 grggg => new dvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.yxyyz swizzling.
        /// </summary>
        public dvec5 yxyyz => new dvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.grggb swizzling (equivalent to dvec3.yxyyz).
        /// </summary>
        public dvec5 grggb => new dvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.yxyz swizzling.
        /// </summary>
        public dvec4 yxyz => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.grgb swizzling (equivalent to dvec3.yxyz).
        /// </summary>
        public dvec4 grgb => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.yxyzx swizzling.
        /// </summary>
        public dvec5 yxyzx => new dvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.grgbr swizzling (equivalent to dvec3.yxyzx).
        /// </summary>
        public dvec5 grgbr => new dvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.yxyzy swizzling.
        /// </summary>
        public dvec5 yxyzy => new dvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.grgbg swizzling (equivalent to dvec3.yxyzy).
        /// </summary>
        public dvec5 grgbg => new dvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.yxyzz swizzling.
        /// </summary>
        public dvec5 yxyzz => new dvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.grgbb swizzling (equivalent to dvec3.yxyzz).
        /// </summary>
        public dvec5 grgbb => new dvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.yxz swizzling.
        /// </summary>
        public dvec3 yxz => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec3.grb swizzling (equivalent to dvec3.yxz).
        /// </summary>
        public dvec3 grb => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec3.yxzx swizzling.
        /// </summary>
        public dvec4 yxzx => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.grbr swizzling (equivalent to dvec3.yxzx).
        /// </summary>
        public dvec4 grbr => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.yxzxx swizzling.
        /// </summary>
        public dvec5 yxzxx => new dvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.grbrr swizzling (equivalent to dvec3.yxzxx).
        /// </summary>
        public dvec5 grbrr => new dvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.yxzxy swizzling.
        /// </summary>
        public dvec5 yxzxy => new dvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.grbrg swizzling (equivalent to dvec3.yxzxy).
        /// </summary>
        public dvec5 grbrg => new dvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.yxzxz swizzling.
        /// </summary>
        public dvec5 yxzxz => new dvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.grbrb swizzling (equivalent to dvec3.yxzxz).
        /// </summary>
        public dvec5 grbrb => new dvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.yxzy swizzling.
        /// </summary>
        public dvec4 yxzy => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.grbg swizzling (equivalent to dvec3.yxzy).
        /// </summary>
        public dvec4 grbg => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.yxzyx swizzling.
        /// </summary>
        public dvec5 yxzyx => new dvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.grbgr swizzling (equivalent to dvec3.yxzyx).
        /// </summary>
        public dvec5 grbgr => new dvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.yxzyy swizzling.
        /// </summary>
        public dvec5 yxzyy => new dvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.grbgg swizzling (equivalent to dvec3.yxzyy).
        /// </summary>
        public dvec5 grbgg => new dvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.yxzyz swizzling.
        /// </summary>
        public dvec5 yxzyz => new dvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.grbgb swizzling (equivalent to dvec3.yxzyz).
        /// </summary>
        public dvec5 grbgb => new dvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.yxzz swizzling.
        /// </summary>
        public dvec4 yxzz => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.grbb swizzling (equivalent to dvec3.yxzz).
        /// </summary>
        public dvec4 grbb => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.yxzzx swizzling.
        /// </summary>
        public dvec5 yxzzx => new dvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.grbbr swizzling (equivalent to dvec3.yxzzx).
        /// </summary>
        public dvec5 grbbr => new dvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.yxzzy swizzling.
        /// </summary>
        public dvec5 yxzzy => new dvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.grbbg swizzling (equivalent to dvec3.yxzzy).
        /// </summary>
        public dvec5 grbbg => new dvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.yxzzz swizzling.
        /// </summary>
        public dvec5 yxzzz => new dvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.grbbb swizzling (equivalent to dvec3.yxzzz).
        /// </summary>
        public dvec5 grbbb => new dvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.yy swizzling.
        /// </summary>
        public dvec2 yy => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec3.gg swizzling (equivalent to dvec3.yy).
        /// </summary>
        public dvec2 gg => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec3.yyx swizzling.
        /// </summary>
        public dvec3 yyx => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec3.ggr swizzling (equivalent to dvec3.yyx).
        /// </summary>
        public dvec3 ggr => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec3.yyxx swizzling.
        /// </summary>
        public dvec4 yyxx => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.ggrr swizzling (equivalent to dvec3.yyxx).
        /// </summary>
        public dvec4 ggrr => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.yyxxx swizzling.
        /// </summary>
        public dvec5 yyxxx => new dvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.ggrrr swizzling (equivalent to dvec3.yyxxx).
        /// </summary>
        public dvec5 ggrrr => new dvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.yyxxy swizzling.
        /// </summary>
        public dvec5 yyxxy => new dvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.ggrrg swizzling (equivalent to dvec3.yyxxy).
        /// </summary>
        public dvec5 ggrrg => new dvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.yyxxz swizzling.
        /// </summary>
        public dvec5 yyxxz => new dvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.ggrrb swizzling (equivalent to dvec3.yyxxz).
        /// </summary>
        public dvec5 ggrrb => new dvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.yyxy swizzling.
        /// </summary>
        public dvec4 yyxy => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.ggrg swizzling (equivalent to dvec3.yyxy).
        /// </summary>
        public dvec4 ggrg => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.yyxyx swizzling.
        /// </summary>
        public dvec5 yyxyx => new dvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.ggrgr swizzling (equivalent to dvec3.yyxyx).
        /// </summary>
        public dvec5 ggrgr => new dvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.yyxyy swizzling.
        /// </summary>
        public dvec5 yyxyy => new dvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.ggrgg swizzling (equivalent to dvec3.yyxyy).
        /// </summary>
        public dvec5 ggrgg => new dvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.yyxyz swizzling.
        /// </summary>
        public dvec5 yyxyz => new dvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.ggrgb swizzling (equivalent to dvec3.yyxyz).
        /// </summary>
        public dvec5 ggrgb => new dvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.yyxz swizzling.
        /// </summary>
        public dvec4 yyxz => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.ggrb swizzling (equivalent to dvec3.yyxz).
        /// </summary>
        public dvec4 ggrb => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.yyxzx swizzling.
        /// </summary>
        public dvec5 yyxzx => new dvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.ggrbr swizzling (equivalent to dvec3.yyxzx).
        /// </summary>
        public dvec5 ggrbr => new dvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.yyxzy swizzling.
        /// </summary>
        public dvec5 yyxzy => new dvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.ggrbg swizzling (equivalent to dvec3.yyxzy).
        /// </summary>
        public dvec5 ggrbg => new dvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.yyxzz swizzling.
        /// </summary>
        public dvec5 yyxzz => new dvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.ggrbb swizzling (equivalent to dvec3.yyxzz).
        /// </summary>
        public dvec5 ggrbb => new dvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.yyy swizzling.
        /// </summary>
        public dvec3 yyy => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec3.ggg swizzling (equivalent to dvec3.yyy).
        /// </summary>
        public dvec3 ggg => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec3.yyyx swizzling.
        /// </summary>
        public dvec4 yyyx => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.gggr swizzling (equivalent to dvec3.yyyx).
        /// </summary>
        public dvec4 gggr => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.yyyxx swizzling.
        /// </summary>
        public dvec5 yyyxx => new dvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.gggrr swizzling (equivalent to dvec3.yyyxx).
        /// </summary>
        public dvec5 gggrr => new dvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.yyyxy swizzling.
        /// </summary>
        public dvec5 yyyxy => new dvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.gggrg swizzling (equivalent to dvec3.yyyxy).
        /// </summary>
        public dvec5 gggrg => new dvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.yyyxz swizzling.
        /// </summary>
        public dvec5 yyyxz => new dvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.gggrb swizzling (equivalent to dvec3.yyyxz).
        /// </summary>
        public dvec5 gggrb => new dvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.yyyy swizzling.
        /// </summary>
        public dvec4 yyyy => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.gggg swizzling (equivalent to dvec3.yyyy).
        /// </summary>
        public dvec4 gggg => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.yyyyx swizzling.
        /// </summary>
        public dvec5 yyyyx => new dvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.ggggr swizzling (equivalent to dvec3.yyyyx).
        /// </summary>
        public dvec5 ggggr => new dvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.yyyyy swizzling.
        /// </summary>
        public dvec5 yyyyy => new dvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.ggggg swizzling (equivalent to dvec3.yyyyy).
        /// </summary>
        public dvec5 ggggg => new dvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.yyyyz swizzling.
        /// </summary>
        public dvec5 yyyyz => new dvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.ggggb swizzling (equivalent to dvec3.yyyyz).
        /// </summary>
        public dvec5 ggggb => new dvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.yyyz swizzling.
        /// </summary>
        public dvec4 yyyz => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.gggb swizzling (equivalent to dvec3.yyyz).
        /// </summary>
        public dvec4 gggb => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.yyyzx swizzling.
        /// </summary>
        public dvec5 yyyzx => new dvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.gggbr swizzling (equivalent to dvec3.yyyzx).
        /// </summary>
        public dvec5 gggbr => new dvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.yyyzy swizzling.
        /// </summary>
        public dvec5 yyyzy => new dvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.gggbg swizzling (equivalent to dvec3.yyyzy).
        /// </summary>
        public dvec5 gggbg => new dvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.yyyzz swizzling.
        /// </summary>
        public dvec5 yyyzz => new dvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.gggbb swizzling (equivalent to dvec3.yyyzz).
        /// </summary>
        public dvec5 gggbb => new dvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.yyz swizzling.
        /// </summary>
        public dvec3 yyz => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec3.ggb swizzling (equivalent to dvec3.yyz).
        /// </summary>
        public dvec3 ggb => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec3.yyzx swizzling.
        /// </summary>
        public dvec4 yyzx => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.ggbr swizzling (equivalent to dvec3.yyzx).
        /// </summary>
        public dvec4 ggbr => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.yyzxx swizzling.
        /// </summary>
        public dvec5 yyzxx => new dvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.ggbrr swizzling (equivalent to dvec3.yyzxx).
        /// </summary>
        public dvec5 ggbrr => new dvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.yyzxy swizzling.
        /// </summary>
        public dvec5 yyzxy => new dvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.ggbrg swizzling (equivalent to dvec3.yyzxy).
        /// </summary>
        public dvec5 ggbrg => new dvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.yyzxz swizzling.
        /// </summary>
        public dvec5 yyzxz => new dvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.ggbrb swizzling (equivalent to dvec3.yyzxz).
        /// </summary>
        public dvec5 ggbrb => new dvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.yyzy swizzling.
        /// </summary>
        public dvec4 yyzy => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.ggbg swizzling (equivalent to dvec3.yyzy).
        /// </summary>
        public dvec4 ggbg => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.yyzyx swizzling.
        /// </summary>
        public dvec5 yyzyx => new dvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.ggbgr swizzling (equivalent to dvec3.yyzyx).
        /// </summary>
        public dvec5 ggbgr => new dvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.yyzyy swizzling.
        /// </summary>
        public dvec5 yyzyy => new dvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.ggbgg swizzling (equivalent to dvec3.yyzyy).
        /// </summary>
        public dvec5 ggbgg => new dvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.yyzyz swizzling.
        /// </summary>
        public dvec5 yyzyz => new dvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.ggbgb swizzling (equivalent to dvec3.yyzyz).
        /// </summary>
        public dvec5 ggbgb => new dvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.yyzz swizzling.
        /// </summary>
        public dvec4 yyzz => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.ggbb swizzling (equivalent to dvec3.yyzz).
        /// </summary>
        public dvec4 ggbb => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.yyzzx swizzling.
        /// </summary>
        public dvec5 yyzzx => new dvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.ggbbr swizzling (equivalent to dvec3.yyzzx).
        /// </summary>
        public dvec5 ggbbr => new dvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.yyzzy swizzling.
        /// </summary>
        public dvec5 yyzzy => new dvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.ggbbg swizzling (equivalent to dvec3.yyzzy).
        /// </summary>
        public dvec5 ggbbg => new dvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.yyzzz swizzling.
        /// </summary>
        public dvec5 yyzzz => new dvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.ggbbb swizzling (equivalent to dvec3.yyzzz).
        /// </summary>
        public dvec5 ggbbb => new dvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.yz swizzling.
        /// </summary>
        public dvec2 yz => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec3.gb swizzling (equivalent to dvec3.yz).
        /// </summary>
        public dvec2 gb => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec3.yzx swizzling.
        /// </summary>
        public dvec3 yzx => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec3.gbr swizzling (equivalent to dvec3.yzx).
        /// </summary>
        public dvec3 gbr => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec3.yzxx swizzling.
        /// </summary>
        public dvec4 yzxx => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.gbrr swizzling (equivalent to dvec3.yzxx).
        /// </summary>
        public dvec4 gbrr => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.yzxxx swizzling.
        /// </summary>
        public dvec5 yzxxx => new dvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.gbrrr swizzling (equivalent to dvec3.yzxxx).
        /// </summary>
        public dvec5 gbrrr => new dvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.yzxxy swizzling.
        /// </summary>
        public dvec5 yzxxy => new dvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.gbrrg swizzling (equivalent to dvec3.yzxxy).
        /// </summary>
        public dvec5 gbrrg => new dvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.yzxxz swizzling.
        /// </summary>
        public dvec5 yzxxz => new dvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.gbrrb swizzling (equivalent to dvec3.yzxxz).
        /// </summary>
        public dvec5 gbrrb => new dvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.yzxy swizzling.
        /// </summary>
        public dvec4 yzxy => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.gbrg swizzling (equivalent to dvec3.yzxy).
        /// </summary>
        public dvec4 gbrg => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.yzxyx swizzling.
        /// </summary>
        public dvec5 yzxyx => new dvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.gbrgr swizzling (equivalent to dvec3.yzxyx).
        /// </summary>
        public dvec5 gbrgr => new dvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.yzxyy swizzling.
        /// </summary>
        public dvec5 yzxyy => new dvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.gbrgg swizzling (equivalent to dvec3.yzxyy).
        /// </summary>
        public dvec5 gbrgg => new dvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.yzxyz swizzling.
        /// </summary>
        public dvec5 yzxyz => new dvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.gbrgb swizzling (equivalent to dvec3.yzxyz).
        /// </summary>
        public dvec5 gbrgb => new dvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.yzxz swizzling.
        /// </summary>
        public dvec4 yzxz => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.gbrb swizzling (equivalent to dvec3.yzxz).
        /// </summary>
        public dvec4 gbrb => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.yzxzx swizzling.
        /// </summary>
        public dvec5 yzxzx => new dvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.gbrbr swizzling (equivalent to dvec3.yzxzx).
        /// </summary>
        public dvec5 gbrbr => new dvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.yzxzy swizzling.
        /// </summary>
        public dvec5 yzxzy => new dvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.gbrbg swizzling (equivalent to dvec3.yzxzy).
        /// </summary>
        public dvec5 gbrbg => new dvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.yzxzz swizzling.
        /// </summary>
        public dvec5 yzxzz => new dvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.gbrbb swizzling (equivalent to dvec3.yzxzz).
        /// </summary>
        public dvec5 gbrbb => new dvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.yzy swizzling.
        /// </summary>
        public dvec3 yzy => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec3.gbg swizzling (equivalent to dvec3.yzy).
        /// </summary>
        public dvec3 gbg => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec3.yzyx swizzling.
        /// </summary>
        public dvec4 yzyx => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.gbgr swizzling (equivalent to dvec3.yzyx).
        /// </summary>
        public dvec4 gbgr => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.yzyxx swizzling.
        /// </summary>
        public dvec5 yzyxx => new dvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.gbgrr swizzling (equivalent to dvec3.yzyxx).
        /// </summary>
        public dvec5 gbgrr => new dvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.yzyxy swizzling.
        /// </summary>
        public dvec5 yzyxy => new dvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.gbgrg swizzling (equivalent to dvec3.yzyxy).
        /// </summary>
        public dvec5 gbgrg => new dvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.yzyxz swizzling.
        /// </summary>
        public dvec5 yzyxz => new dvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.gbgrb swizzling (equivalent to dvec3.yzyxz).
        /// </summary>
        public dvec5 gbgrb => new dvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.yzyy swizzling.
        /// </summary>
        public dvec4 yzyy => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.gbgg swizzling (equivalent to dvec3.yzyy).
        /// </summary>
        public dvec4 gbgg => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.yzyyx swizzling.
        /// </summary>
        public dvec5 yzyyx => new dvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.gbggr swizzling (equivalent to dvec3.yzyyx).
        /// </summary>
        public dvec5 gbggr => new dvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.yzyyy swizzling.
        /// </summary>
        public dvec5 yzyyy => new dvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.gbggg swizzling (equivalent to dvec3.yzyyy).
        /// </summary>
        public dvec5 gbggg => new dvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.yzyyz swizzling.
        /// </summary>
        public dvec5 yzyyz => new dvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.gbggb swizzling (equivalent to dvec3.yzyyz).
        /// </summary>
        public dvec5 gbggb => new dvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.yzyz swizzling.
        /// </summary>
        public dvec4 yzyz => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.gbgb swizzling (equivalent to dvec3.yzyz).
        /// </summary>
        public dvec4 gbgb => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.yzyzx swizzling.
        /// </summary>
        public dvec5 yzyzx => new dvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.gbgbr swizzling (equivalent to dvec3.yzyzx).
        /// </summary>
        public dvec5 gbgbr => new dvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.yzyzy swizzling.
        /// </summary>
        public dvec5 yzyzy => new dvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.gbgbg swizzling (equivalent to dvec3.yzyzy).
        /// </summary>
        public dvec5 gbgbg => new dvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.yzyzz swizzling.
        /// </summary>
        public dvec5 yzyzz => new dvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.gbgbb swizzling (equivalent to dvec3.yzyzz).
        /// </summary>
        public dvec5 gbgbb => new dvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.yzz swizzling.
        /// </summary>
        public dvec3 yzz => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec3.gbb swizzling (equivalent to dvec3.yzz).
        /// </summary>
        public dvec3 gbb => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec3.yzzx swizzling.
        /// </summary>
        public dvec4 yzzx => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.gbbr swizzling (equivalent to dvec3.yzzx).
        /// </summary>
        public dvec4 gbbr => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.yzzxx swizzling.
        /// </summary>
        public dvec5 yzzxx => new dvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.gbbrr swizzling (equivalent to dvec3.yzzxx).
        /// </summary>
        public dvec5 gbbrr => new dvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.yzzxy swizzling.
        /// </summary>
        public dvec5 yzzxy => new dvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.gbbrg swizzling (equivalent to dvec3.yzzxy).
        /// </summary>
        public dvec5 gbbrg => new dvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.yzzxz swizzling.
        /// </summary>
        public dvec5 yzzxz => new dvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.gbbrb swizzling (equivalent to dvec3.yzzxz).
        /// </summary>
        public dvec5 gbbrb => new dvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.yzzy swizzling.
        /// </summary>
        public dvec4 yzzy => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.gbbg swizzling (equivalent to dvec3.yzzy).
        /// </summary>
        public dvec4 gbbg => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.yzzyx swizzling.
        /// </summary>
        public dvec5 yzzyx => new dvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.gbbgr swizzling (equivalent to dvec3.yzzyx).
        /// </summary>
        public dvec5 gbbgr => new dvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.yzzyy swizzling.
        /// </summary>
        public dvec5 yzzyy => new dvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.gbbgg swizzling (equivalent to dvec3.yzzyy).
        /// </summary>
        public dvec5 gbbgg => new dvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.yzzyz swizzling.
        /// </summary>
        public dvec5 yzzyz => new dvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.gbbgb swizzling (equivalent to dvec3.yzzyz).
        /// </summary>
        public dvec5 gbbgb => new dvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.yzzz swizzling.
        /// </summary>
        public dvec4 yzzz => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.gbbb swizzling (equivalent to dvec3.yzzz).
        /// </summary>
        public dvec4 gbbb => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.yzzzx swizzling.
        /// </summary>
        public dvec5 yzzzx => new dvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.gbbbr swizzling (equivalent to dvec3.yzzzx).
        /// </summary>
        public dvec5 gbbbr => new dvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.yzzzy swizzling.
        /// </summary>
        public dvec5 yzzzy => new dvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.gbbbg swizzling (equivalent to dvec3.yzzzy).
        /// </summary>
        public dvec5 gbbbg => new dvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.yzzzz swizzling.
        /// </summary>
        public dvec5 yzzzz => new dvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns dvec3.gbbbb swizzling (equivalent to dvec3.yzzzz).
        /// </summary>
        public dvec5 gbbbb => new dvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns dvec3.zx swizzling.
        /// </summary>
        public dvec2 zx => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec3.br swizzling (equivalent to dvec3.zx).
        /// </summary>
        public dvec2 br => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec3.zxx swizzling.
        /// </summary>
        public dvec3 zxx => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec3.brr swizzling (equivalent to dvec3.zxx).
        /// </summary>
        public dvec3 brr => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec3.zxxx swizzling.
        /// </summary>
        public dvec4 zxxx => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.brrr swizzling (equivalent to dvec3.zxxx).
        /// </summary>
        public dvec4 brrr => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.zxxxx swizzling.
        /// </summary>
        public dvec5 zxxxx => new dvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.brrrr swizzling (equivalent to dvec3.zxxxx).
        /// </summary>
        public dvec5 brrrr => new dvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.zxxxy swizzling.
        /// </summary>
        public dvec5 zxxxy => new dvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.brrrg swizzling (equivalent to dvec3.zxxxy).
        /// </summary>
        public dvec5 brrrg => new dvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.zxxxz swizzling.
        /// </summary>
        public dvec5 zxxxz => new dvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.brrrb swizzling (equivalent to dvec3.zxxxz).
        /// </summary>
        public dvec5 brrrb => new dvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.zxxy swizzling.
        /// </summary>
        public dvec4 zxxy => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.brrg swizzling (equivalent to dvec3.zxxy).
        /// </summary>
        public dvec4 brrg => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.zxxyx swizzling.
        /// </summary>
        public dvec5 zxxyx => new dvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.brrgr swizzling (equivalent to dvec3.zxxyx).
        /// </summary>
        public dvec5 brrgr => new dvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.zxxyy swizzling.
        /// </summary>
        public dvec5 zxxyy => new dvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.brrgg swizzling (equivalent to dvec3.zxxyy).
        /// </summary>
        public dvec5 brrgg => new dvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.zxxyz swizzling.
        /// </summary>
        public dvec5 zxxyz => new dvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.brrgb swizzling (equivalent to dvec3.zxxyz).
        /// </summary>
        public dvec5 brrgb => new dvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.zxxz swizzling.
        /// </summary>
        public dvec4 zxxz => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.brrb swizzling (equivalent to dvec3.zxxz).
        /// </summary>
        public dvec4 brrb => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.zxxzx swizzling.
        /// </summary>
        public dvec5 zxxzx => new dvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.brrbr swizzling (equivalent to dvec3.zxxzx).
        /// </summary>
        public dvec5 brrbr => new dvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.zxxzy swizzling.
        /// </summary>
        public dvec5 zxxzy => new dvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.brrbg swizzling (equivalent to dvec3.zxxzy).
        /// </summary>
        public dvec5 brrbg => new dvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.zxxzz swizzling.
        /// </summary>
        public dvec5 zxxzz => new dvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.brrbb swizzling (equivalent to dvec3.zxxzz).
        /// </summary>
        public dvec5 brrbb => new dvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.zxy swizzling.
        /// </summary>
        public dvec3 zxy => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec3.brg swizzling (equivalent to dvec3.zxy).
        /// </summary>
        public dvec3 brg => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec3.zxyx swizzling.
        /// </summary>
        public dvec4 zxyx => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.brgr swizzling (equivalent to dvec3.zxyx).
        /// </summary>
        public dvec4 brgr => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.zxyxx swizzling.
        /// </summary>
        public dvec5 zxyxx => new dvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.brgrr swizzling (equivalent to dvec3.zxyxx).
        /// </summary>
        public dvec5 brgrr => new dvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.zxyxy swizzling.
        /// </summary>
        public dvec5 zxyxy => new dvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.brgrg swizzling (equivalent to dvec3.zxyxy).
        /// </summary>
        public dvec5 brgrg => new dvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.zxyxz swizzling.
        /// </summary>
        public dvec5 zxyxz => new dvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.brgrb swizzling (equivalent to dvec3.zxyxz).
        /// </summary>
        public dvec5 brgrb => new dvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.zxyy swizzling.
        /// </summary>
        public dvec4 zxyy => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.brgg swizzling (equivalent to dvec3.zxyy).
        /// </summary>
        public dvec4 brgg => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.zxyyx swizzling.
        /// </summary>
        public dvec5 zxyyx => new dvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.brggr swizzling (equivalent to dvec3.zxyyx).
        /// </summary>
        public dvec5 brggr => new dvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.zxyyy swizzling.
        /// </summary>
        public dvec5 zxyyy => new dvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.brggg swizzling (equivalent to dvec3.zxyyy).
        /// </summary>
        public dvec5 brggg => new dvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.zxyyz swizzling.
        /// </summary>
        public dvec5 zxyyz => new dvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.brggb swizzling (equivalent to dvec3.zxyyz).
        /// </summary>
        public dvec5 brggb => new dvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.zxyz swizzling.
        /// </summary>
        public dvec4 zxyz => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.brgb swizzling (equivalent to dvec3.zxyz).
        /// </summary>
        public dvec4 brgb => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.zxyzx swizzling.
        /// </summary>
        public dvec5 zxyzx => new dvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.brgbr swizzling (equivalent to dvec3.zxyzx).
        /// </summary>
        public dvec5 brgbr => new dvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.zxyzy swizzling.
        /// </summary>
        public dvec5 zxyzy => new dvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.brgbg swizzling (equivalent to dvec3.zxyzy).
        /// </summary>
        public dvec5 brgbg => new dvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.zxyzz swizzling.
        /// </summary>
        public dvec5 zxyzz => new dvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.brgbb swizzling (equivalent to dvec3.zxyzz).
        /// </summary>
        public dvec5 brgbb => new dvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.zxz swizzling.
        /// </summary>
        public dvec3 zxz => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec3.brb swizzling (equivalent to dvec3.zxz).
        /// </summary>
        public dvec3 brb => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec3.zxzx swizzling.
        /// </summary>
        public dvec4 zxzx => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.brbr swizzling (equivalent to dvec3.zxzx).
        /// </summary>
        public dvec4 brbr => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.zxzxx swizzling.
        /// </summary>
        public dvec5 zxzxx => new dvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.brbrr swizzling (equivalent to dvec3.zxzxx).
        /// </summary>
        public dvec5 brbrr => new dvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.zxzxy swizzling.
        /// </summary>
        public dvec5 zxzxy => new dvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.brbrg swizzling (equivalent to dvec3.zxzxy).
        /// </summary>
        public dvec5 brbrg => new dvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.zxzxz swizzling.
        /// </summary>
        public dvec5 zxzxz => new dvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.brbrb swizzling (equivalent to dvec3.zxzxz).
        /// </summary>
        public dvec5 brbrb => new dvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.zxzy swizzling.
        /// </summary>
        public dvec4 zxzy => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.brbg swizzling (equivalent to dvec3.zxzy).
        /// </summary>
        public dvec4 brbg => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.zxzyx swizzling.
        /// </summary>
        public dvec5 zxzyx => new dvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.brbgr swizzling (equivalent to dvec3.zxzyx).
        /// </summary>
        public dvec5 brbgr => new dvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.zxzyy swizzling.
        /// </summary>
        public dvec5 zxzyy => new dvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.brbgg swizzling (equivalent to dvec3.zxzyy).
        /// </summary>
        public dvec5 brbgg => new dvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.zxzyz swizzling.
        /// </summary>
        public dvec5 zxzyz => new dvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.brbgb swizzling (equivalent to dvec3.zxzyz).
        /// </summary>
        public dvec5 brbgb => new dvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.zxzz swizzling.
        /// </summary>
        public dvec4 zxzz => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.brbb swizzling (equivalent to dvec3.zxzz).
        /// </summary>
        public dvec4 brbb => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.zxzzx swizzling.
        /// </summary>
        public dvec5 zxzzx => new dvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.brbbr swizzling (equivalent to dvec3.zxzzx).
        /// </summary>
        public dvec5 brbbr => new dvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.zxzzy swizzling.
        /// </summary>
        public dvec5 zxzzy => new dvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.brbbg swizzling (equivalent to dvec3.zxzzy).
        /// </summary>
        public dvec5 brbbg => new dvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.zxzzz swizzling.
        /// </summary>
        public dvec5 zxzzz => new dvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.brbbb swizzling (equivalent to dvec3.zxzzz).
        /// </summary>
        public dvec5 brbbb => new dvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.zy swizzling.
        /// </summary>
        public dvec2 zy => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec3.bg swizzling (equivalent to dvec3.zy).
        /// </summary>
        public dvec2 bg => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec3.zyx swizzling.
        /// </summary>
        public dvec3 zyx => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec3.bgr swizzling (equivalent to dvec3.zyx).
        /// </summary>
        public dvec3 bgr => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec3.zyxx swizzling.
        /// </summary>
        public dvec4 zyxx => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.bgrr swizzling (equivalent to dvec3.zyxx).
        /// </summary>
        public dvec4 bgrr => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.zyxxx swizzling.
        /// </summary>
        public dvec5 zyxxx => new dvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.bgrrr swizzling (equivalent to dvec3.zyxxx).
        /// </summary>
        public dvec5 bgrrr => new dvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.zyxxy swizzling.
        /// </summary>
        public dvec5 zyxxy => new dvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.bgrrg swizzling (equivalent to dvec3.zyxxy).
        /// </summary>
        public dvec5 bgrrg => new dvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.zyxxz swizzling.
        /// </summary>
        public dvec5 zyxxz => new dvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.bgrrb swizzling (equivalent to dvec3.zyxxz).
        /// </summary>
        public dvec5 bgrrb => new dvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.zyxy swizzling.
        /// </summary>
        public dvec4 zyxy => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.bgrg swizzling (equivalent to dvec3.zyxy).
        /// </summary>
        public dvec4 bgrg => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.zyxyx swizzling.
        /// </summary>
        public dvec5 zyxyx => new dvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.bgrgr swizzling (equivalent to dvec3.zyxyx).
        /// </summary>
        public dvec5 bgrgr => new dvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.zyxyy swizzling.
        /// </summary>
        public dvec5 zyxyy => new dvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.bgrgg swizzling (equivalent to dvec3.zyxyy).
        /// </summary>
        public dvec5 bgrgg => new dvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.zyxyz swizzling.
        /// </summary>
        public dvec5 zyxyz => new dvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.bgrgb swizzling (equivalent to dvec3.zyxyz).
        /// </summary>
        public dvec5 bgrgb => new dvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.zyxz swizzling.
        /// </summary>
        public dvec4 zyxz => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.bgrb swizzling (equivalent to dvec3.zyxz).
        /// </summary>
        public dvec4 bgrb => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.zyxzx swizzling.
        /// </summary>
        public dvec5 zyxzx => new dvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.bgrbr swizzling (equivalent to dvec3.zyxzx).
        /// </summary>
        public dvec5 bgrbr => new dvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.zyxzy swizzling.
        /// </summary>
        public dvec5 zyxzy => new dvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.bgrbg swizzling (equivalent to dvec3.zyxzy).
        /// </summary>
        public dvec5 bgrbg => new dvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.zyxzz swizzling.
        /// </summary>
        public dvec5 zyxzz => new dvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.bgrbb swizzling (equivalent to dvec3.zyxzz).
        /// </summary>
        public dvec5 bgrbb => new dvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.zyy swizzling.
        /// </summary>
        public dvec3 zyy => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec3.bgg swizzling (equivalent to dvec3.zyy).
        /// </summary>
        public dvec3 bgg => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec3.zyyx swizzling.
        /// </summary>
        public dvec4 zyyx => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.bggr swizzling (equivalent to dvec3.zyyx).
        /// </summary>
        public dvec4 bggr => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.zyyxx swizzling.
        /// </summary>
        public dvec5 zyyxx => new dvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.bggrr swizzling (equivalent to dvec3.zyyxx).
        /// </summary>
        public dvec5 bggrr => new dvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.zyyxy swizzling.
        /// </summary>
        public dvec5 zyyxy => new dvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.bggrg swizzling (equivalent to dvec3.zyyxy).
        /// </summary>
        public dvec5 bggrg => new dvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.zyyxz swizzling.
        /// </summary>
        public dvec5 zyyxz => new dvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.bggrb swizzling (equivalent to dvec3.zyyxz).
        /// </summary>
        public dvec5 bggrb => new dvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.zyyy swizzling.
        /// </summary>
        public dvec4 zyyy => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.bggg swizzling (equivalent to dvec3.zyyy).
        /// </summary>
        public dvec4 bggg => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.zyyyx swizzling.
        /// </summary>
        public dvec5 zyyyx => new dvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.bgggr swizzling (equivalent to dvec3.zyyyx).
        /// </summary>
        public dvec5 bgggr => new dvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.zyyyy swizzling.
        /// </summary>
        public dvec5 zyyyy => new dvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.bgggg swizzling (equivalent to dvec3.zyyyy).
        /// </summary>
        public dvec5 bgggg => new dvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.zyyyz swizzling.
        /// </summary>
        public dvec5 zyyyz => new dvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.bgggb swizzling (equivalent to dvec3.zyyyz).
        /// </summary>
        public dvec5 bgggb => new dvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.zyyz swizzling.
        /// </summary>
        public dvec4 zyyz => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.bggb swizzling (equivalent to dvec3.zyyz).
        /// </summary>
        public dvec4 bggb => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.zyyzx swizzling.
        /// </summary>
        public dvec5 zyyzx => new dvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.bggbr swizzling (equivalent to dvec3.zyyzx).
        /// </summary>
        public dvec5 bggbr => new dvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.zyyzy swizzling.
        /// </summary>
        public dvec5 zyyzy => new dvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.bggbg swizzling (equivalent to dvec3.zyyzy).
        /// </summary>
        public dvec5 bggbg => new dvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.zyyzz swizzling.
        /// </summary>
        public dvec5 zyyzz => new dvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.bggbb swizzling (equivalent to dvec3.zyyzz).
        /// </summary>
        public dvec5 bggbb => new dvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.zyz swizzling.
        /// </summary>
        public dvec3 zyz => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec3.bgb swizzling (equivalent to dvec3.zyz).
        /// </summary>
        public dvec3 bgb => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec3.zyzx swizzling.
        /// </summary>
        public dvec4 zyzx => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.bgbr swizzling (equivalent to dvec3.zyzx).
        /// </summary>
        public dvec4 bgbr => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.zyzxx swizzling.
        /// </summary>
        public dvec5 zyzxx => new dvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.bgbrr swizzling (equivalent to dvec3.zyzxx).
        /// </summary>
        public dvec5 bgbrr => new dvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.zyzxy swizzling.
        /// </summary>
        public dvec5 zyzxy => new dvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.bgbrg swizzling (equivalent to dvec3.zyzxy).
        /// </summary>
        public dvec5 bgbrg => new dvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.zyzxz swizzling.
        /// </summary>
        public dvec5 zyzxz => new dvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.bgbrb swizzling (equivalent to dvec3.zyzxz).
        /// </summary>
        public dvec5 bgbrb => new dvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.zyzy swizzling.
        /// </summary>
        public dvec4 zyzy => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.bgbg swizzling (equivalent to dvec3.zyzy).
        /// </summary>
        public dvec4 bgbg => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.zyzyx swizzling.
        /// </summary>
        public dvec5 zyzyx => new dvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.bgbgr swizzling (equivalent to dvec3.zyzyx).
        /// </summary>
        public dvec5 bgbgr => new dvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.zyzyy swizzling.
        /// </summary>
        public dvec5 zyzyy => new dvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.bgbgg swizzling (equivalent to dvec3.zyzyy).
        /// </summary>
        public dvec5 bgbgg => new dvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.zyzyz swizzling.
        /// </summary>
        public dvec5 zyzyz => new dvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.bgbgb swizzling (equivalent to dvec3.zyzyz).
        /// </summary>
        public dvec5 bgbgb => new dvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.zyzz swizzling.
        /// </summary>
        public dvec4 zyzz => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.bgbb swizzling (equivalent to dvec3.zyzz).
        /// </summary>
        public dvec4 bgbb => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.zyzzx swizzling.
        /// </summary>
        public dvec5 zyzzx => new dvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.bgbbr swizzling (equivalent to dvec3.zyzzx).
        /// </summary>
        public dvec5 bgbbr => new dvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.zyzzy swizzling.
        /// </summary>
        public dvec5 zyzzy => new dvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.bgbbg swizzling (equivalent to dvec3.zyzzy).
        /// </summary>
        public dvec5 bgbbg => new dvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.zyzzz swizzling.
        /// </summary>
        public dvec5 zyzzz => new dvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.bgbbb swizzling (equivalent to dvec3.zyzzz).
        /// </summary>
        public dvec5 bgbbb => new dvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.zz swizzling.
        /// </summary>
        public dvec2 zz => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec3.bb swizzling (equivalent to dvec3.zz).
        /// </summary>
        public dvec2 bb => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec3.zzx swizzling.
        /// </summary>
        public dvec3 zzx => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec3.bbr swizzling (equivalent to dvec3.zzx).
        /// </summary>
        public dvec3 bbr => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec3.zzxx swizzling.
        /// </summary>
        public dvec4 zzxx => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.bbrr swizzling (equivalent to dvec3.zzxx).
        /// </summary>
        public dvec4 bbrr => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.zzxxx swizzling.
        /// </summary>
        public dvec5 zzxxx => new dvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.bbrrr swizzling (equivalent to dvec3.zzxxx).
        /// </summary>
        public dvec5 bbrrr => new dvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.zzxxy swizzling.
        /// </summary>
        public dvec5 zzxxy => new dvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.bbrrg swizzling (equivalent to dvec3.zzxxy).
        /// </summary>
        public dvec5 bbrrg => new dvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.zzxxz swizzling.
        /// </summary>
        public dvec5 zzxxz => new dvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.bbrrb swizzling (equivalent to dvec3.zzxxz).
        /// </summary>
        public dvec5 bbrrb => new dvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.zzxy swizzling.
        /// </summary>
        public dvec4 zzxy => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.bbrg swizzling (equivalent to dvec3.zzxy).
        /// </summary>
        public dvec4 bbrg => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.zzxyx swizzling.
        /// </summary>
        public dvec5 zzxyx => new dvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.bbrgr swizzling (equivalent to dvec3.zzxyx).
        /// </summary>
        public dvec5 bbrgr => new dvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.zzxyy swizzling.
        /// </summary>
        public dvec5 zzxyy => new dvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.bbrgg swizzling (equivalent to dvec3.zzxyy).
        /// </summary>
        public dvec5 bbrgg => new dvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.zzxyz swizzling.
        /// </summary>
        public dvec5 zzxyz => new dvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.bbrgb swizzling (equivalent to dvec3.zzxyz).
        /// </summary>
        public dvec5 bbrgb => new dvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.zzxz swizzling.
        /// </summary>
        public dvec4 zzxz => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.bbrb swizzling (equivalent to dvec3.zzxz).
        /// </summary>
        public dvec4 bbrb => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.zzxzx swizzling.
        /// </summary>
        public dvec5 zzxzx => new dvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.bbrbr swizzling (equivalent to dvec3.zzxzx).
        /// </summary>
        public dvec5 bbrbr => new dvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.zzxzy swizzling.
        /// </summary>
        public dvec5 zzxzy => new dvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.bbrbg swizzling (equivalent to dvec3.zzxzy).
        /// </summary>
        public dvec5 bbrbg => new dvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.zzxzz swizzling.
        /// </summary>
        public dvec5 zzxzz => new dvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.bbrbb swizzling (equivalent to dvec3.zzxzz).
        /// </summary>
        public dvec5 bbrbb => new dvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.zzy swizzling.
        /// </summary>
        public dvec3 zzy => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec3.bbg swizzling (equivalent to dvec3.zzy).
        /// </summary>
        public dvec3 bbg => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec3.zzyx swizzling.
        /// </summary>
        public dvec4 zzyx => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.bbgr swizzling (equivalent to dvec3.zzyx).
        /// </summary>
        public dvec4 bbgr => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.zzyxx swizzling.
        /// </summary>
        public dvec5 zzyxx => new dvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.bbgrr swizzling (equivalent to dvec3.zzyxx).
        /// </summary>
        public dvec5 bbgrr => new dvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.zzyxy swizzling.
        /// </summary>
        public dvec5 zzyxy => new dvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.bbgrg swizzling (equivalent to dvec3.zzyxy).
        /// </summary>
        public dvec5 bbgrg => new dvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.zzyxz swizzling.
        /// </summary>
        public dvec5 zzyxz => new dvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.bbgrb swizzling (equivalent to dvec3.zzyxz).
        /// </summary>
        public dvec5 bbgrb => new dvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.zzyy swizzling.
        /// </summary>
        public dvec4 zzyy => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.bbgg swizzling (equivalent to dvec3.zzyy).
        /// </summary>
        public dvec4 bbgg => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.zzyyx swizzling.
        /// </summary>
        public dvec5 zzyyx => new dvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.bbggr swizzling (equivalent to dvec3.zzyyx).
        /// </summary>
        public dvec5 bbggr => new dvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.zzyyy swizzling.
        /// </summary>
        public dvec5 zzyyy => new dvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.bbggg swizzling (equivalent to dvec3.zzyyy).
        /// </summary>
        public dvec5 bbggg => new dvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.zzyyz swizzling.
        /// </summary>
        public dvec5 zzyyz => new dvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.bbggb swizzling (equivalent to dvec3.zzyyz).
        /// </summary>
        public dvec5 bbggb => new dvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.zzyz swizzling.
        /// </summary>
        public dvec4 zzyz => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.bbgb swizzling (equivalent to dvec3.zzyz).
        /// </summary>
        public dvec4 bbgb => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.zzyzx swizzling.
        /// </summary>
        public dvec5 zzyzx => new dvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.bbgbr swizzling (equivalent to dvec3.zzyzx).
        /// </summary>
        public dvec5 bbgbr => new dvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.zzyzy swizzling.
        /// </summary>
        public dvec5 zzyzy => new dvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.bbgbg swizzling (equivalent to dvec3.zzyzy).
        /// </summary>
        public dvec5 bbgbg => new dvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.zzyzz swizzling.
        /// </summary>
        public dvec5 zzyzz => new dvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.bbgbb swizzling (equivalent to dvec3.zzyzz).
        /// </summary>
        public dvec5 bbgbb => new dvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.zzz swizzling.
        /// </summary>
        public dvec3 zzz => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec3.bbb swizzling (equivalent to dvec3.zzz).
        /// </summary>
        public dvec3 bbb => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec3.zzzx swizzling.
        /// </summary>
        public dvec4 zzzx => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.bbbr swizzling (equivalent to dvec3.zzzx).
        /// </summary>
        public dvec4 bbbr => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.zzzxx swizzling.
        /// </summary>
        public dvec5 zzzxx => new dvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.bbbrr swizzling (equivalent to dvec3.zzzxx).
        /// </summary>
        public dvec5 bbbrr => new dvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.zzzxy swizzling.
        /// </summary>
        public dvec5 zzzxy => new dvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.bbbrg swizzling (equivalent to dvec3.zzzxy).
        /// </summary>
        public dvec5 bbbrg => new dvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.zzzxz swizzling.
        /// </summary>
        public dvec5 zzzxz => new dvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.bbbrb swizzling (equivalent to dvec3.zzzxz).
        /// </summary>
        public dvec5 bbbrb => new dvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.zzzy swizzling.
        /// </summary>
        public dvec4 zzzy => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.bbbg swizzling (equivalent to dvec3.zzzy).
        /// </summary>
        public dvec4 bbbg => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.zzzyx swizzling.
        /// </summary>
        public dvec5 zzzyx => new dvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.bbbgr swizzling (equivalent to dvec3.zzzyx).
        /// </summary>
        public dvec5 bbbgr => new dvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.zzzyy swizzling.
        /// </summary>
        public dvec5 zzzyy => new dvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.bbbgg swizzling (equivalent to dvec3.zzzyy).
        /// </summary>
        public dvec5 bbbgg => new dvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.zzzyz swizzling.
        /// </summary>
        public dvec5 zzzyz => new dvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.bbbgb swizzling (equivalent to dvec3.zzzyz).
        /// </summary>
        public dvec5 bbbgb => new dvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.zzzz swizzling.
        /// </summary>
        public dvec4 zzzz => new dvec4(z, z, z, z);
        
        /// <summary>
        /// Returns dvec3.bbbb swizzling (equivalent to dvec3.zzzz).
        /// </summary>
        public dvec4 bbbb => new dvec4(z, z, z, z);
        
        /// <summary>
        /// Returns dvec3.zzzzx swizzling.
        /// </summary>
        public dvec5 zzzzx => new dvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.bbbbr swizzling (equivalent to dvec3.zzzzx).
        /// </summary>
        public dvec5 bbbbr => new dvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.zzzzy swizzling.
        /// </summary>
        public dvec5 zzzzy => new dvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.bbbbg swizzling (equivalent to dvec3.zzzzy).
        /// </summary>
        public dvec5 bbbbg => new dvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.zzzzz swizzling.
        /// </summary>
        public dvec5 zzzzz => new dvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns dvec3.bbbbb swizzling (equivalent to dvec3.zzzzz).
        /// </summary>
        public dvec5 bbbbb => new dvec5(z, z, z, z, z);

        #endregion

    }
}
