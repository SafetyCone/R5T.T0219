using System;


namespace R5T.T0219.Extensions
{
    public static class IntegerExtensions
    {
        /// <inheritdoc cref="IIntegerOperator.ToDotnetMajorVersion(int)"/>
        public static IDotnetMajorVersion ToDotnetMajorVersion(this int value)
        {
            return Instances.IntegerOperator_Extensions.ToDotnetMajorVersion(value);
        }
    }
}
