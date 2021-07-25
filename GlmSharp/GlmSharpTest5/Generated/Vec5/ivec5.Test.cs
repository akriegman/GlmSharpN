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
    public class IntVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec5(-3);
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var v = new ivec5(-5, -7, -3, -7, -3);
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-7, v.w);
                Assert.AreEqual(-3, v.v);
            }
            {
                var v = new ivec5(new ivec2(4, 6));
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var v = new ivec5(new ivec3(-2, -5, -2));
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(0, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var v = new ivec5(new ivec4(-9, 7, 1, 8));
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8, v.w);
                Assert.AreEqual(0, v.v);
            }
            {
                var v = new ivec5(new ivec5(3, 6, -1, -8, 8));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-8, v.w);
                Assert.AreEqual(8, v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new ivec5(-7, -7, -3, 1, -3);
            Assert.AreEqual(-7, v[0]);
            Assert.AreEqual(-7, v[1]);
            Assert.AreEqual(-3, v[2]);
            Assert.AreEqual(1, v[3]);
            Assert.AreEqual(-3, v[4]);
            
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
            
            v[3] = 0;
            Assert.AreEqual(0, v[3]);
            v[4] = 1;
            Assert.AreEqual(1, v[4]);
            v[2] = 2;
            Assert.AreEqual(2, v[2]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[3] = 4;
            Assert.AreEqual(4, v[3]);
            v[3] = 5;
            Assert.AreEqual(5, v[3]);
            v[4] = 6;
            Assert.AreEqual(6, v[4]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[2] = -6;
            Assert.AreEqual(-6, v[2]);
            v[2] = -7;
            Assert.AreEqual(-7, v[2]);
            v[4] = -8;
            Assert.AreEqual(-8, v[4]);
            v[4] = -9;
            Assert.AreEqual(-9, v[4]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new ivec5(0, 4, 8, 3, -2);
            var vals = v.Values;
            Assert.AreEqual(0, vals[0]);
            Assert.AreEqual(4, vals[1]);
            Assert.AreEqual(8, vals[2]);
            Assert.AreEqual(3, vals[3]);
            Assert.AreEqual(-2, vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, ivec5.Zero.x);
            Assert.AreEqual(0, ivec5.Zero.y);
            Assert.AreEqual(0, ivec5.Zero.z);
            Assert.AreEqual(0, ivec5.Zero.w);
            Assert.AreEqual(0, ivec5.Zero.v);
            
            Assert.AreEqual(1, ivec5.Ones.x);
            Assert.AreEqual(1, ivec5.Ones.y);
            Assert.AreEqual(1, ivec5.Ones.z);
            Assert.AreEqual(1, ivec5.Ones.w);
            Assert.AreEqual(1, ivec5.Ones.v);
            
            Assert.AreEqual(1, ivec5.UnitX.x);
            Assert.AreEqual(0, ivec5.UnitX.y);
            Assert.AreEqual(0, ivec5.UnitX.z);
            Assert.AreEqual(0, ivec5.UnitX.w);
            Assert.AreEqual(0, ivec5.UnitX.v);
            
            Assert.AreEqual(0, ivec5.UnitY.x);
            Assert.AreEqual(1, ivec5.UnitY.y);
            Assert.AreEqual(0, ivec5.UnitY.z);
            Assert.AreEqual(0, ivec5.UnitY.w);
            Assert.AreEqual(0, ivec5.UnitY.v);
            
            Assert.AreEqual(0, ivec5.UnitZ.x);
            Assert.AreEqual(0, ivec5.UnitZ.y);
            Assert.AreEqual(1, ivec5.UnitZ.z);
            Assert.AreEqual(0, ivec5.UnitZ.w);
            Assert.AreEqual(0, ivec5.UnitZ.v);
            
            Assert.AreEqual(0, ivec5.UnitW.x);
            Assert.AreEqual(0, ivec5.UnitW.y);
            Assert.AreEqual(0, ivec5.UnitW.z);
            Assert.AreEqual(1, ivec5.UnitW.w);
            Assert.AreEqual(0, ivec5.UnitW.v);
            
            Assert.AreEqual(0, ivec5.UnitV.x);
            Assert.AreEqual(0, ivec5.UnitV.y);
            Assert.AreEqual(0, ivec5.UnitV.z);
            Assert.AreEqual(0, ivec5.UnitV.w);
            Assert.AreEqual(1, ivec5.UnitV.v);
            
            Assert.AreEqual(int.MaxValue, ivec5.MaxValue.x);
            Assert.AreEqual(int.MaxValue, ivec5.MaxValue.y);
            Assert.AreEqual(int.MaxValue, ivec5.MaxValue.z);
            Assert.AreEqual(int.MaxValue, ivec5.MaxValue.w);
            Assert.AreEqual(int.MaxValue, ivec5.MaxValue.v);
            
            Assert.AreEqual(int.MinValue, ivec5.MinValue.x);
            Assert.AreEqual(int.MinValue, ivec5.MinValue.y);
            Assert.AreEqual(int.MinValue, ivec5.MinValue.z);
            Assert.AreEqual(int.MinValue, ivec5.MinValue.w);
            Assert.AreEqual(int.MinValue, ivec5.MinValue.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new ivec5(0, -6, 8, 7, 1);
            var v2 = new ivec5(0, -6, 8, 7, 1);
            var v3 = new ivec5(1, 7, 8, -6, 0);
            Assert.That(v1 == new ivec5(v1));
            Assert.That(v2 == new ivec5(v2));
            Assert.That(v3 == new ivec5(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new ivec5(2, 1, -9, -5, 6);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = ivec5.Parse(s0);
            var v1 = ivec5.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = ivec5.TryParse(s0, out v0);
            var b1 = ivec5.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = ivec5.TryParse(null, out v0);
            Assert.False(b0);
            b0 = ivec5.TryParse("", out v0);
            Assert.False(b0);
            b0 = ivec5.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { ivec5.Parse(null); });
            Assert.Throws<FormatException>(() => { ivec5.Parse(""); });
            Assert.Throws<FormatException>(() => { ivec5.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = ivec5.Parse(s3, "; ", NumberStyles.Number);
            var v4 = ivec5.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = ivec5.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new ivec5(0, 1, -9, 0, -9);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<ivec5>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new ivec5(7, 4, 6, 1, 1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(4, 8, -2, -5, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(-2, -2, 6, 0, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(8, -1, 8, -8, -3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(-9, -8, -7, 0, -3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(-1, -6, 5, 1, -7);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(5, -3, -8, -8, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(-6, 9, -6, -1, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(7, 3, -7, -8, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec5(7, -6, -1, -4, 4);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new ivec5(-4, -8, 1, 0, 1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(-5, -7, 1, 1, -4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(3, -8, -7, -1, -1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(3, 0, 5, 8, 7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(6, 4, 0, 7, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(-9, 2, -6, -8, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(4, -5, -1, 6, -8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(0, 6, -6, 1, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(-5, -5, 8, 8, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec5(0, -8, 4, 1, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new ivec5(3, 6, 6, 0, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(0, 1, 5, 8, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(-6, 7, -9, -5, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(5, -2, -7, 0, -2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(1, 7, 7, 4, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(6, -4, 3, -6, -2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(8, -8, 8, -3, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(-1, -9, 3, 5, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(-1, 6, 1, 7, 9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec5(-2, -5, 8, -1, 6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new ivec5(1, 6, -7, -5, -5);
                var v1 = new ivec5(0, -9, 1, -7, -1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(-9, -9, 6, -6, -7);
                var v1 = new ivec5(9, 8, 6, -2, -9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(9, 1, -8, -1, 3);
                var v1 = new ivec5(3, 7, 1, 8, -7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(-1, -1, -6, 9, -7);
                var v1 = new ivec5(-9, 8, -9, 7, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(7, -4, 2, 8, 7);
                var v1 = new ivec5(-3, -3, -7, 8, 4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(-4, 3, 6, -9, 6);
                var v1 = new ivec5(-9, 7, 6, -2, -2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(-3, -8, -2, 0, -9);
                var v1 = new ivec5(7, 3, -7, -8, -8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(1, 9, -9, 4, -1);
                var v1 = new ivec5(-6, -9, 8, 2, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(-1, 9, -2, 4, 2);
                var v1 = new ivec5(7, 4, -6, 2, -7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec5(-2, 2, 6, -6, -4);
                var v1 = new ivec5(9, 2, 2, 8, 0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new ivec5(9, -2, 4, -6, -6);
                var v1 = new ivec5(7, 7, -6, -4, 2);
                var v2 = new ivec5(-5, 4, -6, -1, 8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(-4, -6, 6, 9, -6);
                var v1 = new ivec5(6, -2, -6, -2, 5);
                var v2 = new ivec5(4, 4, 2, 4, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(-2, 3, -4, -7, 2);
                var v1 = new ivec5(-3, 0, -7, 3, 1);
                var v2 = new ivec5(-4, -7, 6, 0, 8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(-2, 7, -6, -4, -9);
                var v1 = new ivec5(3, 8, -1, 1, 1);
                var v2 = new ivec5(-8, -5, -2, -1, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(3, 4, -2, 4, -1);
                var v1 = new ivec5(-1, -1, -9, 8, -5);
                var v2 = new ivec5(-3, -9, 2, 7, 1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(9, 5, -6, 3, -3);
                var v1 = new ivec5(-6, 7, 8, 4, 5);
                var v2 = new ivec5(3, -2, -2, -6, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(-8, 8, 5, -3, -8);
                var v1 = new ivec5(8, 4, 1, 9, -8);
                var v2 = new ivec5(1, 8, 7, -8, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(3, 5, 3, -9, -1);
                var v1 = new ivec5(-3, -9, 8, -8, -4);
                var v2 = new ivec5(-5, -6, 6, -8, 6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(-8, -8, 3, 4, -7);
                var v1 = new ivec5(4, -3, 8, 8, -2);
                var v2 = new ivec5(4, 3, 5, 5, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec5(7, -9, 9, -9, 2);
                var v1 = new ivec5(-7, 8, -2, 4, -1);
                var v2 = new ivec5(-8, 0, 7, -8, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new ivec5(8, -8, 6, -7, 9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(-3, -9, 1, -1, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(-8, -4, 1, -7, 1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(-8, -9, 6, -7, 5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(1, 4, -1, 6, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(4, 0, -6, -6, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(8, -1, 8, 6, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(-2, 7, -8, 1, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(3, -3, 9, 1, -7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec5(0, -6, -5, 4, -1);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new ivec5(6, 5, -8, -5, 1);
                var v1 = new ivec5(-2, 2, -6, -6, -6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(4, -5, -3, -4, -1);
                var v1 = new ivec5(9, -4, -9, 8, 1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(1, -6, -5, -9, 2);
                var v1 = new ivec5(1, 0, -7, 5, -6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(-6, -3, -2, -8, 4);
                var v1 = new ivec5(0, 2, 8, 1, 5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(1, -7, 0, 2, -7);
                var v1 = new ivec5(6, 6, 7, 5, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(4, 2, 4, -1, 7);
                var v1 = new ivec5(9, -1, -9, -3, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(-1, 5, -1, 0, -9);
                var v1 = new ivec5(-1, 3, -5, 9, 9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(7, 5, -7, 2, 0);
                var v1 = new ivec5(3, -5, -2, 1, -5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(-4, -2, -2, 6, -1);
                var v1 = new ivec5(-3, 7, 0, 9, -4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec5(9, 3, -6, 1, -4);
                var v1 = new ivec5(-5, 6, 0, 2, 5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new ivec5(-9, 2, -3, 5, 9);
                var v1 = new ivec5(2, 5, -7, 9, 9);
                var v2 = new ivec5(4, -2, -6, -3, 3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(5, -4, 7, 2, -6);
                var v1 = new ivec5(9, 8, -3, -7, -6);
                var v2 = new ivec5(5, -7, -4, -1, -5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(-8, 8, -8, -5, -7);
                var v1 = new ivec5(3, 5, -5, -2, 8);
                var v2 = new ivec5(2, -3, -7, -2, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(-8, -7, 6, 0, -5);
                var v1 = new ivec5(-9, -2, 7, -6, 9);
                var v2 = new ivec5(-1, 8, -5, 9, 3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(4, -1, 6, -4, -1);
                var v1 = new ivec5(-6, -3, 1, -6, -9);
                var v2 = new ivec5(0, -9, -6, -3, -4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(-7, -1, 0, -6, -8);
                var v1 = new ivec5(7, 9, -3, -5, -5);
                var v2 = new ivec5(6, 0, 2, 4, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(-5, -1, 5, 7, 4);
                var v1 = new ivec5(-1, 6, 3, 1, 5);
                var v2 = new ivec5(5, -5, -1, 1, -5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(0, -6, -4, 1, -3);
                var v1 = new ivec5(0, 7, -9, -1, -6);
                var v2 = new ivec5(-5, -7, -1, -8, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(-5, 9, -6, 9, 4);
                var v1 = new ivec5(9, -4, 7, 8, 2);
                var v2 = new ivec5(9, 7, -9, 9, -2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec5(-2, -8, -2, -9, -5);
                var v1 = new ivec5(9, 5, 1, -2, 5);
                var v2 = new ivec5(7, -1, -4, -2, 8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new ivec5(6, -7, 2, 6, 0);
                var v1 = new ivec5(-6, -5, 9, -5, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(5, -2, -1, -5, -9);
                var v1 = new ivec5(-4, 8, 1, 3, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(7, -8, 2, -3, 0);
                var v1 = new ivec5(1, 8, -9, 4, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(7, 8, 6, -2, -9);
                var v1 = new ivec5(3, 6, 3, 9, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(4, -2, -2, 2, 4);
                var v1 = new ivec5(-7, 6, 7, -7, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(4, -3, -1, -1, -8);
                var v1 = new ivec5(8, -4, 9, 5, -9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(7, -6, 5, -7, -4);
                var v1 = new ivec5(-6, 4, -9, -5, -5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(6, 4, -1, 0, 6);
                var v1 = new ivec5(-6, 5, 0, 7, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(-4, 0, 1, 2, -4);
                var v1 = new ivec5(-4, -8, -6, -3, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec5(8, -7, -7, 9, -5);
                var v1 = new ivec5(8, 5, -5, 8, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new ivec5(2, 0, -9, 0, 6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(9, 9, 7, -3, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(9, -3, -5, 2, -1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(-1, 9, -1, -3, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(-5, 3, -4, -1, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(4, -9, -5, -4, 1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(-3, 7, 7, -7, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(-6, 0, 0, -4, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(5, 1, 4, 3, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec5(-9, -8, 5, 9, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1178409559);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.Random(random, -5, 0);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3, 1.0);
            Assert.AreEqual(avg.y, -3, 1.0);
            Assert.AreEqual(avg.z, -3, 1.0);
            Assert.AreEqual(avg.w, -3, 1.0);
            Assert.AreEqual(avg.v, -3, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
            Assert.AreEqual(variance.v, 2, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1896977561);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.RandomUniform(random, 3, 5);
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
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
            Assert.AreEqual(variance.w, 0.25, 3.0);
            Assert.AreEqual(variance.v, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(468061916);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.Random(random, -2, 1);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            Assert.AreEqual(avg.z, -1, 1.0);
            Assert.AreEqual(avg.w, -1, 1.0);
            Assert.AreEqual(avg.v, -1, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.w, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.v, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1186629918);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.RandomUniform(random, 3, 6);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            Assert.AreEqual(avg.z, 4, 1.0);
            Assert.AreEqual(avg.w, 4, 1.0);
            Assert.AreEqual(avg.v, 4, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.w, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.v, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(451621198);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.Random(random, -2, 2);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            Assert.AreEqual(avg.z, -0.5, 1.0);
            Assert.AreEqual(avg.w, -0.5, 1.0);
            Assert.AreEqual(avg.v, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
            Assert.AreEqual(variance.v, 1.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1342845778);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.RandomPoisson(random, 2.80836640452424);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.80836640452424, 1.0);
            Assert.AreEqual(avg.y, 2.80836640452424, 1.0);
            Assert.AreEqual(avg.z, 2.80836640452424, 1.0);
            Assert.AreEqual(avg.w, 2.80836640452424, 1.0);
            Assert.AreEqual(avg.v, 2.80836640452424, 1.0);
            
            Assert.AreEqual(variance.x, 2.80836640452424, 3.0);
            Assert.AreEqual(variance.y, 2.80836640452424, 3.0);
            Assert.AreEqual(variance.z, 2.80836640452424, 3.0);
            Assert.AreEqual(variance.w, 2.80836640452424, 3.0);
            Assert.AreEqual(variance.v, 2.80836640452424, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(2061413780);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.RandomPoisson(random, 1.95231651303001);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.95231651303001, 1.0);
            Assert.AreEqual(avg.y, 1.95231651303001, 1.0);
            Assert.AreEqual(avg.z, 1.95231651303001, 1.0);
            Assert.AreEqual(avg.w, 1.95231651303001, 1.0);
            Assert.AreEqual(avg.v, 1.95231651303001, 1.0);
            
            Assert.AreEqual(variance.x, 1.95231651303001, 3.0);
            Assert.AreEqual(variance.y, 1.95231651303001, 3.0);
            Assert.AreEqual(variance.z, 1.95231651303001, 3.0);
            Assert.AreEqual(variance.w, 1.95231651303001, 3.0);
            Assert.AreEqual(variance.v, 1.95231651303001, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(2053193421);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.RandomPoisson(random, 0.504749366550124);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.504749366550124, 1.0);
            Assert.AreEqual(avg.y, 0.504749366550124, 1.0);
            Assert.AreEqual(avg.z, 0.504749366550124, 1.0);
            Assert.AreEqual(avg.w, 0.504749366550124, 1.0);
            Assert.AreEqual(avg.v, 0.504749366550124, 1.0);
            
            Assert.AreEqual(variance.x, 0.504749366550124, 3.0);
            Assert.AreEqual(variance.y, 0.504749366550124, 3.0);
            Assert.AreEqual(variance.z, 0.504749366550124, 3.0);
            Assert.AreEqual(variance.w, 0.504749366550124, 3.0);
            Assert.AreEqual(variance.v, 0.504749366550124, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(624277776);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.RandomPoisson(random, 1.84745080598977);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.84745080598977, 1.0);
            Assert.AreEqual(avg.y, 1.84745080598977, 1.0);
            Assert.AreEqual(avg.z, 1.84745080598977, 1.0);
            Assert.AreEqual(avg.w, 1.84745080598977, 1.0);
            Assert.AreEqual(avg.v, 1.84745080598977, 1.0);
            
            Assert.AreEqual(variance.x, 1.84745080598977, 3.0);
            Assert.AreEqual(variance.y, 1.84745080598977, 3.0);
            Assert.AreEqual(variance.z, 1.84745080598977, 3.0);
            Assert.AreEqual(variance.w, 1.84745080598977, 3.0);
            Assert.AreEqual(variance.v, 1.84745080598977, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(616057417);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec5.RandomPoisson(random, 3.39988365950989);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.39988365950989, 1.0);
            Assert.AreEqual(avg.y, 3.39988365950989, 1.0);
            Assert.AreEqual(avg.z, 3.39988365950989, 1.0);
            Assert.AreEqual(avg.w, 3.39988365950989, 1.0);
            Assert.AreEqual(avg.v, 3.39988365950989, 1.0);
            
            Assert.AreEqual(variance.x, 3.39988365950989, 3.0);
            Assert.AreEqual(variance.y, 3.39988365950989, 3.0);
            Assert.AreEqual(variance.z, 3.39988365950989, 3.0);
            Assert.AreEqual(variance.w, 3.39988365950989, 3.0);
            Assert.AreEqual(variance.v, 3.39988365950989, 3.0);
        }

    }
}
