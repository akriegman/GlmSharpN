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
    public class TSwizzleVec3Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new gvec3<string>("((-9-5)-7)", "", "(-9-6)");
                var v = ov.swizzle.xx;
                Assert.AreEqual("((-9-5)-7)", v.x);
                Assert.AreEqual("((-9-5)-7)", v.y);
            }
            {
                var ov = new gvec3<string>("5", "(-55)", null);
                var v = ov.swizzle.xxx;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
            }
            {
                var ov = new gvec3<string>("((6-7)8)", "(21)", null);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual("((6-7)8)", v.x);
                Assert.AreEqual("((6-7)8)", v.y);
                Assert.AreEqual("((6-7)8)", v.z);
                Assert.AreEqual("((6-7)8)", v.w);
            }
            {
                var ov = new gvec3<string>("9", "(5-5)", "(5-5)");
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("((-11)-9)", "((-34)0)", "");
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual("((-11)-9)", v.x);
                Assert.AreEqual("((-11)-9)", v.y);
                Assert.AreEqual("((-11)-9)", v.z);
                Assert.AreEqual("((-11)-9)", v.w);
                Assert.AreEqual("((-34)0)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((-1-9)3)", "-6");
                var v = ov.swizzle.xxxxz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("((8-6)9)", "(48)", "((-1-5)1)");
                var v = ov.swizzle.xxxy;
                Assert.AreEqual("((8-6)9)", v.x);
                Assert.AreEqual("((8-6)9)", v.y);
                Assert.AreEqual("((8-6)9)", v.z);
                Assert.AreEqual("(48)", v.w);
            }
            {
                var ov = new gvec3<string>("(02)", null, "((-5-6)7)");
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual("(02)", v.x);
                Assert.AreEqual("(02)", v.y);
                Assert.AreEqual("(02)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(02)", v.v);
            }
            {
                var ov = new gvec3<string>("((3-1)-3)", "-2", null);
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual("((3-1)-3)", v.x);
                Assert.AreEqual("((3-1)-3)", v.y);
                Assert.AreEqual("((3-1)-3)", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("((80)5)", "0", "((-56)4)");
                var v = ov.swizzle.xxxyz;
                Assert.AreEqual("((80)5)", v.x);
                Assert.AreEqual("((80)5)", v.y);
                Assert.AreEqual("((80)5)", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("((-56)4)", v.v);
            }
            {
                var ov = new gvec3<string>("-6", "(35)", null);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("(-39)", "4", "0");
                var v = ov.swizzle.xxxzx;
                Assert.AreEqual("(-39)", v.x);
                Assert.AreEqual("(-39)", v.y);
                Assert.AreEqual("(-39)", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("(-39)", v.v);
            }
            {
                var ov = new gvec3<string>("((64)-7)", "", "(84)");
                var v = ov.swizzle.xxxzy;
                Assert.AreEqual("((64)-7)", v.x);
                Assert.AreEqual("((64)-7)", v.y);
                Assert.AreEqual("((64)-7)", v.z);
                Assert.AreEqual("(84)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((-4-3)9)", "(-3-5)", "");
                var v = ov.swizzle.xxxzz;
                Assert.AreEqual("((-4-3)9)", v.x);
                Assert.AreEqual("((-4-3)9)", v.y);
                Assert.AreEqual("((-4-3)9)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((8-1)2)", "", "4");
                var v = ov.swizzle.xxy;
                Assert.AreEqual("((8-1)2)", v.x);
                Assert.AreEqual("((8-1)2)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("((25)-2)", "((25)-2)", "8");
                var v = ov.swizzle.xxyx;
                Assert.AreEqual("((25)-2)", v.x);
                Assert.AreEqual("((25)-2)", v.y);
                Assert.AreEqual("((25)-2)", v.z);
                Assert.AreEqual("((25)-2)", v.w);
            }
            {
                var ov = new gvec3<string>("5", "-4", "6");
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("5", v.w);
                Assert.AreEqual("5", v.v);
            }
            {
                var ov = new gvec3<string>("6", "9", "(10)");
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("((-92)-3)", "-9", "((-92)-3)");
                var v = ov.swizzle.xxyxz;
                Assert.AreEqual("((-92)-3)", v.x);
                Assert.AreEqual("((-92)-3)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("((-92)-3)", v.w);
                Assert.AreEqual("((-92)-3)", v.v);
            }
            {
                var ov = new gvec3<string>("(0-8)", "((-14)-4)", "(8-3)");
                var v = ov.swizzle.xxyy;
                Assert.AreEqual("(0-8)", v.x);
                Assert.AreEqual("(0-8)", v.y);
                Assert.AreEqual("((-14)-4)", v.z);
                Assert.AreEqual("((-14)-4)", v.w);
            }
            {
                var ov = new gvec3<string>("((-4-2)-7)", "((82)7)", "(0-9)");
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual("((-4-2)-7)", v.x);
                Assert.AreEqual("((-4-2)-7)", v.y);
                Assert.AreEqual("((82)7)", v.z);
                Assert.AreEqual("((82)7)", v.w);
                Assert.AreEqual("((-4-2)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("(-55)", "(-55)", "6");
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual("(-55)", v.x);
                Assert.AreEqual("(-55)", v.y);
                Assert.AreEqual("(-55)", v.z);
                Assert.AreEqual("(-55)", v.w);
                Assert.AreEqual("(-55)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(02)", "(07)");
                var v = ov.swizzle.xxyyz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(02)", v.z);
                Assert.AreEqual("(02)", v.w);
                Assert.AreEqual("(07)", v.v);
            }
            {
                var ov = new gvec3<string>("((-30)2)", "-7", "(3-5)");
                var v = ov.swizzle.xxyz;
                Assert.AreEqual("((-30)2)", v.x);
                Assert.AreEqual("((-30)2)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("(3-5)", v.w);
            }
            {
                var ov = new gvec3<string>("(-42)", "(-47)", "(-47)");
                var v = ov.swizzle.xxyzx;
                Assert.AreEqual("(-42)", v.x);
                Assert.AreEqual("(-42)", v.y);
                Assert.AreEqual("(-47)", v.z);
                Assert.AreEqual("(-47)", v.w);
                Assert.AreEqual("(-42)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((-2-6)5)", "7");
                var v = ov.swizzle.xxyzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-2-6)5)", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("((-2-6)5)", v.v);
            }
            {
                var ov = new gvec3<string>("0", null, "0");
                var v = ov.swizzle.xxyzz;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>(null, "1", "");
                var v = ov.swizzle.xxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("1", "1", "(-71)");
                var v = ov.swizzle.xxzx;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("(-71)", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec3<string>(null, null, "2");
                var v = ov.swizzle.xxzxx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("", "", null);
                var v = ov.swizzle.xxzxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>(null, "1", "(-3-2)");
                var v = ov.swizzle.xxzxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-3-2)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-3-2)", v.v);
            }
            {
                var ov = new gvec3<string>("((8-8)4)", "(7-5)", "(-81)");
                var v = ov.swizzle.xxzy;
                Assert.AreEqual("((8-8)4)", v.x);
                Assert.AreEqual("((8-8)4)", v.y);
                Assert.AreEqual("(-81)", v.z);
                Assert.AreEqual("(7-5)", v.w);
            }
            {
                var ov = new gvec3<string>("3", null, "((52)6)");
                var v = ov.swizzle.xxzyx;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("((52)6)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("3", v.v);
            }
            {
                var ov = new gvec3<string>("8", "(-4-3)", "(-6-8)");
                var v = ov.swizzle.xxzyy;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("(-6-8)", v.z);
                Assert.AreEqual("(-4-3)", v.w);
                Assert.AreEqual("(-4-3)", v.v);
            }
            {
                var ov = new gvec3<string>("4", null, "(5-5)");
                var v = ov.swizzle.xxzyz;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("(5-5)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(5-5)", v.v);
            }
            {
                var ov = new gvec3<string>("(-3-9)", "-7", "((3-1)-6)");
                var v = ov.swizzle.xxzz;
                Assert.AreEqual("(-3-9)", v.x);
                Assert.AreEqual("(-3-9)", v.y);
                Assert.AreEqual("((3-1)-6)", v.z);
                Assert.AreEqual("((3-1)-6)", v.w);
            }
            {
                var ov = new gvec3<string>("((-30)2)", "9", "");
                var v = ov.swizzle.xxzzx;
                Assert.AreEqual("((-30)2)", v.x);
                Assert.AreEqual("((-30)2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((-30)2)", v.v);
            }
            {
                var ov = new gvec3<string>("((-6-3)5)", "-6", null);
                var v = ov.swizzle.xxzzy;
                Assert.AreEqual("((-6-3)5)", v.x);
                Assert.AreEqual("((-6-3)5)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("((-24)-1)", "(8-7)", null);
                var v = ov.swizzle.xxzzz;
                Assert.AreEqual("((-24)-1)", v.x);
                Assert.AreEqual("((-24)-1)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((0-3)-1)", "((-7-3)-3)", "((0-3)-1)");
                var v = ov.swizzle.xy;
                Assert.AreEqual("((0-3)-1)", v.x);
                Assert.AreEqual("((-7-3)-3)", v.y);
            }
            {
                var ov = new gvec3<string>("-4", "((-4-1)2)", "");
                var v = ov.swizzle.xyx;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("((-4-1)2)", v.y);
                Assert.AreEqual("-4", v.z);
            }
            {
                var ov = new gvec3<string>("((-84)-7)", null, "((05)4)");
                var v = ov.swizzle.xyxx;
                Assert.AreEqual("((-84)-7)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-84)-7)", v.z);
                Assert.AreEqual("((-84)-7)", v.w);
            }
            {
                var ov = new gvec3<string>("(-4-3)", null, "((-2-7)3)");
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual("(-4-3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-4-3)", v.z);
                Assert.AreEqual("(-4-3)", v.w);
                Assert.AreEqual("(-4-3)", v.v);
            }
            {
                var ov = new gvec3<string>("(-20)", "7", "7");
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual("(-20)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("(-20)", v.z);
                Assert.AreEqual("(-20)", v.w);
                Assert.AreEqual("7", v.v);
            }
            {
                var ov = new gvec3<string>("3", "-1", "0");
                var v = ov.swizzle.xyxxz;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("3", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("((5-3)-7)", "(1-5)", "(0-8)");
                var v = ov.swizzle.xyxy;
                Assert.AreEqual("((5-3)-7)", v.x);
                Assert.AreEqual("(1-5)", v.y);
                Assert.AreEqual("((5-3)-7)", v.z);
                Assert.AreEqual("(1-5)", v.w);
            }
            {
                var ov = new gvec3<string>("((-34)-3)", null, null);
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual("((-34)-3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-34)-3)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((-34)-3)", v.v);
            }
            {
                var ov = new gvec3<string>("-6", null, null);
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((21)3)", "(-33)", "(36)");
                var v = ov.swizzle.xyxyz;
                Assert.AreEqual("((21)3)", v.x);
                Assert.AreEqual("(-33)", v.y);
                Assert.AreEqual("((21)3)", v.z);
                Assert.AreEqual("(-33)", v.w);
                Assert.AreEqual("(36)", v.v);
            }
            {
                var ov = new gvec3<string>("(-9-5)", "((86)8)", "((2-9)7)");
                var v = ov.swizzle.xyxz;
                Assert.AreEqual("(-9-5)", v.x);
                Assert.AreEqual("((86)8)", v.y);
                Assert.AreEqual("(-9-5)", v.z);
                Assert.AreEqual("((2-9)7)", v.w);
            }
            {
                var ov = new gvec3<string>("-5", "((-9-1)-3)", "-5");
                var v = ov.swizzle.xyxzx;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("((-9-1)-3)", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("-5", v.w);
                Assert.AreEqual("-5", v.v);
            }
            {
                var ov = new gvec3<string>("5", "((-69)-6)", "-7");
                var v = ov.swizzle.xyxzy;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("((-69)-6)", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("-7", v.w);
                Assert.AreEqual("((-69)-6)", v.v);
            }
            {
                var ov = new gvec3<string>("(-15)", "-5", "((-4-3)-7)");
                var v = ov.swizzle.xyxzz;
                Assert.AreEqual("(-15)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(-15)", v.z);
                Assert.AreEqual("((-4-3)-7)", v.w);
                Assert.AreEqual("((-4-3)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("(-1-6)", "((-8-8)7)", "(-1-6)");
                var v = ov.swizzle.xyy;
                Assert.AreEqual("(-1-6)", v.x);
                Assert.AreEqual("((-8-8)7)", v.y);
                Assert.AreEqual("((-8-8)7)", v.z);
            }
            {
                var ov = new gvec3<string>("-4", "((54)-3)", "-2");
                var v = ov.swizzle.xyyx;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("((54)-3)", v.y);
                Assert.AreEqual("((54)-3)", v.z);
                Assert.AreEqual("-4", v.w);
            }
            {
                var ov = new gvec3<string>("8", "8", "(-7-6)");
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("8", v.w);
                Assert.AreEqual("8", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(-9-5)", "6");
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-9-5)", v.y);
                Assert.AreEqual("(-9-5)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-9-5)", v.v);
            }
            {
                var ov = new gvec3<string>("((51)7)", "3", "0");
                var v = ov.swizzle.xyyxz;
                Assert.AreEqual("((51)7)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("((51)7)", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("3", "-7", "((67)2)");
                var v = ov.swizzle.xyyy;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec3<string>("(-7-2)", "(-24)", "-9");
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual("(-7-2)", v.x);
                Assert.AreEqual("(-24)", v.y);
                Assert.AreEqual("(-24)", v.z);
                Assert.AreEqual("(-24)", v.w);
                Assert.AreEqual("(-7-2)", v.v);
            }
            {
                var ov = new gvec3<string>("((28)5)", "(-2-1)", null);
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual("((28)5)", v.x);
                Assert.AreEqual("(-2-1)", v.y);
                Assert.AreEqual("(-2-1)", v.z);
                Assert.AreEqual("(-2-1)", v.w);
                Assert.AreEqual("(-2-1)", v.v);
            }
            {
                var ov = new gvec3<string>("((-1-3)3)", "4", "(3-9)");
                var v = ov.swizzle.xyyyz;
                Assert.AreEqual("((-1-3)3)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("(3-9)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(-6-9)", "0");
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-6-9)", v.y);
                Assert.AreEqual("(-6-9)", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec3<string>("(-1-6)", "(-77)", "((1-9)-7)");
                var v = ov.swizzle.xyyzx;
                Assert.AreEqual("(-1-6)", v.x);
                Assert.AreEqual("(-77)", v.y);
                Assert.AreEqual("(-77)", v.z);
                Assert.AreEqual("((1-9)-7)", v.w);
                Assert.AreEqual("(-1-6)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((22)-2)", null);
                var v = ov.swizzle.xyyzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((22)-2)", v.y);
                Assert.AreEqual("((22)-2)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((22)-2)", v.v);
            }
            {
                var ov = new gvec3<string>("((1-3)-1)", "(27)", "9");
                var v = ov.swizzle.xyyzz;
                Assert.AreEqual("((1-3)-1)", v.x);
                Assert.AreEqual("(27)", v.y);
                Assert.AreEqual("(27)", v.z);
                Assert.AreEqual("9", v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("", null, "2");
                var v = ov.swizzle.xyz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("2", v.z);
            }
            {
                var ov = new gvec3<string>("((-8-2)3)", "((-8-2)3)", "4");
                var v = ov.swizzle.xyzx;
                Assert.AreEqual("((-8-2)3)", v.x);
                Assert.AreEqual("((-8-2)3)", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("((-8-2)3)", v.w);
            }
            {
                var ov = new gvec3<string>("(-48)", "8", "-2");
                var v = ov.swizzle.xyzxx;
                Assert.AreEqual("(-48)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("(-48)", v.w);
                Assert.AreEqual("(-48)", v.v);
            }
            {
                var ov = new gvec3<string>("((-68)3)", "((-68)3)", "7");
                var v = ov.swizzle.xyzxy;
                Assert.AreEqual("((-68)3)", v.x);
                Assert.AreEqual("((-68)3)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("((-68)3)", v.w);
                Assert.AreEqual("((-68)3)", v.v);
            }
            {
                var ov = new gvec3<string>("((40)4)", "6", null);
                var v = ov.swizzle.xyzxz;
                Assert.AreEqual("((40)4)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((40)4)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("", "((5-8)-6)", "");
                var v = ov.swizzle.xyzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((5-8)-6)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((5-8)-6)", v.w);
            }
            {
                var ov = new gvec3<string>("9", null, "5");
                var v = ov.swizzle.xyzyx;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("-5", "(9-8)", "-8");
                var v = ov.swizzle.xyzyy;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("(9-8)", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("(9-8)", v.w);
                Assert.AreEqual("(9-8)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((7-1)-3)", "((7-1)-3)");
                var v = ov.swizzle.xyzyz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((7-1)-3)", v.y);
                Assert.AreEqual("((7-1)-3)", v.z);
                Assert.AreEqual("((7-1)-3)", v.w);
                Assert.AreEqual("((7-1)-3)", v.v);
            }
            {
                var ov = new gvec3<string>("", null, "(-14)");
                var v = ov.swizzle.xyzz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-14)", v.z);
                Assert.AreEqual("(-14)", v.w);
            }
            {
                var ov = new gvec3<string>("1", "-8", "(1-9)");
                var v = ov.swizzle.xyzzx;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("(1-9)", v.z);
                Assert.AreEqual("(1-9)", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>("", "(-59)", "(-26)");
                var v = ov.swizzle.xyzzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-59)", v.y);
                Assert.AreEqual("(-26)", v.z);
                Assert.AreEqual("(-26)", v.w);
                Assert.AreEqual("(-59)", v.v);
            }
            {
                var ov = new gvec3<string>("((-96)-1)", null, "(3-1)");
                var v = ov.swizzle.xyzzz;
                Assert.AreEqual("((-96)-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(3-1)", v.z);
                Assert.AreEqual("(3-1)", v.w);
                Assert.AreEqual("(3-1)", v.v);
            }
            {
                var ov = new gvec3<string>("((-89)3)", "-5", "(-4-8)");
                var v = ov.swizzle.xz;
                Assert.AreEqual("((-89)3)", v.x);
                Assert.AreEqual("(-4-8)", v.y);
            }
            {
                var ov = new gvec3<string>("((2-8)-1)", null, "(3-2)");
                var v = ov.swizzle.xzx;
                Assert.AreEqual("((2-8)-1)", v.x);
                Assert.AreEqual("(3-2)", v.y);
                Assert.AreEqual("((2-8)-1)", v.z);
            }
            {
                var ov = new gvec3<string>("((68)5)", "(-13)", null);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual("((68)5)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((68)5)", v.z);
                Assert.AreEqual("((68)5)", v.w);
            }
            {
                var ov = new gvec3<string>("((-5-2)-4)", "((-5-2)-4)", "");
                var v = ov.swizzle.xzxxx;
                Assert.AreEqual("((-5-2)-4)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-5-2)-4)", v.z);
                Assert.AreEqual("((-5-2)-4)", v.w);
                Assert.AreEqual("((-5-2)-4)", v.v);
            }
            {
                var ov = new gvec3<string>("((6-4)7)", "-3", "((6-4)7)");
                var v = ov.swizzle.xzxxy;
                Assert.AreEqual("((6-4)7)", v.x);
                Assert.AreEqual("((6-4)7)", v.y);
                Assert.AreEqual("((6-4)7)", v.z);
                Assert.AreEqual("((6-4)7)", v.w);
                Assert.AreEqual("-3", v.v);
            }
            {
                var ov = new gvec3<string>("7", "(0-2)", "(-31)");
                var v = ov.swizzle.xzxxz;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("(-31)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("(-31)", v.v);
            }
            {
                var ov = new gvec3<string>("((60)-2)", "(8-7)", "((89)0)");
                var v = ov.swizzle.xzxy;
                Assert.AreEqual("((60)-2)", v.x);
                Assert.AreEqual("((89)0)", v.y);
                Assert.AreEqual("((60)-2)", v.z);
                Assert.AreEqual("(8-7)", v.w);
            }
            {
                var ov = new gvec3<string>("((-93)-8)", "(62)", "(62)");
                var v = ov.swizzle.xzxyx;
                Assert.AreEqual("((-93)-8)", v.x);
                Assert.AreEqual("(62)", v.y);
                Assert.AreEqual("((-93)-8)", v.z);
                Assert.AreEqual("(62)", v.w);
                Assert.AreEqual("((-93)-8)", v.v);
            }
            {
                var ov = new gvec3<string>("", "(4-3)", "((2-7)-2)");
                var v = ov.swizzle.xzxyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((2-7)-2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(4-3)", v.w);
                Assert.AreEqual("(4-3)", v.v);
            }
            {
                var ov = new gvec3<string>("((-1-6)8)", "", null);
                var v = ov.swizzle.xzxyz;
                Assert.AreEqual("((-1-6)8)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-1-6)8)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(-92)", "-2", "(-77)");
                var v = ov.swizzle.xzxz;
                Assert.AreEqual("(-92)", v.x);
                Assert.AreEqual("(-77)", v.y);
                Assert.AreEqual("(-92)", v.z);
                Assert.AreEqual("(-77)", v.w);
            }
            {
                var ov = new gvec3<string>("(84)", "((-3-3)-6)", "(61)");
                var v = ov.swizzle.xzxzx;
                Assert.AreEqual("(84)", v.x);
                Assert.AreEqual("(61)", v.y);
                Assert.AreEqual("(84)", v.z);
                Assert.AreEqual("(61)", v.w);
                Assert.AreEqual("(84)", v.v);
            }
            {
                var ov = new gvec3<string>("((-7-5)2)", "((84)-7)", "-9");
                var v = ov.swizzle.xzxzy;
                Assert.AreEqual("((-7-5)2)", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("((-7-5)2)", v.z);
                Assert.AreEqual("-9", v.w);
                Assert.AreEqual("((84)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("(32)", null, "(2-3)");
                var v = ov.swizzle.xzxzz;
                Assert.AreEqual("(32)", v.x);
                Assert.AreEqual("(2-3)", v.y);
                Assert.AreEqual("(32)", v.z);
                Assert.AreEqual("(2-3)", v.w);
                Assert.AreEqual("(2-3)", v.v);
            }
            {
                var ov = new gvec3<string>("(51)", "(-2-1)", null);
                var v = ov.swizzle.xzy;
                Assert.AreEqual("(51)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-2-1)", v.z);
            }
            {
                var ov = new gvec3<string>("((-27)7)", "", "((-1-4)5)");
                var v = ov.swizzle.xzyx;
                Assert.AreEqual("((-27)7)", v.x);
                Assert.AreEqual("((-1-4)5)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-27)7)", v.w);
            }
            {
                var ov = new gvec3<string>("((5-9)4)", "", "((-45)2)");
                var v = ov.swizzle.xzyxx;
                Assert.AreEqual("((5-9)4)", v.x);
                Assert.AreEqual("((-45)2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((5-9)4)", v.w);
                Assert.AreEqual("((5-9)4)", v.v);
            }
            {
                var ov = new gvec3<string>("(93)", "5", null);
                var v = ov.swizzle.xzyxy;
                Assert.AreEqual("(93)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("(93)", v.w);
                Assert.AreEqual("5", v.v);
            }
            {
                var ov = new gvec3<string>("-9", "((1-7)2)", "((5-4)-9)");
                var v = ov.swizzle.xzyxz;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((5-4)-9)", v.y);
                Assert.AreEqual("((1-7)2)", v.z);
                Assert.AreEqual("-9", v.w);
                Assert.AreEqual("((5-4)-9)", v.v);
            }
            {
                var ov = new gvec3<string>("((-92)9)", "((-3-7)7)", "(6-7)");
                var v = ov.swizzle.xzyy;
                Assert.AreEqual("((-92)9)", v.x);
                Assert.AreEqual("(6-7)", v.y);
                Assert.AreEqual("((-3-7)7)", v.z);
                Assert.AreEqual("((-3-7)7)", v.w);
            }
            {
                var ov = new gvec3<string>("(93)", "(93)", "(93)");
                var v = ov.swizzle.xzyyx;
                Assert.AreEqual("(93)", v.x);
                Assert.AreEqual("(93)", v.y);
                Assert.AreEqual("(93)", v.z);
                Assert.AreEqual("(93)", v.w);
                Assert.AreEqual("(93)", v.v);
            }
            {
                var ov = new gvec3<string>("-7", "(-87)", null);
                var v = ov.swizzle.xzyyy;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-87)", v.z);
                Assert.AreEqual("(-87)", v.w);
                Assert.AreEqual("(-87)", v.v);
            }
            {
                var ov = new gvec3<string>("((52)-4)", "9", "((52)-4)");
                var v = ov.swizzle.xzyyz;
                Assert.AreEqual("((52)-4)", v.x);
                Assert.AreEqual("((52)-4)", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
                Assert.AreEqual("((52)-4)", v.v);
            }
            {
                var ov = new gvec3<string>("((89)-4)", "-8", "(-4-8)");
                var v = ov.swizzle.xzyz;
                Assert.AreEqual("((89)-4)", v.x);
                Assert.AreEqual("(-4-8)", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("(-4-8)", v.w);
            }
            {
                var ov = new gvec3<string>("-7", "(-8-5)", "(-2-2)");
                var v = ov.swizzle.xzyzx;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(-2-2)", v.y);
                Assert.AreEqual("(-8-5)", v.z);
                Assert.AreEqual("(-2-2)", v.w);
                Assert.AreEqual("-7", v.v);
            }
            {
                var ov = new gvec3<string>("((85)-2)", "((85)-2)", "");
                var v = ov.swizzle.xzyzy;
                Assert.AreEqual("((85)-2)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((85)-2)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((85)-2)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "", "((07)-8)");
                var v = ov.swizzle.xzyzz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((07)-8)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((07)-8)", v.w);
                Assert.AreEqual("((07)-8)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((-2-6)1)", "-9");
                var v = ov.swizzle.xzz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-9", v.z);
            }
            {
                var ov = new gvec3<string>("-1", "", "(8-7)");
                var v = ov.swizzle.xzzx;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("(8-7)", v.y);
                Assert.AreEqual("(8-7)", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec3<string>("((48)-9)", "-4", "(76)");
                var v = ov.swizzle.xzzxx;
                Assert.AreEqual("((48)-9)", v.x);
                Assert.AreEqual("(76)", v.y);
                Assert.AreEqual("(76)", v.z);
                Assert.AreEqual("((48)-9)", v.w);
                Assert.AreEqual("((48)-9)", v.v);
            }
            {
                var ov = new gvec3<string>("-7", "(-7-3)", "((-5-7)-6)");
                var v = ov.swizzle.xzzxy;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((-5-7)-6)", v.y);
                Assert.AreEqual("((-5-7)-6)", v.z);
                Assert.AreEqual("-7", v.w);
                Assert.AreEqual("(-7-3)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "9", "(-4-5)");
                var v = ov.swizzle.xzzxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-4-5)", v.y);
                Assert.AreEqual("(-4-5)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-4-5)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((0-8)2)", "(61)");
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(61)", v.y);
                Assert.AreEqual("(61)", v.z);
                Assert.AreEqual("((0-8)2)", v.w);
            }
            {
                var ov = new gvec3<string>("((-97)0)", "((-97)0)", "(-86)");
                var v = ov.swizzle.xzzyx;
                Assert.AreEqual("((-97)0)", v.x);
                Assert.AreEqual("(-86)", v.y);
                Assert.AreEqual("(-86)", v.z);
                Assert.AreEqual("((-97)0)", v.w);
                Assert.AreEqual("((-97)0)", v.v);
            }
            {
                var ov = new gvec3<string>("-4", "((96)-1)", "0");
                var v = ov.swizzle.xzzyy;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("((96)-1)", v.w);
                Assert.AreEqual("((96)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("5", "(51)", "(-66)");
                var v = ov.swizzle.xzzyz;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("(-66)", v.y);
                Assert.AreEqual("(-66)", v.z);
                Assert.AreEqual("(51)", v.w);
                Assert.AreEqual("(-66)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((66)-7)", "-6");
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec3<string>("(5-9)", "((56)1)", "((2-9)-6)");
                var v = ov.swizzle.xzzzx;
                Assert.AreEqual("(5-9)", v.x);
                Assert.AreEqual("((2-9)-6)", v.y);
                Assert.AreEqual("((2-9)-6)", v.z);
                Assert.AreEqual("((2-9)-6)", v.w);
                Assert.AreEqual("(5-9)", v.v);
            }
            {
                var ov = new gvec3<string>("2", "((-18)2)", "(-4-3)");
                var v = ov.swizzle.xzzzy;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("(-4-3)", v.y);
                Assert.AreEqual("(-4-3)", v.z);
                Assert.AreEqual("(-4-3)", v.w);
                Assert.AreEqual("((-18)2)", v.v);
            }
            {
                var ov = new gvec3<string>("((07)0)", "((4-8)-6)", "0");
                var v = ov.swizzle.xzzzz;
                Assert.AreEqual("((07)0)", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("(0-6)", "((-4-5)9)", "(0-6)");
                var v = ov.swizzle.yx;
                Assert.AreEqual("((-4-5)9)", v.x);
                Assert.AreEqual("(0-6)", v.y);
            }
            {
                var ov = new gvec3<string>("(90)", "((8-1)3)", "((8-1)3)");
                var v = ov.swizzle.yxx;
                Assert.AreEqual("((8-1)3)", v.x);
                Assert.AreEqual("(90)", v.y);
                Assert.AreEqual("(90)", v.z);
            }
            {
                var ov = new gvec3<string>("((8-2)-3)", "(22)", "-8");
                var v = ov.swizzle.yxxx;
                Assert.AreEqual("(22)", v.x);
                Assert.AreEqual("((8-2)-3)", v.y);
                Assert.AreEqual("((8-2)-3)", v.z);
                Assert.AreEqual("((8-2)-3)", v.w);
            }
            {
                var ov = new gvec3<string>("-1", "7", "((8-5)-1)");
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("7", "(-9-8)", "7");
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual("(-9-8)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("(-9-8)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "", "(-5-5)");
                var v = ov.swizzle.yxxxz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-5-5)", v.v);
            }
            {
                var ov = new gvec3<string>("9", null, "((6-5)-7)");
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("((-62)6)", "((-3-3)7)", "((-45)2)");
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual("((-3-3)7)", v.x);
                Assert.AreEqual("((-62)6)", v.y);
                Assert.AreEqual("((-62)6)", v.z);
                Assert.AreEqual("((-3-3)7)", v.w);
                Assert.AreEqual("((-62)6)", v.v);
            }
            {
                var ov = new gvec3<string>("((6-2)-8)", "", "-6");
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((6-2)-8)", v.y);
                Assert.AreEqual("((6-2)-8)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(67)", "((91)8)", null);
                var v = ov.swizzle.yxxyz;
                Assert.AreEqual("((91)8)", v.x);
                Assert.AreEqual("(67)", v.y);
                Assert.AreEqual("(67)", v.z);
                Assert.AreEqual("((91)8)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(91)", "5", "((80)-1)");
                var v = ov.swizzle.yxxz;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("(91)", v.y);
                Assert.AreEqual("(91)", v.z);
                Assert.AreEqual("((80)-1)", v.w);
            }
            {
                var ov = new gvec3<string>("3", "(-92)", null);
                var v = ov.swizzle.yxxzx;
                Assert.AreEqual("(-92)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("3", v.v);
            }
            {
                var ov = new gvec3<string>("((-65)-7)", "7", "(26)");
                var v = ov.swizzle.yxxzy;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("((-65)-7)", v.y);
                Assert.AreEqual("((-65)-7)", v.z);
                Assert.AreEqual("(26)", v.w);
                Assert.AreEqual("7", v.v);
            }
            {
                var ov = new gvec3<string>("(7-8)", "(7-8)", "((90)-7)");
                var v = ov.swizzle.yxxzz;
                Assert.AreEqual("(7-8)", v.x);
                Assert.AreEqual("(7-8)", v.y);
                Assert.AreEqual("(7-8)", v.z);
                Assert.AreEqual("((90)-7)", v.w);
                Assert.AreEqual("((90)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("((-1-6)9)", "((9-9)5)", "((87)-1)");
                var v = ov.swizzle.yxy;
                Assert.AreEqual("((9-9)5)", v.x);
                Assert.AreEqual("((-1-6)9)", v.y);
                Assert.AreEqual("((9-9)5)", v.z);
            }
            {
                var ov = new gvec3<string>("((-64)4)", "((-64)4)", "4");
                var v = ov.swizzle.yxyx;
                Assert.AreEqual("((-64)4)", v.x);
                Assert.AreEqual("((-64)4)", v.y);
                Assert.AreEqual("((-64)4)", v.z);
                Assert.AreEqual("((-64)4)", v.w);
            }
            {
                var ov = new gvec3<string>("((3-8)7)", "0", "(7-3)");
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("((3-8)7)", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("((3-8)7)", v.w);
                Assert.AreEqual("((3-8)7)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((5-9)-1)", "((5-9)-1)");
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual("((5-9)-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((5-9)-1)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((5-9)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("((73)-2)", "((1-7)-4)", "2");
                var v = ov.swizzle.yxyxz;
                Assert.AreEqual("((1-7)-4)", v.x);
                Assert.AreEqual("((73)-2)", v.y);
                Assert.AreEqual("((1-7)-4)", v.z);
                Assert.AreEqual("((73)-2)", v.w);
                Assert.AreEqual("2", v.v);
            }
            {
                var ov = new gvec3<string>(null, "-8", null);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec3<string>("((-2-4)0)", "((6-2)-3)", "8");
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual("((6-2)-3)", v.x);
                Assert.AreEqual("((-2-4)0)", v.y);
                Assert.AreEqual("((6-2)-3)", v.z);
                Assert.AreEqual("((6-2)-3)", v.w);
                Assert.AreEqual("((-2-4)0)", v.v);
            }
            {
                var ov = new gvec3<string>("", "(-4-4)", "((80)4)");
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual("(-4-4)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-4-4)", v.z);
                Assert.AreEqual("(-4-4)", v.w);
                Assert.AreEqual("(-4-4)", v.v);
            }
            {
                var ov = new gvec3<string>("", "4", "((-33)7)");
                var v = ov.swizzle.yxyyz;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("((-33)7)", v.v);
            }
            {
                var ov = new gvec3<string>("4", "((-8-9)-8)", "((-6-5)1)");
                var v = ov.swizzle.yxyz;
                Assert.AreEqual("((-8-9)-8)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("((-8-9)-8)", v.z);
                Assert.AreEqual("((-6-5)1)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((3-7)9)", "((44)7)");
                var v = ov.swizzle.yxyzx;
                Assert.AreEqual("((3-7)9)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((3-7)9)", v.z);
                Assert.AreEqual("((44)7)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("0", "", null);
                var v = ov.swizzle.yxyzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((-1-3)4)", "", null);
                var v = ov.swizzle.yxyzz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-1-3)4)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((-4-1)-8)", "-7", "((-4-5)-3)");
                var v = ov.swizzle.yxz;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((-4-1)-8)", v.y);
                Assert.AreEqual("((-4-5)-3)", v.z);
            }
            {
                var ov = new gvec3<string>("-5", "((-71)-9)", "(6-6)");
                var v = ov.swizzle.yxzx;
                Assert.AreEqual("((-71)-9)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(6-6)", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec3<string>("-1", "(-12)", "-1");
                var v = ov.swizzle.yxzxx;
                Assert.AreEqual("(-12)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("7", "6", "7");
                var v = ov.swizzle.yxzxy;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec3<string>("((9-2)-5)", "", "");
                var v = ov.swizzle.yxzxz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((9-2)-5)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((9-2)-5)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("9", "((-5-3)-2)", "7");
                var v = ov.swizzle.yxzy;
                Assert.AreEqual("((-5-3)-2)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("((-5-3)-2)", v.w);
            }
            {
                var ov = new gvec3<string>("(-3-4)", "", "((-8-5)1)");
                var v = ov.swizzle.yxzyx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-3-4)", v.y);
                Assert.AreEqual("((-8-5)1)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("(-3-4)", v.v);
            }
            {
                var ov = new gvec3<string>("(71)", "(2-7)", "(71)");
                var v = ov.swizzle.yxzyy;
                Assert.AreEqual("(2-7)", v.x);
                Assert.AreEqual("(71)", v.y);
                Assert.AreEqual("(71)", v.z);
                Assert.AreEqual("(2-7)", v.w);
                Assert.AreEqual("(2-7)", v.v);
            }
            {
                var ov = new gvec3<string>("-2", "-2", "6");
                var v = ov.swizzle.yxzyz;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec3<string>("(-17)", "((6-9)-7)", "(7-2)");
                var v = ov.swizzle.yxzz;
                Assert.AreEqual("((6-9)-7)", v.x);
                Assert.AreEqual("(-17)", v.y);
                Assert.AreEqual("(7-2)", v.z);
                Assert.AreEqual("(7-2)", v.w);
            }
            {
                var ov = new gvec3<string>("6", "(-59)", "(-59)");
                var v = ov.swizzle.yxzzx;
                Assert.AreEqual("(-59)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("(-59)", v.z);
                Assert.AreEqual("(-59)", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec3<string>("((1-5)1)", "-8", "6");
                var v = ov.swizzle.yxzzy;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("((1-5)1)", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("-8", v.v);
            }
            {
                var ov = new gvec3<string>("((-6-5)-6)", "-8", null);
                var v = ov.swizzle.yxzzz;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("((-6-5)-6)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("0", "(92)", null);
                var v = ov.swizzle.yy;
                Assert.AreEqual("(92)", v.x);
                Assert.AreEqual("(92)", v.y);
            }
            {
                var ov = new gvec3<string>("5", "", "((-18)-3)");
                var v = ov.swizzle.yyx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("5", v.z);
            }
            {
                var ov = new gvec3<string>("((02)-7)", "((7-9)4)", "-8");
                var v = ov.swizzle.yyxx;
                Assert.AreEqual("((7-9)4)", v.x);
                Assert.AreEqual("((7-9)4)", v.y);
                Assert.AreEqual("((02)-7)", v.z);
                Assert.AreEqual("((02)-7)", v.w);
            }
            {
                var ov = new gvec3<string>("((-75)-7)", "(-6-6)", null);
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual("(-6-6)", v.x);
                Assert.AreEqual("(-6-6)", v.y);
                Assert.AreEqual("((-75)-7)", v.z);
                Assert.AreEqual("((-75)-7)", v.w);
                Assert.AreEqual("((-75)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("((65)3)", "(1-7)", "(-1-3)");
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual("(1-7)", v.x);
                Assert.AreEqual("(1-7)", v.y);
                Assert.AreEqual("((65)3)", v.z);
                Assert.AreEqual("((65)3)", v.w);
                Assert.AreEqual("(1-7)", v.v);
            }
            {
                var ov = new gvec3<string>("((94)-7)", "-4", "(9-3)");
                var v = ov.swizzle.yyxxz;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("((94)-7)", v.z);
                Assert.AreEqual("((94)-7)", v.w);
                Assert.AreEqual("(9-3)", v.v);
            }
            {
                var ov = new gvec3<string>("(1-3)", "4", "4");
                var v = ov.swizzle.yyxy;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("(1-3)", v.z);
                Assert.AreEqual("4", v.w);
            }
            {
                var ov = new gvec3<string>("(-70)", "(-70)", "(-8-3)");
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual("(-70)", v.x);
                Assert.AreEqual("(-70)", v.y);
                Assert.AreEqual("(-70)", v.z);
                Assert.AreEqual("(-70)", v.w);
                Assert.AreEqual("(-70)", v.v);
            }
            {
                var ov = new gvec3<string>("((-28)4)", "", "(-33)");
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-28)4)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(26)", "9");
                var v = ov.swizzle.yyxyz;
                Assert.AreEqual("(26)", v.x);
                Assert.AreEqual("(26)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(26)", v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("((-18)4)", "((-18)4)", "");
                var v = ov.swizzle.yyxz;
                Assert.AreEqual("((-18)4)", v.x);
                Assert.AreEqual("((-18)4)", v.y);
                Assert.AreEqual("((-18)4)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(-5-1)", "1", "(-5-1)");
                var v = ov.swizzle.yyxzx;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("(-5-1)", v.z);
                Assert.AreEqual("(-5-1)", v.w);
                Assert.AreEqual("(-5-1)", v.v);
            }
            {
                var ov = new gvec3<string>("(-92)", "(0-6)", "(-38)");
                var v = ov.swizzle.yyxzy;
                Assert.AreEqual("(0-6)", v.x);
                Assert.AreEqual("(0-6)", v.y);
                Assert.AreEqual("(-92)", v.z);
                Assert.AreEqual("(-38)", v.w);
                Assert.AreEqual("(0-6)", v.v);
            }
            {
                var ov = new gvec3<string>("((-28)7)", "(4-7)", "");
                var v = ov.swizzle.yyxzz;
                Assert.AreEqual("(4-7)", v.x);
                Assert.AreEqual("(4-7)", v.y);
                Assert.AreEqual("((-28)7)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("", "(08)", "2");
                var v = ov.swizzle.yyy;
                Assert.AreEqual("(08)", v.x);
                Assert.AreEqual("(08)", v.y);
                Assert.AreEqual("(08)", v.z);
            }
            {
                var ov = new gvec3<string>("(2-7)", "-6", "(2-7)");
                var v = ov.swizzle.yyyx;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("(2-7)", v.w);
            }
            {
                var ov = new gvec3<string>("", "-6", "((-60)-5)");
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((-1-5)1)", "(18)", "((5-3)-1)");
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual("(18)", v.x);
                Assert.AreEqual("(18)", v.y);
                Assert.AreEqual("(18)", v.z);
                Assert.AreEqual("((-1-5)1)", v.w);
                Assert.AreEqual("(18)", v.v);
            }
            {
                var ov = new gvec3<string>("-9", null, null);
                var v = ov.swizzle.yyyxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-9", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(16)", "", "((49)3)");
                var v = ov.swizzle.yyyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((11)-4)", null, "(4-2)");
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((11)-4)", v.v);
            }
            {
                var ov = new gvec3<string>("(-35)", "6", "1");
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec3<string>("((3-9)2)", "", "(-35)");
                var v = ov.swizzle.yyyyz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("(-35)", v.v);
            }
            {
                var ov = new gvec3<string>("(2-5)", "(8-1)", "6");
                var v = ov.swizzle.yyyz;
                Assert.AreEqual("(8-1)", v.x);
                Assert.AreEqual("(8-1)", v.y);
                Assert.AreEqual("(8-1)", v.z);
                Assert.AreEqual("6", v.w);
            }
            {
                var ov = new gvec3<string>("9", "((-68)0)", "(09)");
                var v = ov.swizzle.yyyzx;
                Assert.AreEqual("((-68)0)", v.x);
                Assert.AreEqual("((-68)0)", v.y);
                Assert.AreEqual("((-68)0)", v.z);
                Assert.AreEqual("(09)", v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("(-20)", "(-6-8)", null);
                var v = ov.swizzle.yyyzy;
                Assert.AreEqual("(-6-8)", v.x);
                Assert.AreEqual("(-6-8)", v.y);
                Assert.AreEqual("(-6-8)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-6-8)", v.v);
            }
            {
                var ov = new gvec3<string>("((-66)-9)", "(-1-3)", "((-37)1)");
                var v = ov.swizzle.yyyzz;
                Assert.AreEqual("(-1-3)", v.x);
                Assert.AreEqual("(-1-3)", v.y);
                Assert.AreEqual("(-1-3)", v.z);
                Assert.AreEqual("((-37)1)", v.w);
                Assert.AreEqual("((-37)1)", v.v);
            }
            {
                var ov = new gvec3<string>("9", "(59)", null);
                var v = ov.swizzle.yyz;
                Assert.AreEqual("(59)", v.x);
                Assert.AreEqual("(59)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("", "(-43)", "((4-7)-4)");
                var v = ov.swizzle.yyzx;
                Assert.AreEqual("(-43)", v.x);
                Assert.AreEqual("(-43)", v.y);
                Assert.AreEqual("((4-7)-4)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((-59)-4)", "(9-3)", "((-59)-4)");
                var v = ov.swizzle.yyzxx;
                Assert.AreEqual("(9-3)", v.x);
                Assert.AreEqual("(9-3)", v.y);
                Assert.AreEqual("((-59)-4)", v.z);
                Assert.AreEqual("((-59)-4)", v.w);
                Assert.AreEqual("((-59)-4)", v.v);
            }
            {
                var ov = new gvec3<string>("(56)", "8", "6");
                var v = ov.swizzle.yyzxy;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("(56)", v.w);
                Assert.AreEqual("8", v.v);
            }
            {
                var ov = new gvec3<string>("", "(86)", "((-94)-1)");
                var v = ov.swizzle.yyzxz;
                Assert.AreEqual("(86)", v.x);
                Assert.AreEqual("(86)", v.y);
                Assert.AreEqual("((-94)-1)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((-94)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("((87)-3)", "", "3");
                var v = ov.swizzle.yyzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(4-3)", "((-95)5)", "(4-3)");
                var v = ov.swizzle.yyzyx;
                Assert.AreEqual("((-95)5)", v.x);
                Assert.AreEqual("((-95)5)", v.y);
                Assert.AreEqual("(4-3)", v.z);
                Assert.AreEqual("((-95)5)", v.w);
                Assert.AreEqual("(4-3)", v.v);
            }
            {
                var ov = new gvec3<string>(null, null, "(-7-4)");
                var v = ov.swizzle.yyzyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-7-4)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((7-4)-5)", "(-8-5)", "(27)");
                var v = ov.swizzle.yyzyz;
                Assert.AreEqual("(-8-5)", v.x);
                Assert.AreEqual("(-8-5)", v.y);
                Assert.AreEqual("(27)", v.z);
                Assert.AreEqual("(-8-5)", v.w);
                Assert.AreEqual("(27)", v.v);
            }
            {
                var ov = new gvec3<string>("", "(-7-8)", "(-7-8)");
                var v = ov.swizzle.yyzz;
                Assert.AreEqual("(-7-8)", v.x);
                Assert.AreEqual("(-7-8)", v.y);
                Assert.AreEqual("(-7-8)", v.z);
                Assert.AreEqual("(-7-8)", v.w);
            }
            {
                var ov = new gvec3<string>("5", "", "(-79)");
                var v = ov.swizzle.yyzzx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-79)", v.z);
                Assert.AreEqual("(-79)", v.w);
                Assert.AreEqual("5", v.v);
            }
            {
                var ov = new gvec3<string>("(-1-6)", "8", "(-1-6)");
                var v = ov.swizzle.yyzzy;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("(-1-6)", v.z);
                Assert.AreEqual("(-1-6)", v.w);
                Assert.AreEqual("8", v.v);
            }
            {
                var ov = new gvec3<string>("-4", "(-85)", "-4");
                var v = ov.swizzle.yyzzz;
                Assert.AreEqual("(-85)", v.x);
                Assert.AreEqual("(-85)", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("-4", v.v);
            }
            {
                var ov = new gvec3<string>("(-59)", "8", "(48)");
                var v = ov.swizzle.yz;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("(48)", v.y);
            }
            {
                var ov = new gvec3<string>(null, "(24)", "-8");
                var v = ov.swizzle.yzx;
                Assert.AreEqual("(24)", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>(null, "(-27)", "");
                var v = ov.swizzle.yzxx;
                Assert.AreEqual("(-27)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("((5-4)3)", "(8-8)", "(76)");
                var v = ov.swizzle.yzxxx;
                Assert.AreEqual("(8-8)", v.x);
                Assert.AreEqual("(76)", v.y);
                Assert.AreEqual("((5-4)3)", v.z);
                Assert.AreEqual("((5-4)3)", v.w);
                Assert.AreEqual("((5-4)3)", v.v);
            }
            {
                var ov = new gvec3<string>("2", null, "((-2-6)-3)");
                var v = ov.swizzle.yzxxy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-2-6)-3)", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("2", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(-87)", "((82)4)", "4");
                var v = ov.swizzle.yzxxz;
                Assert.AreEqual("((82)4)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("(-87)", v.z);
                Assert.AreEqual("(-87)", v.w);
                Assert.AreEqual("4", v.v);
            }
            {
                var ov = new gvec3<string>("-7", "", "(84)");
                var v = ov.swizzle.yzxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(84)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("-6", "-6", "-6");
                var v = ov.swizzle.yzxyx;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("", "-7", "((-5-7)-2)");
                var v = ov.swizzle.yzxyy;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((-5-7)-2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-7", v.w);
                Assert.AreEqual("-7", v.v);
            }
            {
                var ov = new gvec3<string>("((93)-8)", "7", "(-41)");
                var v = ov.swizzle.yzxyz;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("(-41)", v.y);
                Assert.AreEqual("((93)-8)", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("(-41)", v.v);
            }
            {
                var ov = new gvec3<string>("((-6-4)2)", "2", "(0-5)");
                var v = ov.swizzle.yzxz;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("(0-5)", v.y);
                Assert.AreEqual("((-6-4)2)", v.z);
                Assert.AreEqual("(0-5)", v.w);
            }
            {
                var ov = new gvec3<string>("(-76)", "2", "2");
                var v = ov.swizzle.yzxzx;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("(-76)", v.z);
                Assert.AreEqual("2", v.w);
                Assert.AreEqual("(-76)", v.v);
            }
            {
                var ov = new gvec3<string>("(-40)", "0", "");
                var v = ov.swizzle.yzxzy;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-40)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("(5-4)", "(20)", "");
                var v = ov.swizzle.yzxzz;
                Assert.AreEqual("(20)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(5-4)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("", "(17)", "(23)");
                var v = ov.swizzle.yzy;
                Assert.AreEqual("(17)", v.x);
                Assert.AreEqual("(23)", v.y);
                Assert.AreEqual("(17)", v.z);
            }
            {
                var ov = new gvec3<string>("((8-3)8)", "(31)", null);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual("(31)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(31)", v.z);
                Assert.AreEqual("((8-3)8)", v.w);
            }
            {
                var ov = new gvec3<string>("((-73)-9)", "((-73)-9)", "((-53)-4)");
                var v = ov.swizzle.yzyxx;
                Assert.AreEqual("((-73)-9)", v.x);
                Assert.AreEqual("((-53)-4)", v.y);
                Assert.AreEqual("((-73)-9)", v.z);
                Assert.AreEqual("((-73)-9)", v.w);
                Assert.AreEqual("((-73)-9)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "5", "");
                var v = ov.swizzle.yzyxy;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("5", v.v);
            }
            {
                var ov = new gvec3<string>("(-28)", "9", "(-6-7)");
                var v = ov.swizzle.yzyxz;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("(-6-7)", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("(-28)", v.w);
                Assert.AreEqual("(-6-7)", v.v);
            }
            {
                var ov = new gvec3<string>("((79)-3)", "-1", "(10)");
                var v = ov.swizzle.yzyy;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("(10)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec3<string>("(5-5)", "(8-3)", "-9");
                var v = ov.swizzle.yzyyx;
                Assert.AreEqual("(8-3)", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("(8-3)", v.z);
                Assert.AreEqual("(8-3)", v.w);
                Assert.AreEqual("(5-5)", v.v);
            }
            {
                var ov = new gvec3<string>("5", "((-59)-5)", "(-84)");
                var v = ov.swizzle.yzyyy;
                Assert.AreEqual("((-59)-5)", v.x);
                Assert.AreEqual("(-84)", v.y);
                Assert.AreEqual("((-59)-5)", v.z);
                Assert.AreEqual("((-59)-5)", v.w);
                Assert.AreEqual("((-59)-5)", v.v);
            }
            {
                var ov = new gvec3<string>("(76)", "((52)4)", "-2");
                var v = ov.swizzle.yzyyz;
                Assert.AreEqual("((52)4)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("((52)4)", v.z);
                Assert.AreEqual("((52)4)", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("((5-5)0)", "((-26)-2)", "((5-5)0)");
                var v = ov.swizzle.yzyz;
                Assert.AreEqual("((-26)-2)", v.x);
                Assert.AreEqual("((5-5)0)", v.y);
                Assert.AreEqual("((-26)-2)", v.z);
                Assert.AreEqual("((5-5)0)", v.w);
            }
            {
                var ov = new gvec3<string>("(-5-9)", "((54)5)", "-2");
                var v = ov.swizzle.yzyzx;
                Assert.AreEqual("((54)5)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("((54)5)", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("(-5-9)", v.v);
            }
            {
                var ov = new gvec3<string>("((8-7)-9)", "(-4-6)", "((-3-7)8)");
                var v = ov.swizzle.yzyzy;
                Assert.AreEqual("(-4-6)", v.x);
                Assert.AreEqual("((-3-7)8)", v.y);
                Assert.AreEqual("(-4-6)", v.z);
                Assert.AreEqual("((-3-7)8)", v.w);
                Assert.AreEqual("(-4-6)", v.v);
            }
            {
                var ov = new gvec3<string>("(-2-3)", "(-2-3)", "6");
                var v = ov.swizzle.yzyzz;
                Assert.AreEqual("(-2-3)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("(-2-3)", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec3<string>("1", "", null);
                var v = ov.swizzle.yzz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("((-50)-8)", "((0-5)8)", "7");
                var v = ov.swizzle.yzzx;
                Assert.AreEqual("((0-5)8)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("((-50)-8)", v.w);
            }
            {
                var ov = new gvec3<string>("(-26)", "4", "((-95)-5)");
                var v = ov.swizzle.yzzxx;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("((-95)-5)", v.y);
                Assert.AreEqual("((-95)-5)", v.z);
                Assert.AreEqual("(-26)", v.w);
                Assert.AreEqual("(-26)", v.v);
            }
            {
                var ov = new gvec3<string>("4", "", null);
                var v = ov.swizzle.yzzxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(-2-3)", "((-8-2)-9)");
                var v = ov.swizzle.yzzxz;
                Assert.AreEqual("(-2-3)", v.x);
                Assert.AreEqual("((-8-2)-9)", v.y);
                Assert.AreEqual("((-8-2)-9)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((-8-2)-9)", v.v);
            }
            {
                var ov = new gvec3<string>("((-54)-6)", "((-54)-6)", "4");
                var v = ov.swizzle.yzzy;
                Assert.AreEqual("((-54)-6)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("((-54)-6)", v.w);
            }
            {
                var ov = new gvec3<string>("9", "9", "(54)");
                var v = ov.swizzle.yzzyx;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("(54)", v.y);
                Assert.AreEqual("(54)", v.z);
                Assert.AreEqual("9", v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("((-8-9)9)", "-9", "-4");
                var v = ov.swizzle.yzzyy;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-9", v.w);
                Assert.AreEqual("-9", v.v);
            }
            {
                var ov = new gvec3<string>("(-8-6)", "", "((-46)6)");
                var v = ov.swizzle.yzzyz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-46)6)", v.y);
                Assert.AreEqual("((-46)6)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((-46)6)", v.v);
            }
            {
                var ov = new gvec3<string>("9", "0", "(0-7)");
                var v = ov.swizzle.yzzz;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("(0-7)", v.y);
                Assert.AreEqual("(0-7)", v.z);
                Assert.AreEqual("(0-7)", v.w);
            }
            {
                var ov = new gvec3<string>("(8-3)", "-6", "-6");
                var v = ov.swizzle.yzzzx;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("(8-3)", v.v);
            }
            {
                var ov = new gvec3<string>("((-65)-1)", "(-9-7)", "(48)");
                var v = ov.swizzle.yzzzy;
                Assert.AreEqual("(-9-7)", v.x);
                Assert.AreEqual("(48)", v.y);
                Assert.AreEqual("(48)", v.z);
                Assert.AreEqual("(48)", v.w);
                Assert.AreEqual("(-9-7)", v.v);
            }
            {
                var ov = new gvec3<string>("(19)", "((-8-6)0)", "-6");
                var v = ov.swizzle.yzzzz;
                Assert.AreEqual("((-8-6)0)", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("((-5-9)0)", "", "((-5-9)0)");
                var v = ov.swizzle.zx;
                Assert.AreEqual("((-5-9)0)", v.x);
                Assert.AreEqual("((-5-9)0)", v.y);
            }
            {
                var ov = new gvec3<string>(null, null, "6");
                var v = ov.swizzle.zxx;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("(83)", "(-10)", "(83)");
                var v = ov.swizzle.zxxx;
                Assert.AreEqual("(83)", v.x);
                Assert.AreEqual("(83)", v.y);
                Assert.AreEqual("(83)", v.z);
                Assert.AreEqual("(83)", v.w);
            }
            {
                var ov = new gvec3<string>("((-2-2)6)", "(-5-5)", "(-71)");
                var v = ov.swizzle.zxxxx;
                Assert.AreEqual("(-71)", v.x);
                Assert.AreEqual("((-2-2)6)", v.y);
                Assert.AreEqual("((-2-2)6)", v.z);
                Assert.AreEqual("((-2-2)6)", v.w);
                Assert.AreEqual("((-2-2)6)", v.v);
            }
            {
                var ov = new gvec3<string>("4", null, "(03)");
                var v = ov.swizzle.zxxxy;
                Assert.AreEqual("(03)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(-52)", "(-1-4)", "1");
                var v = ov.swizzle.zxxxz;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("(-52)", v.y);
                Assert.AreEqual("(-52)", v.z);
                Assert.AreEqual("(-52)", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>(null, "9", "((2-3)-1)");
                var v = ov.swizzle.zxxy;
                Assert.AreEqual("((2-3)-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec3<string>("", "4", "6");
                var v = ov.swizzle.zxxyx;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((-2-5)9)", "((2-2)-3)", null);
                var v = ov.swizzle.zxxyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-2-5)9)", v.y);
                Assert.AreEqual("((-2-5)9)", v.z);
                Assert.AreEqual("((2-2)-3)", v.w);
                Assert.AreEqual("((2-2)-3)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(7-3)", "(-24)");
                var v = ov.swizzle.zxxyz;
                Assert.AreEqual("(-24)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(7-3)", v.w);
                Assert.AreEqual("(-24)", v.v);
            }
            {
                var ov = new gvec3<string>("(6-1)", "-4", "((5-1)-8)");
                var v = ov.swizzle.zxxz;
                Assert.AreEqual("((5-1)-8)", v.x);
                Assert.AreEqual("(6-1)", v.y);
                Assert.AreEqual("(6-1)", v.z);
                Assert.AreEqual("((5-1)-8)", v.w);
            }
            {
                var ov = new gvec3<string>("(3-3)", "(-6-6)", "((-1-2)-6)");
                var v = ov.swizzle.zxxzx;
                Assert.AreEqual("((-1-2)-6)", v.x);
                Assert.AreEqual("(3-3)", v.y);
                Assert.AreEqual("(3-3)", v.z);
                Assert.AreEqual("((-1-2)-6)", v.w);
                Assert.AreEqual("(3-3)", v.v);
            }
            {
                var ov = new gvec3<string>("(2-2)", "-6", "-8");
                var v = ov.swizzle.zxxzy;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("(2-2)", v.y);
                Assert.AreEqual("(2-2)", v.z);
                Assert.AreEqual("-8", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("(7-7)", "-8", "");
                var v = ov.swizzle.zxxzz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(7-7)", v.y);
                Assert.AreEqual("(7-7)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(-58)", null, "((86)-1)");
                var v = ov.swizzle.zxy;
                Assert.AreEqual("((86)-1)", v.x);
                Assert.AreEqual("(-58)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("(-10)", "(95)", "(-10)");
                var v = ov.swizzle.zxyx;
                Assert.AreEqual("(-10)", v.x);
                Assert.AreEqual("(-10)", v.y);
                Assert.AreEqual("(95)", v.z);
                Assert.AreEqual("(-10)", v.w);
            }
            {
                var ov = new gvec3<string>("-8", "(-1-9)", "7");
                var v = ov.swizzle.zxyxx;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("(-1-9)", v.z);
                Assert.AreEqual("-8", v.w);
                Assert.AreEqual("-8", v.v);
            }
            {
                var ov = new gvec3<string>("8", null, "((-34)7)");
                var v = ov.swizzle.zxyxy;
                Assert.AreEqual("((-34)7)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("8", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>(null, "((-41)-5)", "1");
                var v = ov.swizzle.zxyxz;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-41)-5)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>("(61)", "-2", null);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(61)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec3<string>("(8-6)", "", "-4");
                var v = ov.swizzle.zxyyx;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("(8-6)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("(8-6)", v.v);
            }
            {
                var ov = new gvec3<string>("3", "", "");
                var v = ov.swizzle.zxyyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("3", "-4", "((2-1)-8)");
                var v = ov.swizzle.zxyyz;
                Assert.AreEqual("((2-1)-8)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("((2-1)-8)", v.v);
            }
            {
                var ov = new gvec3<string>("((32)0)", "(40)", "5");
                var v = ov.swizzle.zxyz;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("((32)0)", v.y);
                Assert.AreEqual("(40)", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec3<string>("-5", "((-81)1)", "(-7-5)");
                var v = ov.swizzle.zxyzx;
                Assert.AreEqual("(-7-5)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("((-81)1)", v.z);
                Assert.AreEqual("(-7-5)", v.w);
                Assert.AreEqual("-5", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((5-1)9)", "((5-1)9)");
                var v = ov.swizzle.zxyzy;
                Assert.AreEqual("((5-1)9)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((5-1)9)", v.z);
                Assert.AreEqual("((5-1)9)", v.w);
                Assert.AreEqual("((5-1)9)", v.v);
            }
            {
                var ov = new gvec3<string>("8", "(6-1)", "-2");
                var v = ov.swizzle.zxyzz;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("(6-1)", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("((-4-5)-9)", "-6", "8");
                var v = ov.swizzle.zxz;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("((-4-5)-9)", v.y);
                Assert.AreEqual("8", v.z);
            }
            {
                var ov = new gvec3<string>("9", "(0-1)", "((7-7)2)");
                var v = ov.swizzle.zxzx;
                Assert.AreEqual("((7-7)2)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("((7-7)2)", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec3<string>("((-8-6)6)", "((-82)-2)", "((-8-6)6)");
                var v = ov.swizzle.zxzxx;
                Assert.AreEqual("((-8-6)6)", v.x);
                Assert.AreEqual("((-8-6)6)", v.y);
                Assert.AreEqual("((-8-6)6)", v.z);
                Assert.AreEqual("((-8-6)6)", v.w);
                Assert.AreEqual("((-8-6)6)", v.v);
            }
            {
                var ov = new gvec3<string>("(-64)", "((7-6)0)", "(-64)");
                var v = ov.swizzle.zxzxy;
                Assert.AreEqual("(-64)", v.x);
                Assert.AreEqual("(-64)", v.y);
                Assert.AreEqual("(-64)", v.z);
                Assert.AreEqual("(-64)", v.w);
                Assert.AreEqual("((7-6)0)", v.v);
            }
            {
                var ov = new gvec3<string>("(6-3)", "(-8-9)", "0");
                var v = ov.swizzle.zxzxz;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("(6-3)", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("(6-3)", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("-1", "", "(8-7)");
                var v = ov.swizzle.zxzy;
                Assert.AreEqual("(8-7)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("(8-7)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>(null, "-6", "(-7-8)");
                var v = ov.swizzle.zxzyx;
                Assert.AreEqual("(-7-8)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-7-8)", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(74)", "((06)-5)", "(1-1)");
                var v = ov.swizzle.zxzyy;
                Assert.AreEqual("(1-1)", v.x);
                Assert.AreEqual("(74)", v.y);
                Assert.AreEqual("(1-1)", v.z);
                Assert.AreEqual("((06)-5)", v.w);
                Assert.AreEqual("((06)-5)", v.v);
            }
            {
                var ov = new gvec3<string>("((-3-1)-3)", "-2", "((-74)-2)");
                var v = ov.swizzle.zxzyz;
                Assert.AreEqual("((-74)-2)", v.x);
                Assert.AreEqual("((-3-1)-3)", v.y);
                Assert.AreEqual("((-74)-2)", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("((-74)-2)", v.v);
            }
            {
                var ov = new gvec3<string>("(-77)", "7", "(-77)");
                var v = ov.swizzle.zxzz;
                Assert.AreEqual("(-77)", v.x);
                Assert.AreEqual("(-77)", v.y);
                Assert.AreEqual("(-77)", v.z);
                Assert.AreEqual("(-77)", v.w);
            }
            {
                var ov = new gvec3<string>("(-39)", "(22)", "-8");
                var v = ov.swizzle.zxzzx;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("(-39)", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("-8", v.w);
                Assert.AreEqual("(-39)", v.v);
            }
            {
                var ov = new gvec3<string>("(9-4)", "((5-2)3)", "");
                var v = ov.swizzle.zxzzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(9-4)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((5-2)3)", v.v);
            }
            {
                var ov = new gvec3<string>("((-74)0)", "(-1-7)", "1");
                var v = ov.swizzle.zxzzz;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("((-74)0)", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("1", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>("((1-7)-9)", "((1-7)-9)", "((-9-5)3)");
                var v = ov.swizzle.zy;
                Assert.AreEqual("((-9-5)3)", v.x);
                Assert.AreEqual("((1-7)-9)", v.y);
            }
            {
                var ov = new gvec3<string>("(73)", "6", "((69)7)");
                var v = ov.swizzle.zyx;
                Assert.AreEqual("((69)7)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("(73)", v.z);
            }
            {
                var ov = new gvec3<string>("", "", "-3");
                var v = ov.swizzle.zyxx;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(-4-1)", "((-6-2)5)", null);
                var v = ov.swizzle.zyxxx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-6-2)5)", v.y);
                Assert.AreEqual("(-4-1)", v.z);
                Assert.AreEqual("(-4-1)", v.w);
                Assert.AreEqual("(-4-1)", v.v);
            }
            {
                var ov = new gvec3<string>("(91)", "(2-1)", "");
                var v = ov.swizzle.zyxxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(2-1)", v.y);
                Assert.AreEqual("(91)", v.z);
                Assert.AreEqual("(91)", v.w);
                Assert.AreEqual("(2-1)", v.v);
            }
            {
                var ov = new gvec3<string>("(74)", "((5-3)-9)", "(74)");
                var v = ov.swizzle.zyxxz;
                Assert.AreEqual("(74)", v.x);
                Assert.AreEqual("((5-3)-9)", v.y);
                Assert.AreEqual("(74)", v.z);
                Assert.AreEqual("(74)", v.w);
                Assert.AreEqual("(74)", v.v);
            }
            {
                var ov = new gvec3<string>("", "(89)", "((-34)-3)");
                var v = ov.swizzle.zyxy;
                Assert.AreEqual("((-34)-3)", v.x);
                Assert.AreEqual("(89)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(89)", v.w);
            }
            {
                var ov = new gvec3<string>("(-9-6)", "(7-6)", "-6");
                var v = ov.swizzle.zyxyx;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("(7-6)", v.y);
                Assert.AreEqual("(-9-6)", v.z);
                Assert.AreEqual("(7-6)", v.w);
                Assert.AreEqual("(-9-6)", v.v);
            }
            {
                var ov = new gvec3<string>("(2-7)", "((74)2)", "2");
                var v = ov.swizzle.zyxyy;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("((74)2)", v.y);
                Assert.AreEqual("(2-7)", v.z);
                Assert.AreEqual("((74)2)", v.w);
                Assert.AreEqual("((74)2)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((-8-2)3)", "(-2-6)");
                var v = ov.swizzle.zyxyz;
                Assert.AreEqual("(-2-6)", v.x);
                Assert.AreEqual("((-8-2)3)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-8-2)3)", v.w);
                Assert.AreEqual("(-2-6)", v.v);
            }
            {
                var ov = new gvec3<string>("4", "((-7-5)1)", "9");
                var v = ov.swizzle.zyxz;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("((-7-5)1)", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec3<string>("((66)-9)", "((-44)-5)", null);
                var v = ov.swizzle.zyxzx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-44)-5)", v.y);
                Assert.AreEqual("((66)-9)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((66)-9)", v.v);
            }
            {
                var ov = new gvec3<string>("(1-6)", "(8-7)", "(7-6)");
                var v = ov.swizzle.zyxzy;
                Assert.AreEqual("(7-6)", v.x);
                Assert.AreEqual("(8-7)", v.y);
                Assert.AreEqual("(1-6)", v.z);
                Assert.AreEqual("(7-6)", v.w);
                Assert.AreEqual("(8-7)", v.v);
            }
            {
                var ov = new gvec3<string>("8", "8", "((-7-6)5)");
                var v = ov.swizzle.zyxzz;
                Assert.AreEqual("((-7-6)5)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("((-7-6)5)", v.w);
                Assert.AreEqual("((-7-6)5)", v.v);
            }
            {
                var ov = new gvec3<string>("(-26)", "(9-2)", "((-46)1)");
                var v = ov.swizzle.zyy;
                Assert.AreEqual("((-46)1)", v.x);
                Assert.AreEqual("(9-2)", v.y);
                Assert.AreEqual("(9-2)", v.z);
            }
            {
                var ov = new gvec3<string>("-2", "((76)5)", "-2");
                var v = ov.swizzle.zyyx;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("((76)5)", v.y);
                Assert.AreEqual("((76)5)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(4-9)", "");
                var v = ov.swizzle.zyyxx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(4-9)", v.y);
                Assert.AreEqual("(4-9)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("1", "(30)", "1");
                var v = ov.swizzle.zyyxy;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("(30)", v.y);
                Assert.AreEqual("(30)", v.z);
                Assert.AreEqual("1", v.w);
                Assert.AreEqual("(30)", v.v);
            }
            {
                var ov = new gvec3<string>("-7", null, "(60)");
                var v = ov.swizzle.zyyxz;
                Assert.AreEqual("(60)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-7", v.w);
                Assert.AreEqual("(60)", v.v);
            }
            {
                var ov = new gvec3<string>("((-2-2)-6)", "(4-4)", "(4-4)");
                var v = ov.swizzle.zyyy;
                Assert.AreEqual("(4-4)", v.x);
                Assert.AreEqual("(4-4)", v.y);
                Assert.AreEqual("(4-4)", v.z);
                Assert.AreEqual("(4-4)", v.w);
            }
            {
                var ov = new gvec3<string>("((61)7)", "-9", "(-20)");
                var v = ov.swizzle.zyyyx;
                Assert.AreEqual("(-20)", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
                Assert.AreEqual("((61)7)", v.v);
            }
            {
                var ov = new gvec3<string>("(50)", "(-5-8)", null);
                var v = ov.swizzle.zyyyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-5-8)", v.y);
                Assert.AreEqual("(-5-8)", v.z);
                Assert.AreEqual("(-5-8)", v.w);
                Assert.AreEqual("(-5-8)", v.v);
            }
            {
                var ov = new gvec3<string>("1", null, "(9-4)");
                var v = ov.swizzle.zyyyz;
                Assert.AreEqual("(9-4)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(9-4)", v.v);
            }
            {
                var ov = new gvec3<string>("", "(-25)", "-3");
                var v = ov.swizzle.zyyz;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("(-25)", v.y);
                Assert.AreEqual("(-25)", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec3<string>("-6", "((12)5)", "(4-6)");
                var v = ov.swizzle.zyyzx;
                Assert.AreEqual("(4-6)", v.x);
                Assert.AreEqual("((12)5)", v.y);
                Assert.AreEqual("((12)5)", v.z);
                Assert.AreEqual("(4-6)", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("", "(0-3)", "7");
                var v = ov.swizzle.zyyzy;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("(0-3)", v.y);
                Assert.AreEqual("(0-3)", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("(0-3)", v.v);
            }
            {
                var ov = new gvec3<string>("(-53)", "((-9-1)5)", "0");
                var v = ov.swizzle.zyyzz;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("((-9-1)5)", v.y);
                Assert.AreEqual("((-9-1)5)", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("(-87)", "((-90)1)", "3");
                var v = ov.swizzle.zyz;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("((-90)1)", v.y);
                Assert.AreEqual("3", v.z);
            }
            {
                var ov = new gvec3<string>("0", "(-3-6)", "(-69)");
                var v = ov.swizzle.zyzx;
                Assert.AreEqual("(-69)", v.x);
                Assert.AreEqual("(-3-6)", v.y);
                Assert.AreEqual("(-69)", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec3<string>(null, "-9", "-5");
                var v = ov.swizzle.zyzxx;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("2", "-2", "");
                var v = ov.swizzle.zyzxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("2", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("((81)1)", null, "((5-5)-7)");
                var v = ov.swizzle.zyzxz;
                Assert.AreEqual("((5-5)-7)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((5-5)-7)", v.z);
                Assert.AreEqual("((81)1)", v.w);
                Assert.AreEqual("((5-5)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("-2", "-2", "((-3-1)1)");
                var v = ov.swizzle.zyzy;
                Assert.AreEqual("((-3-1)1)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("((-3-1)1)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec3<string>("((4-5)9)", null, "-7");
                var v = ov.swizzle.zyzyx;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((4-5)9)", v.v);
            }
            {
                var ov = new gvec3<string>("(5-6)", "4", "((38)-5)");
                var v = ov.swizzle.zyzyy;
                Assert.AreEqual("((38)-5)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("((38)-5)", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("4", v.v);
            }
            {
                var ov = new gvec3<string>("((-6-7)6)", null, "-9");
                var v = ov.swizzle.zyzyz;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("-9", v.v);
            }
            {
                var ov = new gvec3<string>("(54)", "9", "-7");
                var v = ov.swizzle.zyzz;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec3<string>("4", "", "4");
                var v = ov.swizzle.zyzzx;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("4", v.v);
            }
            {
                var ov = new gvec3<string>("((9-2)5)", "5", "((9-2)5)");
                var v = ov.swizzle.zyzzy;
                Assert.AreEqual("((9-2)5)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("((9-2)5)", v.z);
                Assert.AreEqual("((9-2)5)", v.w);
                Assert.AreEqual("5", v.v);
            }
            {
                var ov = new gvec3<string>("((-35)6)", "((42)-6)", "((-35)6)");
                var v = ov.swizzle.zyzzz;
                Assert.AreEqual("((-35)6)", v.x);
                Assert.AreEqual("((42)-6)", v.y);
                Assert.AreEqual("((-35)6)", v.z);
                Assert.AreEqual("((-35)6)", v.w);
                Assert.AreEqual("((-35)6)", v.v);
            }
            {
                var ov = new gvec3<string>("((68)3)", "", "((6-8)-3)");
                var v = ov.swizzle.zz;
                Assert.AreEqual("((6-8)-3)", v.x);
                Assert.AreEqual("((6-8)-3)", v.y);
            }
            {
                var ov = new gvec3<string>("((35)-6)", "6", "7");
                var v = ov.swizzle.zzx;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("((35)-6)", v.z);
            }
            {
                var ov = new gvec3<string>("(7-7)", "1", "((-29)-6)");
                var v = ov.swizzle.zzxx;
                Assert.AreEqual("((-29)-6)", v.x);
                Assert.AreEqual("((-29)-6)", v.y);
                Assert.AreEqual("(7-7)", v.z);
                Assert.AreEqual("(7-7)", v.w);
            }
            {
                var ov = new gvec3<string>("((-1-4)-1)", "7", "3");
                var v = ov.swizzle.zzxxx;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("((-1-4)-1)", v.z);
                Assert.AreEqual("((-1-4)-1)", v.w);
                Assert.AreEqual("((-1-4)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("(0-7)", "((-8-6)5)", "-2");
                var v = ov.swizzle.zzxxy;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("(0-7)", v.z);
                Assert.AreEqual("(0-7)", v.w);
                Assert.AreEqual("((-8-6)5)", v.v);
            }
            {
                var ov = new gvec3<string>("((1-1)5)", "(7-1)", "(7-1)");
                var v = ov.swizzle.zzxxz;
                Assert.AreEqual("(7-1)", v.x);
                Assert.AreEqual("(7-1)", v.y);
                Assert.AreEqual("((1-1)5)", v.z);
                Assert.AreEqual("((1-1)5)", v.w);
                Assert.AreEqual("(7-1)", v.v);
            }
            {
                var ov = new gvec3<string>("3", "((-6-1)-6)", "3");
                var v = ov.swizzle.zzxy;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("((-6-1)-6)", v.w);
            }
            {
                var ov = new gvec3<string>("((-3-7)-6)", "((-3-7)-6)", "");
                var v = ov.swizzle.zzxyx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-3-7)-6)", v.z);
                Assert.AreEqual("((-3-7)-6)", v.w);
                Assert.AreEqual("((-3-7)-6)", v.v);
            }
            {
                var ov = new gvec3<string>("((-38)4)", "(6-2)", "(-1-9)");
                var v = ov.swizzle.zzxyy;
                Assert.AreEqual("(-1-9)", v.x);
                Assert.AreEqual("(-1-9)", v.y);
                Assert.AreEqual("((-38)4)", v.z);
                Assert.AreEqual("(6-2)", v.w);
                Assert.AreEqual("(6-2)", v.v);
            }
            {
                var ov = new gvec3<string>("(2-3)", "(-32)", "((63)8)");
                var v = ov.swizzle.zzxyz;
                Assert.AreEqual("((63)8)", v.x);
                Assert.AreEqual("((63)8)", v.y);
                Assert.AreEqual("(2-3)", v.z);
                Assert.AreEqual("(-32)", v.w);
                Assert.AreEqual("((63)8)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((30)-6)", "((53)-8)");
                var v = ov.swizzle.zzxz;
                Assert.AreEqual("((53)-8)", v.x);
                Assert.AreEqual("((53)-8)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((53)-8)", v.w);
            }
            {
                var ov = new gvec3<string>("0", "(12)", "(12)");
                var v = ov.swizzle.zzxzx;
                Assert.AreEqual("(12)", v.x);
                Assert.AreEqual("(12)", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("(12)", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("1", "", null);
                var v = ov.swizzle.zzxzy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(6-7)", null, "(0-5)");
                var v = ov.swizzle.zzxzz;
                Assert.AreEqual("(0-5)", v.x);
                Assert.AreEqual("(0-5)", v.y);
                Assert.AreEqual("(6-7)", v.z);
                Assert.AreEqual("(0-5)", v.w);
                Assert.AreEqual("(0-5)", v.v);
            }
            {
                var ov = new gvec3<string>("(81)", "5", null);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("5", v.z);
            }
            {
                var ov = new gvec3<string>("8", "", "(-96)");
                var v = ov.swizzle.zzyx;
                Assert.AreEqual("(-96)", v.x);
                Assert.AreEqual("(-96)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec3<string>("(-46)", "(3-9)", "5");
                var v = ov.swizzle.zzyxx;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("(3-9)", v.z);
                Assert.AreEqual("(-46)", v.w);
                Assert.AreEqual("(-46)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((6-7)6)", "(-1-6)");
                var v = ov.swizzle.zzyxy;
                Assert.AreEqual("(-1-6)", v.x);
                Assert.AreEqual("(-1-6)", v.y);
                Assert.AreEqual("((6-7)6)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((6-7)6)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((9-7)3)", "((26)-7)");
                var v = ov.swizzle.zzyxz;
                Assert.AreEqual("((26)-7)", v.x);
                Assert.AreEqual("((26)-7)", v.y);
                Assert.AreEqual("((9-7)3)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((26)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("((-48)-2)", "-6", "");
                var v = ov.swizzle.zzyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec3<string>("-1", "(6-4)", "(6-4)");
                var v = ov.swizzle.zzyyx;
                Assert.AreEqual("(6-4)", v.x);
                Assert.AreEqual("(6-4)", v.y);
                Assert.AreEqual("(6-4)", v.z);
                Assert.AreEqual("(6-4)", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("((4-8)4)", "-7", "((-3-4)-2)");
                var v = ov.swizzle.zzyyy;
                Assert.AreEqual("((-3-4)-2)", v.x);
                Assert.AreEqual("((-3-4)-2)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-7", v.w);
                Assert.AreEqual("-7", v.v);
            }
            {
                var ov = new gvec3<string>("6", "-1", "(-58)");
                var v = ov.swizzle.zzyyz;
                Assert.AreEqual("(-58)", v.x);
                Assert.AreEqual("(-58)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("(-58)", v.v);
            }
            {
                var ov = new gvec3<string>("((4-7)1)", null, "");
                var v = ov.swizzle.zzyz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(-48)", "((13)-5)", "3");
                var v = ov.swizzle.zzyzx;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("((13)-5)", v.z);
                Assert.AreEqual("3", v.w);
                Assert.AreEqual("(-48)", v.v);
            }
            {
                var ov = new gvec3<string>("((-58)2)", "(7-1)", "((-1-3)6)");
                var v = ov.swizzle.zzyzy;
                Assert.AreEqual("((-1-3)6)", v.x);
                Assert.AreEqual("((-1-3)6)", v.y);
                Assert.AreEqual("(7-1)", v.z);
                Assert.AreEqual("((-1-3)6)", v.w);
                Assert.AreEqual("(7-1)", v.v);
            }
            {
                var ov = new gvec3<string>("((6-4)-7)", "((8-2)-3)", "((8-2)-3)");
                var v = ov.swizzle.zzyzz;
                Assert.AreEqual("((8-2)-3)", v.x);
                Assert.AreEqual("((8-2)-3)", v.y);
                Assert.AreEqual("((8-2)-3)", v.z);
                Assert.AreEqual("((8-2)-3)", v.w);
                Assert.AreEqual("((8-2)-3)", v.v);
            }
            {
                var ov = new gvec3<string>("(-3-3)", "1", "((68)5)");
                var v = ov.swizzle.zzz;
                Assert.AreEqual("((68)5)", v.x);
                Assert.AreEqual("((68)5)", v.y);
                Assert.AreEqual("((68)5)", v.z);
            }
            {
                var ov = new gvec3<string>("(20)", null, null);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(20)", v.w);
            }
            {
                var ov = new gvec3<string>("((-91)-3)", "(-14)", "1");
                var v = ov.swizzle.zzzxx;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("((-91)-3)", v.w);
                Assert.AreEqual("((-91)-3)", v.v);
            }
            {
                var ov = new gvec3<string>("((8-8)-3)", "((8-4)3)", "(-67)");
                var v = ov.swizzle.zzzxy;
                Assert.AreEqual("(-67)", v.x);
                Assert.AreEqual("(-67)", v.y);
                Assert.AreEqual("(-67)", v.z);
                Assert.AreEqual("((8-8)-3)", v.w);
                Assert.AreEqual("((8-4)3)", v.v);
            }
            {
                var ov = new gvec3<string>("-4", "-6", "-7");
                var v = ov.swizzle.zzzxz;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("-7", v.v);
            }
            {
                var ov = new gvec3<string>("-1", null, "((12)-8)");
                var v = ov.swizzle.zzzy;
                Assert.AreEqual("((12)-8)", v.x);
                Assert.AreEqual("((12)-8)", v.y);
                Assert.AreEqual("((12)-8)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("-6", "", null);
                var v = ov.swizzle.zzzyx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("(23)", "-1", "5");
                var v = ov.swizzle.zzzyy;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("", "8", "-8");
                var v = ov.swizzle.zzzyz;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("8", v.w);
                Assert.AreEqual("-8", v.v);
            }
            {
                var ov = new gvec3<string>("-2", "", "(17)");
                var v = ov.swizzle.zzzz;
                Assert.AreEqual("(17)", v.x);
                Assert.AreEqual("(17)", v.y);
                Assert.AreEqual("(17)", v.z);
                Assert.AreEqual("(17)", v.w);
            }
            {
                var ov = new gvec3<string>("9", "((3-7)-4)", "((3-7)-4)");
                var v = ov.swizzle.zzzzx;
                Assert.AreEqual("((3-7)-4)", v.x);
                Assert.AreEqual("((3-7)-4)", v.y);
                Assert.AreEqual("((3-7)-4)", v.z);
                Assert.AreEqual("((3-7)-4)", v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("6", "(-9-9)", "(2-6)");
                var v = ov.swizzle.zzzzy;
                Assert.AreEqual("(2-6)", v.x);
                Assert.AreEqual("(2-6)", v.y);
                Assert.AreEqual("(2-6)", v.z);
                Assert.AreEqual("(2-6)", v.w);
                Assert.AreEqual("(-9-9)", v.v);
            }
            {
                var ov = new gvec3<string>("(-8-1)", "", "(-8-1)");
                var v = ov.swizzle.zzzzz;
                Assert.AreEqual("(-8-1)", v.x);
                Assert.AreEqual("(-8-1)", v.y);
                Assert.AreEqual("(-8-1)", v.z);
                Assert.AreEqual("(-8-1)", v.w);
                Assert.AreEqual("(-8-1)", v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new gvec3<string>("(-7-2)", "(-56)", "");
                var v = ov.swizzle.rr;
                Assert.AreEqual("(-7-2)", v.x);
                Assert.AreEqual("(-7-2)", v.y);
            }
            {
                var ov = new gvec3<string>(null, "((-11)0)", "(9-8)");
                var v = ov.swizzle.rrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("((-6-3)-9)", "((-6-3)-9)", "-8");
                var v = ov.swizzle.rrrr;
                Assert.AreEqual("((-6-3)-9)", v.x);
                Assert.AreEqual("((-6-3)-9)", v.y);
                Assert.AreEqual("((-6-3)-9)", v.z);
                Assert.AreEqual("((-6-3)-9)", v.w);
            }
            {
                var ov = new gvec3<string>("", "6", null);
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(-21)", "((87)-6)", "((87)-6)");
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual("(-21)", v.x);
                Assert.AreEqual("(-21)", v.y);
                Assert.AreEqual("(-21)", v.z);
                Assert.AreEqual("(-21)", v.w);
                Assert.AreEqual("((87)-6)", v.v);
            }
            {
                var ov = new gvec3<string>("", "-9", null);
                var v = ov.swizzle.rrrrb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("", "((06)-4)", "(40)");
                var v = ov.swizzle.rrrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((06)-4)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(-7-7)", "");
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(-7-7)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("", null, "4");
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("", "(4-5)", "(-82)");
                var v = ov.swizzle.rrrgb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(4-5)", v.w);
                Assert.AreEqual("(-82)", v.v);
            }
            {
                var ov = new gvec3<string>("(68)", null, "-3");
                var v = ov.swizzle.rrrb;
                Assert.AreEqual("(68)", v.x);
                Assert.AreEqual("(68)", v.y);
                Assert.AreEqual("(68)", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec3<string>("(73)", "8", "((4-1)0)");
                var v = ov.swizzle.rrrbr;
                Assert.AreEqual("(73)", v.x);
                Assert.AreEqual("(73)", v.y);
                Assert.AreEqual("(73)", v.z);
                Assert.AreEqual("((4-1)0)", v.w);
                Assert.AreEqual("(73)", v.v);
            }
            {
                var ov = new gvec3<string>("((7-8)-7)", "((-66)-7)", "-8");
                var v = ov.swizzle.rrrbg;
                Assert.AreEqual("((7-8)-7)", v.x);
                Assert.AreEqual("((7-8)-7)", v.y);
                Assert.AreEqual("((7-8)-7)", v.z);
                Assert.AreEqual("-8", v.w);
                Assert.AreEqual("((-66)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("", "1", "6");
                var v = ov.swizzle.rrrbb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec3<string>("", "((5-7)5)", "((77)7)");
                var v = ov.swizzle.rrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((5-7)5)", v.z);
            }
            {
                var ov = new gvec3<string>("(15)", "(15)", "((-42)5)");
                var v = ov.swizzle.rrgr;
                Assert.AreEqual("(15)", v.x);
                Assert.AreEqual("(15)", v.y);
                Assert.AreEqual("(15)", v.z);
                Assert.AreEqual("(15)", v.w);
            }
            {
                var ov = new gvec3<string>("((-6-9)1)", "(4-9)", "0");
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual("((-6-9)1)", v.x);
                Assert.AreEqual("((-6-9)1)", v.y);
                Assert.AreEqual("(4-9)", v.z);
                Assert.AreEqual("((-6-9)1)", v.w);
                Assert.AreEqual("((-6-9)1)", v.v);
            }
            {
                var ov = new gvec3<string>("(-1-1)", "", "((25)-6)");
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual("(-1-1)", v.x);
                Assert.AreEqual("(-1-1)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-1-1)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("-5", "((86)-4)", "(-69)");
                var v = ov.swizzle.rrgrb;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("((86)-4)", v.z);
                Assert.AreEqual("-5", v.w);
                Assert.AreEqual("(-69)", v.v);
            }
            {
                var ov = new gvec3<string>("-4", "(-3-4)", "(-62)");
                var v = ov.swizzle.rrgg;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("(-3-4)", v.z);
                Assert.AreEqual("(-3-4)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(-19)", "(-41)");
                var v = ov.swizzle.rrggr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-19)", v.z);
                Assert.AreEqual("(-19)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((5-1)-2)", "(76)", "-6");
                var v = ov.swizzle.rrggg;
                Assert.AreEqual("((5-1)-2)", v.x);
                Assert.AreEqual("((5-1)-2)", v.y);
                Assert.AreEqual("(76)", v.z);
                Assert.AreEqual("(76)", v.w);
                Assert.AreEqual("(76)", v.v);
            }
            {
                var ov = new gvec3<string>("((39)4)", "-1", "(-7-6)");
                var v = ov.swizzle.rrggb;
                Assert.AreEqual("((39)4)", v.x);
                Assert.AreEqual("((39)4)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("(-7-6)", v.v);
            }
            {
                var ov = new gvec3<string>("(-6-1)", "-9", "((87)-1)");
                var v = ov.swizzle.rrgb;
                Assert.AreEqual("(-6-1)", v.x);
                Assert.AreEqual("(-6-1)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("((87)-1)", v.w);
            }
            {
                var ov = new gvec3<string>("((-84)-2)", "", "3");
                var v = ov.swizzle.rrgbr;
                Assert.AreEqual("((-84)-2)", v.x);
                Assert.AreEqual("((-84)-2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("3", v.w);
                Assert.AreEqual("((-84)-2)", v.v);
            }
            {
                var ov = new gvec3<string>("-3", "((27)6)", "(9-5)");
                var v = ov.swizzle.rrgbg;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("((27)6)", v.z);
                Assert.AreEqual("(9-5)", v.w);
                Assert.AreEqual("((27)6)", v.v);
            }
            {
                var ov = new gvec3<string>("(92)", "(-3-6)", "(44)");
                var v = ov.swizzle.rrgbb;
                Assert.AreEqual("(92)", v.x);
                Assert.AreEqual("(92)", v.y);
                Assert.AreEqual("(-3-6)", v.z);
                Assert.AreEqual("(44)", v.w);
                Assert.AreEqual("(44)", v.v);
            }
            {
                var ov = new gvec3<string>("((1-1)9)", "-3", null);
                var v = ov.swizzle.rrb;
                Assert.AreEqual("((1-1)9)", v.x);
                Assert.AreEqual("((1-1)9)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("(81)", null, null);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual("(81)", v.x);
                Assert.AreEqual("(81)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(81)", v.w);
            }
            {
                var ov = new gvec3<string>("(4-3)", "((3-8)-2)", "-1");
                var v = ov.swizzle.rrbrr;
                Assert.AreEqual("(4-3)", v.x);
                Assert.AreEqual("(4-3)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("(4-3)", v.w);
                Assert.AreEqual("(4-3)", v.v);
            }
            {
                var ov = new gvec3<string>("-9", "((-99)2)", "((1-3)3)");
                var v = ov.swizzle.rrbrg;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("((1-3)3)", v.z);
                Assert.AreEqual("-9", v.w);
                Assert.AreEqual("((-99)2)", v.v);
            }
            {
                var ov = new gvec3<string>("(-84)", "5", "(01)");
                var v = ov.swizzle.rrbrb;
                Assert.AreEqual("(-84)", v.x);
                Assert.AreEqual("(-84)", v.y);
                Assert.AreEqual("(01)", v.z);
                Assert.AreEqual("(-84)", v.w);
                Assert.AreEqual("(01)", v.v);
            }
            {
                var ov = new gvec3<string>("(50)", "(91)", "(11)");
                var v = ov.swizzle.rrbg;
                Assert.AreEqual("(50)", v.x);
                Assert.AreEqual("(50)", v.y);
                Assert.AreEqual("(11)", v.z);
                Assert.AreEqual("(91)", v.w);
            }
            {
                var ov = new gvec3<string>("((-5-4)6)", "((42)2)", "((-5-4)6)");
                var v = ov.swizzle.rrbgr;
                Assert.AreEqual("((-5-4)6)", v.x);
                Assert.AreEqual("((-5-4)6)", v.y);
                Assert.AreEqual("((-5-4)6)", v.z);
                Assert.AreEqual("((42)2)", v.w);
                Assert.AreEqual("((-5-4)6)", v.v);
            }
            {
                var ov = new gvec3<string>("(33)", "-1", "((-2-8)-4)");
                var v = ov.swizzle.rrbgg;
                Assert.AreEqual("(33)", v.x);
                Assert.AreEqual("(33)", v.y);
                Assert.AreEqual("((-2-8)-4)", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("(4-3)", "(-4-1)", "(-4-1)");
                var v = ov.swizzle.rrbgb;
                Assert.AreEqual("(4-3)", v.x);
                Assert.AreEqual("(4-3)", v.y);
                Assert.AreEqual("(-4-1)", v.z);
                Assert.AreEqual("(-4-1)", v.w);
                Assert.AreEqual("(-4-1)", v.v);
            }
            {
                var ov = new gvec3<string>("((-2-9)0)", "((-4-7)-8)", "((-2-9)0)");
                var v = ov.swizzle.rrbb;
                Assert.AreEqual("((-2-9)0)", v.x);
                Assert.AreEqual("((-2-9)0)", v.y);
                Assert.AreEqual("((-2-9)0)", v.z);
                Assert.AreEqual("((-2-9)0)", v.w);
            }
            {
                var ov = new gvec3<string>("(5-1)", "(-8-4)", "(5-1)");
                var v = ov.swizzle.rrbbr;
                Assert.AreEqual("(5-1)", v.x);
                Assert.AreEqual("(5-1)", v.y);
                Assert.AreEqual("(5-1)", v.z);
                Assert.AreEqual("(5-1)", v.w);
                Assert.AreEqual("(5-1)", v.v);
            }
            {
                var ov = new gvec3<string>("-4", "((0-3)4)", "(3-1)");
                var v = ov.swizzle.rrbbg;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("(3-1)", v.z);
                Assert.AreEqual("(3-1)", v.w);
                Assert.AreEqual("((0-3)4)", v.v);
            }
            {
                var ov = new gvec3<string>("7", "(26)", "(-3-7)");
                var v = ov.swizzle.rrbbb;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("(-3-7)", v.z);
                Assert.AreEqual("(-3-7)", v.w);
                Assert.AreEqual("(-3-7)", v.v);
            }
            {
                var ov = new gvec3<string>("", "8", "((-4-9)7)");
                var v = ov.swizzle.rg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("8", v.y);
            }
            {
                var ov = new gvec3<string>("(56)", "((7-4)0)", "((59)-6)");
                var v = ov.swizzle.rgr;
                Assert.AreEqual("(56)", v.x);
                Assert.AreEqual("((7-4)0)", v.y);
                Assert.AreEqual("(56)", v.z);
            }
            {
                var ov = new gvec3<string>("", "-7", "(92)");
                var v = ov.swizzle.rgrr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((-64)7)", null, "");
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual("((-64)7)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-64)7)", v.z);
                Assert.AreEqual("((-64)7)", v.w);
                Assert.AreEqual("((-64)7)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((-3-4)3)", "((-42)-7)");
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-3-4)3)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((-3-4)3)", v.v);
            }
            {
                var ov = new gvec3<string>("(-71)", "-2", "((-4-5)9)");
                var v = ov.swizzle.rgrrb;
                Assert.AreEqual("(-71)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("(-71)", v.z);
                Assert.AreEqual("(-71)", v.w);
                Assert.AreEqual("((-4-5)9)", v.v);
            }
            {
                var ov = new gvec3<string>("((-53)-9)", null, "(84)");
                var v = ov.swizzle.rgrg;
                Assert.AreEqual("((-53)-9)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-53)-9)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("3", "((58)3)", "((-3-7)-8)");
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("((58)3)", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("((58)3)", v.w);
                Assert.AreEqual("3", v.v);
            }
            {
                var ov = new gvec3<string>("-7", "(3-9)", "");
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(3-9)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("(3-9)", v.w);
                Assert.AreEqual("(3-9)", v.v);
            }
            {
                var ov = new gvec3<string>("4", "(-7-5)", "4");
                var v = ov.swizzle.rgrgb;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("(-7-5)", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("(-7-5)", v.w);
                Assert.AreEqual("4", v.v);
            }
            {
                var ov = new gvec3<string>("((-32)-1)", "(-3-8)", "((-4-1)-7)");
                var v = ov.swizzle.rgrb;
                Assert.AreEqual("((-32)-1)", v.x);
                Assert.AreEqual("(-3-8)", v.y);
                Assert.AreEqual("((-32)-1)", v.z);
                Assert.AreEqual("((-4-1)-7)", v.w);
            }
            {
                var ov = new gvec3<string>("-2", "(-87)", "((-58)-9)");
                var v = ov.swizzle.rgrbr;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("(-87)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("((-58)-9)", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("9", "1", "9");
                var v = ov.swizzle.rgrbg;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>("", "(-92)", "");
                var v = ov.swizzle.rgrbb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-92)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("8", "-5", "(01)");
                var v = ov.swizzle.rgg;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("-5", v.z);
            }
            {
                var ov = new gvec3<string>("((52)8)", "(-5-3)", null);
                var v = ov.swizzle.rggr;
                Assert.AreEqual("((52)8)", v.x);
                Assert.AreEqual("(-5-3)", v.y);
                Assert.AreEqual("(-5-3)", v.z);
                Assert.AreEqual("((52)8)", v.w);
            }
            {
                var ov = new gvec3<string>("((0-2)-7)", "((-9-1)5)", "-5");
                var v = ov.swizzle.rggrr;
                Assert.AreEqual("((0-2)-7)", v.x);
                Assert.AreEqual("((-9-1)5)", v.y);
                Assert.AreEqual("((-9-1)5)", v.z);
                Assert.AreEqual("((0-2)-7)", v.w);
                Assert.AreEqual("((0-2)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("0", "5", "(-1-5)");
                var v = ov.swizzle.rggrg;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("5", v.v);
            }
            {
                var ov = new gvec3<string>("", "((7-7)5)", "(05)");
                var v = ov.swizzle.rggrb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((7-7)5)", v.y);
                Assert.AreEqual("((7-7)5)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("(05)", v.v);
            }
            {
                var ov = new gvec3<string>("", "(22)", "9");
                var v = ov.swizzle.rggg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(22)", v.y);
                Assert.AreEqual("(22)", v.z);
                Assert.AreEqual("(22)", v.w);
            }
            {
                var ov = new gvec3<string>("((16)-6)", "((7-5)-7)", "((7-5)-7)");
                var v = ov.swizzle.rgggr;
                Assert.AreEqual("((16)-6)", v.x);
                Assert.AreEqual("((7-5)-7)", v.y);
                Assert.AreEqual("((7-5)-7)", v.z);
                Assert.AreEqual("((7-5)-7)", v.w);
                Assert.AreEqual("((16)-6)", v.v);
            }
            {
                var ov = new gvec3<string>("((-19)7)", "2", "((5-8)6)");
                var v = ov.swizzle.rgggg;
                Assert.AreEqual("((-19)7)", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("2", v.w);
                Assert.AreEqual("2", v.v);
            }
            {
                var ov = new gvec3<string>("-2", "2", "");
                var v = ov.swizzle.rgggb;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("2", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(-1-2)", "", "((8-4)3)");
                var v = ov.swizzle.rggb;
                Assert.AreEqual("(-1-2)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((8-4)3)", v.w);
            }
            {
                var ov = new gvec3<string>("-1", "(70)", "(70)");
                var v = ov.swizzle.rggbr;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("(70)", v.y);
                Assert.AreEqual("(70)", v.z);
                Assert.AreEqual("(70)", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("-9", "((86)-4)", "((26)7)");
                var v = ov.swizzle.rggbg;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((86)-4)", v.y);
                Assert.AreEqual("((86)-4)", v.z);
                Assert.AreEqual("((26)7)", v.w);
                Assert.AreEqual("((86)-4)", v.v);
            }
            {
                var ov = new gvec3<string>("(29)", "((-25)3)", "((-9-3)2)");
                var v = ov.swizzle.rggbb;
                Assert.AreEqual("(29)", v.x);
                Assert.AreEqual("((-25)3)", v.y);
                Assert.AreEqual("((-25)3)", v.z);
                Assert.AreEqual("((-9-3)2)", v.w);
                Assert.AreEqual("((-9-3)2)", v.v);
            }
            {
                var ov = new gvec3<string>("(32)", "((-62)-7)", "");
                var v = ov.swizzle.rgb;
                Assert.AreEqual("(32)", v.x);
                Assert.AreEqual("((-62)-7)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("(-35)", "-5", "(-35)");
                var v = ov.swizzle.rgbr;
                Assert.AreEqual("(-35)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(-35)", v.z);
                Assert.AreEqual("(-35)", v.w);
            }
            {
                var ov = new gvec3<string>("-6", "0", "(-8-3)");
                var v = ov.swizzle.rgbrr;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("(-8-3)", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(-9-4)", "(25)");
                var v = ov.swizzle.rgbrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-9-4)", v.y);
                Assert.AreEqual("(25)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-9-4)", v.v);
            }
            {
                var ov = new gvec3<string>("1", "((2-7)-4)", "((1-6)0)");
                var v = ov.swizzle.rgbrb;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("((2-7)-4)", v.y);
                Assert.AreEqual("((1-6)0)", v.z);
                Assert.AreEqual("1", v.w);
                Assert.AreEqual("((1-6)0)", v.v);
            }
            {
                var ov = new gvec3<string>("(06)", "(06)", "(-25)");
                var v = ov.swizzle.rgbg;
                Assert.AreEqual("(06)", v.x);
                Assert.AreEqual("(06)", v.y);
                Assert.AreEqual("(-25)", v.z);
                Assert.AreEqual("(06)", v.w);
            }
            {
                var ov = new gvec3<string>("-8", "-8", "((4-4)-2)");
                var v = ov.swizzle.rgbgr;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("((4-4)-2)", v.z);
                Assert.AreEqual("-8", v.w);
                Assert.AreEqual("-8", v.v);
            }
            {
                var ov = new gvec3<string>("(-54)", "((34)6)", "3");
                var v = ov.swizzle.rgbgg;
                Assert.AreEqual("(-54)", v.x);
                Assert.AreEqual("((34)6)", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("((34)6)", v.w);
                Assert.AreEqual("((34)6)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(-27)", "((60)2)");
                var v = ov.swizzle.rgbgb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-27)", v.y);
                Assert.AreEqual("((60)2)", v.z);
                Assert.AreEqual("(-27)", v.w);
                Assert.AreEqual("((60)2)", v.v);
            }
            {
                var ov = new gvec3<string>("1", "((-2-4)-8)", "(-4-3)");
                var v = ov.swizzle.rgbb;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("((-2-4)-8)", v.y);
                Assert.AreEqual("(-4-3)", v.z);
                Assert.AreEqual("(-4-3)", v.w);
            }
            {
                var ov = new gvec3<string>("-7", "((-51)-1)", "((-99)3)");
                var v = ov.swizzle.rgbbr;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((-51)-1)", v.y);
                Assert.AreEqual("((-99)3)", v.z);
                Assert.AreEqual("((-99)3)", v.w);
                Assert.AreEqual("-7", v.v);
            }
            {
                var ov = new gvec3<string>("", "-1", "(-51)");
                var v = ov.swizzle.rgbbg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("(-51)", v.z);
                Assert.AreEqual("(-51)", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("((93)-1)", null, "((93)-1)");
                var v = ov.swizzle.rgbbb;
                Assert.AreEqual("((93)-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((93)-1)", v.z);
                Assert.AreEqual("((93)-1)", v.w);
                Assert.AreEqual("((93)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((-90)-8)", "((36)-5)");
                var v = ov.swizzle.rb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((36)-5)", v.y);
            }
            {
                var ov = new gvec3<string>("6", "((-8-9)-8)", "7");
                var v = ov.swizzle.rbr;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("6", v.z);
            }
            {
                var ov = new gvec3<string>("((40)3)", "", "((40)3)");
                var v = ov.swizzle.rbrr;
                Assert.AreEqual("((40)3)", v.x);
                Assert.AreEqual("((40)3)", v.y);
                Assert.AreEqual("((40)3)", v.z);
                Assert.AreEqual("((40)3)", v.w);
            }
            {
                var ov = new gvec3<string>("((75)-1)", "(-6-4)", "1");
                var v = ov.swizzle.rbrrr;
                Assert.AreEqual("((75)-1)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("((75)-1)", v.z);
                Assert.AreEqual("((75)-1)", v.w);
                Assert.AreEqual("((75)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("(37)", "4", "(37)");
                var v = ov.swizzle.rbrrg;
                Assert.AreEqual("(37)", v.x);
                Assert.AreEqual("(37)", v.y);
                Assert.AreEqual("(37)", v.z);
                Assert.AreEqual("(37)", v.w);
                Assert.AreEqual("4", v.v);
            }
            {
                var ov = new gvec3<string>("-8", "-8", "");
                var v = ov.swizzle.rbrrb;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("-8", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((-6-1)-7)", "", "((50)9)");
                var v = ov.swizzle.rbrg;
                Assert.AreEqual("((-6-1)-7)", v.x);
                Assert.AreEqual("((50)9)", v.y);
                Assert.AreEqual("((-6-1)-7)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((8-1)-4)", "", "((-34)2)");
                var v = ov.swizzle.rbrgr;
                Assert.AreEqual("((8-1)-4)", v.x);
                Assert.AreEqual("((-34)2)", v.y);
                Assert.AreEqual("((8-1)-4)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((8-1)-4)", v.v);
            }
            {
                var ov = new gvec3<string>("((-8-7)-3)", "((-9-4)-8)", null);
                var v = ov.swizzle.rbrgg;
                Assert.AreEqual("((-8-7)-3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-8-7)-3)", v.z);
                Assert.AreEqual("((-9-4)-8)", v.w);
                Assert.AreEqual("((-9-4)-8)", v.v);
            }
            {
                var ov = new gvec3<string>("(-46)", "-7", "((-44)0)");
                var v = ov.swizzle.rbrgb;
                Assert.AreEqual("(-46)", v.x);
                Assert.AreEqual("((-44)0)", v.y);
                Assert.AreEqual("(-46)", v.z);
                Assert.AreEqual("-7", v.w);
                Assert.AreEqual("((-44)0)", v.v);
            }
            {
                var ov = new gvec3<string>("((09)8)", null, "-9");
                var v = ov.swizzle.rbrb;
                Assert.AreEqual("((09)8)", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("((09)8)", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((5-6)2)", "(-39)");
                var v = ov.swizzle.rbrbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-39)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(-39)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("-4", "((-69)3)", "(-35)");
                var v = ov.swizzle.rbrbg;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("(-35)", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("(-35)", v.w);
                Assert.AreEqual("((-69)3)", v.v);
            }
            {
                var ov = new gvec3<string>("7", "", "((35)7)");
                var v = ov.swizzle.rbrbb;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("((35)7)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("((35)7)", v.w);
                Assert.AreEqual("((35)7)", v.v);
            }
            {
                var ov = new gvec3<string>("(86)", "((1-4)-6)", "((5-1)0)");
                var v = ov.swizzle.rbg;
                Assert.AreEqual("(86)", v.x);
                Assert.AreEqual("((5-1)0)", v.y);
                Assert.AreEqual("((1-4)-6)", v.z);
            }
            {
                var ov = new gvec3<string>("8", "(-33)", "(-33)");
                var v = ov.swizzle.rbgr;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("(-33)", v.y);
                Assert.AreEqual("(-33)", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec3<string>("-2", null, "((69)2)");
                var v = ov.swizzle.rbgrr;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("((69)2)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("(-54)", "(2-5)", "(-54)");
                var v = ov.swizzle.rbgrg;
                Assert.AreEqual("(-54)", v.x);
                Assert.AreEqual("(-54)", v.y);
                Assert.AreEqual("(2-5)", v.z);
                Assert.AreEqual("(-54)", v.w);
                Assert.AreEqual("(2-5)", v.v);
            }
            {
                var ov = new gvec3<string>("-6", "(-22)", null);
                var v = ov.swizzle.rbgrb;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-22)", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((-3-2)1)", "(84)", "((-22)4)");
                var v = ov.swizzle.rbgg;
                Assert.AreEqual("((-3-2)1)", v.x);
                Assert.AreEqual("((-22)4)", v.y);
                Assert.AreEqual("(84)", v.z);
                Assert.AreEqual("(84)", v.w);
            }
            {
                var ov = new gvec3<string>("", "5", "((5-3)-3)");
                var v = ov.swizzle.rbggr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((5-3)-3)", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("5", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(-4-2)", "((0-6)3)", "7");
                var v = ov.swizzle.rbggg;
                Assert.AreEqual("(-4-2)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("((0-6)3)", v.z);
                Assert.AreEqual("((0-6)3)", v.w);
                Assert.AreEqual("((0-6)3)", v.v);
            }
            {
                var ov = new gvec3<string>("(-16)", "-4", "1");
                var v = ov.swizzle.rbggb;
                Assert.AreEqual("(-16)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>("(-45)", "(-45)", "");
                var v = ov.swizzle.rbgb;
                Assert.AreEqual("(-45)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-45)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((-26)-8)", "(9-9)");
                var v = ov.swizzle.rbgbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(9-9)", v.y);
                Assert.AreEqual("((-26)-8)", v.z);
                Assert.AreEqual("(9-9)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(-8-4)", "4", "((-6-1)2)");
                var v = ov.swizzle.rbgbg;
                Assert.AreEqual("(-8-4)", v.x);
                Assert.AreEqual("((-6-1)2)", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("((-6-1)2)", v.w);
                Assert.AreEqual("4", v.v);
            }
            {
                var ov = new gvec3<string>("(-4-1)", "(-4-1)", "6");
                var v = ov.swizzle.rbgbb;
                Assert.AreEqual("(-4-1)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("(-4-1)", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec3<string>("((-48)-9)", "", "(-4-5)");
                var v = ov.swizzle.rbb;
                Assert.AreEqual("((-48)-9)", v.x);
                Assert.AreEqual("(-4-5)", v.y);
                Assert.AreEqual("(-4-5)", v.z);
            }
            {
                var ov = new gvec3<string>("((09)6)", "", "(-2-4)");
                var v = ov.swizzle.rbbr;
                Assert.AreEqual("((09)6)", v.x);
                Assert.AreEqual("(-2-4)", v.y);
                Assert.AreEqual("(-2-4)", v.z);
                Assert.AreEqual("((09)6)", v.w);
            }
            {
                var ov = new gvec3<string>("((37)-5)", "((37)-5)", "(11)");
                var v = ov.swizzle.rbbrr;
                Assert.AreEqual("((37)-5)", v.x);
                Assert.AreEqual("(11)", v.y);
                Assert.AreEqual("(11)", v.z);
                Assert.AreEqual("((37)-5)", v.w);
                Assert.AreEqual("((37)-5)", v.v);
            }
            {
                var ov = new gvec3<string>("6", "(-54)", "");
                var v = ov.swizzle.rbbrg;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("(-54)", v.v);
            }
            {
                var ov = new gvec3<string>("((-6-3)4)", "6", "8");
                var v = ov.swizzle.rbbrb;
                Assert.AreEqual("((-6-3)4)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("((-6-3)4)", v.w);
                Assert.AreEqual("8", v.v);
            }
            {
                var ov = new gvec3<string>("((2-7)-5)", null, "((-6-8)-7)");
                var v = ov.swizzle.rbbg;
                Assert.AreEqual("((2-7)-5)", v.x);
                Assert.AreEqual("((-6-8)-7)", v.y);
                Assert.AreEqual("((-6-8)-7)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>(null, "(-63)", "");
                var v = ov.swizzle.rbbgr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-63)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((2-4)-1)", "((-96)7)", "(-3-5)");
                var v = ov.swizzle.rbbgg;
                Assert.AreEqual("((2-4)-1)", v.x);
                Assert.AreEqual("(-3-5)", v.y);
                Assert.AreEqual("(-3-5)", v.z);
                Assert.AreEqual("((-96)7)", v.w);
                Assert.AreEqual("((-96)7)", v.v);
            }
            {
                var ov = new gvec3<string>("(9-9)", "", "");
                var v = ov.swizzle.rbbgb;
                Assert.AreEqual("(9-9)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(77)", "8", "((2-2)4)");
                var v = ov.swizzle.rbbb;
                Assert.AreEqual("(77)", v.x);
                Assert.AreEqual("((2-2)4)", v.y);
                Assert.AreEqual("((2-2)4)", v.z);
                Assert.AreEqual("((2-2)4)", v.w);
            }
            {
                var ov = new gvec3<string>("8", "8", "(00)");
                var v = ov.swizzle.rbbbr;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("(00)", v.y);
                Assert.AreEqual("(00)", v.z);
                Assert.AreEqual("(00)", v.w);
                Assert.AreEqual("8", v.v);
            }
            {
                var ov = new gvec3<string>("3", "(-68)", "(86)");
                var v = ov.swizzle.rbbbg;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("(86)", v.y);
                Assert.AreEqual("(86)", v.z);
                Assert.AreEqual("(86)", v.w);
                Assert.AreEqual("(-68)", v.v);
            }
            {
                var ov = new gvec3<string>("((-3-5)8)", "-1", "((-50)9)");
                var v = ov.swizzle.rbbbb;
                Assert.AreEqual("((-3-5)8)", v.x);
                Assert.AreEqual("((-50)9)", v.y);
                Assert.AreEqual("((-50)9)", v.z);
                Assert.AreEqual("((-50)9)", v.w);
                Assert.AreEqual("((-50)9)", v.v);
            }
            {
                var ov = new gvec3<string>("(-75)", "5", "((-70)-8)");
                var v = ov.swizzle.gr;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("(-75)", v.y);
            }
            {
                var ov = new gvec3<string>(null, "", "((9-2)-8)");
                var v = ov.swizzle.grr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("-1", "-4", "((-46)9)");
                var v = ov.swizzle.grrr;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec3<string>("7", "(-2-9)", "(-33)");
                var v = ov.swizzle.grrrr;
                Assert.AreEqual("(-2-9)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("7", v.v);
            }
            {
                var ov = new gvec3<string>("", "", "(-99)");
                var v = ov.swizzle.grrrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("", "((9-9)8)", "((9-9)8)");
                var v = ov.swizzle.grrrb;
                Assert.AreEqual("((9-9)8)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((9-9)8)", v.v);
            }
            {
                var ov = new gvec3<string>("(6-6)", "((-53)-5)", "");
                var v = ov.swizzle.grrg;
                Assert.AreEqual("((-53)-5)", v.x);
                Assert.AreEqual("(6-6)", v.y);
                Assert.AreEqual("(6-6)", v.z);
                Assert.AreEqual("((-53)-5)", v.w);
            }
            {
                var ov = new gvec3<string>("(2-9)", "-9", "-9");
                var v = ov.swizzle.grrgr;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(2-9)", v.y);
                Assert.AreEqual("(2-9)", v.z);
                Assert.AreEqual("-9", v.w);
                Assert.AreEqual("(2-9)", v.v);
            }
            {
                var ov = new gvec3<string>("(81)", "(-22)", "4");
                var v = ov.swizzle.grrgg;
                Assert.AreEqual("(-22)", v.x);
                Assert.AreEqual("(81)", v.y);
                Assert.AreEqual("(81)", v.z);
                Assert.AreEqual("(-22)", v.w);
                Assert.AreEqual("(-22)", v.v);
            }
            {
                var ov = new gvec3<string>("(1-9)", "((-7-4)8)", "");
                var v = ov.swizzle.grrgb;
                Assert.AreEqual("((-7-4)8)", v.x);
                Assert.AreEqual("(1-9)", v.y);
                Assert.AreEqual("(1-9)", v.z);
                Assert.AreEqual("((-7-4)8)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("3", "((-38)9)", null);
                var v = ov.swizzle.grrb;
                Assert.AreEqual("((-38)9)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("((8-5)-8)", "((-10)-1)", "-2");
                var v = ov.swizzle.grrbr;
                Assert.AreEqual("((-10)-1)", v.x);
                Assert.AreEqual("((8-5)-8)", v.y);
                Assert.AreEqual("((8-5)-8)", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("((8-5)-8)", v.v);
            }
            {
                var ov = new gvec3<string>("((82)5)", "((40)-1)", "((82)5)");
                var v = ov.swizzle.grrbg;
                Assert.AreEqual("((40)-1)", v.x);
                Assert.AreEqual("((82)5)", v.y);
                Assert.AreEqual("((82)5)", v.z);
                Assert.AreEqual("((82)5)", v.w);
                Assert.AreEqual("((40)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("((-9-5)7)", "(-18)", "-6");
                var v = ov.swizzle.grrbb;
                Assert.AreEqual("(-18)", v.x);
                Assert.AreEqual("((-9-5)7)", v.y);
                Assert.AreEqual("((-9-5)7)", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("((4-4)5)", "", "(1-8)");
                var v = ov.swizzle.grg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((4-4)5)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("2", "((-4-2)9)", "4");
                var v = ov.swizzle.grgr;
                Assert.AreEqual("((-4-2)9)", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("((-4-2)9)", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec3<string>("-2", "((8-5)2)", "");
                var v = ov.swizzle.grgrr;
                Assert.AreEqual("((8-5)2)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("((8-5)2)", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("(-63)", "-6", "-6");
                var v = ov.swizzle.grgrg;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("(-63)", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("(-63)", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("-3", "-5", "-5");
                var v = ov.swizzle.grgrb;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("-3", v.w);
                Assert.AreEqual("-5", v.v);
            }
            {
                var ov = new gvec3<string>("((8-4)-9)", "", "6");
                var v = ov.swizzle.grgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((8-4)-9)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("-2", "(8-8)", "(7-8)");
                var v = ov.swizzle.grggr;
                Assert.AreEqual("(8-8)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("(8-8)", v.z);
                Assert.AreEqual("(8-8)", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("-4", "-4", "(-51)");
                var v = ov.swizzle.grggg;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("-4", v.v);
            }
            {
                var ov = new gvec3<string>("(46)", "((-1-1)-7)", "((38)-6)");
                var v = ov.swizzle.grggb;
                Assert.AreEqual("((-1-1)-7)", v.x);
                Assert.AreEqual("(46)", v.y);
                Assert.AreEqual("((-1-1)-7)", v.z);
                Assert.AreEqual("((-1-1)-7)", v.w);
                Assert.AreEqual("((38)-6)", v.v);
            }
            {
                var ov = new gvec3<string>("((-9-1)1)", "(7-3)", "(-37)");
                var v = ov.swizzle.grgb;
                Assert.AreEqual("(7-3)", v.x);
                Assert.AreEqual("((-9-1)1)", v.y);
                Assert.AreEqual("(7-3)", v.z);
                Assert.AreEqual("(-37)", v.w);
            }
            {
                var ov = new gvec3<string>(null, null, "-4");
                var v = ov.swizzle.grgbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("9", "((-18)-2)", "(-2-4)");
                var v = ov.swizzle.grgbg;
                Assert.AreEqual("((-18)-2)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("((-18)-2)", v.z);
                Assert.AreEqual("(-2-4)", v.w);
                Assert.AreEqual("((-18)-2)", v.v);
            }
            {
                var ov = new gvec3<string>("0", "0", "((-3-1)0)");
                var v = ov.swizzle.grgbb;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("((-3-1)0)", v.w);
                Assert.AreEqual("((-3-1)0)", v.v);
            }
            {
                var ov = new gvec3<string>("(-48)", "-8", "((41)9)");
                var v = ov.swizzle.grb;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("(-48)", v.y);
                Assert.AreEqual("((41)9)", v.z);
            }
            {
                var ov = new gvec3<string>("2", null, "((-76)7)");
                var v = ov.swizzle.grbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("((-76)7)", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec3<string>("(6-7)", "0", "((7-7)-9)");
                var v = ov.swizzle.grbrr;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("(6-7)", v.y);
                Assert.AreEqual("((7-7)-9)", v.z);
                Assert.AreEqual("(6-7)", v.w);
                Assert.AreEqual("(6-7)", v.v);
            }
            {
                var ov = new gvec3<string>("(87)", "(-33)", "((3-1)-9)");
                var v = ov.swizzle.grbrg;
                Assert.AreEqual("(-33)", v.x);
                Assert.AreEqual("(87)", v.y);
                Assert.AreEqual("((3-1)-9)", v.z);
                Assert.AreEqual("(87)", v.w);
                Assert.AreEqual("(-33)", v.v);
            }
            {
                var ov = new gvec3<string>("-4", "((-3-7)7)", null);
                var v = ov.swizzle.grbrb;
                Assert.AreEqual("((-3-7)7)", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("-1", "((-46)-1)", "0");
                var v = ov.swizzle.grbg;
                Assert.AreEqual("((-46)-1)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("((-46)-1)", v.w);
            }
            {
                var ov = new gvec3<string>("(9-3)", "", "((-20)-3)");
                var v = ov.swizzle.grbgr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(9-3)", v.y);
                Assert.AreEqual("((-20)-3)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("(9-3)", v.v);
            }
            {
                var ov = new gvec3<string>("4", "(-93)", "((-6-2)-9)");
                var v = ov.swizzle.grbgg;
                Assert.AreEqual("(-93)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("((-6-2)-9)", v.z);
                Assert.AreEqual("(-93)", v.w);
                Assert.AreEqual("(-93)", v.v);
            }
            {
                var ov = new gvec3<string>("", "(75)", "(7-7)");
                var v = ov.swizzle.grbgb;
                Assert.AreEqual("(75)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(7-7)", v.z);
                Assert.AreEqual("(75)", v.w);
                Assert.AreEqual("(7-7)", v.v);
            }
            {
                var ov = new gvec3<string>("8", "(-58)", "(-89)");
                var v = ov.swizzle.grbb;
                Assert.AreEqual("(-58)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("(-89)", v.z);
                Assert.AreEqual("(-89)", v.w);
            }
            {
                var ov = new gvec3<string>("((-9-8)-1)", "((-9-8)-1)", "-8");
                var v = ov.swizzle.grbbr;
                Assert.AreEqual("((-9-8)-1)", v.x);
                Assert.AreEqual("((-9-8)-1)", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("-8", v.w);
                Assert.AreEqual("((-9-8)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("(-66)", "(-5-7)", "((-10)-7)");
                var v = ov.swizzle.grbbg;
                Assert.AreEqual("(-5-7)", v.x);
                Assert.AreEqual("(-66)", v.y);
                Assert.AreEqual("((-10)-7)", v.z);
                Assert.AreEqual("((-10)-7)", v.w);
                Assert.AreEqual("(-5-7)", v.v);
            }
            {
                var ov = new gvec3<string>("((19)8)", "1", "((19)8)");
                var v = ov.swizzle.grbbb;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("((19)8)", v.y);
                Assert.AreEqual("((19)8)", v.z);
                Assert.AreEqual("((19)8)", v.w);
                Assert.AreEqual("((19)8)", v.v);
            }
            {
                var ov = new gvec3<string>("(9-5)", "((3-3)7)", "(98)");
                var v = ov.swizzle.gg;
                Assert.AreEqual("((3-3)7)", v.x);
                Assert.AreEqual("((3-3)7)", v.y);
            }
            {
                var ov = new gvec3<string>("((-3-4)-6)", "4", "((1-2)-6)");
                var v = ov.swizzle.ggr;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("((-3-4)-6)", v.z);
            }
            {
                var ov = new gvec3<string>("((78)4)", "2", "((3-8)1)");
                var v = ov.swizzle.ggrr;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("((78)4)", v.z);
                Assert.AreEqual("((78)4)", v.w);
            }
            {
                var ov = new gvec3<string>("-2", "(9-3)", "(21)");
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual("(9-3)", v.x);
                Assert.AreEqual("(9-3)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("(-8-3)", "0", "((-59)-4)");
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("(-8-3)", v.z);
                Assert.AreEqual("(-8-3)", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>(null, "", "-4");
                var v = ov.swizzle.ggrrb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("-4", v.v);
            }
            {
                var ov = new gvec3<string>("(-4-7)", "", "");
                var v = ov.swizzle.ggrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-4-7)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(45)", "((9-4)6)", "((05)-3)");
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual("((9-4)6)", v.x);
                Assert.AreEqual("((9-4)6)", v.y);
                Assert.AreEqual("(45)", v.z);
                Assert.AreEqual("((9-4)6)", v.w);
                Assert.AreEqual("(45)", v.v);
            }
            {
                var ov = new gvec3<string>("(-50)", "(-50)", null);
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual("(-50)", v.x);
                Assert.AreEqual("(-50)", v.y);
                Assert.AreEqual("(-50)", v.z);
                Assert.AreEqual("(-50)", v.w);
                Assert.AreEqual("(-50)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "-8", "(87)");
                var v = ov.swizzle.ggrgb;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-8", v.w);
                Assert.AreEqual("(87)", v.v);
            }
            {
                var ov = new gvec3<string>("-2", "((-2-2)-4)", "(-39)");
                var v = ov.swizzle.ggrb;
                Assert.AreEqual("((-2-2)-4)", v.x);
                Assert.AreEqual("((-2-2)-4)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("(-39)", v.w);
            }
            {
                var ov = new gvec3<string>("8", "", "8");
                var v = ov.swizzle.ggrbr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("8", v.w);
                Assert.AreEqual("8", v.v);
            }
            {
                var ov = new gvec3<string>("", "-9", "((84)-6)");
                var v = ov.swizzle.ggrbg;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((84)-6)", v.w);
                Assert.AreEqual("-9", v.v);
            }
            {
                var ov = new gvec3<string>("-1", "-1", "-1");
                var v = ov.swizzle.ggrbb;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("6", "((-13)8)", "(75)");
                var v = ov.swizzle.ggg;
                Assert.AreEqual("((-13)8)", v.x);
                Assert.AreEqual("((-13)8)", v.y);
                Assert.AreEqual("((-13)8)", v.z);
            }
            {
                var ov = new gvec3<string>("", "7", "6");
                var v = ov.swizzle.gggr;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("", "((20)7)", "");
                var v = ov.swizzle.gggrr;
                Assert.AreEqual("((20)7)", v.x);
                Assert.AreEqual("((20)7)", v.y);
                Assert.AreEqual("((20)7)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>(null, "", "(2-7)");
                var v = ov.swizzle.gggrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(-5-6)", "2", "1");
                var v = ov.swizzle.gggrb;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("(-5-6)", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>("(-4-1)", "(6-7)", "((0-5)5)");
                var v = ov.swizzle.gggg;
                Assert.AreEqual("(6-7)", v.x);
                Assert.AreEqual("(6-7)", v.y);
                Assert.AreEqual("(6-7)", v.z);
                Assert.AreEqual("(6-7)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "", "((-7-5)5)");
                var v = ov.swizzle.ggggr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>(null, null, "((03)-9)");
                var v = ov.swizzle.ggggg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((-76)7)", "-9", "-9");
                var v = ov.swizzle.ggggb;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
                Assert.AreEqual("-9", v.v);
            }
            {
                var ov = new gvec3<string>("4", "(-15)", "((14)5)");
                var v = ov.swizzle.gggb;
                Assert.AreEqual("(-15)", v.x);
                Assert.AreEqual("(-15)", v.y);
                Assert.AreEqual("(-15)", v.z);
                Assert.AreEqual("((14)5)", v.w);
            }
            {
                var ov = new gvec3<string>("0", "((45)4)", null);
                var v = ov.swizzle.gggbr;
                Assert.AreEqual("((45)4)", v.x);
                Assert.AreEqual("((45)4)", v.y);
                Assert.AreEqual("((45)4)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("((89)8)", "", "(-35)");
                var v = ov.swizzle.gggbg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-35)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((-7-4)3)", "(-4-7)");
                var v = ov.swizzle.gggbb;
                Assert.AreEqual("((-7-4)3)", v.x);
                Assert.AreEqual("((-7-4)3)", v.y);
                Assert.AreEqual("((-7-4)3)", v.z);
                Assert.AreEqual("(-4-7)", v.w);
                Assert.AreEqual("(-4-7)", v.v);
            }
            {
                var ov = new gvec3<string>("(1-6)", "(-91)", "((-17)-6)");
                var v = ov.swizzle.ggb;
                Assert.AreEqual("(-91)", v.x);
                Assert.AreEqual("(-91)", v.y);
                Assert.AreEqual("((-17)-6)", v.z);
            }
            {
                var ov = new gvec3<string>(null, "5", "5");
                var v = ov.swizzle.ggbr;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("-6", "(40)", "");
                var v = ov.swizzle.ggbrr;
                Assert.AreEqual("(40)", v.x);
                Assert.AreEqual("(40)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>(null, "", "(9-8)");
                var v = ov.swizzle.ggbrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(9-8)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(-7-5)", "((-74)-7)", "((-8-2)0)");
                var v = ov.swizzle.ggbrb;
                Assert.AreEqual("((-74)-7)", v.x);
                Assert.AreEqual("((-74)-7)", v.y);
                Assert.AreEqual("((-8-2)0)", v.z);
                Assert.AreEqual("(-7-5)", v.w);
                Assert.AreEqual("((-8-2)0)", v.v);
            }
            {
                var ov = new gvec3<string>("(-46)", "-1", "5");
                var v = ov.swizzle.ggbg;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec3<string>("(70)", "4", "2");
                var v = ov.swizzle.ggbgr;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("(70)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(37)", "7");
                var v = ov.swizzle.ggbgg;
                Assert.AreEqual("(37)", v.x);
                Assert.AreEqual("(37)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("(37)", v.w);
                Assert.AreEqual("(37)", v.v);
            }
            {
                var ov = new gvec3<string>("4", "((2-1)0)", "((2-1)0)");
                var v = ov.swizzle.ggbgb;
                Assert.AreEqual("((2-1)0)", v.x);
                Assert.AreEqual("((2-1)0)", v.y);
                Assert.AreEqual("((2-1)0)", v.z);
                Assert.AreEqual("((2-1)0)", v.w);
                Assert.AreEqual("((2-1)0)", v.v);
            }
            {
                var ov = new gvec3<string>("", "", "(-55)");
                var v = ov.swizzle.ggbb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-55)", v.z);
                Assert.AreEqual("(-55)", v.w);
            }
            {
                var ov = new gvec3<string>("((-4-2)-8)", "((-4-2)-8)", "(-1-2)");
                var v = ov.swizzle.ggbbr;
                Assert.AreEqual("((-4-2)-8)", v.x);
                Assert.AreEqual("((-4-2)-8)", v.y);
                Assert.AreEqual("(-1-2)", v.z);
                Assert.AreEqual("(-1-2)", v.w);
                Assert.AreEqual("((-4-2)-8)", v.v);
            }
            {
                var ov = new gvec3<string>("(-75)", "1", "(7-4)");
                var v = ov.swizzle.ggbbg;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("(7-4)", v.z);
                Assert.AreEqual("(7-4)", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>("(5-1)", "-4", null);
                var v = ov.swizzle.ggbbb;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("-8", "0", "7");
                var v = ov.swizzle.gb;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("7", v.y);
            }
            {
                var ov = new gvec3<string>("2", "(6-9)", "(-39)");
                var v = ov.swizzle.gbr;
                Assert.AreEqual("(6-9)", v.x);
                Assert.AreEqual("(-39)", v.y);
                Assert.AreEqual("2", v.z);
            }
            {
                var ov = new gvec3<string>(null, "-6", "((-3-4)0)");
                var v = ov.swizzle.gbrr;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("((-3-4)0)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("", "((-77)-3)", "");
                var v = ov.swizzle.gbrrr;
                Assert.AreEqual("((-77)-3)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(40)", "(-11)", "(-11)");
                var v = ov.swizzle.gbrrg;
                Assert.AreEqual("(-11)", v.x);
                Assert.AreEqual("(-11)", v.y);
                Assert.AreEqual("(40)", v.z);
                Assert.AreEqual("(40)", v.w);
                Assert.AreEqual("(-11)", v.v);
            }
            {
                var ov = new gvec3<string>("((-4-7)3)", "", "((-4-7)3)");
                var v = ov.swizzle.gbrrb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-4-7)3)", v.y);
                Assert.AreEqual("((-4-7)3)", v.z);
                Assert.AreEqual("((-4-7)3)", v.w);
                Assert.AreEqual("((-4-7)3)", v.v);
            }
            {
                var ov = new gvec3<string>("((2-1)-2)", "(-5-5)", "(-5-5)");
                var v = ov.swizzle.gbrg;
                Assert.AreEqual("(-5-5)", v.x);
                Assert.AreEqual("(-5-5)", v.y);
                Assert.AreEqual("((2-1)-2)", v.z);
                Assert.AreEqual("(-5-5)", v.w);
            }
            {
                var ov = new gvec3<string>("((1-1)-7)", "(-1-8)", "7");
                var v = ov.swizzle.gbrgr;
                Assert.AreEqual("(-1-8)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("((1-1)-7)", v.z);
                Assert.AreEqual("(-1-8)", v.w);
                Assert.AreEqual("((1-1)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("1", "", null);
                var v = ov.swizzle.gbrgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(9-8)", "(9-8)", "((88)0)");
                var v = ov.swizzle.gbrgb;
                Assert.AreEqual("(9-8)", v.x);
                Assert.AreEqual("((88)0)", v.y);
                Assert.AreEqual("(9-8)", v.z);
                Assert.AreEqual("(9-8)", v.w);
                Assert.AreEqual("((88)0)", v.v);
            }
            {
                var ov = new gvec3<string>("(67)", null, "(67)");
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(67)", v.y);
                Assert.AreEqual("(67)", v.z);
                Assert.AreEqual("(67)", v.w);
            }
            {
                var ov = new gvec3<string>("-9", "(1-7)", "8");
                var v = ov.swizzle.gbrbr;
                Assert.AreEqual("(1-7)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("8", v.w);
                Assert.AreEqual("-9", v.v);
            }
            {
                var ov = new gvec3<string>("(26)", "-6", "(26)");
                var v = ov.swizzle.gbrbg;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("(26)", v.y);
                Assert.AreEqual("(26)", v.z);
                Assert.AreEqual("(26)", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("0", "((-84)-2)", "((-60)3)");
                var v = ov.swizzle.gbrbb;
                Assert.AreEqual("((-84)-2)", v.x);
                Assert.AreEqual("((-60)3)", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("((-60)3)", v.w);
                Assert.AreEqual("((-60)3)", v.v);
            }
            {
                var ov = new gvec3<string>("((0-4)-8)", "9", "6");
                var v = ov.swizzle.gbg;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("9", v.z);
            }
            {
                var ov = new gvec3<string>("((86)7)", "(-50)", "(-6-9)");
                var v = ov.swizzle.gbgr;
                Assert.AreEqual("(-50)", v.x);
                Assert.AreEqual("(-6-9)", v.y);
                Assert.AreEqual("(-50)", v.z);
                Assert.AreEqual("((86)7)", v.w);
            }
            {
                var ov = new gvec3<string>("((-62)-7)", "-9", "(49)");
                var v = ov.swizzle.gbgrr;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(49)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("((-62)-7)", v.w);
                Assert.AreEqual("((-62)-7)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "", "((-23)6)");
                var v = ov.swizzle.gbgrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-23)6)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((93)-4)", "((93)-4)", "(-24)");
                var v = ov.swizzle.gbgrb;
                Assert.AreEqual("((93)-4)", v.x);
                Assert.AreEqual("(-24)", v.y);
                Assert.AreEqual("((93)-4)", v.z);
                Assert.AreEqual("((93)-4)", v.w);
                Assert.AreEqual("(-24)", v.v);
            }
            {
                var ov = new gvec3<string>(null, null, "-8");
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>(null, "", null);
                var v = ov.swizzle.gbggr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(2-9)", "", "");
                var v = ov.swizzle.gbggg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((40)-8)", "((77)9)", "((75)-3)");
                var v = ov.swizzle.gbggb;
                Assert.AreEqual("((77)9)", v.x);
                Assert.AreEqual("((75)-3)", v.y);
                Assert.AreEqual("((77)9)", v.z);
                Assert.AreEqual("((77)9)", v.w);
                Assert.AreEqual("((75)-3)", v.v);
            }
            {
                var ov = new gvec3<string>("5", "((7-7)3)", "(-5-5)");
                var v = ov.swizzle.gbgb;
                Assert.AreEqual("((7-7)3)", v.x);
                Assert.AreEqual("(-5-5)", v.y);
                Assert.AreEqual("((7-7)3)", v.z);
                Assert.AreEqual("(-5-5)", v.w);
            }
            {
                var ov = new gvec3<string>("((91)5)", "(-15)", null);
                var v = ov.swizzle.gbgbr;
                Assert.AreEqual("(-15)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-15)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((91)5)", v.v);
            }
            {
                var ov = new gvec3<string>("(91)", "((-8-6)9)", "((2-6)2)");
                var v = ov.swizzle.gbgbg;
                Assert.AreEqual("((-8-6)9)", v.x);
                Assert.AreEqual("((2-6)2)", v.y);
                Assert.AreEqual("((-8-6)9)", v.z);
                Assert.AreEqual("((2-6)2)", v.w);
                Assert.AreEqual("((-8-6)9)", v.v);
            }
            {
                var ov = new gvec3<string>("(81)", "-9", "(81)");
                var v = ov.swizzle.gbgbb;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(81)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("(81)", v.w);
                Assert.AreEqual("(81)", v.v);
            }
            {
                var ov = new gvec3<string>("7", "((45)0)", null);
                var v = ov.swizzle.gbb;
                Assert.AreEqual("((45)0)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("-5", "-5", "8");
                var v = ov.swizzle.gbbr;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec3<string>("", "9", "3");
                var v = ov.swizzle.gbbrr;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("", "(1-3)", "((49)-7)");
                var v = ov.swizzle.gbbrg;
                Assert.AreEqual("(1-3)", v.x);
                Assert.AreEqual("((49)-7)", v.y);
                Assert.AreEqual("((49)-7)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("(1-3)", v.v);
            }
            {
                var ov = new gvec3<string>("-4", "-3", "");
                var v = ov.swizzle.gbbrb;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(17)", null, "-7");
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("(-40)", null, "-6");
                var v = ov.swizzle.gbbgr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-40)", v.v);
            }
            {
                var ov = new gvec3<string>("(9-4)", "6", "5");
                var v = ov.swizzle.gbbgg;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec3<string>("((3-5)-9)", "(-73)", null);
                var v = ov.swizzle.gbbgb;
                Assert.AreEqual("(-73)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(-73)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("0", "((-2-8)-6)", "(21)");
                var v = ov.swizzle.gbbb;
                Assert.AreEqual("((-2-8)-6)", v.x);
                Assert.AreEqual("(21)", v.y);
                Assert.AreEqual("(21)", v.z);
                Assert.AreEqual("(21)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(17)", "9");
                var v = ov.swizzle.gbbbr;
                Assert.AreEqual("(17)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("1", "", "(12)");
                var v = ov.swizzle.gbbbg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(12)", v.y);
                Assert.AreEqual("(12)", v.z);
                Assert.AreEqual("(12)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("6", "6", "-1");
                var v = ov.swizzle.gbbbb;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("((-11)5)", "-3", "(-58)");
                var v = ov.swizzle.br;
                Assert.AreEqual("(-58)", v.x);
                Assert.AreEqual("((-11)5)", v.y);
            }
            {
                var ov = new gvec3<string>("((1-1)-9)", null, "((-1-9)-8)");
                var v = ov.swizzle.brr;
                Assert.AreEqual("((-1-9)-8)", v.x);
                Assert.AreEqual("((1-1)-9)", v.y);
                Assert.AreEqual("((1-1)-9)", v.z);
            }
            {
                var ov = new gvec3<string>("(-4-3)", "(-4-3)", "(-12)");
                var v = ov.swizzle.brrr;
                Assert.AreEqual("(-12)", v.x);
                Assert.AreEqual("(-4-3)", v.y);
                Assert.AreEqual("(-4-3)", v.z);
                Assert.AreEqual("(-4-3)", v.w);
            }
            {
                var ov = new gvec3<string>("-7", "(-52)", "((62)2)");
                var v = ov.swizzle.brrrr;
                Assert.AreEqual("((62)2)", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-7", v.w);
                Assert.AreEqual("-7", v.v);
            }
            {
                var ov = new gvec3<string>("(9-9)", "((-87)-9)", "0");
                var v = ov.swizzle.brrrg;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("(9-9)", v.y);
                Assert.AreEqual("(9-9)", v.z);
                Assert.AreEqual("(9-9)", v.w);
                Assert.AreEqual("((-87)-9)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((-69)-7)", "0");
                var v = ov.swizzle.brrrb;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("", "-2", "-1");
                var v = ov.swizzle.brrg;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec3<string>("((-8-7)8)", "-5", "-1");
                var v = ov.swizzle.brrgr;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("((-8-7)8)", v.y);
                Assert.AreEqual("((-8-7)8)", v.z);
                Assert.AreEqual("-5", v.w);
                Assert.AreEqual("((-8-7)8)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "-5", null);
                var v = ov.swizzle.brrgg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-5", v.w);
                Assert.AreEqual("-5", v.v);
            }
            {
                var ov = new gvec3<string>("-2", "-2", "-3");
                var v = ov.swizzle.brrgb;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("-3", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((07)-4)", "((25)8)");
                var v = ov.swizzle.brrb;
                Assert.AreEqual("((25)8)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((25)8)", v.w);
            }
            {
                var ov = new gvec3<string>("((-7-8)6)", null, "-1");
                var v = ov.swizzle.brrbr;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("((-7-8)6)", v.y);
                Assert.AreEqual("((-7-8)6)", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("((-7-8)6)", v.v);
            }
            {
                var ov = new gvec3<string>("(-26)", "-5", "((10)-3)");
                var v = ov.swizzle.brrbg;
                Assert.AreEqual("((10)-3)", v.x);
                Assert.AreEqual("(-26)", v.y);
                Assert.AreEqual("(-26)", v.z);
                Assert.AreEqual("((10)-3)", v.w);
                Assert.AreEqual("-5", v.v);
            }
            {
                var ov = new gvec3<string>("", "((88)-4)", "((20)-3)");
                var v = ov.swizzle.brrbb;
                Assert.AreEqual("((20)-3)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((20)-3)", v.w);
                Assert.AreEqual("((20)-3)", v.v);
            }
            {
                var ov = new gvec3<string>("6", "(8-2)", "1");
                var v = ov.swizzle.brg;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("(8-2)", v.z);
            }
            {
                var ov = new gvec3<string>("(-47)", "(9-6)", "-9");
                var v = ov.swizzle.brgr;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(-47)", v.y);
                Assert.AreEqual("(9-6)", v.z);
                Assert.AreEqual("(-47)", v.w);
            }
            {
                var ov = new gvec3<string>("", null, "((-37)9)");
                var v = ov.swizzle.brgrr;
                Assert.AreEqual("((-37)9)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("", "((-91)-3)", "((-38)-9)");
                var v = ov.swizzle.brgrg;
                Assert.AreEqual("((-38)-9)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-91)-3)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((-91)-3)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(-6-6)", "(-9-4)");
                var v = ov.swizzle.brgrb;
                Assert.AreEqual("(-9-4)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-6-6)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-9-4)", v.v);
            }
            {
                var ov = new gvec3<string>("(-67)", "((-1-4)4)", "(-67)");
                var v = ov.swizzle.brgg;
                Assert.AreEqual("(-67)", v.x);
                Assert.AreEqual("(-67)", v.y);
                Assert.AreEqual("((-1-4)4)", v.z);
                Assert.AreEqual("((-1-4)4)", v.w);
            }
            {
                var ov = new gvec3<string>("((-70)2)", "7", "7");
                var v = ov.swizzle.brggr;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("((-70)2)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("((-70)2)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "", "-4");
                var v = ov.swizzle.brggg;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((17)3)", "-6", "-2");
                var v = ov.swizzle.brggb;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("((17)3)", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("((7-7)1)", "-1", "((7-7)1)");
                var v = ov.swizzle.brgb;
                Assert.AreEqual("((7-7)1)", v.x);
                Assert.AreEqual("((7-7)1)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("((7-7)1)", v.w);
            }
            {
                var ov = new gvec3<string>("-9", "(-11)", "1");
                var v = ov.swizzle.brgbr;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("(-11)", v.z);
                Assert.AreEqual("1", v.w);
                Assert.AreEqual("-9", v.v);
            }
            {
                var ov = new gvec3<string>("", "((93)4)", "((95)0)");
                var v = ov.swizzle.brgbg;
                Assert.AreEqual("((95)0)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((93)4)", v.z);
                Assert.AreEqual("((95)0)", v.w);
                Assert.AreEqual("((93)4)", v.v);
            }
            {
                var ov = new gvec3<string>("((68)-9)", "(3-2)", "((09)-2)");
                var v = ov.swizzle.brgbb;
                Assert.AreEqual("((09)-2)", v.x);
                Assert.AreEqual("((68)-9)", v.y);
                Assert.AreEqual("(3-2)", v.z);
                Assert.AreEqual("((09)-2)", v.w);
                Assert.AreEqual("((09)-2)", v.v);
            }
            {
                var ov = new gvec3<string>("((80)-3)", "(1-5)", "((80)-3)");
                var v = ov.swizzle.brb;
                Assert.AreEqual("((80)-3)", v.x);
                Assert.AreEqual("((80)-3)", v.y);
                Assert.AreEqual("((80)-3)", v.z);
            }
            {
                var ov = new gvec3<string>("(9-6)", "-8", "(3-4)");
                var v = ov.swizzle.brbr;
                Assert.AreEqual("(3-4)", v.x);
                Assert.AreEqual("(9-6)", v.y);
                Assert.AreEqual("(3-4)", v.z);
                Assert.AreEqual("(9-6)", v.w);
            }
            {
                var ov = new gvec3<string>("1", "((08)-6)", "3");
                var v = ov.swizzle.brbrr;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("1", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec3<string>(null, "-5", null);
                var v = ov.swizzle.brbrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("-5", v.v);
            }
            {
                var ov = new gvec3<string>("(-9-7)", "", "((-3-3)6)");
                var v = ov.swizzle.brbrb;
                Assert.AreEqual("((-3-3)6)", v.x);
                Assert.AreEqual("(-9-7)", v.y);
                Assert.AreEqual("((-3-3)6)", v.z);
                Assert.AreEqual("(-9-7)", v.w);
                Assert.AreEqual("((-3-3)6)", v.v);
            }
            {
                var ov = new gvec3<string>("-8", "((-93)1)", "-8");
                var v = ov.swizzle.brbg;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("((-93)1)", v.w);
            }
            {
                var ov = new gvec3<string>("((7-1)-7)", "((-7-9)-9)", "-4");
                var v = ov.swizzle.brbgr;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("((7-1)-7)", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("((-7-9)-9)", v.w);
                Assert.AreEqual("((7-1)-7)", v.v);
            }
            {
                var ov = new gvec3<string>("", "-6", "-6");
                var v = ov.swizzle.brbgg;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>(null, null, "(-71)");
                var v = ov.swizzle.brbgb;
                Assert.AreEqual("(-71)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-71)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(-71)", v.v);
            }
            {
                var ov = new gvec3<string>("(-1-5)", "", "");
                var v = ov.swizzle.brbb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-1-5)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("-6", "(-9-5)", null);
                var v = ov.swizzle.brbbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("-6", v.v);
            }
            {
                var ov = new gvec3<string>("((-68)-9)", "(58)", null);
                var v = ov.swizzle.brbbg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-68)-9)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(58)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((-27)-3)", "((-9-2)-2)");
                var v = ov.swizzle.brbbb;
                Assert.AreEqual("((-9-2)-2)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-9-2)-2)", v.z);
                Assert.AreEqual("((-9-2)-2)", v.w);
                Assert.AreEqual("((-9-2)-2)", v.v);
            }
            {
                var ov = new gvec3<string>("((1-1)-2)", null, "9");
                var v = ov.swizzle.bg;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual(null, v.y);
            }
            {
                var ov = new gvec3<string>("", "((3-5)0)", "((1-2)6)");
                var v = ov.swizzle.bgr;
                Assert.AreEqual("((1-2)6)", v.x);
                Assert.AreEqual("((3-5)0)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("((99)-9)", "((-22)-8)", "(-9-3)");
                var v = ov.swizzle.bgrr;
                Assert.AreEqual("(-9-3)", v.x);
                Assert.AreEqual("((-22)-8)", v.y);
                Assert.AreEqual("((99)-9)", v.z);
                Assert.AreEqual("((99)-9)", v.w);
            }
            {
                var ov = new gvec3<string>("(-1-1)", null, "-4");
                var v = ov.swizzle.bgrrr;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-1-1)", v.z);
                Assert.AreEqual("(-1-1)", v.w);
                Assert.AreEqual("(-1-1)", v.v);
            }
            {
                var ov = new gvec3<string>("(-73)", null, "((97)6)");
                var v = ov.swizzle.bgrrg;
                Assert.AreEqual("((97)6)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-73)", v.z);
                Assert.AreEqual("(-73)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("(-6-8)", null, "(-21)");
                var v = ov.swizzle.bgrrb;
                Assert.AreEqual("(-21)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-6-8)", v.z);
                Assert.AreEqual("(-6-8)", v.w);
                Assert.AreEqual("(-21)", v.v);
            }
            {
                var ov = new gvec3<string>("((-2-3)-8)", "(5-5)", "((-2-3)-8)");
                var v = ov.swizzle.bgrg;
                Assert.AreEqual("((-2-3)-8)", v.x);
                Assert.AreEqual("(5-5)", v.y);
                Assert.AreEqual("((-2-3)-8)", v.z);
                Assert.AreEqual("(5-5)", v.w);
            }
            {
                var ov = new gvec3<string>(null, null, null);
                var v = ov.swizzle.bgrgr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("((83)5)", "0", "");
                var v = ov.swizzle.bgrgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("((83)5)", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("3", "-3", "((-27)-1)");
                var v = ov.swizzle.bgrgb;
                Assert.AreEqual("((-27)-1)", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("-3", v.w);
                Assert.AreEqual("((-27)-1)", v.v);
            }
            {
                var ov = new gvec3<string>("-1", "(61)", "(9-1)");
                var v = ov.swizzle.bgrb;
                Assert.AreEqual("(9-1)", v.x);
                Assert.AreEqual("(61)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("(9-1)", v.w);
            }
            {
                var ov = new gvec3<string>("", null, "((-72)1)");
                var v = ov.swizzle.bgrbr;
                Assert.AreEqual("((-72)1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-72)1)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("(3-2)", "((-40)2)", "((-40)2)");
                var v = ov.swizzle.bgrbg;
                Assert.AreEqual("((-40)2)", v.x);
                Assert.AreEqual("((-40)2)", v.y);
                Assert.AreEqual("(3-2)", v.z);
                Assert.AreEqual("((-40)2)", v.w);
                Assert.AreEqual("((-40)2)", v.v);
            }
            {
                var ov = new gvec3<string>("(27)", "-5", "(27)");
                var v = ov.swizzle.bgrbb;
                Assert.AreEqual("(27)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(27)", v.z);
                Assert.AreEqual("(27)", v.w);
                Assert.AreEqual("(27)", v.v);
            }
            {
                var ov = new gvec3<string>("((89)-9)", "(-47)", "-3");
                var v = ov.swizzle.bgg;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("(-47)", v.y);
                Assert.AreEqual("(-47)", v.z);
            }
            {
                var ov = new gvec3<string>("((-65)-4)", "(-7-9)", "((4-1)3)");
                var v = ov.swizzle.bggr;
                Assert.AreEqual("((4-1)3)", v.x);
                Assert.AreEqual("(-7-9)", v.y);
                Assert.AreEqual("(-7-9)", v.z);
                Assert.AreEqual("((-65)-4)", v.w);
            }
            {
                var ov = new gvec3<string>("-1", "((-47)-8)", "(-36)");
                var v = ov.swizzle.bggrr;
                Assert.AreEqual("(-36)", v.x);
                Assert.AreEqual("((-47)-8)", v.y);
                Assert.AreEqual("((-47)-8)", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec3<string>("((0-7)7)", "(-56)", "((39)-9)");
                var v = ov.swizzle.bggrg;
                Assert.AreEqual("((39)-9)", v.x);
                Assert.AreEqual("(-56)", v.y);
                Assert.AreEqual("(-56)", v.z);
                Assert.AreEqual("((0-7)7)", v.w);
                Assert.AreEqual("(-56)", v.v);
            }
            {
                var ov = new gvec3<string>("((7-4)-8)", "-2", "((3-6)-2)");
                var v = ov.swizzle.bggrb;
                Assert.AreEqual("((3-6)-2)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("((7-4)-8)", v.w);
                Assert.AreEqual("((3-6)-2)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((-9-5)-6)", "((-87)-7)");
                var v = ov.swizzle.bggg;
                Assert.AreEqual("((-87)-7)", v.x);
                Assert.AreEqual("((-9-5)-6)", v.y);
                Assert.AreEqual("((-9-5)-6)", v.z);
                Assert.AreEqual("((-9-5)-6)", v.w);
            }
            {
                var ov = new gvec3<string>("", "-4", "(-70)");
                var v = ov.swizzle.bgggr;
                Assert.AreEqual("(-70)", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((3-3)-1)", "(-30)", "((1-3)-5)");
                var v = ov.swizzle.bgggg;
                Assert.AreEqual("((1-3)-5)", v.x);
                Assert.AreEqual("(-30)", v.y);
                Assert.AreEqual("(-30)", v.z);
                Assert.AreEqual("(-30)", v.w);
                Assert.AreEqual("(-30)", v.v);
            }
            {
                var ov = new gvec3<string>("((39)-4)", "0", "3");
                var v = ov.swizzle.bgggb;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("3", v.v);
            }
            {
                var ov = new gvec3<string>(null, "((8-7)3)", "((12)1)");
                var v = ov.swizzle.bggb;
                Assert.AreEqual("((12)1)", v.x);
                Assert.AreEqual("((8-7)3)", v.y);
                Assert.AreEqual("((8-7)3)", v.z);
                Assert.AreEqual("((12)1)", v.w);
            }
            {
                var ov = new gvec3<string>("(3-6)", "(2-1)", null);
                var v = ov.swizzle.bggbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(2-1)", v.y);
                Assert.AreEqual("(2-1)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(3-6)", v.v);
            }
            {
                var ov = new gvec3<string>("", "-5", "((-68)7)");
                var v = ov.swizzle.bggbg;
                Assert.AreEqual("((-68)7)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("((-68)7)", v.w);
                Assert.AreEqual("-5", v.v);
            }
            {
                var ov = new gvec3<string>(null, "-5", "7");
                var v = ov.swizzle.bggbb;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("7", v.v);
            }
            {
                var ov = new gvec3<string>("((3-4)-2)", "1", "(1-2)");
                var v = ov.swizzle.bgb;
                Assert.AreEqual("(1-2)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("(1-2)", v.z);
            }
            {
                var ov = new gvec3<string>("(-4-8)", "(6-2)", "-7");
                var v = ov.swizzle.bgbr;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(6-2)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("(-4-8)", v.w);
            }
            {
                var ov = new gvec3<string>("((05)0)", "1", "((-11)-4)");
                var v = ov.swizzle.bgbrr;
                Assert.AreEqual("((-11)-4)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("((-11)-4)", v.z);
                Assert.AreEqual("((05)0)", v.w);
                Assert.AreEqual("((05)0)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "(4-7)", null);
                var v = ov.swizzle.bgbrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(4-7)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("(4-7)", v.v);
            }
            {
                var ov = new gvec3<string>("(53)", "-9", "((-87)-2)");
                var v = ov.swizzle.bgbrb;
                Assert.AreEqual("((-87)-2)", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("((-87)-2)", v.z);
                Assert.AreEqual("(53)", v.w);
                Assert.AreEqual("((-87)-2)", v.v);
            }
            {
                var ov = new gvec3<string>("5", "5", "(11)");
                var v = ov.swizzle.bgbg;
                Assert.AreEqual("(11)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("(11)", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec3<string>("((-19)4)", "((-28)6)", "2");
                var v = ov.swizzle.bgbgr;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("((-28)6)", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("((-28)6)", v.w);
                Assert.AreEqual("((-19)4)", v.v);
            }
            {
                var ov = new gvec3<string>("((25)-9)", "(13)", "((01)-9)");
                var v = ov.swizzle.bgbgg;
                Assert.AreEqual("((01)-9)", v.x);
                Assert.AreEqual("(13)", v.y);
                Assert.AreEqual("((01)-9)", v.z);
                Assert.AreEqual("(13)", v.w);
                Assert.AreEqual("(13)", v.v);
            }
            {
                var ov = new gvec3<string>("7", "(0-5)", "(59)");
                var v = ov.swizzle.bgbgb;
                Assert.AreEqual("(59)", v.x);
                Assert.AreEqual("(0-5)", v.y);
                Assert.AreEqual("(59)", v.z);
                Assert.AreEqual("(0-5)", v.w);
                Assert.AreEqual("(59)", v.v);
            }
            {
                var ov = new gvec3<string>("-8", "(-17)", null);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-17)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>(null, "-5", "(2-5)");
                var v = ov.swizzle.bgbbr;
                Assert.AreEqual("(2-5)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(2-5)", v.z);
                Assert.AreEqual("(2-5)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("", "7", "-1");
                var v = ov.swizzle.bgbbg;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("7", v.v);
            }
            {
                var ov = new gvec3<string>("(37)", null, null);
                var v = ov.swizzle.bgbbb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>(null, "((-2-8)-3)", "((-41)-1)");
                var v = ov.swizzle.bb;
                Assert.AreEqual("((-41)-1)", v.x);
                Assert.AreEqual("((-41)-1)", v.y);
            }
            {
                var ov = new gvec3<string>("(-66)", null, null);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-66)", v.z);
            }
            {
                var ov = new gvec3<string>("", "((-91)-4)", "-3");
                var v = ov.swizzle.bbrr;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((-23)-4)", "(30)", "(-1-3)");
                var v = ov.swizzle.bbrrr;
                Assert.AreEqual("(-1-3)", v.x);
                Assert.AreEqual("(-1-3)", v.y);
                Assert.AreEqual("((-23)-4)", v.z);
                Assert.AreEqual("((-23)-4)", v.w);
                Assert.AreEqual("((-23)-4)", v.v);
            }
            {
                var ov = new gvec3<string>(null, "-8", "5");
                var v = ov.swizzle.bbrrg;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("-8", v.v);
            }
            {
                var ov = new gvec3<string>("((7-9)-2)", "((7-9)-2)", "(-1-4)");
                var v = ov.swizzle.bbrrb;
                Assert.AreEqual("(-1-4)", v.x);
                Assert.AreEqual("(-1-4)", v.y);
                Assert.AreEqual("((7-9)-2)", v.z);
                Assert.AreEqual("((7-9)-2)", v.w);
                Assert.AreEqual("(-1-4)", v.v);
            }
            {
                var ov = new gvec3<string>("((-5-3)-1)", null, null);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-5-3)-1)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("(26)", "((-39)4)", "(-97)");
                var v = ov.swizzle.bbrgr;
                Assert.AreEqual("(-97)", v.x);
                Assert.AreEqual("(-97)", v.y);
                Assert.AreEqual("(26)", v.z);
                Assert.AreEqual("((-39)4)", v.w);
                Assert.AreEqual("(26)", v.v);
            }
            {
                var ov = new gvec3<string>("-7", "((01)-9)", "((75)-8)");
                var v = ov.swizzle.bbrgg;
                Assert.AreEqual("((75)-8)", v.x);
                Assert.AreEqual("((75)-8)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("((01)-9)", v.w);
                Assert.AreEqual("((01)-9)", v.v);
            }
            {
                var ov = new gvec3<string>("((-20)-4)", "(9-1)", "-7");
                var v = ov.swizzle.bbrgb;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("((-20)-4)", v.z);
                Assert.AreEqual("(9-1)", v.w);
                Assert.AreEqual("-7", v.v);
            }
            {
                var ov = new gvec3<string>("7", "((80)3)", null);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("8", "8", "4");
                var v = ov.swizzle.bbrbr;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("8", v.v);
            }
            {
                var ov = new gvec3<string>("((4-5)-7)", "-3", "");
                var v = ov.swizzle.bbrbg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((4-5)-7)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("-3", v.v);
            }
            {
                var ov = new gvec3<string>("-6", "(9-9)", null);
                var v = ov.swizzle.bbrbb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("", null, "((5-3)5)");
                var v = ov.swizzle.bbg;
                Assert.AreEqual("((5-3)5)", v.x);
                Assert.AreEqual("((5-3)5)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("-7", "2", "2");
                var v = ov.swizzle.bbgr;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec3<string>("((87)9)", "", "((87)9)");
                var v = ov.swizzle.bbgrr;
                Assert.AreEqual("((87)9)", v.x);
                Assert.AreEqual("((87)9)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((87)9)", v.w);
                Assert.AreEqual("((87)9)", v.v);
            }
            {
                var ov = new gvec3<string>("(0-2)", "(-1-3)", "((-9-8)-2)");
                var v = ov.swizzle.bbgrg;
                Assert.AreEqual("((-9-8)-2)", v.x);
                Assert.AreEqual("((-9-8)-2)", v.y);
                Assert.AreEqual("(-1-3)", v.z);
                Assert.AreEqual("(0-2)", v.w);
                Assert.AreEqual("(-1-3)", v.v);
            }
            {
                var ov = new gvec3<string>("((7-6)-3)", "(-11)", "((71)-8)");
                var v = ov.swizzle.bbgrb;
                Assert.AreEqual("((71)-8)", v.x);
                Assert.AreEqual("((71)-8)", v.y);
                Assert.AreEqual("(-11)", v.z);
                Assert.AreEqual("((7-6)-3)", v.w);
                Assert.AreEqual("((71)-8)", v.v);
            }
            {
                var ov = new gvec3<string>("((5-8)-8)", "((87)5)", "");
                var v = ov.swizzle.bbgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((87)5)", v.z);
                Assert.AreEqual("((87)5)", v.w);
            }
            {
                var ov = new gvec3<string>("(9-6)", "", "-4");
                var v = ov.swizzle.bbggr;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("(9-6)", v.v);
            }
            {
                var ov = new gvec3<string>("-5", "((-9-4)-6)", "0");
                var v = ov.swizzle.bbggg;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("((-9-4)-6)", v.z);
                Assert.AreEqual("((-9-4)-6)", v.w);
                Assert.AreEqual("((-9-4)-6)", v.v);
            }
            {
                var ov = new gvec3<string>("((0-4)-7)", "((-63)-1)", "((73)6)");
                var v = ov.swizzle.bbggb;
                Assert.AreEqual("((73)6)", v.x);
                Assert.AreEqual("((73)6)", v.y);
                Assert.AreEqual("((-63)-1)", v.z);
                Assert.AreEqual("((-63)-1)", v.w);
                Assert.AreEqual("((73)6)", v.v);
            }
            {
                var ov = new gvec3<string>("((-26)2)", "((4-1)3)", "(71)");
                var v = ov.swizzle.bbgb;
                Assert.AreEqual("(71)", v.x);
                Assert.AreEqual("(71)", v.y);
                Assert.AreEqual("((4-1)3)", v.z);
                Assert.AreEqual("(71)", v.w);
            }
            {
                var ov = new gvec3<string>("", "((96)5)", "((96)5)");
                var v = ov.swizzle.bbgbr;
                Assert.AreEqual("((96)5)", v.x);
                Assert.AreEqual("((96)5)", v.y);
                Assert.AreEqual("((96)5)", v.z);
                Assert.AreEqual("((96)5)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("((6-9)-5)", "0", "9");
                var v = ov.swizzle.bbgbg;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("9", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec3<string>("2", "((80)6)", "2");
                var v = ov.swizzle.bbgbb;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("((80)6)", v.z);
                Assert.AreEqual("2", v.w);
                Assert.AreEqual("2", v.v);
            }
            {
                var ov = new gvec3<string>("(8-6)", "(0-4)", "-6");
                var v = ov.swizzle.bbb;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
            }
            {
                var ov = new gvec3<string>("(-8-9)", null, "4");
                var v = ov.swizzle.bbbr;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("(-8-9)", v.w);
            }
            {
                var ov = new gvec3<string>("-5", null, null);
                var v = ov.swizzle.bbbrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-5", v.w);
                Assert.AreEqual("-5", v.v);
            }
            {
                var ov = new gvec3<string>("(-6-8)", null, "((04)0)");
                var v = ov.swizzle.bbbrg;
                Assert.AreEqual("((04)0)", v.x);
                Assert.AreEqual("((04)0)", v.y);
                Assert.AreEqual("((04)0)", v.z);
                Assert.AreEqual("(-6-8)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec3<string>("", "((09)-1)", "3");
                var v = ov.swizzle.bbbrb;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("3", v.v);
            }
            {
                var ov = new gvec3<string>("((-20)-9)", "", "-2");
                var v = ov.swizzle.bbbg;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((-11)0)", null, "((-13)-2)");
                var v = ov.swizzle.bbbgr;
                Assert.AreEqual("((-13)-2)", v.x);
                Assert.AreEqual("((-13)-2)", v.y);
                Assert.AreEqual("((-13)-2)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual("((-11)0)", v.v);
            }
            {
                var ov = new gvec3<string>("", "((11)0)", "((53)-8)");
                var v = ov.swizzle.bbbgg;
                Assert.AreEqual("((53)-8)", v.x);
                Assert.AreEqual("((53)-8)", v.y);
                Assert.AreEqual("((53)-8)", v.z);
                Assert.AreEqual("((11)0)", v.w);
                Assert.AreEqual("((11)0)", v.v);
            }
            {
                var ov = new gvec3<string>("((79)-9)", "-2", "-2");
                var v = ov.swizzle.bbbgb;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec3<string>("((-14)-2)", "((-7-4)3)", "1");
                var v = ov.swizzle.bbbb;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec3<string>("", "(-8-3)", "((3-9)-3)");
                var v = ov.swizzle.bbbbr;
                Assert.AreEqual("((3-9)-3)", v.x);
                Assert.AreEqual("((3-9)-3)", v.y);
                Assert.AreEqual("((3-9)-3)", v.z);
                Assert.AreEqual("((3-9)-3)", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec3<string>("-3", "9", "(-1-5)");
                var v = ov.swizzle.bbbbg;
                Assert.AreEqual("(-1-5)", v.x);
                Assert.AreEqual("(-1-5)", v.y);
                Assert.AreEqual("(-1-5)", v.z);
                Assert.AreEqual("(-1-5)", v.w);
                Assert.AreEqual("9", v.v);
            }
            {
                var ov = new gvec3<string>("(70)", "9", "((9-9)-4)");
                var v = ov.swizzle.bbbbb;
                Assert.AreEqual("((9-9)-4)", v.x);
                Assert.AreEqual("((9-9)-4)", v.y);
                Assert.AreEqual("((9-9)-4)", v.z);
                Assert.AreEqual("((9-9)-4)", v.w);
                Assert.AreEqual("((9-9)-4)", v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new gvec3<string>("((9-8)-1)", "0", "((3-1)1)");
                var v1 = new gvec2<string>("((-42)1)", "-1");
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-42)1)", v0.x);
                Assert.AreEqual("-1", v0.y);
                Assert.AreEqual("((3-1)1)", v0.z);
            
                Assert.AreEqual("((9-8)-1)", v2.x);
                Assert.AreEqual("0", v2.y);
            }
            {
                var v0 = new gvec3<string>("(96)", null, "(93)");
                var v1 = new gvec2<string>("", "((9-3)-2)");
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("", v0.x);
                Assert.AreEqual(null, v0.y);
                Assert.AreEqual("((9-3)-2)", v0.z);
            
                Assert.AreEqual("(96)", v2.x);
                Assert.AreEqual("(93)", v2.y);
            }
            {
                var v0 = new gvec3<string>("(-3-1)", "((93)-2)", "((0-1)1)");
                var v1 = new gvec2<string>("1", null);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-3-1)", v0.x);
                Assert.AreEqual("1", v0.y);
                Assert.AreEqual(null, v0.z);
            
                Assert.AreEqual("((93)-2)", v2.x);
                Assert.AreEqual("((0-1)1)", v2.y);
            }
            {
                var v0 = new gvec3<string>("3", "(8-7)", "-2");
                var v1 = new gvec3<string>("(-7-1)", "", "((-20)8)");
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-7-1)", v0.x);
                Assert.AreEqual("", v0.y);
                Assert.AreEqual("((-20)8)", v0.z);
            
                Assert.AreEqual("3", v2.x);
                Assert.AreEqual("(8-7)", v2.y);
                Assert.AreEqual("-2", v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new gvec3<string>("9", "((-3-2)4)", "-2");
                var v1 = "((-1-4)5)";
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-1-4)5)", v0.x);
                Assert.AreEqual("((-3-2)4)", v0.y);
                Assert.AreEqual("-2", v0.z);
            
                Assert.AreEqual("9", v2);
            }
            {
                var v0 = new gvec3<string>("5", "(-25)", null);
                var v1 = "2";
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("5", v0.x);
                Assert.AreEqual("2", v0.y);
                Assert.AreEqual(null, v0.z);
            
                Assert.AreEqual("(-25)", v2);
            }
            {
                var v0 = new gvec3<string>("(-6-3)", "((57)3)", "(2-5)");
                var v1 = new gvec2<string>(null, "-7");
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(null, v0.x);
                Assert.AreEqual("-7", v0.y);
                Assert.AreEqual("(2-5)", v0.z);
            
                Assert.AreEqual("(-6-3)", v2.x);
                Assert.AreEqual("((57)3)", v2.y);
            }
            {
                var v0 = new gvec3<string>(null, "(68)", "-4");
                var v1 = "((-17)-5)";
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(null, v0.x);
                Assert.AreEqual("(68)", v0.y);
                Assert.AreEqual("((-17)-5)", v0.z);
            
                Assert.AreEqual("-4", v2);
            }
            {
                var v0 = new gvec3<string>(null, "(-52)", "(-5-9)");
                var v1 = new gvec2<string>("((-16)-6)", "(08)");
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-16)-6)", v0.x);
                Assert.AreEqual("(-52)", v0.y);
                Assert.AreEqual("(08)", v0.z);
            
                Assert.AreEqual(null, v2.x);
                Assert.AreEqual("(-5-9)", v2.y);
            }
            {
                var v0 = new gvec3<string>("((0-1)6)", "-1", null);
                var v1 = new gvec2<string>("(-1-2)", "8");
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((0-1)6)", v0.x);
                Assert.AreEqual("(-1-2)", v0.y);
                Assert.AreEqual("8", v0.z);
            
                Assert.AreEqual("-1", v2.x);
                Assert.AreEqual(null, v2.y);
            }
            {
                var v0 = new gvec3<string>("((-84)-8)", "((-97)0)", "(-4-8)");
                var v1 = new gvec3<string>("(-1-4)", "-8", "(-88)");
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-1-4)", v0.x);
                Assert.AreEqual("-8", v0.y);
                Assert.AreEqual("(-88)", v0.z);
            
                Assert.AreEqual("((-84)-8)", v2.x);
                Assert.AreEqual("((-97)0)", v2.y);
                Assert.AreEqual("(-4-8)", v2.z);
            }
        }

    }
}
