using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WeaponERP.Business.Exceptions;
using WeaponERP.Business.Interfaces;
using WeaponERP.Core.Models.Weapons;
using WeaponERP.Data.Weapon_DAL;

namespace WeaponERP.Business.Implementations
{
    public class PistolService : IPistolService
    {
        public void ChangeBulletCapacity(int id)
        {
            Console.WriteLine("Enter new capacity!");
            int newCap = Convert.ToInt32(Console.ReadLine());
            Pistol? searched = WeaponDataBase<Pistol>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                if (newCap > searched.BulletCapacity)
                {
                    searched.BulletCapacity = newCap;
                    Console.WriteLine($"The Bullet Capacity of pistol has changed to {searched.BulletCapacity}");
                }
                else
                {
                    Console.WriteLine("Bullet capacity can not be changed to less than previous one!");
                }
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");

        }

        public void Create(Pistol pistol)
        {
            if(pistol != null)
            {
                WeaponDataBase<Pistol>.Weapons.Add(pistol);
                Console.WriteLine("New pistol added");
            }
        }

        public List<Pistol> GetAllPistols()
        {
            return WeaponDataBase<Pistol>.Weapons;
        }

        public int GetRemainingBulletCount(int id)
        {
           Pistol? searched= WeaponDataBase<Pistol>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                return searched.RemainingBullet;
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");
        }

        public void Reload(int id)
        {
            Pistol? searched = WeaponDataBase<Pistol>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                searched.RemainingBullet = searched.BulletCapacity;
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");

        }

        public void Shoot(int id)
        {

            Pistol? searched = WeaponDataBase<Pistol>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                if(searched.RemainingBullet > 0)
                {
                    searched.RemainingBullet -= 1;
                    SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Desktop\\PB201-hws\\WaeponERP\\WeaponERP.Business\\bin\\Debug\\net8.0\\shoot.wav");
                    if (File.Exists("C:\\Users\\user\\Desktop\\PB201-hws\\WaeponERP\\WeaponERP.Business\\bin\\Debug\\net8.0\\shoot.wav"))
                        sound.PlaySync();
                    Console.WriteLine("Shoot!");

                }
                   
                else
                    Console.WriteLine("There is not any bullet to shoot!");
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");

        }
    }
}
