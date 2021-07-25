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
    public class DecimalSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new decvec2(2.5m, -9m);
                var v = ov.swizzle.xx;
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(2.5m, v.y);
            }
            {
                var ov = new decvec2(-8m, -1m);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-8m, v.x);
                Assert.AreEqual(-8m, v.y);
                Assert.AreEqual(-8m, v.z);
            }
            {
                var ov = new decvec2(2m, 5m);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(2m, v.x);
                Assert.AreEqual(2m, v.y);
                Assert.AreEqual(2m, v.z);
                Assert.AreEqual(2m, v.w);
            }
            {
                var ov = new decvec2(-7m, -7.5m);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(-7m, v.x);
                Assert.AreEqual(-7m, v.y);
                Assert.AreEqual(-7m, v.z);
                Assert.AreEqual(-7m, v.w);
                Assert.AreEqual(-7m, v.v);
            }
            {
                var ov = new decvec2(-5.5m, -4m);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(-5.5m, v.x);
                Assert.AreEqual(-5.5m, v.y);
                Assert.AreEqual(-5.5m, v.z);
                Assert.AreEqual(-5.5m, v.w);
                Assert.AreEqual(-4m, v.v);
            }
            {
                var ov = new decvec2(2.5m, 7.5m);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(2.5m, v.z);
                Assert.AreEqual(7.5m, v.w);
            }
            {
                var ov = new decvec2(-7.5m, 9m);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(-7.5m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-7.5m, v.z);
                Assert.AreEqual(9m, v.w);
                Assert.AreEqual(-7.5m, v.v);
            }
            {
                var ov = new decvec2(7m, -7m);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(7m, v.x);
                Assert.AreEqual(7m, v.y);
                Assert.AreEqual(7m, v.z);
                Assert.AreEqual(-7m, v.w);
                Assert.AreEqual(-7m, v.v);
            }
            {
                var ov = new decvec2(-5.5m, -8.5m);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-5.5m, v.x);
                Assert.AreEqual(-5.5m, v.y);
                Assert.AreEqual(-8.5m, v.z);
            }
            {
                var ov = new decvec2(-6m, 8m);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-6m, v.x);
                Assert.AreEqual(-6m, v.y);
                Assert.AreEqual(8m, v.z);
                Assert.AreEqual(-6m, v.w);
            }
            {
                var ov = new decvec2(3.5m, -0.5m);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(3.5m, v.x);
                Assert.AreEqual(3.5m, v.y);
                Assert.AreEqual(-0.5m, v.z);
                Assert.AreEqual(3.5m, v.w);
                Assert.AreEqual(3.5m, v.v);
            }
            {
                var ov = new decvec2(4m, -1m);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(4m, v.x);
                Assert.AreEqual(4m, v.y);
                Assert.AreEqual(-1m, v.z);
                Assert.AreEqual(4m, v.w);
                Assert.AreEqual(-1m, v.v);
            }
            {
                var ov = new decvec2(7m, 0.5m);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(7m, v.x);
                Assert.AreEqual(7m, v.y);
                Assert.AreEqual(0.5m, v.z);
                Assert.AreEqual(0.5m, v.w);
            }
            {
                var ov = new decvec2(-1.5m, 6m);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(-1.5m, v.x);
                Assert.AreEqual(-1.5m, v.y);
                Assert.AreEqual(6m, v.z);
                Assert.AreEqual(6m, v.w);
                Assert.AreEqual(-1.5m, v.v);
            }
            {
                var ov = new decvec2(-4.5m, -6.5m);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(-4.5m, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-6.5m, v.z);
                Assert.AreEqual(-6.5m, v.w);
                Assert.AreEqual(-6.5m, v.v);
            }
            {
                var ov = new decvec2(3.5m, 0.5m);
                var v = ov.swizzle.xy;
                Assert.AreEqual(3.5m, v.x);
                Assert.AreEqual(0.5m, v.y);
            }
            {
                var ov = new decvec2(-6m, -5m);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(-6m, v.x);
                Assert.AreEqual(-5m, v.y);
                Assert.AreEqual(-6m, v.z);
            }
            {
                var ov = new decvec2(-9.5m, -3m);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-9.5m, v.x);
                Assert.AreEqual(-3m, v.y);
                Assert.AreEqual(-9.5m, v.z);
                Assert.AreEqual(-9.5m, v.w);
            }
            {
                var ov = new decvec2(0.5m, -3m);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(0.5m, v.x);
                Assert.AreEqual(-3m, v.y);
                Assert.AreEqual(0.5m, v.z);
                Assert.AreEqual(0.5m, v.w);
                Assert.AreEqual(0.5m, v.v);
            }
            {
                var ov = new decvec2(2m, -4m);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(2m, v.x);
                Assert.AreEqual(-4m, v.y);
                Assert.AreEqual(2m, v.z);
                Assert.AreEqual(2m, v.w);
                Assert.AreEqual(-4m, v.v);
            }
            {
                var ov = new decvec2(7.5m, 3m);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(7.5m, v.x);
                Assert.AreEqual(3m, v.y);
                Assert.AreEqual(7.5m, v.z);
                Assert.AreEqual(3m, v.w);
            }
            {
                var ov = new decvec2(-9m, 4.5m);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(-9m, v.x);
                Assert.AreEqual(4.5m, v.y);
                Assert.AreEqual(-9m, v.z);
                Assert.AreEqual(4.5m, v.w);
                Assert.AreEqual(-9m, v.v);
            }
            {
                var ov = new decvec2(-5m, 2.5m);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(-5m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(-5m, v.z);
                Assert.AreEqual(2.5m, v.w);
                Assert.AreEqual(2.5m, v.v);
            }
            {
                var ov = new decvec2(5.5m, -1.5m);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(5.5m, v.x);
                Assert.AreEqual(-1.5m, v.y);
                Assert.AreEqual(-1.5m, v.z);
            }
            {
                var ov = new decvec2(6m, -4m);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(6m, v.x);
                Assert.AreEqual(-4m, v.y);
                Assert.AreEqual(-4m, v.z);
                Assert.AreEqual(6m, v.w);
            }
            {
                var ov = new decvec2(-7m, -6.5m);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(-7m, v.x);
                Assert.AreEqual(-6.5m, v.y);
                Assert.AreEqual(-6.5m, v.z);
                Assert.AreEqual(-7m, v.w);
                Assert.AreEqual(-7m, v.v);
            }
            {
                var ov = new decvec2(7.5m, 6m);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(7.5m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(6m, v.z);
                Assert.AreEqual(7.5m, v.w);
                Assert.AreEqual(6m, v.v);
            }
            {
                var ov = new decvec2(8m, 2m);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(8m, v.x);
                Assert.AreEqual(2m, v.y);
                Assert.AreEqual(2m, v.z);
                Assert.AreEqual(2m, v.w);
            }
            {
                var ov = new decvec2(-4m, 6m);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(-4m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(6m, v.z);
                Assert.AreEqual(6m, v.w);
                Assert.AreEqual(-4m, v.v);
            }
            {
                var ov = new decvec2(2m, -3m);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(2m, v.x);
                Assert.AreEqual(-3m, v.y);
                Assert.AreEqual(-3m, v.z);
                Assert.AreEqual(-3m, v.w);
                Assert.AreEqual(-3m, v.v);
            }
            {
                var ov = new decvec2(-8m, -1m);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-1m, v.x);
                Assert.AreEqual(-8m, v.y);
            }
            {
                var ov = new decvec2(6.5m, 1m);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(1m, v.x);
                Assert.AreEqual(6.5m, v.y);
                Assert.AreEqual(6.5m, v.z);
            }
            {
                var ov = new decvec2(-9.5m, 1m);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(1m, v.x);
                Assert.AreEqual(-9.5m, v.y);
                Assert.AreEqual(-9.5m, v.z);
                Assert.AreEqual(-9.5m, v.w);
            }
            {
                var ov = new decvec2(-7.5m, 6m);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(6m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-7.5m, v.z);
                Assert.AreEqual(-7.5m, v.w);
                Assert.AreEqual(-7.5m, v.v);
            }
            {
                var ov = new decvec2(-0.5m, 5.5m);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(5.5m, v.x);
                Assert.AreEqual(-0.5m, v.y);
                Assert.AreEqual(-0.5m, v.z);
                Assert.AreEqual(-0.5m, v.w);
                Assert.AreEqual(5.5m, v.v);
            }
            {
                var ov = new decvec2(-3.5m, -1m);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-1m, v.x);
                Assert.AreEqual(-3.5m, v.y);
                Assert.AreEqual(-3.5m, v.z);
                Assert.AreEqual(-1m, v.w);
            }
            {
                var ov = new decvec2(-9m, 2m);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(2m, v.x);
                Assert.AreEqual(-9m, v.y);
                Assert.AreEqual(-9m, v.z);
                Assert.AreEqual(2m, v.w);
                Assert.AreEqual(-9m, v.v);
            }
            {
                var ov = new decvec2(-1m, -0.5m);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(-0.5m, v.x);
                Assert.AreEqual(-1m, v.y);
                Assert.AreEqual(-1m, v.z);
                Assert.AreEqual(-0.5m, v.w);
                Assert.AreEqual(-0.5m, v.v);
            }
            {
                var ov = new decvec2(-1m, -1m);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-1m, v.x);
                Assert.AreEqual(-1m, v.y);
                Assert.AreEqual(-1m, v.z);
            }
            {
                var ov = new decvec2(6.5m, -5m);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-5m, v.x);
                Assert.AreEqual(6.5m, v.y);
                Assert.AreEqual(-5m, v.z);
                Assert.AreEqual(6.5m, v.w);
            }
            {
                var ov = new decvec2(4.5m, 9.5m);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(9.5m, v.x);
                Assert.AreEqual(4.5m, v.y);
                Assert.AreEqual(9.5m, v.z);
                Assert.AreEqual(4.5m, v.w);
                Assert.AreEqual(4.5m, v.v);
            }
            {
                var ov = new decvec2(9.5m, -1m);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(-1m, v.x);
                Assert.AreEqual(9.5m, v.y);
                Assert.AreEqual(-1m, v.z);
                Assert.AreEqual(9.5m, v.w);
                Assert.AreEqual(-1m, v.v);
            }
            {
                var ov = new decvec2(5m, -1m);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(-1m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(-1m, v.z);
                Assert.AreEqual(-1m, v.w);
            }
            {
                var ov = new decvec2(2.5m, 8m);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(8m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(8m, v.z);
                Assert.AreEqual(8m, v.w);
                Assert.AreEqual(2.5m, v.v);
            }
            {
                var ov = new decvec2(5m, -7m);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(-7m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(-7m, v.z);
                Assert.AreEqual(-7m, v.w);
                Assert.AreEqual(-7m, v.v);
            }
            {
                var ov = new decvec2(8.5m, -6.5m);
                var v = ov.swizzle.yy;
                Assert.AreEqual(-6.5m, v.x);
                Assert.AreEqual(-6.5m, v.y);
            }
            {
                var ov = new decvec2(9m, 0.5m);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(0.5m, v.x);
                Assert.AreEqual(0.5m, v.y);
                Assert.AreEqual(9m, v.z);
            }
            {
                var ov = new decvec2(5.5m, -2.5m);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-2.5m, v.x);
                Assert.AreEqual(-2.5m, v.y);
                Assert.AreEqual(5.5m, v.z);
                Assert.AreEqual(5.5m, v.w);
            }
            {
                var ov = new decvec2(7m, -8m);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(-8m, v.x);
                Assert.AreEqual(-8m, v.y);
                Assert.AreEqual(7m, v.z);
                Assert.AreEqual(7m, v.w);
                Assert.AreEqual(7m, v.v);
            }
            {
                var ov = new decvec2(-5m, -3m);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(-3m, v.x);
                Assert.AreEqual(-3m, v.y);
                Assert.AreEqual(-5m, v.z);
                Assert.AreEqual(-5m, v.w);
                Assert.AreEqual(-3m, v.v);
            }
            {
                var ov = new decvec2(-1m, -0.5m);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-0.5m, v.x);
                Assert.AreEqual(-0.5m, v.y);
                Assert.AreEqual(-1m, v.z);
                Assert.AreEqual(-0.5m, v.w);
            }
            {
                var ov = new decvec2(8.5m, -2m);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(-2m, v.x);
                Assert.AreEqual(-2m, v.y);
                Assert.AreEqual(8.5m, v.z);
                Assert.AreEqual(-2m, v.w);
                Assert.AreEqual(8.5m, v.v);
            }
            {
                var ov = new decvec2(-2.5m, 5m);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(5m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(-2.5m, v.z);
                Assert.AreEqual(5m, v.w);
                Assert.AreEqual(5m, v.v);
            }
            {
                var ov = new decvec2(4m, 5.5m);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(5.5m, v.x);
                Assert.AreEqual(5.5m, v.y);
                Assert.AreEqual(5.5m, v.z);
            }
            {
                var ov = new decvec2(6.5m, -9m);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-9m, v.x);
                Assert.AreEqual(-9m, v.y);
                Assert.AreEqual(-9m, v.z);
                Assert.AreEqual(6.5m, v.w);
            }
            {
                var ov = new decvec2(2.5m, 3m);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(3m, v.x);
                Assert.AreEqual(3m, v.y);
                Assert.AreEqual(3m, v.z);
                Assert.AreEqual(2.5m, v.w);
                Assert.AreEqual(2.5m, v.v);
            }
            {
                var ov = new decvec2(-1m, -1.5m);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(-1.5m, v.x);
                Assert.AreEqual(-1.5m, v.y);
                Assert.AreEqual(-1.5m, v.z);
                Assert.AreEqual(-1m, v.w);
                Assert.AreEqual(-1.5m, v.v);
            }
            {
                var ov = new decvec2(-8m, -9m);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-9m, v.x);
                Assert.AreEqual(-9m, v.y);
                Assert.AreEqual(-9m, v.z);
                Assert.AreEqual(-9m, v.w);
            }
            {
                var ov = new decvec2(-2m, -4.5m);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(-4.5m, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-4.5m, v.z);
                Assert.AreEqual(-4.5m, v.w);
                Assert.AreEqual(-2m, v.v);
            }
            {
                var ov = new decvec2(5.5m, 8m);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(8m, v.x);
                Assert.AreEqual(8m, v.y);
                Assert.AreEqual(8m, v.z);
                Assert.AreEqual(8m, v.w);
                Assert.AreEqual(8m, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new decvec2(-4m, 5.5m);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-4m, v.x);
                Assert.AreEqual(-4m, v.y);
            }
            {
                var ov = new decvec2(-2m, 4m);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(-2m, v.x);
                Assert.AreEqual(-2m, v.y);
                Assert.AreEqual(-2m, v.z);
            }
            {
                var ov = new decvec2(1m, 6m);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(1m, v.x);
                Assert.AreEqual(1m, v.y);
                Assert.AreEqual(1m, v.z);
                Assert.AreEqual(1m, v.w);
            }
            {
                var ov = new decvec2(6m, -5m);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(6m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(6m, v.z);
                Assert.AreEqual(6m, v.w);
                Assert.AreEqual(6m, v.v);
            }
            {
                var ov = new decvec2(6m, 0m);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(6m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(6m, v.z);
                Assert.AreEqual(6m, v.w);
                Assert.AreEqual(0m, v.v);
            }
            {
                var ov = new decvec2(1m, 0.5m);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(1m, v.x);
                Assert.AreEqual(1m, v.y);
                Assert.AreEqual(1m, v.z);
                Assert.AreEqual(0.5m, v.w);
            }
            {
                var ov = new decvec2(-0.5m, 9.5m);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(-0.5m, v.x);
                Assert.AreEqual(-0.5m, v.y);
                Assert.AreEqual(-0.5m, v.z);
                Assert.AreEqual(9.5m, v.w);
                Assert.AreEqual(-0.5m, v.v);
            }
            {
                var ov = new decvec2(-3.5m, 2.5m);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(-3.5m, v.y);
                Assert.AreEqual(-3.5m, v.z);
                Assert.AreEqual(2.5m, v.w);
                Assert.AreEqual(2.5m, v.v);
            }
            {
                var ov = new decvec2(-1.5m, 5.5m);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-1.5m, v.x);
                Assert.AreEqual(-1.5m, v.y);
                Assert.AreEqual(5.5m, v.z);
            }
            {
                var ov = new decvec2(2.5m, 2.5m);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(2.5m, v.z);
                Assert.AreEqual(2.5m, v.w);
            }
            {
                var ov = new decvec2(0m, -9m);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(0m, v.x);
                Assert.AreEqual(0m, v.y);
                Assert.AreEqual(-9m, v.z);
                Assert.AreEqual(0m, v.w);
                Assert.AreEqual(0m, v.v);
            }
            {
                var ov = new decvec2(4m, 1m);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(4m, v.x);
                Assert.AreEqual(4m, v.y);
                Assert.AreEqual(1m, v.z);
                Assert.AreEqual(4m, v.w);
                Assert.AreEqual(1m, v.v);
            }
            {
                var ov = new decvec2(4m, -0.5m);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(4m, v.x);
                Assert.AreEqual(4m, v.y);
                Assert.AreEqual(-0.5m, v.z);
                Assert.AreEqual(-0.5m, v.w);
            }
            {
                var ov = new decvec2(0.5m, 6m);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(0.5m, v.x);
                Assert.AreEqual(0.5m, v.y);
                Assert.AreEqual(6m, v.z);
                Assert.AreEqual(6m, v.w);
                Assert.AreEqual(0.5m, v.v);
            }
            {
                var ov = new decvec2(-9.5m, 1.5m);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(-9.5m, v.x);
                Assert.AreEqual(-9.5m, v.y);
                Assert.AreEqual(1.5m, v.z);
                Assert.AreEqual(1.5m, v.w);
                Assert.AreEqual(1.5m, v.v);
            }
            {
                var ov = new decvec2(-9m, -6.5m);
                var v = ov.swizzle.rg;
                Assert.AreEqual(-9m, v.x);
                Assert.AreEqual(-6.5m, v.y);
            }
            {
                var ov = new decvec2(6.5m, 0.5m);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(6.5m, v.x);
                Assert.AreEqual(0.5m, v.y);
                Assert.AreEqual(6.5m, v.z);
            }
            {
                var ov = new decvec2(-8.5m, -4.5m);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-8.5m, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-8.5m, v.z);
                Assert.AreEqual(-8.5m, v.w);
            }
            {
                var ov = new decvec2(-9m, 8m);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(-9m, v.x);
                Assert.AreEqual(8m, v.y);
                Assert.AreEqual(-9m, v.z);
                Assert.AreEqual(-9m, v.w);
                Assert.AreEqual(-9m, v.v);
            }
            {
                var ov = new decvec2(9.5m, -4m);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(9.5m, v.x);
                Assert.AreEqual(-4m, v.y);
                Assert.AreEqual(9.5m, v.z);
                Assert.AreEqual(9.5m, v.w);
                Assert.AreEqual(-4m, v.v);
            }
            {
                var ov = new decvec2(-4m, -6m);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(-4m, v.x);
                Assert.AreEqual(-6m, v.y);
                Assert.AreEqual(-4m, v.z);
                Assert.AreEqual(-6m, v.w);
            }
            {
                var ov = new decvec2(-1m, 9m);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(-1m, v.x);
                Assert.AreEqual(9m, v.y);
                Assert.AreEqual(-1m, v.z);
                Assert.AreEqual(9m, v.w);
                Assert.AreEqual(-1m, v.v);
            }
            {
                var ov = new decvec2(-9.5m, -7.5m);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(-9.5m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-9.5m, v.z);
                Assert.AreEqual(-7.5m, v.w);
                Assert.AreEqual(-7.5m, v.v);
            }
            {
                var ov = new decvec2(-6.5m, 5m);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-6.5m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(5m, v.z);
            }
            {
                var ov = new decvec2(1m, 1m);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(1m, v.x);
                Assert.AreEqual(1m, v.y);
                Assert.AreEqual(1m, v.z);
                Assert.AreEqual(1m, v.w);
            }
            {
                var ov = new decvec2(-1.5m, 2.5m);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(-1.5m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(2.5m, v.z);
                Assert.AreEqual(-1.5m, v.w);
                Assert.AreEqual(-1.5m, v.v);
            }
            {
                var ov = new decvec2(-4.5m, 0m);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(-4.5m, v.x);
                Assert.AreEqual(0m, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(-4.5m, v.w);
                Assert.AreEqual(0m, v.v);
            }
            {
                var ov = new decvec2(2m, 4.5m);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(2m, v.x);
                Assert.AreEqual(4.5m, v.y);
                Assert.AreEqual(4.5m, v.z);
                Assert.AreEqual(4.5m, v.w);
            }
            {
                var ov = new decvec2(1.5m, 9m);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(1.5m, v.x);
                Assert.AreEqual(9m, v.y);
                Assert.AreEqual(9m, v.z);
                Assert.AreEqual(9m, v.w);
                Assert.AreEqual(1.5m, v.v);
            }
            {
                var ov = new decvec2(9.5m, -2m);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(9.5m, v.x);
                Assert.AreEqual(-2m, v.y);
                Assert.AreEqual(-2m, v.z);
                Assert.AreEqual(-2m, v.w);
                Assert.AreEqual(-2m, v.v);
            }
            {
                var ov = new decvec2(-7m, 0m);
                var v = ov.swizzle.gr;
                Assert.AreEqual(0m, v.x);
                Assert.AreEqual(-7m, v.y);
            }
            {
                var ov = new decvec2(5.5m, -6m);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-6m, v.x);
                Assert.AreEqual(5.5m, v.y);
                Assert.AreEqual(5.5m, v.z);
            }
            {
                var ov = new decvec2(-7.5m, -9m);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-9m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-7.5m, v.z);
                Assert.AreEqual(-7.5m, v.w);
            }
            {
                var ov = new decvec2(3.5m, 8.5m);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(8.5m, v.x);
                Assert.AreEqual(3.5m, v.y);
                Assert.AreEqual(3.5m, v.z);
                Assert.AreEqual(3.5m, v.w);
                Assert.AreEqual(3.5m, v.v);
            }
            {
                var ov = new decvec2(-9m, 1m);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(1m, v.x);
                Assert.AreEqual(-9m, v.y);
                Assert.AreEqual(-9m, v.z);
                Assert.AreEqual(-9m, v.w);
                Assert.AreEqual(1m, v.v);
            }
            {
                var ov = new decvec2(-3m, -9.5m);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(-9.5m, v.x);
                Assert.AreEqual(-3m, v.y);
                Assert.AreEqual(-3m, v.z);
                Assert.AreEqual(-9.5m, v.w);
            }
            {
                var ov = new decvec2(6.5m, -9m);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(-9m, v.x);
                Assert.AreEqual(6.5m, v.y);
                Assert.AreEqual(6.5m, v.z);
                Assert.AreEqual(-9m, v.w);
                Assert.AreEqual(6.5m, v.v);
            }
            {
                var ov = new decvec2(-8m, -5.5m);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(-5.5m, v.x);
                Assert.AreEqual(-8m, v.y);
                Assert.AreEqual(-8m, v.z);
                Assert.AreEqual(-5.5m, v.w);
                Assert.AreEqual(-5.5m, v.v);
            }
            {
                var ov = new decvec2(8m, 4.5m);
                var v = ov.swizzle.grg;
                Assert.AreEqual(4.5m, v.x);
                Assert.AreEqual(8m, v.y);
                Assert.AreEqual(4.5m, v.z);
            }
            {
                var ov = new decvec2(-7.5m, -6.5m);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-6.5m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-6.5m, v.z);
                Assert.AreEqual(-7.5m, v.w);
            }
            {
                var ov = new decvec2(5m, -4.5m);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(-4.5m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(-4.5m, v.z);
                Assert.AreEqual(5m, v.w);
                Assert.AreEqual(5m, v.v);
            }
            {
                var ov = new decvec2(4m, -8m);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(-8m, v.x);
                Assert.AreEqual(4m, v.y);
                Assert.AreEqual(-8m, v.z);
                Assert.AreEqual(4m, v.w);
                Assert.AreEqual(-8m, v.v);
            }
            {
                var ov = new decvec2(3m, -3.5m);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(3m, v.y);
                Assert.AreEqual(-3.5m, v.z);
                Assert.AreEqual(-3.5m, v.w);
            }
            {
                var ov = new decvec2(7.5m, 6.5m);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(6.5m, v.x);
                Assert.AreEqual(7.5m, v.y);
                Assert.AreEqual(6.5m, v.z);
                Assert.AreEqual(6.5m, v.w);
                Assert.AreEqual(7.5m, v.v);
            }
            {
                var ov = new decvec2(-1.5m, -3.5m);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(-1.5m, v.y);
                Assert.AreEqual(-3.5m, v.z);
                Assert.AreEqual(-3.5m, v.w);
                Assert.AreEqual(-3.5m, v.v);
            }
            {
                var ov = new decvec2(3.5m, 9m);
                var v = ov.swizzle.gg;
                Assert.AreEqual(9m, v.x);
                Assert.AreEqual(9m, v.y);
            }
            {
                var ov = new decvec2(8m, -2.5m);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-2.5m, v.x);
                Assert.AreEqual(-2.5m, v.y);
                Assert.AreEqual(8m, v.z);
            }
            {
                var ov = new decvec2(6.5m, -4m);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-4m, v.x);
                Assert.AreEqual(-4m, v.y);
                Assert.AreEqual(6.5m, v.z);
                Assert.AreEqual(6.5m, v.w);
            }
            {
                var ov = new decvec2(-8.5m, 5.5m);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(5.5m, v.x);
                Assert.AreEqual(5.5m, v.y);
                Assert.AreEqual(-8.5m, v.z);
                Assert.AreEqual(-8.5m, v.w);
                Assert.AreEqual(-8.5m, v.v);
            }
            {
                var ov = new decvec2(-1.5m, 1m);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(1m, v.x);
                Assert.AreEqual(1m, v.y);
                Assert.AreEqual(-1.5m, v.z);
                Assert.AreEqual(-1.5m, v.w);
                Assert.AreEqual(1m, v.v);
            }
            {
                var ov = new decvec2(-0.5m, -4.5m);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-4.5m, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-0.5m, v.z);
                Assert.AreEqual(-4.5m, v.w);
            }
            {
                var ov = new decvec2(-3.5m, 9.5m);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(9.5m, v.x);
                Assert.AreEqual(9.5m, v.y);
                Assert.AreEqual(-3.5m, v.z);
                Assert.AreEqual(9.5m, v.w);
                Assert.AreEqual(-3.5m, v.v);
            }
            {
                var ov = new decvec2(-1.5m, 7m);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(7m, v.x);
                Assert.AreEqual(7m, v.y);
                Assert.AreEqual(-1.5m, v.z);
                Assert.AreEqual(7m, v.w);
                Assert.AreEqual(7m, v.v);
            }
            {
                var ov = new decvec2(5.5m, 5m);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(5m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(5m, v.z);
            }
            {
                var ov = new decvec2(-7.5m, -8m);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-8m, v.x);
                Assert.AreEqual(-8m, v.y);
                Assert.AreEqual(-8m, v.z);
                Assert.AreEqual(-7.5m, v.w);
            }
            {
                var ov = new decvec2(-3.5m, 6.5m);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(6.5m, v.x);
                Assert.AreEqual(6.5m, v.y);
                Assert.AreEqual(6.5m, v.z);
                Assert.AreEqual(-3.5m, v.w);
                Assert.AreEqual(-3.5m, v.v);
            }
            {
                var ov = new decvec2(-1.5m, -7m);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(-7m, v.x);
                Assert.AreEqual(-7m, v.y);
                Assert.AreEqual(-7m, v.z);
                Assert.AreEqual(-1.5m, v.w);
                Assert.AreEqual(-7m, v.v);
            }
            {
                var ov = new decvec2(5m, 2.5m);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(2.5m, v.z);
                Assert.AreEqual(2.5m, v.w);
            }
            {
                var ov = new decvec2(5.5m, -7m);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(-7m, v.x);
                Assert.AreEqual(-7m, v.y);
                Assert.AreEqual(-7m, v.z);
                Assert.AreEqual(-7m, v.w);
                Assert.AreEqual(5.5m, v.v);
            }
            {
                var ov = new decvec2(-3m, 5.5m);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(5.5m, v.x);
                Assert.AreEqual(5.5m, v.y);
                Assert.AreEqual(5.5m, v.z);
                Assert.AreEqual(5.5m, v.w);
                Assert.AreEqual(5.5m, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new decvec2(3m, -3.5m);
                var v1 = new decvec2(-9m, 4.5m);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-9m, v0.x);
                Assert.AreEqual(4.5m, v0.y);
            
                Assert.AreEqual(3m, v2.x);
                Assert.AreEqual(-3.5m, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new decvec2(7.5m, 9.5m);
                var v1 = -2m;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-2m, v0.x);
                Assert.AreEqual(9.5m, v0.y);
            
                Assert.AreEqual(7.5m, v2);
            }
            {
                var v0 = new decvec2(-5.5m, -1.5m);
                var v1 = 4.5m;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5.5m, v0.x);
                Assert.AreEqual(4.5m, v0.y);
            
                Assert.AreEqual(-1.5m, v2);
            }
            {
                var v0 = new decvec2(-9.5m, -1.5m);
                var v1 = new decvec2(-6.5m, -3.5m);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-6.5m, v0.x);
                Assert.AreEqual(-3.5m, v0.y);
            
                Assert.AreEqual(-9.5m, v2.x);
                Assert.AreEqual(-1.5m, v2.y);
            }
        }

    }
}
