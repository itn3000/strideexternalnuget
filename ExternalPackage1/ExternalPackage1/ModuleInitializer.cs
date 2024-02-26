using System.Reflection;
using Stride.Core;
using Stride.Core.Reflection;

namespace ExternalPackage1;

internal class Module
{
    [ModuleInitializer]
    public static void InitializeModule()
    {
        AssemblyRegistry.Register(typeof(Module).GetTypeInfo().Assembly, AssemblyCommonCategories.Assets);
    }
}