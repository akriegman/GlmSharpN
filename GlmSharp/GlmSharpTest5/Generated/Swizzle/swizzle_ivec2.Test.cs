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
    public class IntSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new ivec2(0, 7);
                var v = ov.swizzle.xx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var ov = new ivec2(9, -6);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new ivec2(4, -5);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec2(-8, 2);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec2(-1, 1);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec2(-1, -1);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec2(3, 1);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec2(6, -9);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(2, 5);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new ivec2(1, 6);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec2(-9, 2);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(-6, -9);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(2, 6);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec2(-1, -4);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec2(2, -6);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec2(-1, 0);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var ov = new ivec2(-3, 5);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec2(-7, 7);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec2(3, 3);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec2(-5, 7);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec2(5, -9);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new ivec2(-5, 7);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec2(9, 3);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec2(2, 3);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new ivec2(2, 0);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec2(-2, 2);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec2(0, -1);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec2(4, -7);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec2(-1, 9);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec2(-3, -7);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec2(4, 4);
                var v = ov.swizzle.yx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
            }
            {
                var ov = new ivec2(0, -4);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new ivec2(-1, 9);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec2(-8, -8);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec2(3, -9);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(-6, -9);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new ivec2(9, -3);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec2(1, 0);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec2(7, 7);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var ov = new ivec2(9, -9);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec2(3, 6);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec2(-1, 1);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec2(4, 7);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec2(0, 1);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec2(0, 0);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec2(-6, -3);
                var v = ov.swizzle.yy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var ov = new ivec2(9, -8);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new ivec2(3, 1);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec2(-9, 1);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(-7, -9);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(5, 4);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec2(-9, 3);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(4, -3);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec2(-2, 7);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var ov = new ivec2(8, 4);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec2(9, 2);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec2(-9, -4);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec2(-3, -7);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec2(-3, -9);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec2(8, 2);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new ivec2(2, -9);
                var v = ov.swizzle.rr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var ov = new ivec2(4, -1);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new ivec2(-7, -1);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec2(-3, -5);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec2(4, 4);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec2(5, 2);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec2(1, 2);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec2(-1, 4);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec2(3, 2);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new ivec2(2, -3);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec2(-7, 1);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec2(8, 6);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec2(3, 2);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec2(-8, -2);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec2(0, 9);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec2(-5, 5);
                var v = ov.swizzle.rg;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var ov = new ivec2(-3, -7);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec2(2, -1);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec2(1, 6);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec2(5, 4);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec2(0, 9);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec2(-9, -4);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(7, 3);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec2(6, -3);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec2(1, 6);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec2(9, 4);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec2(-1, -3);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec2(0, 1);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec2(-1, -8);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec2(7, -5);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec2(-3, 1);
                var v = ov.swizzle.gr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var ov = new ivec2(-5, -5);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new ivec2(9, 0);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec2(8, 4);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec2(0, -9);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(3, -6);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec2(-7, -8);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec2(-3, 6);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec2(2, -4);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new ivec2(-8, 0);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec2(-6, 4);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec2(-1, -3);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec2(-9, 9);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec2(-5, 0);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec2(-6, 1);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec2(-9, 3);
                var v = ov.swizzle.gg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var ov = new ivec2(-8, -1);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var ov = new ivec2(-2, -9);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new ivec2(-4, 4);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec2(4, 7);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec2(-4, 1);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec2(-3, 1);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec2(3, -4);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec2(7, -3);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec2(0, -4);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec2(-9, -7);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec2(-9, 7);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec2(-8, 7);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec2(-1, 1);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec2(-5, -9);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new ivec2(-7, -5);
                var v1 = new ivec2(8, 5);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8, v0.x);
                Assert.AreEqual(5, v0.y);
            
                Assert.AreEqual(-7, v2.x);
                Assert.AreEqual(-5, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new ivec2(2, -7);
                var v1 = 6;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6, v0.x);
                Assert.AreEqual(-7, v0.y);
            
                Assert.AreEqual(2, v2);
            }
            {
                var v0 = new ivec2(3, -7);
                var v1 = 8;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3, v0.x);
                Assert.AreEqual(8, v0.y);
            
                Assert.AreEqual(-7, v2);
            }
            {
                var v0 = new ivec2(-9, 5);
                var v1 = new ivec2(9, 7);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9, v0.x);
                Assert.AreEqual(7, v0.y);
            
                Assert.AreEqual(-9, v2.x);
                Assert.AreEqual(5, v2.y);
            }
        }

    }
}
