using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponERP.Core.Models.Weapons
{
    public class AK_74 : WeaponBase
    {
        private static int _id;
        
        public WeaponMode Mode { get; set; }
        public int RemainingBulletCapacity { get; }

        public AK_74(string name, int bulletcapacity)
        {
            ++_id;
            ID = _id;
            Name = name;
            BulletCapacity = bulletcapacity;
            RemainingBullet = BulletCapacity;
            Mode = WeaponMode.OneByOne;
        }

        public override string ToString()
        {
            return $"Num:{ID} AK_74 Name:{Name}- Bullet Capacity:{BulletCapacity}- Remaining Bullet:{RemainingBullet}- Mode:{Mode} ";
        }
    }
}
