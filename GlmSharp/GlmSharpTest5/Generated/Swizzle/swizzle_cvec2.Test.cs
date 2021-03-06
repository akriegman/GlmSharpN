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
    public class ComplexSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new cvec2(new Complex(8.5d, -3.5d), new Complex(0.5d, -8.5d));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.y);
            }
            {
                var ov = new cvec2(new Complex(-6d, 0.0), new Complex(-2d, -9.5d));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new Complex(-6d, 0.0), v.x);
                Assert.AreEqual(new Complex(-6d, 0.0), v.y);
                Assert.AreEqual(new Complex(-6d, 0.0), v.z);
            }
            {
                var ov = new cvec2(new Complex(9d, 5d), new Complex(-9.5d, 7d));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new Complex(9d, 5d), v.x);
                Assert.AreEqual(new Complex(9d, 5d), v.y);
                Assert.AreEqual(new Complex(9d, 5d), v.z);
                Assert.AreEqual(new Complex(9d, 5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, 5d), new Complex(-1d, 1.0));
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(new Complex(-1.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-7d, 8d), new Complex(0.0, -0.5d));
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(new Complex(-7d, 8d), v.x);
                Assert.AreEqual(new Complex(-7d, 8d), v.y);
                Assert.AreEqual(new Complex(-7d, 8d), v.z);
                Assert.AreEqual(new Complex(-7d, 8d), v.w);
                Assert.AreEqual(new Complex(0.0, -0.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(0.5d, -3.5d), new Complex(-4.5d, -6.5d));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new Complex(0.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-3.5d, -7d), new Complex(-2.5d, -4.5d));
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(new Complex(-3.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -7d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -4.5d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -7d), v.v);
            }
            {
                var ov = new cvec2(new Complex(1.0, 9d), new Complex(6d, 8.5d));
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(new Complex(1.0, 9d), v.x);
                Assert.AreEqual(new Complex(1.0, 9d), v.y);
                Assert.AreEqual(new Complex(1.0, 9d), v.z);
                Assert.AreEqual(new Complex(6d, 8.5d), v.w);
                Assert.AreEqual(new Complex(6d, 8.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(7d, -1d), new Complex(-4d, -1d));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new Complex(7d, -1d), v.x);
                Assert.AreEqual(new Complex(7d, -1d), v.y);
                Assert.AreEqual(new Complex(-4d, -1d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-7.5d, -2.5d), new Complex(-5.5d, 9.5d));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(5d, -6.5d), new Complex(-0.5d, -5.5d));
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(new Complex(5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(5d, -6.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(8d, -8.5d), new Complex(-7d, -8d));
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(new Complex(8d, -8.5d), v.x);
                Assert.AreEqual(new Complex(8d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -8d), v.z);
                Assert.AreEqual(new Complex(8d, -8.5d), v.w);
                Assert.AreEqual(new Complex(-7d, -8d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-8.5d, -4d), new Complex(-0.5d, -7.5d));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new Complex(-8.5d, -4d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(5.5d, -3.5d), new Complex(-0.5d, 6.5d));
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(6d, 7.5d), new Complex(3.5d, 7d));
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(new Complex(6d, 7.5d), v.x);
                Assert.AreEqual(new Complex(6d, 7.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 7d), v.z);
                Assert.AreEqual(new Complex(3.5d, 7d), v.w);
                Assert.AreEqual(new Complex(3.5d, 7d), v.v);
            }
            {
                var ov = new cvec2(new Complex(7.5d, 5d), new Complex(8d, -3d));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new Complex(7.5d, 5d), v.x);
                Assert.AreEqual(new Complex(8d, -3d), v.y);
            }
            {
                var ov = new cvec2(new Complex(7.5d, 5.5d), Complex.Zero);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new Complex(7.5d, 5.5d), v.x);
                Assert.AreEqual(Complex.Zero, v.y);
                Assert.AreEqual(new Complex(7.5d, 5.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(1.0, -8.5d), new Complex(4d, -9d));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new Complex(1.0, -8.5d), v.x);
                Assert.AreEqual(new Complex(4d, -9d), v.y);
                Assert.AreEqual(new Complex(1.0, -8.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -8.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-4.5d, -1.5d), new Complex(9.5d, -9.5d));
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(5d, -0.5d), new Complex(3.5d, -8.5d));
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(new Complex(5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(5d, -0.5d), v.w);
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-5.5d, -4.5d), new Complex(-2.5d, -3d));
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new Complex(-5.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -3d), v.w);
            }
            {
                var ov = new cvec2(new Complex(7.5d, 6.5d), new Complex(-3.5d, -9d));
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -9d), v.y);
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -9d), v.w);
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-8.5d, 7d), new Complex(2.5d, 4d));
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(new Complex(-8.5d, 7d), v.x);
                Assert.AreEqual(new Complex(2.5d, 4d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 7d), v.z);
                Assert.AreEqual(new Complex(2.5d, 4d), v.w);
                Assert.AreEqual(new Complex(2.5d, 4d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-6.5d, -6.5d), new Complex(-9d, -2.5d));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new Complex(-6.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-9d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-9d, -2.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-4.5d, 2d), new Complex(8.5d, -3.5d));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new Complex(-4.5d, 2d), v.x);
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 2d), v.w);
            }
            {
                var ov = new cvec2(new Complex(4d, -8.5d), new Complex(-2.5d, -3d));
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(new Complex(4d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -3d), v.z);
                Assert.AreEqual(new Complex(4d, -8.5d), v.w);
                Assert.AreEqual(new Complex(4d, -8.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(0.5d, 0.5d), new Complex(5.5d, -9.5d));
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-2d, -2.5d), new Complex(8d, 9.5d));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new Complex(-2d, -2.5d), v.x);
                Assert.AreEqual(new Complex(8d, 9.5d), v.y);
                Assert.AreEqual(new Complex(8d, 9.5d), v.z);
                Assert.AreEqual(new Complex(8d, 9.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-8.5d, 8.5d), new Complex(8.5d, -7.5d));
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(1.5d, 5d), new Complex(-9.5d, -6.5d));
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(new Complex(1.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-9.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-5.5d, -8.5d), new Complex(8.5d, 8d));
                var v = ov.swizzle.yx;
                Assert.AreEqual(new Complex(8.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.y);
            }
            {
                var ov = new cvec2(new Complex(3d, 2d), new Complex(-5.5d, 0.0));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new Complex(-5.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(3d, 2d), v.y);
                Assert.AreEqual(new Complex(3d, 2d), v.z);
            }
            {
                var ov = new cvec2(new Complex(3d, -5.5d), new Complex(-7.5d, -2d));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(new Complex(-7.5d, -2d), v.x);
                Assert.AreEqual(new Complex(3d, -5.5d), v.y);
                Assert.AreEqual(new Complex(3d, -5.5d), v.z);
                Assert.AreEqual(new Complex(3d, -5.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-2.5d, -2.5d), new Complex(-3.5d, -6d));
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(new Complex(-3.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(-2.5d, -2.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-3.5d, 1.0), new Complex(6.5d, 1.5d));
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(new Complex(6.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.w);
                Assert.AreEqual(new Complex(6.5d, 1.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-7.5d, 9d), new Complex(7d, 0.5d));
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(new Complex(7d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 9d), v.z);
                Assert.AreEqual(new Complex(7d, 0.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(7d, -9.5d), new Complex(-0.5d, 6d));
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(new Complex(-0.5d, 6d), v.x);
                Assert.AreEqual(new Complex(7d, -9.5d), v.y);
                Assert.AreEqual(new Complex(7d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 6d), v.w);
                Assert.AreEqual(new Complex(7d, -9.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(0.0, -2d), new Complex(-9d, 9d));
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(new Complex(-9d, 9d), v.x);
                Assert.AreEqual(new Complex(0.0, -2d), v.y);
                Assert.AreEqual(new Complex(0.0, -2d), v.z);
                Assert.AreEqual(new Complex(-9d, 9d), v.w);
                Assert.AreEqual(new Complex(-9d, 9d), v.v);
            }
            {
                var ov = new cvec2(new Complex(1.5d, -2.5d), new Complex(-6.5d, 1.0));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new Complex(-6.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(1.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 1.0), v.z);
            }
            {
                var ov = new cvec2(new Complex(6.5d, -1d), new Complex(-0.5d, 9d));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new Complex(-0.5d, 9d), v.x);
                Assert.AreEqual(new Complex(6.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 9d), v.z);
                Assert.AreEqual(new Complex(6.5d, -1d), v.w);
            }
            {
                var ov = new cvec2(new Complex(5d, 7.5d), new Complex(-6d, 7.5d));
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(new Complex(-6d, 7.5d), v.x);
                Assert.AreEqual(new Complex(5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 7.5d), v.z);
                Assert.AreEqual(new Complex(5d, 7.5d), v.w);
                Assert.AreEqual(new Complex(5d, 7.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(4d, 1.5d), new Complex(8d, -2d));
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(new Complex(8d, -2d), v.x);
                Assert.AreEqual(new Complex(4d, 1.5d), v.y);
                Assert.AreEqual(new Complex(8d, -2d), v.z);
                Assert.AreEqual(new Complex(4d, 1.5d), v.w);
                Assert.AreEqual(new Complex(8d, -2d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, -4.5d), new Complex(9d, 0.5d));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new Complex(9d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(9d, 0.5d), v.z);
                Assert.AreEqual(new Complex(9d, 0.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-8d, -6.5d), new Complex(2d, -4d));
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(new Complex(2d, -4d), v.x);
                Assert.AreEqual(new Complex(-8d, -6.5d), v.y);
                Assert.AreEqual(new Complex(2d, -4d), v.z);
                Assert.AreEqual(new Complex(2d, -4d), v.w);
                Assert.AreEqual(new Complex(-8d, -6.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, -2d), new Complex(2.5d, -7.5d));
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(new Complex(2.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -2d), v.y);
                Assert.AreEqual(new Complex(2.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -7.5d), v.w);
                Assert.AreEqual(new Complex(2.5d, -7.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-6.5d, -9.5d), new Complex(-2.5d, 6d));
                var v = ov.swizzle.yy;
                Assert.AreEqual(new Complex(-2.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 6d), v.y);
            }
            {
                var ov = new cvec2(new Complex(8d, -2d), new Complex(-3.5d, 5d));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new Complex(-3.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 5d), v.y);
                Assert.AreEqual(new Complex(8d, -2d), v.z);
            }
            {
                var ov = new cvec2(new Complex(8d, 8.5d), new Complex(-3.5d, -6d));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new Complex(-3.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -6d), v.y);
                Assert.AreEqual(new Complex(8d, 8.5d), v.z);
                Assert.AreEqual(new Complex(8d, 8.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-5.5d, 8d), new Complex(-4d, 4.5d));
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(new Complex(-4d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-4d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-7.5d, 3.5d), new Complex(8.5d, 5.5d));
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(4d, -5d), new Complex(7.5d, 7d));
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(new Complex(7.5d, 7d), v.x);
                Assert.AreEqual(new Complex(7.5d, 7d), v.y);
                Assert.AreEqual(new Complex(4d, -5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 7d), v.w);
            }
            {
                var ov = new cvec2(new Complex(3.5d, -3.5d), new Complex(-1.5d, -2d));
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(new Complex(-1.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -2d), v.y);
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -2d), v.w);
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-7d, -4d), new Complex(6.5d, 0.5d));
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(new Complex(6.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -4d), v.z);
                Assert.AreEqual(new Complex(6.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(6.5d, 0.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-9d, 1.5d), new Complex(1.0, -7.5d));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new Complex(1.0, -7.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -7.5d), v.y);
                Assert.AreEqual(new Complex(1.0, -7.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(5.5d, 5d), new Complex(3.5d, -7d));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new Complex(3.5d, -7d), v.x);
                Assert.AreEqual(new Complex(3.5d, -7d), v.y);
                Assert.AreEqual(new Complex(3.5d, -7d), v.z);
                Assert.AreEqual(new Complex(5.5d, 5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-8d, -3d), new Complex(8.5d, 6.5d));
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(new Complex(8.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-8d, -3d), v.w);
                Assert.AreEqual(new Complex(-8d, -3d), v.v);
            }
            {
                var ov = new cvec2(new Complex(2d, 8d), new Complex(1.0, 4.5d));
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(new Complex(1.0, 4.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.z);
                Assert.AreEqual(new Complex(2d, 8d), v.w);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-4d, -5.5d), new Complex(7d, -8.5d));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new Complex(7d, -8.5d), v.x);
                Assert.AreEqual(new Complex(7d, -8.5d), v.y);
                Assert.AreEqual(new Complex(7d, -8.5d), v.z);
                Assert.AreEqual(new Complex(7d, -8.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(3.5d, -5d), new Complex(4.5d, 0.5d));
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(3.5d, -5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(5.5d, -6d), new Complex(3.5d, 3.5d));
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(new Complex(3.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(3.5d, 3.5d), v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new cvec2(new Complex(7d, -7d), new Complex(-5.5d, 3.5d));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new Complex(7d, -7d), v.x);
                Assert.AreEqual(new Complex(7d, -7d), v.y);
            }
            {
                var ov = new cvec2(new Complex(-5d, -1d), new Complex(4d, 5d));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new Complex(-5d, -1d), v.x);
                Assert.AreEqual(new Complex(-5d, -1d), v.y);
                Assert.AreEqual(new Complex(-5d, -1d), v.z);
            }
            {
                var ov = new cvec2(new Complex(4.5d, -8.5d), new Complex(3.5d, 6d));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new Complex(4.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(6.5d, 4d), new Complex(-3.5d, -8d));
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(new Complex(6.5d, 4d), v.x);
                Assert.AreEqual(new Complex(6.5d, 4d), v.y);
                Assert.AreEqual(new Complex(6.5d, 4d), v.z);
                Assert.AreEqual(new Complex(6.5d, 4d), v.w);
                Assert.AreEqual(new Complex(6.5d, 4d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-4d, -7.5d), new Complex(-3d, 7.5d));
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(new Complex(-4d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-4d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-4d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -7.5d), v.w);
                Assert.AreEqual(new Complex(-3d, 7.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(3d, 1.0), new Complex(2d, -9.5d));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new Complex(3d, 1.0), v.x);
                Assert.AreEqual(new Complex(3d, 1.0), v.y);
                Assert.AreEqual(new Complex(3d, 1.0), v.z);
                Assert.AreEqual(new Complex(2d, -9.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-4.5d, 6d), new Complex(-7.5d, -5.5d));
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(new Complex(-4.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 6d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 6d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -5.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 6d), v.v);
            }
            {
                var ov = new cvec2(new Complex(3.5d, -3d), new Complex(2d, 0.0));
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(new Complex(3.5d, -3d), v.x);
                Assert.AreEqual(new Complex(3.5d, -3d), v.y);
                Assert.AreEqual(new Complex(3.5d, -3d), v.z);
                Assert.AreEqual(new Complex(2d, 0.0), v.w);
                Assert.AreEqual(new Complex(2d, 0.0), v.v);
            }
            {
                var ov = new cvec2(new Complex(4d, -0.5d), new Complex(3d, -6.5d));
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new Complex(4d, -0.5d), v.x);
                Assert.AreEqual(new Complex(4d, -0.5d), v.y);
                Assert.AreEqual(new Complex(3d, -6.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-3.5d, -1.5d), new Complex(-6d, 6.5d));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new Complex(-3.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, 9d), new Complex(-9d, 7.5d));
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(new Complex(-1.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-9d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.v);
            }
            {
                var ov = new cvec2(new Complex(0.0, -3.5d), new Complex(6.5d, -4d));
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(new Complex(0.0, -3.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -3.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -4d), v.z);
                Assert.AreEqual(new Complex(0.0, -3.5d), v.w);
                Assert.AreEqual(new Complex(6.5d, -4d), v.v);
            }
            {
                var ov = new cvec2(new Complex(2.5d, -5d), new Complex(0.5d, -2d));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new Complex(2.5d, -5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -2d), v.z);
                Assert.AreEqual(new Complex(0.5d, -2d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-7.5d, 5.5d), new Complex(-6.5d, -7d));
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -7d), v.w);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(7.5d, 2.5d), new Complex(-8.5d, 5d));
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(new Complex(7.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-5d, 6.5d), new Complex(4d, 9d));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new Complex(-5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(4d, 9d), v.y);
            }
            {
                var ov = new cvec2(new Complex(-5d, 1.0), new Complex(5d, -6.5d));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new Complex(-5d, 1.0), v.x);
                Assert.AreEqual(new Complex(5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 1.0), v.z);
            }
            {
                var ov = new cvec2(new Complex(8.5d, 8.5d), new Complex(2.5d, -1.5d));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new Complex(8.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-5.5d, 4.5d), new Complex(-7.5d, -2.5d));
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(new Complex(-5.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 4.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(6.5d, -3d), new Complex(3.5d, 1.5d));
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(new Complex(6.5d, -3d), v.x);
                Assert.AreEqual(new Complex(3.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -3d), v.z);
                Assert.AreEqual(new Complex(6.5d, -3d), v.w);
                Assert.AreEqual(new Complex(3.5d, 1.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-2.5d, 1.5d), new Complex(2.5d, 1.5d));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new Complex(-2.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(1.5d, 2.5d), new Complex(-8d, 0.5d));
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(new Complex(1.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-8d, 0.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 0.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-4d, 4.5d), new Complex(-6.5d, -8.5d));
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(new Complex(-4d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(-6.5d, -8.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(5.5d, -4.5d), new Complex(-5d, -5d));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -5d), v.y);
                Assert.AreEqual(new Complex(-5d, -5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-5.5d, 8d), new Complex(-7d, -9d));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new Complex(-5.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-7d, -9d), v.y);
                Assert.AreEqual(new Complex(-7d, -9d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.w);
            }
            {
                var ov = new cvec2(new Complex(0.0, 4d), new Complex(-1.5d, -6d));
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(new Complex(0.0, 4d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -6d), v.z);
                Assert.AreEqual(new Complex(0.0, 4d), v.w);
                Assert.AreEqual(new Complex(0.0, 4d), v.v);
            }
            {
                var ov = new cvec2(new Complex(2.5d, -9d), new Complex(-3d, 9d));
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(new Complex(2.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-3d, 9d), v.y);
                Assert.AreEqual(new Complex(-3d, 9d), v.z);
                Assert.AreEqual(new Complex(2.5d, -9d), v.w);
                Assert.AreEqual(new Complex(-3d, 9d), v.v);
            }
            {
                var ov = new cvec2(new Complex(9.5d, -3d), new Complex(-1.5d, -9d));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new Complex(9.5d, -3d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -9d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -9d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -9d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-5.5d, 4d), new Complex(-8d, 6.5d));
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(new Complex(-5.5d, 4d), v.x);
                Assert.AreEqual(new Complex(-8d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-8d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 4d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-2d, 1.5d), new Complex(4d, 6d));
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(new Complex(-2d, 1.5d), v.x);
                Assert.AreEqual(new Complex(4d, 6d), v.y);
                Assert.AreEqual(new Complex(4d, 6d), v.z);
                Assert.AreEqual(new Complex(4d, 6d), v.w);
                Assert.AreEqual(new Complex(4d, 6d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-1d, 9d), new Complex(-3d, -4.5d));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new Complex(-3d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 9d), v.y);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, -4.5d), new Complex(3.5d, -7d));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new Complex(3.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -4.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(8.5d, 1.0), new Complex(8.5d, 1.5d));
                var v = ov.swizzle.grrr;
                Assert.AreEqual(new Complex(8.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.w);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, -8d), new Complex(-9d, -7.5d));
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(new Complex(-9d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.w);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-6.5d, -4.5d), new Complex(0.0, -6.5d));
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(new Complex(0.0, -6.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -4.5d), v.w);
                Assert.AreEqual(new Complex(0.0, -6.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-8d, 6d), new Complex(-6.5d, 2d));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new Complex(-6.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-8d, 6d), v.y);
                Assert.AreEqual(new Complex(-8d, 6d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 2d), v.w);
            }
            {
                var ov = new cvec2(new Complex(7d, -1d), new Complex(2.5d, 7.5d));
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(new Complex(2.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(7d, -1d), v.y);
                Assert.AreEqual(new Complex(7d, -1d), v.z);
                Assert.AreEqual(new Complex(2.5d, 7.5d), v.w);
                Assert.AreEqual(new Complex(7d, -1d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-0.5d, 5d), new Complex(5.5d, -9d));
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(new Complex(5.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -9d), v.w);
                Assert.AreEqual(new Complex(5.5d, -9d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, 5d), new Complex(-7.5d, 5.5d));
                var v = ov.swizzle.grg;
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-7.5d, -7d), new Complex(8d, 1.5d));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new Complex(8d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -7d), v.y);
                Assert.AreEqual(new Complex(8d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -7d), v.w);
            }
            {
                var ov = new cvec2(new Complex(4.5d, -2.5d), new Complex(7d, -9d));
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(new Complex(7d, -9d), v.x);
                Assert.AreEqual(new Complex(4.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(7d, -9d), v.z);
                Assert.AreEqual(new Complex(4.5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, -2.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(9.5d, 7d), new Complex(-8.5d, -2d));
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(new Complex(-8.5d, -2d), v.x);
                Assert.AreEqual(new Complex(9.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -2d), v.z);
                Assert.AreEqual(new Complex(9.5d, 7d), v.w);
                Assert.AreEqual(new Complex(-8.5d, -2d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-9.5d, 8.5d), new Complex(-2.5d, -8.5d));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-2d, 1.5d), new Complex(1.0, 0.5d));
                var v = ov.swizzle.grggr;
                Assert.AreEqual(new Complex(1.0, 0.5d), v.x);
                Assert.AreEqual(new Complex(-2d, 1.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 0.5d), v.z);
                Assert.AreEqual(new Complex(1.0, 0.5d), v.w);
                Assert.AreEqual(new Complex(-2d, 1.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(6d, 9d), new Complex(-1d, -8d));
                var v = ov.swizzle.grggg;
                Assert.AreEqual(new Complex(-1d, -8d), v.x);
                Assert.AreEqual(new Complex(6d, 9d), v.y);
                Assert.AreEqual(new Complex(-1d, -8d), v.z);
                Assert.AreEqual(new Complex(-1d, -8d), v.w);
                Assert.AreEqual(new Complex(-1d, -8d), v.v);
            }
            {
                var ov = new cvec2(new Complex(8d, -7.5d), new Complex(5d, 5.5d));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new Complex(5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(5d, 5.5d), v.y);
            }
            {
                var ov = new cvec2(new Complex(9d, 3.5d), new Complex(2.5d, 4d));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new Complex(2.5d, 4d), v.x);
                Assert.AreEqual(new Complex(2.5d, 4d), v.y);
                Assert.AreEqual(new Complex(9d, 3.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-6.5d, -9.5d), new Complex(-5d, 3d));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new Complex(-5d, 3d), v.x);
                Assert.AreEqual(new Complex(-5d, 3d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(4d, 3d), new Complex(8.5d, -6d));
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(new Complex(8.5d, -6d), v.x);
                Assert.AreEqual(new Complex(8.5d, -6d), v.y);
                Assert.AreEqual(new Complex(4d, 3d), v.z);
                Assert.AreEqual(new Complex(4d, 3d), v.w);
                Assert.AreEqual(new Complex(4d, 3d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-9.5d, -0.5d), new Complex(-6d, 2d));
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(new Complex(-6d, 2d), v.x);
                Assert.AreEqual(new Complex(-6d, 2d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.w);
                Assert.AreEqual(new Complex(-6d, 2d), v.v);
            }
            {
                var ov = new cvec2(new Complex(5.5d, 3d), new Complex(-7d, 0.0));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new Complex(-7d, 0.0), v.x);
                Assert.AreEqual(new Complex(-7d, 0.0), v.y);
                Assert.AreEqual(new Complex(5.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-7d, 0.0), v.w);
            }
            {
                var ov = new cvec2(new Complex(1.5d, -0.5d), new Complex(-6.5d, -5.5d));
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(new Complex(-6.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -5.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, -0.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(9.5d, -2d), new Complex(-8d, 1.0));
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(new Complex(-8d, 1.0), v.x);
                Assert.AreEqual(new Complex(-8d, 1.0), v.y);
                Assert.AreEqual(new Complex(9.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-8d, 1.0), v.w);
                Assert.AreEqual(new Complex(-8d, 1.0), v.v);
            }
            {
                var ov = new cvec2(new Complex(-8.5d, 3d), new Complex(9.5d, -8.5d));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new Complex(9.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -8.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-5.5d, 4d), new Complex(3d, 1.5d));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new Complex(3d, 1.5d), v.x);
                Assert.AreEqual(new Complex(3d, 1.5d), v.y);
                Assert.AreEqual(new Complex(3d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 4d), v.w);
            }
            {
                var ov = new cvec2(new Complex(0.0, -2d), new Complex(1.0, 6d));
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(new Complex(1.0, 6d), v.x);
                Assert.AreEqual(new Complex(1.0, 6d), v.y);
                Assert.AreEqual(new Complex(1.0, 6d), v.z);
                Assert.AreEqual(new Complex(0.0, -2d), v.w);
                Assert.AreEqual(new Complex(0.0, -2d), v.v);
            }
            {
                var ov = new cvec2(new Complex(6.5d, -9.5d), new Complex(2d, 8.5d));
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(new Complex(2d, 8.5d), v.x);
                Assert.AreEqual(new Complex(2d, 8.5d), v.y);
                Assert.AreEqual(new Complex(2d, 8.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -9.5d), v.w);
                Assert.AreEqual(new Complex(2d, 8.5d), v.v);
            }
            {
                var ov = new cvec2(new Complex(9d, -9d), new Complex(2d, -1.5d));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new Complex(2d, -1.5d), v.x);
                Assert.AreEqual(new Complex(2d, -1.5d), v.y);
                Assert.AreEqual(new Complex(2d, -1.5d), v.z);
                Assert.AreEqual(new Complex(2d, -1.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-4d, -8d), new Complex(7d, -2d));
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(new Complex(7d, -2d), v.x);
                Assert.AreEqual(new Complex(7d, -2d), v.y);
                Assert.AreEqual(new Complex(7d, -2d), v.z);
                Assert.AreEqual(new Complex(7d, -2d), v.w);
                Assert.AreEqual(new Complex(-4d, -8d), v.v);
            }
            {
                var ov = new cvec2(new Complex(-3d, -6d), new Complex(-1d, -8d));
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(new Complex(-1d, -8d), v.x);
                Assert.AreEqual(new Complex(-1d, -8d), v.y);
                Assert.AreEqual(new Complex(-1d, -8d), v.z);
                Assert.AreEqual(new Complex(-1d, -8d), v.w);
                Assert.AreEqual(new Complex(-1d, -8d), v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new cvec2(new Complex(7.5d, -7d), new Complex(-5d, -6.5d));
                var v1 = new cvec2(new Complex(-7.5d, -1d), new Complex(3.5d, -5d));
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-7.5d, -1d), v0.x);
                Assert.AreEqual(new Complex(3.5d, -5d), v0.y);
            
                Assert.AreEqual(new Complex(7.5d, -7d), v2.x);
                Assert.AreEqual(new Complex(-5d, -6.5d), v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new cvec2(new Complex(3d, -9.5d), new Complex(-1d, 1.0));
                var v1 = new Complex(9d, 6d);
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(9d, 6d), v0.x);
                Assert.AreEqual(new Complex(-1d, 1.0), v0.y);
            
                Assert.AreEqual(new Complex(3d, -9.5d), v2);
            }
            {
                var v0 = new cvec2(new Complex(-4.5d, -4d), new Complex(5.5d, -9d));
                var v1 = new Complex(7d, 3.5d);
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-4.5d, -4d), v0.x);
                Assert.AreEqual(new Complex(7d, 3.5d), v0.y);
            
                Assert.AreEqual(new Complex(5.5d, -9d), v2);
            }
            {
                var v0 = new cvec2(new Complex(0.5d, 9.5d), new Complex(-7d, -6.5d));
                var v1 = new cvec2(new Complex(-6d, -4.5d), new Complex(-3d, 8.5d));
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-6d, -4.5d), v0.x);
                Assert.AreEqual(new Complex(-3d, 8.5d), v0.y);
            
                Assert.AreEqual(new Complex(0.5d, 9.5d), v2.x);
                Assert.AreEqual(new Complex(-7d, -6.5d), v2.y);
            }
        }

    }
}
