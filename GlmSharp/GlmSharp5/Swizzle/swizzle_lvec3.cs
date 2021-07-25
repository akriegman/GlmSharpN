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
    /// Temporary vector of type long with 3 components, used for implementing swizzling for lvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_lvec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly long x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly long y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly long z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_lvec3.
        /// </summary>
        internal swizzle_lvec3(long x, long y, long z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns lvec3.xx swizzling.
        /// </summary>
        public lvec2 xx => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec3.rr swizzling (equivalent to lvec3.xx).
        /// </summary>
        public lvec2 rr => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec3.xxx swizzling.
        /// </summary>
        public lvec3 xxx => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec3.rrr swizzling (equivalent to lvec3.xxx).
        /// </summary>
        public lvec3 rrr => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec3.xxxx swizzling.
        /// </summary>
        public lvec4 xxxx => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.rrrr swizzling (equivalent to lvec3.xxxx).
        /// </summary>
        public lvec4 rrrr => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.xxxxx swizzling.
        /// </summary>
        public lvec5 xxxxx => new lvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.rrrrr swizzling (equivalent to lvec3.xxxxx).
        /// </summary>
        public lvec5 rrrrr => new lvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.xxxxy swizzling.
        /// </summary>
        public lvec5 xxxxy => new lvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.rrrrg swizzling (equivalent to lvec3.xxxxy).
        /// </summary>
        public lvec5 rrrrg => new lvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.xxxxz swizzling.
        /// </summary>
        public lvec5 xxxxz => new lvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.rrrrb swizzling (equivalent to lvec3.xxxxz).
        /// </summary>
        public lvec5 rrrrb => new lvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.xxxy swizzling.
        /// </summary>
        public lvec4 xxxy => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.rrrg swizzling (equivalent to lvec3.xxxy).
        /// </summary>
        public lvec4 rrrg => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.xxxyx swizzling.
        /// </summary>
        public lvec5 xxxyx => new lvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.rrrgr swizzling (equivalent to lvec3.xxxyx).
        /// </summary>
        public lvec5 rrrgr => new lvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.xxxyy swizzling.
        /// </summary>
        public lvec5 xxxyy => new lvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.rrrgg swizzling (equivalent to lvec3.xxxyy).
        /// </summary>
        public lvec5 rrrgg => new lvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.xxxyz swizzling.
        /// </summary>
        public lvec5 xxxyz => new lvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.rrrgb swizzling (equivalent to lvec3.xxxyz).
        /// </summary>
        public lvec5 rrrgb => new lvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.xxxz swizzling.
        /// </summary>
        public lvec4 xxxz => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.rrrb swizzling (equivalent to lvec3.xxxz).
        /// </summary>
        public lvec4 rrrb => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.xxxzx swizzling.
        /// </summary>
        public lvec5 xxxzx => new lvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.rrrbr swizzling (equivalent to lvec3.xxxzx).
        /// </summary>
        public lvec5 rrrbr => new lvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.xxxzy swizzling.
        /// </summary>
        public lvec5 xxxzy => new lvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.rrrbg swizzling (equivalent to lvec3.xxxzy).
        /// </summary>
        public lvec5 rrrbg => new lvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.xxxzz swizzling.
        /// </summary>
        public lvec5 xxxzz => new lvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.rrrbb swizzling (equivalent to lvec3.xxxzz).
        /// </summary>
        public lvec5 rrrbb => new lvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.xxy swizzling.
        /// </summary>
        public lvec3 xxy => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec3.rrg swizzling (equivalent to lvec3.xxy).
        /// </summary>
        public lvec3 rrg => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec3.xxyx swizzling.
        /// </summary>
        public lvec4 xxyx => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.rrgr swizzling (equivalent to lvec3.xxyx).
        /// </summary>
        public lvec4 rrgr => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.xxyxx swizzling.
        /// </summary>
        public lvec5 xxyxx => new lvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.rrgrr swizzling (equivalent to lvec3.xxyxx).
        /// </summary>
        public lvec5 rrgrr => new lvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.xxyxy swizzling.
        /// </summary>
        public lvec5 xxyxy => new lvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.rrgrg swizzling (equivalent to lvec3.xxyxy).
        /// </summary>
        public lvec5 rrgrg => new lvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.xxyxz swizzling.
        /// </summary>
        public lvec5 xxyxz => new lvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.rrgrb swizzling (equivalent to lvec3.xxyxz).
        /// </summary>
        public lvec5 rrgrb => new lvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.xxyy swizzling.
        /// </summary>
        public lvec4 xxyy => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.rrgg swizzling (equivalent to lvec3.xxyy).
        /// </summary>
        public lvec4 rrgg => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.xxyyx swizzling.
        /// </summary>
        public lvec5 xxyyx => new lvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.rrggr swizzling (equivalent to lvec3.xxyyx).
        /// </summary>
        public lvec5 rrggr => new lvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.xxyyy swizzling.
        /// </summary>
        public lvec5 xxyyy => new lvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.rrggg swizzling (equivalent to lvec3.xxyyy).
        /// </summary>
        public lvec5 rrggg => new lvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.xxyyz swizzling.
        /// </summary>
        public lvec5 xxyyz => new lvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.rrggb swizzling (equivalent to lvec3.xxyyz).
        /// </summary>
        public lvec5 rrggb => new lvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.xxyz swizzling.
        /// </summary>
        public lvec4 xxyz => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.rrgb swizzling (equivalent to lvec3.xxyz).
        /// </summary>
        public lvec4 rrgb => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.xxyzx swizzling.
        /// </summary>
        public lvec5 xxyzx => new lvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.rrgbr swizzling (equivalent to lvec3.xxyzx).
        /// </summary>
        public lvec5 rrgbr => new lvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.xxyzy swizzling.
        /// </summary>
        public lvec5 xxyzy => new lvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.rrgbg swizzling (equivalent to lvec3.xxyzy).
        /// </summary>
        public lvec5 rrgbg => new lvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.xxyzz swizzling.
        /// </summary>
        public lvec5 xxyzz => new lvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.rrgbb swizzling (equivalent to lvec3.xxyzz).
        /// </summary>
        public lvec5 rrgbb => new lvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.xxz swizzling.
        /// </summary>
        public lvec3 xxz => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec3.rrb swizzling (equivalent to lvec3.xxz).
        /// </summary>
        public lvec3 rrb => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec3.xxzx swizzling.
        /// </summary>
        public lvec4 xxzx => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.rrbr swizzling (equivalent to lvec3.xxzx).
        /// </summary>
        public lvec4 rrbr => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.xxzxx swizzling.
        /// </summary>
        public lvec5 xxzxx => new lvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.rrbrr swizzling (equivalent to lvec3.xxzxx).
        /// </summary>
        public lvec5 rrbrr => new lvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.xxzxy swizzling.
        /// </summary>
        public lvec5 xxzxy => new lvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.rrbrg swizzling (equivalent to lvec3.xxzxy).
        /// </summary>
        public lvec5 rrbrg => new lvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.xxzxz swizzling.
        /// </summary>
        public lvec5 xxzxz => new lvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.rrbrb swizzling (equivalent to lvec3.xxzxz).
        /// </summary>
        public lvec5 rrbrb => new lvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.xxzy swizzling.
        /// </summary>
        public lvec4 xxzy => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.rrbg swizzling (equivalent to lvec3.xxzy).
        /// </summary>
        public lvec4 rrbg => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.xxzyx swizzling.
        /// </summary>
        public lvec5 xxzyx => new lvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.rrbgr swizzling (equivalent to lvec3.xxzyx).
        /// </summary>
        public lvec5 rrbgr => new lvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.xxzyy swizzling.
        /// </summary>
        public lvec5 xxzyy => new lvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.rrbgg swizzling (equivalent to lvec3.xxzyy).
        /// </summary>
        public lvec5 rrbgg => new lvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.xxzyz swizzling.
        /// </summary>
        public lvec5 xxzyz => new lvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.rrbgb swizzling (equivalent to lvec3.xxzyz).
        /// </summary>
        public lvec5 rrbgb => new lvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.xxzz swizzling.
        /// </summary>
        public lvec4 xxzz => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.rrbb swizzling (equivalent to lvec3.xxzz).
        /// </summary>
        public lvec4 rrbb => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.xxzzx swizzling.
        /// </summary>
        public lvec5 xxzzx => new lvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.rrbbr swizzling (equivalent to lvec3.xxzzx).
        /// </summary>
        public lvec5 rrbbr => new lvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.xxzzy swizzling.
        /// </summary>
        public lvec5 xxzzy => new lvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.rrbbg swizzling (equivalent to lvec3.xxzzy).
        /// </summary>
        public lvec5 rrbbg => new lvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.xxzzz swizzling.
        /// </summary>
        public lvec5 xxzzz => new lvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.rrbbb swizzling (equivalent to lvec3.xxzzz).
        /// </summary>
        public lvec5 rrbbb => new lvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.xy swizzling.
        /// </summary>
        public lvec2 xy => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec3.rg swizzling (equivalent to lvec3.xy).
        /// </summary>
        public lvec2 rg => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec3.xyx swizzling.
        /// </summary>
        public lvec3 xyx => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec3.rgr swizzling (equivalent to lvec3.xyx).
        /// </summary>
        public lvec3 rgr => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec3.xyxx swizzling.
        /// </summary>
        public lvec4 xyxx => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.rgrr swizzling (equivalent to lvec3.xyxx).
        /// </summary>
        public lvec4 rgrr => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.xyxxx swizzling.
        /// </summary>
        public lvec5 xyxxx => new lvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.rgrrr swizzling (equivalent to lvec3.xyxxx).
        /// </summary>
        public lvec5 rgrrr => new lvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.xyxxy swizzling.
        /// </summary>
        public lvec5 xyxxy => new lvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.rgrrg swizzling (equivalent to lvec3.xyxxy).
        /// </summary>
        public lvec5 rgrrg => new lvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.xyxxz swizzling.
        /// </summary>
        public lvec5 xyxxz => new lvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.rgrrb swizzling (equivalent to lvec3.xyxxz).
        /// </summary>
        public lvec5 rgrrb => new lvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.xyxy swizzling.
        /// </summary>
        public lvec4 xyxy => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.rgrg swizzling (equivalent to lvec3.xyxy).
        /// </summary>
        public lvec4 rgrg => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.xyxyx swizzling.
        /// </summary>
        public lvec5 xyxyx => new lvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.rgrgr swizzling (equivalent to lvec3.xyxyx).
        /// </summary>
        public lvec5 rgrgr => new lvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.xyxyy swizzling.
        /// </summary>
        public lvec5 xyxyy => new lvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.rgrgg swizzling (equivalent to lvec3.xyxyy).
        /// </summary>
        public lvec5 rgrgg => new lvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.xyxyz swizzling.
        /// </summary>
        public lvec5 xyxyz => new lvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.rgrgb swizzling (equivalent to lvec3.xyxyz).
        /// </summary>
        public lvec5 rgrgb => new lvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.xyxz swizzling.
        /// </summary>
        public lvec4 xyxz => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.rgrb swizzling (equivalent to lvec3.xyxz).
        /// </summary>
        public lvec4 rgrb => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.xyxzx swizzling.
        /// </summary>
        public lvec5 xyxzx => new lvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.rgrbr swizzling (equivalent to lvec3.xyxzx).
        /// </summary>
        public lvec5 rgrbr => new lvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.xyxzy swizzling.
        /// </summary>
        public lvec5 xyxzy => new lvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.rgrbg swizzling (equivalent to lvec3.xyxzy).
        /// </summary>
        public lvec5 rgrbg => new lvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.xyxzz swizzling.
        /// </summary>
        public lvec5 xyxzz => new lvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.rgrbb swizzling (equivalent to lvec3.xyxzz).
        /// </summary>
        public lvec5 rgrbb => new lvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.xyy swizzling.
        /// </summary>
        public lvec3 xyy => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec3.rgg swizzling (equivalent to lvec3.xyy).
        /// </summary>
        public lvec3 rgg => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec3.xyyx swizzling.
        /// </summary>
        public lvec4 xyyx => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.rggr swizzling (equivalent to lvec3.xyyx).
        /// </summary>
        public lvec4 rggr => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.xyyxx swizzling.
        /// </summary>
        public lvec5 xyyxx => new lvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.rggrr swizzling (equivalent to lvec3.xyyxx).
        /// </summary>
        public lvec5 rggrr => new lvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.xyyxy swizzling.
        /// </summary>
        public lvec5 xyyxy => new lvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.rggrg swizzling (equivalent to lvec3.xyyxy).
        /// </summary>
        public lvec5 rggrg => new lvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.xyyxz swizzling.
        /// </summary>
        public lvec5 xyyxz => new lvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.rggrb swizzling (equivalent to lvec3.xyyxz).
        /// </summary>
        public lvec5 rggrb => new lvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.xyyy swizzling.
        /// </summary>
        public lvec4 xyyy => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.rggg swizzling (equivalent to lvec3.xyyy).
        /// </summary>
        public lvec4 rggg => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.xyyyx swizzling.
        /// </summary>
        public lvec5 xyyyx => new lvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.rgggr swizzling (equivalent to lvec3.xyyyx).
        /// </summary>
        public lvec5 rgggr => new lvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.xyyyy swizzling.
        /// </summary>
        public lvec5 xyyyy => new lvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.rgggg swizzling (equivalent to lvec3.xyyyy).
        /// </summary>
        public lvec5 rgggg => new lvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.xyyyz swizzling.
        /// </summary>
        public lvec5 xyyyz => new lvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.rgggb swizzling (equivalent to lvec3.xyyyz).
        /// </summary>
        public lvec5 rgggb => new lvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.xyyz swizzling.
        /// </summary>
        public lvec4 xyyz => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.rggb swizzling (equivalent to lvec3.xyyz).
        /// </summary>
        public lvec4 rggb => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.xyyzx swizzling.
        /// </summary>
        public lvec5 xyyzx => new lvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.rggbr swizzling (equivalent to lvec3.xyyzx).
        /// </summary>
        public lvec5 rggbr => new lvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.xyyzy swizzling.
        /// </summary>
        public lvec5 xyyzy => new lvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.rggbg swizzling (equivalent to lvec3.xyyzy).
        /// </summary>
        public lvec5 rggbg => new lvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.xyyzz swizzling.
        /// </summary>
        public lvec5 xyyzz => new lvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.rggbb swizzling (equivalent to lvec3.xyyzz).
        /// </summary>
        public lvec5 rggbb => new lvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.xyz swizzling.
        /// </summary>
        public lvec3 xyz => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec3.rgb swizzling (equivalent to lvec3.xyz).
        /// </summary>
        public lvec3 rgb => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec3.xyzx swizzling.
        /// </summary>
        public lvec4 xyzx => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.rgbr swizzling (equivalent to lvec3.xyzx).
        /// </summary>
        public lvec4 rgbr => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.xyzxx swizzling.
        /// </summary>
        public lvec5 xyzxx => new lvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.rgbrr swizzling (equivalent to lvec3.xyzxx).
        /// </summary>
        public lvec5 rgbrr => new lvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.xyzxy swizzling.
        /// </summary>
        public lvec5 xyzxy => new lvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.rgbrg swizzling (equivalent to lvec3.xyzxy).
        /// </summary>
        public lvec5 rgbrg => new lvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.xyzxz swizzling.
        /// </summary>
        public lvec5 xyzxz => new lvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.rgbrb swizzling (equivalent to lvec3.xyzxz).
        /// </summary>
        public lvec5 rgbrb => new lvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.xyzy swizzling.
        /// </summary>
        public lvec4 xyzy => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.rgbg swizzling (equivalent to lvec3.xyzy).
        /// </summary>
        public lvec4 rgbg => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.xyzyx swizzling.
        /// </summary>
        public lvec5 xyzyx => new lvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.rgbgr swizzling (equivalent to lvec3.xyzyx).
        /// </summary>
        public lvec5 rgbgr => new lvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.xyzyy swizzling.
        /// </summary>
        public lvec5 xyzyy => new lvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.rgbgg swizzling (equivalent to lvec3.xyzyy).
        /// </summary>
        public lvec5 rgbgg => new lvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.xyzyz swizzling.
        /// </summary>
        public lvec5 xyzyz => new lvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.rgbgb swizzling (equivalent to lvec3.xyzyz).
        /// </summary>
        public lvec5 rgbgb => new lvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.xyzz swizzling.
        /// </summary>
        public lvec4 xyzz => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.rgbb swizzling (equivalent to lvec3.xyzz).
        /// </summary>
        public lvec4 rgbb => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.xyzzx swizzling.
        /// </summary>
        public lvec5 xyzzx => new lvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.rgbbr swizzling (equivalent to lvec3.xyzzx).
        /// </summary>
        public lvec5 rgbbr => new lvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.xyzzy swizzling.
        /// </summary>
        public lvec5 xyzzy => new lvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.rgbbg swizzling (equivalent to lvec3.xyzzy).
        /// </summary>
        public lvec5 rgbbg => new lvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.xyzzz swizzling.
        /// </summary>
        public lvec5 xyzzz => new lvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.rgbbb swizzling (equivalent to lvec3.xyzzz).
        /// </summary>
        public lvec5 rgbbb => new lvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.xz swizzling.
        /// </summary>
        public lvec2 xz => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec3.rb swizzling (equivalent to lvec3.xz).
        /// </summary>
        public lvec2 rb => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec3.xzx swizzling.
        /// </summary>
        public lvec3 xzx => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec3.rbr swizzling (equivalent to lvec3.xzx).
        /// </summary>
        public lvec3 rbr => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec3.xzxx swizzling.
        /// </summary>
        public lvec4 xzxx => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.rbrr swizzling (equivalent to lvec3.xzxx).
        /// </summary>
        public lvec4 rbrr => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.xzxxx swizzling.
        /// </summary>
        public lvec5 xzxxx => new lvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.rbrrr swizzling (equivalent to lvec3.xzxxx).
        /// </summary>
        public lvec5 rbrrr => new lvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.xzxxy swizzling.
        /// </summary>
        public lvec5 xzxxy => new lvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.rbrrg swizzling (equivalent to lvec3.xzxxy).
        /// </summary>
        public lvec5 rbrrg => new lvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.xzxxz swizzling.
        /// </summary>
        public lvec5 xzxxz => new lvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.rbrrb swizzling (equivalent to lvec3.xzxxz).
        /// </summary>
        public lvec5 rbrrb => new lvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.xzxy swizzling.
        /// </summary>
        public lvec4 xzxy => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.rbrg swizzling (equivalent to lvec3.xzxy).
        /// </summary>
        public lvec4 rbrg => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.xzxyx swizzling.
        /// </summary>
        public lvec5 xzxyx => new lvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.rbrgr swizzling (equivalent to lvec3.xzxyx).
        /// </summary>
        public lvec5 rbrgr => new lvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.xzxyy swizzling.
        /// </summary>
        public lvec5 xzxyy => new lvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.rbrgg swizzling (equivalent to lvec3.xzxyy).
        /// </summary>
        public lvec5 rbrgg => new lvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.xzxyz swizzling.
        /// </summary>
        public lvec5 xzxyz => new lvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.rbrgb swizzling (equivalent to lvec3.xzxyz).
        /// </summary>
        public lvec5 rbrgb => new lvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.xzxz swizzling.
        /// </summary>
        public lvec4 xzxz => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.rbrb swizzling (equivalent to lvec3.xzxz).
        /// </summary>
        public lvec4 rbrb => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.xzxzx swizzling.
        /// </summary>
        public lvec5 xzxzx => new lvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.rbrbr swizzling (equivalent to lvec3.xzxzx).
        /// </summary>
        public lvec5 rbrbr => new lvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.xzxzy swizzling.
        /// </summary>
        public lvec5 xzxzy => new lvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.rbrbg swizzling (equivalent to lvec3.xzxzy).
        /// </summary>
        public lvec5 rbrbg => new lvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.xzxzz swizzling.
        /// </summary>
        public lvec5 xzxzz => new lvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.rbrbb swizzling (equivalent to lvec3.xzxzz).
        /// </summary>
        public lvec5 rbrbb => new lvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.xzy swizzling.
        /// </summary>
        public lvec3 xzy => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec3.rbg swizzling (equivalent to lvec3.xzy).
        /// </summary>
        public lvec3 rbg => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec3.xzyx swizzling.
        /// </summary>
        public lvec4 xzyx => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.rbgr swizzling (equivalent to lvec3.xzyx).
        /// </summary>
        public lvec4 rbgr => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.xzyxx swizzling.
        /// </summary>
        public lvec5 xzyxx => new lvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.rbgrr swizzling (equivalent to lvec3.xzyxx).
        /// </summary>
        public lvec5 rbgrr => new lvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.xzyxy swizzling.
        /// </summary>
        public lvec5 xzyxy => new lvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.rbgrg swizzling (equivalent to lvec3.xzyxy).
        /// </summary>
        public lvec5 rbgrg => new lvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.xzyxz swizzling.
        /// </summary>
        public lvec5 xzyxz => new lvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.rbgrb swizzling (equivalent to lvec3.xzyxz).
        /// </summary>
        public lvec5 rbgrb => new lvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.xzyy swizzling.
        /// </summary>
        public lvec4 xzyy => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.rbgg swizzling (equivalent to lvec3.xzyy).
        /// </summary>
        public lvec4 rbgg => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.xzyyx swizzling.
        /// </summary>
        public lvec5 xzyyx => new lvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.rbggr swizzling (equivalent to lvec3.xzyyx).
        /// </summary>
        public lvec5 rbggr => new lvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.xzyyy swizzling.
        /// </summary>
        public lvec5 xzyyy => new lvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.rbggg swizzling (equivalent to lvec3.xzyyy).
        /// </summary>
        public lvec5 rbggg => new lvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.xzyyz swizzling.
        /// </summary>
        public lvec5 xzyyz => new lvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.rbggb swizzling (equivalent to lvec3.xzyyz).
        /// </summary>
        public lvec5 rbggb => new lvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.xzyz swizzling.
        /// </summary>
        public lvec4 xzyz => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.rbgb swizzling (equivalent to lvec3.xzyz).
        /// </summary>
        public lvec4 rbgb => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.xzyzx swizzling.
        /// </summary>
        public lvec5 xzyzx => new lvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.rbgbr swizzling (equivalent to lvec3.xzyzx).
        /// </summary>
        public lvec5 rbgbr => new lvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.xzyzy swizzling.
        /// </summary>
        public lvec5 xzyzy => new lvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.rbgbg swizzling (equivalent to lvec3.xzyzy).
        /// </summary>
        public lvec5 rbgbg => new lvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.xzyzz swizzling.
        /// </summary>
        public lvec5 xzyzz => new lvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.rbgbb swizzling (equivalent to lvec3.xzyzz).
        /// </summary>
        public lvec5 rbgbb => new lvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.xzz swizzling.
        /// </summary>
        public lvec3 xzz => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec3.rbb swizzling (equivalent to lvec3.xzz).
        /// </summary>
        public lvec3 rbb => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec3.xzzx swizzling.
        /// </summary>
        public lvec4 xzzx => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.rbbr swizzling (equivalent to lvec3.xzzx).
        /// </summary>
        public lvec4 rbbr => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.xzzxx swizzling.
        /// </summary>
        public lvec5 xzzxx => new lvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.rbbrr swizzling (equivalent to lvec3.xzzxx).
        /// </summary>
        public lvec5 rbbrr => new lvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.xzzxy swizzling.
        /// </summary>
        public lvec5 xzzxy => new lvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.rbbrg swizzling (equivalent to lvec3.xzzxy).
        /// </summary>
        public lvec5 rbbrg => new lvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.xzzxz swizzling.
        /// </summary>
        public lvec5 xzzxz => new lvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.rbbrb swizzling (equivalent to lvec3.xzzxz).
        /// </summary>
        public lvec5 rbbrb => new lvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.xzzy swizzling.
        /// </summary>
        public lvec4 xzzy => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.rbbg swizzling (equivalent to lvec3.xzzy).
        /// </summary>
        public lvec4 rbbg => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.xzzyx swizzling.
        /// </summary>
        public lvec5 xzzyx => new lvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.rbbgr swizzling (equivalent to lvec3.xzzyx).
        /// </summary>
        public lvec5 rbbgr => new lvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.xzzyy swizzling.
        /// </summary>
        public lvec5 xzzyy => new lvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.rbbgg swizzling (equivalent to lvec3.xzzyy).
        /// </summary>
        public lvec5 rbbgg => new lvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.xzzyz swizzling.
        /// </summary>
        public lvec5 xzzyz => new lvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.rbbgb swizzling (equivalent to lvec3.xzzyz).
        /// </summary>
        public lvec5 rbbgb => new lvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.xzzz swizzling.
        /// </summary>
        public lvec4 xzzz => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.rbbb swizzling (equivalent to lvec3.xzzz).
        /// </summary>
        public lvec4 rbbb => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.xzzzx swizzling.
        /// </summary>
        public lvec5 xzzzx => new lvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.rbbbr swizzling (equivalent to lvec3.xzzzx).
        /// </summary>
        public lvec5 rbbbr => new lvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.xzzzy swizzling.
        /// </summary>
        public lvec5 xzzzy => new lvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.rbbbg swizzling (equivalent to lvec3.xzzzy).
        /// </summary>
        public lvec5 rbbbg => new lvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.xzzzz swizzling.
        /// </summary>
        public lvec5 xzzzz => new lvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns lvec3.rbbbb swizzling (equivalent to lvec3.xzzzz).
        /// </summary>
        public lvec5 rbbbb => new lvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns lvec3.yx swizzling.
        /// </summary>
        public lvec2 yx => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec3.gr swizzling (equivalent to lvec3.yx).
        /// </summary>
        public lvec2 gr => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec3.yxx swizzling.
        /// </summary>
        public lvec3 yxx => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec3.grr swizzling (equivalent to lvec3.yxx).
        /// </summary>
        public lvec3 grr => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec3.yxxx swizzling.
        /// </summary>
        public lvec4 yxxx => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.grrr swizzling (equivalent to lvec3.yxxx).
        /// </summary>
        public lvec4 grrr => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.yxxxx swizzling.
        /// </summary>
        public lvec5 yxxxx => new lvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.grrrr swizzling (equivalent to lvec3.yxxxx).
        /// </summary>
        public lvec5 grrrr => new lvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.yxxxy swizzling.
        /// </summary>
        public lvec5 yxxxy => new lvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.grrrg swizzling (equivalent to lvec3.yxxxy).
        /// </summary>
        public lvec5 grrrg => new lvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.yxxxz swizzling.
        /// </summary>
        public lvec5 yxxxz => new lvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.grrrb swizzling (equivalent to lvec3.yxxxz).
        /// </summary>
        public lvec5 grrrb => new lvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.yxxy swizzling.
        /// </summary>
        public lvec4 yxxy => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.grrg swizzling (equivalent to lvec3.yxxy).
        /// </summary>
        public lvec4 grrg => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.yxxyx swizzling.
        /// </summary>
        public lvec5 yxxyx => new lvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.grrgr swizzling (equivalent to lvec3.yxxyx).
        /// </summary>
        public lvec5 grrgr => new lvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.yxxyy swizzling.
        /// </summary>
        public lvec5 yxxyy => new lvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.grrgg swizzling (equivalent to lvec3.yxxyy).
        /// </summary>
        public lvec5 grrgg => new lvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.yxxyz swizzling.
        /// </summary>
        public lvec5 yxxyz => new lvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.grrgb swizzling (equivalent to lvec3.yxxyz).
        /// </summary>
        public lvec5 grrgb => new lvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.yxxz swizzling.
        /// </summary>
        public lvec4 yxxz => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.grrb swizzling (equivalent to lvec3.yxxz).
        /// </summary>
        public lvec4 grrb => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.yxxzx swizzling.
        /// </summary>
        public lvec5 yxxzx => new lvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.grrbr swizzling (equivalent to lvec3.yxxzx).
        /// </summary>
        public lvec5 grrbr => new lvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.yxxzy swizzling.
        /// </summary>
        public lvec5 yxxzy => new lvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.grrbg swizzling (equivalent to lvec3.yxxzy).
        /// </summary>
        public lvec5 grrbg => new lvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.yxxzz swizzling.
        /// </summary>
        public lvec5 yxxzz => new lvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.grrbb swizzling (equivalent to lvec3.yxxzz).
        /// </summary>
        public lvec5 grrbb => new lvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.yxy swizzling.
        /// </summary>
        public lvec3 yxy => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec3.grg swizzling (equivalent to lvec3.yxy).
        /// </summary>
        public lvec3 grg => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec3.yxyx swizzling.
        /// </summary>
        public lvec4 yxyx => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.grgr swizzling (equivalent to lvec3.yxyx).
        /// </summary>
        public lvec4 grgr => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.yxyxx swizzling.
        /// </summary>
        public lvec5 yxyxx => new lvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.grgrr swizzling (equivalent to lvec3.yxyxx).
        /// </summary>
        public lvec5 grgrr => new lvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.yxyxy swizzling.
        /// </summary>
        public lvec5 yxyxy => new lvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.grgrg swizzling (equivalent to lvec3.yxyxy).
        /// </summary>
        public lvec5 grgrg => new lvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.yxyxz swizzling.
        /// </summary>
        public lvec5 yxyxz => new lvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.grgrb swizzling (equivalent to lvec3.yxyxz).
        /// </summary>
        public lvec5 grgrb => new lvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.yxyy swizzling.
        /// </summary>
        public lvec4 yxyy => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.grgg swizzling (equivalent to lvec3.yxyy).
        /// </summary>
        public lvec4 grgg => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.yxyyx swizzling.
        /// </summary>
        public lvec5 yxyyx => new lvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.grggr swizzling (equivalent to lvec3.yxyyx).
        /// </summary>
        public lvec5 grggr => new lvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.yxyyy swizzling.
        /// </summary>
        public lvec5 yxyyy => new lvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.grggg swizzling (equivalent to lvec3.yxyyy).
        /// </summary>
        public lvec5 grggg => new lvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.yxyyz swizzling.
        /// </summary>
        public lvec5 yxyyz => new lvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.grggb swizzling (equivalent to lvec3.yxyyz).
        /// </summary>
        public lvec5 grggb => new lvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.yxyz swizzling.
        /// </summary>
        public lvec4 yxyz => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.grgb swizzling (equivalent to lvec3.yxyz).
        /// </summary>
        public lvec4 grgb => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.yxyzx swizzling.
        /// </summary>
        public lvec5 yxyzx => new lvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.grgbr swizzling (equivalent to lvec3.yxyzx).
        /// </summary>
        public lvec5 grgbr => new lvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.yxyzy swizzling.
        /// </summary>
        public lvec5 yxyzy => new lvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.grgbg swizzling (equivalent to lvec3.yxyzy).
        /// </summary>
        public lvec5 grgbg => new lvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.yxyzz swizzling.
        /// </summary>
        public lvec5 yxyzz => new lvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.grgbb swizzling (equivalent to lvec3.yxyzz).
        /// </summary>
        public lvec5 grgbb => new lvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.yxz swizzling.
        /// </summary>
        public lvec3 yxz => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec3.grb swizzling (equivalent to lvec3.yxz).
        /// </summary>
        public lvec3 grb => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec3.yxzx swizzling.
        /// </summary>
        public lvec4 yxzx => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.grbr swizzling (equivalent to lvec3.yxzx).
        /// </summary>
        public lvec4 grbr => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.yxzxx swizzling.
        /// </summary>
        public lvec5 yxzxx => new lvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.grbrr swizzling (equivalent to lvec3.yxzxx).
        /// </summary>
        public lvec5 grbrr => new lvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.yxzxy swizzling.
        /// </summary>
        public lvec5 yxzxy => new lvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.grbrg swizzling (equivalent to lvec3.yxzxy).
        /// </summary>
        public lvec5 grbrg => new lvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.yxzxz swizzling.
        /// </summary>
        public lvec5 yxzxz => new lvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.grbrb swizzling (equivalent to lvec3.yxzxz).
        /// </summary>
        public lvec5 grbrb => new lvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.yxzy swizzling.
        /// </summary>
        public lvec4 yxzy => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.grbg swizzling (equivalent to lvec3.yxzy).
        /// </summary>
        public lvec4 grbg => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.yxzyx swizzling.
        /// </summary>
        public lvec5 yxzyx => new lvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.grbgr swizzling (equivalent to lvec3.yxzyx).
        /// </summary>
        public lvec5 grbgr => new lvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.yxzyy swizzling.
        /// </summary>
        public lvec5 yxzyy => new lvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.grbgg swizzling (equivalent to lvec3.yxzyy).
        /// </summary>
        public lvec5 grbgg => new lvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.yxzyz swizzling.
        /// </summary>
        public lvec5 yxzyz => new lvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.grbgb swizzling (equivalent to lvec3.yxzyz).
        /// </summary>
        public lvec5 grbgb => new lvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.yxzz swizzling.
        /// </summary>
        public lvec4 yxzz => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.grbb swizzling (equivalent to lvec3.yxzz).
        /// </summary>
        public lvec4 grbb => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.yxzzx swizzling.
        /// </summary>
        public lvec5 yxzzx => new lvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.grbbr swizzling (equivalent to lvec3.yxzzx).
        /// </summary>
        public lvec5 grbbr => new lvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.yxzzy swizzling.
        /// </summary>
        public lvec5 yxzzy => new lvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.grbbg swizzling (equivalent to lvec3.yxzzy).
        /// </summary>
        public lvec5 grbbg => new lvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.yxzzz swizzling.
        /// </summary>
        public lvec5 yxzzz => new lvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.grbbb swizzling (equivalent to lvec3.yxzzz).
        /// </summary>
        public lvec5 grbbb => new lvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.yy swizzling.
        /// </summary>
        public lvec2 yy => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec3.gg swizzling (equivalent to lvec3.yy).
        /// </summary>
        public lvec2 gg => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec3.yyx swizzling.
        /// </summary>
        public lvec3 yyx => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec3.ggr swizzling (equivalent to lvec3.yyx).
        /// </summary>
        public lvec3 ggr => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec3.yyxx swizzling.
        /// </summary>
        public lvec4 yyxx => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.ggrr swizzling (equivalent to lvec3.yyxx).
        /// </summary>
        public lvec4 ggrr => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.yyxxx swizzling.
        /// </summary>
        public lvec5 yyxxx => new lvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.ggrrr swizzling (equivalent to lvec3.yyxxx).
        /// </summary>
        public lvec5 ggrrr => new lvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.yyxxy swizzling.
        /// </summary>
        public lvec5 yyxxy => new lvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.ggrrg swizzling (equivalent to lvec3.yyxxy).
        /// </summary>
        public lvec5 ggrrg => new lvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.yyxxz swizzling.
        /// </summary>
        public lvec5 yyxxz => new lvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.ggrrb swizzling (equivalent to lvec3.yyxxz).
        /// </summary>
        public lvec5 ggrrb => new lvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.yyxy swizzling.
        /// </summary>
        public lvec4 yyxy => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.ggrg swizzling (equivalent to lvec3.yyxy).
        /// </summary>
        public lvec4 ggrg => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.yyxyx swizzling.
        /// </summary>
        public lvec5 yyxyx => new lvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.ggrgr swizzling (equivalent to lvec3.yyxyx).
        /// </summary>
        public lvec5 ggrgr => new lvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.yyxyy swizzling.
        /// </summary>
        public lvec5 yyxyy => new lvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.ggrgg swizzling (equivalent to lvec3.yyxyy).
        /// </summary>
        public lvec5 ggrgg => new lvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.yyxyz swizzling.
        /// </summary>
        public lvec5 yyxyz => new lvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.ggrgb swizzling (equivalent to lvec3.yyxyz).
        /// </summary>
        public lvec5 ggrgb => new lvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.yyxz swizzling.
        /// </summary>
        public lvec4 yyxz => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.ggrb swizzling (equivalent to lvec3.yyxz).
        /// </summary>
        public lvec4 ggrb => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.yyxzx swizzling.
        /// </summary>
        public lvec5 yyxzx => new lvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.ggrbr swizzling (equivalent to lvec3.yyxzx).
        /// </summary>
        public lvec5 ggrbr => new lvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.yyxzy swizzling.
        /// </summary>
        public lvec5 yyxzy => new lvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.ggrbg swizzling (equivalent to lvec3.yyxzy).
        /// </summary>
        public lvec5 ggrbg => new lvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.yyxzz swizzling.
        /// </summary>
        public lvec5 yyxzz => new lvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.ggrbb swizzling (equivalent to lvec3.yyxzz).
        /// </summary>
        public lvec5 ggrbb => new lvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.yyy swizzling.
        /// </summary>
        public lvec3 yyy => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec3.ggg swizzling (equivalent to lvec3.yyy).
        /// </summary>
        public lvec3 ggg => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec3.yyyx swizzling.
        /// </summary>
        public lvec4 yyyx => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.gggr swizzling (equivalent to lvec3.yyyx).
        /// </summary>
        public lvec4 gggr => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.yyyxx swizzling.
        /// </summary>
        public lvec5 yyyxx => new lvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.gggrr swizzling (equivalent to lvec3.yyyxx).
        /// </summary>
        public lvec5 gggrr => new lvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.yyyxy swizzling.
        /// </summary>
        public lvec5 yyyxy => new lvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.gggrg swizzling (equivalent to lvec3.yyyxy).
        /// </summary>
        public lvec5 gggrg => new lvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.yyyxz swizzling.
        /// </summary>
        public lvec5 yyyxz => new lvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.gggrb swizzling (equivalent to lvec3.yyyxz).
        /// </summary>
        public lvec5 gggrb => new lvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.yyyy swizzling.
        /// </summary>
        public lvec4 yyyy => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.gggg swizzling (equivalent to lvec3.yyyy).
        /// </summary>
        public lvec4 gggg => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.yyyyx swizzling.
        /// </summary>
        public lvec5 yyyyx => new lvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.ggggr swizzling (equivalent to lvec3.yyyyx).
        /// </summary>
        public lvec5 ggggr => new lvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.yyyyy swizzling.
        /// </summary>
        public lvec5 yyyyy => new lvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.ggggg swizzling (equivalent to lvec3.yyyyy).
        /// </summary>
        public lvec5 ggggg => new lvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.yyyyz swizzling.
        /// </summary>
        public lvec5 yyyyz => new lvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.ggggb swizzling (equivalent to lvec3.yyyyz).
        /// </summary>
        public lvec5 ggggb => new lvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.yyyz swizzling.
        /// </summary>
        public lvec4 yyyz => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.gggb swizzling (equivalent to lvec3.yyyz).
        /// </summary>
        public lvec4 gggb => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.yyyzx swizzling.
        /// </summary>
        public lvec5 yyyzx => new lvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.gggbr swizzling (equivalent to lvec3.yyyzx).
        /// </summary>
        public lvec5 gggbr => new lvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.yyyzy swizzling.
        /// </summary>
        public lvec5 yyyzy => new lvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.gggbg swizzling (equivalent to lvec3.yyyzy).
        /// </summary>
        public lvec5 gggbg => new lvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.yyyzz swizzling.
        /// </summary>
        public lvec5 yyyzz => new lvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.gggbb swizzling (equivalent to lvec3.yyyzz).
        /// </summary>
        public lvec5 gggbb => new lvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.yyz swizzling.
        /// </summary>
        public lvec3 yyz => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec3.ggb swizzling (equivalent to lvec3.yyz).
        /// </summary>
        public lvec3 ggb => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec3.yyzx swizzling.
        /// </summary>
        public lvec4 yyzx => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.ggbr swizzling (equivalent to lvec3.yyzx).
        /// </summary>
        public lvec4 ggbr => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.yyzxx swizzling.
        /// </summary>
        public lvec5 yyzxx => new lvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.ggbrr swizzling (equivalent to lvec3.yyzxx).
        /// </summary>
        public lvec5 ggbrr => new lvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.yyzxy swizzling.
        /// </summary>
        public lvec5 yyzxy => new lvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.ggbrg swizzling (equivalent to lvec3.yyzxy).
        /// </summary>
        public lvec5 ggbrg => new lvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.yyzxz swizzling.
        /// </summary>
        public lvec5 yyzxz => new lvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.ggbrb swizzling (equivalent to lvec3.yyzxz).
        /// </summary>
        public lvec5 ggbrb => new lvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.yyzy swizzling.
        /// </summary>
        public lvec4 yyzy => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.ggbg swizzling (equivalent to lvec3.yyzy).
        /// </summary>
        public lvec4 ggbg => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.yyzyx swizzling.
        /// </summary>
        public lvec5 yyzyx => new lvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.ggbgr swizzling (equivalent to lvec3.yyzyx).
        /// </summary>
        public lvec5 ggbgr => new lvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.yyzyy swizzling.
        /// </summary>
        public lvec5 yyzyy => new lvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.ggbgg swizzling (equivalent to lvec3.yyzyy).
        /// </summary>
        public lvec5 ggbgg => new lvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.yyzyz swizzling.
        /// </summary>
        public lvec5 yyzyz => new lvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.ggbgb swizzling (equivalent to lvec3.yyzyz).
        /// </summary>
        public lvec5 ggbgb => new lvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.yyzz swizzling.
        /// </summary>
        public lvec4 yyzz => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.ggbb swizzling (equivalent to lvec3.yyzz).
        /// </summary>
        public lvec4 ggbb => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.yyzzx swizzling.
        /// </summary>
        public lvec5 yyzzx => new lvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.ggbbr swizzling (equivalent to lvec3.yyzzx).
        /// </summary>
        public lvec5 ggbbr => new lvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.yyzzy swizzling.
        /// </summary>
        public lvec5 yyzzy => new lvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.ggbbg swizzling (equivalent to lvec3.yyzzy).
        /// </summary>
        public lvec5 ggbbg => new lvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.yyzzz swizzling.
        /// </summary>
        public lvec5 yyzzz => new lvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.ggbbb swizzling (equivalent to lvec3.yyzzz).
        /// </summary>
        public lvec5 ggbbb => new lvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.yz swizzling.
        /// </summary>
        public lvec2 yz => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec3.gb swizzling (equivalent to lvec3.yz).
        /// </summary>
        public lvec2 gb => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec3.yzx swizzling.
        /// </summary>
        public lvec3 yzx => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec3.gbr swizzling (equivalent to lvec3.yzx).
        /// </summary>
        public lvec3 gbr => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec3.yzxx swizzling.
        /// </summary>
        public lvec4 yzxx => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.gbrr swizzling (equivalent to lvec3.yzxx).
        /// </summary>
        public lvec4 gbrr => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.yzxxx swizzling.
        /// </summary>
        public lvec5 yzxxx => new lvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.gbrrr swizzling (equivalent to lvec3.yzxxx).
        /// </summary>
        public lvec5 gbrrr => new lvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.yzxxy swizzling.
        /// </summary>
        public lvec5 yzxxy => new lvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.gbrrg swizzling (equivalent to lvec3.yzxxy).
        /// </summary>
        public lvec5 gbrrg => new lvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.yzxxz swizzling.
        /// </summary>
        public lvec5 yzxxz => new lvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.gbrrb swizzling (equivalent to lvec3.yzxxz).
        /// </summary>
        public lvec5 gbrrb => new lvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.yzxy swizzling.
        /// </summary>
        public lvec4 yzxy => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.gbrg swizzling (equivalent to lvec3.yzxy).
        /// </summary>
        public lvec4 gbrg => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.yzxyx swizzling.
        /// </summary>
        public lvec5 yzxyx => new lvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.gbrgr swizzling (equivalent to lvec3.yzxyx).
        /// </summary>
        public lvec5 gbrgr => new lvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.yzxyy swizzling.
        /// </summary>
        public lvec5 yzxyy => new lvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.gbrgg swizzling (equivalent to lvec3.yzxyy).
        /// </summary>
        public lvec5 gbrgg => new lvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.yzxyz swizzling.
        /// </summary>
        public lvec5 yzxyz => new lvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.gbrgb swizzling (equivalent to lvec3.yzxyz).
        /// </summary>
        public lvec5 gbrgb => new lvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.yzxz swizzling.
        /// </summary>
        public lvec4 yzxz => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.gbrb swizzling (equivalent to lvec3.yzxz).
        /// </summary>
        public lvec4 gbrb => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.yzxzx swizzling.
        /// </summary>
        public lvec5 yzxzx => new lvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.gbrbr swizzling (equivalent to lvec3.yzxzx).
        /// </summary>
        public lvec5 gbrbr => new lvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.yzxzy swizzling.
        /// </summary>
        public lvec5 yzxzy => new lvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.gbrbg swizzling (equivalent to lvec3.yzxzy).
        /// </summary>
        public lvec5 gbrbg => new lvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.yzxzz swizzling.
        /// </summary>
        public lvec5 yzxzz => new lvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.gbrbb swizzling (equivalent to lvec3.yzxzz).
        /// </summary>
        public lvec5 gbrbb => new lvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.yzy swizzling.
        /// </summary>
        public lvec3 yzy => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec3.gbg swizzling (equivalent to lvec3.yzy).
        /// </summary>
        public lvec3 gbg => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec3.yzyx swizzling.
        /// </summary>
        public lvec4 yzyx => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.gbgr swizzling (equivalent to lvec3.yzyx).
        /// </summary>
        public lvec4 gbgr => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.yzyxx swizzling.
        /// </summary>
        public lvec5 yzyxx => new lvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.gbgrr swizzling (equivalent to lvec3.yzyxx).
        /// </summary>
        public lvec5 gbgrr => new lvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.yzyxy swizzling.
        /// </summary>
        public lvec5 yzyxy => new lvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.gbgrg swizzling (equivalent to lvec3.yzyxy).
        /// </summary>
        public lvec5 gbgrg => new lvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.yzyxz swizzling.
        /// </summary>
        public lvec5 yzyxz => new lvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.gbgrb swizzling (equivalent to lvec3.yzyxz).
        /// </summary>
        public lvec5 gbgrb => new lvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.yzyy swizzling.
        /// </summary>
        public lvec4 yzyy => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.gbgg swizzling (equivalent to lvec3.yzyy).
        /// </summary>
        public lvec4 gbgg => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.yzyyx swizzling.
        /// </summary>
        public lvec5 yzyyx => new lvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.gbggr swizzling (equivalent to lvec3.yzyyx).
        /// </summary>
        public lvec5 gbggr => new lvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.yzyyy swizzling.
        /// </summary>
        public lvec5 yzyyy => new lvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.gbggg swizzling (equivalent to lvec3.yzyyy).
        /// </summary>
        public lvec5 gbggg => new lvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.yzyyz swizzling.
        /// </summary>
        public lvec5 yzyyz => new lvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.gbggb swizzling (equivalent to lvec3.yzyyz).
        /// </summary>
        public lvec5 gbggb => new lvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.yzyz swizzling.
        /// </summary>
        public lvec4 yzyz => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.gbgb swizzling (equivalent to lvec3.yzyz).
        /// </summary>
        public lvec4 gbgb => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.yzyzx swizzling.
        /// </summary>
        public lvec5 yzyzx => new lvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.gbgbr swizzling (equivalent to lvec3.yzyzx).
        /// </summary>
        public lvec5 gbgbr => new lvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.yzyzy swizzling.
        /// </summary>
        public lvec5 yzyzy => new lvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.gbgbg swizzling (equivalent to lvec3.yzyzy).
        /// </summary>
        public lvec5 gbgbg => new lvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.yzyzz swizzling.
        /// </summary>
        public lvec5 yzyzz => new lvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.gbgbb swizzling (equivalent to lvec3.yzyzz).
        /// </summary>
        public lvec5 gbgbb => new lvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.yzz swizzling.
        /// </summary>
        public lvec3 yzz => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec3.gbb swizzling (equivalent to lvec3.yzz).
        /// </summary>
        public lvec3 gbb => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec3.yzzx swizzling.
        /// </summary>
        public lvec4 yzzx => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.gbbr swizzling (equivalent to lvec3.yzzx).
        /// </summary>
        public lvec4 gbbr => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.yzzxx swizzling.
        /// </summary>
        public lvec5 yzzxx => new lvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.gbbrr swizzling (equivalent to lvec3.yzzxx).
        /// </summary>
        public lvec5 gbbrr => new lvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.yzzxy swizzling.
        /// </summary>
        public lvec5 yzzxy => new lvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.gbbrg swizzling (equivalent to lvec3.yzzxy).
        /// </summary>
        public lvec5 gbbrg => new lvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.yzzxz swizzling.
        /// </summary>
        public lvec5 yzzxz => new lvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.gbbrb swizzling (equivalent to lvec3.yzzxz).
        /// </summary>
        public lvec5 gbbrb => new lvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.yzzy swizzling.
        /// </summary>
        public lvec4 yzzy => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.gbbg swizzling (equivalent to lvec3.yzzy).
        /// </summary>
        public lvec4 gbbg => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.yzzyx swizzling.
        /// </summary>
        public lvec5 yzzyx => new lvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.gbbgr swizzling (equivalent to lvec3.yzzyx).
        /// </summary>
        public lvec5 gbbgr => new lvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.yzzyy swizzling.
        /// </summary>
        public lvec5 yzzyy => new lvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.gbbgg swizzling (equivalent to lvec3.yzzyy).
        /// </summary>
        public lvec5 gbbgg => new lvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.yzzyz swizzling.
        /// </summary>
        public lvec5 yzzyz => new lvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.gbbgb swizzling (equivalent to lvec3.yzzyz).
        /// </summary>
        public lvec5 gbbgb => new lvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.yzzz swizzling.
        /// </summary>
        public lvec4 yzzz => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.gbbb swizzling (equivalent to lvec3.yzzz).
        /// </summary>
        public lvec4 gbbb => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.yzzzx swizzling.
        /// </summary>
        public lvec5 yzzzx => new lvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.gbbbr swizzling (equivalent to lvec3.yzzzx).
        /// </summary>
        public lvec5 gbbbr => new lvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.yzzzy swizzling.
        /// </summary>
        public lvec5 yzzzy => new lvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.gbbbg swizzling (equivalent to lvec3.yzzzy).
        /// </summary>
        public lvec5 gbbbg => new lvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.yzzzz swizzling.
        /// </summary>
        public lvec5 yzzzz => new lvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns lvec3.gbbbb swizzling (equivalent to lvec3.yzzzz).
        /// </summary>
        public lvec5 gbbbb => new lvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns lvec3.zx swizzling.
        /// </summary>
        public lvec2 zx => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec3.br swizzling (equivalent to lvec3.zx).
        /// </summary>
        public lvec2 br => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec3.zxx swizzling.
        /// </summary>
        public lvec3 zxx => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec3.brr swizzling (equivalent to lvec3.zxx).
        /// </summary>
        public lvec3 brr => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec3.zxxx swizzling.
        /// </summary>
        public lvec4 zxxx => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.brrr swizzling (equivalent to lvec3.zxxx).
        /// </summary>
        public lvec4 brrr => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.zxxxx swizzling.
        /// </summary>
        public lvec5 zxxxx => new lvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.brrrr swizzling (equivalent to lvec3.zxxxx).
        /// </summary>
        public lvec5 brrrr => new lvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.zxxxy swizzling.
        /// </summary>
        public lvec5 zxxxy => new lvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.brrrg swizzling (equivalent to lvec3.zxxxy).
        /// </summary>
        public lvec5 brrrg => new lvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.zxxxz swizzling.
        /// </summary>
        public lvec5 zxxxz => new lvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.brrrb swizzling (equivalent to lvec3.zxxxz).
        /// </summary>
        public lvec5 brrrb => new lvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.zxxy swizzling.
        /// </summary>
        public lvec4 zxxy => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.brrg swizzling (equivalent to lvec3.zxxy).
        /// </summary>
        public lvec4 brrg => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.zxxyx swizzling.
        /// </summary>
        public lvec5 zxxyx => new lvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.brrgr swizzling (equivalent to lvec3.zxxyx).
        /// </summary>
        public lvec5 brrgr => new lvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.zxxyy swizzling.
        /// </summary>
        public lvec5 zxxyy => new lvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.brrgg swizzling (equivalent to lvec3.zxxyy).
        /// </summary>
        public lvec5 brrgg => new lvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.zxxyz swizzling.
        /// </summary>
        public lvec5 zxxyz => new lvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.brrgb swizzling (equivalent to lvec3.zxxyz).
        /// </summary>
        public lvec5 brrgb => new lvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.zxxz swizzling.
        /// </summary>
        public lvec4 zxxz => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.brrb swizzling (equivalent to lvec3.zxxz).
        /// </summary>
        public lvec4 brrb => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.zxxzx swizzling.
        /// </summary>
        public lvec5 zxxzx => new lvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.brrbr swizzling (equivalent to lvec3.zxxzx).
        /// </summary>
        public lvec5 brrbr => new lvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.zxxzy swizzling.
        /// </summary>
        public lvec5 zxxzy => new lvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.brrbg swizzling (equivalent to lvec3.zxxzy).
        /// </summary>
        public lvec5 brrbg => new lvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.zxxzz swizzling.
        /// </summary>
        public lvec5 zxxzz => new lvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.brrbb swizzling (equivalent to lvec3.zxxzz).
        /// </summary>
        public lvec5 brrbb => new lvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.zxy swizzling.
        /// </summary>
        public lvec3 zxy => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec3.brg swizzling (equivalent to lvec3.zxy).
        /// </summary>
        public lvec3 brg => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec3.zxyx swizzling.
        /// </summary>
        public lvec4 zxyx => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.brgr swizzling (equivalent to lvec3.zxyx).
        /// </summary>
        public lvec4 brgr => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.zxyxx swizzling.
        /// </summary>
        public lvec5 zxyxx => new lvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.brgrr swizzling (equivalent to lvec3.zxyxx).
        /// </summary>
        public lvec5 brgrr => new lvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.zxyxy swizzling.
        /// </summary>
        public lvec5 zxyxy => new lvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.brgrg swizzling (equivalent to lvec3.zxyxy).
        /// </summary>
        public lvec5 brgrg => new lvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.zxyxz swizzling.
        /// </summary>
        public lvec5 zxyxz => new lvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.brgrb swizzling (equivalent to lvec3.zxyxz).
        /// </summary>
        public lvec5 brgrb => new lvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.zxyy swizzling.
        /// </summary>
        public lvec4 zxyy => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.brgg swizzling (equivalent to lvec3.zxyy).
        /// </summary>
        public lvec4 brgg => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.zxyyx swizzling.
        /// </summary>
        public lvec5 zxyyx => new lvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.brggr swizzling (equivalent to lvec3.zxyyx).
        /// </summary>
        public lvec5 brggr => new lvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.zxyyy swizzling.
        /// </summary>
        public lvec5 zxyyy => new lvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.brggg swizzling (equivalent to lvec3.zxyyy).
        /// </summary>
        public lvec5 brggg => new lvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.zxyyz swizzling.
        /// </summary>
        public lvec5 zxyyz => new lvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.brggb swizzling (equivalent to lvec3.zxyyz).
        /// </summary>
        public lvec5 brggb => new lvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.zxyz swizzling.
        /// </summary>
        public lvec4 zxyz => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.brgb swizzling (equivalent to lvec3.zxyz).
        /// </summary>
        public lvec4 brgb => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.zxyzx swizzling.
        /// </summary>
        public lvec5 zxyzx => new lvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.brgbr swizzling (equivalent to lvec3.zxyzx).
        /// </summary>
        public lvec5 brgbr => new lvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.zxyzy swizzling.
        /// </summary>
        public lvec5 zxyzy => new lvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.brgbg swizzling (equivalent to lvec3.zxyzy).
        /// </summary>
        public lvec5 brgbg => new lvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.zxyzz swizzling.
        /// </summary>
        public lvec5 zxyzz => new lvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.brgbb swizzling (equivalent to lvec3.zxyzz).
        /// </summary>
        public lvec5 brgbb => new lvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.zxz swizzling.
        /// </summary>
        public lvec3 zxz => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec3.brb swizzling (equivalent to lvec3.zxz).
        /// </summary>
        public lvec3 brb => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec3.zxzx swizzling.
        /// </summary>
        public lvec4 zxzx => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.brbr swizzling (equivalent to lvec3.zxzx).
        /// </summary>
        public lvec4 brbr => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.zxzxx swizzling.
        /// </summary>
        public lvec5 zxzxx => new lvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.brbrr swizzling (equivalent to lvec3.zxzxx).
        /// </summary>
        public lvec5 brbrr => new lvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.zxzxy swizzling.
        /// </summary>
        public lvec5 zxzxy => new lvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.brbrg swizzling (equivalent to lvec3.zxzxy).
        /// </summary>
        public lvec5 brbrg => new lvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.zxzxz swizzling.
        /// </summary>
        public lvec5 zxzxz => new lvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.brbrb swizzling (equivalent to lvec3.zxzxz).
        /// </summary>
        public lvec5 brbrb => new lvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.zxzy swizzling.
        /// </summary>
        public lvec4 zxzy => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.brbg swizzling (equivalent to lvec3.zxzy).
        /// </summary>
        public lvec4 brbg => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.zxzyx swizzling.
        /// </summary>
        public lvec5 zxzyx => new lvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.brbgr swizzling (equivalent to lvec3.zxzyx).
        /// </summary>
        public lvec5 brbgr => new lvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.zxzyy swizzling.
        /// </summary>
        public lvec5 zxzyy => new lvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.brbgg swizzling (equivalent to lvec3.zxzyy).
        /// </summary>
        public lvec5 brbgg => new lvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.zxzyz swizzling.
        /// </summary>
        public lvec5 zxzyz => new lvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.brbgb swizzling (equivalent to lvec3.zxzyz).
        /// </summary>
        public lvec5 brbgb => new lvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.zxzz swizzling.
        /// </summary>
        public lvec4 zxzz => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.brbb swizzling (equivalent to lvec3.zxzz).
        /// </summary>
        public lvec4 brbb => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.zxzzx swizzling.
        /// </summary>
        public lvec5 zxzzx => new lvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.brbbr swizzling (equivalent to lvec3.zxzzx).
        /// </summary>
        public lvec5 brbbr => new lvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.zxzzy swizzling.
        /// </summary>
        public lvec5 zxzzy => new lvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.brbbg swizzling (equivalent to lvec3.zxzzy).
        /// </summary>
        public lvec5 brbbg => new lvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.zxzzz swizzling.
        /// </summary>
        public lvec5 zxzzz => new lvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.brbbb swizzling (equivalent to lvec3.zxzzz).
        /// </summary>
        public lvec5 brbbb => new lvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.zy swizzling.
        /// </summary>
        public lvec2 zy => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec3.bg swizzling (equivalent to lvec3.zy).
        /// </summary>
        public lvec2 bg => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec3.zyx swizzling.
        /// </summary>
        public lvec3 zyx => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec3.bgr swizzling (equivalent to lvec3.zyx).
        /// </summary>
        public lvec3 bgr => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec3.zyxx swizzling.
        /// </summary>
        public lvec4 zyxx => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.bgrr swizzling (equivalent to lvec3.zyxx).
        /// </summary>
        public lvec4 bgrr => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.zyxxx swizzling.
        /// </summary>
        public lvec5 zyxxx => new lvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.bgrrr swizzling (equivalent to lvec3.zyxxx).
        /// </summary>
        public lvec5 bgrrr => new lvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.zyxxy swizzling.
        /// </summary>
        public lvec5 zyxxy => new lvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.bgrrg swizzling (equivalent to lvec3.zyxxy).
        /// </summary>
        public lvec5 bgrrg => new lvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.zyxxz swizzling.
        /// </summary>
        public lvec5 zyxxz => new lvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.bgrrb swizzling (equivalent to lvec3.zyxxz).
        /// </summary>
        public lvec5 bgrrb => new lvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.zyxy swizzling.
        /// </summary>
        public lvec4 zyxy => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.bgrg swizzling (equivalent to lvec3.zyxy).
        /// </summary>
        public lvec4 bgrg => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.zyxyx swizzling.
        /// </summary>
        public lvec5 zyxyx => new lvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.bgrgr swizzling (equivalent to lvec3.zyxyx).
        /// </summary>
        public lvec5 bgrgr => new lvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.zyxyy swizzling.
        /// </summary>
        public lvec5 zyxyy => new lvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.bgrgg swizzling (equivalent to lvec3.zyxyy).
        /// </summary>
        public lvec5 bgrgg => new lvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.zyxyz swizzling.
        /// </summary>
        public lvec5 zyxyz => new lvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.bgrgb swizzling (equivalent to lvec3.zyxyz).
        /// </summary>
        public lvec5 bgrgb => new lvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.zyxz swizzling.
        /// </summary>
        public lvec4 zyxz => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.bgrb swizzling (equivalent to lvec3.zyxz).
        /// </summary>
        public lvec4 bgrb => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.zyxzx swizzling.
        /// </summary>
        public lvec5 zyxzx => new lvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.bgrbr swizzling (equivalent to lvec3.zyxzx).
        /// </summary>
        public lvec5 bgrbr => new lvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.zyxzy swizzling.
        /// </summary>
        public lvec5 zyxzy => new lvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.bgrbg swizzling (equivalent to lvec3.zyxzy).
        /// </summary>
        public lvec5 bgrbg => new lvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.zyxzz swizzling.
        /// </summary>
        public lvec5 zyxzz => new lvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.bgrbb swizzling (equivalent to lvec3.zyxzz).
        /// </summary>
        public lvec5 bgrbb => new lvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.zyy swizzling.
        /// </summary>
        public lvec3 zyy => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec3.bgg swizzling (equivalent to lvec3.zyy).
        /// </summary>
        public lvec3 bgg => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec3.zyyx swizzling.
        /// </summary>
        public lvec4 zyyx => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.bggr swizzling (equivalent to lvec3.zyyx).
        /// </summary>
        public lvec4 bggr => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.zyyxx swizzling.
        /// </summary>
        public lvec5 zyyxx => new lvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.bggrr swizzling (equivalent to lvec3.zyyxx).
        /// </summary>
        public lvec5 bggrr => new lvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.zyyxy swizzling.
        /// </summary>
        public lvec5 zyyxy => new lvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.bggrg swizzling (equivalent to lvec3.zyyxy).
        /// </summary>
        public lvec5 bggrg => new lvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.zyyxz swizzling.
        /// </summary>
        public lvec5 zyyxz => new lvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.bggrb swizzling (equivalent to lvec3.zyyxz).
        /// </summary>
        public lvec5 bggrb => new lvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.zyyy swizzling.
        /// </summary>
        public lvec4 zyyy => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.bggg swizzling (equivalent to lvec3.zyyy).
        /// </summary>
        public lvec4 bggg => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.zyyyx swizzling.
        /// </summary>
        public lvec5 zyyyx => new lvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.bgggr swizzling (equivalent to lvec3.zyyyx).
        /// </summary>
        public lvec5 bgggr => new lvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.zyyyy swizzling.
        /// </summary>
        public lvec5 zyyyy => new lvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.bgggg swizzling (equivalent to lvec3.zyyyy).
        /// </summary>
        public lvec5 bgggg => new lvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.zyyyz swizzling.
        /// </summary>
        public lvec5 zyyyz => new lvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.bgggb swizzling (equivalent to lvec3.zyyyz).
        /// </summary>
        public lvec5 bgggb => new lvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.zyyz swizzling.
        /// </summary>
        public lvec4 zyyz => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.bggb swizzling (equivalent to lvec3.zyyz).
        /// </summary>
        public lvec4 bggb => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.zyyzx swizzling.
        /// </summary>
        public lvec5 zyyzx => new lvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.bggbr swizzling (equivalent to lvec3.zyyzx).
        /// </summary>
        public lvec5 bggbr => new lvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.zyyzy swizzling.
        /// </summary>
        public lvec5 zyyzy => new lvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.bggbg swizzling (equivalent to lvec3.zyyzy).
        /// </summary>
        public lvec5 bggbg => new lvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.zyyzz swizzling.
        /// </summary>
        public lvec5 zyyzz => new lvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.bggbb swizzling (equivalent to lvec3.zyyzz).
        /// </summary>
        public lvec5 bggbb => new lvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.zyz swizzling.
        /// </summary>
        public lvec3 zyz => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec3.bgb swizzling (equivalent to lvec3.zyz).
        /// </summary>
        public lvec3 bgb => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec3.zyzx swizzling.
        /// </summary>
        public lvec4 zyzx => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.bgbr swizzling (equivalent to lvec3.zyzx).
        /// </summary>
        public lvec4 bgbr => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.zyzxx swizzling.
        /// </summary>
        public lvec5 zyzxx => new lvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.bgbrr swizzling (equivalent to lvec3.zyzxx).
        /// </summary>
        public lvec5 bgbrr => new lvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.zyzxy swizzling.
        /// </summary>
        public lvec5 zyzxy => new lvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.bgbrg swizzling (equivalent to lvec3.zyzxy).
        /// </summary>
        public lvec5 bgbrg => new lvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.zyzxz swizzling.
        /// </summary>
        public lvec5 zyzxz => new lvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.bgbrb swizzling (equivalent to lvec3.zyzxz).
        /// </summary>
        public lvec5 bgbrb => new lvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.zyzy swizzling.
        /// </summary>
        public lvec4 zyzy => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.bgbg swizzling (equivalent to lvec3.zyzy).
        /// </summary>
        public lvec4 bgbg => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.zyzyx swizzling.
        /// </summary>
        public lvec5 zyzyx => new lvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.bgbgr swizzling (equivalent to lvec3.zyzyx).
        /// </summary>
        public lvec5 bgbgr => new lvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.zyzyy swizzling.
        /// </summary>
        public lvec5 zyzyy => new lvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.bgbgg swizzling (equivalent to lvec3.zyzyy).
        /// </summary>
        public lvec5 bgbgg => new lvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.zyzyz swizzling.
        /// </summary>
        public lvec5 zyzyz => new lvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.bgbgb swizzling (equivalent to lvec3.zyzyz).
        /// </summary>
        public lvec5 bgbgb => new lvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.zyzz swizzling.
        /// </summary>
        public lvec4 zyzz => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.bgbb swizzling (equivalent to lvec3.zyzz).
        /// </summary>
        public lvec4 bgbb => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.zyzzx swizzling.
        /// </summary>
        public lvec5 zyzzx => new lvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.bgbbr swizzling (equivalent to lvec3.zyzzx).
        /// </summary>
        public lvec5 bgbbr => new lvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.zyzzy swizzling.
        /// </summary>
        public lvec5 zyzzy => new lvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.bgbbg swizzling (equivalent to lvec3.zyzzy).
        /// </summary>
        public lvec5 bgbbg => new lvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.zyzzz swizzling.
        /// </summary>
        public lvec5 zyzzz => new lvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.bgbbb swizzling (equivalent to lvec3.zyzzz).
        /// </summary>
        public lvec5 bgbbb => new lvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.zz swizzling.
        /// </summary>
        public lvec2 zz => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec3.bb swizzling (equivalent to lvec3.zz).
        /// </summary>
        public lvec2 bb => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec3.zzx swizzling.
        /// </summary>
        public lvec3 zzx => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec3.bbr swizzling (equivalent to lvec3.zzx).
        /// </summary>
        public lvec3 bbr => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec3.zzxx swizzling.
        /// </summary>
        public lvec4 zzxx => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.bbrr swizzling (equivalent to lvec3.zzxx).
        /// </summary>
        public lvec4 bbrr => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.zzxxx swizzling.
        /// </summary>
        public lvec5 zzxxx => new lvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.bbrrr swizzling (equivalent to lvec3.zzxxx).
        /// </summary>
        public lvec5 bbrrr => new lvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.zzxxy swizzling.
        /// </summary>
        public lvec5 zzxxy => new lvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.bbrrg swizzling (equivalent to lvec3.zzxxy).
        /// </summary>
        public lvec5 bbrrg => new lvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.zzxxz swizzling.
        /// </summary>
        public lvec5 zzxxz => new lvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.bbrrb swizzling (equivalent to lvec3.zzxxz).
        /// </summary>
        public lvec5 bbrrb => new lvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.zzxy swizzling.
        /// </summary>
        public lvec4 zzxy => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.bbrg swizzling (equivalent to lvec3.zzxy).
        /// </summary>
        public lvec4 bbrg => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.zzxyx swizzling.
        /// </summary>
        public lvec5 zzxyx => new lvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.bbrgr swizzling (equivalent to lvec3.zzxyx).
        /// </summary>
        public lvec5 bbrgr => new lvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.zzxyy swizzling.
        /// </summary>
        public lvec5 zzxyy => new lvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.bbrgg swizzling (equivalent to lvec3.zzxyy).
        /// </summary>
        public lvec5 bbrgg => new lvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.zzxyz swizzling.
        /// </summary>
        public lvec5 zzxyz => new lvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.bbrgb swizzling (equivalent to lvec3.zzxyz).
        /// </summary>
        public lvec5 bbrgb => new lvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.zzxz swizzling.
        /// </summary>
        public lvec4 zzxz => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.bbrb swizzling (equivalent to lvec3.zzxz).
        /// </summary>
        public lvec4 bbrb => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.zzxzx swizzling.
        /// </summary>
        public lvec5 zzxzx => new lvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.bbrbr swizzling (equivalent to lvec3.zzxzx).
        /// </summary>
        public lvec5 bbrbr => new lvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.zzxzy swizzling.
        /// </summary>
        public lvec5 zzxzy => new lvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.bbrbg swizzling (equivalent to lvec3.zzxzy).
        /// </summary>
        public lvec5 bbrbg => new lvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.zzxzz swizzling.
        /// </summary>
        public lvec5 zzxzz => new lvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.bbrbb swizzling (equivalent to lvec3.zzxzz).
        /// </summary>
        public lvec5 bbrbb => new lvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.zzy swizzling.
        /// </summary>
        public lvec3 zzy => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec3.bbg swizzling (equivalent to lvec3.zzy).
        /// </summary>
        public lvec3 bbg => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec3.zzyx swizzling.
        /// </summary>
        public lvec4 zzyx => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.bbgr swizzling (equivalent to lvec3.zzyx).
        /// </summary>
        public lvec4 bbgr => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.zzyxx swizzling.
        /// </summary>
        public lvec5 zzyxx => new lvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.bbgrr swizzling (equivalent to lvec3.zzyxx).
        /// </summary>
        public lvec5 bbgrr => new lvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.zzyxy swizzling.
        /// </summary>
        public lvec5 zzyxy => new lvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.bbgrg swizzling (equivalent to lvec3.zzyxy).
        /// </summary>
        public lvec5 bbgrg => new lvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.zzyxz swizzling.
        /// </summary>
        public lvec5 zzyxz => new lvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.bbgrb swizzling (equivalent to lvec3.zzyxz).
        /// </summary>
        public lvec5 bbgrb => new lvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.zzyy swizzling.
        /// </summary>
        public lvec4 zzyy => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.bbgg swizzling (equivalent to lvec3.zzyy).
        /// </summary>
        public lvec4 bbgg => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.zzyyx swizzling.
        /// </summary>
        public lvec5 zzyyx => new lvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.bbggr swizzling (equivalent to lvec3.zzyyx).
        /// </summary>
        public lvec5 bbggr => new lvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.zzyyy swizzling.
        /// </summary>
        public lvec5 zzyyy => new lvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.bbggg swizzling (equivalent to lvec3.zzyyy).
        /// </summary>
        public lvec5 bbggg => new lvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.zzyyz swizzling.
        /// </summary>
        public lvec5 zzyyz => new lvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.bbggb swizzling (equivalent to lvec3.zzyyz).
        /// </summary>
        public lvec5 bbggb => new lvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.zzyz swizzling.
        /// </summary>
        public lvec4 zzyz => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.bbgb swizzling (equivalent to lvec3.zzyz).
        /// </summary>
        public lvec4 bbgb => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.zzyzx swizzling.
        /// </summary>
        public lvec5 zzyzx => new lvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.bbgbr swizzling (equivalent to lvec3.zzyzx).
        /// </summary>
        public lvec5 bbgbr => new lvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.zzyzy swizzling.
        /// </summary>
        public lvec5 zzyzy => new lvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.bbgbg swizzling (equivalent to lvec3.zzyzy).
        /// </summary>
        public lvec5 bbgbg => new lvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.zzyzz swizzling.
        /// </summary>
        public lvec5 zzyzz => new lvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.bbgbb swizzling (equivalent to lvec3.zzyzz).
        /// </summary>
        public lvec5 bbgbb => new lvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.zzz swizzling.
        /// </summary>
        public lvec3 zzz => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec3.bbb swizzling (equivalent to lvec3.zzz).
        /// </summary>
        public lvec3 bbb => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec3.zzzx swizzling.
        /// </summary>
        public lvec4 zzzx => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.bbbr swizzling (equivalent to lvec3.zzzx).
        /// </summary>
        public lvec4 bbbr => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.zzzxx swizzling.
        /// </summary>
        public lvec5 zzzxx => new lvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.bbbrr swizzling (equivalent to lvec3.zzzxx).
        /// </summary>
        public lvec5 bbbrr => new lvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.zzzxy swizzling.
        /// </summary>
        public lvec5 zzzxy => new lvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.bbbrg swizzling (equivalent to lvec3.zzzxy).
        /// </summary>
        public lvec5 bbbrg => new lvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.zzzxz swizzling.
        /// </summary>
        public lvec5 zzzxz => new lvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.bbbrb swizzling (equivalent to lvec3.zzzxz).
        /// </summary>
        public lvec5 bbbrb => new lvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.zzzy swizzling.
        /// </summary>
        public lvec4 zzzy => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.bbbg swizzling (equivalent to lvec3.zzzy).
        /// </summary>
        public lvec4 bbbg => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.zzzyx swizzling.
        /// </summary>
        public lvec5 zzzyx => new lvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.bbbgr swizzling (equivalent to lvec3.zzzyx).
        /// </summary>
        public lvec5 bbbgr => new lvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.zzzyy swizzling.
        /// </summary>
        public lvec5 zzzyy => new lvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.bbbgg swizzling (equivalent to lvec3.zzzyy).
        /// </summary>
        public lvec5 bbbgg => new lvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.zzzyz swizzling.
        /// </summary>
        public lvec5 zzzyz => new lvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.bbbgb swizzling (equivalent to lvec3.zzzyz).
        /// </summary>
        public lvec5 bbbgb => new lvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.zzzz swizzling.
        /// </summary>
        public lvec4 zzzz => new lvec4(z, z, z, z);
        
        /// <summary>
        /// Returns lvec3.bbbb swizzling (equivalent to lvec3.zzzz).
        /// </summary>
        public lvec4 bbbb => new lvec4(z, z, z, z);
        
        /// <summary>
        /// Returns lvec3.zzzzx swizzling.
        /// </summary>
        public lvec5 zzzzx => new lvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.bbbbr swizzling (equivalent to lvec3.zzzzx).
        /// </summary>
        public lvec5 bbbbr => new lvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.zzzzy swizzling.
        /// </summary>
        public lvec5 zzzzy => new lvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.bbbbg swizzling (equivalent to lvec3.zzzzy).
        /// </summary>
        public lvec5 bbbbg => new lvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.zzzzz swizzling.
        /// </summary>
        public lvec5 zzzzz => new lvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns lvec3.bbbbb swizzling (equivalent to lvec3.zzzzz).
        /// </summary>
        public lvec5 bbbbb => new lvec5(z, z, z, z, z);

        #endregion

    }
}
