﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VowpalWabbitDebugExample.cs">
//   Copyright (c) by respective owners including Yahoo!, Microsoft, and
//   individual contributors. All rights reserved.  Released under a BSD
//   license as described in the file LICENSE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Diagnostics;

namespace VW.Serializer
{
    /// <summary>
    /// A debug example generated in debug mode by the serializer. Apart from the native example a
    /// string version is generated.
    /// </summary>
    [DebuggerDisplay("CmdLine: {VowpalWabbitString}")]
    public class VowpalWabbitDebugExample : VowpalWabbitExample
    {
        internal VowpalWabbitDebugExample(VowpalWabbitExample example, string vwString) :
            base(example.Owner, example)
        {
            this.VowpalWabbitString = vwString;
        }

        /// <summary>
        /// Native vw string representation generated by <see name="VowpalWabbitStringVisitor"/>.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string VowpalWabbitString 
        {
            get;
            private set;
        }
    }
}