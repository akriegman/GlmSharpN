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
    public class LongVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec5(9L);
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
                Assert.AreEqual(9L, v.v);
            }
            {
                var v = new lvec5(3L, 6L, 7L, -5L, -6L);
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-5L, v.w);
                Assert.AreEqual(-6L, v.v);
            }
            {
                var v = new lvec5(new lvec2(-1L, 9L));
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var v = new lvec5(new lvec3(0, -7L, -6L));
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var v = new lvec5(new lvec4(-1L, 1, -9L, -7L));
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-7L, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var v = new lvec5(new lvec5(-7L, 2L, 8L, -6L, -2L));
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-6L, v.w);
                Assert.AreEqual(-2L, v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec5(9L, -2L, -9L, -1L, -8L);
            Assert.AreEqual(9L, v[0]);
            Assert.AreEqual(-2L, v[1]);
            Assert.AreEqual(-9L, v[2]);
            Assert.AreEqual(-1L, v[3]);
            Assert.AreEqual(-8L, v[4]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[2] = 0;
            Assert.AreEqual(0, v[2]);
            v[4] = 1;
            Assert.AreEqual(1, v[4]);
            v[2] = 2L;
            Assert.AreEqual(2L, v[2]);
            v[2] = 3L;
            Assert.AreEqual(3L, v[2]);
            v[0] = 4L;
            Assert.AreEqual(4L, v[0]);
            v[0] = 5L;
            Assert.AreEqual(5L, v[0]);
            v[4] = 6L;
            Assert.AreEqual(6L, v[4]);
            v[4] = 7L;
            Assert.AreEqual(7L, v[4]);
            v[3] = 8L;
            Assert.AreEqual(8L, v[3]);
            v[1] = 9L;
            Assert.AreEqual(9L, v[1]);
            v[4] = -1L;
            Assert.AreEqual(-1L, v[4]);
            v[1] = -2L;
            Assert.AreEqual(-2L, v[1]);
            v[4] = -3L;
            Assert.AreEqual(-3L, v[4]);
            v[3] = -4L;
            Assert.AreEqual(-4L, v[3]);
            v[4] = -5L;
            Assert.AreEqual(-5L, v[4]);
            v[1] = -6L;
            Assert.AreEqual(-6L, v[1]);
            v[3] = -7L;
            Assert.AreEqual(-7L, v[3]);
            v[2] = -8L;
            Assert.AreEqual(-8L, v[2]);
            v[0] = -9L;
            Assert.AreEqual(-9L, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec5(2L, -4L, -5L, -7L, 0);
            var vals = v.Values;
            Assert.AreEqual(2L, vals[0]);
            Assert.AreEqual(-4L, vals[1]);
            Assert.AreEqual(-5L, vals[2]);
            Assert.AreEqual(-7L, vals[3]);
            Assert.AreEqual(0, vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, lvec5.Zero.x);
            Assert.AreEqual(0, lvec5.Zero.y);
            Assert.AreEqual(0, lvec5.Zero.z);
            Assert.AreEqual(0, lvec5.Zero.w);
            Assert.AreEqual(0, lvec5.Zero.v);
            
            Assert.AreEqual(1, lvec5.Ones.x);
            Assert.AreEqual(1, lvec5.Ones.y);
            Assert.AreEqual(1, lvec5.Ones.z);
            Assert.AreEqual(1, lvec5.Ones.w);
            Assert.AreEqual(1, lvec5.Ones.v);
            
            Assert.AreEqual(1, lvec5.UnitX.x);
            Assert.AreEqual(0, lvec5.UnitX.y);
            Assert.AreEqual(0, lvec5.UnitX.z);
            Assert.AreEqual(0, lvec5.UnitX.w);
            Assert.AreEqual(0, lvec5.UnitX.v);
            
            Assert.AreEqual(0, lvec5.UnitY.x);
            Assert.AreEqual(1, lvec5.UnitY.y);
            Assert.AreEqual(0, lvec5.UnitY.z);
            Assert.AreEqual(0, lvec5.UnitY.w);
            Assert.AreEqual(0, lvec5.UnitY.v);
            
            Assert.AreEqual(0, lvec5.UnitZ.x);
            Assert.AreEqual(0, lvec5.UnitZ.y);
            Assert.AreEqual(1, lvec5.UnitZ.z);
            Assert.AreEqual(0, lvec5.UnitZ.w);
            Assert.AreEqual(0, lvec5.UnitZ.v);
            
            Assert.AreEqual(0, lvec5.UnitW.x);
            Assert.AreEqual(0, lvec5.UnitW.y);
            Assert.AreEqual(0, lvec5.UnitW.z);
            Assert.AreEqual(1, lvec5.UnitW.w);
            Assert.AreEqual(0, lvec5.UnitW.v);
            
            Assert.AreEqual(0, lvec5.UnitV.x);
            Assert.AreEqual(0, lvec5.UnitV.y);
            Assert.AreEqual(0, lvec5.UnitV.z);
            Assert.AreEqual(0, lvec5.UnitV.w);
            Assert.AreEqual(1, lvec5.UnitV.v);
            
            Assert.AreEqual(long.MaxValue, lvec5.MaxValue.x);
            Assert.AreEqual(long.MaxValue, lvec5.MaxValue.y);
            Assert.AreEqual(long.MaxValue, lvec5.MaxValue.z);
            Assert.AreEqual(long.MaxValue, lvec5.MaxValue.w);
            Assert.AreEqual(long.MaxValue, lvec5.MaxValue.v);
            
            Assert.AreEqual(long.MinValue, lvec5.MinValue.x);
            Assert.AreEqual(long.MinValue, lvec5.MinValue.y);
            Assert.AreEqual(long.MinValue, lvec5.MinValue.z);
            Assert.AreEqual(long.MinValue, lvec5.MinValue.w);
            Assert.AreEqual(long.MinValue, lvec5.MinValue.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new lvec5(-5L, 1, -6L, 4L, 0);
            var v2 = new lvec5(-5L, 1, -6L, 4L, 0);
            var v3 = new lvec5(0, 4L, -6L, 1, -5L);
            Assert.That(v1 == new lvec5(v1));
            Assert.That(v2 == new lvec5(v2));
            Assert.That(v3 == new lvec5(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new lvec5(8L, 6L, -4L, 5L, 0);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = lvec5.Parse(s0);
            var v1 = lvec5.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = lvec5.TryParse(s0, out v0);
            var b1 = lvec5.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = lvec5.TryParse(null, out v0);
            Assert.False(b0);
            b0 = lvec5.TryParse("", out v0);
            Assert.False(b0);
            b0 = lvec5.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { lvec5.Parse(null); });
            Assert.Throws<FormatException>(() => { lvec5.Parse(""); });
            Assert.Throws<FormatException>(() => { lvec5.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = lvec5.Parse(s3, "; ", NumberStyles.Number);
            var v4 = lvec5.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = lvec5.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new lvec5(2L, -7L, 4L, -9L, -3L);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<lvec5>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new lvec5(7L, -3L, -8L, -1L, 1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(4L, 5L, 5L, -6L, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(-1L, 6L, 2L, -6L, -6L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(-7L, 4L, -5L, 1, 6L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(-6L, -3L, -3L, -6L, -6L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(-4L, 7L, 9L, -6L, 4L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(1, -6L, -2L, -3L, 5L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(-3L, -2L, 9L, 3L, 2L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(9L, -9L, 4L, 4L, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec5(-1L, 1, -4L, -9L, -9L);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new lvec5(8L, 0, 2L, 0, 9L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(-4L, -8L, -5L, 9L, -9L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(5L, -1L, -1L, 9L, -5L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(-8L, 9L, -4L, 5L, -3L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(7L, 1, -4L, -2L, -8L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(2L, 1, 7L, -7L, -3L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(-7L, 2L, -7L, 2L, 1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(-2L, 6L, -6L, -8L, 6L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(-7L, 9L, 1, -5L, -8L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec5(0, 4L, 6L, 0, 8L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new lvec5(-6L, 1, -3L, 9L, 2L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(-3L, 3L, 4L, -6L, 8L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(4L, 7L, -5L, -7L, -3L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(1, 9L, -2L, 6L, 4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(-7L, 9L, -6L, 8L, -9L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(1, 6L, -6L, 0, -3L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(8L, 6L, 9L, 1, -9L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(-1L, -8L, -3L, 5L, -6L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(-3L, -2L, 3L, -6L, -3L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec5(5L, -1L, 1, 2L, -1L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new lvec5(9L, -3L, -6L, 7L, 4L);
                var v1 = new lvec5(-7L, 5L, -7L, 9L, 4L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(-6L, -9L, -8L, -5L, -1L);
                var v1 = new lvec5(-6L, 8L, -9L, 4L, 3L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(-3L, 3L, -7L, 0, 4L);
                var v1 = new lvec5(6L, -9L, -2L, -3L, 5L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(-8L, 4L, 4L, -6L, 2L);
                var v1 = new lvec5(8L, -6L, -8L, 5L, 7L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(-9L, -8L, -1L, -8L, -7L);
                var v1 = new lvec5(9L, -6L, -5L, -9L, 5L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(5L, -3L, 9L, 4L, 7L);
                var v1 = new lvec5(5L, -5L, -5L, 3L, -8L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(-8L, -4L, 4L, 4L, 5L);
                var v1 = new lvec5(-1L, -5L, 1, -3L, 1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(-9L, -1L, -3L, -7L, 3L);
                var v1 = new lvec5(-4L, -3L, -9L, 3L, -4L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(9L, 4L, -2L, 7L, -9L);
                var v1 = new lvec5(5L, -5L, 0, 8L, -6L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec5(-4L, 0, -4L, 7L, 8L);
                var v1 = new lvec5(4L, -4L, 5L, -2L, 5L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new lvec5(-7L, -7L, -9L, 6L, 9L);
                var v1 = new lvec5(-5L, 6L, -7L, 6L, -5L);
                var v2 = new lvec5(6L, 3L, 0, 8L, 8L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(-9L, -8L, -1L, 2L, 3L);
                var v1 = new lvec5(-1L, 8L, 6L, 7L, 6L);
                var v2 = new lvec5(8L, -2L, -1L, 0, 7L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(-3L, -5L, -3L, 8L, 1);
                var v1 = new lvec5(-3L, 1, 7L, 4L, 5L);
                var v2 = new lvec5(-2L, -2L, 3L, -2L, 4L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(-9L, -2L, 3L, 1, -5L);
                var v1 = new lvec5(-5L, -5L, 4L, -2L, 1);
                var v2 = new lvec5(7L, 9L, -1L, -9L, 0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(3L, -6L, -6L, -8L, 2L);
                var v1 = new lvec5(-2L, -1L, -2L, 7L, -6L);
                var v2 = new lvec5(-7L, 9L, 6L, -7L, -1L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(-9L, 5L, -5L, 2L, 7L);
                var v1 = new lvec5(-7L, 7L, 8L, 5L, -2L);
                var v2 = new lvec5(-7L, -1L, 1, 6L, -4L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(2L, 9L, 7L, 3L, 1);
                var v1 = new lvec5(-6L, -5L, 5L, 8L, -3L);
                var v2 = new lvec5(7L, 0, -6L, 5L, -7L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(4L, 7L, 6L, 0, 2L);
                var v1 = new lvec5(1, -5L, 8L, -1L, 3L);
                var v2 = new lvec5(-5L, 6L, -1L, 5L, 4L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(1, 8L, 4L, -3L, -3L);
                var v1 = new lvec5(6L, 1, 2L, -5L, -4L);
                var v2 = new lvec5(3L, 0, 5L, 9L, -9L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec5(-6L, -1L, 2L, 8L, 7L);
                var v1 = new lvec5(9L, 3L, 0, 3L, -2L);
                var v2 = new lvec5(7L, 1, -7L, 0, 5L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new lvec5(-6L, 3L, 1, 7L, 3L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(0, -8L, 2L, 2L, 0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(9L, -4L, 5L, -5L, 1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(2L, 0, -2L, 9L, -3L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(5L, 2L, 2L, 2L, -3L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(8L, 7L, 4L, -2L, -5L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(8L, 2L, 8L, -8L, 6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(-1L, 8L, 8L, 1, -4L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(2L, 7L, 7L, -3L, -3L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec5(6L, -9L, 2L, -3L, 6L);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new lvec5(-6L, -3L, 5L, 5L, -1L);
                var v1 = new lvec5(-8L, -3L, 0, -5L, -7L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(4L, -5L, -5L, 6L, -5L);
                var v1 = new lvec5(-1L, -5L, 0, 5L, -9L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(-3L, 9L, 0, 0, 7L);
                var v1 = new lvec5(0, 4L, 7L, -1L, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(5L, 3L, -6L, -1L, -5L);
                var v1 = new lvec5(-2L, 9L, 2L, -8L, -1L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(-2L, 6L, 9L, 1, 3L);
                var v1 = new lvec5(-4L, -5L, 3L, -6L, -9L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(3L, -7L, -6L, 5L, 6L);
                var v1 = new lvec5(6L, -2L, 4L, -7L, 9L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(-4L, 5L, 8L, -4L, -1L);
                var v1 = new lvec5(0, -8L, 4L, -1L, 2L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(0, -3L, 2L, -4L, 6L);
                var v1 = new lvec5(5L, 0, -9L, -7L, -4L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(4L, 0, -1L, -1L, -6L);
                var v1 = new lvec5(7L, 7L, -1L, 3L, 8L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec5(-9L, 5L, 4L, 7L, -7L);
                var v1 = new lvec5(6L, -8L, -5L, 9L, 3L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new lvec5(-3L, -6L, -8L, -6L, -5L);
                var v1 = new lvec5(-5L, 6L, -6L, -7L, -7L);
                var v2 = new lvec5(-3L, -2L, -3L, -5L, 2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(1, -3L, 3L, 9L, 8L);
                var v1 = new lvec5(5L, -1L, 2L, 2L, -5L);
                var v2 = new lvec5(0, 9L, 6L, -4L, -7L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(-8L, -7L, -9L, 3L, -8L);
                var v1 = new lvec5(4L, 4L, 4L, -2L, 5L);
                var v2 = new lvec5(4L, -8L, -9L, 0, 5L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(-2L, -3L, 0, -2L, 0);
                var v1 = new lvec5(7L, 5L, -5L, 5L, 8L);
                var v2 = new lvec5(1, -4L, -6L, 1, -4L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(4L, 0, 1, 0, -9L);
                var v1 = new lvec5(-5L, -2L, 8L, -7L, -8L);
                var v2 = new lvec5(-6L, 8L, -2L, 3L, 4L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(7L, -1L, 1, -7L, 2L);
                var v1 = new lvec5(7L, 9L, -4L, -4L, 8L);
                var v2 = new lvec5(-2L, 2L, -4L, -4L, -6L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(9L, 8L, 3L, -7L, 1);
                var v1 = new lvec5(3L, -6L, -9L, 1, 9L);
                var v2 = new lvec5(-9L, 4L, 2L, -4L, 3L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(-8L, -4L, -2L, 0, 0);
                var v1 = new lvec5(-1L, -3L, -9L, -8L, 6L);
                var v2 = new lvec5(-4L, 5L, 7L, -1L, 6L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(-2L, -8L, -5L, 0, 7L);
                var v1 = new lvec5(7L, 5L, -4L, 2L, 0);
                var v2 = new lvec5(-1L, -2L, 0, 6L, 3L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec5(3L, 6L, 0, 9L, 9L);
                var v1 = new lvec5(-8L, -1L, -3L, -3L, 5L);
                var v2 = new lvec5(-7L, 9L, 4L, -1L, 6L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new lvec5(-2L, -6L, 9L, 7L, 6L);
                var v1 = new lvec5(-9L, -4L, 7L, 2L, 7L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(8L, -6L, -5L, -3L, 8L);
                var v1 = new lvec5(8L, -8L, -3L, -5L, 7L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(3L, 3L, -1L, -1L, -4L);
                var v1 = new lvec5(2L, 2L, -4L, -8L, 5L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(7L, -7L, -9L, -2L, -3L);
                var v1 = new lvec5(-9L, -7L, 7L, -9L, 3L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(-9L, 5L, -7L, -2L, -1L);
                var v1 = new lvec5(3L, 7L, -3L, -4L, 3L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(8L, -3L, -4L, -3L, -1L);
                var v1 = new lvec5(8L, 4L, -8L, -3L, 3L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(-6L, -9L, 8L, -6L, -9L);
                var v1 = new lvec5(-1L, -7L, 3L, -9L, 9L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(-1L, 9L, -3L, -2L, 8L);
                var v1 = new lvec5(-7L, 6L, -9L, 0, 9L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(-5L, 9L, -9L, -5L, -7L);
                var v1 = new lvec5(-5L, 2L, 5L, 1, 4L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec5(-5L, -8L, -5L, -6L, 6L);
                var v1 = new lvec5(-9L, -7L, 1, -2L, -9L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new lvec5(-4L, -7L, 5L, -2L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(-9L, 4L, -1L, -8L, 3L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(-4L, 4L, -4L, -4L, 8L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(-4L, 5L, -3L, 7L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(0, 7L, -6L, 5L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(1, 4L, -9L, 4L, -9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(-5L, 1, 2L, -4L, 2L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(-4L, 1, 5L, 0, -8L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(-3L, 1, -8L, -9L, -3L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec5(-9L, -9L, 0, 3L, -5L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1932073072);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.Random(random, -2, 3);
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
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
            Assert.AreEqual(variance.v, 2, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(503157427);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.RandomUniform(random, -4, 1);
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
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
            Assert.AreEqual(variance.v, 2, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1221725429);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.Random(random, 1, 3);
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
            var random = new Random(1940293431);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.RandomUniform(random, -4, -2);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3.5, 1.0);
            Assert.AreEqual(avg.y, -3.5, 1.0);
            Assert.AreEqual(avg.z, -3.5, 1.0);
            Assert.AreEqual(avg.w, -3.5, 1.0);
            Assert.AreEqual(avg.v, -3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
            Assert.AreEqual(variance.w, 0.25, 3.0);
            Assert.AreEqual(variance.v, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1205284711);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.Random(random, 1, 4);
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
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.w, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.v, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(382525180);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.RandomPoisson(random, 0.620560889188461);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.620560889188461, 1.0);
            Assert.AreEqual(avg.y, 0.620560889188461, 1.0);
            Assert.AreEqual(avg.z, 0.620560889188461, 1.0);
            Assert.AreEqual(avg.w, 0.620560889188461, 1.0);
            Assert.AreEqual(avg.v, 0.620560889188461, 1.0);
            
            Assert.AreEqual(variance.x, 0.620560889188461, 3.0);
            Assert.AreEqual(variance.y, 0.620560889188461, 3.0);
            Assert.AreEqual(variance.z, 0.620560889188461, 3.0);
            Assert.AreEqual(variance.w, 0.620560889188461, 3.0);
            Assert.AreEqual(variance.v, 0.620560889188461, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(1811440825);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.RandomPoisson(random, 1.76383012918002);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.76383012918002, 1.0);
            Assert.AreEqual(avg.y, 1.76383012918002, 1.0);
            Assert.AreEqual(avg.z, 1.76383012918002, 1.0);
            Assert.AreEqual(avg.w, 1.76383012918002, 1.0);
            Assert.AreEqual(avg.v, 1.76383012918002, 1.0);
            
            Assert.AreEqual(variance.x, 1.76383012918002, 3.0);
            Assert.AreEqual(variance.y, 1.76383012918002, 3.0);
            Assert.AreEqual(variance.z, 1.76383012918002, 3.0);
            Assert.AreEqual(variance.w, 1.76383012918002, 3.0);
            Assert.AreEqual(variance.v, 1.76383012918002, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(1819661184);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.RandomPoisson(random, 3.21139727565991);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.21139727565991, 1.0);
            Assert.AreEqual(avg.y, 3.21139727565991, 1.0);
            Assert.AreEqual(avg.z, 3.21139727565991, 1.0);
            Assert.AreEqual(avg.w, 3.21139727565991, 1.0);
            Assert.AreEqual(avg.v, 3.21139727565991, 1.0);
            
            Assert.AreEqual(variance.x, 3.21139727565991, 3.0);
            Assert.AreEqual(variance.y, 3.21139727565991, 3.0);
            Assert.AreEqual(variance.z, 3.21139727565991, 3.0);
            Assert.AreEqual(variance.w, 3.21139727565991, 3.0);
            Assert.AreEqual(variance.v, 3.21139727565991, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1101093182);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.RandomPoisson(random, 1.86869583622026);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.86869583622026, 1.0);
            Assert.AreEqual(avg.y, 1.86869583622026, 1.0);
            Assert.AreEqual(avg.z, 1.86869583622026, 1.0);
            Assert.AreEqual(avg.w, 1.86869583622026, 1.0);
            Assert.AreEqual(avg.v, 1.86869583622026, 1.0);
            
            Assert.AreEqual(variance.x, 1.86869583622026, 3.0);
            Assert.AreEqual(variance.y, 1.86869583622026, 3.0);
            Assert.AreEqual(variance.z, 1.86869583622026, 3.0);
            Assert.AreEqual(variance.w, 1.86869583622026, 3.0);
            Assert.AreEqual(variance.v, 1.86869583622026, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1109313541);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec5.RandomPoisson(random, 3.31626298270014);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.31626298270014, 1.0);
            Assert.AreEqual(avg.y, 3.31626298270014, 1.0);
            Assert.AreEqual(avg.z, 3.31626298270014, 1.0);
            Assert.AreEqual(avg.w, 3.31626298270014, 1.0);
            Assert.AreEqual(avg.v, 3.31626298270014, 1.0);
            
            Assert.AreEqual(variance.x, 3.31626298270014, 3.0);
            Assert.AreEqual(variance.y, 3.31626298270014, 3.0);
            Assert.AreEqual(variance.z, 3.31626298270014, 3.0);
            Assert.AreEqual(variance.w, 3.31626298270014, 3.0);
            Assert.AreEqual(variance.v, 3.31626298270014, 3.0);
        }

    }
}
