using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class Move
    {
        IMovable MovableObject;

        public Move(IMovable movableObject)
        {
            this.MovableObject = movableObject;
        }

        public void Execute()
        {
            MovableObject.Position = Vector.Add(MovableObject.Position, MovableObject.Velocity);
        }
    }
}
