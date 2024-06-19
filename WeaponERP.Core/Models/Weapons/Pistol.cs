using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponERP.Core.Models.Weapons
{
    public  class Pistol : WeaponBase
    {
        private static int _id;
        public Pistol(string name, int bulletcapacity) {
            ++_id;
            ID = _id;
            Name=name;
            BulletCapacity = bulletcapacity;
            RemainingBullet = BulletCapacity;// when the weapon first created it is full.
        }
        public override string ToString()
        {
            return $"Num:{ID}-Pistol Name:{Name}- Bullet Capacity:{BulletCapacity}- Remaining Bullet:{RemainingBullet} ";
        }

    }
}
