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
    public class TSwizzleVec2Test
    {

        [Test]
        public void xyzwvuts()
        {
            {
                var ov = new gvec2<string>("4", "(5-7)");
                var v = ov.swizzle.xx;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
            }
            {
                var ov = new gvec2<string>("(-82)", "((-4-9)-8)");
                var v = ov.swizzle.xxx;
                Assert.AreEqual("(-82)", v.x);
                Assert.AreEqual("(-82)", v.y);
                Assert.AreEqual("(-82)", v.z);
            }
            {
                var ov = new gvec2<string>("-4", "((-16)6)");
                var v = ov.swizzle.xxxx;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-4", v.w);
            }
            {
                var ov = new gvec2<string>(null, "");
                var v = ov.swizzle.xxxxx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec2<string>("", "8");
                var v = ov.swizzle.xxxxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("8", v.v);
            }
            {
                var ov = new gvec2<string>("(9-2)", "");
                var v = ov.swizzle.xxxy;
                Assert.AreEqual("(9-2)", v.x);
                Assert.AreEqual("(9-2)", v.y);
                Assert.AreEqual("(9-2)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec2<string>("-1", "((-5-1)-3)");
                var v = ov.swizzle.xxxyx;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("((-5-1)-3)", v.w);
                Assert.AreEqual("-1", v.v);
            }
            {
                var ov = new gvec2<string>("-4", "((-9-2)4)");
                var v = ov.swizzle.xxxyy;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("((-9-2)4)", v.w);
                Assert.AreEqual("((-9-2)4)", v.v);
            }
            {
                var ov = new gvec2<string>("1", "-8");
                var v = ov.swizzle.xxy;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("-8", v.z);
            }
            {
                var ov = new gvec2<string>("((17)-2)", "((-82)-3)");
                var v = ov.swizzle.xxyx;
                Assert.AreEqual("((17)-2)", v.x);
                Assert.AreEqual("((17)-2)", v.y);
                Assert.AreEqual("((-82)-3)", v.z);
                Assert.AreEqual("((17)-2)", v.w);
            }
            {
                var ov = new gvec2<string>("0", "(78)");
                var v = ov.swizzle.xxyxx;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("(78)", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec2<string>("(-50)", "(-2-5)");
                var v = ov.swizzle.xxyxy;
                Assert.AreEqual("(-50)", v.x);
                Assert.AreEqual("(-50)", v.y);
                Assert.AreEqual("(-2-5)", v.z);
                Assert.AreEqual("(-50)", v.w);
                Assert.AreEqual("(-2-5)", v.v);
            }
            {
                var ov = new gvec2<string>("-7", "((26)-2)");
                var v = ov.swizzle.xxyy;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("((26)-2)", v.z);
                Assert.AreEqual("((26)-2)", v.w);
            }
            {
                var ov = new gvec2<string>("((5-4)-6)", "((90)1)");
                var v = ov.swizzle.xxyyx;
                Assert.AreEqual("((5-4)-6)", v.x);
                Assert.AreEqual("((5-4)-6)", v.y);
                Assert.AreEqual("((90)1)", v.z);
                Assert.AreEqual("((90)1)", v.w);
                Assert.AreEqual("((5-4)-6)", v.v);
            }
            {
                var ov = new gvec2<string>(null, "(78)");
                var v = ov.swizzle.xxyyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(78)", v.z);
                Assert.AreEqual("(78)", v.w);
                Assert.AreEqual("(78)", v.v);
            }
            {
                var ov = new gvec2<string>("6", "((6-6)2)");
                var v = ov.swizzle.xy;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("((6-6)2)", v.y);
            }
            {
                var ov = new gvec2<string>("5", "(-7-2)");
                var v = ov.swizzle.xyx;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("(-7-2)", v.y);
                Assert.AreEqual("5", v.z);
            }
            {
                var ov = new gvec2<string>("((-6-8)-7)", "");
                var v = ov.swizzle.xyxx;
                Assert.AreEqual("((-6-8)-7)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-6-8)-7)", v.z);
                Assert.AreEqual("((-6-8)-7)", v.w);
            }
            {
                var ov = new gvec2<string>("(-74)", "6");
                var v = ov.swizzle.xyxxx;
                Assert.AreEqual("(-74)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("(-74)", v.z);
                Assert.AreEqual("(-74)", v.w);
                Assert.AreEqual("(-74)", v.v);
            }
            {
                var ov = new gvec2<string>("((-9-1)-7)", "((-9-1)-7)");
                var v = ov.swizzle.xyxxy;
                Assert.AreEqual("((-9-1)-7)", v.x);
                Assert.AreEqual("((-9-1)-7)", v.y);
                Assert.AreEqual("((-9-1)-7)", v.z);
                Assert.AreEqual("((-9-1)-7)", v.w);
                Assert.AreEqual("((-9-1)-7)", v.v);
            }
            {
                var ov = new gvec2<string>("(-25)", "0");
                var v = ov.swizzle.xyxy;
                Assert.AreEqual("(-25)", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("(-25)", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec2<string>("-2", "(-8-4)");
                var v = ov.swizzle.xyxyx;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("(-8-4)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("(-8-4)", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec2<string>("-7", "(-87)");
                var v = ov.swizzle.xyxyy;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(-87)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("(-87)", v.w);
                Assert.AreEqual("(-87)", v.v);
            }
            {
                var ov = new gvec2<string>("((6-6)2)", "((7-1)4)");
                var v = ov.swizzle.xyy;
                Assert.AreEqual("((6-6)2)", v.x);
                Assert.AreEqual("((7-1)4)", v.y);
                Assert.AreEqual("((7-1)4)", v.z);
            }
            {
                var ov = new gvec2<string>("6", "(-4-1)");
                var v = ov.swizzle.xyyx;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("(-4-1)", v.y);
                Assert.AreEqual("(-4-1)", v.z);
                Assert.AreEqual("6", v.w);
            }
            {
                var ov = new gvec2<string>("0", null);
                var v = ov.swizzle.xyyxx;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var ov = new gvec2<string>("-7", "((-5-7)-5)");
                var v = ov.swizzle.xyyxy;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((-5-7)-5)", v.y);
                Assert.AreEqual("((-5-7)-5)", v.z);
                Assert.AreEqual("-7", v.w);
                Assert.AreEqual("((-5-7)-5)", v.v);
            }
            {
                var ov = new gvec2<string>("(38)", "((17)-1)");
                var v = ov.swizzle.xyyy;
                Assert.AreEqual("(38)", v.x);
                Assert.AreEqual("((17)-1)", v.y);
                Assert.AreEqual("((17)-1)", v.z);
                Assert.AreEqual("((17)-1)", v.w);
            }
            {
                var ov = new gvec2<string>("6", "(6-3)");
                var v = ov.swizzle.xyyyx;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("(6-3)", v.y);
                Assert.AreEqual("(6-3)", v.z);
                Assert.AreEqual("(6-3)", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec2<string>("((-9-5)7)", "(85)");
                var v = ov.swizzle.xyyyy;
                Assert.AreEqual("((-9-5)7)", v.x);
                Assert.AreEqual("(85)", v.y);
                Assert.AreEqual("(85)", v.z);
                Assert.AreEqual("(85)", v.w);
                Assert.AreEqual("(85)", v.v);
            }
            {
                var ov = new gvec2<string>("(1-2)", "4");
                var v = ov.swizzle.yx;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("(1-2)", v.y);
            }
            {
                var ov = new gvec2<string>("-2", "((8-2)2)");
                var v = ov.swizzle.yxx;
                Assert.AreEqual("((8-2)2)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("-2", v.z);
            }
            {
                var ov = new gvec2<string>("(-5-2)", "(-5-2)");
                var v = ov.swizzle.yxxx;
                Assert.AreEqual("(-5-2)", v.x);
                Assert.AreEqual("(-5-2)", v.y);
                Assert.AreEqual("(-5-2)", v.z);
                Assert.AreEqual("(-5-2)", v.w);
            }
            {
                var ov = new gvec2<string>("(7-6)", "8");
                var v = ov.swizzle.yxxxx;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("(7-6)", v.y);
                Assert.AreEqual("(7-6)", v.z);
                Assert.AreEqual("(7-6)", v.w);
                Assert.AreEqual("(7-6)", v.v);
            }
            {
                var ov = new gvec2<string>("(-26)", "((-87)-7)");
                var v = ov.swizzle.yxxxy;
                Assert.AreEqual("((-87)-7)", v.x);
                Assert.AreEqual("(-26)", v.y);
                Assert.AreEqual("(-26)", v.z);
                Assert.AreEqual("(-26)", v.w);
                Assert.AreEqual("((-87)-7)", v.v);
            }
            {
                var ov = new gvec2<string>("-6", "((41)1)");
                var v = ov.swizzle.yxxy;
                Assert.AreEqual("((41)1)", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("((41)1)", v.w);
            }
            {
                var ov = new gvec2<string>("6", "(95)");
                var v = ov.swizzle.yxxyx;
                Assert.AreEqual("(95)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("(95)", v.w);
                Assert.AreEqual("6", v.v);
            }
            {
                var ov = new gvec2<string>("9", "1");
                var v = ov.swizzle.yxxyy;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("1", v.w);
                Assert.AreEqual("1", v.v);
            }
            {
                var ov = new gvec2<string>("((-2-9)7)", "");
                var v = ov.swizzle.yxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-2-9)7)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec2<string>("7", "(0-3)");
                var v = ov.swizzle.yxyx;
                Assert.AreEqual("(0-3)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("(0-3)", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec2<string>("(18)", "");
                var v = ov.swizzle.yxyxx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(18)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(18)", v.w);
                Assert.AreEqual("(18)", v.v);
            }
            {
                var ov = new gvec2<string>("5", "");
                var v = ov.swizzle.yxyxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("5", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec2<string>("8", null);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec2<string>("(-44)", "((-47)5)");
                var v = ov.swizzle.yxyyx;
                Assert.AreEqual("((-47)5)", v.x);
                Assert.AreEqual("(-44)", v.y);
                Assert.AreEqual("((-47)5)", v.z);
                Assert.AreEqual("((-47)5)", v.w);
                Assert.AreEqual("(-44)", v.v);
            }
            {
                var ov = new gvec2<string>("(38)", "(19)");
                var v = ov.swizzle.yxyyy;
                Assert.AreEqual("(19)", v.x);
                Assert.AreEqual("(38)", v.y);
                Assert.AreEqual("(19)", v.z);
                Assert.AreEqual("(19)", v.w);
                Assert.AreEqual("(19)", v.v);
            }
            {
                var ov = new gvec2<string>("((-27)-4)", "2");
                var v = ov.swizzle.yy;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
            }
            {
                var ov = new gvec2<string>("-2", null);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-2", v.z);
            }
            {
                var ov = new gvec2<string>("-4", "((-7-3)0)");
                var v = ov.swizzle.yyxx;
                Assert.AreEqual("((-7-3)0)", v.x);
                Assert.AreEqual("((-7-3)0)", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-4", v.w);
            }
            {
                var ov = new gvec2<string>("(-88)", "-5");
                var v = ov.swizzle.yyxxx;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(-88)", v.z);
                Assert.AreEqual("(-88)", v.w);
                Assert.AreEqual("(-88)", v.v);
            }
            {
                var ov = new gvec2<string>("-6", "");
                var v = ov.swizzle.yyxxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec2<string>("", "((95)3)");
                var v = ov.swizzle.yyxy;
                Assert.AreEqual("((95)3)", v.x);
                Assert.AreEqual("((95)3)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((95)3)", v.w);
            }
            {
                var ov = new gvec2<string>("((60)1)", "0");
                var v = ov.swizzle.yyxyx;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("((60)1)", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("((60)1)", v.v);
            }
            {
                var ov = new gvec2<string>("(-43)", "((9-9)0)");
                var v = ov.swizzle.yyxyy;
                Assert.AreEqual("((9-9)0)", v.x);
                Assert.AreEqual("((9-9)0)", v.y);
                Assert.AreEqual("(-43)", v.z);
                Assert.AreEqual("((9-9)0)", v.w);
                Assert.AreEqual("((9-9)0)", v.v);
            }
            {
                var ov = new gvec2<string>("", "(-7-6)");
                var v = ov.swizzle.yyy;
                Assert.AreEqual("(-7-6)", v.x);
                Assert.AreEqual("(-7-6)", v.y);
                Assert.AreEqual("(-7-6)", v.z);
            }
            {
                var ov = new gvec2<string>("((7-6)0)", "(10)");
                var v = ov.swizzle.yyyx;
                Assert.AreEqual("(10)", v.x);
                Assert.AreEqual("(10)", v.y);
                Assert.AreEqual("(10)", v.z);
                Assert.AreEqual("((7-6)0)", v.w);
            }
            {
                var ov = new gvec2<string>("((43)9)", "((43)9)");
                var v = ov.swizzle.yyyxx;
                Assert.AreEqual("((43)9)", v.x);
                Assert.AreEqual("((43)9)", v.y);
                Assert.AreEqual("((43)9)", v.z);
                Assert.AreEqual("((43)9)", v.w);
                Assert.AreEqual("((43)9)", v.v);
            }
            {
                var ov = new gvec2<string>("(27)", "(-21)");
                var v = ov.swizzle.yyyxy;
                Assert.AreEqual("(-21)", v.x);
                Assert.AreEqual("(-21)", v.y);
                Assert.AreEqual("(-21)", v.z);
                Assert.AreEqual("(27)", v.w);
                Assert.AreEqual("(-21)", v.v);
            }
            {
                var ov = new gvec2<string>("-8", "9");
                var v = ov.swizzle.yyyy;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec2<string>("(4-3)", "8");
                var v = ov.swizzle.yyyyx;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("8", v.w);
                Assert.AreEqual("(4-3)", v.v);
            }
            {
                var ov = new gvec2<string>("8", "(-70)");
                var v = ov.swizzle.yyyyy;
                Assert.AreEqual("(-70)", v.x);
                Assert.AreEqual("(-70)", v.y);
                Assert.AreEqual("(-70)", v.z);
                Assert.AreEqual("(-70)", v.w);
                Assert.AreEqual("(-70)", v.v);
            }
        }

        [Test]
        public void rgbaklpq()
        {
            {
                var ov = new gvec2<string>("(-99)", "");
                var v = ov.swizzle.rr;
                Assert.AreEqual("(-99)", v.x);
                Assert.AreEqual("(-99)", v.y);
            }
            {
                var ov = new gvec2<string>("", "(62)");
                var v = ov.swizzle.rrr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec2<string>("", null);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec2<string>("((1-7)-6)", "((-18)3)");
                var v = ov.swizzle.rrrrr;
                Assert.AreEqual("((1-7)-6)", v.x);
                Assert.AreEqual("((1-7)-6)", v.y);
                Assert.AreEqual("((1-7)-6)", v.z);
                Assert.AreEqual("((1-7)-6)", v.w);
                Assert.AreEqual("((1-7)-6)", v.v);
            }
            {
                var ov = new gvec2<string>("5", "-9");
                var v = ov.swizzle.rrrrg;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("5", v.w);
                Assert.AreEqual("-9", v.v);
            }
            {
                var ov = new gvec2<string>("((-56)-2)", "((-56)-2)");
                var v = ov.swizzle.rrrg;
                Assert.AreEqual("((-56)-2)", v.x);
                Assert.AreEqual("((-56)-2)", v.y);
                Assert.AreEqual("((-56)-2)", v.z);
                Assert.AreEqual("((-56)-2)", v.w);
            }
            {
                var ov = new gvec2<string>("((-5-7)2)", "7");
                var v = ov.swizzle.rrrgr;
                Assert.AreEqual("((-5-7)2)", v.x);
                Assert.AreEqual("((-5-7)2)", v.y);
                Assert.AreEqual("((-5-7)2)", v.z);
                Assert.AreEqual("7", v.w);
                Assert.AreEqual("((-5-7)2)", v.v);
            }
            {
                var ov = new gvec2<string>("(0-2)", "((-62)-9)");
                var v = ov.swizzle.rrrgg;
                Assert.AreEqual("(0-2)", v.x);
                Assert.AreEqual("(0-2)", v.y);
                Assert.AreEqual("(0-2)", v.z);
                Assert.AreEqual("((-62)-9)", v.w);
                Assert.AreEqual("((-62)-9)", v.v);
            }
            {
                var ov = new gvec2<string>("(-87)", "5");
                var v = ov.swizzle.rrg;
                Assert.AreEqual("(-87)", v.x);
                Assert.AreEqual("(-87)", v.y);
                Assert.AreEqual("5", v.z);
            }
            {
                var ov = new gvec2<string>("-6", "((-47)-7)");
                var v = ov.swizzle.rrgr;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("((-47)-7)", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec2<string>(null, "((-57)-2)");
                var v = ov.swizzle.rrgrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-57)-2)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var ov = new gvec2<string>("(4-9)", "3");
                var v = ov.swizzle.rrgrg;
                Assert.AreEqual("(4-9)", v.x);
                Assert.AreEqual("(4-9)", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("(4-9)", v.w);
                Assert.AreEqual("3", v.v);
            }
            {
                var ov = new gvec2<string>("((-7-9)0)", "((-7-9)0)");
                var v = ov.swizzle.rrgg;
                Assert.AreEqual("((-7-9)0)", v.x);
                Assert.AreEqual("((-7-9)0)", v.y);
                Assert.AreEqual("((-7-9)0)", v.z);
                Assert.AreEqual("((-7-9)0)", v.w);
            }
            {
                var ov = new gvec2<string>("(4-8)", "((-49)5)");
                var v = ov.swizzle.rrggr;
                Assert.AreEqual("(4-8)", v.x);
                Assert.AreEqual("(4-8)", v.y);
                Assert.AreEqual("((-49)5)", v.z);
                Assert.AreEqual("((-49)5)", v.w);
                Assert.AreEqual("(4-8)", v.v);
            }
            {
                var ov = new gvec2<string>("((6-6)-9)", "(-99)");
                var v = ov.swizzle.rrggg;
                Assert.AreEqual("((6-6)-9)", v.x);
                Assert.AreEqual("((6-6)-9)", v.y);
                Assert.AreEqual("(-99)", v.z);
                Assert.AreEqual("(-99)", v.w);
                Assert.AreEqual("(-99)", v.v);
            }
            {
                var ov = new gvec2<string>("((0-8)3)", "1");
                var v = ov.swizzle.rg;
                Assert.AreEqual("((0-8)3)", v.x);
                Assert.AreEqual("1", v.y);
            }
            {
                var ov = new gvec2<string>("(0-5)", "(-72)");
                var v = ov.swizzle.rgr;
                Assert.AreEqual("(0-5)", v.x);
                Assert.AreEqual("(-72)", v.y);
                Assert.AreEqual("(0-5)", v.z);
            }
            {
                var ov = new gvec2<string>("9", null);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec2<string>("(0-5)", "(60)");
                var v = ov.swizzle.rgrrr;
                Assert.AreEqual("(0-5)", v.x);
                Assert.AreEqual("(60)", v.y);
                Assert.AreEqual("(0-5)", v.z);
                Assert.AreEqual("(0-5)", v.w);
                Assert.AreEqual("(0-5)", v.v);
            }
            {
                var ov = new gvec2<string>("(96)", "((76)8)");
                var v = ov.swizzle.rgrrg;
                Assert.AreEqual("(96)", v.x);
                Assert.AreEqual("((76)8)", v.y);
                Assert.AreEqual("(96)", v.z);
                Assert.AreEqual("(96)", v.w);
                Assert.AreEqual("((76)8)", v.v);
            }
            {
                var ov = new gvec2<string>("", "((95)-4)");
                var v = ov.swizzle.rgrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((95)-4)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((95)-4)", v.w);
            }
            {
                var ov = new gvec2<string>("2", "-4");
                var v = ov.swizzle.rgrgr;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("2", v.v);
            }
            {
                var ov = new gvec2<string>("((06)-7)", "");
                var v = ov.swizzle.rgrgg;
                Assert.AreEqual("((06)-7)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((06)-7)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec2<string>(null, null);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec2<string>("1", "");
                var v = ov.swizzle.rggr;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec2<string>("((-37)-7)", "((10)-4)");
                var v = ov.swizzle.rggrr;
                Assert.AreEqual("((-37)-7)", v.x);
                Assert.AreEqual("((10)-4)", v.y);
                Assert.AreEqual("((10)-4)", v.z);
                Assert.AreEqual("((-37)-7)", v.w);
                Assert.AreEqual("((-37)-7)", v.v);
            }
            {
                var ov = new gvec2<string>("6", "");
                var v = ov.swizzle.rggrg;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec2<string>("((-2-9)-3)", "((96)4)");
                var v = ov.swizzle.rggg;
                Assert.AreEqual("((-2-9)-3)", v.x);
                Assert.AreEqual("((96)4)", v.y);
                Assert.AreEqual("((96)4)", v.z);
                Assert.AreEqual("((96)4)", v.w);
            }
            {
                var ov = new gvec2<string>("(09)", "6");
                var v = ov.swizzle.rgggr;
                Assert.AreEqual("(09)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("6", v.w);
                Assert.AreEqual("(09)", v.v);
            }
            {
                var ov = new gvec2<string>("(92)", "((-9-5)5)");
                var v = ov.swizzle.rgggg;
                Assert.AreEqual("(92)", v.x);
                Assert.AreEqual("((-9-5)5)", v.y);
                Assert.AreEqual("((-9-5)5)", v.z);
                Assert.AreEqual("((-9-5)5)", v.w);
                Assert.AreEqual("((-9-5)5)", v.v);
            }
            {
                var ov = new gvec2<string>(null, "(8-6)");
                var v = ov.swizzle.gr;
                Assert.AreEqual("(8-6)", v.x);
                Assert.AreEqual(null, v.y);
            }
            {
                var ov = new gvec2<string>("(1-8)", "((-14)9)");
                var v = ov.swizzle.grr;
                Assert.AreEqual("((-14)9)", v.x);
                Assert.AreEqual("(1-8)", v.y);
                Assert.AreEqual("(1-8)", v.z);
            }
            {
                var ov = new gvec2<string>("((-8-3)6)", "(-48)");
                var v = ov.swizzle.grrr;
                Assert.AreEqual("(-48)", v.x);
                Assert.AreEqual("((-8-3)6)", v.y);
                Assert.AreEqual("((-8-3)6)", v.z);
                Assert.AreEqual("((-8-3)6)", v.w);
            }
            {
                var ov = new gvec2<string>("(17)", null);
                var v = ov.swizzle.grrrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(17)", v.y);
                Assert.AreEqual("(17)", v.z);
                Assert.AreEqual("(17)", v.w);
                Assert.AreEqual("(17)", v.v);
            }
            {
                var ov = new gvec2<string>("-1", "((-78)8)");
                var v = ov.swizzle.grrrg;
                Assert.AreEqual("((-78)8)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
                Assert.AreEqual("((-78)8)", v.v);
            }
            {
                var ov = new gvec2<string>(null, "");
                var v = ov.swizzle.grrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec2<string>("(-87)", "-4");
                var v = ov.swizzle.grrgr;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("(-87)", v.y);
                Assert.AreEqual("(-87)", v.z);
                Assert.AreEqual("-4", v.w);
                Assert.AreEqual("(-87)", v.v);
            }
            {
                var ov = new gvec2<string>("", "(-70)");
                var v = ov.swizzle.grrgg;
                Assert.AreEqual("(-70)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-70)", v.w);
                Assert.AreEqual("(-70)", v.v);
            }
            {
                var ov = new gvec2<string>("-2", "-2");
                var v = ov.swizzle.grg;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("-2", v.z);
            }
            {
                var ov = new gvec2<string>("-1", "(1-3)");
                var v = ov.swizzle.grgr;
                Assert.AreEqual("(1-3)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("(1-3)", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec2<string>("-2", null);
                var v = ov.swizzle.grgrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-2", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec2<string>("4", "-2");
                var v = ov.swizzle.grgrg;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("4", v.w);
                Assert.AreEqual("-2", v.v);
            }
            {
                var ov = new gvec2<string>("((-6-3)-9)", "");
                var v = ov.swizzle.grgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-6-3)-9)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec2<string>("((-92)5)", "((90)3)");
                var v = ov.swizzle.grggr;
                Assert.AreEqual("((90)3)", v.x);
                Assert.AreEqual("((-92)5)", v.y);
                Assert.AreEqual("((90)3)", v.z);
                Assert.AreEqual("((90)3)", v.w);
                Assert.AreEqual("((-92)5)", v.v);
            }
            {
                var ov = new gvec2<string>("((-61)6)", "((-61)6)");
                var v = ov.swizzle.grggg;
                Assert.AreEqual("((-61)6)", v.x);
                Assert.AreEqual("((-61)6)", v.y);
                Assert.AreEqual("((-61)6)", v.z);
                Assert.AreEqual("((-61)6)", v.w);
                Assert.AreEqual("((-61)6)", v.v);
            }
            {
                var ov = new gvec2<string>(null, "(-4-4)");
                var v = ov.swizzle.gg;
                Assert.AreEqual("(-4-4)", v.x);
                Assert.AreEqual("(-4-4)", v.y);
            }
            {
                var ov = new gvec2<string>("((-15)9)", "(-7-3)");
                var v = ov.swizzle.ggr;
                Assert.AreEqual("(-7-3)", v.x);
                Assert.AreEqual("(-7-3)", v.y);
                Assert.AreEqual("((-15)9)", v.z);
            }
            {
                var ov = new gvec2<string>("", "");
                var v = ov.swizzle.ggrr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec2<string>("((26)-2)", "-3");
                var v = ov.swizzle.ggrrr;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("((26)-2)", v.z);
                Assert.AreEqual("((26)-2)", v.w);
                Assert.AreEqual("((26)-2)", v.v);
            }
            {
                var ov = new gvec2<string>("((50)5)", "7");
                var v = ov.swizzle.ggrrg;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("((50)5)", v.z);
                Assert.AreEqual("((50)5)", v.w);
                Assert.AreEqual("7", v.v);
            }
            {
                var ov = new gvec2<string>("", null);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec2<string>("((16)-6)", "((-8-4)8)");
                var v = ov.swizzle.ggrgr;
                Assert.AreEqual("((-8-4)8)", v.x);
                Assert.AreEqual("((-8-4)8)", v.y);
                Assert.AreEqual("((16)-6)", v.z);
                Assert.AreEqual("((-8-4)8)", v.w);
                Assert.AreEqual("((16)-6)", v.v);
            }
            {
                var ov = new gvec2<string>(null, "");
                var v = ov.swizzle.ggrgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("", v.v);
            }
            {
                var ov = new gvec2<string>("4", "(-75)");
                var v = ov.swizzle.ggg;
                Assert.AreEqual("(-75)", v.x);
                Assert.AreEqual("(-75)", v.y);
                Assert.AreEqual("(-75)", v.z);
            }
            {
                var ov = new gvec2<string>("(-5-8)", "-8");
                var v = ov.swizzle.gggr;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("(-5-8)", v.w);
            }
            {
                var ov = new gvec2<string>("((89)-1)", "-7");
                var v = ov.swizzle.gggrr;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("((89)-1)", v.w);
                Assert.AreEqual("((89)-1)", v.v);
            }
            {
                var ov = new gvec2<string>("", "((22)-1)");
                var v = ov.swizzle.gggrg;
                Assert.AreEqual("((22)-1)", v.x);
                Assert.AreEqual("((22)-1)", v.y);
                Assert.AreEqual("((22)-1)", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((22)-1)", v.v);
            }
            {
                var ov = new gvec2<string>("((-6-9)9)", "((-6-9)9)");
                var v = ov.swizzle.gggg;
                Assert.AreEqual("((-6-9)9)", v.x);
                Assert.AreEqual("((-6-9)9)", v.y);
                Assert.AreEqual("((-6-9)9)", v.z);
                Assert.AreEqual("((-6-9)9)", v.w);
            }
            {
                var ov = new gvec2<string>("((-6-3)6)", "");
                var v = ov.swizzle.ggggr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
                Assert.AreEqual("((-6-3)6)", v.v);
            }
            {
                var ov = new gvec2<string>("", "((-65)-9)");
                var v = ov.swizzle.ggggg;
                Assert.AreEqual("((-65)-9)", v.x);
                Assert.AreEqual("((-65)-9)", v.y);
                Assert.AreEqual("((-65)-9)", v.z);
                Assert.AreEqual("((-65)-9)", v.w);
                Assert.AreEqual("((-65)-9)", v.v);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new gvec2<string>("-3", "(60)");
                var v1 = new gvec2<string>("", null);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("", v0.x);
                Assert.AreEqual(null, v0.y);
            
                Assert.AreEqual("-3", v2.x);
                Assert.AreEqual("(60)", v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new gvec2<string>(null, null);
                var v1 = "8";
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("8", v0.x);
                Assert.AreEqual(null, v0.y);
            
                Assert.AreEqual(null, v2);
            }
            {
                var v0 = new gvec2<string>("(-82)", "(-97)");
                var v1 = "(37)";
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-82)", v0.x);
                Assert.AreEqual("(37)", v0.y);
            
                Assert.AreEqual("(-97)", v2);
            }
            {
                var v0 = new gvec2<string>("(-90)", "-1");
                var v1 = new gvec2<string>("(-2-6)", null);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-2-6)", v0.x);
                Assert.AreEqual(null, v0.y);
            
                Assert.AreEqual("(-90)", v2.x);
                Assert.AreEqual("-1", v2.y);
            }
        }

    }
}
