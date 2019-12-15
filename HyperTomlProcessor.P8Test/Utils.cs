﻿using System.Collections.Generic;
using NUnit.Framework;

namespace HyperTomlProcessor.Test
{
    static class Utils
    {
        internal static void SequenceEqual<T>(this IEnumerable<T> actual, params T[] expected)
        {
            var i = 0;
            foreach (var o in actual)
                Assert.AreEqual(expected[i++], o);
        }
    }
}
