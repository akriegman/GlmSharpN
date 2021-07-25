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
    public class LongSwizzleVec4Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new lvec4(-2L, -7L, 1, -8L);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
            }
            {
                var ov = new lvec4(-2L, 9L, 4L, 9L);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec4(6L, -9L, 9L, -6L);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(5L, -4L, 3L, -4L);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-4L, 0, 5L, -8L);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, 1, -2L, -1L);
                var v = ov.swizzle.xxxxz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(9L, 8L, 9L, 4L);
                var v = ov.swizzle.xxxxw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, -4L, 2L);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(5L, 7L, 7L, -4L);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-1L, 7L, 9L, 7L);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(0, -6L, 8L, -3L);
                var v = ov.swizzle.xxxyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(7L, -8L, -6L, -3L);
                var v = ov.swizzle.xxxyw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(1, 8L, -8L, -8L);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(6L, 3L, 9L, 9L);
                var v = ov.swizzle.xxxzx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(4L, -1L, 8L, 3L);
                var v = ov.swizzle.xxxzy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-9L, 0, -8L, -9L);
                var v = ov.swizzle.xxxzz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, 6L, -1L, -7L);
                var v = ov.swizzle.xxxzw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, 2L, 5L);
                var v = ov.swizzle.xxxw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-1L, -8L, -7L, -1L);
                var v = ov.swizzle.xxxwx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-3L, -9L, 3L, -2L);
                var v = ov.swizzle.xxxwy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, 3L, 2L);
                var v = ov.swizzle.xxxwz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(8L, -6L, -6L, 1);
                var v = ov.swizzle.xxxww;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-8L, -7L, 8L, 0);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec4(-9L, 5L, 7L, 0);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-7L, 8L, 7L, 1);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, 6L, -2L);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(5L, -2L, 7L, 7L);
                var v = ov.swizzle.xxyxz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, -8L, -7L, 5L);
                var v = ov.swizzle.xxyxw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, -2L, 2L);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-7L, -6L, -1L, 8L);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-1L, 8L, -9L, 8L);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, 2L, 6L, 4L);
                var v = ov.swizzle.xxyyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -7L, -4L, 4L);
                var v = ov.swizzle.xxyyw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-2L, 2L, 4L, -2L);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(8L, -1L, -7L, -7L);
                var v = ov.swizzle.xxyzx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 7L, -6L, 0);
                var v = ov.swizzle.xxyzy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-9L, 2L, -3L, 2L);
                var v = ov.swizzle.xxyzz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, 4L, 2L, 1);
                var v = ov.swizzle.xxyzw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-7L, -8L, -1L, -8L);
                var v = ov.swizzle.xxyw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(0, -7L, -1L, 3L);
                var v = ov.swizzle.xxywx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(5L, 2L, -7L, 8L);
                var v = ov.swizzle.xxywy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(3L, -2L, -4L, 5L);
                var v = ov.swizzle.xxywz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -9L, -4L, 5L);
                var v = ov.swizzle.xxyww;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-8L, -4L, 0, 2L);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec4(-3L, -8L, 8L, -8L);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(8L, 4L, -1L, 5L);
                var v = ov.swizzle.xxzxx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-4L, -3L, 6L, -3L);
                var v = ov.swizzle.xxzxy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-1L, 6L, -2L, -2L);
                var v = ov.swizzle.xxzxz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, -1L, 5L);
                var v = ov.swizzle.xxzxw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(9L, 6L, -6L, 7L);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(8L, 7L, -1L, -4L);
                var v = ov.swizzle.xxzyx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, -7L, 2L, 3L);
                var v = ov.swizzle.xxzyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-7L, 7L, 4L, 1);
                var v = ov.swizzle.xxzyz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, -5L, 1);
                var v = ov.swizzle.xxzyw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, -2L, -5L, -1L);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(4L, 0, -4L, 4L);
                var v = ov.swizzle.xxzzx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, 2L, 5L, 5L);
                var v = ov.swizzle.xxzzy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(2L, -4L, -3L, 5L);
                var v = ov.swizzle.xxzzz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, 8L, 1);
                var v = ov.swizzle.xxzzw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-3L, -6L, -4L, -7L);
                var v = ov.swizzle.xxzw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(9L, 3L, -5L, 3L);
                var v = ov.swizzle.xxzwx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(2L, -1L, 3L, 6L);
                var v = ov.swizzle.xxzwy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-8L, 9L, -4L, -8L);
                var v = ov.swizzle.xxzwz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, 4L, 2L, 7L);
                var v = ov.swizzle.xxzww;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-4L, 5L, 6L, 8L);
                var v = ov.swizzle.xxw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec4(-2L, -7L, 1, 3L);
                var v = ov.swizzle.xxwx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-5L, -8L, -8L, 6L);
                var v = ov.swizzle.xxwxx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, -4L, 7L, -5L);
                var v = ov.swizzle.xxwxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, -7L, 0, 1);
                var v = ov.swizzle.xxwxz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(5L, 9L, 2L, -6L);
                var v = ov.swizzle.xxwxw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-8L, -8L, 6L, -2L);
                var v = ov.swizzle.xxwy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(0, -4L, -4L, -7L);
                var v = ov.swizzle.xxwyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, 6L, 6L);
                var v = ov.swizzle.xxwyy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, 5L, -3L);
                var v = ov.swizzle.xxwyz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(1, -2L, 8L, 3L);
                var v = ov.swizzle.xxwyw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, 3L, 4L);
                var v = ov.swizzle.xxwz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(2L, -8L, 0, -4L);
                var v = ov.swizzle.xxwzx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, 2L, 3L);
                var v = ov.swizzle.xxwzy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(3L, 9L, 9L, -3L);
                var v = ov.swizzle.xxwzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(9L, 8L, 2L, 0);
                var v = ov.swizzle.xxwzw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(4L, 0, 7L, 2L);
                var v = ov.swizzle.xxww;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(6L, 0, 6L, -2L);
                var v = ov.swizzle.xxwwx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, 0, -3L);
                var v = ov.swizzle.xxwwy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(1, -8L, 4L, 1);
                var v = ov.swizzle.xxwwz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-5L, 2L, 9L, 2L);
                var v = ov.swizzle.xxwww;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-4L, -9L, -3L, -7L);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
            }
            {
                var ov = new lvec4(-8L, 3L, 3L, -9L);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec4(-5L, -2L, 3L, -2L);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(9L, 7L, -9L, -1L);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(8L, 0, -8L, 1);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, 2L, -7L);
                var v = ov.swizzle.xyxxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(1, 8L, 2L, 5L);
                var v = ov.swizzle.xyxxw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(5L, 7L, -8L, 7L);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-9L, -9L, 6L, 4L);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(7L, -1L, 4L, 3L);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-7L, 6L, -7L, 0);
                var v = ov.swizzle.xyxyz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(3L, 7L, 3L, -3L);
                var v = ov.swizzle.xyxyw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-9L, -3L, -3L, -4L);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(3L, 7L, -1L, 5L);
                var v = ov.swizzle.xyxzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -5L, -6L, 8L);
                var v = ov.swizzle.xyxzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(0, -7L, -3L, 6L);
                var v = ov.swizzle.xyxzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-3L, -5L, -2L, 9L);
                var v = ov.swizzle.xyxzw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(1, -5L, 3L, -7L);
                var v = ov.swizzle.xyxw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-5L, -5L, 4L, 4L);
                var v = ov.swizzle.xyxwx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, -4L, -3L);
                var v = ov.swizzle.xyxwy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, 6L, -3L);
                var v = ov.swizzle.xyxwz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-5L, 4L, 3L, -1L);
                var v = ov.swizzle.xyxww;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(8L, 0, 6L, -2L);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec4(-5L, -5L, 2L, -9L);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-4L, 9L, 6L, 8L);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, -2L, 4L);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(8L, -5L, -9L, 8L);
                var v = ov.swizzle.xyyxz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(3L, 5L, -4L, -5L);
                var v = ov.swizzle.xyyxw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(1, 2L, 3L, -2L);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(-1L, 0, -2L, 8L);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, 0, 1);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, 2L, 0);
                var v = ov.swizzle.xyyyz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-2L, 4L, 9L, 1);
                var v = ov.swizzle.xyyyw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 4L, -7L, -2L);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-7L, 2L, 3L, -9L);
                var v = ov.swizzle.xyyzx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, -5L, 7L, 3L);
                var v = ov.swizzle.xyyzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(5L, -1L, 9L, -2L);
                var v = ov.swizzle.xyyzz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-2L, -1L, 7L, -4L);
                var v = ov.swizzle.xyyzw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, -8L, -7L, -4L);
                var v = ov.swizzle.xyyw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-3L, 9L, -6L, -6L);
                var v = ov.swizzle.xyywx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-2L, -8L, -7L, -9L);
                var v = ov.swizzle.xyywy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-5L, -3L, 0, -6L);
                var v = ov.swizzle.xyywz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(4L, -2L, -4L, 8L);
                var v = ov.swizzle.xyyww;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-6L, -3L, 3L, -6L);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec4(-4L, -7L, -5L, -6L);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(2L, -1L, 7L, 1);
                var v = ov.swizzle.xyzxx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-6L, -6L, 3L, -6L);
                var v = ov.swizzle.xyzxy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, -8L, 6L);
                var v = ov.swizzle.xyzxz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(5L, 7L, 6L, 6L);
                var v = ov.swizzle.xyzxw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-7L, 8L, 7L, -3L);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(9L, -3L, 6L, 0);
                var v = ov.swizzle.xyzyx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, -7L, 4L);
                var v = ov.swizzle.xyzyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-5L, 0, 0, -6L);
                var v = ov.swizzle.xyzyz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-5L, 0, -4L, 1);
                var v = ov.swizzle.xyzyw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, 2L, -8L);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(9L, 4L, 8L, 1);
                var v = ov.swizzle.xyzzx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 7L, 3L, 8L);
                var v = ov.swizzle.xyzzy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, -7L, -9L, 5L);
                var v = ov.swizzle.xyzzz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(8L, 2L, 5L, 9L);
                var v = ov.swizzle.xyzzw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(3L, 7L, 4L, -7L);
                var v = ov.swizzle.xyzw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-9L, -8L, 0, 7L);
                var v = ov.swizzle.xyzwx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(3L, 2L, -2L, 5L);
                var v = ov.swizzle.xyzwy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 4L, -6L, 1);
                var v = ov.swizzle.xyzwz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, 3L, 5L);
                var v = ov.swizzle.xyzww;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(4L, 5L, 6L, 8L);
                var v = ov.swizzle.xyw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec4(-5L, 8L, -9L, -8L);
                var v = ov.swizzle.xywx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(1, -5L, 6L, -2L);
                var v = ov.swizzle.xywxx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 4L, -8L, 2L);
                var v = ov.swizzle.xywxy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, -9L, -1L);
                var v = ov.swizzle.xywxz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, -7L, -1L);
                var v = ov.swizzle.xywxw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, -5L, 0);
                var v = ov.swizzle.xywy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(0, -7L, -9L, 0);
                var v = ov.swizzle.xywyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-9L, 0, 5L, -7L);
                var v = ov.swizzle.xywyy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, -6L, 2L, 9L);
                var v = ov.swizzle.xywyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-9L, 2L, 5L, 8L);
                var v = ov.swizzle.xywyw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, -1L, 8L);
                var v = ov.swizzle.xywz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(6L, -3L, -1L, 1);
                var v = ov.swizzle.xywzx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(8L, -2L, 0, 2L);
                var v = ov.swizzle.xywzy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, -6L, -3L, -7L);
                var v = ov.swizzle.xywzz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -8L, -7L, 3L);
                var v = ov.swizzle.xywzw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 6L, -3L, -4L);
                var v = ov.swizzle.xyww;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-8L, 0, 1, -4L);
                var v = ov.swizzle.xywwx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, 9L, -2L, 2L);
                var v = ov.swizzle.xywwy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-5L, 8L, -5L, -6L);
                var v = ov.swizzle.xywwz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(6L, 5L, -4L, 7L);
                var v = ov.swizzle.xywww;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, -1L, 6L);
                var v = ov.swizzle.xz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-1L, v.y);
            }
            {
                var ov = new lvec4(-9L, 2L, 8L, 3L);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec4(3L, 4L, -6L, 0);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(4L, 1, -2L, 8L);
                var v = ov.swizzle.xzxxx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(5L, -7L, 9L, 5L);
                var v = ov.swizzle.xzxxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, -9L, -9L);
                var v = ov.swizzle.xzxxz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(0, -8L, 7L, -9L);
                var v = ov.swizzle.xzxxw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, -6L, 9L, 8L);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(4L, 9L, -7L, -8L);
                var v = ov.swizzle.xzxyx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-5L, 5L, -4L, -6L);
                var v = ov.swizzle.xzxyy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-2L, -7L, -1L, -7L);
                var v = ov.swizzle.xzxyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, -7L, -4L);
                var v = ov.swizzle.xzxyw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-6L, 5L, 9L, 9L);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-5L, 7L, -6L, -1L);
                var v = ov.swizzle.xzxzx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, 6L, 0);
                var v = ov.swizzle.xzxzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, 9L, 2L, 7L);
                var v = ov.swizzle.xzxzz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-4L, 6L, -5L, -5L);
                var v = ov.swizzle.xzxzw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, -4L, -3L, -9L);
                var v = ov.swizzle.xzxw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(2L, -4L, -4L, -4L);
                var v = ov.swizzle.xzxwx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(5L, 2L, 4L, 8L);
                var v = ov.swizzle.xzxwy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(0, -4L, 2L, -6L);
                var v = ov.swizzle.xzxwz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(5L, 0, -3L, -7L);
                var v = ov.swizzle.xzxww;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-3L, 6L, 1, 3L);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(-9L, -3L, 1, 1);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-5L, 3L, 2L, 6L);
                var v = ov.swizzle.xzyxx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-6L, 2L, 9L, 2L);
                var v = ov.swizzle.xzyxy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-2L, 9L, 7L, 1);
                var v = ov.swizzle.xzyxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-3L, 2L, 5L, -5L);
                var v = ov.swizzle.xzyxw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, -9L, 0);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(7L, 5L, 1, -4L);
                var v = ov.swizzle.xzyyx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-4L, -8L, 1, -7L);
                var v = ov.swizzle.xzyyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, 0, 8L);
                var v = ov.swizzle.xzyyz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-2L, -2L, -8L, 1);
                var v = ov.swizzle.xzyyw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(0, -8L, -3L, -8L);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(4L, -9L, 3L, -6L);
                var v = ov.swizzle.xzyzx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-3L, -2L, 3L, -1L);
                var v = ov.swizzle.xzyzy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, -7L, 1);
                var v = ov.swizzle.xzyzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-4L, 1, -4L, 8L);
                var v = ov.swizzle.xzyzw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, -3L, -7L);
                var v = ov.swizzle.xzyw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(1, -2L, 9L, 3L);
                var v = ov.swizzle.xzywx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, 9L, 0);
                var v = ov.swizzle.xzywy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(3L, 3L, -5L, 7L);
                var v = ov.swizzle.xzywz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, -6L, 7L);
                var v = ov.swizzle.xzyww;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, 1, 2L);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec4(-4L, 9L, -6L, 6L);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-1L, -8L, -5L, 9L);
                var v = ov.swizzle.xzzxx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-7L, 8L, -9L, -2L);
                var v = ov.swizzle.xzzxy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(5L, -5L, -7L, -2L);
                var v = ov.swizzle.xzzxz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(8L, 0, 5L, -4L);
                var v = ov.swizzle.xzzxw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(1, 3L, 6L, -7L);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-1L, 9L, -7L, -2L);
                var v = ov.swizzle.xzzyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(4L, 6L, 6L, -7L);
                var v = ov.swizzle.xzzyy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, 3L, -1L);
                var v = ov.swizzle.xzzyz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 3L, -2L, -2L);
                var v = ov.swizzle.xzzyw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(3L, -9L, 2L, -5L);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(3L, 2L, 2L, 9L);
                var v = ov.swizzle.xzzzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(3L, 3L, -8L, 2L);
                var v = ov.swizzle.xzzzy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-8L, 6L, 0, -1L);
                var v = ov.swizzle.xzzzz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, -5L, 1);
                var v = ov.swizzle.xzzzw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(0, 2L, 5L, -1L);
                var v = ov.swizzle.xzzw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(2L, 2L, 4L, -5L);
                var v = ov.swizzle.xzzwx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, -6L, 5L);
                var v = ov.swizzle.xzzwy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(7L, -4L, -1L, 2L);
                var v = ov.swizzle.xzzwz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(0, -2L, -4L, 8L);
                var v = ov.swizzle.xzzww;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(7L, 7L, 7L, 0);
                var v = ov.swizzle.xzw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec4(7L, 3L, -8L, 0);
                var v = ov.swizzle.xzwx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(9L, -2L, 6L, -7L);
                var v = ov.swizzle.xzwxx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(8L, -1L, -1L, 0);
                var v = ov.swizzle.xzwxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, -2L, -2L, 1);
                var v = ov.swizzle.xzwxz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 6L, -8L, -7L);
                var v = ov.swizzle.xzwxw;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, -4L, 4L);
                var v = ov.swizzle.xzwy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-6L, -8L, -1L, -1L);
                var v = ov.swizzle.xzwyx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(4L, 6L, -4L, -3L);
                var v = ov.swizzle.xzwyy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-4L, 4L, 3L, -8L);
                var v = ov.swizzle.xzwyz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(4L, 4L, 5L, -9L);
                var v = ov.swizzle.xzwyw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, -6L, -7L);
                var v = ov.swizzle.xzwz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(3L, 9L, 7L, 8L);
                var v = ov.swizzle.xzwzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, 9L, 0);
                var v = ov.swizzle.xzwzy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, -3L, -4L);
                var v = ov.swizzle.xzwzz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(9L, -4L, 3L, -1L);
                var v = ov.swizzle.xzwzw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(1, -6L, -2L, 2L);
                var v = ov.swizzle.xzww;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(-6L, -7L, 5L, 9L);
                var v = ov.swizzle.xzwwx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, -6L, -4L);
                var v = ov.swizzle.xzwwy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(1, -8L, -7L, 8L);
                var v = ov.swizzle.xzwwz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 0, 5L);
                var v = ov.swizzle.xzwww;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(9L, 2L, -1L, -2L);
                var v = ov.swizzle.xw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-2L, v.y);
            }
            {
                var ov = new lvec4(-6L, -3L, 3L, 3L);
                var v = ov.swizzle.xwx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec4(-1L, 8L, 8L, 9L);
                var v = ov.swizzle.xwxx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(0, -4L, -7L, 3L);
                var v = ov.swizzle.xwxxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(6L, -3L, 0, 5L);
                var v = ov.swizzle.xwxxy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, 0, 6L);
                var v = ov.swizzle.xwxxz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-6L, -5L, -9L, -1L);
                var v = ov.swizzle.xwxxw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-3L, 4L, -6L, -4L);
                var v = ov.swizzle.xwxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-3L, -8L, 0, -9L);
                var v = ov.swizzle.xwxyx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, 6L, 3L);
                var v = ov.swizzle.xwxyy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-4L, 2L, -8L, -8L);
                var v = ov.swizzle.xwxyz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, 5L, -4L, 6L);
                var v = ov.swizzle.xwxyw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(1, -4L, 1, 3L);
                var v = ov.swizzle.xwxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-5L, -4L, 1, -2L);
                var v = ov.swizzle.xwxzx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, -6L, 0);
                var v = ov.swizzle.xwxzy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-3L, -3L, 9L, 6L);
                var v = ov.swizzle.xwxzz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-3L, -5L, -7L, 2L);
                var v = ov.swizzle.xwxzw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, -8L, -8L, 5L);
                var v = ov.swizzle.xwxw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(6L, -7L, -2L, 1);
                var v = ov.swizzle.xwxwx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-9L, 1, 1, 9L);
                var v = ov.swizzle.xwxwy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, -3L, 9L, -8L);
                var v = ov.swizzle.xwxwz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, -8L, -9L);
                var v = ov.swizzle.xwxww;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-6L, 8L, -7L, 0);
                var v = ov.swizzle.xwy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec4(4L, 5L, 9L, 1);
                var v = ov.swizzle.xwyx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-2L, -2L, 5L, 9L);
                var v = ov.swizzle.xwyxx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, -2L, -3L, 2L);
                var v = ov.swizzle.xwyxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-6L, -5L, -7L, -8L);
                var v = ov.swizzle.xwyxz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(1, 0, -3L, 0);
                var v = ov.swizzle.xwyxw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(2L, 6L, -8L, 0);
                var v = ov.swizzle.xwyy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(2L, -2L, 3L, -9L);
                var v = ov.swizzle.xwyyx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, 5L, 4L);
                var v = ov.swizzle.xwyyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, -7L, 1, 1);
                var v = ov.swizzle.xwyyz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(6L, -1L, 8L, 6L);
                var v = ov.swizzle.xwyyw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-5L, -1L, 0, 9L);
                var v = ov.swizzle.xwyz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-9L, 6L, 2L, 6L);
                var v = ov.swizzle.xwyzx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, -7L, -6L);
                var v = ov.swizzle.xwyzy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, -6L, -8L, -8L);
                var v = ov.swizzle.xwyzz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, -8L, 0);
                var v = ov.swizzle.xwyzw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, -3L, -1L);
                var v = ov.swizzle.xwyw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(5L, 7L, 1, -9L);
                var v = ov.swizzle.xwywx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-4L, -6L, -2L, 9L);
                var v = ov.swizzle.xwywy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 5L, 4L, -1L);
                var v = ov.swizzle.xwywz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(5L, 7L, 0, -6L);
                var v = ov.swizzle.xwyww;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(9L, -6L, 4L, -7L);
                var v = ov.swizzle.xwz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec4(1, 8L, 9L, 4L);
                var v = ov.swizzle.xwzx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-9L, 2L, -4L, -6L);
                var v = ov.swizzle.xwzxx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, -8L, 8L);
                var v = ov.swizzle.xwzxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-8L, 9L, 4L, -1L);
                var v = ov.swizzle.xwzxz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(4L, 3L, -3L, -9L);
                var v = ov.swizzle.xwzxw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(6L, 6L, 5L, 8L);
                var v = ov.swizzle.xwzy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-1L, 6L, -2L, -8L);
                var v = ov.swizzle.xwzyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(9L, 1, -1L, -3L);
                var v = ov.swizzle.xwzyy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, -6L, 9L, -6L);
                var v = ov.swizzle.xwzyz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-8L, -7L, -9L, -1L);
                var v = ov.swizzle.xwzyw;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(1, -6L, -7L, 2L);
                var v = ov.swizzle.xwzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(7L, -5L, -3L, -5L);
                var v = ov.swizzle.xwzzx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(3L, 8L, -1L, 6L);
                var v = ov.swizzle.xwzzy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(3L, 5L, 9L, -4L);
                var v = ov.swizzle.xwzzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(3L, 0, -3L, -2L);
                var v = ov.swizzle.xwzzw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(9L, -5L, 6L, -1L);
                var v = ov.swizzle.xwzw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(-7L, 4L, 7L, 1);
                var v = ov.swizzle.xwzwx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(0, 7L, -3L, 7L);
                var v = ov.swizzle.xwzwy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(3L, 1, -7L, -1L);
                var v = ov.swizzle.xwzwz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(9L, 2L, 0, -5L);
                var v = ov.swizzle.xwzww;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, -7L, -5L, 0);
                var v = ov.swizzle.xww;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec4(-1L, 4L, 9L, -6L);
                var v = ov.swizzle.xwwx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(5L, -5L, -3L, -8L);
                var v = ov.swizzle.xwwxx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(3L, 7L, 0, 6L);
                var v = ov.swizzle.xwwxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, 4L, 3L);
                var v = ov.swizzle.xwwxz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, -5L, -6L);
                var v = ov.swizzle.xwwxw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-6L, 2L, 2L, 1);
                var v = ov.swizzle.xwwy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(7L, -8L, 4L, 0);
                var v = ov.swizzle.xwwyx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-9L, -7L, -8L, -3L);
                var v = ov.swizzle.xwwyy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(0, 6L, 0, -3L);
                var v = ov.swizzle.xwwyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-5L, -2L, -5L, 4L);
                var v = ov.swizzle.xwwyw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, 4L, -5L);
                var v = ov.swizzle.xwwz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(0, -1L, 2L, 3L);
                var v = ov.swizzle.xwwzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-8L, -7L, 7L, 2L);
                var v = ov.swizzle.xwwzy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(1, -8L, 3L, 7L);
                var v = ov.swizzle.xwwzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, 7L, 7L, 7L);
                var v = ov.swizzle.xwwzw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -2L, -8L, 5L);
                var v = ov.swizzle.xwww;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(9L, 6L, 5L, 2L);
                var v = ov.swizzle.xwwwx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(5L, -1L, 7L, -6L);
                var v = ov.swizzle.xwwwy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-6L, -1L, 1, 1);
                var v = ov.swizzle.xwwwz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-8L, 6L, 0, -7L);
                var v = ov.swizzle.xwwww;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-6L, 0, 2L, 2L);
                var v = ov.swizzle.yx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-6L, v.y);
            }
            {
                var ov = new lvec4(9L, -6L, -2L, 2L);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec4(2L, -2L, -1L, 7L);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(3L, 7L, -4L, 2L);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, 5L, -4L);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, -9L, -7L, 6L);
                var v = ov.swizzle.yxxxz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(9L, -2L, 5L, -1L);
                var v = ov.swizzle.yxxxw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-6L, 1, 9L, -4L);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(6L, -1L, -1L, 9L);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(9L, -6L, -6L, -3L);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-5L, 3L, 0, -3L);
                var v = ov.swizzle.yxxyz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, -2L, 7L);
                var v = ov.swizzle.yxxyw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, 5L, 0);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(1, 6L, -3L, -6L);
                var v = ov.swizzle.yxxzx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(3L, -5L, -2L, -8L);
                var v = ov.swizzle.yxxzy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(9L, 1, 5L, 0);
                var v = ov.swizzle.yxxzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, -7L, 0, -3L);
                var v = ov.swizzle.yxxzw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-7L, 4L, -3L, 0);
                var v = ov.swizzle.yxxw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(2L, -3L, -9L, 0);
                var v = ov.swizzle.yxxwx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-9L, 4L, 7L, 9L);
                var v = ov.swizzle.yxxwy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, -8L, -4L, -8L);
                var v = ov.swizzle.yxxwz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-6L, 9L, -3L, 0);
                var v = ov.swizzle.yxxww;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-7L, -4L, 6L, -5L);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec4(3L, -7L, 3L, -3L);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-8L, 0, -1L, 2L);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, -1L, -2L);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(5L, 5L, -7L, 8L);
                var v = ov.swizzle.yxyxz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, -7L, -9L);
                var v = ov.swizzle.yxyxw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(7L, 2L, -9L, -2L);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(6L, 7L, 4L, -3L);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(3L, 0, -5L, 2L);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-7L, -8L, -6L, 4L);
                var v = ov.swizzle.yxyyz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, 2L, -9L);
                var v = ov.swizzle.yxyyw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 4L, -1L, -9L);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(6L, 1, -2L, 9L);
                var v = ov.swizzle.yxyzx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 4L, -2L, 5L);
                var v = ov.swizzle.yxyzy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-7L, 7L, 7L, 0);
                var v = ov.swizzle.yxyzz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-8L, -2L, 5L, -1L);
                var v = ov.swizzle.yxyzw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-5L, -7L, -8L, -8L);
                var v = ov.swizzle.yxyw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(4L, 8L, -4L, 7L);
                var v = ov.swizzle.yxywx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(8L, -2L, -9L, 1);
                var v = ov.swizzle.yxywy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, 5L, 2L);
                var v = ov.swizzle.yxywz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-2L, -9L, 4L, 5L);
                var v = ov.swizzle.yxyww;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, 1, -9L);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec4(7L, 9L, 5L, 9L);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(9L, -6L, 6L, -7L);
                var v = ov.swizzle.yxzxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-9L, -1L, 3L, -5L);
                var v = ov.swizzle.yxzxy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(5L, -2L, -5L, -8L);
                var v = ov.swizzle.yxzxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, 0, -9L);
                var v = ov.swizzle.yxzxw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(5L, -1L, -5L, -8L);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(1, 4L, 8L, -8L);
                var v = ov.swizzle.yxzyx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(7L, 0, -5L, 1);
                var v = ov.swizzle.yxzyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-6L, -9L, -1L, -5L);
                var v = ov.swizzle.yxzyz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, -7L, -3L);
                var v = ov.swizzle.yxzyw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(5L, 2L, 1, -8L);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-4L, 9L, -6L, 0);
                var v = ov.swizzle.yxzzx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(4L, 5L, -8L, -1L);
                var v = ov.swizzle.yxzzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, 1, -4L, -7L);
                var v = ov.swizzle.yxzzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-4L, 6L, 7L, 5L);
                var v = ov.swizzle.yxzzw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, 7L, 8L, -9L);
                var v = ov.swizzle.yxzw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-5L, 1, -9L, 6L);
                var v = ov.swizzle.yxzwx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(0, 0, -5L, 2L);
                var v = ov.swizzle.yxzwy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(6L, 7L, -3L, 2L);
                var v = ov.swizzle.yxzwz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, -7L, 4L, -2L);
                var v = ov.swizzle.yxzww;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(7L, 8L, -4L, 1);
                var v = ov.swizzle.yxw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec4(2L, 4L, 8L, -4L);
                var v = ov.swizzle.yxwx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(5L, -3L, 1, -6L);
                var v = ov.swizzle.yxwxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-6L, -2L, 5L, -8L);
                var v = ov.swizzle.yxwxy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 2L, 3L, -3L);
                var v = ov.swizzle.yxwxz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-1L, 9L, -9L, 4L);
                var v = ov.swizzle.yxwxw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(9L, -5L, 4L, 4L);
                var v = ov.swizzle.yxwy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(8L, -1L, 8L, -7L);
                var v = ov.swizzle.yxwyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, -6L, -7L, -8L);
                var v = ov.swizzle.yxwyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-4L, 7L, -7L, -1L);
                var v = ov.swizzle.yxwyz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-3L, 4L, 1, 6L);
                var v = ov.swizzle.yxwyw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, 6L, -4L);
                var v = ov.swizzle.yxwz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(1, -5L, 9L, 5L);
                var v = ov.swizzle.yxwzx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-3L, -2L, 1, -8L);
                var v = ov.swizzle.yxwzy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, -1L, 7L);
                var v = ov.swizzle.yxwzz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-9L, 3L, 5L, -4L);
                var v = ov.swizzle.yxwzw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(4L, 3L, -4L, -9L);
                var v = ov.swizzle.yxww;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-4L, 6L, 3L, 5L);
                var v = ov.swizzle.yxwwx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(5L, -2L, -9L, 6L);
                var v = ov.swizzle.yxwwy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, -2L, 5L, -1L);
                var v = ov.swizzle.yxwwz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(7L, 9L, 3L, -3L);
                var v = ov.swizzle.yxwww;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(1, 2L, 3L, -1L);
                var v = ov.swizzle.yy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
            }
            {
                var ov = new lvec4(-5L, -9L, 8L, 4L);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec4(-6L, 9L, -2L, 9L);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-8L, 6L, 2L, -5L);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(5L, 6L, 0, -4L);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, 0, 1);
                var v = ov.swizzle.yyxxz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, 9L, -7L);
                var v = ov.swizzle.yyxxw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(3L, 0, -9L, 8L);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(0, -3L, -3L, 1);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, 3L, 4L, -5L);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -8L, 8L, -6L);
                var v = ov.swizzle.yyxyz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, 9L, 7L, 1);
                var v = ov.swizzle.yyxyw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, 5L, 0);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(9L, 8L, 1, -7L);
                var v = ov.swizzle.yyxzx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, -8L, 0);
                var v = ov.swizzle.yyxzy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(9L, -2L, 1, -6L);
                var v = ov.swizzle.yyxzz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(9L, 2L, 9L, 4L);
                var v = ov.swizzle.yyxzw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-3L, 0, -4L, 1);
                var v = ov.swizzle.yyxw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(2L, 5L, -6L, -3L);
                var v = ov.swizzle.yyxwx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-5L, 4L, 1, 2L);
                var v = ov.swizzle.yyxwy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(6L, 7L, 7L, -2L);
                var v = ov.swizzle.yyxwz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-4L, -8L, -9L, -1L);
                var v = ov.swizzle.yyxww;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, -9L, -9L);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec4(4L, 3L, 5L, 5L);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-6L, -3L, 5L, -7L);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-9L, 2L, 8L, 8L);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, 3L, -8L, 3L);
                var v = ov.swizzle.yyyxz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-2L, 8L, 1, -8L);
                var v = ov.swizzle.yyyxw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(0, -5L, -4L, 1);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(4L, 8L, 1, -2L);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, -3L, -7L);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, -5L, -7L, -8L);
                var v = ov.swizzle.yyyyz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(0, -1L, -6L, 2L);
                var v = ov.swizzle.yyyyw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 3L, 2L, 3L);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(-8L, -8L, -5L, -1L);
                var v = ov.swizzle.yyyzx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -5L, -9L, 2L);
                var v = ov.swizzle.yyyzy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-5L, 0, -8L, 8L);
                var v = ov.swizzle.yyyzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(9L, 3L, 0, 7L);
                var v = ov.swizzle.yyyzw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -4L, -4L, 1);
                var v = ov.swizzle.yyyw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(8L, -2L, 7L, 2L);
                var v = ov.swizzle.yyywx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(6L, 0, 3L, 0);
                var v = ov.swizzle.yyywy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-3L, -8L, -9L, -7L);
                var v = ov.swizzle.yyywz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, -1L, 2L, 6L);
                var v = ov.swizzle.yyyww;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, -2L, 7L);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec4(-8L, -1L, 1, 0);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-6L, 7L, 7L, -7L);
                var v = ov.swizzle.yyzxx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 8L, -1L, 4L);
                var v = ov.swizzle.yyzxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 1, -4L, 6L);
                var v = ov.swizzle.yyzxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-1L, -3L, 3L, -9L);
                var v = ov.swizzle.yyzxw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, 9L, -6L);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(1, 0, -6L, -9L);
                var v = ov.swizzle.yyzyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(0, -4L, -3L, 0);
                var v = ov.swizzle.yyzyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, 2L, -8L);
                var v = ov.swizzle.yyzyz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(9L, 6L, 5L, -8L);
                var v = ov.swizzle.yyzyw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, 9L, 3L);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(7L, -4L, 8L, -2L);
                var v = ov.swizzle.yyzzx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, -6L, 1);
                var v = ov.swizzle.yyzzy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(6L, -2L, -6L, -9L);
                var v = ov.swizzle.yyzzz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(0, 5L, -9L, -5L);
                var v = ov.swizzle.yyzzw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-2L, 8L, -6L, -6L);
                var v = ov.swizzle.yyzw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-5L, -1L, 3L, 2L);
                var v = ov.swizzle.yyzwx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-8L, -5L, -7L, 3L);
                var v = ov.swizzle.yyzwy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(6L, 5L, 7L, 4L);
                var v = ov.swizzle.yyzwz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, 7L, 6L);
                var v = ov.swizzle.yyzww;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 4L, 2L, 3L);
                var v = ov.swizzle.yyw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec4(-8L, -2L, -4L, 9L);
                var v = ov.swizzle.yywx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(9L, 2L, -7L, 3L);
                var v = ov.swizzle.yywxx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(7L, -1L, 6L, 2L);
                var v = ov.swizzle.yywxy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(9L, -4L, 8L, -7L);
                var v = ov.swizzle.yywxz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 5L, -3L, 1);
                var v = ov.swizzle.yywxw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-9L, -2L, -4L, 0);
                var v = ov.swizzle.yywy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(3L, -2L, -1L, -5L);
                var v = ov.swizzle.yywyx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, 2L, 6L);
                var v = ov.swizzle.yywyy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(6L, -3L, -7L, 2L);
                var v = ov.swizzle.yywyz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-6L, -3L, -3L, -6L);
                var v = ov.swizzle.yywyw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-7L, -3L, -6L, -6L);
                var v = ov.swizzle.yywz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-8L, 4L, -4L, -5L);
                var v = ov.swizzle.yywzx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, -6L, 6L);
                var v = ov.swizzle.yywzy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-2L, 0, 4L, 5L);
                var v = ov.swizzle.yywzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-8L, -3L, 5L, -7L);
                var v = ov.swizzle.yywzw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, 2L, 5L, -5L);
                var v = ov.swizzle.yyww;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(7L, -9L, -6L, -7L);
                var v = ov.swizzle.yywwx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-6L, 5L, 0, -7L);
                var v = ov.swizzle.yywwy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, -7L, 3L, 5L);
                var v = ov.swizzle.yywwz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, -7L, 2L, -8L);
                var v = ov.swizzle.yywww;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, -7L, 6L);
                var v = ov.swizzle.yz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-7L, v.y);
            }
            {
                var ov = new lvec4(-6L, -6L, -5L, 5L);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec4(7L, -2L, 4L, 3L);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(7L, -5L, 4L, -5L);
                var v = ov.swizzle.yzxxx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, 0, 8L, -9L);
                var v = ov.swizzle.yzxxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, -7L, -9L, -1L);
                var v = ov.swizzle.yzxxz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, -3L, -5L);
                var v = ov.swizzle.yzxxw;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-7L, -8L, 9L, 0);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-1L, 6L, -9L, -5L);
                var v = ov.swizzle.yzxyx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(4L, -9L, -9L, -1L);
                var v = ov.swizzle.yzxyy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(3L, -1L, 8L, 3L);
                var v = ov.swizzle.yzxyz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, -6L, 9L, -7L);
                var v = ov.swizzle.yzxyw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, 8L, -9L, -6L);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(8L, 3L, 9L, 0);
                var v = ov.swizzle.yzxzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-6L, 5L, -5L, -7L);
                var v = ov.swizzle.yzxzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, 0, 8L, 8L);
                var v = ov.swizzle.yzxzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, -3L, 0);
                var v = ov.swizzle.yzxzw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-6L, 8L, 9L, 6L);
                var v = ov.swizzle.yzxw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(1, -7L, -5L, -8L);
                var v = ov.swizzle.yzxwx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(7L, -5L, -1L, -4L);
                var v = ov.swizzle.yzxwy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(8L, -6L, 2L, 7L);
                var v = ov.swizzle.yzxwz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-9L, -3L, -1L, 7L);
                var v = ov.swizzle.yzxww;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -8L, -8L, -8L);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec4(4L, 1, 8L, 3L);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(1, -9L, 1, -6L);
                var v = ov.swizzle.yzyxx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(3L, 8L, 1, 3L);
                var v = ov.swizzle.yzyxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-8L, -2L, -5L, -2L);
                var v = ov.swizzle.yzyxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, -2L, 1);
                var v = ov.swizzle.yzyxw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, 0, 8L, 6L);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-8L, 0, 9L, 8L);
                var v = ov.swizzle.yzyyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 5L, 3L, -7L);
                var v = ov.swizzle.yzyyy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, 2L, -9L);
                var v = ov.swizzle.yzyyz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(8L, -2L, -6L, 7L);
                var v = ov.swizzle.yzyyw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-3L, -4L, 9L, 0);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-5L, -8L, 8L, 7L);
                var v = ov.swizzle.yzyzx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-8L, -9L, -9L, 5L);
                var v = ov.swizzle.yzyzy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, 3L, 3L);
                var v = ov.swizzle.yzyzz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, 1, 4L, 1);
                var v = ov.swizzle.yzyzw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(9L, -3L, 3L, -8L);
                var v = ov.swizzle.yzyw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(4L, 3L, -4L, 7L);
                var v = ov.swizzle.yzywx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(8L, -5L, 2L, -6L);
                var v = ov.swizzle.yzywy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-5L, 4L, 8L, 1);
                var v = ov.swizzle.yzywz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 8L, -2L, 0);
                var v = ov.swizzle.yzyww;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, 9L, -3L);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec4(5L, -8L, -1L, -3L);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(7L, -9L, 5L, 6L);
                var v = ov.swizzle.yzzxx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, -5L, -7L, -9L);
                var v = ov.swizzle.yzzxy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(9L, -2L, -5L, -1L);
                var v = ov.swizzle.yzzxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, -8L, 2L);
                var v = ov.swizzle.yzzxw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, 2L, 9L, 1);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(7L, 1, -3L, 4L);
                var v = ov.swizzle.yzzyx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(9L, 4L, -1L, 8L);
                var v = ov.swizzle.yzzyy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(3L, -1L, -2L, 6L);
                var v = ov.swizzle.yzzyz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 0, 0, 9L);
                var v = ov.swizzle.yzzyw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(9L, -5L, 8L, 0);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(6L, 8L, -1L, -8L);
                var v = ov.swizzle.yzzzx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-3L, 1, -5L, 8L);
                var v = ov.swizzle.yzzzy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, -5L, 3L);
                var v = ov.swizzle.yzzzz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, 4L, 5L);
                var v = ov.swizzle.yzzzw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, -7L, 2L);
                var v = ov.swizzle.yzzw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(4L, 8L, -6L, -9L);
                var v = ov.swizzle.yzzwx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 7L, -8L, 3L);
                var v = ov.swizzle.yzzwy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(1, 8L, -3L, 1);
                var v = ov.swizzle.yzzwz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, 8L, -5L, -8L);
                var v = ov.swizzle.yzzww;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(9L, -4L, -1L, 7L);
                var v = ov.swizzle.yzw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
            }
            {
                var ov = new lvec4(8L, 1, 5L, -5L);
                var v = ov.swizzle.yzwx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-5L, 8L, -8L, 3L);
                var v = ov.swizzle.yzwxx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-6L, -4L, 3L, 7L);
                var v = ov.swizzle.yzwxy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, 5L, -6L, -7L);
                var v = ov.swizzle.yzwxz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-3L, -2L, -8L, 4L);
                var v = ov.swizzle.yzwxw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(3L, -2L, 7L, -4L);
                var v = ov.swizzle.yzwy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-4L, -4L, 8L, -9L);
                var v = ov.swizzle.yzwyx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-3L, 5L, -6L, -2L);
                var v = ov.swizzle.yzwyy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(9L, 8L, -3L, 2L);
                var v = ov.swizzle.yzwyz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(3L, 0, 3L, -1L);
                var v = ov.swizzle.yzwyw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(9L, -4L, 6L, 7L);
                var v = ov.swizzle.yzwz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(5L, 5L, 4L, 7L);
                var v = ov.swizzle.yzwzx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, -7L, 5L, -7L);
                var v = ov.swizzle.yzwzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-5L, 5L, 4L, -7L);
                var v = ov.swizzle.yzwzz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-3L, -1L, 1, 1);
                var v = ov.swizzle.yzwzw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, 9L, 9L);
                var v = ov.swizzle.yzww;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-7L, -1L, -7L, 7L);
                var v = ov.swizzle.yzwwx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, -3L, -4L, -2L);
                var v = ov.swizzle.yzwwy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(7L, 7L, -5L, 8L);
                var v = ov.swizzle.yzwwz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, 8L, 8L);
                var v = ov.swizzle.yzwww;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(9L, 1, 5L, -6L);
                var v = ov.swizzle.yw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6L, v.y);
            }
            {
                var ov = new lvec4(-9L, -8L, -7L, 4L);
                var v = ov.swizzle.ywx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec4(3L, -6L, 9L, -2L);
                var v = ov.swizzle.ywxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-9L, 2L, -1L, -1L);
                var v = ov.swizzle.ywxxx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(3L, -6L, 9L, -4L);
                var v = ov.swizzle.ywxxy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, -5L, -9L);
                var v = ov.swizzle.ywxxz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, -4L, 8L, 7L);
                var v = ov.swizzle.ywxxw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, -2L, -3L);
                var v = ov.swizzle.ywxy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(2L, -2L, -2L, -7L);
                var v = ov.swizzle.ywxyx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, -4L, -1L, -9L);
                var v = ov.swizzle.ywxyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-4L, -3L, 3L, -6L);
                var v = ov.swizzle.ywxyz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(3L, 2L, -3L, 5L);
                var v = ov.swizzle.ywxyw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-6L, 4L, 5L, 7L);
                var v = ov.swizzle.ywxz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-1L, -5L, 1, -3L);
                var v = ov.swizzle.ywxzx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(6L, 5L, -2L, 5L);
                var v = ov.swizzle.ywxzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, -3L, 7L);
                var v = ov.swizzle.ywxzz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(3L, -7L, 9L, 6L);
                var v = ov.swizzle.ywxzw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -4L, -7L, 8L);
                var v = ov.swizzle.ywxw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(5L, 9L, -9L, -5L);
                var v = ov.swizzle.ywxwx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-2L, -9L, -6L, 0);
                var v = ov.swizzle.ywxwy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, 3L, -1L, 6L);
                var v = ov.swizzle.ywxwz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(9L, 4L, 1, 6L);
                var v = ov.swizzle.ywxww;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, -1L, 7L);
                var v = ov.swizzle.ywy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec4(2L, 4L, -1L, 4L);
                var v = ov.swizzle.ywyx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(-9L, -6L, -2L, 5L);
                var v = ov.swizzle.ywyxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 5L, -5L, 2L);
                var v = ov.swizzle.ywyxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, 1, 0);
                var v = ov.swizzle.ywyxz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, 5L, 1, 7L);
                var v = ov.swizzle.ywyxw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(8L, -1L, 4L, 4L);
                var v = ov.swizzle.ywyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(-8L, 6L, -8L, -9L);
                var v = ov.swizzle.ywyyx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-5L, 2L, -5L, -2L);
                var v = ov.swizzle.ywyyy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(2L, 9L, 6L, 0);
                var v = ov.swizzle.ywyyz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-9L, -5L, -5L, -6L);
                var v = ov.swizzle.ywyyw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, 7L, -5L);
                var v = ov.swizzle.ywyz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(8L, 8L, -9L, -3L);
                var v = ov.swizzle.ywyzx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, 0, -2L, 4L);
                var v = ov.swizzle.ywyzy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-7L, 3L, -8L, -1L);
                var v = ov.swizzle.ywyzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(0, 5L, 6L, -2L);
                var v = ov.swizzle.ywyzw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, -1L, -1L);
                var v = ov.swizzle.ywyw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(9L, 2L, -9L, -7L);
                var v = ov.swizzle.ywywx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(9L, 1, 1, 0);
                var v = ov.swizzle.ywywy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, 5L, 0, -9L);
                var v = ov.swizzle.ywywz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(3L, 8L, -6L, 8L);
                var v = ov.swizzle.ywyww;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(7L, 5L, -7L, -4L);
                var v = ov.swizzle.ywz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec4(9L, -1L, -5L, -9L);
                var v = ov.swizzle.ywzx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-2L, -6L, 0, -4L);
                var v = ov.swizzle.ywzxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, -8L, -5L);
                var v = ov.swizzle.ywzxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-9L, -7L, 5L, 5L);
                var v = ov.swizzle.ywzxz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, 2L, 2L, 1);
                var v = ov.swizzle.ywzxw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-9L, -2L, -4L, -1L);
                var v = ov.swizzle.ywzy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(2L, -9L, 6L, -2L);
                var v = ov.swizzle.ywzyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(8L, -7L, 4L, -2L);
                var v = ov.swizzle.ywzyy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-4L, -6L, 0, -9L);
                var v = ov.swizzle.ywzyz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, 0, 5L, -4L);
                var v = ov.swizzle.ywzyw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(1, 7L, -2L, 7L);
                var v = ov.swizzle.ywzz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(6L, 5L, -9L, 5L);
                var v = ov.swizzle.ywzzx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(2L, -1L, 0, 4L);
                var v = ov.swizzle.ywzzy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(2L, -6L, -5L, -8L);
                var v = ov.swizzle.ywzzz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-6L, 3L, -6L, -3L);
                var v = ov.swizzle.ywzzw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, 7L, 4L, 9L);
                var v = ov.swizzle.ywzw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-8L, 5L, 0, 3L);
                var v = ov.swizzle.ywzwx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, 5L, -7L, 7L);
                var v = ov.swizzle.ywzwy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, 7L, -9L, -2L);
                var v = ov.swizzle.ywzwz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-9L, 6L, 3L, -7L);
                var v = ov.swizzle.ywzww;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-9L, 1, 9L, -7L);
                var v = ov.swizzle.yww;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec4(-6L, -9L, 8L, -8L);
                var v = ov.swizzle.ywwx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(0, 2L, 3L, 3L);
                var v = ov.swizzle.ywwxx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(4L, -2L, 5L, -3L);
                var v = ov.swizzle.ywwxy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, 8L, 0);
                var v = ov.swizzle.ywwxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(4L, -5L, 8L, -6L);
                var v = ov.swizzle.ywwxw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-3L, -2L, 7L, -5L);
                var v = ov.swizzle.ywwy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-6L, 3L, -9L, 8L);
                var v = ov.swizzle.ywwyx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-9L, -8L, -3L, 7L);
                var v = ov.swizzle.ywwyy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-8L, 7L, -4L, -9L);
                var v = ov.swizzle.ywwyz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, 1, 3L, -5L);
                var v = ov.swizzle.ywwyw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, 3L, 4L);
                var v = ov.swizzle.ywwz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(2L, 6L, 8L, -7L);
                var v = ov.swizzle.ywwzx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 3L, -2L, 3L);
                var v = ov.swizzle.ywwzy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-2L, -3L, 3L, 3L);
                var v = ov.swizzle.ywwzz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-1L, -4L, 1, -7L);
                var v = ov.swizzle.ywwzw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(2L, -4L, 4L, 5L);
                var v = ov.swizzle.ywww;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-9L, -7L, -5L, -5L);
                var v = ov.swizzle.ywwwx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(7L, 9L, 3L, 2L);
                var v = ov.swizzle.ywwwy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, -4L, 0);
                var v = ov.swizzle.ywwwz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(8L, 3L, -2L, 9L);
                var v = ov.swizzle.ywwww;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-4L, 1, -1L, -6L);
                var v = ov.swizzle.zx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-4L, v.y);
            }
            {
                var ov = new lvec4(6L, 9L, -6L, 5L);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(3L, 9L, 7L, 2L);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(0, 5L, -2L, 8L);
                var v = ov.swizzle.zxxxx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, -8L, 5L, 5L);
                var v = ov.swizzle.zxxxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-1L, -4L, 8L, 7L);
                var v = ov.swizzle.zxxxz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-9L, 8L, -1L, -7L);
                var v = ov.swizzle.zxxxw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-9L, 3L, -5L, 7L);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(1, -2L, 2L, 0);
                var v = ov.swizzle.zxxyx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, -8L, 9L);
                var v = ov.swizzle.zxxyy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(1, 9L, -2L, -8L);
                var v = ov.swizzle.zxxyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(1, 0, 2L, 6L);
                var v = ov.swizzle.zxxyw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, -1L, 9L);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(-8L, 6L, -8L, -9L);
                var v = ov.swizzle.zxxzx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 3L, -7L, -7L);
                var v = ov.swizzle.zxxzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-8L, -8L, 5L, -9L);
                var v = ov.swizzle.zxxzz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-4L, 0, 0, 7L);
                var v = ov.swizzle.zxxzw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(3L, -1L, 6L, 1);
                var v = ov.swizzle.zxxw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-9L, -5L, 3L, 1);
                var v = ov.swizzle.zxxwx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(2L, 9L, 6L, -8L);
                var v = ov.swizzle.zxxwy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(6L, 4L, -5L, -4L);
                var v = ov.swizzle.zxxwz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-3L, 4L, 8L, -5L);
                var v = ov.swizzle.zxxww;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, 2L, 7L, -9L);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec4(9L, 1, -1L, 3L);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(3L, -2L, 4L, 0);
                var v = ov.swizzle.zxyxx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(0, -4L, 2L, -2L);
                var v = ov.swizzle.zxyxy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, 8L, 9L, 2L);
                var v = ov.swizzle.zxyxz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(2L, -6L, -6L, 2L);
                var v = ov.swizzle.zxyxw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, -1L, -3L);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(2L, -2L, 5L, 8L);
                var v = ov.swizzle.zxyyx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-1L, 5L, -4L, 0);
                var v = ov.swizzle.zxyyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, -1L, -8L);
                var v = ov.swizzle.zxyyz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, -8L, 9L);
                var v = ov.swizzle.zxyyw;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(5L, 5L, -8L, -2L);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(1, 3L, -6L, 4L);
                var v = ov.swizzle.zxyzx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 6L, -2L, -7L);
                var v = ov.swizzle.zxyzy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(5L, 4L, 2L, -2L);
                var v = ov.swizzle.zxyzz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, 0, -2L);
                var v = ov.swizzle.zxyzw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(6L, -5L, 8L, -4L);
                var v = ov.swizzle.zxyw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(0, 2L, 8L, 9L);
                var v = ov.swizzle.zxywx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-8L, -2L, -8L, 2L);
                var v = ov.swizzle.zxywy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 6L, -7L, 9L);
                var v = ov.swizzle.zxywz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(0, -9L, -1L, -9L);
                var v = ov.swizzle.zxyww;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, 1, -5L, 4L);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec4(-3L, -7L, -4L, -8L);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(4L, -9L, 8L, 6L);
                var v = ov.swizzle.zxzxx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 6L, 3L, -1L);
                var v = ov.swizzle.zxzxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-7L, 3L, -1L, -9L);
                var v = ov.swizzle.zxzxz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, 6L, 5L, 2L);
                var v = ov.swizzle.zxzxw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, -9L, -9L);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(6L, -3L, -1L, -1L);
                var v = ov.swizzle.zxzyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, -6L, 5L);
                var v = ov.swizzle.zxzyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(0, 4L, 0, 3L);
                var v = ov.swizzle.zxzyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, 9L, 5L, -8L);
                var v = ov.swizzle.zxzyw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(3L, -2L, 3L, -1L);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(3L, 6L, -3L, -6L);
                var v = ov.swizzle.zxzzx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, 4L, 7L);
                var v = ov.swizzle.zxzzy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-5L, -2L, -6L, 4L);
                var v = ov.swizzle.zxzzz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-7L, -4L, -1L, -2L);
                var v = ov.swizzle.zxzzw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(7L, -8L, -9L, -7L);
                var v = ov.swizzle.zxzw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(9L, -7L, -1L, -2L);
                var v = ov.swizzle.zxzwx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, -1L, 4L);
                var v = ov.swizzle.zxzwy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, -9L, -6L);
                var v = ov.swizzle.zxzwz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(5L, 7L, -6L, 0);
                var v = ov.swizzle.zxzww;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, -5L, 2L, -5L);
                var v = ov.swizzle.zxw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec4(-7L, 8L, 9L, 7L);
                var v = ov.swizzle.zxwx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(8L, -6L, 5L, -4L);
                var v = ov.swizzle.zxwxx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -3L, -1L, 5L);
                var v = ov.swizzle.zxwxy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-2L, 5L, 1, 5L);
                var v = ov.swizzle.zxwxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, 0, -3L, 0);
                var v = ov.swizzle.zxwxw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, 0, 6L, 7L);
                var v = ov.swizzle.zxwy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-3L, -9L, -8L, 9L);
                var v = ov.swizzle.zxwyx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-8L, 9L, -2L, -2L);
                var v = ov.swizzle.zxwyy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-5L, 4L, 0, 1);
                var v = ov.swizzle.zxwyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(6L, 2L, 2L, 6L);
                var v = ov.swizzle.zxwyw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(2L, -7L, 4L, 7L);
                var v = ov.swizzle.zxwz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-6L, -4L, 4L, -9L);
                var v = ov.swizzle.zxwzx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(5L, -1L, 5L, -9L);
                var v = ov.swizzle.zxwzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(1, 2L, -4L, -6L);
                var v = ov.swizzle.zxwzz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(1, 2L, -5L, 9L);
                var v = ov.swizzle.zxwzw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-7L, -5L, -5L, 8L);
                var v = ov.swizzle.zxww;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(1, -8L, 9L, 6L);
                var v = ov.swizzle.zxwwx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(4L, 0, -8L, -3L);
                var v = ov.swizzle.zxwwy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-7L, 6L, -7L, 2L);
                var v = ov.swizzle.zxwwz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, -2L, -9L);
                var v = ov.swizzle.zxwww;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, 3L, 6L);
                var v = ov.swizzle.zy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-9L, v.y);
            }
            {
                var ov = new lvec4(4L, -2L, -1L, -3L);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec4(9L, 4L, 0, 4L);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(7L, -3L, 8L, 6L);
                var v = ov.swizzle.zyxxx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(1, -5L, 5L, -7L);
                var v = ov.swizzle.zyxxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, -7L, -4L, 5L);
                var v = ov.swizzle.zyxxz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -3L, 1, -5L);
                var v = ov.swizzle.zyxxw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, -2L, 0, 1);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(9L, -6L, -5L, -8L);
                var v = ov.swizzle.zyxyx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, 4L, 9L);
                var v = ov.swizzle.zyxyy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(7L, -7L, -7L, 0);
                var v = ov.swizzle.zyxyz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, 4L, 4L);
                var v = ov.swizzle.zyxyw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, 0, -9L);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-4L, -4L, -5L, -7L);
                var v = ov.swizzle.zyxzx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(4L, -7L, -5L, -2L);
                var v = ov.swizzle.zyxzy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -5L, 7L, -8L);
                var v = ov.swizzle.zyxzz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, -4L, -2L);
                var v = ov.swizzle.zyxzw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, -1L, -4L, -3L);
                var v = ov.swizzle.zyxw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-1L, -6L, 9L, 6L);
                var v = ov.swizzle.zyxwx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-9L, -4L, 5L, -8L);
                var v = ov.swizzle.zyxwy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(7L, -7L, -8L, -3L);
                var v = ov.swizzle.zyxwz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, 6L, -6L);
                var v = ov.swizzle.zyxww;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(0, -7L, -4L, -4L);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec4(-3L, -3L, -8L, -2L);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(8L, -8L, -7L, 1);
                var v = ov.swizzle.zyyxx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-8L, -3L, 5L, 6L);
                var v = ov.swizzle.zyyxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 6L, 8L, -8L);
                var v = ov.swizzle.zyyxz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(4L, 8L, -7L, 9L);
                var v = ov.swizzle.zyyxw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, 3L, -4L);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-7L, -5L, 6L, 2L);
                var v = ov.swizzle.zyyyx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, -1L, 1);
                var v = ov.swizzle.zyyyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, 0, 0, -7L);
                var v = ov.swizzle.zyyyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-7L, -7L, -7L, 0);
                var v = ov.swizzle.zyyyw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-7L, 3L, -9L, -4L);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-1L, -1L, -6L, 3L);
                var v = ov.swizzle.zyyzx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-2L, 8L, -1L, -2L);
                var v = ov.swizzle.zyyzy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-9L, 3L, 2L, -7L);
                var v = ov.swizzle.zyyzz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(8L, 4L, -5L, -4L);
                var v = ov.swizzle.zyyzw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, 9L, 0);
                var v = ov.swizzle.zyyw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(2L, 3L, 9L, -6L);
                var v = ov.swizzle.zyywx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(6L, -1L, 0, 7L);
                var v = ov.swizzle.zyywy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, -3L, 7L);
                var v = ov.swizzle.zyywz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 8L, 2L, 5L);
                var v = ov.swizzle.zyyww;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-8L, 2L, 9L, 1);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec4(7L, -8L, 2L, -4L);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-7L, 2L, 7L, -3L);
                var v = ov.swizzle.zyzxx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(2L, 3L, 8L, 2L);
                var v = ov.swizzle.zyzxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -9L, -2L, 7L);
                var v = ov.swizzle.zyzxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(1, -9L, -7L, 0);
                var v = ov.swizzle.zyzxw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, 3L, 1, 2L);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(9L, -4L, 0, -9L);
                var v = ov.swizzle.zyzyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(1, 8L, -5L, 8L);
                var v = ov.swizzle.zyzyy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(4L, 7L, -2L, 4L);
                var v = ov.swizzle.zyzyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(1, -6L, -8L, 3L);
                var v = ov.swizzle.zyzyw;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(3L, 6L, 5L, 6L);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(7L, -1L, -4L, -6L);
                var v = ov.swizzle.zyzzx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -5L, 4L, -8L);
                var v = ov.swizzle.zyzzy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(5L, 9L, -3L, 4L);
                var v = ov.swizzle.zyzzz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-6L, -9L, 3L, 3L);
                var v = ov.swizzle.zyzzw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, -2L, -3L);
                var v = ov.swizzle.zyzw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(7L, -9L, -8L, 5L);
                var v = ov.swizzle.zyzwx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(7L, 7L, 6L, 5L);
                var v = ov.swizzle.zyzwy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(1, -3L, -7L, 1);
                var v = ov.swizzle.zyzwz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-8L, -4L, -5L, -9L);
                var v = ov.swizzle.zyzww;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(0, 4L, 2L, 6L);
                var v = ov.swizzle.zyw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(4L, -7L, 2L, -4L);
                var v = ov.swizzle.zywx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-5L, 7L, 7L, 1);
                var v = ov.swizzle.zywxx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-2L, -5L, 1, -5L);
                var v = ov.swizzle.zywxy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-5L, -2L, -8L, 7L);
                var v = ov.swizzle.zywxz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 7L, 8L, 9L);
                var v = ov.swizzle.zywxw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(7L, -8L, -7L, -3L);
                var v = ov.swizzle.zywy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-3L, -1L, 6L, 1);
                var v = ov.swizzle.zywyx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(4L, 4L, 2L, -8L);
                var v = ov.swizzle.zywyy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(5L, 4L, 8L, -1L);
                var v = ov.swizzle.zywyz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-7L, 3L, -1L, -9L);
                var v = ov.swizzle.zywyw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-9L, 4L, -4L, 5L);
                var v = ov.swizzle.zywz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-1L, 2L, 6L, 5L);
                var v = ov.swizzle.zywzx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-6L, 6L, 5L, -2L);
                var v = ov.swizzle.zywzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-5L, -3L, -8L, 5L);
                var v = ov.swizzle.zywzz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-9L, 9L, 0, 3L);
                var v = ov.swizzle.zywzw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, 5L, -6L, 6L);
                var v = ov.swizzle.zyww;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-2L, 3L, 8L, 9L);
                var v = ov.swizzle.zywwx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(3L, 7L, -1L, 8L);
                var v = ov.swizzle.zywwy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-7L, 8L, 9L, 3L);
                var v = ov.swizzle.zywwz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(4L, -2L, 1, -1L);
                var v = ov.swizzle.zywww;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, 5L, -7L);
                var v = ov.swizzle.zz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var ov = new lvec4(-8L, -1L, 2L, -3L);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec4(5L, 2L, -1L, 6L);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(2L, 6L, -7L, -4L);
                var v = ov.swizzle.zzxxx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(7L, 6L, -3L, 6L);
                var v = ov.swizzle.zzxxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-3L, -6L, 2L, 8L);
                var v = ov.swizzle.zzxxz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-6L, -7L, -4L, 5L);
                var v = ov.swizzle.zzxxw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, -5L, 0, 7L);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(7L, 9L, -8L, 0);
                var v = ov.swizzle.zzxyx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, 8L, 1);
                var v = ov.swizzle.zzxyy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, -6L, 4L, 0);
                var v = ov.swizzle.zzxyz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-6L, 3L, 5L, -1L);
                var v = ov.swizzle.zzxyw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, -5L, -5L, -8L);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-8L, -5L, -8L, 8L);
                var v = ov.swizzle.zzxzx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-8L, -7L, 1, 1);
                var v = ov.swizzle.zzxzy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-6L, -6L, 9L, -1L);
                var v = ov.swizzle.zzxzz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(1, 3L, -9L, -3L);
                var v = ov.swizzle.zzxzw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(7L, -7L, -4L, 8L);
                var v = ov.swizzle.zzxw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-7L, -1L, 5L, -6L);
                var v = ov.swizzle.zzxwx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, 1, -2L, -3L);
                var v = ov.swizzle.zzxwy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, 3L, -4L, 6L);
                var v = ov.swizzle.zzxwz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 2L, 9L, -3L);
                var v = ov.swizzle.zzxww;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-2L, 9L, 2L, 2L);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec4(-7L, 6L, 5L, 4L);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(5L, -3L, -8L, -3L);
                var v = ov.swizzle.zzyxx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(4L, -3L, 2L, -4L);
                var v = ov.swizzle.zzyxy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, 0, 7L);
                var v = ov.swizzle.zzyxz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, 1, -6L, -7L);
                var v = ov.swizzle.zzyxw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(4L, 7L, 9L, -2L);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(1, 2L, -2L, -9L);
                var v = ov.swizzle.zzyyx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 5L, 0, -8L);
                var v = ov.swizzle.zzyyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-4L, -2L, -1L, 9L);
                var v = ov.swizzle.zzyyz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, -1L, -8L);
                var v = ov.swizzle.zzyyw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(2L, -9L, 7L, -8L);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(0, -9L, 5L, -3L);
                var v = ov.swizzle.zzyzx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(1, 1, 3L, -1L);
                var v = ov.swizzle.zzyzy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-3L, 4L, -7L, 9L);
                var v = ov.swizzle.zzyzz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -3L, 2L, 2L);
                var v = ov.swizzle.zzyzw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(1, -9L, -9L, -8L);
                var v = ov.swizzle.zzyw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-2L, 4L, 0, 8L);
                var v = ov.swizzle.zzywx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-5L, 9L, 2L, 7L);
                var v = ov.swizzle.zzywy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, -4L, 5L);
                var v = ov.swizzle.zzywz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-9L, -2L, -1L, 2L);
                var v = ov.swizzle.zzyww;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, -8L, -2L);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec4(2L, 9L, 4L, 8L);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(-4L, 1, -3L, -2L);
                var v = ov.swizzle.zzzxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-8L, 7L, -7L, 3L);
                var v = ov.swizzle.zzzxy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(0, 9L, 5L, -6L);
                var v = ov.swizzle.zzzxz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-9L, -6L, -7L, -1L);
                var v = ov.swizzle.zzzxw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-9L, -6L, 0, -5L);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-1L, -2L, 9L, 5L);
                var v = ov.swizzle.zzzyx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(1, 0, 6L, 2L);
                var v = ov.swizzle.zzzyy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, 7L, -6L, 2L);
                var v = ov.swizzle.zzzyz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(0, -1L, -5L, -3L);
                var v = ov.swizzle.zzzyw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-7L, 9L, 9L, 2L);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(0, 9L, 4L, 9L);
                var v = ov.swizzle.zzzzx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(5L, -5L, 2L, 0);
                var v = ov.swizzle.zzzzy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, -2L, 5L);
                var v = ov.swizzle.zzzzz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, -8L, 1);
                var v = ov.swizzle.zzzzw;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, 9L, -7L);
                var v = ov.swizzle.zzzw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(1, -5L, 2L, -2L);
                var v = ov.swizzle.zzzwx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, -6L, 8L);
                var v = ov.swizzle.zzzwy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, 3L, -4L, 8L);
                var v = ov.swizzle.zzzwz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(5L, -8L, -5L, 0);
                var v = ov.swizzle.zzzww;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, -9L, 6L);
                var v = ov.swizzle.zzw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(-8L, 6L, 1, -4L);
                var v = ov.swizzle.zzwx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-5L, 9L, -4L, -1L);
                var v = ov.swizzle.zzwxx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, 1, 9L);
                var v = ov.swizzle.zzwxy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, 1, 5L);
                var v = ov.swizzle.zzwxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, -5L, 2L);
                var v = ov.swizzle.zzwxw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-9L, -4L, -8L, -7L);
                var v = ov.swizzle.zzwy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-3L, 2L, 0, 9L);
                var v = ov.swizzle.zzwyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -7L, -4L, -2L);
                var v = ov.swizzle.zzwyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, -8L, -5L);
                var v = ov.swizzle.zzwyz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, -7L, 4L);
                var v = ov.swizzle.zzwyw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(8L, 4L, -6L, 6L);
                var v = ov.swizzle.zzwz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(2L, 3L, 8L, -3L);
                var v = ov.swizzle.zzwzx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, 8L, -3L, -4L);
                var v = ov.swizzle.zzwzy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(4L, -7L, 6L, 4L);
                var v = ov.swizzle.zzwzz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, 1, -2L);
                var v = ov.swizzle.zzwzw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, 3L, -7L, -5L);
                var v = ov.swizzle.zzww;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-9L, 8L, 2L, -7L);
                var v = ov.swizzle.zzwwx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-4L, 5L, -2L, -9L);
                var v = ov.swizzle.zzwwy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-5L, 9L, -3L, -5L);
                var v = ov.swizzle.zzwwz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, -5L, 8L);
                var v = ov.swizzle.zzwww;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-4L, 6L, -3L, 5L);
                var v = ov.swizzle.zw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var ov = new lvec4(4L, -9L, 7L, 9L);
                var v = ov.swizzle.zwx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec4(-6L, -4L, 7L, 9L);
                var v = ov.swizzle.zwxx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(6L, 4L, -5L, 5L);
                var v = ov.swizzle.zwxxx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(7L, 1, 7L, -3L);
                var v = ov.swizzle.zwxxy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, -1L, -9L, -1L);
                var v = ov.swizzle.zwxxz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-6L, -3L, -9L, -4L);
                var v = ov.swizzle.zwxxw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(3L, -2L, 6L, -6L);
                var v = ov.swizzle.zwxy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(8L, -2L, -8L, 1);
                var v = ov.swizzle.zwxyx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(9L, -2L, 9L, -9L);
                var v = ov.swizzle.zwxyy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(1, -2L, 0, -9L);
                var v = ov.swizzle.zwxyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-8L, 2L, -2L, -1L);
                var v = ov.swizzle.zwxyw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, 7L, 6L, -6L);
                var v = ov.swizzle.zwxz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(3L, 1, 7L, 2L);
                var v = ov.swizzle.zwxzx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(7L, 2L, 8L, -1L);
                var v = ov.swizzle.zwxzy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, 5L, 4L);
                var v = ov.swizzle.zwxzz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, -1L, 0, -5L);
                var v = ov.swizzle.zwxzw;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(6L, -4L, -5L, -6L);
                var v = ov.swizzle.zwxw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-2L, 7L, -1L, 8L);
                var v = ov.swizzle.zwxwx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-1L, -9L, -2L, -4L);
                var v = ov.swizzle.zwxwy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, 7L, 0, -6L);
                var v = ov.swizzle.zwxwz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(4L, -1L, -2L, 6L);
                var v = ov.swizzle.zwxww;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(4L, -5L, -4L, 7L);
                var v = ov.swizzle.zwy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec4(2L, -8L, -9L, 8L);
                var v = ov.swizzle.zwyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(6L, -6L, -3L, 7L);
                var v = ov.swizzle.zwyxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(1, -7L, 3L, 0);
                var v = ov.swizzle.zwyxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, -1L, 4L, -6L);
                var v = ov.swizzle.zwyxz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, -2L, 8L);
                var v = ov.swizzle.zwyxw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(9L, -4L, 9L, -2L);
                var v = ov.swizzle.zwyy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-3L, 9L, -9L, -6L);
                var v = ov.swizzle.zwyyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-8L, -3L, 9L, -2L);
                var v = ov.swizzle.zwyyy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-9L, 7L, -3L, -3L);
                var v = ov.swizzle.zwyyz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, 2L, 2L, -4L);
                var v = ov.swizzle.zwyyw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(5L, 4L, -2L, 4L);
                var v = ov.swizzle.zwyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(4L, -9L, 3L, -3L);
                var v = ov.swizzle.zwyzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(6L, -6L, -7L, 5L);
                var v = ov.swizzle.zwyzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, -7L, 8L);
                var v = ov.swizzle.zwyzz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(7L, 6L, -6L, -7L);
                var v = ov.swizzle.zwyzw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-6L, -7L, 8L, 8L);
                var v = ov.swizzle.zwyw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(6L, -2L, 0, 4L);
                var v = ov.swizzle.zwywx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-8L, -1L, 6L, 6L);
                var v = ov.swizzle.zwywy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-6L, -7L, 2L, 5L);
                var v = ov.swizzle.zwywz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(2L, 5L, 7L, -3L);
                var v = ov.swizzle.zwyww;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(5L, 6L, 8L, 1);
                var v = ov.swizzle.zwz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec4(-6L, 3L, 8L, -5L);
                var v = ov.swizzle.zwzx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(9L, 4L, 4L, 1);
                var v = ov.swizzle.zwzxx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(6L, 4L, -8L, 8L);
                var v = ov.swizzle.zwzxy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-5L, 3L, -7L, -2L);
                var v = ov.swizzle.zwzxz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-8L, -8L, -5L, -5L);
                var v = ov.swizzle.zwzxw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(8L, 9L, 9L, 5L);
                var v = ov.swizzle.zwzy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(2L, -2L, 6L, 2L);
                var v = ov.swizzle.zwzyx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 2L, -1L, 9L);
                var v = ov.swizzle.zwzyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(7L, 6L, -2L, 2L);
                var v = ov.swizzle.zwzyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(3L, 5L, -5L, -4L);
                var v = ov.swizzle.zwzyw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(5L, 5L, 0, -1L);
                var v = ov.swizzle.zwzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-9L, -4L, 9L, -8L);
                var v = ov.swizzle.zwzzx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, -4L, 7L);
                var v = ov.swizzle.zwzzy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -3L, -2L, 6L);
                var v = ov.swizzle.zwzzz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, -2L, -8L);
                var v = ov.swizzle.zwzzw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, 1, 2L, 4L);
                var v = ov.swizzle.zwzw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-3L, 8L, 1, 8L);
                var v = ov.swizzle.zwzwx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-2L, -5L, 8L, -3L);
                var v = ov.swizzle.zwzwy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, 8L, 3L);
                var v = ov.swizzle.zwzwz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, -8L, 6L, 7L);
                var v = ov.swizzle.zwzww;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(1, 7L, -5L, 2L);
                var v = ov.swizzle.zww;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec4(7L, 3L, -9L, -4L);
                var v = ov.swizzle.zwwx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-4L, 4L, 8L, -9L);
                var v = ov.swizzle.zwwxx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-3L, -7L, -6L, 4L);
                var v = ov.swizzle.zwwxy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(2L, -6L, -8L, 9L);
                var v = ov.swizzle.zwwxz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 1, 6L, -3L);
                var v = ov.swizzle.zwwxw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, 4L, 8L);
                var v = ov.swizzle.zwwy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(4L, 8L, -7L, -6L);
                var v = ov.swizzle.zwwyx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-7L, 4L, -6L, 8L);
                var v = ov.swizzle.zwwyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, -6L, 9L);
                var v = ov.swizzle.zwwyz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(9L, 6L, -4L, 6L);
                var v = ov.swizzle.zwwyw;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, 8L, -9L, 5L);
                var v = ov.swizzle.zwwz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(5L, 4L, 0, -3L);
                var v = ov.swizzle.zwwzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, -6L, -5L, -9L);
                var v = ov.swizzle.zwwzy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(1, 2L, -5L, 6L);
                var v = ov.swizzle.zwwzz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-9L, 9L, 9L, 5L);
                var v = ov.swizzle.zwwzw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, 2L, 8L);
                var v = ov.swizzle.zwww;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(0, 6L, -7L, 3L);
                var v = ov.swizzle.zwwwx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-9L, 7L, 0, 5L);
                var v = ov.swizzle.zwwwy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(7L, -9L, 6L, -8L);
                var v = ov.swizzle.zwwwz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(2L, -8L, 3L, -9L);
                var v = ov.swizzle.zwwww;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, -5L, 1);
                var v = ov.swizzle.wx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
            }
            {
                var ov = new lvec4(8L, -6L, 7L, 3L);
                var v = ov.swizzle.wxx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec4(3L, 8L, 9L, -9L);
                var v = ov.swizzle.wxxx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-7L, 7L, -9L, -4L);
                var v = ov.swizzle.wxxxx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, 4L, -8L);
                var v = ov.swizzle.wxxxy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(7L, -7L, -3L, -2L);
                var v = ov.swizzle.wxxxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-5L, 9L, -2L, 1);
                var v = ov.swizzle.wxxxw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-6L, -7L, 3L, 0);
                var v = ov.swizzle.wxxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(5L, -1L, -7L, 3L);
                var v = ov.swizzle.wxxyx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, 1, 0, 3L);
                var v = ov.swizzle.wxxyy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-8L, -4L, -9L, 9L);
                var v = ov.swizzle.wxxyz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, 8L, -9L);
                var v = ov.swizzle.wxxyw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, -2L, -3L);
                var v = ov.swizzle.wxxz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-3L, 5L, -2L, -1L);
                var v = ov.swizzle.wxxzx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(9L, 3L, 5L, -8L);
                var v = ov.swizzle.wxxzy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(4L, 6L, 7L, 6L);
                var v = ov.swizzle.wxxzz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(4L, 8L, -4L, 5L);
                var v = ov.swizzle.wxxzw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, -7L, 4L);
                var v = ov.swizzle.wxxw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(8L, 1, -9L, -4L);
                var v = ov.swizzle.wxxwx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-8L, 3L, -4L, -4L);
                var v = ov.swizzle.wxxwy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(0, -2L, 0, 3L);
                var v = ov.swizzle.wxxwz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(5L, -1L, 7L, 0);
                var v = ov.swizzle.wxxww;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-9L, 6L, -3L, -3L);
                var v = ov.swizzle.wxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(-5L, 1, -8L, -2L);
                var v = ov.swizzle.wxyx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(5L, -3L, 5L, 8L);
                var v = ov.swizzle.wxyxx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, 2L, 8L, 4L);
                var v = ov.swizzle.wxyxy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-5L, 6L, 3L, -2L);
                var v = ov.swizzle.wxyxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(5L, -8L, -2L, 6L);
                var v = ov.swizzle.wxyxw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(9L, -2L, -8L, -3L);
                var v = ov.swizzle.wxyy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(5L, 4L, 0, -4L);
                var v = ov.swizzle.wxyyx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(1, -3L, 6L, 3L);
                var v = ov.swizzle.wxyyy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(2L, 3L, 8L, 6L);
                var v = ov.swizzle.wxyyz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, 6L, 7L, 5L);
                var v = ov.swizzle.wxyyw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, 4L, 7L, -8L);
                var v = ov.swizzle.wxyz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(3L, -6L, 7L, -8L);
                var v = ov.swizzle.wxyzx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(7L, -5L, -5L, 0);
                var v = ov.swizzle.wxyzy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, 5L, 3L, 3L);
                var v = ov.swizzle.wxyzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(3L, 5L, 6L, 1);
                var v = ov.swizzle.wxyzw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, -2L, 7L, -3L);
                var v = ov.swizzle.wxyw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-5L, 5L, 1, -2L);
                var v = ov.swizzle.wxywx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 9L, -8L);
                var v = ov.swizzle.wxywy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(9L, 6L, 8L, 4L);
                var v = ov.swizzle.wxywz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, 9L, 9L);
                var v = ov.swizzle.wxyww;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-6L, 1, 5L, 6L);
                var v = ov.swizzle.wxz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec4(-8L, 5L, 8L, -7L);
                var v = ov.swizzle.wxzx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-9L, 5L, 3L, -6L);
                var v = ov.swizzle.wxzxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(0, 6L, -3L, 5L);
                var v = ov.swizzle.wxzxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-6L, -4L, 2L, -7L);
                var v = ov.swizzle.wxzxz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-4L, -5L, 1, -2L);
                var v = ov.swizzle.wxzxw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(4L, -6L, -1L, 6L);
                var v = ov.swizzle.wxzy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-6L, -8L, -9L, 3L);
                var v = ov.swizzle.wxzyx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-6L, -7L, 4L, 9L);
                var v = ov.swizzle.wxzyy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, 1, -4L, 8L);
                var v = ov.swizzle.wxzyz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-6L, 4L, -2L, -2L);
                var v = ov.swizzle.wxzyw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-3L, -4L, -8L, 3L);
                var v = ov.swizzle.wxzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-4L, 3L, 7L, 9L);
                var v = ov.swizzle.wxzzx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, -5L, 1);
                var v = ov.swizzle.wxzzy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(0, -4L, 1, 2L);
                var v = ov.swizzle.wxzzz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, 1, 0, 1);
                var v = ov.swizzle.wxzzw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(5L, -9L, -9L, 2L);
                var v = ov.swizzle.wxzw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(1, 2L, 0, -5L);
                var v = ov.swizzle.wxzwx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-9L, -3L, 1, 8L);
                var v = ov.swizzle.wxzwy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(2L, 9L, -9L, -1L);
                var v = ov.swizzle.wxzwz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-8L, 6L, -3L, -3L);
                var v = ov.swizzle.wxzww;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(9L, 9L, 5L, 4L);
                var v = ov.swizzle.wxw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec4(1, 3L, 9L, -2L);
                var v = ov.swizzle.wxwx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-9L, -2L, -4L, -4L);
                var v = ov.swizzle.wxwxx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(3L, -1L, 5L, -3L);
                var v = ov.swizzle.wxwxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-5L, -5L, 1, -2L);
                var v = ov.swizzle.wxwxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, 9L, 4L);
                var v = ov.swizzle.wxwxw;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(9L, 5L, -8L, -1L);
                var v = ov.swizzle.wxwy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-5L, -1L, 3L, 7L);
                var v = ov.swizzle.wxwyx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(8L, 7L, -1L, -6L);
                var v = ov.swizzle.wxwyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-4L, -4L, 1, -8L);
                var v = ov.swizzle.wxwyz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, -6L, 7L);
                var v = ov.swizzle.wxwyw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-9L, 6L, 5L, -2L);
                var v = ov.swizzle.wxwz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(3L, 5L, -5L, 3L);
                var v = ov.swizzle.wxwzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, 9L, -7L);
                var v = ov.swizzle.wxwzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-9L, 0, -5L, -5L);
                var v = ov.swizzle.wxwzz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, -9L, -7L, 8L);
                var v = ov.swizzle.wxwzw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, 5L, -6L);
                var v = ov.swizzle.wxww;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(0, 9L, -8L, 0);
                var v = ov.swizzle.wxwwx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, -9L, -4L);
                var v = ov.swizzle.wxwwy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 2L, 5L, 2L);
                var v = ov.swizzle.wxwwz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, 6L, 6L, 8L);
                var v = ov.swizzle.wxwww;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, 2L, 6L);
                var v = ov.swizzle.wy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
            }
            {
                var ov = new lvec4(-7L, -3L, -6L, -3L);
                var v = ov.swizzle.wyx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec4(-9L, 5L, -3L, -3L);
                var v = ov.swizzle.wyxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-1L, 6L, -9L, -3L);
                var v = ov.swizzle.wyxxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(1, 8L, -1L, -4L);
                var v = ov.swizzle.wyxxy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(6L, -5L, 9L, 1);
                var v = ov.swizzle.wyxxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(2L, -5L, 0, -7L);
                var v = ov.swizzle.wyxxw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-5L, -2L, -5L, -8L);
                var v = ov.swizzle.wyxy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-2L, 7L, -3L, 8L);
                var v = ov.swizzle.wyxyx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, -8L, -8L, 6L);
                var v = ov.swizzle.wyxyy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 5L, 1, 8L);
                var v = ov.swizzle.wyxyz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, 6L, 3L, 8L);
                var v = ov.swizzle.wyxyw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, 1, -1L);
                var v = ov.swizzle.wyxz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-5L, -3L, 1, 0);
                var v = ov.swizzle.wyxzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(9L, 1, 4L, 1);
                var v = ov.swizzle.wyxzy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-3L, -8L, -8L, 6L);
                var v = ov.swizzle.wyxzz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(9L, -5L, 0, 3L);
                var v = ov.swizzle.wyxzw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-4L, 9L, 9L, 2L);
                var v = ov.swizzle.wyxw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(9L, 4L, 0, 1);
                var v = ov.swizzle.wyxwx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 1, -1L, -5L);
                var v = ov.swizzle.wyxwy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, -1L, -4L, 2L);
                var v = ov.swizzle.wyxwz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-1L, 3L, 2L, -9L);
                var v = ov.swizzle.wyxww;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(6L, -3L, -8L, 1);
                var v = ov.swizzle.wyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
            }
            {
                var ov = new lvec4(-4L, -7L, -4L, -4L);
                var v = ov.swizzle.wyyx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(7L, -4L, -8L, -6L);
                var v = ov.swizzle.wyyxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, -5L, -3L);
                var v = ov.swizzle.wyyxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(2L, -8L, 0, -1L);
                var v = ov.swizzle.wyyxz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-2L, 0, 6L, 8L);
                var v = ov.swizzle.wyyxw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 8L, 8L, 1);
                var v = ov.swizzle.wyyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(4L, -6L, -5L, 6L);
                var v = ov.swizzle.wyyyx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-2L, 0, -7L, 0);
                var v = ov.swizzle.wyyyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-1L, 8L, 8L, -3L);
                var v = ov.swizzle.wyyyz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 5L, -4L, -9L);
                var v = ov.swizzle.wyyyw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(3L, -5L, 8L, -3L);
                var v = ov.swizzle.wyyz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-5L, 1, 0, -3L);
                var v = ov.swizzle.wyyzx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(2L, -2L, 6L, 6L);
                var v = ov.swizzle.wyyzy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, -1L, 4L);
                var v = ov.swizzle.wyyzz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, 9L, -2L);
                var v = ov.swizzle.wyyzw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, -1L, 3L, 5L);
                var v = ov.swizzle.wyyw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(2L, -5L, 1, -3L);
                var v = ov.swizzle.wyywx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(9L, 7L, -9L, 6L);
                var v = ov.swizzle.wyywy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, 7L, 5L, -5L);
                var v = ov.swizzle.wyywz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, -6L, 5L, 2L);
                var v = ov.swizzle.wyyww;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-5L, 2L, 3L, -9L);
                var v = ov.swizzle.wyz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec4(-3L, -1L, -4L, 1);
                var v = ov.swizzle.wyzx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-8L, 3L, 5L, -8L);
                var v = ov.swizzle.wyzxx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-5L, 2L, 0, -2L);
                var v = ov.swizzle.wyzxy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-1L, 2L, 9L, 0);
                var v = ov.swizzle.wyzxz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-9L, 6L, 3L, -5L);
                var v = ov.swizzle.wyzxw;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-2L, 0, 0, -9L);
                var v = ov.swizzle.wyzy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(4L, -5L, 4L, -1L);
                var v = ov.swizzle.wyzyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(6L, 7L, -6L, -6L);
                var v = ov.swizzle.wyzyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, -2L, -2L);
                var v = ov.swizzle.wyzyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(1, 0, -5L, 5L);
                var v = ov.swizzle.wyzyw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, -1L, 3L);
                var v = ov.swizzle.wyzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(6L, -4L, 4L, -7L);
                var v = ov.swizzle.wyzzx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, 4L, 2L, 8L);
                var v = ov.swizzle.wyzzy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 8L, 7L, -3L);
                var v = ov.swizzle.wyzzz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(9L, -4L, -6L, 2L);
                var v = ov.swizzle.wyzzw;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-9L, -4L, -2L, 7L);
                var v = ov.swizzle.wyzw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(6L, 3L, 3L, 6L);
                var v = ov.swizzle.wyzwx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(9L, -7L, -9L, -9L);
                var v = ov.swizzle.wyzwy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, -7L, -3L, -1L);
                var v = ov.swizzle.wyzwz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(9L, -6L, -2L, -1L);
                var v = ov.swizzle.wyzww;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, 6L, 4L, 1);
                var v = ov.swizzle.wyw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec4(4L, 6L, -6L, -9L);
                var v = ov.swizzle.wywx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-6L, -9L, 1, 6L);
                var v = ov.swizzle.wywxx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(3L, -2L, 5L, 7L);
                var v = ov.swizzle.wywxy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(9L, 2L, -7L, 3L);
                var v = ov.swizzle.wywxz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(9L, -7L, 6L, 8L);
                var v = ov.swizzle.wywxw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(5L, 3L, -7L, 1);
                var v = ov.swizzle.wywy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-5L, -6L, 3L, -3L);
                var v = ov.swizzle.wywyx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(2L, 5L, -2L, -2L);
                var v = ov.swizzle.wywyy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, -1L, 3L, -9L);
                var v = ov.swizzle.wywyz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(6L, 4L, 9L, -1L);
                var v = ov.swizzle.wywyw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-5L, -3L, -5L, -9L);
                var v = ov.swizzle.wywz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-2L, 4L, 1, 6L);
                var v = ov.swizzle.wywzx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-9L, 8L, 0, -3L);
                var v = ov.swizzle.wywzy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -5L, -5L, 0);
                var v = ov.swizzle.wywzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(8L, -5L, 3L, -9L);
                var v = ov.swizzle.wywzw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-6L, 7L, 4L, -8L);
                var v = ov.swizzle.wyww;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-9L, -4L, -9L, -9L);
                var v = ov.swizzle.wywwx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-9L, -8L, -6L, 5L);
                var v = ov.swizzle.wywwy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(6L, -6L, -3L, -3L);
                var v = ov.swizzle.wywwz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, -8L, 9L, -1L);
                var v = ov.swizzle.wywww;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-5L, -6L, -4L, -3L);
                var v = ov.swizzle.wz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-4L, v.y);
            }
            {
                var ov = new lvec4(5L, -9L, -2L, -3L);
                var v = ov.swizzle.wzx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec4(-5L, 2L, 9L, -2L);
                var v = ov.swizzle.wzxx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(1, 9L, -5L, 6L);
                var v = ov.swizzle.wzxxx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(7L, -7L, -9L, -7L);
                var v = ov.swizzle.wzxxy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, 2L, 7L, 1);
                var v = ov.swizzle.wzxxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-3L, -5L, 5L, 3L);
                var v = ov.swizzle.wzxxw;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, 2L, -2L, -1L);
                var v = ov.swizzle.wzxy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(4L, -2L, 4L, -9L);
                var v = ov.swizzle.wzxyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, -2L, 0);
                var v = ov.swizzle.wzxyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(1, 5L, 3L, -6L);
                var v = ov.swizzle.wzxyz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, 3L, -6L);
                var v = ov.swizzle.wzxyw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, 4L, -2L);
                var v = ov.swizzle.wzxz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-8L, -2L, 4L, -3L);
                var v = ov.swizzle.wzxzx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(8L, -3L, 0, 9L);
                var v = ov.swizzle.wzxzy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, -2L, -2L);
                var v = ov.swizzle.wzxzz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, 6L, 8L);
                var v = ov.swizzle.wzxzw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(5L, -5L, -3L, -7L);
                var v = ov.swizzle.wzxw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(4L, -9L, -5L, 0);
                var v = ov.swizzle.wzxwx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-8L, -2L, -3L, 8L);
                var v = ov.swizzle.wzxwy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-1L, 9L, 2L, -5L);
                var v = ov.swizzle.wzxwz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, -3L, -3L);
                var v = ov.swizzle.wzxww;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(7L, -1L, -1L, 0);
                var v = ov.swizzle.wzy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(9L, 2L, 7L, -3L);
                var v = ov.swizzle.wzyx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-3L, -2L, 4L, 9L);
                var v = ov.swizzle.wzyxx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-6L, -5L, 9L, 5L);
                var v = ov.swizzle.wzyxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-3L, 6L, 6L, -9L);
                var v = ov.swizzle.wzyxz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-6L, 4L, -5L, -6L);
                var v = ov.swizzle.wzyxw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(0, -1L, -9L, 3L);
                var v = ov.swizzle.wzyy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(6L, -6L, -4L, -1L);
                var v = ov.swizzle.wzyyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(4L, -4L, 1, -5L);
                var v = ov.swizzle.wzyyy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(4L, -3L, 6L, 2L);
                var v = ov.swizzle.wzyyz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 2L, 6L, 5L);
                var v = ov.swizzle.wzyyw;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, 3L, -3L, -5L);
                var v = ov.swizzle.wzyz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-9L, -6L, 2L, -1L);
                var v = ov.swizzle.wzyzx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, -4L, -6L, 2L);
                var v = ov.swizzle.wzyzy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, 0, -9L);
                var v = ov.swizzle.wzyzz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, 6L, -7L);
                var v = ov.swizzle.wzyzw;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-8L, -3L, 4L, 1);
                var v = ov.swizzle.wzyw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-4L, -5L, 1, 0);
                var v = ov.swizzle.wzywx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 4L, 7L, -4L);
                var v = ov.swizzle.wzywy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-7L, 8L, 9L, -6L);
                var v = ov.swizzle.wzywz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-8L, 3L, 4L, 9L);
                var v = ov.swizzle.wzyww;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 2L, -8L, -1L);
                var v = ov.swizzle.wzz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec4(-8L, -8L, -9L, -1L);
                var v = ov.swizzle.wzzx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-2L, 7L, -9L, 6L);
                var v = ov.swizzle.wzzxx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-5L, 8L, 7L, -3L);
                var v = ov.swizzle.wzzxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -1L, 1, 3L);
                var v = ov.swizzle.wzzxz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, 2L, -1L, 7L);
                var v = ov.swizzle.wzzxw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, 5L, 5L);
                var v = ov.swizzle.wzzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(3L, 3L, 0, -9L);
                var v = ov.swizzle.wzzyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-9L, -6L, 3L, -5L);
                var v = ov.swizzle.wzzyy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-5L, -3L, 3L, -6L);
                var v = ov.swizzle.wzzyz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 9L, 7L, -2L);
                var v = ov.swizzle.wzzyw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(5L, 0, -9L, 7L);
                var v = ov.swizzle.wzzz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(1, -6L, -7L, 6L);
                var v = ov.swizzle.wzzzx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, 0, -5L, -1L);
                var v = ov.swizzle.wzzzy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-2L, 9L, 4L, -7L);
                var v = ov.swizzle.wzzzz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -3L, 6L, 7L);
                var v = ov.swizzle.wzzzw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, 0, 6L, -8L);
                var v = ov.swizzle.wzzw;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(4L, -2L, -8L, 5L);
                var v = ov.swizzle.wzzwx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, 4L, 7L, 4L);
                var v = ov.swizzle.wzzwy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-4L, -9L, 2L, 5L);
                var v = ov.swizzle.wzzwz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(2L, -7L, 4L, 7L);
                var v = ov.swizzle.wzzww;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, -4L, -7L, -9L);
                var v = ov.swizzle.wzw;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec4(1, -3L, 3L, 4L);
                var v = ov.swizzle.wzwx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(8L, 6L, 3L, 2L);
                var v = ov.swizzle.wzwxx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(3L, -9L, 4L, 5L);
                var v = ov.swizzle.wzwxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 0, 3L, 8L);
                var v = ov.swizzle.wzwxz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-8L, -1L, -9L, -6L);
                var v = ov.swizzle.wzwxw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-2L, -1L, -7L, -3L);
                var v = ov.swizzle.wzwy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(7L, -8L, -4L, -5L);
                var v = ov.swizzle.wzwyx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(8L, -8L, 0, -3L);
                var v = ov.swizzle.wzwyy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, -7L, -2L);
                var v = ov.swizzle.wzwyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(8L, -3L, -6L, 1);
                var v = ov.swizzle.wzwyw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, 5L, 0, -4L);
                var v = ov.swizzle.wzwz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-4L, -7L, -2L, 2L);
                var v = ov.swizzle.wzwzx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-4L, -5L, 9L, -5L);
                var v = ov.swizzle.wzwzy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, 0, 6L, -1L);
                var v = ov.swizzle.wzwzz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-5L, -1L, -7L, -1L);
                var v = ov.swizzle.wzwzw;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, -4L, 4L);
                var v = ov.swizzle.wzww;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-9L, -2L, 2L, 4L);
                var v = ov.swizzle.wzwwx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(2L, -1L, 0, 4L);
                var v = ov.swizzle.wzwwy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-5L, -8L, -5L, 6L);
                var v = ov.swizzle.wzwwz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(9L, 2L, -8L, 9L);
                var v = ov.swizzle.wzwww;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(5L, -2L, 1, -3L);
                var v = ov.swizzle.ww;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
            }
            {
                var ov = new lvec4(8L, 5L, -8L, 2L);
                var v = ov.swizzle.wwx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec4(1, 6L, -6L, -8L);
                var v = ov.swizzle.wwxx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-5L, 5L, 8L, -3L);
                var v = ov.swizzle.wwxxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, -5L, 2L);
                var v = ov.swizzle.wwxxy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-5L, 6L, -9L, 2L);
                var v = ov.swizzle.wwxxz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, 4L, 0, -6L);
                var v = ov.swizzle.wwxxw;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(4L, -9L, 0, -3L);
                var v = ov.swizzle.wwxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-2L, 6L, 4L, 0);
                var v = ov.swizzle.wwxyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, -6L, -4L);
                var v = ov.swizzle.wwxyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-3L, 0, 3L, -6L);
                var v = ov.swizzle.wwxyz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-4L, 1, 9L, 8L);
                var v = ov.swizzle.wwxyw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 2L, -6L, -4L);
                var v = ov.swizzle.wwxz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(7L, -6L, -5L, -8L);
                var v = ov.swizzle.wwxzx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-3L, -8L, -7L, 4L);
                var v = ov.swizzle.wwxzy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, -7L, 1);
                var v = ov.swizzle.wwxzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, 3L, 5L, 7L);
                var v = ov.swizzle.wwxzw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(0, 8L, 5L, 9L);
                var v = ov.swizzle.wwxw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(0, 1, 8L, -4L);
                var v = ov.swizzle.wwxwx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(3L, 2L, 8L, -3L);
                var v = ov.swizzle.wwxwy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, 7L, 2L);
                var v = ov.swizzle.wwxwz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(3L, 6L, 4L, -6L);
                var v = ov.swizzle.wwxww;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, 7L, 7L);
                var v = ov.swizzle.wwy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(3L, -1L, 8L, -1L);
                var v = ov.swizzle.wwyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(3L, 1, 9L, 9L);
                var v = ov.swizzle.wwyxx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 1, 8L, 0);
                var v = ov.swizzle.wwyxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-6L, 5L, -4L, 5L);
                var v = ov.swizzle.wwyxz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, -5L, 9L);
                var v = ov.swizzle.wwyxw;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(9L, 3L, 9L, -3L);
                var v = ov.swizzle.wwyy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-4L, -4L, -8L, -9L);
                var v = ov.swizzle.wwyyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-8L, 8L, -6L, -4L);
                var v = ov.swizzle.wwyyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, -8L, 6L, 8L);
                var v = ov.swizzle.wwyyz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-2L, -8L, -1L, 1);
                var v = ov.swizzle.wwyyw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, -8L, -7L, -3L);
                var v = ov.swizzle.wwyz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(2L, 6L, 6L, -7L);
                var v = ov.swizzle.wwyzx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, -8L, 9L, -1L);
                var v = ov.swizzle.wwyzy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-1L, -7L, -8L, -9L);
                var v = ov.swizzle.wwyzz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, -5L, -7L, 8L);
                var v = ov.swizzle.wwyzw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, -1L, -1L, 6L);
                var v = ov.swizzle.wwyw;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(5L, -4L, -9L, -8L);
                var v = ov.swizzle.wwywx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-9L, 4L, -4L, 8L);
                var v = ov.swizzle.wwywy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(9L, -3L, -7L, -1L);
                var v = ov.swizzle.wwywz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, -1L, 7L);
                var v = ov.swizzle.wwyww;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, 6L, 0);
                var v = ov.swizzle.wwz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(-9L, 5L, 2L, 3L);
                var v = ov.swizzle.wwzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-9L, 6L, 7L, -7L);
                var v = ov.swizzle.wwzxx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, 1, -8L, 0);
                var v = ov.swizzle.wwzxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, 7L, 7L);
                var v = ov.swizzle.wwzxz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(7L, 8L, -7L, 7L);
                var v = ov.swizzle.wwzxw;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, 0, -8L);
                var v = ov.swizzle.wwzy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-9L, 6L, -2L, 3L);
                var v = ov.swizzle.wwzyx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(4L, 8L, 2L, 1);
                var v = ov.swizzle.wwzyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(4L, -1L, 7L, -9L);
                var v = ov.swizzle.wwzyz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, -8L, -3L);
                var v = ov.swizzle.wwzyw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -7L, 7L, 8L);
                var v = ov.swizzle.wwzz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-4L, -6L, 3L, -6L);
                var v = ov.swizzle.wwzzx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(9L, 2L, -9L, -8L);
                var v = ov.swizzle.wwzzy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, -5L, -7L);
                var v = ov.swizzle.wwzzz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, 4L, 3L, -3L);
                var v = ov.swizzle.wwzzw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, -2L, -2L);
                var v = ov.swizzle.wwzw;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-9L, -7L, -6L, -6L);
                var v = ov.swizzle.wwzwx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, -6L, -1L);
                var v = ov.swizzle.wwzwy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, 9L, 7L);
                var v = ov.swizzle.wwzwz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-4L, -2L, 3L, 2L);
                var v = ov.swizzle.wwzww;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(2L, -6L, -4L, 1);
                var v = ov.swizzle.www;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec4(9L, 3L, -7L, 5L);
                var v = ov.swizzle.wwwx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-6L, 9L, -5L, 6L);
                var v = ov.swizzle.wwwxx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 5L, -8L, -3L);
                var v = ov.swizzle.wwwxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(4L, -6L, 8L, -7L);
                var v = ov.swizzle.wwwxz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, 7L, -3L, 1);
                var v = ov.swizzle.wwwxw;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(6L, 7L, 6L, -9L);
                var v = ov.swizzle.wwwy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(8L, 7L, 3L, -3L);
                var v = ov.swizzle.wwwyx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, 0, 9L, -8L);
                var v = ov.swizzle.wwwyy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, 2L, -5L);
                var v = ov.swizzle.wwwyz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-9L, 9L, -9L, -3L);
                var v = ov.swizzle.wwwyw;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, -9L, 5L);
                var v = ov.swizzle.wwwz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(5L, -7L, 3L, -8L);
                var v = ov.swizzle.wwwzx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, 6L, 2L, -4L);
                var v = ov.swizzle.wwwzy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(2L, -2L, -4L, 1);
                var v = ov.swizzle.wwwzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-6L, -7L, -7L, 8L);
                var v = ov.swizzle.wwwzw;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(5L, 1, 6L, -2L);
                var v = ov.swizzle.wwww;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-5L, -9L, 3L, -3L);
                var v = ov.swizzle.wwwwx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, -4L, -7L, 9L);
                var v = ov.swizzle.wwwwy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(7L, 0, 8L, -7L);
                var v = ov.swizzle.wwwwz;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 1, -3L, -1L);
                var v = ov.swizzle.wwwww;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new lvec4(3L, -2L, -2L, 5L);
                var v = ov.swizzle.rr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
            }
            {
                var ov = new lvec4(0, 3L, -3L, 6L);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec4(0, 9L, 6L, -8L);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(6L, -9L, 5L, 8L);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(5L, -5L, 4L, 1);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(5L, -1L, 8L, -8L);
                var v = ov.swizzle.rrrrb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(3L, 9L, 9L, 8L);
                var v = ov.swizzle.rrrra;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, 4L, 8L, -7L);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(7L, 8L, -7L, 9L);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, 3L, -8L);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(4L, 2L, 8L, -1L);
                var v = ov.swizzle.rrrgb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, -4L, 6L);
                var v = ov.swizzle.rrrga;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(9L, 6L, -7L, 9L);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(0, -9L, 7L, -2L);
                var v = ov.swizzle.rrrbr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, 2L, -1L);
                var v = ov.swizzle.rrrbg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-3L, 4L, 5L, -6L);
                var v = ov.swizzle.rrrbb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, 8L, 9L, -8L);
                var v = ov.swizzle.rrrba;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, -5L, 8L, 6L);
                var v = ov.swizzle.rrra;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-2L, 6L, -7L, 3L);
                var v = ov.swizzle.rrrar;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, -7L, 9L, 9L);
                var v = ov.swizzle.rrrag;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-5L, 3L, -8L, -4L);
                var v = ov.swizzle.rrrab;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(7L, -9L, -7L, 8L);
                var v = ov.swizzle.rrraa;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, 5L, 6L, 5L);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec4(-6L, -2L, 4L, 0);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-6L, -3L, 9L, -9L);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(3L, -6L, 4L, -4L);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-7L, 9L, -8L, -4L);
                var v = ov.swizzle.rrgrb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, 9L, 5L);
                var v = ov.swizzle.rrgra;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, -5L, 9L);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(5L, -2L, 8L, 1);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-2L, 1, -7L, -6L);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(8L, 3L, -1L, -9L);
                var v = ov.swizzle.rrggb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(1, -7L, 6L, 8L);
                var v = ov.swizzle.rrgga;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(6L, -1L, 6L, -8L);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-8L, 4L, -7L, -7L);
                var v = ov.swizzle.rrgbr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, 2L, 6L, -6L);
                var v = ov.swizzle.rrgbg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-5L, 1, 2L, 2L);
                var v = ov.swizzle.rrgbb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, -4L, -4L, 4L);
                var v = ov.swizzle.rrgba;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(4L, 8L, 6L, 1);
                var v = ov.swizzle.rrga;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-9L, 7L, 5L, -3L);
                var v = ov.swizzle.rrgar;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, -2L, 4L);
                var v = ov.swizzle.rrgag;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-7L, 0, -8L, -2L);
                var v = ov.swizzle.rrgab;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(5L, -6L, -1L, 1);
                var v = ov.swizzle.rrgaa;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, -1L, -9L, 8L);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec4(-5L, 0, 1, 6L);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(1, 7L, 1, 7L);
                var v = ov.swizzle.rrbrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(3L, 2L, 4L, -8L);
                var v = ov.swizzle.rrbrg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(3L, 4L, -9L, -1L);
                var v = ov.swizzle.rrbrb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-8L, 3L, -8L, 2L);
                var v = ov.swizzle.rrbra;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, -9L, -4L);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(3L, -1L, -7L, 0);
                var v = ov.swizzle.rrbgr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, 9L, -4L);
                var v = ov.swizzle.rrbgg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, 6L, -8L);
                var v = ov.swizzle.rrbgb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, -2L, -1L);
                var v = ov.swizzle.rrbga;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-7L, 4L, 1, -4L);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-6L, 0, 7L, 1);
                var v = ov.swizzle.rrbbr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-7L, 0, 2L, -2L);
                var v = ov.swizzle.rrbbg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-2L, -7L, -7L, -3L);
                var v = ov.swizzle.rrbbb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, 3L, 9L);
                var v = ov.swizzle.rrbba;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, 4L, 9L);
                var v = ov.swizzle.rrba;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-3L, 9L, 8L, 5L);
                var v = ov.swizzle.rrbar;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, 3L, -9L);
                var v = ov.swizzle.rrbag;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-1L, 6L, 5L, 6L);
                var v = ov.swizzle.rrbab;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, 4L, -7L, 3L);
                var v = ov.swizzle.rrbaa;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(2L, -5L, 2L, 2L);
                var v = ov.swizzle.rra;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec4(9L, -8L, 1, -2L);
                var v = ov.swizzle.rrar;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(0, -3L, -7L, 0);
                var v = ov.swizzle.rrarr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-5L, 1, 0, -5L);
                var v = ov.swizzle.rrarg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-9L, -1L, 1, 6L);
                var v = ov.swizzle.rrarb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, 3L, -6L);
                var v = ov.swizzle.rrara;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-6L, 3L, 0, 5L);
                var v = ov.swizzle.rrag;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-2L, -1L, -3L, -7L);
                var v = ov.swizzle.rragr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, -9L, 7L, -5L);
                var v = ov.swizzle.rragg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-8L, 2L, -9L, -5L);
                var v = ov.swizzle.rragb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(8L, -6L, 5L, 4L);
                var v = ov.swizzle.rraga;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(3L, 3L, 3L, 8L);
                var v = ov.swizzle.rrab;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(6L, 9L, 7L, 8L);
                var v = ov.swizzle.rrabr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(2L, -1L, -2L, 0);
                var v = ov.swizzle.rrabg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, 5L, 6L);
                var v = ov.swizzle.rrabb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 0, 9L);
                var v = ov.swizzle.rraba;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(0, -9L, -1L, -5L);
                var v = ov.swizzle.rraa;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-4L, 4L, -6L, -7L);
                var v = ov.swizzle.rraar;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-1L, 6L, -7L, -5L);
                var v = ov.swizzle.rraag;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, -2L, -3L);
                var v = ov.swizzle.rraab;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-9L, -1L, -8L, 1);
                var v = ov.swizzle.rraaa;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(3L, 3L, -4L, -7L);
                var v = ov.swizzle.rg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
            }
            {
                var ov = new lvec4(7L, 6L, 3L, -2L);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
            }
            {
                var ov = new lvec4(-6L, -3L, -7L, -3L);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-5L, -5L, 3L, 3L);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, -4L, 2L);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-3L, 9L, -7L, -6L);
                var v = ov.swizzle.rgrrb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-4L, -6L, 4L, -3L);
                var v = ov.swizzle.rgrra;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -3L, 6L, 5L);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-7L, -9L, 5L, -7L);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, -4L, 7L, 7L);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(1, 3L, 0, -8L);
                var v = ov.swizzle.rgrgb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(9L, 4L, -9L, 0);
                var v = ov.swizzle.rgrga;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-5L, 7L, 0, -2L);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-7L, -6L, 7L, -3L);
                var v = ov.swizzle.rgrbr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, -8L, 3L, -1L);
                var v = ov.swizzle.rgrbg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, 9L, -8L, 3L);
                var v = ov.swizzle.rgrbb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(5L, -1L, -5L, -6L);
                var v = ov.swizzle.rgrba;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(8L, 6L, -8L, -8L);
                var v = ov.swizzle.rgra;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(0, 5L, 0, 8L);
                var v = ov.swizzle.rgrar;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(9L, -9L, 5L, 9L);
                var v = ov.swizzle.rgrag;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-6L, 3L, -8L, 5L);
                var v = ov.swizzle.rgrab;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-2L, -5L, 8L, 1);
                var v = ov.swizzle.rgraa;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, -3L, -1L, 7L);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
            }
            {
                var ov = new lvec4(-1L, -6L, 6L, -1L);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(5L, -7L, -2L, -8L);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, 3L, -1L, 7L);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(9L, 2L, -2L, -1L);
                var v = ov.swizzle.rggrb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-5L, -8L, 3L, 6L);
                var v = ov.swizzle.rggra;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-2L, -3L, -5L, -8L);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-2L, -3L, -1L, -1L);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, -4L, 4L, -6L);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-6L, -1L, 6L, 4L);
                var v = ov.swizzle.rgggb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-9L, 8L, 3L, -2L);
                var v = ov.swizzle.rggga;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(6L, 7L, 0, -3L);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-2L, 9L, -5L, 9L);
                var v = ov.swizzle.rggbr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, 5L, -3L);
                var v = ov.swizzle.rggbg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(8L, 3L, -5L, -7L);
                var v = ov.swizzle.rggbb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(1, 7L, -9L, -2L);
                var v = ov.swizzle.rggba;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(5L, 1, -6L, -5L);
                var v = ov.swizzle.rgga;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-9L, -5L, -2L, -9L);
                var v = ov.swizzle.rggar;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, 6L, -1L, 6L);
                var v = ov.swizzle.rggag;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, -9L, 4L);
                var v = ov.swizzle.rggab;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 1, 6L, 1);
                var v = ov.swizzle.rggaa;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-7L, 1, 7L, 3L);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(7L, v.z);
            }
            {
                var ov = new lvec4(7L, -1L, 6L, -2L);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-5L, 9L, 2L, -2L);
                var v = ov.swizzle.rgbrr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, 5L, 5L);
                var v = ov.swizzle.rgbrg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, -4L, -7L);
                var v = ov.swizzle.rgbrb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-8L, -6L, -4L, -6L);
                var v = ov.swizzle.rgbra;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, -8L, -8L);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(3L, -1L, 4L, -9L);
                var v = ov.swizzle.rgbgr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, -7L, -5L, 4L);
                var v = ov.swizzle.rgbgg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-4L, -2L, 7L, 7L);
                var v = ov.swizzle.rgbgb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(7L, -9L, 4L, 5L);
                var v = ov.swizzle.rgbga;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(4L, -9L, -7L, 2L);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(4L, -4L, -3L, 7L);
                var v = ov.swizzle.rgbbr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, 9L, 3L, 1);
                var v = ov.swizzle.rgbbg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(6L, -1L, -7L, 8L);
                var v = ov.swizzle.rgbbb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, 7L, 3L);
                var v = ov.swizzle.rgbba;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(4L, 3L, 9L, -2L);
                var v = ov.swizzle.rgba;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-6L, 1, -2L, -9L);
                var v = ov.swizzle.rgbar;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-7L, 6L, 8L, -8L);
                var v = ov.swizzle.rgbag;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 8L, -2L, 7L);
                var v = ov.swizzle.rgbab;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, -5L, -3L, 9L);
                var v = ov.swizzle.rgbaa;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-8L, -7L, -2L, -2L);
                var v = ov.swizzle.rga;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec4(-4L, -3L, -8L, 2L);
                var v = ov.swizzle.rgar;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-5L, -8L, -4L, -8L);
                var v = ov.swizzle.rgarr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-2L, 0, 0, 1);
                var v = ov.swizzle.rgarg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, 4L, 6L, 3L);
                var v = ov.swizzle.rgarb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, 9L, 0);
                var v = ov.swizzle.rgara;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, 5L, 9L, -8L);
                var v = ov.swizzle.rgag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-9L, 8L, 5L, -7L);
                var v = ov.swizzle.rgagr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, 5L, 7L);
                var v = ov.swizzle.rgagg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, -8L, 3L);
                var v = ov.swizzle.rgagb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(3L, 9L, 4L, -9L);
                var v = ov.swizzle.rgaga;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-2L, 9L, 6L, -1L);
                var v = ov.swizzle.rgab;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(7L, 9L, -8L, -7L);
                var v = ov.swizzle.rgabr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(8L, 9L, 7L, 4L);
                var v = ov.swizzle.rgabg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(6L, -1L, -1L, 7L);
                var v = ov.swizzle.rgabb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(2L, -9L, 2L, 5L);
                var v = ov.swizzle.rgaba;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, -7L, 2L, -3L);
                var v = ov.swizzle.rgaa;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-4L, -3L, 9L, 9L);
                var v = ov.swizzle.rgaar;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(6L, 2L, 0, -3L);
                var v = ov.swizzle.rgaag;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(8L, -1L, 8L, 9L);
                var v = ov.swizzle.rgaab;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -8L, 9L, 8L);
                var v = ov.swizzle.rgaaa;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 8L, 8L, 6L);
                var v = ov.swizzle.rb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
            }
            {
                var ov = new lvec4(-1L, 0, 0, -9L);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(6L, 9L, 0, 3L);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(6L, -8L, 6L, -5L);
                var v = ov.swizzle.rbrrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, -7L, -5L);
                var v = ov.swizzle.rbrrg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(0, 8L, 9L, 5L);
                var v = ov.swizzle.rbrrb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(9L, -5L, -6L, -6L);
                var v = ov.swizzle.rbrra;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, 8L, 4L);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(9L, -3L, -5L, 3L);
                var v = ov.swizzle.rbrgr;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, 2L, -4L);
                var v = ov.swizzle.rbrgg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 9L, 2L, -7L);
                var v = ov.swizzle.rbrgb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(2L, -6L, 5L, 9L);
                var v = ov.swizzle.rbrga;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(4L, -3L, 2L, 6L);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(1, -5L, 8L, 1);
                var v = ov.swizzle.rbrbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-8L, 2L, -6L, -5L);
                var v = ov.swizzle.rbrbg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(4L, 4L, -7L, 5L);
                var v = ov.swizzle.rbrbb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(1, -6L, -4L, -3L);
                var v = ov.swizzle.rbrba;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(3L, 2L, 6L, -1L);
                var v = ov.swizzle.rbra;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(9L, 2L, 3L, 9L);
                var v = ov.swizzle.rbrar;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(5L, -3L, 3L, -3L);
                var v = ov.swizzle.rbrag;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, -2L, 8L);
                var v = ov.swizzle.rbrab;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 1, 2L, -5L);
                var v = ov.swizzle.rbraa;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, -3L, 5L, 4L);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-3L, v.z);
            }
            {
                var ov = new lvec4(-9L, 6L, 8L, 6L);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-3L, -6L, -6L, 6L);
                var v = ov.swizzle.rbgrr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(2L, -2L, 6L, 1);
                var v = ov.swizzle.rbgrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(5L, -2L, -7L, -8L);
                var v = ov.swizzle.rbgrb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -9L, -6L, 5L);
                var v = ov.swizzle.rbgra;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-9L, 3L, 6L, -9L);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-3L, 7L, 7L, -9L);
                var v = ov.swizzle.rbggr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-3L, -8L, 8L, -1L);
                var v = ov.swizzle.rbggg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, 1, -1L, 2L);
                var v = ov.swizzle.rbggb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, -6L, -6L, 8L);
                var v = ov.swizzle.rbgga;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 9L, -7L);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-8L, 9L, 2L, 6L);
                var v = ov.swizzle.rbgbr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, 3L, 3L, 4L);
                var v = ov.swizzle.rbgbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -9L, 5L, -6L);
                var v = ov.swizzle.rbgbb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, 8L, -4L, 4L);
                var v = ov.swizzle.rbgba;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(8L, -6L, -3L, 3L);
                var v = ov.swizzle.rbga;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(2L, -6L, 4L, 4L);
                var v = ov.swizzle.rbgar;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(0, -4L, 4L, -4L);
                var v = ov.swizzle.rbgag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(2L, 6L, 8L, 2L);
                var v = ov.swizzle.rbgab;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, 0, 3L);
                var v = ov.swizzle.rbgaa;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, -4L, 9L);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec4(-5L, 3L, -3L, -7L);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-6L, -5L, 1, 4L);
                var v = ov.swizzle.rbbrr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(2L, -2L, -9L, 0);
                var v = ov.swizzle.rbbrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(3L, 6L, -4L, 2L);
                var v = ov.swizzle.rbbrb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(4L, -8L, 6L, -1L);
                var v = ov.swizzle.rbbra;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-9L, 8L, 2L, 9L);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-1L, 2L, 2L, -1L);
                var v = ov.swizzle.rbbgr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(8L, -1L, 0, 8L);
                var v = ov.swizzle.rbbgg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(2L, 2L, 8L, -8L);
                var v = ov.swizzle.rbbgb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, 7L, 4L);
                var v = ov.swizzle.rbbga;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -9L, -2L, 9L);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(7L, 8L, -9L, 6L);
                var v = ov.swizzle.rbbbr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-5L, -8L, -8L, 6L);
                var v = ov.swizzle.rbbbg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, 9L, 5L);
                var v = ov.swizzle.rbbbb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(1, 3L, 5L, -4L);
                var v = ov.swizzle.rbbba;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, 9L, -6L, -2L);
                var v = ov.swizzle.rbba;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-2L, -1L, -8L, 0);
                var v = ov.swizzle.rbbar;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 0, -7L);
                var v = ov.swizzle.rbbag;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, -8L, -9L);
                var v = ov.swizzle.rbbab;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, 2L, 2L);
                var v = ov.swizzle.rbbaa;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(3L, -6L, -6L, -1L);
                var v = ov.swizzle.rba;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(-2L, -3L, -5L, -8L);
                var v = ov.swizzle.rbar;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-2L, 2L, -7L, -8L);
                var v = ov.swizzle.rbarr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(1, -3L, -3L, 2L);
                var v = ov.swizzle.rbarg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(3L, 0, -8L, -6L);
                var v = ov.swizzle.rbarb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, 9L, -9L);
                var v = ov.swizzle.rbara;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-7L, 1, -5L, -2L);
                var v = ov.swizzle.rbag;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(5L, 9L, 8L, 8L);
                var v = ov.swizzle.rbagr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(1, 3L, -1L, -6L);
                var v = ov.swizzle.rbagg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, 5L, -9L, -8L);
                var v = ov.swizzle.rbagb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, 7L, -4L);
                var v = ov.swizzle.rbaga;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-8L, 1, -5L, -7L);
                var v = ov.swizzle.rbab;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(8L, -5L, -6L, -6L);
                var v = ov.swizzle.rbabr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-4L, 5L, -2L, 5L);
                var v = ov.swizzle.rbabg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, -3L, -1L);
                var v = ov.swizzle.rbabb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-8L, 2L, -3L, 2L);
                var v = ov.swizzle.rbaba;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, -7L, -8L);
                var v = ov.swizzle.rbaa;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(2L, -6L, 8L, -8L);
                var v = ov.swizzle.rbaar;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(0, 0, 0, -1L);
                var v = ov.swizzle.rbaag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(9L, -5L, 0, -6L);
                var v = ov.swizzle.rbaab;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, 3L, 9L);
                var v = ov.swizzle.rbaaa;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-4L, -3L, -5L, -6L);
                var v = ov.swizzle.ra;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-6L, v.y);
            }
            {
                var ov = new lvec4(-1L, 5L, 9L, -5L);
                var v = ov.swizzle.rar;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(-3L, 8L, -9L, -3L);
                var v = ov.swizzle.rarr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(6L, 5L, 0, 9L);
                var v = ov.swizzle.rarrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(4L, -6L, -5L, -2L);
                var v = ov.swizzle.rarrg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(6L, -8L, -5L, -3L);
                var v = ov.swizzle.rarrb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, -5L, -1L);
                var v = ov.swizzle.rarra;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 3L, 0);
                var v = ov.swizzle.rarg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-9L, 3L, 7L, 0);
                var v = ov.swizzle.rargr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-4L, 1, 7L, -6L);
                var v = ov.swizzle.rargg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(6L, -3L, 5L, -2L);
                var v = ov.swizzle.rargb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, 7L, 4L, 3L);
                var v = ov.swizzle.rarga;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, -2L, 9L);
                var v = ov.swizzle.rarb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(2L, -2L, 2L, -5L);
                var v = ov.swizzle.rarbr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, 1, -1L, 8L);
                var v = ov.swizzle.rarbg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, -8L, -6L);
                var v = ov.swizzle.rarbb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, -9L, -4L, 3L);
                var v = ov.swizzle.rarba;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, -5L, 2L);
                var v = ov.swizzle.rara;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(8L, -8L, 5L, -3L);
                var v = ov.swizzle.rarar;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 3L, -3L, -6L);
                var v = ov.swizzle.rarag;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, -7L, 6L);
                var v = ov.swizzle.rarab;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(4L, -4L, -7L, 6L);
                var v = ov.swizzle.raraa;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(0, -2L, 3L, -2L);
                var v = ov.swizzle.rag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec4(9L, -8L, 6L, 7L);
                var v = ov.swizzle.ragr;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-5L, 8L, 6L, 0);
                var v = ov.swizzle.ragrr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, 1, 4L, -4L);
                var v = ov.swizzle.ragrg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, 8L, 0, 4L);
                var v = ov.swizzle.ragrb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, 2L, -3L);
                var v = ov.swizzle.ragra;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, -4L, -2L, -7L);
                var v = ov.swizzle.ragg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(1, -2L, -2L, 9L);
                var v = ov.swizzle.raggr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, 6L, 2L, 5L);
                var v = ov.swizzle.raggg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-6L, 3L, -3L, -1L);
                var v = ov.swizzle.raggb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-1L, -7L, -8L, 3L);
                var v = ov.swizzle.ragga;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, 2L, -6L);
                var v = ov.swizzle.ragb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(6L, 3L, -1L, -5L);
                var v = ov.swizzle.ragbr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-4L, -3L, 1, -1L);
                var v = ov.swizzle.ragbg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, 3L, -5L);
                var v = ov.swizzle.ragbb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, 6L, 2L);
                var v = ov.swizzle.ragba;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, -9L, 6L);
                var v = ov.swizzle.raga;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-8L, -9L, -8L, -2L);
                var v = ov.swizzle.ragar;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-6L, 8L, -3L, 8L);
                var v = ov.swizzle.ragag;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, -6L, -7L);
                var v = ov.swizzle.ragab;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, 9L, -7L);
                var v = ov.swizzle.ragaa;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(0, -6L, -6L, 8L);
                var v = ov.swizzle.rab;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec4(5L, -2L, -6L, 4L);
                var v = ov.swizzle.rabr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-9L, -7L, 5L, 2L);
                var v = ov.swizzle.rabrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, 6L, 0);
                var v = ov.swizzle.rabrg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-3L, -5L, -8L, 7L);
                var v = ov.swizzle.rabrb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(5L, -9L, -9L, 4L);
                var v = ov.swizzle.rabra;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, -2L, 0, -1L);
                var v = ov.swizzle.rabg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-5L, 6L, 3L, 9L);
                var v = ov.swizzle.rabgr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-8L, 8L, 2L, 0);
                var v = ov.swizzle.rabgg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-9L, 9L, 1, 6L);
                var v = ov.swizzle.rabgb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(3L, -3L, -2L, -8L);
                var v = ov.swizzle.rabga;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(3L, -1L, -7L, -5L);
                var v = ov.swizzle.rabb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-2L, -5L, 4L, -6L);
                var v = ov.swizzle.rabbr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 2L, -2L, 0);
                var v = ov.swizzle.rabbg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, 8L, -3L);
                var v = ov.swizzle.rabbb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, 9L, -3L);
                var v = ov.swizzle.rabba;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -5L, 3L, 1);
                var v = ov.swizzle.raba;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-3L, 6L, 0, 2L);
                var v = ov.swizzle.rabar;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, 4L, -2L);
                var v = ov.swizzle.rabag;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(7L, 0, 0, 8L);
                var v = ov.swizzle.rabab;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-4L, 5L, -8L, 0);
                var v = ov.swizzle.rabaa;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(1, 7L, -2L, -6L);
                var v = ov.swizzle.raa;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec4(-6L, 1, 2L, 7L);
                var v = ov.swizzle.raar;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(0, 8L, -5L, -8L);
                var v = ov.swizzle.raarr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(3L, -9L, 4L, 8L);
                var v = ov.swizzle.raarg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, 1, 5L);
                var v = ov.swizzle.raarb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 1, 2L, 6L);
                var v = ov.swizzle.raara;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-7L, -9L, -3L, -6L);
                var v = ov.swizzle.raag;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-1L, -9L, -8L, 5L);
                var v = ov.swizzle.raagr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, -1L, 6L);
                var v = ov.swizzle.raagg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(3L, 6L, 4L, -2L);
                var v = ov.swizzle.raagb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(3L, -3L, 1, 4L);
                var v = ov.swizzle.raaga;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-5L, 6L, 8L, 7L);
                var v = ov.swizzle.raab;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-6L, -2L, 1, -8L);
                var v = ov.swizzle.raabr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(4L, -3L, 5L, 0);
                var v = ov.swizzle.raabg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(4L, 5L, -8L, -7L);
                var v = ov.swizzle.raabb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(7L, 6L, -7L, 0);
                var v = ov.swizzle.raaba;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(9L, 9L, -2L, -4L);
                var v = ov.swizzle.raaa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(7L, -8L, 5L, 0);
                var v = ov.swizzle.raaar;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, 9L, 2L, 1);
                var v = ov.swizzle.raaag;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(0, -7L, -1L, -1L);
                var v = ov.swizzle.raaab;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(9L, 4L, 0, -8L);
                var v = ov.swizzle.raaaa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, 1, -3L);
                var v = ov.swizzle.gr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8L, v.y);
            }
            {
                var ov = new lvec4(3L, -1L, 1, -7L);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec4(7L, 7L, 3L, -6L);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-5L, 0, -5L, 4L);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, -5L, 0, -8L);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(6L, 0, 7L, -4L);
                var v = ov.swizzle.grrrb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, -9L, 7L);
                var v = ov.swizzle.grrra;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-4L, 6L, 6L, 2L);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(6L, -9L, 2L, 9L);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(8L, -8L, 9L, -7L);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-6L, 7L, -2L, 2L);
                var v = ov.swizzle.grrgb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(5L, 5L, 5L, -9L);
                var v = ov.swizzle.grrga;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, 5L, -6L, -5L);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(4L, 1, -1L, -7L);
                var v = ov.swizzle.grrbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, 2L, -8L);
                var v = ov.swizzle.grrbg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -4L, 3L, 1);
                var v = ov.swizzle.grrbb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(0, 0, 9L, -6L);
                var v = ov.swizzle.grrba;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-8L, 5L, -6L, -6L);
                var v = ov.swizzle.grra;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(4L, 2L, 2L, -9L);
                var v = ov.swizzle.grrar;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(8L, 4L, 8L, 5L);
                var v = ov.swizzle.grrag;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, 5L, 7L);
                var v = ov.swizzle.grrab;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-1L, -2L, -8L, 4L);
                var v = ov.swizzle.grraa;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, 4L, -7L, 2L);
                var v = ov.swizzle.grg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec4(-6L, -1L, 5L, 2L);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(3L, -1L, 2L, 5L);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-5L, 8L, 1, -6L);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(9L, 0, 9L, 2L);
                var v = ov.swizzle.grgrb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-9L, -1L, 8L, 7L);
                var v = ov.swizzle.grgra;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 0, -1L);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(7L, -6L, 9L, 8L);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, 7L, -3L);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, -9L, -3L);
                var v = ov.swizzle.grggb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-6L, -9L, -6L, -7L);
                var v = ov.swizzle.grgga;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(2L, 3L, 9L, 8L);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-8L, 8L, -7L, 9L);
                var v = ov.swizzle.grgbr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(2L, -5L, 5L, -7L);
                var v = ov.swizzle.grgbg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-5L, 8L, 5L, -9L);
                var v = ov.swizzle.grgbb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-1L, -5L, -4L, 7L);
                var v = ov.swizzle.grgba;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, 2L, 9L);
                var v = ov.swizzle.grga;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(1, 8L, 8L, -7L);
                var v = ov.swizzle.grgar;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, -6L, 5L, -9L);
                var v = ov.swizzle.grgag;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-5L, -2L, 5L, -4L);
                var v = ov.swizzle.grgab;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, -1L, -3L, -9L);
                var v = ov.swizzle.grgaa;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, 6L, 6L);
                var v = ov.swizzle.grb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(-9L, -1L, -7L, -8L);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(7L, -9L, 2L, 1);
                var v = ov.swizzle.grbrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, -6L, 8L);
                var v = ov.swizzle.grbrg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, -9L, 7L, 9L);
                var v = ov.swizzle.grbrb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(0, 0, 8L, 6L);
                var v = ov.swizzle.grbra;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(9L, 6L, 2L, 3L);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(3L, -1L, -3L, 0);
                var v = ov.swizzle.grbgr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(2L, -4L, 8L, 0);
                var v = ov.swizzle.grbgg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(6L, -6L, -1L, 9L);
                var v = ov.swizzle.grbgb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, 9L, 9L, 1);
                var v = ov.swizzle.grbga;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, -3L, 5L);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-5L, -7L, -4L, 6L);
                var v = ov.swizzle.grbbr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(2L, 2L, -8L, -8L);
                var v = ov.swizzle.grbbg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-2L, 0, -7L, -3L);
                var v = ov.swizzle.grbbb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(8L, -4L, -5L, -6L);
                var v = ov.swizzle.grbba;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, -9L, -1L);
                var v = ov.swizzle.grba;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(-9L, -6L, 1, 3L);
                var v = ov.swizzle.grbar;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(8L, -8L, -8L, -1L);
                var v = ov.swizzle.grbag;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 6L, -2L, 5L);
                var v = ov.swizzle.grbab;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-3L, -6L, 7L, 6L);
                var v = ov.swizzle.grbaa;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-7L, 5L, -8L, -9L);
                var v = ov.swizzle.gra;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec4(-6L, -1L, 7L, 6L);
                var v = ov.swizzle.grar;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-9L, -7L, 1, -7L);
                var v = ov.swizzle.grarr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-4L, -3L, -5L, -2L);
                var v = ov.swizzle.grarg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(4L, 1, 6L, -9L);
                var v = ov.swizzle.grarb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-5L, 9L, -7L, 4L);
                var v = ov.swizzle.grara;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(3L, 7L, 7L, 4L);
                var v = ov.swizzle.grag;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(7L, -1L, -9L, -3L);
                var v = ov.swizzle.gragr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, -9L, 0);
                var v = ov.swizzle.gragg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(3L, -9L, -5L, 7L);
                var v = ov.swizzle.gragb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(7L, -5L, 4L, -2L);
                var v = ov.swizzle.graga;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-7L, 1, -7L, -7L);
                var v = ov.swizzle.grab;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-1L, 0, 0, -1L);
                var v = ov.swizzle.grabr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, -1L, 6L);
                var v = ov.swizzle.grabg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, -4L, -5L, 7L);
                var v = ov.swizzle.grabb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, 3L, -9L, 7L);
                var v = ov.swizzle.graba;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-8L, 8L, -1L, 4L);
                var v = ov.swizzle.graa;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-3L, -5L, 8L, 5L);
                var v = ov.swizzle.graar;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(5L, -8L, -1L, -9L);
                var v = ov.swizzle.graag;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, 5L, 7L, 1);
                var v = ov.swizzle.graab;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, 9L, -4L, 7L);
                var v = ov.swizzle.graaa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(9L, 7L, 3L, -7L);
                var v = ov.swizzle.gg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
            }
            {
                var ov = new lvec4(-7L, -3L, -1L, 8L);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec4(3L, 6L, 4L, 4L);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-6L, -6L, -3L, 7L);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -2L, 4L, -6L);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-1L, -5L, 5L, 9L);
                var v = ov.swizzle.ggrrb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, 1, 2L);
                var v = ov.swizzle.ggrra;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(6L, -4L, -7L, -3L);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(9L, -1L, -7L, 9L);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(4L, -4L, 6L, 0);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(3L, -9L, 1, -9L);
                var v = ov.swizzle.ggrgb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 6L, 2L, 8L);
                var v = ov.swizzle.ggrga;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, -9L, -1L, -8L);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(5L, -7L, -6L, -5L);
                var v = ov.swizzle.ggrbr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, -9L, 5L);
                var v = ov.swizzle.ggrbg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-1L, 7L, 2L, 9L);
                var v = ov.swizzle.ggrbb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(8L, -2L, -5L, 4L);
                var v = ov.swizzle.ggrba;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 3L, 3L, -6L);
                var v = ov.swizzle.ggra;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(4L, 3L, -2L, -2L);
                var v = ov.swizzle.ggrar;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-3L, 5L, -6L, -1L);
                var v = ov.swizzle.ggrag;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, -3L, -1L, 6L);
                var v = ov.swizzle.ggrab;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(2L, -9L, 7L, -2L);
                var v = ov.swizzle.ggraa;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-5L, 2L, 6L, -1L);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec4(-5L, 1, 8L, -5L);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-6L, -1L, 9L, 2L);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, 9L, 8L);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, -3L, 1);
                var v = ov.swizzle.gggrb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(5L, 4L, 1, -6L);
                var v = ov.swizzle.gggra;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-6L, 7L, -7L, -8L);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-7L, -5L, 6L, 9L);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(3L, 3L, 9L, -6L);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, -2L, 1, 3L);
                var v = ov.swizzle.ggggb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, -6L, -5L, 1);
                var v = ov.swizzle.gggga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-6L, -4L, 0, -1L);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(3L, 2L, -2L, 8L);
                var v = ov.swizzle.gggbr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(5L, 5L, 5L, -1L);
                var v = ov.swizzle.gggbg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, -1L, -5L, 7L);
                var v = ov.swizzle.gggbb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, 9L, -8L, 1);
                var v = ov.swizzle.gggba;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(4L, -9L, -8L, 7L);
                var v = ov.swizzle.ggga;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(8L, -3L, -2L, 3L);
                var v = ov.swizzle.gggar;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, 9L, 6L, 8L);
                var v = ov.swizzle.gggag;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(9L, -9L, -9L, 2L);
                var v = ov.swizzle.gggab;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(7L, 6L, -5L, -5L);
                var v = ov.swizzle.gggaa;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, 4L, -8L);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec4(-7L, -8L, -6L, 4L);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-7L, -4L, -9L, 4L);
                var v = ov.swizzle.ggbrr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -4L, -7L, -7L);
                var v = ov.swizzle.ggbrg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-6L, -2L, 1, 9L);
                var v = ov.swizzle.ggbrb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(9L, 7L, -6L, -6L);
                var v = ov.swizzle.ggbra;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-8L, -7L, 1, 0);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-1L, -3L, -9L, -7L);
                var v = ov.swizzle.ggbgr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-5L, 3L, -7L, 5L);
                var v = ov.swizzle.ggbgg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, -1L, 9L);
                var v = ov.swizzle.ggbgb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-7L, 6L, 6L, -8L);
                var v = ov.swizzle.ggbga;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(9L, 1, -1L, -6L);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(1, 2L, 5L, -5L);
                var v = ov.swizzle.ggbbr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(4L, 4L, 5L, -6L);
                var v = ov.swizzle.ggbbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(1, 8L, -9L, -9L);
                var v = ov.swizzle.ggbbb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-7L, -5L, -4L, 4L);
                var v = ov.swizzle.ggbba;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-4L, 2L, 9L, -4L);
                var v = ov.swizzle.ggba;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-6L, -2L, 2L, -7L);
                var v = ov.swizzle.ggbar;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(0, -2L, -3L, 2L);
                var v = ov.swizzle.ggbag;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(0, -8L, 5L, -7L);
                var v = ov.swizzle.ggbab;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(5L, 5L, -9L, 8L);
                var v = ov.swizzle.ggbaa;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(6L, 3L, -3L, 9L);
                var v = ov.swizzle.gga;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec4(-7L, 1, 4L, 6L);
                var v = ov.swizzle.ggar;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-9L, -1L, -3L, 1);
                var v = ov.swizzle.ggarr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 2L, 3L, 6L);
                var v = ov.swizzle.ggarg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, -9L, 9L);
                var v = ov.swizzle.ggarb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(0, 8L, -4L, -2L);
                var v = ov.swizzle.ggara;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-1L, 2L, -5L, 3L);
                var v = ov.swizzle.ggag;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(2L, 2L, -4L, -2L);
                var v = ov.swizzle.ggagr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-6L, 5L, -7L, 9L);
                var v = ov.swizzle.ggagg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, -9L, -7L, -5L);
                var v = ov.swizzle.ggagb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(7L, -5L, -8L, 9L);
                var v = ov.swizzle.ggaga;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-9L, -2L, 8L, -8L);
                var v = ov.swizzle.ggab;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-5L, -8L, 4L, 8L);
                var v = ov.swizzle.ggabr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, 7L, -8L);
                var v = ov.swizzle.ggabg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 0, -9L, -5L);
                var v = ov.swizzle.ggabb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(5L, 0, 3L, -6L);
                var v = ov.swizzle.ggaba;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-6L, 0, 5L, 7L);
                var v = ov.swizzle.ggaa;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(4L, -3L, -8L, -3L);
                var v = ov.swizzle.ggaar;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 4L, 2L, 4L);
                var v = ov.swizzle.ggaag;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, -3L, -9L);
                var v = ov.swizzle.ggaab;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-3L, -6L, 7L, 3L);
                var v = ov.swizzle.ggaaa;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-8L, 5L, 5L, 6L);
                var v = ov.swizzle.gb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var ov = new lvec4(-7L, -9L, 0, 8L);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec4(-9L, 1, 8L, 6L);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-1L, 1, -3L, -8L);
                var v = ov.swizzle.gbrrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(5L, 1, -3L, 2L);
                var v = ov.swizzle.gbrrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(0, -2L, 8L, 1);
                var v = ov.swizzle.gbrrb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(6L, 2L, 7L, 4L);
                var v = ov.swizzle.gbrra;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, 0, 1, 9L);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-3L, 0, -7L, -1L);
                var v = ov.swizzle.gbrgr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-5L, -8L, 9L, 5L);
                var v = ov.swizzle.gbrgg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-2L, 9L, -3L, -8L);
                var v = ov.swizzle.gbrgb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-5L, -6L, -3L, 8L);
                var v = ov.swizzle.gbrga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, -5L, -3L, -2L);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(2L, 5L, 2L, 6L);
                var v = ov.swizzle.gbrbr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, 4L, 0, -4L);
                var v = ov.swizzle.gbrbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, 0, -9L);
                var v = ov.swizzle.gbrbb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, -9L, -3L, -1L);
                var v = ov.swizzle.gbrba;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(3L, 2L, 2L, 6L);
                var v = ov.swizzle.gbra;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-2L, 7L, 9L, -1L);
                var v = ov.swizzle.gbrar;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, -1L, 5L, 9L);
                var v = ov.swizzle.gbrag;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(9L, -9L, -3L, -3L);
                var v = ov.swizzle.gbrab;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, 6L, 6L);
                var v = ov.swizzle.gbraa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-8L, -1L, -4L, -1L);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(-8L, -5L, -5L, -5L);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(8L, -3L, -7L, -6L);
                var v = ov.swizzle.gbgrr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, 2L, 4L, 8L);
                var v = ov.swizzle.gbgrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-2L, 5L, -9L, -5L);
                var v = ov.swizzle.gbgrb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-6L, -1L, 7L, 5L);
                var v = ov.swizzle.gbgra;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-8L, 9L, 4L, -2L);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(3L, 7L, -3L, -1L);
                var v = ov.swizzle.gbggr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, 6L, -3L, -3L);
                var v = ov.swizzle.gbggg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, 8L, -6L);
                var v = ov.swizzle.gbggb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, 2L, 5L);
                var v = ov.swizzle.gbgga;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, 9L, 7L, 7L);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-4L, 3L, 0, 0);
                var v = ov.swizzle.gbgbr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, -1L, 6L);
                var v = ov.swizzle.gbgbg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(3L, 7L, -3L, 7L);
                var v = ov.swizzle.gbgbb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-1L, 2L, -2L, 0);
                var v = ov.swizzle.gbgba;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, 5L, 2L, -5L);
                var v = ov.swizzle.gbga;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(9L, -2L, 1, -9L);
                var v = ov.swizzle.gbgar;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-7L, 3L, 3L, 1);
                var v = ov.swizzle.gbgag;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(8L, 2L, -2L, 7L);
                var v = ov.swizzle.gbgab;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, -7L, -7L, -9L);
                var v = ov.swizzle.gbgaa;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(6L, -2L, 1, 2L);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec4(-5L, 5L, 9L, 0);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-9L, 0, 5L, 9L);
                var v = ov.swizzle.gbbrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, 4L, 7L);
                var v = ov.swizzle.gbbrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, -7L, 2L);
                var v = ov.swizzle.gbbrb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, 3L, 5L);
                var v = ov.swizzle.gbbra;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(7L, 9L, -8L, 0);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-5L, 5L, 5L, -3L);
                var v = ov.swizzle.gbbgr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, -2L, -4L, 7L);
                var v = ov.swizzle.gbbgg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, -9L, 3L);
                var v = ov.swizzle.gbbgb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, 0, 0, -6L);
                var v = ov.swizzle.gbbga;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-8L, -4L, -9L, 6L);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-7L, 4L, -9L, 9L);
                var v = ov.swizzle.gbbbr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-9L, -5L, -7L, 5L);
                var v = ov.swizzle.gbbbg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(8L, -5L, -5L, 5L);
                var v = ov.swizzle.gbbbb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(7L, 8L, 4L, -4L);
                var v = ov.swizzle.gbbba;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-5L, -2L, 4L, 9L);
                var v = ov.swizzle.gbba;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(7L, -6L, 2L, 6L);
                var v = ov.swizzle.gbbar;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-2L, -3L, 0, 1);
                var v = ov.swizzle.gbbag;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(1, 7L, 7L, -3L);
                var v = ov.swizzle.gbbab;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -1L, 3L, -1L);
                var v = ov.swizzle.gbbaa;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(5L, -6L, -4L, 9L);
                var v = ov.swizzle.gba;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec4(-4L, 7L, -9L, 8L);
                var v = ov.swizzle.gbar;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(5L, -4L, -6L, -3L);
                var v = ov.swizzle.gbarr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-6L, 6L, 1, 5L);
                var v = ov.swizzle.gbarg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, -9L, 0);
                var v = ov.swizzle.gbarb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, -2L, -7L, 5L);
                var v = ov.swizzle.gbara;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-5L, -6L, 4L, 1);
                var v = ov.swizzle.gbag;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(7L, 1, -5L, -7L);
                var v = ov.swizzle.gbagr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, -4L, 8L, -9L);
                var v = ov.swizzle.gbagg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-8L, -5L, -5L, -9L);
                var v = ov.swizzle.gbagb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-6L, -4L, 1, -8L);
                var v = ov.swizzle.gbaga;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, 7L, 4L, -5L);
                var v = ov.swizzle.gbab;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(5L, 1, 4L, 1);
                var v = ov.swizzle.gbabr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-1L, 2L, 8L, -3L);
                var v = ov.swizzle.gbabg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 7L, -5L, -8L);
                var v = ov.swizzle.gbabb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, 0, 3L);
                var v = ov.swizzle.gbaba;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-8L, -9L, 6L, 2L);
                var v = ov.swizzle.gbaa;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(-7L, 1, 7L, -4L);
                var v = ov.swizzle.gbaar;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-3L, -9L, 3L, 7L);
                var v = ov.swizzle.gbaag;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-1L, -8L, 8L, 6L);
                var v = ov.swizzle.gbaab;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 9L, -5L, 5L);
                var v = ov.swizzle.gbaaa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, -4L, 5L, 3L);
                var v = ov.swizzle.ga;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(3L, v.y);
            }
            {
                var ov = new lvec4(5L, -5L, 0, 9L);
                var v = ov.swizzle.gar;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec4(0, -6L, -6L, -8L);
                var v = ov.swizzle.garr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-3L, -7L, 0, -8L);
                var v = ov.swizzle.garrr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(0, 2L, -7L, 3L);
                var v = ov.swizzle.garrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 9L, 7L, -2L);
                var v = ov.swizzle.garrb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, 2L, -9L);
                var v = ov.swizzle.garra;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-9L, 7L, 7L, -3L);
                var v = ov.swizzle.garg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(3L, -4L, 6L, 4L);
                var v = ov.swizzle.gargr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, 3L, -7L, 2L);
                var v = ov.swizzle.gargg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, -7L, -4L, -6L);
                var v = ov.swizzle.gargb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(3L, 5L, -4L, -3L);
                var v = ov.swizzle.garga;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-8L, 9L, 5L, 7L);
                var v = ov.swizzle.garb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-3L, -1L, -2L, 6L);
                var v = ov.swizzle.garbr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(5L, -4L, 5L, 4L);
                var v = ov.swizzle.garbg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-3L, 0, -1L, -2L);
                var v = ov.swizzle.garbb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(8L, 2L, -4L, -8L);
                var v = ov.swizzle.garba;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-1L, -5L, 4L, -7L);
                var v = ov.swizzle.gara;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(5L, -4L, 2L, -6L);
                var v = ov.swizzle.garar;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-6L, -2L, 8L, -2L);
                var v = ov.swizzle.garag;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, 0, 8L);
                var v = ov.swizzle.garab;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(1, -9L, 0, -3L);
                var v = ov.swizzle.garaa;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(1, 0, -9L, -9L);
                var v = ov.swizzle.gag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec4(-8L, -3L, 8L, 0);
                var v = ov.swizzle.gagr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(6L, 1, 6L, 0);
                var v = ov.swizzle.gagrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-2L, -5L, 1, 3L);
                var v = ov.swizzle.gagrg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(4L, 8L, 2L, -8L);
                var v = ov.swizzle.gagrb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, 9L, -4L);
                var v = ov.swizzle.gagra;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(5L, -3L, -7L, 3L);
                var v = ov.swizzle.gagg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(0, 2L, -1L, 9L);
                var v = ov.swizzle.gaggr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(1, 1, -7L, 9L);
                var v = ov.swizzle.gaggg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-6L, 5L, -9L, -3L);
                var v = ov.swizzle.gaggb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(4L, 2L, 9L, -4L);
                var v = ov.swizzle.gagga;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(4L, 7L, 0, -1L);
                var v = ov.swizzle.gagb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(7L, -7L, 3L, -3L);
                var v = ov.swizzle.gagbr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-6L, 2L, 4L, 5L);
                var v = ov.swizzle.gagbg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(9L, 5L, -4L, 4L);
                var v = ov.swizzle.gagbb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-5L, 5L, 0, 3L);
                var v = ov.swizzle.gagba;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-1L, -7L, -8L, -1L);
                var v = ov.swizzle.gaga;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(-8L, -2L, 6L, -9L);
                var v = ov.swizzle.gagar;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(8L, 9L, -3L, 5L);
                var v = ov.swizzle.gagag;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(6L, -6L, 8L, -7L);
                var v = ov.swizzle.gagab;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, -5L, 2L);
                var v = ov.swizzle.gagaa;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-8L, -8L, -3L, -9L);
                var v = ov.swizzle.gab;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-3L, v.z);
            }
            {
                var ov = new lvec4(-6L, -2L, 0, -1L);
                var v = ov.swizzle.gabr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-2L, -4L, -7L, -9L);
                var v = ov.swizzle.gabrr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, 5L, 3L, 6L);
                var v = ov.swizzle.gabrg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, 9L, -2L, -6L);
                var v = ov.swizzle.gabrb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, 3L, 6L);
                var v = ov.swizzle.gabra;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(8L, -9L, -8L, -4L);
                var v = ov.swizzle.gabg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-6L, -6L, -3L, 8L);
                var v = ov.swizzle.gabgr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -7L, 5L, -3L);
                var v = ov.swizzle.gabgg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(3L, -9L, -4L, 6L);
                var v = ov.swizzle.gabgb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, 6L, -4L);
                var v = ov.swizzle.gabga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, 3L, 1);
                var v = ov.swizzle.gabb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-2L, 2L, 8L, 1);
                var v = ov.swizzle.gabbr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-4L, -9L, -2L, -4L);
                var v = ov.swizzle.gabbg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-4L, 6L, -1L, -6L);
                var v = ov.swizzle.gabbb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-3L, 5L, -4L, -6L);
                var v = ov.swizzle.gabba;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(1, 8L, 8L, 4L);
                var v = ov.swizzle.gaba;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-9L, 9L, 2L, 9L);
                var v = ov.swizzle.gabar;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, 5L, 4L, -4L);
                var v = ov.swizzle.gabag;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, 8L, -5L, -4L);
                var v = ov.swizzle.gabab;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-6L, -6L, 1, -4L);
                var v = ov.swizzle.gabaa;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(7L, -1L, -5L, -1L);
                var v = ov.swizzle.gaa;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(5L, -1L, -9L, -7L);
                var v = ov.swizzle.gaar;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(8L, -8L, -3L, 5L);
                var v = ov.swizzle.gaarr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(1, -1L, -3L, 2L);
                var v = ov.swizzle.gaarg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(5L, -8L, 1, 1);
                var v = ov.swizzle.gaarb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-9L, -8L, 6L, 7L);
                var v = ov.swizzle.gaara;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-5L, -7L, -7L, 4L);
                var v = ov.swizzle.gaag;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-1L, -6L, -9L, -6L);
                var v = ov.swizzle.gaagr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, 8L, -1L);
                var v = ov.swizzle.gaagg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-4L, -7L, -8L, 8L);
                var v = ov.swizzle.gaagb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 5L, 1, -7L);
                var v = ov.swizzle.gaaga;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, -9L, -3L, 5L);
                var v = ov.swizzle.gaab;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-6L, -3L, 8L, -7L);
                var v = ov.swizzle.gaabr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, -4L, 8L);
                var v = ov.swizzle.gaabg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(4L, 6L, -5L, 8L);
                var v = ov.swizzle.gaabb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, -4L, 6L, -2L);
                var v = ov.swizzle.gaaba;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, -7L, 0, 0);
                var v = ov.swizzle.gaaa;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(2L, 2L, 7L, 7L);
                var v = ov.swizzle.gaaar;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-9L, -3L, -1L, -4L);
                var v = ov.swizzle.gaaag;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-7L, 9L, -6L, -6L);
                var v = ov.swizzle.gaaab;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(3L, -1L, 8L, -8L);
                var v = ov.swizzle.gaaaa;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, 1, 5L);
                var v = ov.swizzle.br;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6L, v.y);
            }
            {
                var ov = new lvec4(6L, -9L, 6L, 7L);
                var v = ov.swizzle.brr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(1, 9L, -4L, -7L);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-9L, 8L, -8L, -5L);
                var v = ov.swizzle.brrrr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-8L, -3L, 3L, -4L);
                var v = ov.swizzle.brrrg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(4L, 0, -8L, 1);
                var v = ov.swizzle.brrrb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(8L, 0, -1L, -4L);
                var v = ov.swizzle.brrra;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(9L, -9L, 4L, 2L);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(5L, 7L, 5L, -7L);
                var v = ov.swizzle.brrgr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-5L, -5L, -4L, 2L);
                var v = ov.swizzle.brrgg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-5L, -9L, 6L, 8L);
                var v = ov.swizzle.brrgb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-8L, -3L, -4L, 7L);
                var v = ov.swizzle.brrga;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, -7L, -1L);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(7L, -4L, -3L, 6L);
                var v = ov.swizzle.brrbr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(3L, 0, -7L, 5L);
                var v = ov.swizzle.brrbg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, -8L, 2L);
                var v = ov.swizzle.brrbb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(5L, -2L, -1L, -1L);
                var v = ov.swizzle.brrba;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(3L, 1, -9L, 3L);
                var v = ov.swizzle.brra;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-8L, 0, -8L, 4L);
                var v = ov.swizzle.brrar;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-4L, 8L, 3L, -5L);
                var v = ov.swizzle.brrag;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(5L, 3L, 2L, 7L);
                var v = ov.swizzle.brrab;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(1, -3L, -5L, -1L);
                var v = ov.swizzle.brraa;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, -8L, -3L, -5L);
                var v = ov.swizzle.brg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec4(-8L, 8L, -4L, 3L);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(1, 4L, 3L, 6L);
                var v = ov.swizzle.brgrr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, 3L, 4L, 9L);
                var v = ov.swizzle.brgrg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, -4L, -2L, 7L);
                var v = ov.swizzle.brgrb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-6L, 8L, -2L, -5L);
                var v = ov.swizzle.brgra;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-6L, 1, -9L, 4L);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(8L, 9L, 0, -2L);
                var v = ov.swizzle.brggr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-7L, 0, -6L, 4L);
                var v = ov.swizzle.brggg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, 4L, 5L, 9L);
                var v = ov.swizzle.brggb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(5L, -4L, 3L, 9L);
                var v = ov.swizzle.brgga;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(4L, -7L, -3L, 2L);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-8L, -3L, 6L, 7L);
                var v = ov.swizzle.brgbr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(0, 6L, -5L, 5L);
                var v = ov.swizzle.brgbg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, -8L, -8L, -6L);
                var v = ov.swizzle.brgbb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, -5L, -2L);
                var v = ov.swizzle.brgba;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(3L, -1L, 9L, 1);
                var v = ov.swizzle.brga;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(6L, -9L, 1, -6L);
                var v = ov.swizzle.brgar;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(8L, 2L, 1, 1);
                var v = ov.swizzle.brgag;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(4L, 2L, 9L, -9L);
                var v = ov.swizzle.brgab;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, 6L, -6L);
                var v = ov.swizzle.brgaa;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(3L, -3L, -1L, 9L);
                var v = ov.swizzle.brb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(4L, -1L, -8L, 9L);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(6L, 8L, 1, -6L);
                var v = ov.swizzle.brbrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-9L, -2L, 5L, -4L);
                var v = ov.swizzle.brbrg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, -6L, -8L);
                var v = ov.swizzle.brbrb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 9L, -8L, -8L);
                var v = ov.swizzle.brbra;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(5L, -4L, 0, 4L);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(7L, -8L, 8L, -2L);
                var v = ov.swizzle.brbgr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(2L, -8L, 7L, 9L);
                var v = ov.swizzle.brbgg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -9L, -7L, -5L);
                var v = ov.swizzle.brbgb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(1, -1L, 9L, -9L);
                var v = ov.swizzle.brbga;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(1, 4L, 1, -3L);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-6L, -6L, -2L, -6L);
                var v = ov.swizzle.brbbr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(0, 7L, 4L, -3L);
                var v = ov.swizzle.brbbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-4L, -3L, 3L, 9L);
                var v = ov.swizzle.brbbb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(9L, -3L, 2L, 7L);
                var v = ov.swizzle.brbba;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(0, 8L, -3L, 1);
                var v = ov.swizzle.brba;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(3L, -6L, -4L, 7L);
                var v = ov.swizzle.brbar;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-4L, 0, -7L, -9L);
                var v = ov.swizzle.brbag;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(0, -8L, -7L, 0);
                var v = ov.swizzle.brbab;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-3L, 7L, 7L, -2L);
                var v = ov.swizzle.brbaa;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(6L, -3L, -2L, -5L);
                var v = ov.swizzle.bra;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec4(-4L, -5L, -6L, 6L);
                var v = ov.swizzle.brar;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-5L, 6L, 5L, 7L);
                var v = ov.swizzle.brarr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(8L, 1, -9L, -2L);
                var v = ov.swizzle.brarg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, 0, 9L, 0);
                var v = ov.swizzle.brarb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(1, 4L, 1, -9L);
                var v = ov.swizzle.brara;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(9L, 5L, -3L, -6L);
                var v = ov.swizzle.brag;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-6L, 3L, -7L, 2L);
                var v = ov.swizzle.bragr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(4L, 9L, 1, 7L);
                var v = ov.swizzle.bragg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-7L, -8L, 6L, 7L);
                var v = ov.swizzle.bragb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(0, 7L, -2L, 7L);
                var v = ov.swizzle.braga;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-5L, 8L, 9L, -8L);
                var v = ov.swizzle.brab;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-8L, 4L, 8L, -2L);
                var v = ov.swizzle.brabr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-7L, 7L, 9L, 2L);
                var v = ov.swizzle.brabg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -2L, 4L, 8L);
                var v = ov.swizzle.brabb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(2L, -9L, 9L, -2L);
                var v = ov.swizzle.braba;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, 2L, 2L, -9L);
                var v = ov.swizzle.braa;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-9L, -2L, -5L, -3L);
                var v = ov.swizzle.braar;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, 1, 0, -4L);
                var v = ov.swizzle.braag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, 4L, 1);
                var v = ov.swizzle.braab;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, -7L, -1L);
                var v = ov.swizzle.braaa;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, 4L, 4L, -7L);
                var v = ov.swizzle.bg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
            }
            {
                var ov = new lvec4(-9L, -9L, -6L, 4L);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec4(-3L, -8L, 5L, 0);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-7L, -9L, -8L, -2L);
                var v = ov.swizzle.bgrrr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, -1L, -9L, 6L);
                var v = ov.swizzle.bgrrg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(8L, -6L, -9L, -6L);
                var v = ov.swizzle.bgrrb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, 9L, -7L);
                var v = ov.swizzle.bgrra;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(6L, 3L, -3L, 8L);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(2L, -9L, -8L, 3L);
                var v = ov.swizzle.bgrgr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 5L, -9L, 0);
                var v = ov.swizzle.bgrgg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-6L, 9L, -9L, -4L);
                var v = ov.swizzle.bgrgb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-6L, -9L, -6L, -3L);
                var v = ov.swizzle.bgrga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-5L, -3L, -5L, 3L);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-4L, 9L, 1, -7L);
                var v = ov.swizzle.bgrbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(5L, 8L, 8L, 3L);
                var v = ov.swizzle.bgrbg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, -8L, 9L);
                var v = ov.swizzle.bgrbb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, -7L, -7L, -8L);
                var v = ov.swizzle.bgrba;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, -4L, -4L, 0);
                var v = ov.swizzle.bgra;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-2L, -8L, 9L, -9L);
                var v = ov.swizzle.bgrar;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-6L, 4L, -9L, 7L);
                var v = ov.swizzle.bgrag;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, -7L, 1, -3L);
                var v = ov.swizzle.bgrab;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(7L, 9L, -4L, -2L);
                var v = ov.swizzle.bgraa;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-7L, 0, -8L, 8L);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec4(-7L, -5L, 9L, -7L);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-2L, 9L, 9L, -9L);
                var v = ov.swizzle.bggrr;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, -8L, -2L, 1);
                var v = ov.swizzle.bggrg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -5L, -1L, -6L);
                var v = ov.swizzle.bggrb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(0, 2L, 1, 1);
                var v = ov.swizzle.bggra;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(8L, 0, 4L, -3L);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-7L, 4L, 1, -5L);
                var v = ov.swizzle.bgggr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, 0, 0);
                var v = ov.swizzle.bgggg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-6L, 4L, 3L, -7L);
                var v = ov.swizzle.bgggb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, 6L, 5L);
                var v = ov.swizzle.bggga;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-5L, 0, 5L, 0);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(5L, 0, -4L, -3L);
                var v = ov.swizzle.bggbr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-8L, -8L, -2L, -4L);
                var v = ov.swizzle.bggbg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -6L, -9L, -6L);
                var v = ov.swizzle.bggbb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-1L, -7L, 0, 7L);
                var v = ov.swizzle.bggba;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(7L, -4L, -6L, -7L);
                var v = ov.swizzle.bgga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(-8L, -1L, 4L, -4L);
                var v = ov.swizzle.bggar;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, 7L, 6L);
                var v = ov.swizzle.bggag;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-6L, -5L, 6L, 7L);
                var v = ov.swizzle.bggab;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, 7L, -6L);
                var v = ov.swizzle.bggaa;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(9L, 8L, -6L, 4L);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec4(-3L, 5L, 1, -9L);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(5L, 6L, 5L, 9L);
                var v = ov.swizzle.bgbrr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, -8L, -7L, 0);
                var v = ov.swizzle.bgbrg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, 7L, 2L, -4L);
                var v = ov.swizzle.bgbrb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-6L, -9L, 0, 4L);
                var v = ov.swizzle.bgbra;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(9L, 4L, -8L, 3L);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(9L, -1L, 1, 7L);
                var v = ov.swizzle.bgbgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(9L, 3L, -7L, -9L);
                var v = ov.swizzle.bgbgg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, 4L, -2L);
                var v = ov.swizzle.bgbgb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(9L, 4L, 8L, 5L);
                var v = ov.swizzle.bgbga;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, -7L, -4L, -8L);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-7L, 5L, 3L, 6L);
                var v = ov.swizzle.bgbbr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, 0, -1L);
                var v = ov.swizzle.bgbbg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, -4L, 7L);
                var v = ov.swizzle.bgbbb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(7L, -8L, 9L, -4L);
                var v = ov.swizzle.bgbba;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(4L, -8L, 0, 8L);
                var v = ov.swizzle.bgba;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(0, -8L, 2L, -3L);
                var v = ov.swizzle.bgbar;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(3L, -1L, 3L, -1L);
                var v = ov.swizzle.bgbag;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, -5L, -5L, -3L);
                var v = ov.swizzle.bgbab;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(9L, 0, 5L, 4L);
                var v = ov.swizzle.bgbaa;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(7L, -5L, 6L, -6L);
                var v = ov.swizzle.bga;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec4(3L, 6L, -2L, 5L);
                var v = ov.swizzle.bgar;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-7L, -7L, 3L, -2L);
                var v = ov.swizzle.bgarr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, 0, 9L);
                var v = ov.swizzle.bgarg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, 5L, -7L, -9L);
                var v = ov.swizzle.bgarb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(2L, -1L, 3L, 9L);
                var v = ov.swizzle.bgara;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(8L, 8L, -9L, -2L);
                var v = ov.swizzle.bgag;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-6L, 1, -7L, 7L);
                var v = ov.swizzle.bgagr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 4L, 6L, 8L);
                var v = ov.swizzle.bgagg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-1L, 3L, 4L, -3L);
                var v = ov.swizzle.bgagb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, -6L, 5L);
                var v = ov.swizzle.bgaga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, -2L, -6L, -6L);
                var v = ov.swizzle.bgab;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-4L, 5L, -6L, 4L);
                var v = ov.swizzle.bgabr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(2L, 5L, 1, -7L);
                var v = ov.swizzle.bgabg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-2L, -7L, 7L, -5L);
                var v = ov.swizzle.bgabb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, 8L, -5L);
                var v = ov.swizzle.bgaba;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-9L, -6L, -9L, 9L);
                var v = ov.swizzle.bgaa;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(7L, -2L, -8L, -3L);
                var v = ov.swizzle.bgaar;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(0, 3L, -3L, 5L);
                var v = ov.swizzle.bgaag;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -7L, 2L, -7L);
                var v = ov.swizzle.bgaab;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 3L, -7L, -1L);
                var v = ov.swizzle.bgaaa;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(5L, -3L, 5L, 5L);
                var v = ov.swizzle.bb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var ov = new lvec4(3L, 8L, -6L, -4L);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec4(-6L, 9L, 5L, 6L);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(8L, 0, 6L, -1L);
                var v = ov.swizzle.bbrrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, 5L, 7L, 2L);
                var v = ov.swizzle.bbrrg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, 2L, 3L, -8L);
                var v = ov.swizzle.bbrrb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, -6L, 2L, -5L);
                var v = ov.swizzle.bbrra;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, 9L, 1, 3L);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(1, -7L, 9L, 6L);
                var v = ov.swizzle.bbrgr;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(9L, -4L, 6L, -8L);
                var v = ov.swizzle.bbrgg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-5L, 4L, -7L, -1L);
                var v = ov.swizzle.bbrgb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-8L, 5L, -6L, -4L);
                var v = ov.swizzle.bbrga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, 4L, 6L);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-6L, -5L, 4L, 3L);
                var v = ov.swizzle.bbrbr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(9L, 6L, -2L, 6L);
                var v = ov.swizzle.bbrbg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, 0, 0, 5L);
                var v = ov.swizzle.bbrbb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, 2L, 5L, -1L);
                var v = ov.swizzle.bbrba;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-1L, 0, 0, -8L);
                var v = ov.swizzle.bbra;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-8L, 8L, 6L, 2L);
                var v = ov.swizzle.bbrar;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(4L, -2L, 0, 7L);
                var v = ov.swizzle.bbrag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-9L, 7L, 4L, 2L);
                var v = ov.swizzle.bbrab;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(5L, -4L, 6L, 6L);
                var v = ov.swizzle.bbraa;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-3L, 6L, -6L, 3L);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(1, 0, -2L, -4L);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(3L, -1L, 2L, -5L);
                var v = ov.swizzle.bbgrr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-9L, 5L, 3L, 9L);
                var v = ov.swizzle.bbgrg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(9L, 5L, 8L, 6L);
                var v = ov.swizzle.bbgrb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(7L, 1, -8L, -7L);
                var v = ov.swizzle.bbgra;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(6L, 3L, 6L, -8L);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-6L, -7L, 0, -3L);
                var v = ov.swizzle.bbggr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-5L, -8L, -7L, 3L);
                var v = ov.swizzle.bbggg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(3L, -7L, -7L, -8L);
                var v = ov.swizzle.bbggb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -3L, -8L, -3L);
                var v = ov.swizzle.bbgga;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(9L, 4L, 7L, -4L);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(4L, -5L, -2L, -9L);
                var v = ov.swizzle.bbgbr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(5L, 0, -9L, -1L);
                var v = ov.swizzle.bbgbg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, -9L, -7L, -7L);
                var v = ov.swizzle.bbgbb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-3L, -3L, -8L, 5L);
                var v = ov.swizzle.bbgba;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-1L, 8L, 0, 1);
                var v = ov.swizzle.bbga;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(8L, -9L, 6L, -3L);
                var v = ov.swizzle.bbgar;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 9L, 9L, -5L);
                var v = ov.swizzle.bbgag;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(3L, 5L, 7L, 1);
                var v = ov.swizzle.bbgab;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-5L, -3L, -4L, 0);
                var v = ov.swizzle.bbgaa;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(5L, 1, 6L, -5L);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(-9L, 5L, -6L, 3L);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(0, -9L, 5L, 3L);
                var v = ov.swizzle.bbbrr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-4L, -2L, 2L, 0);
                var v = ov.swizzle.bbbrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(4L, 6L, 4L, 4L);
                var v = ov.swizzle.bbbrb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(8L, -9L, 9L, -6L);
                var v = ov.swizzle.bbbra;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(9L, 4L, 7L, 2L);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(-1L, -5L, 1, 0);
                var v = ov.swizzle.bbbgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-9L, -8L, 0, 9L);
                var v = ov.swizzle.bbbgg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, 4L, 2L, 2L);
                var v = ov.swizzle.bbbgb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(3L, 2L, -3L, 9L);
                var v = ov.swizzle.bbbga;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(4L, 6L, 0, -1L);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(2L, 7L, -7L, 8L);
                var v = ov.swizzle.bbbbr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(7L, 8L, -2L, 6L);
                var v = ov.swizzle.bbbbg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, -1L, 5L, -4L);
                var v = ov.swizzle.bbbbb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-8L, -3L, -3L, 5L);
                var v = ov.swizzle.bbbba;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, 5L, 3L, -6L);
                var v = ov.swizzle.bbba;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-1L, -3L, -8L, -9L);
                var v = ov.swizzle.bbbar;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(4L, 2L, 1, 5L);
                var v = ov.swizzle.bbbag;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(5L, 0, -2L, 2L);
                var v = ov.swizzle.bbbab;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(3L, -6L, -9L, 3L);
                var v = ov.swizzle.bbbaa;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -3L, -2L, -1L);
                var v = ov.swizzle.bba;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(5L, -4L, -7L, -1L);
                var v = ov.swizzle.bbar;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-9L, 7L, 4L, 9L);
                var v = ov.swizzle.bbarr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(9L, 7L, -2L, -9L);
                var v = ov.swizzle.bbarg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(3L, 4L, 0, 9L);
                var v = ov.swizzle.bbarb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, -8L, 4L, 5L);
                var v = ov.swizzle.bbara;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(6L, 5L, 0, -2L);
                var v = ov.swizzle.bbag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-9L, 2L, -1L, 1);
                var v = ov.swizzle.bbagr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-4L, 8L, 7L, 4L);
                var v = ov.swizzle.bbagg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-3L, -2L, 9L, -6L);
                var v = ov.swizzle.bbagb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-5L, 6L, -9L, -6L);
                var v = ov.swizzle.bbaga;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, -6L, -8L);
                var v = ov.swizzle.bbab;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(7L, -2L, -9L, -8L);
                var v = ov.swizzle.bbabr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-6L, 8L, -5L, -8L);
                var v = ov.swizzle.bbabg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, 4L, 0);
                var v = ov.swizzle.bbabb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-4L, 5L, -2L, -7L);
                var v = ov.swizzle.bbaba;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-6L, 3L, -6L, 1);
                var v = ov.swizzle.bbaa;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-9L, 6L, 5L, -1L);
                var v = ov.swizzle.bbaar;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, 3L, -5L, 1);
                var v = ov.swizzle.bbaag;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-9L, 7L, 8L, -5L);
                var v = ov.swizzle.bbaab;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(9L, 2L, 3L, 6L);
                var v = ov.swizzle.bbaaa;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(2L, -2L, 5L, 4L);
                var v = ov.swizzle.ba;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(4L, v.y);
            }
            {
                var ov = new lvec4(-4L, 9L, -6L, 6L);
                var v = ov.swizzle.bar;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec4(7L, 9L, 2L, 8L);
                var v = ov.swizzle.barr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-5L, 1, -9L, -4L);
                var v = ov.swizzle.barrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-5L, -5L, -8L, 1);
                var v = ov.swizzle.barrg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(6L, 7L, 3L, -2L);
                var v = ov.swizzle.barrb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, -3L, -8L, 0);
                var v = ov.swizzle.barra;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-7L, 8L, 9L, -2L);
                var v = ov.swizzle.barg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(2L, 4L, -4L, 4L);
                var v = ov.swizzle.bargr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, 7L, 8L);
                var v = ov.swizzle.bargg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, 2L, 4L);
                var v = ov.swizzle.bargb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, 6L, -8L);
                var v = ov.swizzle.barga;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(7L, -4L, 0, -4L);
                var v = ov.swizzle.barb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(3L, 1, 0, -4L);
                var v = ov.swizzle.barbr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(8L, -3L, -1L, 0);
                var v = ov.swizzle.barbg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, 9L, -9L);
                var v = ov.swizzle.barbb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-9L, -1L, 5L, -1L);
                var v = ov.swizzle.barba;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(6L, -5L, -6L, 3L);
                var v = ov.swizzle.bara;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(7L, 9L, -1L, 7L);
                var v = ov.swizzle.barar;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, -9L, -1L, 6L);
                var v = ov.swizzle.barag;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(6L, 0, -3L, 3L);
                var v = ov.swizzle.barab;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, -6L, 8L, 0);
                var v = ov.swizzle.baraa;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(4L, 0, -6L, 4L);
                var v = ov.swizzle.bag;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec4(0, 6L, -8L, -4L);
                var v = ov.swizzle.bagr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(8L, 3L, 4L, -1L);
                var v = ov.swizzle.bagrr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(1, -5L, -1L, -2L);
                var v = ov.swizzle.bagrg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 6L, -4L);
                var v = ov.swizzle.bagrb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -3L, 8L, 8L);
                var v = ov.swizzle.bagra;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(1, 4L, -4L, -1L);
                var v = ov.swizzle.bagg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(2L, 5L, -1L, 3L);
                var v = ov.swizzle.baggr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(1, 4L, 6L, 6L);
                var v = ov.swizzle.baggg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, -2L, 3L, 1);
                var v = ov.swizzle.baggb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, -8L, 1);
                var v = ov.swizzle.bagga;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, 0, 5L, -1L);
                var v = ov.swizzle.bagb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(9L, 0, 5L, -2L);
                var v = ov.swizzle.bagbr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(8L, -5L, 9L, -1L);
                var v = ov.swizzle.bagbg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-1L, 6L, 2L, -5L);
                var v = ov.swizzle.bagbb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, -1L, 2L);
                var v = ov.swizzle.bagba;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 1, 8L, -6L);
                var v = ov.swizzle.baga;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(8L, 4L, -3L, 5L);
                var v = ov.swizzle.bagar;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, 5L, 2L, -4L);
                var v = ov.swizzle.bagag;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-4L, 7L, -5L, 0);
                var v = ov.swizzle.bagab;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-9L, 3L, 0, 2L);
                var v = ov.swizzle.bagaa;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(0, -8L, -4L, 6L);
                var v = ov.swizzle.bab;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec4(-5L, -5L, -5L, -3L);
                var v = ov.swizzle.babr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(8L, 8L, 8L, 3L);
                var v = ov.swizzle.babrr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(4L, -5L, 8L, -2L);
                var v = ov.swizzle.babrg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-2L, 8L, 1, 4L);
                var v = ov.swizzle.babrb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, 0, 3L);
                var v = ov.swizzle.babra;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, -6L, -7L, 3L);
                var v = ov.swizzle.babg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-1L, 1, -6L, 8L);
                var v = ov.swizzle.babgr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(6L, 8L, 2L, -5L);
                var v = ov.swizzle.babgg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(6L, 2L, 1, -4L);
                var v = ov.swizzle.babgb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(8L, 0, -6L, 3L);
                var v = ov.swizzle.babga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, -8L, 8L, -8L);
                var v = ov.swizzle.babb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-8L, 2L, 8L, 9L);
                var v = ov.swizzle.babbr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(1, -6L, -6L, 0);
                var v = ov.swizzle.babbg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, -4L, -9L);
                var v = ov.swizzle.babbb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, 1, 7L);
                var v = ov.swizzle.babba;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-2L, -9L, -7L, -6L);
                var v = ov.swizzle.baba;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-3L, -4L, 5L, 9L);
                var v = ov.swizzle.babar;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(7L, 6L, -6L, 6L);
                var v = ov.swizzle.babag;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(3L, -7L, 6L, -4L);
                var v = ov.swizzle.babab;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, -8L, 4L, 8L);
                var v = ov.swizzle.babaa;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-3L, 5L, 7L, -1L);
                var v = ov.swizzle.baa;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(-3L, 1, -7L, -6L);
                var v = ov.swizzle.baar;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(7L, 2L, -6L, -7L);
                var v = ov.swizzle.baarr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-9L, 8L, -1L, -7L);
                var v = ov.swizzle.baarg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(1, -2L, 4L, 4L);
                var v = ov.swizzle.baarb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-7L, -9L, 2L, -4L);
                var v = ov.swizzle.baara;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 8L, -7L, 0);
                var v = ov.swizzle.baag;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(3L, -9L, -2L, -9L);
                var v = ov.swizzle.baagr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(6L, -3L, -4L, 6L);
                var v = ov.swizzle.baagg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, 3L, -2L);
                var v = ov.swizzle.baagb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 8L, 1, 4L);
                var v = ov.swizzle.baaga;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(9L, -9L, 7L, -4L);
                var v = ov.swizzle.baab;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(5L, 9L, -3L, -4L);
                var v = ov.swizzle.baabr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, -9L, -1L, -4L);
                var v = ov.swizzle.baabg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(3L, -3L, -1L, 3L);
                var v = ov.swizzle.baabb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(3L, -6L, -3L, 8L);
                var v = ov.swizzle.baaba;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(9L, -7L, 9L, 5L);
                var v = ov.swizzle.baaa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-5L, 4L, 4L, -4L);
                var v = ov.swizzle.baaar;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(7L, -2L, 8L, 8L);
                var v = ov.swizzle.baaag;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-7L, -7L, 4L, -9L);
                var v = ov.swizzle.baaab;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(1, 3L, -4L, -3L);
                var v = ov.swizzle.baaaa;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, 5L, 6L);
                var v = ov.swizzle.ar;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
            }
            {
                var ov = new lvec4(1, 0, 2L, -9L);
                var v = ov.swizzle.arr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec4(-5L, 0, 8L, 0);
                var v = ov.swizzle.arrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-6L, -3L, -4L, -3L);
                var v = ov.swizzle.arrrr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(9L, 1, -9L, 1);
                var v = ov.swizzle.arrrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(5L, -8L, 5L, 1);
                var v = ov.swizzle.arrrb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-1L, 2L, -6L, 5L);
                var v = ov.swizzle.arrra;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(8L, -1L, 2L, 0);
                var v = ov.swizzle.arrg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(1, -9L, 1, -3L);
                var v = ov.swizzle.arrgr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, 2L, 3L, -4L);
                var v = ov.swizzle.arrgg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(1, 4L, -9L, 7L);
                var v = ov.swizzle.arrgb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(3L, 7L, -3L, 4L);
                var v = ov.swizzle.arrga;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(2L, -2L, 9L, -9L);
                var v = ov.swizzle.arrb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(3L, -3L, 7L, 8L);
                var v = ov.swizzle.arrbr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-1L, 4L, -5L, -9L);
                var v = ov.swizzle.arrbg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(4L, -7L, -1L, 3L);
                var v = ov.swizzle.arrbb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-8L, 7L, -8L, -6L);
                var v = ov.swizzle.arrba;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, 0, 6L);
                var v = ov.swizzle.arra;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-7L, 4L, 0, 0);
                var v = ov.swizzle.arrar;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-8L, -8L, -7L, 2L);
                var v = ov.swizzle.arrag;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(8L, -1L, 2L, -7L);
                var v = ov.swizzle.arrab;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(1, 2L, -6L, 8L);
                var v = ov.swizzle.arraa;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-1L, -2L, 1, 7L);
                var v = ov.swizzle.arg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec4(6L, 4L, 9L, 3L);
                var v = ov.swizzle.argr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-4L, -5L, 9L, -5L);
                var v = ov.swizzle.argrr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(9L, -6L, -3L, 1);
                var v = ov.swizzle.argrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 2L, 1, -8L);
                var v = ov.swizzle.argrb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, 9L, -3L);
                var v = ov.swizzle.argra;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(6L, -2L, 9L, -3L);
                var v = ov.swizzle.argg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-4L, -4L, 2L, -5L);
                var v = ov.swizzle.arggr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, 8L, 5L, -8L);
                var v = ov.swizzle.arggg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, -2L, 0, -3L);
                var v = ov.swizzle.arggb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-5L, -6L, 5L, 3L);
                var v = ov.swizzle.argga;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(8L, 1, -3L, -3L);
                var v = ov.swizzle.argb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-7L, 1, 5L, -8L);
                var v = ov.swizzle.argbr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(0, -7L, -6L, 2L);
                var v = ov.swizzle.argbg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, 0, -4L);
                var v = ov.swizzle.argbb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-4L, -7L, 9L, 0);
                var v = ov.swizzle.argba;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-3L, -4L, 3L, 0);
                var v = ov.swizzle.arga;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-1L, -5L, 0, -8L);
                var v = ov.swizzle.argar;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(2L, 8L, 3L, -6L);
                var v = ov.swizzle.argag;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(1, 6L, 3L, 5L);
                var v = ov.swizzle.argab;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-9L, -7L, -5L, -3L);
                var v = ov.swizzle.argaa;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, -5L, -4L);
                var v = ov.swizzle.arb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec4(-2L, 2L, -6L, -2L);
                var v = ov.swizzle.arbr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(-2L, 5L, -9L, -8L);
                var v = ov.swizzle.arbrr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(6L, 5L, 9L, -5L);
                var v = ov.swizzle.arbrg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-7L, -2L, 1, 2L);
                var v = ov.swizzle.arbrb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(0, 6L, -5L, -1L);
                var v = ov.swizzle.arbra;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-4L, 0, 0, -5L);
                var v = ov.swizzle.arbg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(3L, -4L, -5L, -6L);
                var v = ov.swizzle.arbgr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, -7L, -2L, 8L);
                var v = ov.swizzle.arbgg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-9L, 9L, 7L, 8L);
                var v = ov.swizzle.arbgb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-8L, 7L, 6L, -7L);
                var v = ov.swizzle.arbga;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(9L, 5L, 8L, -6L);
                var v = ov.swizzle.arbb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-6L, 8L, 8L, 6L);
                var v = ov.swizzle.arbbr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-6L, -2L, -2L, 1);
                var v = ov.swizzle.arbbg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(8L, 3L, 0, -1L);
                var v = ov.swizzle.arbbb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(1, 1, 8L, -7L);
                var v = ov.swizzle.arbba;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-1L, 2L, -6L, 9L);
                var v = ov.swizzle.arba;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-4L, 1, -5L, 7L);
                var v = ov.swizzle.arbar;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(4L, -3L, 4L, -3L);
                var v = ov.swizzle.arbag;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-9L, -8L, 1, 8L);
                var v = ov.swizzle.arbab;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, 4L, -8L, -5L);
                var v = ov.swizzle.arbaa;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(5L, 7L, 0, 8L);
                var v = ov.swizzle.ara;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec4(4L, 9L, -9L, -5L);
                var v = ov.swizzle.arar;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(8L, -6L, 6L, -7L);
                var v = ov.swizzle.ararr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-9L, 9L, 6L, 6L);
                var v = ov.swizzle.ararg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(8L, -9L, 2L, -5L);
                var v = ov.swizzle.ararb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 0, 2L, 2L);
                var v = ov.swizzle.arara;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(7L, -8L, 2L, 9L);
                var v = ov.swizzle.arag;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(1, -1L, -9L, -6L);
                var v = ov.swizzle.aragr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(3L, -4L, -1L, 2L);
                var v = ov.swizzle.aragg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(2L, 6L, 4L, 3L);
                var v = ov.swizzle.aragb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(1, -9L, -8L, 7L);
                var v = ov.swizzle.araga;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, 6L, -3L, 8L);
                var v = ov.swizzle.arab;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-2L, -4L, -9L, -2L);
                var v = ov.swizzle.arabr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(2L, 2L, 1, 5L);
                var v = ov.swizzle.arabg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(5L, -7L, 0, 6L);
                var v = ov.swizzle.arabb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, 8L, -4L, -7L);
                var v = ov.swizzle.araba;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -1L, -4L, 5L);
                var v = ov.swizzle.araa;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(-9L, 3L, 4L, 1);
                var v = ov.swizzle.araar;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-5L, -8L, -3L, -3L);
                var v = ov.swizzle.araag;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(2L, -4L, -7L, 0);
                var v = ov.swizzle.araab;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, -3L, -8L, 7L);
                var v = ov.swizzle.araaa;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-2L, 7L, -4L, 0);
                var v = ov.swizzle.ag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(7L, v.y);
            }
            {
                var ov = new lvec4(-2L, 4L, -6L, 4L);
                var v = ov.swizzle.agr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec4(5L, -8L, -5L, -2L);
                var v = ov.swizzle.agrr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(5L, 0, -1L, -5L);
                var v = ov.swizzle.agrrr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, 7L, 9L, 7L);
                var v = ov.swizzle.agrrg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(9L, -8L, -7L, 3L);
                var v = ov.swizzle.agrrb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(9L, 7L, 3L, -1L);
                var v = ov.swizzle.agrra;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(0, 0, 0, -5L);
                var v = ov.swizzle.agrg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-1L, 6L, 5L, 8L);
                var v = ov.swizzle.agrgr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-6L, -4L, -3L, -4L);
                var v = ov.swizzle.agrgg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(6L, -9L, -5L, -7L);
                var v = ov.swizzle.agrgb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, 1, 7L, 1);
                var v = ov.swizzle.agrga;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(3L, 1, 6L, -7L);
                var v = ov.swizzle.agrb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(3L, 9L, -7L, -3L);
                var v = ov.swizzle.agrbr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(9L, -1L, 9L, 4L);
                var v = ov.swizzle.agrbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(1, 5L, 4L, 5L);
                var v = ov.swizzle.agrbb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-7L, 0, 1, -9L);
                var v = ov.swizzle.agrba;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-4L, 1, -8L, -9L);
                var v = ov.swizzle.agra;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-4L, -5L, 0, 9L);
                var v = ov.swizzle.agrar;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(2L, -9L, 0, 8L);
                var v = ov.swizzle.agrag;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-9L, 1, 7L, -8L);
                var v = ov.swizzle.agrab;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-3L, 3L, -2L, 0);
                var v = ov.swizzle.agraa;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(8L, -3L, -8L, 5L);
                var v = ov.swizzle.agg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
            }
            {
                var ov = new lvec4(3L, 7L, -2L, 1);
                var v = ov.swizzle.aggr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(-5L, 8L, 0, 3L);
                var v = ov.swizzle.aggrr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-9L, 7L, 6L, 1);
                var v = ov.swizzle.aggrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(3L, 7L, 3L, 7L);
                var v = ov.swizzle.aggrb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(9L, 7L, -1L, -1L);
                var v = ov.swizzle.aggra;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(9L, 1, 4L, 0);
                var v = ov.swizzle.aggg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-7L, 5L, -3L, -3L);
                var v = ov.swizzle.agggr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(7L, 1, 9L, 1);
                var v = ov.swizzle.agggg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(2L, -3L, -6L, 6L);
                var v = ov.swizzle.agggb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(2L, -9L, -5L, -4L);
                var v = ov.swizzle.aggga;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-9L, -7L, 8L, -2L);
                var v = ov.swizzle.aggb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-4L, 5L, -5L, 4L);
                var v = ov.swizzle.aggbr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(0, 3L, -1L, 1);
                var v = ov.swizzle.aggbg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(1, 7L, -5L, 1);
                var v = ov.swizzle.aggbb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(2L, -2L, 3L, 8L);
                var v = ov.swizzle.aggba;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-6L, 6L, -5L, -8L);
                var v = ov.swizzle.agga;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec4(-7L, 5L, -9L, 9L);
                var v = ov.swizzle.aggar;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-1L, -6L, 5L, 9L);
                var v = ov.swizzle.aggag;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-3L, -6L, -1L, -3L);
                var v = ov.swizzle.aggab;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-2L, -3L, 5L, -2L);
                var v = ov.swizzle.aggaa;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-1L, 7L, -3L, 4L);
                var v = ov.swizzle.agb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
            }
            {
                var ov = new lvec4(9L, 8L, -9L, -4L);
                var v = ov.swizzle.agbr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-7L, -4L, 3L, -1L);
                var v = ov.swizzle.agbrr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-5L, 5L, -8L, -3L);
                var v = ov.swizzle.agbrg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, -1L, -4L, 8L);
                var v = ov.swizzle.agbrb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(6L, 4L, -3L, 3L);
                var v = ov.swizzle.agbra;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, 0, 8L, 4L);
                var v = ov.swizzle.agbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-7L, 1, 8L, 9L);
                var v = ov.swizzle.agbgr;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(5L, -2L, -8L, 7L);
                var v = ov.swizzle.agbgg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-3L, 9L, 7L, 8L);
                var v = ov.swizzle.agbgb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, 4L, -3L, -7L);
                var v = ov.swizzle.agbga;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-3L, -5L, -5L, 6L);
                var v = ov.swizzle.agbb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec4(-8L, -7L, -1L, 1);
                var v = ov.swizzle.agbbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-9L, -7L, 5L, 6L);
                var v = ov.swizzle.agbbg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-4L, 9L, 6L, 9L);
                var v = ov.swizzle.agbbb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(0, -4L, -7L, -6L);
                var v = ov.swizzle.agbba;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(4L, -3L, 4L, 2L);
                var v = ov.swizzle.agba;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(7L, 9L, 0, -2L);
                var v = ov.swizzle.agbar;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, 2L, 1);
                var v = ov.swizzle.agbag;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, 9L, 2L);
                var v = ov.swizzle.agbab;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(5L, 1, 6L, 0);
                var v = ov.swizzle.agbaa;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(9L, 6L, 9L, 8L);
                var v = ov.swizzle.aga;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec4(6L, -2L, -3L, 2L);
                var v = ov.swizzle.agar;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(2L, -8L, 7L, -1L);
                var v = ov.swizzle.agarr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(7L, -7L, -2L, -9L);
                var v = ov.swizzle.agarg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(9L, -2L, -9L, 8L);
                var v = ov.swizzle.agarb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-7L, -9L, -9L, -4L);
                var v = ov.swizzle.agara;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, -5L, -8L);
                var v = ov.swizzle.agag;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(0, 3L, 3L, -8L);
                var v = ov.swizzle.agagr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(7L, -7L, 5L, -7L);
                var v = ov.swizzle.agagg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(3L, -6L, -6L, -5L);
                var v = ov.swizzle.agagb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-7L, -7L, 8L, 3L);
                var v = ov.swizzle.agaga;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, -2L, -4L, -4L);
                var v = ov.swizzle.agab;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(4L, 9L, -3L, -4L);
                var v = ov.swizzle.agabr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(1, -7L, 2L, -1L);
                var v = ov.swizzle.agabg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, -4L, 3L);
                var v = ov.swizzle.agabb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-7L, -5L, 2L, -8L);
                var v = ov.swizzle.agaba;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-5L, 9L, 2L, 9L);
                var v = ov.swizzle.agaa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(-2L, -4L, -6L, -4L);
                var v = ov.swizzle.agaar;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-5L, 3L, -2L, -9L);
                var v = ov.swizzle.agaag;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(9L, -6L, -7L, 2L);
                var v = ov.swizzle.agaab;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(8L, 0, -3L, 9L);
                var v = ov.swizzle.agaaa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-1L, 9L, -7L, -1L);
                var v = ov.swizzle.ab;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-7L, v.y);
            }
            {
                var ov = new lvec4(-4L, -4L, 9L, 6L);
                var v = ov.swizzle.abr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec4(1, -3L, -8L, 1);
                var v = ov.swizzle.abrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-5L, -1L, 8L, 6L);
                var v = ov.swizzle.abrrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(8L, 3L, 2L, 9L);
                var v = ov.swizzle.abrrg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, -8L, -8L, -7L);
                var v = ov.swizzle.abrrb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(5L, 3L, 1, -1L);
                var v = ov.swizzle.abrra;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-8L, -2L, -4L, -6L);
                var v = ov.swizzle.abrg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec4(1, -2L, 7L, 4L);
                var v = ov.swizzle.abrgr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-2L, -2L, -6L, -7L);
                var v = ov.swizzle.abrgg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(3L, 8L, -3L, 2L);
                var v = ov.swizzle.abrgb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(5L, 9L, 4L, -9L);
                var v = ov.swizzle.abrga;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(6L, 9L, -3L, 4L);
                var v = ov.swizzle.abrb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(-7L, 3L, -7L, -3L);
                var v = ov.swizzle.abrbr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, -9L, 4L, -1L);
                var v = ov.swizzle.abrbg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(-3L, -9L, 7L, 8L);
                var v = ov.swizzle.abrbb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(-8L, 1, 0, 2L);
                var v = ov.swizzle.abrba;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(3L, 3L, -5L, -6L);
                var v = ov.swizzle.abra;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(7L, 5L, 6L, 3L);
                var v = ov.swizzle.abrar;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(5L, -5L, -2L, -6L);
                var v = ov.swizzle.abrag;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-8L, 2L, 3L, 8L);
                var v = ov.swizzle.abrab;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-9L, 9L, -9L, -8L);
                var v = ov.swizzle.abraa;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, -3L, -3L);
                var v = ov.swizzle.abg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec4(7L, 5L, 4L, 4L);
                var v = ov.swizzle.abgr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(0, 3L, 4L, 3L);
                var v = ov.swizzle.abgrr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(9L, 1, -6L, 2L);
                var v = ov.swizzle.abgrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, -7L, -7L, -2L);
                var v = ov.swizzle.abgrb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -3L, 6L, -6L);
                var v = ov.swizzle.abgra;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(7L, 8L, -2L, -1L);
                var v = ov.swizzle.abgg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-5L, -9L, 9L, 7L);
                var v = ov.swizzle.abggr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(2L, 1, 7L, 8L);
                var v = ov.swizzle.abggg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, 1, 7L, 2L);
                var v = ov.swizzle.abggb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(1, 1, 3L, 1);
                var v = ov.swizzle.abgga;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-1L, 7L, 6L, -7L);
                var v = ov.swizzle.abgb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(5L, 0, -4L, 1);
                var v = ov.swizzle.abgbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, 6L, 0, 2L);
                var v = ov.swizzle.abgbg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(7L, -6L, 5L, -9L);
                var v = ov.swizzle.abgbb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-3L, -3L, 8L, 1);
                var v = ov.swizzle.abgba;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-4L, -6L, 1, 7L);
                var v = ov.swizzle.abga;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec4(-3L, 7L, -1L, -3L);
                var v = ov.swizzle.abgar;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, -4L, -1L, -5L);
                var v = ov.swizzle.abgag;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(9L, 5L, 5L, -9L);
                var v = ov.swizzle.abgab;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, -5L, 4L, -4L);
                var v = ov.swizzle.abgaa;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(5L, 7L, -5L, -5L);
                var v = ov.swizzle.abb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec4(1, 5L, 1, -5L);
                var v = ov.swizzle.abbr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(-6L, 8L, 8L, 7L);
                var v = ov.swizzle.abbrr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-2L, 1, 6L, -4L);
                var v = ov.swizzle.abbrg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(6L, -8L, 3L, -8L);
                var v = ov.swizzle.abbrb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(8L, 0, -3L, -8L);
                var v = ov.swizzle.abbra;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-6L, 5L, -3L, 1);
                var v = ov.swizzle.abbg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec4(9L, 5L, -7L, -7L);
                var v = ov.swizzle.abbgr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(8L, -5L, -5L, 5L);
                var v = ov.swizzle.abbgg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(1, 5L, 6L, 7L);
                var v = ov.swizzle.abbgb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(6L, -6L, -6L, 0);
                var v = ov.swizzle.abbga;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(4L, 3L, 2L, 7L);
                var v = ov.swizzle.abbb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(-8L, -2L, -2L, 3L);
                var v = ov.swizzle.abbbr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-1L, 5L, 4L, 4L);
                var v = ov.swizzle.abbbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-5L, -6L, -8L, -5L);
                var v = ov.swizzle.abbbb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(-3L, -9L, 5L, 9L);
                var v = ov.swizzle.abbba;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-2L, -1L, -8L, -7L);
                var v = ov.swizzle.abba;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec4(5L, 1, -2L, 1);
                var v = ov.swizzle.abbar;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, -2L, -3L);
                var v = ov.swizzle.abbag;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(4L, -2L, -3L, -3L);
                var v = ov.swizzle.abbab;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(2L, 4L, 3L, -7L);
                var v = ov.swizzle.abbaa;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-4L, -4L, 6L, 2L);
                var v = ov.swizzle.aba;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec4(9L, -1L, -1L, 4L);
                var v = ov.swizzle.abar;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec4(6L, -1L, -4L, 6L);
                var v = ov.swizzle.abarr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(9L, 5L, 8L, -3L);
                var v = ov.swizzle.abarg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(4L, 5L, 1, -7L);
                var v = ov.swizzle.abarb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-9L, 9L, -1L, -5L);
                var v = ov.swizzle.abara;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, 0, 2L);
                var v = ov.swizzle.abag;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(3L, 5L, -3L, 7L);
                var v = ov.swizzle.abagr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-6L, 8L, -6L, -8L);
                var v = ov.swizzle.abagg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(4L, -6L, 6L, -5L);
                var v = ov.swizzle.abagb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(9L, 7L, -4L, 1);
                var v = ov.swizzle.abaga;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, 5L, 3L, -8L);
                var v = ov.swizzle.abab;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec4(3L, -9L, 8L, -6L);
                var v = ov.swizzle.ababr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(3L, 5L, -7L, 3L);
                var v = ov.swizzle.ababg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(2L, -1L, 8L, -9L);
                var v = ov.swizzle.ababb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(9L, 7L, 1, 1);
                var v = ov.swizzle.ababa;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-8L, 6L, -1L, 1);
                var v = ov.swizzle.abaa;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec4(9L, 9L, 8L, 8L);
                var v = ov.swizzle.abaar;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-9L, 6L, 6L, -2L);
                var v = ov.swizzle.abaag;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-6L, 9L, -3L, 8L);
                var v = ov.swizzle.abaab;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(6L, 1, -8L, 3L);
                var v = ov.swizzle.abaaa;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-7L, -6L, 4L, 9L);
                var v = ov.swizzle.aa;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
            }
            {
                var ov = new lvec4(-1L, -2L, -5L, -3L);
                var v = ov.swizzle.aar;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(6L, 6L, 4L, 2L);
                var v = ov.swizzle.aarr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(6L, -3L, 2L, -4L);
                var v = ov.swizzle.aarrr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-4L, 2L, 8L, -3L);
                var v = ov.swizzle.aarrg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(-1L, -9L, -7L, -6L);
                var v = ov.swizzle.aarrb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-9L, 5L, 7L, -3L);
                var v = ov.swizzle.aarra;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-8L, 0, -2L, 7L);
                var v = ov.swizzle.aarg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(8L, -7L, 4L, 1);
                var v = ov.swizzle.aargr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(2L, 0, 9L, -7L);
                var v = ov.swizzle.aargg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-5L, -5L, 1, -2L);
                var v = ov.swizzle.aargb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, 3L, 4L, 2L);
                var v = ov.swizzle.aarga;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(2L, v.v);
            }
            {
                var ov = new lvec4(6L, -8L, -4L, 4L);
                var v = ov.swizzle.aarb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-3L, 5L, -3L, -7L);
                var v = ov.swizzle.aarbr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-9L, 7L, -1L, 4L);
                var v = ov.swizzle.aarbg;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(4L, 2L, -5L, 6L);
                var v = ov.swizzle.aarbb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(-5L, -7L, -4L, 8L);
                var v = ov.swizzle.aarba;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(8L, 1, -2L, -4L);
                var v = ov.swizzle.aara;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-2L, -2L, -8L, -6L);
                var v = ov.swizzle.aarar;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(-8L, 4L, -5L, -5L);
                var v = ov.swizzle.aarag;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(0, 4L, 5L, -9L);
                var v = ov.swizzle.aarab;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(5L, 6L, -5L, 3L);
                var v = ov.swizzle.aaraa;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(4L, 6L, 2L, -4L);
                var v = ov.swizzle.aag;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec4(8L, 5L, -2L, -3L);
                var v = ov.swizzle.aagr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec4(-9L, -4L, -7L, 4L);
                var v = ov.swizzle.aagrr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(9L, -6L, -4L, 5L);
                var v = ov.swizzle.aagrg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(6L, 0, -3L, 1);
                var v = ov.swizzle.aagrb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, -9L, -4L);
                var v = ov.swizzle.aagra;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-2L, -6L, 4L, -9L);
                var v = ov.swizzle.aagg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec4(-6L, -6L, 1, 7L);
                var v = ov.swizzle.aaggr;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(1, -1L, 4L, 1);
                var v = ov.swizzle.aaggg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-8L, -7L, 4L, 6L);
                var v = ov.swizzle.aaggb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-9L, 5L, -6L, 3L);
                var v = ov.swizzle.aagga;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(7L, -1L, 4L, 4L);
                var v = ov.swizzle.aagb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec4(9L, 0, -2L, 5L);
                var v = ov.swizzle.aagbr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var ov = new lvec4(-4L, -4L, -6L, 6L);
                var v = ov.swizzle.aagbg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(6L, 7L, 1, -3L);
                var v = ov.swizzle.aagbb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(1, -3L, -7L, 3L);
                var v = ov.swizzle.aagba;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(3L, v.v);
            }
            {
                var ov = new lvec4(-3L, 8L, 2L, -9L);
                var v = ov.swizzle.aaga;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec4(-1L, -3L, 6L, 8L);
                var v = ov.swizzle.aagar;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-1L, v.v);
            }
            {
                var ov = new lvec4(-5L, 5L, 1, 1);
                var v = ov.swizzle.aagag;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, -6L, 5L, 1);
                var v = ov.swizzle.aagab;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(-1L, -9L, 9L, -5L);
                var v = ov.swizzle.aagaa;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(3L, -5L, -3L, 7L);
                var v = ov.swizzle.aab;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
            }
            {
                var ov = new lvec4(-4L, -7L, -4L, -1L);
                var v = ov.swizzle.aabr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(-6L, -1L, 5L, 6L);
                var v = ov.swizzle.aabrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(8L, -3L, 9L, -9L);
                var v = ov.swizzle.aabrg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(8L, 5L, -4L, -7L);
                var v = ov.swizzle.aabrb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(-4L, 3L, 9L, 8L);
                var v = ov.swizzle.aabra;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(-2L, -4L, 6L, -1L);
                var v = ov.swizzle.aabg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec4(1, 0, 2L, 1);
                var v = ov.swizzle.aabgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(2L, 1, -9L, -7L);
                var v = ov.swizzle.aabgg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new lvec4(-5L, -4L, 4L, -3L);
                var v = ov.swizzle.aabgb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-8L, -6L, -3L, 4L);
                var v = ov.swizzle.aabga;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(0, -5L, -3L, 7L);
                var v = ov.swizzle.aabb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(5L, 6L, -3L, 4L);
                var v = ov.swizzle.aabbr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(5L, -2L, 0, 0);
                var v = ov.swizzle.aabbg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-2L, v.v);
            }
            {
                var ov = new lvec4(5L, 4L, -6L, 0);
                var v = ov.swizzle.aabbb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-1L, 3L, 8L, -5L);
                var v = ov.swizzle.aabba;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(7L, 3L, 3L, 6L);
                var v = ov.swizzle.aaba;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec4(-4L, -3L, 3L, -4L);
                var v = ov.swizzle.aabar;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(0, 0, -9L, -8L);
                var v = ov.swizzle.aabag;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new lvec4(-1L, 5L, 7L, -6L);
                var v = ov.swizzle.aabab;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(7L, v.v);
            }
            {
                var ov = new lvec4(0, -9L, 5L, -5L);
                var v = ov.swizzle.aabaa;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-5L, v.v);
            }
            {
                var ov = new lvec4(7L, -8L, -5L, -1L);
                var v = ov.swizzle.aaa;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec4(0, -9L, -2L, -1L);
                var v = ov.swizzle.aaar;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec4(-8L, 4L, 1, -5L);
                var v = ov.swizzle.aaarr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(6L, -7L, -6L, -7L);
                var v = ov.swizzle.aaarg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-2L, 6L, -4L, -3L);
                var v = ov.swizzle.aaarb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(3L, -8L, 3L, 4L);
                var v = ov.swizzle.aaara;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(3L, v.w);
                Assert.AreEqual(4L, v.v);
            }
            {
                var ov = new lvec4(-3L, 2L, 8L, 0);
                var v = ov.swizzle.aaag;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec4(-7L, -9L, -9L, -2L);
                var v = ov.swizzle.aaagr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
                Assert.AreEqual(-7L, v.v);
            }
            {
                var ov = new lvec4(-7L, -4L, 7L, 9L);
                var v = ov.swizzle.aaagg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-4L, v.w);
                Assert.AreEqual(-4L, v.v);
            }
            {
                var ov = new lvec4(7L, -3L, 5L, -4L);
                var v = ov.swizzle.aaagb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(5L, v.v);
            }
            {
                var ov = new lvec4(0, -3L, -6L, -6L);
                var v = ov.swizzle.aaaga;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var ov = new lvec4(-8L, 4L, -1L, -4L);
                var v = ov.swizzle.aaab;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec4(8L, -1L, 4L, -4L);
                var v = ov.swizzle.aaabr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(4L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(5L, -3L, -1L, 8L);
                var v = ov.swizzle.aaabg;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-1L, v.w);
                Assert.AreEqual(-3L, v.v);
            }
            {
                var ov = new lvec4(-4L, -1L, -8L, -8L);
                var v = ov.swizzle.aaabb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(-8L, v.v);
            }
            {
                var ov = new lvec4(9L, -2L, -3L, -9L);
                var v = ov.swizzle.aaaba;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-3L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(5L, 9L, -7L, -3L);
                var v = ov.swizzle.aaaa;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec4(8L, 6L, 8L, -8L);
                var v = ov.swizzle.aaaar;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
                Assert.AreEqual(8L, v.v);
            }
            {
                var ov = new lvec4(0, -9L, -2L, 9L);
                var v = ov.swizzle.aaaag;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(-9L, v.v);
            }
            {
                var ov = new lvec4(2L, 7L, 6L, 7L);
                var v = ov.swizzle.aaaab;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
                Assert.AreEqual(6L, v.v);
            }
            {
                var ov = new lvec4(-1L, -5L, -1L, 6L);
                var v = ov.swizzle.aaaaa;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
                Assert.AreEqual(6L, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new lvec4(0, -6L, 1, 9L);
                var v1 = new lvec2(-7L, 1);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7L, v0.x);
                Assert.AreEqual(1, v0.y);
                Assert.AreEqual(1, v0.z);
                Assert.AreEqual(9L, v0.w);
            
                Assert.AreEqual(0, v2.x);
                Assert.AreEqual(-6L, v2.y);
            }
            {
                var v0 = new lvec4(6L, 6L, 8L, 8L);
                var v1 = new lvec2(2L, -3L);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2L, v0.x);
                Assert.AreEqual(6L, v0.y);
                Assert.AreEqual(-3L, v0.z);
                Assert.AreEqual(8L, v0.w);
            
                Assert.AreEqual(6L, v2.x);
                Assert.AreEqual(8L, v2.y);
            }
            {
                var v0 = new lvec4(7L, -5L, 6L, -2L);
                var v1 = new lvec2(1, 1);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7L, v0.x);
                Assert.AreEqual(1, v0.y);
                Assert.AreEqual(1, v0.z);
                Assert.AreEqual(-2L, v0.w);
            
                Assert.AreEqual(-5L, v2.x);
                Assert.AreEqual(6L, v2.y);
            }
            {
                var v0 = new lvec4(5L, -8L, 9L, -9L);
                var v1 = new lvec3(-7L, 1, -2L);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7L, v0.x);
                Assert.AreEqual(1, v0.y);
                Assert.AreEqual(-2L, v0.z);
                Assert.AreEqual(-9L, v0.w);
            
                Assert.AreEqual(5L, v2.x);
                Assert.AreEqual(-8L, v2.y);
                Assert.AreEqual(9L, v2.z);
            }
            {
                var v0 = new lvec4(0, -7L, 1, 8L);
                var v1 = new lvec2(1, -1L);
                var v2 = v0.xw;
                v0.xw = v1;
                var v3 = v0.xw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1, v0.x);
                Assert.AreEqual(-7L, v0.y);
                Assert.AreEqual(1, v0.z);
                Assert.AreEqual(-1L, v0.w);
            
                Assert.AreEqual(0, v2.x);
                Assert.AreEqual(8L, v2.y);
            }
            {
                var v0 = new lvec4(-3L, -9L, 5L, -4L);
                var v1 = new lvec2(-1L, 2L);
                var v2 = v0.yw;
                v0.yw = v1;
                var v3 = v0.yw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3L, v0.x);
                Assert.AreEqual(-1L, v0.y);
                Assert.AreEqual(5L, v0.z);
                Assert.AreEqual(2L, v0.w);
            
                Assert.AreEqual(-9L, v2.x);
                Assert.AreEqual(-4L, v2.y);
            }
            {
                var v0 = new lvec4(-6L, 2L, 7L, -9L);
                var v1 = new lvec3(-7L, 3L, 6L);
                var v2 = v0.xyw;
                v0.xyw = v1;
                var v3 = v0.xyw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7L, v0.x);
                Assert.AreEqual(3L, v0.y);
                Assert.AreEqual(7L, v0.z);
                Assert.AreEqual(6L, v0.w);
            
                Assert.AreEqual(-6L, v2.x);
                Assert.AreEqual(2L, v2.y);
                Assert.AreEqual(-9L, v2.z);
            }
            {
                var v0 = new lvec4(8L, 5L, -1L, 5L);
                var v1 = new lvec2(-2L, -1L);
                var v2 = v0.zw;
                v0.zw = v1;
                var v3 = v0.zw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8L, v0.x);
                Assert.AreEqual(5L, v0.y);
                Assert.AreEqual(-2L, v0.z);
                Assert.AreEqual(-1L, v0.w);
            
                Assert.AreEqual(-1L, v2.x);
                Assert.AreEqual(5L, v2.y);
            }
            {
                var v0 = new lvec4(-2L, 1, 5L, -9L);
                var v1 = new lvec3(-1L, 0, -8L);
                var v2 = v0.xzw;
                v0.xzw = v1;
                var v3 = v0.xzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-1L, v0.x);
                Assert.AreEqual(1, v0.y);
                Assert.AreEqual(0, v0.z);
                Assert.AreEqual(-8L, v0.w);
            
                Assert.AreEqual(-2L, v2.x);
                Assert.AreEqual(5L, v2.y);
                Assert.AreEqual(-9L, v2.z);
            }
            {
                var v0 = new lvec4(0, -8L, -7L, 4L);
                var v1 = new lvec3(5L, -8L, 6L);
                var v2 = v0.yzw;
                v0.yzw = v1;
                var v3 = v0.yzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(0, v0.x);
                Assert.AreEqual(5L, v0.y);
                Assert.AreEqual(-8L, v0.z);
                Assert.AreEqual(6L, v0.w);
            
                Assert.AreEqual(-8L, v2.x);
                Assert.AreEqual(-7L, v2.y);
                Assert.AreEqual(4L, v2.z);
            }
            {
                var v0 = new lvec4(-8L, 8L, -3L, 1);
                var v1 = new lvec4(1, -5L, 9L, 5L);
                var v2 = v0.xyzw;
                v0.xyzw = v1;
                var v3 = v0.xyzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1, v0.x);
                Assert.AreEqual(-5L, v0.y);
                Assert.AreEqual(9L, v0.z);
                Assert.AreEqual(5L, v0.w);
            
                Assert.AreEqual(-8L, v2.x);
                Assert.AreEqual(8L, v2.y);
                Assert.AreEqual(-3L, v2.z);
                Assert.AreEqual(1, v2.w);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new lvec4(9L, 7L, 4L, -2L);
                var v1 = -9L;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-9L, v0.x);
                Assert.AreEqual(7L, v0.y);
                Assert.AreEqual(4L, v0.z);
                Assert.AreEqual(-2L, v0.w);
            
                Assert.AreEqual(9L, v2);
            }
            {
                var v0 = new lvec4(-5L, 3L, 6L, 7L);
                var v1 = -3L;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5L, v0.x);
                Assert.AreEqual(-3L, v0.y);
                Assert.AreEqual(6L, v0.z);
                Assert.AreEqual(7L, v0.w);
            
                Assert.AreEqual(3L, v2);
            }
            {
                var v0 = new lvec4(-1L, 0, 8L, 7L);
                var v1 = new lvec2(4L, 6L);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(4L, v0.x);
                Assert.AreEqual(6L, v0.y);
                Assert.AreEqual(8L, v0.z);
                Assert.AreEqual(7L, v0.w);
            
                Assert.AreEqual(-1L, v2.x);
                Assert.AreEqual(0, v2.y);
            }
            {
                var v0 = new lvec4(-7L, 7L, 2L, 2L);
                var v1 = 6L;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7L, v0.x);
                Assert.AreEqual(7L, v0.y);
                Assert.AreEqual(6L, v0.z);
                Assert.AreEqual(2L, v0.w);
            
                Assert.AreEqual(2L, v2);
            }
            {
                var v0 = new lvec4(-7L, -7L, -5L, 5L);
                var v1 = new lvec2(5L, -4L);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(5L, v0.x);
                Assert.AreEqual(-7L, v0.y);
                Assert.AreEqual(-4L, v0.z);
                Assert.AreEqual(5L, v0.w);
            
                Assert.AreEqual(-7L, v2.x);
                Assert.AreEqual(-5L, v2.y);
            }
            {
                var v0 = new lvec4(-3L, 9L, -4L, 9L);
                var v1 = new lvec2(-3L, -4L);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3L, v0.x);
                Assert.AreEqual(-3L, v0.y);
                Assert.AreEqual(-4L, v0.z);
                Assert.AreEqual(9L, v0.w);
            
                Assert.AreEqual(9L, v2.x);
                Assert.AreEqual(-4L, v2.y);
            }
            {
                var v0 = new lvec4(5L, -3L, 5L, 8L);
                var v1 = new lvec3(-8L, 3L, -7L);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8L, v0.x);
                Assert.AreEqual(3L, v0.y);
                Assert.AreEqual(-7L, v0.z);
                Assert.AreEqual(8L, v0.w);
            
                Assert.AreEqual(5L, v2.x);
                Assert.AreEqual(-3L, v2.y);
                Assert.AreEqual(5L, v2.z);
            }
            {
                var v0 = new lvec4(-9L, -8L, -3L, 3L);
                var v1 = -6L;
                var v2 = v0.a;
                v0.a = v1;
                var v3 = v0.a;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-9L, v0.x);
                Assert.AreEqual(-8L, v0.y);
                Assert.AreEqual(-3L, v0.z);
                Assert.AreEqual(-6L, v0.w);
            
                Assert.AreEqual(3L, v2);
            }
            {
                var v0 = new lvec4(-7L, 0, -2L, -2L);
                var v1 = new lvec2(-7L, 2L);
                var v2 = v0.ra;
                v0.ra = v1;
                var v3 = v0.ra;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7L, v0.x);
                Assert.AreEqual(0, v0.y);
                Assert.AreEqual(-2L, v0.z);
                Assert.AreEqual(2L, v0.w);
            
                Assert.AreEqual(-7L, v2.x);
                Assert.AreEqual(-2L, v2.y);
            }
            {
                var v0 = new lvec4(-4L, -8L, -2L, 2L);
                var v1 = new lvec2(-3L, -1L);
                var v2 = v0.ga;
                v0.ga = v1;
                var v3 = v0.ga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-4L, v0.x);
                Assert.AreEqual(-3L, v0.y);
                Assert.AreEqual(-2L, v0.z);
                Assert.AreEqual(-1L, v0.w);
            
                Assert.AreEqual(-8L, v2.x);
                Assert.AreEqual(2L, v2.y);
            }
            {
                var v0 = new lvec4(9L, 5L, -3L, 1);
                var v1 = new lvec3(-1L, -7L, -4L);
                var v2 = v0.rga;
                v0.rga = v1;
                var v3 = v0.rga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-1L, v0.x);
                Assert.AreEqual(-7L, v0.y);
                Assert.AreEqual(-3L, v0.z);
                Assert.AreEqual(-4L, v0.w);
            
                Assert.AreEqual(9L, v2.x);
                Assert.AreEqual(5L, v2.y);
                Assert.AreEqual(1, v2.z);
            }
            {
                var v0 = new lvec4(3L, -8L, 5L, 3L);
                var v1 = new lvec2(-5L, -8L);
                var v2 = v0.ba;
                v0.ba = v1;
                var v3 = v0.ba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3L, v0.x);
                Assert.AreEqual(-8L, v0.y);
                Assert.AreEqual(-5L, v0.z);
                Assert.AreEqual(-8L, v0.w);
            
                Assert.AreEqual(5L, v2.x);
                Assert.AreEqual(3L, v2.y);
            }
            {
                var v0 = new lvec4(-7L, -9L, 3L, 5L);
                var v1 = new lvec3(2L, 7L, 3L);
                var v2 = v0.rba;
                v0.rba = v1;
                var v3 = v0.rba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2L, v0.x);
                Assert.AreEqual(-9L, v0.y);
                Assert.AreEqual(7L, v0.z);
                Assert.AreEqual(3L, v0.w);
            
                Assert.AreEqual(-7L, v2.x);
                Assert.AreEqual(3L, v2.y);
                Assert.AreEqual(5L, v2.z);
            }
            {
                var v0 = new lvec4(-3L, -9L, 7L, 5L);
                var v1 = new lvec3(2L, 0, -2L);
                var v2 = v0.gba;
                v0.gba = v1;
                var v3 = v0.gba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3L, v0.x);
                Assert.AreEqual(2L, v0.y);
                Assert.AreEqual(0, v0.z);
                Assert.AreEqual(-2L, v0.w);
            
                Assert.AreEqual(-9L, v2.x);
                Assert.AreEqual(7L, v2.y);
                Assert.AreEqual(5L, v2.z);
            }
            {
                var v0 = new lvec4(-2L, -5L, -4L, 2L);
                var v1 = new lvec4(2L, 0, -5L, -9L);
                var v2 = v0.rgba;
                v0.rgba = v1;
                var v3 = v0.rgba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2L, v0.x);
                Assert.AreEqual(0, v0.y);
                Assert.AreEqual(-5L, v0.z);
                Assert.AreEqual(-9L, v0.w);
            
                Assert.AreEqual(-2L, v2.x);
                Assert.AreEqual(-5L, v2.y);
                Assert.AreEqual(-4L, v2.z);
                Assert.AreEqual(2L, v2.w);
            }
        }

    }
}
