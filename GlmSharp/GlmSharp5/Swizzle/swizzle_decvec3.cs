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
    /// Temporary vector of type decimal with 3 components, used for implementing swizzling for decvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_decvec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly decimal y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly decimal z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_decvec3.
        /// </summary>
        internal swizzle_decvec3(decimal x, decimal y, decimal z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns decvec3.xx swizzling.
        /// </summary>
        public decvec2 xx => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec3.rr swizzling (equivalent to decvec3.xx).
        /// </summary>
        public decvec2 rr => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec3.xxx swizzling.
        /// </summary>
        public decvec3 xxx => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec3.rrr swizzling (equivalent to decvec3.xxx).
        /// </summary>
        public decvec3 rrr => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec3.xxxx swizzling.
        /// </summary>
        public decvec4 xxxx => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.rrrr swizzling (equivalent to decvec3.xxxx).
        /// </summary>
        public decvec4 rrrr => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.xxxxx swizzling.
        /// </summary>
        public decvec5 xxxxx => new decvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.rrrrr swizzling (equivalent to decvec3.xxxxx).
        /// </summary>
        public decvec5 rrrrr => new decvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.xxxxy swizzling.
        /// </summary>
        public decvec5 xxxxy => new decvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.rrrrg swizzling (equivalent to decvec3.xxxxy).
        /// </summary>
        public decvec5 rrrrg => new decvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.xxxxz swizzling.
        /// </summary>
        public decvec5 xxxxz => new decvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.rrrrb swizzling (equivalent to decvec3.xxxxz).
        /// </summary>
        public decvec5 rrrrb => new decvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.xxxy swizzling.
        /// </summary>
        public decvec4 xxxy => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.rrrg swizzling (equivalent to decvec3.xxxy).
        /// </summary>
        public decvec4 rrrg => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.xxxyx swizzling.
        /// </summary>
        public decvec5 xxxyx => new decvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.rrrgr swizzling (equivalent to decvec3.xxxyx).
        /// </summary>
        public decvec5 rrrgr => new decvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.xxxyy swizzling.
        /// </summary>
        public decvec5 xxxyy => new decvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.rrrgg swizzling (equivalent to decvec3.xxxyy).
        /// </summary>
        public decvec5 rrrgg => new decvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.xxxyz swizzling.
        /// </summary>
        public decvec5 xxxyz => new decvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.rrrgb swizzling (equivalent to decvec3.xxxyz).
        /// </summary>
        public decvec5 rrrgb => new decvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.xxxz swizzling.
        /// </summary>
        public decvec4 xxxz => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.rrrb swizzling (equivalent to decvec3.xxxz).
        /// </summary>
        public decvec4 rrrb => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.xxxzx swizzling.
        /// </summary>
        public decvec5 xxxzx => new decvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.rrrbr swizzling (equivalent to decvec3.xxxzx).
        /// </summary>
        public decvec5 rrrbr => new decvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.xxxzy swizzling.
        /// </summary>
        public decvec5 xxxzy => new decvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.rrrbg swizzling (equivalent to decvec3.xxxzy).
        /// </summary>
        public decvec5 rrrbg => new decvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.xxxzz swizzling.
        /// </summary>
        public decvec5 xxxzz => new decvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.rrrbb swizzling (equivalent to decvec3.xxxzz).
        /// </summary>
        public decvec5 rrrbb => new decvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.xxy swizzling.
        /// </summary>
        public decvec3 xxy => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec3.rrg swizzling (equivalent to decvec3.xxy).
        /// </summary>
        public decvec3 rrg => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec3.xxyx swizzling.
        /// </summary>
        public decvec4 xxyx => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.rrgr swizzling (equivalent to decvec3.xxyx).
        /// </summary>
        public decvec4 rrgr => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.xxyxx swizzling.
        /// </summary>
        public decvec5 xxyxx => new decvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.rrgrr swizzling (equivalent to decvec3.xxyxx).
        /// </summary>
        public decvec5 rrgrr => new decvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.xxyxy swizzling.
        /// </summary>
        public decvec5 xxyxy => new decvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.rrgrg swizzling (equivalent to decvec3.xxyxy).
        /// </summary>
        public decvec5 rrgrg => new decvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.xxyxz swizzling.
        /// </summary>
        public decvec5 xxyxz => new decvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.rrgrb swizzling (equivalent to decvec3.xxyxz).
        /// </summary>
        public decvec5 rrgrb => new decvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.xxyy swizzling.
        /// </summary>
        public decvec4 xxyy => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.rrgg swizzling (equivalent to decvec3.xxyy).
        /// </summary>
        public decvec4 rrgg => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.xxyyx swizzling.
        /// </summary>
        public decvec5 xxyyx => new decvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.rrggr swizzling (equivalent to decvec3.xxyyx).
        /// </summary>
        public decvec5 rrggr => new decvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.xxyyy swizzling.
        /// </summary>
        public decvec5 xxyyy => new decvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.rrggg swizzling (equivalent to decvec3.xxyyy).
        /// </summary>
        public decvec5 rrggg => new decvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.xxyyz swizzling.
        /// </summary>
        public decvec5 xxyyz => new decvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.rrggb swizzling (equivalent to decvec3.xxyyz).
        /// </summary>
        public decvec5 rrggb => new decvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.xxyz swizzling.
        /// </summary>
        public decvec4 xxyz => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.rrgb swizzling (equivalent to decvec3.xxyz).
        /// </summary>
        public decvec4 rrgb => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.xxyzx swizzling.
        /// </summary>
        public decvec5 xxyzx => new decvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.rrgbr swizzling (equivalent to decvec3.xxyzx).
        /// </summary>
        public decvec5 rrgbr => new decvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.xxyzy swizzling.
        /// </summary>
        public decvec5 xxyzy => new decvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.rrgbg swizzling (equivalent to decvec3.xxyzy).
        /// </summary>
        public decvec5 rrgbg => new decvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.xxyzz swizzling.
        /// </summary>
        public decvec5 xxyzz => new decvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.rrgbb swizzling (equivalent to decvec3.xxyzz).
        /// </summary>
        public decvec5 rrgbb => new decvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.xxz swizzling.
        /// </summary>
        public decvec3 xxz => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec3.rrb swizzling (equivalent to decvec3.xxz).
        /// </summary>
        public decvec3 rrb => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec3.xxzx swizzling.
        /// </summary>
        public decvec4 xxzx => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.rrbr swizzling (equivalent to decvec3.xxzx).
        /// </summary>
        public decvec4 rrbr => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.xxzxx swizzling.
        /// </summary>
        public decvec5 xxzxx => new decvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.rrbrr swizzling (equivalent to decvec3.xxzxx).
        /// </summary>
        public decvec5 rrbrr => new decvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.xxzxy swizzling.
        /// </summary>
        public decvec5 xxzxy => new decvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.rrbrg swizzling (equivalent to decvec3.xxzxy).
        /// </summary>
        public decvec5 rrbrg => new decvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.xxzxz swizzling.
        /// </summary>
        public decvec5 xxzxz => new decvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.rrbrb swizzling (equivalent to decvec3.xxzxz).
        /// </summary>
        public decvec5 rrbrb => new decvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.xxzy swizzling.
        /// </summary>
        public decvec4 xxzy => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.rrbg swizzling (equivalent to decvec3.xxzy).
        /// </summary>
        public decvec4 rrbg => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.xxzyx swizzling.
        /// </summary>
        public decvec5 xxzyx => new decvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.rrbgr swizzling (equivalent to decvec3.xxzyx).
        /// </summary>
        public decvec5 rrbgr => new decvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.xxzyy swizzling.
        /// </summary>
        public decvec5 xxzyy => new decvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.rrbgg swizzling (equivalent to decvec3.xxzyy).
        /// </summary>
        public decvec5 rrbgg => new decvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.xxzyz swizzling.
        /// </summary>
        public decvec5 xxzyz => new decvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.rrbgb swizzling (equivalent to decvec3.xxzyz).
        /// </summary>
        public decvec5 rrbgb => new decvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.xxzz swizzling.
        /// </summary>
        public decvec4 xxzz => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.rrbb swizzling (equivalent to decvec3.xxzz).
        /// </summary>
        public decvec4 rrbb => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.xxzzx swizzling.
        /// </summary>
        public decvec5 xxzzx => new decvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.rrbbr swizzling (equivalent to decvec3.xxzzx).
        /// </summary>
        public decvec5 rrbbr => new decvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.xxzzy swizzling.
        /// </summary>
        public decvec5 xxzzy => new decvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.rrbbg swizzling (equivalent to decvec3.xxzzy).
        /// </summary>
        public decvec5 rrbbg => new decvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.xxzzz swizzling.
        /// </summary>
        public decvec5 xxzzz => new decvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.rrbbb swizzling (equivalent to decvec3.xxzzz).
        /// </summary>
        public decvec5 rrbbb => new decvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.xy swizzling.
        /// </summary>
        public decvec2 xy => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec3.rg swizzling (equivalent to decvec3.xy).
        /// </summary>
        public decvec2 rg => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec3.xyx swizzling.
        /// </summary>
        public decvec3 xyx => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec3.rgr swizzling (equivalent to decvec3.xyx).
        /// </summary>
        public decvec3 rgr => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec3.xyxx swizzling.
        /// </summary>
        public decvec4 xyxx => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.rgrr swizzling (equivalent to decvec3.xyxx).
        /// </summary>
        public decvec4 rgrr => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.xyxxx swizzling.
        /// </summary>
        public decvec5 xyxxx => new decvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.rgrrr swizzling (equivalent to decvec3.xyxxx).
        /// </summary>
        public decvec5 rgrrr => new decvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.xyxxy swizzling.
        /// </summary>
        public decvec5 xyxxy => new decvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.rgrrg swizzling (equivalent to decvec3.xyxxy).
        /// </summary>
        public decvec5 rgrrg => new decvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.xyxxz swizzling.
        /// </summary>
        public decvec5 xyxxz => new decvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.rgrrb swizzling (equivalent to decvec3.xyxxz).
        /// </summary>
        public decvec5 rgrrb => new decvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.xyxy swizzling.
        /// </summary>
        public decvec4 xyxy => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.rgrg swizzling (equivalent to decvec3.xyxy).
        /// </summary>
        public decvec4 rgrg => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.xyxyx swizzling.
        /// </summary>
        public decvec5 xyxyx => new decvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.rgrgr swizzling (equivalent to decvec3.xyxyx).
        /// </summary>
        public decvec5 rgrgr => new decvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.xyxyy swizzling.
        /// </summary>
        public decvec5 xyxyy => new decvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.rgrgg swizzling (equivalent to decvec3.xyxyy).
        /// </summary>
        public decvec5 rgrgg => new decvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.xyxyz swizzling.
        /// </summary>
        public decvec5 xyxyz => new decvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.rgrgb swizzling (equivalent to decvec3.xyxyz).
        /// </summary>
        public decvec5 rgrgb => new decvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.xyxz swizzling.
        /// </summary>
        public decvec4 xyxz => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.rgrb swizzling (equivalent to decvec3.xyxz).
        /// </summary>
        public decvec4 rgrb => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.xyxzx swizzling.
        /// </summary>
        public decvec5 xyxzx => new decvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.rgrbr swizzling (equivalent to decvec3.xyxzx).
        /// </summary>
        public decvec5 rgrbr => new decvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.xyxzy swizzling.
        /// </summary>
        public decvec5 xyxzy => new decvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.rgrbg swizzling (equivalent to decvec3.xyxzy).
        /// </summary>
        public decvec5 rgrbg => new decvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.xyxzz swizzling.
        /// </summary>
        public decvec5 xyxzz => new decvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.rgrbb swizzling (equivalent to decvec3.xyxzz).
        /// </summary>
        public decvec5 rgrbb => new decvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.xyy swizzling.
        /// </summary>
        public decvec3 xyy => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec3.rgg swizzling (equivalent to decvec3.xyy).
        /// </summary>
        public decvec3 rgg => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec3.xyyx swizzling.
        /// </summary>
        public decvec4 xyyx => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.rggr swizzling (equivalent to decvec3.xyyx).
        /// </summary>
        public decvec4 rggr => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.xyyxx swizzling.
        /// </summary>
        public decvec5 xyyxx => new decvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.rggrr swizzling (equivalent to decvec3.xyyxx).
        /// </summary>
        public decvec5 rggrr => new decvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.xyyxy swizzling.
        /// </summary>
        public decvec5 xyyxy => new decvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.rggrg swizzling (equivalent to decvec3.xyyxy).
        /// </summary>
        public decvec5 rggrg => new decvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.xyyxz swizzling.
        /// </summary>
        public decvec5 xyyxz => new decvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.rggrb swizzling (equivalent to decvec3.xyyxz).
        /// </summary>
        public decvec5 rggrb => new decvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.xyyy swizzling.
        /// </summary>
        public decvec4 xyyy => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.rggg swizzling (equivalent to decvec3.xyyy).
        /// </summary>
        public decvec4 rggg => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.xyyyx swizzling.
        /// </summary>
        public decvec5 xyyyx => new decvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.rgggr swizzling (equivalent to decvec3.xyyyx).
        /// </summary>
        public decvec5 rgggr => new decvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.xyyyy swizzling.
        /// </summary>
        public decvec5 xyyyy => new decvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.rgggg swizzling (equivalent to decvec3.xyyyy).
        /// </summary>
        public decvec5 rgggg => new decvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.xyyyz swizzling.
        /// </summary>
        public decvec5 xyyyz => new decvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.rgggb swizzling (equivalent to decvec3.xyyyz).
        /// </summary>
        public decvec5 rgggb => new decvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.xyyz swizzling.
        /// </summary>
        public decvec4 xyyz => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.rggb swizzling (equivalent to decvec3.xyyz).
        /// </summary>
        public decvec4 rggb => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.xyyzx swizzling.
        /// </summary>
        public decvec5 xyyzx => new decvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.rggbr swizzling (equivalent to decvec3.xyyzx).
        /// </summary>
        public decvec5 rggbr => new decvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.xyyzy swizzling.
        /// </summary>
        public decvec5 xyyzy => new decvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.rggbg swizzling (equivalent to decvec3.xyyzy).
        /// </summary>
        public decvec5 rggbg => new decvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.xyyzz swizzling.
        /// </summary>
        public decvec5 xyyzz => new decvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.rggbb swizzling (equivalent to decvec3.xyyzz).
        /// </summary>
        public decvec5 rggbb => new decvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.xyz swizzling.
        /// </summary>
        public decvec3 xyz => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec3.rgb swizzling (equivalent to decvec3.xyz).
        /// </summary>
        public decvec3 rgb => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec3.xyzx swizzling.
        /// </summary>
        public decvec4 xyzx => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.rgbr swizzling (equivalent to decvec3.xyzx).
        /// </summary>
        public decvec4 rgbr => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.xyzxx swizzling.
        /// </summary>
        public decvec5 xyzxx => new decvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.rgbrr swizzling (equivalent to decvec3.xyzxx).
        /// </summary>
        public decvec5 rgbrr => new decvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.xyzxy swizzling.
        /// </summary>
        public decvec5 xyzxy => new decvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.rgbrg swizzling (equivalent to decvec3.xyzxy).
        /// </summary>
        public decvec5 rgbrg => new decvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.xyzxz swizzling.
        /// </summary>
        public decvec5 xyzxz => new decvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.rgbrb swizzling (equivalent to decvec3.xyzxz).
        /// </summary>
        public decvec5 rgbrb => new decvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.xyzy swizzling.
        /// </summary>
        public decvec4 xyzy => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.rgbg swizzling (equivalent to decvec3.xyzy).
        /// </summary>
        public decvec4 rgbg => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.xyzyx swizzling.
        /// </summary>
        public decvec5 xyzyx => new decvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.rgbgr swizzling (equivalent to decvec3.xyzyx).
        /// </summary>
        public decvec5 rgbgr => new decvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.xyzyy swizzling.
        /// </summary>
        public decvec5 xyzyy => new decvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.rgbgg swizzling (equivalent to decvec3.xyzyy).
        /// </summary>
        public decvec5 rgbgg => new decvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.xyzyz swizzling.
        /// </summary>
        public decvec5 xyzyz => new decvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.rgbgb swizzling (equivalent to decvec3.xyzyz).
        /// </summary>
        public decvec5 rgbgb => new decvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.xyzz swizzling.
        /// </summary>
        public decvec4 xyzz => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.rgbb swizzling (equivalent to decvec3.xyzz).
        /// </summary>
        public decvec4 rgbb => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.xyzzx swizzling.
        /// </summary>
        public decvec5 xyzzx => new decvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.rgbbr swizzling (equivalent to decvec3.xyzzx).
        /// </summary>
        public decvec5 rgbbr => new decvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.xyzzy swizzling.
        /// </summary>
        public decvec5 xyzzy => new decvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.rgbbg swizzling (equivalent to decvec3.xyzzy).
        /// </summary>
        public decvec5 rgbbg => new decvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.xyzzz swizzling.
        /// </summary>
        public decvec5 xyzzz => new decvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.rgbbb swizzling (equivalent to decvec3.xyzzz).
        /// </summary>
        public decvec5 rgbbb => new decvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.xz swizzling.
        /// </summary>
        public decvec2 xz => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec3.rb swizzling (equivalent to decvec3.xz).
        /// </summary>
        public decvec2 rb => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec3.xzx swizzling.
        /// </summary>
        public decvec3 xzx => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec3.rbr swizzling (equivalent to decvec3.xzx).
        /// </summary>
        public decvec3 rbr => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec3.xzxx swizzling.
        /// </summary>
        public decvec4 xzxx => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.rbrr swizzling (equivalent to decvec3.xzxx).
        /// </summary>
        public decvec4 rbrr => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.xzxxx swizzling.
        /// </summary>
        public decvec5 xzxxx => new decvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.rbrrr swizzling (equivalent to decvec3.xzxxx).
        /// </summary>
        public decvec5 rbrrr => new decvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.xzxxy swizzling.
        /// </summary>
        public decvec5 xzxxy => new decvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.rbrrg swizzling (equivalent to decvec3.xzxxy).
        /// </summary>
        public decvec5 rbrrg => new decvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.xzxxz swizzling.
        /// </summary>
        public decvec5 xzxxz => new decvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.rbrrb swizzling (equivalent to decvec3.xzxxz).
        /// </summary>
        public decvec5 rbrrb => new decvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.xzxy swizzling.
        /// </summary>
        public decvec4 xzxy => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.rbrg swizzling (equivalent to decvec3.xzxy).
        /// </summary>
        public decvec4 rbrg => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.xzxyx swizzling.
        /// </summary>
        public decvec5 xzxyx => new decvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.rbrgr swizzling (equivalent to decvec3.xzxyx).
        /// </summary>
        public decvec5 rbrgr => new decvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.xzxyy swizzling.
        /// </summary>
        public decvec5 xzxyy => new decvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.rbrgg swizzling (equivalent to decvec3.xzxyy).
        /// </summary>
        public decvec5 rbrgg => new decvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.xzxyz swizzling.
        /// </summary>
        public decvec5 xzxyz => new decvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.rbrgb swizzling (equivalent to decvec3.xzxyz).
        /// </summary>
        public decvec5 rbrgb => new decvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.xzxz swizzling.
        /// </summary>
        public decvec4 xzxz => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.rbrb swizzling (equivalent to decvec3.xzxz).
        /// </summary>
        public decvec4 rbrb => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.xzxzx swizzling.
        /// </summary>
        public decvec5 xzxzx => new decvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.rbrbr swizzling (equivalent to decvec3.xzxzx).
        /// </summary>
        public decvec5 rbrbr => new decvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.xzxzy swizzling.
        /// </summary>
        public decvec5 xzxzy => new decvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.rbrbg swizzling (equivalent to decvec3.xzxzy).
        /// </summary>
        public decvec5 rbrbg => new decvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.xzxzz swizzling.
        /// </summary>
        public decvec5 xzxzz => new decvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.rbrbb swizzling (equivalent to decvec3.xzxzz).
        /// </summary>
        public decvec5 rbrbb => new decvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.xzy swizzling.
        /// </summary>
        public decvec3 xzy => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec3.rbg swizzling (equivalent to decvec3.xzy).
        /// </summary>
        public decvec3 rbg => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec3.xzyx swizzling.
        /// </summary>
        public decvec4 xzyx => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.rbgr swizzling (equivalent to decvec3.xzyx).
        /// </summary>
        public decvec4 rbgr => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.xzyxx swizzling.
        /// </summary>
        public decvec5 xzyxx => new decvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.rbgrr swizzling (equivalent to decvec3.xzyxx).
        /// </summary>
        public decvec5 rbgrr => new decvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.xzyxy swizzling.
        /// </summary>
        public decvec5 xzyxy => new decvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.rbgrg swizzling (equivalent to decvec3.xzyxy).
        /// </summary>
        public decvec5 rbgrg => new decvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.xzyxz swizzling.
        /// </summary>
        public decvec5 xzyxz => new decvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.rbgrb swizzling (equivalent to decvec3.xzyxz).
        /// </summary>
        public decvec5 rbgrb => new decvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.xzyy swizzling.
        /// </summary>
        public decvec4 xzyy => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.rbgg swizzling (equivalent to decvec3.xzyy).
        /// </summary>
        public decvec4 rbgg => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.xzyyx swizzling.
        /// </summary>
        public decvec5 xzyyx => new decvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.rbggr swizzling (equivalent to decvec3.xzyyx).
        /// </summary>
        public decvec5 rbggr => new decvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.xzyyy swizzling.
        /// </summary>
        public decvec5 xzyyy => new decvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.rbggg swizzling (equivalent to decvec3.xzyyy).
        /// </summary>
        public decvec5 rbggg => new decvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.xzyyz swizzling.
        /// </summary>
        public decvec5 xzyyz => new decvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.rbggb swizzling (equivalent to decvec3.xzyyz).
        /// </summary>
        public decvec5 rbggb => new decvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.xzyz swizzling.
        /// </summary>
        public decvec4 xzyz => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.rbgb swizzling (equivalent to decvec3.xzyz).
        /// </summary>
        public decvec4 rbgb => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.xzyzx swizzling.
        /// </summary>
        public decvec5 xzyzx => new decvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.rbgbr swizzling (equivalent to decvec3.xzyzx).
        /// </summary>
        public decvec5 rbgbr => new decvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.xzyzy swizzling.
        /// </summary>
        public decvec5 xzyzy => new decvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.rbgbg swizzling (equivalent to decvec3.xzyzy).
        /// </summary>
        public decvec5 rbgbg => new decvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.xzyzz swizzling.
        /// </summary>
        public decvec5 xzyzz => new decvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.rbgbb swizzling (equivalent to decvec3.xzyzz).
        /// </summary>
        public decvec5 rbgbb => new decvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.xzz swizzling.
        /// </summary>
        public decvec3 xzz => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec3.rbb swizzling (equivalent to decvec3.xzz).
        /// </summary>
        public decvec3 rbb => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec3.xzzx swizzling.
        /// </summary>
        public decvec4 xzzx => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.rbbr swizzling (equivalent to decvec3.xzzx).
        /// </summary>
        public decvec4 rbbr => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.xzzxx swizzling.
        /// </summary>
        public decvec5 xzzxx => new decvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.rbbrr swizzling (equivalent to decvec3.xzzxx).
        /// </summary>
        public decvec5 rbbrr => new decvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.xzzxy swizzling.
        /// </summary>
        public decvec5 xzzxy => new decvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.rbbrg swizzling (equivalent to decvec3.xzzxy).
        /// </summary>
        public decvec5 rbbrg => new decvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.xzzxz swizzling.
        /// </summary>
        public decvec5 xzzxz => new decvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.rbbrb swizzling (equivalent to decvec3.xzzxz).
        /// </summary>
        public decvec5 rbbrb => new decvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.xzzy swizzling.
        /// </summary>
        public decvec4 xzzy => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.rbbg swizzling (equivalent to decvec3.xzzy).
        /// </summary>
        public decvec4 rbbg => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.xzzyx swizzling.
        /// </summary>
        public decvec5 xzzyx => new decvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.rbbgr swizzling (equivalent to decvec3.xzzyx).
        /// </summary>
        public decvec5 rbbgr => new decvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.xzzyy swizzling.
        /// </summary>
        public decvec5 xzzyy => new decvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.rbbgg swizzling (equivalent to decvec3.xzzyy).
        /// </summary>
        public decvec5 rbbgg => new decvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.xzzyz swizzling.
        /// </summary>
        public decvec5 xzzyz => new decvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.rbbgb swizzling (equivalent to decvec3.xzzyz).
        /// </summary>
        public decvec5 rbbgb => new decvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.xzzz swizzling.
        /// </summary>
        public decvec4 xzzz => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.rbbb swizzling (equivalent to decvec3.xzzz).
        /// </summary>
        public decvec4 rbbb => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.xzzzx swizzling.
        /// </summary>
        public decvec5 xzzzx => new decvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.rbbbr swizzling (equivalent to decvec3.xzzzx).
        /// </summary>
        public decvec5 rbbbr => new decvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.xzzzy swizzling.
        /// </summary>
        public decvec5 xzzzy => new decvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.rbbbg swizzling (equivalent to decvec3.xzzzy).
        /// </summary>
        public decvec5 rbbbg => new decvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.xzzzz swizzling.
        /// </summary>
        public decvec5 xzzzz => new decvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns decvec3.rbbbb swizzling (equivalent to decvec3.xzzzz).
        /// </summary>
        public decvec5 rbbbb => new decvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns decvec3.yx swizzling.
        /// </summary>
        public decvec2 yx => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec3.gr swizzling (equivalent to decvec3.yx).
        /// </summary>
        public decvec2 gr => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec3.yxx swizzling.
        /// </summary>
        public decvec3 yxx => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec3.grr swizzling (equivalent to decvec3.yxx).
        /// </summary>
        public decvec3 grr => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec3.yxxx swizzling.
        /// </summary>
        public decvec4 yxxx => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.grrr swizzling (equivalent to decvec3.yxxx).
        /// </summary>
        public decvec4 grrr => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.yxxxx swizzling.
        /// </summary>
        public decvec5 yxxxx => new decvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.grrrr swizzling (equivalent to decvec3.yxxxx).
        /// </summary>
        public decvec5 grrrr => new decvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.yxxxy swizzling.
        /// </summary>
        public decvec5 yxxxy => new decvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.grrrg swizzling (equivalent to decvec3.yxxxy).
        /// </summary>
        public decvec5 grrrg => new decvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.yxxxz swizzling.
        /// </summary>
        public decvec5 yxxxz => new decvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.grrrb swizzling (equivalent to decvec3.yxxxz).
        /// </summary>
        public decvec5 grrrb => new decvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.yxxy swizzling.
        /// </summary>
        public decvec4 yxxy => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.grrg swizzling (equivalent to decvec3.yxxy).
        /// </summary>
        public decvec4 grrg => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.yxxyx swizzling.
        /// </summary>
        public decvec5 yxxyx => new decvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.grrgr swizzling (equivalent to decvec3.yxxyx).
        /// </summary>
        public decvec5 grrgr => new decvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.yxxyy swizzling.
        /// </summary>
        public decvec5 yxxyy => new decvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.grrgg swizzling (equivalent to decvec3.yxxyy).
        /// </summary>
        public decvec5 grrgg => new decvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.yxxyz swizzling.
        /// </summary>
        public decvec5 yxxyz => new decvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.grrgb swizzling (equivalent to decvec3.yxxyz).
        /// </summary>
        public decvec5 grrgb => new decvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.yxxz swizzling.
        /// </summary>
        public decvec4 yxxz => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.grrb swizzling (equivalent to decvec3.yxxz).
        /// </summary>
        public decvec4 grrb => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.yxxzx swizzling.
        /// </summary>
        public decvec5 yxxzx => new decvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.grrbr swizzling (equivalent to decvec3.yxxzx).
        /// </summary>
        public decvec5 grrbr => new decvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.yxxzy swizzling.
        /// </summary>
        public decvec5 yxxzy => new decvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.grrbg swizzling (equivalent to decvec3.yxxzy).
        /// </summary>
        public decvec5 grrbg => new decvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.yxxzz swizzling.
        /// </summary>
        public decvec5 yxxzz => new decvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.grrbb swizzling (equivalent to decvec3.yxxzz).
        /// </summary>
        public decvec5 grrbb => new decvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.yxy swizzling.
        /// </summary>
        public decvec3 yxy => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec3.grg swizzling (equivalent to decvec3.yxy).
        /// </summary>
        public decvec3 grg => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec3.yxyx swizzling.
        /// </summary>
        public decvec4 yxyx => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.grgr swizzling (equivalent to decvec3.yxyx).
        /// </summary>
        public decvec4 grgr => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.yxyxx swizzling.
        /// </summary>
        public decvec5 yxyxx => new decvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.grgrr swizzling (equivalent to decvec3.yxyxx).
        /// </summary>
        public decvec5 grgrr => new decvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.yxyxy swizzling.
        /// </summary>
        public decvec5 yxyxy => new decvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.grgrg swizzling (equivalent to decvec3.yxyxy).
        /// </summary>
        public decvec5 grgrg => new decvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.yxyxz swizzling.
        /// </summary>
        public decvec5 yxyxz => new decvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.grgrb swizzling (equivalent to decvec3.yxyxz).
        /// </summary>
        public decvec5 grgrb => new decvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.yxyy swizzling.
        /// </summary>
        public decvec4 yxyy => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.grgg swizzling (equivalent to decvec3.yxyy).
        /// </summary>
        public decvec4 grgg => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.yxyyx swizzling.
        /// </summary>
        public decvec5 yxyyx => new decvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.grggr swizzling (equivalent to decvec3.yxyyx).
        /// </summary>
        public decvec5 grggr => new decvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.yxyyy swizzling.
        /// </summary>
        public decvec5 yxyyy => new decvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.grggg swizzling (equivalent to decvec3.yxyyy).
        /// </summary>
        public decvec5 grggg => new decvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.yxyyz swizzling.
        /// </summary>
        public decvec5 yxyyz => new decvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.grggb swizzling (equivalent to decvec3.yxyyz).
        /// </summary>
        public decvec5 grggb => new decvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.yxyz swizzling.
        /// </summary>
        public decvec4 yxyz => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.grgb swizzling (equivalent to decvec3.yxyz).
        /// </summary>
        public decvec4 grgb => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.yxyzx swizzling.
        /// </summary>
        public decvec5 yxyzx => new decvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.grgbr swizzling (equivalent to decvec3.yxyzx).
        /// </summary>
        public decvec5 grgbr => new decvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.yxyzy swizzling.
        /// </summary>
        public decvec5 yxyzy => new decvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.grgbg swizzling (equivalent to decvec3.yxyzy).
        /// </summary>
        public decvec5 grgbg => new decvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.yxyzz swizzling.
        /// </summary>
        public decvec5 yxyzz => new decvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.grgbb swizzling (equivalent to decvec3.yxyzz).
        /// </summary>
        public decvec5 grgbb => new decvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.yxz swizzling.
        /// </summary>
        public decvec3 yxz => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec3.grb swizzling (equivalent to decvec3.yxz).
        /// </summary>
        public decvec3 grb => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec3.yxzx swizzling.
        /// </summary>
        public decvec4 yxzx => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.grbr swizzling (equivalent to decvec3.yxzx).
        /// </summary>
        public decvec4 grbr => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.yxzxx swizzling.
        /// </summary>
        public decvec5 yxzxx => new decvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.grbrr swizzling (equivalent to decvec3.yxzxx).
        /// </summary>
        public decvec5 grbrr => new decvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.yxzxy swizzling.
        /// </summary>
        public decvec5 yxzxy => new decvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.grbrg swizzling (equivalent to decvec3.yxzxy).
        /// </summary>
        public decvec5 grbrg => new decvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.yxzxz swizzling.
        /// </summary>
        public decvec5 yxzxz => new decvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.grbrb swizzling (equivalent to decvec3.yxzxz).
        /// </summary>
        public decvec5 grbrb => new decvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.yxzy swizzling.
        /// </summary>
        public decvec4 yxzy => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.grbg swizzling (equivalent to decvec3.yxzy).
        /// </summary>
        public decvec4 grbg => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.yxzyx swizzling.
        /// </summary>
        public decvec5 yxzyx => new decvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.grbgr swizzling (equivalent to decvec3.yxzyx).
        /// </summary>
        public decvec5 grbgr => new decvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.yxzyy swizzling.
        /// </summary>
        public decvec5 yxzyy => new decvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.grbgg swizzling (equivalent to decvec3.yxzyy).
        /// </summary>
        public decvec5 grbgg => new decvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.yxzyz swizzling.
        /// </summary>
        public decvec5 yxzyz => new decvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.grbgb swizzling (equivalent to decvec3.yxzyz).
        /// </summary>
        public decvec5 grbgb => new decvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.yxzz swizzling.
        /// </summary>
        public decvec4 yxzz => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.grbb swizzling (equivalent to decvec3.yxzz).
        /// </summary>
        public decvec4 grbb => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.yxzzx swizzling.
        /// </summary>
        public decvec5 yxzzx => new decvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.grbbr swizzling (equivalent to decvec3.yxzzx).
        /// </summary>
        public decvec5 grbbr => new decvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.yxzzy swizzling.
        /// </summary>
        public decvec5 yxzzy => new decvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.grbbg swizzling (equivalent to decvec3.yxzzy).
        /// </summary>
        public decvec5 grbbg => new decvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.yxzzz swizzling.
        /// </summary>
        public decvec5 yxzzz => new decvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.grbbb swizzling (equivalent to decvec3.yxzzz).
        /// </summary>
        public decvec5 grbbb => new decvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.yy swizzling.
        /// </summary>
        public decvec2 yy => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec3.gg swizzling (equivalent to decvec3.yy).
        /// </summary>
        public decvec2 gg => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec3.yyx swizzling.
        /// </summary>
        public decvec3 yyx => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec3.ggr swizzling (equivalent to decvec3.yyx).
        /// </summary>
        public decvec3 ggr => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec3.yyxx swizzling.
        /// </summary>
        public decvec4 yyxx => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.ggrr swizzling (equivalent to decvec3.yyxx).
        /// </summary>
        public decvec4 ggrr => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.yyxxx swizzling.
        /// </summary>
        public decvec5 yyxxx => new decvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.ggrrr swizzling (equivalent to decvec3.yyxxx).
        /// </summary>
        public decvec5 ggrrr => new decvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.yyxxy swizzling.
        /// </summary>
        public decvec5 yyxxy => new decvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.ggrrg swizzling (equivalent to decvec3.yyxxy).
        /// </summary>
        public decvec5 ggrrg => new decvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.yyxxz swizzling.
        /// </summary>
        public decvec5 yyxxz => new decvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.ggrrb swizzling (equivalent to decvec3.yyxxz).
        /// </summary>
        public decvec5 ggrrb => new decvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.yyxy swizzling.
        /// </summary>
        public decvec4 yyxy => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.ggrg swizzling (equivalent to decvec3.yyxy).
        /// </summary>
        public decvec4 ggrg => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.yyxyx swizzling.
        /// </summary>
        public decvec5 yyxyx => new decvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.ggrgr swizzling (equivalent to decvec3.yyxyx).
        /// </summary>
        public decvec5 ggrgr => new decvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.yyxyy swizzling.
        /// </summary>
        public decvec5 yyxyy => new decvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.ggrgg swizzling (equivalent to decvec3.yyxyy).
        /// </summary>
        public decvec5 ggrgg => new decvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.yyxyz swizzling.
        /// </summary>
        public decvec5 yyxyz => new decvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.ggrgb swizzling (equivalent to decvec3.yyxyz).
        /// </summary>
        public decvec5 ggrgb => new decvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.yyxz swizzling.
        /// </summary>
        public decvec4 yyxz => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.ggrb swizzling (equivalent to decvec3.yyxz).
        /// </summary>
        public decvec4 ggrb => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.yyxzx swizzling.
        /// </summary>
        public decvec5 yyxzx => new decvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.ggrbr swizzling (equivalent to decvec3.yyxzx).
        /// </summary>
        public decvec5 ggrbr => new decvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.yyxzy swizzling.
        /// </summary>
        public decvec5 yyxzy => new decvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.ggrbg swizzling (equivalent to decvec3.yyxzy).
        /// </summary>
        public decvec5 ggrbg => new decvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.yyxzz swizzling.
        /// </summary>
        public decvec5 yyxzz => new decvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.ggrbb swizzling (equivalent to decvec3.yyxzz).
        /// </summary>
        public decvec5 ggrbb => new decvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.yyy swizzling.
        /// </summary>
        public decvec3 yyy => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec3.ggg swizzling (equivalent to decvec3.yyy).
        /// </summary>
        public decvec3 ggg => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec3.yyyx swizzling.
        /// </summary>
        public decvec4 yyyx => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.gggr swizzling (equivalent to decvec3.yyyx).
        /// </summary>
        public decvec4 gggr => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.yyyxx swizzling.
        /// </summary>
        public decvec5 yyyxx => new decvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.gggrr swizzling (equivalent to decvec3.yyyxx).
        /// </summary>
        public decvec5 gggrr => new decvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.yyyxy swizzling.
        /// </summary>
        public decvec5 yyyxy => new decvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.gggrg swizzling (equivalent to decvec3.yyyxy).
        /// </summary>
        public decvec5 gggrg => new decvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.yyyxz swizzling.
        /// </summary>
        public decvec5 yyyxz => new decvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.gggrb swizzling (equivalent to decvec3.yyyxz).
        /// </summary>
        public decvec5 gggrb => new decvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.yyyy swizzling.
        /// </summary>
        public decvec4 yyyy => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.gggg swizzling (equivalent to decvec3.yyyy).
        /// </summary>
        public decvec4 gggg => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.yyyyx swizzling.
        /// </summary>
        public decvec5 yyyyx => new decvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.ggggr swizzling (equivalent to decvec3.yyyyx).
        /// </summary>
        public decvec5 ggggr => new decvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.yyyyy swizzling.
        /// </summary>
        public decvec5 yyyyy => new decvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.ggggg swizzling (equivalent to decvec3.yyyyy).
        /// </summary>
        public decvec5 ggggg => new decvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.yyyyz swizzling.
        /// </summary>
        public decvec5 yyyyz => new decvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.ggggb swizzling (equivalent to decvec3.yyyyz).
        /// </summary>
        public decvec5 ggggb => new decvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.yyyz swizzling.
        /// </summary>
        public decvec4 yyyz => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.gggb swizzling (equivalent to decvec3.yyyz).
        /// </summary>
        public decvec4 gggb => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.yyyzx swizzling.
        /// </summary>
        public decvec5 yyyzx => new decvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.gggbr swizzling (equivalent to decvec3.yyyzx).
        /// </summary>
        public decvec5 gggbr => new decvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.yyyzy swizzling.
        /// </summary>
        public decvec5 yyyzy => new decvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.gggbg swizzling (equivalent to decvec3.yyyzy).
        /// </summary>
        public decvec5 gggbg => new decvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.yyyzz swizzling.
        /// </summary>
        public decvec5 yyyzz => new decvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.gggbb swizzling (equivalent to decvec3.yyyzz).
        /// </summary>
        public decvec5 gggbb => new decvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.yyz swizzling.
        /// </summary>
        public decvec3 yyz => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec3.ggb swizzling (equivalent to decvec3.yyz).
        /// </summary>
        public decvec3 ggb => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec3.yyzx swizzling.
        /// </summary>
        public decvec4 yyzx => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.ggbr swizzling (equivalent to decvec3.yyzx).
        /// </summary>
        public decvec4 ggbr => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.yyzxx swizzling.
        /// </summary>
        public decvec5 yyzxx => new decvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.ggbrr swizzling (equivalent to decvec3.yyzxx).
        /// </summary>
        public decvec5 ggbrr => new decvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.yyzxy swizzling.
        /// </summary>
        public decvec5 yyzxy => new decvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.ggbrg swizzling (equivalent to decvec3.yyzxy).
        /// </summary>
        public decvec5 ggbrg => new decvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.yyzxz swizzling.
        /// </summary>
        public decvec5 yyzxz => new decvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.ggbrb swizzling (equivalent to decvec3.yyzxz).
        /// </summary>
        public decvec5 ggbrb => new decvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.yyzy swizzling.
        /// </summary>
        public decvec4 yyzy => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.ggbg swizzling (equivalent to decvec3.yyzy).
        /// </summary>
        public decvec4 ggbg => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.yyzyx swizzling.
        /// </summary>
        public decvec5 yyzyx => new decvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.ggbgr swizzling (equivalent to decvec3.yyzyx).
        /// </summary>
        public decvec5 ggbgr => new decvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.yyzyy swizzling.
        /// </summary>
        public decvec5 yyzyy => new decvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.ggbgg swizzling (equivalent to decvec3.yyzyy).
        /// </summary>
        public decvec5 ggbgg => new decvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.yyzyz swizzling.
        /// </summary>
        public decvec5 yyzyz => new decvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.ggbgb swizzling (equivalent to decvec3.yyzyz).
        /// </summary>
        public decvec5 ggbgb => new decvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.yyzz swizzling.
        /// </summary>
        public decvec4 yyzz => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.ggbb swizzling (equivalent to decvec3.yyzz).
        /// </summary>
        public decvec4 ggbb => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.yyzzx swizzling.
        /// </summary>
        public decvec5 yyzzx => new decvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.ggbbr swizzling (equivalent to decvec3.yyzzx).
        /// </summary>
        public decvec5 ggbbr => new decvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.yyzzy swizzling.
        /// </summary>
        public decvec5 yyzzy => new decvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.ggbbg swizzling (equivalent to decvec3.yyzzy).
        /// </summary>
        public decvec5 ggbbg => new decvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.yyzzz swizzling.
        /// </summary>
        public decvec5 yyzzz => new decvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.ggbbb swizzling (equivalent to decvec3.yyzzz).
        /// </summary>
        public decvec5 ggbbb => new decvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.yz swizzling.
        /// </summary>
        public decvec2 yz => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec3.gb swizzling (equivalent to decvec3.yz).
        /// </summary>
        public decvec2 gb => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec3.yzx swizzling.
        /// </summary>
        public decvec3 yzx => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec3.gbr swizzling (equivalent to decvec3.yzx).
        /// </summary>
        public decvec3 gbr => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec3.yzxx swizzling.
        /// </summary>
        public decvec4 yzxx => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.gbrr swizzling (equivalent to decvec3.yzxx).
        /// </summary>
        public decvec4 gbrr => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.yzxxx swizzling.
        /// </summary>
        public decvec5 yzxxx => new decvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.gbrrr swizzling (equivalent to decvec3.yzxxx).
        /// </summary>
        public decvec5 gbrrr => new decvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.yzxxy swizzling.
        /// </summary>
        public decvec5 yzxxy => new decvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.gbrrg swizzling (equivalent to decvec3.yzxxy).
        /// </summary>
        public decvec5 gbrrg => new decvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.yzxxz swizzling.
        /// </summary>
        public decvec5 yzxxz => new decvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.gbrrb swizzling (equivalent to decvec3.yzxxz).
        /// </summary>
        public decvec5 gbrrb => new decvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.yzxy swizzling.
        /// </summary>
        public decvec4 yzxy => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.gbrg swizzling (equivalent to decvec3.yzxy).
        /// </summary>
        public decvec4 gbrg => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.yzxyx swizzling.
        /// </summary>
        public decvec5 yzxyx => new decvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.gbrgr swizzling (equivalent to decvec3.yzxyx).
        /// </summary>
        public decvec5 gbrgr => new decvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.yzxyy swizzling.
        /// </summary>
        public decvec5 yzxyy => new decvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.gbrgg swizzling (equivalent to decvec3.yzxyy).
        /// </summary>
        public decvec5 gbrgg => new decvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.yzxyz swizzling.
        /// </summary>
        public decvec5 yzxyz => new decvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.gbrgb swizzling (equivalent to decvec3.yzxyz).
        /// </summary>
        public decvec5 gbrgb => new decvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.yzxz swizzling.
        /// </summary>
        public decvec4 yzxz => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.gbrb swizzling (equivalent to decvec3.yzxz).
        /// </summary>
        public decvec4 gbrb => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.yzxzx swizzling.
        /// </summary>
        public decvec5 yzxzx => new decvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.gbrbr swizzling (equivalent to decvec3.yzxzx).
        /// </summary>
        public decvec5 gbrbr => new decvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.yzxzy swizzling.
        /// </summary>
        public decvec5 yzxzy => new decvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.gbrbg swizzling (equivalent to decvec3.yzxzy).
        /// </summary>
        public decvec5 gbrbg => new decvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.yzxzz swizzling.
        /// </summary>
        public decvec5 yzxzz => new decvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.gbrbb swizzling (equivalent to decvec3.yzxzz).
        /// </summary>
        public decvec5 gbrbb => new decvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.yzy swizzling.
        /// </summary>
        public decvec3 yzy => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec3.gbg swizzling (equivalent to decvec3.yzy).
        /// </summary>
        public decvec3 gbg => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec3.yzyx swizzling.
        /// </summary>
        public decvec4 yzyx => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.gbgr swizzling (equivalent to decvec3.yzyx).
        /// </summary>
        public decvec4 gbgr => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.yzyxx swizzling.
        /// </summary>
        public decvec5 yzyxx => new decvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.gbgrr swizzling (equivalent to decvec3.yzyxx).
        /// </summary>
        public decvec5 gbgrr => new decvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.yzyxy swizzling.
        /// </summary>
        public decvec5 yzyxy => new decvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.gbgrg swizzling (equivalent to decvec3.yzyxy).
        /// </summary>
        public decvec5 gbgrg => new decvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.yzyxz swizzling.
        /// </summary>
        public decvec5 yzyxz => new decvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.gbgrb swizzling (equivalent to decvec3.yzyxz).
        /// </summary>
        public decvec5 gbgrb => new decvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.yzyy swizzling.
        /// </summary>
        public decvec4 yzyy => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.gbgg swizzling (equivalent to decvec3.yzyy).
        /// </summary>
        public decvec4 gbgg => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.yzyyx swizzling.
        /// </summary>
        public decvec5 yzyyx => new decvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.gbggr swizzling (equivalent to decvec3.yzyyx).
        /// </summary>
        public decvec5 gbggr => new decvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.yzyyy swizzling.
        /// </summary>
        public decvec5 yzyyy => new decvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.gbggg swizzling (equivalent to decvec3.yzyyy).
        /// </summary>
        public decvec5 gbggg => new decvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.yzyyz swizzling.
        /// </summary>
        public decvec5 yzyyz => new decvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.gbggb swizzling (equivalent to decvec3.yzyyz).
        /// </summary>
        public decvec5 gbggb => new decvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.yzyz swizzling.
        /// </summary>
        public decvec4 yzyz => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.gbgb swizzling (equivalent to decvec3.yzyz).
        /// </summary>
        public decvec4 gbgb => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.yzyzx swizzling.
        /// </summary>
        public decvec5 yzyzx => new decvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.gbgbr swizzling (equivalent to decvec3.yzyzx).
        /// </summary>
        public decvec5 gbgbr => new decvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.yzyzy swizzling.
        /// </summary>
        public decvec5 yzyzy => new decvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.gbgbg swizzling (equivalent to decvec3.yzyzy).
        /// </summary>
        public decvec5 gbgbg => new decvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.yzyzz swizzling.
        /// </summary>
        public decvec5 yzyzz => new decvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.gbgbb swizzling (equivalent to decvec3.yzyzz).
        /// </summary>
        public decvec5 gbgbb => new decvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.yzz swizzling.
        /// </summary>
        public decvec3 yzz => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec3.gbb swizzling (equivalent to decvec3.yzz).
        /// </summary>
        public decvec3 gbb => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec3.yzzx swizzling.
        /// </summary>
        public decvec4 yzzx => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.gbbr swizzling (equivalent to decvec3.yzzx).
        /// </summary>
        public decvec4 gbbr => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.yzzxx swizzling.
        /// </summary>
        public decvec5 yzzxx => new decvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.gbbrr swizzling (equivalent to decvec3.yzzxx).
        /// </summary>
        public decvec5 gbbrr => new decvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.yzzxy swizzling.
        /// </summary>
        public decvec5 yzzxy => new decvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.gbbrg swizzling (equivalent to decvec3.yzzxy).
        /// </summary>
        public decvec5 gbbrg => new decvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.yzzxz swizzling.
        /// </summary>
        public decvec5 yzzxz => new decvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.gbbrb swizzling (equivalent to decvec3.yzzxz).
        /// </summary>
        public decvec5 gbbrb => new decvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.yzzy swizzling.
        /// </summary>
        public decvec4 yzzy => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.gbbg swizzling (equivalent to decvec3.yzzy).
        /// </summary>
        public decvec4 gbbg => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.yzzyx swizzling.
        /// </summary>
        public decvec5 yzzyx => new decvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.gbbgr swizzling (equivalent to decvec3.yzzyx).
        /// </summary>
        public decvec5 gbbgr => new decvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.yzzyy swizzling.
        /// </summary>
        public decvec5 yzzyy => new decvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.gbbgg swizzling (equivalent to decvec3.yzzyy).
        /// </summary>
        public decvec5 gbbgg => new decvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.yzzyz swizzling.
        /// </summary>
        public decvec5 yzzyz => new decvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.gbbgb swizzling (equivalent to decvec3.yzzyz).
        /// </summary>
        public decvec5 gbbgb => new decvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.yzzz swizzling.
        /// </summary>
        public decvec4 yzzz => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.gbbb swizzling (equivalent to decvec3.yzzz).
        /// </summary>
        public decvec4 gbbb => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.yzzzx swizzling.
        /// </summary>
        public decvec5 yzzzx => new decvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.gbbbr swizzling (equivalent to decvec3.yzzzx).
        /// </summary>
        public decvec5 gbbbr => new decvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.yzzzy swizzling.
        /// </summary>
        public decvec5 yzzzy => new decvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.gbbbg swizzling (equivalent to decvec3.yzzzy).
        /// </summary>
        public decvec5 gbbbg => new decvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.yzzzz swizzling.
        /// </summary>
        public decvec5 yzzzz => new decvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns decvec3.gbbbb swizzling (equivalent to decvec3.yzzzz).
        /// </summary>
        public decvec5 gbbbb => new decvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns decvec3.zx swizzling.
        /// </summary>
        public decvec2 zx => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec3.br swizzling (equivalent to decvec3.zx).
        /// </summary>
        public decvec2 br => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec3.zxx swizzling.
        /// </summary>
        public decvec3 zxx => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec3.brr swizzling (equivalent to decvec3.zxx).
        /// </summary>
        public decvec3 brr => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec3.zxxx swizzling.
        /// </summary>
        public decvec4 zxxx => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.brrr swizzling (equivalent to decvec3.zxxx).
        /// </summary>
        public decvec4 brrr => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.zxxxx swizzling.
        /// </summary>
        public decvec5 zxxxx => new decvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.brrrr swizzling (equivalent to decvec3.zxxxx).
        /// </summary>
        public decvec5 brrrr => new decvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.zxxxy swizzling.
        /// </summary>
        public decvec5 zxxxy => new decvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.brrrg swizzling (equivalent to decvec3.zxxxy).
        /// </summary>
        public decvec5 brrrg => new decvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.zxxxz swizzling.
        /// </summary>
        public decvec5 zxxxz => new decvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.brrrb swizzling (equivalent to decvec3.zxxxz).
        /// </summary>
        public decvec5 brrrb => new decvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.zxxy swizzling.
        /// </summary>
        public decvec4 zxxy => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.brrg swizzling (equivalent to decvec3.zxxy).
        /// </summary>
        public decvec4 brrg => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.zxxyx swizzling.
        /// </summary>
        public decvec5 zxxyx => new decvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.brrgr swizzling (equivalent to decvec3.zxxyx).
        /// </summary>
        public decvec5 brrgr => new decvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.zxxyy swizzling.
        /// </summary>
        public decvec5 zxxyy => new decvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.brrgg swizzling (equivalent to decvec3.zxxyy).
        /// </summary>
        public decvec5 brrgg => new decvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.zxxyz swizzling.
        /// </summary>
        public decvec5 zxxyz => new decvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.brrgb swizzling (equivalent to decvec3.zxxyz).
        /// </summary>
        public decvec5 brrgb => new decvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.zxxz swizzling.
        /// </summary>
        public decvec4 zxxz => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.brrb swizzling (equivalent to decvec3.zxxz).
        /// </summary>
        public decvec4 brrb => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.zxxzx swizzling.
        /// </summary>
        public decvec5 zxxzx => new decvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.brrbr swizzling (equivalent to decvec3.zxxzx).
        /// </summary>
        public decvec5 brrbr => new decvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.zxxzy swizzling.
        /// </summary>
        public decvec5 zxxzy => new decvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.brrbg swizzling (equivalent to decvec3.zxxzy).
        /// </summary>
        public decvec5 brrbg => new decvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.zxxzz swizzling.
        /// </summary>
        public decvec5 zxxzz => new decvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.brrbb swizzling (equivalent to decvec3.zxxzz).
        /// </summary>
        public decvec5 brrbb => new decvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.zxy swizzling.
        /// </summary>
        public decvec3 zxy => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec3.brg swizzling (equivalent to decvec3.zxy).
        /// </summary>
        public decvec3 brg => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec3.zxyx swizzling.
        /// </summary>
        public decvec4 zxyx => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.brgr swizzling (equivalent to decvec3.zxyx).
        /// </summary>
        public decvec4 brgr => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.zxyxx swizzling.
        /// </summary>
        public decvec5 zxyxx => new decvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.brgrr swizzling (equivalent to decvec3.zxyxx).
        /// </summary>
        public decvec5 brgrr => new decvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.zxyxy swizzling.
        /// </summary>
        public decvec5 zxyxy => new decvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.brgrg swizzling (equivalent to decvec3.zxyxy).
        /// </summary>
        public decvec5 brgrg => new decvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.zxyxz swizzling.
        /// </summary>
        public decvec5 zxyxz => new decvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.brgrb swizzling (equivalent to decvec3.zxyxz).
        /// </summary>
        public decvec5 brgrb => new decvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.zxyy swizzling.
        /// </summary>
        public decvec4 zxyy => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.brgg swizzling (equivalent to decvec3.zxyy).
        /// </summary>
        public decvec4 brgg => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.zxyyx swizzling.
        /// </summary>
        public decvec5 zxyyx => new decvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.brggr swizzling (equivalent to decvec3.zxyyx).
        /// </summary>
        public decvec5 brggr => new decvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.zxyyy swizzling.
        /// </summary>
        public decvec5 zxyyy => new decvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.brggg swizzling (equivalent to decvec3.zxyyy).
        /// </summary>
        public decvec5 brggg => new decvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.zxyyz swizzling.
        /// </summary>
        public decvec5 zxyyz => new decvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.brggb swizzling (equivalent to decvec3.zxyyz).
        /// </summary>
        public decvec5 brggb => new decvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.zxyz swizzling.
        /// </summary>
        public decvec4 zxyz => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.brgb swizzling (equivalent to decvec3.zxyz).
        /// </summary>
        public decvec4 brgb => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.zxyzx swizzling.
        /// </summary>
        public decvec5 zxyzx => new decvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.brgbr swizzling (equivalent to decvec3.zxyzx).
        /// </summary>
        public decvec5 brgbr => new decvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.zxyzy swizzling.
        /// </summary>
        public decvec5 zxyzy => new decvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.brgbg swizzling (equivalent to decvec3.zxyzy).
        /// </summary>
        public decvec5 brgbg => new decvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.zxyzz swizzling.
        /// </summary>
        public decvec5 zxyzz => new decvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.brgbb swizzling (equivalent to decvec3.zxyzz).
        /// </summary>
        public decvec5 brgbb => new decvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.zxz swizzling.
        /// </summary>
        public decvec3 zxz => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec3.brb swizzling (equivalent to decvec3.zxz).
        /// </summary>
        public decvec3 brb => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec3.zxzx swizzling.
        /// </summary>
        public decvec4 zxzx => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.brbr swizzling (equivalent to decvec3.zxzx).
        /// </summary>
        public decvec4 brbr => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.zxzxx swizzling.
        /// </summary>
        public decvec5 zxzxx => new decvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.brbrr swizzling (equivalent to decvec3.zxzxx).
        /// </summary>
        public decvec5 brbrr => new decvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.zxzxy swizzling.
        /// </summary>
        public decvec5 zxzxy => new decvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.brbrg swizzling (equivalent to decvec3.zxzxy).
        /// </summary>
        public decvec5 brbrg => new decvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.zxzxz swizzling.
        /// </summary>
        public decvec5 zxzxz => new decvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.brbrb swizzling (equivalent to decvec3.zxzxz).
        /// </summary>
        public decvec5 brbrb => new decvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.zxzy swizzling.
        /// </summary>
        public decvec4 zxzy => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.brbg swizzling (equivalent to decvec3.zxzy).
        /// </summary>
        public decvec4 brbg => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.zxzyx swizzling.
        /// </summary>
        public decvec5 zxzyx => new decvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.brbgr swizzling (equivalent to decvec3.zxzyx).
        /// </summary>
        public decvec5 brbgr => new decvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.zxzyy swizzling.
        /// </summary>
        public decvec5 zxzyy => new decvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.brbgg swizzling (equivalent to decvec3.zxzyy).
        /// </summary>
        public decvec5 brbgg => new decvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.zxzyz swizzling.
        /// </summary>
        public decvec5 zxzyz => new decvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.brbgb swizzling (equivalent to decvec3.zxzyz).
        /// </summary>
        public decvec5 brbgb => new decvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.zxzz swizzling.
        /// </summary>
        public decvec4 zxzz => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.brbb swizzling (equivalent to decvec3.zxzz).
        /// </summary>
        public decvec4 brbb => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.zxzzx swizzling.
        /// </summary>
        public decvec5 zxzzx => new decvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.brbbr swizzling (equivalent to decvec3.zxzzx).
        /// </summary>
        public decvec5 brbbr => new decvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.zxzzy swizzling.
        /// </summary>
        public decvec5 zxzzy => new decvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.brbbg swizzling (equivalent to decvec3.zxzzy).
        /// </summary>
        public decvec5 brbbg => new decvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.zxzzz swizzling.
        /// </summary>
        public decvec5 zxzzz => new decvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.brbbb swizzling (equivalent to decvec3.zxzzz).
        /// </summary>
        public decvec5 brbbb => new decvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.zy swizzling.
        /// </summary>
        public decvec2 zy => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec3.bg swizzling (equivalent to decvec3.zy).
        /// </summary>
        public decvec2 bg => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec3.zyx swizzling.
        /// </summary>
        public decvec3 zyx => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec3.bgr swizzling (equivalent to decvec3.zyx).
        /// </summary>
        public decvec3 bgr => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec3.zyxx swizzling.
        /// </summary>
        public decvec4 zyxx => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.bgrr swizzling (equivalent to decvec3.zyxx).
        /// </summary>
        public decvec4 bgrr => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.zyxxx swizzling.
        /// </summary>
        public decvec5 zyxxx => new decvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.bgrrr swizzling (equivalent to decvec3.zyxxx).
        /// </summary>
        public decvec5 bgrrr => new decvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.zyxxy swizzling.
        /// </summary>
        public decvec5 zyxxy => new decvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.bgrrg swizzling (equivalent to decvec3.zyxxy).
        /// </summary>
        public decvec5 bgrrg => new decvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.zyxxz swizzling.
        /// </summary>
        public decvec5 zyxxz => new decvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.bgrrb swizzling (equivalent to decvec3.zyxxz).
        /// </summary>
        public decvec5 bgrrb => new decvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.zyxy swizzling.
        /// </summary>
        public decvec4 zyxy => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.bgrg swizzling (equivalent to decvec3.zyxy).
        /// </summary>
        public decvec4 bgrg => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.zyxyx swizzling.
        /// </summary>
        public decvec5 zyxyx => new decvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.bgrgr swizzling (equivalent to decvec3.zyxyx).
        /// </summary>
        public decvec5 bgrgr => new decvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.zyxyy swizzling.
        /// </summary>
        public decvec5 zyxyy => new decvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.bgrgg swizzling (equivalent to decvec3.zyxyy).
        /// </summary>
        public decvec5 bgrgg => new decvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.zyxyz swizzling.
        /// </summary>
        public decvec5 zyxyz => new decvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.bgrgb swizzling (equivalent to decvec3.zyxyz).
        /// </summary>
        public decvec5 bgrgb => new decvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.zyxz swizzling.
        /// </summary>
        public decvec4 zyxz => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.bgrb swizzling (equivalent to decvec3.zyxz).
        /// </summary>
        public decvec4 bgrb => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.zyxzx swizzling.
        /// </summary>
        public decvec5 zyxzx => new decvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.bgrbr swizzling (equivalent to decvec3.zyxzx).
        /// </summary>
        public decvec5 bgrbr => new decvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.zyxzy swizzling.
        /// </summary>
        public decvec5 zyxzy => new decvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.bgrbg swizzling (equivalent to decvec3.zyxzy).
        /// </summary>
        public decvec5 bgrbg => new decvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.zyxzz swizzling.
        /// </summary>
        public decvec5 zyxzz => new decvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.bgrbb swizzling (equivalent to decvec3.zyxzz).
        /// </summary>
        public decvec5 bgrbb => new decvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.zyy swizzling.
        /// </summary>
        public decvec3 zyy => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec3.bgg swizzling (equivalent to decvec3.zyy).
        /// </summary>
        public decvec3 bgg => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec3.zyyx swizzling.
        /// </summary>
        public decvec4 zyyx => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.bggr swizzling (equivalent to decvec3.zyyx).
        /// </summary>
        public decvec4 bggr => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.zyyxx swizzling.
        /// </summary>
        public decvec5 zyyxx => new decvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.bggrr swizzling (equivalent to decvec3.zyyxx).
        /// </summary>
        public decvec5 bggrr => new decvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.zyyxy swizzling.
        /// </summary>
        public decvec5 zyyxy => new decvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.bggrg swizzling (equivalent to decvec3.zyyxy).
        /// </summary>
        public decvec5 bggrg => new decvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.zyyxz swizzling.
        /// </summary>
        public decvec5 zyyxz => new decvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.bggrb swizzling (equivalent to decvec3.zyyxz).
        /// </summary>
        public decvec5 bggrb => new decvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.zyyy swizzling.
        /// </summary>
        public decvec4 zyyy => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.bggg swizzling (equivalent to decvec3.zyyy).
        /// </summary>
        public decvec4 bggg => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.zyyyx swizzling.
        /// </summary>
        public decvec5 zyyyx => new decvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.bgggr swizzling (equivalent to decvec3.zyyyx).
        /// </summary>
        public decvec5 bgggr => new decvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.zyyyy swizzling.
        /// </summary>
        public decvec5 zyyyy => new decvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.bgggg swizzling (equivalent to decvec3.zyyyy).
        /// </summary>
        public decvec5 bgggg => new decvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.zyyyz swizzling.
        /// </summary>
        public decvec5 zyyyz => new decvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.bgggb swizzling (equivalent to decvec3.zyyyz).
        /// </summary>
        public decvec5 bgggb => new decvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.zyyz swizzling.
        /// </summary>
        public decvec4 zyyz => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.bggb swizzling (equivalent to decvec3.zyyz).
        /// </summary>
        public decvec4 bggb => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.zyyzx swizzling.
        /// </summary>
        public decvec5 zyyzx => new decvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.bggbr swizzling (equivalent to decvec3.zyyzx).
        /// </summary>
        public decvec5 bggbr => new decvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.zyyzy swizzling.
        /// </summary>
        public decvec5 zyyzy => new decvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.bggbg swizzling (equivalent to decvec3.zyyzy).
        /// </summary>
        public decvec5 bggbg => new decvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.zyyzz swizzling.
        /// </summary>
        public decvec5 zyyzz => new decvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.bggbb swizzling (equivalent to decvec3.zyyzz).
        /// </summary>
        public decvec5 bggbb => new decvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.zyz swizzling.
        /// </summary>
        public decvec3 zyz => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec3.bgb swizzling (equivalent to decvec3.zyz).
        /// </summary>
        public decvec3 bgb => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec3.zyzx swizzling.
        /// </summary>
        public decvec4 zyzx => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.bgbr swizzling (equivalent to decvec3.zyzx).
        /// </summary>
        public decvec4 bgbr => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.zyzxx swizzling.
        /// </summary>
        public decvec5 zyzxx => new decvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.bgbrr swizzling (equivalent to decvec3.zyzxx).
        /// </summary>
        public decvec5 bgbrr => new decvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.zyzxy swizzling.
        /// </summary>
        public decvec5 zyzxy => new decvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.bgbrg swizzling (equivalent to decvec3.zyzxy).
        /// </summary>
        public decvec5 bgbrg => new decvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.zyzxz swizzling.
        /// </summary>
        public decvec5 zyzxz => new decvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.bgbrb swizzling (equivalent to decvec3.zyzxz).
        /// </summary>
        public decvec5 bgbrb => new decvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.zyzy swizzling.
        /// </summary>
        public decvec4 zyzy => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.bgbg swizzling (equivalent to decvec3.zyzy).
        /// </summary>
        public decvec4 bgbg => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.zyzyx swizzling.
        /// </summary>
        public decvec5 zyzyx => new decvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.bgbgr swizzling (equivalent to decvec3.zyzyx).
        /// </summary>
        public decvec5 bgbgr => new decvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.zyzyy swizzling.
        /// </summary>
        public decvec5 zyzyy => new decvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.bgbgg swizzling (equivalent to decvec3.zyzyy).
        /// </summary>
        public decvec5 bgbgg => new decvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.zyzyz swizzling.
        /// </summary>
        public decvec5 zyzyz => new decvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.bgbgb swizzling (equivalent to decvec3.zyzyz).
        /// </summary>
        public decvec5 bgbgb => new decvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.zyzz swizzling.
        /// </summary>
        public decvec4 zyzz => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.bgbb swizzling (equivalent to decvec3.zyzz).
        /// </summary>
        public decvec4 bgbb => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.zyzzx swizzling.
        /// </summary>
        public decvec5 zyzzx => new decvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.bgbbr swizzling (equivalent to decvec3.zyzzx).
        /// </summary>
        public decvec5 bgbbr => new decvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.zyzzy swizzling.
        /// </summary>
        public decvec5 zyzzy => new decvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.bgbbg swizzling (equivalent to decvec3.zyzzy).
        /// </summary>
        public decvec5 bgbbg => new decvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.zyzzz swizzling.
        /// </summary>
        public decvec5 zyzzz => new decvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.bgbbb swizzling (equivalent to decvec3.zyzzz).
        /// </summary>
        public decvec5 bgbbb => new decvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.zz swizzling.
        /// </summary>
        public decvec2 zz => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec3.bb swizzling (equivalent to decvec3.zz).
        /// </summary>
        public decvec2 bb => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec3.zzx swizzling.
        /// </summary>
        public decvec3 zzx => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec3.bbr swizzling (equivalent to decvec3.zzx).
        /// </summary>
        public decvec3 bbr => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec3.zzxx swizzling.
        /// </summary>
        public decvec4 zzxx => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.bbrr swizzling (equivalent to decvec3.zzxx).
        /// </summary>
        public decvec4 bbrr => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.zzxxx swizzling.
        /// </summary>
        public decvec5 zzxxx => new decvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.bbrrr swizzling (equivalent to decvec3.zzxxx).
        /// </summary>
        public decvec5 bbrrr => new decvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.zzxxy swizzling.
        /// </summary>
        public decvec5 zzxxy => new decvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.bbrrg swizzling (equivalent to decvec3.zzxxy).
        /// </summary>
        public decvec5 bbrrg => new decvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.zzxxz swizzling.
        /// </summary>
        public decvec5 zzxxz => new decvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.bbrrb swizzling (equivalent to decvec3.zzxxz).
        /// </summary>
        public decvec5 bbrrb => new decvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.zzxy swizzling.
        /// </summary>
        public decvec4 zzxy => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.bbrg swizzling (equivalent to decvec3.zzxy).
        /// </summary>
        public decvec4 bbrg => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.zzxyx swizzling.
        /// </summary>
        public decvec5 zzxyx => new decvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.bbrgr swizzling (equivalent to decvec3.zzxyx).
        /// </summary>
        public decvec5 bbrgr => new decvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.zzxyy swizzling.
        /// </summary>
        public decvec5 zzxyy => new decvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.bbrgg swizzling (equivalent to decvec3.zzxyy).
        /// </summary>
        public decvec5 bbrgg => new decvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.zzxyz swizzling.
        /// </summary>
        public decvec5 zzxyz => new decvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.bbrgb swizzling (equivalent to decvec3.zzxyz).
        /// </summary>
        public decvec5 bbrgb => new decvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.zzxz swizzling.
        /// </summary>
        public decvec4 zzxz => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.bbrb swizzling (equivalent to decvec3.zzxz).
        /// </summary>
        public decvec4 bbrb => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.zzxzx swizzling.
        /// </summary>
        public decvec5 zzxzx => new decvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.bbrbr swizzling (equivalent to decvec3.zzxzx).
        /// </summary>
        public decvec5 bbrbr => new decvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.zzxzy swizzling.
        /// </summary>
        public decvec5 zzxzy => new decvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.bbrbg swizzling (equivalent to decvec3.zzxzy).
        /// </summary>
        public decvec5 bbrbg => new decvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.zzxzz swizzling.
        /// </summary>
        public decvec5 zzxzz => new decvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.bbrbb swizzling (equivalent to decvec3.zzxzz).
        /// </summary>
        public decvec5 bbrbb => new decvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.zzy swizzling.
        /// </summary>
        public decvec3 zzy => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec3.bbg swizzling (equivalent to decvec3.zzy).
        /// </summary>
        public decvec3 bbg => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec3.zzyx swizzling.
        /// </summary>
        public decvec4 zzyx => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.bbgr swizzling (equivalent to decvec3.zzyx).
        /// </summary>
        public decvec4 bbgr => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.zzyxx swizzling.
        /// </summary>
        public decvec5 zzyxx => new decvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.bbgrr swizzling (equivalent to decvec3.zzyxx).
        /// </summary>
        public decvec5 bbgrr => new decvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.zzyxy swizzling.
        /// </summary>
        public decvec5 zzyxy => new decvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.bbgrg swizzling (equivalent to decvec3.zzyxy).
        /// </summary>
        public decvec5 bbgrg => new decvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.zzyxz swizzling.
        /// </summary>
        public decvec5 zzyxz => new decvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.bbgrb swizzling (equivalent to decvec3.zzyxz).
        /// </summary>
        public decvec5 bbgrb => new decvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.zzyy swizzling.
        /// </summary>
        public decvec4 zzyy => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.bbgg swizzling (equivalent to decvec3.zzyy).
        /// </summary>
        public decvec4 bbgg => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.zzyyx swizzling.
        /// </summary>
        public decvec5 zzyyx => new decvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.bbggr swizzling (equivalent to decvec3.zzyyx).
        /// </summary>
        public decvec5 bbggr => new decvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.zzyyy swizzling.
        /// </summary>
        public decvec5 zzyyy => new decvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.bbggg swizzling (equivalent to decvec3.zzyyy).
        /// </summary>
        public decvec5 bbggg => new decvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.zzyyz swizzling.
        /// </summary>
        public decvec5 zzyyz => new decvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.bbggb swizzling (equivalent to decvec3.zzyyz).
        /// </summary>
        public decvec5 bbggb => new decvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.zzyz swizzling.
        /// </summary>
        public decvec4 zzyz => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.bbgb swizzling (equivalent to decvec3.zzyz).
        /// </summary>
        public decvec4 bbgb => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.zzyzx swizzling.
        /// </summary>
        public decvec5 zzyzx => new decvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.bbgbr swizzling (equivalent to decvec3.zzyzx).
        /// </summary>
        public decvec5 bbgbr => new decvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.zzyzy swizzling.
        /// </summary>
        public decvec5 zzyzy => new decvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.bbgbg swizzling (equivalent to decvec3.zzyzy).
        /// </summary>
        public decvec5 bbgbg => new decvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.zzyzz swizzling.
        /// </summary>
        public decvec5 zzyzz => new decvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.bbgbb swizzling (equivalent to decvec3.zzyzz).
        /// </summary>
        public decvec5 bbgbb => new decvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.zzz swizzling.
        /// </summary>
        public decvec3 zzz => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec3.bbb swizzling (equivalent to decvec3.zzz).
        /// </summary>
        public decvec3 bbb => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec3.zzzx swizzling.
        /// </summary>
        public decvec4 zzzx => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.bbbr swizzling (equivalent to decvec3.zzzx).
        /// </summary>
        public decvec4 bbbr => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.zzzxx swizzling.
        /// </summary>
        public decvec5 zzzxx => new decvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.bbbrr swizzling (equivalent to decvec3.zzzxx).
        /// </summary>
        public decvec5 bbbrr => new decvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.zzzxy swizzling.
        /// </summary>
        public decvec5 zzzxy => new decvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.bbbrg swizzling (equivalent to decvec3.zzzxy).
        /// </summary>
        public decvec5 bbbrg => new decvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.zzzxz swizzling.
        /// </summary>
        public decvec5 zzzxz => new decvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.bbbrb swizzling (equivalent to decvec3.zzzxz).
        /// </summary>
        public decvec5 bbbrb => new decvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.zzzy swizzling.
        /// </summary>
        public decvec4 zzzy => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.bbbg swizzling (equivalent to decvec3.zzzy).
        /// </summary>
        public decvec4 bbbg => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.zzzyx swizzling.
        /// </summary>
        public decvec5 zzzyx => new decvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.bbbgr swizzling (equivalent to decvec3.zzzyx).
        /// </summary>
        public decvec5 bbbgr => new decvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.zzzyy swizzling.
        /// </summary>
        public decvec5 zzzyy => new decvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.bbbgg swizzling (equivalent to decvec3.zzzyy).
        /// </summary>
        public decvec5 bbbgg => new decvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.zzzyz swizzling.
        /// </summary>
        public decvec5 zzzyz => new decvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.bbbgb swizzling (equivalent to decvec3.zzzyz).
        /// </summary>
        public decvec5 bbbgb => new decvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.zzzz swizzling.
        /// </summary>
        public decvec4 zzzz => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec3.bbbb swizzling (equivalent to decvec3.zzzz).
        /// </summary>
        public decvec4 bbbb => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec3.zzzzx swizzling.
        /// </summary>
        public decvec5 zzzzx => new decvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.bbbbr swizzling (equivalent to decvec3.zzzzx).
        /// </summary>
        public decvec5 bbbbr => new decvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.zzzzy swizzling.
        /// </summary>
        public decvec5 zzzzy => new decvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.bbbbg swizzling (equivalent to decvec3.zzzzy).
        /// </summary>
        public decvec5 bbbbg => new decvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.zzzzz swizzling.
        /// </summary>
        public decvec5 zzzzz => new decvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns decvec3.bbbbb swizzling (equivalent to decvec3.zzzzz).
        /// </summary>
        public decvec5 bbbbb => new decvec5(z, z, z, z, z);

        #endregion

    }
}
