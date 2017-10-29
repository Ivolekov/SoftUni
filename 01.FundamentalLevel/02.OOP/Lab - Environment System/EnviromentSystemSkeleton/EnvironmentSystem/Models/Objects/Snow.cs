using System.Collections.Generic;

namespace EnvironmentSystem.Models.Objects
{
    using System;

    using EnvironmentSystem.Models.DataStructures;

    public class Snow : EnvironmentObject
    {
        public Snow(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
            this.ImageProfile = new char[,] { { '.' } };
            this.CollisionGroup = CollisionGroup.Snow;
        }

        public Snow(Rectangle bounds)
            : base(bounds)
        {
        }

        public override void Update()
        {
            
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new EnvironmentObject[0];
        }
    }
}
