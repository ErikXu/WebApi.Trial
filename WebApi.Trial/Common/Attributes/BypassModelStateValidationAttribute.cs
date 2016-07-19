using System;

namespace WebApi.Trial.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false)]
    public sealed class BypassModelStateValidationAttribute : Attribute
    {

    }
}