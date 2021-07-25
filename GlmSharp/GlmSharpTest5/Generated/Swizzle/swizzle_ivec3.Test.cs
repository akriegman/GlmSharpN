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
    public class IntSwizzleVec3Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new ivec3(7, 7, 6);
                var v = ov.swizzle.xx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
            }
            {
                var ov = new ivec3(-5, -1, -9);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new ivec3(-5, 1, -4);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new ivec3(8, 0, -2);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-2, 3, 5);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(6, -8, -5);
                var v = ov.swizzle.xxxxz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(8, -4, 1);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new ivec3(3, -1, 6);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(3, 8, 5);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(4, 7, 7);
                var v = ov.swizzle.xxxyz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(2, 9, 2);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(7, 0, 3);
                var v = ov.swizzle.xxxzx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(8, 5, -3);
                var v = ov.swizzle.xxxzy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-2, -8, -3);
                var v = ov.swizzle.xxxzz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(6, -2, 8);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new ivec3(0, 0, 2);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(0, -3, -5);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-7, -6, -3);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(8, 4, -7);
                var v = ov.swizzle.xxyxz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(0, -1, 2);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(-4, 9, -4);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(5, 6, 9);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(8, 3, 2);
                var v = ov.swizzle.xxyyz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(2, -7, -3);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(1, -6, -6);
                var v = ov.swizzle.xxyzx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(8, -6, -8);
                var v = ov.swizzle.xxyzy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-7, 3, 7);
                var v = ov.swizzle.xxyzz;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(3, 4, -5);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new ivec3(-3, 5, -4);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(8, -9, -6);
                var v = ov.swizzle.xxzxx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(5, 8, -4);
                var v = ov.swizzle.xxzxy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-1, -7, 7);
                var v = ov.swizzle.xxzxz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-8, 1, 5);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec3(-8, -1, -6);
                var v = ov.swizzle.xxzyx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-9, -8, -5);
                var v = ov.swizzle.xxzyy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(2, -5, -9);
                var v = ov.swizzle.xxzyz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-7, 0, 7);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec3(-9, 2, 7);
                var v = ov.swizzle.xxzzx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-4, -1, 5);
                var v = ov.swizzle.xxzzy;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-9, -2, 1);
                var v = ov.swizzle.xxzzz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-5, -9, 4);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-9, v.y);
            }
            {
                var ov = new ivec3(6, -6, 7);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new ivec3(-8, -1, -8);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(7, 9, -4);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-3, -9, -2);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-2, 4, 5);
                var v = ov.swizzle.xyxxz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-9, -1, 9);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(-5, -2, -8);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(7, 6, 6);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(5, -7, 6);
                var v = ov.swizzle.xyxyz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(2, -9, 8);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec3(3, 3, -1);
                var v = ov.swizzle.xyxzx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-1, -2, 1);
                var v = ov.swizzle.xyxzy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(6, 3, 4);
                var v = ov.swizzle.xyxzz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(0, 9, 9);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new ivec3(-3, 6, 2);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(-6, 1, 6);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-9, -9, 1);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-2, 0, 7);
                var v = ov.swizzle.xyyxz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(5, -9, 9);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new ivec3(1, -2, -4);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-2, 5, -1);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(5, 8, -5);
                var v = ov.swizzle.xyyyz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(0, 0, -2);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new ivec3(4, -3, 6);
                var v = ov.swizzle.xyyzx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(4, -4, 2);
                var v = ov.swizzle.xyyzy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(8, -4, 0);
                var v = ov.swizzle.xyyzz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(3, 9, -5);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new ivec3(0, 3, -9);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(6, -2, 2);
                var v = ov.swizzle.xyzxx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(3, 4, -2);
                var v = ov.swizzle.xyzxy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-2, 5, -1);
                var v = ov.swizzle.xyzxz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-1, 8, 3);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec3(-9, 7, -7);
                var v = ov.swizzle.xyzyx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(6, -6, 1);
                var v = ov.swizzle.xyzyy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-4, -5, 6);
                var v = ov.swizzle.xyzyz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-4, 6, 6);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(5, -7, 4);
                var v = ov.swizzle.xyzzx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(9, -7, 2);
                var v = ov.swizzle.xyzzy;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-8, -1, 1);
                var v = ov.swizzle.xyzzz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-1, -8, -6);
                var v = ov.swizzle.xz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-6, v.y);
            }
            {
                var ov = new ivec3(-3, -6, -5);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec3(0, -3, 6);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(-6, -3, 5);
                var v = ov.swizzle.xzxxx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-8, 9, 6);
                var v = ov.swizzle.xzxxy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(2, -6, -3);
                var v = ov.swizzle.xzxxz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-3, 6, 8);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(-2, -2, 4);
                var v = ov.swizzle.xzxyx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-6, -8, 7);
                var v = ov.swizzle.xzxyy;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(6, 1, 7);
                var v = ov.swizzle.xzxyz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(7, -2, -7);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(1, 7, 8);
                var v = ov.swizzle.xzxzx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(0, -4, -9);
                var v = ov.swizzle.xzxzy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(6, -4, 2);
                var v = ov.swizzle.xzxzz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-9, -8, -4);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var ov = new ivec3(0, 6, 7);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(-8, 6, 0);
                var v = ov.swizzle.xzyxx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(9, 5, 4);
                var v = ov.swizzle.xzyxy;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-3, -9, 5);
                var v = ov.swizzle.xzyxz;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-1, -6, -8);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(6, -3, -1);
                var v = ov.swizzle.xzyyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-9, 7, 0);
                var v = ov.swizzle.xzyyy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(7, -6, 2);
                var v = ov.swizzle.xzyyz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-7, 1, 2);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(-4, 6, -3);
                var v = ov.swizzle.xzyzx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(5, -2, -4);
                var v = ov.swizzle.xzyzy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-1, -5, -1);
                var v = ov.swizzle.xzyzz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(0, 8, -4);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new ivec3(6, -8, 6);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(-3, 8, 7);
                var v = ov.swizzle.xzzxx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(2, 8, -7);
                var v = ov.swizzle.xzzxy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(1, -9, 1);
                var v = ov.swizzle.xzzxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-1, 0, -1);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(-3, -3, -1);
                var v = ov.swizzle.xzzyx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(4, 1, 5);
                var v = ov.swizzle.xzzyy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-8, -6, -8);
                var v = ov.swizzle.xzzyz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-1, 6, 6);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(-2, 0, 0);
                var v = ov.swizzle.xzzzx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(7, 6, 4);
                var v = ov.swizzle.xzzzy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-6, -2, 8);
                var v = ov.swizzle.xzzzz;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-4, -5, 7);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-4, v.y);
            }
            {
                var ov = new ivec3(-4, -4, -2);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new ivec3(4, -3, 7);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec3(-2, -5, -2);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(3, -8, 2);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-9, -5, 6);
                var v = ov.swizzle.yxxxz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(8, 7, 2);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec3(7, 1, 1);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(1, -1, 8);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-6, -3, -2);
                var v = ov.swizzle.yxxyz;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-7, -4, 7);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec3(1, -8, -7);
                var v = ov.swizzle.yxxzx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(3, -1, 6);
                var v = ov.swizzle.yxxzy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-3, -4, 2);
                var v = ov.swizzle.yxxzz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-1, -9, -2);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new ivec3(-4, 8, 1);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new ivec3(-8, 7, -1);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-7, 7, 3);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(6, 5, -4);
                var v = ov.swizzle.yxyxz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(6, -3, 3);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(2, 7, -9);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-5, -5, 0);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(4, 1, -9);
                var v = ov.swizzle.yxyyz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(5, -6, 4);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec3(-9, -5, -4);
                var v = ov.swizzle.yxyzx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-9, -7, 1);
                var v = ov.swizzle.yxyzy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(8, 6, 1);
                var v = ov.swizzle.yxyzz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(7, -8, 4);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new ivec3(1, -9, 5);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec3(3, -5, -3);
                var v = ov.swizzle.yxzxx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(3, -7, -7);
                var v = ov.swizzle.yxzxy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(3, 9, 5);
                var v = ov.swizzle.yxzxz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(3, -6, 4);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(-1, 9, 6);
                var v = ov.swizzle.yxzyx;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(1, -2, -2);
                var v = ov.swizzle.yxzyy;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(6, -7, -3);
                var v = ov.swizzle.yxzyz;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(9, 6, 8);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec3(-2, -7, 5);
                var v = ov.swizzle.yxzzx;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(1, -5, 9);
                var v = ov.swizzle.yxzzy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-4, -4, -5);
                var v = ov.swizzle.yxzzz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-5, 0, 6);
                var v = ov.swizzle.yy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var ov = new ivec3(6, 1, -9);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new ivec3(6, -5, 4);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(8, -6, 0);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-7, -8, -6);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-5, 5, 5);
                var v = ov.swizzle.yyxxz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-3, -4, 1);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new ivec3(-3, -4, 8);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(3, -2, -9);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-2, 2, -4);
                var v = ov.swizzle.yyxyz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-6, 9, 2);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(8, -6, 8);
                var v = ov.swizzle.yyxzx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(0, -4, -1);
                var v = ov.swizzle.yyxzy;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-3, -9, 2);
                var v = ov.swizzle.yyxzz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(7, 0, -1);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new ivec3(8, -4, -9);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec3(8, 6, 9);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(3, 0, -9);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-4, 1, 6);
                var v = ov.swizzle.yyyxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-8, 2, 9);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(-9, -5, -3);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(9, -3, 5);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-7, 7, 2);
                var v = ov.swizzle.yyyyz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(7, -4, -1);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(-5, 0, -5);
                var v = ov.swizzle.yyyzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-9, 4, -3);
                var v = ov.swizzle.yyyzy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-7, -5, -7);
                var v = ov.swizzle.yyyzz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(0, 2, -6);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new ivec3(4, -2, 8);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec3(3, -5, -4);
                var v = ov.swizzle.yyzxx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(2, 2, -1);
                var v = ov.swizzle.yyzxy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(1, -4, 4);
                var v = ov.swizzle.yyzxz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(8, -7, 7);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(4, -1, 5);
                var v = ov.swizzle.yyzyx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-7, 1, -2);
                var v = ov.swizzle.yyzyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-8, 8, 0);
                var v = ov.swizzle.yyzyz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(3, -4, -6);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(-4, 0, 7);
                var v = ov.swizzle.yyzzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-2, -8, -2);
                var v = ov.swizzle.yyzzy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-7, 4, 0);
                var v = ov.swizzle.yyzzz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-7, -4, -3);
                var v = ov.swizzle.yz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var ov = new ivec3(7, 5, -2);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var ov = new ivec3(0, -4, 6);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(9, 9, 7);
                var v = ov.swizzle.yzxxx;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(5, -3, 4);
                var v = ov.swizzle.yzxxy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-1, 3, 1);
                var v = ov.swizzle.yzxxz;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(3, 6, 3);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(7, -9, 0);
                var v = ov.swizzle.yzxyx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-7, 7, 1);
                var v = ov.swizzle.yzxyy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(3, 8, -5);
                var v = ov.swizzle.yzxyz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-2, -2, -2);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new ivec3(7, 6, -7);
                var v = ov.swizzle.yzxzx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-3, 8, -6);
                var v = ov.swizzle.yzxzy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(0, -8, -4);
                var v = ov.swizzle.yzxzz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-4, -4, 3);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new ivec3(8, 8, 7);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec3(3, 0, -4);
                var v = ov.swizzle.yzyxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-1, -3, -8);
                var v = ov.swizzle.yzyxy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-6, 9, -4);
                var v = ov.swizzle.yzyxz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-2, -1, -7);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(9, -6, 4);
                var v = ov.swizzle.yzyyx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(-1, -7, -8);
                var v = ov.swizzle.yzyyy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-5, -8, 5);
                var v = ov.swizzle.yzyyz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(7, -8, -5);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new ivec3(5, 3, 8);
                var v = ov.swizzle.yzyzx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(8, -3, 5);
                var v = ov.swizzle.yzyzy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-7, 8, -9);
                var v = ov.swizzle.yzyzz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-4, 0, 7);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var ov = new ivec3(0, 1, -9);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(-4, -1, -7);
                var v = ov.swizzle.yzzxx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(2, 0, -8);
                var v = ov.swizzle.yzzxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-8, -1, 1);
                var v = ov.swizzle.yzzxz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(9, 3, -6);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec3(5, -3, -1);
                var v = ov.swizzle.yzzyx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(1, -5, 1);
                var v = ov.swizzle.yzzyy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-9, 5, 8);
                var v = ov.swizzle.yzzyz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(8, 7, -6);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(8, -5, 1);
                var v = ov.swizzle.yzzzx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-7, -5, -6);
                var v = ov.swizzle.yzzzy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-6, 9, -6);
                var v = ov.swizzle.yzzzz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-8, 1, 6);
                var v = ov.swizzle.zx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-8, v.y);
            }
            {
                var ov = new ivec3(8, 4, -8);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new ivec3(-6, 6, -3);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(6, -9, 9);
                var v = ov.swizzle.zxxxx;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(9, -1, -5);
                var v = ov.swizzle.zxxxy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(8, -3, 4);
                var v = ov.swizzle.zxxxz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(6, 0, -6);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(9, 4, 3);
                var v = ov.swizzle.zxxyx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(0, -4, 4);
                var v = ov.swizzle.zxxyy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-6, 1, -5);
                var v = ov.swizzle.zxxyz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(5, -3, -3);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(0, 6, -2);
                var v = ov.swizzle.zxxzx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(3, -2, -1);
                var v = ov.swizzle.zxxzy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(3, 3, -8);
                var v = ov.swizzle.zxxzz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-6, 1, 7);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new ivec3(6, -8, 3);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(6, 7, 1);
                var v = ov.swizzle.zxyxx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-1, 9, 8);
                var v = ov.swizzle.zxyxy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(-9, 8, -6);
                var v = ov.swizzle.zxyxz;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(3, 7, -1);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec3(-3, -9, 4);
                var v = ov.swizzle.zxyyx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-7, 1, 6);
                var v = ov.swizzle.zxyyy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-6, 9, 4);
                var v = ov.swizzle.zxyyz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(2, 5, 0);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(-4, 2, -7);
                var v = ov.swizzle.zxyzx;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-7, -3, 2);
                var v = ov.swizzle.zxyzy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-5, -4, -5);
                var v = ov.swizzle.zxyzz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(1, 8, -3);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec3(-3, -4, 2);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(4, 0, -7);
                var v = ov.swizzle.zxzxx;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-5, -9, 4);
                var v = ov.swizzle.zxzxy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(0, -1, 3);
                var v = ov.swizzle.zxzxz;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-4, -8, 0);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(1, 9, 8);
                var v = ov.swizzle.zxzyx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-9, 4, 2);
                var v = ov.swizzle.zxzyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(1, -7, 7);
                var v = ov.swizzle.zxzyz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-1, 2, -5);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new ivec3(-3, 8, -4);
                var v = ov.swizzle.zxzzx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-5, -2, -1);
                var v = ov.swizzle.zxzzy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-2, 4, 6);
                var v = ov.swizzle.zxzzz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(3, -2, 8);
                var v = ov.swizzle.zy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-2, v.y);
            }
            {
                var ov = new ivec3(6, 6, 5);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new ivec3(-6, -3, -2);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(-4, 3, -4);
                var v = ov.swizzle.zyxxx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(2, -4, 3);
                var v = ov.swizzle.zyxxy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(5, 1, 4);
                var v = ov.swizzle.zyxxz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-1, -2, -7);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new ivec3(-4, -3, -8);
                var v = ov.swizzle.zyxyx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(2, 1, -1);
                var v = ov.swizzle.zyxyy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(9, 4, -8);
                var v = ov.swizzle.zyxyz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-3, 2, -4);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new ivec3(-3, -7, -8);
                var v = ov.swizzle.zyxzx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(0, -3, -7);
                var v = ov.swizzle.zyxzy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-6, 5, 3);
                var v = ov.swizzle.zyxzz;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-5, -7, -8);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new ivec3(0, -1, -4);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(9, 8, 9);
                var v = ov.swizzle.zyyxx;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(5, 0, -2);
                var v = ov.swizzle.zyyxy;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(9, 8, -8);
                var v = ov.swizzle.zyyxz;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-1, 3, 4);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec3(-5, 5, 8);
                var v = ov.swizzle.zyyyx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-3, 0, 1);
                var v = ov.swizzle.zyyyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(0, 9, -6);
                var v = ov.swizzle.zyyyz;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(5, 5, 7);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec3(6, -5, 6);
                var v = ov.swizzle.zyyzx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-3, -9, -5);
                var v = ov.swizzle.zyyzy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-9, 1, -1);
                var v = ov.swizzle.zyyzz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-6, 0, -5);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new ivec3(7, 6, 1);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec3(2, 2, 7);
                var v = ov.swizzle.zyzxx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-9, 8, 8);
                var v = ov.swizzle.zyzxy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-2, 1, -9);
                var v = ov.swizzle.zyzxz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-5, 2, -7);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(-7, 0, 0);
                var v = ov.swizzle.zyzyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-8, 4, 3);
                var v = ov.swizzle.zyzyy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(2, -8, 5);
                var v = ov.swizzle.zyzyz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(5, -6, 9);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec3(3, -1, 2);
                var v = ov.swizzle.zyzzx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-3, -8, 4);
                var v = ov.swizzle.zyzzy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-3, 4, -3);
                var v = ov.swizzle.zyzzz;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-9, -7, 6);
                var v = ov.swizzle.zz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
            }
            {
                var ov = new ivec3(7, 5, -6);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var ov = new ivec3(-9, -5, -3);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new ivec3(6, -8, -6);
                var v = ov.swizzle.zzxxx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-8, 2, 0);
                var v = ov.swizzle.zzxxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(9, -8, -6);
                var v = ov.swizzle.zzxxz;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-2, 5, 8);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new ivec3(-6, -6, 6);
                var v = ov.swizzle.zzxyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-8, -6, -8);
                var v = ov.swizzle.zzxyy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(5, -8, 3);
                var v = ov.swizzle.zzxyz;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-5, 1, -7);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(3, -7, 2);
                var v = ov.swizzle.zzxzx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-4, 9, -8);
                var v = ov.swizzle.zzxzy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(6, 3, 3);
                var v = ov.swizzle.zzxzz;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-2, -9, -8);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new ivec3(-3, 5, 8);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(2, 3, -9);
                var v = ov.swizzle.zzyxx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(8, 1, -8);
                var v = ov.swizzle.zzyxy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(4, 3, 1);
                var v = ov.swizzle.zzyxz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(0, 9, 9);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec3(-8, -3, -6);
                var v = ov.swizzle.zzyyx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(9, -2, -6);
                var v = ov.swizzle.zzyyy;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-9, -4, 5);
                var v = ov.swizzle.zzyyz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-7, -6, 7);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec3(-7, 4, 2);
                var v = ov.swizzle.zzyzx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(4, 3, -7);
                var v = ov.swizzle.zzyzy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(7, 4, -1);
                var v = ov.swizzle.zzyzz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(8, 3, -5);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new ivec3(3, 5, 0);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec3(-8, -8, -3);
                var v = ov.swizzle.zzzxx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(1, -4, 0);
                var v = ov.swizzle.zzzxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(8, 8, -1);
                var v = ov.swizzle.zzzxz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(7, 1, 6);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec3(1, -4, -1);
                var v = ov.swizzle.zzzyx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(2, 5, 6);
                var v = ov.swizzle.zzzyy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-2, -1, -6);
                var v = ov.swizzle.zzzyz;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-6, 0, -9);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new ivec3(4, -2, 5);
                var v = ov.swizzle.zzzzx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-8, 8, 8);
                var v = ov.swizzle.zzzzy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(0, 6, 5);
                var v = ov.swizzle.zzzzz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(5, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new ivec3(-5, -9, 8);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
            }
            {
                var ov = new ivec3(-3, 9, 6);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec3(-6, -6, 1);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(-7, -6, 1);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-3, 1, -1);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-8, 7, -4);
                var v = ov.swizzle.rrrrb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-5, 5, -5);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new ivec3(1, -4, 0);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(2, 0, 3);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(1, -5, -8);
                var v = ov.swizzle.rrrgb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(3, -6, 2);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(-4, -9, -5);
                var v = ov.swizzle.rrrbr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-5, 4, 7);
                var v = ov.swizzle.rrrbg;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(1, 7, -7);
                var v = ov.swizzle.rrrbb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(7, 9, 8);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new ivec3(6, 8, -5);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(3, -5, 6);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(9, -5, 9);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-6, -4, 4);
                var v = ov.swizzle.rrgrb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(7, 9, 9);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec3(2, -5, 1);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(2, -4, 0);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-8, -8, 1);
                var v = ov.swizzle.rrggb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-6, 2, 2);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(5, -4, -8);
                var v = ov.swizzle.rrgbr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-8, -3, 3);
                var v = ov.swizzle.rrgbg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-1, -6, -2);
                var v = ov.swizzle.rrgbb;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(8, -7, -9);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new ivec3(-1, -3, 0);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(-3, -8, 5);
                var v = ov.swizzle.rrbrr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(9, 6, -5);
                var v = ov.swizzle.rrbrg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-8, -8, -2);
                var v = ov.swizzle.rrbrb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-5, 4, -6);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec3(7, 7, 9);
                var v = ov.swizzle.rrbgr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-3, 6, -3);
                var v = ov.swizzle.rrbgg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(4, 4, 1);
                var v = ov.swizzle.rrbgb;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-2, -8, 0);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(0, -7, -4);
                var v = ov.swizzle.rrbbr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-8, -4, -8);
                var v = ov.swizzle.rrbbg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(1, -1, 0);
                var v = ov.swizzle.rrbbb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-9, 5, 0);
                var v = ov.swizzle.rg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var ov = new ivec3(-5, 5, -5);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new ivec3(7, 7, -6);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new ivec3(6, 2, 8);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(7, 2, 7);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(1, -5, 9);
                var v = ov.swizzle.rgrrb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(6, 6, 8);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(-9, 0, -9);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(4, 8, 9);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(0, -9, 3);
                var v = ov.swizzle.rgrgb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-4, -3, -3);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(-5, 8, 2);
                var v = ov.swizzle.rgrbr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(9, -7, 1);
                var v = ov.swizzle.rgrbg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-8, -7, -6);
                var v = ov.swizzle.rgrbb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(5, 5, -5);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new ivec3(-2, -2, -4);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new ivec3(6, -6, -9);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(7, -4, 4);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-2, 0, 4);
                var v = ov.swizzle.rggrb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(0, -1, -6);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(4, 6, 7);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-2, -2, 8);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-5, -3, -4);
                var v = ov.swizzle.rgggb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(4, -2, -7);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(8, 8, 8);
                var v = ov.swizzle.rggbr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-3, -4, -5);
                var v = ov.swizzle.rggbg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(3, -2, -7);
                var v = ov.swizzle.rggbb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-5, -4, 3);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new ivec3(4, 6, -9);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec3(8, 3, 8);
                var v = ov.swizzle.rgbrr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-7, 9, 6);
                var v = ov.swizzle.rgbrg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(4, -3, -1);
                var v = ov.swizzle.rgbrb;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(7, -3, -3);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(6, -6, -9);
                var v = ov.swizzle.rgbgr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(0, 1, 4);
                var v = ov.swizzle.rgbgg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(1, -8, 5);
                var v = ov.swizzle.rgbgb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-6, -8, 5);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new ivec3(9, -6, -8);
                var v = ov.swizzle.rgbbr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(-9, 8, -3);
                var v = ov.swizzle.rgbbg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(4, 7, 5);
                var v = ov.swizzle.rgbbb;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(9, 6, 9);
                var v = ov.swizzle.rb;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
            }
            {
                var ov = new ivec3(5, 6, 2);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new ivec3(-1, 4, -6);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(-8, 4, 0);
                var v = ov.swizzle.rbrrr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(1, -7, -6);
                var v = ov.swizzle.rbrrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-7, -5, -2);
                var v = ov.swizzle.rbrrb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-9, 2, 7);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(-3, -2, 4);
                var v = ov.swizzle.rbrgr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(2, 7, -3);
                var v = ov.swizzle.rbrgg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(7, 4, 4);
                var v = ov.swizzle.rbrgb;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-8, 3, 5);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new ivec3(7, -6, 9);
                var v = ov.swizzle.rbrbr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(8, -4, -4);
                var v = ov.swizzle.rbrbg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(2, -1, -4);
                var v = ov.swizzle.rbrbb;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(9, -7, -4);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new ivec3(4, 7, -8);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec3(2, 2, -3);
                var v = ov.swizzle.rbgrr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(0, 4, 4);
                var v = ov.swizzle.rbgrg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-8, -6, -4);
                var v = ov.swizzle.rbgrb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(5, 2, -9);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(8, 2, 0);
                var v = ov.swizzle.rbggr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-2, 0, 0);
                var v = ov.swizzle.rbggg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-5, -4, 1);
                var v = ov.swizzle.rbggb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(5, 8, 0);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(-7, -6, -1);
                var v = ov.swizzle.rbgbr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-4, 3, -5);
                var v = ov.swizzle.rbgbg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(9, -8, 0);
                var v = ov.swizzle.rbgbb;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-4, 5, 2);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new ivec3(-1, -7, -8);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(0, 8, 0);
                var v = ov.swizzle.rbbrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-5, 3, -2);
                var v = ov.swizzle.rbbrg;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-5, -3, 8);
                var v = ov.swizzle.rbbrb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-3, -7, -7);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(-4, 9, -3);
                var v = ov.swizzle.rbbgr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-7, -6, -4);
                var v = ov.swizzle.rbbgg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-2, 3, 7);
                var v = ov.swizzle.rbbgb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-4, 3, -2);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new ivec3(-9, -5, 4);
                var v = ov.swizzle.rbbbr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-8, -4, -7);
                var v = ov.swizzle.rbbbg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-7, 0, 2);
                var v = ov.swizzle.rbbbb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(1, -4, 4);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(1, v.y);
            }
            {
                var ov = new ivec3(0, 9, 4);
                var v = ov.swizzle.grr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new ivec3(8, 1, 3);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec3(2, 0, 5);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-7, -6, 7);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(7, -7, 8);
                var v = ov.swizzle.grrrb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(8, -8, -4);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(9, 6, 4);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(7, -6, 7);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(6, -7, -9);
                var v = ov.swizzle.grrgb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-2, -6, -7);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(-4, -2, -5);
                var v = ov.swizzle.grrbr;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(7, -6, 6);
                var v = ov.swizzle.grrbg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(8, 3, 1);
                var v = ov.swizzle.grrbb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(4, -1, 3);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-1, v.z);
            }
            {
                var ov = new ivec3(5, 1, -9);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new ivec3(-6, -1, -7);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(7, 8, 2);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(8, -2, 6);
                var v = ov.swizzle.grgrb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(0, -3, -4);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(-6, 2, 4);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(3, 9, 4);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(8, 2, 4);
                var v = ov.swizzle.grggb;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-3, 0, 0);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(1, -9, -5);
                var v = ov.swizzle.grgbr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-3, 5, -5);
                var v = ov.swizzle.grgbg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(1, 1, -4);
                var v = ov.swizzle.grgbb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(8, 9, 5);
                var v = ov.swizzle.grb;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new ivec3(2, 3, 6);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new ivec3(-5, 5, 0);
                var v = ov.swizzle.grbrr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(8, 7, 3);
                var v = ov.swizzle.grbrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-3, -2, 0);
                var v = ov.swizzle.grbrb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-6, 0, 1);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(-9, -6, -9);
                var v = ov.swizzle.grbgr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-4, 3, -1);
                var v = ov.swizzle.grbgg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-6, 5, 8);
                var v = ov.swizzle.grbgb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(6, -5, 5);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new ivec3(-1, -8, -1);
                var v = ov.swizzle.grbbr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-9, 7, -2);
                var v = ov.swizzle.grbbg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-9, 1, 6);
                var v = ov.swizzle.grbbb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-7, -4, -6);
                var v = ov.swizzle.gg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
            }
            {
                var ov = new ivec3(4, 3, -2);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new ivec3(-7, 8, 7);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(-4, -7, 4);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-4, 2, 5);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-5, -4, 6);
                var v = ov.swizzle.ggrrb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(-5, 5, -7);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new ivec3(-7, 7, -1);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-4, -7, 8);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-3, -4, 3);
                var v = ov.swizzle.ggrgb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(8, -7, -8);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(-4, 1, 2);
                var v = ov.swizzle.ggrbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(2, 9, -9);
                var v = ov.swizzle.ggrbg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(-8, -9, -7);
                var v = ov.swizzle.ggrbb;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(1, -3, -8);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec3(1, -7, -6);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec3(5, 3, -4);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(5, 3, -6);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(8, -9, 6);
                var v = ov.swizzle.gggrb;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(5, -1, 6);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(3, 4, -5);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(3, 4, -9);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(5, 0, 0);
                var v = ov.swizzle.ggggb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(2, -3, 3);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec3(6, -6, 6);
                var v = ov.swizzle.gggbr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(6, v.v);
            }
            {
                var ov = new ivec3(0, -6, -4);
                var v = ov.swizzle.gggbg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-2, -2, -9);
                var v = ov.swizzle.gggbb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-3, 6, 9);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new ivec3(9, 3, -3);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec3(2, 4, 1);
                var v = ov.swizzle.ggbrr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-5, -6, -9);
                var v = ov.swizzle.ggbrg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-2, -5, -5);
                var v = ov.swizzle.ggbrb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(1, -7, 7);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(-8, -6, -7);
                var v = ov.swizzle.ggbgr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-6, 2, -1);
                var v = ov.swizzle.ggbgg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(9, -8, 7);
                var v = ov.swizzle.ggbgb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(8, 8, 3);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec3(-2, -4, -8);
                var v = ov.swizzle.ggbbr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(6, -1, -7);
                var v = ov.swizzle.ggbbg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(5, -4, 1);
                var v = ov.swizzle.ggbbb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(6, 2, -5);
                var v = ov.swizzle.gb;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-5, v.y);
            }
            {
                var ov = new ivec3(-8, 7, -6);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var ov = new ivec3(4, -4, 1);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec3(-2, -8, -8);
                var v = ov.swizzle.gbrrr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(6, -3, -6);
                var v = ov.swizzle.gbrrg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(2, -6, 4);
                var v = ov.swizzle.gbrrb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-8, -9, 5);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new ivec3(5, -4, -6);
                var v = ov.swizzle.gbrgr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-8, 3, 2);
                var v = ov.swizzle.gbrgg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(0, 5, 4);
                var v = ov.swizzle.gbrgb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(-8, -6, 3);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec3(5, -2, -3);
                var v = ov.swizzle.gbrbr;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(2, -7, -5);
                var v = ov.swizzle.gbrbg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-5, 5, 3);
                var v = ov.swizzle.gbrbb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(5, -7, -1);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new ivec3(4, 5, 0);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new ivec3(2, 4, -4);
                var v = ov.swizzle.gbgrr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-2, 7, -4);
                var v = ov.swizzle.gbgrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-6, 1, 8);
                var v = ov.swizzle.gbgrb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-8, -9, 3);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new ivec3(-3, 3, 8);
                var v = ov.swizzle.gbggr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-6, -4, 1);
                var v = ov.swizzle.gbggg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-5, 0, 0);
                var v = ov.swizzle.gbggb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(3, 0, -8);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(9, 2, -4);
                var v = ov.swizzle.gbgbr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(1, -9, -6);
                var v = ov.swizzle.gbgbg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(5, -4, -7);
                var v = ov.swizzle.gbgbb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(1, -8, 1);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new ivec3(-1, 5, 8);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(9, 9, -1);
                var v = ov.swizzle.gbbrr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(3, 3, -8);
                var v = ov.swizzle.gbbrg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-1, 1, 2);
                var v = ov.swizzle.gbbrb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-5, 9, 3);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new ivec3(8, 9, 4);
                var v = ov.swizzle.gbbgr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(0, -8, 3);
                var v = ov.swizzle.gbbgg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(-8, v.v);
            }
            {
                var ov = new ivec3(-5, 2, 4);
                var v = ov.swizzle.gbbgb;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(0, -4, 1);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec3(-2, -3, 5);
                var v = ov.swizzle.gbbbr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(6, -2, 4);
                var v = ov.swizzle.gbbbg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(7, 5, 7);
                var v = ov.swizzle.gbbbb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-3, 5, -1);
                var v = ov.swizzle.br;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var ov = new ivec3(9, -9, -7);
                var v = ov.swizzle.brr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new ivec3(0, -8, 1);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(-2, 6, 9);
                var v = ov.swizzle.brrrr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-3, -7, 4);
                var v = ov.swizzle.brrrg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-3, 1, -9);
                var v = ov.swizzle.brrrb;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-7, -5, 3);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new ivec3(4, 8, -5);
                var v = ov.swizzle.brrgr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(8, -1, -1);
                var v = ov.swizzle.brrgg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-2, 4, 8);
                var v = ov.swizzle.brrgb;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-7, 6, 3);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec3(-5, -5, 3);
                var v = ov.swizzle.brrbr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-4, 9, -9);
                var v = ov.swizzle.brrbg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(6, -4, 3);
                var v = ov.swizzle.brrbb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(2, 8, 7);
                var v = ov.swizzle.brg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new ivec3(-2, -9, -5);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new ivec3(1, -3, -1);
                var v = ov.swizzle.brgrr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(4, 9, 9);
                var v = ov.swizzle.brgrg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(4, 8, -6);
                var v = ov.swizzle.brgrb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(-5, 0, 8);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new ivec3(5, 8, -4);
                var v = ov.swizzle.brggr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-2, -4, -9);
                var v = ov.swizzle.brggg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(5, -8, 1);
                var v = ov.swizzle.brggb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(0, -8, -1);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(0, -1, 1);
                var v = ov.swizzle.brgbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-9, 1, 0);
                var v = ov.swizzle.brgbg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(7, -6, -2);
                var v = ov.swizzle.brgbb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(-5, -1, -1);
                var v = ov.swizzle.brb;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-1, v.z);
            }
            {
                var ov = new ivec3(-8, -2, -6);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(-3, 9, 6);
                var v = ov.swizzle.brbrr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(7, -9, 8);
                var v = ov.swizzle.brbrg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(9, 0, 5);
                var v = ov.swizzle.brbrb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(9, -1, -4);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new ivec3(7, 6, 1);
                var v = ov.swizzle.brbgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-4, 1, -4);
                var v = ov.swizzle.brbgg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(-9, 4, -9);
                var v = ov.swizzle.brbgb;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(8, 5, 6);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(-5, 6, 4);
                var v = ov.swizzle.brbbr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-7, -1, -7);
                var v = ov.swizzle.brbbg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(2, -3, 2);
                var v = ov.swizzle.brbbb;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(2, -2, 7);
                var v = ov.swizzle.bg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-2, v.y);
            }
            {
                var ov = new ivec3(-4, -2, -9);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new ivec3(1, -1, -1);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec3(-5, 8, -1);
                var v = ov.swizzle.bgrrr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(6, 0, 9);
                var v = ov.swizzle.bgrrg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(9, 0, 9);
                var v = ov.swizzle.bgrrb;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(-7, -8, 7);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(-7, 4, 4);
                var v = ov.swizzle.bgrgr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-9, -2, -2);
                var v = ov.swizzle.bgrgg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
            {
                var ov = new ivec3(4, -3, 8);
                var v = ov.swizzle.bgrgb;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(7, 7, -7);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(-1, 4, -4);
                var v = ov.swizzle.bgrbr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-4, -9, 8);
                var v = ov.swizzle.bgrbg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-5, -7, -4);
                var v = ov.swizzle.bgrbb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-4, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(8, -3, -6);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec3(-6, 8, 6);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(-5, 6, 9);
                var v = ov.swizzle.bggrr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(7, 5, -4);
                var v = ov.swizzle.bggrg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-5, 5, 7);
                var v = ov.swizzle.bggrb;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(2, -5, 0);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new ivec3(7, -7, -7);
                var v = ov.swizzle.bgggr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(1, 7, 1);
                var v = ov.swizzle.bgggg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-3, -5, -5);
                var v = ov.swizzle.bgggb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-5, -6, 1);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new ivec3(0, 2, 1);
                var v = ov.swizzle.bggbr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(1, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-4, 8, -1);
                var v = ov.swizzle.bggbg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(7, 3, 2);
                var v = ov.swizzle.bggbb;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(5, 9, 6);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new ivec3(-8, -9, 2);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(2, -6, -9);
                var v = ov.swizzle.bgbrr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(2, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(6, -1, 4);
                var v = ov.swizzle.bgbrg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(8, 6, 0);
                var v = ov.swizzle.bgbrb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(-6, 6, 5);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new ivec3(-5, 3, -4);
                var v = ov.swizzle.bgbgr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(-2, -9, 9);
                var v = ov.swizzle.bgbgg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-9, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(8, 6, 3);
                var v = ov.swizzle.bgbgb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(6, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(-3, 1, -6);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(-7, -4, -1);
                var v = ov.swizzle.bgbbr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-7, 1, 7);
                var v = ov.swizzle.bgbbg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(9, 2, 8);
                var v = ov.swizzle.bgbbb;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-8, 9, -9);
                var v = ov.swizzle.bb;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
            }
            {
                var ov = new ivec3(-5, 8, 4);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new ivec3(-6, -2, -5);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new ivec3(0, -7, 1);
                var v = ov.swizzle.bbrrr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var ov = new ivec3(5, -3, 0);
                var v = ov.swizzle.bbrrg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(8, -4, 9);
                var v = ov.swizzle.bbrrb;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(-6, 8, -2);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec3(-9, 8, -4);
                var v = ov.swizzle.bbrgr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(2, 8, -6);
                var v = ov.swizzle.bbrgg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-3, -2, 5);
                var v = ov.swizzle.bbrgb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(5, v.v);
            }
            {
                var ov = new ivec3(-3, 5, 3);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new ivec3(-7, -6, -3);
                var v = ov.swizzle.bbrbr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-4, -6, -1);
                var v = ov.swizzle.bbrbg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(4, -2, -5);
                var v = ov.swizzle.bbrbb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-5, v.w);
                Assert.AreEqual(-5, v.v);
            }
            {
                var ov = new ivec3(7, -3, 4);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new ivec3(-4, -2, 1);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new ivec3(-1, 7, 7);
                var v = ov.swizzle.bbgrr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(-7, -4, -3);
                var v = ov.swizzle.bbgrg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-4, v.v);
            }
            {
                var ov = new ivec3(-6, -9, 1);
                var v = ov.swizzle.bbgrb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(1, v.v);
            }
            {
                var ov = new ivec3(4, -3, -9);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new ivec3(7, 3, 0);
                var v = ov.swizzle.bbggr;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(9, 7, -1);
                var v = ov.swizzle.bbggg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(7, v.v);
            }
            {
                var ov = new ivec3(-8, 7, -6);
                var v = ov.swizzle.bbggb;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
                Assert.AreEqual(-6, v.v);
            }
            {
                var ov = new ivec3(7, -5, -8);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(-9, -1, -7);
                var v = ov.swizzle.bbgbr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-9, v.v);
            }
            {
                var ov = new ivec3(-7, -1, -6);
                var v = ov.swizzle.bbgbg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-1, v.v);
            }
            {
                var ov = new ivec3(9, 8, -7);
                var v = ov.swizzle.bbgbb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-7, v.v);
            }
            {
                var ov = new ivec3(-5, 2, 3);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new ivec3(-7, -5, -2);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new ivec3(9, 0, -6);
                var v = ov.swizzle.bbbrr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(9, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(-1, 9, 2);
                var v = ov.swizzle.bbbrg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(9, v.v);
            }
            {
                var ov = new ivec3(-1, -7, 8);
                var v = ov.swizzle.bbbrb;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-1, v.w);
                Assert.AreEqual(8, v.v);
            }
            {
                var ov = new ivec3(-5, -8, 4);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new ivec3(-3, -6, 3);
                var v = ov.swizzle.bbbgr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-6, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(4, 3, -2);
                var v = ov.swizzle.bbbgg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(3, v.w);
                Assert.AreEqual(3, v.v);
            }
            {
                var ov = new ivec3(9, -7, 2);
                var v = ov.swizzle.bbbgb;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(2, v.v);
            }
            {
                var ov = new ivec3(-6, -9, 8);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new ivec3(4, -4, 4);
                var v = ov.swizzle.bbbbr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
                Assert.AreEqual(4, v.v);
            }
            {
                var ov = new ivec3(2, -3, 0);
                var v = ov.swizzle.bbbbg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var ov = new ivec3(-6, -2, -2);
                var v = ov.swizzle.bbbbb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
                Assert.AreEqual(-2, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new ivec3(9, -4, -2);
                var v1 = new ivec2(7, -9);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7, v0.x);
                Assert.AreEqual(-9, v0.y);
                Assert.AreEqual(-2, v0.z);
            
                Assert.AreEqual(9, v2.x);
                Assert.AreEqual(-4, v2.y);
            }
            {
                var v0 = new ivec3(9, 0, -3);
                var v1 = new ivec2(-2, 5);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-2, v0.x);
                Assert.AreEqual(0, v0.y);
                Assert.AreEqual(5, v0.z);
            
                Assert.AreEqual(9, v2.x);
                Assert.AreEqual(-3, v2.y);
            }
            {
                var v0 = new ivec3(-3, -4, 1);
                var v1 = new ivec2(-7, 4);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3, v0.x);
                Assert.AreEqual(-7, v0.y);
                Assert.AreEqual(4, v0.z);
            
                Assert.AreEqual(-4, v2.x);
                Assert.AreEqual(1, v2.y);
            }
            {
                var v0 = new ivec3(-7, 0, -1);
                var v1 = new ivec3(-8, -3, -8);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8, v0.x);
                Assert.AreEqual(-3, v0.y);
                Assert.AreEqual(-8, v0.z);
            
                Assert.AreEqual(-7, v2.x);
                Assert.AreEqual(0, v2.y);
                Assert.AreEqual(-1, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new ivec3(9, -8, 3);
                var v1 = 1;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1, v0.x);
                Assert.AreEqual(-8, v0.y);
                Assert.AreEqual(3, v0.z);
            
                Assert.AreEqual(9, v2);
            }
            {
                var v0 = new ivec3(4, -4, -6);
                var v1 = 4;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(4, v0.x);
                Assert.AreEqual(4, v0.y);
                Assert.AreEqual(-6, v0.z);
            
                Assert.AreEqual(-4, v2);
            }
            {
                var v0 = new ivec3(-3, -5, -8);
                var v1 = new ivec2(7, 8);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7, v0.x);
                Assert.AreEqual(8, v0.y);
                Assert.AreEqual(-8, v0.z);
            
                Assert.AreEqual(-3, v2.x);
                Assert.AreEqual(-5, v2.y);
            }
            {
                var v0 = new ivec3(8, 4, -4);
                var v1 = -5;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8, v0.x);
                Assert.AreEqual(4, v0.y);
                Assert.AreEqual(-5, v0.z);
            
                Assert.AreEqual(-4, v2);
            }
            {
                var v0 = new ivec3(7, -2, 9);
                var v1 = new ivec2(2, 7);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2, v0.x);
                Assert.AreEqual(-2, v0.y);
                Assert.AreEqual(7, v0.z);
            
                Assert.AreEqual(7, v2.x);
                Assert.AreEqual(9, v2.y);
            }
            {
                var v0 = new ivec3(5, 2, 7);
                var v1 = new ivec2(-1, 1);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(5, v0.x);
                Assert.AreEqual(-1, v0.y);
                Assert.AreEqual(1, v0.z);
            
                Assert.AreEqual(2, v2.x);
                Assert.AreEqual(7, v2.y);
            }
            {
                var v0 = new ivec3(-7, 8, 1);
                var v1 = new ivec3(6, 0, -4);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6, v0.x);
                Assert.AreEqual(0, v0.y);
                Assert.AreEqual(-4, v0.z);
            
                Assert.AreEqual(-7, v2.x);
                Assert.AreEqual(8, v2.y);
                Assert.AreEqual(1, v2.z);
            }
        }

    }
}
