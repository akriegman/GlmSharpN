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
    public class UintVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec5(9u);
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
                Assert.AreEqual(9u, v.v);
            }
            {
                var v = new uvec5(2u, 5u, 9u, 3u, 1u);
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(3u, v.w);
                Assert.AreEqual(1u, v.v);
            }
            {
                var v = new uvec5(new uvec2(4u, 7u));
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var v = new uvec5(new uvec3(0u, 6u, 9u));
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(0u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var v = new uvec5(new uvec4(5u, 0u, 8u, 2u));
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(2u, v.w);
                Assert.AreEqual(0u, v.v);
            }
            {
                var v = new uvec5(new uvec5(4u, 4u, 2u, 1u, 2u));
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(1u, v.w);
                Assert.AreEqual(2u, v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec5(5u, 0u, 3u, 9u, 9u);
            Assert.AreEqual(5u, v[0]);
            Assert.AreEqual(0u, v[1]);
            Assert.AreEqual(3u, v[2]);
            Assert.AreEqual(9u, v[3]);
            Assert.AreEqual(9u, v[4]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[1] = 0u;
            Assert.AreEqual(0u, v[1]);
            v[0] = 1u;
            Assert.AreEqual(1u, v[0]);
            v[0] = 2u;
            Assert.AreEqual(2u, v[0]);
            v[1] = 3u;
            Assert.AreEqual(3u, v[1]);
            v[3] = 4u;
            Assert.AreEqual(4u, v[3]);
            v[1] = 5u;
            Assert.AreEqual(5u, v[1]);
            v[0] = 6u;
            Assert.AreEqual(6u, v[0]);
            v[1] = 7u;
            Assert.AreEqual(7u, v[1]);
            v[2] = 8u;
            Assert.AreEqual(8u, v[2]);
            v[1] = 9u;
            Assert.AreEqual(9u, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uvec5(5u, 7u, 9u, 4u, 5u);
            var vals = v.Values;
            Assert.AreEqual(5u, vals[0]);
            Assert.AreEqual(7u, vals[1]);
            Assert.AreEqual(9u, vals[2]);
            Assert.AreEqual(4u, vals[3]);
            Assert.AreEqual(5u, vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uvec5.Zero.x);
            Assert.AreEqual(0u, uvec5.Zero.y);
            Assert.AreEqual(0u, uvec5.Zero.z);
            Assert.AreEqual(0u, uvec5.Zero.w);
            Assert.AreEqual(0u, uvec5.Zero.v);
            
            Assert.AreEqual(1u, uvec5.Ones.x);
            Assert.AreEqual(1u, uvec5.Ones.y);
            Assert.AreEqual(1u, uvec5.Ones.z);
            Assert.AreEqual(1u, uvec5.Ones.w);
            Assert.AreEqual(1u, uvec5.Ones.v);
            
            Assert.AreEqual(1u, uvec5.UnitX.x);
            Assert.AreEqual(0u, uvec5.UnitX.y);
            Assert.AreEqual(0u, uvec5.UnitX.z);
            Assert.AreEqual(0u, uvec5.UnitX.w);
            Assert.AreEqual(0u, uvec5.UnitX.v);
            
            Assert.AreEqual(0u, uvec5.UnitY.x);
            Assert.AreEqual(1u, uvec5.UnitY.y);
            Assert.AreEqual(0u, uvec5.UnitY.z);
            Assert.AreEqual(0u, uvec5.UnitY.w);
            Assert.AreEqual(0u, uvec5.UnitY.v);
            
            Assert.AreEqual(0u, uvec5.UnitZ.x);
            Assert.AreEqual(0u, uvec5.UnitZ.y);
            Assert.AreEqual(1u, uvec5.UnitZ.z);
            Assert.AreEqual(0u, uvec5.UnitZ.w);
            Assert.AreEqual(0u, uvec5.UnitZ.v);
            
            Assert.AreEqual(0u, uvec5.UnitW.x);
            Assert.AreEqual(0u, uvec5.UnitW.y);
            Assert.AreEqual(0u, uvec5.UnitW.z);
            Assert.AreEqual(1u, uvec5.UnitW.w);
            Assert.AreEqual(0u, uvec5.UnitW.v);
            
            Assert.AreEqual(0u, uvec5.UnitV.x);
            Assert.AreEqual(0u, uvec5.UnitV.y);
            Assert.AreEqual(0u, uvec5.UnitV.z);
            Assert.AreEqual(0u, uvec5.UnitV.w);
            Assert.AreEqual(1u, uvec5.UnitV.v);
            
            Assert.AreEqual(uint.MaxValue, uvec5.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uvec5.MaxValue.y);
            Assert.AreEqual(uint.MaxValue, uvec5.MaxValue.z);
            Assert.AreEqual(uint.MaxValue, uvec5.MaxValue.w);
            Assert.AreEqual(uint.MaxValue, uvec5.MaxValue.v);
            
            Assert.AreEqual(uint.MinValue, uvec5.MinValue.x);
            Assert.AreEqual(uint.MinValue, uvec5.MinValue.y);
            Assert.AreEqual(uint.MinValue, uvec5.MinValue.z);
            Assert.AreEqual(uint.MinValue, uvec5.MinValue.w);
            Assert.AreEqual(uint.MinValue, uvec5.MinValue.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uvec5(3u, 0u, 6u, 6u, 4u);
            var v2 = new uvec5(3u, 0u, 6u, 6u, 4u);
            var v3 = new uvec5(4u, 6u, 6u, 0u, 3u);
            Assert.That(v1 == new uvec5(v1));
            Assert.That(v2 == new uvec5(v2));
            Assert.That(v3 == new uvec5(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uvec5(4u, 9u, 4u, 8u, 8u);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uvec5.Parse(s0);
            var v1 = uvec5.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uvec5.TryParse(s0, out v0);
            var b1 = uvec5.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uvec5.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uvec5.TryParse("", out v0);
            Assert.False(b0);
            b0 = uvec5.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uvec5.Parse(null); });
            Assert.Throws<FormatException>(() => { uvec5.Parse(""); });
            Assert.Throws<FormatException>(() => { uvec5.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uvec5.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uvec5.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uvec5.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new uvec5(5u, 9u, 4u, 5u, 2u);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<uvec5>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new uvec5(9u, 6u, 7u, 9u, 4u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(8u, 4u, 0u, 7u, 2u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(3u, 2u, 2u, 9u, 4u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(2u, 9u, 9u, 6u, 6u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(0u, 8u, 8u, 1u, 4u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(3u, 0u, 4u, 2u, 9u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(5u, 9u, 5u, 6u, 7u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(7u, 4u, 5u, 4u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(8u, 4u, 5u, 6u, 9u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec5(2u, 5u, 7u, 0u, 5u);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new uvec5(8u, 0u, 3u, 6u, 0u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(0u, 8u, 0u, 5u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(4u, 6u, 4u, 3u, 1u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(5u, 7u, 5u, 6u, 3u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(1u, 9u, 4u, 2u, 3u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(5u, 4u, 4u, 5u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(4u, 9u, 9u, 1u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(5u, 4u, 7u, 6u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(5u, 0u, 7u, 3u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec5(2u, 7u, 2u, 9u, 8u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new uvec5(2u, 1u, 8u, 0u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(0u, 0u, 5u, 8u, 2u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(3u, 4u, 7u, 6u, 0u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(6u, 8u, 4u, 7u, 9u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(6u, 3u, 5u, 0u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(4u, 6u, 8u, 6u, 9u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(0u, 1u, 5u, 1u, 5u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(5u, 0u, 6u, 0u, 1u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(3u, 0u, 8u, 3u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec5(5u, 0u, 0u, 0u, 9u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new uvec5(2u, 0u, 1u, 8u, 2u);
                var v1 = new uvec5(8u, 1u, 1u, 5u, 6u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(4u, 9u, 9u, 7u, 2u);
                var v1 = new uvec5(2u, 7u, 4u, 3u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(2u, 2u, 2u, 7u, 4u);
                var v1 = new uvec5(4u, 4u, 1u, 8u, 1u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(4u, 9u, 3u, 8u, 2u);
                var v1 = new uvec5(1u, 0u, 3u, 0u, 5u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(6u, 6u, 4u, 2u, 2u);
                var v1 = new uvec5(8u, 1u, 9u, 6u, 5u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(1u, 3u, 5u, 7u, 0u);
                var v1 = new uvec5(9u, 8u, 4u, 4u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(3u, 0u, 3u, 4u, 1u);
                var v1 = new uvec5(4u, 5u, 1u, 5u, 1u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(1u, 4u, 3u, 7u, 6u);
                var v1 = new uvec5(5u, 7u, 9u, 4u, 5u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(2u, 4u, 4u, 2u, 9u);
                var v1 = new uvec5(1u, 4u, 6u, 7u, 2u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec5(3u, 6u, 8u, 2u, 1u);
                var v1 = new uvec5(6u, 3u, 0u, 0u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new uvec5(0u, 4u, 1u, 8u, 3u);
                var v1 = new uvec5(4u, 2u, 2u, 9u, 3u);
                var v2 = new uvec5(8u, 3u, 5u, 3u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(9u, 9u, 5u, 6u, 9u);
                var v1 = new uvec5(1u, 5u, 7u, 0u, 6u);
                var v2 = new uvec5(2u, 3u, 1u, 2u, 6u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(0u, 4u, 7u, 6u, 4u);
                var v1 = new uvec5(9u, 7u, 6u, 5u, 0u);
                var v2 = new uvec5(5u, 9u, 8u, 7u, 6u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(6u, 2u, 6u, 3u, 4u);
                var v1 = new uvec5(7u, 7u, 3u, 8u, 5u);
                var v2 = new uvec5(5u, 6u, 1u, 1u, 1u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(1u, 1u, 0u, 2u, 2u);
                var v1 = new uvec5(3u, 5u, 9u, 8u, 3u);
                var v2 = new uvec5(2u, 2u, 9u, 5u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(2u, 7u, 9u, 3u, 0u);
                var v1 = new uvec5(0u, 6u, 8u, 8u, 9u);
                var v2 = new uvec5(2u, 1u, 9u, 1u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(2u, 6u, 5u, 4u, 9u);
                var v1 = new uvec5(4u, 8u, 5u, 4u, 2u);
                var v2 = new uvec5(1u, 3u, 7u, 9u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(4u, 8u, 7u, 4u, 3u);
                var v1 = new uvec5(7u, 6u, 7u, 1u, 0u);
                var v2 = new uvec5(4u, 2u, 2u, 2u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(1u, 5u, 7u, 9u, 1u);
                var v1 = new uvec5(6u, 7u, 4u, 6u, 8u);
                var v2 = new uvec5(4u, 1u, 5u, 1u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec5(7u, 8u, 8u, 6u, 5u);
                var v1 = new uvec5(4u, 4u, 5u, 8u, 1u);
                var v2 = new uvec5(5u, 8u, 4u, 3u, 5u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new uvec5(4u, 4u, 1u, 8u, 7u);
                var v1 = new uvec5(8u, 3u, 1u, 5u, 5u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(0u, 7u, 1u, 4u, 7u);
                var v1 = new uvec5(0u, 5u, 3u, 6u, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(6u, 1u, 1u, 6u, 9u);
                var v1 = new uvec5(3u, 1u, 1u, 8u, 4u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(3u, 2u, 4u, 0u, 7u);
                var v1 = new uvec5(5u, 2u, 6u, 2u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(6u, 0u, 8u, 7u, 5u);
                var v1 = new uvec5(9u, 2u, 2u, 9u, 8u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(4u, 6u, 0u, 9u, 2u);
                var v1 = new uvec5(3u, 2u, 4u, 9u, 3u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(7u, 2u, 2u, 0u, 2u);
                var v1 = new uvec5(8u, 3u, 1u, 7u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(7u, 8u, 1u, 4u, 3u);
                var v1 = new uvec5(6u, 2u, 3u, 0u, 9u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(1u, 8u, 2u, 0u, 0u);
                var v1 = new uvec5(6u, 2u, 4u, 7u, 3u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec5(2u, 8u, 7u, 9u, 4u);
                var v1 = new uvec5(4u, 7u, 7u, 4u, 7u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new uvec5(2u, 8u, 1u, 0u, 2u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(6u, 3u, 2u, 8u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(5u, 1u, 7u, 8u, 0u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(1u, 0u, 8u, 9u, 1u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(2u, 5u, 0u, 6u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(6u, 8u, 9u, 6u, 6u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(1u, 2u, 0u, 6u, 5u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(7u, 9u, 3u, 2u, 6u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(9u, 5u, 2u, 4u, 6u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec5(7u, 4u, 0u, 2u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(52359773);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.Random(random, 4, 8);
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
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
            Assert.AreEqual(variance.v, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1481275418);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.RandomUniform(random, 4, 6);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            Assert.AreEqual(avg.w, 4.5, 1.0);
            Assert.AreEqual(avg.v, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
            Assert.AreEqual(variance.w, 0.25, 3.0);
            Assert.AreEqual(variance.v, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(762707416);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.Random(random, 1, 3);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            Assert.AreEqual(avg.z, 1.5, 1.0);
            Assert.AreEqual(avg.w, 1.5, 1.0);
            Assert.AreEqual(avg.v, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
            Assert.AreEqual(variance.w, 0.25, 3.0);
            Assert.AreEqual(variance.v, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(44139414);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.RandomUniform(random, 4, 9);
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
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
            Assert.AreEqual(variance.v, 2, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(779148134);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.Random(random, 0, 5);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            Assert.AreEqual(avg.z, 2, 1.0);
            Assert.AreEqual(avg.w, 2, 1.0);
            Assert.AreEqual(avg.v, 2, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
            Assert.AreEqual(variance.v, 2, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1613599418);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.RandomPoisson(random, 1.1597555077913);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.1597555077913, 1.0);
            Assert.AreEqual(avg.y, 1.1597555077913, 1.0);
            Assert.AreEqual(avg.z, 1.1597555077913, 1.0);
            Assert.AreEqual(avg.w, 1.1597555077913, 1.0);
            Assert.AreEqual(avg.v, 1.1597555077913, 1.0);
            
            Assert.AreEqual(variance.x, 1.1597555077913, 3.0);
            Assert.AreEqual(variance.y, 1.1597555077913, 3.0);
            Assert.AreEqual(variance.z, 1.1597555077913, 3.0);
            Assert.AreEqual(variance.w, 1.1597555077913, 3.0);
            Assert.AreEqual(variance.v, 1.1597555077913, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(895031416);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.RandomPoisson(random, 1.64797759528643);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.64797759528643, 1.0);
            Assert.AreEqual(avg.y, 1.64797759528643, 1.0);
            Assert.AreEqual(avg.z, 1.64797759528643, 1.0);
            Assert.AreEqual(avg.w, 1.64797759528643, 1.0);
            Assert.AreEqual(avg.v, 1.64797759528643, 1.0);
            
            Assert.AreEqual(variance.x, 1.64797759528643, 3.0);
            Assert.AreEqual(variance.y, 1.64797759528643, 3.0);
            Assert.AreEqual(variance.z, 1.64797759528643, 3.0);
            Assert.AreEqual(variance.w, 1.64797759528643, 3.0);
            Assert.AreEqual(variance.v, 1.64797759528643, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(903251775);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.RandomPoisson(random, 3.09554474176632);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.09554474176632, 1.0);
            Assert.AreEqual(avg.y, 3.09554474176632, 1.0);
            Assert.AreEqual(avg.z, 3.09554474176632, 1.0);
            Assert.AreEqual(avg.w, 3.09554474176632, 1.0);
            Assert.AreEqual(avg.v, 3.09554474176632, 1.0);
            
            Assert.AreEqual(variance.x, 3.09554474176632, 3.0);
            Assert.AreEqual(variance.y, 3.09554474176632, 3.0);
            Assert.AreEqual(variance.z, 3.09554474176632, 3.0);
            Assert.AreEqual(variance.w, 3.09554474176632, 3.0);
            Assert.AreEqual(variance.v, 3.09554474176632, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(184683773);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.RandomPoisson(random, 1.75284330232667);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.75284330232667, 1.0);
            Assert.AreEqual(avg.y, 1.75284330232667, 1.0);
            Assert.AreEqual(avg.z, 1.75284330232667, 1.0);
            Assert.AreEqual(avg.w, 1.75284330232667, 1.0);
            Assert.AreEqual(avg.v, 1.75284330232667, 1.0);
            
            Assert.AreEqual(variance.x, 1.75284330232667, 3.0);
            Assert.AreEqual(variance.y, 1.75284330232667, 3.0);
            Assert.AreEqual(variance.z, 1.75284330232667, 3.0);
            Assert.AreEqual(variance.w, 1.75284330232667, 3.0);
            Assert.AreEqual(variance.v, 1.75284330232667, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(192904132);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec5.RandomPoisson(random, 3.20041044880655);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.20041044880655, 1.0);
            Assert.AreEqual(avg.y, 3.20041044880655, 1.0);
            Assert.AreEqual(avg.z, 3.20041044880655, 1.0);
            Assert.AreEqual(avg.w, 3.20041044880655, 1.0);
            Assert.AreEqual(avg.v, 3.20041044880655, 1.0);
            
            Assert.AreEqual(variance.x, 3.20041044880655, 3.0);
            Assert.AreEqual(variance.y, 3.20041044880655, 3.0);
            Assert.AreEqual(variance.z, 3.20041044880655, 3.0);
            Assert.AreEqual(variance.w, 3.20041044880655, 3.0);
            Assert.AreEqual(variance.v, 3.20041044880655, 3.0);
        }

    }
}
