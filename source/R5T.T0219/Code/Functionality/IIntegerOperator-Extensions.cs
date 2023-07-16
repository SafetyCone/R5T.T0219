using System;

using R5T.T0132;


namespace R5T.T0219.Extensions
{
    [FunctionalityMarker]
    public partial interface IIntegerOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IDotnetMajorVersion"/>
        public IDotnetMajorVersion ToDotnetMajorVersion(int value)
        {
            var output = new DotnetMajorVersion(value);
            return output;
        }
    }
}
