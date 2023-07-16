using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0219
{
    /// <inheritdoc cref="IDotnetMajorVersion"/>
    [StrongTypeImplementationMarker]
    public class DotnetMajorVersion : TypedBase<int>, IStrongTypeMarker,
        IDotnetMajorVersion
    {
        public DotnetMajorVersion(int value)
            : base(value)
        {
        }
    }
}