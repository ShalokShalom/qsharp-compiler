﻿// -----------------------------------------------------------------------
// <copyright file="Trunc.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// Portions Copyright (c) Microsoft Corporation
// </copyright>
// -----------------------------------------------------------------------

using LlvmBindings.Interop;

namespace LlvmBindings.Instructions
{
    /// <summary>Integer truncate instruction.</summary>
    public class Trunc
        : Cast
    {
        internal Trunc(LLVMValueRef valueRef)
            : base(valueRef)
        {
        }
    }
}
