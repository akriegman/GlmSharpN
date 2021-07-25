using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    /// <summary>
    /// Static class that contains static glm functions
    /// </summary>
    public static partial class glm
    {
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public static swizzle_bvec5 swizzle(bvec5 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static bool[] Values(bvec5 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<bool> GetEnumerator(bvec5 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(bvec5 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(bvec5 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(bvec5 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public static int Count(bvec5 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(bvec5 v, bvec5 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(bvec5 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(bvec5 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(bvec5 lhs, bvec5 rhs) => bvec5.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(bvec5 lhs, bvec5 rhs) => bvec5.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Not (!v).
        /// </summary>
        public static bvec5 Not(bvec5 v) => bvec5.Not(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec5 And(bvec5 lhs, bvec5 rhs) => bvec5.And(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec5 Nand(bvec5 lhs, bvec5 rhs) => bvec5.Nand(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec5 Or(bvec5 lhs, bvec5 rhs) => bvec5.Or(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec5 Nor(bvec5 lhs, bvec5 rhs) => bvec5.Nor(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec5 Xor(bvec5 lhs, bvec5 rhs) => bvec5.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec5 Xnor(bvec5 lhs, bvec5 rhs) => bvec5.Xnor(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static bool MinElement(bvec5 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static bool MaxElement(bvec5 v) => v.MaxElement;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public static bool All(bvec5 v) => v.All;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public static bool Any(bvec5 v) => v.Any;

    }
}
