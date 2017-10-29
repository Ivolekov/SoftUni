namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;

    using EnvironmentSystem.Models.DataStructures;

    public class FallingStar : MovingObject
    {
        public FallingStar(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = new char[,] { { 'V' } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObjectGroup = collisionInfo.HitObject.CollisionGroup;
            if (hitObjectGroup == CollisionGroup.Ground || hitObjectGroup == CollisionGroup.Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> producedObject = new List<EnvironmentObject>();
            producedObject.Add(new Tail(this.Bounds.TopLeft.X - this.Direction.X, this.Bounds.TopLeft.Y - this.Direction.Y));
            producedObject.Add(
                new Tail(this.Bounds.TopLeft.X - 2 * this.Direction.X, this.Bounds.TopLeft.Y - 2 * this.Direction.Y));
            producedObject.Add(
                new Tail(this.Bounds.TopLeft.X - 3 * this.Direction.X, this.Bounds.TopLeft.Y - 3 * this.Direction.Y));

            return producedObject;
        }
    }
}
