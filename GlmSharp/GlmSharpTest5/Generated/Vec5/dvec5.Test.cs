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
    public class DoubleVec5Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec5(7.5d);
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
                Assert.AreEqual(7.5d, v.v);
            }
            {
                var v = new dvec5(3.5d, -1d, -6.5d, -4d, 5.5d);
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-4d, v.w);
                Assert.AreEqual(5.5d, v.v);
            }
            {
                var v = new dvec5(new dvec2(-4.5d, 9d));
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(9d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
                Assert.AreEqual(0.0, v.v);
            }
            {
                var v = new dvec5(new dvec3(5d, 4d, 3d));
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(0.0, v.w);
                Assert.AreEqual(0.0, v.v);
            }
            {
                var v = new dvec5(new dvec4(-4d, -1d, -4d, -3.5d));
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-4d, v.z);
                Assert.AreEqual(-3.5d, v.w);
                Assert.AreEqual(0.0, v.v);
            }
            {
                var v = new dvec5(new dvec5(6d, -5d, -2d, 0.0, -5d));
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(0.0, v.w);
                Assert.AreEqual(-5d, v.v);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec5(-6.5d, 3.5d, -1d, 4d, 5d);
            Assert.AreEqual(-6.5d, v[0]);
            Assert.AreEqual(3.5d, v[1]);
            Assert.AreEqual(-1d, v[2]);
            Assert.AreEqual(4d, v[3]);
            Assert.AreEqual(5d, v[4]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[2] = 0.0;
            Assert.AreEqual(0.0, v[2]);
            v[2] = 1.0;
            Assert.AreEqual(1.0, v[2]);
            v[3] = 2d;
            Assert.AreEqual(2d, v[3]);
            v[3] = 3d;
            Assert.AreEqual(3d, v[3]);
            v[1] = 4d;
            Assert.AreEqual(4d, v[1]);
            v[1] = 5d;
            Assert.AreEqual(5d, v[1]);
            v[2] = 6d;
            Assert.AreEqual(6d, v[2]);
            v[1] = 7d;
            Assert.AreEqual(7d, v[1]);
            v[1] = 8d;
            Assert.AreEqual(8d, v[1]);
            v[0] = 9d;
            Assert.AreEqual(9d, v[0]);
            v[0] = -1d;
            Assert.AreEqual(-1d, v[0]);
            v[1] = -2d;
            Assert.AreEqual(-2d, v[1]);
            v[1] = -3d;
            Assert.AreEqual(-3d, v[1]);
            v[1] = -4d;
            Assert.AreEqual(-4d, v[1]);
            v[2] = -5d;
            Assert.AreEqual(-5d, v[2]);
            v[0] = -6d;
            Assert.AreEqual(-6d, v[0]);
            v[0] = -7d;
            Assert.AreEqual(-7d, v[0]);
            v[3] = -8d;
            Assert.AreEqual(-8d, v[3]);
            v[4] = -9d;
            Assert.AreEqual(-9d, v[4]);
            v[3] = -9.5d;
            Assert.AreEqual(-9.5d, v[3]);
            v[1] = -8.5d;
            Assert.AreEqual(-8.5d, v[1]);
            v[3] = -7.5d;
            Assert.AreEqual(-7.5d, v[3]);
            v[2] = -6.5d;
            Assert.AreEqual(-6.5d, v[2]);
            v[0] = -5.5d;
            Assert.AreEqual(-5.5d, v[0]);
            v[4] = -4.5d;
            Assert.AreEqual(-4.5d, v[4]);
            v[1] = -3.5d;
            Assert.AreEqual(-3.5d, v[1]);
            v[3] = -2.5d;
            Assert.AreEqual(-2.5d, v[3]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[4] = -0.5d;
            Assert.AreEqual(-0.5d, v[4]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[2] = 1.5d;
            Assert.AreEqual(1.5d, v[2]);
            v[1] = 2.5d;
            Assert.AreEqual(2.5d, v[1]);
            v[1] = 3.5d;
            Assert.AreEqual(3.5d, v[1]);
            v[4] = 4.5d;
            Assert.AreEqual(4.5d, v[4]);
            v[1] = 5.5d;
            Assert.AreEqual(5.5d, v[1]);
            v[1] = 6.5d;
            Assert.AreEqual(6.5d, v[1]);
            v[2] = 7.5d;
            Assert.AreEqual(7.5d, v[2]);
            v[1] = 8.5d;
            Assert.AreEqual(8.5d, v[1]);
            v[4] = 9.5d;
            Assert.AreEqual(9.5d, v[4]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new dvec5(-1d, -1d, 4.5d, 4d, 3d);
            var vals = v.Values;
            Assert.AreEqual(-1d, vals[0]);
            Assert.AreEqual(-1d, vals[1]);
            Assert.AreEqual(4.5d, vals[2]);
            Assert.AreEqual(4d, vals[3]);
            Assert.AreEqual(3d, vals[4]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, dvec5.Zero.x);
            Assert.AreEqual(0.0, dvec5.Zero.y);
            Assert.AreEqual(0.0, dvec5.Zero.z);
            Assert.AreEqual(0.0, dvec5.Zero.w);
            Assert.AreEqual(0.0, dvec5.Zero.v);
            
            Assert.AreEqual(1.0, dvec5.Ones.x);
            Assert.AreEqual(1.0, dvec5.Ones.y);
            Assert.AreEqual(1.0, dvec5.Ones.z);
            Assert.AreEqual(1.0, dvec5.Ones.w);
            Assert.AreEqual(1.0, dvec5.Ones.v);
            
            Assert.AreEqual(1.0, dvec5.UnitX.x);
            Assert.AreEqual(0.0, dvec5.UnitX.y);
            Assert.AreEqual(0.0, dvec5.UnitX.z);
            Assert.AreEqual(0.0, dvec5.UnitX.w);
            Assert.AreEqual(0.0, dvec5.UnitX.v);
            
            Assert.AreEqual(0.0, dvec5.UnitY.x);
            Assert.AreEqual(1.0, dvec5.UnitY.y);
            Assert.AreEqual(0.0, dvec5.UnitY.z);
            Assert.AreEqual(0.0, dvec5.UnitY.w);
            Assert.AreEqual(0.0, dvec5.UnitY.v);
            
            Assert.AreEqual(0.0, dvec5.UnitZ.x);
            Assert.AreEqual(0.0, dvec5.UnitZ.y);
            Assert.AreEqual(1.0, dvec5.UnitZ.z);
            Assert.AreEqual(0.0, dvec5.UnitZ.w);
            Assert.AreEqual(0.0, dvec5.UnitZ.v);
            
            Assert.AreEqual(0.0, dvec5.UnitW.x);
            Assert.AreEqual(0.0, dvec5.UnitW.y);
            Assert.AreEqual(0.0, dvec5.UnitW.z);
            Assert.AreEqual(1.0, dvec5.UnitW.w);
            Assert.AreEqual(0.0, dvec5.UnitW.v);
            
            Assert.AreEqual(0.0, dvec5.UnitV.x);
            Assert.AreEqual(0.0, dvec5.UnitV.y);
            Assert.AreEqual(0.0, dvec5.UnitV.z);
            Assert.AreEqual(0.0, dvec5.UnitV.w);
            Assert.AreEqual(1.0, dvec5.UnitV.v);
            
            Assert.AreEqual(double.MaxValue, dvec5.MaxValue.x);
            Assert.AreEqual(double.MaxValue, dvec5.MaxValue.y);
            Assert.AreEqual(double.MaxValue, dvec5.MaxValue.z);
            Assert.AreEqual(double.MaxValue, dvec5.MaxValue.w);
            Assert.AreEqual(double.MaxValue, dvec5.MaxValue.v);
            
            Assert.AreEqual(double.MinValue, dvec5.MinValue.x);
            Assert.AreEqual(double.MinValue, dvec5.MinValue.y);
            Assert.AreEqual(double.MinValue, dvec5.MinValue.z);
            Assert.AreEqual(double.MinValue, dvec5.MinValue.w);
            Assert.AreEqual(double.MinValue, dvec5.MinValue.v);
            
            Assert.AreEqual(double.Epsilon, dvec5.Epsilon.x);
            Assert.AreEqual(double.Epsilon, dvec5.Epsilon.y);
            Assert.AreEqual(double.Epsilon, dvec5.Epsilon.z);
            Assert.AreEqual(double.Epsilon, dvec5.Epsilon.w);
            Assert.AreEqual(double.Epsilon, dvec5.Epsilon.v);
            
            Assert.AreEqual(double.NaN, dvec5.NaN.x);
            Assert.AreEqual(double.NaN, dvec5.NaN.y);
            Assert.AreEqual(double.NaN, dvec5.NaN.z);
            Assert.AreEqual(double.NaN, dvec5.NaN.w);
            Assert.AreEqual(double.NaN, dvec5.NaN.v);
            
            Assert.AreEqual(double.NegativeInfinity, dvec5.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, dvec5.NegativeInfinity.y);
            Assert.AreEqual(double.NegativeInfinity, dvec5.NegativeInfinity.z);
            Assert.AreEqual(double.NegativeInfinity, dvec5.NegativeInfinity.w);
            Assert.AreEqual(double.NegativeInfinity, dvec5.NegativeInfinity.v);
            
            Assert.AreEqual(double.PositiveInfinity, dvec5.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, dvec5.PositiveInfinity.y);
            Assert.AreEqual(double.PositiveInfinity, dvec5.PositiveInfinity.z);
            Assert.AreEqual(double.PositiveInfinity, dvec5.PositiveInfinity.w);
            Assert.AreEqual(double.PositiveInfinity, dvec5.PositiveInfinity.v);
        }

        [Test]
        public void Operators()
        {
            var v1 = new dvec5(0.5d, 1.5d, 2d, -9d, -5.5d);
            var v2 = new dvec5(0.5d, 1.5d, 2d, -9d, -5.5d);
            var v3 = new dvec5(-5.5d, -9d, 2d, 1.5d, 0.5d);
            Assert.That(v1 == new dvec5(v1));
            Assert.That(v2 == new dvec5(v2));
            Assert.That(v3 == new dvec5(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new dvec5(-6d, 4d, -6d, -1.5d, 3.5d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = dvec5.Parse(s0);
            var v1 = dvec5.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = dvec5.TryParse(s0, out v0);
            var b1 = dvec5.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = dvec5.TryParse(null, out v0);
            Assert.False(b0);
            b0 = dvec5.TryParse("", out v0);
            Assert.False(b0);
            b0 = dvec5.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { dvec5.Parse(null); });
            Assert.Throws<FormatException>(() => { dvec5.Parse(""); });
            Assert.Throws<FormatException>(() => { dvec5.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = dvec5.Parse(s3, "; ", NumberStyles.Number);
            var v4 = dvec5.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = dvec5.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new dvec5(-2d, 4d, -6d, 9.5d, -8d);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<dvec5>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new dvec5(5d, 7d, 8.5d, 5d, -6.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(0.0, 1.0, 0.5d, 7d, 3.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(6d, 8d, -7d, 1.5d, 8.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(-7d, -8.5d, -1.5d, 4.5d, -1.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(-6.5d, -7d, -5.5d, 2d, 4d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(4.5d, -6.5d, -6d, -3d, -7.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(-3.5d, 7d, -7d, -5d, -7d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(2d, -5.5d, -9.5d, -2d, 4.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(2.5d, -1d, 8.5d, -1.5d, 6.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec5(9d, 7d, 9d, -5d, 1.5d);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new dvec5(8.5d, 7.5d, -9.5d, 8.5d, -5.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(0.0, 8d, 8.5d, -3.5d, 1.0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(-4.5d, -2d, 1.5d, 4.5d, 1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(5d, 1.0, 0.0, -8.5d, -3d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(-1.5d, -0.5d, -3d, -5d, 4d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(-3.5d, -6d, -1.5d, -1.5d, -9d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(4.5d, 7d, 3d, 4.5d, -8d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(2.5d, -1d, 4d, -3d, -5.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(-5d, -2.5d, -4d, -4.5d, 2.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec5(4d, -9.5d, -6.5d, -6d, 8.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new dvec5(7.5d, -2d, 8.5d, 2d, -4d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(2.5d, -1.5d, -7d, 5.5d, -0.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(-5d, 0.0, 3d, -9d, -9.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(-2d, -6.5d, 4d, 7.5d, -1.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(-2.5d, 7.5d, 4d, 9d, -8.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(-4.5d, -8d, -3d, 2d, -2d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(2.5d, -8d, 7.5d, 5d, -8d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(1.5d, 2d, 5.5d, 2d, 5.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(8.5d, -6d, 6d, 6d, 1.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec5(-9.5d, 6d, 4d, 8d, 4.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new dvec5(1.5d, 4d, -1d, 5.5d, -5d);
                var v1 = new dvec5(-0.5d, -6.5d, 1.0, 1.0, 0.0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(-0.5d, -1d, 7d, 2.5d, 7d);
                var v1 = new dvec5(-8d, -9d, -7.5d, -4.5d, 2d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(7.5d, -5.5d, 1.0, -8.5d, -1.5d);
                var v1 = new dvec5(-4.5d, -7.5d, 0.0, -6.5d, -3.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(7.5d, -2.5d, -1d, 4.5d, 0.5d);
                var v1 = new dvec5(4d, 3d, -3d, -8d, -5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(1.0, -2d, -4.5d, -9d, 5.5d);
                var v1 = new dvec5(-5d, -1d, 8.5d, -1.5d, 7d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(-5.5d, 6d, -4.5d, -5d, 9d);
                var v1 = new dvec5(7d, 2d, 0.5d, 6d, 0.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(7d, -6.5d, -8d, -6d, 3d);
                var v1 = new dvec5(1.0, 0.0, -3d, 1.0, 2d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(-5d, 5d, 3d, -1d, 0.0);
                var v1 = new dvec5(-3.5d, 9.5d, -6.5d, -4.5d, -3d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(-4d, -6.5d, -2d, -6d, 2d);
                var v1 = new dvec5(1.5d, 2d, 5.5d, -4.5d, -7.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec5(2d, -3d, 5d, -1.5d, 7d);
                var v1 = new dvec5(-9d, 3.5d, 8d, -6d, 3.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new dvec5(0.5d, -4.5d, -4.5d, 0.5d, -2d);
                var v1 = new dvec5(-4.5d, 1.5d, -2.5d, -2d, -9d);
                var v2 = new dvec5(8d, -5.5d, -0.5d, 2.5d, -4.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(-1.5d, 4.5d, 2d, -7.5d, -0.5d);
                var v1 = new dvec5(-0.5d, 2d, 2d, -5.5d, 2.5d);
                var v2 = new dvec5(7.5d, -9d, 0.0, 9.5d, 1.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(-1d, -3.5d, 8d, -5d, -4.5d);
                var v1 = new dvec5(-8d, 8.5d, 6d, -8d, 7d);
                var v2 = new dvec5(-4d, 1.5d, 9d, 8d, 4d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(0.5d, 0.0, 5d, 1.0, -7d);
                var v1 = new dvec5(7d, -2d, -6.5d, 9d, 2d);
                var v2 = new dvec5(-1.5d, -7.5d, 1.0, 8.5d, -4d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(5d, 0.5d, -1.5d, -9.5d, 8d);
                var v1 = new dvec5(-7.5d, -5d, -4d, 6d, 7d);
                var v2 = new dvec5(0.5d, -1.5d, -4.5d, -5d, -6d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(8.5d, 3.5d, 4.5d, -9d, 1.0);
                var v1 = new dvec5(6.5d, -3d, 9.5d, -7.5d, -5.5d);
                var v2 = new dvec5(8.5d, 2d, 8.5d, -3d, 7.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(6.5d, 7.5d, 7d, 3d, 1.0);
                var v1 = new dvec5(-6.5d, 2d, -0.5d, 0.0, -6.5d);
                var v2 = new dvec5(-5d, -2.5d, 9.5d, 3.5d, -2.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(-9.5d, -2.5d, 8d, 3.5d, 3d);
                var v1 = new dvec5(4.5d, -1.5d, -7.5d, 6.5d, -7d);
                var v2 = new dvec5(3.5d, 1.5d, 5d, 5.5d, -1d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(-9d, -6d, 1.0, 8d, -2d);
                var v1 = new dvec5(2.5d, -9.5d, -8.5d, -3d, 3.5d);
                var v2 = new dvec5(6.5d, 3d, 3.5d, 6.5d, -3.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec5(9d, -4d, 5d, 5.5d, 4d);
                var v1 = new dvec5(-1d, 4.5d, 4d, 8d, 3d);
                var v2 = new dvec5(7d, -5d, -2d, -3.5d, 8d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new dvec5(-0.5d, 7.5d, -0.5d, 3.5d, 9.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(5.5d, -5d, 8.5d, 3d, -0.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(-5d, 3d, 9.5d, 5d, -1d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(6.5d, 8.5d, 3d, 7.5d, 8d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(-9.5d, -0.5d, 3.5d, -3d, 3d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(6.5d, -1d, -1.5d, -6.5d, 5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(2d, 0.0, 9.5d, 5.5d, 7.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(-4d, -3d, 9d, -2d, -4.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(2.5d, -6.5d, -6d, -2d, -7.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec5(5d, -6d, 2d, -5.5d, 0.0);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new dvec5(-6.5d, -4d, -4d, -2.5d, -7.5d);
                var v1 = new dvec5(2.5d, -8.5d, -1.5d, -5d, 5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(-1.5d, 5d, -7.5d, 9.5d, 1.5d);
                var v1 = new dvec5(-8.5d, -0.5d, -1.5d, -8.5d, 0.0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(-9d, -1d, 0.0, 7.5d, -3.5d);
                var v1 = new dvec5(1.5d, 9d, -0.5d, 1.0, 5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(-8d, 4d, 4d, -7d, 0.5d);
                var v1 = new dvec5(2.5d, 2d, 0.5d, -3d, -6d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(-3.5d, 2.5d, 7.5d, -3d, -7.5d);
                var v1 = new dvec5(-9d, 8.5d, -0.5d, -5.5d, -6d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(-1d, 1.0, 9d, -0.5d, -6d);
                var v1 = new dvec5(-3d, -3d, -6d, 1.0, 1.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(-7.5d, 2.5d, -2.5d, 9d, -2.5d);
                var v1 = new dvec5(-6.5d, 1.0, 5d, 9d, 8.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(-8d, 9.5d, -6d, 4d, -4d);
                var v1 = new dvec5(-3.5d, -4d, -2.5d, -5d, 7d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(2.5d, -8.5d, 4d, -4.5d, 4.5d);
                var v1 = new dvec5(-7d, 4.5d, -5d, 0.0, -8d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec5(-9.5d, -2.5d, -1.5d, -8.5d, 3.5d);
                var v1 = new dvec5(4.5d, 5d, -2.5d, -3.5d, 9.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new dvec5(-0.5d, 2d, -1d, -5d, 9.5d);
                var v1 = new dvec5(5.5d, 6.5d, 8.5d, 6.5d, 6d);
                var v2 = new dvec5(1.5d, 8d, 7.5d, -6d, 9.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(-3d, -0.5d, -2.5d, 2d, 5.5d);
                var v1 = new dvec5(3d, 7.5d, -6d, 6.5d, -2d);
                var v2 = new dvec5(-6.5d, -5.5d, 4.5d, 1.5d, -8d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(-2d, 9.5d, -7d, 8d, -4d);
                var v1 = new dvec5(-7d, -5d, -8d, -5d, -5d);
                var v2 = new dvec5(-8.5d, -1.5d, 8.5d, -7d, -6d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(1.5d, -1d, 1.0, -1.5d, -3d);
                var v1 = new dvec5(8.5d, -0.5d, -6d, -4.5d, -9d);
                var v2 = new dvec5(1.5d, -2.5d, -4d, 2d, -6d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(-1d, 1.0, 7d, -8d, 5.5d);
                var v1 = new dvec5(1.5d, 1.5d, -1.5d, 2d, -7.5d);
                var v2 = new dvec5(7.5d, -1d, -2d, -1.5d, -5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(-5d, 9.5d, 9.5d, -8.5d, -9.5d);
                var v1 = new dvec5(-2d, -6.5d, 5d, -8d, -9d);
                var v2 = new dvec5(-6.5d, -5.5d, 2.5d, 0.5d, -6.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(0.5d, 1.0, -5d, 9.5d, 4d);
                var v1 = new dvec5(-9d, -8.5d, -9.5d, -8.5d, -5.5d);
                var v2 = new dvec5(0.0, -6.5d, 9.5d, 6d, -5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(-1.5d, -7d, -1.5d, 9d, 3d);
                var v1 = new dvec5(1.5d, -2.5d, 3.5d, -6.5d, 3d);
                var v2 = new dvec5(-1.5d, 6.5d, 0.5d, 8.5d, -3d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(7d, 9.5d, 8.5d, -9d, 1.5d);
                var v1 = new dvec5(6.5d, 5.5d, -3d, -6.5d, 6.5d);
                var v2 = new dvec5(4.5d, -9.5d, -8d, 6.5d, -9.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec5(-0.5d, -6.5d, 9.5d, 2d, 1.5d);
                var v1 = new dvec5(5d, 5.5d, -7.5d, -3.5d, 2.5d);
                var v2 = new dvec5(3d, 7d, 2.5d, 5.5d, -7d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new dvec5(-0.5d, -1d, 5.5d, 1.5d, -7d);
                var v1 = new dvec5(-0.5d, 8d, -4.5d, -4d, -7.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(-7.5d, 1.0, 7.5d, 0.0, -5.5d);
                var v1 = new dvec5(-0.5d, -7d, -0.5d, -4d, -6d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(3.5d, 5d, 5d, 8d, -6d);
                var v1 = new dvec5(-1.5d, 0.5d, -7d, 9d, 5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(-1d, 4.5d, 2d, 3d, -8d);
                var v1 = new dvec5(0.0, 0.5d, -5d, -3.5d, 4d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(-4d, 7d, -7d, -8.5d, 6d);
                var v1 = new dvec5(8.5d, -3d, 5d, 9d, 3.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(-3.5d, 1.5d, 1.5d, 9.5d, -0.5d);
                var v1 = new dvec5(-6.5d, 4d, -3.5d, -6d, -1.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(8.5d, 2.5d, -6d, 8d, -1d);
                var v1 = new dvec5(-2.5d, 9.5d, 3.5d, -7.5d, -6.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(9.5d, 1.0, 3d, 9d, 2d);
                var v1 = new dvec5(-3.5d, -1.5d, -5.5d, 2d, -7d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(-6d, -5.5d, 7d, -6d, -9d);
                var v1 = new dvec5(-9.5d, 3d, 2d, -5d, 4.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec5(5.5d, 3d, 8.5d, 8.5d, 5d);
                var v1 = new dvec5(-8.5d, 1.5d, 8d, 9d, -9d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new dvec5(3.5d, 0.0, -6.5d, 3d, 3.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(-1d, 4d, -9.5d, 3d, -3.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(0.0, -2d, 4.5d, 5.5d, -4d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(-6.5d, -9d, 3.5d, -6.5d, -1d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(-6d, -1.5d, -7d, -6.5d, 5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(-8.5d, -0.5d, 6.5d, 7.5d, 1.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(9.5d, 7.5d, 5.5d, -3d, -5.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(1.0, 3d, -1.5d, -8d, 2d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(-3.5d, 6d, -3d, 8.5d, -2d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec5(3.5d, -2d, 7.5d, 6d, 9.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1747604860);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.Random(random, -5, -1);
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
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.v, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(318689215);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomUniform(random, 3, 6);
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
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
            Assert.AreEqual(variance.v, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1037257217);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.Random(random, -2, 1);
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
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
            Assert.AreEqual(variance.v, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1755825219);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomUniform(random, 4, 8);
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
        public void RandomUniform4()
        {
            var random = new Random(1020816499);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.Random(random, -1, 3);
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
        public void RandomGaussian0()
        {
            var random = new Random(1604596889);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomNormal(random, 1.21747190096298d, 0.866343127967018d);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.21747190096298, 1.0);
            Assert.AreEqual(avg.y, 1.21747190096298, 1.0);
            Assert.AreEqual(avg.z, 1.21747190096298, 1.0);
            Assert.AreEqual(avg.w, 1.21747190096298, 1.0);
            Assert.AreEqual(avg.v, 1.21747190096298, 1.0);
            
            Assert.AreEqual(variance.x, 0.866343127967018, 3.0);
            Assert.AreEqual(variance.y, 0.866343127967018, 3.0);
            Assert.AreEqual(variance.z, 0.866343127967018, 3.0);
            Assert.AreEqual(variance.w, 0.866343127967018, 3.0);
            Assert.AreEqual(variance.v, 0.866343127967018, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1768921275);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomGaussian(random, 1.826729319909d, 6.69238447988982d);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.826729319909, 1.0);
            Assert.AreEqual(avg.y, 1.826729319909, 1.0);
            Assert.AreEqual(avg.z, 1.826729319909, 1.0);
            Assert.AreEqual(avg.w, 1.826729319909, 1.0);
            Assert.AreEqual(avg.v, 1.826729319909, 1.0);
            
            Assert.AreEqual(variance.x, 6.69238447988982, 3.0);
            Assert.AreEqual(variance.y, 6.69238447988982, 3.0);
            Assert.AreEqual(variance.z, 6.69238447988982, 3.0);
            Assert.AreEqual(variance.w, 6.69238447988982, 3.0);
            Assert.AreEqual(variance.v, 6.69238447988982, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1179632126);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomNormal(random, 1.83387813709391d, 8.30435675489919d);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.83387813709391, 1.0);
            Assert.AreEqual(avg.y, 1.83387813709391, 1.0);
            Assert.AreEqual(avg.z, 1.83387813709391, 1.0);
            Assert.AreEqual(avg.w, 1.83387813709391, 1.0);
            Assert.AreEqual(avg.v, 1.83387813709391, 1.0);
            
            Assert.AreEqual(variance.x, 8.30435675489919, 3.0);
            Assert.AreEqual(variance.y, 8.30435675489919, 3.0);
            Assert.AreEqual(variance.z, 8.30435675489919, 3.0);
            Assert.AreEqual(variance.w, 8.30435675489919, 3.0);
            Assert.AreEqual(variance.v, 8.30435675489919, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(1775234580);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomGaussian(random, -0.534917255181315d, 9.48868009237977d);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.534917255181315, 1.0);
            Assert.AreEqual(avg.y, -0.534917255181315, 1.0);
            Assert.AreEqual(avg.z, -0.534917255181315, 1.0);
            Assert.AreEqual(avg.w, -0.534917255181315, 1.0);
            Assert.AreEqual(avg.v, -0.534917255181315, 1.0);
            
            Assert.AreEqual(variance.x, 9.48868009237977, 3.0);
            Assert.AreEqual(variance.y, 9.48868009237977, 3.0);
            Assert.AreEqual(variance.z, 9.48868009237977, 3.0);
            Assert.AreEqual(variance.w, 9.48868009237977, 3.0);
            Assert.AreEqual(variance.v, 9.48868009237977, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(760980668);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomNormal(random, -0.933628685275851d, 4.25980142050413d);
                sum += (dvec5)v;
                sumSqr += glm.Pow2((dvec5)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.933628685275851, 1.0);
            Assert.AreEqual(avg.y, -0.933628685275851, 1.0);
            Assert.AreEqual(avg.z, -0.933628685275851, 1.0);
            Assert.AreEqual(avg.w, -0.933628685275851, 1.0);
            Assert.AreEqual(avg.v, -0.933628685275851, 1.0);
            
            Assert.AreEqual(variance.x, 4.25980142050413, 3.0);
            Assert.AreEqual(variance.y, 4.25980142050413, 3.0);
            Assert.AreEqual(variance.z, 4.25980142050413, 3.0);
            Assert.AreEqual(variance.w, 4.25980142050413, 3.0);
            Assert.AreEqual(variance.v, 4.25980142050413, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(1076850660);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomNormal(random);
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
            var random = new Random(51266832);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomNormal(random);
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
            var random = new Random(1173166651);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomNormal(random);
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
            var random = new Random(147582823);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomNormal(random);
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
            var random = new Random(884218678);
            var sum = new dvec5(0.0);
            var sumSqr = new dvec5(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec5.RandomNormal(random);
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
