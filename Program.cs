namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(10,23,false);
            
           

            bool f = false;
            string choice;
            do
            {
                Console.WriteLine("0. Informasiya alin  " +
                    "1. Ates acin  " +
                    "2. Tam dolmaga lazim olan gulle sayini goster  " +
                    "3. Daragi yeniden doldur  " +
                    "4. Atis modunu deyis  " +
                    "5. Proqrami dayandır.");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        
                        weapon.ShowFullInfo();
                        break;

                    case "1":
                        weapon.Shoot();
                        break;

                    case "2":
                        weapon.GetRemainBulletCount();
                        break;

                     case "3":
                        weapon.Reload();
                        break;

                     case "4":
                        weapon.ChangeFireMode();
                        break;

                     case "5":
                        f = true;
                        break;

                }
            }
            while (!f);





        }
    }
}
