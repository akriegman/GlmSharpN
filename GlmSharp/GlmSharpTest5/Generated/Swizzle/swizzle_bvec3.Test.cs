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
    public class BoolSwizzleVec3Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xxxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xxxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xxxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xxyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xxyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xxyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xxzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xxzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xxzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xyxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xyxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xyyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xyyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xyzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xyzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xyzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xyzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xyzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xyzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xyzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xzxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xzxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xzxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xzxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xzxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xzxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xzxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xzxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xzyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xzyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xzyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xzyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xzyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xzyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xzzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xzzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xzzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xzzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xzzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xzzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xzzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xzzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xzzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yxxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yxxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yxxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yxxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yxyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yxyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yxyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yxzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yxzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yxzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yxzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yxzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yxzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yxzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yyxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yyxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yyxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yyxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yyyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yyyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yyzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yyzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yyzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yyzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yyzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yyzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yzxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yzxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yzxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yzxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yzxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yzxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yzxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yzxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yzyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yzyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yzyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yzyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yzyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yzyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yzyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yzyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yzzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yzzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yzzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yzzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zxxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zxxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zxxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zxxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zxxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zxxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zxyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zxyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zxyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zxyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zxyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zxyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zxyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zxzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zxzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zxzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zxzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zxzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zxzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zxzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zyxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zyxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zyxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zyxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zyxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zyxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zyyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zyyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zyyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zyyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zyyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zyyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zyyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zyyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zyyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zyzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zyzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zyzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zyzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zyzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zyzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zyzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zyzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zzxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zzxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zzxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zzxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zzxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zzyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zzyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zzyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zzyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zzyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zzyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zzzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zzzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zzzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zzzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zzzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zzzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzzzz;
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
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rrrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rrrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rrrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rrgrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rrggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rrgbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rrgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rrbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rrbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rrbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rrbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rrbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rgrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rgrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rgrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rggrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rggbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rggbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rgbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rgbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rgbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rgbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rgbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rgbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rgbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rgbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rbrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rbrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rbrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rbrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rbrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rbrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rbrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rbgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rbgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rbggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rbggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rbgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rbgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rbgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rbbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rbbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rbbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rbbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rbbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rbbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rbbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rbbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.grr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.grrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.grrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.grrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.grrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.grg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.grgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.grggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.grgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.grgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.grb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.grbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.grbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.grbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.grbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.grbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.grbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.gg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.ggrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.ggrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.ggrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.ggrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.ggrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gggrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.ggggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.gggbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gggbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.ggbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.ggbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.ggbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.ggbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.ggbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.ggbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.ggbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.ggbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.ggbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gbrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.gbrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.gbrrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gbrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.gbrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gbrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.gbrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gbrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gbrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.gbgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.gbggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gbgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.gbgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.gbgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.gbbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.gbbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.gbbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gbbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.gbbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.br;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.brr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.brrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.brrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.brrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.brrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.brrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.brrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.brrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.brrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.brgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.brgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.brgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.brgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.brgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.brgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.brb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.brbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.brbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.brbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.brbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.brbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.brbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.brbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.brbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bgrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bgrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bgrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bgrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bgrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bgrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bgrbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bgrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bgrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bggrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bggrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bgggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bgggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bgggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bggbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bggbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.bgbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bgbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bgbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bgbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bgbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bgbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bgbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bgbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bgbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bbrrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.bbrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bbrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bbrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.bbrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bbgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bbggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bbgbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bbgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.bbbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bbbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.bbbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bbbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bbbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bbbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bbbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new bvec3(false, false, false);
                var v1 = new bvec2(true, true);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(true, false, false);
                var v1 = new bvec2(false, true);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(false, true, false);
                var v1 = new bvec2(true, true);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(true, false, true);
                var v1 = new bvec3(false, false, false);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(true, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new bvec3(true, true, false);
                var v1 = false;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec3(true, true, false);
                var v1 = false;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec3(true, true, true);
                var v1 = new bvec2(true, true);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bvec3(false, true, true);
                var v1 = false;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec3(false, true, false);
                var v1 = new bvec2(false, false);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(false, true, false);
                var v1 = new bvec2(true, false);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(true, false, true);
                var v1 = new bvec3(true, true, false);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(true, v2.z);
            }
        }

    }
}
