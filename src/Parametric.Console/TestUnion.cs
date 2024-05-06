namespace Parametric.Console;

using Parametric;

/// <summary>
/// A test class for the Parametric attrbute.
/// </summary>
/// <param name="First">The first named member of the Union.</param>
/// <param name="Second">The first named member of the Union.</param>
[Parametric]
internal sealed record TestUnion(int First = 0, int Second = 0);