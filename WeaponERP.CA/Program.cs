using System.Transactions;
using WeaponERP.Business.Exceptions;
using WeaponERP.Business.Implementations;
using WeaponERP.Business.Interfaces;
using WeaponERP.Core.Models.Weapons;
using System.Media;
namespace WeaponERP.CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IPistolService pistolService=new PistolService();
            IAK_74Service aK_74Service = new AK_74Service();
            label1:
            Console.WriteLine("Choose weapon type:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. AK-74");
            Console.WriteLine("2. Pistol");
            int c1 = Convert.ToInt32(Console.ReadLine());
            if (c1 == 0)
            {
                Console.WriteLine("Program exited!");
            }
            else if (c1 == 1)
            {
                label2:
                Console.WriteLine("Choose AK-74 operation:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create Ak-74");
                Console.WriteLine("2. Show all Ak-74 s");
                Console.WriteLine("3.Shoot");
                Console.WriteLine("4.Fire");
                Console.WriteLine("5.Reload");
                Console.WriteLine("6.Change fire mode");
                Console.WriteLine("7.Change Bullet Capacity");
                int c2 = Convert.ToInt32(Console.ReadLine());

                if (c2 == 0)
                {
                    Console.WriteLine("Ak-74 operation exited");
                    goto label1;
                }
                else if (c2 == 1)
                {label3:
                    Console.WriteLine("Enter name:");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter bullet capacity:");
                    int capacity= Convert.ToInt32(Console.ReadLine());
                    if(name != null)
                    {
                        aK_74Service.Create(new AK_74(name, capacity));
                    }
                    else
                    {  
                        goto label3;

                    }
                    goto label2;
                }
                else if (c2 == 2)
                {
                    aK_74Service.GetAllAK_74s().ForEach(x => Console.WriteLine(x));
                    goto label2;
                }
                else if (c2 == 3)
                {
                    Console.WriteLine("Enter ID of the Ak-74 that you want to shoot: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        aK_74Service.Shoot(id);
                    }
                    catch(WeaponNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message );
                    }
                    goto label2;
                }
                else if (c2 == 4)
                {
                    Console.WriteLine("Enter ID of the Ak-74 that you want to fire: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        aK_74Service.Fire(id);
                    }
                    catch (WeaponNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto label2;
                }
                else if (c2 == 5)
                {
                    Console.WriteLine("Enter ID of the Ak-74 that you want to reload: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        aK_74Service.Reload(id);
                    }
                    catch (WeaponNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto label2;

                }
                else if (c2 == 6)
                {
                    Console.WriteLine("Enter ID of the Ak-74 that you want to reload: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        aK_74Service.ChangeFireMode(id);
                    }
                    catch (WeaponNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto label2;

                }
                else if (c2 == 7)
                {

                    Console.WriteLine("Enter ID of the Ak-74 that you want to change bullet capacity: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        aK_74Service.ChangeBulletCapacity(id);
                    }
                    catch (WeaponNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto label2;


                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    goto label2;
                }



            }
            else if (c1 == 2)
            {
            label4:
                Console.WriteLine("Choose Pistol operation:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create Pistol");
                Console.WriteLine("2. Show all Pistols");
                Console.WriteLine("3.Shoot");
                Console.WriteLine("4.Reload");
                Console.WriteLine("5.Change Bullet Capacity");
                int c2 = Convert.ToInt32(Console.ReadLine());
                if (c2 == 0)
                {
                    Console.WriteLine("Pistol operation exited.");
                    goto label1;
                }
                else if (c2 == 1)
                {
                label5:
                    Console.WriteLine("Enter name:");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter bullet capacity:");
                    int capacity = Convert.ToInt32(Console.ReadLine());
                    if (name != null)
                    {
                        pistolService.Create(new Pistol(name, capacity));
                    }
                    else
                    {
                        goto label5;

                    }
                    goto label4;

                }
                else if (c2 == 2)
                {
                    pistolService.GetAllPistols().ForEach(x => Console.WriteLine(x));
                    goto label4;
                }
                else if (c2 == 3)
                {
                    Console.WriteLine("Enter ID of the Pistol that you want to shoot: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        pistolService.Shoot(id);
                    }
                    catch (WeaponNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto label4;
                }
                else if (c2 == 4)
                {
                    Console.WriteLine("Enter ID of the Pistol that you want to reload: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        pistolService.Reload(id);
                    }
                    catch (WeaponNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto label4;

                }
                else if (c2 == 5)
                {

                    Console.WriteLine("Enter ID of the Pistol that you want to change bullet capacity: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        pistolService.ChangeBulletCapacity(id);
                    }
                    catch (WeaponNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto label4;


                }

                else
                {
                    Console.WriteLine("Invalid choice!");
                    goto label4;
                }

            }
            else
            {
                Console.WriteLine("Invalid choise");
                goto label1;
            }
        }
    }
}
