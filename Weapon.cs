using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Weapon
    {
        private int _bulletnumber;
        private int _bulletcapasity;
        public bool AutomaticMode;

      

        public int BulletCapasity 
        { 
            get
            { 
              return _bulletcapasity;
            }
            set
            {
                if (value>0)
                {
                    _bulletcapasity = value;
                }
                    
            }
        }
        
        public int BulletNumber
        {
            get
            {
                return _bulletnumber;
            }
            set
            {
                if (value<BulletCapasity && value==BulletCapasity)
                {
                    _bulletnumber = value;
                }
            }
        }

        public Weapon()
        {
            
        }
        public Weapon(int bulletnumber, int bulletcapasity, bool automaticMode)
         {
            _bulletnumber = bulletnumber;
            _bulletcapasity = bulletcapasity;
            AutomaticMode = automaticMode;
         }

        public void Shoot()
        {
            if (BulletNumber > 0)
            {
                if (AutomaticMode)
                {
                    Console.WriteLine("avtomatik moddadi,daraq bosaldi.");
                        BulletNumber = 0;
                }
                else 
                {
                    
                    Console.WriteLine("tekli moddadi,1 gulle atildi.");
                    BulletNumber--;
                }
            }
            else
            {
                Console.WriteLine("gulle yoxdu.");
            }
        }

        public void GetRemainBulletCount()
        {
            int a = BulletCapasity - BulletNumber;
            Console.WriteLine(a);
        }

        public void Reload()
        {
            BulletNumber = BulletCapasity;
            Console.WriteLine("Daraq yeniden dolduruldu.");
        }

        public void ChangeFireMode()
            
        {
            bool AutomaticMode = true;
            if (AutomaticMode)
            {
                AutomaticMode=!AutomaticMode;
                Console.WriteLine("mod deyisdi,tekli moddadi.");
            }
            else
            {
                bool b = !AutomaticMode;
                b = AutomaticMode;
                Console.WriteLine("mod deyisdi,avtomatik moddadi.");
            }
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"gulle tutumu: {BulletCapasity}, gulle sayi: {BulletNumber}, atis modu: {AutomaticMode}");
        }

      
       
    }
}
