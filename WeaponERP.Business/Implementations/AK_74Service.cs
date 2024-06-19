using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WeaponERP.Business.Exceptions;
using WeaponERP.Business.Interfaces;
using WeaponERP.Core.Models.Weapons;
using WeaponERP.Data.Weapon_DAL;

namespace WeaponERP.Business.Implementations
{
    public class AK_74Service : IAK_74Service
    {
        public void ChangeBulletCapacity(int id)
        {
            Console.WriteLine("Enter new capacity!");
            int newCap = Convert.ToInt32(Console.ReadLine());
            AK_74? searched = WeaponDataBase<AK_74>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                if (newCap > searched.BulletCapacity)
                {
                    searched.BulletCapacity = newCap;
                    Console.WriteLine($"The Bullet Capacity of AK-74 has changed to {searched.BulletCapacity}");
                }
                else
                {
                    Console.WriteLine("Bullet capacity can not be changed to less than previous one!");
                }
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");

        }
        public void ChangeFireMode(int id)
        {
            AK_74? searched = WeaponDataBase<AK_74>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                if (searched.Mode == WeaponMode.OneByOne)
                {
                    searched.Mode = WeaponMode.Automatic;
                    Console.WriteLine("Weapon mode changed to Automatic!");

                }
                   
                else
                {
                    searched.Mode = WeaponMode.OneByOne;
                    Console.WriteLine("Weapon mode changed to OneByOne!");

                }
                   

            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");
        }

        public void Create(AK_74 aK_74)
        {
            if (aK_74 != null)
            {
                WeaponDataBase<AK_74>.Weapons.Add(aK_74);
                Console.WriteLine("New AK-74 added");
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");

        }

        public void Fire(int id)
        {
            AK_74? searched = WeaponDataBase<AK_74>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                if (searched.RemainingBullet > 0)
                {
                    if (searched.Mode == WeaponMode.Automatic)
                    {
                        searched.RemainingBullet = 0;
                       
                        SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Desktop\\PB201-hws\\WaeponERP\\WeaponERP.Business\\bin\\Debug\\net8.0\\gunfire.wav");
                        if(File.Exists("C:\\Users\\user\\Desktop\\PB201-hws\\WaeponERP\\WeaponERP.Business\\bin\\Debug\\net8.0\\gunfire.wav"))
                        sound.PlaySync();
                        Console.WriteLine("Fireeeeee!!!");

                    }
                       
                    else
                        Console.WriteLine("Change the mode to automatic to fire!");
                }
                else
                {
                    Console.WriteLine("There is not any bullet to fire!");
                }
                
               
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");
        }

        public List<AK_74> GetAllAK_74s()
        {
            return WeaponDataBase<AK_74>.Weapons;
        }

        public int GetRemainingBulletCount(int id)
        {
            AK_74? searched = WeaponDataBase<AK_74>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                return searched.RemainingBullet;
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");

        }

        public void Reload(int id)
        {
            AK_74? searched = WeaponDataBase<AK_74>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                searched.RemainingBullet = searched.BulletCapacity;
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");
        }

        public void Shoot(int id)
        {
            AK_74? searched = WeaponDataBase<AK_74>.Weapons.Find(x => x.ID == id);
            if (searched != null)
            {
                if (searched.RemainingBullet > 0)
                {
                    searched.RemainingBullet -= 1;
                    SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Desktop\\PB201-hws\\WaeponERP\\WeaponERP.Business\\bin\\Debug\\net8.0\\shoot.wav");
                    if (File.Exists("C:\\Users\\user\\Desktop\\PB201-hws\\WaeponERP\\WeaponERP.Business\\bin\\Debug\\net8.0\\shoot.wav"))
                        sound.PlaySync();

                    Console.WriteLine("Shooooott!");
                }
                   
                else
                    Console.WriteLine("There is not any bullet to shoot!");
            }
            else
                throw new WeaponNotFoundException("Weapon could not be found!");

        }
    }
}
