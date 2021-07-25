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
    public class BoolSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.gr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.grr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.grg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.gg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.ggggg;
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
                var v0 = new bvec2(true, true);
                var v1 = new bvec2(true, true);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new bvec2(false, false);
                var v1 = true;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
            
                Assert.AreEqual(false, v2);
            }
            {
                var v0 = new bvec2(false, true);
                var v1 = false;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec2(true, true);
                var v1 = new bvec2(true, false);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
        }

    }
}
