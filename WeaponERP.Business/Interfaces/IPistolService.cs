using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponERP.Core.Models.Weapons;

namespace WeaponERP.Business.Interfaces
{
    public interface IPistolService
    {
        void Create(Pistol pistol);
        void Shoot(int id);
        int GetRemainingBulletCount(int id);
        void Reload(int id);
        List<Pistol> GetAllPistols();
        void ChangeBulletCapacity(int id);
    }
}
