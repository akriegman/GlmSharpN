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
    public class DecimalVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec5(1.5m);
                Assert.AreEqual(1.5m, v.x);
                Assert.AreEqual(1.5m, v.y);
                Assert.AreEqual(1.5m, v.z);
                Assert.AreEqual(1.5m, v.w);
                Assert.AreEqual(1.5m, v.v);
            }
            {
                var v = new decvec5(-2.5m, 8.5m, -5.5m, 5m, 0m);
                Assert.AreEqual(-2.5m, v.x);
                Assert.AreEqual(8.5m, v.y);
                Assert.AreEqual(-5.5m, v.z);
                Assert.AreEqual(5m, v.w);
                Assert.AreEqual(0m, v.v);
            }
            {
                var v = new decvec5(new decvec2(4m, 0m));
                Assert.AreEqual(4m, v.x);
                Assert.AreEqual(0m, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(0m, v.w);
                Assert.AreEqual(0m, v.v);
            }
            {
                var v = new decvec5(new decvec3(3.5m, 9m, 0m));
                Assert.AreEqual(3.5m, v.x);
                Assert.AreEqual(9m, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(0m, v.w);
                Assert.AreEqual(0m, v.v);
            }
            {
                var v = new decvec5(new decvec4(-1.5m, 9.5m, 9m, -7m));
                Assert.AreEqual(-1.5m, v.x);
                Assert.AreEqual(9.5m, v.y);
                Assert.AreEqual(9m, v.z);
                Assert.AreEqual(-7m, v.w);
                Assert.AreEqual(0m, v.v);
            }
            {
                var v = new decvec5(new decvec5(5m, -8m, 8m, -3m, 6m));
                Assert.AreEqual(5m, v.x);
                Assert.AreEqual(-8m, v.y);
                Assert.AreEqual(8m, v.z);
                Assert.AreEqual(-3m, v.w);
                Assert.AreEqual(6m, v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new decvec5(0.5m, 9m, -4m, -8m, 8.5m);
            Assert.AreEqual(0.5m, v[0]);
            Assert.AreEqual(9m, v[1]);
            Assert.AreEqual(-4m, v[2]);
            Assert.AreEqual(-8m, v[3]);
            Assert.AreEqual(8.5m, v[4]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
            
            v[2] = 0m;
            Assert.AreEqual(0m, v[2]);
            v[3] = 1m;
            Assert.AreEqual(1m, v[3]);
            v[0] = 2m;
            Assert.AreEqual(2m, v[0]);
            v[1] = 3m;
            Assert.AreEqual(3m, v[1]);
            v[0] = 4m;
            Assert.AreEqual(4m, v[0]);
            v[3] = 5m;
            Assert.AreEqual(5m, v[3]);
            v[1] = 6m;
            Assert.AreEqual(6m, v[1]);
            v[0] = 7m;
            Assert.AreEqual(7m, v[0]);
            v[2] = 8m;
            Assert.AreEqual(8m, v[2]);
            v[0] = 9m;
            Assert.AreEqual(9m, v[0]);
            v[1] = -1m;
            Assert.AreEqual(-1m, v[1]);
            v[1] = -2m;
            Assert.AreEqual(-2m, v[1]);
            v[4] = -3m;
            Assert.AreEqual(-3m, v[4]);
            v[2] = -4m;
            Assert.AreEqual(-4m, v[2]);
            v[4] = -5m;
            Assert.AreEqual(-5m, v[4]);
            v[2] = -6m;
            Assert.AreEqual(-6m, v[2]);
            v[2] = -7m;
            Assert.AreEqual(-7m, v[2]);
            v[1] = -8m;
            Assert.AreEqual(-8m, v[1]);
            v[0] = -9m;
            Assert.AreEqual(-9m, v[0]);
            v[1] = -9.5m;
            Assert.AreEqual(-9.5m, v[1]);
            v[1] = -8.5m;
            Assert.AreEqual(-8.5m, v[1]);
            v[3] = -7.5m;
            Assert.AreEqual(-7.5m, v[3]);
            v[0] = -6.5m;
            Assert.AreEqual(-6.5m, v[0]);
            v[1] = -5.5m;
            Assert.AreEqual(-5.5m, v[1]);
            v[4] = -4.5m;
            Assert.AreEqual(-4.5m, v[4]);
            v[3] = -3.5m;
            Assert.AreEqual(-3.5m, v[3]);
            v[3] = -2.5m;
            Assert.AreEqual(-2.5m, v[3]);
            v[3] = -1.5m;
            Assert.AreEqual(-1.5m, v[3]);
            v[1] = -0.5m;
            Assert.AreEqual(-0.5m, v[1]);
            v[0] = 0.5m;
            Assert.AreEqual(0.5m, v[0]);
            v[1] = 1.5m;
            Assert.AreEqual(1.5m, v[1]);
            v[4] = 2.5m;
            Assert.AreEqual(2.5m, v[4]);
            v[0] = 3.5m;
            Assert.AreEqual(3.5m, v[0]);
            v[2] = 4.5m;
            Assert.AreEqual(4.5m, v[2]);
            v[3] = 5.5m;
            Assert.AreEqual(5.5m, v[3]);
            v[1] = 6.5m;
            Assert.AreEqual(6.5m, v[1]);
            v[1] = 7.5m;
            Assert.AreEqual(7.5m, v[1]);
            v[1] = 8.5m;
            Assert.AreEqual(8.5m, v[1]);
            v[3] = 9.5m;
            Assert.AreEqual(9.5m, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new decvec5(5m, 4m, -6.5m, 4m, 5.5m);
            var vals = v.Values;
            Assert.AreEqual(5m, vals[0]);
            Assert.AreEqual(4m, vals[1]);
            Assert.AreEqual(-6.5m, vals[2]);
            Assert.AreEqual(4m, vals[3]);
            Assert.AreEqual(5.5m, vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0m, decvec5.Zero.x);
            Assert.AreEqual(0m, decvec5.Zero.y);
            Assert.AreEqual(0m, decvec5.Zero.z);
            Assert.AreEqual(0m, decvec5.Zero.w);
            Assert.AreEqual(0m, decvec5.Zero.v);
            
            Assert.AreEqual(1m, decvec5.Ones.x);
            Assert.AreEqual(1m, decvec5.Ones.y);
            Assert.AreEqual(1m, decvec5.Ones.z);
            Assert.AreEqual(1m, decvec5.Ones.w);
            Assert.AreEqual(1m, decvec5.Ones.v);
            
            Assert.AreEqual(1m, decvec5.UnitX.x);
            Assert.AreEqual(0m, decvec5.UnitX.y);
            Assert.AreEqual(0m, decvec5.UnitX.z);
            Assert.AreEqual(0m, decvec5.UnitX.w);
            Assert.AreEqual(0m, decvec5.UnitX.v);
            
            Assert.AreEqual(0m, decvec5.UnitY.x);
            Assert.AreEqual(1m, decvec5.UnitY.y);
            Assert.AreEqual(0m, decvec5.UnitY.z);
            Assert.AreEqual(0m, decvec5.UnitY.w);
            Assert.AreEqual(0m, decvec5.UnitY.v);
            
            Assert.AreEqual(0m, decvec5.UnitZ.x);
            Assert.AreEqual(0m, decvec5.UnitZ.y);
            Assert.AreEqual(1m, decvec5.UnitZ.z);
            Assert.AreEqual(0m, decvec5.UnitZ.w);
            Assert.AreEqual(0m, decvec5.UnitZ.v);
            
            Assert.AreEqual(0m, decvec5.UnitW.x);
            Assert.AreEqual(0m, decvec5.UnitW.y);
            Assert.AreEqual(0m, decvec5.UnitW.z);
            Assert.AreEqual(1m, decvec5.UnitW.w);
            Assert.AreEqual(0m, decvec5.UnitW.v);
            
            Assert.AreEqual(0m, decvec5.UnitV.x);
            Assert.AreEqual(0m, decvec5.UnitV.y);
            Assert.AreEqual(0m, decvec5.UnitV.z);
            Assert.AreEqual(0m, decvec5.UnitV.w);
            Assert.AreEqual(1m, decvec5.UnitV.v);
            
            Assert.AreEqual(decimal.MaxValue, decvec5.MaxValue.x);
            Assert.AreEqual(decimal.MaxValue, decvec5.MaxValue.y);
            Assert.AreEqual(decimal.MaxValue, decvec5.MaxValue.z);
            Assert.AreEqual(decimal.MaxValue, decvec5.MaxValue.w);
            Assert.AreEqual(decimal.MaxValue, decvec5.MaxValue.v);
            
            Assert.AreEqual(decimal.MinValue, decvec5.MinValue.x);
            Assert.AreEqual(decimal.MinValue, decvec5.MinValue.y);
            Assert.AreEqual(decimal.MinValue, decvec5.MinValue.z);
            Assert.AreEqual(decimal.MinValue, decvec5.MinValue.w);
            Assert.AreEqual(decimal.MinValue, decvec5.MinValue.v);
            
            Assert.AreEqual(decimal.MinusOne, decvec5.MinusOne.x);
            Assert.AreEqual(decimal.MinusOne, decvec5.MinusOne.y);
            Assert.AreEqual(decimal.MinusOne, decvec5.MinusOne.z);
            Assert.AreEqual(decimal.MinusOne, decvec5.MinusOne.w);
            Assert.AreEqual(decimal.MinusOne, decvec5.MinusOne.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new decvec5(6.5m, 6.5m, -4m, -8m, 2.5m);
            var v2 = new decvec5(6.5m, 6.5m, -4m, -8m, 2.5m);
            var v3 = new decvec5(2.5m, -8m, -4m, 6.5m, 6.5m);
            Assert.That(v1 == new decvec5(v1));
            Assert.That(v2 == new decvec5(v2));
            Assert.That(v3 == new decvec5(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new decvec5(8m, -3.5m, -8m, -6m, 1.5m);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = decvec5.Parse(s0);
            var v1 = decvec5.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = decvec5.TryParse(s0, out v0);
            var b1 = decvec5.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = decvec5.TryParse(null, out v0);
            Assert.False(b0);
            b0 = decvec5.TryParse("", out v0);
            Assert.False(b0);
            b0 = decvec5.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { decvec5.Parse(null); });
            Assert.Throws<FormatException>(() => { decvec5.Parse(""); });
            Assert.Throws<FormatException>(() => { decvec5.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = decvec5.Parse(s3, "; ", NumberStyles.Number);
            var v4 = decvec5.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = decvec5.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new decvec5(5m, 8.5m, 3m, 0m, 9m);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<decvec5>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new decvec5(-2m, -4m, -1m, 5m, 1.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(6.5m, -6.5m, 9.5m, -9m, -1.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(8m, 3.5m, -1.5m, 6.5m, 7m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(-8m, -8m, 1.5m, -7.5m, 6.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(7.5m, 2m, 4.5m, 8.5m, -0.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(-2.5m, 2.5m, -5m, -1.5m, -8.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(-5.5m, 9m, 6m, 5m, 9m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(4.5m, 7m, 7m, 6.5m, 2m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(0.5m, -9m, 1.5m, 8.5m, 3.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec5(-1.5m, 1.5m, -4m, -7m, 7m);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new decvec5(2.5m, 2.5m, 7m, 8.5m, -6m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(4m, -1.5m, 0.5m, -4m, 6m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(-6.5m, -2.5m, -9.5m, -0.5m, -6.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(4m, 3m, 7.5m, 3.5m, 4m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(-5m, 2m, 2m, -9m, -8.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(3.5m, 6m, -1.5m, -3m, -8.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(7.5m, 5m, -4m, 2m, -4.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(1m, -2.5m, -7m, -1.5m, -6m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(-7m, -9m, -7.5m, -5m, 6.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec5(-2.5m, 7.5m, -8m, -4m, -8.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new decvec5(-7m, 1.5m, -2.5m, -9m, 1.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(6m, -9m, 9m, 0m, -2.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(-4.5m, 3.5m, -1m, -5m, -4.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(9.5m, 2m, 1m, 0.5m, -8.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(5.5m, -5.5m, 8.5m, -4.5m, -9m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(5.5m, 6.5m, -2m, 7m, -8.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(-5m, 6.5m, -0.5m, 4m, -0.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(2m, 2m, -7.5m, -4m, 8.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(-4.5m, -6m, -7m, -4m, 6m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec5(-6m, -5.5m, -1.5m, 8m, -6m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new decvec5(-4m, 7m, 2m, -9.5m, -5m);
                var v1 = new decvec5(7m, -5m, -4m, 2.5m, -6m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(-6m, 7m, -6.5m, 1m, -3m);
                var v1 = new decvec5(0m, 2m, -7m, -1.5m, -3m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(-1.5m, 0.5m, -3m, -8.5m, 9m);
                var v1 = new decvec5(4.5m, -9.5m, 8m, -7.5m, -9m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(-0.5m, 1m, 6.5m, 8.5m, -4m);
                var v1 = new decvec5(-2m, -6m, -3.5m, -7m, 6m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(7.5m, 9m, -6.5m, -3m, -8.5m);
                var v1 = new decvec5(-4m, 2m, 0m, 2.5m, 6m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(-7m, -3.5m, 0m, -8m, -6m);
                var v1 = new decvec5(-5.5m, 4.5m, -7.5m, 9m, -8.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(-1.5m, 5m, 1.5m, -4m, -2.5m);
                var v1 = new decvec5(-4m, -1m, -4.5m, -1.5m, 1m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(-4.5m, -7m, 9.5m, -8.5m, -5m);
                var v1 = new decvec5(-8m, 6m, 9.5m, 0m, 5.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(1.5m, -9m, -6m, -5m, 2m);
                var v1 = new decvec5(2m, 0m, -8m, -6.5m, 0.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec5(-7m, 4.5m, -6m, 6.5m, -9m);
                var v1 = new decvec5(1.5m, -9m, 9m, -3.5m, 6m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new decvec5(-5.5m, -9m, -3m, 0.5m, 3m);
                var v1 = new decvec5(-0.5m, -1m, -9m, 9.5m, -5.5m);
                var v2 = new decvec5(5m, 8.5m, -8m, -1.5m, -7m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(-2.5m, 6.5m, 9.5m, 4.5m, -7.5m);
                var v1 = new decvec5(-6m, -7m, 3.5m, -2.5m, 7m);
                var v2 = new decvec5(4m, 9m, 1m, -5.5m, 3.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(-3m, -5.5m, -9m, -5.5m, 3.5m);
                var v1 = new decvec5(-3.5m, -5m, -9m, 3.5m, 9.5m);
                var v2 = new decvec5(-5m, -6.5m, -7m, 8.5m, 8m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(-3m, -8m, 1m, 9.5m, 9.5m);
                var v1 = new decvec5(-9m, 2m, 2.5m, 9m, -8.5m);
                var v2 = new decvec5(7m, -3.5m, -4.5m, -6.5m, 8.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(-9m, 8m, 5.5m, 6m, -1m);
                var v1 = new decvec5(-7.5m, -9.5m, 3.5m, 4.5m, 0.5m);
                var v2 = new decvec5(-3m, -8m, 6m, 5.5m, 6m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(2.5m, 9.5m, 4.5m, -9m, 5.5m);
                var v1 = new decvec5(-2.5m, 8m, 1m, -5.5m, -4m);
                var v2 = new decvec5(-1m, 2.5m, 8m, 3m, -3.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(0m, -0.5m, 6.5m, 4.5m, -9.5m);
                var v1 = new decvec5(5m, -1.5m, -1m, -2.5m, -2.5m);
                var v2 = new decvec5(3.5m, -5.5m, 6m, 8m, -2.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(1m, 5.5m, 7.5m, 2m, -1.5m);
                var v1 = new decvec5(7m, 1.5m, 6m, -2.5m, -2m);
                var v2 = new decvec5(-1m, 6m, -2m, 3.5m, 0m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(-0.5m, -1m, 0.5m, 8m, 0.5m);
                var v1 = new decvec5(-6.5m, -7.5m, -3m, -5m, 0m);
                var v2 = new decvec5(4m, -0.5m, 7m, 2.5m, 2m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec5(2m, 1m, 2.5m, 6.5m, -3m);
                var v1 = new decvec5(-5m, 5.5m, 5m, -5m, -8m);
                var v2 = new decvec5(8m, -6.5m, 9m, -7.5m, 9m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new decvec5(-6.5m, 2.5m, -7m, 3.5m, 1.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(9.5m, 4.5m, 0.5m, 1.5m, 4.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(-2m, -9m, -1.5m, 0m, 1m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(5.5m, 1m, 0m, 9m, 1m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(5m, 3m, -6.5m, -7m, -9.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(3m, 2m, -1.5m, 7m, 7m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(5m, 8.5m, 9m, 4m, 4m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(-6.5m, -0.5m, -7.5m, -2.5m, -7m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(4.5m, -5m, -5.5m, 1m, -4.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec5(-2.5m, 2.5m, 8.5m, -7.5m, -6.5m);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new decvec5(-7m, 7m, 1m, -1.5m, -4m);
                var v1 = new decvec5(7.5m, 9.5m, -9.5m, 3m, -1m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(-4.5m, -9.5m, -1m, 5.5m, -6.5m);
                var v1 = new decvec5(-9m, 1.5m, -4.5m, 3.5m, 2.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(5m, -4.5m, 1.5m, 1m, 1m);
                var v1 = new decvec5(8.5m, 1m, -0.5m, -3.5m, 6m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(-8.5m, 2m, -5m, -3.5m, 8.5m);
                var v1 = new decvec5(1m, -9m, 2m, -1.5m, 7m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(-1.5m, -4.5m, 5m, 2m, -3.5m);
                var v1 = new decvec5(0m, -6m, -5.5m, -6.5m, 8.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(-7.5m, 1.5m, -9m, -0.5m, 4.5m);
                var v1 = new decvec5(2.5m, -7m, 0m, -3.5m, -6m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(5.5m, -1m, 4.5m, 7.5m, 0.5m);
                var v1 = new decvec5(-6.5m, 5m, -4.5m, 6.5m, -7.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(0m, -0.5m, 7.5m, -4.5m, 4m);
                var v1 = new decvec5(-9.5m, -9.5m, -1.5m, -5m, 1m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(-6.5m, -7m, 6m, -2.5m, -5.5m);
                var v1 = new decvec5(-0.5m, -5.5m, -4.5m, 1.5m, 5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec5(-5.5m, -9m, -6m, -2m, -2m);
                var v1 = new decvec5(-8m, 1.5m, 7m, -3m, 3m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new decvec5(-4.5m, 0m, -5m, 7m, 5m);
                var v1 = new decvec5(3m, -2m, -1.5m, 9.5m, 9m);
                var v2 = new decvec5(7m, -3.5m, -7m, -8m, 6m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(8.5m, 6.5m, -9m, -4.5m, -3m);
                var v1 = new decvec5(-8m, -5.5m, -3.5m, 8.5m, -1.5m);
                var v2 = new decvec5(7.5m, 0.5m, 1.5m, -9m, -4m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(5.5m, -5m, 9m, 1m, 3.5m);
                var v1 = new decvec5(-6m, 0.5m, 9.5m, 1m, -9m);
                var v2 = new decvec5(3m, 3m, -4.5m, 3m, -6.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(4m, -9.5m, 1.5m, 0.5m, 8.5m);
                var v1 = new decvec5(-5m, -5m, -9.5m, 0.5m, 1.5m);
                var v2 = new decvec5(1m, -4m, -7m, -9.5m, 7m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(-4m, -9.5m, 8m, -3.5m, -4m);
                var v1 = new decvec5(2.5m, -7m, -6m, -4.5m, 1.5m);
                var v2 = new decvec5(8m, 6.5m, -8m, 6m, 9m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(-5m, 8.5m, -6.5m, -5m, -6.5m);
                var v1 = new decvec5(-7m, 8.5m, 1m, -8.5m, 9.5m);
                var v2 = new decvec5(-8.5m, 5.5m, -9m, 9m, 1.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(2m, -3m, -9.5m, 3.5m, 4m);
                var v1 = new decvec5(-6.5m, 4.5m, 9.5m, -0.5m, 0.5m);
                var v2 = new decvec5(-1.5m, 3m, 6m, 8.5m, 0.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(-8m, 6.5m, -4m, -9.5m, -6m);
                var v1 = new decvec5(2m, 0.5m, 1m, 6.5m, 0.5m);
                var v2 = new decvec5(-5m, -9m, -2.5m, -2.5m, 3.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(7.5m, 7.5m, 5m, 3.5m, -0.5m);
                var v1 = new decvec5(5.5m, -7m, -4.5m, 1m, -2.5m);
                var v2 = new decvec5(-9.5m, 9.5m, 4.5m, -4.5m, 5.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec5(-3m, 2.5m, 2m, 1.5m, -8.5m);
                var v1 = new decvec5(-4.5m, -7.5m, 8.5m, 4.5m, -0.5m);
                var v2 = new decvec5(-2m, -1m, -5.5m, 2m, 0.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new decvec5(3.5m, -3.5m, 8m, -5.5m, -7m);
                var v1 = new decvec5(-9m, 9.5m, -7.5m, 5m, -5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(9m, 2.5m, -8m, 1m, 4.5m);
                var v1 = new decvec5(-3.5m, -7m, -8m, 7m, -4m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(7m, 0.5m, 9m, -8.5m, -2m);
                var v1 = new decvec5(9.5m, -7.5m, -2m, 5.5m, -7.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(-8m, -8m, 5m, 5.5m, -3.5m);
                var v1 = new decvec5(9.5m, -4.5m, -2.5m, 0m, 5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(-0.5m, -4m, -2.5m, 6.5m, -1m);
                var v1 = new decvec5(8m, 9m, -2m, -5m, 9m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(-4m, -0.5m, -6.5m, -8m, -3.5m);
                var v1 = new decvec5(3m, -7m, -2.5m, -2m, -8m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(7.5m, -1.5m, -2.5m, -5.5m, 7.5m);
                var v1 = new decvec5(2.5m, -2.5m, -6.5m, -6m, 5.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(1m, -0.5m, -8m, 1m, -5.5m);
                var v1 = new decvec5(4.5m, 2m, -4m, -1m, 3m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(-0.5m, -1m, 6.5m, -4.5m, 7m);
                var v1 = new decvec5(-0.5m, 5.5m, -2.5m, 9m, -7.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec5(-6.5m, 7.5m, -5m, -6.5m, 8m);
                var v1 = new decvec5(1m, -3.5m, 2m, 8.5m, -9m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new decvec5(9.5m, 6m, 4.5m, 2m, 1m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(6m, -4.5m, -1.5m, -5m, -8.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(3m, 7.5m, 5m, 0m, -6.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(-5.5m, -6m, 6.5m, -1m, -8m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(-0.5m, -4m, -2.5m, -9m, 0.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(-4m, 8.5m, 5.5m, -3m, 0.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(7.5m, 9.5m, -4.5m, 4m, -6m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(3.5m, -2.5m, -6m, 3m, -1m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(-4.5m, -5m, 4m, 8m, 7m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec5(-1m, 5.5m, 2m, 8m, -6m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1425795026);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.Random(random, 2, 3);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            Assert.AreEqual(avg.w, 2.5, 1.0);
            Assert.AreEqual(avg.v, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.v, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(2144363028);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomUniform(random, 2, 4);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            Assert.AreEqual(avg.z, 3, 1.0);
            Assert.AreEqual(avg.w, 3, 1.0);
            Assert.AreEqual(avg.v, 3, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.v, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(715447383);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.Random(random, -3, -1);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            Assert.AreEqual(avg.z, -2, 1.0);
            Assert.AreEqual(avg.w, -2, 1.0);
            Assert.AreEqual(avg.v, -2, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.v, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1434015385);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomUniform(random, 2, 5);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            Assert.AreEqual(avg.z, 3.5, 1.0);
            Assert.AreEqual(avg.w, 3.5, 1.0);
            Assert.AreEqual(avg.v, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
            Assert.AreEqual(variance.v, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(699006665);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.Random(random, -3, 0);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            Assert.AreEqual(avg.z, -1.5, 1.0);
            Assert.AreEqual(avg.w, -1.5, 1.0);
            Assert.AreEqual(avg.v, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
            Assert.AreEqual(variance.v, 0.75, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1282787055);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomNormal(random, 0.652221703274279m, 7.86663248104352m);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.652221703274279, 1.0);
            Assert.AreEqual(avg.y, 0.652221703274279, 1.0);
            Assert.AreEqual(avg.z, 0.652221703274279, 1.0);
            Assert.AreEqual(avg.w, 0.652221703274279, 1.0);
            Assert.AreEqual(avg.v, 0.652221703274279, 1.0);
            
            Assert.AreEqual(variance.x, 7.86663248104352, 3.0);
            Assert.AreEqual(variance.y, 7.86663248104352, 3.0);
            Assert.AreEqual(variance.z, 7.86663248104352, 3.0);
            Assert.AreEqual(variance.w, 7.86663248104352, 3.0);
            Assert.AreEqual(variance.v, 7.86663248104352, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1672079651);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomGaussian(random, 1.2614791222203m, 3.69267380502665m);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.2614791222203, 1.0);
            Assert.AreEqual(avg.y, 1.2614791222203, 1.0);
            Assert.AreEqual(avg.z, 1.2614791222203, 1.0);
            Assert.AreEqual(avg.w, 1.2614791222203, 1.0);
            Assert.AreEqual(avg.v, 1.2614791222203, 1.0);
            
            Assert.AreEqual(variance.x, 3.69267380502665, 3.0);
            Assert.AreEqual(variance.y, 3.69267380502665, 3.0);
            Assert.AreEqual(variance.z, 3.69267380502665, 3.0);
            Assert.AreEqual(variance.w, 3.69267380502665, 3.0);
            Assert.AreEqual(variance.v, 3.69267380502665, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(113885153);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomNormal(random, 1.26997493732254m, 0.055807707857251m);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.26997493732254, 1.0);
            Assert.AreEqual(avg.y, 1.26997493732254, 1.0);
            Assert.AreEqual(avg.z, 1.26997493732254, 1.0);
            Assert.AreEqual(avg.w, 1.26997493732254, 1.0);
            Assert.AreEqual(avg.v, 1.26997493732254, 1.0);
            
            Assert.AreEqual(variance.x, 0.055807707857251, 3.0);
            Assert.AreEqual(variance.y, 0.055807707857251, 3.0);
            Assert.AreEqual(variance.z, 0.055807707857251, 3.0);
            Assert.AreEqual(variance.w, 0.055807707857251, 3.0);
            Assert.AreEqual(variance.v, 0.055807707857251, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(2097044414);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomGaussian(random, -0.361229670402235m, 8.87148437037667m);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.361229670402235, 1.0);
            Assert.AreEqual(avg.y, -0.361229670402235, 1.0);
            Assert.AreEqual(avg.z, -0.361229670402235, 1.0);
            Assert.AreEqual(avg.w, -0.361229670402235, 1.0);
            Assert.AreEqual(avg.v, -0.361229670402235, 1.0);
            
            Assert.AreEqual(variance.x, 8.87148437037667, 3.0);
            Assert.AreEqual(variance.y, 8.87148437037667, 3.0);
            Assert.AreEqual(variance.z, 8.87148437037667, 3.0);
            Assert.AreEqual(variance.w, 8.87148437037667, 3.0);
            Assert.AreEqual(variance.v, 8.87148437037667, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1082790502);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomNormal(random, -0.368378487587151m, 7.25951209536731m);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.368378487587151, 1.0);
            Assert.AreEqual(avg.y, -0.368378487587151, 1.0);
            Assert.AreEqual(avg.z, -0.368378487587151, 1.0);
            Assert.AreEqual(avg.w, -0.368378487587151, 1.0);
            Assert.AreEqual(avg.v, -0.368378487587151, 1.0);
            
            Assert.AreEqual(variance.x, 7.25951209536731, 3.0);
            Assert.AreEqual(variance.y, 7.25951209536731, 3.0);
            Assert.AreEqual(variance.z, 7.25951209536731, 3.0);
            Assert.AreEqual(variance.w, 7.25951209536731, 3.0);
            Assert.AreEqual(variance.v, 7.25951209536731, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(755040826);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomNormal(random);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            Assert.AreEqual(avg.v, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
            Assert.AreEqual(variance.v, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(1876940645);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomNormal(random);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            Assert.AreEqual(avg.v, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
            Assert.AreEqual(variance.v, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(851356817);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomNormal(random);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            Assert.AreEqual(avg.v, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
            Assert.AreEqual(variance.v, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(1973256636);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomNormal(random);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            Assert.AreEqual(avg.v, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
            Assert.AreEqual(variance.v, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(562408844);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec5.RandomNormal(random);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            Assert.AreEqual(avg.v, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
            Assert.AreEqual(variance.v, 1, 3.0);
        }

    }
}
