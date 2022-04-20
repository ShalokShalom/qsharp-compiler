﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

module Microsoft.Quantum.QsCompiler.SyntaxProcessing.CapabilityInference.Capabilities

open Microsoft.Quantum.QsCompiler.DataTypes
open Microsoft.Quantum.QsCompiler.SyntaxProcessing
open Microsoft.Quantum.QsCompiler.SyntaxTree

/// Returns all capability diagnostics for the scope. Ranges are relative to the start of the specialization.
[<CompiledName "Diagnose">]
val diagnose: context: ScopeContext -> scope: QsScope -> QsCompilerDiagnostic seq

/// Infers the capability of all callables in the compilation, adding the built-in Capability attribute to each
/// callable.
[<CompiledName "InferAttributes">]
val inferAttributes: compilation: QsCompilation -> QsCompilation
