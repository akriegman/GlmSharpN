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
    /// Temporary vector of type int with 2 components, used for implementing swizzling for ivec2.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_ivec2
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_ivec2.
        /// </summary>
        internal swizzle_ivec2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns ivec2.xx swizzling.
        /// </summary>
        public ivec2 xx => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec2.rr swizzling (equivalent to ivec2.xx).
        /// </summary>
        public ivec2 rr => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec2.xxx swizzling.
        /// </summary>
        public ivec3 xxx => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec2.rrr swizzling (equivalent to ivec2.xxx).
        /// </summary>
        public ivec3 rrr => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec2.xxxx swizzling.
        /// </summary>
        public ivec4 xxxx => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec2.rrrr swizzling (equivalent to ivec2.xxxx).
        /// </summary>
        public ivec4 rrrr => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec2.xxxxx swizzling.
        /// </summary>
        public ivec5 xxxxx => new ivec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns ivec2.rrrrr swizzling (equivalent to ivec2.xxxxx).
        /// </summary>
        public ivec5 rrrrr => new ivec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns ivec2.xxxxy swizzling.
        /// </summary>
        public ivec5 xxxxy => new ivec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns ivec2.rrrrg swizzling (equivalent to ivec2.xxxxy).
        /// </summary>
        public ivec5 rrrrg => new ivec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns ivec2.xxxy swizzling.
        /// </summary>
        public ivec4 xxxy => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec2.rrrg swizzling (equivalent to ivec2.xxxy).
        /// </summary>
        public ivec4 rrrg => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec2.xxxyx swizzling.
        /// </summary>
        public ivec5 xxxyx => new ivec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns ivec2.rrrgr swizzling (equivalent to ivec2.xxxyx).
        /// </summary>
        public ivec5 rrrgr => new ivec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns ivec2.xxxyy swizzling.
        /// </summary>
        public ivec5 xxxyy => new ivec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns ivec2.rrrgg swizzling (equivalent to ivec2.xxxyy).
        /// </summary>
        public ivec5 rrrgg => new ivec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns ivec2.xxy swizzling.
        /// </summary>
        public ivec3 xxy => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec2.rrg swizzling (equivalent to ivec2.xxy).
        /// </summary>
        public ivec3 rrg => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec2.xxyx swizzling.
        /// </summary>
        public ivec4 xxyx => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec2.rrgr swizzling (equivalent to ivec2.xxyx).
        /// </summary>
        public ivec4 rrgr => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec2.xxyxx swizzling.
        /// </summary>
        public ivec5 xxyxx => new ivec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns ivec2.rrgrr swizzling (equivalent to ivec2.xxyxx).
        /// </summary>
        public ivec5 rrgrr => new ivec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns ivec2.xxyxy swizzling.
        /// </summary>
        public ivec5 xxyxy => new ivec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns ivec2.rrgrg swizzling (equivalent to ivec2.xxyxy).
        /// </summary>
        public ivec5 rrgrg => new ivec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns ivec2.xxyy swizzling.
        /// </summary>
        public ivec4 xxyy => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec2.rrgg swizzling (equivalent to ivec2.xxyy).
        /// </summary>
        public ivec4 rrgg => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec2.xxyyx swizzling.
        /// </summary>
        public ivec5 xxyyx => new ivec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns ivec2.rrggr swizzling (equivalent to ivec2.xxyyx).
        /// </summary>
        public ivec5 rrggr => new ivec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns ivec2.xxyyy swizzling.
        /// </summary>
        public ivec5 xxyyy => new ivec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns ivec2.rrggg swizzling (equivalent to ivec2.xxyyy).
        /// </summary>
        public ivec5 rrggg => new ivec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns ivec2.xy swizzling.
        /// </summary>
        public ivec2 xy => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec2.rg swizzling (equivalent to ivec2.xy).
        /// </summary>
        public ivec2 rg => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec2.xyx swizzling.
        /// </summary>
        public ivec3 xyx => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec2.rgr swizzling (equivalent to ivec2.xyx).
        /// </summary>
        public ivec3 rgr => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec2.xyxx swizzling.
        /// </summary>
        public ivec4 xyxx => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec2.rgrr swizzling (equivalent to ivec2.xyxx).
        /// </summary>
        public ivec4 rgrr => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec2.xyxxx swizzling.
        /// </summary>
        public ivec5 xyxxx => new ivec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns ivec2.rgrrr swizzling (equivalent to ivec2.xyxxx).
        /// </summary>
        public ivec5 rgrrr => new ivec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns ivec2.xyxxy swizzling.
        /// </summary>
        public ivec5 xyxxy => new ivec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns ivec2.rgrrg swizzling (equivalent to ivec2.xyxxy).
        /// </summary>
        public ivec5 rgrrg => new ivec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns ivec2.xyxy swizzling.
        /// </summary>
        public ivec4 xyxy => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec2.rgrg swizzling (equivalent to ivec2.xyxy).
        /// </summary>
        public ivec4 rgrg => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec2.xyxyx swizzling.
        /// </summary>
        public ivec5 xyxyx => new ivec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns ivec2.rgrgr swizzling (equivalent to ivec2.xyxyx).
        /// </summary>
        public ivec5 rgrgr => new ivec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns ivec2.xyxyy swizzling.
        /// </summary>
        public ivec5 xyxyy => new ivec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns ivec2.rgrgg swizzling (equivalent to ivec2.xyxyy).
        /// </summary>
        public ivec5 rgrgg => new ivec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns ivec2.xyy swizzling.
        /// </summary>
        public ivec3 xyy => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec2.rgg swizzling (equivalent to ivec2.xyy).
        /// </summary>
        public ivec3 rgg => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec2.xyyx swizzling.
        /// </summary>
        public ivec4 xyyx => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec2.rggr swizzling (equivalent to ivec2.xyyx).
        /// </summary>
        public ivec4 rggr => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec2.xyyxx swizzling.
        /// </summary>
        public ivec5 xyyxx => new ivec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns ivec2.rggrr swizzling (equivalent to ivec2.xyyxx).
        /// </summary>
        public ivec5 rggrr => new ivec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns ivec2.xyyxy swizzling.
        /// </summary>
        public ivec5 xyyxy => new ivec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns ivec2.rggrg swizzling (equivalent to ivec2.xyyxy).
        /// </summary>
        public ivec5 rggrg => new ivec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns ivec2.xyyy swizzling.
        /// </summary>
        public ivec4 xyyy => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec2.rggg swizzling (equivalent to ivec2.xyyy).
        /// </summary>
        public ivec4 rggg => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec2.xyyyx swizzling.
        /// </summary>
        public ivec5 xyyyx => new ivec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns ivec2.rgggr swizzling (equivalent to ivec2.xyyyx).
        /// </summary>
        public ivec5 rgggr => new ivec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns ivec2.xyyyy swizzling.
        /// </summary>
        public ivec5 xyyyy => new ivec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns ivec2.rgggg swizzling (equivalent to ivec2.xyyyy).
        /// </summary>
        public ivec5 rgggg => new ivec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns ivec2.yx swizzling.
        /// </summary>
        public ivec2 yx => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec2.gr swizzling (equivalent to ivec2.yx).
        /// </summary>
        public ivec2 gr => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec2.yxx swizzling.
        /// </summary>
        public ivec3 yxx => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec2.grr swizzling (equivalent to ivec2.yxx).
        /// </summary>
        public ivec3 grr => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec2.yxxx swizzling.
        /// </summary>
        public ivec4 yxxx => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec2.grrr swizzling (equivalent to ivec2.yxxx).
        /// </summary>
        public ivec4 grrr => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec2.yxxxx swizzling.
        /// </summary>
        public ivec5 yxxxx => new ivec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns ivec2.grrrr swizzling (equivalent to ivec2.yxxxx).
        /// </summary>
        public ivec5 grrrr => new ivec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns ivec2.yxxxy swizzling.
        /// </summary>
        public ivec5 yxxxy => new ivec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns ivec2.grrrg swizzling (equivalent to ivec2.yxxxy).
        /// </summary>
        public ivec5 grrrg => new ivec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns ivec2.yxxy swizzling.
        /// </summary>
        public ivec4 yxxy => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec2.grrg swizzling (equivalent to ivec2.yxxy).
        /// </summary>
        public ivec4 grrg => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec2.yxxyx swizzling.
        /// </summary>
        public ivec5 yxxyx => new ivec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns ivec2.grrgr swizzling (equivalent to ivec2.yxxyx).
        /// </summary>
        public ivec5 grrgr => new ivec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns ivec2.yxxyy swizzling.
        /// </summary>
        public ivec5 yxxyy => new ivec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns ivec2.grrgg swizzling (equivalent to ivec2.yxxyy).
        /// </summary>
        public ivec5 grrgg => new ivec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns ivec2.yxy swizzling.
        /// </summary>
        public ivec3 yxy => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec2.grg swizzling (equivalent to ivec2.yxy).
        /// </summary>
        public ivec3 grg => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec2.yxyx swizzling.
        /// </summary>
        public ivec4 yxyx => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec2.grgr swizzling (equivalent to ivec2.yxyx).
        /// </summary>
        public ivec4 grgr => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec2.yxyxx swizzling.
        /// </summary>
        public ivec5 yxyxx => new ivec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns ivec2.grgrr swizzling (equivalent to ivec2.yxyxx).
        /// </summary>
        public ivec5 grgrr => new ivec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns ivec2.yxyxy swizzling.
        /// </summary>
        public ivec5 yxyxy => new ivec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns ivec2.grgrg swizzling (equivalent to ivec2.yxyxy).
        /// </summary>
        public ivec5 grgrg => new ivec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns ivec2.yxyy swizzling.
        /// </summary>
        public ivec4 yxyy => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec2.grgg swizzling (equivalent to ivec2.yxyy).
        /// </summary>
        public ivec4 grgg => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec2.yxyyx swizzling.
        /// </summary>
        public ivec5 yxyyx => new ivec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns ivec2.grggr swizzling (equivalent to ivec2.yxyyx).
        /// </summary>
        public ivec5 grggr => new ivec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns ivec2.yxyyy swizzling.
        /// </summary>
        public ivec5 yxyyy => new ivec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns ivec2.grggg swizzling (equivalent to ivec2.yxyyy).
        /// </summary>
        public ivec5 grggg => new ivec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns ivec2.yy swizzling.
        /// </summary>
        public ivec2 yy => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec2.gg swizzling (equivalent to ivec2.yy).
        /// </summary>
        public ivec2 gg => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec2.yyx swizzling.
        /// </summary>
        public ivec3 yyx => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec2.ggr swizzling (equivalent to ivec2.yyx).
        /// </summary>
        public ivec3 ggr => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec2.yyxx swizzling.
        /// </summary>
        public ivec4 yyxx => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec2.ggrr swizzling (equivalent to ivec2.yyxx).
        /// </summary>
        public ivec4 ggrr => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec2.yyxxx swizzling.
        /// </summary>
        public ivec5 yyxxx => new ivec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns ivec2.ggrrr swizzling (equivalent to ivec2.yyxxx).
        /// </summary>
        public ivec5 ggrrr => new ivec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns ivec2.yyxxy swizzling.
        /// </summary>
        public ivec5 yyxxy => new ivec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns ivec2.ggrrg swizzling (equivalent to ivec2.yyxxy).
        /// </summary>
        public ivec5 ggrrg => new ivec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns ivec2.yyxy swizzling.
        /// </summary>
        public ivec4 yyxy => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec2.ggrg swizzling (equivalent to ivec2.yyxy).
        /// </summary>
        public ivec4 ggrg => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec2.yyxyx swizzling.
        /// </summary>
        public ivec5 yyxyx => new ivec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns ivec2.ggrgr swizzling (equivalent to ivec2.yyxyx).
        /// </summary>
        public ivec5 ggrgr => new ivec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns ivec2.yyxyy swizzling.
        /// </summary>
        public ivec5 yyxyy => new ivec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns ivec2.ggrgg swizzling (equivalent to ivec2.yyxyy).
        /// </summary>
        public ivec5 ggrgg => new ivec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns ivec2.yyy swizzling.
        /// </summary>
        public ivec3 yyy => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec2.ggg swizzling (equivalent to ivec2.yyy).
        /// </summary>
        public ivec3 ggg => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec2.yyyx swizzling.
        /// </summary>
        public ivec4 yyyx => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec2.gggr swizzling (equivalent to ivec2.yyyx).
        /// </summary>
        public ivec4 gggr => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec2.yyyxx swizzling.
        /// </summary>
        public ivec5 yyyxx => new ivec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns ivec2.gggrr swizzling (equivalent to ivec2.yyyxx).
        /// </summary>
        public ivec5 gggrr => new ivec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns ivec2.yyyxy swizzling.
        /// </summary>
        public ivec5 yyyxy => new ivec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns ivec2.gggrg swizzling (equivalent to ivec2.yyyxy).
        /// </summary>
        public ivec5 gggrg => new ivec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns ivec2.yyyy swizzling.
        /// </summary>
        public ivec4 yyyy => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec2.gggg swizzling (equivalent to ivec2.yyyy).
        /// </summary>
        public ivec4 gggg => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec2.yyyyx swizzling.
        /// </summary>
        public ivec5 yyyyx => new ivec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns ivec2.ggggr swizzling (equivalent to ivec2.yyyyx).
        /// </summary>
        public ivec5 ggggr => new ivec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns ivec2.yyyyy swizzling.
        /// </summary>
        public ivec5 yyyyy => new ivec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns ivec2.ggggg swizzling (equivalent to ivec2.yyyyy).
        /// </summary>
        public ivec5 ggggg => new ivec5(y, y, y, y, y);

        #endregion

    }
}
