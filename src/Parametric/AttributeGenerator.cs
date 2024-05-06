namespace Parametric;

using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

[Generator]
public sealed class AttributeGenerator
    : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(Generate);
    }

    private static void Generate(IncrementalGeneratorPostInitializationContext context)
    {
        const string source = $$"""
            namespace Parametric;

            using System;

            [AttributeUsage(AttributeTargets.Class, Inherited = false)]
            public sealed class ParametricAttribute
                : Attribute
            {
            }
            """;

        context.AddSource("ParametricAttribute.g.cs", SourceText.From(source, Encoding.UTF8));
    }
}