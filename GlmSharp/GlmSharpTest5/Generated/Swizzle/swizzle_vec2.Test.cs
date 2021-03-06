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
    public class FloatSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new vec2(1.5f, 5f);
                var v = ov.swizzle.xx;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
            }
            {
                var ov = new vec2(0.5f, 1f);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
            }
            {
                var ov = new vec2(-4.5f, -9f);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec2(3.5f, 7f);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec2(0.5f, 4f);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec2(-2f, 8f);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec2(-4.5f, -8f);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec2(1f, 1.5f);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec2(-9f, 1.5f);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(1.5f, v.z);
            }
            {
                var ov = new vec2(9.5f, -9.5f);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec2(0f, 5f);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec2(6f, 3f);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec2(-1.5f, -1f);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec2(0f, -4.5f);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec2(9f, 5f);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec2(1.5f, 7.5f);
                var v = ov.swizzle.xy;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
            }
            {
                var ov = new vec2(2f, -4f);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec2(-5.5f, 1.5f);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec2(7.5f, -9f);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec2(0.5f, 7f);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec2(4f, -4f);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec2(9.5f, -1f);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec2(-7.5f, -4.5f);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec2(9f, -1f);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
            }
            {
                var ov = new vec2(-6f, -7f);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec2(7.5f, -1.5f);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec2(6f, -7.5f);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(-7.5f, v.v);
            }
            {
                var ov = new vec2(-2f, -4.5f);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec2(9.5f, -2.5f);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec2(-4f, -4f);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec2(-9f, 7f);
                var v = ov.swizzle.yx;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-9f, v.y);
            }
            {
                var ov = new vec2(8.5f, -5.5f);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
            }
            {
                var ov = new vec2(-3f, -4f);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec2(6f, -2f);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec2(3.5f, 9f);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec2(4.5f, 0f);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec2(1f, 2.5f);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec2(-6f, -3.5f);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec2(5f, 6.5f);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(6.5f, v.z);
            }
            {
                var ov = new vec2(-8.5f, 2f);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec2(1f, -0.5f);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec2(8f, 2.5f);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec2(7f, 3f);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec2(1.5f, -8.5f);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec2(1f, 8.5f);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec2(2.5f, 9f);
                var v = ov.swizzle.yy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(9f, v.y);
            }
            {
                var ov = new vec2(4f, -6f);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec2(-0.5f, 6.5f);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec2(-6f, -5f);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-6f, v.v);
            }
            {
                var ov = new vec2(7.5f, 8f);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec2(-8f, 7.5f);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec2(-8f, 5f);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec2(-6.5f, 7.5f);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec2(-2.5f, -5f);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
            }
            {
                var ov = new vec2(5f, -3.5f);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec2(-9f, 3f);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec2(5f, -2f);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec2(-3f, -0.5f);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec2(8.5f, 5f);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec2(-7f, 9f);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(9f, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new vec2(-5f, 8f);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
            }
            {
                var ov = new vec2(9.5f, -4f);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
            }
            {
                var ov = new vec2(-9f, 3.5f);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec2(1.5f, -1.5f);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec2(0f, 9f);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec2(-7.5f, -9f);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec2(-4.5f, 2.5f);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec2(3.5f, -8f);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec2(3.5f, -3.5f);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
            }
            {
                var ov = new vec2(8f, -8.5f);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec2(3.5f, 2f);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec2(2f, 9f);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(2f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec2(-4.5f, 8f);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec2(-8f, -1.5f);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec2(5.5f, 7f);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec2(-8.5f, -5f);
                var v = ov.swizzle.rg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-5f, v.y);
            }
            {
                var ov = new vec2(9f, 2.5f);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(9f, v.z);
            }
            {
                var ov = new vec2(-6f, 5f);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec2(-3f, 2f);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec2(-2f, -9f);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec2(7f, 5f);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec2(-0.5f, 4.5f);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec2(-3f, 0.5f);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(0.5f, v.v);
            }
            {
                var ov = new vec2(8f, -6.5f);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
            }
            {
                var ov = new vec2(2.5f, 8.5f);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec2(6f, -2.5f);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec2(-6f, -3.5f);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec2(9.5f, -2f);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec2(5f, 0.5f);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec2(-0.5f, -1f);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec2(-6f, 3f);
                var v = ov.swizzle.gr;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-6f, v.y);
            }
            {
                var ov = new vec2(3.5f, 2.5f);
                var v = ov.swizzle.grr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec2(-1.5f, 6f);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec2(8f, 3.5f);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec2(-6f, -1.5f);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec2(5f, 0.5f);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec2(-4f, 0.5f);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec2(-4f, -1.5f);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec2(-3f, 8f);
                var v = ov.swizzle.grg;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(8f, v.z);
            }
            {
                var ov = new vec2(7.5f, 5.5f);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec2(9.5f, 4.5f);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec2(5.5f, 6.5f);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec2(1f, 4.5f);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec2(9.5f, -5.5f);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec2(3.5f, 4f);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec2(9.5f, -6.5f);
                var v = ov.swizzle.gg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
            }
            {
                var ov = new vec2(-4f, 1f);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-4f, v.z);
            }
            {
                var ov = new vec2(3f, 4f);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec2(-2f, 7.5f);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec2(5f, 5f);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec2(-8.5f, -6f);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec2(7f, 4f);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec2(2.5f, -7f);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec2(-3f, -3.5f);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
            }
            {
                var ov = new vec2(-3f, -2f);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec2(8.5f, 6.5f);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec2(3.5f, 3.5f);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec2(-1f, -8.5f);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec2(8f, 6.5f);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec2(1.5f, 4.5f);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new vec2(4f, 9.5f);
                var v1 = new vec2(6f, 3f);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6f, v0.x);
                Assert.AreEqual(3f, v0.y);
            
                Assert.AreEqual(4f, v2.x);
                Assert.AreEqual(9.5f, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new vec2(6.5f, -3.5f);
                var v1 = -5.5f;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5.5f, v0.x);
                Assert.AreEqual(-3.5f, v0.y);
            
                Assert.AreEqual(6.5f, v2);
            }
            {
                var v0 = new vec2(-5f, -1f);
                var v1 = 7f;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5f, v0.x);
                Assert.AreEqual(7f, v0.y);
            
                Assert.AreEqual(-1f, v2);
            }
            {
                var v0 = new vec2(5.5f, -5f);
                var v1 = new vec2(-0.5f, -7f);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-0.5f, v0.x);
                Assert.AreEqual(-7f, v0.y);
            
                Assert.AreEqual(5.5f, v2.x);
                Assert.AreEqual(-5f, v2.y);
            }
        }

    }
}
