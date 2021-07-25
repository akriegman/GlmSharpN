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
    public class FloatSwizzleVec3Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new vec3(-7f, 9f, -9f);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
            }
            {
                var ov = new vec3(-6f, 7f, -7f);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new vec3(2.5f, -4f, -8f);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(-0.5f, -9f, 6f);
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(0.5f, 7f, -5.5f);
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(3.5f, 4f, 8f);
                var v = ov.swizzle.xxxxz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(5f, 7f, 9.5f);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec3(0f, -9.5f, -1f);
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(-6f, 2.5f, -0.5f);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(6f, 8f, 8f);
                var v = ov.swizzle.xxxyz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(-1.5f, 8.5f, -7.5f);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(4f, 7.5f, -6f);
                var v = ov.swizzle.xxxzx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(5.5f, -2f, 0.5f);
                var v = ov.swizzle.xxxzy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(4f, -1f, -7f);
                var v = ov.swizzle.xxxzz;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(-6f, 0.5f, -4f);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(0.5f, v.z);
            }
            {
                var ov = new vec3(7.5f, 3.5f, -3.5f);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(-4.5f, 3.5f, 3.5f);
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, -9f, -7.5f);
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(2.5f, -7f, -0.5f);
                var v = ov.swizzle.xxyxz;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(8f, 0f, -6f);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec3(-1.5f, -4.5f, 5f);
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec3(8f, 0f, -9.5f);
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(-5.5f, -4.5f, -1f);
                var v = ov.swizzle.xxyyz;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(8f, 8.5f, 3.5f);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(-8f, 0f, 7.5f);
                var v = ov.swizzle.xxyzx;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(-6.5f, -5.5f, 0.5f);
                var v = ov.swizzle.xxyzy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, -8f, 9.5f);
                var v = ov.swizzle.xxyzz;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(2f, -7.5f, -5f);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-5f, v.z);
            }
            {
                var ov = new vec3(-5f, 5.5f, -9f);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec3(9.5f, -2f, -9.5f);
                var v = ov.swizzle.xxzxx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(-3.5f, -2.5f, -2f);
                var v = ov.swizzle.xxzxy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(-5f, -7f, -4.5f);
                var v = ov.swizzle.xxzxz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-2f, 6f, -0.5f);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec3(3.5f, -4f, 7f);
                var v = ov.swizzle.xxzyx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(-5f, -6f, 5.5f);
                var v = ov.swizzle.xxzyy;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-6f, v.v);
            }
            {
                var ov = new vec3(0f, -5f, -9f);
                var v = ov.swizzle.xxzyz;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(-4.5f, 9f, 2.5f);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(9.5f, -1f, -7.5f);
                var v = ov.swizzle.xxzzx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(-6f, -4.5f, 3f);
                var v = ov.swizzle.xxzzy;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(0.5f, 3.5f, 5f);
                var v = ov.swizzle.xxzzz;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(0f, -5.5f, -3f);
                var v = ov.swizzle.xy;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-5.5f, v.y);
            }
            {
                var ov = new vec3(1.5f, -7.5f, -2f);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
            }
            {
                var ov = new vec3(-8.5f, 3f, -5.5f);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(-2f, -2f, -7f);
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(0f, 3f, 4f);
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(1.5f, -1.5f, 5f);
                var v = ov.swizzle.xyxxz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(-9.5f, -5f, -9.5f);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec3(0f, -5f, 2f);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(-2.5f, -2.5f, -6f);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(-0.5f, 8.5f, 1.5f);
                var v = ov.swizzle.xyxyz;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, -7.5f, -4f);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 2.5f, -0.5f);
                var v = ov.swizzle.xyxzx;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, -5.5f, 3.5f);
                var v = ov.swizzle.xyxzy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(-6.5f, -9f, -1f);
                var v = ov.swizzle.xyxzz;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(4.5f, -4f, 8.5f);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
            }
            {
                var ov = new vec3(-5f, 8.5f, 6f);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec3(-8f, -5.5f, 7.5f);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(7.5f, 9f, -9f);
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 9.5f, 9f);
                var v = ov.swizzle.xyyxz;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec3(-1f, 3f, 5.5f);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec3(6.5f, 2.5f, 5f);
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(2.5f, -0.5f, 0.5f);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(3f, -7f, -2f);
                var v = ov.swizzle.xyyyz;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(-5f, 6.5f, 3f);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec3(-2f, 6.5f, 5.5f);
                var v = ov.swizzle.xyyzx;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(8f, 6f, 0f);
                var v = ov.swizzle.xyyzy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(3f, -3f, -1.5f);
                var v = ov.swizzle.xyyzz;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec3(8f, -1f, -4f);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-4f, v.z);
            }
            {
                var ov = new vec3(4.5f, -5.5f, -2f);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec3(4.5f, 7.5f, 2.5f);
                var v = ov.swizzle.xyzxx;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(-9.5f, -4.5f, -8.5f);
                var v = ov.swizzle.xyzxy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(8.5f, -2.5f, -2.5f);
                var v = ov.swizzle.xyzxz;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(5f, 2f, -5.5f);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec3(8f, -1f, -8.5f);
                var v = ov.swizzle.xyzyx;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(5.5f, 2f, -1.5f);
                var v = ov.swizzle.xyzyy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(2f, v.w);
                Assert.AreEqual(2f, v.v);
            }
            {
                var ov = new vec3(4.5f, -3.5f, -3f);
                var v = ov.swizzle.xyzyz;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec3(-6.5f, -7f, 3.5f);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(8f, 6f, 0.5f);
                var v = ov.swizzle.xyzzx;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(6f, -2.5f, -8.5f);
                var v = ov.swizzle.xyzzy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, 8.5f, 5f);
                var v = ov.swizzle.xyzzz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(-8f, 9f, -9.5f);
                var v = ov.swizzle.xz;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-9.5f, v.y);
            }
            {
                var ov = new vec3(-9f, 5.5f, -2f);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-9f, v.z);
            }
            {
                var ov = new vec3(-7.5f, -4f, 9f);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(8f, 3f, 3f);
                var v = ov.swizzle.xzxxx;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(-7f, 5.5f, 1f);
                var v = ov.swizzle.xzxxy;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(7f, -3f, 7f);
                var v = ov.swizzle.xzxxz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 0f, 8.5f);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec3(9.5f, -1f, -8.5f);
                var v = ov.swizzle.xzxyx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(8.5f, -1f, -8f);
                var v = ov.swizzle.xzxyy;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(0.5f, 1.5f, 0f);
                var v = ov.swizzle.xzxyz;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(5f, -5f, 4f);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec3(-8f, 0.5f, 1f);
                var v = ov.swizzle.xzxzx;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(1f, -7f, 7f);
                var v = ov.swizzle.xzxzy;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(-6f, -2f, -3f);
                var v = ov.swizzle.xzxzz;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec3(3f, -4f, -4f);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
            }
            {
                var ov = new vec3(-0.5f, 1.5f, -1f);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec3(-0.5f, 9.5f, -4f);
                var v = ov.swizzle.xzyxx;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(-3f, 4f, 7.5f);
                var v = ov.swizzle.xzyxy;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(7f, -9f, 8.5f);
                var v = ov.swizzle.xzyxz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(9.5f, -9.5f, -5.5f);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(3.5f, 2.5f, -7.5f);
                var v = ov.swizzle.xzyyx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(9f, 3f, -0.5f);
                var v = ov.swizzle.xzyyy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(9.5f, 8.5f, 4f);
                var v = ov.swizzle.xzyyz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(0f, 5f, 6.5f);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec3(0f, 9f, -1.5f);
                var v = ov.swizzle.xzyzx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(-4.5f, 5.5f, 7.5f);
                var v = ov.swizzle.xzyzy;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(6f, 9f, -9.5f);
                var v = ov.swizzle.xzyzz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(6f, 1f, 1.5f);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
            }
            {
                var ov = new vec3(-3.5f, 2.5f, 9f);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec3(6f, -1f, -2f);
                var v = ov.swizzle.xzzxx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(2f, 2f, 6.5f);
                var v = ov.swizzle.xzzxy;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(2f, v.w);
                Assert.AreEqual(2f, v.v);
            }
            {
                var ov = new vec3(-5.5f, -6.5f, -9f);
                var v = ov.swizzle.xzzxz;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(0.5f, 4.5f, -1f);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec3(-4.5f, -0.5f, 2.5f);
                var v = ov.swizzle.xzzyx;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(6f, -0.5f, 4.5f);
                var v = ov.swizzle.xzzyy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(-8f, -3f, 4.5f);
                var v = ov.swizzle.xzzyz;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(8f, -7.5f, -6.5f);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec3(1f, 2.5f, -1f);
                var v = ov.swizzle.xzzzx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(4f, -3.5f, 1.5f);
                var v = ov.swizzle.xzzzy;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(0.5f, -6.5f, -1f);
                var v = ov.swizzle.xzzzz;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(-9f, 3.5f, -1.5f);
                var v = ov.swizzle.yx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-9f, v.y);
            }
            {
                var ov = new vec3(2.5f, 7.5f, 3f);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
            }
            {
                var ov = new vec3(9.5f, -6f, -2.5f);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec3(9f, 4.5f, 1f);
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec3(-3.5f, -7.5f, -9.5f);
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(-7.5f, v.v);
            }
            {
                var ov = new vec3(-2.5f, 0f, -2f);
                var v = ov.swizzle.yxxxz;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(7.5f, 7f, -9.5f);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec3(-5f, 7.5f, -1.5f);
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-1.5f, 1f, 9f);
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(-3.5f, -9.5f, 6.5f);
                var v = ov.swizzle.yxxyz;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(-1.5f, 9.5f, -1f);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(9.5f, 5f, 6.5f);
                var v = ov.swizzle.yxxzx;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(4f, -4f, 1.5f);
                var v = ov.swizzle.yxxzy;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(0.5f, -9f, 6.5f);
                var v = ov.swizzle.yxxzz;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(7f, 9.5f, -2.5f);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(9.5f, v.z);
            }
            {
                var ov = new vec3(-8.5f, -5f, 9f);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, -7f, -3.5f);
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-9f, 3.5f, -6f);
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, 4f, 6.5f);
                var v = ov.swizzle.yxyxz;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(9.5f, 3f, 5.5f);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec3(4.5f, -3f, 6.5f);
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(0.5f, -8.5f, 4.5f);
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, -3.5f, -7f);
                var v = ov.swizzle.yxyyz;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(-6.5f, -7.5f, -3.5f);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec3(-9.5f, 7f, -0.5f);
                var v = ov.swizzle.yxyzx;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(-6.5f, 7f, 7.5f);
                var v = ov.swizzle.yxyzy;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(0f, 6f, -3.5f);
                var v = ov.swizzle.yxyzz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(0f, 5.5f, 2f);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec3(-1f, 9f, 6f);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(4.5f, 8f, 1f);
                var v = ov.swizzle.yxzxx;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(9.5f, 5f, -1f);
                var v = ov.swizzle.yxzxy;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(6.5f, 6.5f, 5f);
                var v = ov.swizzle.yxzxz;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(0f, -8f, -9f);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec3(2.5f, 0.5f, -1.5f);
                var v = ov.swizzle.yxzyx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, 7f, 5.5f);
                var v = ov.swizzle.yxzyy;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(0f, 8.5f, -4.5f);
                var v = ov.swizzle.yxzyz;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 7f, 7.5f);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(8.5f, 8.5f, 6.5f);
                var v = ov.swizzle.yxzzx;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(9f, 3.5f, -8f);
                var v = ov.swizzle.yxzzy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, -9f, -2f);
                var v = ov.swizzle.yxzzz;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(-1.5f, 6.5f, -8f);
                var v = ov.swizzle.yy;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
            }
            {
                var ov = new vec3(-6f, -6.5f, -6f);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new vec3(-6f, -5.5f, -2f);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec3(-5.5f, -7.5f, 0.5f);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(-9f, 8f, -7f);
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(7.5f, 6f, -2.5f);
                var v = ov.swizzle.yyxxz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(7f, -1f, -1f);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(-8.5f, 7f, 0f);
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(4f, 1f, 7f);
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(-4f, -3.5f, 2f);
                var v = ov.swizzle.yyxyz;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(2f, v.v);
            }
            {
                var ov = new vec3(-2.5f, 7f, 8.5f);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(6f, 4f, 3.5f);
                var v = ov.swizzle.yyxzx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(-1f, -8f, -5.5f);
                var v = ov.swizzle.yyxzy;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(-9f, -5.5f, -4f);
                var v = ov.swizzle.yyxzz;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(-4f, 2f, -3.5f);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec3(6f, -9.5f, 0.5f);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec3(-9.5f, -2f, -2.5f);
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, -3.5f, 8f);
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(0f, 6f, -1.5f);
                var v = ov.swizzle.yyyxz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec3(-7f, -1f, -7.5f);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(8f, 1f, 7.5f);
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(9f, 6.5f, -5f);
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, -2f, 3f);
                var v = ov.swizzle.yyyyz;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(-6.5f, -2.5f, -0.5f);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec3(3f, -1.5f, -3.5f);
                var v = ov.swizzle.yyyzx;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(6.5f, 6f, 5f);
                var v = ov.swizzle.yyyzy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(-5f, 7.5f, -8.5f);
                var v = ov.swizzle.yyyzz;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(-7f, 4.5f, -5f);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-5f, v.z);
            }
            {
                var ov = new vec3(-6f, 6.5f, -8.5f);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec3(-0.5f, 6f, 7.5f);
                var v = ov.swizzle.yyzxx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(5f, 4.5f, 6f);
                var v = ov.swizzle.yyzxy;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(1f, 9f, -6.5f);
                var v = ov.swizzle.yyzxz;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(-7f, 4f, 5f);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec3(-1f, -6f, 8f);
                var v = ov.swizzle.yyzyx;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 6.5f, -5.5f);
                var v = ov.swizzle.yyzyy;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, -2.5f, 8.5f);
                var v = ov.swizzle.yyzyz;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, 4f, 0f);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 1f, -4f);
                var v = ov.swizzle.yyzzx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(1f, 1.5f, 7f);
                var v = ov.swizzle.yyzzy;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, 3.5f, 0f);
                var v = ov.swizzle.yyzzz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(4.5f, 2f, 5f);
                var v = ov.swizzle.yz;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(5f, v.y);
            }
            {
                var ov = new vec3(6f, -8f, 2.5f);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(6f, v.z);
            }
            {
                var ov = new vec3(-6.5f, 1f, -8f);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec3(3f, -9.5f, 2f);
                var v = ov.swizzle.yzxxx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(9.5f, 4f, -7.5f);
                var v = ov.swizzle.yzxxy;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(-2f, 1.5f, 7.5f);
                var v = ov.swizzle.yzxxz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, -8f, 8f);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 6f, 1f);
                var v = ov.swizzle.yzxyx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, -7.5f, 2.5f);
                var v = ov.swizzle.yzxyy;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(-7.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, 9.5f, -8f);
                var v = ov.swizzle.yzxyz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(-5f, 4.5f, -1f);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(5f, -7f, -3f);
                var v = ov.swizzle.yzxzx;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(3f, -9.5f, -8f);
                var v = ov.swizzle.yzxzy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, -5f, -4.5f);
                var v = ov.swizzle.yzxzz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-9.5f, -9f, -5.5f);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-9f, v.z);
            }
            {
                var ov = new vec3(7.5f, -5.5f, 7.5f);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(2.5f, 0.5f, 0f);
                var v = ov.swizzle.yzyxx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(-1f, 1.5f, -6f);
                var v = ov.swizzle.yzyxy;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(2.5f, -1f, 5.5f);
                var v = ov.swizzle.yzyxz;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(3f, 8f, 6.5f);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec3(9.5f, 0.5f, 2f);
                var v = ov.swizzle.yzyyx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(9.5f, -0.5f, -3.5f);
                var v = ov.swizzle.yzyyy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, 4.5f, -1.5f);
                var v = ov.swizzle.yzyyz;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec3(8f, 7f, -1f);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(-9f, 9.5f, 3f);
                var v = ov.swizzle.yzyzx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(-6.5f, 3f, -1.5f);
                var v = ov.swizzle.yzyzy;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(-8f, 9.5f, 8.5f);
                var v = ov.swizzle.yzyzz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, 0f, 9f);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
            }
            {
                var ov = new vec3(-8f, 3f, 2f);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec3(5.5f, -4f, 5f);
                var v = ov.swizzle.yzzxx;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(-8f, 0f, -1f);
                var v = ov.swizzle.yzzxy;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(-7.5f, 1.5f, -4.5f);
                var v = ov.swizzle.yzzxz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-6.5f, -9.5f, 0.5f);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(8.5f, 6f, 0.5f);
                var v = ov.swizzle.yzzyx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(9f, -6.5f, -7.5f);
                var v = ov.swizzle.yzzyy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(-0.5f, 1.5f, 2.5f);
                var v = ov.swizzle.yzzyz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(-2f, 8f, 7f);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec3(7f, -3.5f, 9f);
                var v = ov.swizzle.yzzzx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(7.5f, 4f, -0.5f);
                var v = ov.swizzle.yzzzy;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(2.5f, -7.5f, -4.5f);
                var v = ov.swizzle.yzzzz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-5.5f, 5.5f, -9.5f);
                var v = ov.swizzle.zx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
            }
            {
                var ov = new vec3(-7.5f, 0.5f, 7f);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var ov = new vec3(9.5f, 7.5f, 7f);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec3(-9f, 9.5f, -6.5f);
                var v = ov.swizzle.zxxxx;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(7.5f, -9f, 2.5f);
                var v = ov.swizzle.zxxxy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(8f, -3.5f, -7f);
                var v = ov.swizzle.zxxxz;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(-1.5f, -1.5f, -3f);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec3(9f, -5.5f, 4f);
                var v = ov.swizzle.zxxyx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec3(7.5f, -1f, -5f);
                var v = ov.swizzle.zxxyy;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(1f, -5.5f, -2.5f);
                var v = ov.swizzle.zxxyz;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, 1.5f, 8.5f);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(5f, -5f, -2f);
                var v = ov.swizzle.zxxzx;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(9f, -2.5f, 2.5f);
                var v = ov.swizzle.zxxzy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(-4f, 0.5f, 4.5f);
                var v = ov.swizzle.zxxzz;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(-4.5f, 3.5f, 8f);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec3(-4.5f, 9f, 6f);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec3(-7f, -0.5f, -8f);
                var v = ov.swizzle.zxyxx;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(-2f, 4f, 4.5f);
                var v = ov.swizzle.zxyxy;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(-2f, -4f, -2f);
                var v = ov.swizzle.zxyxz;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(-5f, -5.5f, -9.5f);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec3(3.5f, 8.5f, -3f);
                var v = ov.swizzle.zxyyx;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(-9.5f, -6.5f, 8f);
                var v = ov.swizzle.zxyyy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(-4.5f, 2.5f, 4f);
                var v = ov.swizzle.zxyyz;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(-8.5f, 9.5f, 8.5f);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(-4.5f, -4f, 8.5f);
                var v = ov.swizzle.zxyzx;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-9f, -4.5f, 0.5f);
                var v = ov.swizzle.zxyzy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(6.5f, -3f, 1f);
                var v = ov.swizzle.zxyzz;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(8f, -4.5f, 5.5f);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var ov = new vec3(8f, -5.5f, -3.5f);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec3(4f, 3.5f, 0f);
                var v = ov.swizzle.zxzxx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(9.5f, 4.5f, 3f);
                var v = ov.swizzle.zxzxy;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(-3f, -8.5f, 1.5f);
                var v = ov.swizzle.zxzxz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-8.5f, 5f, 9f);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec3(0f, 0f, -7f);
                var v = ov.swizzle.zxzyx;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(1f, 5.5f, 0.5f);
                var v = ov.swizzle.zxzyy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(-9f, -2.5f, 1.5f);
                var v = ov.swizzle.zxzyz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, 3.5f, -0.5f);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec3(-8.5f, -9f, -1f);
                var v = ov.swizzle.zxzzx;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(-9f, -4.5f, -3f);
                var v = ov.swizzle.zxzzy;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-8f, -1f, 9.5f);
                var v = ov.swizzle.zxzzz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, -9.5f, 8.5f);
                var v = ov.swizzle.zy;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
            }
            {
                var ov = new vec3(4f, -8.5f, 4f);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec3(5.5f, -2f, 2.5f);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec3(6f, 8.5f, -9.5f);
                var v = ov.swizzle.zyxxx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(-8.5f, 6.5f, -3f);
                var v = ov.swizzle.zyxxy;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(-5.5f, 6f, -0.5f);
                var v = ov.swizzle.zyxxz;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(4f, 0.5f, 7.5f);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(5.5f, 8f, 0f);
                var v = ov.swizzle.zyxyx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(-2f, -9f, -5f);
                var v = ov.swizzle.zyxyy;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(2.5f, 3.5f, 6.5f);
                var v = ov.swizzle.zyxyz;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(-9f, 2f, 4.5f);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec3(-1f, -8f, -9.5f);
                var v = ov.swizzle.zyxzx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(-8f, 7.5f, -4f);
                var v = ov.swizzle.zyxzy;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec3(-4.5f, -5.5f, -5f);
                var v = ov.swizzle.zyxzz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(9.5f, -0.5f, 4.5f);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec3(9f, 0f, -6.5f);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec3(8.5f, 5.5f, -8f);
                var v = ov.swizzle.zyyxx;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-5.5f, -3f, -8.5f);
                var v = ov.swizzle.zyyxy;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec3(2f, -2.5f, -2f);
                var v = ov.swizzle.zyyxz;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(2f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(8.5f, 3.5f, 2f);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(-0.5f, 3f, -9f);
                var v = ov.swizzle.zyyyx;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, -1.5f, 5.5f);
                var v = ov.swizzle.zyyyy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec3(-4.5f, 9f, -8f);
                var v = ov.swizzle.zyyyz;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(3.5f, 5f, 9f);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec3(-5f, -9.5f, 5f);
                var v = ov.swizzle.zyyzx;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, 5.5f, -9f);
                var v = ov.swizzle.zyyzy;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(5f, 1f, -8f);
                var v = ov.swizzle.zyyzz;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(2.5f, 4.5f, 8.5f);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
            }
            {
                var ov = new vec3(-9f, 5.5f, 0.5f);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec3(-3f, 8f, 0.5f);
                var v = ov.swizzle.zyzxx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec3(7f, -9.5f, 4f);
                var v = ov.swizzle.zyzxy;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(-1f, 5.5f, -9.5f);
                var v = ov.swizzle.zyzxz;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, 3f, 1f);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec3(9.5f, -5.5f, 0.5f);
                var v = ov.swizzle.zyzyx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(4f, 5f, -0.5f);
                var v = ov.swizzle.zyzyy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(8f, 8f, 3.5f);
                var v = ov.swizzle.zyzyz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(-5f, -9.5f, 1.5f);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(2.5f, 2.5f, 1.5f);
                var v = ov.swizzle.zyzzx;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(-4.5f, 7.5f, 8f);
                var v = ov.swizzle.zyzzy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec3(-8.5f, -7f, 3.5f);
                var v = ov.swizzle.zyzzz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(4f, -2f, 1f);
                var v = ov.swizzle.zz;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
            }
            {
                var ov = new vec3(-1.5f, -4.5f, -3.5f);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
            }
            {
                var ov = new vec3(5f, 3f, -5.5f);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec3(-4.5f, -2.5f, 2.5f);
                var v = ov.swizzle.zzxxx;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-8f, 5f, -8f);
                var v = ov.swizzle.zzxxy;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(-1.5f, -2.5f, -0.5f);
                var v = ov.swizzle.zzxxz;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(8f, 9f, -3.5f);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec3(6.5f, 8.5f, -1.5f);
                var v = ov.swizzle.zzxyx;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(8.5f, -6f, -2.5f);
                var v = ov.swizzle.zzxyy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-6f, v.v);
            }
            {
                var ov = new vec3(-3f, -3.5f, 8.5f);
                var v = ov.swizzle.zzxyz;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-1f, -5f, -2.5f);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec3(8f, 4.5f, -2f);
                var v = ov.swizzle.zzxzx;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(-1.5f, -7f, -9.5f);
                var v = ov.swizzle.zzxzy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(3f, 2f, 4f);
                var v = ov.swizzle.zzxzz;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(9f, -0.5f, 3.5f);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec3(9.5f, -5f, -3.5f);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec3(-4f, 7.5f, -1f);
                var v = ov.swizzle.zzyxx;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(-9.5f, -2f, 6f);
                var v = ov.swizzle.zzyxy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(6f, 8f, -4f);
                var v = ov.swizzle.zzyxz;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(-4f, -0.5f, 8f);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec3(8.5f, 2.5f, -8f);
                var v = ov.swizzle.zzyyx;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-3.5f, -5f, -2f);
                var v = ov.swizzle.zzyyy;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(5f, 9f, -1f);
                var v = ov.swizzle.zzyyz;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(5f, 9.5f, -1f);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(8f, 5f, 7f);
                var v = ov.swizzle.zzyzx;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(-7.5f, -2.5f, 8f);
                var v = ov.swizzle.zzyzy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, 8.5f, 1f);
                var v = ov.swizzle.zzyzz;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(0f, 9.5f, -0.5f);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec3(-2.5f, 1.5f, 2f);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec3(-9.5f, 1f, -3.5f);
                var v = ov.swizzle.zzzxx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(8.5f, -5f, -2.5f);
                var v = ov.swizzle.zzzxy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-1f, 4f, -1f);
                var v = ov.swizzle.zzzxz;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(-2.5f, -5.5f, -5f);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec3(-8.5f, 4.5f, 5f);
                var v = ov.swizzle.zzzyx;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(-5f, 8f, 7.5f);
                var v = ov.swizzle.zzzyy;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(0f, -2f, 6f);
                var v = ov.swizzle.zzzyz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(9.5f, -4.5f, -8.5f);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(5f, -8f, 1.5f);
                var v = ov.swizzle.zzzzx;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(7f, 8.5f, 2.5f);
                var v = ov.swizzle.zzzzy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-0.5f, 8.5f, -6.5f);
                var v = ov.swizzle.zzzzz;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new vec3(-5f, 9f, 9f);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
            }
            {
                var ov = new vec3(4.5f, -7f, 9f);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec3(4f, -9.5f, 8.5f);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec3(0.5f, -3f, -6.5f);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(0.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, -9f, 4.5f);
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(-2f, 4.5f, -6.5f);
                var v = ov.swizzle.rrrrb;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(-7f, 2.5f, -1.5f);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(-3.5f, -7.5f, 8f);
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(-1f, 3f, -2f);
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(-9.5f, -6f, -5f);
                var v = ov.swizzle.rrrgb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-9f, 2f, 4f);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec3(-0.5f, -3f, 2.5f);
                var v = ov.swizzle.rrrbr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 2f, 6.5f);
                var v = ov.swizzle.rrrbg;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(2f, v.v);
            }
            {
                var ov = new vec3(6f, 9.5f, -8.5f);
                var v = ov.swizzle.rrrbb;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(-9f, -8f, -9f);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-8f, v.z);
            }
            {
                var ov = new vec3(-4.5f, -0.5f, -5f);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec3(7.5f, 6.5f, 6.5f);
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, 5.5f, -5.5f);
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(3f, -1.5f, -2.5f);
                var v = ov.swizzle.rrgrb;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(0f, -6.5f, -4f);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec3(8.5f, -4.5f, 4f);
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-6.5f, -1f, -1f);
                var v = ov.swizzle.rrggg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(-8f, 5f, 6f);
                var v = ov.swizzle.rrggb;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(1f, -3.5f, 2.5f);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(-3.5f, 9f, 2.5f);
                var v = ov.swizzle.rrgbr;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(7f, 6f, 4f);
                var v = ov.swizzle.rrgbg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(0.5f, -3.5f, -4f);
                var v = ov.swizzle.rrgbb;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(7.5f, -7.5f, -9f);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-9f, v.z);
            }
            {
                var ov = new vec3(-8f, 6.5f, 6f);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec3(-8.5f, -3.5f, -4.5f);
                var v = ov.swizzle.rrbrr;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(5f, -3.5f, -9f);
                var v = ov.swizzle.rrbrg;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(-6.5f, 8f, -5f);
                var v = ov.swizzle.rrbrb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-6f, 6.5f, 6f);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec3(7f, 6f, -5.5f);
                var v = ov.swizzle.rrbgr;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(8f, 6.5f, -1f);
                var v = ov.swizzle.rrbgg;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(3f, 5.5f, -3.5f);
                var v = ov.swizzle.rrbgb;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, 5.5f, -7.5f);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 9f, 7.5f);
                var v = ov.swizzle.rrbbr;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(9.5f, 1f, 2f);
                var v = ov.swizzle.rrbbg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(2f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 4f, -5f);
                var v = ov.swizzle.rrbbb;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(4f, 6.5f, -9.5f);
                var v = ov.swizzle.rg;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(6.5f, v.y);
            }
            {
                var ov = new vec3(-8.5f, 6.5f, 9.5f);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec3(-4f, 3f, 1f);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec3(-8f, 1.5f, -1f);
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(7.5f, -6.5f, -9f);
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(0.5f, -1.5f, -3.5f);
                var v = ov.swizzle.rgrrb;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(7f, -4f, 0f);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec3(-8.5f, 0.5f, 0.5f);
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(3f, -7.5f, -6f);
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(-7.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, -5.5f, 6f);
                var v = ov.swizzle.rgrgb;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(-3f, 0.5f, 1.5f);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(2.5f, 3f, -1f);
                var v = ov.swizzle.rgrbr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(3f, -2.5f, 0f);
                var v = ov.swizzle.rgrbg;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(-1f, 0.5f, 2.5f);
                var v = ov.swizzle.rgrbb;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(-4.5f, -4f, 3f);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
            }
            {
                var ov = new vec3(-1f, -3.5f, -2.5f);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(-8f, 8f, -3f);
                var v = ov.swizzle.rggrr;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(-6f, -8f, 0.5f);
                var v = ov.swizzle.rggrg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(-5f, -6.5f, 6f);
                var v = ov.swizzle.rggrb;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(-0.5f, -8f, -4f);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec3(-5.5f, 2.5f, -9.5f);
                var v = ov.swizzle.rgggr;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(4.5f, 4f, 1f);
                var v = ov.swizzle.rgggg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(-9f, 5f, -9.5f);
                var v = ov.swizzle.rgggb;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(8f, -2.5f, 1f);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(-3.5f, 6.5f, -5.5f);
                var v = ov.swizzle.rggbr;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(-3.5f, v.v);
            }
            {
                var ov = new vec3(7f, 6.5f, -6f);
                var v = ov.swizzle.rggbg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(-2.5f, 2.5f, 6.5f);
                var v = ov.swizzle.rggbb;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(-1.5f, 3f, -5f);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-5f, v.z);
            }
            {
                var ov = new vec3(4.5f, 6.5f, -3f);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec3(1f, -7f, -9.5f);
                var v = ov.swizzle.rgbrr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(3f, -5f, 8f);
                var v = ov.swizzle.rgbrg;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-3.5f, -2.5f, 8.5f);
                var v = ov.swizzle.rgbrb;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-3f, 0.5f, 8f);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(2f, 2.5f, -8.5f);
                var v = ov.swizzle.rgbgr;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(2f, v.v);
            }
            {
                var ov = new vec3(7f, 8f, -7.5f);
                var v = ov.swizzle.rgbgg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(-2f, 0.5f, -8.5f);
                var v = ov.swizzle.rgbgb;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(6f, 6f, -2.5f);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec3(0.5f, 2f, -4.5f);
                var v = ov.swizzle.rgbbr;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(0.5f, v.v);
            }
            {
                var ov = new vec3(-8f, 5.5f, -1.5f);
                var v = ov.swizzle.rgbbg;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(4f, 0f, 8f);
                var v = ov.swizzle.rgbbb;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(-0.5f, -8f, -1.5f);
                var v = ov.swizzle.rb;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
            }
            {
                var ov = new vec3(0f, 5f, -2f);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new vec3(2.5f, 0f, 9f);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(-4.5f, 5.5f, 5f);
                var v = ov.swizzle.rbrrr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(7f, -5.5f, 0f);
                var v = ov.swizzle.rbrrg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(-6f, -8.5f, 5.5f);
                var v = ov.swizzle.rbrrb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, -7.5f, 5f);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, 5.5f, -1f);
                var v = ov.swizzle.rbrgr;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(2.5f, -3f, -3f);
                var v = ov.swizzle.rbrgg;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec3(-5.5f, 8f, 1.5f);
                var v = ov.swizzle.rbrgb;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-1f, 7f, 0.5f);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(9.5f, -4f, -5f);
                var v = ov.swizzle.rbrbr;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(2.5f, 7f, 3f);
                var v = ov.swizzle.rbrbg;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(9f, -9f, 0.5f);
                var v = ov.swizzle.rbrbb;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(0.5f, v.v);
            }
            {
                var ov = new vec3(-2f, -8.5f, -1f);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec3(-8.5f, -6.5f, -8f);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(-4.5f, 2f, -5f);
                var v = ov.swizzle.rbgrr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(2.5f, -2f, -8f);
                var v = ov.swizzle.rbgrg;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(3f, 7.5f, -6.5f);
                var v = ov.swizzle.rbgrb;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(-8f, 7f, 2.5f);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec3(9.5f, 8f, 1.5f);
                var v = ov.swizzle.rbggr;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(-8f, -5f, -1.5f);
                var v = ov.swizzle.rbggg;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-6f, 8f, -1f);
                var v = ov.swizzle.rbggb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(-4.5f, -6.5f, -4f);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec3(2.5f, -6.5f, 3f);
                var v = ov.swizzle.rbgbr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(-6f, -9.5f, -4f);
                var v = ov.swizzle.rbgbg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(9.5f, -1f, 0.5f);
                var v = ov.swizzle.rbgbb;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(0.5f, v.v);
            }
            {
                var ov = new vec3(4.5f, 8.5f, 6f);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
            }
            {
                var ov = new vec3(-7f, -8f, 6.5f);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec3(-2f, 6.5f, -6f);
                var v = ov.swizzle.rbbrr;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(2.5f, -5f, 9.5f);
                var v = ov.swizzle.rbbrg;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-1f, -1f, -1f);
                var v = ov.swizzle.rbbrb;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(8.5f, 3.5f, 5f);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 5f, -4f);
                var v = ov.swizzle.rbbgr;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(7f, 0f, -9f);
                var v = ov.swizzle.rbbgg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(0f, 0f, -1.5f);
                var v = ov.swizzle.rbbgb;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec3(-4f, -2.5f, -8f);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec3(8f, -8f, 6.5f);
                var v = ov.swizzle.rbbbr;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(2f, 4f, -1f);
                var v = ov.swizzle.rbbbg;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(-4.5f, 1f, 6.5f);
                var v = ov.swizzle.rbbbb;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(2.5f, 3f, -2f);
                var v = ov.swizzle.gr;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(2.5f, v.y);
            }
            {
                var ov = new vec3(4.5f, 3.5f, 7f);
                var v = ov.swizzle.grr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec3(-4f, -8.5f, -3f);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec3(3.5f, -7f, -3.5f);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(7f, -6f, 5f);
                var v = ov.swizzle.grrrg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(-6f, v.v);
            }
            {
                var ov = new vec3(-6f, -3.5f, 7.5f);
                var v = ov.swizzle.grrrb;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec3(-2.5f, -6f, -8f);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec3(7f, 8.5f, 8f);
                var v = ov.swizzle.grrgr;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(8.5f, -6.5f, 6.5f);
                var v = ov.swizzle.grrgg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(2f, 8f, 5f);
                var v = ov.swizzle.grrgb;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(9.5f, -3f, 1.5f);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(8f, 1.5f, 1f);
                var v = ov.swizzle.grrbr;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(2f, -4f, 6f);
                var v = ov.swizzle.grrbg;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(-2f, -2.5f, -9f);
                var v = ov.swizzle.grrbb;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(-6f, -8.5f, -1f);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec3(1.5f, 0f, 2f);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, -3.5f, -9f);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-3f, 8.5f, -3.5f);
                var v = ov.swizzle.grgrg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-9f, -5.5f, 5f);
                var v = ov.swizzle.grgrb;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(3f, 6.5f, -1f);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec3(-1f, -2f, -3f);
                var v = ov.swizzle.grggr;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(6f, 3.5f, 3f);
                var v = ov.swizzle.grggg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(4.5f, 9.5f, -4.5f);
                var v = ov.swizzle.grggb;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(3f, -4f, -3f);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec3(1.5f, -6f, -0.5f);
                var v = ov.swizzle.grgbr;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(8.5f, 2.5f, -7f);
                var v = ov.swizzle.grgbg;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(8.5f, 6f, -6.5f);
                var v = ov.swizzle.grgbb;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-6.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(4.5f, -2f, -7.5f);
                var v = ov.swizzle.grb;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var ov = new vec3(-2.5f, -2.5f, -5f);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec3(5f, 0.5f, 7f);
                var v = ov.swizzle.grbrr;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(6.5f, 9.5f, -8f);
                var v = ov.swizzle.grbrg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(6.5f, 0f, -5f);
                var v = ov.swizzle.grbrb;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(5f, 8f, -2.5f);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec3(6f, 6.5f, 1f);
                var v = ov.swizzle.grbgr;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(-7f, -1.5f, -3f);
                var v = ov.swizzle.grbgg;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-1.5f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec3(5f, -7.5f, -6.5f);
                var v = ov.swizzle.grbgb;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, -9.5f, 2.5f);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(-0.5f, 4f, -0.5f);
                var v = ov.swizzle.grbbr;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(-2.5f, -6f, 0f);
                var v = ov.swizzle.grbbg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(-6f, v.v);
            }
            {
                var ov = new vec3(1.5f, -9.5f, 6f);
                var v = ov.swizzle.grbbb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(-0.5f, -0.5f, 8f);
                var v = ov.swizzle.gg;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
            }
            {
                var ov = new vec3(-7f, 6f, -5f);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-7f, v.z);
            }
            {
                var ov = new vec3(5.5f, 4.5f, -5f);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec3(-4f, 3.5f, -6.5f);
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(-0.5f, 1.5f, 9f);
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-8.5f, -8f, -6.5f);
                var v = ov.swizzle.ggrrb;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(9f, -8.5f, 5f);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, 8f, 9f);
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-6f, 7f, 4.5f);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(-1.5f, 8f, -5.5f);
                var v = ov.swizzle.ggrgb;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(-5f, -5f, -0.5f);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec3(-8.5f, -7f, 7f);
                var v = ov.swizzle.ggrbr;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(2.5f, 9.5f, -8.5f);
                var v = ov.swizzle.ggrbg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, -1f, -2.5f);
                var v = ov.swizzle.ggrbb;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(8f, -6.5f, -2.5f);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
            }
            {
                var ov = new vec3(8f, 9.5f, -3f);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec3(-9f, 6f, 8.5f);
                var v = ov.swizzle.gggrr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(-7f, -8.5f, 8.5f);
                var v = ov.swizzle.gggrg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(1f, 8.5f, -8.5f);
                var v = ov.swizzle.gggrb;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(9.5f, 1f, 9.5f);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(-9.5f, 6f, -3.5f);
                var v = ov.swizzle.ggggr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(0.5f, 8.5f, -8f);
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, 8f, -5f);
                var v = ov.swizzle.ggggb;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(2f, -1.5f, -8f);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec3(2f, -2f, 9f);
                var v = ov.swizzle.gggbr;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(2f, v.v);
            }
            {
                var ov = new vec3(-8f, -6.5f, -4.5f);
                var v = ov.swizzle.gggbg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(-6.5f, 6f, 7f);
                var v = ov.swizzle.gggbb;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(-8.5f, 8f, 2f);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec3(-4.5f, 8.5f, 3.5f);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, -9f, -9f);
                var v = ov.swizzle.ggbrr;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-2.5f, 3.5f, 7.5f);
                var v = ov.swizzle.ggbrg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, -8f, 4f);
                var v = ov.swizzle.ggbrb;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(0f, -8f, -4.5f);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec3(8f, -6f, 1.5f);
                var v = ov.swizzle.ggbgr;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(8.5f, -7f, -8f);
                var v = ov.swizzle.ggbgg;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(-8.5f, -5f, 8f);
                var v = ov.swizzle.ggbgb;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(-1.5f, -6.5f, -5f);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec3(5.5f, -6f, 5.5f);
                var v = ov.swizzle.ggbbr;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, 8.5f, 7.5f);
                var v = ov.swizzle.ggbbg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-5.5f, 4f, 0f);
                var v = ov.swizzle.ggbbb;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(-4.5f, 1f, -0.5f);
                var v = ov.swizzle.gb;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-0.5f, v.y);
            }
            {
                var ov = new vec3(5.5f, -5f, 4.5f);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var ov = new vec3(-9.5f, -9.5f, 4.5f);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(5f, -8f, 5f);
                var v = ov.swizzle.gbrrr;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(0f, -5f, 1.5f);
                var v = ov.swizzle.gbrrg;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-7f, -7.5f, 2.5f);
                var v = ov.swizzle.gbrrb;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(-5.5f, 4f, -5.5f);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec3(-4.5f, 3f, 5.5f);
                var v = ov.swizzle.gbrgr;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(3f, 1.5f, -8f);
                var v = ov.swizzle.gbrgg;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(2f, 0.5f, -9f);
                var v = ov.swizzle.gbrgb;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(7f, -7f, -3f);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec3(-4.5f, -5.5f, -4f);
                var v = ov.swizzle.gbrbr;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(1f, 3f, 2f);
                var v = ov.swizzle.gbrbg;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(2f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(-6.5f, 1f, 4.5f);
                var v = ov.swizzle.gbrbb;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(-5f, -6.5f, 5f);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
            }
            {
                var ov = new vec3(9f, 5.5f, 1f);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec3(4f, -4f, -6f);
                var v = ov.swizzle.gbgrr;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(5f, 9.5f, 0f);
                var v = ov.swizzle.gbgrg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(-6f, 9.5f, 8.5f);
                var v = ov.swizzle.gbgrb;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, 1.5f, -6.5f);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(-7f, -7f, 0.5f);
                var v = ov.swizzle.gbggr;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(-6f, 8.5f, 0f);
                var v = ov.swizzle.gbggg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, -6f, 0.5f);
                var v = ov.swizzle.gbggb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(0.5f, v.v);
            }
            {
                var ov = new vec3(-8f, -6f, -9f);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec3(-0.5f, 1f, 3f);
                var v = ov.swizzle.gbgbr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(0.5f, 9f, -8.5f);
                var v = ov.swizzle.gbgbg;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec3(0.5f, 4.5f, 6.5f);
                var v = ov.swizzle.gbgbb;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(-6f, 8.5f, -7f);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
            }
            {
                var ov = new vec3(2f, 1f, -8f);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec3(-2f, 8f, -5.5f);
                var v = ov.swizzle.gbbrr;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(-5f, 7f, -2f);
                var v = ov.swizzle.gbbrg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(-9f, 5f, -5.5f);
                var v = ov.swizzle.gbbrb;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(4f, 9.5f, -5.5f);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec3(4f, -7f, -9.5f);
                var v = ov.swizzle.gbbgr;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(-1f, -2.5f, 7.5f);
                var v = ov.swizzle.gbbgg;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, -6f, 8.5f);
                var v = ov.swizzle.gbbgb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(6.5f, -3.5f, 0.5f);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(-8f, 3f, 6.5f);
                var v = ov.swizzle.gbbbr;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(-2.5f, 0f, -9f);
                var v = ov.swizzle.gbbbg;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var ov = new vec3(-3f, -3f, 6.5f);
                var v = ov.swizzle.gbbbb;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(-6.5f, -8.5f, 6f);
                var v = ov.swizzle.br;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-6.5f, v.y);
            }
            {
                var ov = new vec3(6f, 2f, 8f);
                var v = ov.swizzle.brr;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
            }
            {
                var ov = new vec3(6f, -1f, 5.5f);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec3(-9f, -3.5f, -1f);
                var v = ov.swizzle.brrrr;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(6.5f, -4.5f, -8f);
                var v = ov.swizzle.brrrg;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(-7f, 5f, -2f);
                var v = ov.swizzle.brrrb;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
                Assert.AreEqual(-2f, v.v);
            }
            {
                var ov = new vec3(-9f, 4f, -3.5f);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec3(-9f, -6f, -7.5f);
                var v = ov.swizzle.brrgr;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(3.5f, 6.5f, 3f);
                var v = ov.swizzle.brrgg;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(-6f, 1.5f, 5f);
                var v = ov.swizzle.brrgb;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(5f, 1.5f, -3.5f);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec3(-1.5f, -8.5f, 6.5f);
                var v = ov.swizzle.brrbr;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(-1.5f, v.v);
            }
            {
                var ov = new vec3(-3f, 3f, -5.5f);
                var v = ov.swizzle.brrbg;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(-0.5f, 0.5f, 4f);
                var v = ov.swizzle.brrbb;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(3f, -7f, 0f);
                var v = ov.swizzle.brg;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-7f, v.z);
            }
            {
                var ov = new vec3(-9.5f, -7.5f, -8f);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(-9f, -1f, 5.5f);
                var v = ov.swizzle.brgrr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(6f, 4.5f, 7f);
                var v = ov.swizzle.brgrg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(9f, 4f, 5f);
                var v = ov.swizzle.brgrb;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(-4.5f, -3f, 6f);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec3(4f, 1.5f, -9.5f);
                var v = ov.swizzle.brggr;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(0.5f, -4f, 4.5f);
                var v = ov.swizzle.brggg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(-5.5f, 7f, 3f);
                var v = ov.swizzle.brggb;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(3f, v.v);
            }
            {
                var ov = new vec3(-7.5f, 4f, 1f);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(-2.5f, -0.5f, -5f);
                var v = ov.swizzle.brgbr;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(-8.5f, -6f, 8.5f);
                var v = ov.swizzle.brgbg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(-6f, v.v);
            }
            {
                var ov = new vec3(-8.5f, -4f, -5f);
                var v = ov.swizzle.brgbb;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 6.5f, -8.5f);
                var v = ov.swizzle.brb;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec3(-1f, 8.5f, 6.5f);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec3(-9f, -8f, -7f);
                var v = ov.swizzle.brbrr;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-9f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(1.5f, -2.5f, 0.5f);
                var v = ov.swizzle.brbrg;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(-8f, -4.5f, 9.5f);
                var v = ov.swizzle.brbrb;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(-4.5f, -3f, 3f);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec3(5f, 5.5f, -4f);
                var v = ov.swizzle.brbgr;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(-4f, 7.5f, 6f);
                var v = ov.swizzle.brbgg;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(7.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, -9.5f, 4f);
                var v = ov.swizzle.brbgb;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(3.5f, -1.5f, -1.5f);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec3(7f, 3f, 9.5f);
                var v = ov.swizzle.brbbr;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(7f, v.v);
            }
            {
                var ov = new vec3(1.5f, -9f, 4.5f);
                var v = ov.swizzle.brbbg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(8.5f, -9.5f, -6f);
                var v = ov.swizzle.brbbb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-6f, v.v);
            }
            {
                var ov = new vec3(8.5f, 5f, -0.5f);
                var v = ov.swizzle.bg;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(5f, v.y);
            }
            {
                var ov = new vec3(-2.5f, 1.5f, -7f);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
            }
            {
                var ov = new vec3(-2f, 9f, 4f);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec3(-5f, 6.5f, 2f);
                var v = ov.swizzle.bgrrr;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(4.5f, -5f, -8f);
                var v = ov.swizzle.bgrrg;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(-5f, v.v);
            }
            {
                var ov = new vec3(0f, -2f, 9.5f);
                var v = ov.swizzle.bgrrb;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(-5f, -7f, -9f);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec3(1.5f, -4.5f, -0.5f);
                var v = ov.swizzle.bgrgr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(-0.5f, -5.5f, -5.5f);
                var v = ov.swizzle.bgrgg;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, -3.5f, 6f);
                var v = ov.swizzle.bgrgb;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(4f, -2.5f, 3.5f);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(-2.5f, 7f, 0.5f);
                var v = ov.swizzle.bgrbr;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(-5.5f, -2.5f, 5f);
                var v = ov.swizzle.bgrbg;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-2.5f, v.v);
            }
            {
                var ov = new vec3(-0.5f, -7.5f, 9f);
                var v = ov.swizzle.bgrbb;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec3(0f, -9f, 2.5f);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
            }
            {
                var ov = new vec3(-4.5f, -3f, -0.5f);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec3(-8.5f, 1.5f, 6f);
                var v = ov.swizzle.bggrr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(4.5f, -5.5f, 2f);
                var v = ov.swizzle.bggrg;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, 6f, -9.5f);
                var v = ov.swizzle.bggrb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(-9.5f, v.v);
            }
            {
                var ov = new vec3(0f, 7.5f, 7f);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(3.5f, -9.5f, -6.5f);
                var v = ov.swizzle.bgggr;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, 9f, 9f);
                var v = ov.swizzle.bgggg;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec3(9f, 7f, 6f);
                var v = ov.swizzle.bgggb;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
                Assert.AreEqual(6f, v.v);
            }
            {
                var ov = new vec3(-1.5f, -6f, -5.5f);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec3(4.5f, -4.5f, 5.5f);
                var v = ov.swizzle.bggbr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(8f, 0.5f, 6f);
                var v = ov.swizzle.bggbg;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(0.5f, v.v);
            }
            {
                var ov = new vec3(7.5f, 4f, -1f);
                var v = ov.swizzle.bggbb;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-1f, v.w);
                Assert.AreEqual(-1f, v.v);
            }
            {
                var ov = new vec3(5.5f, -1f, 5.5f);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var ov = new vec3(9.5f, 9f, 3f);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, 0.5f, 1f);
                var v = ov.swizzle.bgbrr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1.5f, v.w);
                Assert.AreEqual(1.5f, v.v);
            }
            {
                var ov = new vec3(9f, -5.5f, 0.5f);
                var v = ov.swizzle.bgbrg;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(9f, v.w);
                Assert.AreEqual(-5.5f, v.v);
            }
            {
                var ov = new vec3(8.5f, 6.5f, 1f);
                var v = ov.swizzle.bgbrb;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 3f, 8f);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec3(-6.5f, -6f, 5f);
                var v = ov.swizzle.bgbgr;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-6f, v.w);
                Assert.AreEqual(-6.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, 2.5f, -5f);
                var v = ov.swizzle.bgbgg;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(2.5f, v.w);
                Assert.AreEqual(2.5f, v.v);
            }
            {
                var ov = new vec3(-7.5f, 0f, 8.5f);
                var v = ov.swizzle.bgbgb;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(6f, -1.5f, -6f);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec3(-4f, 2f, 3.5f);
                var v = ov.swizzle.bgbbr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(6.5f, 8.5f, 8f);
                var v = ov.swizzle.bgbbg;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(-1.5f, 7.5f, 9.5f);
                var v = ov.swizzle.bgbbb;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
                Assert.AreEqual(9.5f, v.v);
            }
            {
                var ov = new vec3(5f, -8f, -7f);
                var v = ov.swizzle.bb;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
            }
            {
                var ov = new vec3(5f, -8f, 1.5f);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(5f, v.z);
            }
            {
                var ov = new vec3(4.5f, 5.5f, -1.5f);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec3(4.5f, -7.5f, -2.5f);
                var v = ov.swizzle.bbrrr;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(8.5f, -4f, -1.5f);
                var v = ov.swizzle.bbrrg;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(-4f, v.v);
            }
            {
                var ov = new vec3(5f, -3f, -9f);
                var v = ov.swizzle.bbrrb;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
            {
                var ov = new vec3(-9.5f, -7f, 9f);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec3(4f, -4.5f, 1f);
                var v = ov.swizzle.bbrgr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(-3.5f, 6.5f, -8.5f);
                var v = ov.swizzle.bbrgg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(6.5f, 1f, 8.5f);
                var v = ov.swizzle.bbrgb;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, 7.5f, 5f);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec3(8f, -7f, 7.5f);
                var v = ov.swizzle.bbrbr;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(7.5f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(-1.5f, -7f, -5f);
                var v = ov.swizzle.bbrbg;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-5f, v.w);
                Assert.AreEqual(-7f, v.v);
            }
            {
                var ov = new vec3(-5.5f, -2.5f, 5f);
                var v = ov.swizzle.bbrbb;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(5f, v.v);
            }
            {
                var ov = new vec3(9f, -3f, 6f);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-3f, v.z);
            }
            {
                var ov = new vec3(-1.5f, -5f, -0.5f);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec3(4f, 0.5f, -4.5f);
                var v = ov.swizzle.bbgrr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(4f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(0.5f, 8f, -8.5f);
                var v = ov.swizzle.bbgrg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(8f, v.v);
            }
            {
                var ov = new vec3(0.5f, 1f, 3.5f);
                var v = ov.swizzle.bbgrb;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(3.5f, v.v);
            }
            {
                var ov = new vec3(-6f, -9f, -8.5f);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec3(9f, 8.5f, 3.5f);
                var v = ov.swizzle.bbggr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(9f, v.v);
            }
            {
                var ov = new vec3(0.5f, 1f, -4.5f);
                var v = ov.swizzle.bbggg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1f, v.w);
                Assert.AreEqual(1f, v.v);
            }
            {
                var ov = new vec3(-7.5f, -0.5f, 6.5f);
                var v = ov.swizzle.bbggb;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
                Assert.AreEqual(6.5f, v.v);
            }
            {
                var ov = new vec3(1.5f, -8f, 6.5f);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec3(4f, 6.5f, 0.5f);
                var v = ov.swizzle.bbgbr;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
                Assert.AreEqual(4f, v.v);
            }
            {
                var ov = new vec3(3f, 4.5f, -2f);
                var v = ov.swizzle.bbgbg;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(-2f, v.w);
                Assert.AreEqual(4.5f, v.v);
            }
            {
                var ov = new vec3(5.5f, 7.5f, -8.5f);
                var v = ov.swizzle.bbgbb;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(2.5f, 2.5f, -2f);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
            }
            {
                var ov = new vec3(-4f, 2f, -1.5f);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec3(-4.5f, -8f, -6f);
                var v = ov.swizzle.bbbrr;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-4.5f, v.w);
                Assert.AreEqual(-4.5f, v.v);
            }
            {
                var ov = new vec3(3f, -3f, 7.5f);
                var v = ov.swizzle.bbbrg;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(3f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec3(3.5f, -4f, -0.5f);
                var v = ov.swizzle.bbbrb;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(-0.5f, v.v);
            }
            {
                var ov = new vec3(-2f, -9.5f, -2f);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(-7.5f, 6f, -3.5f);
                var v = ov.swizzle.bbbgr;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(6f, v.w);
                Assert.AreEqual(-7.5f, v.v);
            }
            {
                var ov = new vec3(3.5f, -3f, -3f);
                var v = ov.swizzle.bbbgg;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec3(-1.5f, -3.5f, -3f);
                var v = ov.swizzle.bbbgb;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3.5f, v.w);
                Assert.AreEqual(-3f, v.v);
            }
            {
                var ov = new vec3(0.5f, -3.5f, 6f);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec3(-8.5f, -9.5f, -7.5f);
                var v = ov.swizzle.bbbbr;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
                Assert.AreEqual(-8.5f, v.v);
            }
            {
                var ov = new vec3(0f, -8f, 5f);
                var v = ov.swizzle.bbbbg;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
                Assert.AreEqual(-8f, v.v);
            }
            {
                var ov = new vec3(-7.5f, -6f, 8.5f);
                var v = ov.swizzle.bbbbb;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new vec3(3.5f, 6f, -9f);
                var v1 = new vec2(9.5f, -8f);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9.5f, v0.x);
                Assert.AreEqual(-8f, v0.y);
                Assert.AreEqual(-9f, v0.z);
            
                Assert.AreEqual(3.5f, v2.x);
                Assert.AreEqual(6f, v2.y);
            }
            {
                var v0 = new vec3(0f, 5.5f, 7f);
                var v1 = new vec2(-8.5f, 8f);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8.5f, v0.x);
                Assert.AreEqual(5.5f, v0.y);
                Assert.AreEqual(8f, v0.z);
            
                Assert.AreEqual(0f, v2.x);
                Assert.AreEqual(7f, v2.y);
            }
            {
                var v0 = new vec3(3f, 9.5f, 3.5f);
                var v1 = new vec2(9f, 0.5f);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3f, v0.x);
                Assert.AreEqual(9f, v0.y);
                Assert.AreEqual(0.5f, v0.z);
            
                Assert.AreEqual(9.5f, v2.x);
                Assert.AreEqual(3.5f, v2.y);
            }
            {
                var v0 = new vec3(-0.5f, -8.5f, -1f);
                var v1 = new vec3(3f, 7f, 3f);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3f, v0.x);
                Assert.AreEqual(7f, v0.y);
                Assert.AreEqual(3f, v0.z);
            
                Assert.AreEqual(-0.5f, v2.x);
                Assert.AreEqual(-8.5f, v2.y);
                Assert.AreEqual(-1f, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new vec3(-2f, 0.5f, -4.5f);
                var v1 = 2f;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2f, v0.x);
                Assert.AreEqual(0.5f, v0.y);
                Assert.AreEqual(-4.5f, v0.z);
            
                Assert.AreEqual(-2f, v2);
            }
            {
                var v0 = new vec3(-7.5f, -1.5f, -0.5f);
                var v1 = 7f;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7.5f, v0.x);
                Assert.AreEqual(7f, v0.y);
                Assert.AreEqual(-0.5f, v0.z);
            
                Assert.AreEqual(-1.5f, v2);
            }
            {
                var v0 = new vec3(-8f, -7f, -7.5f);
                var v1 = new vec2(-5f, 6.5f);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5f, v0.x);
                Assert.AreEqual(6.5f, v0.y);
                Assert.AreEqual(-7.5f, v0.z);
            
                Assert.AreEqual(-8f, v2.x);
                Assert.AreEqual(-7f, v2.y);
            }
            {
                var v0 = new vec3(6.5f, -3.5f, -9f);
                var v1 = -2f;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6.5f, v0.x);
                Assert.AreEqual(-3.5f, v0.y);
                Assert.AreEqual(-2f, v0.z);
            
                Assert.AreEqual(-9f, v2);
            }
            {
                var v0 = new vec3(-7.5f, 8.5f, -6f);
                var v1 = new vec2(7.5f, 0.5f);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7.5f, v0.x);
                Assert.AreEqual(8.5f, v0.y);
                Assert.AreEqual(0.5f, v0.z);
            
                Assert.AreEqual(-7.5f, v2.x);
                Assert.AreEqual(-6f, v2.y);
            }
            {
                var v0 = new vec3(-0.5f, -9f, 7f);
                var v1 = new vec2(-1.5f, 7.5f);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-0.5f, v0.x);
                Assert.AreEqual(-1.5f, v0.y);
                Assert.AreEqual(7.5f, v0.z);
            
                Assert.AreEqual(-9f, v2.x);
                Assert.AreEqual(7f, v2.y);
            }
            {
                var v0 = new vec3(-6.5f, 5f, -7.5f);
                var v1 = new vec3(-9f, -9f, 0f);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-9f, v0.x);
                Assert.AreEqual(-9f, v0.y);
                Assert.AreEqual(0f, v0.z);
            
                Assert.AreEqual(-6.5f, v2.x);
                Assert.AreEqual(5f, v2.y);
                Assert.AreEqual(-7.5f, v2.z);
            }
        }

    }
}
