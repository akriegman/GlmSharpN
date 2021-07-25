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
    /// Temporary vector of type Half with 2 components, used for implementing swizzling for hvec2.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_hvec2
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly Half x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly Half y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_hvec2.
        /// </summary>
        internal swizzle_hvec2(Half x, Half y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns hvec2.xx swizzling.
        /// </summary>
        public hvec2 xx => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec2.rr swizzling (equivalent to hvec2.xx).
        /// </summary>
        public hvec2 rr => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec2.xxx swizzling.
        /// </summary>
        public hvec3 xxx => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec2.rrr swizzling (equivalent to hvec2.xxx).
        /// </summary>
        public hvec3 rrr => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec2.xxxx swizzling.
        /// </summary>
        public hvec4 xxxx => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec2.rrrr swizzling (equivalent to hvec2.xxxx).
        /// </summary>
        public hvec4 rrrr => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec2.xxxxx swizzling.
        /// </summary>
        public hvec5 xxxxx => new hvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns hvec2.rrrrr swizzling (equivalent to hvec2.xxxxx).
        /// </summary>
        public hvec5 rrrrr => new hvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns hvec2.xxxxy swizzling.
        /// </summary>
        public hvec5 xxxxy => new hvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns hvec2.rrrrg swizzling (equivalent to hvec2.xxxxy).
        /// </summary>
        public hvec5 rrrrg => new hvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns hvec2.xxxy swizzling.
        /// </summary>
        public hvec4 xxxy => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec2.rrrg swizzling (equivalent to hvec2.xxxy).
        /// </summary>
        public hvec4 rrrg => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec2.xxxyx swizzling.
        /// </summary>
        public hvec5 xxxyx => new hvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns hvec2.rrrgr swizzling (equivalent to hvec2.xxxyx).
        /// </summary>
        public hvec5 rrrgr => new hvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns hvec2.xxxyy swizzling.
        /// </summary>
        public hvec5 xxxyy => new hvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns hvec2.rrrgg swizzling (equivalent to hvec2.xxxyy).
        /// </summary>
        public hvec5 rrrgg => new hvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns hvec2.xxy swizzling.
        /// </summary>
        public hvec3 xxy => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec2.rrg swizzling (equivalent to hvec2.xxy).
        /// </summary>
        public hvec3 rrg => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec2.xxyx swizzling.
        /// </summary>
        public hvec4 xxyx => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec2.rrgr swizzling (equivalent to hvec2.xxyx).
        /// </summary>
        public hvec4 rrgr => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec2.xxyxx swizzling.
        /// </summary>
        public hvec5 xxyxx => new hvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns hvec2.rrgrr swizzling (equivalent to hvec2.xxyxx).
        /// </summary>
        public hvec5 rrgrr => new hvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns hvec2.xxyxy swizzling.
        /// </summary>
        public hvec5 xxyxy => new hvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns hvec2.rrgrg swizzling (equivalent to hvec2.xxyxy).
        /// </summary>
        public hvec5 rrgrg => new hvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns hvec2.xxyy swizzling.
        /// </summary>
        public hvec4 xxyy => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec2.rrgg swizzling (equivalent to hvec2.xxyy).
        /// </summary>
        public hvec4 rrgg => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec2.xxyyx swizzling.
        /// </summary>
        public hvec5 xxyyx => new hvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns hvec2.rrggr swizzling (equivalent to hvec2.xxyyx).
        /// </summary>
        public hvec5 rrggr => new hvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns hvec2.xxyyy swizzling.
        /// </summary>
        public hvec5 xxyyy => new hvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns hvec2.rrggg swizzling (equivalent to hvec2.xxyyy).
        /// </summary>
        public hvec5 rrggg => new hvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns hvec2.xy swizzling.
        /// </summary>
        public hvec2 xy => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec2.rg swizzling (equivalent to hvec2.xy).
        /// </summary>
        public hvec2 rg => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec2.xyx swizzling.
        /// </summary>
        public hvec3 xyx => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec2.rgr swizzling (equivalent to hvec2.xyx).
        /// </summary>
        public hvec3 rgr => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec2.xyxx swizzling.
        /// </summary>
        public hvec4 xyxx => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec2.rgrr swizzling (equivalent to hvec2.xyxx).
        /// </summary>
        public hvec4 rgrr => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec2.xyxxx swizzling.
        /// </summary>
        public hvec5 xyxxx => new hvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns hvec2.rgrrr swizzling (equivalent to hvec2.xyxxx).
        /// </summary>
        public hvec5 rgrrr => new hvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns hvec2.xyxxy swizzling.
        /// </summary>
        public hvec5 xyxxy => new hvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns hvec2.rgrrg swizzling (equivalent to hvec2.xyxxy).
        /// </summary>
        public hvec5 rgrrg => new hvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns hvec2.xyxy swizzling.
        /// </summary>
        public hvec4 xyxy => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec2.rgrg swizzling (equivalent to hvec2.xyxy).
        /// </summary>
        public hvec4 rgrg => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec2.xyxyx swizzling.
        /// </summary>
        public hvec5 xyxyx => new hvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns hvec2.rgrgr swizzling (equivalent to hvec2.xyxyx).
        /// </summary>
        public hvec5 rgrgr => new hvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns hvec2.xyxyy swizzling.
        /// </summary>
        public hvec5 xyxyy => new hvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns hvec2.rgrgg swizzling (equivalent to hvec2.xyxyy).
        /// </summary>
        public hvec5 rgrgg => new hvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns hvec2.xyy swizzling.
        /// </summary>
        public hvec3 xyy => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec2.rgg swizzling (equivalent to hvec2.xyy).
        /// </summary>
        public hvec3 rgg => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec2.xyyx swizzling.
        /// </summary>
        public hvec4 xyyx => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec2.rggr swizzling (equivalent to hvec2.xyyx).
        /// </summary>
        public hvec4 rggr => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec2.xyyxx swizzling.
        /// </summary>
        public hvec5 xyyxx => new hvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns hvec2.rggrr swizzling (equivalent to hvec2.xyyxx).
        /// </summary>
        public hvec5 rggrr => new hvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns hvec2.xyyxy swizzling.
        /// </summary>
        public hvec5 xyyxy => new hvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns hvec2.rggrg swizzling (equivalent to hvec2.xyyxy).
        /// </summary>
        public hvec5 rggrg => new hvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns hvec2.xyyy swizzling.
        /// </summary>
        public hvec4 xyyy => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec2.rggg swizzling (equivalent to hvec2.xyyy).
        /// </summary>
        public hvec4 rggg => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec2.xyyyx swizzling.
        /// </summary>
        public hvec5 xyyyx => new hvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns hvec2.rgggr swizzling (equivalent to hvec2.xyyyx).
        /// </summary>
        public hvec5 rgggr => new hvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns hvec2.xyyyy swizzling.
        /// </summary>
        public hvec5 xyyyy => new hvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns hvec2.rgggg swizzling (equivalent to hvec2.xyyyy).
        /// </summary>
        public hvec5 rgggg => new hvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns hvec2.yx swizzling.
        /// </summary>
        public hvec2 yx => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec2.gr swizzling (equivalent to hvec2.yx).
        /// </summary>
        public hvec2 gr => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec2.yxx swizzling.
        /// </summary>
        public hvec3 yxx => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec2.grr swizzling (equivalent to hvec2.yxx).
        /// </summary>
        public hvec3 grr => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec2.yxxx swizzling.
        /// </summary>
        public hvec4 yxxx => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec2.grrr swizzling (equivalent to hvec2.yxxx).
        /// </summary>
        public hvec4 grrr => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec2.yxxxx swizzling.
        /// </summary>
        public hvec5 yxxxx => new hvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns hvec2.grrrr swizzling (equivalent to hvec2.yxxxx).
        /// </summary>
        public hvec5 grrrr => new hvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns hvec2.yxxxy swizzling.
        /// </summary>
        public hvec5 yxxxy => new hvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns hvec2.grrrg swizzling (equivalent to hvec2.yxxxy).
        /// </summary>
        public hvec5 grrrg => new hvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns hvec2.yxxy swizzling.
        /// </summary>
        public hvec4 yxxy => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec2.grrg swizzling (equivalent to hvec2.yxxy).
        /// </summary>
        public hvec4 grrg => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec2.yxxyx swizzling.
        /// </summary>
        public hvec5 yxxyx => new hvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns hvec2.grrgr swizzling (equivalent to hvec2.yxxyx).
        /// </summary>
        public hvec5 grrgr => new hvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns hvec2.yxxyy swizzling.
        /// </summary>
        public hvec5 yxxyy => new hvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns hvec2.grrgg swizzling (equivalent to hvec2.yxxyy).
        /// </summary>
        public hvec5 grrgg => new hvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns hvec2.yxy swizzling.
        /// </summary>
        public hvec3 yxy => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec2.grg swizzling (equivalent to hvec2.yxy).
        /// </summary>
        public hvec3 grg => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec2.yxyx swizzling.
        /// </summary>
        public hvec4 yxyx => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec2.grgr swizzling (equivalent to hvec2.yxyx).
        /// </summary>
        public hvec4 grgr => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec2.yxyxx swizzling.
        /// </summary>
        public hvec5 yxyxx => new hvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns hvec2.grgrr swizzling (equivalent to hvec2.yxyxx).
        /// </summary>
        public hvec5 grgrr => new hvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns hvec2.yxyxy swizzling.
        /// </summary>
        public hvec5 yxyxy => new hvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns hvec2.grgrg swizzling (equivalent to hvec2.yxyxy).
        /// </summary>
        public hvec5 grgrg => new hvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns hvec2.yxyy swizzling.
        /// </summary>
        public hvec4 yxyy => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec2.grgg swizzling (equivalent to hvec2.yxyy).
        /// </summary>
        public hvec4 grgg => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec2.yxyyx swizzling.
        /// </summary>
        public hvec5 yxyyx => new hvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns hvec2.grggr swizzling (equivalent to hvec2.yxyyx).
        /// </summary>
        public hvec5 grggr => new hvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns hvec2.yxyyy swizzling.
        /// </summary>
        public hvec5 yxyyy => new hvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns hvec2.grggg swizzling (equivalent to hvec2.yxyyy).
        /// </summary>
        public hvec5 grggg => new hvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns hvec2.yy swizzling.
        /// </summary>
        public hvec2 yy => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec2.gg swizzling (equivalent to hvec2.yy).
        /// </summary>
        public hvec2 gg => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec2.yyx swizzling.
        /// </summary>
        public hvec3 yyx => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec2.ggr swizzling (equivalent to hvec2.yyx).
        /// </summary>
        public hvec3 ggr => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec2.yyxx swizzling.
        /// </summary>
        public hvec4 yyxx => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec2.ggrr swizzling (equivalent to hvec2.yyxx).
        /// </summary>
        public hvec4 ggrr => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec2.yyxxx swizzling.
        /// </summary>
        public hvec5 yyxxx => new hvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns hvec2.ggrrr swizzling (equivalent to hvec2.yyxxx).
        /// </summary>
        public hvec5 ggrrr => new hvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns hvec2.yyxxy swizzling.
        /// </summary>
        public hvec5 yyxxy => new hvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns hvec2.ggrrg swizzling (equivalent to hvec2.yyxxy).
        /// </summary>
        public hvec5 ggrrg => new hvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns hvec2.yyxy swizzling.
        /// </summary>
        public hvec4 yyxy => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec2.ggrg swizzling (equivalent to hvec2.yyxy).
        /// </summary>
        public hvec4 ggrg => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec2.yyxyx swizzling.
        /// </summary>
        public hvec5 yyxyx => new hvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns hvec2.ggrgr swizzling (equivalent to hvec2.yyxyx).
        /// </summary>
        public hvec5 ggrgr => new hvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns hvec2.yyxyy swizzling.
        /// </summary>
        public hvec5 yyxyy => new hvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns hvec2.ggrgg swizzling (equivalent to hvec2.yyxyy).
        /// </summary>
        public hvec5 ggrgg => new hvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns hvec2.yyy swizzling.
        /// </summary>
        public hvec3 yyy => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec2.ggg swizzling (equivalent to hvec2.yyy).
        /// </summary>
        public hvec3 ggg => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec2.yyyx swizzling.
        /// </summary>
        public hvec4 yyyx => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec2.gggr swizzling (equivalent to hvec2.yyyx).
        /// </summary>
        public hvec4 gggr => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec2.yyyxx swizzling.
        /// </summary>
        public hvec5 yyyxx => new hvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns hvec2.gggrr swizzling (equivalent to hvec2.yyyxx).
        /// </summary>
        public hvec5 gggrr => new hvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns hvec2.yyyxy swizzling.
        /// </summary>
        public hvec5 yyyxy => new hvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns hvec2.gggrg swizzling (equivalent to hvec2.yyyxy).
        /// </summary>
        public hvec5 gggrg => new hvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns hvec2.yyyy swizzling.
        /// </summary>
        public hvec4 yyyy => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec2.gggg swizzling (equivalent to hvec2.yyyy).
        /// </summary>
        public hvec4 gggg => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec2.yyyyx swizzling.
        /// </summary>
        public hvec5 yyyyx => new hvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns hvec2.ggggr swizzling (equivalent to hvec2.yyyyx).
        /// </summary>
        public hvec5 ggggr => new hvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns hvec2.yyyyy swizzling.
        /// </summary>
        public hvec5 yyyyy => new hvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns hvec2.ggggg swizzling (equivalent to hvec2.yyyyy).
        /// </summary>
        public hvec5 ggggg => new hvec5(y, y, y, y, y);

        #endregion

    }
}
