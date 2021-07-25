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
    /// Temporary vector of type T with 3 components, used for implementing swizzling for gvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_gvec3<T>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly T x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly T y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly T z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_gvec3.
        /// </summary>
        internal swizzle_gvec3(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns gvec3.xx swizzling.
        /// </summary>
        public gvec2<T> xx => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec3.rr swizzling (equivalent to gvec3.xx).
        /// </summary>
        public gvec2<T> rr => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec3.xxx swizzling.
        /// </summary>
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec3.rrr swizzling (equivalent to gvec3.xxx).
        /// </summary>
        public gvec3<T> rrr => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec3.xxxx swizzling.
        /// </summary>
        public gvec4<T> xxxx => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.rrrr swizzling (equivalent to gvec3.xxxx).
        /// </summary>
        public gvec4<T> rrrr => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.xxxxx swizzling.
        /// </summary>
        public gvec5<T> xxxxx => new gvec5<T>(x, x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.rrrrr swizzling (equivalent to gvec3.xxxxx).
        /// </summary>
        public gvec5<T> rrrrr => new gvec5<T>(x, x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.xxxxy swizzling.
        /// </summary>
        public gvec5<T> xxxxy => new gvec5<T>(x, x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.rrrrg swizzling (equivalent to gvec3.xxxxy).
        /// </summary>
        public gvec5<T> rrrrg => new gvec5<T>(x, x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.xxxxz swizzling.
        /// </summary>
        public gvec5<T> xxxxz => new gvec5<T>(x, x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.rrrrb swizzling (equivalent to gvec3.xxxxz).
        /// </summary>
        public gvec5<T> rrrrb => new gvec5<T>(x, x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.xxxy swizzling.
        /// </summary>
        public gvec4<T> xxxy => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.rrrg swizzling (equivalent to gvec3.xxxy).
        /// </summary>
        public gvec4<T> rrrg => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.xxxyx swizzling.
        /// </summary>
        public gvec5<T> xxxyx => new gvec5<T>(x, x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.rrrgr swizzling (equivalent to gvec3.xxxyx).
        /// </summary>
        public gvec5<T> rrrgr => new gvec5<T>(x, x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.xxxyy swizzling.
        /// </summary>
        public gvec5<T> xxxyy => new gvec5<T>(x, x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.rrrgg swizzling (equivalent to gvec3.xxxyy).
        /// </summary>
        public gvec5<T> rrrgg => new gvec5<T>(x, x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.xxxyz swizzling.
        /// </summary>
        public gvec5<T> xxxyz => new gvec5<T>(x, x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.rrrgb swizzling (equivalent to gvec3.xxxyz).
        /// </summary>
        public gvec5<T> rrrgb => new gvec5<T>(x, x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.xxxz swizzling.
        /// </summary>
        public gvec4<T> xxxz => new gvec4<T>(x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.rrrb swizzling (equivalent to gvec3.xxxz).
        /// </summary>
        public gvec4<T> rrrb => new gvec4<T>(x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.xxxzx swizzling.
        /// </summary>
        public gvec5<T> xxxzx => new gvec5<T>(x, x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.rrrbr swizzling (equivalent to gvec3.xxxzx).
        /// </summary>
        public gvec5<T> rrrbr => new gvec5<T>(x, x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.xxxzy swizzling.
        /// </summary>
        public gvec5<T> xxxzy => new gvec5<T>(x, x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.rrrbg swizzling (equivalent to gvec3.xxxzy).
        /// </summary>
        public gvec5<T> rrrbg => new gvec5<T>(x, x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.xxxzz swizzling.
        /// </summary>
        public gvec5<T> xxxzz => new gvec5<T>(x, x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.rrrbb swizzling (equivalent to gvec3.xxxzz).
        /// </summary>
        public gvec5<T> rrrbb => new gvec5<T>(x, x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.xxy swizzling.
        /// </summary>
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec3.rrg swizzling (equivalent to gvec3.xxy).
        /// </summary>
        public gvec3<T> rrg => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec3.xxyx swizzling.
        /// </summary>
        public gvec4<T> xxyx => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.rrgr swizzling (equivalent to gvec3.xxyx).
        /// </summary>
        public gvec4<T> rrgr => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.xxyxx swizzling.
        /// </summary>
        public gvec5<T> xxyxx => new gvec5<T>(x, x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.rrgrr swizzling (equivalent to gvec3.xxyxx).
        /// </summary>
        public gvec5<T> rrgrr => new gvec5<T>(x, x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.xxyxy swizzling.
        /// </summary>
        public gvec5<T> xxyxy => new gvec5<T>(x, x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.rrgrg swizzling (equivalent to gvec3.xxyxy).
        /// </summary>
        public gvec5<T> rrgrg => new gvec5<T>(x, x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.xxyxz swizzling.
        /// </summary>
        public gvec5<T> xxyxz => new gvec5<T>(x, x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.rrgrb swizzling (equivalent to gvec3.xxyxz).
        /// </summary>
        public gvec5<T> rrgrb => new gvec5<T>(x, x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.xxyy swizzling.
        /// </summary>
        public gvec4<T> xxyy => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.rrgg swizzling (equivalent to gvec3.xxyy).
        /// </summary>
        public gvec4<T> rrgg => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.xxyyx swizzling.
        /// </summary>
        public gvec5<T> xxyyx => new gvec5<T>(x, x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.rrggr swizzling (equivalent to gvec3.xxyyx).
        /// </summary>
        public gvec5<T> rrggr => new gvec5<T>(x, x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.xxyyy swizzling.
        /// </summary>
        public gvec5<T> xxyyy => new gvec5<T>(x, x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.rrggg swizzling (equivalent to gvec3.xxyyy).
        /// </summary>
        public gvec5<T> rrggg => new gvec5<T>(x, x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.xxyyz swizzling.
        /// </summary>
        public gvec5<T> xxyyz => new gvec5<T>(x, x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.rrggb swizzling (equivalent to gvec3.xxyyz).
        /// </summary>
        public gvec5<T> rrggb => new gvec5<T>(x, x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.xxyz swizzling.
        /// </summary>
        public gvec4<T> xxyz => new gvec4<T>(x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.rrgb swizzling (equivalent to gvec3.xxyz).
        /// </summary>
        public gvec4<T> rrgb => new gvec4<T>(x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.xxyzx swizzling.
        /// </summary>
        public gvec5<T> xxyzx => new gvec5<T>(x, x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.rrgbr swizzling (equivalent to gvec3.xxyzx).
        /// </summary>
        public gvec5<T> rrgbr => new gvec5<T>(x, x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.xxyzy swizzling.
        /// </summary>
        public gvec5<T> xxyzy => new gvec5<T>(x, x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.rrgbg swizzling (equivalent to gvec3.xxyzy).
        /// </summary>
        public gvec5<T> rrgbg => new gvec5<T>(x, x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.xxyzz swizzling.
        /// </summary>
        public gvec5<T> xxyzz => new gvec5<T>(x, x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.rrgbb swizzling (equivalent to gvec3.xxyzz).
        /// </summary>
        public gvec5<T> rrgbb => new gvec5<T>(x, x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.xxz swizzling.
        /// </summary>
        public gvec3<T> xxz => new gvec3<T>(x, x, z);
        
        /// <summary>
        /// Returns gvec3.rrb swizzling (equivalent to gvec3.xxz).
        /// </summary>
        public gvec3<T> rrb => new gvec3<T>(x, x, z);
        
        /// <summary>
        /// Returns gvec3.xxzx swizzling.
        /// </summary>
        public gvec4<T> xxzx => new gvec4<T>(x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.rrbr swizzling (equivalent to gvec3.xxzx).
        /// </summary>
        public gvec4<T> rrbr => new gvec4<T>(x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.xxzxx swizzling.
        /// </summary>
        public gvec5<T> xxzxx => new gvec5<T>(x, x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.rrbrr swizzling (equivalent to gvec3.xxzxx).
        /// </summary>
        public gvec5<T> rrbrr => new gvec5<T>(x, x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.xxzxy swizzling.
        /// </summary>
        public gvec5<T> xxzxy => new gvec5<T>(x, x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.rrbrg swizzling (equivalent to gvec3.xxzxy).
        /// </summary>
        public gvec5<T> rrbrg => new gvec5<T>(x, x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.xxzxz swizzling.
        /// </summary>
        public gvec5<T> xxzxz => new gvec5<T>(x, x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.rrbrb swizzling (equivalent to gvec3.xxzxz).
        /// </summary>
        public gvec5<T> rrbrb => new gvec5<T>(x, x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.xxzy swizzling.
        /// </summary>
        public gvec4<T> xxzy => new gvec4<T>(x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.rrbg swizzling (equivalent to gvec3.xxzy).
        /// </summary>
        public gvec4<T> rrbg => new gvec4<T>(x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.xxzyx swizzling.
        /// </summary>
        public gvec5<T> xxzyx => new gvec5<T>(x, x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.rrbgr swizzling (equivalent to gvec3.xxzyx).
        /// </summary>
        public gvec5<T> rrbgr => new gvec5<T>(x, x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.xxzyy swizzling.
        /// </summary>
        public gvec5<T> xxzyy => new gvec5<T>(x, x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.rrbgg swizzling (equivalent to gvec3.xxzyy).
        /// </summary>
        public gvec5<T> rrbgg => new gvec5<T>(x, x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.xxzyz swizzling.
        /// </summary>
        public gvec5<T> xxzyz => new gvec5<T>(x, x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.rrbgb swizzling (equivalent to gvec3.xxzyz).
        /// </summary>
        public gvec5<T> rrbgb => new gvec5<T>(x, x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.xxzz swizzling.
        /// </summary>
        public gvec4<T> xxzz => new gvec4<T>(x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.rrbb swizzling (equivalent to gvec3.xxzz).
        /// </summary>
        public gvec4<T> rrbb => new gvec4<T>(x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.xxzzx swizzling.
        /// </summary>
        public gvec5<T> xxzzx => new gvec5<T>(x, x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.rrbbr swizzling (equivalent to gvec3.xxzzx).
        /// </summary>
        public gvec5<T> rrbbr => new gvec5<T>(x, x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.xxzzy swizzling.
        /// </summary>
        public gvec5<T> xxzzy => new gvec5<T>(x, x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.rrbbg swizzling (equivalent to gvec3.xxzzy).
        /// </summary>
        public gvec5<T> rrbbg => new gvec5<T>(x, x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.xxzzz swizzling.
        /// </summary>
        public gvec5<T> xxzzz => new gvec5<T>(x, x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.rrbbb swizzling (equivalent to gvec3.xxzzz).
        /// </summary>
        public gvec5<T> rrbbb => new gvec5<T>(x, x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.xy swizzling.
        /// </summary>
        public gvec2<T> xy => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec3.rg swizzling (equivalent to gvec3.xy).
        /// </summary>
        public gvec2<T> rg => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec3.xyx swizzling.
        /// </summary>
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec3.rgr swizzling (equivalent to gvec3.xyx).
        /// </summary>
        public gvec3<T> rgr => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec3.xyxx swizzling.
        /// </summary>
        public gvec4<T> xyxx => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.rgrr swizzling (equivalent to gvec3.xyxx).
        /// </summary>
        public gvec4<T> rgrr => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.xyxxx swizzling.
        /// </summary>
        public gvec5<T> xyxxx => new gvec5<T>(x, y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.rgrrr swizzling (equivalent to gvec3.xyxxx).
        /// </summary>
        public gvec5<T> rgrrr => new gvec5<T>(x, y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.xyxxy swizzling.
        /// </summary>
        public gvec5<T> xyxxy => new gvec5<T>(x, y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.rgrrg swizzling (equivalent to gvec3.xyxxy).
        /// </summary>
        public gvec5<T> rgrrg => new gvec5<T>(x, y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.xyxxz swizzling.
        /// </summary>
        public gvec5<T> xyxxz => new gvec5<T>(x, y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.rgrrb swizzling (equivalent to gvec3.xyxxz).
        /// </summary>
        public gvec5<T> rgrrb => new gvec5<T>(x, y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.xyxy swizzling.
        /// </summary>
        public gvec4<T> xyxy => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.rgrg swizzling (equivalent to gvec3.xyxy).
        /// </summary>
        public gvec4<T> rgrg => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.xyxyx swizzling.
        /// </summary>
        public gvec5<T> xyxyx => new gvec5<T>(x, y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.rgrgr swizzling (equivalent to gvec3.xyxyx).
        /// </summary>
        public gvec5<T> rgrgr => new gvec5<T>(x, y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.xyxyy swizzling.
        /// </summary>
        public gvec5<T> xyxyy => new gvec5<T>(x, y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.rgrgg swizzling (equivalent to gvec3.xyxyy).
        /// </summary>
        public gvec5<T> rgrgg => new gvec5<T>(x, y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.xyxyz swizzling.
        /// </summary>
        public gvec5<T> xyxyz => new gvec5<T>(x, y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.rgrgb swizzling (equivalent to gvec3.xyxyz).
        /// </summary>
        public gvec5<T> rgrgb => new gvec5<T>(x, y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.xyxz swizzling.
        /// </summary>
        public gvec4<T> xyxz => new gvec4<T>(x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.rgrb swizzling (equivalent to gvec3.xyxz).
        /// </summary>
        public gvec4<T> rgrb => new gvec4<T>(x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.xyxzx swizzling.
        /// </summary>
        public gvec5<T> xyxzx => new gvec5<T>(x, y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.rgrbr swizzling (equivalent to gvec3.xyxzx).
        /// </summary>
        public gvec5<T> rgrbr => new gvec5<T>(x, y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.xyxzy swizzling.
        /// </summary>
        public gvec5<T> xyxzy => new gvec5<T>(x, y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.rgrbg swizzling (equivalent to gvec3.xyxzy).
        /// </summary>
        public gvec5<T> rgrbg => new gvec5<T>(x, y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.xyxzz swizzling.
        /// </summary>
        public gvec5<T> xyxzz => new gvec5<T>(x, y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.rgrbb swizzling (equivalent to gvec3.xyxzz).
        /// </summary>
        public gvec5<T> rgrbb => new gvec5<T>(x, y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.xyy swizzling.
        /// </summary>
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec3.rgg swizzling (equivalent to gvec3.xyy).
        /// </summary>
        public gvec3<T> rgg => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec3.xyyx swizzling.
        /// </summary>
        public gvec4<T> xyyx => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.rggr swizzling (equivalent to gvec3.xyyx).
        /// </summary>
        public gvec4<T> rggr => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.xyyxx swizzling.
        /// </summary>
        public gvec5<T> xyyxx => new gvec5<T>(x, y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.rggrr swizzling (equivalent to gvec3.xyyxx).
        /// </summary>
        public gvec5<T> rggrr => new gvec5<T>(x, y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.xyyxy swizzling.
        /// </summary>
        public gvec5<T> xyyxy => new gvec5<T>(x, y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.rggrg swizzling (equivalent to gvec3.xyyxy).
        /// </summary>
        public gvec5<T> rggrg => new gvec5<T>(x, y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.xyyxz swizzling.
        /// </summary>
        public gvec5<T> xyyxz => new gvec5<T>(x, y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.rggrb swizzling (equivalent to gvec3.xyyxz).
        /// </summary>
        public gvec5<T> rggrb => new gvec5<T>(x, y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.xyyy swizzling.
        /// </summary>
        public gvec4<T> xyyy => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.rggg swizzling (equivalent to gvec3.xyyy).
        /// </summary>
        public gvec4<T> rggg => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.xyyyx swizzling.
        /// </summary>
        public gvec5<T> xyyyx => new gvec5<T>(x, y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.rgggr swizzling (equivalent to gvec3.xyyyx).
        /// </summary>
        public gvec5<T> rgggr => new gvec5<T>(x, y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.xyyyy swizzling.
        /// </summary>
        public gvec5<T> xyyyy => new gvec5<T>(x, y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.rgggg swizzling (equivalent to gvec3.xyyyy).
        /// </summary>
        public gvec5<T> rgggg => new gvec5<T>(x, y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.xyyyz swizzling.
        /// </summary>
        public gvec5<T> xyyyz => new gvec5<T>(x, y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.rgggb swizzling (equivalent to gvec3.xyyyz).
        /// </summary>
        public gvec5<T> rgggb => new gvec5<T>(x, y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.xyyz swizzling.
        /// </summary>
        public gvec4<T> xyyz => new gvec4<T>(x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.rggb swizzling (equivalent to gvec3.xyyz).
        /// </summary>
        public gvec4<T> rggb => new gvec4<T>(x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.xyyzx swizzling.
        /// </summary>
        public gvec5<T> xyyzx => new gvec5<T>(x, y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.rggbr swizzling (equivalent to gvec3.xyyzx).
        /// </summary>
        public gvec5<T> rggbr => new gvec5<T>(x, y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.xyyzy swizzling.
        /// </summary>
        public gvec5<T> xyyzy => new gvec5<T>(x, y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.rggbg swizzling (equivalent to gvec3.xyyzy).
        /// </summary>
        public gvec5<T> rggbg => new gvec5<T>(x, y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.xyyzz swizzling.
        /// </summary>
        public gvec5<T> xyyzz => new gvec5<T>(x, y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.rggbb swizzling (equivalent to gvec3.xyyzz).
        /// </summary>
        public gvec5<T> rggbb => new gvec5<T>(x, y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.xyz swizzling.
        /// </summary>
        public gvec3<T> xyz => new gvec3<T>(x, y, z);
        
        /// <summary>
        /// Returns gvec3.rgb swizzling (equivalent to gvec3.xyz).
        /// </summary>
        public gvec3<T> rgb => new gvec3<T>(x, y, z);
        
        /// <summary>
        /// Returns gvec3.xyzx swizzling.
        /// </summary>
        public gvec4<T> xyzx => new gvec4<T>(x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.rgbr swizzling (equivalent to gvec3.xyzx).
        /// </summary>
        public gvec4<T> rgbr => new gvec4<T>(x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.xyzxx swizzling.
        /// </summary>
        public gvec5<T> xyzxx => new gvec5<T>(x, y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.rgbrr swizzling (equivalent to gvec3.xyzxx).
        /// </summary>
        public gvec5<T> rgbrr => new gvec5<T>(x, y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.xyzxy swizzling.
        /// </summary>
        public gvec5<T> xyzxy => new gvec5<T>(x, y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.rgbrg swizzling (equivalent to gvec3.xyzxy).
        /// </summary>
        public gvec5<T> rgbrg => new gvec5<T>(x, y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.xyzxz swizzling.
        /// </summary>
        public gvec5<T> xyzxz => new gvec5<T>(x, y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.rgbrb swizzling (equivalent to gvec3.xyzxz).
        /// </summary>
        public gvec5<T> rgbrb => new gvec5<T>(x, y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.xyzy swizzling.
        /// </summary>
        public gvec4<T> xyzy => new gvec4<T>(x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.rgbg swizzling (equivalent to gvec3.xyzy).
        /// </summary>
        public gvec4<T> rgbg => new gvec4<T>(x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.xyzyx swizzling.
        /// </summary>
        public gvec5<T> xyzyx => new gvec5<T>(x, y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.rgbgr swizzling (equivalent to gvec3.xyzyx).
        /// </summary>
        public gvec5<T> rgbgr => new gvec5<T>(x, y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.xyzyy swizzling.
        /// </summary>
        public gvec5<T> xyzyy => new gvec5<T>(x, y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.rgbgg swizzling (equivalent to gvec3.xyzyy).
        /// </summary>
        public gvec5<T> rgbgg => new gvec5<T>(x, y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.xyzyz swizzling.
        /// </summary>
        public gvec5<T> xyzyz => new gvec5<T>(x, y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.rgbgb swizzling (equivalent to gvec3.xyzyz).
        /// </summary>
        public gvec5<T> rgbgb => new gvec5<T>(x, y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.xyzz swizzling.
        /// </summary>
        public gvec4<T> xyzz => new gvec4<T>(x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.rgbb swizzling (equivalent to gvec3.xyzz).
        /// </summary>
        public gvec4<T> rgbb => new gvec4<T>(x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.xyzzx swizzling.
        /// </summary>
        public gvec5<T> xyzzx => new gvec5<T>(x, y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.rgbbr swizzling (equivalent to gvec3.xyzzx).
        /// </summary>
        public gvec5<T> rgbbr => new gvec5<T>(x, y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.xyzzy swizzling.
        /// </summary>
        public gvec5<T> xyzzy => new gvec5<T>(x, y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.rgbbg swizzling (equivalent to gvec3.xyzzy).
        /// </summary>
        public gvec5<T> rgbbg => new gvec5<T>(x, y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.xyzzz swizzling.
        /// </summary>
        public gvec5<T> xyzzz => new gvec5<T>(x, y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.rgbbb swizzling (equivalent to gvec3.xyzzz).
        /// </summary>
        public gvec5<T> rgbbb => new gvec5<T>(x, y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.xz swizzling.
        /// </summary>
        public gvec2<T> xz => new gvec2<T>(x, z);
        
        /// <summary>
        /// Returns gvec3.rb swizzling (equivalent to gvec3.xz).
        /// </summary>
        public gvec2<T> rb => new gvec2<T>(x, z);
        
        /// <summary>
        /// Returns gvec3.xzx swizzling.
        /// </summary>
        public gvec3<T> xzx => new gvec3<T>(x, z, x);
        
        /// <summary>
        /// Returns gvec3.rbr swizzling (equivalent to gvec3.xzx).
        /// </summary>
        public gvec3<T> rbr => new gvec3<T>(x, z, x);
        
        /// <summary>
        /// Returns gvec3.xzxx swizzling.
        /// </summary>
        public gvec4<T> xzxx => new gvec4<T>(x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.rbrr swizzling (equivalent to gvec3.xzxx).
        /// </summary>
        public gvec4<T> rbrr => new gvec4<T>(x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.xzxxx swizzling.
        /// </summary>
        public gvec5<T> xzxxx => new gvec5<T>(x, z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.rbrrr swizzling (equivalent to gvec3.xzxxx).
        /// </summary>
        public gvec5<T> rbrrr => new gvec5<T>(x, z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.xzxxy swizzling.
        /// </summary>
        public gvec5<T> xzxxy => new gvec5<T>(x, z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.rbrrg swizzling (equivalent to gvec3.xzxxy).
        /// </summary>
        public gvec5<T> rbrrg => new gvec5<T>(x, z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.xzxxz swizzling.
        /// </summary>
        public gvec5<T> xzxxz => new gvec5<T>(x, z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.rbrrb swizzling (equivalent to gvec3.xzxxz).
        /// </summary>
        public gvec5<T> rbrrb => new gvec5<T>(x, z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.xzxy swizzling.
        /// </summary>
        public gvec4<T> xzxy => new gvec4<T>(x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.rbrg swizzling (equivalent to gvec3.xzxy).
        /// </summary>
        public gvec4<T> rbrg => new gvec4<T>(x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.xzxyx swizzling.
        /// </summary>
        public gvec5<T> xzxyx => new gvec5<T>(x, z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.rbrgr swizzling (equivalent to gvec3.xzxyx).
        /// </summary>
        public gvec5<T> rbrgr => new gvec5<T>(x, z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.xzxyy swizzling.
        /// </summary>
        public gvec5<T> xzxyy => new gvec5<T>(x, z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.rbrgg swizzling (equivalent to gvec3.xzxyy).
        /// </summary>
        public gvec5<T> rbrgg => new gvec5<T>(x, z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.xzxyz swizzling.
        /// </summary>
        public gvec5<T> xzxyz => new gvec5<T>(x, z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.rbrgb swizzling (equivalent to gvec3.xzxyz).
        /// </summary>
        public gvec5<T> rbrgb => new gvec5<T>(x, z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.xzxz swizzling.
        /// </summary>
        public gvec4<T> xzxz => new gvec4<T>(x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.rbrb swizzling (equivalent to gvec3.xzxz).
        /// </summary>
        public gvec4<T> rbrb => new gvec4<T>(x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.xzxzx swizzling.
        /// </summary>
        public gvec5<T> xzxzx => new gvec5<T>(x, z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.rbrbr swizzling (equivalent to gvec3.xzxzx).
        /// </summary>
        public gvec5<T> rbrbr => new gvec5<T>(x, z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.xzxzy swizzling.
        /// </summary>
        public gvec5<T> xzxzy => new gvec5<T>(x, z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.rbrbg swizzling (equivalent to gvec3.xzxzy).
        /// </summary>
        public gvec5<T> rbrbg => new gvec5<T>(x, z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.xzxzz swizzling.
        /// </summary>
        public gvec5<T> xzxzz => new gvec5<T>(x, z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.rbrbb swizzling (equivalent to gvec3.xzxzz).
        /// </summary>
        public gvec5<T> rbrbb => new gvec5<T>(x, z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.xzy swizzling.
        /// </summary>
        public gvec3<T> xzy => new gvec3<T>(x, z, y);
        
        /// <summary>
        /// Returns gvec3.rbg swizzling (equivalent to gvec3.xzy).
        /// </summary>
        public gvec3<T> rbg => new gvec3<T>(x, z, y);
        
        /// <summary>
        /// Returns gvec3.xzyx swizzling.
        /// </summary>
        public gvec4<T> xzyx => new gvec4<T>(x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.rbgr swizzling (equivalent to gvec3.xzyx).
        /// </summary>
        public gvec4<T> rbgr => new gvec4<T>(x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.xzyxx swizzling.
        /// </summary>
        public gvec5<T> xzyxx => new gvec5<T>(x, z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.rbgrr swizzling (equivalent to gvec3.xzyxx).
        /// </summary>
        public gvec5<T> rbgrr => new gvec5<T>(x, z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.xzyxy swizzling.
        /// </summary>
        public gvec5<T> xzyxy => new gvec5<T>(x, z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.rbgrg swizzling (equivalent to gvec3.xzyxy).
        /// </summary>
        public gvec5<T> rbgrg => new gvec5<T>(x, z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.xzyxz swizzling.
        /// </summary>
        public gvec5<T> xzyxz => new gvec5<T>(x, z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.rbgrb swizzling (equivalent to gvec3.xzyxz).
        /// </summary>
        public gvec5<T> rbgrb => new gvec5<T>(x, z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.xzyy swizzling.
        /// </summary>
        public gvec4<T> xzyy => new gvec4<T>(x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.rbgg swizzling (equivalent to gvec3.xzyy).
        /// </summary>
        public gvec4<T> rbgg => new gvec4<T>(x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.xzyyx swizzling.
        /// </summary>
        public gvec5<T> xzyyx => new gvec5<T>(x, z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.rbggr swizzling (equivalent to gvec3.xzyyx).
        /// </summary>
        public gvec5<T> rbggr => new gvec5<T>(x, z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.xzyyy swizzling.
        /// </summary>
        public gvec5<T> xzyyy => new gvec5<T>(x, z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.rbggg swizzling (equivalent to gvec3.xzyyy).
        /// </summary>
        public gvec5<T> rbggg => new gvec5<T>(x, z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.xzyyz swizzling.
        /// </summary>
        public gvec5<T> xzyyz => new gvec5<T>(x, z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.rbggb swizzling (equivalent to gvec3.xzyyz).
        /// </summary>
        public gvec5<T> rbggb => new gvec5<T>(x, z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.xzyz swizzling.
        /// </summary>
        public gvec4<T> xzyz => new gvec4<T>(x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.rbgb swizzling (equivalent to gvec3.xzyz).
        /// </summary>
        public gvec4<T> rbgb => new gvec4<T>(x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.xzyzx swizzling.
        /// </summary>
        public gvec5<T> xzyzx => new gvec5<T>(x, z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.rbgbr swizzling (equivalent to gvec3.xzyzx).
        /// </summary>
        public gvec5<T> rbgbr => new gvec5<T>(x, z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.xzyzy swizzling.
        /// </summary>
        public gvec5<T> xzyzy => new gvec5<T>(x, z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.rbgbg swizzling (equivalent to gvec3.xzyzy).
        /// </summary>
        public gvec5<T> rbgbg => new gvec5<T>(x, z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.xzyzz swizzling.
        /// </summary>
        public gvec5<T> xzyzz => new gvec5<T>(x, z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.rbgbb swizzling (equivalent to gvec3.xzyzz).
        /// </summary>
        public gvec5<T> rbgbb => new gvec5<T>(x, z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.xzz swizzling.
        /// </summary>
        public gvec3<T> xzz => new gvec3<T>(x, z, z);
        
        /// <summary>
        /// Returns gvec3.rbb swizzling (equivalent to gvec3.xzz).
        /// </summary>
        public gvec3<T> rbb => new gvec3<T>(x, z, z);
        
        /// <summary>
        /// Returns gvec3.xzzx swizzling.
        /// </summary>
        public gvec4<T> xzzx => new gvec4<T>(x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.rbbr swizzling (equivalent to gvec3.xzzx).
        /// </summary>
        public gvec4<T> rbbr => new gvec4<T>(x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.xzzxx swizzling.
        /// </summary>
        public gvec5<T> xzzxx => new gvec5<T>(x, z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.rbbrr swizzling (equivalent to gvec3.xzzxx).
        /// </summary>
        public gvec5<T> rbbrr => new gvec5<T>(x, z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.xzzxy swizzling.
        /// </summary>
        public gvec5<T> xzzxy => new gvec5<T>(x, z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.rbbrg swizzling (equivalent to gvec3.xzzxy).
        /// </summary>
        public gvec5<T> rbbrg => new gvec5<T>(x, z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.xzzxz swizzling.
        /// </summary>
        public gvec5<T> xzzxz => new gvec5<T>(x, z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.rbbrb swizzling (equivalent to gvec3.xzzxz).
        /// </summary>
        public gvec5<T> rbbrb => new gvec5<T>(x, z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.xzzy swizzling.
        /// </summary>
        public gvec4<T> xzzy => new gvec4<T>(x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.rbbg swizzling (equivalent to gvec3.xzzy).
        /// </summary>
        public gvec4<T> rbbg => new gvec4<T>(x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.xzzyx swizzling.
        /// </summary>
        public gvec5<T> xzzyx => new gvec5<T>(x, z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.rbbgr swizzling (equivalent to gvec3.xzzyx).
        /// </summary>
        public gvec5<T> rbbgr => new gvec5<T>(x, z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.xzzyy swizzling.
        /// </summary>
        public gvec5<T> xzzyy => new gvec5<T>(x, z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.rbbgg swizzling (equivalent to gvec3.xzzyy).
        /// </summary>
        public gvec5<T> rbbgg => new gvec5<T>(x, z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.xzzyz swizzling.
        /// </summary>
        public gvec5<T> xzzyz => new gvec5<T>(x, z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.rbbgb swizzling (equivalent to gvec3.xzzyz).
        /// </summary>
        public gvec5<T> rbbgb => new gvec5<T>(x, z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.xzzz swizzling.
        /// </summary>
        public gvec4<T> xzzz => new gvec4<T>(x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.rbbb swizzling (equivalent to gvec3.xzzz).
        /// </summary>
        public gvec4<T> rbbb => new gvec4<T>(x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.xzzzx swizzling.
        /// </summary>
        public gvec5<T> xzzzx => new gvec5<T>(x, z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.rbbbr swizzling (equivalent to gvec3.xzzzx).
        /// </summary>
        public gvec5<T> rbbbr => new gvec5<T>(x, z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.xzzzy swizzling.
        /// </summary>
        public gvec5<T> xzzzy => new gvec5<T>(x, z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.rbbbg swizzling (equivalent to gvec3.xzzzy).
        /// </summary>
        public gvec5<T> rbbbg => new gvec5<T>(x, z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.xzzzz swizzling.
        /// </summary>
        public gvec5<T> xzzzz => new gvec5<T>(x, z, z, z, z);
        
        /// <summary>
        /// Returns gvec3.rbbbb swizzling (equivalent to gvec3.xzzzz).
        /// </summary>
        public gvec5<T> rbbbb => new gvec5<T>(x, z, z, z, z);
        
        /// <summary>
        /// Returns gvec3.yx swizzling.
        /// </summary>
        public gvec2<T> yx => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec3.gr swizzling (equivalent to gvec3.yx).
        /// </summary>
        public gvec2<T> gr => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec3.yxx swizzling.
        /// </summary>
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec3.grr swizzling (equivalent to gvec3.yxx).
        /// </summary>
        public gvec3<T> grr => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec3.yxxx swizzling.
        /// </summary>
        public gvec4<T> yxxx => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.grrr swizzling (equivalent to gvec3.yxxx).
        /// </summary>
        public gvec4<T> grrr => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.yxxxx swizzling.
        /// </summary>
        public gvec5<T> yxxxx => new gvec5<T>(y, x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.grrrr swizzling (equivalent to gvec3.yxxxx).
        /// </summary>
        public gvec5<T> grrrr => new gvec5<T>(y, x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.yxxxy swizzling.
        /// </summary>
        public gvec5<T> yxxxy => new gvec5<T>(y, x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.grrrg swizzling (equivalent to gvec3.yxxxy).
        /// </summary>
        public gvec5<T> grrrg => new gvec5<T>(y, x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.yxxxz swizzling.
        /// </summary>
        public gvec5<T> yxxxz => new gvec5<T>(y, x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.grrrb swizzling (equivalent to gvec3.yxxxz).
        /// </summary>
        public gvec5<T> grrrb => new gvec5<T>(y, x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.yxxy swizzling.
        /// </summary>
        public gvec4<T> yxxy => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.grrg swizzling (equivalent to gvec3.yxxy).
        /// </summary>
        public gvec4<T> grrg => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.yxxyx swizzling.
        /// </summary>
        public gvec5<T> yxxyx => new gvec5<T>(y, x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.grrgr swizzling (equivalent to gvec3.yxxyx).
        /// </summary>
        public gvec5<T> grrgr => new gvec5<T>(y, x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.yxxyy swizzling.
        /// </summary>
        public gvec5<T> yxxyy => new gvec5<T>(y, x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.grrgg swizzling (equivalent to gvec3.yxxyy).
        /// </summary>
        public gvec5<T> grrgg => new gvec5<T>(y, x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.yxxyz swizzling.
        /// </summary>
        public gvec5<T> yxxyz => new gvec5<T>(y, x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.grrgb swizzling (equivalent to gvec3.yxxyz).
        /// </summary>
        public gvec5<T> grrgb => new gvec5<T>(y, x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.yxxz swizzling.
        /// </summary>
        public gvec4<T> yxxz => new gvec4<T>(y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.grrb swizzling (equivalent to gvec3.yxxz).
        /// </summary>
        public gvec4<T> grrb => new gvec4<T>(y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.yxxzx swizzling.
        /// </summary>
        public gvec5<T> yxxzx => new gvec5<T>(y, x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.grrbr swizzling (equivalent to gvec3.yxxzx).
        /// </summary>
        public gvec5<T> grrbr => new gvec5<T>(y, x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.yxxzy swizzling.
        /// </summary>
        public gvec5<T> yxxzy => new gvec5<T>(y, x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.grrbg swizzling (equivalent to gvec3.yxxzy).
        /// </summary>
        public gvec5<T> grrbg => new gvec5<T>(y, x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.yxxzz swizzling.
        /// </summary>
        public gvec5<T> yxxzz => new gvec5<T>(y, x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.grrbb swizzling (equivalent to gvec3.yxxzz).
        /// </summary>
        public gvec5<T> grrbb => new gvec5<T>(y, x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.yxy swizzling.
        /// </summary>
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec3.grg swizzling (equivalent to gvec3.yxy).
        /// </summary>
        public gvec3<T> grg => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec3.yxyx swizzling.
        /// </summary>
        public gvec4<T> yxyx => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.grgr swizzling (equivalent to gvec3.yxyx).
        /// </summary>
        public gvec4<T> grgr => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.yxyxx swizzling.
        /// </summary>
        public gvec5<T> yxyxx => new gvec5<T>(y, x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.grgrr swizzling (equivalent to gvec3.yxyxx).
        /// </summary>
        public gvec5<T> grgrr => new gvec5<T>(y, x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.yxyxy swizzling.
        /// </summary>
        public gvec5<T> yxyxy => new gvec5<T>(y, x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.grgrg swizzling (equivalent to gvec3.yxyxy).
        /// </summary>
        public gvec5<T> grgrg => new gvec5<T>(y, x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.yxyxz swizzling.
        /// </summary>
        public gvec5<T> yxyxz => new gvec5<T>(y, x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.grgrb swizzling (equivalent to gvec3.yxyxz).
        /// </summary>
        public gvec5<T> grgrb => new gvec5<T>(y, x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.yxyy swizzling.
        /// </summary>
        public gvec4<T> yxyy => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.grgg swizzling (equivalent to gvec3.yxyy).
        /// </summary>
        public gvec4<T> grgg => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.yxyyx swizzling.
        /// </summary>
        public gvec5<T> yxyyx => new gvec5<T>(y, x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.grggr swizzling (equivalent to gvec3.yxyyx).
        /// </summary>
        public gvec5<T> grggr => new gvec5<T>(y, x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.yxyyy swizzling.
        /// </summary>
        public gvec5<T> yxyyy => new gvec5<T>(y, x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.grggg swizzling (equivalent to gvec3.yxyyy).
        /// </summary>
        public gvec5<T> grggg => new gvec5<T>(y, x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.yxyyz swizzling.
        /// </summary>
        public gvec5<T> yxyyz => new gvec5<T>(y, x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.grggb swizzling (equivalent to gvec3.yxyyz).
        /// </summary>
        public gvec5<T> grggb => new gvec5<T>(y, x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.yxyz swizzling.
        /// </summary>
        public gvec4<T> yxyz => new gvec4<T>(y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.grgb swizzling (equivalent to gvec3.yxyz).
        /// </summary>
        public gvec4<T> grgb => new gvec4<T>(y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.yxyzx swizzling.
        /// </summary>
        public gvec5<T> yxyzx => new gvec5<T>(y, x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.grgbr swizzling (equivalent to gvec3.yxyzx).
        /// </summary>
        public gvec5<T> grgbr => new gvec5<T>(y, x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.yxyzy swizzling.
        /// </summary>
        public gvec5<T> yxyzy => new gvec5<T>(y, x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.grgbg swizzling (equivalent to gvec3.yxyzy).
        /// </summary>
        public gvec5<T> grgbg => new gvec5<T>(y, x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.yxyzz swizzling.
        /// </summary>
        public gvec5<T> yxyzz => new gvec5<T>(y, x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.grgbb swizzling (equivalent to gvec3.yxyzz).
        /// </summary>
        public gvec5<T> grgbb => new gvec5<T>(y, x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.yxz swizzling.
        /// </summary>
        public gvec3<T> yxz => new gvec3<T>(y, x, z);
        
        /// <summary>
        /// Returns gvec3.grb swizzling (equivalent to gvec3.yxz).
        /// </summary>
        public gvec3<T> grb => new gvec3<T>(y, x, z);
        
        /// <summary>
        /// Returns gvec3.yxzx swizzling.
        /// </summary>
        public gvec4<T> yxzx => new gvec4<T>(y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.grbr swizzling (equivalent to gvec3.yxzx).
        /// </summary>
        public gvec4<T> grbr => new gvec4<T>(y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.yxzxx swizzling.
        /// </summary>
        public gvec5<T> yxzxx => new gvec5<T>(y, x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.grbrr swizzling (equivalent to gvec3.yxzxx).
        /// </summary>
        public gvec5<T> grbrr => new gvec5<T>(y, x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.yxzxy swizzling.
        /// </summary>
        public gvec5<T> yxzxy => new gvec5<T>(y, x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.grbrg swizzling (equivalent to gvec3.yxzxy).
        /// </summary>
        public gvec5<T> grbrg => new gvec5<T>(y, x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.yxzxz swizzling.
        /// </summary>
        public gvec5<T> yxzxz => new gvec5<T>(y, x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.grbrb swizzling (equivalent to gvec3.yxzxz).
        /// </summary>
        public gvec5<T> grbrb => new gvec5<T>(y, x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.yxzy swizzling.
        /// </summary>
        public gvec4<T> yxzy => new gvec4<T>(y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.grbg swizzling (equivalent to gvec3.yxzy).
        /// </summary>
        public gvec4<T> grbg => new gvec4<T>(y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.yxzyx swizzling.
        /// </summary>
        public gvec5<T> yxzyx => new gvec5<T>(y, x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.grbgr swizzling (equivalent to gvec3.yxzyx).
        /// </summary>
        public gvec5<T> grbgr => new gvec5<T>(y, x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.yxzyy swizzling.
        /// </summary>
        public gvec5<T> yxzyy => new gvec5<T>(y, x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.grbgg swizzling (equivalent to gvec3.yxzyy).
        /// </summary>
        public gvec5<T> grbgg => new gvec5<T>(y, x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.yxzyz swizzling.
        /// </summary>
        public gvec5<T> yxzyz => new gvec5<T>(y, x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.grbgb swizzling (equivalent to gvec3.yxzyz).
        /// </summary>
        public gvec5<T> grbgb => new gvec5<T>(y, x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.yxzz swizzling.
        /// </summary>
        public gvec4<T> yxzz => new gvec4<T>(y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.grbb swizzling (equivalent to gvec3.yxzz).
        /// </summary>
        public gvec4<T> grbb => new gvec4<T>(y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.yxzzx swizzling.
        /// </summary>
        public gvec5<T> yxzzx => new gvec5<T>(y, x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.grbbr swizzling (equivalent to gvec3.yxzzx).
        /// </summary>
        public gvec5<T> grbbr => new gvec5<T>(y, x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.yxzzy swizzling.
        /// </summary>
        public gvec5<T> yxzzy => new gvec5<T>(y, x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.grbbg swizzling (equivalent to gvec3.yxzzy).
        /// </summary>
        public gvec5<T> grbbg => new gvec5<T>(y, x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.yxzzz swizzling.
        /// </summary>
        public gvec5<T> yxzzz => new gvec5<T>(y, x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.grbbb swizzling (equivalent to gvec3.yxzzz).
        /// </summary>
        public gvec5<T> grbbb => new gvec5<T>(y, x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.yy swizzling.
        /// </summary>
        public gvec2<T> yy => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec3.gg swizzling (equivalent to gvec3.yy).
        /// </summary>
        public gvec2<T> gg => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec3.yyx swizzling.
        /// </summary>
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec3.ggr swizzling (equivalent to gvec3.yyx).
        /// </summary>
        public gvec3<T> ggr => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec3.yyxx swizzling.
        /// </summary>
        public gvec4<T> yyxx => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.ggrr swizzling (equivalent to gvec3.yyxx).
        /// </summary>
        public gvec4<T> ggrr => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.yyxxx swizzling.
        /// </summary>
        public gvec5<T> yyxxx => new gvec5<T>(y, y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.ggrrr swizzling (equivalent to gvec3.yyxxx).
        /// </summary>
        public gvec5<T> ggrrr => new gvec5<T>(y, y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.yyxxy swizzling.
        /// </summary>
        public gvec5<T> yyxxy => new gvec5<T>(y, y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.ggrrg swizzling (equivalent to gvec3.yyxxy).
        /// </summary>
        public gvec5<T> ggrrg => new gvec5<T>(y, y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.yyxxz swizzling.
        /// </summary>
        public gvec5<T> yyxxz => new gvec5<T>(y, y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.ggrrb swizzling (equivalent to gvec3.yyxxz).
        /// </summary>
        public gvec5<T> ggrrb => new gvec5<T>(y, y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.yyxy swizzling.
        /// </summary>
        public gvec4<T> yyxy => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.ggrg swizzling (equivalent to gvec3.yyxy).
        /// </summary>
        public gvec4<T> ggrg => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.yyxyx swizzling.
        /// </summary>
        public gvec5<T> yyxyx => new gvec5<T>(y, y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.ggrgr swizzling (equivalent to gvec3.yyxyx).
        /// </summary>
        public gvec5<T> ggrgr => new gvec5<T>(y, y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.yyxyy swizzling.
        /// </summary>
        public gvec5<T> yyxyy => new gvec5<T>(y, y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.ggrgg swizzling (equivalent to gvec3.yyxyy).
        /// </summary>
        public gvec5<T> ggrgg => new gvec5<T>(y, y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.yyxyz swizzling.
        /// </summary>
        public gvec5<T> yyxyz => new gvec5<T>(y, y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.ggrgb swizzling (equivalent to gvec3.yyxyz).
        /// </summary>
        public gvec5<T> ggrgb => new gvec5<T>(y, y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.yyxz swizzling.
        /// </summary>
        public gvec4<T> yyxz => new gvec4<T>(y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.ggrb swizzling (equivalent to gvec3.yyxz).
        /// </summary>
        public gvec4<T> ggrb => new gvec4<T>(y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.yyxzx swizzling.
        /// </summary>
        public gvec5<T> yyxzx => new gvec5<T>(y, y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.ggrbr swizzling (equivalent to gvec3.yyxzx).
        /// </summary>
        public gvec5<T> ggrbr => new gvec5<T>(y, y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.yyxzy swizzling.
        /// </summary>
        public gvec5<T> yyxzy => new gvec5<T>(y, y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.ggrbg swizzling (equivalent to gvec3.yyxzy).
        /// </summary>
        public gvec5<T> ggrbg => new gvec5<T>(y, y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.yyxzz swizzling.
        /// </summary>
        public gvec5<T> yyxzz => new gvec5<T>(y, y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.ggrbb swizzling (equivalent to gvec3.yyxzz).
        /// </summary>
        public gvec5<T> ggrbb => new gvec5<T>(y, y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.yyy swizzling.
        /// </summary>
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec3.ggg swizzling (equivalent to gvec3.yyy).
        /// </summary>
        public gvec3<T> ggg => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec3.yyyx swizzling.
        /// </summary>
        public gvec4<T> yyyx => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.gggr swizzling (equivalent to gvec3.yyyx).
        /// </summary>
        public gvec4<T> gggr => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.yyyxx swizzling.
        /// </summary>
        public gvec5<T> yyyxx => new gvec5<T>(y, y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.gggrr swizzling (equivalent to gvec3.yyyxx).
        /// </summary>
        public gvec5<T> gggrr => new gvec5<T>(y, y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.yyyxy swizzling.
        /// </summary>
        public gvec5<T> yyyxy => new gvec5<T>(y, y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.gggrg swizzling (equivalent to gvec3.yyyxy).
        /// </summary>
        public gvec5<T> gggrg => new gvec5<T>(y, y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.yyyxz swizzling.
        /// </summary>
        public gvec5<T> yyyxz => new gvec5<T>(y, y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.gggrb swizzling (equivalent to gvec3.yyyxz).
        /// </summary>
        public gvec5<T> gggrb => new gvec5<T>(y, y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.yyyy swizzling.
        /// </summary>
        public gvec4<T> yyyy => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.gggg swizzling (equivalent to gvec3.yyyy).
        /// </summary>
        public gvec4<T> gggg => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.yyyyx swizzling.
        /// </summary>
        public gvec5<T> yyyyx => new gvec5<T>(y, y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.ggggr swizzling (equivalent to gvec3.yyyyx).
        /// </summary>
        public gvec5<T> ggggr => new gvec5<T>(y, y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.yyyyy swizzling.
        /// </summary>
        public gvec5<T> yyyyy => new gvec5<T>(y, y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.ggggg swizzling (equivalent to gvec3.yyyyy).
        /// </summary>
        public gvec5<T> ggggg => new gvec5<T>(y, y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.yyyyz swizzling.
        /// </summary>
        public gvec5<T> yyyyz => new gvec5<T>(y, y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.ggggb swizzling (equivalent to gvec3.yyyyz).
        /// </summary>
        public gvec5<T> ggggb => new gvec5<T>(y, y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.yyyz swizzling.
        /// </summary>
        public gvec4<T> yyyz => new gvec4<T>(y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.gggb swizzling (equivalent to gvec3.yyyz).
        /// </summary>
        public gvec4<T> gggb => new gvec4<T>(y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.yyyzx swizzling.
        /// </summary>
        public gvec5<T> yyyzx => new gvec5<T>(y, y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.gggbr swizzling (equivalent to gvec3.yyyzx).
        /// </summary>
        public gvec5<T> gggbr => new gvec5<T>(y, y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.yyyzy swizzling.
        /// </summary>
        public gvec5<T> yyyzy => new gvec5<T>(y, y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.gggbg swizzling (equivalent to gvec3.yyyzy).
        /// </summary>
        public gvec5<T> gggbg => new gvec5<T>(y, y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.yyyzz swizzling.
        /// </summary>
        public gvec5<T> yyyzz => new gvec5<T>(y, y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.gggbb swizzling (equivalent to gvec3.yyyzz).
        /// </summary>
        public gvec5<T> gggbb => new gvec5<T>(y, y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.yyz swizzling.
        /// </summary>
        public gvec3<T> yyz => new gvec3<T>(y, y, z);
        
        /// <summary>
        /// Returns gvec3.ggb swizzling (equivalent to gvec3.yyz).
        /// </summary>
        public gvec3<T> ggb => new gvec3<T>(y, y, z);
        
        /// <summary>
        /// Returns gvec3.yyzx swizzling.
        /// </summary>
        public gvec4<T> yyzx => new gvec4<T>(y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.ggbr swizzling (equivalent to gvec3.yyzx).
        /// </summary>
        public gvec4<T> ggbr => new gvec4<T>(y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.yyzxx swizzling.
        /// </summary>
        public gvec5<T> yyzxx => new gvec5<T>(y, y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.ggbrr swizzling (equivalent to gvec3.yyzxx).
        /// </summary>
        public gvec5<T> ggbrr => new gvec5<T>(y, y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.yyzxy swizzling.
        /// </summary>
        public gvec5<T> yyzxy => new gvec5<T>(y, y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.ggbrg swizzling (equivalent to gvec3.yyzxy).
        /// </summary>
        public gvec5<T> ggbrg => new gvec5<T>(y, y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.yyzxz swizzling.
        /// </summary>
        public gvec5<T> yyzxz => new gvec5<T>(y, y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.ggbrb swizzling (equivalent to gvec3.yyzxz).
        /// </summary>
        public gvec5<T> ggbrb => new gvec5<T>(y, y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.yyzy swizzling.
        /// </summary>
        public gvec4<T> yyzy => new gvec4<T>(y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.ggbg swizzling (equivalent to gvec3.yyzy).
        /// </summary>
        public gvec4<T> ggbg => new gvec4<T>(y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.yyzyx swizzling.
        /// </summary>
        public gvec5<T> yyzyx => new gvec5<T>(y, y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.ggbgr swizzling (equivalent to gvec3.yyzyx).
        /// </summary>
        public gvec5<T> ggbgr => new gvec5<T>(y, y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.yyzyy swizzling.
        /// </summary>
        public gvec5<T> yyzyy => new gvec5<T>(y, y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.ggbgg swizzling (equivalent to gvec3.yyzyy).
        /// </summary>
        public gvec5<T> ggbgg => new gvec5<T>(y, y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.yyzyz swizzling.
        /// </summary>
        public gvec5<T> yyzyz => new gvec5<T>(y, y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.ggbgb swizzling (equivalent to gvec3.yyzyz).
        /// </summary>
        public gvec5<T> ggbgb => new gvec5<T>(y, y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.yyzz swizzling.
        /// </summary>
        public gvec4<T> yyzz => new gvec4<T>(y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.ggbb swizzling (equivalent to gvec3.yyzz).
        /// </summary>
        public gvec4<T> ggbb => new gvec4<T>(y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.yyzzx swizzling.
        /// </summary>
        public gvec5<T> yyzzx => new gvec5<T>(y, y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.ggbbr swizzling (equivalent to gvec3.yyzzx).
        /// </summary>
        public gvec5<T> ggbbr => new gvec5<T>(y, y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.yyzzy swizzling.
        /// </summary>
        public gvec5<T> yyzzy => new gvec5<T>(y, y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.ggbbg swizzling (equivalent to gvec3.yyzzy).
        /// </summary>
        public gvec5<T> ggbbg => new gvec5<T>(y, y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.yyzzz swizzling.
        /// </summary>
        public gvec5<T> yyzzz => new gvec5<T>(y, y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.ggbbb swizzling (equivalent to gvec3.yyzzz).
        /// </summary>
        public gvec5<T> ggbbb => new gvec5<T>(y, y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.yz swizzling.
        /// </summary>
        public gvec2<T> yz => new gvec2<T>(y, z);
        
        /// <summary>
        /// Returns gvec3.gb swizzling (equivalent to gvec3.yz).
        /// </summary>
        public gvec2<T> gb => new gvec2<T>(y, z);
        
        /// <summary>
        /// Returns gvec3.yzx swizzling.
        /// </summary>
        public gvec3<T> yzx => new gvec3<T>(y, z, x);
        
        /// <summary>
        /// Returns gvec3.gbr swizzling (equivalent to gvec3.yzx).
        /// </summary>
        public gvec3<T> gbr => new gvec3<T>(y, z, x);
        
        /// <summary>
        /// Returns gvec3.yzxx swizzling.
        /// </summary>
        public gvec4<T> yzxx => new gvec4<T>(y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.gbrr swizzling (equivalent to gvec3.yzxx).
        /// </summary>
        public gvec4<T> gbrr => new gvec4<T>(y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.yzxxx swizzling.
        /// </summary>
        public gvec5<T> yzxxx => new gvec5<T>(y, z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.gbrrr swizzling (equivalent to gvec3.yzxxx).
        /// </summary>
        public gvec5<T> gbrrr => new gvec5<T>(y, z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.yzxxy swizzling.
        /// </summary>
        public gvec5<T> yzxxy => new gvec5<T>(y, z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.gbrrg swizzling (equivalent to gvec3.yzxxy).
        /// </summary>
        public gvec5<T> gbrrg => new gvec5<T>(y, z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.yzxxz swizzling.
        /// </summary>
        public gvec5<T> yzxxz => new gvec5<T>(y, z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.gbrrb swizzling (equivalent to gvec3.yzxxz).
        /// </summary>
        public gvec5<T> gbrrb => new gvec5<T>(y, z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.yzxy swizzling.
        /// </summary>
        public gvec4<T> yzxy => new gvec4<T>(y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.gbrg swizzling (equivalent to gvec3.yzxy).
        /// </summary>
        public gvec4<T> gbrg => new gvec4<T>(y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.yzxyx swizzling.
        /// </summary>
        public gvec5<T> yzxyx => new gvec5<T>(y, z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.gbrgr swizzling (equivalent to gvec3.yzxyx).
        /// </summary>
        public gvec5<T> gbrgr => new gvec5<T>(y, z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.yzxyy swizzling.
        /// </summary>
        public gvec5<T> yzxyy => new gvec5<T>(y, z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.gbrgg swizzling (equivalent to gvec3.yzxyy).
        /// </summary>
        public gvec5<T> gbrgg => new gvec5<T>(y, z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.yzxyz swizzling.
        /// </summary>
        public gvec5<T> yzxyz => new gvec5<T>(y, z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.gbrgb swizzling (equivalent to gvec3.yzxyz).
        /// </summary>
        public gvec5<T> gbrgb => new gvec5<T>(y, z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.yzxz swizzling.
        /// </summary>
        public gvec4<T> yzxz => new gvec4<T>(y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.gbrb swizzling (equivalent to gvec3.yzxz).
        /// </summary>
        public gvec4<T> gbrb => new gvec4<T>(y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.yzxzx swizzling.
        /// </summary>
        public gvec5<T> yzxzx => new gvec5<T>(y, z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.gbrbr swizzling (equivalent to gvec3.yzxzx).
        /// </summary>
        public gvec5<T> gbrbr => new gvec5<T>(y, z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.yzxzy swizzling.
        /// </summary>
        public gvec5<T> yzxzy => new gvec5<T>(y, z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.gbrbg swizzling (equivalent to gvec3.yzxzy).
        /// </summary>
        public gvec5<T> gbrbg => new gvec5<T>(y, z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.yzxzz swizzling.
        /// </summary>
        public gvec5<T> yzxzz => new gvec5<T>(y, z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.gbrbb swizzling (equivalent to gvec3.yzxzz).
        /// </summary>
        public gvec5<T> gbrbb => new gvec5<T>(y, z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.yzy swizzling.
        /// </summary>
        public gvec3<T> yzy => new gvec3<T>(y, z, y);
        
        /// <summary>
        /// Returns gvec3.gbg swizzling (equivalent to gvec3.yzy).
        /// </summary>
        public gvec3<T> gbg => new gvec3<T>(y, z, y);
        
        /// <summary>
        /// Returns gvec3.yzyx swizzling.
        /// </summary>
        public gvec4<T> yzyx => new gvec4<T>(y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.gbgr swizzling (equivalent to gvec3.yzyx).
        /// </summary>
        public gvec4<T> gbgr => new gvec4<T>(y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.yzyxx swizzling.
        /// </summary>
        public gvec5<T> yzyxx => new gvec5<T>(y, z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.gbgrr swizzling (equivalent to gvec3.yzyxx).
        /// </summary>
        public gvec5<T> gbgrr => new gvec5<T>(y, z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.yzyxy swizzling.
        /// </summary>
        public gvec5<T> yzyxy => new gvec5<T>(y, z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.gbgrg swizzling (equivalent to gvec3.yzyxy).
        /// </summary>
        public gvec5<T> gbgrg => new gvec5<T>(y, z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.yzyxz swizzling.
        /// </summary>
        public gvec5<T> yzyxz => new gvec5<T>(y, z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.gbgrb swizzling (equivalent to gvec3.yzyxz).
        /// </summary>
        public gvec5<T> gbgrb => new gvec5<T>(y, z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.yzyy swizzling.
        /// </summary>
        public gvec4<T> yzyy => new gvec4<T>(y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.gbgg swizzling (equivalent to gvec3.yzyy).
        /// </summary>
        public gvec4<T> gbgg => new gvec4<T>(y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.yzyyx swizzling.
        /// </summary>
        public gvec5<T> yzyyx => new gvec5<T>(y, z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.gbggr swizzling (equivalent to gvec3.yzyyx).
        /// </summary>
        public gvec5<T> gbggr => new gvec5<T>(y, z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.yzyyy swizzling.
        /// </summary>
        public gvec5<T> yzyyy => new gvec5<T>(y, z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.gbggg swizzling (equivalent to gvec3.yzyyy).
        /// </summary>
        public gvec5<T> gbggg => new gvec5<T>(y, z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.yzyyz swizzling.
        /// </summary>
        public gvec5<T> yzyyz => new gvec5<T>(y, z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.gbggb swizzling (equivalent to gvec3.yzyyz).
        /// </summary>
        public gvec5<T> gbggb => new gvec5<T>(y, z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.yzyz swizzling.
        /// </summary>
        public gvec4<T> yzyz => new gvec4<T>(y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.gbgb swizzling (equivalent to gvec3.yzyz).
        /// </summary>
        public gvec4<T> gbgb => new gvec4<T>(y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.yzyzx swizzling.
        /// </summary>
        public gvec5<T> yzyzx => new gvec5<T>(y, z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.gbgbr swizzling (equivalent to gvec3.yzyzx).
        /// </summary>
        public gvec5<T> gbgbr => new gvec5<T>(y, z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.yzyzy swizzling.
        /// </summary>
        public gvec5<T> yzyzy => new gvec5<T>(y, z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.gbgbg swizzling (equivalent to gvec3.yzyzy).
        /// </summary>
        public gvec5<T> gbgbg => new gvec5<T>(y, z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.yzyzz swizzling.
        /// </summary>
        public gvec5<T> yzyzz => new gvec5<T>(y, z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.gbgbb swizzling (equivalent to gvec3.yzyzz).
        /// </summary>
        public gvec5<T> gbgbb => new gvec5<T>(y, z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.yzz swizzling.
        /// </summary>
        public gvec3<T> yzz => new gvec3<T>(y, z, z);
        
        /// <summary>
        /// Returns gvec3.gbb swizzling (equivalent to gvec3.yzz).
        /// </summary>
        public gvec3<T> gbb => new gvec3<T>(y, z, z);
        
        /// <summary>
        /// Returns gvec3.yzzx swizzling.
        /// </summary>
        public gvec4<T> yzzx => new gvec4<T>(y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.gbbr swizzling (equivalent to gvec3.yzzx).
        /// </summary>
        public gvec4<T> gbbr => new gvec4<T>(y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.yzzxx swizzling.
        /// </summary>
        public gvec5<T> yzzxx => new gvec5<T>(y, z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.gbbrr swizzling (equivalent to gvec3.yzzxx).
        /// </summary>
        public gvec5<T> gbbrr => new gvec5<T>(y, z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.yzzxy swizzling.
        /// </summary>
        public gvec5<T> yzzxy => new gvec5<T>(y, z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.gbbrg swizzling (equivalent to gvec3.yzzxy).
        /// </summary>
        public gvec5<T> gbbrg => new gvec5<T>(y, z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.yzzxz swizzling.
        /// </summary>
        public gvec5<T> yzzxz => new gvec5<T>(y, z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.gbbrb swizzling (equivalent to gvec3.yzzxz).
        /// </summary>
        public gvec5<T> gbbrb => new gvec5<T>(y, z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.yzzy swizzling.
        /// </summary>
        public gvec4<T> yzzy => new gvec4<T>(y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.gbbg swizzling (equivalent to gvec3.yzzy).
        /// </summary>
        public gvec4<T> gbbg => new gvec4<T>(y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.yzzyx swizzling.
        /// </summary>
        public gvec5<T> yzzyx => new gvec5<T>(y, z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.gbbgr swizzling (equivalent to gvec3.yzzyx).
        /// </summary>
        public gvec5<T> gbbgr => new gvec5<T>(y, z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.yzzyy swizzling.
        /// </summary>
        public gvec5<T> yzzyy => new gvec5<T>(y, z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.gbbgg swizzling (equivalent to gvec3.yzzyy).
        /// </summary>
        public gvec5<T> gbbgg => new gvec5<T>(y, z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.yzzyz swizzling.
        /// </summary>
        public gvec5<T> yzzyz => new gvec5<T>(y, z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.gbbgb swizzling (equivalent to gvec3.yzzyz).
        /// </summary>
        public gvec5<T> gbbgb => new gvec5<T>(y, z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.yzzz swizzling.
        /// </summary>
        public gvec4<T> yzzz => new gvec4<T>(y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.gbbb swizzling (equivalent to gvec3.yzzz).
        /// </summary>
        public gvec4<T> gbbb => new gvec4<T>(y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.yzzzx swizzling.
        /// </summary>
        public gvec5<T> yzzzx => new gvec5<T>(y, z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.gbbbr swizzling (equivalent to gvec3.yzzzx).
        /// </summary>
        public gvec5<T> gbbbr => new gvec5<T>(y, z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.yzzzy swizzling.
        /// </summary>
        public gvec5<T> yzzzy => new gvec5<T>(y, z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.gbbbg swizzling (equivalent to gvec3.yzzzy).
        /// </summary>
        public gvec5<T> gbbbg => new gvec5<T>(y, z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.yzzzz swizzling.
        /// </summary>
        public gvec5<T> yzzzz => new gvec5<T>(y, z, z, z, z);
        
        /// <summary>
        /// Returns gvec3.gbbbb swizzling (equivalent to gvec3.yzzzz).
        /// </summary>
        public gvec5<T> gbbbb => new gvec5<T>(y, z, z, z, z);
        
        /// <summary>
        /// Returns gvec3.zx swizzling.
        /// </summary>
        public gvec2<T> zx => new gvec2<T>(z, x);
        
        /// <summary>
        /// Returns gvec3.br swizzling (equivalent to gvec3.zx).
        /// </summary>
        public gvec2<T> br => new gvec2<T>(z, x);
        
        /// <summary>
        /// Returns gvec3.zxx swizzling.
        /// </summary>
        public gvec3<T> zxx => new gvec3<T>(z, x, x);
        
        /// <summary>
        /// Returns gvec3.brr swizzling (equivalent to gvec3.zxx).
        /// </summary>
        public gvec3<T> brr => new gvec3<T>(z, x, x);
        
        /// <summary>
        /// Returns gvec3.zxxx swizzling.
        /// </summary>
        public gvec4<T> zxxx => new gvec4<T>(z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.brrr swizzling (equivalent to gvec3.zxxx).
        /// </summary>
        public gvec4<T> brrr => new gvec4<T>(z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.zxxxx swizzling.
        /// </summary>
        public gvec5<T> zxxxx => new gvec5<T>(z, x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.brrrr swizzling (equivalent to gvec3.zxxxx).
        /// </summary>
        public gvec5<T> brrrr => new gvec5<T>(z, x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.zxxxy swizzling.
        /// </summary>
        public gvec5<T> zxxxy => new gvec5<T>(z, x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.brrrg swizzling (equivalent to gvec3.zxxxy).
        /// </summary>
        public gvec5<T> brrrg => new gvec5<T>(z, x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.zxxxz swizzling.
        /// </summary>
        public gvec5<T> zxxxz => new gvec5<T>(z, x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.brrrb swizzling (equivalent to gvec3.zxxxz).
        /// </summary>
        public gvec5<T> brrrb => new gvec5<T>(z, x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.zxxy swizzling.
        /// </summary>
        public gvec4<T> zxxy => new gvec4<T>(z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.brrg swizzling (equivalent to gvec3.zxxy).
        /// </summary>
        public gvec4<T> brrg => new gvec4<T>(z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.zxxyx swizzling.
        /// </summary>
        public gvec5<T> zxxyx => new gvec5<T>(z, x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.brrgr swizzling (equivalent to gvec3.zxxyx).
        /// </summary>
        public gvec5<T> brrgr => new gvec5<T>(z, x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.zxxyy swizzling.
        /// </summary>
        public gvec5<T> zxxyy => new gvec5<T>(z, x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.brrgg swizzling (equivalent to gvec3.zxxyy).
        /// </summary>
        public gvec5<T> brrgg => new gvec5<T>(z, x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.zxxyz swizzling.
        /// </summary>
        public gvec5<T> zxxyz => new gvec5<T>(z, x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.brrgb swizzling (equivalent to gvec3.zxxyz).
        /// </summary>
        public gvec5<T> brrgb => new gvec5<T>(z, x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.zxxz swizzling.
        /// </summary>
        public gvec4<T> zxxz => new gvec4<T>(z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.brrb swizzling (equivalent to gvec3.zxxz).
        /// </summary>
        public gvec4<T> brrb => new gvec4<T>(z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.zxxzx swizzling.
        /// </summary>
        public gvec5<T> zxxzx => new gvec5<T>(z, x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.brrbr swizzling (equivalent to gvec3.zxxzx).
        /// </summary>
        public gvec5<T> brrbr => new gvec5<T>(z, x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.zxxzy swizzling.
        /// </summary>
        public gvec5<T> zxxzy => new gvec5<T>(z, x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.brrbg swizzling (equivalent to gvec3.zxxzy).
        /// </summary>
        public gvec5<T> brrbg => new gvec5<T>(z, x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.zxxzz swizzling.
        /// </summary>
        public gvec5<T> zxxzz => new gvec5<T>(z, x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.brrbb swizzling (equivalent to gvec3.zxxzz).
        /// </summary>
        public gvec5<T> brrbb => new gvec5<T>(z, x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.zxy swizzling.
        /// </summary>
        public gvec3<T> zxy => new gvec3<T>(z, x, y);
        
        /// <summary>
        /// Returns gvec3.brg swizzling (equivalent to gvec3.zxy).
        /// </summary>
        public gvec3<T> brg => new gvec3<T>(z, x, y);
        
        /// <summary>
        /// Returns gvec3.zxyx swizzling.
        /// </summary>
        public gvec4<T> zxyx => new gvec4<T>(z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.brgr swizzling (equivalent to gvec3.zxyx).
        /// </summary>
        public gvec4<T> brgr => new gvec4<T>(z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.zxyxx swizzling.
        /// </summary>
        public gvec5<T> zxyxx => new gvec5<T>(z, x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.brgrr swizzling (equivalent to gvec3.zxyxx).
        /// </summary>
        public gvec5<T> brgrr => new gvec5<T>(z, x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.zxyxy swizzling.
        /// </summary>
        public gvec5<T> zxyxy => new gvec5<T>(z, x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.brgrg swizzling (equivalent to gvec3.zxyxy).
        /// </summary>
        public gvec5<T> brgrg => new gvec5<T>(z, x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.zxyxz swizzling.
        /// </summary>
        public gvec5<T> zxyxz => new gvec5<T>(z, x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.brgrb swizzling (equivalent to gvec3.zxyxz).
        /// </summary>
        public gvec5<T> brgrb => new gvec5<T>(z, x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.zxyy swizzling.
        /// </summary>
        public gvec4<T> zxyy => new gvec4<T>(z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.brgg swizzling (equivalent to gvec3.zxyy).
        /// </summary>
        public gvec4<T> brgg => new gvec4<T>(z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.zxyyx swizzling.
        /// </summary>
        public gvec5<T> zxyyx => new gvec5<T>(z, x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.brggr swizzling (equivalent to gvec3.zxyyx).
        /// </summary>
        public gvec5<T> brggr => new gvec5<T>(z, x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.zxyyy swizzling.
        /// </summary>
        public gvec5<T> zxyyy => new gvec5<T>(z, x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.brggg swizzling (equivalent to gvec3.zxyyy).
        /// </summary>
        public gvec5<T> brggg => new gvec5<T>(z, x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.zxyyz swizzling.
        /// </summary>
        public gvec5<T> zxyyz => new gvec5<T>(z, x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.brggb swizzling (equivalent to gvec3.zxyyz).
        /// </summary>
        public gvec5<T> brggb => new gvec5<T>(z, x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.zxyz swizzling.
        /// </summary>
        public gvec4<T> zxyz => new gvec4<T>(z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.brgb swizzling (equivalent to gvec3.zxyz).
        /// </summary>
        public gvec4<T> brgb => new gvec4<T>(z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.zxyzx swizzling.
        /// </summary>
        public gvec5<T> zxyzx => new gvec5<T>(z, x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.brgbr swizzling (equivalent to gvec3.zxyzx).
        /// </summary>
        public gvec5<T> brgbr => new gvec5<T>(z, x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.zxyzy swizzling.
        /// </summary>
        public gvec5<T> zxyzy => new gvec5<T>(z, x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.brgbg swizzling (equivalent to gvec3.zxyzy).
        /// </summary>
        public gvec5<T> brgbg => new gvec5<T>(z, x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.zxyzz swizzling.
        /// </summary>
        public gvec5<T> zxyzz => new gvec5<T>(z, x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.brgbb swizzling (equivalent to gvec3.zxyzz).
        /// </summary>
        public gvec5<T> brgbb => new gvec5<T>(z, x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.zxz swizzling.
        /// </summary>
        public gvec3<T> zxz => new gvec3<T>(z, x, z);
        
        /// <summary>
        /// Returns gvec3.brb swizzling (equivalent to gvec3.zxz).
        /// </summary>
        public gvec3<T> brb => new gvec3<T>(z, x, z);
        
        /// <summary>
        /// Returns gvec3.zxzx swizzling.
        /// </summary>
        public gvec4<T> zxzx => new gvec4<T>(z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.brbr swizzling (equivalent to gvec3.zxzx).
        /// </summary>
        public gvec4<T> brbr => new gvec4<T>(z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.zxzxx swizzling.
        /// </summary>
        public gvec5<T> zxzxx => new gvec5<T>(z, x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.brbrr swizzling (equivalent to gvec3.zxzxx).
        /// </summary>
        public gvec5<T> brbrr => new gvec5<T>(z, x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.zxzxy swizzling.
        /// </summary>
        public gvec5<T> zxzxy => new gvec5<T>(z, x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.brbrg swizzling (equivalent to gvec3.zxzxy).
        /// </summary>
        public gvec5<T> brbrg => new gvec5<T>(z, x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.zxzxz swizzling.
        /// </summary>
        public gvec5<T> zxzxz => new gvec5<T>(z, x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.brbrb swizzling (equivalent to gvec3.zxzxz).
        /// </summary>
        public gvec5<T> brbrb => new gvec5<T>(z, x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.zxzy swizzling.
        /// </summary>
        public gvec4<T> zxzy => new gvec4<T>(z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.brbg swizzling (equivalent to gvec3.zxzy).
        /// </summary>
        public gvec4<T> brbg => new gvec4<T>(z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.zxzyx swizzling.
        /// </summary>
        public gvec5<T> zxzyx => new gvec5<T>(z, x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.brbgr swizzling (equivalent to gvec3.zxzyx).
        /// </summary>
        public gvec5<T> brbgr => new gvec5<T>(z, x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.zxzyy swizzling.
        /// </summary>
        public gvec5<T> zxzyy => new gvec5<T>(z, x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.brbgg swizzling (equivalent to gvec3.zxzyy).
        /// </summary>
        public gvec5<T> brbgg => new gvec5<T>(z, x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.zxzyz swizzling.
        /// </summary>
        public gvec5<T> zxzyz => new gvec5<T>(z, x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.brbgb swizzling (equivalent to gvec3.zxzyz).
        /// </summary>
        public gvec5<T> brbgb => new gvec5<T>(z, x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.zxzz swizzling.
        /// </summary>
        public gvec4<T> zxzz => new gvec4<T>(z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.brbb swizzling (equivalent to gvec3.zxzz).
        /// </summary>
        public gvec4<T> brbb => new gvec4<T>(z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.zxzzx swizzling.
        /// </summary>
        public gvec5<T> zxzzx => new gvec5<T>(z, x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.brbbr swizzling (equivalent to gvec3.zxzzx).
        /// </summary>
        public gvec5<T> brbbr => new gvec5<T>(z, x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.zxzzy swizzling.
        /// </summary>
        public gvec5<T> zxzzy => new gvec5<T>(z, x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.brbbg swizzling (equivalent to gvec3.zxzzy).
        /// </summary>
        public gvec5<T> brbbg => new gvec5<T>(z, x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.zxzzz swizzling.
        /// </summary>
        public gvec5<T> zxzzz => new gvec5<T>(z, x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.brbbb swizzling (equivalent to gvec3.zxzzz).
        /// </summary>
        public gvec5<T> brbbb => new gvec5<T>(z, x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.zy swizzling.
        /// </summary>
        public gvec2<T> zy => new gvec2<T>(z, y);
        
        /// <summary>
        /// Returns gvec3.bg swizzling (equivalent to gvec3.zy).
        /// </summary>
        public gvec2<T> bg => new gvec2<T>(z, y);
        
        /// <summary>
        /// Returns gvec3.zyx swizzling.
        /// </summary>
        public gvec3<T> zyx => new gvec3<T>(z, y, x);
        
        /// <summary>
        /// Returns gvec3.bgr swizzling (equivalent to gvec3.zyx).
        /// </summary>
        public gvec3<T> bgr => new gvec3<T>(z, y, x);
        
        /// <summary>
        /// Returns gvec3.zyxx swizzling.
        /// </summary>
        public gvec4<T> zyxx => new gvec4<T>(z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.bgrr swizzling (equivalent to gvec3.zyxx).
        /// </summary>
        public gvec4<T> bgrr => new gvec4<T>(z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.zyxxx swizzling.
        /// </summary>
        public gvec5<T> zyxxx => new gvec5<T>(z, y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.bgrrr swizzling (equivalent to gvec3.zyxxx).
        /// </summary>
        public gvec5<T> bgrrr => new gvec5<T>(z, y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.zyxxy swizzling.
        /// </summary>
        public gvec5<T> zyxxy => new gvec5<T>(z, y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.bgrrg swizzling (equivalent to gvec3.zyxxy).
        /// </summary>
        public gvec5<T> bgrrg => new gvec5<T>(z, y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.zyxxz swizzling.
        /// </summary>
        public gvec5<T> zyxxz => new gvec5<T>(z, y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.bgrrb swizzling (equivalent to gvec3.zyxxz).
        /// </summary>
        public gvec5<T> bgrrb => new gvec5<T>(z, y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.zyxy swizzling.
        /// </summary>
        public gvec4<T> zyxy => new gvec4<T>(z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.bgrg swizzling (equivalent to gvec3.zyxy).
        /// </summary>
        public gvec4<T> bgrg => new gvec4<T>(z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.zyxyx swizzling.
        /// </summary>
        public gvec5<T> zyxyx => new gvec5<T>(z, y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.bgrgr swizzling (equivalent to gvec3.zyxyx).
        /// </summary>
        public gvec5<T> bgrgr => new gvec5<T>(z, y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.zyxyy swizzling.
        /// </summary>
        public gvec5<T> zyxyy => new gvec5<T>(z, y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.bgrgg swizzling (equivalent to gvec3.zyxyy).
        /// </summary>
        public gvec5<T> bgrgg => new gvec5<T>(z, y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.zyxyz swizzling.
        /// </summary>
        public gvec5<T> zyxyz => new gvec5<T>(z, y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.bgrgb swizzling (equivalent to gvec3.zyxyz).
        /// </summary>
        public gvec5<T> bgrgb => new gvec5<T>(z, y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.zyxz swizzling.
        /// </summary>
        public gvec4<T> zyxz => new gvec4<T>(z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.bgrb swizzling (equivalent to gvec3.zyxz).
        /// </summary>
        public gvec4<T> bgrb => new gvec4<T>(z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.zyxzx swizzling.
        /// </summary>
        public gvec5<T> zyxzx => new gvec5<T>(z, y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.bgrbr swizzling (equivalent to gvec3.zyxzx).
        /// </summary>
        public gvec5<T> bgrbr => new gvec5<T>(z, y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.zyxzy swizzling.
        /// </summary>
        public gvec5<T> zyxzy => new gvec5<T>(z, y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.bgrbg swizzling (equivalent to gvec3.zyxzy).
        /// </summary>
        public gvec5<T> bgrbg => new gvec5<T>(z, y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.zyxzz swizzling.
        /// </summary>
        public gvec5<T> zyxzz => new gvec5<T>(z, y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.bgrbb swizzling (equivalent to gvec3.zyxzz).
        /// </summary>
        public gvec5<T> bgrbb => new gvec5<T>(z, y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.zyy swizzling.
        /// </summary>
        public gvec3<T> zyy => new gvec3<T>(z, y, y);
        
        /// <summary>
        /// Returns gvec3.bgg swizzling (equivalent to gvec3.zyy).
        /// </summary>
        public gvec3<T> bgg => new gvec3<T>(z, y, y);
        
        /// <summary>
        /// Returns gvec3.zyyx swizzling.
        /// </summary>
        public gvec4<T> zyyx => new gvec4<T>(z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.bggr swizzling (equivalent to gvec3.zyyx).
        /// </summary>
        public gvec4<T> bggr => new gvec4<T>(z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.zyyxx swizzling.
        /// </summary>
        public gvec5<T> zyyxx => new gvec5<T>(z, y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.bggrr swizzling (equivalent to gvec3.zyyxx).
        /// </summary>
        public gvec5<T> bggrr => new gvec5<T>(z, y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.zyyxy swizzling.
        /// </summary>
        public gvec5<T> zyyxy => new gvec5<T>(z, y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.bggrg swizzling (equivalent to gvec3.zyyxy).
        /// </summary>
        public gvec5<T> bggrg => new gvec5<T>(z, y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.zyyxz swizzling.
        /// </summary>
        public gvec5<T> zyyxz => new gvec5<T>(z, y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.bggrb swizzling (equivalent to gvec3.zyyxz).
        /// </summary>
        public gvec5<T> bggrb => new gvec5<T>(z, y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.zyyy swizzling.
        /// </summary>
        public gvec4<T> zyyy => new gvec4<T>(z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.bggg swizzling (equivalent to gvec3.zyyy).
        /// </summary>
        public gvec4<T> bggg => new gvec4<T>(z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.zyyyx swizzling.
        /// </summary>
        public gvec5<T> zyyyx => new gvec5<T>(z, y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.bgggr swizzling (equivalent to gvec3.zyyyx).
        /// </summary>
        public gvec5<T> bgggr => new gvec5<T>(z, y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.zyyyy swizzling.
        /// </summary>
        public gvec5<T> zyyyy => new gvec5<T>(z, y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.bgggg swizzling (equivalent to gvec3.zyyyy).
        /// </summary>
        public gvec5<T> bgggg => new gvec5<T>(z, y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.zyyyz swizzling.
        /// </summary>
        public gvec5<T> zyyyz => new gvec5<T>(z, y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.bgggb swizzling (equivalent to gvec3.zyyyz).
        /// </summary>
        public gvec5<T> bgggb => new gvec5<T>(z, y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.zyyz swizzling.
        /// </summary>
        public gvec4<T> zyyz => new gvec4<T>(z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.bggb swizzling (equivalent to gvec3.zyyz).
        /// </summary>
        public gvec4<T> bggb => new gvec4<T>(z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.zyyzx swizzling.
        /// </summary>
        public gvec5<T> zyyzx => new gvec5<T>(z, y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.bggbr swizzling (equivalent to gvec3.zyyzx).
        /// </summary>
        public gvec5<T> bggbr => new gvec5<T>(z, y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.zyyzy swizzling.
        /// </summary>
        public gvec5<T> zyyzy => new gvec5<T>(z, y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.bggbg swizzling (equivalent to gvec3.zyyzy).
        /// </summary>
        public gvec5<T> bggbg => new gvec5<T>(z, y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.zyyzz swizzling.
        /// </summary>
        public gvec5<T> zyyzz => new gvec5<T>(z, y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.bggbb swizzling (equivalent to gvec3.zyyzz).
        /// </summary>
        public gvec5<T> bggbb => new gvec5<T>(z, y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.zyz swizzling.
        /// </summary>
        public gvec3<T> zyz => new gvec3<T>(z, y, z);
        
        /// <summary>
        /// Returns gvec3.bgb swizzling (equivalent to gvec3.zyz).
        /// </summary>
        public gvec3<T> bgb => new gvec3<T>(z, y, z);
        
        /// <summary>
        /// Returns gvec3.zyzx swizzling.
        /// </summary>
        public gvec4<T> zyzx => new gvec4<T>(z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.bgbr swizzling (equivalent to gvec3.zyzx).
        /// </summary>
        public gvec4<T> bgbr => new gvec4<T>(z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.zyzxx swizzling.
        /// </summary>
        public gvec5<T> zyzxx => new gvec5<T>(z, y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.bgbrr swizzling (equivalent to gvec3.zyzxx).
        /// </summary>
        public gvec5<T> bgbrr => new gvec5<T>(z, y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.zyzxy swizzling.
        /// </summary>
        public gvec5<T> zyzxy => new gvec5<T>(z, y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.bgbrg swizzling (equivalent to gvec3.zyzxy).
        /// </summary>
        public gvec5<T> bgbrg => new gvec5<T>(z, y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.zyzxz swizzling.
        /// </summary>
        public gvec5<T> zyzxz => new gvec5<T>(z, y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.bgbrb swizzling (equivalent to gvec3.zyzxz).
        /// </summary>
        public gvec5<T> bgbrb => new gvec5<T>(z, y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.zyzy swizzling.
        /// </summary>
        public gvec4<T> zyzy => new gvec4<T>(z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.bgbg swizzling (equivalent to gvec3.zyzy).
        /// </summary>
        public gvec4<T> bgbg => new gvec4<T>(z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.zyzyx swizzling.
        /// </summary>
        public gvec5<T> zyzyx => new gvec5<T>(z, y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.bgbgr swizzling (equivalent to gvec3.zyzyx).
        /// </summary>
        public gvec5<T> bgbgr => new gvec5<T>(z, y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.zyzyy swizzling.
        /// </summary>
        public gvec5<T> zyzyy => new gvec5<T>(z, y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.bgbgg swizzling (equivalent to gvec3.zyzyy).
        /// </summary>
        public gvec5<T> bgbgg => new gvec5<T>(z, y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.zyzyz swizzling.
        /// </summary>
        public gvec5<T> zyzyz => new gvec5<T>(z, y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.bgbgb swizzling (equivalent to gvec3.zyzyz).
        /// </summary>
        public gvec5<T> bgbgb => new gvec5<T>(z, y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.zyzz swizzling.
        /// </summary>
        public gvec4<T> zyzz => new gvec4<T>(z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.bgbb swizzling (equivalent to gvec3.zyzz).
        /// </summary>
        public gvec4<T> bgbb => new gvec4<T>(z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.zyzzx swizzling.
        /// </summary>
        public gvec5<T> zyzzx => new gvec5<T>(z, y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.bgbbr swizzling (equivalent to gvec3.zyzzx).
        /// </summary>
        public gvec5<T> bgbbr => new gvec5<T>(z, y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.zyzzy swizzling.
        /// </summary>
        public gvec5<T> zyzzy => new gvec5<T>(z, y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.bgbbg swizzling (equivalent to gvec3.zyzzy).
        /// </summary>
        public gvec5<T> bgbbg => new gvec5<T>(z, y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.zyzzz swizzling.
        /// </summary>
        public gvec5<T> zyzzz => new gvec5<T>(z, y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.bgbbb swizzling (equivalent to gvec3.zyzzz).
        /// </summary>
        public gvec5<T> bgbbb => new gvec5<T>(z, y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.zz swizzling.
        /// </summary>
        public gvec2<T> zz => new gvec2<T>(z, z);
        
        /// <summary>
        /// Returns gvec3.bb swizzling (equivalent to gvec3.zz).
        /// </summary>
        public gvec2<T> bb => new gvec2<T>(z, z);
        
        /// <summary>
        /// Returns gvec3.zzx swizzling.
        /// </summary>
        public gvec3<T> zzx => new gvec3<T>(z, z, x);
        
        /// <summary>
        /// Returns gvec3.bbr swizzling (equivalent to gvec3.zzx).
        /// </summary>
        public gvec3<T> bbr => new gvec3<T>(z, z, x);
        
        /// <summary>
        /// Returns gvec3.zzxx swizzling.
        /// </summary>
        public gvec4<T> zzxx => new gvec4<T>(z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.bbrr swizzling (equivalent to gvec3.zzxx).
        /// </summary>
        public gvec4<T> bbrr => new gvec4<T>(z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.zzxxx swizzling.
        /// </summary>
        public gvec5<T> zzxxx => new gvec5<T>(z, z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.bbrrr swizzling (equivalent to gvec3.zzxxx).
        /// </summary>
        public gvec5<T> bbrrr => new gvec5<T>(z, z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.zzxxy swizzling.
        /// </summary>
        public gvec5<T> zzxxy => new gvec5<T>(z, z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.bbrrg swizzling (equivalent to gvec3.zzxxy).
        /// </summary>
        public gvec5<T> bbrrg => new gvec5<T>(z, z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.zzxxz swizzling.
        /// </summary>
        public gvec5<T> zzxxz => new gvec5<T>(z, z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.bbrrb swizzling (equivalent to gvec3.zzxxz).
        /// </summary>
        public gvec5<T> bbrrb => new gvec5<T>(z, z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.zzxy swizzling.
        /// </summary>
        public gvec4<T> zzxy => new gvec4<T>(z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.bbrg swizzling (equivalent to gvec3.zzxy).
        /// </summary>
        public gvec4<T> bbrg => new gvec4<T>(z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.zzxyx swizzling.
        /// </summary>
        public gvec5<T> zzxyx => new gvec5<T>(z, z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.bbrgr swizzling (equivalent to gvec3.zzxyx).
        /// </summary>
        public gvec5<T> bbrgr => new gvec5<T>(z, z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.zzxyy swizzling.
        /// </summary>
        public gvec5<T> zzxyy => new gvec5<T>(z, z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.bbrgg swizzling (equivalent to gvec3.zzxyy).
        /// </summary>
        public gvec5<T> bbrgg => new gvec5<T>(z, z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.zzxyz swizzling.
        /// </summary>
        public gvec5<T> zzxyz => new gvec5<T>(z, z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.bbrgb swizzling (equivalent to gvec3.zzxyz).
        /// </summary>
        public gvec5<T> bbrgb => new gvec5<T>(z, z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.zzxz swizzling.
        /// </summary>
        public gvec4<T> zzxz => new gvec4<T>(z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.bbrb swizzling (equivalent to gvec3.zzxz).
        /// </summary>
        public gvec4<T> bbrb => new gvec4<T>(z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.zzxzx swizzling.
        /// </summary>
        public gvec5<T> zzxzx => new gvec5<T>(z, z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.bbrbr swizzling (equivalent to gvec3.zzxzx).
        /// </summary>
        public gvec5<T> bbrbr => new gvec5<T>(z, z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.zzxzy swizzling.
        /// </summary>
        public gvec5<T> zzxzy => new gvec5<T>(z, z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.bbrbg swizzling (equivalent to gvec3.zzxzy).
        /// </summary>
        public gvec5<T> bbrbg => new gvec5<T>(z, z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.zzxzz swizzling.
        /// </summary>
        public gvec5<T> zzxzz => new gvec5<T>(z, z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.bbrbb swizzling (equivalent to gvec3.zzxzz).
        /// </summary>
        public gvec5<T> bbrbb => new gvec5<T>(z, z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.zzy swizzling.
        /// </summary>
        public gvec3<T> zzy => new gvec3<T>(z, z, y);
        
        /// <summary>
        /// Returns gvec3.bbg swizzling (equivalent to gvec3.zzy).
        /// </summary>
        public gvec3<T> bbg => new gvec3<T>(z, z, y);
        
        /// <summary>
        /// Returns gvec3.zzyx swizzling.
        /// </summary>
        public gvec4<T> zzyx => new gvec4<T>(z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.bbgr swizzling (equivalent to gvec3.zzyx).
        /// </summary>
        public gvec4<T> bbgr => new gvec4<T>(z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.zzyxx swizzling.
        /// </summary>
        public gvec5<T> zzyxx => new gvec5<T>(z, z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.bbgrr swizzling (equivalent to gvec3.zzyxx).
        /// </summary>
        public gvec5<T> bbgrr => new gvec5<T>(z, z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.zzyxy swizzling.
        /// </summary>
        public gvec5<T> zzyxy => new gvec5<T>(z, z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.bbgrg swizzling (equivalent to gvec3.zzyxy).
        /// </summary>
        public gvec5<T> bbgrg => new gvec5<T>(z, z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.zzyxz swizzling.
        /// </summary>
        public gvec5<T> zzyxz => new gvec5<T>(z, z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.bbgrb swizzling (equivalent to gvec3.zzyxz).
        /// </summary>
        public gvec5<T> bbgrb => new gvec5<T>(z, z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.zzyy swizzling.
        /// </summary>
        public gvec4<T> zzyy => new gvec4<T>(z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.bbgg swizzling (equivalent to gvec3.zzyy).
        /// </summary>
        public gvec4<T> bbgg => new gvec4<T>(z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.zzyyx swizzling.
        /// </summary>
        public gvec5<T> zzyyx => new gvec5<T>(z, z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.bbggr swizzling (equivalent to gvec3.zzyyx).
        /// </summary>
        public gvec5<T> bbggr => new gvec5<T>(z, z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.zzyyy swizzling.
        /// </summary>
        public gvec5<T> zzyyy => new gvec5<T>(z, z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.bbggg swizzling (equivalent to gvec3.zzyyy).
        /// </summary>
        public gvec5<T> bbggg => new gvec5<T>(z, z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.zzyyz swizzling.
        /// </summary>
        public gvec5<T> zzyyz => new gvec5<T>(z, z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.bbggb swizzling (equivalent to gvec3.zzyyz).
        /// </summary>
        public gvec5<T> bbggb => new gvec5<T>(z, z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.zzyz swizzling.
        /// </summary>
        public gvec4<T> zzyz => new gvec4<T>(z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.bbgb swizzling (equivalent to gvec3.zzyz).
        /// </summary>
        public gvec4<T> bbgb => new gvec4<T>(z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.zzyzx swizzling.
        /// </summary>
        public gvec5<T> zzyzx => new gvec5<T>(z, z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.bbgbr swizzling (equivalent to gvec3.zzyzx).
        /// </summary>
        public gvec5<T> bbgbr => new gvec5<T>(z, z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.zzyzy swizzling.
        /// </summary>
        public gvec5<T> zzyzy => new gvec5<T>(z, z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.bbgbg swizzling (equivalent to gvec3.zzyzy).
        /// </summary>
        public gvec5<T> bbgbg => new gvec5<T>(z, z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.zzyzz swizzling.
        /// </summary>
        public gvec5<T> zzyzz => new gvec5<T>(z, z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.bbgbb swizzling (equivalent to gvec3.zzyzz).
        /// </summary>
        public gvec5<T> bbgbb => new gvec5<T>(z, z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.zzz swizzling.
        /// </summary>
        public gvec3<T> zzz => new gvec3<T>(z, z, z);
        
        /// <summary>
        /// Returns gvec3.bbb swizzling (equivalent to gvec3.zzz).
        /// </summary>
        public gvec3<T> bbb => new gvec3<T>(z, z, z);
        
        /// <summary>
        /// Returns gvec3.zzzx swizzling.
        /// </summary>
        public gvec4<T> zzzx => new gvec4<T>(z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.bbbr swizzling (equivalent to gvec3.zzzx).
        /// </summary>
        public gvec4<T> bbbr => new gvec4<T>(z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.zzzxx swizzling.
        /// </summary>
        public gvec5<T> zzzxx => new gvec5<T>(z, z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.bbbrr swizzling (equivalent to gvec3.zzzxx).
        /// </summary>
        public gvec5<T> bbbrr => new gvec5<T>(z, z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.zzzxy swizzling.
        /// </summary>
        public gvec5<T> zzzxy => new gvec5<T>(z, z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.bbbrg swizzling (equivalent to gvec3.zzzxy).
        /// </summary>
        public gvec5<T> bbbrg => new gvec5<T>(z, z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.zzzxz swizzling.
        /// </summary>
        public gvec5<T> zzzxz => new gvec5<T>(z, z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.bbbrb swizzling (equivalent to gvec3.zzzxz).
        /// </summary>
        public gvec5<T> bbbrb => new gvec5<T>(z, z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.zzzy swizzling.
        /// </summary>
        public gvec4<T> zzzy => new gvec4<T>(z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.bbbg swizzling (equivalent to gvec3.zzzy).
        /// </summary>
        public gvec4<T> bbbg => new gvec4<T>(z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.zzzyx swizzling.
        /// </summary>
        public gvec5<T> zzzyx => new gvec5<T>(z, z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.bbbgr swizzling (equivalent to gvec3.zzzyx).
        /// </summary>
        public gvec5<T> bbbgr => new gvec5<T>(z, z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.zzzyy swizzling.
        /// </summary>
        public gvec5<T> zzzyy => new gvec5<T>(z, z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.bbbgg swizzling (equivalent to gvec3.zzzyy).
        /// </summary>
        public gvec5<T> bbbgg => new gvec5<T>(z, z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.zzzyz swizzling.
        /// </summary>
        public gvec5<T> zzzyz => new gvec5<T>(z, z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.bbbgb swizzling (equivalent to gvec3.zzzyz).
        /// </summary>
        public gvec5<T> bbbgb => new gvec5<T>(z, z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.zzzz swizzling.
        /// </summary>
        public gvec4<T> zzzz => new gvec4<T>(z, z, z, z);
        
        /// <summary>
        /// Returns gvec3.bbbb swizzling (equivalent to gvec3.zzzz).
        /// </summary>
        public gvec4<T> bbbb => new gvec4<T>(z, z, z, z);
        
        /// <summary>
        /// Returns gvec3.zzzzx swizzling.
        /// </summary>
        public gvec5<T> zzzzx => new gvec5<T>(z, z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.bbbbr swizzling (equivalent to gvec3.zzzzx).
        /// </summary>
        public gvec5<T> bbbbr => new gvec5<T>(z, z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.zzzzy swizzling.
        /// </summary>
        public gvec5<T> zzzzy => new gvec5<T>(z, z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.bbbbg swizzling (equivalent to gvec3.zzzzy).
        /// </summary>
        public gvec5<T> bbbbg => new gvec5<T>(z, z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.zzzzz swizzling.
        /// </summary>
        public gvec5<T> zzzzz => new gvec5<T>(z, z, z, z, z);
        
        /// <summary>
        /// Returns gvec3.bbbbb swizzling (equivalent to gvec3.zzzzz).
        /// </summary>
        public gvec5<T> bbbbb => new gvec5<T>(z, z, z, z, z);

        #endregion

    }
}
