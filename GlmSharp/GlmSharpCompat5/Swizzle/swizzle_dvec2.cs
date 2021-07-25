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
    /// Temporary vector of type double with 2 components, used for implementing swizzling for dvec2.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_dvec2
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly double y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_dvec2.
        /// </summary>
        internal swizzle_dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns dvec2.xx swizzling.
        /// </summary>
        public dvec2 xx => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec2.rr swizzling (equivalent to dvec2.xx).
        /// </summary>
        public dvec2 rr => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec2.xxx swizzling.
        /// </summary>
        public dvec3 xxx => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec2.rrr swizzling (equivalent to dvec2.xxx).
        /// </summary>
        public dvec3 rrr => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec2.xxxx swizzling.
        /// </summary>
        public dvec4 xxxx => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec2.rrrr swizzling (equivalent to dvec2.xxxx).
        /// </summary>
        public dvec4 rrrr => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec2.xxxxx swizzling.
        /// </summary>
        public dvec5 xxxxx => new dvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns dvec2.rrrrr swizzling (equivalent to dvec2.xxxxx).
        /// </summary>
        public dvec5 rrrrr => new dvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns dvec2.xxxxy swizzling.
        /// </summary>
        public dvec5 xxxxy => new dvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns dvec2.rrrrg swizzling (equivalent to dvec2.xxxxy).
        /// </summary>
        public dvec5 rrrrg => new dvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns dvec2.xxxy swizzling.
        /// </summary>
        public dvec4 xxxy => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec2.rrrg swizzling (equivalent to dvec2.xxxy).
        /// </summary>
        public dvec4 rrrg => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec2.xxxyx swizzling.
        /// </summary>
        public dvec5 xxxyx => new dvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns dvec2.rrrgr swizzling (equivalent to dvec2.xxxyx).
        /// </summary>
        public dvec5 rrrgr => new dvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns dvec2.xxxyy swizzling.
        /// </summary>
        public dvec5 xxxyy => new dvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns dvec2.rrrgg swizzling (equivalent to dvec2.xxxyy).
        /// </summary>
        public dvec5 rrrgg => new dvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns dvec2.xxy swizzling.
        /// </summary>
        public dvec3 xxy => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec2.rrg swizzling (equivalent to dvec2.xxy).
        /// </summary>
        public dvec3 rrg => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec2.xxyx swizzling.
        /// </summary>
        public dvec4 xxyx => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec2.rrgr swizzling (equivalent to dvec2.xxyx).
        /// </summary>
        public dvec4 rrgr => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec2.xxyxx swizzling.
        /// </summary>
        public dvec5 xxyxx => new dvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns dvec2.rrgrr swizzling (equivalent to dvec2.xxyxx).
        /// </summary>
        public dvec5 rrgrr => new dvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns dvec2.xxyxy swizzling.
        /// </summary>
        public dvec5 xxyxy => new dvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns dvec2.rrgrg swizzling (equivalent to dvec2.xxyxy).
        /// </summary>
        public dvec5 rrgrg => new dvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns dvec2.xxyy swizzling.
        /// </summary>
        public dvec4 xxyy => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec2.rrgg swizzling (equivalent to dvec2.xxyy).
        /// </summary>
        public dvec4 rrgg => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec2.xxyyx swizzling.
        /// </summary>
        public dvec5 xxyyx => new dvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns dvec2.rrggr swizzling (equivalent to dvec2.xxyyx).
        /// </summary>
        public dvec5 rrggr => new dvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns dvec2.xxyyy swizzling.
        /// </summary>
        public dvec5 xxyyy => new dvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns dvec2.rrggg swizzling (equivalent to dvec2.xxyyy).
        /// </summary>
        public dvec5 rrggg => new dvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns dvec2.xy swizzling.
        /// </summary>
        public dvec2 xy => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec2.rg swizzling (equivalent to dvec2.xy).
        /// </summary>
        public dvec2 rg => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec2.xyx swizzling.
        /// </summary>
        public dvec3 xyx => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec2.rgr swizzling (equivalent to dvec2.xyx).
        /// </summary>
        public dvec3 rgr => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec2.xyxx swizzling.
        /// </summary>
        public dvec4 xyxx => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec2.rgrr swizzling (equivalent to dvec2.xyxx).
        /// </summary>
        public dvec4 rgrr => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec2.xyxxx swizzling.
        /// </summary>
        public dvec5 xyxxx => new dvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns dvec2.rgrrr swizzling (equivalent to dvec2.xyxxx).
        /// </summary>
        public dvec5 rgrrr => new dvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns dvec2.xyxxy swizzling.
        /// </summary>
        public dvec5 xyxxy => new dvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns dvec2.rgrrg swizzling (equivalent to dvec2.xyxxy).
        /// </summary>
        public dvec5 rgrrg => new dvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns dvec2.xyxy swizzling.
        /// </summary>
        public dvec4 xyxy => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec2.rgrg swizzling (equivalent to dvec2.xyxy).
        /// </summary>
        public dvec4 rgrg => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec2.xyxyx swizzling.
        /// </summary>
        public dvec5 xyxyx => new dvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns dvec2.rgrgr swizzling (equivalent to dvec2.xyxyx).
        /// </summary>
        public dvec5 rgrgr => new dvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns dvec2.xyxyy swizzling.
        /// </summary>
        public dvec5 xyxyy => new dvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns dvec2.rgrgg swizzling (equivalent to dvec2.xyxyy).
        /// </summary>
        public dvec5 rgrgg => new dvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns dvec2.xyy swizzling.
        /// </summary>
        public dvec3 xyy => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec2.rgg swizzling (equivalent to dvec2.xyy).
        /// </summary>
        public dvec3 rgg => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec2.xyyx swizzling.
        /// </summary>
        public dvec4 xyyx => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec2.rggr swizzling (equivalent to dvec2.xyyx).
        /// </summary>
        public dvec4 rggr => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec2.xyyxx swizzling.
        /// </summary>
        public dvec5 xyyxx => new dvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns dvec2.rggrr swizzling (equivalent to dvec2.xyyxx).
        /// </summary>
        public dvec5 rggrr => new dvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns dvec2.xyyxy swizzling.
        /// </summary>
        public dvec5 xyyxy => new dvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns dvec2.rggrg swizzling (equivalent to dvec2.xyyxy).
        /// </summary>
        public dvec5 rggrg => new dvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns dvec2.xyyy swizzling.
        /// </summary>
        public dvec4 xyyy => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec2.rggg swizzling (equivalent to dvec2.xyyy).
        /// </summary>
        public dvec4 rggg => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec2.xyyyx swizzling.
        /// </summary>
        public dvec5 xyyyx => new dvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns dvec2.rgggr swizzling (equivalent to dvec2.xyyyx).
        /// </summary>
        public dvec5 rgggr => new dvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns dvec2.xyyyy swizzling.
        /// </summary>
        public dvec5 xyyyy => new dvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns dvec2.rgggg swizzling (equivalent to dvec2.xyyyy).
        /// </summary>
        public dvec5 rgggg => new dvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns dvec2.yx swizzling.
        /// </summary>
        public dvec2 yx => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec2.gr swizzling (equivalent to dvec2.yx).
        /// </summary>
        public dvec2 gr => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec2.yxx swizzling.
        /// </summary>
        public dvec3 yxx => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec2.grr swizzling (equivalent to dvec2.yxx).
        /// </summary>
        public dvec3 grr => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec2.yxxx swizzling.
        /// </summary>
        public dvec4 yxxx => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec2.grrr swizzling (equivalent to dvec2.yxxx).
        /// </summary>
        public dvec4 grrr => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec2.yxxxx swizzling.
        /// </summary>
        public dvec5 yxxxx => new dvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns dvec2.grrrr swizzling (equivalent to dvec2.yxxxx).
        /// </summary>
        public dvec5 grrrr => new dvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns dvec2.yxxxy swizzling.
        /// </summary>
        public dvec5 yxxxy => new dvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns dvec2.grrrg swizzling (equivalent to dvec2.yxxxy).
        /// </summary>
        public dvec5 grrrg => new dvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns dvec2.yxxy swizzling.
        /// </summary>
        public dvec4 yxxy => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec2.grrg swizzling (equivalent to dvec2.yxxy).
        /// </summary>
        public dvec4 grrg => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec2.yxxyx swizzling.
        /// </summary>
        public dvec5 yxxyx => new dvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns dvec2.grrgr swizzling (equivalent to dvec2.yxxyx).
        /// </summary>
        public dvec5 grrgr => new dvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns dvec2.yxxyy swizzling.
        /// </summary>
        public dvec5 yxxyy => new dvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns dvec2.grrgg swizzling (equivalent to dvec2.yxxyy).
        /// </summary>
        public dvec5 grrgg => new dvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns dvec2.yxy swizzling.
        /// </summary>
        public dvec3 yxy => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec2.grg swizzling (equivalent to dvec2.yxy).
        /// </summary>
        public dvec3 grg => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec2.yxyx swizzling.
        /// </summary>
        public dvec4 yxyx => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec2.grgr swizzling (equivalent to dvec2.yxyx).
        /// </summary>
        public dvec4 grgr => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec2.yxyxx swizzling.
        /// </summary>
        public dvec5 yxyxx => new dvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns dvec2.grgrr swizzling (equivalent to dvec2.yxyxx).
        /// </summary>
        public dvec5 grgrr => new dvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns dvec2.yxyxy swizzling.
        /// </summary>
        public dvec5 yxyxy => new dvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns dvec2.grgrg swizzling (equivalent to dvec2.yxyxy).
        /// </summary>
        public dvec5 grgrg => new dvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns dvec2.yxyy swizzling.
        /// </summary>
        public dvec4 yxyy => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec2.grgg swizzling (equivalent to dvec2.yxyy).
        /// </summary>
        public dvec4 grgg => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec2.yxyyx swizzling.
        /// </summary>
        public dvec5 yxyyx => new dvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns dvec2.grggr swizzling (equivalent to dvec2.yxyyx).
        /// </summary>
        public dvec5 grggr => new dvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns dvec2.yxyyy swizzling.
        /// </summary>
        public dvec5 yxyyy => new dvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns dvec2.grggg swizzling (equivalent to dvec2.yxyyy).
        /// </summary>
        public dvec5 grggg => new dvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns dvec2.yy swizzling.
        /// </summary>
        public dvec2 yy => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec2.gg swizzling (equivalent to dvec2.yy).
        /// </summary>
        public dvec2 gg => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec2.yyx swizzling.
        /// </summary>
        public dvec3 yyx => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec2.ggr swizzling (equivalent to dvec2.yyx).
        /// </summary>
        public dvec3 ggr => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec2.yyxx swizzling.
        /// </summary>
        public dvec4 yyxx => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec2.ggrr swizzling (equivalent to dvec2.yyxx).
        /// </summary>
        public dvec4 ggrr => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec2.yyxxx swizzling.
        /// </summary>
        public dvec5 yyxxx => new dvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns dvec2.ggrrr swizzling (equivalent to dvec2.yyxxx).
        /// </summary>
        public dvec5 ggrrr => new dvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns dvec2.yyxxy swizzling.
        /// </summary>
        public dvec5 yyxxy => new dvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns dvec2.ggrrg swizzling (equivalent to dvec2.yyxxy).
        /// </summary>
        public dvec5 ggrrg => new dvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns dvec2.yyxy swizzling.
        /// </summary>
        public dvec4 yyxy => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec2.ggrg swizzling (equivalent to dvec2.yyxy).
        /// </summary>
        public dvec4 ggrg => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec2.yyxyx swizzling.
        /// </summary>
        public dvec5 yyxyx => new dvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns dvec2.ggrgr swizzling (equivalent to dvec2.yyxyx).
        /// </summary>
        public dvec5 ggrgr => new dvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns dvec2.yyxyy swizzling.
        /// </summary>
        public dvec5 yyxyy => new dvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns dvec2.ggrgg swizzling (equivalent to dvec2.yyxyy).
        /// </summary>
        public dvec5 ggrgg => new dvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns dvec2.yyy swizzling.
        /// </summary>
        public dvec3 yyy => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec2.ggg swizzling (equivalent to dvec2.yyy).
        /// </summary>
        public dvec3 ggg => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec2.yyyx swizzling.
        /// </summary>
        public dvec4 yyyx => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec2.gggr swizzling (equivalent to dvec2.yyyx).
        /// </summary>
        public dvec4 gggr => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec2.yyyxx swizzling.
        /// </summary>
        public dvec5 yyyxx => new dvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns dvec2.gggrr swizzling (equivalent to dvec2.yyyxx).
        /// </summary>
        public dvec5 gggrr => new dvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns dvec2.yyyxy swizzling.
        /// </summary>
        public dvec5 yyyxy => new dvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns dvec2.gggrg swizzling (equivalent to dvec2.yyyxy).
        /// </summary>
        public dvec5 gggrg => new dvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns dvec2.yyyy swizzling.
        /// </summary>
        public dvec4 yyyy => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec2.gggg swizzling (equivalent to dvec2.yyyy).
        /// </summary>
        public dvec4 gggg => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec2.yyyyx swizzling.
        /// </summary>
        public dvec5 yyyyx => new dvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns dvec2.ggggr swizzling (equivalent to dvec2.yyyyx).
        /// </summary>
        public dvec5 ggggr => new dvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns dvec2.yyyyy swizzling.
        /// </summary>
        public dvec5 yyyyy => new dvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns dvec2.ggggg swizzling (equivalent to dvec2.yyyyy).
        /// </summary>
        public dvec5 ggggg => new dvec5(y, y, y, y, y);

        #endregion

    }
}
