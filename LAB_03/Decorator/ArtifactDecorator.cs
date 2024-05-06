using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ArtifactDecorator : BaseDecorator
    {
        public string Artifact {  get; set; }
        public ArtifactDecorator(IHero hero, string artifact) : base(hero)
        {
            Artifact = artifact;
        }

        public override void Show()
        {
            _hero.Show();
            Console.WriteLine($"Artifact: {Artifact}");

        }
    }
}
