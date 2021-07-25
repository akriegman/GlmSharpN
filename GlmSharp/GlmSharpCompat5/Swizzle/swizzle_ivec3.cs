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
    /// Temporary vector of type int with 3 components, used for implementing swizzling for ivec3.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_ivec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly int x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly int y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly int z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_ivec3.
        /// </summary>
        internal swizzle_ivec3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns ivec3.xx swizzling.
        /// </summary>
        public ivec2 xx => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec3.rr swizzling (equivalent to ivec3.xx).
        /// </summary>
        public ivec2 rr => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec3.xxx swizzling.
        /// </summary>
        public ivec3 xxx => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec3.rrr swizzling (equivalent to ivec3.xxx).
        /// </summary>
        public ivec3 rrr => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec3.xxxx swizzling.
        /// </summary>
        public ivec4 xxxx => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.rrrr swizzling (equivalent to ivec3.xxxx).
        /// </summary>
        public ivec4 rrrr => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.xxxxx swizzling.
        /// </summary>
        public ivec5 xxxxx => new ivec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.rrrrr swizzling (equivalent to ivec3.xxxxx).
        /// </summary>
        public ivec5 rrrrr => new ivec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.xxxxy swizzling.
        /// </summary>
        public ivec5 xxxxy => new ivec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.rrrrg swizzling (equivalent to ivec3.xxxxy).
        /// </summary>
        public ivec5 rrrrg => new ivec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.xxxxz swizzling.
        /// </summary>
        public ivec5 xxxxz => new ivec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.rrrrb swizzling (equivalent to ivec3.xxxxz).
        /// </summary>
        public ivec5 rrrrb => new ivec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.xxxy swizzling.
        /// </summary>
        public ivec4 xxxy => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.rrrg swizzling (equivalent to ivec3.xxxy).
        /// </summary>
        public ivec4 rrrg => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.xxxyx swizzling.
        /// </summary>
        public ivec5 xxxyx => new ivec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.rrrgr swizzling (equivalent to ivec3.xxxyx).
        /// </summary>
        public ivec5 rrrgr => new ivec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.xxxyy swizzling.
        /// </summary>
        public ivec5 xxxyy => new ivec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.rrrgg swizzling (equivalent to ivec3.xxxyy).
        /// </summary>
        public ivec5 rrrgg => new ivec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.xxxyz swizzling.
        /// </summary>
        public ivec5 xxxyz => new ivec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.rrrgb swizzling (equivalent to ivec3.xxxyz).
        /// </summary>
        public ivec5 rrrgb => new ivec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.xxxz swizzling.
        /// </summary>
        public ivec4 xxxz => new ivec4(x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.rrrb swizzling (equivalent to ivec3.xxxz).
        /// </summary>
        public ivec4 rrrb => new ivec4(x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.xxxzx swizzling.
        /// </summary>
        public ivec5 xxxzx => new ivec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.rrrbr swizzling (equivalent to ivec3.xxxzx).
        /// </summary>
        public ivec5 rrrbr => new ivec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.xxxzy swizzling.
        /// </summary>
        public ivec5 xxxzy => new ivec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.rrrbg swizzling (equivalent to ivec3.xxxzy).
        /// </summary>
        public ivec5 rrrbg => new ivec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.xxxzz swizzling.
        /// </summary>
        public ivec5 xxxzz => new ivec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.rrrbb swizzling (equivalent to ivec3.xxxzz).
        /// </summary>
        public ivec5 rrrbb => new ivec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.xxy swizzling.
        /// </summary>
        public ivec3 xxy => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec3.rrg swizzling (equivalent to ivec3.xxy).
        /// </summary>
        public ivec3 rrg => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec3.xxyx swizzling.
        /// </summary>
        public ivec4 xxyx => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.rrgr swizzling (equivalent to ivec3.xxyx).
        /// </summary>
        public ivec4 rrgr => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.xxyxx swizzling.
        /// </summary>
        public ivec5 xxyxx => new ivec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.rrgrr swizzling (equivalent to ivec3.xxyxx).
        /// </summary>
        public ivec5 rrgrr => new ivec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.xxyxy swizzling.
        /// </summary>
        public ivec5 xxyxy => new ivec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.rrgrg swizzling (equivalent to ivec3.xxyxy).
        /// </summary>
        public ivec5 rrgrg => new ivec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.xxyxz swizzling.
        /// </summary>
        public ivec5 xxyxz => new ivec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.rrgrb swizzling (equivalent to ivec3.xxyxz).
        /// </summary>
        public ivec5 rrgrb => new ivec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.xxyy swizzling.
        /// </summary>
        public ivec4 xxyy => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.rrgg swizzling (equivalent to ivec3.xxyy).
        /// </summary>
        public ivec4 rrgg => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.xxyyx swizzling.
        /// </summary>
        public ivec5 xxyyx => new ivec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.rrggr swizzling (equivalent to ivec3.xxyyx).
        /// </summary>
        public ivec5 rrggr => new ivec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.xxyyy swizzling.
        /// </summary>
        public ivec5 xxyyy => new ivec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.rrggg swizzling (equivalent to ivec3.xxyyy).
        /// </summary>
        public ivec5 rrggg => new ivec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.xxyyz swizzling.
        /// </summary>
        public ivec5 xxyyz => new ivec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.rrggb swizzling (equivalent to ivec3.xxyyz).
        /// </summary>
        public ivec5 rrggb => new ivec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.xxyz swizzling.
        /// </summary>
        public ivec4 xxyz => new ivec4(x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.rrgb swizzling (equivalent to ivec3.xxyz).
        /// </summary>
        public ivec4 rrgb => new ivec4(x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.xxyzx swizzling.
        /// </summary>
        public ivec5 xxyzx => new ivec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.rrgbr swizzling (equivalent to ivec3.xxyzx).
        /// </summary>
        public ivec5 rrgbr => new ivec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.xxyzy swizzling.
        /// </summary>
        public ivec5 xxyzy => new ivec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.rrgbg swizzling (equivalent to ivec3.xxyzy).
        /// </summary>
        public ivec5 rrgbg => new ivec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.xxyzz swizzling.
        /// </summary>
        public ivec5 xxyzz => new ivec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.rrgbb swizzling (equivalent to ivec3.xxyzz).
        /// </summary>
        public ivec5 rrgbb => new ivec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.xxz swizzling.
        /// </summary>
        public ivec3 xxz => new ivec3(x, x, z);
        
        /// <summary>
        /// Returns ivec3.rrb swizzling (equivalent to ivec3.xxz).
        /// </summary>
        public ivec3 rrb => new ivec3(x, x, z);
        
        /// <summary>
        /// Returns ivec3.xxzx swizzling.
        /// </summary>
        public ivec4 xxzx => new ivec4(x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.rrbr swizzling (equivalent to ivec3.xxzx).
        /// </summary>
        public ivec4 rrbr => new ivec4(x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.xxzxx swizzling.
        /// </summary>
        public ivec5 xxzxx => new ivec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.rrbrr swizzling (equivalent to ivec3.xxzxx).
        /// </summary>
        public ivec5 rrbrr => new ivec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.xxzxy swizzling.
        /// </summary>
        public ivec5 xxzxy => new ivec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.rrbrg swizzling (equivalent to ivec3.xxzxy).
        /// </summary>
        public ivec5 rrbrg => new ivec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.xxzxz swizzling.
        /// </summary>
        public ivec5 xxzxz => new ivec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.rrbrb swizzling (equivalent to ivec3.xxzxz).
        /// </summary>
        public ivec5 rrbrb => new ivec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.xxzy swizzling.
        /// </summary>
        public ivec4 xxzy => new ivec4(x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.rrbg swizzling (equivalent to ivec3.xxzy).
        /// </summary>
        public ivec4 rrbg => new ivec4(x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.xxzyx swizzling.
        /// </summary>
        public ivec5 xxzyx => new ivec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.rrbgr swizzling (equivalent to ivec3.xxzyx).
        /// </summary>
        public ivec5 rrbgr => new ivec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.xxzyy swizzling.
        /// </summary>
        public ivec5 xxzyy => new ivec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.rrbgg swizzling (equivalent to ivec3.xxzyy).
        /// </summary>
        public ivec5 rrbgg => new ivec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.xxzyz swizzling.
        /// </summary>
        public ivec5 xxzyz => new ivec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.rrbgb swizzling (equivalent to ivec3.xxzyz).
        /// </summary>
        public ivec5 rrbgb => new ivec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.xxzz swizzling.
        /// </summary>
        public ivec4 xxzz => new ivec4(x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.rrbb swizzling (equivalent to ivec3.xxzz).
        /// </summary>
        public ivec4 rrbb => new ivec4(x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.xxzzx swizzling.
        /// </summary>
        public ivec5 xxzzx => new ivec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.rrbbr swizzling (equivalent to ivec3.xxzzx).
        /// </summary>
        public ivec5 rrbbr => new ivec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.xxzzy swizzling.
        /// </summary>
        public ivec5 xxzzy => new ivec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.rrbbg swizzling (equivalent to ivec3.xxzzy).
        /// </summary>
        public ivec5 rrbbg => new ivec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.xxzzz swizzling.
        /// </summary>
        public ivec5 xxzzz => new ivec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.rrbbb swizzling (equivalent to ivec3.xxzzz).
        /// </summary>
        public ivec5 rrbbb => new ivec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.xy swizzling.
        /// </summary>
        public ivec2 xy => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec3.rg swizzling (equivalent to ivec3.xy).
        /// </summary>
        public ivec2 rg => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec3.xyx swizzling.
        /// </summary>
        public ivec3 xyx => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec3.rgr swizzling (equivalent to ivec3.xyx).
        /// </summary>
        public ivec3 rgr => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec3.xyxx swizzling.
        /// </summary>
        public ivec4 xyxx => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.rgrr swizzling (equivalent to ivec3.xyxx).
        /// </summary>
        public ivec4 rgrr => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.xyxxx swizzling.
        /// </summary>
        public ivec5 xyxxx => new ivec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.rgrrr swizzling (equivalent to ivec3.xyxxx).
        /// </summary>
        public ivec5 rgrrr => new ivec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.xyxxy swizzling.
        /// </summary>
        public ivec5 xyxxy => new ivec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.rgrrg swizzling (equivalent to ivec3.xyxxy).
        /// </summary>
        public ivec5 rgrrg => new ivec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.xyxxz swizzling.
        /// </summary>
        public ivec5 xyxxz => new ivec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.rgrrb swizzling (equivalent to ivec3.xyxxz).
        /// </summary>
        public ivec5 rgrrb => new ivec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.xyxy swizzling.
        /// </summary>
        public ivec4 xyxy => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.rgrg swizzling (equivalent to ivec3.xyxy).
        /// </summary>
        public ivec4 rgrg => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.xyxyx swizzling.
        /// </summary>
        public ivec5 xyxyx => new ivec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.rgrgr swizzling (equivalent to ivec3.xyxyx).
        /// </summary>
        public ivec5 rgrgr => new ivec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.xyxyy swizzling.
        /// </summary>
        public ivec5 xyxyy => new ivec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.rgrgg swizzling (equivalent to ivec3.xyxyy).
        /// </summary>
        public ivec5 rgrgg => new ivec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.xyxyz swizzling.
        /// </summary>
        public ivec5 xyxyz => new ivec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.rgrgb swizzling (equivalent to ivec3.xyxyz).
        /// </summary>
        public ivec5 rgrgb => new ivec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.xyxz swizzling.
        /// </summary>
        public ivec4 xyxz => new ivec4(x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.rgrb swizzling (equivalent to ivec3.xyxz).
        /// </summary>
        public ivec4 rgrb => new ivec4(x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.xyxzx swizzling.
        /// </summary>
        public ivec5 xyxzx => new ivec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.rgrbr swizzling (equivalent to ivec3.xyxzx).
        /// </summary>
        public ivec5 rgrbr => new ivec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.xyxzy swizzling.
        /// </summary>
        public ivec5 xyxzy => new ivec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.rgrbg swizzling (equivalent to ivec3.xyxzy).
        /// </summary>
        public ivec5 rgrbg => new ivec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.xyxzz swizzling.
        /// </summary>
        public ivec5 xyxzz => new ivec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.rgrbb swizzling (equivalent to ivec3.xyxzz).
        /// </summary>
        public ivec5 rgrbb => new ivec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.xyy swizzling.
        /// </summary>
        public ivec3 xyy => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec3.rgg swizzling (equivalent to ivec3.xyy).
        /// </summary>
        public ivec3 rgg => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec3.xyyx swizzling.
        /// </summary>
        public ivec4 xyyx => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.rggr swizzling (equivalent to ivec3.xyyx).
        /// </summary>
        public ivec4 rggr => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.xyyxx swizzling.
        /// </summary>
        public ivec5 xyyxx => new ivec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.rggrr swizzling (equivalent to ivec3.xyyxx).
        /// </summary>
        public ivec5 rggrr => new ivec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.xyyxy swizzling.
        /// </summary>
        public ivec5 xyyxy => new ivec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.rggrg swizzling (equivalent to ivec3.xyyxy).
        /// </summary>
        public ivec5 rggrg => new ivec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.xyyxz swizzling.
        /// </summary>
        public ivec5 xyyxz => new ivec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.rggrb swizzling (equivalent to ivec3.xyyxz).
        /// </summary>
        public ivec5 rggrb => new ivec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.xyyy swizzling.
        /// </summary>
        public ivec4 xyyy => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.rggg swizzling (equivalent to ivec3.xyyy).
        /// </summary>
        public ivec4 rggg => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.xyyyx swizzling.
        /// </summary>
        public ivec5 xyyyx => new ivec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.rgggr swizzling (equivalent to ivec3.xyyyx).
        /// </summary>
        public ivec5 rgggr => new ivec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.xyyyy swizzling.
        /// </summary>
        public ivec5 xyyyy => new ivec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.rgggg swizzling (equivalent to ivec3.xyyyy).
        /// </summary>
        public ivec5 rgggg => new ivec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.xyyyz swizzling.
        /// </summary>
        public ivec5 xyyyz => new ivec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.rgggb swizzling (equivalent to ivec3.xyyyz).
        /// </summary>
        public ivec5 rgggb => new ivec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.xyyz swizzling.
        /// </summary>
        public ivec4 xyyz => new ivec4(x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.rggb swizzling (equivalent to ivec3.xyyz).
        /// </summary>
        public ivec4 rggb => new ivec4(x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.xyyzx swizzling.
        /// </summary>
        public ivec5 xyyzx => new ivec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.rggbr swizzling (equivalent to ivec3.xyyzx).
        /// </summary>
        public ivec5 rggbr => new ivec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.xyyzy swizzling.
        /// </summary>
        public ivec5 xyyzy => new ivec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.rggbg swizzling (equivalent to ivec3.xyyzy).
        /// </summary>
        public ivec5 rggbg => new ivec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.xyyzz swizzling.
        /// </summary>
        public ivec5 xyyzz => new ivec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.rggbb swizzling (equivalent to ivec3.xyyzz).
        /// </summary>
        public ivec5 rggbb => new ivec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.xyz swizzling.
        /// </summary>
        public ivec3 xyz => new ivec3(x, y, z);
        
        /// <summary>
        /// Returns ivec3.rgb swizzling (equivalent to ivec3.xyz).
        /// </summary>
        public ivec3 rgb => new ivec3(x, y, z);
        
        /// <summary>
        /// Returns ivec3.xyzx swizzling.
        /// </summary>
        public ivec4 xyzx => new ivec4(x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.rgbr swizzling (equivalent to ivec3.xyzx).
        /// </summary>
        public ivec4 rgbr => new ivec4(x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.xyzxx swizzling.
        /// </summary>
        public ivec5 xyzxx => new ivec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.rgbrr swizzling (equivalent to ivec3.xyzxx).
        /// </summary>
        public ivec5 rgbrr => new ivec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.xyzxy swizzling.
        /// </summary>
        public ivec5 xyzxy => new ivec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.rgbrg swizzling (equivalent to ivec3.xyzxy).
        /// </summary>
        public ivec5 rgbrg => new ivec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.xyzxz swizzling.
        /// </summary>
        public ivec5 xyzxz => new ivec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.rgbrb swizzling (equivalent to ivec3.xyzxz).
        /// </summary>
        public ivec5 rgbrb => new ivec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.xyzy swizzling.
        /// </summary>
        public ivec4 xyzy => new ivec4(x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.rgbg swizzling (equivalent to ivec3.xyzy).
        /// </summary>
        public ivec4 rgbg => new ivec4(x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.xyzyx swizzling.
        /// </summary>
        public ivec5 xyzyx => new ivec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.rgbgr swizzling (equivalent to ivec3.xyzyx).
        /// </summary>
        public ivec5 rgbgr => new ivec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.xyzyy swizzling.
        /// </summary>
        public ivec5 xyzyy => new ivec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.rgbgg swizzling (equivalent to ivec3.xyzyy).
        /// </summary>
        public ivec5 rgbgg => new ivec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.xyzyz swizzling.
        /// </summary>
        public ivec5 xyzyz => new ivec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.rgbgb swizzling (equivalent to ivec3.xyzyz).
        /// </summary>
        public ivec5 rgbgb => new ivec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.xyzz swizzling.
        /// </summary>
        public ivec4 xyzz => new ivec4(x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.rgbb swizzling (equivalent to ivec3.xyzz).
        /// </summary>
        public ivec4 rgbb => new ivec4(x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.xyzzx swizzling.
        /// </summary>
        public ivec5 xyzzx => new ivec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.rgbbr swizzling (equivalent to ivec3.xyzzx).
        /// </summary>
        public ivec5 rgbbr => new ivec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.xyzzy swizzling.
        /// </summary>
        public ivec5 xyzzy => new ivec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.rgbbg swizzling (equivalent to ivec3.xyzzy).
        /// </summary>
        public ivec5 rgbbg => new ivec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.xyzzz swizzling.
        /// </summary>
        public ivec5 xyzzz => new ivec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.rgbbb swizzling (equivalent to ivec3.xyzzz).
        /// </summary>
        public ivec5 rgbbb => new ivec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.xz swizzling.
        /// </summary>
        public ivec2 xz => new ivec2(x, z);
        
        /// <summary>
        /// Returns ivec3.rb swizzling (equivalent to ivec3.xz).
        /// </summary>
        public ivec2 rb => new ivec2(x, z);
        
        /// <summary>
        /// Returns ivec3.xzx swizzling.
        /// </summary>
        public ivec3 xzx => new ivec3(x, z, x);
        
        /// <summary>
        /// Returns ivec3.rbr swizzling (equivalent to ivec3.xzx).
        /// </summary>
        public ivec3 rbr => new ivec3(x, z, x);
        
        /// <summary>
        /// Returns ivec3.xzxx swizzling.
        /// </summary>
        public ivec4 xzxx => new ivec4(x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.rbrr swizzling (equivalent to ivec3.xzxx).
        /// </summary>
        public ivec4 rbrr => new ivec4(x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.xzxxx swizzling.
        /// </summary>
        public ivec5 xzxxx => new ivec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.rbrrr swizzling (equivalent to ivec3.xzxxx).
        /// </summary>
        public ivec5 rbrrr => new ivec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.xzxxy swizzling.
        /// </summary>
        public ivec5 xzxxy => new ivec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.rbrrg swizzling (equivalent to ivec3.xzxxy).
        /// </summary>
        public ivec5 rbrrg => new ivec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.xzxxz swizzling.
        /// </summary>
        public ivec5 xzxxz => new ivec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.rbrrb swizzling (equivalent to ivec3.xzxxz).
        /// </summary>
        public ivec5 rbrrb => new ivec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.xzxy swizzling.
        /// </summary>
        public ivec4 xzxy => new ivec4(x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.rbrg swizzling (equivalent to ivec3.xzxy).
        /// </summary>
        public ivec4 rbrg => new ivec4(x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.xzxyx swizzling.
        /// </summary>
        public ivec5 xzxyx => new ivec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.rbrgr swizzling (equivalent to ivec3.xzxyx).
        /// </summary>
        public ivec5 rbrgr => new ivec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.xzxyy swizzling.
        /// </summary>
        public ivec5 xzxyy => new ivec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.rbrgg swizzling (equivalent to ivec3.xzxyy).
        /// </summary>
        public ivec5 rbrgg => new ivec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.xzxyz swizzling.
        /// </summary>
        public ivec5 xzxyz => new ivec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.rbrgb swizzling (equivalent to ivec3.xzxyz).
        /// </summary>
        public ivec5 rbrgb => new ivec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.xzxz swizzling.
        /// </summary>
        public ivec4 xzxz => new ivec4(x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.rbrb swizzling (equivalent to ivec3.xzxz).
        /// </summary>
        public ivec4 rbrb => new ivec4(x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.xzxzx swizzling.
        /// </summary>
        public ivec5 xzxzx => new ivec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.rbrbr swizzling (equivalent to ivec3.xzxzx).
        /// </summary>
        public ivec5 rbrbr => new ivec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.xzxzy swizzling.
        /// </summary>
        public ivec5 xzxzy => new ivec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.rbrbg swizzling (equivalent to ivec3.xzxzy).
        /// </summary>
        public ivec5 rbrbg => new ivec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.xzxzz swizzling.
        /// </summary>
        public ivec5 xzxzz => new ivec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.rbrbb swizzling (equivalent to ivec3.xzxzz).
        /// </summary>
        public ivec5 rbrbb => new ivec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.xzy swizzling.
        /// </summary>
        public ivec3 xzy => new ivec3(x, z, y);
        
        /// <summary>
        /// Returns ivec3.rbg swizzling (equivalent to ivec3.xzy).
        /// </summary>
        public ivec3 rbg => new ivec3(x, z, y);
        
        /// <summary>
        /// Returns ivec3.xzyx swizzling.
        /// </summary>
        public ivec4 xzyx => new ivec4(x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.rbgr swizzling (equivalent to ivec3.xzyx).
        /// </summary>
        public ivec4 rbgr => new ivec4(x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.xzyxx swizzling.
        /// </summary>
        public ivec5 xzyxx => new ivec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.rbgrr swizzling (equivalent to ivec3.xzyxx).
        /// </summary>
        public ivec5 rbgrr => new ivec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.xzyxy swizzling.
        /// </summary>
        public ivec5 xzyxy => new ivec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.rbgrg swizzling (equivalent to ivec3.xzyxy).
        /// </summary>
        public ivec5 rbgrg => new ivec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.xzyxz swizzling.
        /// </summary>
        public ivec5 xzyxz => new ivec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.rbgrb swizzling (equivalent to ivec3.xzyxz).
        /// </summary>
        public ivec5 rbgrb => new ivec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.xzyy swizzling.
        /// </summary>
        public ivec4 xzyy => new ivec4(x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.rbgg swizzling (equivalent to ivec3.xzyy).
        /// </summary>
        public ivec4 rbgg => new ivec4(x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.xzyyx swizzling.
        /// </summary>
        public ivec5 xzyyx => new ivec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.rbggr swizzling (equivalent to ivec3.xzyyx).
        /// </summary>
        public ivec5 rbggr => new ivec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.xzyyy swizzling.
        /// </summary>
        public ivec5 xzyyy => new ivec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.rbggg swizzling (equivalent to ivec3.xzyyy).
        /// </summary>
        public ivec5 rbggg => new ivec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.xzyyz swizzling.
        /// </summary>
        public ivec5 xzyyz => new ivec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.rbggb swizzling (equivalent to ivec3.xzyyz).
        /// </summary>
        public ivec5 rbggb => new ivec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.xzyz swizzling.
        /// </summary>
        public ivec4 xzyz => new ivec4(x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.rbgb swizzling (equivalent to ivec3.xzyz).
        /// </summary>
        public ivec4 rbgb => new ivec4(x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.xzyzx swizzling.
        /// </summary>
        public ivec5 xzyzx => new ivec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.rbgbr swizzling (equivalent to ivec3.xzyzx).
        /// </summary>
        public ivec5 rbgbr => new ivec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.xzyzy swizzling.
        /// </summary>
        public ivec5 xzyzy => new ivec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.rbgbg swizzling (equivalent to ivec3.xzyzy).
        /// </summary>
        public ivec5 rbgbg => new ivec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.xzyzz swizzling.
        /// </summary>
        public ivec5 xzyzz => new ivec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.rbgbb swizzling (equivalent to ivec3.xzyzz).
        /// </summary>
        public ivec5 rbgbb => new ivec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.xzz swizzling.
        /// </summary>
        public ivec3 xzz => new ivec3(x, z, z);
        
        /// <summary>
        /// Returns ivec3.rbb swizzling (equivalent to ivec3.xzz).
        /// </summary>
        public ivec3 rbb => new ivec3(x, z, z);
        
        /// <summary>
        /// Returns ivec3.xzzx swizzling.
        /// </summary>
        public ivec4 xzzx => new ivec4(x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.rbbr swizzling (equivalent to ivec3.xzzx).
        /// </summary>
        public ivec4 rbbr => new ivec4(x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.xzzxx swizzling.
        /// </summary>
        public ivec5 xzzxx => new ivec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.rbbrr swizzling (equivalent to ivec3.xzzxx).
        /// </summary>
        public ivec5 rbbrr => new ivec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.xzzxy swizzling.
        /// </summary>
        public ivec5 xzzxy => new ivec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.rbbrg swizzling (equivalent to ivec3.xzzxy).
        /// </summary>
        public ivec5 rbbrg => new ivec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.xzzxz swizzling.
        /// </summary>
        public ivec5 xzzxz => new ivec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.rbbrb swizzling (equivalent to ivec3.xzzxz).
        /// </summary>
        public ivec5 rbbrb => new ivec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.xzzy swizzling.
        /// </summary>
        public ivec4 xzzy => new ivec4(x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.rbbg swizzling (equivalent to ivec3.xzzy).
        /// </summary>
        public ivec4 rbbg => new ivec4(x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.xzzyx swizzling.
        /// </summary>
        public ivec5 xzzyx => new ivec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.rbbgr swizzling (equivalent to ivec3.xzzyx).
        /// </summary>
        public ivec5 rbbgr => new ivec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.xzzyy swizzling.
        /// </summary>
        public ivec5 xzzyy => new ivec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.rbbgg swizzling (equivalent to ivec3.xzzyy).
        /// </summary>
        public ivec5 rbbgg => new ivec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.xzzyz swizzling.
        /// </summary>
        public ivec5 xzzyz => new ivec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.rbbgb swizzling (equivalent to ivec3.xzzyz).
        /// </summary>
        public ivec5 rbbgb => new ivec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.xzzz swizzling.
        /// </summary>
        public ivec4 xzzz => new ivec4(x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.rbbb swizzling (equivalent to ivec3.xzzz).
        /// </summary>
        public ivec4 rbbb => new ivec4(x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.xzzzx swizzling.
        /// </summary>
        public ivec5 xzzzx => new ivec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.rbbbr swizzling (equivalent to ivec3.xzzzx).
        /// </summary>
        public ivec5 rbbbr => new ivec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.xzzzy swizzling.
        /// </summary>
        public ivec5 xzzzy => new ivec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.rbbbg swizzling (equivalent to ivec3.xzzzy).
        /// </summary>
        public ivec5 rbbbg => new ivec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.xzzzz swizzling.
        /// </summary>
        public ivec5 xzzzz => new ivec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns ivec3.rbbbb swizzling (equivalent to ivec3.xzzzz).
        /// </summary>
        public ivec5 rbbbb => new ivec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns ivec3.yx swizzling.
        /// </summary>
        public ivec2 yx => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec3.gr swizzling (equivalent to ivec3.yx).
        /// </summary>
        public ivec2 gr => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec3.yxx swizzling.
        /// </summary>
        public ivec3 yxx => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec3.grr swizzling (equivalent to ivec3.yxx).
        /// </summary>
        public ivec3 grr => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec3.yxxx swizzling.
        /// </summary>
        public ivec4 yxxx => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.grrr swizzling (equivalent to ivec3.yxxx).
        /// </summary>
        public ivec4 grrr => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.yxxxx swizzling.
        /// </summary>
        public ivec5 yxxxx => new ivec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.grrrr swizzling (equivalent to ivec3.yxxxx).
        /// </summary>
        public ivec5 grrrr => new ivec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.yxxxy swizzling.
        /// </summary>
        public ivec5 yxxxy => new ivec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.grrrg swizzling (equivalent to ivec3.yxxxy).
        /// </summary>
        public ivec5 grrrg => new ivec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.yxxxz swizzling.
        /// </summary>
        public ivec5 yxxxz => new ivec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.grrrb swizzling (equivalent to ivec3.yxxxz).
        /// </summary>
        public ivec5 grrrb => new ivec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.yxxy swizzling.
        /// </summary>
        public ivec4 yxxy => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.grrg swizzling (equivalent to ivec3.yxxy).
        /// </summary>
        public ivec4 grrg => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.yxxyx swizzling.
        /// </summary>
        public ivec5 yxxyx => new ivec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.grrgr swizzling (equivalent to ivec3.yxxyx).
        /// </summary>
        public ivec5 grrgr => new ivec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.yxxyy swizzling.
        /// </summary>
        public ivec5 yxxyy => new ivec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.grrgg swizzling (equivalent to ivec3.yxxyy).
        /// </summary>
        public ivec5 grrgg => new ivec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.yxxyz swizzling.
        /// </summary>
        public ivec5 yxxyz => new ivec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.grrgb swizzling (equivalent to ivec3.yxxyz).
        /// </summary>
        public ivec5 grrgb => new ivec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.yxxz swizzling.
        /// </summary>
        public ivec4 yxxz => new ivec4(y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.grrb swizzling (equivalent to ivec3.yxxz).
        /// </summary>
        public ivec4 grrb => new ivec4(y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.yxxzx swizzling.
        /// </summary>
        public ivec5 yxxzx => new ivec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.grrbr swizzling (equivalent to ivec3.yxxzx).
        /// </summary>
        public ivec5 grrbr => new ivec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.yxxzy swizzling.
        /// </summary>
        public ivec5 yxxzy => new ivec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.grrbg swizzling (equivalent to ivec3.yxxzy).
        /// </summary>
        public ivec5 grrbg => new ivec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.yxxzz swizzling.
        /// </summary>
        public ivec5 yxxzz => new ivec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.grrbb swizzling (equivalent to ivec3.yxxzz).
        /// </summary>
        public ivec5 grrbb => new ivec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.yxy swizzling.
        /// </summary>
        public ivec3 yxy => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec3.grg swizzling (equivalent to ivec3.yxy).
        /// </summary>
        public ivec3 grg => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec3.yxyx swizzling.
        /// </summary>
        public ivec4 yxyx => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.grgr swizzling (equivalent to ivec3.yxyx).
        /// </summary>
        public ivec4 grgr => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.yxyxx swizzling.
        /// </summary>
        public ivec5 yxyxx => new ivec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.grgrr swizzling (equivalent to ivec3.yxyxx).
        /// </summary>
        public ivec5 grgrr => new ivec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.yxyxy swizzling.
        /// </summary>
        public ivec5 yxyxy => new ivec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.grgrg swizzling (equivalent to ivec3.yxyxy).
        /// </summary>
        public ivec5 grgrg => new ivec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.yxyxz swizzling.
        /// </summary>
        public ivec5 yxyxz => new ivec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.grgrb swizzling (equivalent to ivec3.yxyxz).
        /// </summary>
        public ivec5 grgrb => new ivec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.yxyy swizzling.
        /// </summary>
        public ivec4 yxyy => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.grgg swizzling (equivalent to ivec3.yxyy).
        /// </summary>
        public ivec4 grgg => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.yxyyx swizzling.
        /// </summary>
        public ivec5 yxyyx => new ivec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.grggr swizzling (equivalent to ivec3.yxyyx).
        /// </summary>
        public ivec5 grggr => new ivec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.yxyyy swizzling.
        /// </summary>
        public ivec5 yxyyy => new ivec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.grggg swizzling (equivalent to ivec3.yxyyy).
        /// </summary>
        public ivec5 grggg => new ivec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.yxyyz swizzling.
        /// </summary>
        public ivec5 yxyyz => new ivec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.grggb swizzling (equivalent to ivec3.yxyyz).
        /// </summary>
        public ivec5 grggb => new ivec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.yxyz swizzling.
        /// </summary>
        public ivec4 yxyz => new ivec4(y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.grgb swizzling (equivalent to ivec3.yxyz).
        /// </summary>
        public ivec4 grgb => new ivec4(y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.yxyzx swizzling.
        /// </summary>
        public ivec5 yxyzx => new ivec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.grgbr swizzling (equivalent to ivec3.yxyzx).
        /// </summary>
        public ivec5 grgbr => new ivec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.yxyzy swizzling.
        /// </summary>
        public ivec5 yxyzy => new ivec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.grgbg swizzling (equivalent to ivec3.yxyzy).
        /// </summary>
        public ivec5 grgbg => new ivec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.yxyzz swizzling.
        /// </summary>
        public ivec5 yxyzz => new ivec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.grgbb swizzling (equivalent to ivec3.yxyzz).
        /// </summary>
        public ivec5 grgbb => new ivec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.yxz swizzling.
        /// </summary>
        public ivec3 yxz => new ivec3(y, x, z);
        
        /// <summary>
        /// Returns ivec3.grb swizzling (equivalent to ivec3.yxz).
        /// </summary>
        public ivec3 grb => new ivec3(y, x, z);
        
        /// <summary>
        /// Returns ivec3.yxzx swizzling.
        /// </summary>
        public ivec4 yxzx => new ivec4(y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.grbr swizzling (equivalent to ivec3.yxzx).
        /// </summary>
        public ivec4 grbr => new ivec4(y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.yxzxx swizzling.
        /// </summary>
        public ivec5 yxzxx => new ivec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.grbrr swizzling (equivalent to ivec3.yxzxx).
        /// </summary>
        public ivec5 grbrr => new ivec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.yxzxy swizzling.
        /// </summary>
        public ivec5 yxzxy => new ivec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.grbrg swizzling (equivalent to ivec3.yxzxy).
        /// </summary>
        public ivec5 grbrg => new ivec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.yxzxz swizzling.
        /// </summary>
        public ivec5 yxzxz => new ivec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.grbrb swizzling (equivalent to ivec3.yxzxz).
        /// </summary>
        public ivec5 grbrb => new ivec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.yxzy swizzling.
        /// </summary>
        public ivec4 yxzy => new ivec4(y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.grbg swizzling (equivalent to ivec3.yxzy).
        /// </summary>
        public ivec4 grbg => new ivec4(y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.yxzyx swizzling.
        /// </summary>
        public ivec5 yxzyx => new ivec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.grbgr swizzling (equivalent to ivec3.yxzyx).
        /// </summary>
        public ivec5 grbgr => new ivec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.yxzyy swizzling.
        /// </summary>
        public ivec5 yxzyy => new ivec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.grbgg swizzling (equivalent to ivec3.yxzyy).
        /// </summary>
        public ivec5 grbgg => new ivec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.yxzyz swizzling.
        /// </summary>
        public ivec5 yxzyz => new ivec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.grbgb swizzling (equivalent to ivec3.yxzyz).
        /// </summary>
        public ivec5 grbgb => new ivec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.yxzz swizzling.
        /// </summary>
        public ivec4 yxzz => new ivec4(y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.grbb swizzling (equivalent to ivec3.yxzz).
        /// </summary>
        public ivec4 grbb => new ivec4(y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.yxzzx swizzling.
        /// </summary>
        public ivec5 yxzzx => new ivec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.grbbr swizzling (equivalent to ivec3.yxzzx).
        /// </summary>
        public ivec5 grbbr => new ivec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.yxzzy swizzling.
        /// </summary>
        public ivec5 yxzzy => new ivec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.grbbg swizzling (equivalent to ivec3.yxzzy).
        /// </summary>
        public ivec5 grbbg => new ivec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.yxzzz swizzling.
        /// </summary>
        public ivec5 yxzzz => new ivec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.grbbb swizzling (equivalent to ivec3.yxzzz).
        /// </summary>
        public ivec5 grbbb => new ivec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.yy swizzling.
        /// </summary>
        public ivec2 yy => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec3.gg swizzling (equivalent to ivec3.yy).
        /// </summary>
        public ivec2 gg => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec3.yyx swizzling.
        /// </summary>
        public ivec3 yyx => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec3.ggr swizzling (equivalent to ivec3.yyx).
        /// </summary>
        public ivec3 ggr => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec3.yyxx swizzling.
        /// </summary>
        public ivec4 yyxx => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.ggrr swizzling (equivalent to ivec3.yyxx).
        /// </summary>
        public ivec4 ggrr => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.yyxxx swizzling.
        /// </summary>
        public ivec5 yyxxx => new ivec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.ggrrr swizzling (equivalent to ivec3.yyxxx).
        /// </summary>
        public ivec5 ggrrr => new ivec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.yyxxy swizzling.
        /// </summary>
        public ivec5 yyxxy => new ivec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.ggrrg swizzling (equivalent to ivec3.yyxxy).
        /// </summary>
        public ivec5 ggrrg => new ivec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.yyxxz swizzling.
        /// </summary>
        public ivec5 yyxxz => new ivec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.ggrrb swizzling (equivalent to ivec3.yyxxz).
        /// </summary>
        public ivec5 ggrrb => new ivec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.yyxy swizzling.
        /// </summary>
        public ivec4 yyxy => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.ggrg swizzling (equivalent to ivec3.yyxy).
        /// </summary>
        public ivec4 ggrg => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.yyxyx swizzling.
        /// </summary>
        public ivec5 yyxyx => new ivec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.ggrgr swizzling (equivalent to ivec3.yyxyx).
        /// </summary>
        public ivec5 ggrgr => new ivec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.yyxyy swizzling.
        /// </summary>
        public ivec5 yyxyy => new ivec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.ggrgg swizzling (equivalent to ivec3.yyxyy).
        /// </summary>
        public ivec5 ggrgg => new ivec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.yyxyz swizzling.
        /// </summary>
        public ivec5 yyxyz => new ivec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.ggrgb swizzling (equivalent to ivec3.yyxyz).
        /// </summary>
        public ivec5 ggrgb => new ivec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.yyxz swizzling.
        /// </summary>
        public ivec4 yyxz => new ivec4(y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.ggrb swizzling (equivalent to ivec3.yyxz).
        /// </summary>
        public ivec4 ggrb => new ivec4(y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.yyxzx swizzling.
        /// </summary>
        public ivec5 yyxzx => new ivec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.ggrbr swizzling (equivalent to ivec3.yyxzx).
        /// </summary>
        public ivec5 ggrbr => new ivec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.yyxzy swizzling.
        /// </summary>
        public ivec5 yyxzy => new ivec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.ggrbg swizzling (equivalent to ivec3.yyxzy).
        /// </summary>
        public ivec5 ggrbg => new ivec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.yyxzz swizzling.
        /// </summary>
        public ivec5 yyxzz => new ivec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.ggrbb swizzling (equivalent to ivec3.yyxzz).
        /// </summary>
        public ivec5 ggrbb => new ivec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.yyy swizzling.
        /// </summary>
        public ivec3 yyy => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec3.ggg swizzling (equivalent to ivec3.yyy).
        /// </summary>
        public ivec3 ggg => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec3.yyyx swizzling.
        /// </summary>
        public ivec4 yyyx => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.gggr swizzling (equivalent to ivec3.yyyx).
        /// </summary>
        public ivec4 gggr => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.yyyxx swizzling.
        /// </summary>
        public ivec5 yyyxx => new ivec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.gggrr swizzling (equivalent to ivec3.yyyxx).
        /// </summary>
        public ivec5 gggrr => new ivec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.yyyxy swizzling.
        /// </summary>
        public ivec5 yyyxy => new ivec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.gggrg swizzling (equivalent to ivec3.yyyxy).
        /// </summary>
        public ivec5 gggrg => new ivec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.yyyxz swizzling.
        /// </summary>
        public ivec5 yyyxz => new ivec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.gggrb swizzling (equivalent to ivec3.yyyxz).
        /// </summary>
        public ivec5 gggrb => new ivec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.yyyy swizzling.
        /// </summary>
        public ivec4 yyyy => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.gggg swizzling (equivalent to ivec3.yyyy).
        /// </summary>
        public ivec4 gggg => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.yyyyx swizzling.
        /// </summary>
        public ivec5 yyyyx => new ivec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.ggggr swizzling (equivalent to ivec3.yyyyx).
        /// </summary>
        public ivec5 ggggr => new ivec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.yyyyy swizzling.
        /// </summary>
        public ivec5 yyyyy => new ivec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.ggggg swizzling (equivalent to ivec3.yyyyy).
        /// </summary>
        public ivec5 ggggg => new ivec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.yyyyz swizzling.
        /// </summary>
        public ivec5 yyyyz => new ivec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.ggggb swizzling (equivalent to ivec3.yyyyz).
        /// </summary>
        public ivec5 ggggb => new ivec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.yyyz swizzling.
        /// </summary>
        public ivec4 yyyz => new ivec4(y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.gggb swizzling (equivalent to ivec3.yyyz).
        /// </summary>
        public ivec4 gggb => new ivec4(y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.yyyzx swizzling.
        /// </summary>
        public ivec5 yyyzx => new ivec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.gggbr swizzling (equivalent to ivec3.yyyzx).
        /// </summary>
        public ivec5 gggbr => new ivec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.yyyzy swizzling.
        /// </summary>
        public ivec5 yyyzy => new ivec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.gggbg swizzling (equivalent to ivec3.yyyzy).
        /// </summary>
        public ivec5 gggbg => new ivec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.yyyzz swizzling.
        /// </summary>
        public ivec5 yyyzz => new ivec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.gggbb swizzling (equivalent to ivec3.yyyzz).
        /// </summary>
        public ivec5 gggbb => new ivec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.yyz swizzling.
        /// </summary>
        public ivec3 yyz => new ivec3(y, y, z);
        
        /// <summary>
        /// Returns ivec3.ggb swizzling (equivalent to ivec3.yyz).
        /// </summary>
        public ivec3 ggb => new ivec3(y, y, z);
        
        /// <summary>
        /// Returns ivec3.yyzx swizzling.
        /// </summary>
        public ivec4 yyzx => new ivec4(y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.ggbr swizzling (equivalent to ivec3.yyzx).
        /// </summary>
        public ivec4 ggbr => new ivec4(y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.yyzxx swizzling.
        /// </summary>
        public ivec5 yyzxx => new ivec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.ggbrr swizzling (equivalent to ivec3.yyzxx).
        /// </summary>
        public ivec5 ggbrr => new ivec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.yyzxy swizzling.
        /// </summary>
        public ivec5 yyzxy => new ivec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.ggbrg swizzling (equivalent to ivec3.yyzxy).
        /// </summary>
        public ivec5 ggbrg => new ivec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.yyzxz swizzling.
        /// </summary>
        public ivec5 yyzxz => new ivec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.ggbrb swizzling (equivalent to ivec3.yyzxz).
        /// </summary>
        public ivec5 ggbrb => new ivec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.yyzy swizzling.
        /// </summary>
        public ivec4 yyzy => new ivec4(y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.ggbg swizzling (equivalent to ivec3.yyzy).
        /// </summary>
        public ivec4 ggbg => new ivec4(y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.yyzyx swizzling.
        /// </summary>
        public ivec5 yyzyx => new ivec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.ggbgr swizzling (equivalent to ivec3.yyzyx).
        /// </summary>
        public ivec5 ggbgr => new ivec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.yyzyy swizzling.
        /// </summary>
        public ivec5 yyzyy => new ivec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.ggbgg swizzling (equivalent to ivec3.yyzyy).
        /// </summary>
        public ivec5 ggbgg => new ivec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.yyzyz swizzling.
        /// </summary>
        public ivec5 yyzyz => new ivec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.ggbgb swizzling (equivalent to ivec3.yyzyz).
        /// </summary>
        public ivec5 ggbgb => new ivec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.yyzz swizzling.
        /// </summary>
        public ivec4 yyzz => new ivec4(y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.ggbb swizzling (equivalent to ivec3.yyzz).
        /// </summary>
        public ivec4 ggbb => new ivec4(y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.yyzzx swizzling.
        /// </summary>
        public ivec5 yyzzx => new ivec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.ggbbr swizzling (equivalent to ivec3.yyzzx).
        /// </summary>
        public ivec5 ggbbr => new ivec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.yyzzy swizzling.
        /// </summary>
        public ivec5 yyzzy => new ivec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.ggbbg swizzling (equivalent to ivec3.yyzzy).
        /// </summary>
        public ivec5 ggbbg => new ivec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.yyzzz swizzling.
        /// </summary>
        public ivec5 yyzzz => new ivec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.ggbbb swizzling (equivalent to ivec3.yyzzz).
        /// </summary>
        public ivec5 ggbbb => new ivec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.yz swizzling.
        /// </summary>
        public ivec2 yz => new ivec2(y, z);
        
        /// <summary>
        /// Returns ivec3.gb swizzling (equivalent to ivec3.yz).
        /// </summary>
        public ivec2 gb => new ivec2(y, z);
        
        /// <summary>
        /// Returns ivec3.yzx swizzling.
        /// </summary>
        public ivec3 yzx => new ivec3(y, z, x);
        
        /// <summary>
        /// Returns ivec3.gbr swizzling (equivalent to ivec3.yzx).
        /// </summary>
        public ivec3 gbr => new ivec3(y, z, x);
        
        /// <summary>
        /// Returns ivec3.yzxx swizzling.
        /// </summary>
        public ivec4 yzxx => new ivec4(y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.gbrr swizzling (equivalent to ivec3.yzxx).
        /// </summary>
        public ivec4 gbrr => new ivec4(y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.yzxxx swizzling.
        /// </summary>
        public ivec5 yzxxx => new ivec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.gbrrr swizzling (equivalent to ivec3.yzxxx).
        /// </summary>
        public ivec5 gbrrr => new ivec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.yzxxy swizzling.
        /// </summary>
        public ivec5 yzxxy => new ivec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.gbrrg swizzling (equivalent to ivec3.yzxxy).
        /// </summary>
        public ivec5 gbrrg => new ivec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.yzxxz swizzling.
        /// </summary>
        public ivec5 yzxxz => new ivec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.gbrrb swizzling (equivalent to ivec3.yzxxz).
        /// </summary>
        public ivec5 gbrrb => new ivec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.yzxy swizzling.
        /// </summary>
        public ivec4 yzxy => new ivec4(y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.gbrg swizzling (equivalent to ivec3.yzxy).
        /// </summary>
        public ivec4 gbrg => new ivec4(y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.yzxyx swizzling.
        /// </summary>
        public ivec5 yzxyx => new ivec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.gbrgr swizzling (equivalent to ivec3.yzxyx).
        /// </summary>
        public ivec5 gbrgr => new ivec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.yzxyy swizzling.
        /// </summary>
        public ivec5 yzxyy => new ivec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.gbrgg swizzling (equivalent to ivec3.yzxyy).
        /// </summary>
        public ivec5 gbrgg => new ivec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.yzxyz swizzling.
        /// </summary>
        public ivec5 yzxyz => new ivec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.gbrgb swizzling (equivalent to ivec3.yzxyz).
        /// </summary>
        public ivec5 gbrgb => new ivec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.yzxz swizzling.
        /// </summary>
        public ivec4 yzxz => new ivec4(y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.gbrb swizzling (equivalent to ivec3.yzxz).
        /// </summary>
        public ivec4 gbrb => new ivec4(y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.yzxzx swizzling.
        /// </summary>
        public ivec5 yzxzx => new ivec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.gbrbr swizzling (equivalent to ivec3.yzxzx).
        /// </summary>
        public ivec5 gbrbr => new ivec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.yzxzy swizzling.
        /// </summary>
        public ivec5 yzxzy => new ivec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.gbrbg swizzling (equivalent to ivec3.yzxzy).
        /// </summary>
        public ivec5 gbrbg => new ivec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.yzxzz swizzling.
        /// </summary>
        public ivec5 yzxzz => new ivec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.gbrbb swizzling (equivalent to ivec3.yzxzz).
        /// </summary>
        public ivec5 gbrbb => new ivec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.yzy swizzling.
        /// </summary>
        public ivec3 yzy => new ivec3(y, z, y);
        
        /// <summary>
        /// Returns ivec3.gbg swizzling (equivalent to ivec3.yzy).
        /// </summary>
        public ivec3 gbg => new ivec3(y, z, y);
        
        /// <summary>
        /// Returns ivec3.yzyx swizzling.
        /// </summary>
        public ivec4 yzyx => new ivec4(y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.gbgr swizzling (equivalent to ivec3.yzyx).
        /// </summary>
        public ivec4 gbgr => new ivec4(y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.yzyxx swizzling.
        /// </summary>
        public ivec5 yzyxx => new ivec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.gbgrr swizzling (equivalent to ivec3.yzyxx).
        /// </summary>
        public ivec5 gbgrr => new ivec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.yzyxy swizzling.
        /// </summary>
        public ivec5 yzyxy => new ivec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.gbgrg swizzling (equivalent to ivec3.yzyxy).
        /// </summary>
        public ivec5 gbgrg => new ivec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.yzyxz swizzling.
        /// </summary>
        public ivec5 yzyxz => new ivec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.gbgrb swizzling (equivalent to ivec3.yzyxz).
        /// </summary>
        public ivec5 gbgrb => new ivec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.yzyy swizzling.
        /// </summary>
        public ivec4 yzyy => new ivec4(y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.gbgg swizzling (equivalent to ivec3.yzyy).
        /// </summary>
        public ivec4 gbgg => new ivec4(y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.yzyyx swizzling.
        /// </summary>
        public ivec5 yzyyx => new ivec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.gbggr swizzling (equivalent to ivec3.yzyyx).
        /// </summary>
        public ivec5 gbggr => new ivec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.yzyyy swizzling.
        /// </summary>
        public ivec5 yzyyy => new ivec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.gbggg swizzling (equivalent to ivec3.yzyyy).
        /// </summary>
        public ivec5 gbggg => new ivec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.yzyyz swizzling.
        /// </summary>
        public ivec5 yzyyz => new ivec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.gbggb swizzling (equivalent to ivec3.yzyyz).
        /// </summary>
        public ivec5 gbggb => new ivec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.yzyz swizzling.
        /// </summary>
        public ivec4 yzyz => new ivec4(y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.gbgb swizzling (equivalent to ivec3.yzyz).
        /// </summary>
        public ivec4 gbgb => new ivec4(y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.yzyzx swizzling.
        /// </summary>
        public ivec5 yzyzx => new ivec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.gbgbr swizzling (equivalent to ivec3.yzyzx).
        /// </summary>
        public ivec5 gbgbr => new ivec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.yzyzy swizzling.
        /// </summary>
        public ivec5 yzyzy => new ivec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.gbgbg swizzling (equivalent to ivec3.yzyzy).
        /// </summary>
        public ivec5 gbgbg => new ivec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.yzyzz swizzling.
        /// </summary>
        public ivec5 yzyzz => new ivec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.gbgbb swizzling (equivalent to ivec3.yzyzz).
        /// </summary>
        public ivec5 gbgbb => new ivec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.yzz swizzling.
        /// </summary>
        public ivec3 yzz => new ivec3(y, z, z);
        
        /// <summary>
        /// Returns ivec3.gbb swizzling (equivalent to ivec3.yzz).
        /// </summary>
        public ivec3 gbb => new ivec3(y, z, z);
        
        /// <summary>
        /// Returns ivec3.yzzx swizzling.
        /// </summary>
        public ivec4 yzzx => new ivec4(y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.gbbr swizzling (equivalent to ivec3.yzzx).
        /// </summary>
        public ivec4 gbbr => new ivec4(y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.yzzxx swizzling.
        /// </summary>
        public ivec5 yzzxx => new ivec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.gbbrr swizzling (equivalent to ivec3.yzzxx).
        /// </summary>
        public ivec5 gbbrr => new ivec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.yzzxy swizzling.
        /// </summary>
        public ivec5 yzzxy => new ivec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.gbbrg swizzling (equivalent to ivec3.yzzxy).
        /// </summary>
        public ivec5 gbbrg => new ivec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.yzzxz swizzling.
        /// </summary>
        public ivec5 yzzxz => new ivec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.gbbrb swizzling (equivalent to ivec3.yzzxz).
        /// </summary>
        public ivec5 gbbrb => new ivec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.yzzy swizzling.
        /// </summary>
        public ivec4 yzzy => new ivec4(y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.gbbg swizzling (equivalent to ivec3.yzzy).
        /// </summary>
        public ivec4 gbbg => new ivec4(y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.yzzyx swizzling.
        /// </summary>
        public ivec5 yzzyx => new ivec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.gbbgr swizzling (equivalent to ivec3.yzzyx).
        /// </summary>
        public ivec5 gbbgr => new ivec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.yzzyy swizzling.
        /// </summary>
        public ivec5 yzzyy => new ivec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.gbbgg swizzling (equivalent to ivec3.yzzyy).
        /// </summary>
        public ivec5 gbbgg => new ivec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.yzzyz swizzling.
        /// </summary>
        public ivec5 yzzyz => new ivec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.gbbgb swizzling (equivalent to ivec3.yzzyz).
        /// </summary>
        public ivec5 gbbgb => new ivec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.yzzz swizzling.
        /// </summary>
        public ivec4 yzzz => new ivec4(y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.gbbb swizzling (equivalent to ivec3.yzzz).
        /// </summary>
        public ivec4 gbbb => new ivec4(y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.yzzzx swizzling.
        /// </summary>
        public ivec5 yzzzx => new ivec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.gbbbr swizzling (equivalent to ivec3.yzzzx).
        /// </summary>
        public ivec5 gbbbr => new ivec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.yzzzy swizzling.
        /// </summary>
        public ivec5 yzzzy => new ivec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.gbbbg swizzling (equivalent to ivec3.yzzzy).
        /// </summary>
        public ivec5 gbbbg => new ivec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.yzzzz swizzling.
        /// </summary>
        public ivec5 yzzzz => new ivec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns ivec3.gbbbb swizzling (equivalent to ivec3.yzzzz).
        /// </summary>
        public ivec5 gbbbb => new ivec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns ivec3.zx swizzling.
        /// </summary>
        public ivec2 zx => new ivec2(z, x);
        
        /// <summary>
        /// Returns ivec3.br swizzling (equivalent to ivec3.zx).
        /// </summary>
        public ivec2 br => new ivec2(z, x);
        
        /// <summary>
        /// Returns ivec3.zxx swizzling.
        /// </summary>
        public ivec3 zxx => new ivec3(z, x, x);
        
        /// <summary>
        /// Returns ivec3.brr swizzling (equivalent to ivec3.zxx).
        /// </summary>
        public ivec3 brr => new ivec3(z, x, x);
        
        /// <summary>
        /// Returns ivec3.zxxx swizzling.
        /// </summary>
        public ivec4 zxxx => new ivec4(z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.brrr swizzling (equivalent to ivec3.zxxx).
        /// </summary>
        public ivec4 brrr => new ivec4(z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.zxxxx swizzling.
        /// </summary>
        public ivec5 zxxxx => new ivec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.brrrr swizzling (equivalent to ivec3.zxxxx).
        /// </summary>
        public ivec5 brrrr => new ivec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.zxxxy swizzling.
        /// </summary>
        public ivec5 zxxxy => new ivec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.brrrg swizzling (equivalent to ivec3.zxxxy).
        /// </summary>
        public ivec5 brrrg => new ivec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.zxxxz swizzling.
        /// </summary>
        public ivec5 zxxxz => new ivec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.brrrb swizzling (equivalent to ivec3.zxxxz).
        /// </summary>
        public ivec5 brrrb => new ivec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.zxxy swizzling.
        /// </summary>
        public ivec4 zxxy => new ivec4(z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.brrg swizzling (equivalent to ivec3.zxxy).
        /// </summary>
        public ivec4 brrg => new ivec4(z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.zxxyx swizzling.
        /// </summary>
        public ivec5 zxxyx => new ivec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.brrgr swizzling (equivalent to ivec3.zxxyx).
        /// </summary>
        public ivec5 brrgr => new ivec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.zxxyy swizzling.
        /// </summary>
        public ivec5 zxxyy => new ivec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.brrgg swizzling (equivalent to ivec3.zxxyy).
        /// </summary>
        public ivec5 brrgg => new ivec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.zxxyz swizzling.
        /// </summary>
        public ivec5 zxxyz => new ivec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.brrgb swizzling (equivalent to ivec3.zxxyz).
        /// </summary>
        public ivec5 brrgb => new ivec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.zxxz swizzling.
        /// </summary>
        public ivec4 zxxz => new ivec4(z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.brrb swizzling (equivalent to ivec3.zxxz).
        /// </summary>
        public ivec4 brrb => new ivec4(z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.zxxzx swizzling.
        /// </summary>
        public ivec5 zxxzx => new ivec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.brrbr swizzling (equivalent to ivec3.zxxzx).
        /// </summary>
        public ivec5 brrbr => new ivec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.zxxzy swizzling.
        /// </summary>
        public ivec5 zxxzy => new ivec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.brrbg swizzling (equivalent to ivec3.zxxzy).
        /// </summary>
        public ivec5 brrbg => new ivec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.zxxzz swizzling.
        /// </summary>
        public ivec5 zxxzz => new ivec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.brrbb swizzling (equivalent to ivec3.zxxzz).
        /// </summary>
        public ivec5 brrbb => new ivec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.zxy swizzling.
        /// </summary>
        public ivec3 zxy => new ivec3(z, x, y);
        
        /// <summary>
        /// Returns ivec3.brg swizzling (equivalent to ivec3.zxy).
        /// </summary>
        public ivec3 brg => new ivec3(z, x, y);
        
        /// <summary>
        /// Returns ivec3.zxyx swizzling.
        /// </summary>
        public ivec4 zxyx => new ivec4(z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.brgr swizzling (equivalent to ivec3.zxyx).
        /// </summary>
        public ivec4 brgr => new ivec4(z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.zxyxx swizzling.
        /// </summary>
        public ivec5 zxyxx => new ivec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.brgrr swizzling (equivalent to ivec3.zxyxx).
        /// </summary>
        public ivec5 brgrr => new ivec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.zxyxy swizzling.
        /// </summary>
        public ivec5 zxyxy => new ivec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.brgrg swizzling (equivalent to ivec3.zxyxy).
        /// </summary>
        public ivec5 brgrg => new ivec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.zxyxz swizzling.
        /// </summary>
        public ivec5 zxyxz => new ivec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.brgrb swizzling (equivalent to ivec3.zxyxz).
        /// </summary>
        public ivec5 brgrb => new ivec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.zxyy swizzling.
        /// </summary>
        public ivec4 zxyy => new ivec4(z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.brgg swizzling (equivalent to ivec3.zxyy).
        /// </summary>
        public ivec4 brgg => new ivec4(z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.zxyyx swizzling.
        /// </summary>
        public ivec5 zxyyx => new ivec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.brggr swizzling (equivalent to ivec3.zxyyx).
        /// </summary>
        public ivec5 brggr => new ivec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.zxyyy swizzling.
        /// </summary>
        public ivec5 zxyyy => new ivec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.brggg swizzling (equivalent to ivec3.zxyyy).
        /// </summary>
        public ivec5 brggg => new ivec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.zxyyz swizzling.
        /// </summary>
        public ivec5 zxyyz => new ivec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.brggb swizzling (equivalent to ivec3.zxyyz).
        /// </summary>
        public ivec5 brggb => new ivec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.zxyz swizzling.
        /// </summary>
        public ivec4 zxyz => new ivec4(z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.brgb swizzling (equivalent to ivec3.zxyz).
        /// </summary>
        public ivec4 brgb => new ivec4(z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.zxyzx swizzling.
        /// </summary>
        public ivec5 zxyzx => new ivec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.brgbr swizzling (equivalent to ivec3.zxyzx).
        /// </summary>
        public ivec5 brgbr => new ivec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.zxyzy swizzling.
        /// </summary>
        public ivec5 zxyzy => new ivec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.brgbg swizzling (equivalent to ivec3.zxyzy).
        /// </summary>
        public ivec5 brgbg => new ivec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.zxyzz swizzling.
        /// </summary>
        public ivec5 zxyzz => new ivec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.brgbb swizzling (equivalent to ivec3.zxyzz).
        /// </summary>
        public ivec5 brgbb => new ivec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.zxz swizzling.
        /// </summary>
        public ivec3 zxz => new ivec3(z, x, z);
        
        /// <summary>
        /// Returns ivec3.brb swizzling (equivalent to ivec3.zxz).
        /// </summary>
        public ivec3 brb => new ivec3(z, x, z);
        
        /// <summary>
        /// Returns ivec3.zxzx swizzling.
        /// </summary>
        public ivec4 zxzx => new ivec4(z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.brbr swizzling (equivalent to ivec3.zxzx).
        /// </summary>
        public ivec4 brbr => new ivec4(z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.zxzxx swizzling.
        /// </summary>
        public ivec5 zxzxx => new ivec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.brbrr swizzling (equivalent to ivec3.zxzxx).
        /// </summary>
        public ivec5 brbrr => new ivec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.zxzxy swizzling.
        /// </summary>
        public ivec5 zxzxy => new ivec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.brbrg swizzling (equivalent to ivec3.zxzxy).
        /// </summary>
        public ivec5 brbrg => new ivec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.zxzxz swizzling.
        /// </summary>
        public ivec5 zxzxz => new ivec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.brbrb swizzling (equivalent to ivec3.zxzxz).
        /// </summary>
        public ivec5 brbrb => new ivec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.zxzy swizzling.
        /// </summary>
        public ivec4 zxzy => new ivec4(z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.brbg swizzling (equivalent to ivec3.zxzy).
        /// </summary>
        public ivec4 brbg => new ivec4(z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.zxzyx swizzling.
        /// </summary>
        public ivec5 zxzyx => new ivec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.brbgr swizzling (equivalent to ivec3.zxzyx).
        /// </summary>
        public ivec5 brbgr => new ivec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.zxzyy swizzling.
        /// </summary>
        public ivec5 zxzyy => new ivec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.brbgg swizzling (equivalent to ivec3.zxzyy).
        /// </summary>
        public ivec5 brbgg => new ivec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.zxzyz swizzling.
        /// </summary>
        public ivec5 zxzyz => new ivec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.brbgb swizzling (equivalent to ivec3.zxzyz).
        /// </summary>
        public ivec5 brbgb => new ivec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.zxzz swizzling.
        /// </summary>
        public ivec4 zxzz => new ivec4(z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.brbb swizzling (equivalent to ivec3.zxzz).
        /// </summary>
        public ivec4 brbb => new ivec4(z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.zxzzx swizzling.
        /// </summary>
        public ivec5 zxzzx => new ivec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.brbbr swizzling (equivalent to ivec3.zxzzx).
        /// </summary>
        public ivec5 brbbr => new ivec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.zxzzy swizzling.
        /// </summary>
        public ivec5 zxzzy => new ivec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.brbbg swizzling (equivalent to ivec3.zxzzy).
        /// </summary>
        public ivec5 brbbg => new ivec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.zxzzz swizzling.
        /// </summary>
        public ivec5 zxzzz => new ivec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.brbbb swizzling (equivalent to ivec3.zxzzz).
        /// </summary>
        public ivec5 brbbb => new ivec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.zy swizzling.
        /// </summary>
        public ivec2 zy => new ivec2(z, y);
        
        /// <summary>
        /// Returns ivec3.bg swizzling (equivalent to ivec3.zy).
        /// </summary>
        public ivec2 bg => new ivec2(z, y);
        
        /// <summary>
        /// Returns ivec3.zyx swizzling.
        /// </summary>
        public ivec3 zyx => new ivec3(z, y, x);
        
        /// <summary>
        /// Returns ivec3.bgr swizzling (equivalent to ivec3.zyx).
        /// </summary>
        public ivec3 bgr => new ivec3(z, y, x);
        
        /// <summary>
        /// Returns ivec3.zyxx swizzling.
        /// </summary>
        public ivec4 zyxx => new ivec4(z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.bgrr swizzling (equivalent to ivec3.zyxx).
        /// </summary>
        public ivec4 bgrr => new ivec4(z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.zyxxx swizzling.
        /// </summary>
        public ivec5 zyxxx => new ivec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.bgrrr swizzling (equivalent to ivec3.zyxxx).
        /// </summary>
        public ivec5 bgrrr => new ivec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.zyxxy swizzling.
        /// </summary>
        public ivec5 zyxxy => new ivec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.bgrrg swizzling (equivalent to ivec3.zyxxy).
        /// </summary>
        public ivec5 bgrrg => new ivec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.zyxxz swizzling.
        /// </summary>
        public ivec5 zyxxz => new ivec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.bgrrb swizzling (equivalent to ivec3.zyxxz).
        /// </summary>
        public ivec5 bgrrb => new ivec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.zyxy swizzling.
        /// </summary>
        public ivec4 zyxy => new ivec4(z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.bgrg swizzling (equivalent to ivec3.zyxy).
        /// </summary>
        public ivec4 bgrg => new ivec4(z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.zyxyx swizzling.
        /// </summary>
        public ivec5 zyxyx => new ivec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.bgrgr swizzling (equivalent to ivec3.zyxyx).
        /// </summary>
        public ivec5 bgrgr => new ivec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.zyxyy swizzling.
        /// </summary>
        public ivec5 zyxyy => new ivec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.bgrgg swizzling (equivalent to ivec3.zyxyy).
        /// </summary>
        public ivec5 bgrgg => new ivec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.zyxyz swizzling.
        /// </summary>
        public ivec5 zyxyz => new ivec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.bgrgb swizzling (equivalent to ivec3.zyxyz).
        /// </summary>
        public ivec5 bgrgb => new ivec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.zyxz swizzling.
        /// </summary>
        public ivec4 zyxz => new ivec4(z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.bgrb swizzling (equivalent to ivec3.zyxz).
        /// </summary>
        public ivec4 bgrb => new ivec4(z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.zyxzx swizzling.
        /// </summary>
        public ivec5 zyxzx => new ivec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.bgrbr swizzling (equivalent to ivec3.zyxzx).
        /// </summary>
        public ivec5 bgrbr => new ivec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.zyxzy swizzling.
        /// </summary>
        public ivec5 zyxzy => new ivec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.bgrbg swizzling (equivalent to ivec3.zyxzy).
        /// </summary>
        public ivec5 bgrbg => new ivec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.zyxzz swizzling.
        /// </summary>
        public ivec5 zyxzz => new ivec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.bgrbb swizzling (equivalent to ivec3.zyxzz).
        /// </summary>
        public ivec5 bgrbb => new ivec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.zyy swizzling.
        /// </summary>
        public ivec3 zyy => new ivec3(z, y, y);
        
        /// <summary>
        /// Returns ivec3.bgg swizzling (equivalent to ivec3.zyy).
        /// </summary>
        public ivec3 bgg => new ivec3(z, y, y);
        
        /// <summary>
        /// Returns ivec3.zyyx swizzling.
        /// </summary>
        public ivec4 zyyx => new ivec4(z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.bggr swizzling (equivalent to ivec3.zyyx).
        /// </summary>
        public ivec4 bggr => new ivec4(z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.zyyxx swizzling.
        /// </summary>
        public ivec5 zyyxx => new ivec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.bggrr swizzling (equivalent to ivec3.zyyxx).
        /// </summary>
        public ivec5 bggrr => new ivec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.zyyxy swizzling.
        /// </summary>
        public ivec5 zyyxy => new ivec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.bggrg swizzling (equivalent to ivec3.zyyxy).
        /// </summary>
        public ivec5 bggrg => new ivec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.zyyxz swizzling.
        /// </summary>
        public ivec5 zyyxz => new ivec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.bggrb swizzling (equivalent to ivec3.zyyxz).
        /// </summary>
        public ivec5 bggrb => new ivec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.zyyy swizzling.
        /// </summary>
        public ivec4 zyyy => new ivec4(z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.bggg swizzling (equivalent to ivec3.zyyy).
        /// </summary>
        public ivec4 bggg => new ivec4(z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.zyyyx swizzling.
        /// </summary>
        public ivec5 zyyyx => new ivec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.bgggr swizzling (equivalent to ivec3.zyyyx).
        /// </summary>
        public ivec5 bgggr => new ivec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.zyyyy swizzling.
        /// </summary>
        public ivec5 zyyyy => new ivec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.bgggg swizzling (equivalent to ivec3.zyyyy).
        /// </summary>
        public ivec5 bgggg => new ivec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.zyyyz swizzling.
        /// </summary>
        public ivec5 zyyyz => new ivec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.bgggb swizzling (equivalent to ivec3.zyyyz).
        /// </summary>
        public ivec5 bgggb => new ivec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.zyyz swizzling.
        /// </summary>
        public ivec4 zyyz => new ivec4(z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.bggb swizzling (equivalent to ivec3.zyyz).
        /// </summary>
        public ivec4 bggb => new ivec4(z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.zyyzx swizzling.
        /// </summary>
        public ivec5 zyyzx => new ivec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.bggbr swizzling (equivalent to ivec3.zyyzx).
        /// </summary>
        public ivec5 bggbr => new ivec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.zyyzy swizzling.
        /// </summary>
        public ivec5 zyyzy => new ivec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.bggbg swizzling (equivalent to ivec3.zyyzy).
        /// </summary>
        public ivec5 bggbg => new ivec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.zyyzz swizzling.
        /// </summary>
        public ivec5 zyyzz => new ivec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.bggbb swizzling (equivalent to ivec3.zyyzz).
        /// </summary>
        public ivec5 bggbb => new ivec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.zyz swizzling.
        /// </summary>
        public ivec3 zyz => new ivec3(z, y, z);
        
        /// <summary>
        /// Returns ivec3.bgb swizzling (equivalent to ivec3.zyz).
        /// </summary>
        public ivec3 bgb => new ivec3(z, y, z);
        
        /// <summary>
        /// Returns ivec3.zyzx swizzling.
        /// </summary>
        public ivec4 zyzx => new ivec4(z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.bgbr swizzling (equivalent to ivec3.zyzx).
        /// </summary>
        public ivec4 bgbr => new ivec4(z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.zyzxx swizzling.
        /// </summary>
        public ivec5 zyzxx => new ivec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.bgbrr swizzling (equivalent to ivec3.zyzxx).
        /// </summary>
        public ivec5 bgbrr => new ivec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.zyzxy swizzling.
        /// </summary>
        public ivec5 zyzxy => new ivec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.bgbrg swizzling (equivalent to ivec3.zyzxy).
        /// </summary>
        public ivec5 bgbrg => new ivec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.zyzxz swizzling.
        /// </summary>
        public ivec5 zyzxz => new ivec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.bgbrb swizzling (equivalent to ivec3.zyzxz).
        /// </summary>
        public ivec5 bgbrb => new ivec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.zyzy swizzling.
        /// </summary>
        public ivec4 zyzy => new ivec4(z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.bgbg swizzling (equivalent to ivec3.zyzy).
        /// </summary>
        public ivec4 bgbg => new ivec4(z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.zyzyx swizzling.
        /// </summary>
        public ivec5 zyzyx => new ivec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.bgbgr swizzling (equivalent to ivec3.zyzyx).
        /// </summary>
        public ivec5 bgbgr => new ivec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.zyzyy swizzling.
        /// </summary>
        public ivec5 zyzyy => new ivec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.bgbgg swizzling (equivalent to ivec3.zyzyy).
        /// </summary>
        public ivec5 bgbgg => new ivec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.zyzyz swizzling.
        /// </summary>
        public ivec5 zyzyz => new ivec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.bgbgb swizzling (equivalent to ivec3.zyzyz).
        /// </summary>
        public ivec5 bgbgb => new ivec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.zyzz swizzling.
        /// </summary>
        public ivec4 zyzz => new ivec4(z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.bgbb swizzling (equivalent to ivec3.zyzz).
        /// </summary>
        public ivec4 bgbb => new ivec4(z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.zyzzx swizzling.
        /// </summary>
        public ivec5 zyzzx => new ivec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.bgbbr swizzling (equivalent to ivec3.zyzzx).
        /// </summary>
        public ivec5 bgbbr => new ivec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.zyzzy swizzling.
        /// </summary>
        public ivec5 zyzzy => new ivec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.bgbbg swizzling (equivalent to ivec3.zyzzy).
        /// </summary>
        public ivec5 bgbbg => new ivec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.zyzzz swizzling.
        /// </summary>
        public ivec5 zyzzz => new ivec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.bgbbb swizzling (equivalent to ivec3.zyzzz).
        /// </summary>
        public ivec5 bgbbb => new ivec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.zz swizzling.
        /// </summary>
        public ivec2 zz => new ivec2(z, z);
        
        /// <summary>
        /// Returns ivec3.bb swizzling (equivalent to ivec3.zz).
        /// </summary>
        public ivec2 bb => new ivec2(z, z);
        
        /// <summary>
        /// Returns ivec3.zzx swizzling.
        /// </summary>
        public ivec3 zzx => new ivec3(z, z, x);
        
        /// <summary>
        /// Returns ivec3.bbr swizzling (equivalent to ivec3.zzx).
        /// </summary>
        public ivec3 bbr => new ivec3(z, z, x);
        
        /// <summary>
        /// Returns ivec3.zzxx swizzling.
        /// </summary>
        public ivec4 zzxx => new ivec4(z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.bbrr swizzling (equivalent to ivec3.zzxx).
        /// </summary>
        public ivec4 bbrr => new ivec4(z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.zzxxx swizzling.
        /// </summary>
        public ivec5 zzxxx => new ivec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.bbrrr swizzling (equivalent to ivec3.zzxxx).
        /// </summary>
        public ivec5 bbrrr => new ivec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.zzxxy swizzling.
        /// </summary>
        public ivec5 zzxxy => new ivec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.bbrrg swizzling (equivalent to ivec3.zzxxy).
        /// </summary>
        public ivec5 bbrrg => new ivec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.zzxxz swizzling.
        /// </summary>
        public ivec5 zzxxz => new ivec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.bbrrb swizzling (equivalent to ivec3.zzxxz).
        /// </summary>
        public ivec5 bbrrb => new ivec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.zzxy swizzling.
        /// </summary>
        public ivec4 zzxy => new ivec4(z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.bbrg swizzling (equivalent to ivec3.zzxy).
        /// </summary>
        public ivec4 bbrg => new ivec4(z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.zzxyx swizzling.
        /// </summary>
        public ivec5 zzxyx => new ivec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.bbrgr swizzling (equivalent to ivec3.zzxyx).
        /// </summary>
        public ivec5 bbrgr => new ivec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.zzxyy swizzling.
        /// </summary>
        public ivec5 zzxyy => new ivec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.bbrgg swizzling (equivalent to ivec3.zzxyy).
        /// </summary>
        public ivec5 bbrgg => new ivec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.zzxyz swizzling.
        /// </summary>
        public ivec5 zzxyz => new ivec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.bbrgb swizzling (equivalent to ivec3.zzxyz).
        /// </summary>
        public ivec5 bbrgb => new ivec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.zzxz swizzling.
        /// </summary>
        public ivec4 zzxz => new ivec4(z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.bbrb swizzling (equivalent to ivec3.zzxz).
        /// </summary>
        public ivec4 bbrb => new ivec4(z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.zzxzx swizzling.
        /// </summary>
        public ivec5 zzxzx => new ivec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.bbrbr swizzling (equivalent to ivec3.zzxzx).
        /// </summary>
        public ivec5 bbrbr => new ivec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.zzxzy swizzling.
        /// </summary>
        public ivec5 zzxzy => new ivec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.bbrbg swizzling (equivalent to ivec3.zzxzy).
        /// </summary>
        public ivec5 bbrbg => new ivec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.zzxzz swizzling.
        /// </summary>
        public ivec5 zzxzz => new ivec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.bbrbb swizzling (equivalent to ivec3.zzxzz).
        /// </summary>
        public ivec5 bbrbb => new ivec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.zzy swizzling.
        /// </summary>
        public ivec3 zzy => new ivec3(z, z, y);
        
        /// <summary>
        /// Returns ivec3.bbg swizzling (equivalent to ivec3.zzy).
        /// </summary>
        public ivec3 bbg => new ivec3(z, z, y);
        
        /// <summary>
        /// Returns ivec3.zzyx swizzling.
        /// </summary>
        public ivec4 zzyx => new ivec4(z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.bbgr swizzling (equivalent to ivec3.zzyx).
        /// </summary>
        public ivec4 bbgr => new ivec4(z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.zzyxx swizzling.
        /// </summary>
        public ivec5 zzyxx => new ivec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.bbgrr swizzling (equivalent to ivec3.zzyxx).
        /// </summary>
        public ivec5 bbgrr => new ivec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.zzyxy swizzling.
        /// </summary>
        public ivec5 zzyxy => new ivec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.bbgrg swizzling (equivalent to ivec3.zzyxy).
        /// </summary>
        public ivec5 bbgrg => new ivec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.zzyxz swizzling.
        /// </summary>
        public ivec5 zzyxz => new ivec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.bbgrb swizzling (equivalent to ivec3.zzyxz).
        /// </summary>
        public ivec5 bbgrb => new ivec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.zzyy swizzling.
        /// </summary>
        public ivec4 zzyy => new ivec4(z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.bbgg swizzling (equivalent to ivec3.zzyy).
        /// </summary>
        public ivec4 bbgg => new ivec4(z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.zzyyx swizzling.
        /// </summary>
        public ivec5 zzyyx => new ivec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.bbggr swizzling (equivalent to ivec3.zzyyx).
        /// </summary>
        public ivec5 bbggr => new ivec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.zzyyy swizzling.
        /// </summary>
        public ivec5 zzyyy => new ivec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.bbggg swizzling (equivalent to ivec3.zzyyy).
        /// </summary>
        public ivec5 bbggg => new ivec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.zzyyz swizzling.
        /// </summary>
        public ivec5 zzyyz => new ivec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.bbggb swizzling (equivalent to ivec3.zzyyz).
        /// </summary>
        public ivec5 bbggb => new ivec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.zzyz swizzling.
        /// </summary>
        public ivec4 zzyz => new ivec4(z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.bbgb swizzling (equivalent to ivec3.zzyz).
        /// </summary>
        public ivec4 bbgb => new ivec4(z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.zzyzx swizzling.
        /// </summary>
        public ivec5 zzyzx => new ivec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.bbgbr swizzling (equivalent to ivec3.zzyzx).
        /// </summary>
        public ivec5 bbgbr => new ivec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.zzyzy swizzling.
        /// </summary>
        public ivec5 zzyzy => new ivec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.bbgbg swizzling (equivalent to ivec3.zzyzy).
        /// </summary>
        public ivec5 bbgbg => new ivec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.zzyzz swizzling.
        /// </summary>
        public ivec5 zzyzz => new ivec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.bbgbb swizzling (equivalent to ivec3.zzyzz).
        /// </summary>
        public ivec5 bbgbb => new ivec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.zzz swizzling.
        /// </summary>
        public ivec3 zzz => new ivec3(z, z, z);
        
        /// <summary>
        /// Returns ivec3.bbb swizzling (equivalent to ivec3.zzz).
        /// </summary>
        public ivec3 bbb => new ivec3(z, z, z);
        
        /// <summary>
        /// Returns ivec3.zzzx swizzling.
        /// </summary>
        public ivec4 zzzx => new ivec4(z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.bbbr swizzling (equivalent to ivec3.zzzx).
        /// </summary>
        public ivec4 bbbr => new ivec4(z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.zzzxx swizzling.
        /// </summary>
        public ivec5 zzzxx => new ivec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.bbbrr swizzling (equivalent to ivec3.zzzxx).
        /// </summary>
        public ivec5 bbbrr => new ivec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.zzzxy swizzling.
        /// </summary>
        public ivec5 zzzxy => new ivec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.bbbrg swizzling (equivalent to ivec3.zzzxy).
        /// </summary>
        public ivec5 bbbrg => new ivec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.zzzxz swizzling.
        /// </summary>
        public ivec5 zzzxz => new ivec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.bbbrb swizzling (equivalent to ivec3.zzzxz).
        /// </summary>
        public ivec5 bbbrb => new ivec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.zzzy swizzling.
        /// </summary>
        public ivec4 zzzy => new ivec4(z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.bbbg swizzling (equivalent to ivec3.zzzy).
        /// </summary>
        public ivec4 bbbg => new ivec4(z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.zzzyx swizzling.
        /// </summary>
        public ivec5 zzzyx => new ivec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.bbbgr swizzling (equivalent to ivec3.zzzyx).
        /// </summary>
        public ivec5 bbbgr => new ivec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.zzzyy swizzling.
        /// </summary>
        public ivec5 zzzyy => new ivec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.bbbgg swizzling (equivalent to ivec3.zzzyy).
        /// </summary>
        public ivec5 bbbgg => new ivec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.zzzyz swizzling.
        /// </summary>
        public ivec5 zzzyz => new ivec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.bbbgb swizzling (equivalent to ivec3.zzzyz).
        /// </summary>
        public ivec5 bbbgb => new ivec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.zzzz swizzling.
        /// </summary>
        public ivec4 zzzz => new ivec4(z, z, z, z);
        
        /// <summary>
        /// Returns ivec3.bbbb swizzling (equivalent to ivec3.zzzz).
        /// </summary>
        public ivec4 bbbb => new ivec4(z, z, z, z);
        
        /// <summary>
        /// Returns ivec3.zzzzx swizzling.
        /// </summary>
        public ivec5 zzzzx => new ivec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.bbbbr swizzling (equivalent to ivec3.zzzzx).
        /// </summary>
        public ivec5 bbbbr => new ivec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.zzzzy swizzling.
        /// </summary>
        public ivec5 zzzzy => new ivec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.bbbbg swizzling (equivalent to ivec3.zzzzy).
        /// </summary>
        public ivec5 bbbbg => new ivec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.zzzzz swizzling.
        /// </summary>
        public ivec5 zzzzz => new ivec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns ivec3.bbbbb swizzling (equivalent to ivec3.zzzzz).
        /// </summary>
        public ivec5 bbbbb => new ivec5(z, z, z, z, z);

        #endregion

    }
}
