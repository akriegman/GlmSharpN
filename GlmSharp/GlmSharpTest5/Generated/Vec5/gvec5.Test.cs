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

namespace GlmSharpTest.Generated.Vec5
{
    [TestFixture]
    public class TVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new gvec5<string>("0");
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("0", v.w);
                Assert.AreEqual("0", v.v);
            }
            {
                var v = new gvec5<string>("-2", "9", "", "9", null);
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("9", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var v = new gvec5<string>(new gvec2<string>("-4", "((56)-9)"));
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("((56)-9)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var v = new gvec5<string>(new gvec3<string>("(1-1)", "(1-1)", "((-49)1)"));
                Assert.AreEqual("(1-1)", v.x);
                Assert.AreEqual("(1-1)", v.y);
                Assert.AreEqual("((-49)1)", v.z);
                Assert.AreEqual(null, v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var v = new gvec5<string>(new gvec4<string>("7", "((7-3)-7)", "", "(0-2)"));
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("((7-3)-7)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(0-2)", v.w);
                Assert.AreEqual(null, v.v);
            }
            {
                var v = new gvec5<string>(new gvec5<string>("-7", "(68)", "(-6-8)", "(-23)", "(68)"));
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(68)", v.y);
                Assert.AreEqual("(-6-8)", v.z);
                Assert.AreEqual("(-23)", v.w);
                Assert.AreEqual("(68)", v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new gvec5<string>(null, "((-3-5)3)", "", "(-97)", "((6-1)7)");
            Assert.AreEqual(null, v[0]);
            Assert.AreEqual("((-3-5)3)", v[1]);
            Assert.AreEqual("", v[2]);
            Assert.AreEqual("(-97)", v[3]);
            Assert.AreEqual("((6-1)7)", v[4]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = null; } );
            
            v[3] = null;
            Assert.AreEqual(null, v[3]);
            v[4] = "";
            Assert.AreEqual("", v[4]);
            v[3] = "0";
            Assert.AreEqual("0", v[3]);
            v[2] = "(9-1)";
            Assert.AreEqual("(9-1)", v[2]);
            v[2] = "((9-6)2)";
            Assert.AreEqual("((9-6)2)", v[2]);
            v[0] = "1";
            Assert.AreEqual("1", v[0]);
            v[1] = "(6-4)";
            Assert.AreEqual("(6-4)", v[1]);
            v[2] = "((-73)2)";
            Assert.AreEqual("((-73)2)", v[2]);
            v[1] = "0";
            Assert.AreEqual("0", v[1]);
            v[1] = "(-6-7)";
            Assert.AreEqual("(-6-7)", v[1]);
            v[4] = "((-76)5)";
            Assert.AreEqual("((-76)5)", v[4]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new gvec5<string>("(-30)", "(12)", "", "7", "(12)");
            var vals = v.Values;
            Assert.AreEqual("(-30)", vals[0]);
            Assert.AreEqual("(12)", vals[1]);
            Assert.AreEqual("", vals[2]);
            Assert.AreEqual("7", vals[3]);
            Assert.AreEqual("(12)", vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(null, gvec5<string>.Zero.x);
            Assert.AreEqual(null, gvec5<string>.Zero.y);
            Assert.AreEqual(null, gvec5<string>.Zero.z);
            Assert.AreEqual(null, gvec5<string>.Zero.w);
            Assert.AreEqual(null, gvec5<string>.Zero.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new gvec5<string>("", "8", "(08)", "8", null);
            var v2 = new gvec5<string>("", "8", "(08)", "8", null);
            var v3 = new gvec5<string>(null, "8", "(08)", "8", "");
            Assert.That(v1 == new gvec5<string>(v1));
            Assert.That(v2 == new gvec5<string>(v2));
            Assert.That(v3 == new gvec5<string>(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new gvec5<string>(null, "((-62)-4)", "(87)", "(87)", "5");
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new gvec5<string>("((3-5)-2)", "(9-7)", "7", null, "-7");
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<gvec5<string>>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
