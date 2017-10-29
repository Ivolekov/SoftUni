using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    public class UnstabileStar : FallingStar
    {
        private int livetime;

        public UnstabileStar(int x, int y, int width, int height, Point direction, int livetime = 8)
            : base(x, y, width, height, direction)
        {
            this.livetime = livetime;
        }

        public override void Update()
        {
            if (livetime <= 0)
            {
                this.Exists = false;
            }

            this.livetime--;
            base.Update();
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> producedObjects = new List<EnvironmentObject>();
            if (!this.Exists)
            {
                for (int y = this.Bounds.TopLeft.Y - 2; y <= this.Bounds.TopLeft.Y + 2; y++)
                {
                    for (int x = this.Bounds.TopLeft.X - 2; x <= this.Bounds.TopLeft.X + 2; x++)
                    {
                        if (!(x == this.Bounds.TopLeft.X && y == this.Bounds.TopLeft.Y))
                        {
                            producedObjects.Add(new Explosion(x, y, 2));
                        }
                    }
                }

                return producedObjects;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
