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
    /// Temporary vector of type uint with 2 components, used for implementing swizzling for uvec2.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_uvec2
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_uvec2.
        /// </summary>
        internal swizzle_uvec2(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns uvec2.xx swizzling.
        /// </summary>
        public uvec2 xx => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec2.rr swizzling (equivalent to uvec2.xx).
        /// </summary>
        public uvec2 rr => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec2.xxx swizzling.
        /// </summary>
        public uvec3 xxx => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec2.rrr swizzling (equivalent to uvec2.xxx).
        /// </summary>
        public uvec3 rrr => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec2.xxxx swizzling.
        /// </summary>
        public uvec4 xxxx => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec2.rrrr swizzling (equivalent to uvec2.xxxx).
        /// </summary>
        public uvec4 rrrr => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec2.xxxxx swizzling.
        /// </summary>
        public uvec5 xxxxx => new uvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns uvec2.rrrrr swizzling (equivalent to uvec2.xxxxx).
        /// </summary>
        public uvec5 rrrrr => new uvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns uvec2.xxxxy swizzling.
        /// </summary>
        public uvec5 xxxxy => new uvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns uvec2.rrrrg swizzling (equivalent to uvec2.xxxxy).
        /// </summary>
        public uvec5 rrrrg => new uvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns uvec2.xxxy swizzling.
        /// </summary>
        public uvec4 xxxy => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec2.rrrg swizzling (equivalent to uvec2.xxxy).
        /// </summary>
        public uvec4 rrrg => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec2.xxxyx swizzling.
        /// </summary>
        public uvec5 xxxyx => new uvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns uvec2.rrrgr swizzling (equivalent to uvec2.xxxyx).
        /// </summary>
        public uvec5 rrrgr => new uvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns uvec2.xxxyy swizzling.
        /// </summary>
        public uvec5 xxxyy => new uvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns uvec2.rrrgg swizzling (equivalent to uvec2.xxxyy).
        /// </summary>
        public uvec5 rrrgg => new uvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns uvec2.xxy swizzling.
        /// </summary>
        public uvec3 xxy => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec2.rrg swizzling (equivalent to uvec2.xxy).
        /// </summary>
        public uvec3 rrg => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec2.xxyx swizzling.
        /// </summary>
        public uvec4 xxyx => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec2.rrgr swizzling (equivalent to uvec2.xxyx).
        /// </summary>
        public uvec4 rrgr => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec2.xxyxx swizzling.
        /// </summary>
        public uvec5 xxyxx => new uvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns uvec2.rrgrr swizzling (equivalent to uvec2.xxyxx).
        /// </summary>
        public uvec5 rrgrr => new uvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns uvec2.xxyxy swizzling.
        /// </summary>
        public uvec5 xxyxy => new uvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns uvec2.rrgrg swizzling (equivalent to uvec2.xxyxy).
        /// </summary>
        public uvec5 rrgrg => new uvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns uvec2.xxyy swizzling.
        /// </summary>
        public uvec4 xxyy => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec2.rrgg swizzling (equivalent to uvec2.xxyy).
        /// </summary>
        public uvec4 rrgg => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec2.xxyyx swizzling.
        /// </summary>
        public uvec5 xxyyx => new uvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns uvec2.rrggr swizzling (equivalent to uvec2.xxyyx).
        /// </summary>
        public uvec5 rrggr => new uvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns uvec2.xxyyy swizzling.
        /// </summary>
        public uvec5 xxyyy => new uvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns uvec2.rrggg swizzling (equivalent to uvec2.xxyyy).
        /// </summary>
        public uvec5 rrggg => new uvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns uvec2.xy swizzling.
        /// </summary>
        public uvec2 xy => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec2.rg swizzling (equivalent to uvec2.xy).
        /// </summary>
        public uvec2 rg => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec2.xyx swizzling.
        /// </summary>
        public uvec3 xyx => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec2.rgr swizzling (equivalent to uvec2.xyx).
        /// </summary>
        public uvec3 rgr => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec2.xyxx swizzling.
        /// </summary>
        public uvec4 xyxx => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec2.rgrr swizzling (equivalent to uvec2.xyxx).
        /// </summary>
        public uvec4 rgrr => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec2.xyxxx swizzling.
        /// </summary>
        public uvec5 xyxxx => new uvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns uvec2.rgrrr swizzling (equivalent to uvec2.xyxxx).
        /// </summary>
        public uvec5 rgrrr => new uvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns uvec2.xyxxy swizzling.
        /// </summary>
        public uvec5 xyxxy => new uvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns uvec2.rgrrg swizzling (equivalent to uvec2.xyxxy).
        /// </summary>
        public uvec5 rgrrg => new uvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns uvec2.xyxy swizzling.
        /// </summary>
        public uvec4 xyxy => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec2.rgrg swizzling (equivalent to uvec2.xyxy).
        /// </summary>
        public uvec4 rgrg => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec2.xyxyx swizzling.
        /// </summary>
        public uvec5 xyxyx => new uvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns uvec2.rgrgr swizzling (equivalent to uvec2.xyxyx).
        /// </summary>
        public uvec5 rgrgr => new uvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns uvec2.xyxyy swizzling.
        /// </summary>
        public uvec5 xyxyy => new uvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns uvec2.rgrgg swizzling (equivalent to uvec2.xyxyy).
        /// </summary>
        public uvec5 rgrgg => new uvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns uvec2.xyy swizzling.
        /// </summary>
        public uvec3 xyy => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec2.rgg swizzling (equivalent to uvec2.xyy).
        /// </summary>
        public uvec3 rgg => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec2.xyyx swizzling.
        /// </summary>
        public uvec4 xyyx => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec2.rggr swizzling (equivalent to uvec2.xyyx).
        /// </summary>
        public uvec4 rggr => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec2.xyyxx swizzling.
        /// </summary>
        public uvec5 xyyxx => new uvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns uvec2.rggrr swizzling (equivalent to uvec2.xyyxx).
        /// </summary>
        public uvec5 rggrr => new uvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns uvec2.xyyxy swizzling.
        /// </summary>
        public uvec5 xyyxy => new uvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns uvec2.rggrg swizzling (equivalent to uvec2.xyyxy).
        /// </summary>
        public uvec5 rggrg => new uvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns uvec2.xyyy swizzling.
        /// </summary>
        public uvec4 xyyy => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec2.rggg swizzling (equivalent to uvec2.xyyy).
        /// </summary>
        public uvec4 rggg => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec2.xyyyx swizzling.
        /// </summary>
        public uvec5 xyyyx => new uvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns uvec2.rgggr swizzling (equivalent to uvec2.xyyyx).
        /// </summary>
        public uvec5 rgggr => new uvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns uvec2.xyyyy swizzling.
        /// </summary>
        public uvec5 xyyyy => new uvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns uvec2.rgggg swizzling (equivalent to uvec2.xyyyy).
        /// </summary>
        public uvec5 rgggg => new uvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns uvec2.yx swizzling.
        /// </summary>
        public uvec2 yx => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec2.gr swizzling (equivalent to uvec2.yx).
        /// </summary>
        public uvec2 gr => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec2.yxx swizzling.
        /// </summary>
        public uvec3 yxx => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec2.grr swizzling (equivalent to uvec2.yxx).
        /// </summary>
        public uvec3 grr => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec2.yxxx swizzling.
        /// </summary>
        public uvec4 yxxx => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec2.grrr swizzling (equivalent to uvec2.yxxx).
        /// </summary>
        public uvec4 grrr => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec2.yxxxx swizzling.
        /// </summary>
        public uvec5 yxxxx => new uvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns uvec2.grrrr swizzling (equivalent to uvec2.yxxxx).
        /// </summary>
        public uvec5 grrrr => new uvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns uvec2.yxxxy swizzling.
        /// </summary>
        public uvec5 yxxxy => new uvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns uvec2.grrrg swizzling (equivalent to uvec2.yxxxy).
        /// </summary>
        public uvec5 grrrg => new uvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns uvec2.yxxy swizzling.
        /// </summary>
        public uvec4 yxxy => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec2.grrg swizzling (equivalent to uvec2.yxxy).
        /// </summary>
        public uvec4 grrg => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec2.yxxyx swizzling.
        /// </summary>
        public uvec5 yxxyx => new uvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns uvec2.grrgr swizzling (equivalent to uvec2.yxxyx).
        /// </summary>
        public uvec5 grrgr => new uvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns uvec2.yxxyy swizzling.
        /// </summary>
        public uvec5 yxxyy => new uvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns uvec2.grrgg swizzling (equivalent to uvec2.yxxyy).
        /// </summary>
        public uvec5 grrgg => new uvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns uvec2.yxy swizzling.
        /// </summary>
        public uvec3 yxy => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec2.grg swizzling (equivalent to uvec2.yxy).
        /// </summary>
        public uvec3 grg => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec2.yxyx swizzling.
        /// </summary>
        public uvec4 yxyx => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec2.grgr swizzling (equivalent to uvec2.yxyx).
        /// </summary>
        public uvec4 grgr => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec2.yxyxx swizzling.
        /// </summary>
        public uvec5 yxyxx => new uvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns uvec2.grgrr swizzling (equivalent to uvec2.yxyxx).
        /// </summary>
        public uvec5 grgrr => new uvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns uvec2.yxyxy swizzling.
        /// </summary>
        public uvec5 yxyxy => new uvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns uvec2.grgrg swizzling (equivalent to uvec2.yxyxy).
        /// </summary>
        public uvec5 grgrg => new uvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns uvec2.yxyy swizzling.
        /// </summary>
        public uvec4 yxyy => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec2.grgg swizzling (equivalent to uvec2.yxyy).
        /// </summary>
        public uvec4 grgg => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec2.yxyyx swizzling.
        /// </summary>
        public uvec5 yxyyx => new uvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns uvec2.grggr swizzling (equivalent to uvec2.yxyyx).
        /// </summary>
        public uvec5 grggr => new uvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns uvec2.yxyyy swizzling.
        /// </summary>
        public uvec5 yxyyy => new uvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns uvec2.grggg swizzling (equivalent to uvec2.yxyyy).
        /// </summary>
        public uvec5 grggg => new uvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns uvec2.yy swizzling.
        /// </summary>
        public uvec2 yy => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec2.gg swizzling (equivalent to uvec2.yy).
        /// </summary>
        public uvec2 gg => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec2.yyx swizzling.
        /// </summary>
        public uvec3 yyx => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec2.ggr swizzling (equivalent to uvec2.yyx).
        /// </summary>
        public uvec3 ggr => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec2.yyxx swizzling.
        /// </summary>
        public uvec4 yyxx => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec2.ggrr swizzling (equivalent to uvec2.yyxx).
        /// </summary>
        public uvec4 ggrr => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec2.yyxxx swizzling.
        /// </summary>
        public uvec5 yyxxx => new uvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns uvec2.ggrrr swizzling (equivalent to uvec2.yyxxx).
        /// </summary>
        public uvec5 ggrrr => new uvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns uvec2.yyxxy swizzling.
        /// </summary>
        public uvec5 yyxxy => new uvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns uvec2.ggrrg swizzling (equivalent to uvec2.yyxxy).
        /// </summary>
        public uvec5 ggrrg => new uvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns uvec2.yyxy swizzling.
        /// </summary>
        public uvec4 yyxy => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec2.ggrg swizzling (equivalent to uvec2.yyxy).
        /// </summary>
        public uvec4 ggrg => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec2.yyxyx swizzling.
        /// </summary>
        public uvec5 yyxyx => new uvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns uvec2.ggrgr swizzling (equivalent to uvec2.yyxyx).
        /// </summary>
        public uvec5 ggrgr => new uvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns uvec2.yyxyy swizzling.
        /// </summary>
        public uvec5 yyxyy => new uvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns uvec2.ggrgg swizzling (equivalent to uvec2.yyxyy).
        /// </summary>
        public uvec5 ggrgg => new uvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns uvec2.yyy swizzling.
        /// </summary>
        public uvec3 yyy => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec2.ggg swizzling (equivalent to uvec2.yyy).
        /// </summary>
        public uvec3 ggg => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec2.yyyx swizzling.
        /// </summary>
        public uvec4 yyyx => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec2.gggr swizzling (equivalent to uvec2.yyyx).
        /// </summary>
        public uvec4 gggr => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec2.yyyxx swizzling.
        /// </summary>
        public uvec5 yyyxx => new uvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns uvec2.gggrr swizzling (equivalent to uvec2.yyyxx).
        /// </summary>
        public uvec5 gggrr => new uvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns uvec2.yyyxy swizzling.
        /// </summary>
        public uvec5 yyyxy => new uvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns uvec2.gggrg swizzling (equivalent to uvec2.yyyxy).
        /// </summary>
        public uvec5 gggrg => new uvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns uvec2.yyyy swizzling.
        /// </summary>
        public uvec4 yyyy => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec2.gggg swizzling (equivalent to uvec2.yyyy).
        /// </summary>
        public uvec4 gggg => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec2.yyyyx swizzling.
        /// </summary>
        public uvec5 yyyyx => new uvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns uvec2.ggggr swizzling (equivalent to uvec2.yyyyx).
        /// </summary>
        public uvec5 ggggr => new uvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns uvec2.yyyyy swizzling.
        /// </summary>
        public uvec5 yyyyy => new uvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns uvec2.ggggg swizzling (equivalent to uvec2.yyyyy).
        /// </summary>
        public uvec5 ggggg => new uvec5(y, y, y, y, y);

        #endregion

    }
}
