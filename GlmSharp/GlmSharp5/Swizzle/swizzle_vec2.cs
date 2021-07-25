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
    /// Temporary vector of type float with 2 components, used for implementing swizzling for vec2.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_vec2
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly float y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_vec2.
        /// </summary>
        internal swizzle_vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns vec2.xx swizzling.
        /// </summary>
        public vec2 xx => new vec2(x, x);
        
        /// <summary>
        /// Returns vec2.rr swizzling (equivalent to vec2.xx).
        /// </summary>
        public vec2 rr => new vec2(x, x);
        
        /// <summary>
        /// Returns vec2.xxx swizzling.
        /// </summary>
        public vec3 xxx => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec2.rrr swizzling (equivalent to vec2.xxx).
        /// </summary>
        public vec3 rrr => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec2.xxxx swizzling.
        /// </summary>
        public vec4 xxxx => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec2.rrrr swizzling (equivalent to vec2.xxxx).
        /// </summary>
        public vec4 rrrr => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec2.xxxxx swizzling.
        /// </summary>
        public vec5 xxxxx => new vec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns vec2.rrrrr swizzling (equivalent to vec2.xxxxx).
        /// </summary>
        public vec5 rrrrr => new vec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns vec2.xxxxy swizzling.
        /// </summary>
        public vec5 xxxxy => new vec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns vec2.rrrrg swizzling (equivalent to vec2.xxxxy).
        /// </summary>
        public vec5 rrrrg => new vec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns vec2.xxxy swizzling.
        /// </summary>
        public vec4 xxxy => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec2.rrrg swizzling (equivalent to vec2.xxxy).
        /// </summary>
        public vec4 rrrg => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec2.xxxyx swizzling.
        /// </summary>
        public vec5 xxxyx => new vec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns vec2.rrrgr swizzling (equivalent to vec2.xxxyx).
        /// </summary>
        public vec5 rrrgr => new vec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns vec2.xxxyy swizzling.
        /// </summary>
        public vec5 xxxyy => new vec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns vec2.rrrgg swizzling (equivalent to vec2.xxxyy).
        /// </summary>
        public vec5 rrrgg => new vec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns vec2.xxy swizzling.
        /// </summary>
        public vec3 xxy => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec2.rrg swizzling (equivalent to vec2.xxy).
        /// </summary>
        public vec3 rrg => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec2.xxyx swizzling.
        /// </summary>
        public vec4 xxyx => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec2.rrgr swizzling (equivalent to vec2.xxyx).
        /// </summary>
        public vec4 rrgr => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec2.xxyxx swizzling.
        /// </summary>
        public vec5 xxyxx => new vec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns vec2.rrgrr swizzling (equivalent to vec2.xxyxx).
        /// </summary>
        public vec5 rrgrr => new vec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns vec2.xxyxy swizzling.
        /// </summary>
        public vec5 xxyxy => new vec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns vec2.rrgrg swizzling (equivalent to vec2.xxyxy).
        /// </summary>
        public vec5 rrgrg => new vec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns vec2.xxyy swizzling.
        /// </summary>
        public vec4 xxyy => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec2.rrgg swizzling (equivalent to vec2.xxyy).
        /// </summary>
        public vec4 rrgg => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec2.xxyyx swizzling.
        /// </summary>
        public vec5 xxyyx => new vec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns vec2.rrggr swizzling (equivalent to vec2.xxyyx).
        /// </summary>
        public vec5 rrggr => new vec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns vec2.xxyyy swizzling.
        /// </summary>
        public vec5 xxyyy => new vec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns vec2.rrggg swizzling (equivalent to vec2.xxyyy).
        /// </summary>
        public vec5 rrggg => new vec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns vec2.xy swizzling.
        /// </summary>
        public vec2 xy => new vec2(x, y);
        
        /// <summary>
        /// Returns vec2.rg swizzling (equivalent to vec2.xy).
        /// </summary>
        public vec2 rg => new vec2(x, y);
        
        /// <summary>
        /// Returns vec2.xyx swizzling.
        /// </summary>
        public vec3 xyx => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec2.rgr swizzling (equivalent to vec2.xyx).
        /// </summary>
        public vec3 rgr => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec2.xyxx swizzling.
        /// </summary>
        public vec4 xyxx => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec2.rgrr swizzling (equivalent to vec2.xyxx).
        /// </summary>
        public vec4 rgrr => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec2.xyxxx swizzling.
        /// </summary>
        public vec5 xyxxx => new vec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns vec2.rgrrr swizzling (equivalent to vec2.xyxxx).
        /// </summary>
        public vec5 rgrrr => new vec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns vec2.xyxxy swizzling.
        /// </summary>
        public vec5 xyxxy => new vec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns vec2.rgrrg swizzling (equivalent to vec2.xyxxy).
        /// </summary>
        public vec5 rgrrg => new vec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns vec2.xyxy swizzling.
        /// </summary>
        public vec4 xyxy => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec2.rgrg swizzling (equivalent to vec2.xyxy).
        /// </summary>
        public vec4 rgrg => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec2.xyxyx swizzling.
        /// </summary>
        public vec5 xyxyx => new vec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns vec2.rgrgr swizzling (equivalent to vec2.xyxyx).
        /// </summary>
        public vec5 rgrgr => new vec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns vec2.xyxyy swizzling.
        /// </summary>
        public vec5 xyxyy => new vec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns vec2.rgrgg swizzling (equivalent to vec2.xyxyy).
        /// </summary>
        public vec5 rgrgg => new vec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns vec2.xyy swizzling.
        /// </summary>
        public vec3 xyy => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec2.rgg swizzling (equivalent to vec2.xyy).
        /// </summary>
        public vec3 rgg => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec2.xyyx swizzling.
        /// </summary>
        public vec4 xyyx => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec2.rggr swizzling (equivalent to vec2.xyyx).
        /// </summary>
        public vec4 rggr => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec2.xyyxx swizzling.
        /// </summary>
        public vec5 xyyxx => new vec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns vec2.rggrr swizzling (equivalent to vec2.xyyxx).
        /// </summary>
        public vec5 rggrr => new vec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns vec2.xyyxy swizzling.
        /// </summary>
        public vec5 xyyxy => new vec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns vec2.rggrg swizzling (equivalent to vec2.xyyxy).
        /// </summary>
        public vec5 rggrg => new vec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns vec2.xyyy swizzling.
        /// </summary>
        public vec4 xyyy => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec2.rggg swizzling (equivalent to vec2.xyyy).
        /// </summary>
        public vec4 rggg => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec2.xyyyx swizzling.
        /// </summary>
        public vec5 xyyyx => new vec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns vec2.rgggr swizzling (equivalent to vec2.xyyyx).
        /// </summary>
        public vec5 rgggr => new vec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns vec2.xyyyy swizzling.
        /// </summary>
        public vec5 xyyyy => new vec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns vec2.rgggg swizzling (equivalent to vec2.xyyyy).
        /// </summary>
        public vec5 rgggg => new vec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns vec2.yx swizzling.
        /// </summary>
        public vec2 yx => new vec2(y, x);
        
        /// <summary>
        /// Returns vec2.gr swizzling (equivalent to vec2.yx).
        /// </summary>
        public vec2 gr => new vec2(y, x);
        
        /// <summary>
        /// Returns vec2.yxx swizzling.
        /// </summary>
        public vec3 yxx => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec2.grr swizzling (equivalent to vec2.yxx).
        /// </summary>
        public vec3 grr => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec2.yxxx swizzling.
        /// </summary>
        public vec4 yxxx => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec2.grrr swizzling (equivalent to vec2.yxxx).
        /// </summary>
        public vec4 grrr => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec2.yxxxx swizzling.
        /// </summary>
        public vec5 yxxxx => new vec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns vec2.grrrr swizzling (equivalent to vec2.yxxxx).
        /// </summary>
        public vec5 grrrr => new vec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns vec2.yxxxy swizzling.
        /// </summary>
        public vec5 yxxxy => new vec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns vec2.grrrg swizzling (equivalent to vec2.yxxxy).
        /// </summary>
        public vec5 grrrg => new vec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns vec2.yxxy swizzling.
        /// </summary>
        public vec4 yxxy => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec2.grrg swizzling (equivalent to vec2.yxxy).
        /// </summary>
        public vec4 grrg => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec2.yxxyx swizzling.
        /// </summary>
        public vec5 yxxyx => new vec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns vec2.grrgr swizzling (equivalent to vec2.yxxyx).
        /// </summary>
        public vec5 grrgr => new vec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns vec2.yxxyy swizzling.
        /// </summary>
        public vec5 yxxyy => new vec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns vec2.grrgg swizzling (equivalent to vec2.yxxyy).
        /// </summary>
        public vec5 grrgg => new vec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns vec2.yxy swizzling.
        /// </summary>
        public vec3 yxy => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec2.grg swizzling (equivalent to vec2.yxy).
        /// </summary>
        public vec3 grg => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec2.yxyx swizzling.
        /// </summary>
        public vec4 yxyx => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec2.grgr swizzling (equivalent to vec2.yxyx).
        /// </summary>
        public vec4 grgr => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec2.yxyxx swizzling.
        /// </summary>
        public vec5 yxyxx => new vec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns vec2.grgrr swizzling (equivalent to vec2.yxyxx).
        /// </summary>
        public vec5 grgrr => new vec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns vec2.yxyxy swizzling.
        /// </summary>
        public vec5 yxyxy => new vec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns vec2.grgrg swizzling (equivalent to vec2.yxyxy).
        /// </summary>
        public vec5 grgrg => new vec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns vec2.yxyy swizzling.
        /// </summary>
        public vec4 yxyy => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec2.grgg swizzling (equivalent to vec2.yxyy).
        /// </summary>
        public vec4 grgg => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec2.yxyyx swizzling.
        /// </summary>
        public vec5 yxyyx => new vec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns vec2.grggr swizzling (equivalent to vec2.yxyyx).
        /// </summary>
        public vec5 grggr => new vec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns vec2.yxyyy swizzling.
        /// </summary>
        public vec5 yxyyy => new vec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns vec2.grggg swizzling (equivalent to vec2.yxyyy).
        /// </summary>
        public vec5 grggg => new vec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns vec2.yy swizzling.
        /// </summary>
        public vec2 yy => new vec2(y, y);
        
        /// <summary>
        /// Returns vec2.gg swizzling (equivalent to vec2.yy).
        /// </summary>
        public vec2 gg => new vec2(y, y);
        
        /// <summary>
        /// Returns vec2.yyx swizzling.
        /// </summary>
        public vec3 yyx => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec2.ggr swizzling (equivalent to vec2.yyx).
        /// </summary>
        public vec3 ggr => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec2.yyxx swizzling.
        /// </summary>
        public vec4 yyxx => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec2.ggrr swizzling (equivalent to vec2.yyxx).
        /// </summary>
        public vec4 ggrr => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec2.yyxxx swizzling.
        /// </summary>
        public vec5 yyxxx => new vec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns vec2.ggrrr swizzling (equivalent to vec2.yyxxx).
        /// </summary>
        public vec5 ggrrr => new vec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns vec2.yyxxy swizzling.
        /// </summary>
        public vec5 yyxxy => new vec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns vec2.ggrrg swizzling (equivalent to vec2.yyxxy).
        /// </summary>
        public vec5 ggrrg => new vec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns vec2.yyxy swizzling.
        /// </summary>
        public vec4 yyxy => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec2.ggrg swizzling (equivalent to vec2.yyxy).
        /// </summary>
        public vec4 ggrg => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec2.yyxyx swizzling.
        /// </summary>
        public vec5 yyxyx => new vec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns vec2.ggrgr swizzling (equivalent to vec2.yyxyx).
        /// </summary>
        public vec5 ggrgr => new vec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns vec2.yyxyy swizzling.
        /// </summary>
        public vec5 yyxyy => new vec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns vec2.ggrgg swizzling (equivalent to vec2.yyxyy).
        /// </summary>
        public vec5 ggrgg => new vec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns vec2.yyy swizzling.
        /// </summary>
        public vec3 yyy => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec2.ggg swizzling (equivalent to vec2.yyy).
        /// </summary>
        public vec3 ggg => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec2.yyyx swizzling.
        /// </summary>
        public vec4 yyyx => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec2.gggr swizzling (equivalent to vec2.yyyx).
        /// </summary>
        public vec4 gggr => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec2.yyyxx swizzling.
        /// </summary>
        public vec5 yyyxx => new vec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns vec2.gggrr swizzling (equivalent to vec2.yyyxx).
        /// </summary>
        public vec5 gggrr => new vec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns vec2.yyyxy swizzling.
        /// </summary>
        public vec5 yyyxy => new vec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns vec2.gggrg swizzling (equivalent to vec2.yyyxy).
        /// </summary>
        public vec5 gggrg => new vec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns vec2.yyyy swizzling.
        /// </summary>
        public vec4 yyyy => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec2.gggg swizzling (equivalent to vec2.yyyy).
        /// </summary>
        public vec4 gggg => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec2.yyyyx swizzling.
        /// </summary>
        public vec5 yyyyx => new vec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns vec2.ggggr swizzling (equivalent to vec2.yyyyx).
        /// </summary>
        public vec5 ggggr => new vec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns vec2.yyyyy swizzling.
        /// </summary>
        public vec5 yyyyy => new vec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns vec2.ggggg swizzling (equivalent to vec2.yyyyy).
        /// </summary>
        public vec5 ggggg => new vec5(y, y, y, y, y);

        #endregion

    }
}
