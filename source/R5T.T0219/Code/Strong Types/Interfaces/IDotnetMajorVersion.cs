using System;

using R5T.T0178;
using R5T.T0185;


namespace R5T.T0219
{
    /// <summary>
    /// Strongly-types a int as a .NET major version number (i.e. 5, 6, 7, etc.).
    /// </summary>
    [StrongTypeMarker]
    public interface IDotnetMajorVersion : IStrongTypeMarker,
        IMajorVersionNumber
    {
    }
}