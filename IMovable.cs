using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public interface IMovable
    {
        public Vector Position { get; set; }
        public Vector Velocity { get; set; }
    }
}
