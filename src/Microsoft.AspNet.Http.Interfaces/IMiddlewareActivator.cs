using System;
using Microsoft.Framework.Runtime;

namespace Microsoft.AspNet.Http
{
    [AssemblyNeutral]
    public interface IMiddlewareActivator
    {
        object CreateInstance(Type middlewareType, object[] parameters);
    }
}