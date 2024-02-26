using Stride.Core;
using Stride.Engine;

namespace ExternalPackage1;

[ComponentCategory("ExternalPackage")]
[Stride.Core.DataContract("ExternalPackageScript")]
public class ExternalPackageScript: StartupScript
{
    public override void Start()
    {
        base.Start();
    }
}