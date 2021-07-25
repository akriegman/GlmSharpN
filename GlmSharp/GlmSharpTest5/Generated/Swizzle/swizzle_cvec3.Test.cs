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
    public class ComplexSwizzleVec3Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new cvec3(new Complex(-4d, 5d), new Complex(2.5d, 6d), new Complex(7d, 1.5d));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new Complex(-4d, 5d), v.x);
                Assert.AreEqual(new Complex(-4d, 5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(8d, -3.5d), new Complex(-6.5d, -1.5d), new Complex(-0.5d, -2d));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new Complex(8d, -3.5d), v.x);
                Assert.AreEqual(new Complex(8d, -3.5d), v.y);
                Assert.AreEqual(new Complex(8d, -3.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 1.0), new Complex(7d, -0.5d), new Complex(-6.5d, 7.5d));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6d, 7d), new Complex(9d, 1.0), new Complex(-2.5d, 8d));
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(new Complex(-6d, 7d), v.x);
                Assert.AreEqual(new Complex(-6d, 7d), v.y);
                Assert.AreEqual(new Complex(-6d, 7d), v.z);
                Assert.AreEqual(new Complex(-6d, 7d), v.w);
                Assert.AreEqual(new Complex(-6d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 5d), new Complex(0.5d, -6d), new Complex(9.5d, -3.5d));
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(new Complex(3d, 5d), v.x);
                Assert.AreEqual(new Complex(3d, 5d), v.y);
                Assert.AreEqual(new Complex(3d, 5d), v.z);
                Assert.AreEqual(new Complex(3d, 5d), v.w);
                Assert.AreEqual(new Complex(0.5d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 3.5d), new Complex(9.5d, 0.0), new Complex(1.5d, -0.5d));
                var v = ov.swizzle.xxxxz;
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 5d), new Complex(9.5d, -1d), new Complex(9d, 1.0));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new Complex(7.5d, 5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 5d), v.y);
                Assert.AreEqual(new Complex(7.5d, 5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -1d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 6d), new Complex(7.5d, -8.5d), new Complex(0.5d, 1.0));
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(new Complex(1.5d, 6d), v.x);
                Assert.AreEqual(new Complex(1.5d, 6d), v.y);
                Assert.AreEqual(new Complex(1.5d, 6d), v.z);
                Assert.AreEqual(new Complex(7.5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -2d), new Complex(3.5d, -3.5d), new Complex(-4.5d, -3.5d));
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(new Complex(-7.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -2d), v.z);
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.w);
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -7.5d), new Complex(-8d, 0.0), new Complex(-6d, -6d));
                var v = ov.swizzle.xxxyz;
                Assert.AreEqual(new Complex(-2d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 0.0), v.w);
                Assert.AreEqual(new Complex(-6d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 9d), new Complex(-1.5d, -2d), new Complex(-8d, 9.5d));
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(new Complex(-8.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 9d), v.z);
                Assert.AreEqual(new Complex(-8d, 9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(4d, -3.5d), new Complex(6d, -1d), new Complex(6.5d, -6d));
                var v = ov.swizzle.xxxzx;
                Assert.AreEqual(new Complex(4d, -3.5d), v.x);
                Assert.AreEqual(new Complex(4d, -3.5d), v.y);
                Assert.AreEqual(new Complex(4d, -3.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -6d), v.w);
                Assert.AreEqual(new Complex(4d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, -1d), new Complex(3d, 9d), new Complex(1.0, 3d));
                var v = ov.swizzle.xxxzy;
                Assert.AreEqual(new Complex(7.5d, -1d), v.x);
                Assert.AreEqual(new Complex(7.5d, -1d), v.y);
                Assert.AreEqual(new Complex(7.5d, -1d), v.z);
                Assert.AreEqual(new Complex(1.0, 3d), v.w);
                Assert.AreEqual(new Complex(3d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.0, -8.5d), new Complex(9d, -3d), new Complex(-3d, -9.5d));
                var v = ov.swizzle.xxxzz;
                Assert.AreEqual(new Complex(0.0, -8.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -8.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -8.5d), v.z);
                Assert.AreEqual(new Complex(-3d, -9.5d), v.w);
                Assert.AreEqual(new Complex(-3d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 2.5d), new Complex(4.5d, -9.5d), new Complex(-9d, -3d));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new Complex(-7.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 6.5d), new Complex(-9d, -7d), new Complex(-6d, -8d));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-9d, -7d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 2d), new Complex(-7.5d, -2.5d), new Complex(9d, 9.5d));
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(new Complex(-8.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 2d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, -7d), new Complex(-7.5d, 1.0), new Complex(1.0, 5d));
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(new Complex(-7d, -7d), v.x);
                Assert.AreEqual(new Complex(-7d, -7d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(-7d, -7d), v.w);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, 9.5d), new Complex(-7.5d, 9.5d), new Complex(4.5d, -3.5d));
                var v = ov.swizzle.xxyxz;
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, -0.5d), new Complex(-2.5d, -4d), new Complex(0.5d, 1.0));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new Complex(-8d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -4d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(3d, -5.5d), new Complex(9d, -8d), new Complex(0.5d, -1.5d));
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(new Complex(3d, -5.5d), v.x);
                Assert.AreEqual(new Complex(3d, -5.5d), v.y);
                Assert.AreEqual(new Complex(9d, -8d), v.z);
                Assert.AreEqual(new Complex(9d, -8d), v.w);
                Assert.AreEqual(new Complex(3d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, -9d), new Complex(4.5d, 7.5d), new Complex(-8.5d, -0.5d));
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(new Complex(7d, -9d), v.x);
                Assert.AreEqual(new Complex(7d, -9d), v.y);
                Assert.AreEqual(new Complex(4.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 7.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, 7d), new Complex(8.5d, -9d), new Complex(-5.5d, 2d));
                var v = ov.swizzle.xxyyz;
                Assert.AreEqual(new Complex(8d, 7d), v.x);
                Assert.AreEqual(new Complex(8d, 7d), v.y);
                Assert.AreEqual(new Complex(8.5d, -9d), v.z);
                Assert.AreEqual(new Complex(8.5d, -9d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 8d), new Complex(-5.5d, -7.5d), new Complex(5.5d, -1.5d));
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(new Complex(3d, 8d), v.x);
                Assert.AreEqual(new Complex(3d, 8d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -6.5d), new Complex(6.5d, -7.5d), new Complex(-0.5d, 5.5d));
                var v = ov.swizzle.xxyzx;
                Assert.AreEqual(new Complex(0.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -8.5d), new Complex(8d, -3d), new Complex(2d, 8.5d));
                var v = ov.swizzle.xxyzy;
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(8d, -3d), v.z);
                Assert.AreEqual(new Complex(2d, 8.5d), v.w);
                Assert.AreEqual(new Complex(8d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, -2.5d), new Complex(7.5d, -6d), new Complex(-5d, 7d));
                var v = ov.swizzle.xxyzz;
                Assert.AreEqual(new Complex(-1d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-1d, -2.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, -6d), v.z);
                Assert.AreEqual(new Complex(-5d, 7d), v.w);
                Assert.AreEqual(new Complex(-5d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, 5d), new Complex(1.5d, -9.5d), new Complex(5.5d, -4d));
                var v = ov.swizzle.xxz;
                Assert.AreEqual(new Complex(9d, 5d), v.x);
                Assert.AreEqual(new Complex(9d, 5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -4d), v.z);
            }
            {
                var ov = new cvec3(new Complex(5d, -4d), new Complex(3d, 1.5d), new Complex(6d, 7d));
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(new Complex(5d, -4d), v.x);
                Assert.AreEqual(new Complex(5d, -4d), v.y);
                Assert.AreEqual(new Complex(6d, 7d), v.z);
                Assert.AreEqual(new Complex(5d, -4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7d, 1.5d), new Complex(-5.5d, -2.5d), new Complex(-5.5d, -1d));
                var v = ov.swizzle.xxzxx;
                Assert.AreEqual(new Complex(-7d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-7d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-7d, 1.5d), v.w);
                Assert.AreEqual(new Complex(-7d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, -1.5d), new Complex(-9d, -9.5d), new Complex(-6d, 6.5d));
                var v = ov.swizzle.xxzxy;
                Assert.AreEqual(new Complex(1.0, -1.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -1.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 6.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -1.5d), v.w);
                Assert.AreEqual(new Complex(-9d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, 2d), new Complex(6.5d, 6.5d), new Complex(9.5d, 5.5d));
                var v = ov.swizzle.xxzxz;
                Assert.AreEqual(new Complex(-2d, 2d), v.x);
                Assert.AreEqual(new Complex(-2d, 2d), v.y);
                Assert.AreEqual(new Complex(9.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-2d, 2d), v.w);
                Assert.AreEqual(new Complex(9.5d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 2.5d), new Complex(-5d, -1d), new Complex(9.5d, -6.5d));
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(new Complex(-7.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-5d, -1d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, -6.5d), new Complex(-6d, -2.5d), new Complex(-9.5d, 7.5d));
                var v = ov.swizzle.xxzyx;
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -2.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -6d), new Complex(-7d, 1.5d), new Complex(8.5d, 5d));
                var v = ov.swizzle.xxzyy;
                Assert.AreEqual(new Complex(2.5d, -6d), v.x);
                Assert.AreEqual(new Complex(2.5d, -6d), v.y);
                Assert.AreEqual(new Complex(8.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-7d, 1.5d), v.w);
                Assert.AreEqual(new Complex(-7d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -2d), new Complex(-3.5d, 3.5d), new Complex(-4.5d, -9d));
                var v = ov.swizzle.xxzyz;
                Assert.AreEqual(new Complex(-5d, -2d), v.x);
                Assert.AreEqual(new Complex(-5d, -2d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -9d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -1d), new Complex(-5.5d, -8d), new Complex(-4d, -4.5d));
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(new Complex(-2d, -1d), v.x);
                Assert.AreEqual(new Complex(-2d, -1d), v.y);
                Assert.AreEqual(new Complex(-4d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -4.5d), new Complex(7d, 0.0), new Complex(-0.5d, 8.5d));
                var v = ov.swizzle.xxzzx;
                Assert.AreEqual(new Complex(1.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, 2.5d), new Complex(4.5d, -9d), new Complex(-8d, 8.5d));
                var v = ov.swizzle.xxzzy;
                Assert.AreEqual(new Complex(-5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-8d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 8.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, -5d), new Complex(2d, 3d), new Complex(1.5d, 3d));
                var v = ov.swizzle.xxzzz;
                Assert.AreEqual(new Complex(5.5d, -5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 3d), v.z);
                Assert.AreEqual(new Complex(1.5d, 3d), v.w);
                Assert.AreEqual(new Complex(1.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -9.5d), new Complex(1.5d, -6d), new Complex(-4d, 0.5d));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new Complex(-5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -6d), v.y);
            }
            {
                var ov = new cvec3(new Complex(9.5d, 1.5d), new Complex(1.0, -9d), new Complex(5d, 0.0));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new Complex(9.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -9d), v.y);
                Assert.AreEqual(new Complex(9.5d, 1.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-9d, 0.5d), new Complex(-9d, -9d), new Complex(9.5d, -4.5d));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new Complex(-9d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-9d, -9d), v.y);
                Assert.AreEqual(new Complex(-9d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-9d, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 0.0), new Complex(-4d, -2.5d), new Complex(4.5d, 1.0));
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(new Complex(0.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-4d, -2.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, -6d), new Complex(-4d, 3d), new Complex(-8.5d, -2.5d));
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(new Complex(3d, -6d), v.x);
                Assert.AreEqual(new Complex(-4d, 3d), v.y);
                Assert.AreEqual(new Complex(3d, -6d), v.z);
                Assert.AreEqual(new Complex(3d, -6d), v.w);
                Assert.AreEqual(new Complex(-4d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, -1d), new Complex(-7d, -0.5d), new Complex(-4d, -3.5d));
                var v = ov.swizzle.xyxxz;
                Assert.AreEqual(new Complex(4.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-7d, -0.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -1d), v.z);
                Assert.AreEqual(new Complex(4.5d, -1d), v.w);
                Assert.AreEqual(new Complex(-4d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 7d), new Complex(1.5d, 2d), new Complex(-7d, 8.5d));
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new Complex(7.5d, 7d), v.x);
                Assert.AreEqual(new Complex(1.5d, 2d), v.y);
                Assert.AreEqual(new Complex(7.5d, 7d), v.z);
                Assert.AreEqual(new Complex(1.5d, 2d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -1.5d), new Complex(5d, -9d), new Complex(0.0, 6d));
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(5d, -9d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(5d, -9d), v.w);
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, -5.5d), new Complex(-1d, 2d), new Complex(-2d, -7d));
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(new Complex(9d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 2d), v.y);
                Assert.AreEqual(new Complex(9d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-1d, 2d), v.w);
                Assert.AreEqual(new Complex(-1d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 7.5d), new Complex(6.5d, 9d), new Complex(2d, -6d));
                var v = ov.swizzle.xyxyz;
                Assert.AreEqual(new Complex(-3.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 9d), v.w);
                Assert.AreEqual(new Complex(2d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 4.5d), new Complex(-2.5d, -8d), new Complex(-3d, 4d));
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(new Complex(-8.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-3d, 4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, -7d), new Complex(-6.5d, 1.0), new Complex(-4.5d, -1d));
                var v = ov.swizzle.xyxzx;
                Assert.AreEqual(new Complex(8d, -7d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(8d, -7d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -1d), v.w);
                Assert.AreEqual(new Complex(8d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 5d), new Complex(2.5d, -4.5d), new Complex(-6d, -1d));
                var v = ov.swizzle.xyxzy;
                Assert.AreEqual(new Complex(6d, 5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(6d, 5d), v.z);
                Assert.AreEqual(new Complex(-6d, -1d), v.w);
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 2d), new Complex(5.5d, -8.5d), new Complex(7d, -3d));
                var v = ov.swizzle.xyxzz;
                Assert.AreEqual(new Complex(3.5d, 2d), v.x);
                Assert.AreEqual(new Complex(5.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 2d), v.z);
                Assert.AreEqual(new Complex(7d, -3d), v.w);
                Assert.AreEqual(new Complex(7d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 4.5d), new Complex(-7.5d, -1d), new Complex(9d, -0.5d));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new Complex(-4.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -1d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -6.5d), new Complex(-1.5d, 7d), new Complex(3.5d, 6.5d));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new Complex(-9.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, 8d), new Complex(-8.5d, -7.5d), new Complex(-7d, -2.5d));
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(new Complex(8d, 8d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(8d, 8d), v.w);
                Assert.AreEqual(new Complex(8d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, -1d), new Complex(8.5d, 6d), new Complex(-2d, 0.0));
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(new Complex(4d, -1d), v.x);
                Assert.AreEqual(new Complex(8.5d, 6d), v.y);
                Assert.AreEqual(new Complex(8.5d, 6d), v.z);
                Assert.AreEqual(new Complex(4d, -1d), v.w);
                Assert.AreEqual(new Complex(8.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, 3d), new Complex(3.5d, 1.5d), new Complex(-4.5d, 4.5d));
                var v = ov.swizzle.xyyxz;
                Assert.AreEqual(new Complex(-4d, 3d), v.x);
                Assert.AreEqual(new Complex(3.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-4d, 3d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, -8.5d), new Complex(0.5d, 5d), new Complex(1.5d, -6d));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new Complex(-4d, -8.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -6.5d), new Complex(2.5d, 2.5d), new Complex(-6.5d, 8d));
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(new Complex(3.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(3.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 7d), new Complex(8d, 3d), new Complex(-2.5d, 9d));
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(new Complex(7.5d, 7d), v.x);
                Assert.AreEqual(new Complex(8d, 3d), v.y);
                Assert.AreEqual(new Complex(8d, 3d), v.z);
                Assert.AreEqual(new Complex(8d, 3d), v.w);
                Assert.AreEqual(new Complex(8d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 4.5d), new Complex(4.5d, 8.5d), new Complex(1.5d, 2d));
                var v = ov.swizzle.xyyyz;
                Assert.AreEqual(new Complex(-8.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -6d), new Complex(-1.5d, 3d), new Complex(-4.5d, 4d));
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(new Complex(6.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -5d), new Complex(4d, 2d), new Complex(5.5d, -8.5d));
                var v = ov.swizzle.xyyzx;
                Assert.AreEqual(new Complex(8.5d, -5d), v.x);
                Assert.AreEqual(new Complex(4d, 2d), v.y);
                Assert.AreEqual(new Complex(4d, 2d), v.z);
                Assert.AreEqual(new Complex(5.5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, -5.5d), new Complex(5.5d, 4.5d), new Complex(-5.5d, 8d));
                var v = ov.swizzle.xyyzy;
                Assert.AreEqual(new Complex(9d, -5.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.w);
                Assert.AreEqual(new Complex(5.5d, 4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -7d), new Complex(0.5d, 0.0), new Complex(-7.5d, 5.5d));
                var v = ov.swizzle.xyyzz;
                Assert.AreEqual(new Complex(0.5d, -7d), v.x);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, -9.5d), new Complex(-8d, -2.5d), new Complex(-5d, -3.5d));
                var v = ov.swizzle.xyz;
                Assert.AreEqual(new Complex(-8d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-5d, -3.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -1.5d), new Complex(-7d, -7.5d), new Complex(-0.5d, -1d));
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.0, 2d), new Complex(5.5d, -3d), new Complex(-0.5d, 9d));
                var v = ov.swizzle.xyzxx;
                Assert.AreEqual(new Complex(1.0, 2d), v.x);
                Assert.AreEqual(new Complex(5.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 9d), v.z);
                Assert.AreEqual(new Complex(1.0, 2d), v.w);
                Assert.AreEqual(new Complex(1.0, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -6d), new Complex(2.5d, -5.5d), new Complex(2d, -7d));
                var v = ov.swizzle.xyzxy;
                Assert.AreEqual(new Complex(9.5d, -6d), v.x);
                Assert.AreEqual(new Complex(2.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(2d, -7d), v.z);
                Assert.AreEqual(new Complex(9.5d, -6d), v.w);
                Assert.AreEqual(new Complex(2.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 4.5d), new Complex(9.5d, -9.5d), new Complex(2d, -2.5d));
                var v = ov.swizzle.xyzxz;
                Assert.AreEqual(new Complex(-5.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(2d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(2d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 3d), new Complex(-1.5d, -3.5d), new Complex(-4d, 4d));
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(new Complex(-4.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 4d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, -9.5d), new Complex(8.5d, -0.5d), new Complex(3.5d, 8d));
                var v = ov.swizzle.xyzyx;
                Assert.AreEqual(new Complex(-6.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 8d), v.z);
                Assert.AreEqual(new Complex(8.5d, -0.5d), v.w);
                Assert.AreEqual(new Complex(-6.5d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, 1.5d), new Complex(-2d, 3.5d), new Complex(3.5d, -9d));
                var v = ov.swizzle.xyzyy;
                Assert.AreEqual(new Complex(2d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-2d, 3.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -9d), v.z);
                Assert.AreEqual(new Complex(-2d, 3.5d), v.w);
                Assert.AreEqual(new Complex(-2d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -7.5d), new Complex(5d, 5.5d), new Complex(4.5d, 1.0));
                var v = ov.swizzle.xyzyz;
                Assert.AreEqual(new Complex(2.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, -9d), new Complex(3d, -8d), new Complex(7.5d, 6.5d));
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(new Complex(-6d, -9d), v.x);
                Assert.AreEqual(new Complex(3d, -8d), v.y);
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.0, -5.5d), new Complex(-5.5d, 3d), new Complex(0.0, 3d));
                var v = ov.swizzle.xyzzx;
                Assert.AreEqual(new Complex(1.0, -5.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 3d), v.y);
                Assert.AreEqual(new Complex(0.0, 3d), v.z);
                Assert.AreEqual(new Complex(0.0, 3d), v.w);
                Assert.AreEqual(new Complex(1.0, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, -9d), new Complex(-6d, 1.0), new Complex(-5d, 3d));
                var v = ov.swizzle.xyzzy;
                Assert.AreEqual(new Complex(8d, -9d), v.x);
                Assert.AreEqual(new Complex(-6d, 1.0), v.y);
                Assert.AreEqual(new Complex(-5d, 3d), v.z);
                Assert.AreEqual(new Complex(-5d, 3d), v.w);
                Assert.AreEqual(new Complex(-6d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, -8.5d), new Complex(-2d, -7d), new Complex(1.5d, -8.5d));
                var v = ov.swizzle.xyzzz;
                Assert.AreEqual(new Complex(7d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -7d), v.y);
                Assert.AreEqual(new Complex(1.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 8.5d), new Complex(-9.5d, 0.5d), new Complex(9.5d, -4.5d));
                var v = ov.swizzle.xz;
                Assert.AreEqual(new Complex(7.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -4.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(1.0, 0.5d), new Complex(6.5d, 9.5d), new Complex(5.5d, -9.5d));
                var v = ov.swizzle.xzx;
                Assert.AreEqual(new Complex(1.0, 0.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 0.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -4.5d), new Complex(-4d, -9d), new Complex(4d, -6.5d));
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(new Complex(-7.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(4d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 2.5d), new Complex(-4.5d, -9.5d), new Complex(7d, 6d));
                var v = ov.swizzle.xzxxx;
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(7d, 6d), v.y);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, 1.0), new Complex(6d, 5.5d), new Complex(1.5d, -2d));
                var v = ov.swizzle.xzxxy;
                Assert.AreEqual(new Complex(-1d, 1.0), v.x);
                Assert.AreEqual(new Complex(1.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-1d, 1.0), v.z);
                Assert.AreEqual(new Complex(-1d, 1.0), v.w);
                Assert.AreEqual(new Complex(6d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -3.5d), new Complex(-5d, -2.5d), new Complex(5d, 1.5d));
                var v = ov.swizzle.xzxxz;
                Assert.AreEqual(new Complex(-0.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -3.5d), v.w);
                Assert.AreEqual(new Complex(5d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 7d), new Complex(3.5d, 5d), new Complex(-1d, -4.5d));
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(new Complex(-7.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-1d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 7d), v.z);
                Assert.AreEqual(new Complex(3.5d, 5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5.5d, 8d), new Complex(-4.5d, -6.5d), new Complex(1.5d, 3.5d));
                var v = ov.swizzle.xzxyx;
                Assert.AreEqual(new Complex(5.5d, 8d), v.x);
                Assert.AreEqual(new Complex(1.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(5.5d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -4d), new Complex(7.5d, 0.5d), new Complex(8d, -8d));
                var v = ov.swizzle.xzxyy;
                Assert.AreEqual(new Complex(1.5d, -4d), v.x);
                Assert.AreEqual(new Complex(8d, -8d), v.y);
                Assert.AreEqual(new Complex(1.5d, -4d), v.z);
                Assert.AreEqual(new Complex(7.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, -2d), new Complex(-6d, -4d), new Complex(-5.5d, -7d));
                var v = ov.swizzle.xzxyz;
                Assert.AreEqual(new Complex(2d, -2d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -7d), v.y);
                Assert.AreEqual(new Complex(2d, -2d), v.z);
                Assert.AreEqual(new Complex(-6d, -4d), v.w);
                Assert.AreEqual(new Complex(-5.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -6.5d), new Complex(-7d, -8.5d), new Complex(-7d, 6d));
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-7d, 6d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -6.5d), new Complex(-4.5d, -8.5d), new Complex(-8d, 6.5d));
                var v = ov.swizzle.xzxzx;
                Assert.AreEqual(new Complex(-7.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-8d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-7.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -6.5d), new Complex(0.0, 8.5d), new Complex(-5d, 3.5d));
                var v = ov.swizzle.xzxzy;
                Assert.AreEqual(new Complex(3.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 9.5d), new Complex(9d, 5.5d), new Complex(2.5d, -7d));
                var v = ov.swizzle.xzxzz;
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -7d), v.y);
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -7d), v.w);
                Assert.AreEqual(new Complex(2.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -7d), new Complex(-6.5d, -3.5d), new Complex(-8d, 7.5d));
                var v = ov.swizzle.xzy;
                Assert.AreEqual(new Complex(-0.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-8d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -1.5d), new Complex(1.5d, -7.5d), new Complex(-7d, 6d));
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(new Complex(0.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-7d, 6d), v.y);
                Assert.AreEqual(new Complex(1.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, 2.5d), new Complex(-9d, 3.5d), new Complex(0.0, -2d));
                var v = ov.swizzle.xzyxx;
                Assert.AreEqual(new Complex(8d, 2.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -2d), v.y);
                Assert.AreEqual(new Complex(-9d, 3.5d), v.z);
                Assert.AreEqual(new Complex(8d, 2.5d), v.w);
                Assert.AreEqual(new Complex(8d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, 9d), new Complex(-3.5d, -3d), new Complex(-9d, -2d));
                var v = ov.swizzle.xzyxy;
                Assert.AreEqual(new Complex(8d, 9d), v.x);
                Assert.AreEqual(new Complex(-9d, -2d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -3d), v.z);
                Assert.AreEqual(new Complex(8d, 9d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, 4.5d), new Complex(2d, -1.5d), new Complex(5.5d, 6d));
                var v = ov.swizzle.xzyxz;
                Assert.AreEqual(new Complex(-9.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 6d), v.y);
                Assert.AreEqual(new Complex(2d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(5.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, 0.5d), new Complex(-1d, -7d), new Complex(9.5d, 8d));
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(new Complex(7d, 0.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-1d, -7d), v.z);
                Assert.AreEqual(new Complex(-1d, -7d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 9.5d), new Complex(-9.5d, -2d), new Complex(8.5d, 4d));
                var v = ov.swizzle.xzyyx;
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 4d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -2d), v.w);
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 6d), new Complex(4d, 6d), new Complex(7d, 7.5d));
                var v = ov.swizzle.xzyyy;
                Assert.AreEqual(new Complex(-8.5d, 6d), v.x);
                Assert.AreEqual(new Complex(7d, 7.5d), v.y);
                Assert.AreEqual(new Complex(4d, 6d), v.z);
                Assert.AreEqual(new Complex(4d, 6d), v.w);
                Assert.AreEqual(new Complex(4d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 9.5d), new Complex(-1.5d, -8d), new Complex(-7.5d, -4d));
                var v = ov.swizzle.xzyyz;
                Assert.AreEqual(new Complex(0.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.w);
                Assert.AreEqual(new Complex(-7.5d, -4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, -3d), new Complex(6.5d, 2d), new Complex(-4d, -3.5d));
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(new Complex(-3d, -3d), v.x);
                Assert.AreEqual(new Complex(-4d, -3.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-4d, -3.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 8.5d), new Complex(-5.5d, 8d), new Complex(-6.5d, 8d));
                var v = ov.swizzle.xzyzx;
                Assert.AreEqual(new Complex(0.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 8d), v.w);
                Assert.AreEqual(new Complex(0.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9d, 8d), new Complex(5d, 0.5d), new Complex(1.0, 4.5d));
                var v = ov.swizzle.xzyzy;
                Assert.AreEqual(new Complex(-9d, 8d), v.x);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.y);
                Assert.AreEqual(new Complex(5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.w);
                Assert.AreEqual(new Complex(5d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, 3.5d), new Complex(0.0, -5.5d), new Complex(6d, 5d));
                var v = ov.swizzle.xzyzz;
                Assert.AreEqual(new Complex(-3d, 3.5d), v.x);
                Assert.AreEqual(new Complex(6d, 5d), v.y);
                Assert.AreEqual(new Complex(0.0, -5.5d), v.z);
                Assert.AreEqual(new Complex(6d, 5d), v.w);
                Assert.AreEqual(new Complex(6d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -1d), new Complex(3.5d, -9.5d), new Complex(6.5d, -8.5d));
                var v = ov.swizzle.xzz;
                Assert.AreEqual(new Complex(2.5d, -1d), v.x);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 2d), new Complex(-9.5d, -2d), new Complex(1.5d, 7d));
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(new Complex(-5.5d, 2d), v.x);
                Assert.AreEqual(new Complex(1.5d, 7d), v.y);
                Assert.AreEqual(new Complex(1.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 2d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 5.5d), new Complex(1.0, -2.5d), new Complex(-7.5d, 1.5d));
                var v = ov.swizzle.xzzxx;
                Assert.AreEqual(new Complex(7.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 0.5d), new Complex(-4.5d, 1.5d), new Complex(0.5d, -7.5d));
                var v = ov.swizzle.xzzxy;
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, -5.5d), new Complex(-1d, 7.5d), new Complex(0.5d, -5.5d));
                var v = ov.swizzle.xzzxz;
                Assert.AreEqual(new Complex(-6d, -5.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -5.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, -2d), new Complex(8d, 7d), new Complex(-9d, -8d));
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(new Complex(4.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-9d, -8d), v.y);
                Assert.AreEqual(new Complex(-9d, -8d), v.z);
                Assert.AreEqual(new Complex(8d, 7d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9d, 8.5d), new Complex(9.5d, -0.5d), new Complex(3d, 1.0));
                var v = ov.swizzle.xzzyx;
                Assert.AreEqual(new Complex(9d, 8.5d), v.x);
                Assert.AreEqual(new Complex(3d, 1.0), v.y);
                Assert.AreEqual(new Complex(3d, 1.0), v.z);
                Assert.AreEqual(new Complex(9.5d, -0.5d), v.w);
                Assert.AreEqual(new Complex(9d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, 2.5d), new Complex(6.5d, -9d), new Complex(-6.5d, 0.5d));
                var v = ov.swizzle.xzzyy;
                Assert.AreEqual(new Complex(4.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -9d), v.w);
                Assert.AreEqual(new Complex(6.5d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -3.5d), new Complex(-8d, -2d), new Complex(2d, 2d));
                var v = ov.swizzle.xzzyz;
                Assert.AreEqual(new Complex(-3.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(2d, 2d), v.y);
                Assert.AreEqual(new Complex(2d, 2d), v.z);
                Assert.AreEqual(new Complex(-8d, -2d), v.w);
                Assert.AreEqual(new Complex(2d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 2d), new Complex(1.0, -6.5d), new Complex(6.5d, 7.5d));
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(new Complex(6.5d, 2d), v.x);
                Assert.AreEqual(new Complex(6.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 9d), new Complex(4.5d, 6.5d), new Complex(9d, 1.5d));
                var v = ov.swizzle.xzzzx;
                Assert.AreEqual(new Complex(3.5d, 9d), v.x);
                Assert.AreEqual(new Complex(9d, 1.5d), v.y);
                Assert.AreEqual(new Complex(9d, 1.5d), v.z);
                Assert.AreEqual(new Complex(9d, 1.5d), v.w);
                Assert.AreEqual(new Complex(3.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 1.0), new Complex(4.5d, -0.5d), new Complex(-3.5d, 1.5d));
                var v = ov.swizzle.xzzzy;
                Assert.AreEqual(new Complex(3.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-3.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 1.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, -7.5d), new Complex(7.5d, 4d), new Complex(-5.5d, 5.5d));
                var v = ov.swizzle.xzzzz;
                Assert.AreEqual(new Complex(1.0, -7.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, -0.5d), new Complex(3.5d, 3d), new Complex(-3.5d, -0.5d));
                var v = ov.swizzle.yx;
                Assert.AreEqual(new Complex(3.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-7d, -0.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -6.5d), new Complex(-0.5d, -6.5d), new Complex(-1d, 9d));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new Complex(-0.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -6.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 3d), new Complex(-5d, -2d), new Complex(-3d, 9d));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(new Complex(-5d, -2d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 3d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -4.5d), new Complex(-5.5d, 7.5d), new Complex(7.5d, -7.5d));
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(new Complex(-5.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.w);
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, -7d), new Complex(2d, 2.5d), new Complex(0.0, 5.5d));
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(new Complex(2d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -7d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -7d), v.w);
                Assert.AreEqual(new Complex(2d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 1.0), new Complex(7.5d, -9d), new Complex(7.5d, 1.0));
                var v = ov.swizzle.yxxxz;
                Assert.AreEqual(new Complex(7.5d, -9d), v.x);
                Assert.AreEqual(new Complex(3d, 1.0), v.y);
                Assert.AreEqual(new Complex(3d, 1.0), v.z);
                Assert.AreEqual(new Complex(3d, 1.0), v.w);
                Assert.AreEqual(new Complex(7.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, -1.5d), new Complex(7.5d, -6d), new Complex(1.0, 7.5d));
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(new Complex(7.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-3d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-3d, -1.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, 2d), new Complex(1.0, 0.5d), new Complex(0.0, 1.0));
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(new Complex(1.0, 0.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 2d), v.z);
                Assert.AreEqual(new Complex(1.0, 0.5d), v.w);
                Assert.AreEqual(new Complex(-0.5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 3.5d), new Complex(0.5d, -9.5d), new Complex(0.5d, 4.5d));
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(new Complex(0.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -9.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -0.5d), new Complex(-6.5d, -6.5d), new Complex(-7d, 8d));
                var v = ov.swizzle.yxxyz;
                Assert.AreEqual(new Complex(-6.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-7d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 0.5d), new Complex(2.5d, -2.5d), new Complex(-2d, 3d));
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(new Complex(2.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(3d, 0.5d), v.y);
                Assert.AreEqual(new Complex(3d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-2d, 3d), v.w);
            }
            {
                var ov = new cvec3(new Complex(4.5d, -7.5d), new Complex(3.5d, 8d), new Complex(6d, -6.5d));
                var v = ov.swizzle.yxxzx;
                Assert.AreEqual(new Complex(3.5d, 8d), v.x);
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(6d, -6.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, -3d), new Complex(5.5d, 9d), new Complex(6d, 4.5d));
                var v = ov.swizzle.yxxzy;
                Assert.AreEqual(new Complex(5.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-7d, -3d), v.y);
                Assert.AreEqual(new Complex(-7d, -3d), v.z);
                Assert.AreEqual(new Complex(6d, 4.5d), v.w);
                Assert.AreEqual(new Complex(5.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, -8d), new Complex(2d, -9.5d), new Complex(2d, 8.5d));
                var v = ov.swizzle.yxxzz;
                Assert.AreEqual(new Complex(2d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -8d), v.y);
                Assert.AreEqual(new Complex(-3d, -8d), v.z);
                Assert.AreEqual(new Complex(2d, 8.5d), v.w);
                Assert.AreEqual(new Complex(2d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, 3.5d), new Complex(3d, -6d), new Complex(-7d, -3.5d));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new Complex(3d, -6d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(3d, -6d), v.z);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -5d), new Complex(9d, 0.5d), new Complex(2.5d, 1.0));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new Complex(9d, 0.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -5d), v.y);
                Assert.AreEqual(new Complex(9d, 0.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, 4.5d), new Complex(-0.5d, 7.5d), new Complex(7.5d, -1d));
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(8d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(8d, 4.5d), v.w);
                Assert.AreEqual(new Complex(8d, 4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, 0.5d), new Complex(-1.5d, 3.5d), new Complex(9.5d, -1.5d));
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(new Complex(-1.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 5.5d), new Complex(-1.5d, -3.5d), new Complex(1.5d, -1d));
                var v = ov.swizzle.yxyxz;
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -4.5d), new Complex(-4d, -2.5d), new Complex(9.5d, 2d));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new Complex(-4d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-4d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -5d), new Complex(3d, -3d), new Complex(1.5d, -1.5d));
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(new Complex(3d, -3d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -5d), v.y);
                Assert.AreEqual(new Complex(3d, -3d), v.z);
                Assert.AreEqual(new Complex(3d, -3d), v.w);
                Assert.AreEqual(new Complex(-9.5d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 1.0), new Complex(-1.5d, 2.5d), new Complex(2.5d, 9d));
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -7d), new Complex(-1.5d, 5.5d), new Complex(9d, -5.5d));
                var v = ov.swizzle.yxyyz;
                Assert.AreEqual(new Complex(-1.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -7d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(9d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, -2d), new Complex(-3.5d, -1.5d), new Complex(2d, 6d));
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(new Complex(-3.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(2d, 6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 4d), new Complex(0.0, 7d), new Complex(4.5d, 4.5d));
                var v = ov.swizzle.yxyzx;
                Assert.AreEqual(new Complex(0.0, 7d), v.x);
                Assert.AreEqual(new Complex(0.5d, 4d), v.y);
                Assert.AreEqual(new Complex(0.0, 7d), v.z);
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 9.5d), new Complex(9.5d, 9d), new Complex(8.5d, -5d));
                var v = ov.swizzle.yxyzy;
                Assert.AreEqual(new Complex(9.5d, 9d), v.x);
                Assert.AreEqual(new Complex(8.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 9d), v.z);
                Assert.AreEqual(new Complex(8.5d, -5d), v.w);
                Assert.AreEqual(new Complex(9.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, -6d), new Complex(-3.5d, -8d), new Complex(-9.5d, -2.5d));
                var v = ov.swizzle.yxyzz;
                Assert.AreEqual(new Complex(-3.5d, -8d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(-9.5d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 2.5d), new Complex(-1d, 3.5d), new Complex(3.5d, -4.5d));
                var v = ov.swizzle.yxz;
                Assert.AreEqual(new Complex(-1d, 3.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -4.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-9d, 7.5d), new Complex(-5d, 0.0), new Complex(3d, 1.5d));
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(new Complex(-5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-9d, 7.5d), v.y);
                Assert.AreEqual(new Complex(3d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-9d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2d, -5d), new Complex(-2d, -4.5d), new Complex(4d, -9.5d));
                var v = ov.swizzle.yxzxx;
                Assert.AreEqual(new Complex(-2d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -5d), v.y);
                Assert.AreEqual(new Complex(4d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-2d, -5d), v.w);
                Assert.AreEqual(new Complex(-2d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, -3d), new Complex(0.5d, -1.5d), new Complex(-8.5d, -9.5d));
                var v = ov.swizzle.yxzxy;
                Assert.AreEqual(new Complex(0.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-6d, -3d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -3d), v.w);
                Assert.AreEqual(new Complex(0.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, 1.5d), new Complex(3.5d, 3d), new Complex(9.5d, 7d));
                var v = ov.swizzle.yxzxz;
                Assert.AreEqual(new Complex(3.5d, 3d), v.x);
                Assert.AreEqual(new Complex(7d, 1.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 7d), v.z);
                Assert.AreEqual(new Complex(7d, 1.5d), v.w);
                Assert.AreEqual(new Complex(9.5d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, 9d), new Complex(3.5d, 2.5d), new Complex(-5d, -5.5d));
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(new Complex(3.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-2d, 9d), v.y);
                Assert.AreEqual(new Complex(-5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -6d), new Complex(-3d, 6.5d), new Complex(-8.5d, 5.5d));
                var v = ov.swizzle.yxzyx;
                Assert.AreEqual(new Complex(-3d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-3d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -6d), new Complex(-5d, -7.5d), new Complex(3d, 6d));
                var v = ov.swizzle.yxzyy;
                Assert.AreEqual(new Complex(-5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -6d), v.y);
                Assert.AreEqual(new Complex(3d, 6d), v.z);
                Assert.AreEqual(new Complex(-5d, -7.5d), v.w);
                Assert.AreEqual(new Complex(-5d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, 1.0), new Complex(9.5d, -4.5d), new Complex(-1.5d, -6.5d));
                var v = ov.swizzle.yxzyz;
                Assert.AreEqual(new Complex(9.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -4.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 2.5d), new Complex(-6.5d, 5.5d), new Complex(-0.5d, -7d));
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(new Complex(-6.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(4d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -7d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 6.5d), new Complex(3d, 6d), new Complex(-1.5d, 8d));
                var v = ov.swizzle.yxzzx;
                Assert.AreEqual(new Complex(3d, 6d), v.x);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.w);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9d, -4d), new Complex(-8.5d, -6.5d), new Complex(2.5d, -9.5d));
                var v = ov.swizzle.yxzzy;
                Assert.AreEqual(new Complex(-8.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-9d, -4d), v.y);
                Assert.AreEqual(new Complex(2.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -9.5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 2d), new Complex(-7d, 1.0), new Complex(-4d, -0.5d));
                var v = ov.swizzle.yxzzz;
                Assert.AreEqual(new Complex(-7d, 1.0), v.x);
                Assert.AreEqual(new Complex(8.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-4d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -0.5d), v.w);
                Assert.AreEqual(new Complex(-4d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -6d), new Complex(-4d, 9.5d), new Complex(-7d, 8d));
                var v = ov.swizzle.yy;
                Assert.AreEqual(new Complex(-4d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-4d, 9.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(5d, 1.0), new Complex(-8d, 7.5d), new Complex(6.5d, 0.0));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new Complex(-8d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-8d, 7.5d), v.y);
                Assert.AreEqual(new Complex(5d, 1.0), v.z);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -2.5d), new Complex(-7.5d, -1d), new Complex(7d, 4d));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new Complex(-7.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5.5d, -3.5d), new Complex(-2.5d, -1.5d), new Complex(5d, -6d));
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.w);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, -0.5d), new Complex(7.5d, 9.5d), new Complex(-3d, -9.5d));
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -0.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 1.5d), new Complex(-7d, -5d), new Complex(6.5d, -1d));
                var v = ov.swizzle.yyxxz;
                Assert.AreEqual(new Complex(-7d, -5d), v.x);
                Assert.AreEqual(new Complex(-7d, -5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 1.5d), v.w);
                Assert.AreEqual(new Complex(6.5d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -7d), new Complex(-5.5d, 6.5d), new Complex(-5d, -5d));
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6d, 8d), new Complex(6d, -9.5d), new Complex(-1.5d, -0.5d));
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(new Complex(6d, -9.5d), v.x);
                Assert.AreEqual(new Complex(6d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 8d), v.z);
                Assert.AreEqual(new Complex(6d, -9.5d), v.w);
                Assert.AreEqual(new Complex(-6d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 3d), new Complex(-6.5d, -6d), new Complex(-2.5d, -9d));
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(new Complex(-6.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-6d, 3d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -6d), v.w);
                Assert.AreEqual(new Complex(-6.5d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -1d), new Complex(-0.5d, -8d), new Complex(-2d, -8d));
                var v = ov.swizzle.yyxyz;
                Assert.AreEqual(new Complex(-0.5d, -8d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -8d), v.y);
                Assert.AreEqual(new Complex(3.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -8d), v.w);
                Assert.AreEqual(new Complex(-2d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, -4.5d), new Complex(-4d, 6d), new Complex(-7d, -0.5d));
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(new Complex(-4d, 6d), v.x);
                Assert.AreEqual(new Complex(-4d, 6d), v.y);
                Assert.AreEqual(new Complex(6d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-7d, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, 2.5d), new Complex(7.5d, 0.0), new Complex(8.5d, 6.5d));
                var v = ov.swizzle.yyxzx;
                Assert.AreEqual(new Complex(7.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(7.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(0.0, 2.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, -4.5d), new Complex(-7d, -3d), new Complex(6.5d, -4.5d));
                var v = ov.swizzle.yyxzy;
                Assert.AreEqual(new Complex(-7d, -3d), v.x);
                Assert.AreEqual(new Complex(-7d, -3d), v.y);
                Assert.AreEqual(new Complex(4d, -4.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -4.5d), v.w);
                Assert.AreEqual(new Complex(-7d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, 6d), new Complex(-4d, -3d), new Complex(-8d, -2d));
                var v = ov.swizzle.yyxzz;
                Assert.AreEqual(new Complex(-4d, -3d), v.x);
                Assert.AreEqual(new Complex(-4d, -3d), v.y);
                Assert.AreEqual(new Complex(7d, 6d), v.z);
                Assert.AreEqual(new Complex(-8d, -2d), v.w);
                Assert.AreEqual(new Complex(-8d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -7d), new Complex(9d, 5d), new Complex(6.5d, 7d));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new Complex(9d, 5d), v.x);
                Assert.AreEqual(new Complex(9d, 5d), v.y);
                Assert.AreEqual(new Complex(9d, 5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 9.5d), new Complex(9d, 4d), new Complex(5d, 7d));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new Complex(9d, 4d), v.x);
                Assert.AreEqual(new Complex(9d, 4d), v.y);
                Assert.AreEqual(new Complex(9d, 4d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5d, -2.5d), new Complex(-9.5d, -7.5d), new Complex(4d, 6d));
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(-5d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 8d), new Complex(7d, -5.5d), new Complex(2.5d, 4d));
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(new Complex(7d, -5.5d), v.x);
                Assert.AreEqual(new Complex(7d, -5.5d), v.y);
                Assert.AreEqual(new Complex(7d, -5.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 8d), v.w);
                Assert.AreEqual(new Complex(7d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -5d), new Complex(-3d, 5d), new Complex(7d, -8d));
                var v = ov.swizzle.yyyxz;
                Assert.AreEqual(new Complex(-3d, 5d), v.x);
                Assert.AreEqual(new Complex(-3d, 5d), v.y);
                Assert.AreEqual(new Complex(-3d, 5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -5d), v.w);
                Assert.AreEqual(new Complex(7d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -9.5d), new Complex(-0.5d, 7.5d), new Complex(5.5d, -8.5d));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, -9d), new Complex(-1.5d, -6d), new Complex(2.5d, 3.5d));
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(new Complex(-1.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -6d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -6d), v.w);
                Assert.AreEqual(new Complex(8d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, -2.5d), new Complex(-1.5d, 8.5d), new Complex(-4d, -9d));
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(new Complex(-1.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -3.5d), new Complex(-7.5d, 5.5d), new Complex(0.0, 7.5d));
                var v = ov.swizzle.yyyyz;
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, -6.5d), new Complex(4.5d, 4d), Complex.One);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(new Complex(4.5d, 4d), v.x);
                Assert.AreEqual(new Complex(4.5d, 4d), v.y);
                Assert.AreEqual(new Complex(4.5d, 4d), v.z);
                Assert.AreEqual(Complex.One, v.w);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -4.5d), new Complex(-6.5d, 8d), new Complex(-1d, -7.5d));
                var v = ov.swizzle.yyyzx;
                Assert.AreEqual(new Complex(-6.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-1d, -7.5d), v.w);
                Assert.AreEqual(new Complex(9.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 2d), new Complex(4.5d, 1.5d), new Complex(7.5d, -5d));
                var v = ov.swizzle.yyyzy;
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -5d), v.w);
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -8.5d), new Complex(2.5d, 4d), new Complex(-4d, 9d));
                var v = ov.swizzle.yyyzz;
                Assert.AreEqual(new Complex(2.5d, 4d), v.x);
                Assert.AreEqual(new Complex(2.5d, 4d), v.y);
                Assert.AreEqual(new Complex(2.5d, 4d), v.z);
                Assert.AreEqual(new Complex(-4d, 9d), v.w);
                Assert.AreEqual(new Complex(-4d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 9d), new Complex(-8d, -7.5d), new Complex(8d, 3.5d));
                var v = ov.swizzle.yyz;
                Assert.AreEqual(new Complex(-8d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -7.5d), v.y);
                Assert.AreEqual(new Complex(8d, 3.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(7d, 9d), new Complex(-1d, -7d), new Complex(5d, -8.5d));
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(new Complex(-1d, -7d), v.x);
                Assert.AreEqual(new Complex(-1d, -7d), v.y);
                Assert.AreEqual(new Complex(5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(7d, 9d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -5.5d), new Complex(1.0, -7d), new Complex(-5.5d, 2.5d));
                var v = ov.swizzle.yyzxx;
                Assert.AreEqual(new Complex(1.0, -7d), v.x);
                Assert.AreEqual(new Complex(1.0, -7d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -5.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -7d), new Complex(-7d, 5d), new Complex(-2.5d, -5d));
                var v = ov.swizzle.yyzxy;
                Assert.AreEqual(new Complex(-7d, 5d), v.x);
                Assert.AreEqual(new Complex(-7d, 5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -5d), v.z);
                Assert.AreEqual(new Complex(1.5d, -7d), v.w);
                Assert.AreEqual(new Complex(-7d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, 2d), new Complex(8.5d, -2.5d), new Complex(-4.5d, 7.5d));
                var v = ov.swizzle.yyzxz;
                Assert.AreEqual(new Complex(8.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(1.0, 2d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -9d), new Complex(-4.5d, 0.5d), new Complex(-8.5d, 6d));
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(new Complex(-4.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 6d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -2.5d), new Complex(5.5d, -3d), new Complex(-2.5d, 9d));
                var v = ov.swizzle.yyzyx;
                Assert.AreEqual(new Complex(5.5d, -3d), v.x);
                Assert.AreEqual(new Complex(5.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 9d), v.z);
                Assert.AreEqual(new Complex(5.5d, -3d), v.w);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 8d), new Complex(1.0, 1.0), new Complex(-3.5d, -8d));
                var v = ov.swizzle.yyzyy;
                Assert.AreEqual(new Complex(1.0, 1.0), v.x);
                Assert.AreEqual(new Complex(1.0, 1.0), v.y);
                Assert.AreEqual(new Complex(-3.5d, -8d), v.z);
                Assert.AreEqual(new Complex(1.0, 1.0), v.w);
                Assert.AreEqual(new Complex(1.0, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 4d), new Complex(6.5d, -6.5d), new Complex(-4.5d, -6d));
                var v = ov.swizzle.yyzyz;
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -6d), v.z);
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -9.5d), new Complex(2d, 9d), new Complex(-8d, -4d));
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(new Complex(2d, 9d), v.x);
                Assert.AreEqual(new Complex(2d, 9d), v.y);
                Assert.AreEqual(new Complex(-8d, -4d), v.z);
                Assert.AreEqual(new Complex(-8d, -4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1d, 3d), new Complex(5.5d, 8.5d), new Complex(7.5d, 3.5d));
                var v = ov.swizzle.yyzzx;
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(-1d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 9d), new Complex(-2.5d, 9d), new Complex(9d, 1.5d));
                var v = ov.swizzle.yyzzy;
                Assert.AreEqual(new Complex(-2.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 9d), v.y);
                Assert.AreEqual(new Complex(9d, 1.5d), v.z);
                Assert.AreEqual(new Complex(9d, 1.5d), v.w);
                Assert.AreEqual(new Complex(-2.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 7.5d), new Complex(-1.5d, -5d), new Complex(-8d, -9.5d));
                var v = ov.swizzle.yyzzz;
                Assert.AreEqual(new Complex(-1.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-8d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-8d, -9.5d), v.w);
                Assert.AreEqual(new Complex(-8d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, 5.5d), new Complex(2d, 9.5d), new Complex(-8.5d, -6d));
                var v = ov.swizzle.yz;
                Assert.AreEqual(new Complex(2d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -6d), v.y);
            }
            {
                var ov = new cvec3(new Complex(-7d, 4d), new Complex(-6.5d, 6d), new Complex(-7d, 6.5d));
                var v = ov.swizzle.yzx;
                Assert.AreEqual(new Complex(-6.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-7d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 4d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-3d, -4.5d), new Complex(8.5d, -8.5d), new Complex(-5.5d, -8.5d));
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(new Complex(8.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -4.5d), new Complex(-2d, -7.5d), new Complex(8d, 9.5d));
                var v = ov.swizzle.yzxxx;
                Assert.AreEqual(new Complex(-2d, -7.5d), v.x);
                Assert.AreEqual(new Complex(8d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, 5d), new Complex(9d, 1.5d), new Complex(6.5d, 1.5d));
                var v = ov.swizzle.yzxxy;
                Assert.AreEqual(new Complex(9d, 1.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 5d), v.z);
                Assert.AreEqual(new Complex(-7d, 5d), v.w);
                Assert.AreEqual(new Complex(9d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 9.5d), new Complex(-7d, 9.5d), new Complex(-7d, -8d));
                var v = ov.swizzle.yzxxz;
                Assert.AreEqual(new Complex(-7d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -8d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.w);
                Assert.AreEqual(new Complex(-7d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, -6d), new Complex(3d, 3d), new Complex(-4d, 3.5d));
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(new Complex(3d, 3d), v.x);
                Assert.AreEqual(new Complex(-4d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -6d), v.z);
                Assert.AreEqual(new Complex(3d, 3d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 5d), new Complex(4d, 1.0), new Complex(9.5d, 7d));
                var v = ov.swizzle.yzxyx;
                Assert.AreEqual(new Complex(4d, 1.0), v.x);
                Assert.AreEqual(new Complex(9.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 5d), v.z);
                Assert.AreEqual(new Complex(4d, 1.0), v.w);
                Assert.AreEqual(new Complex(-8.5d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, -6d), new Complex(-8.5d, -2d), new Complex(-8.5d, 6d));
                var v = ov.swizzle.yzxyy;
                Assert.AreEqual(new Complex(-8.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 6d), v.y);
                Assert.AreEqual(new Complex(6d, -6d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -2d), v.w);
                Assert.AreEqual(new Complex(-8.5d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -7.5d), new Complex(-9d, 3.5d), new Complex(-2d, -6d));
                var v = ov.swizzle.yzxyz;
                Assert.AreEqual(new Complex(-9d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -6d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-9d, 3.5d), v.w);
                Assert.AreEqual(new Complex(-2d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 3d), new Complex(1.0, -9.5d), new Complex(7.5d, -5d));
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(new Complex(1.0, -9.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-6d, 3d), v.z);
                Assert.AreEqual(new Complex(7.5d, -5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2d, -4.5d), new Complex(-4d, -0.5d), new Complex(2.5d, -1d));
                var v = ov.swizzle.yzxzx;
                Assert.AreEqual(new Complex(-4d, -0.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -1d), v.y);
                Assert.AreEqual(new Complex(2d, -4.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -1d), v.w);
                Assert.AreEqual(new Complex(2d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, 2.5d), new Complex(-1.5d, 3d), new Complex(-8d, 5.5d));
                var v = ov.swizzle.yzxzy;
                Assert.AreEqual(new Complex(-1.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-8d, 5.5d), v.y);
                Assert.AreEqual(new Complex(5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 5.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, -9.5d), new Complex(1.5d, -9.5d), new Complex(8.5d, 2d));
                var v = ov.swizzle.yzxzz;
                Assert.AreEqual(new Complex(1.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 2d), v.y);
                Assert.AreEqual(new Complex(8d, -9.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 2d), v.w);
                Assert.AreEqual(new Complex(8.5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.0, 2.5d), new Complex(5.5d, 5.5d), new Complex(0.5d, -1.5d));
                var v = ov.swizzle.yzy;
                Assert.AreEqual(new Complex(5.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 5.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(8d, -2d), new Complex(3.5d, 7.5d), new Complex(-3.5d, 5d));
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(new Complex(3.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(8d, -2d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, 9.5d), new Complex(5.5d, 9d), new Complex(9d, 7d));
                var v = ov.swizzle.yzyxx;
                Assert.AreEqual(new Complex(5.5d, 9d), v.x);
                Assert.AreEqual(new Complex(9d, 7d), v.y);
                Assert.AreEqual(new Complex(5.5d, 9d), v.z);
                Assert.AreEqual(new Complex(0.0, 9.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -3d), new Complex(0.0, -9d), new Complex(-4.5d, 9d));
                var v = ov.swizzle.yzyxy;
                Assert.AreEqual(new Complex(0.0, -9d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 9d), v.y);
                Assert.AreEqual(new Complex(0.0, -9d), v.z);
                Assert.AreEqual(new Complex(3.5d, -3d), v.w);
                Assert.AreEqual(new Complex(0.0, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, -5.5d), new Complex(-2.5d, 0.5d), new Complex(8.5d, 7.5d));
                var v = ov.swizzle.yzyxz;
                Assert.AreEqual(new Complex(-2.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(3d, -5.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 7d), new Complex(9d, -3.5d), new Complex(1.0, 2.5d));
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(new Complex(9d, -3.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 2.5d), v.y);
                Assert.AreEqual(new Complex(9d, -3.5d), v.z);
                Assert.AreEqual(new Complex(9d, -3.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -0.5d), new Complex(-5.5d, 3d), new Complex(-9d, -3.5d));
                var v = ov.swizzle.yzyyx;
                Assert.AreEqual(new Complex(-5.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-9d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 3d), v.w);
                Assert.AreEqual(new Complex(6.5d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, 3d), new Complex(9d, -9d), new Complex(9d, 9.5d));
                var v = ov.swizzle.yzyyy;
                Assert.AreEqual(new Complex(9d, -9d), v.x);
                Assert.AreEqual(new Complex(9d, 9.5d), v.y);
                Assert.AreEqual(new Complex(9d, -9d), v.z);
                Assert.AreEqual(new Complex(9d, -9d), v.w);
                Assert.AreEqual(new Complex(9d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -4.5d), new Complex(-4d, -8d), new Complex(6.5d, 1.0));
                var v = ov.swizzle.yzyyz;
                Assert.AreEqual(new Complex(-4d, -8d), v.x);
                Assert.AreEqual(new Complex(6.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-4d, -8d), v.z);
                Assert.AreEqual(new Complex(-4d, -8d), v.w);
                Assert.AreEqual(new Complex(6.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, -9d), new Complex(-8.5d, 5d), new Complex(-0.5d, 5.5d));
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(new Complex(-8.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -6.5d), new Complex(-4d, 4.5d), new Complex(-2d, -6.5d));
                var v = ov.swizzle.yzyzx;
                Assert.AreEqual(new Complex(-4d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-2d, -6.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 1.5d), new Complex(-9.5d, -1d), new Complex(8d, 6d));
                var v = ov.swizzle.yzyzy;
                Assert.AreEqual(new Complex(-9.5d, -1d), v.x);
                Assert.AreEqual(new Complex(8d, 6d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -1d), v.z);
                Assert.AreEqual(new Complex(8d, 6d), v.w);
                Assert.AreEqual(new Complex(-9.5d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, -8d), new Complex(8.5d, 4d), new Complex(-2.5d, -4d));
                var v = ov.swizzle.yzyzz;
                Assert.AreEqual(new Complex(8.5d, 4d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -4d), v.y);
                Assert.AreEqual(new Complex(8.5d, 4d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -4d), v.w);
                Assert.AreEqual(new Complex(-2.5d, -4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, 1.0), new Complex(-1.5d, -9.5d), new Complex(-5.5d, -6.5d));
                var v = ov.swizzle.yzz;
                Assert.AreEqual(new Complex(-1.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -6.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(2d, 5d), new Complex(-7.5d, 0.5d), new Complex(0.0, 8.5d));
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(new Complex(-7.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 8.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 8.5d), v.z);
                Assert.AreEqual(new Complex(2d, 5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3d, 3d), new Complex(9.5d, 0.0), new Complex(-3.5d, 8.5d));
                var v = ov.swizzle.yzzxx;
                Assert.AreEqual(new Complex(9.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-3.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-3d, 3d), v.w);
                Assert.AreEqual(new Complex(-3d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -3d), new Complex(-5.5d, -5.5d), new Complex(-8d, -5d));
                var v = ov.swizzle.yzzxy;
                Assert.AreEqual(new Complex(-5.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -5d), v.y);
                Assert.AreEqual(new Complex(-8d, -5d), v.z);
                Assert.AreEqual(new Complex(3.5d, -3d), v.w);
                Assert.AreEqual(new Complex(-5.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, 0.0), new Complex(-2d, 0.5d), new Complex(7d, -5d));
                var v = ov.swizzle.yzzxz;
                Assert.AreEqual(new Complex(-2d, 0.5d), v.x);
                Assert.AreEqual(new Complex(7d, -5d), v.y);
                Assert.AreEqual(new Complex(7d, -5d), v.z);
                Assert.AreEqual(new Complex(-7d, 0.0), v.w);
                Assert.AreEqual(new Complex(7d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9d, -5d), new Complex(-1.5d, -0.5d), new Complex(-3.5d, -4d));
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(new Complex(-1.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -4d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -3.5d), new Complex(6.5d, -2.5d), new Complex(-9.5d, -8d));
                var v = ov.swizzle.yzzyx;
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -8d), v.z);
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(-9.5d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 3d), new Complex(6.5d, -8.5d), new Complex(-5d, 2d));
                var v = ov.swizzle.yzzyy;
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 2d), v.y);
                Assert.AreEqual(new Complex(-5d, 2d), v.z);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -2d), new Complex(4.5d, 0.5d), new Complex(-3.5d, -4.5d));
                var v = ov.swizzle.yzzyz;
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, -5.5d), new Complex(-2.5d, 3.5d), new Complex(7d, -8d));
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(new Complex(-2.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(7d, -8d), v.y);
                Assert.AreEqual(new Complex(7d, -8d), v.z);
                Assert.AreEqual(new Complex(7d, -8d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -0.5d), new Complex(-3d, -1.5d), new Complex(-2d, -7.5d));
                var v = ov.swizzle.yzzzx;
                Assert.AreEqual(new Complex(-3d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-2d, -7.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -9d), new Complex(1.0, -4.5d), new Complex(5.5d, -6.5d));
                var v = ov.swizzle.yzzzy;
                Assert.AreEqual(new Complex(1.0, -4.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(1.0, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, 2d), new Complex(9d, 5.5d), new Complex(-2.5d, -1.5d));
                var v = ov.swizzle.yzzzz;
                Assert.AreEqual(new Complex(9d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.w);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, 9.5d), new Complex(9.5d, -7.5d), new Complex(-5d, -8d));
                var v = ov.swizzle.zx;
                Assert.AreEqual(new Complex(-5d, -8d), v.x);
                Assert.AreEqual(new Complex(8d, 9.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(9d, 1.0), new Complex(-2d, 5d), new Complex(6.5d, -8.5d));
                var v = ov.swizzle.zxx;
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(9d, 1.0), v.y);
                Assert.AreEqual(new Complex(9d, 1.0), v.z);
            }
            {
                var ov = new cvec3(new Complex(-2d, -9d), new Complex(-7.5d, -8.5d), new Complex(2d, 1.0));
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(new Complex(2d, 1.0), v.x);
                Assert.AreEqual(new Complex(-2d, -9d), v.y);
                Assert.AreEqual(new Complex(-2d, -9d), v.z);
                Assert.AreEqual(new Complex(-2d, -9d), v.w);
            }
            {
                var ov = new cvec3(new Complex(4d, 6d), new Complex(7.5d, -7d), new Complex(1.5d, -8.5d));
                var v = ov.swizzle.zxxxx;
                Assert.AreEqual(new Complex(1.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(4d, 6d), v.y);
                Assert.AreEqual(new Complex(4d, 6d), v.z);
                Assert.AreEqual(new Complex(4d, 6d), v.w);
                Assert.AreEqual(new Complex(4d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 2.5d), new Complex(-1.5d, 1.5d), new Complex(1.0, -5d));
                var v = ov.swizzle.zxxxy;
                Assert.AreEqual(new Complex(1.0, -5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 4.5d), new Complex(4d, 6.5d), new Complex(1.5d, 8.5d));
                var v = ov.swizzle.zxxxz;
                Assert.AreEqual(new Complex(1.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(6d, 4.5d), v.y);
                Assert.AreEqual(new Complex(6d, 4.5d), v.z);
                Assert.AreEqual(new Complex(6d, 4.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, -9d), new Complex(-7.5d, 3.5d), new Complex(-1.5d, 0.0));
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(new Complex(-1.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(9d, -9d), v.y);
                Assert.AreEqual(new Complex(9d, -9d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5d, -4d), new Complex(9.5d, -9d), new Complex(-2d, 5d));
                var v = ov.swizzle.zxxyx;
                Assert.AreEqual(new Complex(-2d, 5d), v.x);
                Assert.AreEqual(new Complex(-5d, -4d), v.y);
                Assert.AreEqual(new Complex(-5d, -4d), v.z);
                Assert.AreEqual(new Complex(9.5d, -9d), v.w);
                Assert.AreEqual(new Complex(-5d, -4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9d, -9d), new Complex(2d, -7.5d), new Complex(-1d, 4.5d));
                var v = ov.swizzle.zxxyy;
                Assert.AreEqual(new Complex(-1d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-9d, -9d), v.y);
                Assert.AreEqual(new Complex(-9d, -9d), v.z);
                Assert.AreEqual(new Complex(2d, -7.5d), v.w);
                Assert.AreEqual(new Complex(2d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, 1.5d), new Complex(1.0, -9d), new Complex(-1d, 2d));
                var v = ov.swizzle.zxxyz;
                Assert.AreEqual(new Complex(-1d, 2d), v.x);
                Assert.AreEqual(new Complex(5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -9d), v.w);
                Assert.AreEqual(new Complex(-1d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, 1.5d), new Complex(-5.5d, -3d), new Complex(-8d, 2.5d));
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(new Complex(-8d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-2d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -4.5d), new Complex(-1d, -4.5d), new Complex(7.5d, 5d));
                var v = ov.swizzle.zxxzx;
                Assert.AreEqual(new Complex(7.5d, 5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 5d), v.w);
                Assert.AreEqual(new Complex(8.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 7.5d), new Complex(-8.5d, 0.0), new Complex(-4.5d, -4d));
                var v = ov.swizzle.zxxzy;
                Assert.AreEqual(new Complex(-4.5d, -4d), v.x);
                Assert.AreEqual(new Complex(4d, 7.5d), v.y);
                Assert.AreEqual(new Complex(4d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -4d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 0.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, -8.5d), new Complex(7d, 1.5d), new Complex(-3d, 6d));
                var v = ov.swizzle.zxxzz;
                Assert.AreEqual(new Complex(-3d, 6d), v.x);
                Assert.AreEqual(new Complex(-8d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-8d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-3d, 6d), v.w);
                Assert.AreEqual(new Complex(-3d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -8.5d), new Complex(8d, -6d), new Complex(0.5d, -7d));
                var v = ov.swizzle.zxy;
                Assert.AreEqual(new Complex(0.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(8d, -6d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6d, 6.5d), new Complex(7d, 5.5d), new Complex(-5.5d, 6.5d));
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-6d, 6.5d), v.y);
                Assert.AreEqual(new Complex(7d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-6d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1d, 5d), new Complex(7d, -6.5d), new Complex(6.5d, -0.5d));
                var v = ov.swizzle.zxyxx;
                Assert.AreEqual(new Complex(6.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 5d), v.y);
                Assert.AreEqual(new Complex(7d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-1d, 5d), v.w);
                Assert.AreEqual(new Complex(-1d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, -6.5d), new Complex(-4.5d, -8.5d), new Complex(-1.5d, 1.0));
                var v = ov.swizzle.zxyxy;
                Assert.AreEqual(new Complex(-1.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(3d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(3d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -1.5d), new Complex(4.5d, -4.5d), new Complex(0.0, 1.0));
                var v = ov.swizzle.zxyxz;
                Assert.AreEqual(new Complex(0.0, 1.0), v.x);
                Assert.AreEqual(new Complex(9.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -1.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, -1d), new Complex(0.5d, -7.5d), new Complex(8d, -7.5d));
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(new Complex(8d, -7.5d), v.x);
                Assert.AreEqual(new Complex(3d, -1d), v.y);
                Assert.AreEqual(new Complex(0.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -4.5d), new Complex(5d, -3.5d), new Complex(-9.5d, 9.5d));
                var v = ov.swizzle.zxyyx;
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(5d, -3.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 8.5d), new Complex(2.5d, -6d), new Complex(-4d, 2d));
                var v = ov.swizzle.zxyyy;
                Assert.AreEqual(new Complex(-4d, 2d), v.x);
                Assert.AreEqual(new Complex(1.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, -6d), v.z);
                Assert.AreEqual(new Complex(2.5d, -6d), v.w);
                Assert.AreEqual(new Complex(2.5d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, -2.5d), new Complex(-5.5d, 6d), new Complex(-8d, 4d));
                var v = ov.swizzle.zxyyz;
                Assert.AreEqual(new Complex(-8d, 4d), v.x);
                Assert.AreEqual(new Complex(-3d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 6d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 6d), v.w);
                Assert.AreEqual(new Complex(-8d, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 9d), new Complex(1.0, 4.5d), new Complex(-5.5d, 6.5d));
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(4d, 9d), v.y);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6d, -7.5d), new Complex(1.5d, 7.5d), new Complex(-5d, 0.0));
                var v = ov.swizzle.zxyzx;
                Assert.AreEqual(new Complex(-5d, 0.0), v.x);
                Assert.AreEqual(new Complex(6d, -7.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 0.0), v.w);
                Assert.AreEqual(new Complex(6d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, 1.5d), new Complex(0.5d, 2.5d), new Complex(1.5d, 0.0));
                var v = ov.swizzle.zxyzy;
                Assert.AreEqual(new Complex(1.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(0.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -1.5d), new Complex(2d, -9.5d), new Complex(4.5d, -2.5d));
                var v = ov.swizzle.zxyzz;
                Assert.AreEqual(new Complex(4.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(2d, -9.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 7.5d), new Complex(5.5d, -4.5d), new Complex(3.5d, 6.5d));
                var v = ov.swizzle.zxz;
                Assert.AreEqual(new Complex(3.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 6.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4d, -4d), new Complex(8d, 5d), new Complex(8.5d, 1.5d));
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(new Complex(8.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-4d, -4d), v.y);
                Assert.AreEqual(new Complex(8.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 0.5d), new Complex(8.5d, 7.5d), new Complex(-6d, 9.5d));
                var v = ov.swizzle.zxzxx;
                Assert.AreEqual(new Complex(-6d, 9.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 9.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 2d), new Complex(1.0, -4.5d), new Complex(0.5d, -8d));
                var v = ov.swizzle.zxzxy;
                Assert.AreEqual(new Complex(0.5d, -8d), v.x);
                Assert.AreEqual(new Complex(7.5d, 2d), v.y);
                Assert.AreEqual(new Complex(0.5d, -8d), v.z);
                Assert.AreEqual(new Complex(7.5d, 2d), v.w);
                Assert.AreEqual(new Complex(1.0, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 0.5d), new Complex(2.5d, 6.5d), new Complex(2d, 3d));
                var v = ov.swizzle.zxzxz;
                Assert.AreEqual(new Complex(2d, 3d), v.x);
                Assert.AreEqual(new Complex(-6d, 0.5d), v.y);
                Assert.AreEqual(new Complex(2d, 3d), v.z);
                Assert.AreEqual(new Complex(-6d, 0.5d), v.w);
                Assert.AreEqual(new Complex(2d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 7d), new Complex(2.5d, -7.5d), new Complex(-7d, 0.0));
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(new Complex(-7d, 0.0), v.x);
                Assert.AreEqual(new Complex(2.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-7d, 0.0), v.z);
                Assert.AreEqual(new Complex(2.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7d, -2d), new Complex(3d, 7d), new Complex(-5.5d, -1.5d));
                var v = ov.swizzle.zxzyx;
                Assert.AreEqual(new Complex(-5.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -2d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(3d, 7d), v.w);
                Assert.AreEqual(new Complex(-7d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 0.5d), new Complex(5d, 3.5d), new Complex(5d, -3.5d));
                var v = ov.swizzle.zxzyy;
                Assert.AreEqual(new Complex(5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(6d, 0.5d), v.y);
                Assert.AreEqual(new Complex(5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(5d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, 1.5d), new Complex(7.5d, 0.0), new Complex(3.5d, -5.5d));
                var v = ov.swizzle.zxzyz;
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-2d, 1.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, 9.5d), new Complex(-5.5d, 4.5d), new Complex(3d, 1.5d));
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(new Complex(3d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 9.5d), v.y);
                Assert.AreEqual(new Complex(3d, 1.5d), v.z);
                Assert.AreEqual(new Complex(3d, 1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9d, 0.0), new Complex(-7.5d, -7.5d), new Complex(-1.5d, 0.0));
                var v = ov.swizzle.zxzzx;
                Assert.AreEqual(new Complex(-1.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(9d, 0.0), v.y);
                Assert.AreEqual(new Complex(-1.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(-1.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(9d, 0.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, 5.5d), new Complex(8.5d, -1.5d), new Complex(-1d, 0.0));
                var v = ov.swizzle.zxzzy;
                Assert.AreEqual(new Complex(-1d, 0.0), v.x);
                Assert.AreEqual(new Complex(-4d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 0.0), v.z);
                Assert.AreEqual(new Complex(-1d, 0.0), v.w);
                Assert.AreEqual(new Complex(8.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 3d), new Complex(-8d, -6.5d), new Complex(-5.5d, 7d));
                var v = ov.swizzle.zxzzz;
                Assert.AreEqual(new Complex(-5.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 7d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -1d), new Complex(-7.5d, 7.5d), new Complex(-4.5d, 8d));
                var v = ov.swizzle.zy;
                Assert.AreEqual(new Complex(-4.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 7.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(1.0, 2d), new Complex(7d, 7d), new Complex(0.0, 7d));
                var v = ov.swizzle.zyx;
                Assert.AreEqual(new Complex(0.0, 7d), v.x);
                Assert.AreEqual(new Complex(7d, 7d), v.y);
                Assert.AreEqual(new Complex(1.0, 2d), v.z);
            }
            {
                var ov = new cvec3(new Complex(4.5d, -9d), new Complex(0.5d, 2.5d), new Complex(9.5d, 1.0));
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(new Complex(9.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(0.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -9d), v.z);
                Assert.AreEqual(new Complex(4.5d, -9d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2d, 5.5d), new Complex(-6.5d, -5.5d), new Complex(8.5d, 9d));
                var v = ov.swizzle.zyxxx;
                Assert.AreEqual(new Complex(8.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-2d, 5.5d), v.w);
                Assert.AreEqual(new Complex(-2d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, 8.5d), new Complex(4d, -4d), new Complex(9.5d, -3d));
                var v = ov.swizzle.zyxxy;
                Assert.AreEqual(new Complex(9.5d, -3d), v.x);
                Assert.AreEqual(new Complex(4d, -4d), v.y);
                Assert.AreEqual(new Complex(-4d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-4d, 8.5d), v.w);
                Assert.AreEqual(new Complex(4d, -4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, 6.5d), new Complex(-9.5d, 5d), new Complex(-0.5d, 0.5d));
                var v = ov.swizzle.zyxxz;
                Assert.AreEqual(new Complex(-0.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 5d), v.y);
                Assert.AreEqual(new Complex(9d, 6.5d), v.z);
                Assert.AreEqual(new Complex(9d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-0.5d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 7d), new Complex(1.0, -8.5d), new Complex(-2d, 4d));
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(new Complex(-2d, 4d), v.x);
                Assert.AreEqual(new Complex(1.0, -8.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 7d), v.z);
                Assert.AreEqual(new Complex(1.0, -8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5d, 5d), new Complex(-7d, -0.5d), new Complex(-5d, 1.0));
                var v = ov.swizzle.zyxyx;
                Assert.AreEqual(new Complex(-5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-7d, -0.5d), v.y);
                Assert.AreEqual(new Complex(5d, 5d), v.z);
                Assert.AreEqual(new Complex(-7d, -0.5d), v.w);
                Assert.AreEqual(new Complex(5d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, 6d), new Complex(-2.5d, 9.5d), new Complex(-9.5d, 2d));
                var v = ov.swizzle.zyxyy;
                Assert.AreEqual(new Complex(-9.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-3d, 6d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 9.5d), v.w);
                Assert.AreEqual(new Complex(-2.5d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, -5d), new Complex(1.0, 2.5d), new Complex(4.5d, 7d));
                var v = ov.swizzle.zyxyz;
                Assert.AreEqual(new Complex(4.5d, 7d), v.x);
                Assert.AreEqual(new Complex(1.0, 2.5d), v.y);
                Assert.AreEqual(new Complex(2d, -5d), v.z);
                Assert.AreEqual(new Complex(1.0, 2.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 2d), new Complex(5d, 2d), new Complex(-4d, 7.5d));
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(new Complex(-4d, 7.5d), v.x);
                Assert.AreEqual(new Complex(5d, 2d), v.y);
                Assert.AreEqual(new Complex(2.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-4d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 2.5d), new Complex(1.0, 9.5d), new Complex(-8.5d, -1d));
                var v = ov.swizzle.zyxzx;
                Assert.AreEqual(new Complex(-8.5d, -1d), v.x);
                Assert.AreEqual(new Complex(1.0, 9.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -1d), v.w);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -9d), new Complex(5d, -4.5d), new Complex(8.5d, -3.5d));
                var v = ov.swizzle.zyxzy;
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -9d), v.z);
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.w);
                Assert.AreEqual(new Complex(5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, -7d), new Complex(-8d, -2d), new Complex(6d, 6d));
                var v = ov.swizzle.zyxzz;
                Assert.AreEqual(new Complex(6d, 6d), v.x);
                Assert.AreEqual(new Complex(-8d, -2d), v.y);
                Assert.AreEqual(new Complex(5d, -7d), v.z);
                Assert.AreEqual(new Complex(6d, 6d), v.w);
                Assert.AreEqual(new Complex(6d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, -7.5d), new Complex(1.0, 2d), new Complex(1.0, 7d));
                var v = ov.swizzle.zyy;
                Assert.AreEqual(new Complex(1.0, 7d), v.x);
                Assert.AreEqual(new Complex(1.0, 2d), v.y);
                Assert.AreEqual(new Complex(1.0, 2d), v.z);
            }
            {
                var ov = new cvec3(new Complex(5d, -7.5d), new Complex(5.5d, 1.0), new Complex(-8d, 5d));
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(new Complex(-8d, 5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(5.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(5d, -7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -1.5d), new Complex(3d, 6.5d), new Complex(-9d, -8.5d));
                var v = ov.swizzle.zyyxx;
                Assert.AreEqual(new Complex(-9d, -8.5d), v.x);
                Assert.AreEqual(new Complex(3d, 6.5d), v.y);
                Assert.AreEqual(new Complex(3d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -1.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -1d), new Complex(8.5d, 5.5d), new Complex(-7d, 0.0));
                var v = ov.swizzle.zyyxy;
                Assert.AreEqual(new Complex(-7d, 0.0), v.x);
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -1d), v.w);
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, 0.0), new Complex(9d, 3d), new Complex(5d, 6d));
                var v = ov.swizzle.zyyxz;
                Assert.AreEqual(new Complex(5d, 6d), v.x);
                Assert.AreEqual(new Complex(9d, 3d), v.y);
                Assert.AreEqual(new Complex(9d, 3d), v.z);
                Assert.AreEqual(new Complex(-3d, 0.0), v.w);
                Assert.AreEqual(new Complex(5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, 5d), new Complex(-1.5d, 6.5d), new Complex(-9.5d, 7d));
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(new Complex(-9.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 4d), new Complex(2.5d, 1.0), new Complex(-1.5d, 8.5d));
                var v = ov.swizzle.zyyyx;
                Assert.AreEqual(new Complex(-1.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(2.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(2.5d, 1.0), v.w);
                Assert.AreEqual(new Complex(-8.5d, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 1.5d), new Complex(-9.5d, 2.5d), new Complex(-8d, -9.5d));
                var v = ov.swizzle.zyyyy;
                Assert.AreEqual(new Complex(-8d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 9d), new Complex(-7.5d, 5d), new Complex(2d, -3d));
                var v = ov.swizzle.zyyyz;
                Assert.AreEqual(new Complex(2d, -3d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 5d), v.w);
                Assert.AreEqual(new Complex(2d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9d, 0.0), new Complex(-1d, -8d), new Complex(-4d, -8d));
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(new Complex(-4d, -8d), v.x);
                Assert.AreEqual(new Complex(-1d, -8d), v.y);
                Assert.AreEqual(new Complex(-1d, -8d), v.z);
                Assert.AreEqual(new Complex(-4d, -8d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 3d), new Complex(-7.5d, -0.5d), new Complex(-5.5d, 8d));
                var v = ov.swizzle.zyyzx;
                Assert.AreEqual(new Complex(-5.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.w);
                Assert.AreEqual(new Complex(1.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 6.5d), new Complex(-1d, -6.5d), new Complex(-6d, -5.5d));
                var v = ov.swizzle.zyyzy;
                Assert.AreEqual(new Complex(-6d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-1d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -5.5d), v.w);
                Assert.AreEqual(new Complex(-1d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, 2.5d), new Complex(6d, -7.5d), new Complex(2.5d, 8.5d));
                var v = ov.swizzle.zyyzz;
                Assert.AreEqual(new Complex(2.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(6d, -7.5d), v.y);
                Assert.AreEqual(new Complex(6d, -7.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(2.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, 5.5d), new Complex(-4d, -2.5d), new Complex(7.5d, 6.5d));
                var v = ov.swizzle.zyz;
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-4d, -2.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-5d, -4.5d), new Complex(-1d, 0.5d), new Complex(6d, 6d));
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(new Complex(6d, 6d), v.x);
                Assert.AreEqual(new Complex(-1d, 0.5d), v.y);
                Assert.AreEqual(new Complex(6d, 6d), v.z);
                Assert.AreEqual(new Complex(-5d, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 7.5d), new Complex(-9.5d, -0.5d), new Complex(2.5d, 5.5d));
                var v = ov.swizzle.zyzxx;
                Assert.AreEqual(new Complex(2.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 7.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 1.0), new Complex(-0.5d, -1d), new Complex(-7d, -1.5d));
                var v = ov.swizzle.zyzxy;
                Assert.AreEqual(new Complex(-7d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-7d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-6d, 1.0), v.w);
                Assert.AreEqual(new Complex(-0.5d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9d, -7d), new Complex(-4.5d, -3d), new Complex(-3.5d, -1d));
                var v = ov.swizzle.zyzxz;
                Assert.AreEqual(new Complex(-3.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-9d, -7d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, 8d), new Complex(-0.5d, -1.5d), new Complex(-8.5d, 9d));
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(new Complex(-8.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 9d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, -2.5d), new Complex(-7.5d, -2d), new Complex(-3d, 4.5d));
                var v = ov.swizzle.zyzyx;
                Assert.AreEqual(new Complex(-3d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-3d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -2d), v.w);
                Assert.AreEqual(new Complex(-6.5d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, 0.5d), new Complex(9d, -3.5d), new Complex(3.5d, -9d));
                var v = ov.swizzle.zyzyy;
                Assert.AreEqual(new Complex(3.5d, -9d), v.x);
                Assert.AreEqual(new Complex(9d, -3.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -9d), v.z);
                Assert.AreEqual(new Complex(9d, -3.5d), v.w);
                Assert.AreEqual(new Complex(9d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, 0.0), new Complex(0.5d, 6d), new Complex(-7d, 4d));
                var v = ov.swizzle.zyzyz;
                Assert.AreEqual(new Complex(-7d, 4d), v.x);
                Assert.AreEqual(new Complex(0.5d, 6d), v.y);
                Assert.AreEqual(new Complex(-7d, 4d), v.z);
                Assert.AreEqual(new Complex(0.5d, 6d), v.w);
                Assert.AreEqual(new Complex(-7d, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 2.5d), new Complex(7d, 2d), new Complex(8.5d, -9.5d));
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(new Complex(8.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(7d, 2d), v.y);
                Assert.AreEqual(new Complex(8.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -7.5d), new Complex(7.5d, -4d), new Complex(-7.5d, -2d));
                var v = ov.swizzle.zyzzx;
                Assert.AreEqual(new Complex(-7.5d, -2d), v.x);
                Assert.AreEqual(new Complex(7.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -2d), v.w);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 9d), new Complex(-9d, 6d), new Complex(-8d, -3d));
                var v = ov.swizzle.zyzzy;
                Assert.AreEqual(new Complex(-8d, -3d), v.x);
                Assert.AreEqual(new Complex(-9d, 6d), v.y);
                Assert.AreEqual(new Complex(-8d, -3d), v.z);
                Assert.AreEqual(new Complex(-8d, -3d), v.w);
                Assert.AreEqual(new Complex(-9d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 1.0), new Complex(0.5d, 5d), new Complex(8d, 9.5d));
                var v = ov.swizzle.zyzzz;
                Assert.AreEqual(new Complex(8d, 9.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 5d), v.y);
                Assert.AreEqual(new Complex(8d, 9.5d), v.z);
                Assert.AreEqual(new Complex(8d, 9.5d), v.w);
                Assert.AreEqual(new Complex(8d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -2d), new Complex(-3.5d, -3d), new Complex(1.0, -4d));
                var v = ov.swizzle.zz;
                Assert.AreEqual(new Complex(1.0, -4d), v.x);
                Assert.AreEqual(new Complex(1.0, -4d), v.y);
            }
            {
                var ov = new cvec3(new Complex(9d, -8d), new Complex(2d, 6.5d), new Complex(-7.5d, 6d));
                var v = ov.swizzle.zzx;
                Assert.AreEqual(new Complex(-7.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 6d), v.y);
                Assert.AreEqual(new Complex(9d, -8d), v.z);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -0.5d), new Complex(-2d, -4.5d), new Complex(7.5d, -6d));
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(new Complex(7.5d, -6d), v.x);
                Assert.AreEqual(new Complex(7.5d, -6d), v.y);
                Assert.AreEqual(new Complex(6.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 8.5d), new Complex(-2.5d, -1.5d), new Complex(-8.5d, 4.5d));
                var v = ov.swizzle.zzxxx;
                Assert.AreEqual(new Complex(-8.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, -5d), new Complex(0.5d, 4d), new Complex(-4.5d, -1d));
                var v = ov.swizzle.zzxxy;
                Assert.AreEqual(new Complex(-4.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -1d), v.y);
                Assert.AreEqual(new Complex(5.5d, -5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -5d), v.w);
                Assert.AreEqual(new Complex(0.5d, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, 2d), new Complex(-2.5d, 4d), new Complex(3d, 8.5d));
                var v = ov.swizzle.zzxxz;
                Assert.AreEqual(new Complex(3d, 8.5d), v.x);
                Assert.AreEqual(new Complex(3d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 2d), v.w);
                Assert.AreEqual(new Complex(3d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, -5d), new Complex(9d, -6.5d), new Complex(-8.5d, -5.5d));
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(new Complex(-8.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(4d, -5d), v.z);
                Assert.AreEqual(new Complex(9d, -6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 2d), new Complex(5d, 3d), new Complex(-3d, -4.5d));
                var v = ov.swizzle.zzxyx;
                Assert.AreEqual(new Complex(-3d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 2d), v.z);
                Assert.AreEqual(new Complex(5d, 3d), v.w);
                Assert.AreEqual(new Complex(0.5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, -5d), new Complex(-3.5d, -9.5d), new Complex(1.5d, 7.5d));
                var v = ov.swizzle.zzxyy;
                Assert.AreEqual(new Complex(1.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -9.5d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, -7d), new Complex(2.5d, 6d), new Complex(6d, 3d));
                var v = ov.swizzle.zzxyz;
                Assert.AreEqual(new Complex(6d, 3d), v.x);
                Assert.AreEqual(new Complex(6d, 3d), v.y);
                Assert.AreEqual(new Complex(5.5d, -7d), v.z);
                Assert.AreEqual(new Complex(2.5d, 6d), v.w);
                Assert.AreEqual(new Complex(6d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, 5.5d), new Complex(-2.5d, 6d), new Complex(9.5d, -7.5d));
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(new Complex(9.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(7d, 5.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2d, 8d), new Complex(-2d, -4d), new Complex(5.5d, 8.5d));
                var v = ov.swizzle.zzxzx;
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 8d), v.z);
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(-2d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -8d), new Complex(5d, -1d), new Complex(6d, -2.5d));
                var v = ov.swizzle.zzxzy;
                Assert.AreEqual(new Complex(6d, -2.5d), v.x);
                Assert.AreEqual(new Complex(6d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -8d), v.z);
                Assert.AreEqual(new Complex(6d, -2.5d), v.w);
                Assert.AreEqual(new Complex(5d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, 9d), new Complex(8d, -2d), new Complex(-8d, -9d));
                var v = ov.swizzle.zzxzz;
                Assert.AreEqual(new Complex(-8d, -9d), v.x);
                Assert.AreEqual(new Complex(-8d, -9d), v.y);
                Assert.AreEqual(new Complex(-2d, 9d), v.z);
                Assert.AreEqual(new Complex(-8d, -9d), v.w);
                Assert.AreEqual(new Complex(-8d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9d, -1.5d), new Complex(4.5d, 3.5d), new Complex(-9.5d, -4d));
                var v = ov.swizzle.zzy;
                Assert.AreEqual(new Complex(-9.5d, -4d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -4d), v.y);
                Assert.AreEqual(new Complex(4.5d, 3.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7d, -6.5d), new Complex(4.5d, 7d), new Complex(7d, 6d));
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(new Complex(7d, 6d), v.x);
                Assert.AreEqual(new Complex(7d, 6d), v.y);
                Assert.AreEqual(new Complex(4.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-7d, -6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 0.0), new Complex(7d, 4d), new Complex(2.5d, 2d));
                var v = ov.swizzle.zzyxx;
                Assert.AreEqual(new Complex(2.5d, 2d), v.x);
                Assert.AreEqual(new Complex(2.5d, 2d), v.y);
                Assert.AreEqual(new Complex(7d, 4d), v.z);
                Assert.AreEqual(new Complex(7.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(7.5d, 0.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, -2d), new Complex(-3.5d, -5.5d), new Complex(-9.5d, -8.5d));
                var v = ov.swizzle.zzyxy;
                Assert.AreEqual(new Complex(-9.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -2d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -5d), new Complex(-7.5d, 8d), new Complex(-8.5d, 7d));
                var v = ov.swizzle.zzyxz;
                Assert.AreEqual(new Complex(-8.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -0.5d), new Complex(-6d, 3d), new Complex(-7d, -6d));
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(new Complex(-7d, -6d), v.x);
                Assert.AreEqual(new Complex(-7d, -6d), v.y);
                Assert.AreEqual(new Complex(-6d, 3d), v.z);
                Assert.AreEqual(new Complex(-6d, 3d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 8d), new Complex(1.0, -1d), new Complex(-9.5d, -9d));
                var v = ov.swizzle.zzyyx;
                Assert.AreEqual(new Complex(-9.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -9d), v.y);
                Assert.AreEqual(new Complex(1.0, -1d), v.z);
                Assert.AreEqual(new Complex(1.0, -1d), v.w);
                Assert.AreEqual(new Complex(0.5d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 9d), new Complex(0.5d, 0.0), new Complex(0.0, -9.5d));
                var v = ov.swizzle.zzyyy;
                Assert.AreEqual(new Complex(0.0, -9.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -9.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -3d), new Complex(-5.5d, 3d), new Complex(-8d, -0.5d));
                var v = ov.swizzle.zzyyz;
                Assert.AreEqual(new Complex(-8d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 3d), v.w);
                Assert.AreEqual(new Complex(-8d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -3d), new Complex(7d, -7.5d), new Complex(-8.5d, 2.5d));
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(7d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, -1d), new Complex(3.5d, 5d), new Complex(1.0, 9d));
                var v = ov.swizzle.zzyzx;
                Assert.AreEqual(new Complex(1.0, 9d), v.x);
                Assert.AreEqual(new Complex(1.0, 9d), v.y);
                Assert.AreEqual(new Complex(3.5d, 5d), v.z);
                Assert.AreEqual(new Complex(1.0, 9d), v.w);
                Assert.AreEqual(new Complex(7.5d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 3d), new Complex(-1d, -2d), new Complex(-1d, 9d));
                var v = ov.swizzle.zzyzy;
                Assert.AreEqual(new Complex(-1d, 9d), v.x);
                Assert.AreEqual(new Complex(-1d, 9d), v.y);
                Assert.AreEqual(new Complex(-1d, -2d), v.z);
                Assert.AreEqual(new Complex(-1d, 9d), v.w);
                Assert.AreEqual(new Complex(-1d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -1d), new Complex(-7d, -0.5d), new Complex(2.5d, -3d));
                var v = ov.swizzle.zzyzz;
                Assert.AreEqual(new Complex(2.5d, -3d), v.x);
                Assert.AreEqual(new Complex(2.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-7d, -0.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -3d), v.w);
                Assert.AreEqual(new Complex(2.5d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -1.5d), new Complex(8.5d, -6d), new Complex(-5.5d, 9.5d));
                var v = ov.swizzle.zzz;
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-5d, 1.0), new Complex(4.5d, -6.5d), new Complex(0.0, -9.5d));
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(new Complex(0.0, -9.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -9.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -9.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9d, 8.5d), new Complex(-6.5d, 4.5d), new Complex(0.5d, 4d));
                var v = ov.swizzle.zzzxx;
                Assert.AreEqual(new Complex(0.5d, 4d), v.x);
                Assert.AreEqual(new Complex(0.5d, 4d), v.y);
                Assert.AreEqual(new Complex(0.5d, 4d), v.z);
                Assert.AreEqual(new Complex(-9d, 8.5d), v.w);
                Assert.AreEqual(new Complex(-9d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -1.5d), new Complex(-6.5d, -0.5d), new Complex(0.5d, 7d));
                var v = ov.swizzle.zzzxy;
                Assert.AreEqual(new Complex(0.5d, 7d), v.x);
                Assert.AreEqual(new Complex(0.5d, 7d), v.y);
                Assert.AreEqual(new Complex(0.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-5d, -1.5d), v.w);
                Assert.AreEqual(new Complex(-6.5d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -2d), new Complex(-7.5d, 0.0), new Complex(6d, 8.5d));
                var v = ov.swizzle.zzzxz;
                Assert.AreEqual(new Complex(6d, 8.5d), v.x);
                Assert.AreEqual(new Complex(6d, 8.5d), v.y);
                Assert.AreEqual(new Complex(6d, 8.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -2d), v.w);
                Assert.AreEqual(new Complex(6d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 0.0), new Complex(-1.5d, -8d), new Complex(4d, 1.5d));
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(new Complex(4d, 1.5d), v.x);
                Assert.AreEqual(new Complex(4d, 1.5d), v.y);
                Assert.AreEqual(new Complex(4d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9d, 2.5d), new Complex(5.5d, -1d), new Complex(-1d, 1.0));
                var v = ov.swizzle.zzzyx;
                Assert.AreEqual(new Complex(-1d, 1.0), v.x);
                Assert.AreEqual(new Complex(-1d, 1.0), v.y);
                Assert.AreEqual(new Complex(-1d, 1.0), v.z);
                Assert.AreEqual(new Complex(5.5d, -1d), v.w);
                Assert.AreEqual(new Complex(-9d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -8d), new Complex(7d, -3.5d), new Complex(9.5d, -6.5d));
                var v = ov.swizzle.zzzyy;
                Assert.AreEqual(new Complex(9.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(7d, -3.5d), v.w);
                Assert.AreEqual(new Complex(7d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, 8d), new Complex(-7d, 0.0), new Complex(3.5d, -9d));
                var v = ov.swizzle.zzzyz;
                Assert.AreEqual(new Complex(3.5d, -9d), v.x);
                Assert.AreEqual(new Complex(3.5d, -9d), v.y);
                Assert.AreEqual(new Complex(3.5d, -9d), v.z);
                Assert.AreEqual(new Complex(-7d, 0.0), v.w);
                Assert.AreEqual(new Complex(3.5d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9d, 9d), new Complex(-4.5d, 8d), new Complex(-1d, 4.5d));
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(new Complex(-1d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-1d, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9d, 6.5d), new Complex(5.5d, -8d), new Complex(8.5d, -4d));
                var v = ov.swizzle.zzzzx;
                Assert.AreEqual(new Complex(8.5d, -4d), v.x);
                Assert.AreEqual(new Complex(8.5d, -4d), v.y);
                Assert.AreEqual(new Complex(8.5d, -4d), v.z);
                Assert.AreEqual(new Complex(8.5d, -4d), v.w);
                Assert.AreEqual(new Complex(9d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 2d), new Complex(5d, -8d), new Complex(2d, 4.5d));
                var v = ov.swizzle.zzzzy;
                Assert.AreEqual(new Complex(2d, 4.5d), v.x);
                Assert.AreEqual(new Complex(2d, 4.5d), v.y);
                Assert.AreEqual(new Complex(2d, 4.5d), v.z);
                Assert.AreEqual(new Complex(2d, 4.5d), v.w);
                Assert.AreEqual(new Complex(5d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, -9d), new Complex(-7d, 6d), new Complex(5.5d, -7d));
                var v = ov.swizzle.zzzzz;
                Assert.AreEqual(new Complex(5.5d, -7d), v.x);
                Assert.AreEqual(new Complex(5.5d, -7d), v.y);
                Assert.AreEqual(new Complex(5.5d, -7d), v.z);
                Assert.AreEqual(new Complex(5.5d, -7d), v.w);
                Assert.AreEqual(new Complex(5.5d, -7d), v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new cvec3(new Complex(2.5d, 6.5d), new Complex(-6.5d, 7d), new Complex(-7.5d, -9.5d));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(6d, 9.5d), new Complex(-9.5d, 8.5d), new Complex(-5.5d, 2d));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new Complex(6d, 9.5d), v.x);
                Assert.AreEqual(new Complex(6d, 9.5d), v.y);
                Assert.AreEqual(new Complex(6d, 9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(2d, 5d), new Complex(-1.5d, 0.5d), new Complex(6d, 3.5d));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new Complex(2d, 5d), v.x);
                Assert.AreEqual(new Complex(2d, 5d), v.y);
                Assert.AreEqual(new Complex(2d, 5d), v.z);
                Assert.AreEqual(new Complex(2d, 5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -7.5d), new Complex(-5.5d, -3.5d), new Complex(0.0, 4.5d));
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, -6d), new Complex(-9d, 3.5d), new Complex(4.5d, 8.5d));
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(new Complex(7d, -6d), v.x);
                Assert.AreEqual(new Complex(7d, -6d), v.y);
                Assert.AreEqual(new Complex(7d, -6d), v.z);
                Assert.AreEqual(new Complex(7d, -6d), v.w);
                Assert.AreEqual(new Complex(-9d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 8d), new Complex(-4d, 1.0), new Complex(-3.5d, 6d));
                var v = ov.swizzle.rrrrb;
                Assert.AreEqual(new Complex(-1.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.w);
                Assert.AreEqual(new Complex(-3.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -1d), new Complex(1.0, -4.5d), new Complex(-5.5d, 1.5d));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new Complex(-2d, -1d), v.x);
                Assert.AreEqual(new Complex(-2d, -1d), v.y);
                Assert.AreEqual(new Complex(-2d, -1d), v.z);
                Assert.AreEqual(new Complex(1.0, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8d, -5d), new Complex(-2d, -1.5d), new Complex(-6.5d, 0.5d));
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(new Complex(-8d, -5d), v.x);
                Assert.AreEqual(new Complex(-8d, -5d), v.y);
                Assert.AreEqual(new Complex(-8d, -5d), v.z);
                Assert.AreEqual(new Complex(-2d, -1.5d), v.w);
                Assert.AreEqual(new Complex(-8d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -7d), new Complex(-3.5d, 8d), new Complex(2.5d, 6.5d));
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(new Complex(1.5d, -7d), v.x);
                Assert.AreEqual(new Complex(1.5d, -7d), v.y);
                Assert.AreEqual(new Complex(1.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 8d), v.w);
                Assert.AreEqual(new Complex(-3.5d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.0, -0.5d), new Complex(-2.5d, -0.5d), new Complex(7.5d, 7.5d));
                var v = ov.swizzle.rrrgb;
                Assert.AreEqual(new Complex(0.0, -0.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -0.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -0.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -0.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 2.5d), new Complex(-4.5d, -4d), new Complex(3.5d, 8.5d));
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(new Complex(1.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, 5.5d), new Complex(4.5d, 8d), new Complex(0.0, 1.5d));
                var v = ov.swizzle.rrrbr;
                Assert.AreEqual(new Complex(0.0, 5.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 5.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 5.5d), v.z);
                Assert.AreEqual(new Complex(0.0, 1.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, -2d), new Complex(-8d, 4.5d), new Complex(0.0, 5.5d));
                var v = ov.swizzle.rrrbg;
                Assert.AreEqual(new Complex(-3d, -2d), v.x);
                Assert.AreEqual(new Complex(-3d, -2d), v.y);
                Assert.AreEqual(new Complex(-3d, -2d), v.z);
                Assert.AreEqual(new Complex(0.0, 5.5d), v.w);
                Assert.AreEqual(new Complex(-8d, 4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -0.5d), new Complex(2d, 0.0), new Complex(6d, -8.5d));
                var v = ov.swizzle.rrrbb;
                Assert.AreEqual(new Complex(-3.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(6d, -8.5d), v.w);
                Assert.AreEqual(new Complex(6d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 5.5d), new Complex(9d, -0.5d), new Complex(-6d, -0.5d));
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new Complex(6d, 5.5d), v.x);
                Assert.AreEqual(new Complex(6d, 5.5d), v.y);
                Assert.AreEqual(new Complex(9d, -0.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 0.5d), new Complex(9.5d, 1.5d), new Complex(-8d, -5.5d));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 9d), new Complex(3.5d, -8d), new Complex(4.5d, -1.5d));
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(new Complex(-1.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.y);
                Assert.AreEqual(new Complex(3.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -3d), new Complex(1.0, 4d), new Complex(6d, -7.5d));
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(new Complex(8.5d, -3d), v.x);
                Assert.AreEqual(new Complex(8.5d, -3d), v.y);
                Assert.AreEqual(new Complex(1.0, 4d), v.z);
                Assert.AreEqual(new Complex(8.5d, -3d), v.w);
                Assert.AreEqual(new Complex(1.0, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 0.0), new Complex(-5d, -9d), new Complex(-1d, -7d));
                var v = ov.swizzle.rrgrb;
                Assert.AreEqual(new Complex(1.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(1.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-5d, -9d), v.z);
                Assert.AreEqual(new Complex(1.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(-1d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -0.5d), new Complex(-6d, -6.5d), new Complex(4.5d, 0.5d));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new Complex(8.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 5d), new Complex(1.0, -4d), new Complex(0.0, 9.5d));
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(new Complex(1.5d, 5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 5d), v.y);
                Assert.AreEqual(new Complex(1.0, -4d), v.z);
                Assert.AreEqual(new Complex(1.0, -4d), v.w);
                Assert.AreEqual(new Complex(1.5d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, 5.5d), new Complex(6d, -1.5d), new Complex(9.5d, -3d));
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(new Complex(8d, 5.5d), v.x);
                Assert.AreEqual(new Complex(8d, 5.5d), v.y);
                Assert.AreEqual(new Complex(6d, -1.5d), v.z);
                Assert.AreEqual(new Complex(6d, -1.5d), v.w);
                Assert.AreEqual(new Complex(6d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 6.5d), new Complex(6d, -9d), new Complex(-4.5d, -5.5d));
                var v = ov.swizzle.rrggb;
                Assert.AreEqual(new Complex(6d, 6.5d), v.x);
                Assert.AreEqual(new Complex(6d, 6.5d), v.y);
                Assert.AreEqual(new Complex(6d, -9d), v.z);
                Assert.AreEqual(new Complex(6d, -9d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, 5d), new Complex(-5d, 5.5d), new Complex(5.5d, 6d));
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(new Complex(4.5d, 5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, 6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 8d), new Complex(-4.5d, -7.5d), new Complex(9.5d, -5.5d));
                var v = ov.swizzle.rrgbr;
                Assert.AreEqual(new Complex(-4.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -5.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, 8d), new Complex(-1d, -8d), new Complex(1.0, 7.5d));
                var v = ov.swizzle.rrgbg;
                Assert.AreEqual(new Complex(-8d, 8d), v.x);
                Assert.AreEqual(new Complex(-8d, 8d), v.y);
                Assert.AreEqual(new Complex(-1d, -8d), v.z);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.w);
                Assert.AreEqual(new Complex(-1d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 9.5d), new Complex(0.0, -5.5d), new Complex(-3.5d, -7d));
                var v = ov.swizzle.rrgbb;
                Assert.AreEqual(new Complex(6d, 9.5d), v.x);
                Assert.AreEqual(new Complex(6d, 9.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -5.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -7d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -1d), new Complex(-3d, -9.5d), new Complex(4.5d, -2d));
                var v = ov.swizzle.rrb;
                Assert.AreEqual(new Complex(-5d, -1d), v.x);
                Assert.AreEqual(new Complex(-5d, -1d), v.y);
                Assert.AreEqual(new Complex(4.5d, -2d), v.z);
            }
            {
                var ov = new cvec3(new Complex(3d, 6d), new Complex(3.5d, -9d), new Complex(-5.5d, 6d));
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(new Complex(3d, 6d), v.x);
                Assert.AreEqual(new Complex(3d, 6d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 6d), v.z);
                Assert.AreEqual(new Complex(3d, 6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -5d), new Complex(9d, 5.5d), new Complex(-9d, -1.5d));
                var v = ov.swizzle.rrbrr;
                Assert.AreEqual(new Complex(-2.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-9d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -5d), v.w);
                Assert.AreEqual(new Complex(-2.5d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -4d), new Complex(-4d, -6.5d), new Complex(2d, 8d));
                var v = ov.swizzle.rrbrg;
                Assert.AreEqual(new Complex(0.5d, -4d), v.x);
                Assert.AreEqual(new Complex(0.5d, -4d), v.y);
                Assert.AreEqual(new Complex(2d, 8d), v.z);
                Assert.AreEqual(new Complex(0.5d, -4d), v.w);
                Assert.AreEqual(new Complex(-4d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 5d), new Complex(5.5d, -6.5d), new Complex(0.0, -5.5d));
                var v = ov.swizzle.rrbrb;
                Assert.AreEqual(new Complex(6d, 5d), v.x);
                Assert.AreEqual(new Complex(6d, 5d), v.y);
                Assert.AreEqual(new Complex(0.0, -5.5d), v.z);
                Assert.AreEqual(new Complex(6d, 5d), v.w);
                Assert.AreEqual(new Complex(0.0, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, -9.5d), new Complex(7.5d, 9.5d), new Complex(2d, 9.5d));
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(new Complex(5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(2d, 9.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7d, -6d), new Complex(-6.5d, 1.5d), new Complex(3.5d, -1d));
                var v = ov.swizzle.rrbgr;
                Assert.AreEqual(new Complex(-7d, -6d), v.x);
                Assert.AreEqual(new Complex(-7d, -6d), v.y);
                Assert.AreEqual(new Complex(3.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.w);
                Assert.AreEqual(new Complex(-7d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 9.5d), new Complex(4.5d, 3d), new Complex(-8d, -8.5d));
                var v = ov.swizzle.rrbgg;
                Assert.AreEqual(new Complex(2.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-8d, -8.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 3d), v.w);
                Assert.AreEqual(new Complex(4.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -8.5d), new Complex(-4d, 1.0), new Complex(-6d, -6.5d));
                var v = ov.swizzle.rrbgb;
                Assert.AreEqual(new Complex(9.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-4d, 1.0), v.w);
                Assert.AreEqual(new Complex(-6d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 7.5d), new Complex(-3d, 0.5d), new Complex(3d, 8.5d));
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(new Complex(6d, 7.5d), v.x);
                Assert.AreEqual(new Complex(6d, 7.5d), v.y);
                Assert.AreEqual(new Complex(3d, 8.5d), v.z);
                Assert.AreEqual(new Complex(3d, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, -8d), new Complex(1.5d, -1.5d), new Complex(-5d, 6.5d));
                var v = ov.swizzle.rrbbr;
                Assert.AreEqual(new Complex(8d, -8d), v.x);
                Assert.AreEqual(new Complex(8d, -8d), v.y);
                Assert.AreEqual(new Complex(-5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(8d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, -1d), new Complex(-6d, 3.5d), new Complex(-1.5d, 4.5d));
                var v = ov.swizzle.rrbbg;
                Assert.AreEqual(new Complex(8d, -1d), v.x);
                Assert.AreEqual(new Complex(8d, -1d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(-6d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, -2.5d), new Complex(5d, -3.5d), new Complex(-4d, 8d));
                var v = ov.swizzle.rrbbb;
                Assert.AreEqual(new Complex(6d, -2.5d), v.x);
                Assert.AreEqual(new Complex(6d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 8d), v.z);
                Assert.AreEqual(new Complex(-4d, 8d), v.w);
                Assert.AreEqual(new Complex(-4d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 4d), new Complex(-9.5d, -7.5d), new Complex(6.5d, -6.5d));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new Complex(-6d, 4d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(5d, 4.5d), new Complex(3d, -0.5d), new Complex(1.0, -1d));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new Complex(5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(3d, -0.5d), v.y);
                Assert.AreEqual(new Complex(5d, 4.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 6.5d), new Complex(-9d, 1.0), new Complex(-0.5d, 8.5d));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-9d, 1.0), v.y);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 7.5d), new Complex(-2d, -3.5d), new Complex(-3d, -9d));
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -3.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 7.5d), new Complex(0.5d, -6.5d), new Complex(-7d, 3.5d));
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 6d), new Complex(-7.5d, -2d), new Complex(-9d, -6d));
                var v = ov.swizzle.rgrrb;
                Assert.AreEqual(new Complex(3.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -2d), v.y);
                Assert.AreEqual(new Complex(3.5d, 6d), v.z);
                Assert.AreEqual(new Complex(3.5d, 6d), v.w);
                Assert.AreEqual(new Complex(-9d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, -0.5d), new Complex(3d, -3.5d), new Complex(-9.5d, -6d));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new Complex(-6d, -0.5d), v.x);
                Assert.AreEqual(new Complex(3d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -0.5d), v.z);
                Assert.AreEqual(new Complex(3d, -3.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7d, -8.5d), new Complex(-9.5d, -5d), new Complex(7.5d, 5d));
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(new Complex(7d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -5d), v.y);
                Assert.AreEqual(new Complex(7d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -5d), v.w);
                Assert.AreEqual(new Complex(7d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -2.5d), new Complex(-8.5d, 3.5d), new Complex(-7.5d, 5.5d));
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(new Complex(-5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -2d), new Complex(7.5d, 4.5d), new Complex(-9d, -1.5d));
                var v = ov.swizzle.rgrgb;
                Assert.AreEqual(new Complex(-2.5d, -2d), v.x);
                Assert.AreEqual(new Complex(7.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -2d), v.z);
                Assert.AreEqual(new Complex(7.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(-9d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, 0.5d), new Complex(8.5d, 2.5d), new Complex(2.5d, -1d));
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(new Complex(-2d, 0.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 0.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -1d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, 1.5d), new Complex(1.0, 9d), new Complex(3d, 7d));
                var v = ov.swizzle.rgrbr;
                Assert.AreEqual(new Complex(-0.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 9d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(3d, 7d), v.w);
                Assert.AreEqual(new Complex(-0.5d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -2.5d), new Complex(-2.5d, 3d), new Complex(0.5d, -3d));
                var v = ov.swizzle.rgrbg;
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 3d), v.y);
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -3d), v.w);
                Assert.AreEqual(new Complex(-2.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, 8d), new Complex(6d, -6.5d), new Complex(5.5d, 0.0));
                var v = ov.swizzle.rgrbb;
                Assert.AreEqual(new Complex(-7d, 8d), v.x);
                Assert.AreEqual(new Complex(6d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 8d), v.z);
                Assert.AreEqual(new Complex(5.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(5.5d, 0.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -4.5d), new Complex(7d, 9.5d), new Complex(1.0, 1.0));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(7d, 9.5d), v.y);
                Assert.AreEqual(new Complex(7d, 9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -9.5d), new Complex(9d, -8.5d), new Complex(1.0, 2d));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new Complex(1.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(9d, -8.5d), v.y);
                Assert.AreEqual(new Complex(9d, -8.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 3d), new Complex(-6d, 4d), new Complex(4.5d, -8.5d));
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(new Complex(8.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-6d, 4d), v.y);
                Assert.AreEqual(new Complex(-6d, 4d), v.z);
                Assert.AreEqual(new Complex(8.5d, 3d), v.w);
                Assert.AreEqual(new Complex(8.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, -7d), new Complex(0.5d, 8.5d), new Complex(1.0, 8.5d));
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(new Complex(9d, -7d), v.x);
                Assert.AreEqual(new Complex(0.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(9d, -7d), v.w);
                Assert.AreEqual(new Complex(0.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 3.5d), new Complex(7d, -8.5d), new Complex(0.0, 4d));
                var v = ov.swizzle.rggrb;
                Assert.AreEqual(new Complex(3.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(7d, -8.5d), v.y);
                Assert.AreEqual(new Complex(7d, -8.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -8d), new Complex(1.5d, 6d), new Complex(-7.5d, 5.5d));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new Complex(9.5d, -8d), v.x);
                Assert.AreEqual(new Complex(1.5d, 6d), v.y);
                Assert.AreEqual(new Complex(1.5d, 6d), v.z);
                Assert.AreEqual(new Complex(1.5d, 6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9d, -5d), new Complex(5d, -7.5d), new Complex(-8.5d, 7d));
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(new Complex(-9d, -5d), v.x);
                Assert.AreEqual(new Complex(5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(5d, -7.5d), v.w);
                Assert.AreEqual(new Complex(-9d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, 7d), new Complex(-2.5d, 5d), new Complex(-3d, 3.5d));
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(new Complex(-1d, 7d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 5d), v.w);
                Assert.AreEqual(new Complex(-2.5d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 7d), new Complex(9d, 4d), new Complex(-0.5d, -2d));
                var v = ov.swizzle.rgggb;
                Assert.AreEqual(new Complex(-8.5d, 7d), v.x);
                Assert.AreEqual(new Complex(9d, 4d), v.y);
                Assert.AreEqual(new Complex(9d, 4d), v.z);
                Assert.AreEqual(new Complex(9d, 4d), v.w);
                Assert.AreEqual(new Complex(-0.5d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, -5.5d), new Complex(6.5d, -9.5d), new Complex(5.5d, 8d));
                var v = ov.swizzle.rggb;
                Assert.AreEqual(new Complex(-4d, -5.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, 8d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, 3d), new Complex(9.5d, -8.5d), new Complex(7.5d, 2d));
                var v = ov.swizzle.rggbr;
                Assert.AreEqual(new Complex(-0.5d, 3d), v.x);
                Assert.AreEqual(new Complex(9.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 2d), v.w);
                Assert.AreEqual(new Complex(-0.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -6d), new Complex(-8.5d, 6.5d), new Complex(-2d, -4d));
                var v = ov.swizzle.rggbg;
                Assert.AreEqual(new Complex(-4.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-2d, -4d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 1.0), new Complex(-5.5d, 7d), new Complex(-2d, -1d));
                var v = ov.swizzle.rggbb;
                Assert.AreEqual(new Complex(6.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-5.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-2d, -1d), v.w);
                Assert.AreEqual(new Complex(-2d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 0.5d), new Complex(-0.5d, 8d), new Complex(-7.5d, -2.5d));
                var v = ov.swizzle.rgb;
                Assert.AreEqual(new Complex(-8.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 6d), new Complex(2d, -1d), new Complex(7d, 2.5d));
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(new Complex(-4.5d, 6d), v.x);
                Assert.AreEqual(new Complex(2d, -1d), v.y);
                Assert.AreEqual(new Complex(7d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 9d), new Complex(5.5d, 8.5d), new Complex(3.5d, -1.5d));
                var v = ov.swizzle.rgbrr;
                Assert.AreEqual(new Complex(0.5d, 9d), v.x);
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 9d), v.w);
                Assert.AreEqual(new Complex(0.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 0.0), new Complex(7.5d, 8d), new Complex(5.5d, 6.5d));
                var v = ov.swizzle.rgbrg;
                Assert.AreEqual(new Complex(3d, 0.0), v.x);
                Assert.AreEqual(new Complex(7.5d, 8d), v.y);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(3d, 0.0), v.w);
                Assert.AreEqual(new Complex(7.5d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, -5d), new Complex(7.5d, 3.5d), new Complex(0.0, 8.5d));
                var v = ov.swizzle.rgbrb;
                Assert.AreEqual(new Complex(7d, -5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 8.5d), v.z);
                Assert.AreEqual(new Complex(7d, -5d), v.w);
                Assert.AreEqual(new Complex(0.0, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, 0.5d), new Complex(-6d, -5d), new Complex(-8.5d, 3.5d));
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(new Complex(-4d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-6d, -5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 7d), new Complex(-1d, 9d), new Complex(0.0, -4d));
                var v = ov.swizzle.rgbgr;
                Assert.AreEqual(new Complex(-1.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-1d, 9d), v.y);
                Assert.AreEqual(new Complex(0.0, -4d), v.z);
                Assert.AreEqual(new Complex(-1d, 9d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, 0.5d), new Complex(-5.5d, -8d), new Complex(-9d, -4.5d));
                var v = ov.swizzle.rgbgg;
                Assert.AreEqual(new Complex(-2d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-9d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -8d), v.w);
                Assert.AreEqual(new Complex(-5.5d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -3d), new Complex(-8.5d, -4d), new Complex(1.5d, -7d));
                var v = ov.swizzle.rgbgb;
                Assert.AreEqual(new Complex(9.5d, -3d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -4d), v.y);
                Assert.AreEqual(new Complex(1.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -4d), v.w);
                Assert.AreEqual(new Complex(1.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 5.5d), new Complex(8d, -5d), new Complex(-3.5d, -4.5d));
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(new Complex(4d, 5.5d), v.x);
                Assert.AreEqual(new Complex(8d, -5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 1.5d), new Complex(3d, -5d), new Complex(6d, 6.5d));
                var v = ov.swizzle.rgbbr;
                Assert.AreEqual(new Complex(-1.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(3d, -5d), v.y);
                Assert.AreEqual(new Complex(6d, 6.5d), v.z);
                Assert.AreEqual(new Complex(6d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, -6.5d), new Complex(7.5d, -4.5d), new Complex(-7d, -4d));
                var v = ov.swizzle.rgbbg;
                Assert.AreEqual(new Complex(-1d, -6.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -4d), v.z);
                Assert.AreEqual(new Complex(-7d, -4d), v.w);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -9.5d), new Complex(-3.5d, 1.0), new Complex(-5.5d, 3.5d));
                var v = ov.swizzle.rgbbb;
                Assert.AreEqual(new Complex(8.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-5.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 9.5d), new Complex(0.5d, 7.5d), new Complex(-4d, 6d));
                var v = ov.swizzle.rb;
                Assert.AreEqual(new Complex(4d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-4d, 6d), v.y);
            }
            {
                var ov = new cvec3(new Complex(5.5d, -5.5d), new Complex(-1d, -8.5d), new Complex(9.5d, -1d));
                var v = ov.swizzle.rbr;
                Assert.AreEqual(new Complex(5.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -1d), v.y);
                Assert.AreEqual(new Complex(5.5d, -5.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -2d), new Complex(-8.5d, -3.5d), new Complex(1.0, -3.5d));
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(new Complex(9.5d, -2d), v.x);
                Assert.AreEqual(new Complex(1.0, -3.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -2d), v.z);
                Assert.AreEqual(new Complex(9.5d, -2d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 1.0), new Complex(-1d, -6.5d), new Complex(5d, -9.5d));
                var v = ov.swizzle.rbrrr;
                Assert.AreEqual(new Complex(6.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(6.5d, 1.0), v.w);
                Assert.AreEqual(new Complex(6.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -9.5d), new Complex(7d, 1.5d), new Complex(-3d, 5.5d));
                var v = ov.swizzle.rbrrg;
                Assert.AreEqual(new Complex(0.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 5.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -9.5d), v.w);
                Assert.AreEqual(new Complex(7d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, 4.5d), new Complex(8d, 8.5d), new Complex(4d, -1.5d));
                var v = ov.swizzle.rbrrb;
                Assert.AreEqual(new Complex(-1d, 4.5d), v.x);
                Assert.AreEqual(new Complex(4d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-1d, 4.5d), v.w);
                Assert.AreEqual(new Complex(4d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 0.0), new Complex(-4.5d, 4.5d), new Complex(-8.5d, 7.5d));
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(new Complex(3d, 0.0), v.x);
                Assert.AreEqual(new Complex(-8.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(3d, 0.0), v.z);
                Assert.AreEqual(new Complex(-4.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7d, -5d), new Complex(-4.5d, -3d), new Complex(-2.5d, -8.5d));
                var v = ov.swizzle.rbrgr;
                Assert.AreEqual(new Complex(-7d, -5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -3d), v.w);
                Assert.AreEqual(new Complex(-7d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, 1.0), new Complex(-5d, 9d), new Complex(3.5d, 2.5d));
                var v = ov.swizzle.rbrgg;
                Assert.AreEqual(new Complex(7d, 1.0), v.x);
                Assert.AreEqual(new Complex(3.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(7d, 1.0), v.z);
                Assert.AreEqual(new Complex(-5d, 9d), v.w);
                Assert.AreEqual(new Complex(-5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 7.5d), new Complex(6.5d, 2.5d), new Complex(0.0, 6d));
                var v = ov.swizzle.rbrgb;
                Assert.AreEqual(new Complex(-1.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 6d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -4.5d), new Complex(-6d, 9d), new Complex(0.5d, -4d));
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(new Complex(-5.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 0.0), new Complex(-6.5d, 6d), new Complex(-9.5d, -3d));
                var v = ov.swizzle.rbrbr;
                Assert.AreEqual(new Complex(7.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-9.5d, -3d), v.y);
                Assert.AreEqual(new Complex(7.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(-9.5d, -3d), v.w);
                Assert.AreEqual(new Complex(7.5d, 0.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 7d), new Complex(-7d, 6d), new Complex(-3d, 5.5d));
                var v = ov.swizzle.rbrbg;
                Assert.AreEqual(new Complex(-2.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-3d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-3d, 5.5d), v.w);
                Assert.AreEqual(new Complex(-7d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -4d), Complex.One, new Complex(9.5d, -2.5d));
                var v = ov.swizzle.rbrbb;
                Assert.AreEqual(new Complex(-9.5d, -4d), v.x);
                Assert.AreEqual(new Complex(9.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -4d), v.z);
                Assert.AreEqual(new Complex(9.5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(9.5d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -0.5d), new Complex(8d, 3.5d), new Complex(7.5d, 2.5d));
                var v = ov.swizzle.rbg;
                Assert.AreEqual(new Complex(-0.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(8d, 3.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 2d), new Complex(8.5d, -2d), new Complex(5.5d, -6.5d));
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(new Complex(-8.5d, 2d), v.x);
                Assert.AreEqual(new Complex(5.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 2d), v.w);
            }
            {
                var ov = new cvec3(new Complex(4.5d, 1.0), new Complex(9.5d, -1.5d), new Complex(-1.5d, -5.5d));
                var v = ov.swizzle.rbgrr;
                Assert.AreEqual(new Complex(4.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-1.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 1.0), v.w);
                Assert.AreEqual(new Complex(4.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -6.5d), new Complex(5.5d, -7d), new Complex(0.0, 5d));
                var v = ov.swizzle.rbgrg;
                Assert.AreEqual(new Complex(-2d, -6.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-2d, -6.5d), v.w);
                Assert.AreEqual(new Complex(5.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, 4.5d), new Complex(-1.5d, -5.5d), new Complex(5d, -6.5d));
                var v = ov.swizzle.rbgrb;
                Assert.AreEqual(new Complex(2d, 4.5d), v.x);
                Assert.AreEqual(new Complex(5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(2d, 4.5d), v.w);
                Assert.AreEqual(new Complex(5d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -4.5d), new Complex(-1.5d, -9.5d), new Complex(6.5d, -2d));
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5d, -7d), new Complex(-1d, -2d), new Complex(-5.5d, 4.5d));
                var v = ov.swizzle.rbggr;
                Assert.AreEqual(new Complex(5d, -7d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -2d), v.z);
                Assert.AreEqual(new Complex(-1d, -2d), v.w);
                Assert.AreEqual(new Complex(5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, -8d), new Complex(-2d, -5d), new Complex(5.5d, -3d));
                var v = ov.swizzle.rbggg;
                Assert.AreEqual(new Complex(1.0, -8d), v.x);
                Assert.AreEqual(new Complex(5.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-2d, -5d), v.z);
                Assert.AreEqual(new Complex(-2d, -5d), v.w);
                Assert.AreEqual(new Complex(-2d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 6d), new Complex(3.5d, -9d), new Complex(-4.5d, -4.5d));
                var v = ov.swizzle.rbggb;
                Assert.AreEqual(new Complex(-6d, 6d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -9d), v.z);
                Assert.AreEqual(new Complex(3.5d, -9d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -6.5d), new Complex(-5.5d, -2.5d), new Complex(2.5d, 2.5d));
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(new Complex(3.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 3.5d), new Complex(-6.5d, -2.5d), new Complex(-4.5d, 2.5d));
                var v = ov.swizzle.rbgbr;
                Assert.AreEqual(new Complex(1.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 9d), new Complex(-2.5d, -3.5d), new Complex(-6d, -7d));
                var v = ov.swizzle.rbgbg;
                Assert.AreEqual(new Complex(-7.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-6d, -7d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -7d), v.w);
                Assert.AreEqual(new Complex(-2.5d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -0.5d), new Complex(-3.5d, 8.5d), new Complex(-6d, 7.5d));
                var v = ov.swizzle.rbgbb;
                Assert.AreEqual(new Complex(-0.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-6d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-6d, 7.5d), v.w);
                Assert.AreEqual(new Complex(-6d, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 8d), new Complex(4.5d, 6.5d), new Complex(7.5d, 4d));
                var v = ov.swizzle.rbb;
                Assert.AreEqual(new Complex(8.5d, 8d), v.x);
                Assert.AreEqual(new Complex(7.5d, 4d), v.y);
                Assert.AreEqual(new Complex(7.5d, 4d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-2d, -7.5d), new Complex(-2d, 9.5d), new Complex(-9.5d, 3.5d));
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(new Complex(-2d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-2d, -7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 6d), new Complex(4.5d, 4d), new Complex(4.5d, -7.5d));
                var v = ov.swizzle.rbbrr;
                Assert.AreEqual(new Complex(0.5d, 6d), v.x);
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 6d), v.w);
                Assert.AreEqual(new Complex(0.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, -2.5d), new Complex(0.0, -8.5d), new Complex(-1.5d, -3.5d));
                var v = ov.swizzle.rbbrg;
                Assert.AreEqual(new Complex(-4d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -2.5d), v.w);
                Assert.AreEqual(new Complex(0.0, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, -6.5d), new Complex(-4d, 4.5d), new Complex(-0.5d, -2.5d));
                var v = ov.swizzle.rbbrb;
                Assert.AreEqual(new Complex(-7d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-7d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-0.5d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, 1.5d), new Complex(-1.5d, 9d), new Complex(7.5d, -9d));
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(new Complex(-5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -9d), v.y);
                Assert.AreEqual(new Complex(7.5d, -9d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2d, -7d), new Complex(4d, 4.5d), new Complex(4d, 0.5d));
                var v = ov.swizzle.rbbgr;
                Assert.AreEqual(new Complex(2d, -7d), v.x);
                Assert.AreEqual(new Complex(4d, 0.5d), v.y);
                Assert.AreEqual(new Complex(4d, 0.5d), v.z);
                Assert.AreEqual(new Complex(4d, 4.5d), v.w);
                Assert.AreEqual(new Complex(2d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, 5.5d), new Complex(0.0, -7d), new Complex(-5d, 8.5d));
                var v = ov.swizzle.rbbgg;
                Assert.AreEqual(new Complex(9d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(0.0, -7d), v.w);
                Assert.AreEqual(new Complex(0.0, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5.5d, 2.5d), new Complex(-9.5d, 0.5d), new Complex(-2d, -1.5d));
                var v = ov.swizzle.rbbgb;
                Assert.AreEqual(new Complex(5.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-2d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -3d), new Complex(-8.5d, -5.5d), new Complex(0.0, 6.5d));
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(new Complex(-5d, -3d), v.x);
                Assert.AreEqual(new Complex(0.0, 6.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 6.5d), v.z);
                Assert.AreEqual(new Complex(0.0, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 6d), new Complex(6.5d, 6.5d), new Complex(1.0, -9.5d));
                var v = ov.swizzle.rbbbr;
                Assert.AreEqual(new Complex(0.5d, 6d), v.x);
                Assert.AreEqual(new Complex(1.0, -9.5d), v.y);
                Assert.AreEqual(new Complex(1.0, -9.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -9.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -2d), new Complex(7d, 7d), new Complex(-6d, -6d));
                var v = ov.swizzle.rbbbg;
                Assert.AreEqual(new Complex(-9.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-6d, -6d), v.y);
                Assert.AreEqual(new Complex(-6d, -6d), v.z);
                Assert.AreEqual(new Complex(-6d, -6d), v.w);
                Assert.AreEqual(new Complex(7d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 0.5d), new Complex(-0.5d, 5.5d), new Complex(9.5d, -5d));
                var v = ov.swizzle.rbbbb;
                Assert.AreEqual(new Complex(-2.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -5d), v.w);
                Assert.AreEqual(new Complex(9.5d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -8d), new Complex(-4.5d, 9.5d), new Complex(9.5d, -5d));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new Complex(-4.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -8d), v.y);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 2d), new Complex(-9d, 3.5d), new Complex(-5.5d, 4d));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new Complex(-9d, 3.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 2d), v.y);
                Assert.AreEqual(new Complex(1.5d, 2d), v.z);
            }
            {
                var ov = new cvec3(new Complex(4d, 4d), new Complex(-5d, 7d), new Complex(8d, 0.5d));
                var v = ov.swizzle.grrr;
                Assert.AreEqual(new Complex(-5d, 7d), v.x);
                Assert.AreEqual(new Complex(4d, 4d), v.y);
                Assert.AreEqual(new Complex(4d, 4d), v.z);
                Assert.AreEqual(new Complex(4d, 4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 5d), new Complex(6d, -7d), new Complex(9.5d, -7d));
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(new Complex(6d, -7d), v.x);
                Assert.AreEqual(new Complex(6.5d, 5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 5d), v.w);
                Assert.AreEqual(new Complex(6.5d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, 7.5d), new Complex(-2.5d, 9d), new Complex(-7.5d, 1.0));
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(new Complex(-2.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-8d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-8d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 7.5d), v.w);
                Assert.AreEqual(new Complex(-2.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, 4d), new Complex(-1.5d, -2d), new Complex(4.5d, -8d));
                var v = ov.swizzle.grrrb;
                Assert.AreEqual(new Complex(-1.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-2d, 4d), v.y);
                Assert.AreEqual(new Complex(-2d, 4d), v.z);
                Assert.AreEqual(new Complex(-2d, 4d), v.w);
                Assert.AreEqual(new Complex(4.5d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 3d), new Complex(-6d, 0.5d), new Complex(2.5d, 8d));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new Complex(-6d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-6d, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, 2d), new Complex(-5d, 1.5d), new Complex(-3d, -8d));
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(new Complex(-5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(8d, 2d), v.y);
                Assert.AreEqual(new Complex(8d, 2d), v.z);
                Assert.AreEqual(new Complex(-5d, 1.5d), v.w);
                Assert.AreEqual(new Complex(8d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -5.5d), new Complex(-5.5d, -8.5d), new Complex(3d, -5.5d));
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 3d), new Complex(7.5d, -1d), new Complex(6d, -4.5d));
                var v = ov.swizzle.grrgb;
                Assert.AreEqual(new Complex(7.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 3d), v.z);
                Assert.AreEqual(new Complex(7.5d, -1d), v.w);
                Assert.AreEqual(new Complex(6d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, 8d), new Complex(-1.5d, 0.0), new Complex(8.5d, -4d));
                var v = ov.swizzle.grrb;
                Assert.AreEqual(new Complex(-1.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-4d, 8d), v.y);
                Assert.AreEqual(new Complex(-4d, 8d), v.z);
                Assert.AreEqual(new Complex(8.5d, -4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 3d), new Complex(-2.5d, 9.5d), new Complex(-9d, 5.5d));
                var v = ov.swizzle.grrbr;
                Assert.AreEqual(new Complex(-2.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 3d), v.y);
                Assert.AreEqual(new Complex(8.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-9d, 5.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, -6d), new Complex(-9d, 2.5d), new Complex(-8.5d, -6.5d));
                var v = ov.swizzle.grrbg;
                Assert.AreEqual(new Complex(-9d, 2.5d), v.x);
                Assert.AreEqual(new Complex(5d, -6d), v.y);
                Assert.AreEqual(new Complex(5d, -6d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-9d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 4.5d), new Complex(1.5d, -3.5d), new Complex(5d, -8.5d));
                var v = ov.swizzle.grrbb;
                Assert.AreEqual(new Complex(1.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(5d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, 5.5d), new Complex(-9d, 7d), new Complex(-5d, 5d));
                var v = ov.swizzle.grg;
                Assert.AreEqual(new Complex(-9d, 7d), v.x);
                Assert.AreEqual(new Complex(2d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 7d), v.z);
            }
            {
                var ov = new cvec3(new Complex(1.0, -9d), new Complex(-2d, 6d), new Complex(9d, -4.5d));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new Complex(-2d, 6d), v.x);
                Assert.AreEqual(new Complex(1.0, -9d), v.y);
                Assert.AreEqual(new Complex(-2d, 6d), v.z);
                Assert.AreEqual(new Complex(1.0, -9d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -9d), new Complex(8d, 5d), new Complex(-9d, 6.5d));
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(new Complex(8d, 5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -9d), v.y);
                Assert.AreEqual(new Complex(8d, 5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -9d), v.w);
                Assert.AreEqual(new Complex(-9.5d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 8.5d), new Complex(5d, -4.5d), new Complex(-4d, 3d));
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(new Complex(5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, 3d), new Complex(6d, -3d), new Complex(-1d, 5d));
                var v = ov.swizzle.grgrb;
                Assert.AreEqual(new Complex(6d, -3d), v.x);
                Assert.AreEqual(new Complex(7d, 3d), v.y);
                Assert.AreEqual(new Complex(6d, -3d), v.z);
                Assert.AreEqual(new Complex(7d, 3d), v.w);
                Assert.AreEqual(new Complex(-1d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 4.5d), new Complex(7.5d, -9d), new Complex(5.5d, -3d));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new Complex(7.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, -9d), v.z);
                Assert.AreEqual(new Complex(7.5d, -9d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -8d), new Complex(-8d, 0.0), new Complex(-7d, 6.5d));
                var v = ov.swizzle.grggr;
                Assert.AreEqual(new Complex(-8d, 0.0), v.x);
                Assert.AreEqual(new Complex(-9.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-8d, 0.0), v.z);
                Assert.AreEqual(new Complex(-8d, 0.0), v.w);
                Assert.AreEqual(new Complex(-9.5d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, 3d), new Complex(-7.5d, 4.5d), new Complex(-9d, -6d));
                var v = ov.swizzle.grggg;
                Assert.AreEqual(new Complex(-7.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(2d, 3d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(-7.5d, 4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, 0.0), new Complex(-9.5d, 4.5d), new Complex(9.5d, 9d));
                var v = ov.swizzle.grggb;
                Assert.AreEqual(new Complex(-9.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 0.0), v.y);
                Assert.AreEqual(new Complex(-9.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(9.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, 4d), new Complex(5d, -2.5d), new Complex(8d, -7d));
                var v = ov.swizzle.grgb;
                Assert.AreEqual(new Complex(5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(2d, 4d), v.y);
                Assert.AreEqual(new Complex(5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(8d, -7d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3d, 2.5d), new Complex(0.5d, 8d), new Complex(-4.5d, 4d));
                var v = ov.swizzle.grgbr;
                Assert.AreEqual(new Complex(0.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-3d, 2.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 4d), v.w);
                Assert.AreEqual(new Complex(-3d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -3.5d), new Complex(5d, 5d), new Complex(6.5d, -5.5d));
                var v = ov.swizzle.grgbg;
                Assert.AreEqual(new Complex(5d, 5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(5d, 5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -5.5d), v.w);
                Assert.AreEqual(new Complex(5d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -2d), new Complex(2.5d, 2d), new Complex(-3d, -2d));
                var v = ov.swizzle.grgbb;
                Assert.AreEqual(new Complex(2.5d, 2d), v.x);
                Assert.AreEqual(new Complex(8.5d, -2d), v.y);
                Assert.AreEqual(new Complex(2.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-3d, -2d), v.w);
                Assert.AreEqual(new Complex(-3d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 9.5d), new Complex(6d, -6.5d), new Complex(-0.5d, 3d));
                var v = ov.swizzle.grb;
                Assert.AreEqual(new Complex(6d, -6.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 3d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -1.5d), new Complex(2.5d, -1d), new Complex(-7.5d, -4d));
                var v = ov.swizzle.grbr;
                Assert.AreEqual(new Complex(2.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -4d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 8d), new Complex(0.5d, 7.5d), new Complex(-8.5d, -4.5d));
                var v = ov.swizzle.grbrr;
                Assert.AreEqual(new Complex(0.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 8d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, -2.5d), new Complex(-9d, -8.5d), new Complex(-7.5d, -4d));
                var v = ov.swizzle.grbrg;
                Assert.AreEqual(new Complex(-9d, -8.5d), v.x);
                Assert.AreEqual(new Complex(8d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -4d), v.z);
                Assert.AreEqual(new Complex(8d, -2.5d), v.w);
                Assert.AreEqual(new Complex(-9d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 9d), new Complex(-2d, -5d), new Complex(-4d, -6.5d));
                var v = ov.swizzle.grbrb;
                Assert.AreEqual(new Complex(-2d, -5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-4d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 9d), v.w);
                Assert.AreEqual(new Complex(-4d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -5.5d), new Complex(0.0, -0.5d), new Complex(6.5d, -3d));
                var v = ov.swizzle.grbg;
                Assert.AreEqual(new Complex(0.0, -0.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -3d), v.z);
                Assert.AreEqual(new Complex(0.0, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5.5d, 0.5d), new Complex(0.0, -7d), new Complex(1.5d, -3d));
                var v = ov.swizzle.grbgr;
                Assert.AreEqual(new Complex(0.0, -7d), v.x);
                Assert.AreEqual(new Complex(5.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -3d), v.z);
                Assert.AreEqual(new Complex(0.0, -7d), v.w);
                Assert.AreEqual(new Complex(5.5d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, -5d), new Complex(-8d, -3d), new Complex(2d, -6d));
                var v = ov.swizzle.grbgg;
                Assert.AreEqual(new Complex(-8d, -3d), v.x);
                Assert.AreEqual(new Complex(-1d, -5d), v.y);
                Assert.AreEqual(new Complex(2d, -6d), v.z);
                Assert.AreEqual(new Complex(-8d, -3d), v.w);
                Assert.AreEqual(new Complex(-8d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, -7d), new Complex(8d, 3d), new Complex(-6d, -7d));
                var v = ov.swizzle.grbgb;
                Assert.AreEqual(new Complex(8d, 3d), v.x);
                Assert.AreEqual(new Complex(-1d, -7d), v.y);
                Assert.AreEqual(new Complex(-6d, -7d), v.z);
                Assert.AreEqual(new Complex(8d, 3d), v.w);
                Assert.AreEqual(new Complex(-6d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 9.5d), new Complex(-8.5d, -8d), new Complex(1.0, 4d));
                var v = ov.swizzle.grbb;
                Assert.AreEqual(new Complex(-8.5d, -8d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 4d), v.z);
                Assert.AreEqual(new Complex(1.0, 4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4d, -7.5d), new Complex(-1.5d, -7.5d), new Complex(5d, -4d));
                var v = ov.swizzle.grbbr;
                Assert.AreEqual(new Complex(-1.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-4d, -7.5d), v.y);
                Assert.AreEqual(new Complex(5d, -4d), v.z);
                Assert.AreEqual(new Complex(5d, -4d), v.w);
                Assert.AreEqual(new Complex(-4d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 9.5d), new Complex(-3.5d, -9d), new Complex(-1d, -6d));
                var v = ov.swizzle.grbbg;
                Assert.AreEqual(new Complex(-3.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -6d), v.z);
                Assert.AreEqual(new Complex(-1d, -6d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 2.5d), new Complex(-5d, -5d), new Complex(0.5d, -5.5d));
                var v = ov.swizzle.grbbb;
                Assert.AreEqual(new Complex(-5d, -5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 1.0), new Complex(-6d, 2.5d), new Complex(-0.5d, 6.5d));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new Complex(-6d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-6d, 2.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(-8d, -6.5d), new Complex(3.5d, -7d), new Complex(-2.5d, 5d));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new Complex(3.5d, -7d), v.x);
                Assert.AreEqual(new Complex(3.5d, -7d), v.y);
                Assert.AreEqual(new Complex(-8d, -6.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 2d), new Complex(-2.5d, -6.5d), new Complex(-8d, 1.5d));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new Complex(-2.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 2d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1d, -9d), new Complex(8.5d, 2d), new Complex(4d, -4d));
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(new Complex(8.5d, 2d), v.x);
                Assert.AreEqual(new Complex(8.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-1d, -9d), v.z);
                Assert.AreEqual(new Complex(-1d, -9d), v.w);
                Assert.AreEqual(new Complex(-1d, -9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.0, 8d), new Complex(2d, -9.5d), new Complex(1.5d, -5.5d));
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(new Complex(2d, -9.5d), v.x);
                Assert.AreEqual(new Complex(2d, -9.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 8d), v.z);
                Assert.AreEqual(new Complex(0.0, 8d), v.w);
                Assert.AreEqual(new Complex(2d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 8.5d), new Complex(-6.5d, -6.5d), new Complex(-0.5d, 9d));
                var v = ov.swizzle.ggrrb;
                Assert.AreEqual(new Complex(-6.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(-0.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -3.5d), new Complex(-7d, 8d), new Complex(-5.5d, 4d));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new Complex(-7d, 8d), v.x);
                Assert.AreEqual(new Complex(-7d, 8d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 8d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5d, 5.5d), new Complex(6.5d, 9d), new Complex(9d, -8d));
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(new Complex(6.5d, 9d), v.x);
                Assert.AreEqual(new Complex(6.5d, 9d), v.y);
                Assert.AreEqual(new Complex(5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 9d), v.w);
                Assert.AreEqual(new Complex(5d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -8d), new Complex(5.5d, 5d), new Complex(0.5d, 8.5d));
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(new Complex(5.5d, 5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -8d), v.z);
                Assert.AreEqual(new Complex(5.5d, 5d), v.w);
                Assert.AreEqual(new Complex(5.5d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 8.5d), new Complex(3d, 8d), new Complex(-4.5d, 6.5d));
                var v = ov.swizzle.ggrgb;
                Assert.AreEqual(new Complex(3d, 8d), v.x);
                Assert.AreEqual(new Complex(3d, 8d), v.y);
                Assert.AreEqual(new Complex(-6d, 8.5d), v.z);
                Assert.AreEqual(new Complex(3d, 8d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 5d), new Complex(9.5d, 2.5d), new Complex(-3.5d, -5d));
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(new Complex(9.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(3d, 5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5d, -2.5d), new Complex(8.5d, -0.5d), new Complex(-5.5d, -4.5d));
                var v = ov.swizzle.ggrbr;
                Assert.AreEqual(new Complex(8.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -4.5d), v.w);
                Assert.AreEqual(new Complex(5d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, -5d), new Complex(2.5d, 1.5d), new Complex(-5.5d, 5.5d));
                var v = ov.swizzle.ggrbg;
                Assert.AreEqual(new Complex(2.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(1.0, -5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.w);
                Assert.AreEqual(new Complex(2.5d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, -1d), new Complex(-5.5d, -5d), new Complex(-8.5d, -8.5d));
                var v = ov.swizzle.ggrbb;
                Assert.AreEqual(new Complex(-5.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-6d, -1d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, -4.5d), new Complex(-8d, -8d), new Complex(-6.5d, -6d));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new Complex(-8d, -8d), v.x);
                Assert.AreEqual(new Complex(-8d, -8d), v.y);
                Assert.AreEqual(new Complex(-8d, -8d), v.z);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 1.5d), new Complex(-4d, -1d), new Complex(-3.5d, 0.0));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new Complex(-4d, -1d), v.x);
                Assert.AreEqual(new Complex(-4d, -1d), v.y);
                Assert.AreEqual(new Complex(-4d, -1d), v.z);
                Assert.AreEqual(new Complex(6.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4d, -0.5d), new Complex(0.0, 8.5d), new Complex(2d, 4.5d));
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(new Complex(0.0, 8.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 8.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 8.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -0.5d), v.w);
                Assert.AreEqual(new Complex(-4d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 5d), new Complex(2d, 4d), new Complex(8.5d, 5d));
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(new Complex(2d, 4d), v.x);
                Assert.AreEqual(new Complex(2d, 4d), v.y);
                Assert.AreEqual(new Complex(2d, 4d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 5d), v.w);
                Assert.AreEqual(new Complex(2d, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, -8d), new Complex(1.5d, 3d), new Complex(-9.5d, -7.5d));
                var v = ov.swizzle.gggrb;
                Assert.AreEqual(new Complex(1.5d, 3d), v.x);
                Assert.AreEqual(new Complex(1.5d, 3d), v.y);
                Assert.AreEqual(new Complex(1.5d, 3d), v.z);
                Assert.AreEqual(new Complex(6d, -8d), v.w);
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -6d), new Complex(8.5d, 5d), new Complex(8.5d, -2d));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new Complex(8.5d, 5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 6d), new Complex(-1d, 2d), new Complex(-5.5d, -3d));
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(new Complex(-1d, 2d), v.x);
                Assert.AreEqual(new Complex(-1d, 2d), v.y);
                Assert.AreEqual(new Complex(-1d, 2d), v.z);
                Assert.AreEqual(new Complex(-1d, 2d), v.w);
                Assert.AreEqual(new Complex(6.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 5.5d), new Complex(7d, -2d), new Complex(8.5d, -1d));
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(new Complex(7d, -2d), v.x);
                Assert.AreEqual(new Complex(7d, -2d), v.y);
                Assert.AreEqual(new Complex(7d, -2d), v.z);
                Assert.AreEqual(new Complex(7d, -2d), v.w);
                Assert.AreEqual(new Complex(7d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, 9.5d), new Complex(4.5d, -7.5d), new Complex(3d, 0.5d));
                var v = ov.swizzle.ggggb;
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.w);
                Assert.AreEqual(new Complex(3d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 7.5d), new Complex(-9.5d, -7.5d), new Complex(0.5d, 1.5d));
                var v = ov.swizzle.gggb;
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(4d, -3d), new Complex(-1d, -4d), new Complex(2.5d, 4.5d));
                var v = ov.swizzle.gggbr;
                Assert.AreEqual(new Complex(-1d, -4d), v.x);
                Assert.AreEqual(new Complex(-1d, -4d), v.y);
                Assert.AreEqual(new Complex(-1d, -4d), v.z);
                Assert.AreEqual(new Complex(2.5d, 4.5d), v.w);
                Assert.AreEqual(new Complex(4d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, -8.5d), new Complex(8d, -1d), new Complex(-8d, -0.5d));
                var v = ov.swizzle.gggbg;
                Assert.AreEqual(new Complex(8d, -1d), v.x);
                Assert.AreEqual(new Complex(8d, -1d), v.y);
                Assert.AreEqual(new Complex(8d, -1d), v.z);
                Assert.AreEqual(new Complex(-8d, -0.5d), v.w);
                Assert.AreEqual(new Complex(8d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 2d), new Complex(-6.5d, -3.5d), new Complex(-8.5d, 2.5d));
                var v = ov.swizzle.gggbb;
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 5.5d), new Complex(2d, 7d), new Complex(2d, 7d));
                var v = ov.swizzle.ggb;
                Assert.AreEqual(new Complex(2d, 7d), v.x);
                Assert.AreEqual(new Complex(2d, 7d), v.y);
                Assert.AreEqual(new Complex(2d, 7d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 0.0), new Complex(-8.5d, 9.5d), new Complex(7.5d, -4.5d));
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(new Complex(-8.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 8d), new Complex(9.5d, 9d), new Complex(7d, -6.5d));
                var v = ov.swizzle.ggbrr;
                Assert.AreEqual(new Complex(9.5d, 9d), v.x);
                Assert.AreEqual(new Complex(9.5d, 9d), v.y);
                Assert.AreEqual(new Complex(7d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 0.0), new Complex(-8.5d, 8.5d), new Complex(4.5d, -4.5d));
                var v = ov.swizzle.ggbrg;
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(4d, 0.0), v.w);
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -6.5d), new Complex(-9.5d, 3d), new Complex(-4d, 9d));
                var v = ov.swizzle.ggbrb;
                Assert.AreEqual(new Complex(-9.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-4d, 9d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-4d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 8d), new Complex(4d, -2.5d), new Complex(-1d, 4d));
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(new Complex(4d, -2.5d), v.x);
                Assert.AreEqual(new Complex(4d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 4d), v.z);
                Assert.AreEqual(new Complex(4d, -2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 5d), new Complex(-8d, 0.5d), new Complex(-9d, -1.5d));
                var v = ov.swizzle.ggbgr;
                Assert.AreEqual(new Complex(-8d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-8d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-9d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 8d), new Complex(6d, 0.5d), new Complex(-8.5d, -6d));
                var v = ov.swizzle.ggbgg;
                Assert.AreEqual(new Complex(6d, 0.5d), v.x);
                Assert.AreEqual(new Complex(6d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -6d), v.z);
                Assert.AreEqual(new Complex(6d, 0.5d), v.w);
                Assert.AreEqual(new Complex(6d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, 2d), new Complex(-7d, 1.5d), new Complex(1.5d, 0.5d));
                var v = ov.swizzle.ggbgb;
                Assert.AreEqual(new Complex(-7d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-7d, 1.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 1.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, 8d), new Complex(3d, 4.5d), new Complex(-7.5d, 1.5d));
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(new Complex(3d, 4.5d), v.x);
                Assert.AreEqual(new Complex(3d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.0, 0.5d), new Complex(3.5d, -3d), new Complex(-5d, -7d));
                var v = ov.swizzle.ggbbr;
                Assert.AreEqual(new Complex(3.5d, -3d), v.x);
                Assert.AreEqual(new Complex(3.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-5d, -7d), v.z);
                Assert.AreEqual(new Complex(-5d, -7d), v.w);
                Assert.AreEqual(new Complex(1.0, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, -7d), new Complex(1.5d, 9d), new Complex(7d, 3.5d));
                var v = ov.swizzle.ggbbg;
                Assert.AreEqual(new Complex(1.5d, 9d), v.x);
                Assert.AreEqual(new Complex(1.5d, 9d), v.y);
                Assert.AreEqual(new Complex(7d, 3.5d), v.z);
                Assert.AreEqual(new Complex(7d, 3.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 2d), new Complex(9d, 3.5d), new Complex(-3.5d, -2d));
                var v = ov.swizzle.ggbbb;
                Assert.AreEqual(new Complex(9d, 3.5d), v.x);
                Assert.AreEqual(new Complex(9d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -2d), v.w);
                Assert.AreEqual(new Complex(-3.5d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.0, -6.5d), new Complex(0.5d, 0.5d), new Complex(5.5d, -3d));
                var v = ov.swizzle.gb;
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -3d), v.y);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 6d), new Complex(2d, 5.5d), new Complex(8.5d, -6.5d));
                var v = ov.swizzle.gbr;
                Assert.AreEqual(new Complex(2d, 5.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 6d), v.z);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 5d), new Complex(-8d, -0.5d), new Complex(1.5d, -1d));
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(new Complex(-8d, -0.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -1d), v.y);
                Assert.AreEqual(new Complex(6.5d, 5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9d, -6.5d), new Complex(5d, -3d), new Complex(3d, -8.5d));
                var v = ov.swizzle.gbrrr;
                Assert.AreEqual(new Complex(5d, -3d), v.x);
                Assert.AreEqual(new Complex(3d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-9d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-9d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-9d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, -6.5d), new Complex(1.0, 5.5d), new Complex(4d, 4.5d));
                var v = ov.swizzle.gbrrg;
                Assert.AreEqual(new Complex(1.0, 5.5d), v.x);
                Assert.AreEqual(new Complex(4d, 4.5d), v.y);
                Assert.AreEqual(new Complex(7d, -6.5d), v.z);
                Assert.AreEqual(new Complex(7d, -6.5d), v.w);
                Assert.AreEqual(new Complex(1.0, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, 2d), new Complex(-6.5d, -2.5d), new Complex(5.5d, -7d));
                var v = ov.swizzle.gbrrb;
                Assert.AreEqual(new Complex(-6.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -7d), v.y);
                Assert.AreEqual(new Complex(2d, 2d), v.z);
                Assert.AreEqual(new Complex(2d, 2d), v.w);
                Assert.AreEqual(new Complex(5.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 2.5d), new Complex(9d, 5.5d), new Complex(4d, 6d));
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(new Complex(9d, 5.5d), v.x);
                Assert.AreEqual(new Complex(4d, 6d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(9d, 5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5d, 2.5d), new Complex(-7.5d, 7.5d), new Complex(5.5d, -4d));
                var v = ov.swizzle.gbrgr;
                Assert.AreEqual(new Complex(-7.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -4d), v.y);
                Assert.AreEqual(new Complex(5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 7.5d), v.w);
                Assert.AreEqual(new Complex(5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 2.5d), new Complex(2d, 7d), new Complex(-1.5d, -3.5d));
                var v = ov.swizzle.gbrgg;
                Assert.AreEqual(new Complex(2d, 7d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(2d, 7d), v.w);
                Assert.AreEqual(new Complex(2d, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, 6d), new Complex(9d, 3d), new Complex(-1.5d, 3.5d));
                var v = ov.swizzle.gbrgb;
                Assert.AreEqual(new Complex(9d, 3d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 6d), v.z);
                Assert.AreEqual(new Complex(9d, 3d), v.w);
                Assert.AreEqual(new Complex(-1.5d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, -5d), new Complex(-6d, 4d), new Complex(4.5d, 4.5d));
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(new Complex(-6d, 4d), v.x);
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(5d, -5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 3.5d), new Complex(-5.5d, -9.5d), new Complex(-2.5d, 9.5d));
                var v = ov.swizzle.gbrbr;
                Assert.AreEqual(new Complex(-5.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 9.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -6d), new Complex(-3.5d, 1.0), new Complex(3d, 2.5d));
                var v = ov.swizzle.gbrbg;
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(3d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -6d), v.z);
                Assert.AreEqual(new Complex(3d, 2.5d), v.w);
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 3.5d), new Complex(-6d, 6.5d), new Complex(9.5d, 1.0));
                var v = ov.swizzle.gbrbb;
                Assert.AreEqual(new Complex(-6d, 6.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, 1.0), v.w);
                Assert.AreEqual(new Complex(9.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.0, -8d), new Complex(-3.5d, -3.5d), new Complex(8.5d, -7.5d));
                var v = ov.swizzle.gbg;
                Assert.AreEqual(new Complex(-3.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -3.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-9d, 7d), new Complex(4.5d, 7d), new Complex(1.5d, -6d));
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(new Complex(4.5d, 7d), v.x);
                Assert.AreEqual(new Complex(1.5d, -6d), v.y);
                Assert.AreEqual(new Complex(4.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-9d, 7d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9d, -8.5d), new Complex(-5d, -3d), new Complex(7d, -9.5d));
                var v = ov.swizzle.gbgrr;
                Assert.AreEqual(new Complex(-5d, -3d), v.x);
                Assert.AreEqual(new Complex(7d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-5d, -3d), v.z);
                Assert.AreEqual(new Complex(9d, -8.5d), v.w);
                Assert.AreEqual(new Complex(9d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, -6d), new Complex(0.0, 7d), new Complex(9.5d, 7.5d));
                var v = ov.swizzle.gbgrg;
                Assert.AreEqual(new Complex(0.0, 7d), v.x);
                Assert.AreEqual(new Complex(9.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 7d), v.z);
                Assert.AreEqual(new Complex(-3d, -6d), v.w);
                Assert.AreEqual(new Complex(0.0, 7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 2d), new Complex(4.5d, 0.5d), new Complex(7d, 1.5d));
                var v = ov.swizzle.gbgrb;
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(7d, 1.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 2d), v.w);
                Assert.AreEqual(new Complex(7d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, 8.5d), new Complex(-1d, -3d), new Complex(0.0, -4.5d));
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(new Complex(-1d, -3d), v.x);
                Assert.AreEqual(new Complex(0.0, -4.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -3d), v.z);
                Assert.AreEqual(new Complex(-1d, -3d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9d, 5.5d), new Complex(-6d, 7.5d), new Complex(8d, -6.5d));
                var v = ov.swizzle.gbggr;
                Assert.AreEqual(new Complex(-6d, 7.5d), v.x);
                Assert.AreEqual(new Complex(8d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-6d, 7.5d), v.w);
                Assert.AreEqual(new Complex(9d, 5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, -5d), new Complex(-4d, 5d), new Complex(0.5d, 7d));
                var v = ov.swizzle.gbggg;
                Assert.AreEqual(new Complex(-4d, 5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-4d, 5d), v.z);
                Assert.AreEqual(new Complex(-4d, 5d), v.w);
                Assert.AreEqual(new Complex(-4d, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, -2.5d), new Complex(-6.5d, 0.5d), new Complex(-8d, -5d));
                var v = ov.swizzle.gbggb;
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-8d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, 5.5d), new Complex(-8d, -3.5d), new Complex(7.5d, -3.5d));
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(new Complex(-8d, -3.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-8d, -3.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -7.5d), new Complex(8.5d, 9.5d), new Complex(3.5d, 8.5d));
                var v = ov.swizzle.gbgbr;
                Assert.AreEqual(new Complex(8.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.w);
                Assert.AreEqual(new Complex(1.5d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, 5d), new Complex(5d, -3d), new Complex(6.5d, -2d));
                var v = ov.swizzle.gbgbg;
                Assert.AreEqual(new Complex(5d, -3d), v.x);
                Assert.AreEqual(new Complex(6.5d, -2d), v.y);
                Assert.AreEqual(new Complex(5d, -3d), v.z);
                Assert.AreEqual(new Complex(6.5d, -2d), v.w);
                Assert.AreEqual(new Complex(5d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 1.5d), new Complex(6d, -6.5d), new Complex(7d, 9.5d));
                var v = ov.swizzle.gbgbb;
                Assert.AreEqual(new Complex(6d, -6.5d), v.x);
                Assert.AreEqual(new Complex(7d, 9.5d), v.y);
                Assert.AreEqual(new Complex(6d, -6.5d), v.z);
                Assert.AreEqual(new Complex(7d, 9.5d), v.w);
                Assert.AreEqual(new Complex(7d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 9d), new Complex(9d, -5.5d), new Complex(4.5d, 1.5d));
                var v = ov.swizzle.gbb;
                Assert.AreEqual(new Complex(9d, -5.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -2d), new Complex(2.5d, 9.5d), new Complex(-5d, 4.5d));
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(new Complex(2.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -2d), v.w);
            }
            {
                var ov = new cvec3(new Complex(4.5d, 6.5d), new Complex(2d, -1.5d), new Complex(-0.5d, 0.5d));
                var v = ov.swizzle.gbbrr;
                Assert.AreEqual(new Complex(2d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, 6d), new Complex(-5.5d, -7d), new Complex(-5d, -2.5d));
                var v = ov.swizzle.gbbrg;
                Assert.AreEqual(new Complex(-5.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 6d), v.w);
                Assert.AreEqual(new Complex(-5.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, 5d), new Complex(-2d, 5.5d), new Complex(9.5d, 9.5d));
                var v = ov.swizzle.gbbrb;
                Assert.AreEqual(new Complex(-2d, 5.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(3d, 5d), v.w);
                Assert.AreEqual(new Complex(9.5d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -6d), new Complex(8.5d, 3d), new Complex(-3d, -8d));
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(new Complex(8.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-3d, -8d), v.y);
                Assert.AreEqual(new Complex(-3d, -8d), v.z);
                Assert.AreEqual(new Complex(8.5d, 3d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, -2d), new Complex(9d, -8d), new Complex(-1d, -6d));
                var v = ov.swizzle.gbbgr;
                Assert.AreEqual(new Complex(9d, -8d), v.x);
                Assert.AreEqual(new Complex(-1d, -6d), v.y);
                Assert.AreEqual(new Complex(-1d, -6d), v.z);
                Assert.AreEqual(new Complex(9d, -8d), v.w);
                Assert.AreEqual(new Complex(8d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, 8.5d), new Complex(2.5d, -4.5d), new Complex(6.5d, -2.5d));
                var v = ov.swizzle.gbbgg;
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.w);
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, 4.5d), new Complex(-8.5d, 3.5d), new Complex(1.0, 8d));
                var v = ov.swizzle.gbbgb;
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 8d), v.y);
                Assert.AreEqual(new Complex(1.0, 8d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.w);
                Assert.AreEqual(new Complex(1.0, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, 7.5d), new Complex(-6d, 5.5d), new Complex(-0.5d, -5d));
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(new Complex(-6d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2d, -9.5d), new Complex(3d, 5d), new Complex(3d, -2.5d));
                var v = ov.swizzle.gbbbr;
                Assert.AreEqual(new Complex(3d, 5d), v.x);
                Assert.AreEqual(new Complex(3d, -2.5d), v.y);
                Assert.AreEqual(new Complex(3d, -2.5d), v.z);
                Assert.AreEqual(new Complex(3d, -2.5d), v.w);
                Assert.AreEqual(new Complex(-2d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -4.5d), new Complex(-3d, -4.5d), new Complex(6d, -2d));
                var v = ov.swizzle.gbbbg;
                Assert.AreEqual(new Complex(-3d, -4.5d), v.x);
                Assert.AreEqual(new Complex(6d, -2d), v.y);
                Assert.AreEqual(new Complex(6d, -2d), v.z);
                Assert.AreEqual(new Complex(6d, -2d), v.w);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, 2.5d), new Complex(-7.5d, 3d), new Complex(-8.5d, 6d));
                var v = ov.swizzle.gbbbb;
                Assert.AreEqual(new Complex(-7.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 6d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 6d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 6d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, -2d), new Complex(-4d, 1.5d), new Complex(-9.5d, 9.5d));
                var v = ov.swizzle.br;
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -2d), v.y);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -5.5d), new Complex(7.5d, -0.5d), new Complex(4.5d, 8d));
                var v = ov.swizzle.brr;
                Assert.AreEqual(new Complex(4.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -5.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 6.5d), new Complex(-1.5d, -5d), new Complex(-2.5d, 1.0));
                var v = ov.swizzle.brrr;
                Assert.AreEqual(new Complex(-2.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-7.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 9.5d), new Complex(-5d, -0.5d), new Complex(7d, 9d));
                var v = ov.swizzle.brrrr;
                Assert.AreEqual(new Complex(7d, 9d), v.x);
                Assert.AreEqual(new Complex(3.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 9.5d), v.w);
                Assert.AreEqual(new Complex(3.5d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 1.5d), new Complex(-1.5d, -8d), new Complex(7.5d, 5d));
                var v = ov.swizzle.brrrg;
                Assert.AreEqual(new Complex(7.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.w);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7.5d, -5.5d), new Complex(-5.5d, 9d), new Complex(-7d, 8.5d));
                var v = ov.swizzle.brrrb;
                Assert.AreEqual(new Complex(-7d, 8.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -5.5d), v.w);
                Assert.AreEqual(new Complex(-7d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 4d), new Complex(-1d, -5d), new Complex(-2d, 4d));
                var v = ov.swizzle.brrg;
                Assert.AreEqual(new Complex(-2d, 4d), v.x);
                Assert.AreEqual(new Complex(8.5d, 4d), v.y);
                Assert.AreEqual(new Complex(8.5d, 4d), v.z);
                Assert.AreEqual(new Complex(-1d, -5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4d, -6.5d), new Complex(-1.5d, 7.5d), new Complex(-3.5d, 3.5d));
                var v = ov.swizzle.brrgr;
                Assert.AreEqual(new Complex(-3.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-4d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-4d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 7.5d), v.w);
                Assert.AreEqual(new Complex(-4d, -6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.0, -3d), new Complex(7d, -4.5d), new Complex(-8.5d, 9d));
                var v = ov.swizzle.brrgg;
                Assert.AreEqual(new Complex(-8.5d, 9d), v.x);
                Assert.AreEqual(new Complex(0.0, -3d), v.y);
                Assert.AreEqual(new Complex(0.0, -3d), v.z);
                Assert.AreEqual(new Complex(7d, -4.5d), v.w);
                Assert.AreEqual(new Complex(7d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, 7.5d), new Complex(-1d, -9.5d), new Complex(9.5d, 9d));
                var v = ov.swizzle.brrgb;
                Assert.AreEqual(new Complex(9.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-1d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-1d, -9.5d), v.w);
                Assert.AreEqual(new Complex(9.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -4.5d), new Complex(-6d, -7.5d), new Complex(-6d, 7.5d));
                var v = ov.swizzle.brrb;
                Assert.AreEqual(new Complex(-6d, 7.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-6d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -2d), new Complex(4.5d, 0.0), new Complex(5.5d, -3.5d));
                var v = ov.swizzle.brrbr;
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -2d), v.y);
                Assert.AreEqual(new Complex(2.5d, -2d), v.z);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.w);
                Assert.AreEqual(new Complex(2.5d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -6d), new Complex(-4.5d, -4d), new Complex(4.5d, 6.5d));
                var v = ov.swizzle.brrbg;
                Assert.AreEqual(new Complex(4.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -6d), v.y);
                Assert.AreEqual(new Complex(0.5d, -6d), v.z);
                Assert.AreEqual(new Complex(4.5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, -4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, -6d), new Complex(-2.5d, 7.5d), new Complex(3.5d, -8d));
                var v = ov.swizzle.brrbb;
                Assert.AreEqual(new Complex(3.5d, -8d), v.x);
                Assert.AreEqual(new Complex(2d, -6d), v.y);
                Assert.AreEqual(new Complex(2d, -6d), v.z);
                Assert.AreEqual(new Complex(3.5d, -8d), v.w);
                Assert.AreEqual(new Complex(3.5d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, 6d), new Complex(-2d, 7.5d), new Complex(1.0, 3d));
                var v = ov.swizzle.brg;
                Assert.AreEqual(new Complex(1.0, 3d), v.x);
                Assert.AreEqual(new Complex(-5d, 6d), v.y);
                Assert.AreEqual(new Complex(-2d, 7.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 3d), new Complex(-1.5d, -1.5d), new Complex(-5d, -1.5d));
                var v = ov.swizzle.brgr;
                Assert.AreEqual(new Complex(-5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6d, -7.5d), new Complex(5.5d, 1.0), new Complex(-0.5d, -6d));
                var v = ov.swizzle.brgrr;
                Assert.AreEqual(new Complex(-0.5d, -6d), v.x);
                Assert.AreEqual(new Complex(6d, -7.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(6d, -7.5d), v.w);
                Assert.AreEqual(new Complex(6d, -7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -4d), new Complex(-6d, -1.5d), new Complex(-1d, -2.5d));
                var v = ov.swizzle.brgrg;
                Assert.AreEqual(new Complex(-1d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-6d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -4d), v.w);
                Assert.AreEqual(new Complex(-6d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, 0.0), new Complex(0.0, -3.5d), new Complex(-4.5d, 4.5d));
                var v = ov.swizzle.brgrb;
                Assert.AreEqual(new Complex(-4.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(9d, 0.0), v.y);
                Assert.AreEqual(new Complex(0.0, -3.5d), v.z);
                Assert.AreEqual(new Complex(9d, 0.0), v.w);
                Assert.AreEqual(new Complex(-4.5d, 4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, 5d), new Complex(-1.5d, 9d), new Complex(0.5d, 2d));
                var v = ov.swizzle.brgg;
                Assert.AreEqual(new Complex(0.5d, 2d), v.x);
                Assert.AreEqual(new Complex(4.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3d, 7.5d), new Complex(-1d, 6.5d), new Complex(-7d, 3.5d));
                var v = ov.swizzle.brggr;
                Assert.AreEqual(new Complex(-7d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-1d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-3d, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 1.5d), new Complex(0.0, -2d), new Complex(9.5d, 6d));
                var v = ov.swizzle.brggg;
                Assert.AreEqual(new Complex(9.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -2d), v.z);
                Assert.AreEqual(new Complex(0.0, -2d), v.w);
                Assert.AreEqual(new Complex(0.0, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -2d), new Complex(1.5d, -9d), new Complex(4.5d, -7d));
                var v = ov.swizzle.brggb;
                Assert.AreEqual(new Complex(4.5d, -7d), v.x);
                Assert.AreEqual(new Complex(1.5d, -2d), v.y);
                Assert.AreEqual(new Complex(1.5d, -9d), v.z);
                Assert.AreEqual(new Complex(1.5d, -9d), v.w);
                Assert.AreEqual(new Complex(4.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, -7d), new Complex(7d, 5d), new Complex(8.5d, 5.5d));
                var v = ov.swizzle.brgb;
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -7d), v.y);
                Assert.AreEqual(new Complex(7d, 5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 1.0), new Complex(5.5d, -3.5d), new Complex(-6.5d, -7d));
                var v = ov.swizzle.brgbr;
                Assert.AreEqual(new Complex(-6.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -7d), v.w);
                Assert.AreEqual(new Complex(-6.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, -3.5d), new Complex(9.5d, -7d), new Complex(-6d, 7.5d));
                var v = ov.swizzle.brgbg;
                Assert.AreEqual(new Complex(-6d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -3.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-6d, 7.5d), v.w);
                Assert.AreEqual(new Complex(9.5d, -7d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -2.5d), new Complex(-9d, 8d), new Complex(-9d, 6.5d));
                var v = ov.swizzle.brgbb;
                Assert.AreEqual(new Complex(-9d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 8d), v.z);
                Assert.AreEqual(new Complex(-9d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-9d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, -9.5d), new Complex(4d, -4d), new Complex(-6d, -8d));
                var v = ov.swizzle.brb;
                Assert.AreEqual(new Complex(-6d, -8d), v.x);
                Assert.AreEqual(new Complex(5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -8d), v.z);
            }
            {
                var ov = new cvec3(new Complex(9d, 2.5d), new Complex(4d, 9d), new Complex(9.5d, 4.5d));
                var v = ov.swizzle.brbr;
                Assert.AreEqual(new Complex(9.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(9d, 2.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(9d, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5d, 8d), new Complex(-6.5d, 9d), new Complex(3.5d, -3d));
                var v = ov.swizzle.brbrr;
                Assert.AreEqual(new Complex(3.5d, -3d), v.x);
                Assert.AreEqual(new Complex(5d, 8d), v.y);
                Assert.AreEqual(new Complex(3.5d, -3d), v.z);
                Assert.AreEqual(new Complex(5d, 8d), v.w);
                Assert.AreEqual(new Complex(5d, 8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, 0.5d), new Complex(6.5d, 9d), new Complex(7.5d, 4d));
                var v = ov.swizzle.brbrg;
                Assert.AreEqual(new Complex(7.5d, 4d), v.x);
                Assert.AreEqual(new Complex(9d, 0.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, 4d), v.z);
                Assert.AreEqual(new Complex(9d, 0.5d), v.w);
                Assert.AreEqual(new Complex(6.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, 2.5d), new Complex(-0.5d, -9d), new Complex(-6d, 9.5d));
                var v = ov.swizzle.brbrb;
                Assert.AreEqual(new Complex(-6d, 9.5d), v.x);
                Assert.AreEqual(new Complex(4d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 9.5d), v.z);
                Assert.AreEqual(new Complex(4d, 2.5d), v.w);
                Assert.AreEqual(new Complex(-6d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, -6.5d), new Complex(-2.5d, -5d), new Complex(-2d, -6.5d));
                var v = ov.swizzle.brbg;
                Assert.AreEqual(new Complex(-2d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-6d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.0, 7.5d), new Complex(0.5d, 2.5d), new Complex(7.5d, 9d));
                var v = ov.swizzle.brbgr;
                Assert.AreEqual(new Complex(7.5d, 9d), v.x);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, 9d), v.z);
                Assert.AreEqual(new Complex(0.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -1d), new Complex(5d, 3d), new Complex(-2.5d, 3.5d));
                var v = ov.swizzle.brbgg;
                Assert.AreEqual(new Complex(-2.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(5d, 3d), v.w);
                Assert.AreEqual(new Complex(5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -9.5d), new Complex(6d, 9d), new Complex(-8.5d, 1.0));
                var v = ov.swizzle.brbgb;
                Assert.AreEqual(new Complex(-8.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(0.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(6d, 9d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 9d), new Complex(1.5d, -4d), new Complex(1.0, 9d));
                var v = ov.swizzle.brbb;
                Assert.AreEqual(new Complex(1.0, 9d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.y);
                Assert.AreEqual(new Complex(1.0, 9d), v.z);
                Assert.AreEqual(new Complex(1.0, 9d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8d, 4.5d), new Complex(8d, -7d), new Complex(8d, 8.5d));
                var v = ov.swizzle.brbbr;
                Assert.AreEqual(new Complex(8d, 8.5d), v.x);
                Assert.AreEqual(new Complex(8d, 4.5d), v.y);
                Assert.AreEqual(new Complex(8d, 8.5d), v.z);
                Assert.AreEqual(new Complex(8d, 8.5d), v.w);
                Assert.AreEqual(new Complex(8d, 4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, 3d), new Complex(7d, -6d), new Complex(6d, -8.5d));
                var v = ov.swizzle.brbbg;
                Assert.AreEqual(new Complex(6d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 3d), v.y);
                Assert.AreEqual(new Complex(6d, -8.5d), v.z);
                Assert.AreEqual(new Complex(6d, -8.5d), v.w);
                Assert.AreEqual(new Complex(7d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(1.0, -3d), new Complex(-7d, 7.5d), new Complex(6.5d, 2d));
                var v = ov.swizzle.brbbb;
                Assert.AreEqual(new Complex(6.5d, 2d), v.x);
                Assert.AreEqual(new Complex(1.0, -3d), v.y);
                Assert.AreEqual(new Complex(6.5d, 2d), v.z);
                Assert.AreEqual(new Complex(6.5d, 2d), v.w);
                Assert.AreEqual(new Complex(6.5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -3d), new Complex(-3.5d, 0.0), new Complex(8d, 7d));
                var v = ov.swizzle.bg;
                Assert.AreEqual(new Complex(8d, 7d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 0.0), v.y);
            }
            {
                var ov = new cvec3(new Complex(1.0, 2d), new Complex(1.5d, -3.5d), new Complex(-1d, 6.5d));
                var v = ov.swizzle.bgr;
                Assert.AreEqual(new Complex(-1d, 6.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 2d), v.z);
            }
            {
                var ov = new cvec3(new Complex(1.0, -0.5d), new Complex(-8d, 7d), new Complex(6d, 5d));
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(new Complex(6d, 5d), v.x);
                Assert.AreEqual(new Complex(-8d, 7d), v.y);
                Assert.AreEqual(new Complex(1.0, -0.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6d, -6d), new Complex(2d, 1.0), new Complex(-2d, 9.5d));
                var v = ov.swizzle.bgrrr;
                Assert.AreEqual(new Complex(-2d, 9.5d), v.x);
                Assert.AreEqual(new Complex(2d, 1.0), v.y);
                Assert.AreEqual(new Complex(6d, -6d), v.z);
                Assert.AreEqual(new Complex(6d, -6d), v.w);
                Assert.AreEqual(new Complex(6d, -6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, -2d), new Complex(-6.5d, -1.5d), new Complex(-1.5d, -7d));
                var v = ov.swizzle.bgrrg;
                Assert.AreEqual(new Complex(-1.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(4d, -2d), v.z);
                Assert.AreEqual(new Complex(4d, -2d), v.w);
                Assert.AreEqual(new Complex(-6.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -3.5d), new Complex(-4.5d, 8d), new Complex(9.5d, -1d));
                var v = ov.swizzle.bgrrb;
                Assert.AreEqual(new Complex(9.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -3.5d), v.w);
                Assert.AreEqual(new Complex(9.5d, -1d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -4.5d), new Complex(-9.5d, -2d), new Complex(8.5d, 0.0));
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(new Complex(8.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-9.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -2d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9d, 1.5d), new Complex(-7d, 9.5d), new Complex(1.5d, 5.5d));
                var v = ov.swizzle.bgrgr;
                Assert.AreEqual(new Complex(1.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-7d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 9.5d), v.w);
                Assert.AreEqual(new Complex(-9d, 1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 0.0), new Complex(0.0, 3.5d), new Complex(-2.5d, 1.5d));
                var v = ov.swizzle.bgrgg;
                Assert.AreEqual(new Complex(-2.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 3.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(0.0, 3.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 4d), new Complex(4.5d, -1.5d), new Complex(-7.5d, 1.0));
                var v = ov.swizzle.bgrgb;
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(4.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 4d), v.z);
                Assert.AreEqual(new Complex(4.5d, -1.5d), v.w);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, -7d), new Complex(-5d, 7d), new Complex(9d, -6d));
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(new Complex(9d, -6d), v.x);
                Assert.AreEqual(new Complex(-5d, 7d), v.y);
                Assert.AreEqual(new Complex(9d, -7d), v.z);
                Assert.AreEqual(new Complex(9d, -6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6d, -8.5d), new Complex(2d, -4.5d), new Complex(4d, 0.5d));
                var v = ov.swizzle.bgrbr;
                Assert.AreEqual(new Complex(4d, 0.5d), v.x);
                Assert.AreEqual(new Complex(2d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -8.5d), v.z);
                Assert.AreEqual(new Complex(4d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-6d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 9.5d), new Complex(-9.5d, 6d), new Complex(-4d, -7d));
                var v = ov.swizzle.bgrbg;
                Assert.AreEqual(new Complex(-4d, -7d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 6d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -7d), v.w);
                Assert.AreEqual(new Complex(-9.5d, 6d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6d, 5.5d), new Complex(-1.5d, -0.5d), new Complex(-0.5d, 1.0));
                var v = ov.swizzle.bgrbb;
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-1.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.w);
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4d, 3.5d), new Complex(-8.5d, 2.5d), new Complex(-0.5d, -1d));
                var v = ov.swizzle.bgg;
                Assert.AreEqual(new Complex(-0.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -1d), new Complex(4d, -8.5d), new Complex(-4.5d, -1.5d));
                var v = ov.swizzle.bggr;
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(4d, -8.5d), v.y);
                Assert.AreEqual(new Complex(4d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -1d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -8.5d), new Complex(-1.5d, -8d), new Complex(-6.5d, 6d));
                var v = ov.swizzle.bggrr;
                Assert.AreEqual(new Complex(-6.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -8.5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, -8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, 9d), new Complex(-3d, -2.5d), new Complex(7.5d, -4.5d));
                var v = ov.swizzle.bggrg;
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-3d, -2.5d), v.z);
                Assert.AreEqual(new Complex(7d, 9d), v.w);
                Assert.AreEqual(new Complex(-3d, -2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 1.0), new Complex(-9.5d, -9d), new Complex(7d, 9.5d));
                var v = ov.swizzle.bggrb;
                Assert.AreEqual(new Complex(7d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -9d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -9d), v.z);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.w);
                Assert.AreEqual(new Complex(7d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, -3d), new Complex(9d, 1.0), new Complex(0.5d, 1.5d));
                var v = ov.swizzle.bggg;
                Assert.AreEqual(new Complex(0.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(9d, 1.0), v.y);
                Assert.AreEqual(new Complex(9d, 1.0), v.z);
                Assert.AreEqual(new Complex(9d, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 4d), new Complex(-4d, -4.5d), new Complex(-6.5d, -9.5d));
                var v = ov.swizzle.bgggr;
                Assert.AreEqual(new Complex(-6.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-4d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-4d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -4.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 4d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 4d), new Complex(6.5d, 9.5d), new Complex(-2.5d, 3.5d));
                var v = ov.swizzle.bgggg;
                Assert.AreEqual(new Complex(-2.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 9.5d), v.w);
                Assert.AreEqual(new Complex(6.5d, 9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, -8.5d), new Complex(-1.5d, 0.5d), new Complex(-8.5d, 1.0));
                var v = ov.swizzle.bgggb;
                Assert.AreEqual(new Complex(-8.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-1.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-8.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, -4.5d), new Complex(3.5d, -3.5d), new Complex(5d, 0.0));
                var v = ov.swizzle.bggb;
                Assert.AreEqual(new Complex(5d, 0.0), v.x);
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(5d, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 2.5d), new Complex(-2d, -1.5d), new Complex(1.5d, -6.5d));
                var v = ov.swizzle.bggbr;
                Assert.AreEqual(new Complex(1.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -1.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, 6.5d), new Complex(4d, 6.5d), new Complex(6.5d, 6d));
                var v = ov.swizzle.bggbg;
                Assert.AreEqual(new Complex(6.5d, 6d), v.x);
                Assert.AreEqual(new Complex(4d, 6.5d), v.y);
                Assert.AreEqual(new Complex(4d, 6.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 6d), v.w);
                Assert.AreEqual(new Complex(4d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, -7.5d), new Complex(2d, -1.5d), new Complex(6.5d, -3d));
                var v = ov.swizzle.bggbb;
                Assert.AreEqual(new Complex(6.5d, -3d), v.x);
                Assert.AreEqual(new Complex(2d, -1.5d), v.y);
                Assert.AreEqual(new Complex(2d, -1.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -3d), v.w);
                Assert.AreEqual(new Complex(6.5d, -3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(2d, 0.0), new Complex(6d, -8.5d), new Complex(6d, 8d));
                var v = ov.swizzle.bgb;
                Assert.AreEqual(new Complex(6d, 8d), v.x);
                Assert.AreEqual(new Complex(6d, -8.5d), v.y);
                Assert.AreEqual(new Complex(6d, 8d), v.z);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 4.5d), new Complex(2d, 4d), new Complex(1.0, -8d));
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(new Complex(1.0, -8d), v.x);
                Assert.AreEqual(new Complex(2d, 4d), v.y);
                Assert.AreEqual(new Complex(1.0, -8d), v.z);
                Assert.AreEqual(new Complex(8.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2d, 0.5d), new Complex(-8d, -9.5d), new Complex(-6.5d, 5d));
                var v = ov.swizzle.bgbrr;
                Assert.AreEqual(new Complex(-6.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-8d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-2d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-2d, 0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 0.5d), new Complex(-2d, -4.5d), new Complex(-1d, 2d));
                var v = ov.swizzle.bgbrg;
                Assert.AreEqual(new Complex(-1d, 2d), v.x);
                Assert.AreEqual(new Complex(-2d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 2d), v.z);
                Assert.AreEqual(new Complex(6.5d, 0.5d), v.w);
                Assert.AreEqual(new Complex(-2d, -4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, -3.5d), new Complex(2.5d, 0.5d), new Complex(-5d, 2d));
                var v = ov.swizzle.bgbrb;
                Assert.AreEqual(new Complex(-5d, 2d), v.x);
                Assert.AreEqual(new Complex(2.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 2d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.w);
                Assert.AreEqual(new Complex(-5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, -9.5d), new Complex(-0.5d, -1.5d), new Complex(-5.5d, 3.5d));
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(new Complex(-5.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.0, -5d), new Complex(-3.5d, -2.5d), new Complex(-6d, 0.5d));
                var v = ov.swizzle.bgbgr;
                Assert.AreEqual(new Complex(-6d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(1.0, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4d, -4.5d), new Complex(7.5d, 6.5d), new Complex(4.5d, 1.5d));
                var v = ov.swizzle.bgbgg;
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, 3d), new Complex(-7.5d, -8d), new Complex(0.0, 7.5d));
                var v = ov.swizzle.bgbgb;
                Assert.AreEqual(new Complex(0.0, 7.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -8d), v.y);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -8d), v.w);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 0.0), new Complex(-0.5d, 2d), new Complex(-5d, -8.5d));
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(new Complex(-5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-5d, -8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2d, 2.5d), new Complex(-4d, -1.5d), new Complex(6d, -1d));
                var v = ov.swizzle.bgbbr;
                Assert.AreEqual(new Complex(6d, -1d), v.x);
                Assert.AreEqual(new Complex(-4d, -1.5d), v.y);
                Assert.AreEqual(new Complex(6d, -1d), v.z);
                Assert.AreEqual(new Complex(6d, -1d), v.w);
                Assert.AreEqual(new Complex(-2d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, -9d), new Complex(-7.5d, 1.0), new Complex(7d, 1.0));
                var v = ov.swizzle.bgbbg;
                Assert.AreEqual(new Complex(7d, 1.0), v.x);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(7d, 1.0), v.z);
                Assert.AreEqual(new Complex(7d, 1.0), v.w);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7d, 8d), new Complex(-3.5d, -1d), new Complex(4.5d, 2.5d));
                var v = ov.swizzle.bgbbb;
                Assert.AreEqual(new Complex(4.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -1d), v.y);
                Assert.AreEqual(new Complex(4.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 2.5d), v.w);
                Assert.AreEqual(new Complex(4.5d, 2.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -4d), new Complex(0.5d, 1.5d), new Complex(-1d, 8d));
                var v = ov.swizzle.bb;
                Assert.AreEqual(new Complex(-1d, 8d), v.x);
                Assert.AreEqual(new Complex(-1d, 8d), v.y);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 5.5d), new Complex(-3.5d, 4.5d), new Complex(-8.5d, 9.5d));
                var v = ov.swizzle.bbr;
                Assert.AreEqual(new Complex(-8.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, 5.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(4.5d, 8.5d), new Complex(2d, 3d), new Complex(-9d, 7.5d));
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(new Complex(-9d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-9d, 7.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7d, -8d), new Complex(3d, -5d), new Complex(-6d, 7d));
                var v = ov.swizzle.bbrrr;
                Assert.AreEqual(new Complex(-6d, 7d), v.x);
                Assert.AreEqual(new Complex(-6d, 7d), v.y);
                Assert.AreEqual(new Complex(-7d, -8d), v.z);
                Assert.AreEqual(new Complex(-7d, -8d), v.w);
                Assert.AreEqual(new Complex(-7d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -2d), new Complex(1.0, 5d), new Complex(-7d, 1.0));
                var v = ov.swizzle.bbrrg;
                Assert.AreEqual(new Complex(-7d, 1.0), v.x);
                Assert.AreEqual(new Complex(-7d, 1.0), v.y);
                Assert.AreEqual(new Complex(-2d, -2d), v.z);
                Assert.AreEqual(new Complex(-2d, -2d), v.w);
                Assert.AreEqual(new Complex(1.0, 5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -9.5d), new Complex(7.5d, -6d), new Complex(8d, -5.5d));
                var v = ov.swizzle.bbrrb;
                Assert.AreEqual(new Complex(8d, -5.5d), v.x);
                Assert.AreEqual(new Complex(8d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -9.5d), v.w);
                Assert.AreEqual(new Complex(8d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -8d), new Complex(-8.5d, -0.5d), new Complex(-9.5d, -3.5d));
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(new Complex(-9.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -8d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, -8d), new Complex(5d, -2.5d), new Complex(-0.5d, -7d));
                var v = ov.swizzle.bbrgr;
                Assert.AreEqual(new Complex(-0.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -7d), v.y);
                Assert.AreEqual(new Complex(0.0, -8d), v.z);
                Assert.AreEqual(new Complex(5d, -2.5d), v.w);
                Assert.AreEqual(new Complex(0.0, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(7d, -7.5d), new Complex(-5.5d, 6.5d), new Complex(7.5d, 7.5d));
                var v = ov.swizzle.bbrgg;
                Assert.AreEqual(new Complex(7.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(7d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, -0.5d), new Complex(-0.5d, 6d), new Complex(-1d, -3.5d));
                var v = ov.swizzle.bbrgb;
                Assert.AreEqual(new Complex(-1d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-1d, -3.5d), v.y);
                Assert.AreEqual(new Complex(3d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 6d), v.w);
                Assert.AreEqual(new Complex(-1d, -3.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, 8.5d), new Complex(-0.5d, -1d), new Complex(3d, -6d));
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(new Complex(3d, -6d), v.x);
                Assert.AreEqual(new Complex(3d, -6d), v.y);
                Assert.AreEqual(new Complex(6d, 8.5d), v.z);
                Assert.AreEqual(new Complex(3d, -6d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 0.0), new Complex(-6d, 1.0), new Complex(5.5d, 6.5d));
                var v = ov.swizzle.bbrbr;
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, -9.5d), new Complex(6d, -0.5d), new Complex(-2d, 0.0));
                var v = ov.swizzle.bbrbg;
                Assert.AreEqual(new Complex(-2d, 0.0), v.x);
                Assert.AreEqual(new Complex(-2d, 0.0), v.y);
                Assert.AreEqual(new Complex(5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-2d, 0.0), v.w);
                Assert.AreEqual(new Complex(6d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-3d, -0.5d), new Complex(-6.5d, 5d), new Complex(-9.5d, -2d));
                var v = ov.swizzle.bbrbb;
                Assert.AreEqual(new Complex(-9.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-3d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -2d), v.w);
                Assert.AreEqual(new Complex(-9.5d, -2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 0.0), new Complex(-0.5d, -7.5d), new Complex(-4.5d, -3.5d));
                var v = ov.swizzle.bbg;
                Assert.AreEqual(new Complex(-4.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -4d), new Complex(0.0, -9d), new Complex(-3d, -8.5d));
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(new Complex(-3d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -8.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -9d), v.z);
                Assert.AreEqual(new Complex(9.5d, -4d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 9d), new Complex(-4d, 6.5d), new Complex(-5.5d, -3.5d));
                var v = ov.swizzle.bbgrr;
                Assert.AreEqual(new Complex(-5.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 6.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 9d), v.w);
                Assert.AreEqual(new Complex(0.5d, 9d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -7d), new Complex(4d, -0.5d), new Complex(4d, -9d));
                var v = ov.swizzle.bbgrg;
                Assert.AreEqual(new Complex(4d, -9d), v.x);
                Assert.AreEqual(new Complex(4d, -9d), v.y);
                Assert.AreEqual(new Complex(4d, -0.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -7d), v.w);
                Assert.AreEqual(new Complex(4d, -0.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-5d, 3d), new Complex(-4.5d, 3.5d), new Complex(-4.5d, 1.0));
                var v = ov.swizzle.bbgrb;
                Assert.AreEqual(new Complex(-4.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-4.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-4.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 3d), v.w);
                Assert.AreEqual(new Complex(-4.5d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 1.5d), new Complex(0.5d, -1d), new Complex(1.0, 5.5d));
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(new Complex(1.0, 5.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 5.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -1d), v.z);
                Assert.AreEqual(new Complex(0.5d, -1d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 2d), new Complex(1.5d, 6d), new Complex(-3d, 6.5d));
                var v = ov.swizzle.bbggr;
                Assert.AreEqual(new Complex(-3d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 6.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 6d), v.z);
                Assert.AreEqual(new Complex(1.5d, 6d), v.w);
                Assert.AreEqual(new Complex(-5.5d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8d, 8d), new Complex(9d, -8d), new Complex(-5d, 3d));
                var v = ov.swizzle.bbggg;
                Assert.AreEqual(new Complex(-5d, 3d), v.x);
                Assert.AreEqual(new Complex(-5d, 3d), v.y);
                Assert.AreEqual(new Complex(9d, -8d), v.z);
                Assert.AreEqual(new Complex(9d, -8d), v.w);
                Assert.AreEqual(new Complex(9d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2d, -0.5d), new Complex(-7.5d, -1d), new Complex(-3.5d, 3d));
                var v = ov.swizzle.bbggb;
                Assert.AreEqual(new Complex(-3.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -1d), v.w);
                Assert.AreEqual(new Complex(-3.5d, 3d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 5d), new Complex(-4d, 7.5d), new Complex(0.5d, -5.5d));
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 7.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, -5.5d), new Complex(8.5d, -1.5d), new Complex(8.5d, -6.5d));
                var v = ov.swizzle.bbgbr;
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.w);
                Assert.AreEqual(new Complex(7.5d, -5.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(0.0, -3d), new Complex(-9d, -8d), new Complex(-7d, 5d));
                var v = ov.swizzle.bbgbg;
                Assert.AreEqual(new Complex(-7d, 5d), v.x);
                Assert.AreEqual(new Complex(-7d, 5d), v.y);
                Assert.AreEqual(new Complex(-9d, -8d), v.z);
                Assert.AreEqual(new Complex(-7d, 5d), v.w);
                Assert.AreEqual(new Complex(-9d, -8d), v.v);
            }
            {
                var ov = new cvec3(new Complex(3d, -0.5d), new Complex(8d, 8d), new Complex(-5.5d, -5d));
                var v = ov.swizzle.bbgbb;
                Assert.AreEqual(new Complex(-5.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -5d), v.y);
                Assert.AreEqual(new Complex(8d, 8d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, -5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -4d), new Complex(-4d, -9.5d), new Complex(-5d, 8d));
                var v = ov.swizzle.bbb;
                Assert.AreEqual(new Complex(-5d, 8d), v.x);
                Assert.AreEqual(new Complex(-5d, 8d), v.y);
                Assert.AreEqual(new Complex(-5d, 8d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 9.5d), new Complex(8d, -8.5d), new Complex(-5.5d, -9.5d));
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(new Complex(-5.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 6.5d), new Complex(-5d, 4.5d), new Complex(0.5d, 8d));
                var v = ov.swizzle.bbbrr;
                Assert.AreEqual(new Complex(0.5d, 8d), v.x);
                Assert.AreEqual(new Complex(0.5d, 8d), v.y);
                Assert.AreEqual(new Complex(0.5d, 8d), v.z);
                Assert.AreEqual(new Complex(8.5d, 6.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, 6.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-1d, 2.5d), new Complex(-5.5d, -1.5d), new Complex(-7d, -9d));
                var v = ov.swizzle.bbbrg;
                Assert.AreEqual(new Complex(-7d, -9d), v.x);
                Assert.AreEqual(new Complex(-7d, -9d), v.y);
                Assert.AreEqual(new Complex(-7d, -9d), v.z);
                Assert.AreEqual(new Complex(-1d, 2.5d), v.w);
                Assert.AreEqual(new Complex(-5.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(9d, 2d), new Complex(-0.5d, -2.5d), new Complex(1.5d, 8.5d));
                var v = ov.swizzle.bbbrb;
                Assert.AreEqual(new Complex(1.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(9d, 2d), v.w);
                Assert.AreEqual(new Complex(1.5d, 8.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(6d, -3d), new Complex(-3d, -0.5d), new Complex(-9.5d, 2d));
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(new Complex(-9.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-3d, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1d, -9.5d), new Complex(-2.5d, -7.5d), new Complex(-9d, 7d));
                var v = ov.swizzle.bbbgr;
                Assert.AreEqual(new Complex(-9d, 7d), v.x);
                Assert.AreEqual(new Complex(-9d, 7d), v.y);
                Assert.AreEqual(new Complex(-9d, 7d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -7.5d), v.w);
                Assert.AreEqual(new Complex(-1d, -9.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -7d), new Complex(9d, 2d), new Complex(9.5d, 8.5d));
                var v = ov.swizzle.bbbgg;
                Assert.AreEqual(new Complex(9.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(9d, 2d), v.w);
                Assert.AreEqual(new Complex(9d, 2d), v.v);
            }
            {
                var ov = new cvec3(new Complex(4.5d, 2d), new Complex(0.0, 1.5d), new Complex(6d, 1.0));
                var v = ov.swizzle.bbbgb;
                Assert.AreEqual(new Complex(6d, 1.0), v.x);
                Assert.AreEqual(new Complex(6d, 1.0), v.y);
                Assert.AreEqual(new Complex(6d, 1.0), v.z);
                Assert.AreEqual(new Complex(0.0, 1.5d), v.w);
                Assert.AreEqual(new Complex(6d, 1.0), v.v);
            }
            {
                var ov = new cvec3(new Complex(5d, 5.5d), new Complex(-4d, -0.5d), new Complex(6d, -3d));
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(new Complex(6d, -3d), v.x);
                Assert.AreEqual(new Complex(6d, -3d), v.y);
                Assert.AreEqual(new Complex(6d, -3d), v.z);
                Assert.AreEqual(new Complex(6d, -3d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7d, 4.5d), new Complex(-8d, 0.0), new Complex(-7.5d, 0.0));
                var v = ov.swizzle.bbbbr;
                Assert.AreEqual(new Complex(-7.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-7.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-7.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(-7.5d, 0.0), v.w);
                Assert.AreEqual(new Complex(7d, 4.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(-8d, -9.5d), new Complex(8.5d, -1.5d), new Complex(-7d, -4.5d));
                var v = ov.swizzle.bbbbg;
                Assert.AreEqual(new Complex(-7d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-7d, -4.5d), v.w);
                Assert.AreEqual(new Complex(8.5d, -1.5d), v.v);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -1.5d), new Complex(-7.5d, 8d), new Complex(0.0, 4.5d));
                var v = ov.swizzle.bbbbb;
                Assert.AreEqual(new Complex(0.0, 4.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 4.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 4.5d), v.z);
                Assert.AreEqual(new Complex(0.0, 4.5d), v.w);
                Assert.AreEqual(new Complex(0.0, 4.5d), v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new cvec3(new Complex(-7.5d, 4.5d), new Complex(-3d, 7.5d), new Complex(-0.5d, -9.5d));
                var v1 = new cvec2(new Complex(6.5d, 8d), new Complex(9.5d, -6.5d));
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(6.5d, 8d), v0.x);
                Assert.AreEqual(new Complex(9.5d, -6.5d), v0.y);
                Assert.AreEqual(new Complex(-0.5d, -9.5d), v0.z);
            
                Assert.AreEqual(new Complex(-7.5d, 4.5d), v2.x);
                Assert.AreEqual(new Complex(-3d, 7.5d), v2.y);
            }
            {
                var v0 = new cvec3(new Complex(-0.5d, 4.5d), new Complex(-1d, -3d), new Complex(-8.5d, -8.5d));
                var v1 = new cvec2(new Complex(-1.5d, 5d), new Complex(-6d, 5d));
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-1.5d, 5d), v0.x);
                Assert.AreEqual(new Complex(-1d, -3d), v0.y);
                Assert.AreEqual(new Complex(-6d, 5d), v0.z);
            
                Assert.AreEqual(new Complex(-0.5d, 4.5d), v2.x);
                Assert.AreEqual(new Complex(-8.5d, -8.5d), v2.y);
            }
            {
                var v0 = new cvec3(new Complex(-8d, -1.5d), new Complex(-4.5d, 3.5d), new Complex(-3.5d, 4d));
                var v1 = new cvec2(new Complex(-2d, 1.0), new Complex(-8.5d, -2d));
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-8d, -1.5d), v0.x);
                Assert.AreEqual(new Complex(-2d, 1.0), v0.y);
                Assert.AreEqual(new Complex(-8.5d, -2d), v0.z);
            
                Assert.AreEqual(new Complex(-4.5d, 3.5d), v2.x);
                Assert.AreEqual(new Complex(-3.5d, 4d), v2.y);
            }
            {
                var v0 = new cvec3(new Complex(-2.5d, 1.0), new Complex(0.0, 0.0), new Complex(-9.5d, 9d));
                var v1 = new cvec3(new Complex(-8d, 1.0), new Complex(-7d, 5d), new Complex(1.5d, -8.5d));
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-8d, 1.0), v0.x);
                Assert.AreEqual(new Complex(-7d, 5d), v0.y);
                Assert.AreEqual(new Complex(1.5d, -8.5d), v0.z);
            
                Assert.AreEqual(new Complex(-2.5d, 1.0), v2.x);
                Assert.AreEqual(new Complex(0.0, 0.0), v2.y);
                Assert.AreEqual(new Complex(-9.5d, 9d), v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new cvec3(new Complex(-9d, 2d), new Complex(-2d, -2.5d), new Complex(1.0, 7.5d));
                var v1 = new Complex(-7.5d, -9.5d);
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-7.5d, -9.5d), v0.x);
                Assert.AreEqual(new Complex(-2d, -2.5d), v0.y);
                Assert.AreEqual(new Complex(1.0, 7.5d), v0.z);
            
                Assert.AreEqual(new Complex(-9d, 2d), v2);
            }
            {
                var v0 = new cvec3(new Complex(8d, 9.5d), new Complex(-7d, 8.5d), new Complex(-5.5d, 5.5d));
                var v1 = new Complex(-5d, 9d);
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(8d, 9.5d), v0.x);
                Assert.AreEqual(new Complex(-5d, 9d), v0.y);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v0.z);
            
                Assert.AreEqual(new Complex(-7d, 8.5d), v2);
            }
            {
                var v0 = new cvec3(new Complex(-6.5d, -4d), new Complex(-1.5d, -6d), new Complex(5d, -9d));
                var v1 = new cvec2(new Complex(-9d, -3d), new Complex(6.5d, 1.5d));
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-9d, -3d), v0.x);
                Assert.AreEqual(new Complex(6.5d, 1.5d), v0.y);
                Assert.AreEqual(new Complex(5d, -9d), v0.z);
            
                Assert.AreEqual(new Complex(-6.5d, -4d), v2.x);
                Assert.AreEqual(new Complex(-1.5d, -6d), v2.y);
            }
            {
                var v0 = new cvec3(new Complex(1.0, 1.0), new Complex(8.5d, 5d), new Complex(5.5d, -1.5d));
                var v1 = new Complex(1.5d, -9d);
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(1.0, 1.0), v0.x);
                Assert.AreEqual(new Complex(8.5d, 5d), v0.y);
                Assert.AreEqual(new Complex(1.5d, -9d), v0.z);
            
                Assert.AreEqual(new Complex(5.5d, -1.5d), v2);
            }
            {
                var v0 = new cvec3(new Complex(-8d, -3.5d), new Complex(4d, 8d), new Complex(1.5d, 3d));
                var v1 = new cvec2(new Complex(-1d, 9.5d), new Complex(0.0, 2.5d));
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-1d, 9.5d), v0.x);
                Assert.AreEqual(new Complex(4d, 8d), v0.y);
                Assert.AreEqual(new Complex(0.0, 2.5d), v0.z);
            
                Assert.AreEqual(new Complex(-8d, -3.5d), v2.x);
                Assert.AreEqual(new Complex(1.5d, 3d), v2.y);
            }
            {
                var v0 = new cvec3(new Complex(-1.5d, -6.5d), new Complex(-7.5d, -6d), new Complex(0.5d, 4d));
                var v1 = new cvec2(new Complex(8.5d, 0.0), new Complex(-7d, -3.5d));
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v0.x);
                Assert.AreEqual(new Complex(8.5d, 0.0), v0.y);
                Assert.AreEqual(new Complex(-7d, -3.5d), v0.z);
            
                Assert.AreEqual(new Complex(-7.5d, -6d), v2.x);
                Assert.AreEqual(new Complex(0.5d, 4d), v2.y);
            }
            {
                var v0 = new cvec3(new Complex(5.5d, -0.5d), new Complex(-8.5d, 6d), new Complex(2d, -0.5d));
                var v1 = new cvec3(new Complex(0.5d, 4d), new Complex(7d, -8d), new Complex(0.0, 7d));
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(0.5d, 4d), v0.x);
                Assert.AreEqual(new Complex(7d, -8d), v0.y);
                Assert.AreEqual(new Complex(0.0, 7d), v0.z);
            
                Assert.AreEqual(new Complex(5.5d, -0.5d), v2.x);
                Assert.AreEqual(new Complex(-8.5d, 6d), v2.y);
                Assert.AreEqual(new Complex(2d, -0.5d), v2.z);
            }
        }

    }
}
