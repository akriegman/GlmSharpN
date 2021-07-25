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
    /// Temporary vector of type T with 2 components, used for implementing swizzling for gvec2.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_gvec2<T>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly T x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly T y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_gvec2.
        /// </summary>
        internal swizzle_gvec2(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns gvec2.xx swizzling.
        /// </summary>
        public gvec2<T> xx => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec2.rr swizzling (equivalent to gvec2.xx).
        /// </summary>
        public gvec2<T> rr => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec2.xxx swizzling.
        /// </summary>
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec2.rrr swizzling (equivalent to gvec2.xxx).
        /// </summary>
        public gvec3<T> rrr => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec2.xxxx swizzling.
        /// </summary>
        public gvec4<T> xxxx => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec2.rrrr swizzling (equivalent to gvec2.xxxx).
        /// </summary>
        public gvec4<T> rrrr => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec2.xxxxx swizzling.
        /// </summary>
        public gvec5<T> xxxxx => new gvec5<T>(x, x, x, x, x);
        
        /// <summary>
        /// Returns gvec2.rrrrr swizzling (equivalent to gvec2.xxxxx).
        /// </summary>
        public gvec5<T> rrrrr => new gvec5<T>(x, x, x, x, x);
        
        /// <summary>
        /// Returns gvec2.xxxxy swizzling.
        /// </summary>
        public gvec5<T> xxxxy => new gvec5<T>(x, x, x, x, y);
        
        /// <summary>
        /// Returns gvec2.rrrrg swizzling (equivalent to gvec2.xxxxy).
        /// </summary>
        public gvec5<T> rrrrg => new gvec5<T>(x, x, x, x, y);
        
        /// <summary>
        /// Returns gvec2.xxxy swizzling.
        /// </summary>
        public gvec4<T> xxxy => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec2.rrrg swizzling (equivalent to gvec2.xxxy).
        /// </summary>
        public gvec4<T> rrrg => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec2.xxxyx swizzling.
        /// </summary>
        public gvec5<T> xxxyx => new gvec5<T>(x, x, x, y, x);
        
        /// <summary>
        /// Returns gvec2.rrrgr swizzling (equivalent to gvec2.xxxyx).
        /// </summary>
        public gvec5<T> rrrgr => new gvec5<T>(x, x, x, y, x);
        
        /// <summary>
        /// Returns gvec2.xxxyy swizzling.
        /// </summary>
        public gvec5<T> xxxyy => new gvec5<T>(x, x, x, y, y);
        
        /// <summary>
        /// Returns gvec2.rrrgg swizzling (equivalent to gvec2.xxxyy).
        /// </summary>
        public gvec5<T> rrrgg => new gvec5<T>(x, x, x, y, y);
        
        /// <summary>
        /// Returns gvec2.xxy swizzling.
        /// </summary>
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec2.rrg swizzling (equivalent to gvec2.xxy).
        /// </summary>
        public gvec3<T> rrg => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec2.xxyx swizzling.
        /// </summary>
        public gvec4<T> xxyx => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec2.rrgr swizzling (equivalent to gvec2.xxyx).
        /// </summary>
        public gvec4<T> rrgr => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec2.xxyxx swizzling.
        /// </summary>
        public gvec5<T> xxyxx => new gvec5<T>(x, x, y, x, x);
        
        /// <summary>
        /// Returns gvec2.rrgrr swizzling (equivalent to gvec2.xxyxx).
        /// </summary>
        public gvec5<T> rrgrr => new gvec5<T>(x, x, y, x, x);
        
        /// <summary>
        /// Returns gvec2.xxyxy swizzling.
        /// </summary>
        public gvec5<T> xxyxy => new gvec5<T>(x, x, y, x, y);
        
        /// <summary>
        /// Returns gvec2.rrgrg swizzling (equivalent to gvec2.xxyxy).
        /// </summary>
        public gvec5<T> rrgrg => new gvec5<T>(x, x, y, x, y);
        
        /// <summary>
        /// Returns gvec2.xxyy swizzling.
        /// </summary>
        public gvec4<T> xxyy => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec2.rrgg swizzling (equivalent to gvec2.xxyy).
        /// </summary>
        public gvec4<T> rrgg => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec2.xxyyx swizzling.
        /// </summary>
        public gvec5<T> xxyyx => new gvec5<T>(x, x, y, y, x);
        
        /// <summary>
        /// Returns gvec2.rrggr swizzling (equivalent to gvec2.xxyyx).
        /// </summary>
        public gvec5<T> rrggr => new gvec5<T>(x, x, y, y, x);
        
        /// <summary>
        /// Returns gvec2.xxyyy swizzling.
        /// </summary>
        public gvec5<T> xxyyy => new gvec5<T>(x, x, y, y, y);
        
        /// <summary>
        /// Returns gvec2.rrggg swizzling (equivalent to gvec2.xxyyy).
        /// </summary>
        public gvec5<T> rrggg => new gvec5<T>(x, x, y, y, y);
        
        /// <summary>
        /// Returns gvec2.xy swizzling.
        /// </summary>
        public gvec2<T> xy => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec2.rg swizzling (equivalent to gvec2.xy).
        /// </summary>
        public gvec2<T> rg => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec2.xyx swizzling.
        /// </summary>
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec2.rgr swizzling (equivalent to gvec2.xyx).
        /// </summary>
        public gvec3<T> rgr => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec2.xyxx swizzling.
        /// </summary>
        public gvec4<T> xyxx => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec2.rgrr swizzling (equivalent to gvec2.xyxx).
        /// </summary>
        public gvec4<T> rgrr => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec2.xyxxx swizzling.
        /// </summary>
        public gvec5<T> xyxxx => new gvec5<T>(x, y, x, x, x);
        
        /// <summary>
        /// Returns gvec2.rgrrr swizzling (equivalent to gvec2.xyxxx).
        /// </summary>
        public gvec5<T> rgrrr => new gvec5<T>(x, y, x, x, x);
        
        /// <summary>
        /// Returns gvec2.xyxxy swizzling.
        /// </summary>
        public gvec5<T> xyxxy => new gvec5<T>(x, y, x, x, y);
        
        /// <summary>
        /// Returns gvec2.rgrrg swizzling (equivalent to gvec2.xyxxy).
        /// </summary>
        public gvec5<T> rgrrg => new gvec5<T>(x, y, x, x, y);
        
        /// <summary>
        /// Returns gvec2.xyxy swizzling.
        /// </summary>
        public gvec4<T> xyxy => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec2.rgrg swizzling (equivalent to gvec2.xyxy).
        /// </summary>
        public gvec4<T> rgrg => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec2.xyxyx swizzling.
        /// </summary>
        public gvec5<T> xyxyx => new gvec5<T>(x, y, x, y, x);
        
        /// <summary>
        /// Returns gvec2.rgrgr swizzling (equivalent to gvec2.xyxyx).
        /// </summary>
        public gvec5<T> rgrgr => new gvec5<T>(x, y, x, y, x);
        
        /// <summary>
        /// Returns gvec2.xyxyy swizzling.
        /// </summary>
        public gvec5<T> xyxyy => new gvec5<T>(x, y, x, y, y);
        
        /// <summary>
        /// Returns gvec2.rgrgg swizzling (equivalent to gvec2.xyxyy).
        /// </summary>
        public gvec5<T> rgrgg => new gvec5<T>(x, y, x, y, y);
        
        /// <summary>
        /// Returns gvec2.xyy swizzling.
        /// </summary>
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec2.rgg swizzling (equivalent to gvec2.xyy).
        /// </summary>
        public gvec3<T> rgg => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec2.xyyx swizzling.
        /// </summary>
        public gvec4<T> xyyx => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec2.rggr swizzling (equivalent to gvec2.xyyx).
        /// </summary>
        public gvec4<T> rggr => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec2.xyyxx swizzling.
        /// </summary>
        public gvec5<T> xyyxx => new gvec5<T>(x, y, y, x, x);
        
        /// <summary>
        /// Returns gvec2.rggrr swizzling (equivalent to gvec2.xyyxx).
        /// </summary>
        public gvec5<T> rggrr => new gvec5<T>(x, y, y, x, x);
        
        /// <summary>
        /// Returns gvec2.xyyxy swizzling.
        /// </summary>
        public gvec5<T> xyyxy => new gvec5<T>(x, y, y, x, y);
        
        /// <summary>
        /// Returns gvec2.rggrg swizzling (equivalent to gvec2.xyyxy).
        /// </summary>
        public gvec5<T> rggrg => new gvec5<T>(x, y, y, x, y);
        
        /// <summary>
        /// Returns gvec2.xyyy swizzling.
        /// </summary>
        public gvec4<T> xyyy => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec2.rggg swizzling (equivalent to gvec2.xyyy).
        /// </summary>
        public gvec4<T> rggg => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec2.xyyyx swizzling.
        /// </summary>
        public gvec5<T> xyyyx => new gvec5<T>(x, y, y, y, x);
        
        /// <summary>
        /// Returns gvec2.rgggr swizzling (equivalent to gvec2.xyyyx).
        /// </summary>
        public gvec5<T> rgggr => new gvec5<T>(x, y, y, y, x);
        
        /// <summary>
        /// Returns gvec2.xyyyy swizzling.
        /// </summary>
        public gvec5<T> xyyyy => new gvec5<T>(x, y, y, y, y);
        
        /// <summary>
        /// Returns gvec2.rgggg swizzling (equivalent to gvec2.xyyyy).
        /// </summary>
        public gvec5<T> rgggg => new gvec5<T>(x, y, y, y, y);
        
        /// <summary>
        /// Returns gvec2.yx swizzling.
        /// </summary>
        public gvec2<T> yx => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec2.gr swizzling (equivalent to gvec2.yx).
        /// </summary>
        public gvec2<T> gr => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec2.yxx swizzling.
        /// </summary>
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec2.grr swizzling (equivalent to gvec2.yxx).
        /// </summary>
        public gvec3<T> grr => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec2.yxxx swizzling.
        /// </summary>
        public gvec4<T> yxxx => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec2.grrr swizzling (equivalent to gvec2.yxxx).
        /// </summary>
        public gvec4<T> grrr => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec2.yxxxx swizzling.
        /// </summary>
        public gvec5<T> yxxxx => new gvec5<T>(y, x, x, x, x);
        
        /// <summary>
        /// Returns gvec2.grrrr swizzling (equivalent to gvec2.yxxxx).
        /// </summary>
        public gvec5<T> grrrr => new gvec5<T>(y, x, x, x, x);
        
        /// <summary>
        /// Returns gvec2.yxxxy swizzling.
        /// </summary>
        public gvec5<T> yxxxy => new gvec5<T>(y, x, x, x, y);
        
        /// <summary>
        /// Returns gvec2.grrrg swizzling (equivalent to gvec2.yxxxy).
        /// </summary>
        public gvec5<T> grrrg => new gvec5<T>(y, x, x, x, y);
        
        /// <summary>
        /// Returns gvec2.yxxy swizzling.
        /// </summary>
        public gvec4<T> yxxy => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec2.grrg swizzling (equivalent to gvec2.yxxy).
        /// </summary>
        public gvec4<T> grrg => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec2.yxxyx swizzling.
        /// </summary>
        public gvec5<T> yxxyx => new gvec5<T>(y, x, x, y, x);
        
        /// <summary>
        /// Returns gvec2.grrgr swizzling (equivalent to gvec2.yxxyx).
        /// </summary>
        public gvec5<T> grrgr => new gvec5<T>(y, x, x, y, x);
        
        /// <summary>
        /// Returns gvec2.yxxyy swizzling.
        /// </summary>
        public gvec5<T> yxxyy => new gvec5<T>(y, x, x, y, y);
        
        /// <summary>
        /// Returns gvec2.grrgg swizzling (equivalent to gvec2.yxxyy).
        /// </summary>
        public gvec5<T> grrgg => new gvec5<T>(y, x, x, y, y);
        
        /// <summary>
        /// Returns gvec2.yxy swizzling.
        /// </summary>
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec2.grg swizzling (equivalent to gvec2.yxy).
        /// </summary>
        public gvec3<T> grg => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec2.yxyx swizzling.
        /// </summary>
        public gvec4<T> yxyx => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec2.grgr swizzling (equivalent to gvec2.yxyx).
        /// </summary>
        public gvec4<T> grgr => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec2.yxyxx swizzling.
        /// </summary>
        public gvec5<T> yxyxx => new gvec5<T>(y, x, y, x, x);
        
        /// <summary>
        /// Returns gvec2.grgrr swizzling (equivalent to gvec2.yxyxx).
        /// </summary>
        public gvec5<T> grgrr => new gvec5<T>(y, x, y, x, x);
        
        /// <summary>
        /// Returns gvec2.yxyxy swizzling.
        /// </summary>
        public gvec5<T> yxyxy => new gvec5<T>(y, x, y, x, y);
        
        /// <summary>
        /// Returns gvec2.grgrg swizzling (equivalent to gvec2.yxyxy).
        /// </summary>
        public gvec5<T> grgrg => new gvec5<T>(y, x, y, x, y);
        
        /// <summary>
        /// Returns gvec2.yxyy swizzling.
        /// </summary>
        public gvec4<T> yxyy => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec2.grgg swizzling (equivalent to gvec2.yxyy).
        /// </summary>
        public gvec4<T> grgg => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec2.yxyyx swizzling.
        /// </summary>
        public gvec5<T> yxyyx => new gvec5<T>(y, x, y, y, x);
        
        /// <summary>
        /// Returns gvec2.grggr swizzling (equivalent to gvec2.yxyyx).
        /// </summary>
        public gvec5<T> grggr => new gvec5<T>(y, x, y, y, x);
        
        /// <summary>
        /// Returns gvec2.yxyyy swizzling.
        /// </summary>
        public gvec5<T> yxyyy => new gvec5<T>(y, x, y, y, y);
        
        /// <summary>
        /// Returns gvec2.grggg swizzling (equivalent to gvec2.yxyyy).
        /// </summary>
        public gvec5<T> grggg => new gvec5<T>(y, x, y, y, y);
        
        /// <summary>
        /// Returns gvec2.yy swizzling.
        /// </summary>
        public gvec2<T> yy => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec2.gg swizzling (equivalent to gvec2.yy).
        /// </summary>
        public gvec2<T> gg => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec2.yyx swizzling.
        /// </summary>
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec2.ggr swizzling (equivalent to gvec2.yyx).
        /// </summary>
        public gvec3<T> ggr => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec2.yyxx swizzling.
        /// </summary>
        public gvec4<T> yyxx => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec2.ggrr swizzling (equivalent to gvec2.yyxx).
        /// </summary>
        public gvec4<T> ggrr => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec2.yyxxx swizzling.
        /// </summary>
        public gvec5<T> yyxxx => new gvec5<T>(y, y, x, x, x);
        
        /// <summary>
        /// Returns gvec2.ggrrr swizzling (equivalent to gvec2.yyxxx).
        /// </summary>
        public gvec5<T> ggrrr => new gvec5<T>(y, y, x, x, x);
        
        /// <summary>
        /// Returns gvec2.yyxxy swizzling.
        /// </summary>
        public gvec5<T> yyxxy => new gvec5<T>(y, y, x, x, y);
        
        /// <summary>
        /// Returns gvec2.ggrrg swizzling (equivalent to gvec2.yyxxy).
        /// </summary>
        public gvec5<T> ggrrg => new gvec5<T>(y, y, x, x, y);
        
        /// <summary>
        /// Returns gvec2.yyxy swizzling.
        /// </summary>
        public gvec4<T> yyxy => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec2.ggrg swizzling (equivalent to gvec2.yyxy).
        /// </summary>
        public gvec4<T> ggrg => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec2.yyxyx swizzling.
        /// </summary>
        public gvec5<T> yyxyx => new gvec5<T>(y, y, x, y, x);
        
        /// <summary>
        /// Returns gvec2.ggrgr swizzling (equivalent to gvec2.yyxyx).
        /// </summary>
        public gvec5<T> ggrgr => new gvec5<T>(y, y, x, y, x);
        
        /// <summary>
        /// Returns gvec2.yyxyy swizzling.
        /// </summary>
        public gvec5<T> yyxyy => new gvec5<T>(y, y, x, y, y);
        
        /// <summary>
        /// Returns gvec2.ggrgg swizzling (equivalent to gvec2.yyxyy).
        /// </summary>
        public gvec5<T> ggrgg => new gvec5<T>(y, y, x, y, y);
        
        /// <summary>
        /// Returns gvec2.yyy swizzling.
        /// </summary>
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec2.ggg swizzling (equivalent to gvec2.yyy).
        /// </summary>
        public gvec3<T> ggg => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec2.yyyx swizzling.
        /// </summary>
        public gvec4<T> yyyx => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec2.gggr swizzling (equivalent to gvec2.yyyx).
        /// </summary>
        public gvec4<T> gggr => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec2.yyyxx swizzling.
        /// </summary>
        public gvec5<T> yyyxx => new gvec5<T>(y, y, y, x, x);
        
        /// <summary>
        /// Returns gvec2.gggrr swizzling (equivalent to gvec2.yyyxx).
        /// </summary>
        public gvec5<T> gggrr => new gvec5<T>(y, y, y, x, x);
        
        /// <summary>
        /// Returns gvec2.yyyxy swizzling.
        /// </summary>
        public gvec5<T> yyyxy => new gvec5<T>(y, y, y, x, y);
        
        /// <summary>
        /// Returns gvec2.gggrg swizzling (equivalent to gvec2.yyyxy).
        /// </summary>
        public gvec5<T> gggrg => new gvec5<T>(y, y, y, x, y);
        
        /// <summary>
        /// Returns gvec2.yyyy swizzling.
        /// </summary>
        public gvec4<T> yyyy => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec2.gggg swizzling (equivalent to gvec2.yyyy).
        /// </summary>
        public gvec4<T> gggg => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec2.yyyyx swizzling.
        /// </summary>
        public gvec5<T> yyyyx => new gvec5<T>(y, y, y, y, x);
        
        /// <summary>
        /// Returns gvec2.ggggr swizzling (equivalent to gvec2.yyyyx).
        /// </summary>
        public gvec5<T> ggggr => new gvec5<T>(y, y, y, y, x);
        
        /// <summary>
        /// Returns gvec2.yyyyy swizzling.
        /// </summary>
        public gvec5<T> yyyyy => new gvec5<T>(y, y, y, y, y);
        
        /// <summary>
        /// Returns gvec2.ggggg swizzling (equivalent to gvec2.yyyyy).
        /// </summary>
        public gvec5<T> ggggg => new gvec5<T>(y, y, y, y, y);

        #endregion

    }
}
