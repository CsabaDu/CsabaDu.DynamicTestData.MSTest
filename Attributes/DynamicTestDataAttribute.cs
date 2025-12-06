// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)using System;

namespace CsabaDu.DynamicTestData.MSTest.Attributes;

public class DynamicTestDataAttribute : DynamicTestDataAttributeBase
{
    public DynamicTestDataAttribute(string dynamicDataSourceName) : base(dynamicDataSourceName)
    {
    }

    public DynamicTestDataAttribute(string dynamicDataSourceName, DynamicDataSourceType dynamicDataSourceType) : base(dynamicDataSourceName, dynamicDataSourceType)
    {
    }

    public DynamicTestDataAttribute(string dynamicDataSourceName, params object?[] dynamicDataSourceArguments) : base(dynamicDataSourceName, dynamicDataSourceArguments)
    {
    }

    public DynamicTestDataAttribute(string dynamicDataSourceName, Type dynamicDataDeclaringType) : base(dynamicDataSourceName, dynamicDataDeclaringType)
    {
    }

    public DynamicTestDataAttribute(string dynamicDataSourceName, Type dynamicDataDeclaringType, DynamicDataSourceType dynamicDataSourceType) : base(dynamicDataSourceName, dynamicDataDeclaringType, dynamicDataSourceType)
    {
    }

    public DynamicTestDataAttribute(string dynamicDataSourceName, Type dynamicDataDeclaringType, params object?[] dynamicDataSourceArguments) : base(dynamicDataSourceName, dynamicDataDeclaringType, dynamicDataSourceArguments)
    {
    }
}
