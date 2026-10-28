using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmartPot.Program;

namespace SmartPot
{
    internal class Smartpot
    {
        public event MyDelegate OnDishReady;

        public void StartCooking(string nameDiah, int minutes)
        {
            Console.WriteLine("Diah:  " + nameDiah + "   :taim "+(minutes));
            for (int i = 0; i < minutes; i++) { }
            OnDishReady?.Invoke(nameDiah, minutes);
        }


    }
}
