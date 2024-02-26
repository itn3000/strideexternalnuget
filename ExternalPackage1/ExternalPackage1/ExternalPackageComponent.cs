using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core;
using Stride.Engine;
using Stride.Engine.Design;
using Stride.Games;

namespace ExternalPackage1
{
    [ComponentCategory("ExternalPackage")]
    [Display("External Package Component")]
    [DefaultEntityComponentProcessor(typeof(ExternalPackageProcessor))]
    [DataContract]
    public class ExternalPackageComponent: EntityComponent
    {
        public int Value1 { get; set; }
    }

    public class ExternalPackageProcessor : EntityProcessor<ExternalPackageComponent>
    {
        protected override void OnSystemAdd()
        {
            base.OnSystemAdd();
        }
        protected override void OnSystemRemove()
        {
            base.OnSystemRemove();
        }

        public override void Update(GameTime time)
        {
            base.Update(time);
        }
    }


}
