using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModP2.Weapon.Models
{
    public class Weapon
    {
        public int Comb { get; set; }
        public double TimeShoot { get; set; }

        public void SingleShotWeapon(double time)
        {
            TimeShoot = time;
            if (TimeShoot >= 1)
            {
                Console.WriteLine("This is Single shoot weapon ");
            }
        }

        public void AutomaticWeapon(double time)

        {
            TimeShoot = time;
            if(TimeShoot >= 0.5 && TimeShoot<1) 
            {
                Console.WriteLine("This is Automatic Weapon");
            }
        }

        public void CombFilling(int comb)
        {
            Comb = comb;
            if (comb == 0)
            {
                Console.WriteLine("Please fill the comb");
            }
            if (comb == 30)
            {
                Console.WriteLine("Comb is full");
            }
            else
            {
                Console.WriteLine("dont need fill the comb");
            }
        }
    }
}
