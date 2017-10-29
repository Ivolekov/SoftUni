namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;

    using EnvironmentSystem.Models.DataStructures;

    public class Tail : EnvironmentObject
    {
        private int livetime;

        public Tail(int x, int y, int livetime = 1)
            : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,] { { '*' } };
            this.livetime = livetime;
        }

        public override void Update()
        {
            this.livetime--;
            if (this.livetime <= 0)
            {
                this.Exists = false;
            }
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
