﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using AliceToolsProxies.Abstracts;

namespace AliceToolsProxies
{
    /// <summary>
    /// Represents the list operation of alice archive files.
    /// </summary>
    public class AliceToolsArList : AliceArFileOperation
    {
        /// <inheritdoc/>
        public override string OperationName => "list";

        /// <inheritdoc/>
        protected override void WriteCustomArguments(ref AliceToolsArgumentsWriter writer) { }
    }

}
