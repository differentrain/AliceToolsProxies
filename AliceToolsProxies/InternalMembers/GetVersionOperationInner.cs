﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using AliceToolsProxies.Abstracts;

using System.Text;

namespace AliceToolsProxies.InternalMembers
{
    internal sealed class GetVersionOperationInner : IAliceToolsOperation
    {
        public static readonly GetVersionOperationInner Default = new GetVersionOperationInner();

        public Encoding OutputEncoding => null;

        public string GetArguments() => "--version";
    }
}
