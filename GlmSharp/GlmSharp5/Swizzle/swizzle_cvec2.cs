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
    /// Temporary vector of type Complex with 2 components, used for implementing swizzling for cvec2.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_cvec2
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_cvec2.
        /// </summary>
        internal swizzle_cvec2(Complex x, Complex y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns cvec2.xx swizzling.
        /// </summary>
        public cvec2 xx => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec2.rr swizzling (equivalent to cvec2.xx).
        /// </summary>
        public cvec2 rr => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec2.xxx swizzling.
        /// </summary>
        public cvec3 xxx => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec2.rrr swizzling (equivalent to cvec2.xxx).
        /// </summary>
        public cvec3 rrr => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec2.xxxx swizzling.
        /// </summary>
        public cvec4 xxxx => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec2.rrrr swizzling (equivalent to cvec2.xxxx).
        /// </summary>
        public cvec4 rrrr => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec2.xxxxx swizzling.
        /// </summary>
        public cvec5 xxxxx => new cvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns cvec2.rrrrr swizzling (equivalent to cvec2.xxxxx).
        /// </summary>
        public cvec5 rrrrr => new cvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns cvec2.xxxxy swizzling.
        /// </summary>
        public cvec5 xxxxy => new cvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns cvec2.rrrrg swizzling (equivalent to cvec2.xxxxy).
        /// </summary>
        public cvec5 rrrrg => new cvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns cvec2.xxxy swizzling.
        /// </summary>
        public cvec4 xxxy => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec2.rrrg swizzling (equivalent to cvec2.xxxy).
        /// </summary>
        public cvec4 rrrg => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec2.xxxyx swizzling.
        /// </summary>
        public cvec5 xxxyx => new cvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns cvec2.rrrgr swizzling (equivalent to cvec2.xxxyx).
        /// </summary>
        public cvec5 rrrgr => new cvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns cvec2.xxxyy swizzling.
        /// </summary>
        public cvec5 xxxyy => new cvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns cvec2.rrrgg swizzling (equivalent to cvec2.xxxyy).
        /// </summary>
        public cvec5 rrrgg => new cvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns cvec2.xxy swizzling.
        /// </summary>
        public cvec3 xxy => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec2.rrg swizzling (equivalent to cvec2.xxy).
        /// </summary>
        public cvec3 rrg => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec2.xxyx swizzling.
        /// </summary>
        public cvec4 xxyx => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec2.rrgr swizzling (equivalent to cvec2.xxyx).
        /// </summary>
        public cvec4 rrgr => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec2.xxyxx swizzling.
        /// </summary>
        public cvec5 xxyxx => new cvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns cvec2.rrgrr swizzling (equivalent to cvec2.xxyxx).
        /// </summary>
        public cvec5 rrgrr => new cvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns cvec2.xxyxy swizzling.
        /// </summary>
        public cvec5 xxyxy => new cvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns cvec2.rrgrg swizzling (equivalent to cvec2.xxyxy).
        /// </summary>
        public cvec5 rrgrg => new cvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns cvec2.xxyy swizzling.
        /// </summary>
        public cvec4 xxyy => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec2.rrgg swizzling (equivalent to cvec2.xxyy).
        /// </summary>
        public cvec4 rrgg => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec2.xxyyx swizzling.
        /// </summary>
        public cvec5 xxyyx => new cvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns cvec2.rrggr swizzling (equivalent to cvec2.xxyyx).
        /// </summary>
        public cvec5 rrggr => new cvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns cvec2.xxyyy swizzling.
        /// </summary>
        public cvec5 xxyyy => new cvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns cvec2.rrggg swizzling (equivalent to cvec2.xxyyy).
        /// </summary>
        public cvec5 rrggg => new cvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns cvec2.xy swizzling.
        /// </summary>
        public cvec2 xy => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec2.rg swizzling (equivalent to cvec2.xy).
        /// </summary>
        public cvec2 rg => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec2.xyx swizzling.
        /// </summary>
        public cvec3 xyx => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec2.rgr swizzling (equivalent to cvec2.xyx).
        /// </summary>
        public cvec3 rgr => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec2.xyxx swizzling.
        /// </summary>
        public cvec4 xyxx => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec2.rgrr swizzling (equivalent to cvec2.xyxx).
        /// </summary>
        public cvec4 rgrr => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec2.xyxxx swizzling.
        /// </summary>
        public cvec5 xyxxx => new cvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns cvec2.rgrrr swizzling (equivalent to cvec2.xyxxx).
        /// </summary>
        public cvec5 rgrrr => new cvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns cvec2.xyxxy swizzling.
        /// </summary>
        public cvec5 xyxxy => new cvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns cvec2.rgrrg swizzling (equivalent to cvec2.xyxxy).
        /// </summary>
        public cvec5 rgrrg => new cvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns cvec2.xyxy swizzling.
        /// </summary>
        public cvec4 xyxy => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec2.rgrg swizzling (equivalent to cvec2.xyxy).
        /// </summary>
        public cvec4 rgrg => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec2.xyxyx swizzling.
        /// </summary>
        public cvec5 xyxyx => new cvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns cvec2.rgrgr swizzling (equivalent to cvec2.xyxyx).
        /// </summary>
        public cvec5 rgrgr => new cvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns cvec2.xyxyy swizzling.
        /// </summary>
        public cvec5 xyxyy => new cvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns cvec2.rgrgg swizzling (equivalent to cvec2.xyxyy).
        /// </summary>
        public cvec5 rgrgg => new cvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns cvec2.xyy swizzling.
        /// </summary>
        public cvec3 xyy => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec2.rgg swizzling (equivalent to cvec2.xyy).
        /// </summary>
        public cvec3 rgg => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec2.xyyx swizzling.
        /// </summary>
        public cvec4 xyyx => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec2.rggr swizzling (equivalent to cvec2.xyyx).
        /// </summary>
        public cvec4 rggr => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec2.xyyxx swizzling.
        /// </summary>
        public cvec5 xyyxx => new cvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns cvec2.rggrr swizzling (equivalent to cvec2.xyyxx).
        /// </summary>
        public cvec5 rggrr => new cvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns cvec2.xyyxy swizzling.
        /// </summary>
        public cvec5 xyyxy => new cvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns cvec2.rggrg swizzling (equivalent to cvec2.xyyxy).
        /// </summary>
        public cvec5 rggrg => new cvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns cvec2.xyyy swizzling.
        /// </summary>
        public cvec4 xyyy => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec2.rggg swizzling (equivalent to cvec2.xyyy).
        /// </summary>
        public cvec4 rggg => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec2.xyyyx swizzling.
        /// </summary>
        public cvec5 xyyyx => new cvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns cvec2.rgggr swizzling (equivalent to cvec2.xyyyx).
        /// </summary>
        public cvec5 rgggr => new cvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns cvec2.xyyyy swizzling.
        /// </summary>
        public cvec5 xyyyy => new cvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns cvec2.rgggg swizzling (equivalent to cvec2.xyyyy).
        /// </summary>
        public cvec5 rgggg => new cvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns cvec2.yx swizzling.
        /// </summary>
        public cvec2 yx => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec2.gr swizzling (equivalent to cvec2.yx).
        /// </summary>
        public cvec2 gr => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec2.yxx swizzling.
        /// </summary>
        public cvec3 yxx => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec2.grr swizzling (equivalent to cvec2.yxx).
        /// </summary>
        public cvec3 grr => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec2.yxxx swizzling.
        /// </summary>
        public cvec4 yxxx => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec2.grrr swizzling (equivalent to cvec2.yxxx).
        /// </summary>
        public cvec4 grrr => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec2.yxxxx swizzling.
        /// </summary>
        public cvec5 yxxxx => new cvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns cvec2.grrrr swizzling (equivalent to cvec2.yxxxx).
        /// </summary>
        public cvec5 grrrr => new cvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns cvec2.yxxxy swizzling.
        /// </summary>
        public cvec5 yxxxy => new cvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns cvec2.grrrg swizzling (equivalent to cvec2.yxxxy).
        /// </summary>
        public cvec5 grrrg => new cvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns cvec2.yxxy swizzling.
        /// </summary>
        public cvec4 yxxy => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec2.grrg swizzling (equivalent to cvec2.yxxy).
        /// </summary>
        public cvec4 grrg => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec2.yxxyx swizzling.
        /// </summary>
        public cvec5 yxxyx => new cvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns cvec2.grrgr swizzling (equivalent to cvec2.yxxyx).
        /// </summary>
        public cvec5 grrgr => new cvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns cvec2.yxxyy swizzling.
        /// </summary>
        public cvec5 yxxyy => new cvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns cvec2.grrgg swizzling (equivalent to cvec2.yxxyy).
        /// </summary>
        public cvec5 grrgg => new cvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns cvec2.yxy swizzling.
        /// </summary>
        public cvec3 yxy => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec2.grg swizzling (equivalent to cvec2.yxy).
        /// </summary>
        public cvec3 grg => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec2.yxyx swizzling.
        /// </summary>
        public cvec4 yxyx => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec2.grgr swizzling (equivalent to cvec2.yxyx).
        /// </summary>
        public cvec4 grgr => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec2.yxyxx swizzling.
        /// </summary>
        public cvec5 yxyxx => new cvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns cvec2.grgrr swizzling (equivalent to cvec2.yxyxx).
        /// </summary>
        public cvec5 grgrr => new cvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns cvec2.yxyxy swizzling.
        /// </summary>
        public cvec5 yxyxy => new cvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns cvec2.grgrg swizzling (equivalent to cvec2.yxyxy).
        /// </summary>
        public cvec5 grgrg => new cvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns cvec2.yxyy swizzling.
        /// </summary>
        public cvec4 yxyy => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec2.grgg swizzling (equivalent to cvec2.yxyy).
        /// </summary>
        public cvec4 grgg => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec2.yxyyx swizzling.
        /// </summary>
        public cvec5 yxyyx => new cvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns cvec2.grggr swizzling (equivalent to cvec2.yxyyx).
        /// </summary>
        public cvec5 grggr => new cvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns cvec2.yxyyy swizzling.
        /// </summary>
        public cvec5 yxyyy => new cvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns cvec2.grggg swizzling (equivalent to cvec2.yxyyy).
        /// </summary>
        public cvec5 grggg => new cvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns cvec2.yy swizzling.
        /// </summary>
        public cvec2 yy => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec2.gg swizzling (equivalent to cvec2.yy).
        /// </summary>
        public cvec2 gg => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec2.yyx swizzling.
        /// </summary>
        public cvec3 yyx => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec2.ggr swizzling (equivalent to cvec2.yyx).
        /// </summary>
        public cvec3 ggr => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec2.yyxx swizzling.
        /// </summary>
        public cvec4 yyxx => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec2.ggrr swizzling (equivalent to cvec2.yyxx).
        /// </summary>
        public cvec4 ggrr => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec2.yyxxx swizzling.
        /// </summary>
        public cvec5 yyxxx => new cvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns cvec2.ggrrr swizzling (equivalent to cvec2.yyxxx).
        /// </summary>
        public cvec5 ggrrr => new cvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns cvec2.yyxxy swizzling.
        /// </summary>
        public cvec5 yyxxy => new cvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns cvec2.ggrrg swizzling (equivalent to cvec2.yyxxy).
        /// </summary>
        public cvec5 ggrrg => new cvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns cvec2.yyxy swizzling.
        /// </summary>
        public cvec4 yyxy => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec2.ggrg swizzling (equivalent to cvec2.yyxy).
        /// </summary>
        public cvec4 ggrg => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec2.yyxyx swizzling.
        /// </summary>
        public cvec5 yyxyx => new cvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns cvec2.ggrgr swizzling (equivalent to cvec2.yyxyx).
        /// </summary>
        public cvec5 ggrgr => new cvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns cvec2.yyxyy swizzling.
        /// </summary>
        public cvec5 yyxyy => new cvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns cvec2.ggrgg swizzling (equivalent to cvec2.yyxyy).
        /// </summary>
        public cvec5 ggrgg => new cvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns cvec2.yyy swizzling.
        /// </summary>
        public cvec3 yyy => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec2.ggg swizzling (equivalent to cvec2.yyy).
        /// </summary>
        public cvec3 ggg => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec2.yyyx swizzling.
        /// </summary>
        public cvec4 yyyx => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec2.gggr swizzling (equivalent to cvec2.yyyx).
        /// </summary>
        public cvec4 gggr => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec2.yyyxx swizzling.
        /// </summary>
        public cvec5 yyyxx => new cvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns cvec2.gggrr swizzling (equivalent to cvec2.yyyxx).
        /// </summary>
        public cvec5 gggrr => new cvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns cvec2.yyyxy swizzling.
        /// </summary>
        public cvec5 yyyxy => new cvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns cvec2.gggrg swizzling (equivalent to cvec2.yyyxy).
        /// </summary>
        public cvec5 gggrg => new cvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns cvec2.yyyy swizzling.
        /// </summary>
        public cvec4 yyyy => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec2.gggg swizzling (equivalent to cvec2.yyyy).
        /// </summary>
        public cvec4 gggg => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec2.yyyyx swizzling.
        /// </summary>
        public cvec5 yyyyx => new cvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns cvec2.ggggr swizzling (equivalent to cvec2.yyyyx).
        /// </summary>
        public cvec5 ggggr => new cvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns cvec2.yyyyy swizzling.
        /// </summary>
        public cvec5 yyyyy => new cvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns cvec2.ggggg swizzling (equivalent to cvec2.yyyyy).
        /// </summary>
        public cvec5 ggggg => new cvec5(y, y, y, y, y);

        #endregion

    }
}
