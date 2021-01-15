﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using AliceToolsProxies.Abstracts;
using AliceToolsProxies.InternalMembers;

namespace AliceToolsProxies
{
    /// <summary>
    /// Represents the build operation of .acx files.
    /// </summary>
    public class AliceToolsAcxBuild : AliceAcxFileOperation
    {
        /// <inheritdoc/>
        public override string OperationName => "build";

        /// <summary>
        /// Output file ath. 
        /// </summary>
        public string OutputPath { get; set; }

        /// <inheritdoc/>
        protected override void WriteCustomArguments(ref AliceToolsArgumentsWriter writer)
        {
            string.IsNullOrWhiteSpace(OutputPath).TrueThrowPropertyInvalidOperation(nameof(OutputPath));
            writer.Write($"-o {OutputPath}");
        }
    }

}
