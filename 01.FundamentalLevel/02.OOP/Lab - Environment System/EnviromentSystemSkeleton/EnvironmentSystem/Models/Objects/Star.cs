using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using EnvironmentSystem.Models.DataStructures;

    public class Star : EnvironmentObject
    {
        private const int ImageChangeFrequency = 10;

        protected static readonly char[] StarImage = new char[] { 'O', '0', '@' };

        private static readonly Random RemdomImage = new Random();

        private int updateCount;

        public Star(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
            this.ImageProfile = new char[,] { { StarImage[0] } };
        }

        public override void Update()
        {
            if (this.updateCount % ImageChangeFrequency == 0)
            {
                int index = RemdomImage.Next(0, StarImage.Length);
                this.ImageProfile = new char[,] { { StarImage[index] } };
            }

            this.updateCount++;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            if (collisionInfo.HitObject.CollisionGroup == CollisionGroup.Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new EnvironmentObject[0];
        }
    }
}
