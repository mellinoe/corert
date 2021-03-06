﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Internal.Runtime.CompilerHelpers
{
    /// <summary>
    /// These methods are used to throw exceptions from generated code.
    /// </summary>
    [System.Runtime.CompilerServices.DependencyReductionRoot] /* keep rooted as code gen may add references to these */
    internal static class ThrowHelpers
    {
        private static void ThrowOverflowException()
        {
            throw new OverflowException();
        }

        private static void ThrowIndexOutOfRangeException()
        {
            throw new IndexOutOfRangeException();
        }

        private static void ThrowNullReferenceException()
        {
            throw new NullReferenceException();
        }

        private static void ThrowDivideByZeroException()
        {
            throw new DivideByZeroException();
        }

        private static void ThrowArrayTypeMismatchException()
        {
            throw new ArrayTypeMismatchException();
        }

        private static void ThrowPlatformNotSupportedException()
        {
            throw new PlatformNotSupportedException();
        }

        private static void ThrowTypeLoadException()
        {
            throw new TypeLoadException();
        }

        private static void ThrowArgumentException()
        {
            throw new ArgumentException();
        }

        private static void ThrowArgumentOutOfRangeException()
        {
            throw new ArgumentOutOfRangeException();
        }

    }
}
