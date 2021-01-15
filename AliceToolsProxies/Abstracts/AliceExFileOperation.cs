﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace AliceToolsProxies.Abstracts
{
    /// <summary>
    /// Represents the operation of .ex files.
    /// </summary>
    public abstract class AliceExFileOperation : AliceFileOperation
    {
        /// <inheritdoc/>
        public override string FileType => "ex";
    }
}
