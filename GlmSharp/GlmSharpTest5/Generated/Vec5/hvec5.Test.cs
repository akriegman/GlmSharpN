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
    public class HalfVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new hvec5(new Half(-5));
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
                Assert.AreEqual(new Half(-5), v.v);
            }
            {
                var v = new hvec5(new Half(-2.5), new Half(-1.5), new Half(-0.5), new Half(8), new Half(2));
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(8), v.w);
                Assert.AreEqual(new Half(2), v.v);
            }
            {
                var v = new hvec5(new hvec2(new Half(-4), new Half(8.5)));
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(Half.Zero, v.w);
                Assert.AreEqual(Half.Zero, v.v);
            }
            {
                var v = new hvec5(new hvec3(new Half(6.5), new Half(-0.5), new Half(-4)));
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(Half.Zero, v.w);
                Assert.AreEqual(Half.Zero, v.v);
            }
            {
                var v = new hvec5(new hvec4(new Half(-9.5), Half.One, new Half(6.5), new Half(3)));
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
                Assert.AreEqual(Half.Zero, v.v);
            }
            {
                var v = new hvec5(new hvec5(new Half(-2.5), new Half(-2), new Half(2), new Half(-8), new Half(7)));
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(-8), v.w);
                Assert.AreEqual(new Half(7), v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new hvec5(new Half(-4), new Half(9), new Half(3), new Half(-6.5), Half.Zero);
            Assert.AreEqual(new Half(-4), v[0]);
            Assert.AreEqual(new Half(9), v[1]);
            Assert.AreEqual(new Half(3), v[2]);
            Assert.AreEqual(new Half(-6.5), v[3]);
            Assert.AreEqual(Half.Zero, v[4]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = Half.Zero; } );
            
            v[2] = Half.Zero;
            Assert.AreEqual(Half.Zero, v[2]);
            v[4] = Half.One;
            Assert.AreEqual(Half.One, v[4]);
            v[4] = new Half(2);
            Assert.AreEqual(new Half(2), v[4]);
            v[1] = new Half(3);
            Assert.AreEqual(new Half(3), v[1]);
            v[2] = new Half(4);
            Assert.AreEqual(new Half(4), v[2]);
            v[0] = new Half(5);
            Assert.AreEqual(new Half(5), v[0]);
            v[0] = new Half(6);
            Assert.AreEqual(new Half(6), v[0]);
            v[0] = new Half(7);
            Assert.AreEqual(new Half(7), v[0]);
            v[1] = new Half(8);
            Assert.AreEqual(new Half(8), v[1]);
            v[3] = new Half(9);
            Assert.AreEqual(new Half(9), v[3]);
            v[3] = new Half(-1);
            Assert.AreEqual(new Half(-1), v[3]);
            v[0] = new Half(-2);
            Assert.AreEqual(new Half(-2), v[0]);
            v[3] = new Half(-3);
            Assert.AreEqual(new Half(-3), v[3]);
            v[2] = new Half(-4);
            Assert.AreEqual(new Half(-4), v[2]);
            v[4] = new Half(-5);
            Assert.AreEqual(new Half(-5), v[4]);
            v[4] = new Half(-6);
            Assert.AreEqual(new Half(-6), v[4]);
            v[4] = new Half(-7);
            Assert.AreEqual(new Half(-7), v[4]);
            v[0] = new Half(-8);
            Assert.AreEqual(new Half(-8), v[0]);
            v[0] = new Half(-9);
            Assert.AreEqual(new Half(-9), v[0]);
            v[0] = new Half(-9.5);
            Assert.AreEqual(new Half(-9.5), v[0]);
            v[1] = new Half(-8.5);
            Assert.AreEqual(new Half(-8.5), v[1]);
            v[0] = new Half(-7.5);
            Assert.AreEqual(new Half(-7.5), v[0]);
            v[3] = new Half(-6.5);
            Assert.AreEqual(new Half(-6.5), v[3]);
            v[2] = new Half(-5.5);
            Assert.AreEqual(new Half(-5.5), v[2]);
            v[2] = new Half(-4.5);
            Assert.AreEqual(new Half(-4.5), v[2]);
            v[4] = new Half(-3.5);
            Assert.AreEqual(new Half(-3.5), v[4]);
            v[4] = new Half(-2.5);
            Assert.AreEqual(new Half(-2.5), v[4]);
            v[0] = new Half(-1.5);
            Assert.AreEqual(new Half(-1.5), v[0]);
            v[4] = new Half(-0.5);
            Assert.AreEqual(new Half(-0.5), v[4]);
            v[4] = new Half(0.5);
            Assert.AreEqual(new Half(0.5), v[4]);
            v[0] = new Half(1.5);
            Assert.AreEqual(new Half(1.5), v[0]);
            v[1] = new Half(2.5);
            Assert.AreEqual(new Half(2.5), v[1]);
            v[4] = new Half(3.5);
            Assert.AreEqual(new Half(3.5), v[4]);
            v[4] = new Half(4.5);
            Assert.AreEqual(new Half(4.5), v[4]);
            v[1] = new Half(5.5);
            Assert.AreEqual(new Half(5.5), v[1]);
            v[1] = new Half(6.5);
            Assert.AreEqual(new Half(6.5), v[1]);
            v[3] = new Half(7.5);
            Assert.AreEqual(new Half(7.5), v[3]);
            v[3] = new Half(8.5);
            Assert.AreEqual(new Half(8.5), v[3]);
            v[4] = new Half(9.5);
            Assert.AreEqual(new Half(9.5), v[4]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new hvec5(new Half(-0.5), new Half(4), new Half(-2), new Half(-1), new Half(7.5));
            var vals = v.Values;
            Assert.AreEqual(new Half(-0.5), vals[0]);
            Assert.AreEqual(new Half(4), vals[1]);
            Assert.AreEqual(new Half(-2), vals[2]);
            Assert.AreEqual(new Half(-1), vals[3]);
            Assert.AreEqual(new Half(7.5), vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(Half.Zero, hvec5.Zero.x);
            Assert.AreEqual(Half.Zero, hvec5.Zero.y);
            Assert.AreEqual(Half.Zero, hvec5.Zero.z);
            Assert.AreEqual(Half.Zero, hvec5.Zero.w);
            Assert.AreEqual(Half.Zero, hvec5.Zero.v);
            
            Assert.AreEqual(Half.One, hvec5.Ones.x);
            Assert.AreEqual(Half.One, hvec5.Ones.y);
            Assert.AreEqual(Half.One, hvec5.Ones.z);
            Assert.AreEqual(Half.One, hvec5.Ones.w);
            Assert.AreEqual(Half.One, hvec5.Ones.v);
            
            Assert.AreEqual(Half.One, hvec5.UnitX.x);
            Assert.AreEqual(Half.Zero, hvec5.UnitX.y);
            Assert.AreEqual(Half.Zero, hvec5.UnitX.z);
            Assert.AreEqual(Half.Zero, hvec5.UnitX.w);
            Assert.AreEqual(Half.Zero, hvec5.UnitX.v);
            
            Assert.AreEqual(Half.Zero, hvec5.UnitY.x);
            Assert.AreEqual(Half.One, hvec5.UnitY.y);
            Assert.AreEqual(Half.Zero, hvec5.UnitY.z);
            Assert.AreEqual(Half.Zero, hvec5.UnitY.w);
            Assert.AreEqual(Half.Zero, hvec5.UnitY.v);
            
            Assert.AreEqual(Half.Zero, hvec5.UnitZ.x);
            Assert.AreEqual(Half.Zero, hvec5.UnitZ.y);
            Assert.AreEqual(Half.One, hvec5.UnitZ.z);
            Assert.AreEqual(Half.Zero, hvec5.UnitZ.w);
            Assert.AreEqual(Half.Zero, hvec5.UnitZ.v);
            
            Assert.AreEqual(Half.Zero, hvec5.UnitW.x);
            Assert.AreEqual(Half.Zero, hvec5.UnitW.y);
            Assert.AreEqual(Half.Zero, hvec5.UnitW.z);
            Assert.AreEqual(Half.One, hvec5.UnitW.w);
            Assert.AreEqual(Half.Zero, hvec5.UnitW.v);
            
            Assert.AreEqual(Half.Zero, hvec5.UnitV.x);
            Assert.AreEqual(Half.Zero, hvec5.UnitV.y);
            Assert.AreEqual(Half.Zero, hvec5.UnitV.z);
            Assert.AreEqual(Half.Zero, hvec5.UnitV.w);
            Assert.AreEqual(Half.One, hvec5.UnitV.v);
            
            Assert.AreEqual(Half.MaxValue, hvec5.MaxValue.x);
            Assert.AreEqual(Half.MaxValue, hvec5.MaxValue.y);
            Assert.AreEqual(Half.MaxValue, hvec5.MaxValue.z);
            Assert.AreEqual(Half.MaxValue, hvec5.MaxValue.w);
            Assert.AreEqual(Half.MaxValue, hvec5.MaxValue.v);
            
            Assert.AreEqual(Half.MinValue, hvec5.MinValue.x);
            Assert.AreEqual(Half.MinValue, hvec5.MinValue.y);
            Assert.AreEqual(Half.MinValue, hvec5.MinValue.z);
            Assert.AreEqual(Half.MinValue, hvec5.MinValue.w);
            Assert.AreEqual(Half.MinValue, hvec5.MinValue.v);
            
            Assert.AreEqual(Half.Epsilon, hvec5.Epsilon.x);
            Assert.AreEqual(Half.Epsilon, hvec5.Epsilon.y);
            Assert.AreEqual(Half.Epsilon, hvec5.Epsilon.z);
            Assert.AreEqual(Half.Epsilon, hvec5.Epsilon.w);
            Assert.AreEqual(Half.Epsilon, hvec5.Epsilon.v);
            
            Assert.AreEqual(Half.NaN, hvec5.NaN.x);
            Assert.AreEqual(Half.NaN, hvec5.NaN.y);
            Assert.AreEqual(Half.NaN, hvec5.NaN.z);
            Assert.AreEqual(Half.NaN, hvec5.NaN.w);
            Assert.AreEqual(Half.NaN, hvec5.NaN.v);
            
            Assert.AreEqual(Half.NegativeInfinity, hvec5.NegativeInfinity.x);
            Assert.AreEqual(Half.NegativeInfinity, hvec5.NegativeInfinity.y);
            Assert.AreEqual(Half.NegativeInfinity, hvec5.NegativeInfinity.z);
            Assert.AreEqual(Half.NegativeInfinity, hvec5.NegativeInfinity.w);
            Assert.AreEqual(Half.NegativeInfinity, hvec5.NegativeInfinity.v);
            
            Assert.AreEqual(Half.PositiveInfinity, hvec5.PositiveInfinity.x);
            Assert.AreEqual(Half.PositiveInfinity, hvec5.PositiveInfinity.y);
            Assert.AreEqual(Half.PositiveInfinity, hvec5.PositiveInfinity.z);
            Assert.AreEqual(Half.PositiveInfinity, hvec5.PositiveInfinity.w);
            Assert.AreEqual(Half.PositiveInfinity, hvec5.PositiveInfinity.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new hvec5(new Half(-3), new Half(7.5), new Half(-4.5), new Half(-3), new Half(-0.5));
            var v2 = new hvec5(new Half(-3), new Half(7.5), new Half(-4.5), new Half(-3), new Half(-0.5));
            var v3 = new hvec5(new Half(-0.5), new Half(-3), new Half(-4.5), new Half(7.5), new Half(-3));
            Assert.That(v1 == new hvec5(v1));
            Assert.That(v2 == new hvec5(v2));
            Assert.That(v3 == new hvec5(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new hvec5(new Half(-4.5), new Half(-3.5), new Half(-1.5), new Half(-1), new Half(-0.5));
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = hvec5.Parse(s0);
            var v1 = hvec5.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = hvec5.TryParse(s0, out v0);
            var b1 = hvec5.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = hvec5.TryParse(null, out v0);
            Assert.False(b0);
            b0 = hvec5.TryParse("", out v0);
            Assert.False(b0);
            b0 = hvec5.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { hvec5.Parse(null); });
            Assert.Throws<FormatException>(() => { hvec5.Parse(""); });
            Assert.Throws<FormatException>(() => { hvec5.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = hvec5.Parse(s3, "; ", NumberStyles.Number);
            var v4 = hvec5.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = hvec5.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new hvec5(new Half(-0.5), new Half(8.5), new Half(3.5), new Half(5), new Half(-2));
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<hvec5>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new hvec5(new Half(-1.5), new Half(-4), new Half(-8.5), new Half(9.5), new Half(-0.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(new Half(4.5), new Half(-4), Half.One, new Half(-7), new Half(8));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(new Half(6.5), new Half(2), new Half(-3.5), new Half(8), new Half(-7.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(new Half(7.5), new Half(-5.5), new Half(8.5), new Half(-7), new Half(5.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(new Half(-8.5), new Half(-8.5), new Half(2), new Half(6.5), Half.One);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(new Half(-9.5), new Half(-6), new Half(7.5), new Half(-9), new Half(8.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(new Half(-9.5), new Half(6.5), new Half(-2.5), new Half(-5.5), new Half(-5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(Half.Zero, new Half(-3.5), new Half(-5), new Half(-7), new Half(-2));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(new Half(-2.5), new Half(3), new Half(-5), new Half(-0.5), new Half(4));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec5(new Half(8), new Half(5), new Half(-8), new Half(0.5), new Half(3.5));
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new hvec5(new Half(-6), new Half(1.5), new Half(7.5), new Half(4), new Half(-8));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(new Half(7), new Half(7.5), new Half(-2.5), new Half(-7), new Half(-3.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(new Half(5.5), new Half(-9), new Half(-7.5), new Half(-6), new Half(8));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(new Half(-3.5), new Half(8.5), new Half(1.5), new Half(8.5), new Half(5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(new Half(1.5), new Half(-5.5), new Half(4.5), new Half(-9.5), new Half(8));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(Half.Zero, new Half(-6.5), new Half(6), new Half(-7.5), new Half(2));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(Half.Zero, new Half(-9.5), new Half(3.5), new Half(-4.5), new Half(-9.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(new Half(5.5), new Half(7), new Half(8), new Half(7), new Half(6));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(new Half(-9.5), new Half(4.5), new Half(7.5), new Half(-5.5), new Half(-4.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec5(new Half(5), new Half(-7.5), new Half(-5), Half.Zero, new Half(5.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new hvec5(Half.Zero, new Half(1.5), new Half(-6), new Half(-4.5), new Half(3.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(8), new Half(-1.5), new Half(7), new Half(3), new Half(6));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(7.5), new Half(-4.5), new Half(-3), Half.One, new Half(-2));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(-8.5), new Half(7.5), new Half(5.5), new Half(6.5), new Half(-8.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(-2), new Half(5), new Half(0.5), new Half(-3.5), new Half(6));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(2), new Half(-3), new Half(0.5), new Half(-7), new Half(2));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(-9), new Half(-1), new Half(8), new Half(-3.5), new Half(-5.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(6.5), new Half(-5.5), new Half(-4), new Half(3.5), new Half(-0.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(-1.5), new Half(1.5), new Half(2.5), new Half(-6.5), new Half(5.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec5(new Half(5.5), new Half(9), new Half(-4.5), new Half(5.5), new Half(1.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new hvec5(new Half(7), Half.One, new Half(8.5), new Half(-4.5), Half.Zero);
                var v1 = new hvec5(new Half(-8), new Half(8.5), new Half(-6), new Half(-3), new Half(-6.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(-9), new Half(-6.5), new Half(8), new Half(2.5), new Half(9.5));
                var v1 = new hvec5(new Half(4.5), new Half(2), new Half(-5.5), new Half(8.5), new Half(-1));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(0.5), new Half(-9.5), new Half(-8.5), new Half(-8.5), new Half(4));
                var v1 = new hvec5(new Half(-2.5), new Half(2.5), new Half(-8.5), new Half(-2), new Half(3.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(-6), new Half(1.5), new Half(7), new Half(-6), new Half(-2));
                var v1 = new hvec5(new Half(5.5), Half.Zero, new Half(-1.5), new Half(6.5), new Half(6));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(8.5), new Half(6), Half.One, new Half(-8), new Half(-4.5));
                var v1 = new hvec5(new Half(-3), new Half(-5.5), new Half(5.5), new Half(-8.5), new Half(7));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(4), new Half(1.5), new Half(6.5), new Half(-3.5), new Half(-7.5));
                var v1 = new hvec5(new Half(-2.5), new Half(-8.5), new Half(-8), new Half(-8.5), new Half(-3));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(-3.5), new Half(-8), new Half(3), new Half(-9), new Half(7));
                var v1 = new hvec5(new Half(-2.5), new Half(-5), new Half(2.5), new Half(-8.5), new Half(4));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(4.5), new Half(-4), new Half(-2.5), new Half(1.5), new Half(-2));
                var v1 = new hvec5(new Half(-5.5), new Half(-9), new Half(2), new Half(5.5), new Half(1.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(2), new Half(6.5), new Half(9.5), new Half(4), new Half(-1.5));
                var v1 = new hvec5(new Half(-5.5), new Half(5.5), new Half(-7.5), new Half(3.5), new Half(-5.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec5(new Half(-4), new Half(-6.5), new Half(7), new Half(-6.5), new Half(-9.5));
                var v1 = new hvec5(new Half(-8.5), new Half(2), new Half(-7.5), new Half(-1), new Half(8.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new hvec5(new Half(7), new Half(-9), new Half(2), new Half(6.5), new Half(5));
                var v1 = new hvec5(new Half(2.5), new Half(-9.5), new Half(-6), new Half(2), new Half(3));
                var v2 = new hvec5(new Half(-8), new Half(0.5), new Half(-9), new Half(-5), new Half(2));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(8), new Half(1.5), new Half(2.5), new Half(9.5), new Half(-7.5));
                var v1 = new hvec5(new Half(2.5), new Half(8.5), new Half(-4.5), new Half(-0.5), new Half(5.5));
                var v2 = new hvec5(new Half(-2), new Half(-3.5), new Half(-9), new Half(3.5), new Half(-5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-7), new Half(8.5), new Half(8.5), new Half(5), new Half(-1.5));
                var v1 = new hvec5(new Half(-9.5), new Half(6.5), new Half(-1), new Half(-3), new Half(0.5));
                var v2 = new hvec5(new Half(-8), new Half(8.5), new Half(3.5), new Half(7), new Half(7.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(1.5), new Half(2), new Half(8.5), new Half(-3.5), new Half(-5));
                var v1 = new hvec5(new Half(-1), new Half(1.5), new Half(4), new Half(-2.5), new Half(-5));
                var v2 = new hvec5(new Half(9), new Half(3.5), new Half(-3), Half.Zero, new Half(3.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(5), Half.Zero, new Half(-6.5), new Half(-2.5), new Half(-2.5));
                var v1 = new hvec5(new Half(-9.5), new Half(1.5), new Half(-4), new Half(-2.5), new Half(-7.5));
                var v2 = new hvec5(new Half(-3), new Half(-9.5), new Half(-9.5), new Half(9), new Half(4));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(3.5), new Half(4), new Half(-7), new Half(1.5), new Half(4));
                var v1 = new hvec5(new Half(8), new Half(-1.5), new Half(3.5), new Half(-9), new Half(3));
                var v2 = new hvec5(new Half(-4.5), new Half(4.5), new Half(-1), new Half(1.5), new Half(-8));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-3.5), new Half(-6.5), new Half(-1), new Half(-9), new Half(-4.5));
                var v1 = new hvec5(new Half(-8), new Half(-6), new Half(5), new Half(-9.5), new Half(-7));
                var v2 = new hvec5(new Half(9.5), new Half(-0.5), new Half(-2), new Half(3), Half.One);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(1.5), new Half(-2), new Half(4.5), new Half(-6.5), new Half(-8.5));
                var v1 = new hvec5(new Half(4), new Half(-7), new Half(-8.5), new Half(5.5), new Half(-4.5));
                var v2 = new hvec5(new Half(-7), new Half(6), new Half(4), new Half(-6.5), Half.One);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-3.5), new Half(-9.5), new Half(-7.5), new Half(8), new Half(6.5));
                var v1 = new hvec5(new Half(0.5), new Half(9), Half.Zero, new Half(-5.5), new Half(-3.5));
                var v2 = new hvec5(new Half(-8), new Half(9.5), new Half(6.5), new Half(-5), new Half(4));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-9), new Half(-7), new Half(0.5), new Half(-7), new Half(-3));
                var v1 = new hvec5(new Half(-4), new Half(9.5), new Half(-1.5), new Half(9), new Half(-3));
                var v2 = new hvec5(new Half(9), Half.One, new Half(-5), new Half(4.5), new Half(8));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new hvec5(new Half(6), new Half(1.5), new Half(6), new Half(9.5), new Half(3.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(2), new Half(3), new Half(-2.5), new Half(4.5), new Half(-4));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(-4.5), new Half(9), new Half(0.5), new Half(-2.5), new Half(-1.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(-7), new Half(6.5), new Half(3.5), new Half(-5), Half.One);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(-7.5), new Half(-4.5), new Half(-5), new Half(-8), new Half(7));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(-1), new Half(-9), new Half(6), new Half(-7), new Half(-0.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(8), new Half(-2), new Half(-0.5), new Half(-3.5), new Half(9.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(-7), new Half(-1), new Half(-4), new Half(6), new Half(7));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(7.5), new Half(0.5), new Half(9.5), new Half(-1), new Half(-4));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec5(new Half(5), new Half(-8), new Half(4.5), new Half(8), new Half(8.5));
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new hvec5(Half.Zero, new Half(7), new Half(1.5), new Half(3.5), new Half(-7));
                var v1 = new hvec5(new Half(9.5), new Half(8), new Half(-7), new Half(6), new Half(0.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(new Half(7.5), new Half(-2), new Half(-3), new Half(-7.5), new Half(8));
                var v1 = new hvec5(Half.Zero, new Half(-3.5), new Half(-9), new Half(8.5), new Half(3.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(new Half(-7.5), new Half(6), new Half(-7.5), new Half(2), new Half(0.5));
                var v1 = new hvec5(new Half(5), new Half(-8), new Half(7), new Half(5.5), new Half(-1.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(new Half(-5.5), new Half(-6), new Half(4.5), new Half(7), new Half(3.5));
                var v1 = new hvec5(new Half(5.5), Half.Zero, new Half(4.5), new Half(7), new Half(8.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(new Half(1.5), Half.Zero, new Half(-8.5), new Half(-2), new Half(-5));
                var v1 = new hvec5(new Half(-9), Half.Zero, new Half(-8.5), new Half(8), new Half(-4));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(new Half(-4), new Half(-9.5), new Half(1.5), new Half(6), new Half(-1.5));
                var v1 = new hvec5(new Half(4.5), new Half(-4.5), new Half(-1.5), new Half(3), new Half(-1));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(new Half(-7.5), Half.One, new Half(-7.5), new Half(-8), new Half(5));
                var v1 = new hvec5(new Half(-8.5), new Half(-8), new Half(5), new Half(-0.5), new Half(-4));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(Half.Zero, new Half(2.5), new Half(-1), new Half(9.5), Half.One);
                var v1 = new hvec5(new Half(-8.5), new Half(-4.5), new Half(-1), new Half(-1.5), new Half(-1));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(new Half(4), new Half(6.5), new Half(8.5), new Half(-7.5), new Half(-4));
                var v1 = new hvec5(new Half(3), new Half(-4.5), new Half(-2.5), new Half(-9), new Half(8.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec5(new Half(9), new Half(-2), new Half(0.5), new Half(7.5), new Half(-7));
                var v1 = new hvec5(new Half(-0.5), new Half(-9), new Half(3), new Half(6), new Half(3.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new hvec5(new Half(8), new Half(9.5), new Half(4), new Half(-3), new Half(7));
                var v1 = new hvec5(new Half(6), new Half(-8.5), new Half(-4.5), new Half(2), new Half(-0.5));
                var v2 = new hvec5(new Half(-9.5), new Half(-8), new Half(-9), new Half(5), new Half(2.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-9.5), new Half(1.5), new Half(-3), new Half(1.5), new Half(-4));
                var v1 = new hvec5(new Half(4.5), new Half(4), new Half(-8), new Half(9.5), new Half(-6));
                var v2 = new hvec5(new Half(4), new Half(6), new Half(8), new Half(-1.5), new Half(6.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(9.5), new Half(-0.5), new Half(-0.5), new Half(-6.5), new Half(-1.5));
                var v1 = new hvec5(new Half(9), new Half(-1), new Half(1.5), new Half(-8.5), new Half(9));
                var v2 = new hvec5(new Half(5), new Half(-9), Half.Zero, new Half(-3), new Half(-2));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-6.5), new Half(5), new Half(-1.5), new Half(-6), new Half(-3));
                var v1 = new hvec5(new Half(6), new Half(3), new Half(2.5), new Half(7), new Half(-4.5));
                var v2 = new hvec5(new Half(3), new Half(-8.5), new Half(4), new Half(7.5), new Half(2));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(9.5), new Half(-2), new Half(6.5), new Half(6), new Half(0.5));
                var v1 = new hvec5(new Half(1.5), new Half(-1.5), new Half(5.5), new Half(-8), new Half(-6.5));
                var v2 = new hvec5(new Half(8), new Half(9.5), new Half(1.5), new Half(-8.5), new Half(7));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-6), new Half(4), new Half(5), new Half(-1.5), new Half(2.5));
                var v1 = new hvec5(new Half(9.5), new Half(-9), new Half(3.5), new Half(-6), new Half(-0.5));
                var v2 = new hvec5(new Half(5.5), new Half(6.5), new Half(-8.5), new Half(8.5), new Half(-5.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-1.5), new Half(5), new Half(4.5), new Half(-8), new Half(9));
                var v1 = new hvec5(new Half(4.5), new Half(-7.5), new Half(4.5), new Half(-6.5), new Half(-9.5));
                var v2 = new hvec5(new Half(4.5), new Half(9), new Half(-1), new Half(3.5), new Half(3));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(7), new Half(-3), new Half(-1), Half.Zero, new Half(8));
                var v1 = new hvec5(new Half(9.5), new Half(-6), new Half(-7), new Half(4), new Half(3));
                var v2 = new hvec5(new Half(-8.5), new Half(-8), new Half(-9.5), new Half(-7), new Half(4.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(4.5), new Half(7), new Half(7.5), new Half(3.5), new Half(4.5));
                var v1 = new hvec5(new Half(2), new Half(4), new Half(-3), new Half(-2), new Half(-3));
                var v2 = new hvec5(new Half(3.5), new Half(9), new Half(-6.5), new Half(7), new Half(7.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec5(new Half(-0.5), new Half(7), new Half(9.5), new Half(-2), new Half(-7.5));
                var v1 = new hvec5(new Half(-6.5), new Half(-3.5), new Half(-8.5), new Half(-0.5), new Half(-5.5));
                var v2 = new hvec5(new Half(-3), new Half(-0.5), new Half(-0.5), new Half(-5), new Half(-1.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new hvec5(new Half(-6), new Half(3), new Half(-8.5), new Half(3), new Half(-9.5));
                var v1 = new hvec5(new Half(-0.5), new Half(-2.5), new Half(-6.5), new Half(8), new Half(-9));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(7), new Half(-8.5), new Half(7), new Half(-2), new Half(4));
                var v1 = new hvec5(new Half(2.5), new Half(8), new Half(-6.5), new Half(-1), new Half(-5.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(8.5), new Half(-6), new Half(7), new Half(4), Half.Zero);
                var v1 = new hvec5(new Half(-3.5), Half.Zero, new Half(4.5), new Half(-9.5), new Half(-6));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(-3), new Half(-5), Half.Zero, new Half(-2.5), new Half(3));
                var v1 = new hvec5(new Half(6.5), new Half(0.5), new Half(-9), new Half(6), new Half(-8));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(-5), new Half(-1.5), new Half(3), new Half(4.5), new Half(8));
                var v1 = new hvec5(new Half(3.5), new Half(4.5), new Half(-9.5), Half.One, new Half(-3.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(5.5), new Half(-1), new Half(-2), new Half(-4), new Half(-3.5));
                var v1 = new hvec5(new Half(9.5), new Half(6.5), new Half(-7), new Half(2), new Half(4.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(-0.5), new Half(2.5), new Half(3), new Half(2.5), new Half(6));
                var v1 = new hvec5(new Half(3.5), new Half(-9.5), new Half(-9.5), new Half(8), new Half(7));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(2), new Half(0.5), new Half(-7), new Half(2.5), new Half(8));
                var v1 = new hvec5(new Half(9), new Half(-3), new Half(-3), new Half(6.5), new Half(7));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(1.5), new Half(-9.5), new Half(3.5), new Half(3.5), new Half(-8.5));
                var v1 = new hvec5(new Half(2), new Half(3), new Half(-2.5), Half.One, new Half(3));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec5(new Half(9.5), new Half(-4), new Half(-6), new Half(-3), new Half(-1.5));
                var v1 = new hvec5(new Half(-6.5), new Half(-4.5), new Half(-1), new Half(-1.5), new Half(-5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new hvec5(new Half(-6), new Half(6), new Half(5), new Half(7.5), new Half(8.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(3), new Half(-7), new Half(1.5), new Half(-3), Half.One);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(1.5), new Half(5), new Half(3), new Half(-3), new Half(6.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(2), new Half(-8.5), new Half(3), new Half(5), new Half(-8));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(-3), new Half(3.5), new Half(5.5), new Half(-8), new Half(2));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(6), new Half(-7.5), new Half(-8), new Half(3), new Half(7));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(3.5), new Half(-3.5), new Half(5), new Half(-7.5), new Half(-8.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(9.5), new Half(5), new Half(-6.5), new Half(-6.5), new Half(-9.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(-7.5), new Half(9.5), new Half(-1.5), new Half(9.5), new Half(-9));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec5(new Half(2.5), new Half(9), new Half(5), new Half(-7.5), Half.One);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(544365117);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.Random(random, 4, 6);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5, 1.0);
            Assert.AreEqual(avg.y, 5, 1.0);
            Assert.AreEqual(avg.z, 5, 1.0);
            Assert.AreEqual(avg.w, 5, 1.0);
            Assert.AreEqual(avg.v, 5, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.v, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1262933119);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomUniform(random, 2, 3);
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
        public void RandomUniform2()
        {
            var random = new Random(1981501121);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.Random(random, -3, -2);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2.5, 1.0);
            Assert.AreEqual(avg.y, -2.5, 1.0);
            Assert.AreEqual(avg.z, -2.5, 1.0);
            Assert.AreEqual(avg.w, -2.5, 1.0);
            Assert.AreEqual(avg.v, -2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.v, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(552585476);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomUniform(random, 2, 4);
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
        public void RandomUniform4()
        {
            var random = new Random(1965060403);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.Random(random, -3, -1);
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
        public void RandomGaussian0()
        {
            var random = new Random(401357146);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomNormal(random, new Half(0.60541556896894), new Half(5.23918231261856));
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.60541556896894, 1.0);
            Assert.AreEqual(avg.y, 0.60541556896894, 1.0);
            Assert.AreEqual(avg.z, 0.60541556896894, 1.0);
            Assert.AreEqual(avg.w, 0.60541556896894, 1.0);
            Assert.AreEqual(avg.v, 0.60541556896894, 1.0);
            
            Assert.AreEqual(variance.x, 5.23918231261856, 3.0);
            Assert.AreEqual(variance.y, 5.23918231261856, 3.0);
            Assert.AreEqual(variance.z, 5.23918231261856, 3.0);
            Assert.AreEqual(variance.w, 5.23918231261856, 3.0);
            Assert.AreEqual(variance.v, 5.23918231261856, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(406025913);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomGaussian(random, new Half(1.21467298791496), new Half(1.06522366454137));
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.21467298791496, 1.0);
            Assert.AreEqual(avg.y, 1.21467298791496, 1.0);
            Assert.AreEqual(avg.z, 1.21467298791496, 1.0);
            Assert.AreEqual(avg.w, 1.21467298791496, 1.0);
            Assert.AreEqual(avg.v, 1.21467298791496, 1.0);
            
            Assert.AreEqual(variance.x, 1.06522366454137, 3.0);
            Assert.AreEqual(variance.y, 1.06522366454137, 3.0);
            Assert.AreEqual(variance.z, 1.06522366454137, 3.0);
            Assert.AreEqual(variance.w, 1.06522366454137, 3.0);
            Assert.AreEqual(variance.v, 1.06522366454137, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(995315062);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomNormal(random, new Half(1.31678107162788), new Half(2.68325790422189));
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.31678107162788, 1.0);
            Assert.AreEqual(avg.y, 1.31678107162788, 1.0);
            Assert.AreEqual(avg.z, 1.31678107162788, 1.0);
            Assert.AreEqual(avg.w, 1.31678107162788, 1.0);
            Assert.AreEqual(avg.v, 1.31678107162788, 1.0);
            
            Assert.AreEqual(variance.x, 2.68325790422189, 3.0);
            Assert.AreEqual(variance.y, 2.68325790422189, 3.0);
            Assert.AreEqual(variance.z, 2.68325790422189, 3.0);
            Assert.AreEqual(variance.w, 2.68325790422189, 3.0);
            Assert.AreEqual(variance.v, 2.68325790422189, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(830990676);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomGaussian(random, new Half(-0.314423536096897), new Half(1.49893451086196));
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.314423536096897, 1.0);
            Assert.AreEqual(avg.y, -0.314423536096897, 1.0);
            Assert.AreEqual(avg.z, -0.314423536096897, 1.0);
            Assert.AreEqual(avg.w, -0.314423536096897, 1.0);
            Assert.AreEqual(avg.v, -0.314423536096897, 1.0);
            
            Assert.AreEqual(variance.x, 1.49893451086196, 3.0);
            Assert.AreEqual(variance.y, 1.49893451086196, 3.0);
            Assert.AreEqual(variance.z, 1.49893451086196, 3.0);
            Assert.AreEqual(variance.w, 1.49893451086196, 3.0);
            Assert.AreEqual(variance.v, 1.49893451086196, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1964220411);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomNormal(random, new Half(-0.321572353281813), new Half(9.88696223585259));
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.321572353281813, 1.0);
            Assert.AreEqual(avg.y, -0.321572353281813, 1.0);
            Assert.AreEqual(avg.z, -0.321572353281813, 1.0);
            Assert.AreEqual(avg.w, -0.321572353281813, 1.0);
            Assert.AreEqual(avg.v, -0.321572353281813, 1.0);
            
            Assert.AreEqual(variance.x, 9.88696223585259, 3.0);
            Assert.AreEqual(variance.y, 9.88696223585259, 3.0);
            Assert.AreEqual(variance.z, 9.88696223585259, 3.0);
            Assert.AreEqual(variance.w, 9.88696223585259, 3.0);
            Assert.AreEqual(variance.v, 9.88696223585259, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(2021094564);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomNormal(random);
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
            var random = new Random(995510736);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomNormal(random);
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
            var random = new Random(2117410555);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomNormal(random);
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
            var random = new Random(1091826727);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomNormal(random);
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
            var random = new Random(1828462582);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec5.RandomNormal(random);
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
