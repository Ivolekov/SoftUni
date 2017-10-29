using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentSystem.Models.Objects
{
    public class Explosion : Tail
    {
        public Explosion(int x, int y, int livetime = 2)
            : base(x, y, livetime)
        {
            this.CollisionGroup = CollisionGroup.Explosion;
        }
    }
}
