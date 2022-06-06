using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Car
    {
        public event Action OverSpeed;
        public event EventHandler DriveAtSameSpeed;
        public string Name { get; set; }
        public float Speed { get; set; }

        public void SpeedTest(float speed)
        {
            if(speed > 120)
            {
                OverSpeed?.Invoke();
            }
            else
            {
                DriveAtSameSpeed?.Invoke(this, null);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
