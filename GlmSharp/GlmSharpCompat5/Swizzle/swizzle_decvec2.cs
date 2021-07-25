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
    /// Temporary vector of type decimal with 2 components, used for implementing swizzling for decvec2.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_decvec2
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly decimal y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_decvec2.
        /// </summary>
        internal swizzle_decvec2(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns decvec2.xx swizzling.
        /// </summary>
        public decvec2 xx => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec2.rr swizzling (equivalent to decvec2.xx).
        /// </summary>
        public decvec2 rr => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec2.xxx swizzling.
        /// </summary>
        public decvec3 xxx => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec2.rrr swizzling (equivalent to decvec2.xxx).
        /// </summary>
        public decvec3 rrr => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec2.xxxx swizzling.
        /// </summary>
        public decvec4 xxxx => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec2.rrrr swizzling (equivalent to decvec2.xxxx).
        /// </summary>
        public decvec4 rrrr => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec2.xxxxx swizzling.
        /// </summary>
        public decvec5 xxxxx => new decvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns decvec2.rrrrr swizzling (equivalent to decvec2.xxxxx).
        /// </summary>
        public decvec5 rrrrr => new decvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns decvec2.xxxxy swizzling.
        /// </summary>
        public decvec5 xxxxy => new decvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns decvec2.rrrrg swizzling (equivalent to decvec2.xxxxy).
        /// </summary>
        public decvec5 rrrrg => new decvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns decvec2.xxxy swizzling.
        /// </summary>
        public decvec4 xxxy => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec2.rrrg swizzling (equivalent to decvec2.xxxy).
        /// </summary>
        public decvec4 rrrg => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec2.xxxyx swizzling.
        /// </summary>
        public decvec5 xxxyx => new decvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns decvec2.rrrgr swizzling (equivalent to decvec2.xxxyx).
        /// </summary>
        public decvec5 rrrgr => new decvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns decvec2.xxxyy swizzling.
        /// </summary>
        public decvec5 xxxyy => new decvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns decvec2.rrrgg swizzling (equivalent to decvec2.xxxyy).
        /// </summary>
        public decvec5 rrrgg => new decvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns decvec2.xxy swizzling.
        /// </summary>
        public decvec3 xxy => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec2.rrg swizzling (equivalent to decvec2.xxy).
        /// </summary>
        public decvec3 rrg => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec2.xxyx swizzling.
        /// </summary>
        public decvec4 xxyx => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec2.rrgr swizzling (equivalent to decvec2.xxyx).
        /// </summary>
        public decvec4 rrgr => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec2.xxyxx swizzling.
        /// </summary>
        public decvec5 xxyxx => new decvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns decvec2.rrgrr swizzling (equivalent to decvec2.xxyxx).
        /// </summary>
        public decvec5 rrgrr => new decvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns decvec2.xxyxy swizzling.
        /// </summary>
        public decvec5 xxyxy => new decvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns decvec2.rrgrg swizzling (equivalent to decvec2.xxyxy).
        /// </summary>
        public decvec5 rrgrg => new decvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns decvec2.xxyy swizzling.
        /// </summary>
        public decvec4 xxyy => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec2.rrgg swizzling (equivalent to decvec2.xxyy).
        /// </summary>
        public decvec4 rrgg => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec2.xxyyx swizzling.
        /// </summary>
        public decvec5 xxyyx => new decvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns decvec2.rrggr swizzling (equivalent to decvec2.xxyyx).
        /// </summary>
        public decvec5 rrggr => new decvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns decvec2.xxyyy swizzling.
        /// </summary>
        public decvec5 xxyyy => new decvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns decvec2.rrggg swizzling (equivalent to decvec2.xxyyy).
        /// </summary>
        public decvec5 rrggg => new decvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns decvec2.xy swizzling.
        /// </summary>
        public decvec2 xy => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec2.rg swizzling (equivalent to decvec2.xy).
        /// </summary>
        public decvec2 rg => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec2.xyx swizzling.
        /// </summary>
        public decvec3 xyx => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec2.rgr swizzling (equivalent to decvec2.xyx).
        /// </summary>
        public decvec3 rgr => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec2.xyxx swizzling.
        /// </summary>
        public decvec4 xyxx => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec2.rgrr swizzling (equivalent to decvec2.xyxx).
        /// </summary>
        public decvec4 rgrr => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec2.xyxxx swizzling.
        /// </summary>
        public decvec5 xyxxx => new decvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns decvec2.rgrrr swizzling (equivalent to decvec2.xyxxx).
        /// </summary>
        public decvec5 rgrrr => new decvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns decvec2.xyxxy swizzling.
        /// </summary>
        public decvec5 xyxxy => new decvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns decvec2.rgrrg swizzling (equivalent to decvec2.xyxxy).
        /// </summary>
        public decvec5 rgrrg => new decvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns decvec2.xyxy swizzling.
        /// </summary>
        public decvec4 xyxy => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec2.rgrg swizzling (equivalent to decvec2.xyxy).
        /// </summary>
        public decvec4 rgrg => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec2.xyxyx swizzling.
        /// </summary>
        public decvec5 xyxyx => new decvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns decvec2.rgrgr swizzling (equivalent to decvec2.xyxyx).
        /// </summary>
        public decvec5 rgrgr => new decvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns decvec2.xyxyy swizzling.
        /// </summary>
        public decvec5 xyxyy => new decvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns decvec2.rgrgg swizzling (equivalent to decvec2.xyxyy).
        /// </summary>
        public decvec5 rgrgg => new decvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns decvec2.xyy swizzling.
        /// </summary>
        public decvec3 xyy => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec2.rgg swizzling (equivalent to decvec2.xyy).
        /// </summary>
        public decvec3 rgg => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec2.xyyx swizzling.
        /// </summary>
        public decvec4 xyyx => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec2.rggr swizzling (equivalent to decvec2.xyyx).
        /// </summary>
        public decvec4 rggr => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec2.xyyxx swizzling.
        /// </summary>
        public decvec5 xyyxx => new decvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns decvec2.rggrr swizzling (equivalent to decvec2.xyyxx).
        /// </summary>
        public decvec5 rggrr => new decvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns decvec2.xyyxy swizzling.
        /// </summary>
        public decvec5 xyyxy => new decvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns decvec2.rggrg swizzling (equivalent to decvec2.xyyxy).
        /// </summary>
        public decvec5 rggrg => new decvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns decvec2.xyyy swizzling.
        /// </summary>
        public decvec4 xyyy => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec2.rggg swizzling (equivalent to decvec2.xyyy).
        /// </summary>
        public decvec4 rggg => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec2.xyyyx swizzling.
        /// </summary>
        public decvec5 xyyyx => new decvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns decvec2.rgggr swizzling (equivalent to decvec2.xyyyx).
        /// </summary>
        public decvec5 rgggr => new decvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns decvec2.xyyyy swizzling.
        /// </summary>
        public decvec5 xyyyy => new decvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns decvec2.rgggg swizzling (equivalent to decvec2.xyyyy).
        /// </summary>
        public decvec5 rgggg => new decvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns decvec2.yx swizzling.
        /// </summary>
        public decvec2 yx => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec2.gr swizzling (equivalent to decvec2.yx).
        /// </summary>
        public decvec2 gr => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec2.yxx swizzling.
        /// </summary>
        public decvec3 yxx => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec2.grr swizzling (equivalent to decvec2.yxx).
        /// </summary>
        public decvec3 grr => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec2.yxxx swizzling.
        /// </summary>
        public decvec4 yxxx => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec2.grrr swizzling (equivalent to decvec2.yxxx).
        /// </summary>
        public decvec4 grrr => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec2.yxxxx swizzling.
        /// </summary>
        public decvec5 yxxxx => new decvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns decvec2.grrrr swizzling (equivalent to decvec2.yxxxx).
        /// </summary>
        public decvec5 grrrr => new decvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns decvec2.yxxxy swizzling.
        /// </summary>
        public decvec5 yxxxy => new decvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns decvec2.grrrg swizzling (equivalent to decvec2.yxxxy).
        /// </summary>
        public decvec5 grrrg => new decvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns decvec2.yxxy swizzling.
        /// </summary>
        public decvec4 yxxy => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec2.grrg swizzling (equivalent to decvec2.yxxy).
        /// </summary>
        public decvec4 grrg => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec2.yxxyx swizzling.
        /// </summary>
        public decvec5 yxxyx => new decvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns decvec2.grrgr swizzling (equivalent to decvec2.yxxyx).
        /// </summary>
        public decvec5 grrgr => new decvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns decvec2.yxxyy swizzling.
        /// </summary>
        public decvec5 yxxyy => new decvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns decvec2.grrgg swizzling (equivalent to decvec2.yxxyy).
        /// </summary>
        public decvec5 grrgg => new decvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns decvec2.yxy swizzling.
        /// </summary>
        public decvec3 yxy => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec2.grg swizzling (equivalent to decvec2.yxy).
        /// </summary>
        public decvec3 grg => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec2.yxyx swizzling.
        /// </summary>
        public decvec4 yxyx => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec2.grgr swizzling (equivalent to decvec2.yxyx).
        /// </summary>
        public decvec4 grgr => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec2.yxyxx swizzling.
        /// </summary>
        public decvec5 yxyxx => new decvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns decvec2.grgrr swizzling (equivalent to decvec2.yxyxx).
        /// </summary>
        public decvec5 grgrr => new decvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns decvec2.yxyxy swizzling.
        /// </summary>
        public decvec5 yxyxy => new decvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns decvec2.grgrg swizzling (equivalent to decvec2.yxyxy).
        /// </summary>
        public decvec5 grgrg => new decvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns decvec2.yxyy swizzling.
        /// </summary>
        public decvec4 yxyy => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec2.grgg swizzling (equivalent to decvec2.yxyy).
        /// </summary>
        public decvec4 grgg => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec2.yxyyx swizzling.
        /// </summary>
        public decvec5 yxyyx => new decvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns decvec2.grggr swizzling (equivalent to decvec2.yxyyx).
        /// </summary>
        public decvec5 grggr => new decvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns decvec2.yxyyy swizzling.
        /// </summary>
        public decvec5 yxyyy => new decvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns decvec2.grggg swizzling (equivalent to decvec2.yxyyy).
        /// </summary>
        public decvec5 grggg => new decvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns decvec2.yy swizzling.
        /// </summary>
        public decvec2 yy => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec2.gg swizzling (equivalent to decvec2.yy).
        /// </summary>
        public decvec2 gg => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec2.yyx swizzling.
        /// </summary>
        public decvec3 yyx => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec2.ggr swizzling (equivalent to decvec2.yyx).
        /// </summary>
        public decvec3 ggr => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec2.yyxx swizzling.
        /// </summary>
        public decvec4 yyxx => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec2.ggrr swizzling (equivalent to decvec2.yyxx).
        /// </summary>
        public decvec4 ggrr => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec2.yyxxx swizzling.
        /// </summary>
        public decvec5 yyxxx => new decvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns decvec2.ggrrr swizzling (equivalent to decvec2.yyxxx).
        /// </summary>
        public decvec5 ggrrr => new decvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns decvec2.yyxxy swizzling.
        /// </summary>
        public decvec5 yyxxy => new decvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns decvec2.ggrrg swizzling (equivalent to decvec2.yyxxy).
        /// </summary>
        public decvec5 ggrrg => new decvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns decvec2.yyxy swizzling.
        /// </summary>
        public decvec4 yyxy => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec2.ggrg swizzling (equivalent to decvec2.yyxy).
        /// </summary>
        public decvec4 ggrg => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec2.yyxyx swizzling.
        /// </summary>
        public decvec5 yyxyx => new decvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns decvec2.ggrgr swizzling (equivalent to decvec2.yyxyx).
        /// </summary>
        public decvec5 ggrgr => new decvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns decvec2.yyxyy swizzling.
        /// </summary>
        public decvec5 yyxyy => new decvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns decvec2.ggrgg swizzling (equivalent to decvec2.yyxyy).
        /// </summary>
        public decvec5 ggrgg => new decvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns decvec2.yyy swizzling.
        /// </summary>
        public decvec3 yyy => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec2.ggg swizzling (equivalent to decvec2.yyy).
        /// </summary>
        public decvec3 ggg => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec2.yyyx swizzling.
        /// </summary>
        public decvec4 yyyx => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec2.gggr swizzling (equivalent to decvec2.yyyx).
        /// </summary>
        public decvec4 gggr => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec2.yyyxx swizzling.
        /// </summary>
        public decvec5 yyyxx => new decvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns decvec2.gggrr swizzling (equivalent to decvec2.yyyxx).
        /// </summary>
        public decvec5 gggrr => new decvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns decvec2.yyyxy swizzling.
        /// </summary>
        public decvec5 yyyxy => new decvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns decvec2.gggrg swizzling (equivalent to decvec2.yyyxy).
        /// </summary>
        public decvec5 gggrg => new decvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns decvec2.yyyy swizzling.
        /// </summary>
        public decvec4 yyyy => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec2.gggg swizzling (equivalent to decvec2.yyyy).
        /// </summary>
        public decvec4 gggg => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec2.yyyyx swizzling.
        /// </summary>
        public decvec5 yyyyx => new decvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns decvec2.ggggr swizzling (equivalent to decvec2.yyyyx).
        /// </summary>
        public decvec5 ggggr => new decvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns decvec2.yyyyy swizzling.
        /// </summary>
        public decvec5 yyyyy => new decvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns decvec2.ggggg swizzling (equivalent to decvec2.yyyyy).
        /// </summary>
        public decvec5 ggggg => new decvec5(y, y, y, y, y);

        #endregion

    }
}
