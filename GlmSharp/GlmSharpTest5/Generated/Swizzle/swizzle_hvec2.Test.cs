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
    public class HalfSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new hvec2(Half.One, new Half(-6));
                var v = ov.swizzle.xx;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
            }
            {
                var ov = new hvec2(new Half(-6.5), new Half(3.5));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
            }
            {
                var ov = new hvec2(new Half(3), new Half(-2.5));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec2(new Half(-1.5), new Half(4.5));
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
                Assert.AreEqual(new Half(-1.5), v.v);
            }
            {
                var ov = new hvec2(new Half(6.5), new Half(5));
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
                Assert.AreEqual(new Half(5), v.v);
            }
            {
                var ov = new hvec2(new Half(-0.5), new Half(-5));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec2(new Half(9), new Half(6.5));
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
                Assert.AreEqual(new Half(9), v.v);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(-0.5));
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
                Assert.AreEqual(new Half(-0.5), v.v);
            }
            {
                var ov = new hvec2(new Half(6), new Half(8.5));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
            }
            {
                var ov = new hvec2(new Half(3), new Half(8));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec2(Half.Zero, new Half(8));
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(Half.Zero, v.w);
                Assert.AreEqual(Half.Zero, v.v);
            }
            {
                var ov = new hvec2(new Half(-3.5), new Half(3.5));
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
                Assert.AreEqual(new Half(3.5), v.v);
            }
            {
                var ov = new hvec2(Half.Zero, new Half(3.5));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec2(new Half(6), new Half(-1.5));
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
                Assert.AreEqual(new Half(6), v.v);
            }
            {
                var ov = new hvec2(new Half(3), new Half(-3));
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
                Assert.AreEqual(new Half(-3), v.v);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(2));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(2), v.y);
            }
            {
                var ov = new hvec2(new Half(2), new Half(3.5));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
            }
            {
                var ov = new hvec2(Half.One, Half.One);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec2(new Half(8.5), new Half(-2.5));
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
                Assert.AreEqual(new Half(8.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-9), new Half(0.5));
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-9), v.w);
                Assert.AreEqual(new Half(0.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-2), new Half(-5));
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec2(new Half(-9), Half.One);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(Half.One, v.w);
                Assert.AreEqual(new Half(-9), v.v);
            }
            {
                var ov = new hvec2(Half.Zero, new Half(0.5));
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(0.5), v.w);
                Assert.AreEqual(new Half(0.5), v.v);
            }
            {
                var ov = new hvec2(new Half(4.5), new Half(7));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(7), v.z);
            }
            {
                var ov = new hvec2(new Half(-5.5), new Half(-8));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-6.5), new Half(5.5));
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
                Assert.AreEqual(new Half(-6.5), v.v);
            }
            {
                var ov = new hvec2(new Half(8.5), new Half(-7));
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
                Assert.AreEqual(new Half(-7), v.v);
            }
            {
                var ov = new hvec2(new Half(-6), new Half(2.5));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec2(new Half(0.5), new Half(-0.5));
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
                Assert.AreEqual(new Half(0.5), v.v);
            }
            {
                var ov = new hvec2(new Half(2.5), new Half(9));
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(9), v.w);
                Assert.AreEqual(new Half(9), v.v);
            }
            {
                var ov = new hvec2(new Half(-9.5), Half.Zero);
                var v = ov.swizzle.yx;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
            }
            {
                var ov = new hvec2(new Half(1.5), new Half(-5.5));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
            }
            {
                var ov = new hvec2(new Half(-4.5), new Half(-2.5));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-3), new Half(-6));
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
                Assert.AreEqual(new Half(-3), v.v);
            }
            {
                var ov = new hvec2(new Half(5.5), new Half(-9.5));
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
                Assert.AreEqual(new Half(-9.5), v.v);
            }
            {
                var ov = new hvec2(new Half(0.5), new Half(-9.5));
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-9), new Half(-4));
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-4), v.w);
                Assert.AreEqual(new Half(-9), v.v);
            }
            {
                var ov = new hvec2(new Half(6.5), new Half(-4.5));
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
                Assert.AreEqual(new Half(-4.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-0.5), new Half(-5.5));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
            }
            {
                var ov = new hvec2(new Half(2.5), new Half(9));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec2(new Half(9.5), new Half(8.5));
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
                Assert.AreEqual(new Half(9.5), v.v);
            }
            {
                var ov = new hvec2(new Half(3), new Half(-4.5));
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
                Assert.AreEqual(new Half(-4.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-0.5), new Half(-4.5));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec2(new Half(3), new Half(-4.5));
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
                Assert.AreEqual(new Half(3), v.v);
            }
            {
                var ov = new hvec2(new Half(-8), new Half(8));
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(8), v.w);
                Assert.AreEqual(new Half(8), v.v);
            }
            {
                var ov = new hvec2(new Half(-1), new Half(9));
                var v = ov.swizzle.yy;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(9), v.y);
            }
            {
                var ov = new hvec2(new Half(4.5), new Half(8));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
            }
            {
                var ov = new hvec2(new Half(9), new Half(-2));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec2(new Half(-5.5), new Half(5.5));
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
                Assert.AreEqual(new Half(-5.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-7), new Half(-4));
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(-7), v.w);
                Assert.AreEqual(new Half(-4), v.v);
            }
            {
                var ov = new hvec2(new Half(-8), new Half(-8));
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec2(new Half(-3), new Half(4));
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(4), v.w);
                Assert.AreEqual(new Half(-3), v.v);
            }
            {
                var ov = new hvec2(new Half(-1.5), new Half(3));
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
                Assert.AreEqual(new Half(3), v.v);
            }
            {
                var ov = new hvec2(new Half(-6), new Half(-4.5));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
            }
            {
                var ov = new hvec2(new Half(-9.5), new Half(0.5));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec2(new Half(3), new Half(6));
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(3), v.w);
                Assert.AreEqual(new Half(3), v.v);
            }
            {
                var ov = new hvec2(new Half(6.5), new Half(-6.5));
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
                Assert.AreEqual(new Half(-6.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-1), new Half(-8.5));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec2(new Half(7.5), new Half(5));
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(5), v.w);
                Assert.AreEqual(new Half(7.5), v.v);
            }
            {
                var ov = new hvec2(new Half(5.5), new Half(9.5));
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
                Assert.AreEqual(new Half(9.5), v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new hvec2(new Half(4), new Half(8.5));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4), v.y);
            }
            {
                var ov = new hvec2(new Half(6), new Half(-6.5));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(6), v.z);
            }
            {
                var ov = new hvec2(Half.Zero, new Half(-4.5));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec2(new Half(5.5), Half.One);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
                Assert.AreEqual(new Half(5.5), v.v);
            }
            {
                var ov = new hvec2(new Half(4.5), new Half(8));
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
                Assert.AreEqual(new Half(8), v.v);
            }
            {
                var ov = new hvec2(new Half(3), new Half(-3));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec2(Half.Zero, new Half(-3));
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(-3), v.w);
                Assert.AreEqual(Half.Zero, v.v);
            }
            {
                var ov = new hvec2(new Half(-4), new Half(-9.5));
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
                Assert.AreEqual(new Half(-9.5), v.v);
            }
            {
                var ov = new hvec2(new Half(5), new Half(-9));
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
            }
            {
                var ov = new hvec2(new Half(4), new Half(2.5));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec2(new Half(3.5), Half.Zero);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(3.5), v.w);
                Assert.AreEqual(new Half(3.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-6.5), new Half(-9));
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
                Assert.AreEqual(new Half(-9), v.v);
            }
            {
                var ov = new hvec2(new Half(-3), new Half(-3.5));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-1), new Half(-5.5));
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
                Assert.AreEqual(new Half(-1), v.v);
            }
            {
                var ov = new hvec2(Half.One, Half.One);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(Half.One, v.w);
                Assert.AreEqual(Half.One, v.v);
            }
            {
                var ov = new hvec2(new Half(1.5), new Half(-1));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(-1), v.y);
            }
            {
                var ov = new hvec2(new Half(9), new Half(-2));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(9), v.z);
            }
            {
                var ov = new hvec2(new Half(9.5), new Half(6.5));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-1), new Half(5.5));
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-1), v.w);
                Assert.AreEqual(new Half(-1), v.v);
            }
            {
                var ov = new hvec2(new Half(-6.5), new Half(6.5));
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
                Assert.AreEqual(new Half(6.5), v.v);
            }
            {
                var ov = new hvec2(new Half(9.5), new Half(4));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec2(new Half(9), new Half(2));
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(2), v.w);
                Assert.AreEqual(new Half(9), v.v);
            }
            {
                var ov = new hvec2(new Half(4.5), new Half(-5.5));
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
                Assert.AreEqual(new Half(-5.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-4.5), new Half(-3.5));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
            }
            {
                var ov = new hvec2(new Half(-5.5), new Half(7.5));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(-9.5));
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
                Assert.AreEqual(new Half(-8.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-5.5), new Half(0.5));
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
                Assert.AreEqual(new Half(0.5), v.v);
            }
            {
                var ov = new hvec2(new Half(6.5), new Half(4));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec2(new Half(-5), new Half(-2.5));
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
                Assert.AreEqual(new Half(-2.5), v.w);
                Assert.AreEqual(new Half(-5), v.v);
            }
            {
                var ov = new hvec2(new Half(-1), new Half(-4));
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4), v.w);
                Assert.AreEqual(new Half(-4), v.v);
            }
            {
                var ov = new hvec2(new Half(-4), new Half(-1));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-4), v.y);
            }
            {
                var ov = new hvec2(Half.Zero, new Half(2.5));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(Half.Zero, v.z);
            }
            {
                var ov = new hvec2(new Half(-7), new Half(3.5));
                var v = ov.swizzle.grrr;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec2(new Half(3), new Half(-0.5));
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(3), v.w);
                Assert.AreEqual(new Half(3), v.v);
            }
            {
                var ov = new hvec2(new Half(-4), new Half(-7));
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4), v.w);
                Assert.AreEqual(new Half(-7), v.v);
            }
            {
                var ov = new hvec2(new Half(9), new Half(-1));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec2(new Half(6.5), new Half(8));
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(8), v.w);
                Assert.AreEqual(new Half(6.5), v.v);
            }
            {
                var ov = new hvec2(new Half(2.5), new Half(-0.5));
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
                Assert.AreEqual(new Half(-0.5), v.v);
            }
            {
                var ov = new hvec2(new Half(0.5), new Half(-8.5));
                var v = ov.swizzle.grg;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
            }
            {
                var ov = new hvec2(new Half(-4.5), new Half(-1.5));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec2(Half.One, new Half(-4.5));
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(Half.One, v.w);
                Assert.AreEqual(Half.One, v.v);
            }
            {
                var ov = new hvec2(Half.Zero, new Half(3));
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(Half.Zero, v.w);
                Assert.AreEqual(new Half(3), v.v);
            }
            {
                var ov = new hvec2(new Half(-9.5), new Half(-2));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec2(new Half(-3.5), new Half(-9));
                var v = ov.swizzle.grggr;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-9), v.w);
                Assert.AreEqual(new Half(-3.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-6), new Half(4.5));
                var v = ov.swizzle.grggg;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
                Assert.AreEqual(new Half(4.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(-6.5));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
            }
            {
                var ov = new hvec2(new Half(-5.5), new Half(8));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
            }
            {
                var ov = new hvec2(new Half(-7.5), new Half(-0.5));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec2(new Half(3), new Half(-7));
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(3), v.w);
                Assert.AreEqual(new Half(3), v.v);
            }
            {
                var ov = new hvec2(new Half(-3.5), Half.Zero);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
                Assert.AreEqual(Half.Zero, v.v);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(6.5));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-2), new Half(6));
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(6), v.w);
                Assert.AreEqual(new Half(-2), v.v);
            }
            {
                var ov = new hvec2(new Half(-1.5), new Half(-1));
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1), v.w);
                Assert.AreEqual(new Half(-1), v.v);
            }
            {
                var ov = new hvec2(new Half(-5.5), new Half(-6));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6), v.z);
            }
            {
                var ov = new hvec2(new Half(8.5), new Half(6));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-5), new Half(3.5));
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
                Assert.AreEqual(new Half(-5), v.v);
            }
            {
                var ov = new hvec2(Half.One, new Half(-7.5));
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(Half.One, v.w);
                Assert.AreEqual(new Half(-7.5), v.v);
            }
            {
                var ov = new hvec2(new Half(-3), new Half(-0.5));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec2(new Half(9), new Half(6.5));
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
                Assert.AreEqual(new Half(9), v.v);
            }
            {
                var ov = new hvec2(new Half(-3), new Half(4));
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(4), v.w);
                Assert.AreEqual(new Half(4), v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new hvec2(new Half(-4.5), new Half(-9.5));
                var v1 = new hvec2(new Half(-6.5), new Half(9));
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-6.5), v0.x);
                Assert.AreEqual(new Half(9), v0.y);
            
                Assert.AreEqual(new Half(-4.5), v2.x);
                Assert.AreEqual(new Half(-9.5), v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new hvec2(new Half(6), new Half(6.5));
                var v1 = new Half(new Half(-7));
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-7), v0.x);
                Assert.AreEqual(new Half(6.5), v0.y);
            
                Assert.AreEqual(new Half(6), v2);
            }
            {
                var v0 = new hvec2(new Half(6), new Half(-0.5));
                var v1 = new Half(new Half(-6));
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(6), v0.x);
                Assert.AreEqual(new Half(-6), v0.y);
            
                Assert.AreEqual(new Half(-0.5), v2);
            }
            {
                var v0 = new hvec2(new Half(1.5), Half.One);
                var v1 = new hvec2(new Half(6.5), new Half(-8));
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(6.5), v0.x);
                Assert.AreEqual(new Half(-8), v0.y);
            
                Assert.AreEqual(new Half(1.5), v2.x);
                Assert.AreEqual(Half.One, v2.y);
            }
        }

    }
}
