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
    public class LongSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new lvec2(-6L, 5L);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
            }
            {
                var ov = new lvec2(-9L, -1L);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec2(6L, -5L);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec2(3L, -5L);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec2(5L, 2L);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec2(2L, 5L);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec2(4L, 0);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec2(-4L, 4L);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec2(0, 7L);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7L, v.z);
            }
            {
                var ov = new lvec2(-8L, 0);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec2(0, 9L);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec2(3L, 8L);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec2(-9L, 3L);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec2(0, 6L);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec2(8L, 1);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec2(-8L, -9L);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
            }
            {
                var ov = new lvec2(3L, -7L);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec2(0, -8L);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec2(0, 9L);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec2(8L, -3L);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec2(3L, -7L);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec2(-8L, -2L);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec2(6L, -1L);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec2(-2L, 2L);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec2(4L, -1L);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec2(9L, -2L);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec2(6L, 7L);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec2(-5L, 6L);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec2(1, 9L);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec2(-1L, 3L);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec2(-4L, -7L);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-4L, v.y);
            }
            {
                var ov = new lvec2(5L, 4L);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec2(4L, 2L);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec2(2L, 7L);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec2(0, -6L);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec2(3L, -1L);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec2(-9L, 4L);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec2(-7L, 3L);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec2(-2L, -1L);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec2(2L, 7L);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec2(-1L, -8L);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec2(2L, -7L);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec2(-1L, 5L);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec2(-3L, -5L);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec2(1, -4L);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec2(-6L, -1L);
                var v = ov.swizzle.yy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
            }
            {
                var ov = new lvec2(-8L, 5L);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec2(-8L, 6L);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec2(-1L, -3L);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec2(7L, 4L);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec2(8L, 4L);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec2(2L, 8L);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec2(6L, -9L);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec2(-3L, 2L);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec2(-1L, -2L);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec2(-4L, -1L);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec2(6L, 3L);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec2(-2L, -6L);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec2(-5L, 7L);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec2(-3L, -8L);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new lvec2(-1L, 0);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
            }
            {
                var ov = new lvec2(3L, -6L);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec2(0, -9L);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec2(-9L, -5L);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec2(2L, -8L);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec2(6L, 0);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec2(5L, 6L);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec2(-2L, 7L);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec2(-2L, -7L);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec2(-5L, 8L);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec2(4L, 0);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec2(8L, -5L);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec2(-7L, -2L);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec2(-2L, 5L);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec2(9L, 5L);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec2(-6L, 7L);
                var v = ov.swizzle.rg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(7L, v.y);
            }
            {
                var ov = new lvec2(-7L, 0);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec2(-5L, 6L);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec2(4L, 5L);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec2(-6L, 8L);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec2(8L, -8L);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec2(7L, 3L);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec2(7L, 6L);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec2(8L, 1);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec2(2L, 9L);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec2(-6L, -1L);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec2(-4L, -3L);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec2(-3L, 9L);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec2(-1L, 8L);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec2(-8L, 8L);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec2(6L, -4L);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(6L, v.y);
            }
            {
                var ov = new lvec2(5L, -7L);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec2(1, -9L);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec2(2L, 4L);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec2(-2L, 5L);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec2(3L, 6L);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec2(0, 6L);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec2(-9L, 6L);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec2(-3L, 4L);
                var v = ov.swizzle.grg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec2(6L, -1L);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec2(3L, -1L);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec2(2L, -9L);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec2(8L, 5L);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec2(-4L, 4L);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec2(6L, 4L);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec2(-5L, -5L);
                var v = ov.swizzle.gg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
            }
            {
                var ov = new lvec2(6L, 7L);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec2(1, -5L);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec2(-2L, -1L);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec2(1, 8L);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec2(3L, 3L);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec2(8L, -7L);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec2(6L, 8L);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec2(9L, 6L);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec2(-3L, 6L);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec2(-7L, 6L);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec2(2L, 7L);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec2(4L, -5L);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec2(-1L, 6L);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec2(7L, -6L);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new lvec2(4L, 8L);
                var v1 = new lvec2(-2L, -9L);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-2L, v0.x);
                Assert.AreEqual(-9L, v0.y);
            
                Assert.AreEqual(4L, v2.x);
                Assert.AreEqual(8L, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new lvec2(-5L, -7L);
                var v1 = 8L;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8L, v0.x);
                Assert.AreEqual(-7L, v0.y);
            
                Assert.AreEqual(-5L, v2);
            }
            {
                var v0 = new lvec2(-8L, -4L);
                var v1 = 1;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8L, v0.x);
                Assert.AreEqual(1, v0.y);
            
                Assert.AreEqual(-4L, v2);
            }
            {
                var v0 = new lvec2(-4L, 5L);
                var v1 = new lvec2(-3L, -5L);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3L, v0.x);
                Assert.AreEqual(-5L, v0.y);
            
                Assert.AreEqual(-4L, v2.x);
                Assert.AreEqual(5L, v2.y);
            }
        }

    }
}
