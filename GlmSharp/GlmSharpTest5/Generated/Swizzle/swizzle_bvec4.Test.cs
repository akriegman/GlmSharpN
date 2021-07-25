using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Swizzle
{
    [TestFixture]
    public class BoolSwizzleVec4Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xxxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xxxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xxxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xxxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xxxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xxxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xxxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xxxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xxxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xxxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xxxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xxyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xxyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xxyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xxyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xxyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xxywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xxywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xxywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xxyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xxzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xxzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xxzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xxzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xxzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xxzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xxzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xxzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xxzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xxzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xxwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xxwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xxwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xxwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xxwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xxwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xxwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xxwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xxwzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xxwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xxwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xxwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xxwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xxwww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xyxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xyxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xyxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xyxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xyxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xyxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xyxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xyxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xyxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xyxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xyyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xyyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xyyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xyyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xyyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xyyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xyyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xyywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xyywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xyywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xyzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xyzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xyzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xyzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xyzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xyzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xyzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xyzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xyzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xyzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xyzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xyzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xyzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xyzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xyzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xyzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xywxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xywxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xywxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xywxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xywyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xywyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xywyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xywyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xywzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xywzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xywzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xywzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xywwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xywwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xywwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xywww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xzxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xzxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xzxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xzxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xzxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xzxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xzxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xzxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xzxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xzxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xzxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xzxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xzxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xzxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xzxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xzxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xzyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xzyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xzyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xzyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xzyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xzyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xzyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xzyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xzyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xzyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xzyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xzyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xzywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xzywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xzywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xzyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xzzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xzzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xzzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xzzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xzzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xzzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xzzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xzzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xzzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xzzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xzzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xzzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xzzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xzzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xzzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xzzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xzwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xzwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xzwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xzwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xzwyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xzwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xzwyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xzwyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xzwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xzwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xzwzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xzwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xzwwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xzwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xzwwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xzwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xwxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xwxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xwxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xwxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xwxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xwxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xwxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xwxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xwxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xwxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xwxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xwxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xwxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xwxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xwxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xwxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xwxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xwyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xwyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xwyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xwyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xwyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xwyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xwyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xwyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xwyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xwyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xwyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xwyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwyzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xwyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xwywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xwyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.xwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xwzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xwzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xwzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xwzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xwzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xwzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xwzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.xwzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xwzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xwzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.xwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.xwzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.xwzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xwzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xwzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xwwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xwwxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xwwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.xwwxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.xwwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.xwwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.xwwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.xwwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.xwwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xwwzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.xwwzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.xwwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xwwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.xwwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.xwwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.xwwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yxxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yxxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yxxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yxxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yxxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yxxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yxxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yxxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yxxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yxxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yxxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yxxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yxyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yxyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yxyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yxyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yxyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yxywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yxywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yxywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yxyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yxzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yxzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yxzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yxzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yxzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yxzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yxzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yxzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yxzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yxzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yxwxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yxwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yxwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yxwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yxwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yxwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yxwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yxwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yxwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yxwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yxwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yxwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yxwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yxwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yyxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yyxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yyxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yyxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yyxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yyxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yyxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yyxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yyxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yyxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yyxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yyxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yyyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yyyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yyyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yyyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yyyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yyyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yyyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yyyzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yyywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yyywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yyywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yyyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yyzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yyzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yyzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yyzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yyzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yyzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yyzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yyzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yyzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yyzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yyzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yyzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yyzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yyzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yyzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yyzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yywxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yywxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yywxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yywxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yywyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yywyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yywyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yywyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yywzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yywzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yywzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yywzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yywwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yywwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yywwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yywww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yzxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yzxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yzxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yzxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yzxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yzxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yzxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yzxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yzxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yzxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yzxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yzxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yzxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yzxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yzxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yzyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yzyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yzyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yzyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yzyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yzyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yzyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yzyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yzyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yzyzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yzywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yzywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yzyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yzzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yzzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yzzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.yzzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yzzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yzzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yzzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.yzzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yzzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yzzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yzzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yzzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yzzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.yzzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yzzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yzzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.yzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yzwxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.yzwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yzwxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yzwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yzwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.yzwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yzwyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.yzwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.yzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yzwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.yzwzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.yzwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.yzwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.yzwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.yzwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.yw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ywxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.ywxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ywxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ywxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ywxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.ywxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ywxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ywxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ywxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ywxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ywxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ywxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.ywxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ywxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.ywxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.ywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ywyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ywyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ywyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ywyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ywyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ywyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ywyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ywyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ywyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ywyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ywyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ywyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ywyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ywyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ywyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ywyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.ywywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ywyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ywzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ywzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ywzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.ywzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ywzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ywzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ywzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ywzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ywzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ywzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ywzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ywzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ywzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ywzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.ywzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ywzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.yww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ywwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ywwxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ywwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ywwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.ywwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.ywwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ywwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ywwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ywwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ywwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ywww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ywwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ywwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.ywwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ywwww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zxxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zxxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zxxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zxxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zxxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zxxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zxxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zxxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zxxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zxxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zxxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zxyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zxyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zxyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zxyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zxyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zxyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zxyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zxyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zxyzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zxywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zxywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zxyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zxzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zxzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zxzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zxzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zxzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zxzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zxzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zxzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zxzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zxzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zxzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zxwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zxwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zxwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zxwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zxwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zxwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zxwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zxwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zxwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zxwwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zxwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zxwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zxwww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zyxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zyxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zyxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zyxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zyxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zyxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zyxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zyxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zyxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zyxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zyxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zyxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zyxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zyxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zyxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zyxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zyyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zyyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zyyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zyyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zyyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zyyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zyyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zyyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zyyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zyyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zyyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zyyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zyywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zyywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zyywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zyyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zyzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zyzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zyzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zyzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zyzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zyzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zyzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zyzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zyzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zyzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zyzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zyzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zyzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zyzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zyzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zyzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zywxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zywxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zywxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zywxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zywyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zywyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zywyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zywyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zywzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zywzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zywzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zywzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zywwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zywwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zywwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zywww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zzxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zzxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zzxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zzxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zzxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zzxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zzxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zzxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zzxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zzxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zzxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zzxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zzxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zzxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zzxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zzxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zzyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zzyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zzyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zzyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zzyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zzyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zzyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zzyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zzyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zzyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zzyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zzyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zzywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zzywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zzywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zzyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zzzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zzzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zzzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zzzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zzzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zzzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zzzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zzzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zzzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zzzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zzzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zzzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zzzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zzzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zzzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zzzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zzwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zzwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zzwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zzwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zzwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zzwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zzwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zzwyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zzwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zzwzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zzwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zzwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zzwwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zzwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zzwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zzwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zwxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zwxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zwxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zwxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zwxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zwxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zwxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zwxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zwxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zwxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zwxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zwxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zwyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zwyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zwyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zwyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zwyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zwyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zwyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zwyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zwyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zwyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zwyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zwyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zwyzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.zwyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zwywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zwywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zwywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zwyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zwzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zwzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zwzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zwzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.zwzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zwzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zwzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zwzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zwzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zwzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.zwzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.zwzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zwzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.zwzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.zwzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.zwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zwwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zwwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zwwxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zwwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zwwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zwwyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zwwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.zwwyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.zwwyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zwwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zwwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zwwzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.zwwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.zwwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.zwww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.zwwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.zwwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.zwwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.zwwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wxxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wxxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wxxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wxxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wxxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wxxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wxxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wxxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wxyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wxyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wxyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wxyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wxyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wxyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wxyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wxyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wxyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wxywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wxywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wxywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wxzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wxzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wxzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wxzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wxzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wxzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wxzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wxzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wxzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wxzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wxzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wxwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wxwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wxwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wxwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wxwyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wxwyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wxwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wxwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wxwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wxwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wxwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wxwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wxwwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wxwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wyxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wyxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wyxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wyxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wyxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wyxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wyxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wyxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wyxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wyxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wyxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wyxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wyxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wyxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wyxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wyxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wyyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wyyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wyyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wyyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wyyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wyyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wyyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wyyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wyyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wyyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wyyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wyyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wyywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wyywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wyywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wyyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wyzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wyzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wyzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wyzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wyzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wyzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wyzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wyzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wyzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wyzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wyzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wyzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wyzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wyzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wyzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wyzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wyzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wywxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wywxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wywxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wywxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wywyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wywyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wywyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wywyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wywzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wywzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wywzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wywzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wywwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wywwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wywwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wywww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wzxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wzxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wzxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wzxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wzxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wzxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wzxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wzxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wzxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wzxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wzxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wzxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wzxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wzxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wzxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wzxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wzyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wzyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wzyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wzyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wzyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wzyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wzyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wzyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wzyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wzyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wzyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wzyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wzywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wzywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wzywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wzyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wzzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wzzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wzzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wzzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wzzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wzzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wzzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wzzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wzzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wzzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wzzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wzzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wzzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wzzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wzzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wzzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wzwxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wzwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wzwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wzwxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wzwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wzwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wzwyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wzwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wzwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wzwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wzwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wzwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wzwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wzwwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wzwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wzwww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.ww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wwxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wwxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wwxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wwxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wwxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wwxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wwxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wwxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wwxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wwxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wwxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wwxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wwxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wwxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wwxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wwxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wwxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wwxww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wwyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wwyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wwyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wwyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wwyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wwyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wwyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wwyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wwyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wwyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wwyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wwyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.wwyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wwywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wwywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wwywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wwyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wwzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wwzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wwzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wwzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wwzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wwzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wwzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wwzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wwzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.wwzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wwzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wwzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wwzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wwzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wwzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wwzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.wwzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.www;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wwwxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wwwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.wwwxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.wwwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wwwyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.wwwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wwwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.wwwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.wwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.wwwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wwwzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.wwwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.wwwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.wwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.wwwwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.wwwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.wwwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.wwwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rrrrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rrrra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rrrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rrrga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rrrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rrrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rrrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rrrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rrra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rrrar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rrrag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rrrab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rrraa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rrgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rrgra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rrggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rrgga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rrgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rrgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rrgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rrgba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rrga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rrgar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rrgag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rrgab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rrgaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rrbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rrbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rrbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rrbra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rrbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rrbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rrbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rrbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rrbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rrbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rrbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rrbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rrbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rrbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rrbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rrbaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rrar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rrarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rrarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rrarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rrara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rrag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rragr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rragg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rragb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rraga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rrab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rrabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rrabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rrabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rraba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rraar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rraag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rraab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rraaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rgrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rgrra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rgrga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rgrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rgrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rgrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rgrar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rgrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rgrab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rgraa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rggrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rggra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rgggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rggga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rggbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rggbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rggbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rggba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rgga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rggar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rggag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rggab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rggaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rgbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rgbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rgbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rgbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rgbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rgbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rgbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rgbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rgbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rgba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rgbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rgbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rgbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rgbaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rgar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rgarr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rgarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rgarb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rgara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rgag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rgagr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rgagg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgagb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rgaga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rgab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rgabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rgabg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rgabb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rgaba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rgaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rgaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rgaag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rgaab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rgaaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rbrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rbrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rbrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rbrra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rbrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rbrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rbrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rbrga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rbrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rbrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rbrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rbrba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rbrar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rbrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rbrab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rbraa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rbgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rbgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rbgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rbgra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rbggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rbggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rbggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rbgga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rbgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rbgbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rbgba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rbga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rbgar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbgag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rbgab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rbgaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rbbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rbbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rbbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rbbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rbbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rbbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rbbga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rbbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rbbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rbbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rbbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rbba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rbbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rbbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rbbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rbbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rbar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rbarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rbarg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rbara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rbagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rbagb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rbaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rbabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rbabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbaba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rbaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rbaag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rbaab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rbaaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.ra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rarr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rarrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rarrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rarrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rarra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.rargr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.rargg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rargb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rarga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rarbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rarbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rarbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rarba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rarar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.rarag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rarab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.raraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ragr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ragrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ragrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ragrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ragra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ragg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.raggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.raggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.raggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.ragga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ragb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ragbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ragbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ragbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ragba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.raga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.ragar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ragag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ragab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ragaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.rabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.rabrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.rabrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.rabrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rabra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.rabg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.rabgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.rabgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rabgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rabga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rabb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.rabbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rabbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.rabbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rabba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.raba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.rabar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.rabag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.rabab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.rabaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.raa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.raar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.raarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.raarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.raarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.raara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.raag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.raagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.raagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.raagb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.raaga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.raab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.raabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.raabg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.raabb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.raaba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.raaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.raaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.raaag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.raaab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.raaaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.grr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.grrrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.grrra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.grrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.grrga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.grrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.grrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.grrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.grrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.grra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.grrar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.grrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.grrab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.grraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.grg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.grgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.grgra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.grggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.grgga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.grgbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.grgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.grgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.grgba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.grga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.grgar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.grgag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.grgab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.grgaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.grb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.grbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.grbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.grbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.grbra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.grbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.grbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.grbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.grbga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.grbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.grbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.grbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.grbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.grba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.grbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.grbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.grbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.grbaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.grar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.grarr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.grarg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.grarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.grara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.grag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gragr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gragg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gragb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.graga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.grab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.grabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.grabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.grabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.graba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.graa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.graar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.graag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.graab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.graaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ggrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ggrra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ggrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ggrga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.ggrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.ggrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ggrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ggrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ggra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.ggrar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.ggrag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ggrab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ggraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gggrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.gggra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ggggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gggga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gggbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gggbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gggbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gggba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ggga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.gggar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gggag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gggab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.gggaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ggbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ggbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ggbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ggbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ggbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ggbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ggbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ggbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ggbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.ggbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.ggbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ggbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.ggba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ggbar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ggbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ggbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.ggbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ggar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ggarr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ggarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.ggarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.ggara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ggag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ggagr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.ggagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ggagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.ggaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ggab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ggabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ggabg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ggabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.ggaba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ggaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ggaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ggaag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ggaab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.ggaaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gbrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gbrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gbrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.gbrra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gbrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gbrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gbrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gbrga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gbrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.gbrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.gbrba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gbrar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gbrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gbrab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gbraa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gbgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gbgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gbgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbgra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.gbggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.gbggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.gbggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.gbgga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gbgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gbgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.gbgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gbgba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gbgar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.gbgag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gbgab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gbgaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gbbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gbbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gbbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.gbbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gbbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gbbga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gbbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gbbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gbbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gbbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gbba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gbbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.gbbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gbbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.gbbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.gbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.gbarr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.gbarg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gbarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gbara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.gbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.gbagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gbagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gbagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gbaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gbabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbabg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gbabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.gbaba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.gbaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gbaag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gbaab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gbaaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.garr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.garrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.garrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.garrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.garra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.garg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gargr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gargg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gargb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.garga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.garb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.garbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.garbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.garbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.garba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.garar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.garag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.garab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.garaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gagrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gagrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.gagrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.gagra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.gagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gaggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gaggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gaggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gagga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.gagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gagbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gagbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gagbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gagba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gagar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gagag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gagab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.gagaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.gabrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gabrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.gabrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.gabra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gabg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gabgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gabgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gabgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gabga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gabb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.gabbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gabbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gabbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gabba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gaba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gabar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gabag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gabab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gabaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.gaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.gaarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gaarg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.gaarb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gaara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.gaag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.gaagr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.gaagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.gaagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gaaga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gaab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.gaabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.gaabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gaabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.gaaba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.gaaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.gaaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.gaaag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.gaaab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.gaaaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.br;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.brr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.brrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.brrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.brrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.brrra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.brrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.brrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.brrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.brrga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.brrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.brrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.brrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.brrba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.brra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.brrar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.brrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.brrab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.brraa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.brg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.brgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.brgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.brgrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.brgra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.brggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.brggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.brggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.brgga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.brgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.brgbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.brgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.brgba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.brga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.brgar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.brgag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.brgab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.brgaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.brb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.brbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.brbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.brbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.brbra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.brbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.brbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.brbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.brbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.brbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.brbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.brbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.brbba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.brba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.brbar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.brbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.brbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.brbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.brar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.brarr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.brarg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.brarb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.brara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.brag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bragr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bragg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bragb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.braga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.brab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.brabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.brabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.brabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.braba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.braa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.braar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.braag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.braab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.braaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bgrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bgrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bgrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bgrra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bgrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bgrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bgrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bgrga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bgrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bgrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bgrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bgrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bgra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bgrar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bgrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bgrab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bgraa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bggrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bggrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bggra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bgggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bgggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bgggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bggga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bggbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bggbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bggba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bgga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bggar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bggag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bggab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bggaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bgbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bgbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bgbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bgbra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.bgbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bgbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bgbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bgbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bgbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bgbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bgbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bgbba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bgba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bgbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bgbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bgbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bgbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bgar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bgarr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bgarg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bgarb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bgara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bgag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bgagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bgagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bgagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bgaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bgab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bgabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bgabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bgabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bgaba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bgaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bgaar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bgaag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bgaab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bgaaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bbrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.bbrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bbrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bbrra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bbrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bbrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bbrga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bbrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bbrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bbrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bbrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bbra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bbrar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bbrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bbrab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bbraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bbgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bbgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbgrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bbgra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bbggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bbggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbgga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbgbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bbgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bbgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bbgba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bbgar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bbgag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bbgab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bbgaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.bbbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bbbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bbbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bbbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bbbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bbbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bbbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bbbga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bbbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bbbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bbbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bbbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bbbar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bbbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bbbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.bbar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bbarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bbarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bbara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.bbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bbagr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.bbagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bbagb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bbaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.bbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bbabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bbabg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bbabb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bbaba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bbaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bbaar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bbaag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bbaab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.bbaaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.barr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.barrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.barrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.barrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.barra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.barg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bargr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.bargg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bargb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.barga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.barb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.barbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.barbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.barbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.barba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.bara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.barar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.barag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.barab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.baraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.bagr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bagrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bagrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bagrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bagra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.bagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.baggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.baggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.baggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bagga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.bagbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.bagbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.bagbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.bagba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.baga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.bagar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bagag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.bagab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.bagaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.bab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.babr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.babrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.babrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.babrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.babra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.babg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.babgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.babgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.babgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.babga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.babb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.babbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.babbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.babbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.babba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.baba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.babar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.babag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.babab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.babaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.baa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.baar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.baarr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.baarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.baarb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.baara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.baag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.baagr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.baagg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.baagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.baaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.baab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.baabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.baabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.baabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.baaba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.baaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.baaar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.baaag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.baaab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.baaaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.arr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.arrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.arrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.arrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arrrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.arrra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.arrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.arrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.arrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.arrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.arrga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.arrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.arrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.arrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.arra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.arrar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arrag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.arrab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.arraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.arg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.argr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.argrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.argrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.argrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.argra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.argg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.arggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.arggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.arggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.argga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.argb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.argbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.argbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.argbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.argba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.arga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.argar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.argag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.argab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.argaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.arb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.arbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.arbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.arbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.arbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arbra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.arbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.arbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.arbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.arbga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.arbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.arbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.arbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.arbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.arbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.arba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.arbar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.arbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.arbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.arbaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.ara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.ararr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.ararg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.ararb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.arara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.aragr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.aragg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.aragb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.araga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.arab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.arabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.arabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.arabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.araba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.araa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.araar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.araag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.araab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.araaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.ag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.agr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.agrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.agrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.agrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.agrrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.agrra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.agrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.agrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.agrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.agrga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.agrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.agrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.agrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.agrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.agrba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.agra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.agrar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.agrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.agrab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.agraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.agg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.aggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.aggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.aggrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.aggrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.aggra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.aggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.agggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.agggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.agggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.aggga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.aggbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.aggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.aggbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aggba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.agga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aggar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.aggag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.aggab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.aggaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.agbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.agbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.agbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.agbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.agbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.agbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.agbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.agbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.agbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.agbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.agbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.agbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.agbba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.agba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.agbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.aga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.agar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.agarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.agarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.agara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.agag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.agagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.agagg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.agagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.agaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.agab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.agabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.agabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.agabb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.agaba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.agaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.agaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.agaag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.agaab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.agaaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.ab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.abrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.abrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.abrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.abrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.abrra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.abrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.abrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.abrga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.abrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.abrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.abrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.abrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abrba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.abra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.abrar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.abrag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.abrab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abraa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.abg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.abgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.abgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.abgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.abgrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abgra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.abgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.abggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.abggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.abggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.abgga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.abgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.abgbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.abgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.abgba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.abga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.abgar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.abgag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.abgab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.abgaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.abb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.abbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.abbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.abbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.abbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.abbra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.abbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.abbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.abbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.abbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.abbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.abbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.abbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.abbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.abbba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.abba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.abbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.abbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.abbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.abbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.aba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.abar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.abarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.abarg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.abarb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.abara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.abag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.abagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.abagg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.abagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.abaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.abab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.ababr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.ababg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.ababb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.ababa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.abaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.abaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.abaag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.abaab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.abaaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.aa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.aarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.aarrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aarrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aarrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.aarra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.aarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.aargr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.aargg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aargb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.aarga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.aarb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.aarbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.aarbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aarbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.aarba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.aara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.aarar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.aarag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aarab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.aaraa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.aagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.aagrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.aagrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.aagrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.aagra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aagg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.aaggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.aaggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.aaggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aagga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.aagb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.aagbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.aagbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.aagbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aagba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.aaga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.aagar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.aagag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aagab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.aagaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.aabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aabrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.aabrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.aabrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, false);
                var v = ov.swizzle.aabra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.aabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aabgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.aabgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aabgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aabga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.aabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(false, false, true, false);
                var v = ov.swizzle.aabbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aabbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.aabbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, true);
                var v = ov.swizzle.aabba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.aaba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aabar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aabag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.aabab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.aabaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.aaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec4(true, true, false, false);
                var v = ov.swizzle.aaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aaarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.aaarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, false, false);
                var v = ov.swizzle.aaarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.aaara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aaag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.aaagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, true, true);
                var v = ov.swizzle.aaagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.aaagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, false);
                var v = ov.swizzle.aaaga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(true, false, true, false);
                var v = ov.swizzle.aaab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.aaabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, false, true, true);
                var v = ov.swizzle.aaabg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec4(false, true, true, true);
                var v = ov.swizzle.aaabb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, true);
                var v = ov.swizzle.aaaba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(false, false, false, false);
                var v = ov.swizzle.aaaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec4(true, true, true, false);
                var v = ov.swizzle.aaaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, false, true);
                var v = ov.swizzle.aaaag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, true, true, true);
                var v = ov.swizzle.aaaab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec4(true, false, false, true);
                var v = ov.swizzle.aaaaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new bvec4(true, true, true, false);
                var v1 = new bvec2(true, true);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bvec4(true, true, false, false);
                var v1 = new bvec2(true, true);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec4(false, true, false, true);
                var v1 = new bvec2(false, false);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec4(false, true, false, true);
                var v1 = new bvec3(false, true, false);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bvec4(true, true, false, false);
                var v1 = new bvec2(false, true);
                var v2 = v0.xw;
                v0.xw = v1;
                var v3 = v0.xw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec4(false, true, true, false);
                var v1 = new bvec2(false, true);
                var v2 = v0.yw;
                v0.yw = v1;
                var v3 = v0.yw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec4(false, false, true, true);
                var v1 = new bvec3(true, false, true);
                var v2 = v0.xyw;
                v0.xyw = v1;
                var v3 = v0.xyw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(true, v2.z);
            }
            {
                var v0 = new bvec4(false, true, false, true);
                var v1 = new bvec2(true, true);
                var v2 = v0.zw;
                v0.zw = v1;
                var v3 = v0.zw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bvec4(false, true, true, false);
                var v1 = new bvec3(false, true, false);
                var v2 = v0.xzw;
                v0.xzw = v1;
                var v3 = v0.xzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bvec4(true, false, true, false);
                var v1 = new bvec3(false, true, true);
                var v2 = v0.yzw;
                v0.yzw = v1;
                var v3 = v0.yzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bvec4(false, true, false, true);
                var v1 = new bvec4(true, false, true, true);
                var v2 = v0.xyzw;
                v0.xyzw = v1;
                var v3 = v0.xyzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(false, v2.z);
                Assert.AreEqual(true, v2.w);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new bvec4(false, true, false, false);
                var v1 = true;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2);
            }
            {
                var v0 = new bvec4(true, true, true, true);
                var v1 = true;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec4(false, true, false, true);
                var v1 = new bvec2(false, false);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bvec4(false, true, true, true);
                var v1 = false;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec4(true, true, false, false);
                var v1 = new bvec2(true, true);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec4(false, false, false, true);
                var v1 = new bvec2(true, true);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec4(false, true, false, true);
                var v1 = new bvec3(false, false, false);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bvec4(false, true, true, true);
                var v1 = true;
                var v2 = v0.a;
                v0.a = v1;
                var v3 = v0.a;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec4(true, false, true, false);
                var v1 = new bvec2(true, false);
                var v2 = v0.ra;
                v0.ra = v1;
                var v3 = v0.ra;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec4(false, false, false, true);
                var v1 = new bvec2(false, false);
                var v2 = v0.ga;
                v0.ga = v1;
                var v3 = v0.ga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bvec4(true, false, false, false);
                var v1 = new bvec3(false, true, false);
                var v2 = v0.rga;
                v0.rga = v1;
                var v3 = v0.rga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bvec4(true, true, true, true);
                var v1 = new bvec2(true, false);
                var v2 = v0.ba;
                v0.ba = v1;
                var v3 = v0.ba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bvec4(true, true, true, false);
                var v1 = new bvec3(true, true, false);
                var v2 = v0.rba;
                v0.rba = v1;
                var v3 = v0.rba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bvec4(true, false, false, false);
                var v1 = new bvec3(false, false, false);
                var v2 = v0.gba;
                v0.gba = v1;
                var v3 = v0.gba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bvec4(false, false, true, true);
                var v1 = new bvec4(false, false, false, true);
                var v2 = v0.rgba;
                v0.rgba = v1;
                var v3 = v0.rgba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(true, v2.z);
                Assert.AreEqual(true, v2.w);
            }
        }

    }
}
