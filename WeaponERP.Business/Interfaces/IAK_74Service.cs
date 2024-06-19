using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponERP.Core.Models.Weapons;

namespace WeaponERP.Business.Interfaces
{
    public interface IAK_74Service
    {
        void Create(AK_74 aK_74);
        void Shoot(int id);
        void Fire(int id);
        int GetRemainingBulletCount(int id);
        void Reload(int id);
        void ChangeFireMode(int id);
        List<AK_74> GetAllAK_74s();
        void ChangeBulletCapacity(int id);
    }
}
