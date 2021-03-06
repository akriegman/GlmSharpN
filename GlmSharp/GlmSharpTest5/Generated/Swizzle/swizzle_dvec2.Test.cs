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
    public class DoubleSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new dvec2(0.0, 6.5d);
                var v = ov.swizzle.xx;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
            }
            {
                var ov = new dvec2(-3d, 8d);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(-3d, v.z);
            }
            {
                var ov = new dvec2(4.5d, 7.5d);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec2(8d, 5.5d);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8d, v.z);
                Assert.AreEqual(8d, v.w);
                Assert.AreEqual(8d, v.v);
            }
            {
                var ov = new dvec2(-1.5d, 4d);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
                Assert.AreEqual(4d, v.v);
            }
            {
                var ov = new dvec2(-1d, 8.5d);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec2(1.5d, -8.5d);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
                Assert.AreEqual(1.5d, v.v);
            }
            {
                var ov = new dvec2(-6.5d, 5.5d);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
                Assert.AreEqual(5.5d, v.v);
            }
            {
                var ov = new dvec2(1.0, -3d);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(-3d, v.z);
            }
            {
                var ov = new dvec2(-5.5d, 9.5d);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec2(3.5d, 3.5d);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
                Assert.AreEqual(3.5d, v.v);
            }
            {
                var ov = new dvec2(1.0, 6d);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(1.0, v.w);
                Assert.AreEqual(6d, v.v);
            }
            {
                var ov = new dvec2(-9d, 2.5d);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(-9d, v.x);
                Assert.AreEqual(-9d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec2(-1.5d, 7d);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(7d, v.w);
                Assert.AreEqual(-1.5d, v.v);
            }
            {
                var ov = new dvec2(4d, -4d);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(-4d, v.z);
                Assert.AreEqual(-4d, v.w);
                Assert.AreEqual(-4d, v.v);
            }
            {
                var ov = new dvec2(4d, 4d);
                var v = ov.swizzle.xy;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
            }
            {
                var ov = new dvec2(8.5d, 1.0);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(8.5d, v.z);
            }
            {
                var ov = new dvec2(-1d, 1.0);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(-1d, v.z);
                Assert.AreEqual(-1d, v.w);
            }
            {
                var ov = new dvec2(-6d, -4d);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(-6d, v.z);
                Assert.AreEqual(-6d, v.w);
                Assert.AreEqual(-6d, v.v);
            }
            {
                var ov = new dvec2(-1d, -7.5d);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-1d, v.z);
                Assert.AreEqual(-1d, v.w);
                Assert.AreEqual(-7.5d, v.v);
            }
            {
                var ov = new dvec2(2d, 4.5d);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(2d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec2(6d, -3.5d);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(-3.5d, v.w);
                Assert.AreEqual(6d, v.v);
            }
            {
                var ov = new dvec2(4d, -5.5d);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(4d, v.z);
                Assert.AreEqual(-5.5d, v.w);
                Assert.AreEqual(-5.5d, v.v);
            }
            {
                var ov = new dvec2(-2d, -3d);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(-3d, v.z);
            }
            {
                var ov = new dvec2(-1.5d, -3d);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(-3d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec2(0.0, 9d);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(9d, v.y);
                Assert.AreEqual(9d, v.z);
                Assert.AreEqual(0.0, v.w);
                Assert.AreEqual(0.0, v.v);
            }
            {
                var ov = new dvec2(-6d, -8d);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(-6d, v.w);
                Assert.AreEqual(-8d, v.v);
            }
            {
                var ov = new dvec2(9d, 7d);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(7d, v.w);
            }
            {
                var ov = new dvec2(5.5d, 6d);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(6d, v.w);
                Assert.AreEqual(5.5d, v.v);
            }
            {
                var ov = new dvec2(0.5d, 1.0);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(1.0, v.w);
                Assert.AreEqual(1.0, v.v);
            }
            {
                var ov = new dvec2(8d, 0.0);
                var v = ov.swizzle.yx;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(8d, v.y);
            }
            {
                var ov = new dvec2(1.5d, -4d);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
            }
            {
                var ov = new dvec2(9.5d, 5d);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec2(9.5d, 0.5d);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
                Assert.AreEqual(9.5d, v.v);
            }
            {
                var ov = new dvec2(-1d, -8.5d);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1d, v.z);
                Assert.AreEqual(-1d, v.w);
                Assert.AreEqual(-8.5d, v.v);
            }
            {
                var ov = new dvec2(-9d, -1.5d);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-9d, v.y);
                Assert.AreEqual(-9d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec2(2d, 2d);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(2d, v.z);
                Assert.AreEqual(2d, v.w);
                Assert.AreEqual(2d, v.v);
            }
            {
                var ov = new dvec2(7.5d, 9.5d);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
                Assert.AreEqual(9.5d, v.v);
            }
            {
                var ov = new dvec2(-2.5d, -5d);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-5d, v.z);
            }
            {
                var ov = new dvec2(1.0, 4.5d);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec2(-8.5d, -6d);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-6d, v.z);
                Assert.AreEqual(-8.5d, v.w);
                Assert.AreEqual(-8.5d, v.v);
            }
            {
                var ov = new dvec2(-9.5d, 1.5d);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
                Assert.AreEqual(1.5d, v.v);
            }
            {
                var ov = new dvec2(-3d, 5.5d);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec2(-0.5d, -9.5d);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
                Assert.AreEqual(-0.5d, v.v);
            }
            {
                var ov = new dvec2(2.5d, 3d);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(3d, v.w);
                Assert.AreEqual(3d, v.v);
            }
            {
                var ov = new dvec2(5d, 9d);
                var v = ov.swizzle.yy;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(9d, v.y);
            }
            {
                var ov = new dvec2(-6.5d, 9d);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(9d, v.y);
                Assert.AreEqual(-6.5d, v.z);
            }
            {
                var ov = new dvec2(-3d, 1.0);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(-3d, v.z);
                Assert.AreEqual(-3d, v.w);
            }
            {
                var ov = new dvec2(2d, 2.5d);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(2d, v.z);
                Assert.AreEqual(2d, v.w);
                Assert.AreEqual(2d, v.v);
            }
            {
                var ov = new dvec2(-3.5d, 9.5d);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
                Assert.AreEqual(9.5d, v.v);
            }
            {
                var ov = new dvec2(-5.5d, -7.5d);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec2(2d, 6d);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(2d, v.z);
                Assert.AreEqual(6d, v.w);
                Assert.AreEqual(2d, v.v);
            }
            {
                var ov = new dvec2(3.5d, -3d);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(-3d, v.w);
                Assert.AreEqual(-3d, v.v);
            }
            {
                var ov = new dvec2(7d, -3d);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(-3d, v.z);
            }
            {
                var ov = new dvec2(-8.5d, -1d);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1d, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec2(-8.5d, -8.5d);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
                Assert.AreEqual(-8.5d, v.v);
            }
            {
                var ov = new dvec2(4d, 6.5d);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(4d, v.w);
                Assert.AreEqual(6.5d, v.v);
            }
            {
                var ov = new dvec2(-8.5d, 3.5d);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec2(-8.5d, 0.0);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
                Assert.AreEqual(-8.5d, v.v);
            }
            {
                var ov = new dvec2(0.0, 4d);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(4d, v.z);
                Assert.AreEqual(4d, v.w);
                Assert.AreEqual(4d, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new dvec2(-3d, 7d);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-3d, v.y);
            }
            {
                var ov = new dvec2(3d, 7.5d);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(3d, v.z);
            }
            {
                var ov = new dvec2(6d, -0.5d);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(6d, v.w);
            }
            {
                var ov = new dvec2(-7d, 4.5d);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(-7d, v.y);
                Assert.AreEqual(-7d, v.z);
                Assert.AreEqual(-7d, v.w);
                Assert.AreEqual(-7d, v.v);
            }
            {
                var ov = new dvec2(5.5d, -2d);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
                Assert.AreEqual(-2d, v.v);
            }
            {
                var ov = new dvec2(0.0, 7d);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(7d, v.w);
            }
            {
                var ov = new dvec2(1.5d, 9d);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(9d, v.w);
                Assert.AreEqual(1.5d, v.v);
            }
            {
                var ov = new dvec2(-2.5d, -1.5d);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
                Assert.AreEqual(-1.5d, v.v);
            }
            {
                var ov = new dvec2(-8d, 5.5d);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-8d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(5.5d, v.z);
            }
            {
                var ov = new dvec2(0.5d, -5.5d);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec2(-4.5d, -2d);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(-4.5d, v.w);
                Assert.AreEqual(-4.5d, v.v);
            }
            {
                var ov = new dvec2(1.5d, 5.5d);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
                Assert.AreEqual(5.5d, v.v);
            }
            {
                var ov = new dvec2(-8.5d, -5d);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(-5d, v.w);
            }
            {
                var ov = new dvec2(5d, 9d);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(5d, v.y);
                Assert.AreEqual(9d, v.z);
                Assert.AreEqual(9d, v.w);
                Assert.AreEqual(5d, v.v);
            }
            {
                var ov = new dvec2(2d, 6d);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(6d, v.w);
                Assert.AreEqual(6d, v.v);
            }
            {
                var ov = new dvec2(6d, -1.5d);
                var v = ov.swizzle.rg;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(-1.5d, v.y);
            }
            {
                var ov = new dvec2(9d, 5.5d);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(9d, v.z);
            }
            {
                var ov = new dvec2(-7.5d, -4.5d);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec2(8d, -7.5d);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(8d, v.z);
                Assert.AreEqual(8d, v.w);
                Assert.AreEqual(8d, v.v);
            }
            {
                var ov = new dvec2(6.5d, 1.5d);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
                Assert.AreEqual(1.5d, v.v);
            }
            {
                var ov = new dvec2(1.5d, 2.5d);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec2(-3.5d, 3d);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(3d, v.w);
                Assert.AreEqual(-3.5d, v.v);
            }
            {
                var ov = new dvec2(2d, 2.5d);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(2d, v.z);
                Assert.AreEqual(2.5d, v.w);
                Assert.AreEqual(2.5d, v.v);
            }
            {
                var ov = new dvec2(-9.5d, -6d);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-6d, v.y);
                Assert.AreEqual(-6d, v.z);
            }
            {
                var ov = new dvec2(1.5d, -5d);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec2(-1.5d, -2d);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(-1.5d, v.w);
                Assert.AreEqual(-1.5d, v.v);
            }
            {
                var ov = new dvec2(2d, 9d);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(9d, v.y);
                Assert.AreEqual(9d, v.z);
                Assert.AreEqual(2d, v.w);
                Assert.AreEqual(9d, v.v);
            }
            {
                var ov = new dvec2(-4d, 0.0);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec2(-6d, 8d);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8d, v.z);
                Assert.AreEqual(8d, v.w);
                Assert.AreEqual(-6d, v.v);
            }
            {
                var ov = new dvec2(-6d, 1.5d);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
                Assert.AreEqual(1.5d, v.v);
            }
            {
                var ov = new dvec2(-5.5d, 6d);
                var v = ov.swizzle.gr;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(-5.5d, v.y);
            }
            {
                var ov = new dvec2(1.5d, -1.5d);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
            }
            {
                var ov = new dvec2(4d, -2d);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(4d, v.z);
                Assert.AreEqual(4d, v.w);
            }
            {
                var ov = new dvec2(8.5d, 6.5d);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
                Assert.AreEqual(8.5d, v.v);
            }
            {
                var ov = new dvec2(-1.5d, 1.0);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
                Assert.AreEqual(1.0, v.v);
            }
            {
                var ov = new dvec2(-9.5d, 6.5d);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec2(9.5d, 8.5d);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
                Assert.AreEqual(9.5d, v.v);
            }
            {
                var ov = new dvec2(2.5d, 3.5d);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
                Assert.AreEqual(3.5d, v.v);
            }
            {
                var ov = new dvec2(-3.5d, -2.5d);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var ov = new dvec2(3.5d, -0.5d);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec2(5.5d, -0.5d);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
                Assert.AreEqual(5.5d, v.v);
            }
            {
                var ov = new dvec2(-9d, -2.5d);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-9d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-9d, v.w);
                Assert.AreEqual(-2.5d, v.v);
            }
            {
                var ov = new dvec2(-8d, 5.5d);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec2(-4.5d, 0.0);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
                Assert.AreEqual(-4.5d, v.v);
            }
            {
                var ov = new dvec2(-8.5d, -8.5d);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
                Assert.AreEqual(-8.5d, v.v);
            }
            {
                var ov = new dvec2(8d, 0.0);
                var v = ov.swizzle.gg;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
            }
            {
                var ov = new dvec2(5d, 4d);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(5d, v.z);
            }
            {
                var ov = new dvec2(7d, -5.5d);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(7d, v.w);
            }
            {
                var ov = new dvec2(0.0, 7.5d);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
                Assert.AreEqual(0.0, v.v);
            }
            {
                var ov = new dvec2(8.5d, 0.5d);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
                Assert.AreEqual(0.5d, v.v);
            }
            {
                var ov = new dvec2(4.5d, -5.5d);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec2(-1.5d, -0.5d);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
                Assert.AreEqual(-1.5d, v.v);
            }
            {
                var ov = new dvec2(5.5d, 2.5d);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
                Assert.AreEqual(2.5d, v.v);
            }
            {
                var ov = new dvec2(-3d, 4d);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(4d, v.z);
            }
            {
                var ov = new dvec2(-7d, -8.5d);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(-7d, v.w);
            }
            {
                var ov = new dvec2(-5d, -0.5d);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-5d, v.w);
                Assert.AreEqual(-5d, v.v);
            }
            {
                var ov = new dvec2(-5d, -2.5d);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-5d, v.w);
                Assert.AreEqual(-2.5d, v.v);
            }
            {
                var ov = new dvec2(6.5d, 4.5d);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec2(-1.5d, 3d);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(3d, v.w);
                Assert.AreEqual(-1.5d, v.v);
            }
            {
                var ov = new dvec2(-1d, 9d);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(9d, v.y);
                Assert.AreEqual(9d, v.z);
                Assert.AreEqual(9d, v.w);
                Assert.AreEqual(9d, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new dvec2(5.5d, 8d);
                var v1 = new dvec2(-4.5d, 5.5d);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-4.5d, v0.x);
                Assert.AreEqual(5.5d, v0.y);
            
                Assert.AreEqual(5.5d, v2.x);
                Assert.AreEqual(8d, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new dvec2(-4d, 2.5d);
                var v1 = 1.5d;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1.5d, v0.x);
                Assert.AreEqual(2.5d, v0.y);
            
                Assert.AreEqual(-4d, v2);
            }
            {
                var v0 = new dvec2(9.5d, 2.5d);
                var v1 = 9d;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9.5d, v0.x);
                Assert.AreEqual(9d, v0.y);
            
                Assert.AreEqual(2.5d, v2);
            }
            {
                var v0 = new dvec2(-7d, 3.5d);
                var v1 = new dvec2(-8.5d, 4.5d);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8.5d, v0.x);
                Assert.AreEqual(4.5d, v0.y);
            
                Assert.AreEqual(-7d, v2.x);
                Assert.AreEqual(3.5d, v2.y);
            }
        }

    }
}
