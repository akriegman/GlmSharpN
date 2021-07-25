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
    /// Temporary vector of type uint with 3 components, used for implementing swizzling for uvec3.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_uvec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly uint y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly uint z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_uvec3.
        /// </summary>
        internal swizzle_uvec3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns uvec3.xx swizzling.
        /// </summary>
        public uvec2 xx => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec3.rr swizzling (equivalent to uvec3.xx).
        /// </summary>
        public uvec2 rr => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec3.xxx swizzling.
        /// </summary>
        public uvec3 xxx => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec3.rrr swizzling (equivalent to uvec3.xxx).
        /// </summary>
        public uvec3 rrr => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec3.xxxx swizzling.
        /// </summary>
        public uvec4 xxxx => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.rrrr swizzling (equivalent to uvec3.xxxx).
        /// </summary>
        public uvec4 rrrr => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.xxxxx swizzling.
        /// </summary>
        public uvec5 xxxxx => new uvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.rrrrr swizzling (equivalent to uvec3.xxxxx).
        /// </summary>
        public uvec5 rrrrr => new uvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.xxxxy swizzling.
        /// </summary>
        public uvec5 xxxxy => new uvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.rrrrg swizzling (equivalent to uvec3.xxxxy).
        /// </summary>
        public uvec5 rrrrg => new uvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.xxxxz swizzling.
        /// </summary>
        public uvec5 xxxxz => new uvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.rrrrb swizzling (equivalent to uvec3.xxxxz).
        /// </summary>
        public uvec5 rrrrb => new uvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.xxxy swizzling.
        /// </summary>
        public uvec4 xxxy => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.rrrg swizzling (equivalent to uvec3.xxxy).
        /// </summary>
        public uvec4 rrrg => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.xxxyx swizzling.
        /// </summary>
        public uvec5 xxxyx => new uvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.rrrgr swizzling (equivalent to uvec3.xxxyx).
        /// </summary>
        public uvec5 rrrgr => new uvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.xxxyy swizzling.
        /// </summary>
        public uvec5 xxxyy => new uvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.rrrgg swizzling (equivalent to uvec3.xxxyy).
        /// </summary>
        public uvec5 rrrgg => new uvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.xxxyz swizzling.
        /// </summary>
        public uvec5 xxxyz => new uvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.rrrgb swizzling (equivalent to uvec3.xxxyz).
        /// </summary>
        public uvec5 rrrgb => new uvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.xxxz swizzling.
        /// </summary>
        public uvec4 xxxz => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.rrrb swizzling (equivalent to uvec3.xxxz).
        /// </summary>
        public uvec4 rrrb => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.xxxzx swizzling.
        /// </summary>
        public uvec5 xxxzx => new uvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.rrrbr swizzling (equivalent to uvec3.xxxzx).
        /// </summary>
        public uvec5 rrrbr => new uvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.xxxzy swizzling.
        /// </summary>
        public uvec5 xxxzy => new uvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.rrrbg swizzling (equivalent to uvec3.xxxzy).
        /// </summary>
        public uvec5 rrrbg => new uvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.xxxzz swizzling.
        /// </summary>
        public uvec5 xxxzz => new uvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.rrrbb swizzling (equivalent to uvec3.xxxzz).
        /// </summary>
        public uvec5 rrrbb => new uvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.xxy swizzling.
        /// </summary>
        public uvec3 xxy => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec3.rrg swizzling (equivalent to uvec3.xxy).
        /// </summary>
        public uvec3 rrg => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec3.xxyx swizzling.
        /// </summary>
        public uvec4 xxyx => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.rrgr swizzling (equivalent to uvec3.xxyx).
        /// </summary>
        public uvec4 rrgr => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.xxyxx swizzling.
        /// </summary>
        public uvec5 xxyxx => new uvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.rrgrr swizzling (equivalent to uvec3.xxyxx).
        /// </summary>
        public uvec5 rrgrr => new uvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.xxyxy swizzling.
        /// </summary>
        public uvec5 xxyxy => new uvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.rrgrg swizzling (equivalent to uvec3.xxyxy).
        /// </summary>
        public uvec5 rrgrg => new uvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.xxyxz swizzling.
        /// </summary>
        public uvec5 xxyxz => new uvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.rrgrb swizzling (equivalent to uvec3.xxyxz).
        /// </summary>
        public uvec5 rrgrb => new uvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.xxyy swizzling.
        /// </summary>
        public uvec4 xxyy => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.rrgg swizzling (equivalent to uvec3.xxyy).
        /// </summary>
        public uvec4 rrgg => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.xxyyx swizzling.
        /// </summary>
        public uvec5 xxyyx => new uvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.rrggr swizzling (equivalent to uvec3.xxyyx).
        /// </summary>
        public uvec5 rrggr => new uvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.xxyyy swizzling.
        /// </summary>
        public uvec5 xxyyy => new uvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.rrggg swizzling (equivalent to uvec3.xxyyy).
        /// </summary>
        public uvec5 rrggg => new uvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.xxyyz swizzling.
        /// </summary>
        public uvec5 xxyyz => new uvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.rrggb swizzling (equivalent to uvec3.xxyyz).
        /// </summary>
        public uvec5 rrggb => new uvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.xxyz swizzling.
        /// </summary>
        public uvec4 xxyz => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.rrgb swizzling (equivalent to uvec3.xxyz).
        /// </summary>
        public uvec4 rrgb => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.xxyzx swizzling.
        /// </summary>
        public uvec5 xxyzx => new uvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.rrgbr swizzling (equivalent to uvec3.xxyzx).
        /// </summary>
        public uvec5 rrgbr => new uvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.xxyzy swizzling.
        /// </summary>
        public uvec5 xxyzy => new uvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.rrgbg swizzling (equivalent to uvec3.xxyzy).
        /// </summary>
        public uvec5 rrgbg => new uvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.xxyzz swizzling.
        /// </summary>
        public uvec5 xxyzz => new uvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.rrgbb swizzling (equivalent to uvec3.xxyzz).
        /// </summary>
        public uvec5 rrgbb => new uvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.xxz swizzling.
        /// </summary>
        public uvec3 xxz => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec3.rrb swizzling (equivalent to uvec3.xxz).
        /// </summary>
        public uvec3 rrb => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec3.xxzx swizzling.
        /// </summary>
        public uvec4 xxzx => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.rrbr swizzling (equivalent to uvec3.xxzx).
        /// </summary>
        public uvec4 rrbr => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.xxzxx swizzling.
        /// </summary>
        public uvec5 xxzxx => new uvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.rrbrr swizzling (equivalent to uvec3.xxzxx).
        /// </summary>
        public uvec5 rrbrr => new uvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.xxzxy swizzling.
        /// </summary>
        public uvec5 xxzxy => new uvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.rrbrg swizzling (equivalent to uvec3.xxzxy).
        /// </summary>
        public uvec5 rrbrg => new uvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.xxzxz swizzling.
        /// </summary>
        public uvec5 xxzxz => new uvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.rrbrb swizzling (equivalent to uvec3.xxzxz).
        /// </summary>
        public uvec5 rrbrb => new uvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.xxzy swizzling.
        /// </summary>
        public uvec4 xxzy => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.rrbg swizzling (equivalent to uvec3.xxzy).
        /// </summary>
        public uvec4 rrbg => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.xxzyx swizzling.
        /// </summary>
        public uvec5 xxzyx => new uvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.rrbgr swizzling (equivalent to uvec3.xxzyx).
        /// </summary>
        public uvec5 rrbgr => new uvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.xxzyy swizzling.
        /// </summary>
        public uvec5 xxzyy => new uvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.rrbgg swizzling (equivalent to uvec3.xxzyy).
        /// </summary>
        public uvec5 rrbgg => new uvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.xxzyz swizzling.
        /// </summary>
        public uvec5 xxzyz => new uvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.rrbgb swizzling (equivalent to uvec3.xxzyz).
        /// </summary>
        public uvec5 rrbgb => new uvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.xxzz swizzling.
        /// </summary>
        public uvec4 xxzz => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.rrbb swizzling (equivalent to uvec3.xxzz).
        /// </summary>
        public uvec4 rrbb => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.xxzzx swizzling.
        /// </summary>
        public uvec5 xxzzx => new uvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.rrbbr swizzling (equivalent to uvec3.xxzzx).
        /// </summary>
        public uvec5 rrbbr => new uvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.xxzzy swizzling.
        /// </summary>
        public uvec5 xxzzy => new uvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.rrbbg swizzling (equivalent to uvec3.xxzzy).
        /// </summary>
        public uvec5 rrbbg => new uvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.xxzzz swizzling.
        /// </summary>
        public uvec5 xxzzz => new uvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.rrbbb swizzling (equivalent to uvec3.xxzzz).
        /// </summary>
        public uvec5 rrbbb => new uvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.xy swizzling.
        /// </summary>
        public uvec2 xy => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec3.rg swizzling (equivalent to uvec3.xy).
        /// </summary>
        public uvec2 rg => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec3.xyx swizzling.
        /// </summary>
        public uvec3 xyx => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec3.rgr swizzling (equivalent to uvec3.xyx).
        /// </summary>
        public uvec3 rgr => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec3.xyxx swizzling.
        /// </summary>
        public uvec4 xyxx => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.rgrr swizzling (equivalent to uvec3.xyxx).
        /// </summary>
        public uvec4 rgrr => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.xyxxx swizzling.
        /// </summary>
        public uvec5 xyxxx => new uvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.rgrrr swizzling (equivalent to uvec3.xyxxx).
        /// </summary>
        public uvec5 rgrrr => new uvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.xyxxy swizzling.
        /// </summary>
        public uvec5 xyxxy => new uvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.rgrrg swizzling (equivalent to uvec3.xyxxy).
        /// </summary>
        public uvec5 rgrrg => new uvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.xyxxz swizzling.
        /// </summary>
        public uvec5 xyxxz => new uvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.rgrrb swizzling (equivalent to uvec3.xyxxz).
        /// </summary>
        public uvec5 rgrrb => new uvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.xyxy swizzling.
        /// </summary>
        public uvec4 xyxy => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.rgrg swizzling (equivalent to uvec3.xyxy).
        /// </summary>
        public uvec4 rgrg => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.xyxyx swizzling.
        /// </summary>
        public uvec5 xyxyx => new uvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.rgrgr swizzling (equivalent to uvec3.xyxyx).
        /// </summary>
        public uvec5 rgrgr => new uvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.xyxyy swizzling.
        /// </summary>
        public uvec5 xyxyy => new uvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.rgrgg swizzling (equivalent to uvec3.xyxyy).
        /// </summary>
        public uvec5 rgrgg => new uvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.xyxyz swizzling.
        /// </summary>
        public uvec5 xyxyz => new uvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.rgrgb swizzling (equivalent to uvec3.xyxyz).
        /// </summary>
        public uvec5 rgrgb => new uvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.xyxz swizzling.
        /// </summary>
        public uvec4 xyxz => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.rgrb swizzling (equivalent to uvec3.xyxz).
        /// </summary>
        public uvec4 rgrb => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.xyxzx swizzling.
        /// </summary>
        public uvec5 xyxzx => new uvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.rgrbr swizzling (equivalent to uvec3.xyxzx).
        /// </summary>
        public uvec5 rgrbr => new uvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.xyxzy swizzling.
        /// </summary>
        public uvec5 xyxzy => new uvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.rgrbg swizzling (equivalent to uvec3.xyxzy).
        /// </summary>
        public uvec5 rgrbg => new uvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.xyxzz swizzling.
        /// </summary>
        public uvec5 xyxzz => new uvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.rgrbb swizzling (equivalent to uvec3.xyxzz).
        /// </summary>
        public uvec5 rgrbb => new uvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.xyy swizzling.
        /// </summary>
        public uvec3 xyy => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec3.rgg swizzling (equivalent to uvec3.xyy).
        /// </summary>
        public uvec3 rgg => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec3.xyyx swizzling.
        /// </summary>
        public uvec4 xyyx => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.rggr swizzling (equivalent to uvec3.xyyx).
        /// </summary>
        public uvec4 rggr => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.xyyxx swizzling.
        /// </summary>
        public uvec5 xyyxx => new uvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.rggrr swizzling (equivalent to uvec3.xyyxx).
        /// </summary>
        public uvec5 rggrr => new uvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.xyyxy swizzling.
        /// </summary>
        public uvec5 xyyxy => new uvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.rggrg swizzling (equivalent to uvec3.xyyxy).
        /// </summary>
        public uvec5 rggrg => new uvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.xyyxz swizzling.
        /// </summary>
        public uvec5 xyyxz => new uvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.rggrb swizzling (equivalent to uvec3.xyyxz).
        /// </summary>
        public uvec5 rggrb => new uvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.xyyy swizzling.
        /// </summary>
        public uvec4 xyyy => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.rggg swizzling (equivalent to uvec3.xyyy).
        /// </summary>
        public uvec4 rggg => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.xyyyx swizzling.
        /// </summary>
        public uvec5 xyyyx => new uvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.rgggr swizzling (equivalent to uvec3.xyyyx).
        /// </summary>
        public uvec5 rgggr => new uvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.xyyyy swizzling.
        /// </summary>
        public uvec5 xyyyy => new uvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.rgggg swizzling (equivalent to uvec3.xyyyy).
        /// </summary>
        public uvec5 rgggg => new uvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.xyyyz swizzling.
        /// </summary>
        public uvec5 xyyyz => new uvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.rgggb swizzling (equivalent to uvec3.xyyyz).
        /// </summary>
        public uvec5 rgggb => new uvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.xyyz swizzling.
        /// </summary>
        public uvec4 xyyz => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.rggb swizzling (equivalent to uvec3.xyyz).
        /// </summary>
        public uvec4 rggb => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.xyyzx swizzling.
        /// </summary>
        public uvec5 xyyzx => new uvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.rggbr swizzling (equivalent to uvec3.xyyzx).
        /// </summary>
        public uvec5 rggbr => new uvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.xyyzy swizzling.
        /// </summary>
        public uvec5 xyyzy => new uvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.rggbg swizzling (equivalent to uvec3.xyyzy).
        /// </summary>
        public uvec5 rggbg => new uvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.xyyzz swizzling.
        /// </summary>
        public uvec5 xyyzz => new uvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.rggbb swizzling (equivalent to uvec3.xyyzz).
        /// </summary>
        public uvec5 rggbb => new uvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.xyz swizzling.
        /// </summary>
        public uvec3 xyz => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec3.rgb swizzling (equivalent to uvec3.xyz).
        /// </summary>
        public uvec3 rgb => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec3.xyzx swizzling.
        /// </summary>
        public uvec4 xyzx => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.rgbr swizzling (equivalent to uvec3.xyzx).
        /// </summary>
        public uvec4 rgbr => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.xyzxx swizzling.
        /// </summary>
        public uvec5 xyzxx => new uvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.rgbrr swizzling (equivalent to uvec3.xyzxx).
        /// </summary>
        public uvec5 rgbrr => new uvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.xyzxy swizzling.
        /// </summary>
        public uvec5 xyzxy => new uvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.rgbrg swizzling (equivalent to uvec3.xyzxy).
        /// </summary>
        public uvec5 rgbrg => new uvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.xyzxz swizzling.
        /// </summary>
        public uvec5 xyzxz => new uvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.rgbrb swizzling (equivalent to uvec3.xyzxz).
        /// </summary>
        public uvec5 rgbrb => new uvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.xyzy swizzling.
        /// </summary>
        public uvec4 xyzy => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.rgbg swizzling (equivalent to uvec3.xyzy).
        /// </summary>
        public uvec4 rgbg => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.xyzyx swizzling.
        /// </summary>
        public uvec5 xyzyx => new uvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.rgbgr swizzling (equivalent to uvec3.xyzyx).
        /// </summary>
        public uvec5 rgbgr => new uvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.xyzyy swizzling.
        /// </summary>
        public uvec5 xyzyy => new uvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.rgbgg swizzling (equivalent to uvec3.xyzyy).
        /// </summary>
        public uvec5 rgbgg => new uvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.xyzyz swizzling.
        /// </summary>
        public uvec5 xyzyz => new uvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.rgbgb swizzling (equivalent to uvec3.xyzyz).
        /// </summary>
        public uvec5 rgbgb => new uvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.xyzz swizzling.
        /// </summary>
        public uvec4 xyzz => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.rgbb swizzling (equivalent to uvec3.xyzz).
        /// </summary>
        public uvec4 rgbb => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.xyzzx swizzling.
        /// </summary>
        public uvec5 xyzzx => new uvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.rgbbr swizzling (equivalent to uvec3.xyzzx).
        /// </summary>
        public uvec5 rgbbr => new uvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.xyzzy swizzling.
        /// </summary>
        public uvec5 xyzzy => new uvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.rgbbg swizzling (equivalent to uvec3.xyzzy).
        /// </summary>
        public uvec5 rgbbg => new uvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.xyzzz swizzling.
        /// </summary>
        public uvec5 xyzzz => new uvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.rgbbb swizzling (equivalent to uvec3.xyzzz).
        /// </summary>
        public uvec5 rgbbb => new uvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.xz swizzling.
        /// </summary>
        public uvec2 xz => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec3.rb swizzling (equivalent to uvec3.xz).
        /// </summary>
        public uvec2 rb => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec3.xzx swizzling.
        /// </summary>
        public uvec3 xzx => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec3.rbr swizzling (equivalent to uvec3.xzx).
        /// </summary>
        public uvec3 rbr => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec3.xzxx swizzling.
        /// </summary>
        public uvec4 xzxx => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.rbrr swizzling (equivalent to uvec3.xzxx).
        /// </summary>
        public uvec4 rbrr => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.xzxxx swizzling.
        /// </summary>
        public uvec5 xzxxx => new uvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.rbrrr swizzling (equivalent to uvec3.xzxxx).
        /// </summary>
        public uvec5 rbrrr => new uvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.xzxxy swizzling.
        /// </summary>
        public uvec5 xzxxy => new uvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.rbrrg swizzling (equivalent to uvec3.xzxxy).
        /// </summary>
        public uvec5 rbrrg => new uvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.xzxxz swizzling.
        /// </summary>
        public uvec5 xzxxz => new uvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.rbrrb swizzling (equivalent to uvec3.xzxxz).
        /// </summary>
        public uvec5 rbrrb => new uvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.xzxy swizzling.
        /// </summary>
        public uvec4 xzxy => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.rbrg swizzling (equivalent to uvec3.xzxy).
        /// </summary>
        public uvec4 rbrg => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.xzxyx swizzling.
        /// </summary>
        public uvec5 xzxyx => new uvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.rbrgr swizzling (equivalent to uvec3.xzxyx).
        /// </summary>
        public uvec5 rbrgr => new uvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.xzxyy swizzling.
        /// </summary>
        public uvec5 xzxyy => new uvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.rbrgg swizzling (equivalent to uvec3.xzxyy).
        /// </summary>
        public uvec5 rbrgg => new uvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.xzxyz swizzling.
        /// </summary>
        public uvec5 xzxyz => new uvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.rbrgb swizzling (equivalent to uvec3.xzxyz).
        /// </summary>
        public uvec5 rbrgb => new uvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.xzxz swizzling.
        /// </summary>
        public uvec4 xzxz => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.rbrb swizzling (equivalent to uvec3.xzxz).
        /// </summary>
        public uvec4 rbrb => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.xzxzx swizzling.
        /// </summary>
        public uvec5 xzxzx => new uvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.rbrbr swizzling (equivalent to uvec3.xzxzx).
        /// </summary>
        public uvec5 rbrbr => new uvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.xzxzy swizzling.
        /// </summary>
        public uvec5 xzxzy => new uvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.rbrbg swizzling (equivalent to uvec3.xzxzy).
        /// </summary>
        public uvec5 rbrbg => new uvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.xzxzz swizzling.
        /// </summary>
        public uvec5 xzxzz => new uvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.rbrbb swizzling (equivalent to uvec3.xzxzz).
        /// </summary>
        public uvec5 rbrbb => new uvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.xzy swizzling.
        /// </summary>
        public uvec3 xzy => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec3.rbg swizzling (equivalent to uvec3.xzy).
        /// </summary>
        public uvec3 rbg => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec3.xzyx swizzling.
        /// </summary>
        public uvec4 xzyx => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.rbgr swizzling (equivalent to uvec3.xzyx).
        /// </summary>
        public uvec4 rbgr => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.xzyxx swizzling.
        /// </summary>
        public uvec5 xzyxx => new uvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.rbgrr swizzling (equivalent to uvec3.xzyxx).
        /// </summary>
        public uvec5 rbgrr => new uvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.xzyxy swizzling.
        /// </summary>
        public uvec5 xzyxy => new uvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.rbgrg swizzling (equivalent to uvec3.xzyxy).
        /// </summary>
        public uvec5 rbgrg => new uvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.xzyxz swizzling.
        /// </summary>
        public uvec5 xzyxz => new uvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.rbgrb swizzling (equivalent to uvec3.xzyxz).
        /// </summary>
        public uvec5 rbgrb => new uvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.xzyy swizzling.
        /// </summary>
        public uvec4 xzyy => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.rbgg swizzling (equivalent to uvec3.xzyy).
        /// </summary>
        public uvec4 rbgg => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.xzyyx swizzling.
        /// </summary>
        public uvec5 xzyyx => new uvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.rbggr swizzling (equivalent to uvec3.xzyyx).
        /// </summary>
        public uvec5 rbggr => new uvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.xzyyy swizzling.
        /// </summary>
        public uvec5 xzyyy => new uvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.rbggg swizzling (equivalent to uvec3.xzyyy).
        /// </summary>
        public uvec5 rbggg => new uvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.xzyyz swizzling.
        /// </summary>
        public uvec5 xzyyz => new uvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.rbggb swizzling (equivalent to uvec3.xzyyz).
        /// </summary>
        public uvec5 rbggb => new uvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.xzyz swizzling.
        /// </summary>
        public uvec4 xzyz => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.rbgb swizzling (equivalent to uvec3.xzyz).
        /// </summary>
        public uvec4 rbgb => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.xzyzx swizzling.
        /// </summary>
        public uvec5 xzyzx => new uvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.rbgbr swizzling (equivalent to uvec3.xzyzx).
        /// </summary>
        public uvec5 rbgbr => new uvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.xzyzy swizzling.
        /// </summary>
        public uvec5 xzyzy => new uvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.rbgbg swizzling (equivalent to uvec3.xzyzy).
        /// </summary>
        public uvec5 rbgbg => new uvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.xzyzz swizzling.
        /// </summary>
        public uvec5 xzyzz => new uvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.rbgbb swizzling (equivalent to uvec3.xzyzz).
        /// </summary>
        public uvec5 rbgbb => new uvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.xzz swizzling.
        /// </summary>
        public uvec3 xzz => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec3.rbb swizzling (equivalent to uvec3.xzz).
        /// </summary>
        public uvec3 rbb => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec3.xzzx swizzling.
        /// </summary>
        public uvec4 xzzx => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.rbbr swizzling (equivalent to uvec3.xzzx).
        /// </summary>
        public uvec4 rbbr => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.xzzxx swizzling.
        /// </summary>
        public uvec5 xzzxx => new uvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.rbbrr swizzling (equivalent to uvec3.xzzxx).
        /// </summary>
        public uvec5 rbbrr => new uvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.xzzxy swizzling.
        /// </summary>
        public uvec5 xzzxy => new uvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.rbbrg swizzling (equivalent to uvec3.xzzxy).
        /// </summary>
        public uvec5 rbbrg => new uvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.xzzxz swizzling.
        /// </summary>
        public uvec5 xzzxz => new uvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.rbbrb swizzling (equivalent to uvec3.xzzxz).
        /// </summary>
        public uvec5 rbbrb => new uvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.xzzy swizzling.
        /// </summary>
        public uvec4 xzzy => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.rbbg swizzling (equivalent to uvec3.xzzy).
        /// </summary>
        public uvec4 rbbg => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.xzzyx swizzling.
        /// </summary>
        public uvec5 xzzyx => new uvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.rbbgr swizzling (equivalent to uvec3.xzzyx).
        /// </summary>
        public uvec5 rbbgr => new uvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.xzzyy swizzling.
        /// </summary>
        public uvec5 xzzyy => new uvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.rbbgg swizzling (equivalent to uvec3.xzzyy).
        /// </summary>
        public uvec5 rbbgg => new uvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.xzzyz swizzling.
        /// </summary>
        public uvec5 xzzyz => new uvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.rbbgb swizzling (equivalent to uvec3.xzzyz).
        /// </summary>
        public uvec5 rbbgb => new uvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.xzzz swizzling.
        /// </summary>
        public uvec4 xzzz => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.rbbb swizzling (equivalent to uvec3.xzzz).
        /// </summary>
        public uvec4 rbbb => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.xzzzx swizzling.
        /// </summary>
        public uvec5 xzzzx => new uvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.rbbbr swizzling (equivalent to uvec3.xzzzx).
        /// </summary>
        public uvec5 rbbbr => new uvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.xzzzy swizzling.
        /// </summary>
        public uvec5 xzzzy => new uvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.rbbbg swizzling (equivalent to uvec3.xzzzy).
        /// </summary>
        public uvec5 rbbbg => new uvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.xzzzz swizzling.
        /// </summary>
        public uvec5 xzzzz => new uvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns uvec3.rbbbb swizzling (equivalent to uvec3.xzzzz).
        /// </summary>
        public uvec5 rbbbb => new uvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns uvec3.yx swizzling.
        /// </summary>
        public uvec2 yx => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec3.gr swizzling (equivalent to uvec3.yx).
        /// </summary>
        public uvec2 gr => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec3.yxx swizzling.
        /// </summary>
        public uvec3 yxx => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec3.grr swizzling (equivalent to uvec3.yxx).
        /// </summary>
        public uvec3 grr => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec3.yxxx swizzling.
        /// </summary>
        public uvec4 yxxx => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.grrr swizzling (equivalent to uvec3.yxxx).
        /// </summary>
        public uvec4 grrr => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.yxxxx swizzling.
        /// </summary>
        public uvec5 yxxxx => new uvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.grrrr swizzling (equivalent to uvec3.yxxxx).
        /// </summary>
        public uvec5 grrrr => new uvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.yxxxy swizzling.
        /// </summary>
        public uvec5 yxxxy => new uvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.grrrg swizzling (equivalent to uvec3.yxxxy).
        /// </summary>
        public uvec5 grrrg => new uvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.yxxxz swizzling.
        /// </summary>
        public uvec5 yxxxz => new uvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.grrrb swizzling (equivalent to uvec3.yxxxz).
        /// </summary>
        public uvec5 grrrb => new uvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.yxxy swizzling.
        /// </summary>
        public uvec4 yxxy => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.grrg swizzling (equivalent to uvec3.yxxy).
        /// </summary>
        public uvec4 grrg => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.yxxyx swizzling.
        /// </summary>
        public uvec5 yxxyx => new uvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.grrgr swizzling (equivalent to uvec3.yxxyx).
        /// </summary>
        public uvec5 grrgr => new uvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.yxxyy swizzling.
        /// </summary>
        public uvec5 yxxyy => new uvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.grrgg swizzling (equivalent to uvec3.yxxyy).
        /// </summary>
        public uvec5 grrgg => new uvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.yxxyz swizzling.
        /// </summary>
        public uvec5 yxxyz => new uvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.grrgb swizzling (equivalent to uvec3.yxxyz).
        /// </summary>
        public uvec5 grrgb => new uvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.yxxz swizzling.
        /// </summary>
        public uvec4 yxxz => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.grrb swizzling (equivalent to uvec3.yxxz).
        /// </summary>
        public uvec4 grrb => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.yxxzx swizzling.
        /// </summary>
        public uvec5 yxxzx => new uvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.grrbr swizzling (equivalent to uvec3.yxxzx).
        /// </summary>
        public uvec5 grrbr => new uvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.yxxzy swizzling.
        /// </summary>
        public uvec5 yxxzy => new uvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.grrbg swizzling (equivalent to uvec3.yxxzy).
        /// </summary>
        public uvec5 grrbg => new uvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.yxxzz swizzling.
        /// </summary>
        public uvec5 yxxzz => new uvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.grrbb swizzling (equivalent to uvec3.yxxzz).
        /// </summary>
        public uvec5 grrbb => new uvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.yxy swizzling.
        /// </summary>
        public uvec3 yxy => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec3.grg swizzling (equivalent to uvec3.yxy).
        /// </summary>
        public uvec3 grg => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec3.yxyx swizzling.
        /// </summary>
        public uvec4 yxyx => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.grgr swizzling (equivalent to uvec3.yxyx).
        /// </summary>
        public uvec4 grgr => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.yxyxx swizzling.
        /// </summary>
        public uvec5 yxyxx => new uvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.grgrr swizzling (equivalent to uvec3.yxyxx).
        /// </summary>
        public uvec5 grgrr => new uvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.yxyxy swizzling.
        /// </summary>
        public uvec5 yxyxy => new uvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.grgrg swizzling (equivalent to uvec3.yxyxy).
        /// </summary>
        public uvec5 grgrg => new uvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.yxyxz swizzling.
        /// </summary>
        public uvec5 yxyxz => new uvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.grgrb swizzling (equivalent to uvec3.yxyxz).
        /// </summary>
        public uvec5 grgrb => new uvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.yxyy swizzling.
        /// </summary>
        public uvec4 yxyy => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.grgg swizzling (equivalent to uvec3.yxyy).
        /// </summary>
        public uvec4 grgg => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.yxyyx swizzling.
        /// </summary>
        public uvec5 yxyyx => new uvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.grggr swizzling (equivalent to uvec3.yxyyx).
        /// </summary>
        public uvec5 grggr => new uvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.yxyyy swizzling.
        /// </summary>
        public uvec5 yxyyy => new uvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.grggg swizzling (equivalent to uvec3.yxyyy).
        /// </summary>
        public uvec5 grggg => new uvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.yxyyz swizzling.
        /// </summary>
        public uvec5 yxyyz => new uvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.grggb swizzling (equivalent to uvec3.yxyyz).
        /// </summary>
        public uvec5 grggb => new uvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.yxyz swizzling.
        /// </summary>
        public uvec4 yxyz => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.grgb swizzling (equivalent to uvec3.yxyz).
        /// </summary>
        public uvec4 grgb => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.yxyzx swizzling.
        /// </summary>
        public uvec5 yxyzx => new uvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.grgbr swizzling (equivalent to uvec3.yxyzx).
        /// </summary>
        public uvec5 grgbr => new uvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.yxyzy swizzling.
        /// </summary>
        public uvec5 yxyzy => new uvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.grgbg swizzling (equivalent to uvec3.yxyzy).
        /// </summary>
        public uvec5 grgbg => new uvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.yxyzz swizzling.
        /// </summary>
        public uvec5 yxyzz => new uvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.grgbb swizzling (equivalent to uvec3.yxyzz).
        /// </summary>
        public uvec5 grgbb => new uvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.yxz swizzling.
        /// </summary>
        public uvec3 yxz => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec3.grb swizzling (equivalent to uvec3.yxz).
        /// </summary>
        public uvec3 grb => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec3.yxzx swizzling.
        /// </summary>
        public uvec4 yxzx => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.grbr swizzling (equivalent to uvec3.yxzx).
        /// </summary>
        public uvec4 grbr => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.yxzxx swizzling.
        /// </summary>
        public uvec5 yxzxx => new uvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.grbrr swizzling (equivalent to uvec3.yxzxx).
        /// </summary>
        public uvec5 grbrr => new uvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.yxzxy swizzling.
        /// </summary>
        public uvec5 yxzxy => new uvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.grbrg swizzling (equivalent to uvec3.yxzxy).
        /// </summary>
        public uvec5 grbrg => new uvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.yxzxz swizzling.
        /// </summary>
        public uvec5 yxzxz => new uvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.grbrb swizzling (equivalent to uvec3.yxzxz).
        /// </summary>
        public uvec5 grbrb => new uvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.yxzy swizzling.
        /// </summary>
        public uvec4 yxzy => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.grbg swizzling (equivalent to uvec3.yxzy).
        /// </summary>
        public uvec4 grbg => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.yxzyx swizzling.
        /// </summary>
        public uvec5 yxzyx => new uvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.grbgr swizzling (equivalent to uvec3.yxzyx).
        /// </summary>
        public uvec5 grbgr => new uvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.yxzyy swizzling.
        /// </summary>
        public uvec5 yxzyy => new uvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.grbgg swizzling (equivalent to uvec3.yxzyy).
        /// </summary>
        public uvec5 grbgg => new uvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.yxzyz swizzling.
        /// </summary>
        public uvec5 yxzyz => new uvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.grbgb swizzling (equivalent to uvec3.yxzyz).
        /// </summary>
        public uvec5 grbgb => new uvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.yxzz swizzling.
        /// </summary>
        public uvec4 yxzz => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.grbb swizzling (equivalent to uvec3.yxzz).
        /// </summary>
        public uvec4 grbb => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.yxzzx swizzling.
        /// </summary>
        public uvec5 yxzzx => new uvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.grbbr swizzling (equivalent to uvec3.yxzzx).
        /// </summary>
        public uvec5 grbbr => new uvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.yxzzy swizzling.
        /// </summary>
        public uvec5 yxzzy => new uvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.grbbg swizzling (equivalent to uvec3.yxzzy).
        /// </summary>
        public uvec5 grbbg => new uvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.yxzzz swizzling.
        /// </summary>
        public uvec5 yxzzz => new uvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.grbbb swizzling (equivalent to uvec3.yxzzz).
        /// </summary>
        public uvec5 grbbb => new uvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.yy swizzling.
        /// </summary>
        public uvec2 yy => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec3.gg swizzling (equivalent to uvec3.yy).
        /// </summary>
        public uvec2 gg => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec3.yyx swizzling.
        /// </summary>
        public uvec3 yyx => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec3.ggr swizzling (equivalent to uvec3.yyx).
        /// </summary>
        public uvec3 ggr => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec3.yyxx swizzling.
        /// </summary>
        public uvec4 yyxx => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.ggrr swizzling (equivalent to uvec3.yyxx).
        /// </summary>
        public uvec4 ggrr => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.yyxxx swizzling.
        /// </summary>
        public uvec5 yyxxx => new uvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.ggrrr swizzling (equivalent to uvec3.yyxxx).
        /// </summary>
        public uvec5 ggrrr => new uvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.yyxxy swizzling.
        /// </summary>
        public uvec5 yyxxy => new uvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.ggrrg swizzling (equivalent to uvec3.yyxxy).
        /// </summary>
        public uvec5 ggrrg => new uvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.yyxxz swizzling.
        /// </summary>
        public uvec5 yyxxz => new uvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.ggrrb swizzling (equivalent to uvec3.yyxxz).
        /// </summary>
        public uvec5 ggrrb => new uvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.yyxy swizzling.
        /// </summary>
        public uvec4 yyxy => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.ggrg swizzling (equivalent to uvec3.yyxy).
        /// </summary>
        public uvec4 ggrg => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.yyxyx swizzling.
        /// </summary>
        public uvec5 yyxyx => new uvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.ggrgr swizzling (equivalent to uvec3.yyxyx).
        /// </summary>
        public uvec5 ggrgr => new uvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.yyxyy swizzling.
        /// </summary>
        public uvec5 yyxyy => new uvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.ggrgg swizzling (equivalent to uvec3.yyxyy).
        /// </summary>
        public uvec5 ggrgg => new uvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.yyxyz swizzling.
        /// </summary>
        public uvec5 yyxyz => new uvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.ggrgb swizzling (equivalent to uvec3.yyxyz).
        /// </summary>
        public uvec5 ggrgb => new uvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.yyxz swizzling.
        /// </summary>
        public uvec4 yyxz => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.ggrb swizzling (equivalent to uvec3.yyxz).
        /// </summary>
        public uvec4 ggrb => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.yyxzx swizzling.
        /// </summary>
        public uvec5 yyxzx => new uvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.ggrbr swizzling (equivalent to uvec3.yyxzx).
        /// </summary>
        public uvec5 ggrbr => new uvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.yyxzy swizzling.
        /// </summary>
        public uvec5 yyxzy => new uvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.ggrbg swizzling (equivalent to uvec3.yyxzy).
        /// </summary>
        public uvec5 ggrbg => new uvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.yyxzz swizzling.
        /// </summary>
        public uvec5 yyxzz => new uvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.ggrbb swizzling (equivalent to uvec3.yyxzz).
        /// </summary>
        public uvec5 ggrbb => new uvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.yyy swizzling.
        /// </summary>
        public uvec3 yyy => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec3.ggg swizzling (equivalent to uvec3.yyy).
        /// </summary>
        public uvec3 ggg => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec3.yyyx swizzling.
        /// </summary>
        public uvec4 yyyx => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.gggr swizzling (equivalent to uvec3.yyyx).
        /// </summary>
        public uvec4 gggr => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.yyyxx swizzling.
        /// </summary>
        public uvec5 yyyxx => new uvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.gggrr swizzling (equivalent to uvec3.yyyxx).
        /// </summary>
        public uvec5 gggrr => new uvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.yyyxy swizzling.
        /// </summary>
        public uvec5 yyyxy => new uvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.gggrg swizzling (equivalent to uvec3.yyyxy).
        /// </summary>
        public uvec5 gggrg => new uvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.yyyxz swizzling.
        /// </summary>
        public uvec5 yyyxz => new uvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.gggrb swizzling (equivalent to uvec3.yyyxz).
        /// </summary>
        public uvec5 gggrb => new uvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.yyyy swizzling.
        /// </summary>
        public uvec4 yyyy => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.gggg swizzling (equivalent to uvec3.yyyy).
        /// </summary>
        public uvec4 gggg => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.yyyyx swizzling.
        /// </summary>
        public uvec5 yyyyx => new uvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.ggggr swizzling (equivalent to uvec3.yyyyx).
        /// </summary>
        public uvec5 ggggr => new uvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.yyyyy swizzling.
        /// </summary>
        public uvec5 yyyyy => new uvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.ggggg swizzling (equivalent to uvec3.yyyyy).
        /// </summary>
        public uvec5 ggggg => new uvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.yyyyz swizzling.
        /// </summary>
        public uvec5 yyyyz => new uvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.ggggb swizzling (equivalent to uvec3.yyyyz).
        /// </summary>
        public uvec5 ggggb => new uvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.yyyz swizzling.
        /// </summary>
        public uvec4 yyyz => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.gggb swizzling (equivalent to uvec3.yyyz).
        /// </summary>
        public uvec4 gggb => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.yyyzx swizzling.
        /// </summary>
        public uvec5 yyyzx => new uvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.gggbr swizzling (equivalent to uvec3.yyyzx).
        /// </summary>
        public uvec5 gggbr => new uvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.yyyzy swizzling.
        /// </summary>
        public uvec5 yyyzy => new uvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.gggbg swizzling (equivalent to uvec3.yyyzy).
        /// </summary>
        public uvec5 gggbg => new uvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.yyyzz swizzling.
        /// </summary>
        public uvec5 yyyzz => new uvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.gggbb swizzling (equivalent to uvec3.yyyzz).
        /// </summary>
        public uvec5 gggbb => new uvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.yyz swizzling.
        /// </summary>
        public uvec3 yyz => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec3.ggb swizzling (equivalent to uvec3.yyz).
        /// </summary>
        public uvec3 ggb => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec3.yyzx swizzling.
        /// </summary>
        public uvec4 yyzx => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.ggbr swizzling (equivalent to uvec3.yyzx).
        /// </summary>
        public uvec4 ggbr => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.yyzxx swizzling.
        /// </summary>
        public uvec5 yyzxx => new uvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.ggbrr swizzling (equivalent to uvec3.yyzxx).
        /// </summary>
        public uvec5 ggbrr => new uvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.yyzxy swizzling.
        /// </summary>
        public uvec5 yyzxy => new uvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.ggbrg swizzling (equivalent to uvec3.yyzxy).
        /// </summary>
        public uvec5 ggbrg => new uvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.yyzxz swizzling.
        /// </summary>
        public uvec5 yyzxz => new uvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.ggbrb swizzling (equivalent to uvec3.yyzxz).
        /// </summary>
        public uvec5 ggbrb => new uvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.yyzy swizzling.
        /// </summary>
        public uvec4 yyzy => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.ggbg swizzling (equivalent to uvec3.yyzy).
        /// </summary>
        public uvec4 ggbg => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.yyzyx swizzling.
        /// </summary>
        public uvec5 yyzyx => new uvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.ggbgr swizzling (equivalent to uvec3.yyzyx).
        /// </summary>
        public uvec5 ggbgr => new uvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.yyzyy swizzling.
        /// </summary>
        public uvec5 yyzyy => new uvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.ggbgg swizzling (equivalent to uvec3.yyzyy).
        /// </summary>
        public uvec5 ggbgg => new uvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.yyzyz swizzling.
        /// </summary>
        public uvec5 yyzyz => new uvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.ggbgb swizzling (equivalent to uvec3.yyzyz).
        /// </summary>
        public uvec5 ggbgb => new uvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.yyzz swizzling.
        /// </summary>
        public uvec4 yyzz => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.ggbb swizzling (equivalent to uvec3.yyzz).
        /// </summary>
        public uvec4 ggbb => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.yyzzx swizzling.
        /// </summary>
        public uvec5 yyzzx => new uvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.ggbbr swizzling (equivalent to uvec3.yyzzx).
        /// </summary>
        public uvec5 ggbbr => new uvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.yyzzy swizzling.
        /// </summary>
        public uvec5 yyzzy => new uvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.ggbbg swizzling (equivalent to uvec3.yyzzy).
        /// </summary>
        public uvec5 ggbbg => new uvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.yyzzz swizzling.
        /// </summary>
        public uvec5 yyzzz => new uvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.ggbbb swizzling (equivalent to uvec3.yyzzz).
        /// </summary>
        public uvec5 ggbbb => new uvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.yz swizzling.
        /// </summary>
        public uvec2 yz => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec3.gb swizzling (equivalent to uvec3.yz).
        /// </summary>
        public uvec2 gb => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec3.yzx swizzling.
        /// </summary>
        public uvec3 yzx => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec3.gbr swizzling (equivalent to uvec3.yzx).
        /// </summary>
        public uvec3 gbr => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec3.yzxx swizzling.
        /// </summary>
        public uvec4 yzxx => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.gbrr swizzling (equivalent to uvec3.yzxx).
        /// </summary>
        public uvec4 gbrr => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.yzxxx swizzling.
        /// </summary>
        public uvec5 yzxxx => new uvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.gbrrr swizzling (equivalent to uvec3.yzxxx).
        /// </summary>
        public uvec5 gbrrr => new uvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.yzxxy swizzling.
        /// </summary>
        public uvec5 yzxxy => new uvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.gbrrg swizzling (equivalent to uvec3.yzxxy).
        /// </summary>
        public uvec5 gbrrg => new uvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.yzxxz swizzling.
        /// </summary>
        public uvec5 yzxxz => new uvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.gbrrb swizzling (equivalent to uvec3.yzxxz).
        /// </summary>
        public uvec5 gbrrb => new uvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.yzxy swizzling.
        /// </summary>
        public uvec4 yzxy => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.gbrg swizzling (equivalent to uvec3.yzxy).
        /// </summary>
        public uvec4 gbrg => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.yzxyx swizzling.
        /// </summary>
        public uvec5 yzxyx => new uvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.gbrgr swizzling (equivalent to uvec3.yzxyx).
        /// </summary>
        public uvec5 gbrgr => new uvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.yzxyy swizzling.
        /// </summary>
        public uvec5 yzxyy => new uvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.gbrgg swizzling (equivalent to uvec3.yzxyy).
        /// </summary>
        public uvec5 gbrgg => new uvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.yzxyz swizzling.
        /// </summary>
        public uvec5 yzxyz => new uvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.gbrgb swizzling (equivalent to uvec3.yzxyz).
        /// </summary>
        public uvec5 gbrgb => new uvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.yzxz swizzling.
        /// </summary>
        public uvec4 yzxz => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.gbrb swizzling (equivalent to uvec3.yzxz).
        /// </summary>
        public uvec4 gbrb => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.yzxzx swizzling.
        /// </summary>
        public uvec5 yzxzx => new uvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.gbrbr swizzling (equivalent to uvec3.yzxzx).
        /// </summary>
        public uvec5 gbrbr => new uvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.yzxzy swizzling.
        /// </summary>
        public uvec5 yzxzy => new uvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.gbrbg swizzling (equivalent to uvec3.yzxzy).
        /// </summary>
        public uvec5 gbrbg => new uvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.yzxzz swizzling.
        /// </summary>
        public uvec5 yzxzz => new uvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.gbrbb swizzling (equivalent to uvec3.yzxzz).
        /// </summary>
        public uvec5 gbrbb => new uvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.yzy swizzling.
        /// </summary>
        public uvec3 yzy => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec3.gbg swizzling (equivalent to uvec3.yzy).
        /// </summary>
        public uvec3 gbg => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec3.yzyx swizzling.
        /// </summary>
        public uvec4 yzyx => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.gbgr swizzling (equivalent to uvec3.yzyx).
        /// </summary>
        public uvec4 gbgr => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.yzyxx swizzling.
        /// </summary>
        public uvec5 yzyxx => new uvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.gbgrr swizzling (equivalent to uvec3.yzyxx).
        /// </summary>
        public uvec5 gbgrr => new uvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.yzyxy swizzling.
        /// </summary>
        public uvec5 yzyxy => new uvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.gbgrg swizzling (equivalent to uvec3.yzyxy).
        /// </summary>
        public uvec5 gbgrg => new uvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.yzyxz swizzling.
        /// </summary>
        public uvec5 yzyxz => new uvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.gbgrb swizzling (equivalent to uvec3.yzyxz).
        /// </summary>
        public uvec5 gbgrb => new uvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.yzyy swizzling.
        /// </summary>
        public uvec4 yzyy => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.gbgg swizzling (equivalent to uvec3.yzyy).
        /// </summary>
        public uvec4 gbgg => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.yzyyx swizzling.
        /// </summary>
        public uvec5 yzyyx => new uvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.gbggr swizzling (equivalent to uvec3.yzyyx).
        /// </summary>
        public uvec5 gbggr => new uvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.yzyyy swizzling.
        /// </summary>
        public uvec5 yzyyy => new uvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.gbggg swizzling (equivalent to uvec3.yzyyy).
        /// </summary>
        public uvec5 gbggg => new uvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.yzyyz swizzling.
        /// </summary>
        public uvec5 yzyyz => new uvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.gbggb swizzling (equivalent to uvec3.yzyyz).
        /// </summary>
        public uvec5 gbggb => new uvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.yzyz swizzling.
        /// </summary>
        public uvec4 yzyz => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.gbgb swizzling (equivalent to uvec3.yzyz).
        /// </summary>
        public uvec4 gbgb => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.yzyzx swizzling.
        /// </summary>
        public uvec5 yzyzx => new uvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.gbgbr swizzling (equivalent to uvec3.yzyzx).
        /// </summary>
        public uvec5 gbgbr => new uvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.yzyzy swizzling.
        /// </summary>
        public uvec5 yzyzy => new uvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.gbgbg swizzling (equivalent to uvec3.yzyzy).
        /// </summary>
        public uvec5 gbgbg => new uvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.yzyzz swizzling.
        /// </summary>
        public uvec5 yzyzz => new uvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.gbgbb swizzling (equivalent to uvec3.yzyzz).
        /// </summary>
        public uvec5 gbgbb => new uvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.yzz swizzling.
        /// </summary>
        public uvec3 yzz => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec3.gbb swizzling (equivalent to uvec3.yzz).
        /// </summary>
        public uvec3 gbb => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec3.yzzx swizzling.
        /// </summary>
        public uvec4 yzzx => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.gbbr swizzling (equivalent to uvec3.yzzx).
        /// </summary>
        public uvec4 gbbr => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.yzzxx swizzling.
        /// </summary>
        public uvec5 yzzxx => new uvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.gbbrr swizzling (equivalent to uvec3.yzzxx).
        /// </summary>
        public uvec5 gbbrr => new uvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.yzzxy swizzling.
        /// </summary>
        public uvec5 yzzxy => new uvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.gbbrg swizzling (equivalent to uvec3.yzzxy).
        /// </summary>
        public uvec5 gbbrg => new uvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.yzzxz swizzling.
        /// </summary>
        public uvec5 yzzxz => new uvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.gbbrb swizzling (equivalent to uvec3.yzzxz).
        /// </summary>
        public uvec5 gbbrb => new uvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.yzzy swizzling.
        /// </summary>
        public uvec4 yzzy => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.gbbg swizzling (equivalent to uvec3.yzzy).
        /// </summary>
        public uvec4 gbbg => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.yzzyx swizzling.
        /// </summary>
        public uvec5 yzzyx => new uvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.gbbgr swizzling (equivalent to uvec3.yzzyx).
        /// </summary>
        public uvec5 gbbgr => new uvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.yzzyy swizzling.
        /// </summary>
        public uvec5 yzzyy => new uvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.gbbgg swizzling (equivalent to uvec3.yzzyy).
        /// </summary>
        public uvec5 gbbgg => new uvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.yzzyz swizzling.
        /// </summary>
        public uvec5 yzzyz => new uvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.gbbgb swizzling (equivalent to uvec3.yzzyz).
        /// </summary>
        public uvec5 gbbgb => new uvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.yzzz swizzling.
        /// </summary>
        public uvec4 yzzz => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.gbbb swizzling (equivalent to uvec3.yzzz).
        /// </summary>
        public uvec4 gbbb => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.yzzzx swizzling.
        /// </summary>
        public uvec5 yzzzx => new uvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.gbbbr swizzling (equivalent to uvec3.yzzzx).
        /// </summary>
        public uvec5 gbbbr => new uvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.yzzzy swizzling.
        /// </summary>
        public uvec5 yzzzy => new uvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.gbbbg swizzling (equivalent to uvec3.yzzzy).
        /// </summary>
        public uvec5 gbbbg => new uvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.yzzzz swizzling.
        /// </summary>
        public uvec5 yzzzz => new uvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns uvec3.gbbbb swizzling (equivalent to uvec3.yzzzz).
        /// </summary>
        public uvec5 gbbbb => new uvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns uvec3.zx swizzling.
        /// </summary>
        public uvec2 zx => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec3.br swizzling (equivalent to uvec3.zx).
        /// </summary>
        public uvec2 br => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec3.zxx swizzling.
        /// </summary>
        public uvec3 zxx => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec3.brr swizzling (equivalent to uvec3.zxx).
        /// </summary>
        public uvec3 brr => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec3.zxxx swizzling.
        /// </summary>
        public uvec4 zxxx => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.brrr swizzling (equivalent to uvec3.zxxx).
        /// </summary>
        public uvec4 brrr => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.zxxxx swizzling.
        /// </summary>
        public uvec5 zxxxx => new uvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.brrrr swizzling (equivalent to uvec3.zxxxx).
        /// </summary>
        public uvec5 brrrr => new uvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.zxxxy swizzling.
        /// </summary>
        public uvec5 zxxxy => new uvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.brrrg swizzling (equivalent to uvec3.zxxxy).
        /// </summary>
        public uvec5 brrrg => new uvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.zxxxz swizzling.
        /// </summary>
        public uvec5 zxxxz => new uvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.brrrb swizzling (equivalent to uvec3.zxxxz).
        /// </summary>
        public uvec5 brrrb => new uvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.zxxy swizzling.
        /// </summary>
        public uvec4 zxxy => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.brrg swizzling (equivalent to uvec3.zxxy).
        /// </summary>
        public uvec4 brrg => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.zxxyx swizzling.
        /// </summary>
        public uvec5 zxxyx => new uvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.brrgr swizzling (equivalent to uvec3.zxxyx).
        /// </summary>
        public uvec5 brrgr => new uvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.zxxyy swizzling.
        /// </summary>
        public uvec5 zxxyy => new uvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.brrgg swizzling (equivalent to uvec3.zxxyy).
        /// </summary>
        public uvec5 brrgg => new uvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.zxxyz swizzling.
        /// </summary>
        public uvec5 zxxyz => new uvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.brrgb swizzling (equivalent to uvec3.zxxyz).
        /// </summary>
        public uvec5 brrgb => new uvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.zxxz swizzling.
        /// </summary>
        public uvec4 zxxz => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.brrb swizzling (equivalent to uvec3.zxxz).
        /// </summary>
        public uvec4 brrb => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.zxxzx swizzling.
        /// </summary>
        public uvec5 zxxzx => new uvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.brrbr swizzling (equivalent to uvec3.zxxzx).
        /// </summary>
        public uvec5 brrbr => new uvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.zxxzy swizzling.
        /// </summary>
        public uvec5 zxxzy => new uvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.brrbg swizzling (equivalent to uvec3.zxxzy).
        /// </summary>
        public uvec5 brrbg => new uvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.zxxzz swizzling.
        /// </summary>
        public uvec5 zxxzz => new uvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.brrbb swizzling (equivalent to uvec3.zxxzz).
        /// </summary>
        public uvec5 brrbb => new uvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.zxy swizzling.
        /// </summary>
        public uvec3 zxy => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec3.brg swizzling (equivalent to uvec3.zxy).
        /// </summary>
        public uvec3 brg => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec3.zxyx swizzling.
        /// </summary>
        public uvec4 zxyx => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.brgr swizzling (equivalent to uvec3.zxyx).
        /// </summary>
        public uvec4 brgr => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.zxyxx swizzling.
        /// </summary>
        public uvec5 zxyxx => new uvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.brgrr swizzling (equivalent to uvec3.zxyxx).
        /// </summary>
        public uvec5 brgrr => new uvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.zxyxy swizzling.
        /// </summary>
        public uvec5 zxyxy => new uvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.brgrg swizzling (equivalent to uvec3.zxyxy).
        /// </summary>
        public uvec5 brgrg => new uvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.zxyxz swizzling.
        /// </summary>
        public uvec5 zxyxz => new uvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.brgrb swizzling (equivalent to uvec3.zxyxz).
        /// </summary>
        public uvec5 brgrb => new uvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.zxyy swizzling.
        /// </summary>
        public uvec4 zxyy => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.brgg swizzling (equivalent to uvec3.zxyy).
        /// </summary>
        public uvec4 brgg => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.zxyyx swizzling.
        /// </summary>
        public uvec5 zxyyx => new uvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.brggr swizzling (equivalent to uvec3.zxyyx).
        /// </summary>
        public uvec5 brggr => new uvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.zxyyy swizzling.
        /// </summary>
        public uvec5 zxyyy => new uvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.brggg swizzling (equivalent to uvec3.zxyyy).
        /// </summary>
        public uvec5 brggg => new uvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.zxyyz swizzling.
        /// </summary>
        public uvec5 zxyyz => new uvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.brggb swizzling (equivalent to uvec3.zxyyz).
        /// </summary>
        public uvec5 brggb => new uvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.zxyz swizzling.
        /// </summary>
        public uvec4 zxyz => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.brgb swizzling (equivalent to uvec3.zxyz).
        /// </summary>
        public uvec4 brgb => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.zxyzx swizzling.
        /// </summary>
        public uvec5 zxyzx => new uvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.brgbr swizzling (equivalent to uvec3.zxyzx).
        /// </summary>
        public uvec5 brgbr => new uvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.zxyzy swizzling.
        /// </summary>
        public uvec5 zxyzy => new uvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.brgbg swizzling (equivalent to uvec3.zxyzy).
        /// </summary>
        public uvec5 brgbg => new uvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.zxyzz swizzling.
        /// </summary>
        public uvec5 zxyzz => new uvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.brgbb swizzling (equivalent to uvec3.zxyzz).
        /// </summary>
        public uvec5 brgbb => new uvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.zxz swizzling.
        /// </summary>
        public uvec3 zxz => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec3.brb swizzling (equivalent to uvec3.zxz).
        /// </summary>
        public uvec3 brb => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec3.zxzx swizzling.
        /// </summary>
        public uvec4 zxzx => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.brbr swizzling (equivalent to uvec3.zxzx).
        /// </summary>
        public uvec4 brbr => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.zxzxx swizzling.
        /// </summary>
        public uvec5 zxzxx => new uvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.brbrr swizzling (equivalent to uvec3.zxzxx).
        /// </summary>
        public uvec5 brbrr => new uvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.zxzxy swizzling.
        /// </summary>
        public uvec5 zxzxy => new uvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.brbrg swizzling (equivalent to uvec3.zxzxy).
        /// </summary>
        public uvec5 brbrg => new uvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.zxzxz swizzling.
        /// </summary>
        public uvec5 zxzxz => new uvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.brbrb swizzling (equivalent to uvec3.zxzxz).
        /// </summary>
        public uvec5 brbrb => new uvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.zxzy swizzling.
        /// </summary>
        public uvec4 zxzy => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.brbg swizzling (equivalent to uvec3.zxzy).
        /// </summary>
        public uvec4 brbg => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.zxzyx swizzling.
        /// </summary>
        public uvec5 zxzyx => new uvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.brbgr swizzling (equivalent to uvec3.zxzyx).
        /// </summary>
        public uvec5 brbgr => new uvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.zxzyy swizzling.
        /// </summary>
        public uvec5 zxzyy => new uvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.brbgg swizzling (equivalent to uvec3.zxzyy).
        /// </summary>
        public uvec5 brbgg => new uvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.zxzyz swizzling.
        /// </summary>
        public uvec5 zxzyz => new uvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.brbgb swizzling (equivalent to uvec3.zxzyz).
        /// </summary>
        public uvec5 brbgb => new uvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.zxzz swizzling.
        /// </summary>
        public uvec4 zxzz => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.brbb swizzling (equivalent to uvec3.zxzz).
        /// </summary>
        public uvec4 brbb => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.zxzzx swizzling.
        /// </summary>
        public uvec5 zxzzx => new uvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.brbbr swizzling (equivalent to uvec3.zxzzx).
        /// </summary>
        public uvec5 brbbr => new uvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.zxzzy swizzling.
        /// </summary>
        public uvec5 zxzzy => new uvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.brbbg swizzling (equivalent to uvec3.zxzzy).
        /// </summary>
        public uvec5 brbbg => new uvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.zxzzz swizzling.
        /// </summary>
        public uvec5 zxzzz => new uvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.brbbb swizzling (equivalent to uvec3.zxzzz).
        /// </summary>
        public uvec5 brbbb => new uvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.zy swizzling.
        /// </summary>
        public uvec2 zy => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec3.bg swizzling (equivalent to uvec3.zy).
        /// </summary>
        public uvec2 bg => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec3.zyx swizzling.
        /// </summary>
        public uvec3 zyx => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec3.bgr swizzling (equivalent to uvec3.zyx).
        /// </summary>
        public uvec3 bgr => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec3.zyxx swizzling.
        /// </summary>
        public uvec4 zyxx => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.bgrr swizzling (equivalent to uvec3.zyxx).
        /// </summary>
        public uvec4 bgrr => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.zyxxx swizzling.
        /// </summary>
        public uvec5 zyxxx => new uvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.bgrrr swizzling (equivalent to uvec3.zyxxx).
        /// </summary>
        public uvec5 bgrrr => new uvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.zyxxy swizzling.
        /// </summary>
        public uvec5 zyxxy => new uvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.bgrrg swizzling (equivalent to uvec3.zyxxy).
        /// </summary>
        public uvec5 bgrrg => new uvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.zyxxz swizzling.
        /// </summary>
        public uvec5 zyxxz => new uvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.bgrrb swizzling (equivalent to uvec3.zyxxz).
        /// </summary>
        public uvec5 bgrrb => new uvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.zyxy swizzling.
        /// </summary>
        public uvec4 zyxy => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.bgrg swizzling (equivalent to uvec3.zyxy).
        /// </summary>
        public uvec4 bgrg => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.zyxyx swizzling.
        /// </summary>
        public uvec5 zyxyx => new uvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.bgrgr swizzling (equivalent to uvec3.zyxyx).
        /// </summary>
        public uvec5 bgrgr => new uvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.zyxyy swizzling.
        /// </summary>
        public uvec5 zyxyy => new uvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.bgrgg swizzling (equivalent to uvec3.zyxyy).
        /// </summary>
        public uvec5 bgrgg => new uvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.zyxyz swizzling.
        /// </summary>
        public uvec5 zyxyz => new uvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.bgrgb swizzling (equivalent to uvec3.zyxyz).
        /// </summary>
        public uvec5 bgrgb => new uvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.zyxz swizzling.
        /// </summary>
        public uvec4 zyxz => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.bgrb swizzling (equivalent to uvec3.zyxz).
        /// </summary>
        public uvec4 bgrb => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.zyxzx swizzling.
        /// </summary>
        public uvec5 zyxzx => new uvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.bgrbr swizzling (equivalent to uvec3.zyxzx).
        /// </summary>
        public uvec5 bgrbr => new uvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.zyxzy swizzling.
        /// </summary>
        public uvec5 zyxzy => new uvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.bgrbg swizzling (equivalent to uvec3.zyxzy).
        /// </summary>
        public uvec5 bgrbg => new uvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.zyxzz swizzling.
        /// </summary>
        public uvec5 zyxzz => new uvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.bgrbb swizzling (equivalent to uvec3.zyxzz).
        /// </summary>
        public uvec5 bgrbb => new uvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.zyy swizzling.
        /// </summary>
        public uvec3 zyy => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec3.bgg swizzling (equivalent to uvec3.zyy).
        /// </summary>
        public uvec3 bgg => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec3.zyyx swizzling.
        /// </summary>
        public uvec4 zyyx => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.bggr swizzling (equivalent to uvec3.zyyx).
        /// </summary>
        public uvec4 bggr => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.zyyxx swizzling.
        /// </summary>
        public uvec5 zyyxx => new uvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.bggrr swizzling (equivalent to uvec3.zyyxx).
        /// </summary>
        public uvec5 bggrr => new uvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.zyyxy swizzling.
        /// </summary>
        public uvec5 zyyxy => new uvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.bggrg swizzling (equivalent to uvec3.zyyxy).
        /// </summary>
        public uvec5 bggrg => new uvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.zyyxz swizzling.
        /// </summary>
        public uvec5 zyyxz => new uvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.bggrb swizzling (equivalent to uvec3.zyyxz).
        /// </summary>
        public uvec5 bggrb => new uvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.zyyy swizzling.
        /// </summary>
        public uvec4 zyyy => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.bggg swizzling (equivalent to uvec3.zyyy).
        /// </summary>
        public uvec4 bggg => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.zyyyx swizzling.
        /// </summary>
        public uvec5 zyyyx => new uvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.bgggr swizzling (equivalent to uvec3.zyyyx).
        /// </summary>
        public uvec5 bgggr => new uvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.zyyyy swizzling.
        /// </summary>
        public uvec5 zyyyy => new uvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.bgggg swizzling (equivalent to uvec3.zyyyy).
        /// </summary>
        public uvec5 bgggg => new uvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.zyyyz swizzling.
        /// </summary>
        public uvec5 zyyyz => new uvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.bgggb swizzling (equivalent to uvec3.zyyyz).
        /// </summary>
        public uvec5 bgggb => new uvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.zyyz swizzling.
        /// </summary>
        public uvec4 zyyz => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.bggb swizzling (equivalent to uvec3.zyyz).
        /// </summary>
        public uvec4 bggb => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.zyyzx swizzling.
        /// </summary>
        public uvec5 zyyzx => new uvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.bggbr swizzling (equivalent to uvec3.zyyzx).
        /// </summary>
        public uvec5 bggbr => new uvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.zyyzy swizzling.
        /// </summary>
        public uvec5 zyyzy => new uvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.bggbg swizzling (equivalent to uvec3.zyyzy).
        /// </summary>
        public uvec5 bggbg => new uvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.zyyzz swizzling.
        /// </summary>
        public uvec5 zyyzz => new uvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.bggbb swizzling (equivalent to uvec3.zyyzz).
        /// </summary>
        public uvec5 bggbb => new uvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.zyz swizzling.
        /// </summary>
        public uvec3 zyz => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec3.bgb swizzling (equivalent to uvec3.zyz).
        /// </summary>
        public uvec3 bgb => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec3.zyzx swizzling.
        /// </summary>
        public uvec4 zyzx => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.bgbr swizzling (equivalent to uvec3.zyzx).
        /// </summary>
        public uvec4 bgbr => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.zyzxx swizzling.
        /// </summary>
        public uvec5 zyzxx => new uvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.bgbrr swizzling (equivalent to uvec3.zyzxx).
        /// </summary>
        public uvec5 bgbrr => new uvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.zyzxy swizzling.
        /// </summary>
        public uvec5 zyzxy => new uvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.bgbrg swizzling (equivalent to uvec3.zyzxy).
        /// </summary>
        public uvec5 bgbrg => new uvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.zyzxz swizzling.
        /// </summary>
        public uvec5 zyzxz => new uvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.bgbrb swizzling (equivalent to uvec3.zyzxz).
        /// </summary>
        public uvec5 bgbrb => new uvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.zyzy swizzling.
        /// </summary>
        public uvec4 zyzy => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.bgbg swizzling (equivalent to uvec3.zyzy).
        /// </summary>
        public uvec4 bgbg => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.zyzyx swizzling.
        /// </summary>
        public uvec5 zyzyx => new uvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.bgbgr swizzling (equivalent to uvec3.zyzyx).
        /// </summary>
        public uvec5 bgbgr => new uvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.zyzyy swizzling.
        /// </summary>
        public uvec5 zyzyy => new uvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.bgbgg swizzling (equivalent to uvec3.zyzyy).
        /// </summary>
        public uvec5 bgbgg => new uvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.zyzyz swizzling.
        /// </summary>
        public uvec5 zyzyz => new uvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.bgbgb swizzling (equivalent to uvec3.zyzyz).
        /// </summary>
        public uvec5 bgbgb => new uvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.zyzz swizzling.
        /// </summary>
        public uvec4 zyzz => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.bgbb swizzling (equivalent to uvec3.zyzz).
        /// </summary>
        public uvec4 bgbb => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.zyzzx swizzling.
        /// </summary>
        public uvec5 zyzzx => new uvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.bgbbr swizzling (equivalent to uvec3.zyzzx).
        /// </summary>
        public uvec5 bgbbr => new uvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.zyzzy swizzling.
        /// </summary>
        public uvec5 zyzzy => new uvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.bgbbg swizzling (equivalent to uvec3.zyzzy).
        /// </summary>
        public uvec5 bgbbg => new uvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.zyzzz swizzling.
        /// </summary>
        public uvec5 zyzzz => new uvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.bgbbb swizzling (equivalent to uvec3.zyzzz).
        /// </summary>
        public uvec5 bgbbb => new uvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.zz swizzling.
        /// </summary>
        public uvec2 zz => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec3.bb swizzling (equivalent to uvec3.zz).
        /// </summary>
        public uvec2 bb => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec3.zzx swizzling.
        /// </summary>
        public uvec3 zzx => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec3.bbr swizzling (equivalent to uvec3.zzx).
        /// </summary>
        public uvec3 bbr => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec3.zzxx swizzling.
        /// </summary>
        public uvec4 zzxx => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.bbrr swizzling (equivalent to uvec3.zzxx).
        /// </summary>
        public uvec4 bbrr => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.zzxxx swizzling.
        /// </summary>
        public uvec5 zzxxx => new uvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.bbrrr swizzling (equivalent to uvec3.zzxxx).
        /// </summary>
        public uvec5 bbrrr => new uvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.zzxxy swizzling.
        /// </summary>
        public uvec5 zzxxy => new uvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.bbrrg swizzling (equivalent to uvec3.zzxxy).
        /// </summary>
        public uvec5 bbrrg => new uvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.zzxxz swizzling.
        /// </summary>
        public uvec5 zzxxz => new uvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.bbrrb swizzling (equivalent to uvec3.zzxxz).
        /// </summary>
        public uvec5 bbrrb => new uvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.zzxy swizzling.
        /// </summary>
        public uvec4 zzxy => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.bbrg swizzling (equivalent to uvec3.zzxy).
        /// </summary>
        public uvec4 bbrg => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.zzxyx swizzling.
        /// </summary>
        public uvec5 zzxyx => new uvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.bbrgr swizzling (equivalent to uvec3.zzxyx).
        /// </summary>
        public uvec5 bbrgr => new uvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.zzxyy swizzling.
        /// </summary>
        public uvec5 zzxyy => new uvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.bbrgg swizzling (equivalent to uvec3.zzxyy).
        /// </summary>
        public uvec5 bbrgg => new uvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.zzxyz swizzling.
        /// </summary>
        public uvec5 zzxyz => new uvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.bbrgb swizzling (equivalent to uvec3.zzxyz).
        /// </summary>
        public uvec5 bbrgb => new uvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.zzxz swizzling.
        /// </summary>
        public uvec4 zzxz => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.bbrb swizzling (equivalent to uvec3.zzxz).
        /// </summary>
        public uvec4 bbrb => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.zzxzx swizzling.
        /// </summary>
        public uvec5 zzxzx => new uvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.bbrbr swizzling (equivalent to uvec3.zzxzx).
        /// </summary>
        public uvec5 bbrbr => new uvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.zzxzy swizzling.
        /// </summary>
        public uvec5 zzxzy => new uvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.bbrbg swizzling (equivalent to uvec3.zzxzy).
        /// </summary>
        public uvec5 bbrbg => new uvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.zzxzz swizzling.
        /// </summary>
        public uvec5 zzxzz => new uvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.bbrbb swizzling (equivalent to uvec3.zzxzz).
        /// </summary>
        public uvec5 bbrbb => new uvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.zzy swizzling.
        /// </summary>
        public uvec3 zzy => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec3.bbg swizzling (equivalent to uvec3.zzy).
        /// </summary>
        public uvec3 bbg => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec3.zzyx swizzling.
        /// </summary>
        public uvec4 zzyx => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.bbgr swizzling (equivalent to uvec3.zzyx).
        /// </summary>
        public uvec4 bbgr => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.zzyxx swizzling.
        /// </summary>
        public uvec5 zzyxx => new uvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.bbgrr swizzling (equivalent to uvec3.zzyxx).
        /// </summary>
        public uvec5 bbgrr => new uvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.zzyxy swizzling.
        /// </summary>
        public uvec5 zzyxy => new uvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.bbgrg swizzling (equivalent to uvec3.zzyxy).
        /// </summary>
        public uvec5 bbgrg => new uvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.zzyxz swizzling.
        /// </summary>
        public uvec5 zzyxz => new uvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.bbgrb swizzling (equivalent to uvec3.zzyxz).
        /// </summary>
        public uvec5 bbgrb => new uvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.zzyy swizzling.
        /// </summary>
        public uvec4 zzyy => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.bbgg swizzling (equivalent to uvec3.zzyy).
        /// </summary>
        public uvec4 bbgg => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.zzyyx swizzling.
        /// </summary>
        public uvec5 zzyyx => new uvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.bbggr swizzling (equivalent to uvec3.zzyyx).
        /// </summary>
        public uvec5 bbggr => new uvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.zzyyy swizzling.
        /// </summary>
        public uvec5 zzyyy => new uvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.bbggg swizzling (equivalent to uvec3.zzyyy).
        /// </summary>
        public uvec5 bbggg => new uvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.zzyyz swizzling.
        /// </summary>
        public uvec5 zzyyz => new uvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.bbggb swizzling (equivalent to uvec3.zzyyz).
        /// </summary>
        public uvec5 bbggb => new uvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.zzyz swizzling.
        /// </summary>
        public uvec4 zzyz => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.bbgb swizzling (equivalent to uvec3.zzyz).
        /// </summary>
        public uvec4 bbgb => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.zzyzx swizzling.
        /// </summary>
        public uvec5 zzyzx => new uvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.bbgbr swizzling (equivalent to uvec3.zzyzx).
        /// </summary>
        public uvec5 bbgbr => new uvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.zzyzy swizzling.
        /// </summary>
        public uvec5 zzyzy => new uvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.bbgbg swizzling (equivalent to uvec3.zzyzy).
        /// </summary>
        public uvec5 bbgbg => new uvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.zzyzz swizzling.
        /// </summary>
        public uvec5 zzyzz => new uvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.bbgbb swizzling (equivalent to uvec3.zzyzz).
        /// </summary>
        public uvec5 bbgbb => new uvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.zzz swizzling.
        /// </summary>
        public uvec3 zzz => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec3.bbb swizzling (equivalent to uvec3.zzz).
        /// </summary>
        public uvec3 bbb => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec3.zzzx swizzling.
        /// </summary>
        public uvec4 zzzx => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.bbbr swizzling (equivalent to uvec3.zzzx).
        /// </summary>
        public uvec4 bbbr => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.zzzxx swizzling.
        /// </summary>
        public uvec5 zzzxx => new uvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.bbbrr swizzling (equivalent to uvec3.zzzxx).
        /// </summary>
        public uvec5 bbbrr => new uvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.zzzxy swizzling.
        /// </summary>
        public uvec5 zzzxy => new uvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.bbbrg swizzling (equivalent to uvec3.zzzxy).
        /// </summary>
        public uvec5 bbbrg => new uvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.zzzxz swizzling.
        /// </summary>
        public uvec5 zzzxz => new uvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.bbbrb swizzling (equivalent to uvec3.zzzxz).
        /// </summary>
        public uvec5 bbbrb => new uvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.zzzy swizzling.
        /// </summary>
        public uvec4 zzzy => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.bbbg swizzling (equivalent to uvec3.zzzy).
        /// </summary>
        public uvec4 bbbg => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.zzzyx swizzling.
        /// </summary>
        public uvec5 zzzyx => new uvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.bbbgr swizzling (equivalent to uvec3.zzzyx).
        /// </summary>
        public uvec5 bbbgr => new uvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.zzzyy swizzling.
        /// </summary>
        public uvec5 zzzyy => new uvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.bbbgg swizzling (equivalent to uvec3.zzzyy).
        /// </summary>
        public uvec5 bbbgg => new uvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.zzzyz swizzling.
        /// </summary>
        public uvec5 zzzyz => new uvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.bbbgb swizzling (equivalent to uvec3.zzzyz).
        /// </summary>
        public uvec5 bbbgb => new uvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.zzzz swizzling.
        /// </summary>
        public uvec4 zzzz => new uvec4(z, z, z, z);
        
        /// <summary>
        /// Returns uvec3.bbbb swizzling (equivalent to uvec3.zzzz).
        /// </summary>
        public uvec4 bbbb => new uvec4(z, z, z, z);
        
        /// <summary>
        /// Returns uvec3.zzzzx swizzling.
        /// </summary>
        public uvec5 zzzzx => new uvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.bbbbr swizzling (equivalent to uvec3.zzzzx).
        /// </summary>
        public uvec5 bbbbr => new uvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.zzzzy swizzling.
        /// </summary>
        public uvec5 zzzzy => new uvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.bbbbg swizzling (equivalent to uvec3.zzzzy).
        /// </summary>
        public uvec5 bbbbg => new uvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.zzzzz swizzling.
        /// </summary>
        public uvec5 zzzzz => new uvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns uvec3.bbbbb swizzling (equivalent to uvec3.zzzzz).
        /// </summary>
        public uvec5 bbbbb => new uvec5(z, z, z, z, z);

        #endregion

    }
}
