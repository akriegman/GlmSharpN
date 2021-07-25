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
    public class BoolVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new bvec5(true);
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(true, v.v);
            }
            {
                var v = new bvec5(false, false, false, true, false);
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var v = new bvec5(new bvec2(false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var v = new bvec5(new bvec3(true, true, false));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var v = new bvec5(new bvec4(false, true, false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
            {
                var v = new bvec5(new bvec5(false, true, true, false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
                Assert.AreEqual(false, v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new bvec5(true, false, false, true, true);
            Assert.AreEqual(true, v[0]);
            Assert.AreEqual(false, v[1]);
            Assert.AreEqual(false, v[2]);
            Assert.AreEqual(true, v[3]);
            Assert.AreEqual(true, v[4]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = false; } );
            
            v[0] = false;
            Assert.AreEqual(false, v[0]);
            v[3] = true;
            Assert.AreEqual(true, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new bvec5(false, true, true, true, false);
            var vals = v.Values;
            Assert.AreEqual(false, vals[0]);
            Assert.AreEqual(true, vals[1]);
            Assert.AreEqual(true, vals[2]);
            Assert.AreEqual(true, vals[3]);
            Assert.AreEqual(false, vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(false, bvec5.Zero.x);
            Assert.AreEqual(false, bvec5.Zero.y);
            Assert.AreEqual(false, bvec5.Zero.z);
            Assert.AreEqual(false, bvec5.Zero.w);
            Assert.AreEqual(false, bvec5.Zero.v);
            
            Assert.AreEqual(true, bvec5.Ones.x);
            Assert.AreEqual(true, bvec5.Ones.y);
            Assert.AreEqual(true, bvec5.Ones.z);
            Assert.AreEqual(true, bvec5.Ones.w);
            Assert.AreEqual(true, bvec5.Ones.v);
            
            Assert.AreEqual(true, bvec5.UnitX.x);
            Assert.AreEqual(false, bvec5.UnitX.y);
            Assert.AreEqual(false, bvec5.UnitX.z);
            Assert.AreEqual(false, bvec5.UnitX.w);
            Assert.AreEqual(false, bvec5.UnitX.v);
            
            Assert.AreEqual(false, bvec5.UnitY.x);
            Assert.AreEqual(true, bvec5.UnitY.y);
            Assert.AreEqual(false, bvec5.UnitY.z);
            Assert.AreEqual(false, bvec5.UnitY.w);
            Assert.AreEqual(false, bvec5.UnitY.v);
            
            Assert.AreEqual(false, bvec5.UnitZ.x);
            Assert.AreEqual(false, bvec5.UnitZ.y);
            Assert.AreEqual(true, bvec5.UnitZ.z);
            Assert.AreEqual(false, bvec5.UnitZ.w);
            Assert.AreEqual(false, bvec5.UnitZ.v);
            
            Assert.AreEqual(false, bvec5.UnitW.x);
            Assert.AreEqual(false, bvec5.UnitW.y);
            Assert.AreEqual(false, bvec5.UnitW.z);
            Assert.AreEqual(true, bvec5.UnitW.w);
            Assert.AreEqual(false, bvec5.UnitW.v);
            
            Assert.AreEqual(false, bvec5.UnitV.x);
            Assert.AreEqual(false, bvec5.UnitV.y);
            Assert.AreEqual(false, bvec5.UnitV.z);
            Assert.AreEqual(false, bvec5.UnitV.w);
            Assert.AreEqual(true, bvec5.UnitV.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new bvec5(true, false, false, false, false);
            var v2 = new bvec5(true, false, false, false, false);
            var v3 = new bvec5(false, false, false, false, true);
            Assert.That(v1 == new bvec5(v1));
            Assert.That(v2 == new bvec5(v2));
            Assert.That(v3 == new bvec5(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new bvec5(false, true, false, false, false);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = bvec5.Parse(s0);
            var v1 = bvec5.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = bvec5.TryParse(s0, out v0);
            var b1 = bvec5.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = bvec5.TryParse(null, out v0);
            Assert.False(b0);
            b0 = bvec5.TryParse("", out v0);
            Assert.False(b0);
            b0 = bvec5.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { bvec5.Parse(null); });
            Assert.Throws<FormatException>(() => { bvec5.Parse(""); });
            Assert.Throws<FormatException>(() => { bvec5.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new bvec5(false, true, false, false, true);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<bvec5>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
