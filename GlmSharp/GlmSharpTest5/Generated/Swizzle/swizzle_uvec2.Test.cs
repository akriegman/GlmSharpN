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
    public class UintSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new uvec2(8u, 5u);
                var v = ov.swizzle.xx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
            }
            {
                var ov = new uvec2(0u, 5u);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var ov = new uvec2(0u, 5u);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec2(0u, 9u);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var ov = new uvec2(8u, 5u);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(2u, 6u);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec2(6u, 4u);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(4u, v.w);
                Assert.AreEqual(6u, v.v);
            }
            {
                var ov = new uvec2(3u, 5u);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(4u, 6u);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec2(0u, 5u);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec2(5u, 6u);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(0u, 3u);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(3u, v.v);
            }
            {
                var ov = new uvec2(4u, 8u);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec2(8u, 8u);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
                Assert.AreEqual(8u, v.v);
            }
            {
                var ov = new uvec2(2u, 5u);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(8u, 1u);
                var v = ov.swizzle.xy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var ov = new uvec2(5u, 7u);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(5u, v.z);
            }
            {
                var ov = new uvec2(8u, 1u);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec2(4u, 2u);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
                Assert.AreEqual(4u, v.v);
            }
            {
                var ov = new uvec2(3u, 9u);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
                Assert.AreEqual(9u, v.v);
            }
            {
                var ov = new uvec2(6u, 9u);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec2(2u, 1u);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(2u, v.v);
            }
            {
                var ov = new uvec2(8u, 9u);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(9u, v.w);
                Assert.AreEqual(9u, v.v);
            }
            {
                var ov = new uvec2(7u, 5u);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
            }
            {
                var ov = new uvec2(5u, 5u);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec2(7u, 2u);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(7u, v.w);
                Assert.AreEqual(7u, v.v);
            }
            {
                var ov = new uvec2(8u, 2u);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(8u, v.w);
                Assert.AreEqual(2u, v.v);
            }
            {
                var ov = new uvec2(4u, 2u);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec2(5u, 6u);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(1u, 1u);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(7u, 1u);
                var v = ov.swizzle.yx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(7u, v.y);
            }
            {
                var ov = new uvec2(7u, 3u);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec2(6u, 0u);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec2(0u, 8u);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var ov = new uvec2(6u, 2u);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
                Assert.AreEqual(2u, v.v);
            }
            {
                var ov = new uvec2(1u, 1u);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec2(2u, 1u);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(2u, v.v);
            }
            {
                var ov = new uvec2(8u, 6u);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(6u, v.w);
                Assert.AreEqual(6u, v.v);
            }
            {
                var ov = new uvec2(3u, 8u);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uvec2(5u, 4u);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec2(1u, 2u);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(2u, 6u);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(2u, v.w);
                Assert.AreEqual(6u, v.v);
            }
            {
                var ov = new uvec2(7u, 6u);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec2(2u, 2u);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
                Assert.AreEqual(2u, v.v);
            }
            {
                var ov = new uvec2(3u, 5u);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(6u, 7u);
                var v = ov.swizzle.yy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
            }
            {
                var ov = new uvec2(0u, 2u);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var ov = new uvec2(1u, 5u);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec2(1u, 9u);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(5u, 7u);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(7u, v.v);
            }
            {
                var ov = new uvec2(8u, 9u);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec2(9u, 3u);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(3u, v.w);
                Assert.AreEqual(9u, v.v);
            }
            {
                var ov = new uvec2(3u, 5u);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(9u, 7u);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec2(3u, 7u);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec2(8u, 6u);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(8u, v.w);
                Assert.AreEqual(8u, v.v);
            }
            {
                var ov = new uvec2(1u, 6u);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(6u, v.v);
            }
            {
                var ov = new uvec2(0u, 5u);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec2(8u, 0u);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(8u, v.v);
            }
            {
                var ov = new uvec2(5u, 0u);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(0u, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new uvec2(9u, 9u);
                var v = ov.swizzle.rr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
            }
            {
                var ov = new uvec2(6u, 6u);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec2(6u, 0u);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec2(9u, 8u);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
                Assert.AreEqual(9u, v.v);
            }
            {
                var ov = new uvec2(5u, 9u);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(9u, v.v);
            }
            {
                var ov = new uvec2(5u, 0u);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec2(0u, 2u);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(2u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var ov = new uvec2(0u, 5u);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(5u, 1u);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec2(4u, 4u);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec2(1u, 0u);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(0u, 1u);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(2u, 0u);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec2(1u, 8u);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(3u, 0u);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var ov = new uvec2(2u, 8u);
                var v = ov.swizzle.rg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(8u, v.y);
            }
            {
                var ov = new uvec2(1u, 0u);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec2(4u, 0u);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec2(1u, 1u);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(2u, 3u);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
                Assert.AreEqual(3u, v.v);
            }
            {
                var ov = new uvec2(5u, 0u);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec2(6u, 0u);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(6u, v.v);
            }
            {
                var ov = new uvec2(9u, 6u);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(6u, v.w);
                Assert.AreEqual(6u, v.v);
            }
            {
                var ov = new uvec2(8u, 4u);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uvec2(9u, 2u);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec2(0u, 1u);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var ov = new uvec2(4u, 8u);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(4u, v.w);
                Assert.AreEqual(8u, v.v);
            }
            {
                var ov = new uvec2(4u, 8u);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec2(8u, 5u);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(8u, v.v);
            }
            {
                var ov = new uvec2(4u, 5u);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(8u, 0u);
                var v = ov.swizzle.gr;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(8u, v.y);
            }
            {
                var ov = new uvec2(4u, 4u);
                var v = ov.swizzle.grr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uvec2(6u, 7u);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec2(9u, 9u);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
                Assert.AreEqual(9u, v.v);
            }
            {
                var ov = new uvec2(7u, 0u);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var ov = new uvec2(4u, 4u);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec2(8u, 1u);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(8u, v.v);
            }
            {
                var ov = new uvec2(8u, 1u);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(4u, 9u);
                var v = ov.swizzle.grg;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var ov = new uvec2(1u, 6u);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec2(2u, 7u);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(2u, v.w);
                Assert.AreEqual(2u, v.v);
            }
            {
                var ov = new uvec2(8u, 1u);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(8u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var ov = new uvec2(0u, 1u);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec2(3u, 2u);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
                Assert.AreEqual(3u, v.v);
            }
            {
                var ov = new uvec2(6u, 5u);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(1u, 6u);
                var v = ov.swizzle.gg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
            }
            {
                var ov = new uvec2(6u, 7u);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec2(4u, 4u);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec2(5u, 1u);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
                Assert.AreEqual(5u, v.v);
            }
            {
                var ov = new uvec2(4u, 2u);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
                Assert.AreEqual(2u, v.v);
            }
            {
                var ov = new uvec2(6u, 8u);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec2(6u, 9u);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(9u, v.w);
                Assert.AreEqual(6u, v.v);
            }
            {
                var ov = new uvec2(7u, 6u);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(6u, v.w);
                Assert.AreEqual(6u, v.v);
            }
            {
                var ov = new uvec2(2u, 3u);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
            }
            {
                var ov = new uvec2(0u, 3u);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec2(4u, 8u);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(4u, v.w);
                Assert.AreEqual(4u, v.v);
            }
            {
                var ov = new uvec2(3u, 8u);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(3u, v.w);
                Assert.AreEqual(8u, v.v);
            }
            {
                var ov = new uvec2(3u, 1u);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec2(2u, 3u);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
                Assert.AreEqual(2u, v.v);
            }
            {
                var ov = new uvec2(3u, 4u);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
                Assert.AreEqual(4u, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new uvec2(1u, 1u);
                var v1 = new uvec2(5u, 9u);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(5u, v0.x);
                Assert.AreEqual(9u, v0.y);
            
                Assert.AreEqual(1u, v2.x);
                Assert.AreEqual(1u, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new uvec2(7u, 0u);
                var v1 = 1u;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1u, v0.x);
                Assert.AreEqual(0u, v0.y);
            
                Assert.AreEqual(7u, v2);
            }
            {
                var v0 = new uvec2(2u, 3u);
                var v1 = 8u;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2u, v0.x);
                Assert.AreEqual(8u, v0.y);
            
                Assert.AreEqual(3u, v2);
            }
            {
                var v0 = new uvec2(9u, 8u);
                var v1 = new uvec2(8u, 2u);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8u, v0.x);
                Assert.AreEqual(2u, v0.y);
            
                Assert.AreEqual(9u, v2.x);
                Assert.AreEqual(8u, v2.y);
            }
        }

    }
}
