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
    public class FloatVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec5(8.5f);
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
                Assert.AreEqual(8.5f, v.v);
            }
            {
                var v = new vec5(1f, -2f, -1f, 2f, 5.5f);
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(2f, v.w);
                Assert.AreEqual(5.5f, v.v);
            }
            {
                var v = new vec5(new vec2(-1f, -6f));
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var v = new vec5(new vec3(-6f, 0f, -3.5f));
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(0f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var v = new vec5(new vec4(-7f, 3.5f, 5.5f, -8f));
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-8f, v.w);
                Assert.AreEqual(0f, v.v);
            }
            {
                var v = new vec5(new vec5(-0.5f, -4.5f, 3.5f, 3.5f, -9f));
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
                Assert.AreEqual(-9f, v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec5(8.5f, -8f, 5.5f, -7f, -1f);
            Assert.AreEqual(8.5f, v[0]);
            Assert.AreEqual(-8f, v[1]);
            Assert.AreEqual(5.5f, v[2]);
            Assert.AreEqual(-7f, v[3]);
            Assert.AreEqual(-1f, v[4]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            
            v[2] = 0f;
            Assert.AreEqual(0f, v[2]);
            v[3] = 1f;
            Assert.AreEqual(1f, v[3]);
            v[1] = 2f;
            Assert.AreEqual(2f, v[1]);
            v[4] = 3f;
            Assert.AreEqual(3f, v[4]);
            v[0] = 4f;
            Assert.AreEqual(4f, v[0]);
            v[4] = 5f;
            Assert.AreEqual(5f, v[4]);
            v[3] = 6f;
            Assert.AreEqual(6f, v[3]);
            v[3] = 7f;
            Assert.AreEqual(7f, v[3]);
            v[2] = 8f;
            Assert.AreEqual(8f, v[2]);
            v[4] = 9f;
            Assert.AreEqual(9f, v[4]);
            v[3] = -1f;
            Assert.AreEqual(-1f, v[3]);
            v[4] = -2f;
            Assert.AreEqual(-2f, v[4]);
            v[1] = -3f;
            Assert.AreEqual(-3f, v[1]);
            v[3] = -4f;
            Assert.AreEqual(-4f, v[3]);
            v[4] = -5f;
            Assert.AreEqual(-5f, v[4]);
            v[1] = -6f;
            Assert.AreEqual(-6f, v[1]);
            v[2] = -7f;
            Assert.AreEqual(-7f, v[2]);
            v[4] = -8f;
            Assert.AreEqual(-8f, v[4]);
            v[2] = -9f;
            Assert.AreEqual(-9f, v[2]);
            v[1] = -9.5f;
            Assert.AreEqual(-9.5f, v[1]);
            v[3] = -8.5f;
            Assert.AreEqual(-8.5f, v[3]);
            v[4] = -7.5f;
            Assert.AreEqual(-7.5f, v[4]);
            v[3] = -6.5f;
            Assert.AreEqual(-6.5f, v[3]);
            v[3] = -5.5f;
            Assert.AreEqual(-5.5f, v[3]);
            v[1] = -4.5f;
            Assert.AreEqual(-4.5f, v[1]);
            v[1] = -3.5f;
            Assert.AreEqual(-3.5f, v[1]);
            v[0] = -2.5f;
            Assert.AreEqual(-2.5f, v[0]);
            v[2] = -1.5f;
            Assert.AreEqual(-1.5f, v[2]);
            v[1] = -0.5f;
            Assert.AreEqual(-0.5f, v[1]);
            v[2] = 0.5f;
            Assert.AreEqual(0.5f, v[2]);
            v[4] = 1.5f;
            Assert.AreEqual(1.5f, v[4]);
            v[0] = 2.5f;
            Assert.AreEqual(2.5f, v[0]);
            v[4] = 3.5f;
            Assert.AreEqual(3.5f, v[4]);
            v[2] = 4.5f;
            Assert.AreEqual(4.5f, v[2]);
            v[2] = 5.5f;
            Assert.AreEqual(5.5f, v[2]);
            v[0] = 6.5f;
            Assert.AreEqual(6.5f, v[0]);
            v[4] = 7.5f;
            Assert.AreEqual(7.5f, v[4]);
            v[2] = 8.5f;
            Assert.AreEqual(8.5f, v[2]);
            v[1] = 9.5f;
            Assert.AreEqual(9.5f, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new vec5(-5.5f, -6.5f, -2.5f, 0.5f, -4f);
            var vals = v.Values;
            Assert.AreEqual(-5.5f, vals[0]);
            Assert.AreEqual(-6.5f, vals[1]);
            Assert.AreEqual(-2.5f, vals[2]);
            Assert.AreEqual(0.5f, vals[3]);
            Assert.AreEqual(-4f, vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0f, vec5.Zero.x);
            Assert.AreEqual(0f, vec5.Zero.y);
            Assert.AreEqual(0f, vec5.Zero.z);
            Assert.AreEqual(0f, vec5.Zero.w);
            Assert.AreEqual(0f, vec5.Zero.v);
            
            Assert.AreEqual(1f, vec5.Ones.x);
            Assert.AreEqual(1f, vec5.Ones.y);
            Assert.AreEqual(1f, vec5.Ones.z);
            Assert.AreEqual(1f, vec5.Ones.w);
            Assert.AreEqual(1f, vec5.Ones.v);
            
            Assert.AreEqual(1f, vec5.UnitX.x);
            Assert.AreEqual(0f, vec5.UnitX.y);
            Assert.AreEqual(0f, vec5.UnitX.z);
            Assert.AreEqual(0f, vec5.UnitX.w);
            Assert.AreEqual(0f, vec5.UnitX.v);
            
            Assert.AreEqual(0f, vec5.UnitY.x);
            Assert.AreEqual(1f, vec5.UnitY.y);
            Assert.AreEqual(0f, vec5.UnitY.z);
            Assert.AreEqual(0f, vec5.UnitY.w);
            Assert.AreEqual(0f, vec5.UnitY.v);
            
            Assert.AreEqual(0f, vec5.UnitZ.x);
            Assert.AreEqual(0f, vec5.UnitZ.y);
            Assert.AreEqual(1f, vec5.UnitZ.z);
            Assert.AreEqual(0f, vec5.UnitZ.w);
            Assert.AreEqual(0f, vec5.UnitZ.v);
            
            Assert.AreEqual(0f, vec5.UnitW.x);
            Assert.AreEqual(0f, vec5.UnitW.y);
            Assert.AreEqual(0f, vec5.UnitW.z);
            Assert.AreEqual(1f, vec5.UnitW.w);
            Assert.AreEqual(0f, vec5.UnitW.v);
            
            Assert.AreEqual(0f, vec5.UnitV.x);
            Assert.AreEqual(0f, vec5.UnitV.y);
            Assert.AreEqual(0f, vec5.UnitV.z);
            Assert.AreEqual(0f, vec5.UnitV.w);
            Assert.AreEqual(1f, vec5.UnitV.v);
            
            Assert.AreEqual(float.MaxValue, vec5.MaxValue.x);
            Assert.AreEqual(float.MaxValue, vec5.MaxValue.y);
            Assert.AreEqual(float.MaxValue, vec5.MaxValue.z);
            Assert.AreEqual(float.MaxValue, vec5.MaxValue.w);
            Assert.AreEqual(float.MaxValue, vec5.MaxValue.v);
            
            Assert.AreEqual(float.MinValue, vec5.MinValue.x);
            Assert.AreEqual(float.MinValue, vec5.MinValue.y);
            Assert.AreEqual(float.MinValue, vec5.MinValue.z);
            Assert.AreEqual(float.MinValue, vec5.MinValue.w);
            Assert.AreEqual(float.MinValue, vec5.MinValue.v);
            
            Assert.AreEqual(float.Epsilon, vec5.Epsilon.x);
            Assert.AreEqual(float.Epsilon, vec5.Epsilon.y);
            Assert.AreEqual(float.Epsilon, vec5.Epsilon.z);
            Assert.AreEqual(float.Epsilon, vec5.Epsilon.w);
            Assert.AreEqual(float.Epsilon, vec5.Epsilon.v);
            
            Assert.AreEqual(float.NaN, vec5.NaN.x);
            Assert.AreEqual(float.NaN, vec5.NaN.y);
            Assert.AreEqual(float.NaN, vec5.NaN.z);
            Assert.AreEqual(float.NaN, vec5.NaN.w);
            Assert.AreEqual(float.NaN, vec5.NaN.v);
            
            Assert.AreEqual(float.NegativeInfinity, vec5.NegativeInfinity.x);
            Assert.AreEqual(float.NegativeInfinity, vec5.NegativeInfinity.y);
            Assert.AreEqual(float.NegativeInfinity, vec5.NegativeInfinity.z);
            Assert.AreEqual(float.NegativeInfinity, vec5.NegativeInfinity.w);
            Assert.AreEqual(float.NegativeInfinity, vec5.NegativeInfinity.v);
            
            Assert.AreEqual(float.PositiveInfinity, vec5.PositiveInfinity.x);
            Assert.AreEqual(float.PositiveInfinity, vec5.PositiveInfinity.y);
            Assert.AreEqual(float.PositiveInfinity, vec5.PositiveInfinity.z);
            Assert.AreEqual(float.PositiveInfinity, vec5.PositiveInfinity.w);
            Assert.AreEqual(float.PositiveInfinity, vec5.PositiveInfinity.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new vec5(-3f, 8f, 4.5f, -3f, -1.5f);
            var v2 = new vec5(-3f, 8f, 4.5f, -3f, -1.5f);
            var v3 = new vec5(-1.5f, -3f, 4.5f, 8f, -3f);
            Assert.That(v1 == new vec5(v1));
            Assert.That(v2 == new vec5(v2));
            Assert.That(v3 == new vec5(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new vec5(0f, -9.5f, 0.5f, -5f, -1.5f);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = vec5.Parse(s0);
            var v1 = vec5.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = vec5.TryParse(s0, out v0);
            var b1 = vec5.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = vec5.TryParse(null, out v0);
            Assert.False(b0);
            b0 = vec5.TryParse("", out v0);
            Assert.False(b0);
            b0 = vec5.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { vec5.Parse(null); });
            Assert.Throws<FormatException>(() => { vec5.Parse(""); });
            Assert.Throws<FormatException>(() => { vec5.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = vec5.Parse(s3, "; ", NumberStyles.Number);
            var v4 = vec5.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = vec5.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new vec5(-6.5f, 0.5f, 6f, 4.5f, 9.5f);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<vec5>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new vec5(7.5f, 2.5f, 8.5f, -3.5f, -0.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(6f, -6.5f, -6f, -8f, 4.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(-0.5f, -8f, -6f, 5.5f, -1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(1f, 0.5f, -5f, 1f, -9f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(3.5f, 3.5f, 5f, -6f, -3.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(1.5f, 3f, -2.5f, 7f, 4f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(-0.5f, -3f, -1.5f, -1f, -9.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(3f, -2.5f, -2.5f, 8.5f, 1.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(-8f, 3.5f, 9.5f, -6f, -8f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec5(0.5f, 8f, 5.5f, 7f, -2.5f);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new vec5(6.5f, 6.5f, 2f, 6.5f, 3.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(1.5f, -2.5f, -3.5f, 5.5f, 3f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(4f, -9f, -2f, -6f, -3f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(-0.5f, 9.5f, 4f, -4f, -8.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(-5f, 7.5f, 9f, 0f, 4f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(3f, -6f, 8f, -8.5f, 1.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(9f, -5.5f, 1.5f, -8.5f, 6.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(6f, 9f, -5.5f, 5f, -0.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(7.5f, -3.5f, -2f, -6.5f, -9.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec5(2.5f, 3f, 6f, 2.5f, -0.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new vec5(-2f, 7.5f, -6.5f, -6f, -8f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(-0.5f, 6.5f, 5f, 8f, -6.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(2f, -2f, -8.5f, 0.5f, 9f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(5.5f, 0f, 0f, -6f, 4f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(4.5f, -6f, -5f, 4.5f, 6f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(1f, -3.5f, -4.5f, -4.5f, 1.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(1.5f, 3.5f, -6f, -9f, 2.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(5f, 4.5f, -9f, -9f, 6f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(-0.5f, -0.5f, -7f, -5.5f, 8f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec5(3f, -7f, 6.5f, 7.5f, 3.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new vec5(-3.5f, 5f, 4f, -4.5f, 5.5f);
                var v1 = new vec5(-3.5f, -9f, 1.5f, 2.5f, -1f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(3.5f, -4f, 8f, -8f, 9f);
                var v1 = new vec5(-8.5f, -6.5f, 0f, 4f, 0.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(9.5f, -4.5f, 3f, 5f, -8f);
                var v1 = new vec5(2.5f, -7f, 8f, -7.5f, -5.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(6.5f, -6.5f, -6.5f, 7f, -7.5f);
                var v1 = new vec5(3.5f, 2f, -2.5f, -4f, -8f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(-6f, -3f, 3.5f, -1f, -3.5f);
                var v1 = new vec5(6.5f, 4f, 7.5f, -9f, 8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(2f, 0.5f, -4.5f, -6.5f, 3.5f);
                var v1 = new vec5(1f, 2f, 8.5f, 6f, 2f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(9f, -1f, 9f, 8f, -4f);
                var v1 = new vec5(-1f, 0.5f, 0f, 5.5f, -6f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(-8f, 6.5f, -3.5f, -2.5f, -5f);
                var v1 = new vec5(-3.5f, 2.5f, 2.5f, -9f, -7.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(-2.5f, -9f, -0.5f, -5.5f, -8.5f);
                var v1 = new vec5(6f, 7.5f, 9.5f, -5f, -8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec5(1.5f, 3f, -9.5f, -1f, 7f);
                var v1 = new vec5(4f, 3f, -5.5f, 7.5f, -6f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new vec5(4f, 9f, 7.5f, 4f, 5f);
                var v1 = new vec5(6f, 4f, 7.5f, 9f, -3.5f);
                var v2 = new vec5(-8.5f, 7f, -5f, -7f, -9f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(7f, 6f, 2f, -2f, 3f);
                var v1 = new vec5(-4f, -6.5f, -9.5f, 1.5f, -7f);
                var v2 = new vec5(2.5f, -2f, 5.5f, 8f, -9f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(4.5f, 6f, -3.5f, 9.5f, -1.5f);
                var v1 = new vec5(-8.5f, -7.5f, -7.5f, 0f, 5f);
                var v2 = new vec5(9.5f, -7.5f, -7f, 9.5f, 6f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(7f, -6.5f, -6.5f, 6f, 9f);
                var v1 = new vec5(7f, -6.5f, -1f, -2f, -9.5f);
                var v2 = new vec5(-8.5f, -0.5f, 5f, -2.5f, -3f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(4.5f, 8f, -1.5f, 1.5f, 2.5f);
                var v1 = new vec5(-5f, -8.5f, -6f, -0.5f, 7.5f);
                var v2 = new vec5(-4.5f, -5.5f, 2f, 6f, 4f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(2.5f, 6f, -9.5f, -5.5f, 9f);
                var v1 = new vec5(8f, -0.5f, -0.5f, 9.5f, -1f);
                var v2 = new vec5(-1f, 5.5f, -5f, -9f, 6f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(1.5f, -7f, 4.5f, -2.5f, -1f);
                var v1 = new vec5(0.5f, 3.5f, -3.5f, 7f, 2.5f);
                var v2 = new vec5(-3.5f, 7f, 4.5f, 9f, -4.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(-5.5f, -8.5f, 3f, 7f, -1.5f);
                var v1 = new vec5(-5f, 9f, -8.5f, -8f, 4f);
                var v2 = new vec5(5f, -9.5f, -0.5f, -9.5f, -7.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(-9f, 6f, 6.5f, -6.5f, 5f);
                var v1 = new vec5(8f, -0.5f, -6f, 5.5f, -4f);
                var v2 = new vec5(9.5f, -8.5f, -3f, 2.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec5(0f, 5.5f, -9f, -4f, -2.5f);
                var v1 = new vec5(-0.5f, 2.5f, 7f, 1.5f, 1.5f);
                var v2 = new vec5(-7.5f, 5.5f, -7f, -6.5f, 5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new vec5(5f, 6.5f, 2.5f, 1f, -8f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(6.5f, -8.5f, -3.5f, -8f, -6f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(-5f, -2.5f, 4f, 4f, 3.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(9.5f, 1f, 1f, 7.5f, -5.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(-5.5f, 6.5f, -0.5f, 2f, 5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(3.5f, -9.5f, 8f, -4.5f, 4f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(1f, 2.5f, 5.5f, -9f, -7f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(-4.5f, 7f, -9f, 5f, -1.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(-9.5f, -0.5f, 9f, 6.5f, 0.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec5(2.5f, 8f, -3.5f, -5.5f, -2.5f);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new vec5(-2f, -9.5f, 8f, 6f, 4.5f);
                var v1 = new vec5(9.5f, -6f, 6.5f, 5f, 9.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(1f, -4.5f, -8.5f, 9f, -2f);
                var v1 = new vec5(-5f, -1f, -7f, -4f, 3.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(-4.5f, -5f, -7.5f, -8f, -6.5f);
                var v1 = new vec5(8.5f, -8.5f, 7f, 7f, 5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(-3.5f, -1.5f, 0.5f, 7.5f, -6.5f);
                var v1 = new vec5(6f, -8f, 8.5f, 4f, 6.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(-3.5f, -9.5f, -1.5f, 5.5f, -0.5f);
                var v1 = new vec5(-9f, -4.5f, 0f, -5.5f, -2f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(4f, 4.5f, -5.5f, 2.5f, 6f);
                var v1 = new vec5(6.5f, 8.5f, 0.5f, -5.5f, 6.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(-8f, 7f, -0.5f, 0f, -4f);
                var v1 = new vec5(-4f, 4.5f, -5.5f, -2.5f, 5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(7.5f, -3f, -2f, -7f, 7f);
                var v1 = new vec5(4f, -3.5f, -3.5f, -1.5f, 3f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(-3f, -8.5f, -5.5f, 6.5f, 0f);
                var v1 = new vec5(2.5f, 4f, 8.5f, 1.5f, -3.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec5(7f, -2.5f, -5f, 8f, -9f);
                var v1 = new vec5(-8f, 0.5f, -1.5f, -7.5f, -6f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new vec5(3f, -1.5f, 5.5f, -2.5f, 3f);
                var v1 = new vec5(2.5f, 3f, -1.5f, 9f, 0f);
                var v2 = new vec5(-9f, -9.5f, -6f, -2.5f, -1.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(6.5f, 6f, -6.5f, -8.5f, -3f);
                var v1 = new vec5(-2f, -6f, -3.5f, -8.5f, 7.5f);
                var v2 = new vec5(9.5f, 2.5f, 5f, -4f, 8.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(-2f, -5f, 6.5f, -7.5f, -1.5f);
                var v1 = new vec5(1.5f, 6f, 1f, 2.5f, -3.5f);
                var v2 = new vec5(-2f, 1f, 8f, 4.5f, 3.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(-5f, -8.5f, 3.5f, -7f, -2f);
                var v1 = new vec5(-3f, -1f, -7.5f, 1.5f, -1f);
                var v2 = new vec5(-1.5f, 2f, -4f, 0.5f, 3f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(9.5f, 8.5f, -5f, -2f, -0.5f);
                var v1 = new vec5(3f, -5.5f, 3.5f, 8.5f, 6.5f);
                var v2 = new vec5(-0.5f, 5f, 1.5f, 5.5f, 1f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(9f, 7f, 1.5f, -1.5f, -7.5f);
                var v1 = new vec5(-8f, 9.5f, -0.5f, 1f, -4.5f);
                var v2 = new vec5(0f, 3.5f, 4f, -2f, 0f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(-0.5f, 3.5f, -1f, -1.5f, -3.5f);
                var v1 = new vec5(-4f, -2.5f, 7.5f, 4f, -0.5f);
                var v2 = new vec5(1.5f, -1.5f, 4.5f, -9.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(7f, -9.5f, -2.5f, 0.5f, 0f);
                var v1 = new vec5(-8.5f, -1f, -3.5f, 8f, -4.5f);
                var v2 = new vec5(0f, 8f, -3f, -3.5f, -0.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(-1f, -9f, -8.5f, 7.5f, 6f);
                var v1 = new vec5(6.5f, 4.5f, 3f, 8f, -1.5f);
                var v2 = new vec5(-6.5f, 9f, -3.5f, 8.5f, 0.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec5(0.5f, 4f, 9f, -9f, -8f);
                var v1 = new vec5(-9.5f, 5f, -5f, -2f, -9.5f);
                var v2 = new vec5(-9f, 7f, 2f, 2f, -4.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new vec5(-0.5f, -2f, -9f, 6f, -9f);
                var v1 = new vec5(-5f, -3f, 1.5f, 0f, 5.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(-5f, -2f, 7f, -1f, 5.5f);
                var v1 = new vec5(-4f, -9f, -8.5f, -5f, -3.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(-6.5f, -3f, -4f, 4f, 9.5f);
                var v1 = new vec5(-2f, 8f, -3f, 7.5f, -1.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(-6.5f, -6f, 9f, -8f, -1f);
                var v1 = new vec5(4f, 3.5f, -9f, 7.5f, -7.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(-6.5f, -8f, 0f, 9.5f, -9f);
                var v1 = new vec5(0f, 9f, 1.5f, 3.5f, -6.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(-8.5f, -6.5f, 9.5f, 5.5f, 1f);
                var v1 = new vec5(-6f, 7.5f, -4f, 7f, 7f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(5f, 0f, 4.5f, -3f, -3f);
                var v1 = new vec5(8.5f, 1f, -0.5f, 9.5f, 0.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(-8.5f, 9.5f, -6.5f, 2.5f, 3f);
                var v1 = new vec5(4f, -3f, -5f, -4.5f, 9.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(1f, -8f, -9f, -4f, 6f);
                var v1 = new vec5(0f, -6f, -5f, -7f, 5.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec5(7f, -9f, -1f, 0.5f, -7f);
                var v1 = new vec5(-7.5f, -5.5f, -2.5f, -2.5f, -9.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new vec5(9f, 9.5f, -4f, -1.5f, -9f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(7.5f, -9.5f, -3.5f, -8.5f, 1f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(5.5f, -4f, 8.5f, 1.5f, 5.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(6.5f, 2.5f, -1f, -3f, 7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(1f, -8.5f, -3f, 4.5f, -4.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(4f, 7.5f, 6f, -5.5f, 5.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(-6f, -6.5f, 8f, -3f, -4f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(5f, 6f, -9f, 2.5f, -6.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(-6.5f, 7.5f, -3.5f, 5f, 3f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec5(6f, 4f, 7f, -7f, -9.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(134073592);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.Random(random, -1, 3);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1, 1.0);
            Assert.AreEqual(avg.y, 1, 1.0);
            Assert.AreEqual(avg.z, 1, 1.0);
            Assert.AreEqual(avg.w, 1, 1.0);
            Assert.AreEqual(avg.v, 1, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.v, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1562989237);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomUniform(random, 4, 8);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 6, 1.0);
            Assert.AreEqual(avg.y, 6, 1.0);
            Assert.AreEqual(avg.z, 6, 1.0);
            Assert.AreEqual(avg.w, 6, 1.0);
            Assert.AreEqual(avg.v, 6, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.v, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(844421235);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.Random(random, -1, 3);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1, 1.0);
            Assert.AreEqual(avg.y, 1, 1.0);
            Assert.AreEqual(avg.z, 1, 1.0);
            Assert.AreEqual(avg.w, 1, 1.0);
            Assert.AreEqual(avg.v, 1, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.v, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(125853233);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomUniform(random, 4, 7);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5.5, 1.0);
            Assert.AreEqual(avg.y, 5.5, 1.0);
            Assert.AreEqual(avg.z, 5.5, 1.0);
            Assert.AreEqual(avg.w, 5.5, 1.0);
            Assert.AreEqual(avg.v, 5.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
            Assert.AreEqual(variance.v, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(860861953);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.Random(random, -1, 2);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            Assert.AreEqual(avg.z, 0.5, 1.0);
            Assert.AreEqual(avg.w, 0.5, 1.0);
            Assert.AreEqual(avg.v, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
            Assert.AreEqual(variance.v, 0.75, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(277081563);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomNormal(random, -1.82130646883571f, 4.64241886261963f);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.82130646883571, 1.0);
            Assert.AreEqual(avg.y, -1.82130646883571, 1.0);
            Assert.AreEqual(avg.z, -1.82130646883571, 1.0);
            Assert.AreEqual(avg.w, -1.82130646883571, 1.0);
            Assert.AreEqual(avg.v, -1.82130646883571, 1.0);
            
            Assert.AreEqual(variance.x, 4.64241886261963, 3.0);
            Assert.AreEqual(variance.y, 4.64241886261963, 3.0);
            Assert.AreEqual(variance.z, 4.64241886261963, 3.0);
            Assert.AreEqual(variance.w, 4.64241886261963, 3.0);
            Assert.AreEqual(variance.v, 4.64241886261963, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(955266259);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomGaussian(random, 1.56943611221827f, 8.8163775386365f);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.56943611221827, 1.0);
            Assert.AreEqual(avg.y, 1.56943611221827, 1.0);
            Assert.AreEqual(avg.z, 1.56943611221827, 1.0);
            Assert.AreEqual(avg.w, 1.56943611221827, 1.0);
            Assert.AreEqual(avg.v, 1.56943611221827, 1.0);
            
            Assert.AreEqual(variance.x, 8.8163775386365, 3.0);
            Assert.AreEqual(variance.y, 8.8163775386365, 3.0);
            Assert.AreEqual(variance.z, 8.8163775386365, 3.0);
            Assert.AreEqual(variance.w, 8.8163775386365, 3.0);
            Assert.AreEqual(variance.v, 8.8163775386365, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(365977110);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomNormal(random, -0.676335477585129f, 2.13580836175746f);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.676335477585129, 1.0);
            Assert.AreEqual(avg.y, -0.676335477585129, 1.0);
            Assert.AreEqual(avg.z, -0.676335477585129, 1.0);
            Assert.AreEqual(avg.w, -0.676335477585129, 1.0);
            Assert.AreEqual(avg.v, -0.676335477585129, 1.0);
            
            Assert.AreEqual(variance.x, 2.13580836175746, 3.0);
            Assert.AreEqual(variance.y, 2.13580836175746, 3.0);
            Assert.AreEqual(variance.z, 2.13580836175746, 3.0);
            Assert.AreEqual(variance.w, 2.13580836175746, 3.0);
            Assert.AreEqual(variance.v, 2.13580836175746, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(530301496);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomGaussian(random, 0.954869130139644f, 3.32013169923803f);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.954869130139644, 1.0);
            Assert.AreEqual(avg.y, 0.954869130139644, 1.0);
            Assert.AreEqual(avg.z, 0.954869130139644, 1.0);
            Assert.AreEqual(avg.w, 0.954869130139644, 1.0);
            Assert.AreEqual(avg.v, 0.954869130139644, 1.0);
            
            Assert.AreEqual(variance.x, 3.32013169923803, 3.0);
            Assert.AreEqual(variance.y, 3.32013169923803, 3.0);
            Assert.AreEqual(variance.z, 3.32013169923803, 3.0);
            Assert.AreEqual(variance.w, 3.32013169923803, 3.0);
            Assert.AreEqual(variance.v, 3.32013169923803, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1544555408);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomNormal(random, 0.96201794732456f, 4.9321039742474f);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.96201794732456, 1.0);
            Assert.AreEqual(avg.y, 0.96201794732456, 1.0);
            Assert.AreEqual(avg.z, 0.96201794732456, 1.0);
            Assert.AreEqual(avg.w, 0.96201794732456, 1.0);
            Assert.AreEqual(avg.v, 0.96201794732456, 1.0);
            
            Assert.AreEqual(variance.x, 4.9321039742474, 3.0);
            Assert.AreEqual(variance.y, 4.9321039742474, 3.0);
            Assert.AreEqual(variance.z, 4.9321039742474, 3.0);
            Assert.AreEqual(variance.w, 4.9321039742474, 3.0);
            Assert.AreEqual(variance.v, 4.9321039742474, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(804827792);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomNormal(random);
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
            var random = new Random(1830411620);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomNormal(random);
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
            var random = new Random(708511801);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomNormal(random);
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
            var random = new Random(1734095629);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomNormal(random);
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
            var random = new Random(997459774);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec5.RandomNormal(random);
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
