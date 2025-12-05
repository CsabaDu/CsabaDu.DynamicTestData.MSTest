// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.DynamicDataRowSources;

/// <summary>
/// Represents an abstract base class for dynamically generating rows of complete object arrays  based on the specified
/// arguments code.
/// </summary>
/// <remarks>This class extends <see cref="DynamicObjectArrayRowSource"/> and is designed to provide  a
/// specialized implementation for handling complete object arrays. It uses the  <see cref="PropsCode.TestCaseName"/>
/// property as a key component in its behavior.</remarks>
/// <param name="argsCode"></param>
public abstract class DynamicCompleteObjectArrayRowSource(ArgsCode argsCode)
: DynamicObjectArrayRowSource(argsCode, PropsCode.TestCaseName);
