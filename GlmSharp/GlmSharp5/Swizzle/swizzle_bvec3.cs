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
    /// Temporary vector of type bool with 3 components, used for implementing swizzling for bvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_bvec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly bool z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_bvec3.
        /// </summary>
        internal swizzle_bvec3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns bvec3.xx swizzling.
        /// </summary>
        public bvec2 xx => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec3.rr swizzling (equivalent to bvec3.xx).
        /// </summary>
        public bvec2 rr => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec3.xxx swizzling.
        /// </summary>
        public bvec3 xxx => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec3.rrr swizzling (equivalent to bvec3.xxx).
        /// </summary>
        public bvec3 rrr => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec3.xxxx swizzling.
        /// </summary>
        public bvec4 xxxx => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.rrrr swizzling (equivalent to bvec3.xxxx).
        /// </summary>
        public bvec4 rrrr => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.xxxxx swizzling.
        /// </summary>
        public bvec5 xxxxx => new bvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.rrrrr swizzling (equivalent to bvec3.xxxxx).
        /// </summary>
        public bvec5 rrrrr => new bvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.xxxxy swizzling.
        /// </summary>
        public bvec5 xxxxy => new bvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.rrrrg swizzling (equivalent to bvec3.xxxxy).
        /// </summary>
        public bvec5 rrrrg => new bvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.xxxxz swizzling.
        /// </summary>
        public bvec5 xxxxz => new bvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.rrrrb swizzling (equivalent to bvec3.xxxxz).
        /// </summary>
        public bvec5 rrrrb => new bvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.xxxy swizzling.
        /// </summary>
        public bvec4 xxxy => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.rrrg swizzling (equivalent to bvec3.xxxy).
        /// </summary>
        public bvec4 rrrg => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.xxxyx swizzling.
        /// </summary>
        public bvec5 xxxyx => new bvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.rrrgr swizzling (equivalent to bvec3.xxxyx).
        /// </summary>
        public bvec5 rrrgr => new bvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.xxxyy swizzling.
        /// </summary>
        public bvec5 xxxyy => new bvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.rrrgg swizzling (equivalent to bvec3.xxxyy).
        /// </summary>
        public bvec5 rrrgg => new bvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.xxxyz swizzling.
        /// </summary>
        public bvec5 xxxyz => new bvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.rrrgb swizzling (equivalent to bvec3.xxxyz).
        /// </summary>
        public bvec5 rrrgb => new bvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.xxxz swizzling.
        /// </summary>
        public bvec4 xxxz => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.rrrb swizzling (equivalent to bvec3.xxxz).
        /// </summary>
        public bvec4 rrrb => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.xxxzx swizzling.
        /// </summary>
        public bvec5 xxxzx => new bvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.rrrbr swizzling (equivalent to bvec3.xxxzx).
        /// </summary>
        public bvec5 rrrbr => new bvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.xxxzy swizzling.
        /// </summary>
        public bvec5 xxxzy => new bvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.rrrbg swizzling (equivalent to bvec3.xxxzy).
        /// </summary>
        public bvec5 rrrbg => new bvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.xxxzz swizzling.
        /// </summary>
        public bvec5 xxxzz => new bvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.rrrbb swizzling (equivalent to bvec3.xxxzz).
        /// </summary>
        public bvec5 rrrbb => new bvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.xxy swizzling.
        /// </summary>
        public bvec3 xxy => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec3.rrg swizzling (equivalent to bvec3.xxy).
        /// </summary>
        public bvec3 rrg => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec3.xxyx swizzling.
        /// </summary>
        public bvec4 xxyx => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.rrgr swizzling (equivalent to bvec3.xxyx).
        /// </summary>
        public bvec4 rrgr => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.xxyxx swizzling.
        /// </summary>
        public bvec5 xxyxx => new bvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.rrgrr swizzling (equivalent to bvec3.xxyxx).
        /// </summary>
        public bvec5 rrgrr => new bvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.xxyxy swizzling.
        /// </summary>
        public bvec5 xxyxy => new bvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.rrgrg swizzling (equivalent to bvec3.xxyxy).
        /// </summary>
        public bvec5 rrgrg => new bvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.xxyxz swizzling.
        /// </summary>
        public bvec5 xxyxz => new bvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.rrgrb swizzling (equivalent to bvec3.xxyxz).
        /// </summary>
        public bvec5 rrgrb => new bvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.xxyy swizzling.
        /// </summary>
        public bvec4 xxyy => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.rrgg swizzling (equivalent to bvec3.xxyy).
        /// </summary>
        public bvec4 rrgg => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.xxyyx swizzling.
        /// </summary>
        public bvec5 xxyyx => new bvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.rrggr swizzling (equivalent to bvec3.xxyyx).
        /// </summary>
        public bvec5 rrggr => new bvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.xxyyy swizzling.
        /// </summary>
        public bvec5 xxyyy => new bvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.rrggg swizzling (equivalent to bvec3.xxyyy).
        /// </summary>
        public bvec5 rrggg => new bvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.xxyyz swizzling.
        /// </summary>
        public bvec5 xxyyz => new bvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.rrggb swizzling (equivalent to bvec3.xxyyz).
        /// </summary>
        public bvec5 rrggb => new bvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.xxyz swizzling.
        /// </summary>
        public bvec4 xxyz => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.rrgb swizzling (equivalent to bvec3.xxyz).
        /// </summary>
        public bvec4 rrgb => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.xxyzx swizzling.
        /// </summary>
        public bvec5 xxyzx => new bvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.rrgbr swizzling (equivalent to bvec3.xxyzx).
        /// </summary>
        public bvec5 rrgbr => new bvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.xxyzy swizzling.
        /// </summary>
        public bvec5 xxyzy => new bvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.rrgbg swizzling (equivalent to bvec3.xxyzy).
        /// </summary>
        public bvec5 rrgbg => new bvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.xxyzz swizzling.
        /// </summary>
        public bvec5 xxyzz => new bvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.rrgbb swizzling (equivalent to bvec3.xxyzz).
        /// </summary>
        public bvec5 rrgbb => new bvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.xxz swizzling.
        /// </summary>
        public bvec3 xxz => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec3.rrb swizzling (equivalent to bvec3.xxz).
        /// </summary>
        public bvec3 rrb => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec3.xxzx swizzling.
        /// </summary>
        public bvec4 xxzx => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.rrbr swizzling (equivalent to bvec3.xxzx).
        /// </summary>
        public bvec4 rrbr => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.xxzxx swizzling.
        /// </summary>
        public bvec5 xxzxx => new bvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.rrbrr swizzling (equivalent to bvec3.xxzxx).
        /// </summary>
        public bvec5 rrbrr => new bvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.xxzxy swizzling.
        /// </summary>
        public bvec5 xxzxy => new bvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.rrbrg swizzling (equivalent to bvec3.xxzxy).
        /// </summary>
        public bvec5 rrbrg => new bvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.xxzxz swizzling.
        /// </summary>
        public bvec5 xxzxz => new bvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.rrbrb swizzling (equivalent to bvec3.xxzxz).
        /// </summary>
        public bvec5 rrbrb => new bvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.xxzy swizzling.
        /// </summary>
        public bvec4 xxzy => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.rrbg swizzling (equivalent to bvec3.xxzy).
        /// </summary>
        public bvec4 rrbg => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.xxzyx swizzling.
        /// </summary>
        public bvec5 xxzyx => new bvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.rrbgr swizzling (equivalent to bvec3.xxzyx).
        /// </summary>
        public bvec5 rrbgr => new bvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.xxzyy swizzling.
        /// </summary>
        public bvec5 xxzyy => new bvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.rrbgg swizzling (equivalent to bvec3.xxzyy).
        /// </summary>
        public bvec5 rrbgg => new bvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.xxzyz swizzling.
        /// </summary>
        public bvec5 xxzyz => new bvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.rrbgb swizzling (equivalent to bvec3.xxzyz).
        /// </summary>
        public bvec5 rrbgb => new bvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.xxzz swizzling.
        /// </summary>
        public bvec4 xxzz => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.rrbb swizzling (equivalent to bvec3.xxzz).
        /// </summary>
        public bvec4 rrbb => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.xxzzx swizzling.
        /// </summary>
        public bvec5 xxzzx => new bvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.rrbbr swizzling (equivalent to bvec3.xxzzx).
        /// </summary>
        public bvec5 rrbbr => new bvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.xxzzy swizzling.
        /// </summary>
        public bvec5 xxzzy => new bvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.rrbbg swizzling (equivalent to bvec3.xxzzy).
        /// </summary>
        public bvec5 rrbbg => new bvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.xxzzz swizzling.
        /// </summary>
        public bvec5 xxzzz => new bvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.rrbbb swizzling (equivalent to bvec3.xxzzz).
        /// </summary>
        public bvec5 rrbbb => new bvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.xy swizzling.
        /// </summary>
        public bvec2 xy => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec3.rg swizzling (equivalent to bvec3.xy).
        /// </summary>
        public bvec2 rg => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec3.xyx swizzling.
        /// </summary>
        public bvec3 xyx => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec3.rgr swizzling (equivalent to bvec3.xyx).
        /// </summary>
        public bvec3 rgr => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec3.xyxx swizzling.
        /// </summary>
        public bvec4 xyxx => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.rgrr swizzling (equivalent to bvec3.xyxx).
        /// </summary>
        public bvec4 rgrr => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.xyxxx swizzling.
        /// </summary>
        public bvec5 xyxxx => new bvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.rgrrr swizzling (equivalent to bvec3.xyxxx).
        /// </summary>
        public bvec5 rgrrr => new bvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.xyxxy swizzling.
        /// </summary>
        public bvec5 xyxxy => new bvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.rgrrg swizzling (equivalent to bvec3.xyxxy).
        /// </summary>
        public bvec5 rgrrg => new bvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.xyxxz swizzling.
        /// </summary>
        public bvec5 xyxxz => new bvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.rgrrb swizzling (equivalent to bvec3.xyxxz).
        /// </summary>
        public bvec5 rgrrb => new bvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.xyxy swizzling.
        /// </summary>
        public bvec4 xyxy => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.rgrg swizzling (equivalent to bvec3.xyxy).
        /// </summary>
        public bvec4 rgrg => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.xyxyx swizzling.
        /// </summary>
        public bvec5 xyxyx => new bvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.rgrgr swizzling (equivalent to bvec3.xyxyx).
        /// </summary>
        public bvec5 rgrgr => new bvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.xyxyy swizzling.
        /// </summary>
        public bvec5 xyxyy => new bvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.rgrgg swizzling (equivalent to bvec3.xyxyy).
        /// </summary>
        public bvec5 rgrgg => new bvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.xyxyz swizzling.
        /// </summary>
        public bvec5 xyxyz => new bvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.rgrgb swizzling (equivalent to bvec3.xyxyz).
        /// </summary>
        public bvec5 rgrgb => new bvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.xyxz swizzling.
        /// </summary>
        public bvec4 xyxz => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.rgrb swizzling (equivalent to bvec3.xyxz).
        /// </summary>
        public bvec4 rgrb => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.xyxzx swizzling.
        /// </summary>
        public bvec5 xyxzx => new bvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.rgrbr swizzling (equivalent to bvec3.xyxzx).
        /// </summary>
        public bvec5 rgrbr => new bvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.xyxzy swizzling.
        /// </summary>
        public bvec5 xyxzy => new bvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.rgrbg swizzling (equivalent to bvec3.xyxzy).
        /// </summary>
        public bvec5 rgrbg => new bvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.xyxzz swizzling.
        /// </summary>
        public bvec5 xyxzz => new bvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.rgrbb swizzling (equivalent to bvec3.xyxzz).
        /// </summary>
        public bvec5 rgrbb => new bvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.xyy swizzling.
        /// </summary>
        public bvec3 xyy => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec3.rgg swizzling (equivalent to bvec3.xyy).
        /// </summary>
        public bvec3 rgg => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec3.xyyx swizzling.
        /// </summary>
        public bvec4 xyyx => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.rggr swizzling (equivalent to bvec3.xyyx).
        /// </summary>
        public bvec4 rggr => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.xyyxx swizzling.
        /// </summary>
        public bvec5 xyyxx => new bvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.rggrr swizzling (equivalent to bvec3.xyyxx).
        /// </summary>
        public bvec5 rggrr => new bvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.xyyxy swizzling.
        /// </summary>
        public bvec5 xyyxy => new bvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.rggrg swizzling (equivalent to bvec3.xyyxy).
        /// </summary>
        public bvec5 rggrg => new bvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.xyyxz swizzling.
        /// </summary>
        public bvec5 xyyxz => new bvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.rggrb swizzling (equivalent to bvec3.xyyxz).
        /// </summary>
        public bvec5 rggrb => new bvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.xyyy swizzling.
        /// </summary>
        public bvec4 xyyy => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.rggg swizzling (equivalent to bvec3.xyyy).
        /// </summary>
        public bvec4 rggg => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.xyyyx swizzling.
        /// </summary>
        public bvec5 xyyyx => new bvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.rgggr swizzling (equivalent to bvec3.xyyyx).
        /// </summary>
        public bvec5 rgggr => new bvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.xyyyy swizzling.
        /// </summary>
        public bvec5 xyyyy => new bvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.rgggg swizzling (equivalent to bvec3.xyyyy).
        /// </summary>
        public bvec5 rgggg => new bvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.xyyyz swizzling.
        /// </summary>
        public bvec5 xyyyz => new bvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.rgggb swizzling (equivalent to bvec3.xyyyz).
        /// </summary>
        public bvec5 rgggb => new bvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.xyyz swizzling.
        /// </summary>
        public bvec4 xyyz => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.rggb swizzling (equivalent to bvec3.xyyz).
        /// </summary>
        public bvec4 rggb => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.xyyzx swizzling.
        /// </summary>
        public bvec5 xyyzx => new bvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.rggbr swizzling (equivalent to bvec3.xyyzx).
        /// </summary>
        public bvec5 rggbr => new bvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.xyyzy swizzling.
        /// </summary>
        public bvec5 xyyzy => new bvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.rggbg swizzling (equivalent to bvec3.xyyzy).
        /// </summary>
        public bvec5 rggbg => new bvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.xyyzz swizzling.
        /// </summary>
        public bvec5 xyyzz => new bvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.rggbb swizzling (equivalent to bvec3.xyyzz).
        /// </summary>
        public bvec5 rggbb => new bvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.xyz swizzling.
        /// </summary>
        public bvec3 xyz => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec3.rgb swizzling (equivalent to bvec3.xyz).
        /// </summary>
        public bvec3 rgb => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec3.xyzx swizzling.
        /// </summary>
        public bvec4 xyzx => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.rgbr swizzling (equivalent to bvec3.xyzx).
        /// </summary>
        public bvec4 rgbr => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.xyzxx swizzling.
        /// </summary>
        public bvec5 xyzxx => new bvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.rgbrr swizzling (equivalent to bvec3.xyzxx).
        /// </summary>
        public bvec5 rgbrr => new bvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.xyzxy swizzling.
        /// </summary>
        public bvec5 xyzxy => new bvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.rgbrg swizzling (equivalent to bvec3.xyzxy).
        /// </summary>
        public bvec5 rgbrg => new bvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.xyzxz swizzling.
        /// </summary>
        public bvec5 xyzxz => new bvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.rgbrb swizzling (equivalent to bvec3.xyzxz).
        /// </summary>
        public bvec5 rgbrb => new bvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.xyzy swizzling.
        /// </summary>
        public bvec4 xyzy => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.rgbg swizzling (equivalent to bvec3.xyzy).
        /// </summary>
        public bvec4 rgbg => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.xyzyx swizzling.
        /// </summary>
        public bvec5 xyzyx => new bvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.rgbgr swizzling (equivalent to bvec3.xyzyx).
        /// </summary>
        public bvec5 rgbgr => new bvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.xyzyy swizzling.
        /// </summary>
        public bvec5 xyzyy => new bvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.rgbgg swizzling (equivalent to bvec3.xyzyy).
        /// </summary>
        public bvec5 rgbgg => new bvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.xyzyz swizzling.
        /// </summary>
        public bvec5 xyzyz => new bvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.rgbgb swizzling (equivalent to bvec3.xyzyz).
        /// </summary>
        public bvec5 rgbgb => new bvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.xyzz swizzling.
        /// </summary>
        public bvec4 xyzz => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.rgbb swizzling (equivalent to bvec3.xyzz).
        /// </summary>
        public bvec4 rgbb => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.xyzzx swizzling.
        /// </summary>
        public bvec5 xyzzx => new bvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.rgbbr swizzling (equivalent to bvec3.xyzzx).
        /// </summary>
        public bvec5 rgbbr => new bvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.xyzzy swizzling.
        /// </summary>
        public bvec5 xyzzy => new bvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.rgbbg swizzling (equivalent to bvec3.xyzzy).
        /// </summary>
        public bvec5 rgbbg => new bvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.xyzzz swizzling.
        /// </summary>
        public bvec5 xyzzz => new bvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.rgbbb swizzling (equivalent to bvec3.xyzzz).
        /// </summary>
        public bvec5 rgbbb => new bvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.xz swizzling.
        /// </summary>
        public bvec2 xz => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec3.rb swizzling (equivalent to bvec3.xz).
        /// </summary>
        public bvec2 rb => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec3.xzx swizzling.
        /// </summary>
        public bvec3 xzx => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec3.rbr swizzling (equivalent to bvec3.xzx).
        /// </summary>
        public bvec3 rbr => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec3.xzxx swizzling.
        /// </summary>
        public bvec4 xzxx => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.rbrr swizzling (equivalent to bvec3.xzxx).
        /// </summary>
        public bvec4 rbrr => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.xzxxx swizzling.
        /// </summary>
        public bvec5 xzxxx => new bvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.rbrrr swizzling (equivalent to bvec3.xzxxx).
        /// </summary>
        public bvec5 rbrrr => new bvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.xzxxy swizzling.
        /// </summary>
        public bvec5 xzxxy => new bvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.rbrrg swizzling (equivalent to bvec3.xzxxy).
        /// </summary>
        public bvec5 rbrrg => new bvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.xzxxz swizzling.
        /// </summary>
        public bvec5 xzxxz => new bvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.rbrrb swizzling (equivalent to bvec3.xzxxz).
        /// </summary>
        public bvec5 rbrrb => new bvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.xzxy swizzling.
        /// </summary>
        public bvec4 xzxy => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.rbrg swizzling (equivalent to bvec3.xzxy).
        /// </summary>
        public bvec4 rbrg => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.xzxyx swizzling.
        /// </summary>
        public bvec5 xzxyx => new bvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.rbrgr swizzling (equivalent to bvec3.xzxyx).
        /// </summary>
        public bvec5 rbrgr => new bvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.xzxyy swizzling.
        /// </summary>
        public bvec5 xzxyy => new bvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.rbrgg swizzling (equivalent to bvec3.xzxyy).
        /// </summary>
        public bvec5 rbrgg => new bvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.xzxyz swizzling.
        /// </summary>
        public bvec5 xzxyz => new bvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.rbrgb swizzling (equivalent to bvec3.xzxyz).
        /// </summary>
        public bvec5 rbrgb => new bvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.xzxz swizzling.
        /// </summary>
        public bvec4 xzxz => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.rbrb swizzling (equivalent to bvec3.xzxz).
        /// </summary>
        public bvec4 rbrb => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.xzxzx swizzling.
        /// </summary>
        public bvec5 xzxzx => new bvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.rbrbr swizzling (equivalent to bvec3.xzxzx).
        /// </summary>
        public bvec5 rbrbr => new bvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.xzxzy swizzling.
        /// </summary>
        public bvec5 xzxzy => new bvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.rbrbg swizzling (equivalent to bvec3.xzxzy).
        /// </summary>
        public bvec5 rbrbg => new bvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.xzxzz swizzling.
        /// </summary>
        public bvec5 xzxzz => new bvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.rbrbb swizzling (equivalent to bvec3.xzxzz).
        /// </summary>
        public bvec5 rbrbb => new bvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.xzy swizzling.
        /// </summary>
        public bvec3 xzy => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec3.rbg swizzling (equivalent to bvec3.xzy).
        /// </summary>
        public bvec3 rbg => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec3.xzyx swizzling.
        /// </summary>
        public bvec4 xzyx => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.rbgr swizzling (equivalent to bvec3.xzyx).
        /// </summary>
        public bvec4 rbgr => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.xzyxx swizzling.
        /// </summary>
        public bvec5 xzyxx => new bvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.rbgrr swizzling (equivalent to bvec3.xzyxx).
        /// </summary>
        public bvec5 rbgrr => new bvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.xzyxy swizzling.
        /// </summary>
        public bvec5 xzyxy => new bvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.rbgrg swizzling (equivalent to bvec3.xzyxy).
        /// </summary>
        public bvec5 rbgrg => new bvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.xzyxz swizzling.
        /// </summary>
        public bvec5 xzyxz => new bvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.rbgrb swizzling (equivalent to bvec3.xzyxz).
        /// </summary>
        public bvec5 rbgrb => new bvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.xzyy swizzling.
        /// </summary>
        public bvec4 xzyy => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.rbgg swizzling (equivalent to bvec3.xzyy).
        /// </summary>
        public bvec4 rbgg => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.xzyyx swizzling.
        /// </summary>
        public bvec5 xzyyx => new bvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.rbggr swizzling (equivalent to bvec3.xzyyx).
        /// </summary>
        public bvec5 rbggr => new bvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.xzyyy swizzling.
        /// </summary>
        public bvec5 xzyyy => new bvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.rbggg swizzling (equivalent to bvec3.xzyyy).
        /// </summary>
        public bvec5 rbggg => new bvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.xzyyz swizzling.
        /// </summary>
        public bvec5 xzyyz => new bvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.rbggb swizzling (equivalent to bvec3.xzyyz).
        /// </summary>
        public bvec5 rbggb => new bvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.xzyz swizzling.
        /// </summary>
        public bvec4 xzyz => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.rbgb swizzling (equivalent to bvec3.xzyz).
        /// </summary>
        public bvec4 rbgb => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.xzyzx swizzling.
        /// </summary>
        public bvec5 xzyzx => new bvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.rbgbr swizzling (equivalent to bvec3.xzyzx).
        /// </summary>
        public bvec5 rbgbr => new bvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.xzyzy swizzling.
        /// </summary>
        public bvec5 xzyzy => new bvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.rbgbg swizzling (equivalent to bvec3.xzyzy).
        /// </summary>
        public bvec5 rbgbg => new bvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.xzyzz swizzling.
        /// </summary>
        public bvec5 xzyzz => new bvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.rbgbb swizzling (equivalent to bvec3.xzyzz).
        /// </summary>
        public bvec5 rbgbb => new bvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.xzz swizzling.
        /// </summary>
        public bvec3 xzz => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec3.rbb swizzling (equivalent to bvec3.xzz).
        /// </summary>
        public bvec3 rbb => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec3.xzzx swizzling.
        /// </summary>
        public bvec4 xzzx => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.rbbr swizzling (equivalent to bvec3.xzzx).
        /// </summary>
        public bvec4 rbbr => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.xzzxx swizzling.
        /// </summary>
        public bvec5 xzzxx => new bvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.rbbrr swizzling (equivalent to bvec3.xzzxx).
        /// </summary>
        public bvec5 rbbrr => new bvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.xzzxy swizzling.
        /// </summary>
        public bvec5 xzzxy => new bvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.rbbrg swizzling (equivalent to bvec3.xzzxy).
        /// </summary>
        public bvec5 rbbrg => new bvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.xzzxz swizzling.
        /// </summary>
        public bvec5 xzzxz => new bvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.rbbrb swizzling (equivalent to bvec3.xzzxz).
        /// </summary>
        public bvec5 rbbrb => new bvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.xzzy swizzling.
        /// </summary>
        public bvec4 xzzy => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.rbbg swizzling (equivalent to bvec3.xzzy).
        /// </summary>
        public bvec4 rbbg => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.xzzyx swizzling.
        /// </summary>
        public bvec5 xzzyx => new bvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.rbbgr swizzling (equivalent to bvec3.xzzyx).
        /// </summary>
        public bvec5 rbbgr => new bvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.xzzyy swizzling.
        /// </summary>
        public bvec5 xzzyy => new bvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.rbbgg swizzling (equivalent to bvec3.xzzyy).
        /// </summary>
        public bvec5 rbbgg => new bvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.xzzyz swizzling.
        /// </summary>
        public bvec5 xzzyz => new bvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.rbbgb swizzling (equivalent to bvec3.xzzyz).
        /// </summary>
        public bvec5 rbbgb => new bvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.xzzz swizzling.
        /// </summary>
        public bvec4 xzzz => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.rbbb swizzling (equivalent to bvec3.xzzz).
        /// </summary>
        public bvec4 rbbb => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.xzzzx swizzling.
        /// </summary>
        public bvec5 xzzzx => new bvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.rbbbr swizzling (equivalent to bvec3.xzzzx).
        /// </summary>
        public bvec5 rbbbr => new bvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.xzzzy swizzling.
        /// </summary>
        public bvec5 xzzzy => new bvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.rbbbg swizzling (equivalent to bvec3.xzzzy).
        /// </summary>
        public bvec5 rbbbg => new bvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.xzzzz swizzling.
        /// </summary>
        public bvec5 xzzzz => new bvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns bvec3.rbbbb swizzling (equivalent to bvec3.xzzzz).
        /// </summary>
        public bvec5 rbbbb => new bvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns bvec3.yx swizzling.
        /// </summary>
        public bvec2 yx => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec3.gr swizzling (equivalent to bvec3.yx).
        /// </summary>
        public bvec2 gr => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec3.yxx swizzling.
        /// </summary>
        public bvec3 yxx => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec3.grr swizzling (equivalent to bvec3.yxx).
        /// </summary>
        public bvec3 grr => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec3.yxxx swizzling.
        /// </summary>
        public bvec4 yxxx => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.grrr swizzling (equivalent to bvec3.yxxx).
        /// </summary>
        public bvec4 grrr => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.yxxxx swizzling.
        /// </summary>
        public bvec5 yxxxx => new bvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.grrrr swizzling (equivalent to bvec3.yxxxx).
        /// </summary>
        public bvec5 grrrr => new bvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.yxxxy swizzling.
        /// </summary>
        public bvec5 yxxxy => new bvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.grrrg swizzling (equivalent to bvec3.yxxxy).
        /// </summary>
        public bvec5 grrrg => new bvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.yxxxz swizzling.
        /// </summary>
        public bvec5 yxxxz => new bvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.grrrb swizzling (equivalent to bvec3.yxxxz).
        /// </summary>
        public bvec5 grrrb => new bvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.yxxy swizzling.
        /// </summary>
        public bvec4 yxxy => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.grrg swizzling (equivalent to bvec3.yxxy).
        /// </summary>
        public bvec4 grrg => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.yxxyx swizzling.
        /// </summary>
        public bvec5 yxxyx => new bvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.grrgr swizzling (equivalent to bvec3.yxxyx).
        /// </summary>
        public bvec5 grrgr => new bvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.yxxyy swizzling.
        /// </summary>
        public bvec5 yxxyy => new bvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.grrgg swizzling (equivalent to bvec3.yxxyy).
        /// </summary>
        public bvec5 grrgg => new bvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.yxxyz swizzling.
        /// </summary>
        public bvec5 yxxyz => new bvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.grrgb swizzling (equivalent to bvec3.yxxyz).
        /// </summary>
        public bvec5 grrgb => new bvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.yxxz swizzling.
        /// </summary>
        public bvec4 yxxz => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.grrb swizzling (equivalent to bvec3.yxxz).
        /// </summary>
        public bvec4 grrb => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.yxxzx swizzling.
        /// </summary>
        public bvec5 yxxzx => new bvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.grrbr swizzling (equivalent to bvec3.yxxzx).
        /// </summary>
        public bvec5 grrbr => new bvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.yxxzy swizzling.
        /// </summary>
        public bvec5 yxxzy => new bvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.grrbg swizzling (equivalent to bvec3.yxxzy).
        /// </summary>
        public bvec5 grrbg => new bvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.yxxzz swizzling.
        /// </summary>
        public bvec5 yxxzz => new bvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.grrbb swizzling (equivalent to bvec3.yxxzz).
        /// </summary>
        public bvec5 grrbb => new bvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.yxy swizzling.
        /// </summary>
        public bvec3 yxy => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec3.grg swizzling (equivalent to bvec3.yxy).
        /// </summary>
        public bvec3 grg => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec3.yxyx swizzling.
        /// </summary>
        public bvec4 yxyx => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.grgr swizzling (equivalent to bvec3.yxyx).
        /// </summary>
        public bvec4 grgr => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.yxyxx swizzling.
        /// </summary>
        public bvec5 yxyxx => new bvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.grgrr swizzling (equivalent to bvec3.yxyxx).
        /// </summary>
        public bvec5 grgrr => new bvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.yxyxy swizzling.
        /// </summary>
        public bvec5 yxyxy => new bvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.grgrg swizzling (equivalent to bvec3.yxyxy).
        /// </summary>
        public bvec5 grgrg => new bvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.yxyxz swizzling.
        /// </summary>
        public bvec5 yxyxz => new bvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.grgrb swizzling (equivalent to bvec3.yxyxz).
        /// </summary>
        public bvec5 grgrb => new bvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.yxyy swizzling.
        /// </summary>
        public bvec4 yxyy => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.grgg swizzling (equivalent to bvec3.yxyy).
        /// </summary>
        public bvec4 grgg => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.yxyyx swizzling.
        /// </summary>
        public bvec5 yxyyx => new bvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.grggr swizzling (equivalent to bvec3.yxyyx).
        /// </summary>
        public bvec5 grggr => new bvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.yxyyy swizzling.
        /// </summary>
        public bvec5 yxyyy => new bvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.grggg swizzling (equivalent to bvec3.yxyyy).
        /// </summary>
        public bvec5 grggg => new bvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.yxyyz swizzling.
        /// </summary>
        public bvec5 yxyyz => new bvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.grggb swizzling (equivalent to bvec3.yxyyz).
        /// </summary>
        public bvec5 grggb => new bvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.yxyz swizzling.
        /// </summary>
        public bvec4 yxyz => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.grgb swizzling (equivalent to bvec3.yxyz).
        /// </summary>
        public bvec4 grgb => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.yxyzx swizzling.
        /// </summary>
        public bvec5 yxyzx => new bvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.grgbr swizzling (equivalent to bvec3.yxyzx).
        /// </summary>
        public bvec5 grgbr => new bvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.yxyzy swizzling.
        /// </summary>
        public bvec5 yxyzy => new bvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.grgbg swizzling (equivalent to bvec3.yxyzy).
        /// </summary>
        public bvec5 grgbg => new bvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.yxyzz swizzling.
        /// </summary>
        public bvec5 yxyzz => new bvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.grgbb swizzling (equivalent to bvec3.yxyzz).
        /// </summary>
        public bvec5 grgbb => new bvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.yxz swizzling.
        /// </summary>
        public bvec3 yxz => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec3.grb swizzling (equivalent to bvec3.yxz).
        /// </summary>
        public bvec3 grb => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec3.yxzx swizzling.
        /// </summary>
        public bvec4 yxzx => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.grbr swizzling (equivalent to bvec3.yxzx).
        /// </summary>
        public bvec4 grbr => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.yxzxx swizzling.
        /// </summary>
        public bvec5 yxzxx => new bvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.grbrr swizzling (equivalent to bvec3.yxzxx).
        /// </summary>
        public bvec5 grbrr => new bvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.yxzxy swizzling.
        /// </summary>
        public bvec5 yxzxy => new bvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.grbrg swizzling (equivalent to bvec3.yxzxy).
        /// </summary>
        public bvec5 grbrg => new bvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.yxzxz swizzling.
        /// </summary>
        public bvec5 yxzxz => new bvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.grbrb swizzling (equivalent to bvec3.yxzxz).
        /// </summary>
        public bvec5 grbrb => new bvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.yxzy swizzling.
        /// </summary>
        public bvec4 yxzy => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.grbg swizzling (equivalent to bvec3.yxzy).
        /// </summary>
        public bvec4 grbg => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.yxzyx swizzling.
        /// </summary>
        public bvec5 yxzyx => new bvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.grbgr swizzling (equivalent to bvec3.yxzyx).
        /// </summary>
        public bvec5 grbgr => new bvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.yxzyy swizzling.
        /// </summary>
        public bvec5 yxzyy => new bvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.grbgg swizzling (equivalent to bvec3.yxzyy).
        /// </summary>
        public bvec5 grbgg => new bvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.yxzyz swizzling.
        /// </summary>
        public bvec5 yxzyz => new bvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.grbgb swizzling (equivalent to bvec3.yxzyz).
        /// </summary>
        public bvec5 grbgb => new bvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.yxzz swizzling.
        /// </summary>
        public bvec4 yxzz => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.grbb swizzling (equivalent to bvec3.yxzz).
        /// </summary>
        public bvec4 grbb => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.yxzzx swizzling.
        /// </summary>
        public bvec5 yxzzx => new bvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.grbbr swizzling (equivalent to bvec3.yxzzx).
        /// </summary>
        public bvec5 grbbr => new bvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.yxzzy swizzling.
        /// </summary>
        public bvec5 yxzzy => new bvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.grbbg swizzling (equivalent to bvec3.yxzzy).
        /// </summary>
        public bvec5 grbbg => new bvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.yxzzz swizzling.
        /// </summary>
        public bvec5 yxzzz => new bvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.grbbb swizzling (equivalent to bvec3.yxzzz).
        /// </summary>
        public bvec5 grbbb => new bvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.yy swizzling.
        /// </summary>
        public bvec2 yy => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec3.gg swizzling (equivalent to bvec3.yy).
        /// </summary>
        public bvec2 gg => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec3.yyx swizzling.
        /// </summary>
        public bvec3 yyx => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec3.ggr swizzling (equivalent to bvec3.yyx).
        /// </summary>
        public bvec3 ggr => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec3.yyxx swizzling.
        /// </summary>
        public bvec4 yyxx => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.ggrr swizzling (equivalent to bvec3.yyxx).
        /// </summary>
        public bvec4 ggrr => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.yyxxx swizzling.
        /// </summary>
        public bvec5 yyxxx => new bvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.ggrrr swizzling (equivalent to bvec3.yyxxx).
        /// </summary>
        public bvec5 ggrrr => new bvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.yyxxy swizzling.
        /// </summary>
        public bvec5 yyxxy => new bvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.ggrrg swizzling (equivalent to bvec3.yyxxy).
        /// </summary>
        public bvec5 ggrrg => new bvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.yyxxz swizzling.
        /// </summary>
        public bvec5 yyxxz => new bvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.ggrrb swizzling (equivalent to bvec3.yyxxz).
        /// </summary>
        public bvec5 ggrrb => new bvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.yyxy swizzling.
        /// </summary>
        public bvec4 yyxy => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.ggrg swizzling (equivalent to bvec3.yyxy).
        /// </summary>
        public bvec4 ggrg => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.yyxyx swizzling.
        /// </summary>
        public bvec5 yyxyx => new bvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.ggrgr swizzling (equivalent to bvec3.yyxyx).
        /// </summary>
        public bvec5 ggrgr => new bvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.yyxyy swizzling.
        /// </summary>
        public bvec5 yyxyy => new bvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.ggrgg swizzling (equivalent to bvec3.yyxyy).
        /// </summary>
        public bvec5 ggrgg => new bvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.yyxyz swizzling.
        /// </summary>
        public bvec5 yyxyz => new bvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.ggrgb swizzling (equivalent to bvec3.yyxyz).
        /// </summary>
        public bvec5 ggrgb => new bvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.yyxz swizzling.
        /// </summary>
        public bvec4 yyxz => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.ggrb swizzling (equivalent to bvec3.yyxz).
        /// </summary>
        public bvec4 ggrb => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.yyxzx swizzling.
        /// </summary>
        public bvec5 yyxzx => new bvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.ggrbr swizzling (equivalent to bvec3.yyxzx).
        /// </summary>
        public bvec5 ggrbr => new bvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.yyxzy swizzling.
        /// </summary>
        public bvec5 yyxzy => new bvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.ggrbg swizzling (equivalent to bvec3.yyxzy).
        /// </summary>
        public bvec5 ggrbg => new bvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.yyxzz swizzling.
        /// </summary>
        public bvec5 yyxzz => new bvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.ggrbb swizzling (equivalent to bvec3.yyxzz).
        /// </summary>
        public bvec5 ggrbb => new bvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.yyy swizzling.
        /// </summary>
        public bvec3 yyy => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec3.ggg swizzling (equivalent to bvec3.yyy).
        /// </summary>
        public bvec3 ggg => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec3.yyyx swizzling.
        /// </summary>
        public bvec4 yyyx => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.gggr swizzling (equivalent to bvec3.yyyx).
        /// </summary>
        public bvec4 gggr => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.yyyxx swizzling.
        /// </summary>
        public bvec5 yyyxx => new bvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.gggrr swizzling (equivalent to bvec3.yyyxx).
        /// </summary>
        public bvec5 gggrr => new bvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.yyyxy swizzling.
        /// </summary>
        public bvec5 yyyxy => new bvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.gggrg swizzling (equivalent to bvec3.yyyxy).
        /// </summary>
        public bvec5 gggrg => new bvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.yyyxz swizzling.
        /// </summary>
        public bvec5 yyyxz => new bvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.gggrb swizzling (equivalent to bvec3.yyyxz).
        /// </summary>
        public bvec5 gggrb => new bvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.yyyy swizzling.
        /// </summary>
        public bvec4 yyyy => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.gggg swizzling (equivalent to bvec3.yyyy).
        /// </summary>
        public bvec4 gggg => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.yyyyx swizzling.
        /// </summary>
        public bvec5 yyyyx => new bvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.ggggr swizzling (equivalent to bvec3.yyyyx).
        /// </summary>
        public bvec5 ggggr => new bvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.yyyyy swizzling.
        /// </summary>
        public bvec5 yyyyy => new bvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.ggggg swizzling (equivalent to bvec3.yyyyy).
        /// </summary>
        public bvec5 ggggg => new bvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.yyyyz swizzling.
        /// </summary>
        public bvec5 yyyyz => new bvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.ggggb swizzling (equivalent to bvec3.yyyyz).
        /// </summary>
        public bvec5 ggggb => new bvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.yyyz swizzling.
        /// </summary>
        public bvec4 yyyz => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.gggb swizzling (equivalent to bvec3.yyyz).
        /// </summary>
        public bvec4 gggb => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.yyyzx swizzling.
        /// </summary>
        public bvec5 yyyzx => new bvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.gggbr swizzling (equivalent to bvec3.yyyzx).
        /// </summary>
        public bvec5 gggbr => new bvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.yyyzy swizzling.
        /// </summary>
        public bvec5 yyyzy => new bvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.gggbg swizzling (equivalent to bvec3.yyyzy).
        /// </summary>
        public bvec5 gggbg => new bvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.yyyzz swizzling.
        /// </summary>
        public bvec5 yyyzz => new bvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.gggbb swizzling (equivalent to bvec3.yyyzz).
        /// </summary>
        public bvec5 gggbb => new bvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.yyz swizzling.
        /// </summary>
        public bvec3 yyz => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec3.ggb swizzling (equivalent to bvec3.yyz).
        /// </summary>
        public bvec3 ggb => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec3.yyzx swizzling.
        /// </summary>
        public bvec4 yyzx => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.ggbr swizzling (equivalent to bvec3.yyzx).
        /// </summary>
        public bvec4 ggbr => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.yyzxx swizzling.
        /// </summary>
        public bvec5 yyzxx => new bvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.ggbrr swizzling (equivalent to bvec3.yyzxx).
        /// </summary>
        public bvec5 ggbrr => new bvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.yyzxy swizzling.
        /// </summary>
        public bvec5 yyzxy => new bvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.ggbrg swizzling (equivalent to bvec3.yyzxy).
        /// </summary>
        public bvec5 ggbrg => new bvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.yyzxz swizzling.
        /// </summary>
        public bvec5 yyzxz => new bvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.ggbrb swizzling (equivalent to bvec3.yyzxz).
        /// </summary>
        public bvec5 ggbrb => new bvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.yyzy swizzling.
        /// </summary>
        public bvec4 yyzy => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.ggbg swizzling (equivalent to bvec3.yyzy).
        /// </summary>
        public bvec4 ggbg => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.yyzyx swizzling.
        /// </summary>
        public bvec5 yyzyx => new bvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.ggbgr swizzling (equivalent to bvec3.yyzyx).
        /// </summary>
        public bvec5 ggbgr => new bvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.yyzyy swizzling.
        /// </summary>
        public bvec5 yyzyy => new bvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.ggbgg swizzling (equivalent to bvec3.yyzyy).
        /// </summary>
        public bvec5 ggbgg => new bvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.yyzyz swizzling.
        /// </summary>
        public bvec5 yyzyz => new bvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.ggbgb swizzling (equivalent to bvec3.yyzyz).
        /// </summary>
        public bvec5 ggbgb => new bvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.yyzz swizzling.
        /// </summary>
        public bvec4 yyzz => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.ggbb swizzling (equivalent to bvec3.yyzz).
        /// </summary>
        public bvec4 ggbb => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.yyzzx swizzling.
        /// </summary>
        public bvec5 yyzzx => new bvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.ggbbr swizzling (equivalent to bvec3.yyzzx).
        /// </summary>
        public bvec5 ggbbr => new bvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.yyzzy swizzling.
        /// </summary>
        public bvec5 yyzzy => new bvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.ggbbg swizzling (equivalent to bvec3.yyzzy).
        /// </summary>
        public bvec5 ggbbg => new bvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.yyzzz swizzling.
        /// </summary>
        public bvec5 yyzzz => new bvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.ggbbb swizzling (equivalent to bvec3.yyzzz).
        /// </summary>
        public bvec5 ggbbb => new bvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.yz swizzling.
        /// </summary>
        public bvec2 yz => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec3.gb swizzling (equivalent to bvec3.yz).
        /// </summary>
        public bvec2 gb => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec3.yzx swizzling.
        /// </summary>
        public bvec3 yzx => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec3.gbr swizzling (equivalent to bvec3.yzx).
        /// </summary>
        public bvec3 gbr => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec3.yzxx swizzling.
        /// </summary>
        public bvec4 yzxx => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.gbrr swizzling (equivalent to bvec3.yzxx).
        /// </summary>
        public bvec4 gbrr => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.yzxxx swizzling.
        /// </summary>
        public bvec5 yzxxx => new bvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.gbrrr swizzling (equivalent to bvec3.yzxxx).
        /// </summary>
        public bvec5 gbrrr => new bvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.yzxxy swizzling.
        /// </summary>
        public bvec5 yzxxy => new bvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.gbrrg swizzling (equivalent to bvec3.yzxxy).
        /// </summary>
        public bvec5 gbrrg => new bvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.yzxxz swizzling.
        /// </summary>
        public bvec5 yzxxz => new bvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.gbrrb swizzling (equivalent to bvec3.yzxxz).
        /// </summary>
        public bvec5 gbrrb => new bvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.yzxy swizzling.
        /// </summary>
        public bvec4 yzxy => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.gbrg swizzling (equivalent to bvec3.yzxy).
        /// </summary>
        public bvec4 gbrg => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.yzxyx swizzling.
        /// </summary>
        public bvec5 yzxyx => new bvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.gbrgr swizzling (equivalent to bvec3.yzxyx).
        /// </summary>
        public bvec5 gbrgr => new bvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.yzxyy swizzling.
        /// </summary>
        public bvec5 yzxyy => new bvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.gbrgg swizzling (equivalent to bvec3.yzxyy).
        /// </summary>
        public bvec5 gbrgg => new bvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.yzxyz swizzling.
        /// </summary>
        public bvec5 yzxyz => new bvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.gbrgb swizzling (equivalent to bvec3.yzxyz).
        /// </summary>
        public bvec5 gbrgb => new bvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.yzxz swizzling.
        /// </summary>
        public bvec4 yzxz => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.gbrb swizzling (equivalent to bvec3.yzxz).
        /// </summary>
        public bvec4 gbrb => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.yzxzx swizzling.
        /// </summary>
        public bvec5 yzxzx => new bvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.gbrbr swizzling (equivalent to bvec3.yzxzx).
        /// </summary>
        public bvec5 gbrbr => new bvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.yzxzy swizzling.
        /// </summary>
        public bvec5 yzxzy => new bvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.gbrbg swizzling (equivalent to bvec3.yzxzy).
        /// </summary>
        public bvec5 gbrbg => new bvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.yzxzz swizzling.
        /// </summary>
        public bvec5 yzxzz => new bvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.gbrbb swizzling (equivalent to bvec3.yzxzz).
        /// </summary>
        public bvec5 gbrbb => new bvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.yzy swizzling.
        /// </summary>
        public bvec3 yzy => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec3.gbg swizzling (equivalent to bvec3.yzy).
        /// </summary>
        public bvec3 gbg => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec3.yzyx swizzling.
        /// </summary>
        public bvec4 yzyx => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.gbgr swizzling (equivalent to bvec3.yzyx).
        /// </summary>
        public bvec4 gbgr => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.yzyxx swizzling.
        /// </summary>
        public bvec5 yzyxx => new bvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.gbgrr swizzling (equivalent to bvec3.yzyxx).
        /// </summary>
        public bvec5 gbgrr => new bvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.yzyxy swizzling.
        /// </summary>
        public bvec5 yzyxy => new bvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.gbgrg swizzling (equivalent to bvec3.yzyxy).
        /// </summary>
        public bvec5 gbgrg => new bvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.yzyxz swizzling.
        /// </summary>
        public bvec5 yzyxz => new bvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.gbgrb swizzling (equivalent to bvec3.yzyxz).
        /// </summary>
        public bvec5 gbgrb => new bvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.yzyy swizzling.
        /// </summary>
        public bvec4 yzyy => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.gbgg swizzling (equivalent to bvec3.yzyy).
        /// </summary>
        public bvec4 gbgg => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.yzyyx swizzling.
        /// </summary>
        public bvec5 yzyyx => new bvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.gbggr swizzling (equivalent to bvec3.yzyyx).
        /// </summary>
        public bvec5 gbggr => new bvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.yzyyy swizzling.
        /// </summary>
        public bvec5 yzyyy => new bvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.gbggg swizzling (equivalent to bvec3.yzyyy).
        /// </summary>
        public bvec5 gbggg => new bvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.yzyyz swizzling.
        /// </summary>
        public bvec5 yzyyz => new bvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.gbggb swizzling (equivalent to bvec3.yzyyz).
        /// </summary>
        public bvec5 gbggb => new bvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.yzyz swizzling.
        /// </summary>
        public bvec4 yzyz => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.gbgb swizzling (equivalent to bvec3.yzyz).
        /// </summary>
        public bvec4 gbgb => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.yzyzx swizzling.
        /// </summary>
        public bvec5 yzyzx => new bvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.gbgbr swizzling (equivalent to bvec3.yzyzx).
        /// </summary>
        public bvec5 gbgbr => new bvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.yzyzy swizzling.
        /// </summary>
        public bvec5 yzyzy => new bvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.gbgbg swizzling (equivalent to bvec3.yzyzy).
        /// </summary>
        public bvec5 gbgbg => new bvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.yzyzz swizzling.
        /// </summary>
        public bvec5 yzyzz => new bvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.gbgbb swizzling (equivalent to bvec3.yzyzz).
        /// </summary>
        public bvec5 gbgbb => new bvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.yzz swizzling.
        /// </summary>
        public bvec3 yzz => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec3.gbb swizzling (equivalent to bvec3.yzz).
        /// </summary>
        public bvec3 gbb => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec3.yzzx swizzling.
        /// </summary>
        public bvec4 yzzx => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.gbbr swizzling (equivalent to bvec3.yzzx).
        /// </summary>
        public bvec4 gbbr => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.yzzxx swizzling.
        /// </summary>
        public bvec5 yzzxx => new bvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.gbbrr swizzling (equivalent to bvec3.yzzxx).
        /// </summary>
        public bvec5 gbbrr => new bvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.yzzxy swizzling.
        /// </summary>
        public bvec5 yzzxy => new bvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.gbbrg swizzling (equivalent to bvec3.yzzxy).
        /// </summary>
        public bvec5 gbbrg => new bvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.yzzxz swizzling.
        /// </summary>
        public bvec5 yzzxz => new bvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.gbbrb swizzling (equivalent to bvec3.yzzxz).
        /// </summary>
        public bvec5 gbbrb => new bvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.yzzy swizzling.
        /// </summary>
        public bvec4 yzzy => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.gbbg swizzling (equivalent to bvec3.yzzy).
        /// </summary>
        public bvec4 gbbg => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.yzzyx swizzling.
        /// </summary>
        public bvec5 yzzyx => new bvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.gbbgr swizzling (equivalent to bvec3.yzzyx).
        /// </summary>
        public bvec5 gbbgr => new bvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.yzzyy swizzling.
        /// </summary>
        public bvec5 yzzyy => new bvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.gbbgg swizzling (equivalent to bvec3.yzzyy).
        /// </summary>
        public bvec5 gbbgg => new bvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.yzzyz swizzling.
        /// </summary>
        public bvec5 yzzyz => new bvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.gbbgb swizzling (equivalent to bvec3.yzzyz).
        /// </summary>
        public bvec5 gbbgb => new bvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.yzzz swizzling.
        /// </summary>
        public bvec4 yzzz => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.gbbb swizzling (equivalent to bvec3.yzzz).
        /// </summary>
        public bvec4 gbbb => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.yzzzx swizzling.
        /// </summary>
        public bvec5 yzzzx => new bvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.gbbbr swizzling (equivalent to bvec3.yzzzx).
        /// </summary>
        public bvec5 gbbbr => new bvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.yzzzy swizzling.
        /// </summary>
        public bvec5 yzzzy => new bvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.gbbbg swizzling (equivalent to bvec3.yzzzy).
        /// </summary>
        public bvec5 gbbbg => new bvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.yzzzz swizzling.
        /// </summary>
        public bvec5 yzzzz => new bvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns bvec3.gbbbb swizzling (equivalent to bvec3.yzzzz).
        /// </summary>
        public bvec5 gbbbb => new bvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns bvec3.zx swizzling.
        /// </summary>
        public bvec2 zx => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec3.br swizzling (equivalent to bvec3.zx).
        /// </summary>
        public bvec2 br => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec3.zxx swizzling.
        /// </summary>
        public bvec3 zxx => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec3.brr swizzling (equivalent to bvec3.zxx).
        /// </summary>
        public bvec3 brr => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec3.zxxx swizzling.
        /// </summary>
        public bvec4 zxxx => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.brrr swizzling (equivalent to bvec3.zxxx).
        /// </summary>
        public bvec4 brrr => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.zxxxx swizzling.
        /// </summary>
        public bvec5 zxxxx => new bvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.brrrr swizzling (equivalent to bvec3.zxxxx).
        /// </summary>
        public bvec5 brrrr => new bvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.zxxxy swizzling.
        /// </summary>
        public bvec5 zxxxy => new bvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.brrrg swizzling (equivalent to bvec3.zxxxy).
        /// </summary>
        public bvec5 brrrg => new bvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.zxxxz swizzling.
        /// </summary>
        public bvec5 zxxxz => new bvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.brrrb swizzling (equivalent to bvec3.zxxxz).
        /// </summary>
        public bvec5 brrrb => new bvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.zxxy swizzling.
        /// </summary>
        public bvec4 zxxy => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.brrg swizzling (equivalent to bvec3.zxxy).
        /// </summary>
        public bvec4 brrg => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.zxxyx swizzling.
        /// </summary>
        public bvec5 zxxyx => new bvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.brrgr swizzling (equivalent to bvec3.zxxyx).
        /// </summary>
        public bvec5 brrgr => new bvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.zxxyy swizzling.
        /// </summary>
        public bvec5 zxxyy => new bvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.brrgg swizzling (equivalent to bvec3.zxxyy).
        /// </summary>
        public bvec5 brrgg => new bvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.zxxyz swizzling.
        /// </summary>
        public bvec5 zxxyz => new bvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.brrgb swizzling (equivalent to bvec3.zxxyz).
        /// </summary>
        public bvec5 brrgb => new bvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.zxxz swizzling.
        /// </summary>
        public bvec4 zxxz => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.brrb swizzling (equivalent to bvec3.zxxz).
        /// </summary>
        public bvec4 brrb => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.zxxzx swizzling.
        /// </summary>
        public bvec5 zxxzx => new bvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.brrbr swizzling (equivalent to bvec3.zxxzx).
        /// </summary>
        public bvec5 brrbr => new bvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.zxxzy swizzling.
        /// </summary>
        public bvec5 zxxzy => new bvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.brrbg swizzling (equivalent to bvec3.zxxzy).
        /// </summary>
        public bvec5 brrbg => new bvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.zxxzz swizzling.
        /// </summary>
        public bvec5 zxxzz => new bvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.brrbb swizzling (equivalent to bvec3.zxxzz).
        /// </summary>
        public bvec5 brrbb => new bvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.zxy swizzling.
        /// </summary>
        public bvec3 zxy => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec3.brg swizzling (equivalent to bvec3.zxy).
        /// </summary>
        public bvec3 brg => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec3.zxyx swizzling.
        /// </summary>
        public bvec4 zxyx => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.brgr swizzling (equivalent to bvec3.zxyx).
        /// </summary>
        public bvec4 brgr => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.zxyxx swizzling.
        /// </summary>
        public bvec5 zxyxx => new bvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.brgrr swizzling (equivalent to bvec3.zxyxx).
        /// </summary>
        public bvec5 brgrr => new bvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.zxyxy swizzling.
        /// </summary>
        public bvec5 zxyxy => new bvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.brgrg swizzling (equivalent to bvec3.zxyxy).
        /// </summary>
        public bvec5 brgrg => new bvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.zxyxz swizzling.
        /// </summary>
        public bvec5 zxyxz => new bvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.brgrb swizzling (equivalent to bvec3.zxyxz).
        /// </summary>
        public bvec5 brgrb => new bvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.zxyy swizzling.
        /// </summary>
        public bvec4 zxyy => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.brgg swizzling (equivalent to bvec3.zxyy).
        /// </summary>
        public bvec4 brgg => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.zxyyx swizzling.
        /// </summary>
        public bvec5 zxyyx => new bvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.brggr swizzling (equivalent to bvec3.zxyyx).
        /// </summary>
        public bvec5 brggr => new bvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.zxyyy swizzling.
        /// </summary>
        public bvec5 zxyyy => new bvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.brggg swizzling (equivalent to bvec3.zxyyy).
        /// </summary>
        public bvec5 brggg => new bvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.zxyyz swizzling.
        /// </summary>
        public bvec5 zxyyz => new bvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.brggb swizzling (equivalent to bvec3.zxyyz).
        /// </summary>
        public bvec5 brggb => new bvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.zxyz swizzling.
        /// </summary>
        public bvec4 zxyz => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.brgb swizzling (equivalent to bvec3.zxyz).
        /// </summary>
        public bvec4 brgb => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.zxyzx swizzling.
        /// </summary>
        public bvec5 zxyzx => new bvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.brgbr swizzling (equivalent to bvec3.zxyzx).
        /// </summary>
        public bvec5 brgbr => new bvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.zxyzy swizzling.
        /// </summary>
        public bvec5 zxyzy => new bvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.brgbg swizzling (equivalent to bvec3.zxyzy).
        /// </summary>
        public bvec5 brgbg => new bvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.zxyzz swizzling.
        /// </summary>
        public bvec5 zxyzz => new bvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.brgbb swizzling (equivalent to bvec3.zxyzz).
        /// </summary>
        public bvec5 brgbb => new bvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.zxz swizzling.
        /// </summary>
        public bvec3 zxz => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec3.brb swizzling (equivalent to bvec3.zxz).
        /// </summary>
        public bvec3 brb => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec3.zxzx swizzling.
        /// </summary>
        public bvec4 zxzx => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.brbr swizzling (equivalent to bvec3.zxzx).
        /// </summary>
        public bvec4 brbr => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.zxzxx swizzling.
        /// </summary>
        public bvec5 zxzxx => new bvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.brbrr swizzling (equivalent to bvec3.zxzxx).
        /// </summary>
        public bvec5 brbrr => new bvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.zxzxy swizzling.
        /// </summary>
        public bvec5 zxzxy => new bvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.brbrg swizzling (equivalent to bvec3.zxzxy).
        /// </summary>
        public bvec5 brbrg => new bvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.zxzxz swizzling.
        /// </summary>
        public bvec5 zxzxz => new bvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.brbrb swizzling (equivalent to bvec3.zxzxz).
        /// </summary>
        public bvec5 brbrb => new bvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.zxzy swizzling.
        /// </summary>
        public bvec4 zxzy => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.brbg swizzling (equivalent to bvec3.zxzy).
        /// </summary>
        public bvec4 brbg => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.zxzyx swizzling.
        /// </summary>
        public bvec5 zxzyx => new bvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.brbgr swizzling (equivalent to bvec3.zxzyx).
        /// </summary>
        public bvec5 brbgr => new bvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.zxzyy swizzling.
        /// </summary>
        public bvec5 zxzyy => new bvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.brbgg swizzling (equivalent to bvec3.zxzyy).
        /// </summary>
        public bvec5 brbgg => new bvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.zxzyz swizzling.
        /// </summary>
        public bvec5 zxzyz => new bvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.brbgb swizzling (equivalent to bvec3.zxzyz).
        /// </summary>
        public bvec5 brbgb => new bvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.zxzz swizzling.
        /// </summary>
        public bvec4 zxzz => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.brbb swizzling (equivalent to bvec3.zxzz).
        /// </summary>
        public bvec4 brbb => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.zxzzx swizzling.
        /// </summary>
        public bvec5 zxzzx => new bvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.brbbr swizzling (equivalent to bvec3.zxzzx).
        /// </summary>
        public bvec5 brbbr => new bvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.zxzzy swizzling.
        /// </summary>
        public bvec5 zxzzy => new bvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.brbbg swizzling (equivalent to bvec3.zxzzy).
        /// </summary>
        public bvec5 brbbg => new bvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.zxzzz swizzling.
        /// </summary>
        public bvec5 zxzzz => new bvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.brbbb swizzling (equivalent to bvec3.zxzzz).
        /// </summary>
        public bvec5 brbbb => new bvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.zy swizzling.
        /// </summary>
        public bvec2 zy => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec3.bg swizzling (equivalent to bvec3.zy).
        /// </summary>
        public bvec2 bg => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec3.zyx swizzling.
        /// </summary>
        public bvec3 zyx => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec3.bgr swizzling (equivalent to bvec3.zyx).
        /// </summary>
        public bvec3 bgr => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec3.zyxx swizzling.
        /// </summary>
        public bvec4 zyxx => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.bgrr swizzling (equivalent to bvec3.zyxx).
        /// </summary>
        public bvec4 bgrr => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.zyxxx swizzling.
        /// </summary>
        public bvec5 zyxxx => new bvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.bgrrr swizzling (equivalent to bvec3.zyxxx).
        /// </summary>
        public bvec5 bgrrr => new bvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.zyxxy swizzling.
        /// </summary>
        public bvec5 zyxxy => new bvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.bgrrg swizzling (equivalent to bvec3.zyxxy).
        /// </summary>
        public bvec5 bgrrg => new bvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.zyxxz swizzling.
        /// </summary>
        public bvec5 zyxxz => new bvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.bgrrb swizzling (equivalent to bvec3.zyxxz).
        /// </summary>
        public bvec5 bgrrb => new bvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.zyxy swizzling.
        /// </summary>
        public bvec4 zyxy => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.bgrg swizzling (equivalent to bvec3.zyxy).
        /// </summary>
        public bvec4 bgrg => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.zyxyx swizzling.
        /// </summary>
        public bvec5 zyxyx => new bvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.bgrgr swizzling (equivalent to bvec3.zyxyx).
        /// </summary>
        public bvec5 bgrgr => new bvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.zyxyy swizzling.
        /// </summary>
        public bvec5 zyxyy => new bvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.bgrgg swizzling (equivalent to bvec3.zyxyy).
        /// </summary>
        public bvec5 bgrgg => new bvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.zyxyz swizzling.
        /// </summary>
        public bvec5 zyxyz => new bvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.bgrgb swizzling (equivalent to bvec3.zyxyz).
        /// </summary>
        public bvec5 bgrgb => new bvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.zyxz swizzling.
        /// </summary>
        public bvec4 zyxz => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.bgrb swizzling (equivalent to bvec3.zyxz).
        /// </summary>
        public bvec4 bgrb => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.zyxzx swizzling.
        /// </summary>
        public bvec5 zyxzx => new bvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.bgrbr swizzling (equivalent to bvec3.zyxzx).
        /// </summary>
        public bvec5 bgrbr => new bvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.zyxzy swizzling.
        /// </summary>
        public bvec5 zyxzy => new bvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.bgrbg swizzling (equivalent to bvec3.zyxzy).
        /// </summary>
        public bvec5 bgrbg => new bvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.zyxzz swizzling.
        /// </summary>
        public bvec5 zyxzz => new bvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.bgrbb swizzling (equivalent to bvec3.zyxzz).
        /// </summary>
        public bvec5 bgrbb => new bvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.zyy swizzling.
        /// </summary>
        public bvec3 zyy => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec3.bgg swizzling (equivalent to bvec3.zyy).
        /// </summary>
        public bvec3 bgg => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec3.zyyx swizzling.
        /// </summary>
        public bvec4 zyyx => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.bggr swizzling (equivalent to bvec3.zyyx).
        /// </summary>
        public bvec4 bggr => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.zyyxx swizzling.
        /// </summary>
        public bvec5 zyyxx => new bvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.bggrr swizzling (equivalent to bvec3.zyyxx).
        /// </summary>
        public bvec5 bggrr => new bvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.zyyxy swizzling.
        /// </summary>
        public bvec5 zyyxy => new bvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.bggrg swizzling (equivalent to bvec3.zyyxy).
        /// </summary>
        public bvec5 bggrg => new bvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.zyyxz swizzling.
        /// </summary>
        public bvec5 zyyxz => new bvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.bggrb swizzling (equivalent to bvec3.zyyxz).
        /// </summary>
        public bvec5 bggrb => new bvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.zyyy swizzling.
        /// </summary>
        public bvec4 zyyy => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.bggg swizzling (equivalent to bvec3.zyyy).
        /// </summary>
        public bvec4 bggg => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.zyyyx swizzling.
        /// </summary>
        public bvec5 zyyyx => new bvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.bgggr swizzling (equivalent to bvec3.zyyyx).
        /// </summary>
        public bvec5 bgggr => new bvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.zyyyy swizzling.
        /// </summary>
        public bvec5 zyyyy => new bvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.bgggg swizzling (equivalent to bvec3.zyyyy).
        /// </summary>
        public bvec5 bgggg => new bvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.zyyyz swizzling.
        /// </summary>
        public bvec5 zyyyz => new bvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.bgggb swizzling (equivalent to bvec3.zyyyz).
        /// </summary>
        public bvec5 bgggb => new bvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.zyyz swizzling.
        /// </summary>
        public bvec4 zyyz => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.bggb swizzling (equivalent to bvec3.zyyz).
        /// </summary>
        public bvec4 bggb => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.zyyzx swizzling.
        /// </summary>
        public bvec5 zyyzx => new bvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.bggbr swizzling (equivalent to bvec3.zyyzx).
        /// </summary>
        public bvec5 bggbr => new bvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.zyyzy swizzling.
        /// </summary>
        public bvec5 zyyzy => new bvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.bggbg swizzling (equivalent to bvec3.zyyzy).
        /// </summary>
        public bvec5 bggbg => new bvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.zyyzz swizzling.
        /// </summary>
        public bvec5 zyyzz => new bvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.bggbb swizzling (equivalent to bvec3.zyyzz).
        /// </summary>
        public bvec5 bggbb => new bvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.zyz swizzling.
        /// </summary>
        public bvec3 zyz => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec3.bgb swizzling (equivalent to bvec3.zyz).
        /// </summary>
        public bvec3 bgb => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec3.zyzx swizzling.
        /// </summary>
        public bvec4 zyzx => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.bgbr swizzling (equivalent to bvec3.zyzx).
        /// </summary>
        public bvec4 bgbr => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.zyzxx swizzling.
        /// </summary>
        public bvec5 zyzxx => new bvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.bgbrr swizzling (equivalent to bvec3.zyzxx).
        /// </summary>
        public bvec5 bgbrr => new bvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.zyzxy swizzling.
        /// </summary>
        public bvec5 zyzxy => new bvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.bgbrg swizzling (equivalent to bvec3.zyzxy).
        /// </summary>
        public bvec5 bgbrg => new bvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.zyzxz swizzling.
        /// </summary>
        public bvec5 zyzxz => new bvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.bgbrb swizzling (equivalent to bvec3.zyzxz).
        /// </summary>
        public bvec5 bgbrb => new bvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.zyzy swizzling.
        /// </summary>
        public bvec4 zyzy => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.bgbg swizzling (equivalent to bvec3.zyzy).
        /// </summary>
        public bvec4 bgbg => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.zyzyx swizzling.
        /// </summary>
        public bvec5 zyzyx => new bvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.bgbgr swizzling (equivalent to bvec3.zyzyx).
        /// </summary>
        public bvec5 bgbgr => new bvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.zyzyy swizzling.
        /// </summary>
        public bvec5 zyzyy => new bvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.bgbgg swizzling (equivalent to bvec3.zyzyy).
        /// </summary>
        public bvec5 bgbgg => new bvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.zyzyz swizzling.
        /// </summary>
        public bvec5 zyzyz => new bvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.bgbgb swizzling (equivalent to bvec3.zyzyz).
        /// </summary>
        public bvec5 bgbgb => new bvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.zyzz swizzling.
        /// </summary>
        public bvec4 zyzz => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.bgbb swizzling (equivalent to bvec3.zyzz).
        /// </summary>
        public bvec4 bgbb => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.zyzzx swizzling.
        /// </summary>
        public bvec5 zyzzx => new bvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.bgbbr swizzling (equivalent to bvec3.zyzzx).
        /// </summary>
        public bvec5 bgbbr => new bvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.zyzzy swizzling.
        /// </summary>
        public bvec5 zyzzy => new bvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.bgbbg swizzling (equivalent to bvec3.zyzzy).
        /// </summary>
        public bvec5 bgbbg => new bvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.zyzzz swizzling.
        /// </summary>
        public bvec5 zyzzz => new bvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.bgbbb swizzling (equivalent to bvec3.zyzzz).
        /// </summary>
        public bvec5 bgbbb => new bvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.zz swizzling.
        /// </summary>
        public bvec2 zz => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec3.bb swizzling (equivalent to bvec3.zz).
        /// </summary>
        public bvec2 bb => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec3.zzx swizzling.
        /// </summary>
        public bvec3 zzx => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec3.bbr swizzling (equivalent to bvec3.zzx).
        /// </summary>
        public bvec3 bbr => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec3.zzxx swizzling.
        /// </summary>
        public bvec4 zzxx => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.bbrr swizzling (equivalent to bvec3.zzxx).
        /// </summary>
        public bvec4 bbrr => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.zzxxx swizzling.
        /// </summary>
        public bvec5 zzxxx => new bvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.bbrrr swizzling (equivalent to bvec3.zzxxx).
        /// </summary>
        public bvec5 bbrrr => new bvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.zzxxy swizzling.
        /// </summary>
        public bvec5 zzxxy => new bvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.bbrrg swizzling (equivalent to bvec3.zzxxy).
        /// </summary>
        public bvec5 bbrrg => new bvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.zzxxz swizzling.
        /// </summary>
        public bvec5 zzxxz => new bvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.bbrrb swizzling (equivalent to bvec3.zzxxz).
        /// </summary>
        public bvec5 bbrrb => new bvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.zzxy swizzling.
        /// </summary>
        public bvec4 zzxy => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.bbrg swizzling (equivalent to bvec3.zzxy).
        /// </summary>
        public bvec4 bbrg => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.zzxyx swizzling.
        /// </summary>
        public bvec5 zzxyx => new bvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.bbrgr swizzling (equivalent to bvec3.zzxyx).
        /// </summary>
        public bvec5 bbrgr => new bvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.zzxyy swizzling.
        /// </summary>
        public bvec5 zzxyy => new bvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.bbrgg swizzling (equivalent to bvec3.zzxyy).
        /// </summary>
        public bvec5 bbrgg => new bvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.zzxyz swizzling.
        /// </summary>
        public bvec5 zzxyz => new bvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.bbrgb swizzling (equivalent to bvec3.zzxyz).
        /// </summary>
        public bvec5 bbrgb => new bvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.zzxz swizzling.
        /// </summary>
        public bvec4 zzxz => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.bbrb swizzling (equivalent to bvec3.zzxz).
        /// </summary>
        public bvec4 bbrb => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.zzxzx swizzling.
        /// </summary>
        public bvec5 zzxzx => new bvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.bbrbr swizzling (equivalent to bvec3.zzxzx).
        /// </summary>
        public bvec5 bbrbr => new bvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.zzxzy swizzling.
        /// </summary>
        public bvec5 zzxzy => new bvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.bbrbg swizzling (equivalent to bvec3.zzxzy).
        /// </summary>
        public bvec5 bbrbg => new bvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.zzxzz swizzling.
        /// </summary>
        public bvec5 zzxzz => new bvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.bbrbb swizzling (equivalent to bvec3.zzxzz).
        /// </summary>
        public bvec5 bbrbb => new bvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.zzy swizzling.
        /// </summary>
        public bvec3 zzy => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec3.bbg swizzling (equivalent to bvec3.zzy).
        /// </summary>
        public bvec3 bbg => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec3.zzyx swizzling.
        /// </summary>
        public bvec4 zzyx => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.bbgr swizzling (equivalent to bvec3.zzyx).
        /// </summary>
        public bvec4 bbgr => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.zzyxx swizzling.
        /// </summary>
        public bvec5 zzyxx => new bvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.bbgrr swizzling (equivalent to bvec3.zzyxx).
        /// </summary>
        public bvec5 bbgrr => new bvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.zzyxy swizzling.
        /// </summary>
        public bvec5 zzyxy => new bvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.bbgrg swizzling (equivalent to bvec3.zzyxy).
        /// </summary>
        public bvec5 bbgrg => new bvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.zzyxz swizzling.
        /// </summary>
        public bvec5 zzyxz => new bvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.bbgrb swizzling (equivalent to bvec3.zzyxz).
        /// </summary>
        public bvec5 bbgrb => new bvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.zzyy swizzling.
        /// </summary>
        public bvec4 zzyy => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.bbgg swizzling (equivalent to bvec3.zzyy).
        /// </summary>
        public bvec4 bbgg => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.zzyyx swizzling.
        /// </summary>
        public bvec5 zzyyx => new bvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.bbggr swizzling (equivalent to bvec3.zzyyx).
        /// </summary>
        public bvec5 bbggr => new bvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.zzyyy swizzling.
        /// </summary>
        public bvec5 zzyyy => new bvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.bbggg swizzling (equivalent to bvec3.zzyyy).
        /// </summary>
        public bvec5 bbggg => new bvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.zzyyz swizzling.
        /// </summary>
        public bvec5 zzyyz => new bvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.bbggb swizzling (equivalent to bvec3.zzyyz).
        /// </summary>
        public bvec5 bbggb => new bvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.zzyz swizzling.
        /// </summary>
        public bvec4 zzyz => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.bbgb swizzling (equivalent to bvec3.zzyz).
        /// </summary>
        public bvec4 bbgb => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.zzyzx swizzling.
        /// </summary>
        public bvec5 zzyzx => new bvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.bbgbr swizzling (equivalent to bvec3.zzyzx).
        /// </summary>
        public bvec5 bbgbr => new bvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.zzyzy swizzling.
        /// </summary>
        public bvec5 zzyzy => new bvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.bbgbg swizzling (equivalent to bvec3.zzyzy).
        /// </summary>
        public bvec5 bbgbg => new bvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.zzyzz swizzling.
        /// </summary>
        public bvec5 zzyzz => new bvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.bbgbb swizzling (equivalent to bvec3.zzyzz).
        /// </summary>
        public bvec5 bbgbb => new bvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.zzz swizzling.
        /// </summary>
        public bvec3 zzz => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec3.bbb swizzling (equivalent to bvec3.zzz).
        /// </summary>
        public bvec3 bbb => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec3.zzzx swizzling.
        /// </summary>
        public bvec4 zzzx => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.bbbr swizzling (equivalent to bvec3.zzzx).
        /// </summary>
        public bvec4 bbbr => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.zzzxx swizzling.
        /// </summary>
        public bvec5 zzzxx => new bvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.bbbrr swizzling (equivalent to bvec3.zzzxx).
        /// </summary>
        public bvec5 bbbrr => new bvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.zzzxy swizzling.
        /// </summary>
        public bvec5 zzzxy => new bvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.bbbrg swizzling (equivalent to bvec3.zzzxy).
        /// </summary>
        public bvec5 bbbrg => new bvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.zzzxz swizzling.
        /// </summary>
        public bvec5 zzzxz => new bvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.bbbrb swizzling (equivalent to bvec3.zzzxz).
        /// </summary>
        public bvec5 bbbrb => new bvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.zzzy swizzling.
        /// </summary>
        public bvec4 zzzy => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.bbbg swizzling (equivalent to bvec3.zzzy).
        /// </summary>
        public bvec4 bbbg => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.zzzyx swizzling.
        /// </summary>
        public bvec5 zzzyx => new bvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.bbbgr swizzling (equivalent to bvec3.zzzyx).
        /// </summary>
        public bvec5 bbbgr => new bvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.zzzyy swizzling.
        /// </summary>
        public bvec5 zzzyy => new bvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.bbbgg swizzling (equivalent to bvec3.zzzyy).
        /// </summary>
        public bvec5 bbbgg => new bvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.zzzyz swizzling.
        /// </summary>
        public bvec5 zzzyz => new bvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.bbbgb swizzling (equivalent to bvec3.zzzyz).
        /// </summary>
        public bvec5 bbbgb => new bvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.zzzz swizzling.
        /// </summary>
        public bvec4 zzzz => new bvec4(z, z, z, z);
        
        /// <summary>
        /// Returns bvec3.bbbb swizzling (equivalent to bvec3.zzzz).
        /// </summary>
        public bvec4 bbbb => new bvec4(z, z, z, z);
        
        /// <summary>
        /// Returns bvec3.zzzzx swizzling.
        /// </summary>
        public bvec5 zzzzx => new bvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.bbbbr swizzling (equivalent to bvec3.zzzzx).
        /// </summary>
        public bvec5 bbbbr => new bvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.zzzzy swizzling.
        /// </summary>
        public bvec5 zzzzy => new bvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.bbbbg swizzling (equivalent to bvec3.zzzzy).
        /// </summary>
        public bvec5 bbbbg => new bvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.zzzzz swizzling.
        /// </summary>
        public bvec5 zzzzz => new bvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns bvec3.bbbbb swizzling (equivalent to bvec3.zzzzz).
        /// </summary>
        public bvec5 bbbbb => new bvec5(z, z, z, z, z);

        #endregion

    }
}
