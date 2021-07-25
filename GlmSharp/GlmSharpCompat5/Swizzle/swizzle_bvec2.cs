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
    /// Temporary vector of type bool with 2 components, used for implementing swizzling for bvec2.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_bvec2
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly bool y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_bvec2.
        /// </summary>
        internal swizzle_bvec2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns bvec2.xx swizzling.
        /// </summary>
        public bvec2 xx => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec2.rr swizzling (equivalent to bvec2.xx).
        /// </summary>
        public bvec2 rr => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec2.xxx swizzling.
        /// </summary>
        public bvec3 xxx => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec2.rrr swizzling (equivalent to bvec2.xxx).
        /// </summary>
        public bvec3 rrr => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec2.xxxx swizzling.
        /// </summary>
        public bvec4 xxxx => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec2.rrrr swizzling (equivalent to bvec2.xxxx).
        /// </summary>
        public bvec4 rrrr => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec2.xxxxx swizzling.
        /// </summary>
        public bvec5 xxxxx => new bvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns bvec2.rrrrr swizzling (equivalent to bvec2.xxxxx).
        /// </summary>
        public bvec5 rrrrr => new bvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns bvec2.xxxxy swizzling.
        /// </summary>
        public bvec5 xxxxy => new bvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns bvec2.rrrrg swizzling (equivalent to bvec2.xxxxy).
        /// </summary>
        public bvec5 rrrrg => new bvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns bvec2.xxxy swizzling.
        /// </summary>
        public bvec4 xxxy => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec2.rrrg swizzling (equivalent to bvec2.xxxy).
        /// </summary>
        public bvec4 rrrg => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec2.xxxyx swizzling.
        /// </summary>
        public bvec5 xxxyx => new bvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns bvec2.rrrgr swizzling (equivalent to bvec2.xxxyx).
        /// </summary>
        public bvec5 rrrgr => new bvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns bvec2.xxxyy swizzling.
        /// </summary>
        public bvec5 xxxyy => new bvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns bvec2.rrrgg swizzling (equivalent to bvec2.xxxyy).
        /// </summary>
        public bvec5 rrrgg => new bvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns bvec2.xxy swizzling.
        /// </summary>
        public bvec3 xxy => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec2.rrg swizzling (equivalent to bvec2.xxy).
        /// </summary>
        public bvec3 rrg => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec2.xxyx swizzling.
        /// </summary>
        public bvec4 xxyx => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec2.rrgr swizzling (equivalent to bvec2.xxyx).
        /// </summary>
        public bvec4 rrgr => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec2.xxyxx swizzling.
        /// </summary>
        public bvec5 xxyxx => new bvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns bvec2.rrgrr swizzling (equivalent to bvec2.xxyxx).
        /// </summary>
        public bvec5 rrgrr => new bvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns bvec2.xxyxy swizzling.
        /// </summary>
        public bvec5 xxyxy => new bvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns bvec2.rrgrg swizzling (equivalent to bvec2.xxyxy).
        /// </summary>
        public bvec5 rrgrg => new bvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns bvec2.xxyy swizzling.
        /// </summary>
        public bvec4 xxyy => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec2.rrgg swizzling (equivalent to bvec2.xxyy).
        /// </summary>
        public bvec4 rrgg => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec2.xxyyx swizzling.
        /// </summary>
        public bvec5 xxyyx => new bvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns bvec2.rrggr swizzling (equivalent to bvec2.xxyyx).
        /// </summary>
        public bvec5 rrggr => new bvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns bvec2.xxyyy swizzling.
        /// </summary>
        public bvec5 xxyyy => new bvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns bvec2.rrggg swizzling (equivalent to bvec2.xxyyy).
        /// </summary>
        public bvec5 rrggg => new bvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns bvec2.xy swizzling.
        /// </summary>
        public bvec2 xy => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec2.rg swizzling (equivalent to bvec2.xy).
        /// </summary>
        public bvec2 rg => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec2.xyx swizzling.
        /// </summary>
        public bvec3 xyx => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec2.rgr swizzling (equivalent to bvec2.xyx).
        /// </summary>
        public bvec3 rgr => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec2.xyxx swizzling.
        /// </summary>
        public bvec4 xyxx => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec2.rgrr swizzling (equivalent to bvec2.xyxx).
        /// </summary>
        public bvec4 rgrr => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec2.xyxxx swizzling.
        /// </summary>
        public bvec5 xyxxx => new bvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns bvec2.rgrrr swizzling (equivalent to bvec2.xyxxx).
        /// </summary>
        public bvec5 rgrrr => new bvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns bvec2.xyxxy swizzling.
        /// </summary>
        public bvec5 xyxxy => new bvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns bvec2.rgrrg swizzling (equivalent to bvec2.xyxxy).
        /// </summary>
        public bvec5 rgrrg => new bvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns bvec2.xyxy swizzling.
        /// </summary>
        public bvec4 xyxy => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec2.rgrg swizzling (equivalent to bvec2.xyxy).
        /// </summary>
        public bvec4 rgrg => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec2.xyxyx swizzling.
        /// </summary>
        public bvec5 xyxyx => new bvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns bvec2.rgrgr swizzling (equivalent to bvec2.xyxyx).
        /// </summary>
        public bvec5 rgrgr => new bvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns bvec2.xyxyy swizzling.
        /// </summary>
        public bvec5 xyxyy => new bvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns bvec2.rgrgg swizzling (equivalent to bvec2.xyxyy).
        /// </summary>
        public bvec5 rgrgg => new bvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns bvec2.xyy swizzling.
        /// </summary>
        public bvec3 xyy => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec2.rgg swizzling (equivalent to bvec2.xyy).
        /// </summary>
        public bvec3 rgg => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec2.xyyx swizzling.
        /// </summary>
        public bvec4 xyyx => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec2.rggr swizzling (equivalent to bvec2.xyyx).
        /// </summary>
        public bvec4 rggr => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec2.xyyxx swizzling.
        /// </summary>
        public bvec5 xyyxx => new bvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns bvec2.rggrr swizzling (equivalent to bvec2.xyyxx).
        /// </summary>
        public bvec5 rggrr => new bvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns bvec2.xyyxy swizzling.
        /// </summary>
        public bvec5 xyyxy => new bvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns bvec2.rggrg swizzling (equivalent to bvec2.xyyxy).
        /// </summary>
        public bvec5 rggrg => new bvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns bvec2.xyyy swizzling.
        /// </summary>
        public bvec4 xyyy => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec2.rggg swizzling (equivalent to bvec2.xyyy).
        /// </summary>
        public bvec4 rggg => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec2.xyyyx swizzling.
        /// </summary>
        public bvec5 xyyyx => new bvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns bvec2.rgggr swizzling (equivalent to bvec2.xyyyx).
        /// </summary>
        public bvec5 rgggr => new bvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns bvec2.xyyyy swizzling.
        /// </summary>
        public bvec5 xyyyy => new bvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns bvec2.rgggg swizzling (equivalent to bvec2.xyyyy).
        /// </summary>
        public bvec5 rgggg => new bvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns bvec2.yx swizzling.
        /// </summary>
        public bvec2 yx => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec2.gr swizzling (equivalent to bvec2.yx).
        /// </summary>
        public bvec2 gr => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec2.yxx swizzling.
        /// </summary>
        public bvec3 yxx => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec2.grr swizzling (equivalent to bvec2.yxx).
        /// </summary>
        public bvec3 grr => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec2.yxxx swizzling.
        /// </summary>
        public bvec4 yxxx => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec2.grrr swizzling (equivalent to bvec2.yxxx).
        /// </summary>
        public bvec4 grrr => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec2.yxxxx swizzling.
        /// </summary>
        public bvec5 yxxxx => new bvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns bvec2.grrrr swizzling (equivalent to bvec2.yxxxx).
        /// </summary>
        public bvec5 grrrr => new bvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns bvec2.yxxxy swizzling.
        /// </summary>
        public bvec5 yxxxy => new bvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns bvec2.grrrg swizzling (equivalent to bvec2.yxxxy).
        /// </summary>
        public bvec5 grrrg => new bvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns bvec2.yxxy swizzling.
        /// </summary>
        public bvec4 yxxy => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec2.grrg swizzling (equivalent to bvec2.yxxy).
        /// </summary>
        public bvec4 grrg => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec2.yxxyx swizzling.
        /// </summary>
        public bvec5 yxxyx => new bvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns bvec2.grrgr swizzling (equivalent to bvec2.yxxyx).
        /// </summary>
        public bvec5 grrgr => new bvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns bvec2.yxxyy swizzling.
        /// </summary>
        public bvec5 yxxyy => new bvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns bvec2.grrgg swizzling (equivalent to bvec2.yxxyy).
        /// </summary>
        public bvec5 grrgg => new bvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns bvec2.yxy swizzling.
        /// </summary>
        public bvec3 yxy => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec2.grg swizzling (equivalent to bvec2.yxy).
        /// </summary>
        public bvec3 grg => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec2.yxyx swizzling.
        /// </summary>
        public bvec4 yxyx => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec2.grgr swizzling (equivalent to bvec2.yxyx).
        /// </summary>
        public bvec4 grgr => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec2.yxyxx swizzling.
        /// </summary>
        public bvec5 yxyxx => new bvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns bvec2.grgrr swizzling (equivalent to bvec2.yxyxx).
        /// </summary>
        public bvec5 grgrr => new bvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns bvec2.yxyxy swizzling.
        /// </summary>
        public bvec5 yxyxy => new bvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns bvec2.grgrg swizzling (equivalent to bvec2.yxyxy).
        /// </summary>
        public bvec5 grgrg => new bvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns bvec2.yxyy swizzling.
        /// </summary>
        public bvec4 yxyy => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec2.grgg swizzling (equivalent to bvec2.yxyy).
        /// </summary>
        public bvec4 grgg => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec2.yxyyx swizzling.
        /// </summary>
        public bvec5 yxyyx => new bvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns bvec2.grggr swizzling (equivalent to bvec2.yxyyx).
        /// </summary>
        public bvec5 grggr => new bvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns bvec2.yxyyy swizzling.
        /// </summary>
        public bvec5 yxyyy => new bvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns bvec2.grggg swizzling (equivalent to bvec2.yxyyy).
        /// </summary>
        public bvec5 grggg => new bvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns bvec2.yy swizzling.
        /// </summary>
        public bvec2 yy => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec2.gg swizzling (equivalent to bvec2.yy).
        /// </summary>
        public bvec2 gg => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec2.yyx swizzling.
        /// </summary>
        public bvec3 yyx => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec2.ggr swizzling (equivalent to bvec2.yyx).
        /// </summary>
        public bvec3 ggr => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec2.yyxx swizzling.
        /// </summary>
        public bvec4 yyxx => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec2.ggrr swizzling (equivalent to bvec2.yyxx).
        /// </summary>
        public bvec4 ggrr => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec2.yyxxx swizzling.
        /// </summary>
        public bvec5 yyxxx => new bvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns bvec2.ggrrr swizzling (equivalent to bvec2.yyxxx).
        /// </summary>
        public bvec5 ggrrr => new bvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns bvec2.yyxxy swizzling.
        /// </summary>
        public bvec5 yyxxy => new bvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns bvec2.ggrrg swizzling (equivalent to bvec2.yyxxy).
        /// </summary>
        public bvec5 ggrrg => new bvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns bvec2.yyxy swizzling.
        /// </summary>
        public bvec4 yyxy => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec2.ggrg swizzling (equivalent to bvec2.yyxy).
        /// </summary>
        public bvec4 ggrg => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec2.yyxyx swizzling.
        /// </summary>
        public bvec5 yyxyx => new bvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns bvec2.ggrgr swizzling (equivalent to bvec2.yyxyx).
        /// </summary>
        public bvec5 ggrgr => new bvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns bvec2.yyxyy swizzling.
        /// </summary>
        public bvec5 yyxyy => new bvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns bvec2.ggrgg swizzling (equivalent to bvec2.yyxyy).
        /// </summary>
        public bvec5 ggrgg => new bvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns bvec2.yyy swizzling.
        /// </summary>
        public bvec3 yyy => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec2.ggg swizzling (equivalent to bvec2.yyy).
        /// </summary>
        public bvec3 ggg => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec2.yyyx swizzling.
        /// </summary>
        public bvec4 yyyx => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec2.gggr swizzling (equivalent to bvec2.yyyx).
        /// </summary>
        public bvec4 gggr => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec2.yyyxx swizzling.
        /// </summary>
        public bvec5 yyyxx => new bvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns bvec2.gggrr swizzling (equivalent to bvec2.yyyxx).
        /// </summary>
        public bvec5 gggrr => new bvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns bvec2.yyyxy swizzling.
        /// </summary>
        public bvec5 yyyxy => new bvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns bvec2.gggrg swizzling (equivalent to bvec2.yyyxy).
        /// </summary>
        public bvec5 gggrg => new bvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns bvec2.yyyy swizzling.
        /// </summary>
        public bvec4 yyyy => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec2.gggg swizzling (equivalent to bvec2.yyyy).
        /// </summary>
        public bvec4 gggg => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec2.yyyyx swizzling.
        /// </summary>
        public bvec5 yyyyx => new bvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns bvec2.ggggr swizzling (equivalent to bvec2.yyyyx).
        /// </summary>
        public bvec5 ggggr => new bvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns bvec2.yyyyy swizzling.
        /// </summary>
        public bvec5 yyyyy => new bvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns bvec2.ggggg swizzling (equivalent to bvec2.yyyyy).
        /// </summary>
        public bvec5 ggggg => new bvec5(y, y, y, y, y);

        #endregion

    }
}
