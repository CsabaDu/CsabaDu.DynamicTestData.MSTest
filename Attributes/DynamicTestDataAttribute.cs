// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)using System;

namespace CsabaDu.DynamicTestData.MSTest.Attributes;

/// <summary>
/// Custom DynamicData attribute that wraps MSTest's sealed DynamicDataAttribute
/// to provide custom display names via TestDataFactory.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class DynamicTestDataAttribute : Attribute, ITestDataSource
{
    private readonly DynamicDataAttribute _dynamicDataAttribute;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public DynamicTestDataAttribute(
        string dynamicDataSourceName,
        DynamicDataSourceType dynamicDataSourceType)
    {
        _dynamicDataAttribute = new DynamicDataAttribute(
            dynamicDataSourceName,
            dynamicDataSourceType);
    }

    public DynamicTestDataAttribute(string dynamicDataSourceName)
    {
        _dynamicDataAttribute =
            new DynamicDataAttribute(dynamicDataSourceName);
    }

    public DynamicTestDataAttribute(
        string dynamicDataSourceName,
        params object?[] dynamicDataSourceArguments)
    {
        _dynamicDataAttribute = new DynamicDataAttribute(
            dynamicDataSourceName,
            dynamicDataSourceArguments);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public DynamicTestDataAttribute(
        string dynamicDataSourceName,
        Type dynamicDataDeclaringType,
        DynamicDataSourceType dynamicDataSourceType)
    {
        _dynamicDataAttribute = new DynamicDataAttribute(
            dynamicDataSourceName,
            dynamicDataDeclaringType,
            dynamicDataSourceType);
    }

    public DynamicTestDataAttribute(
        string dynamicDataSourceName,
        Type dynamicDataDeclaringType)
    {
        _dynamicDataAttribute = new DynamicDataAttribute(
            dynamicDataSourceName,
            dynamicDataDeclaringType);
    }

    public DynamicTestDataAttribute(
        string dynamicDataSourceName,
        Type dynamicDataDeclaringType,
        params object?[] dynamicDataSourceArguments)
    {
        _dynamicDataAttribute = new DynamicDataAttribute
            (dynamicDataSourceName,
            dynamicDataDeclaringType,
            dynamicDataSourceArguments);
    }

    /// <inheritdoc />
    public IEnumerable<object?[]> GetData(MethodInfo methodInfo)
    => _dynamicDataAttribute.GetData(methodInfo);

    /// <inheritdoc />
    public string? GetDisplayName(
        MethodInfo methodInfo,
        object?[]? data)
    => TestDataFactory.GetDisplayName(
        methodInfo.Name,
        data);
}