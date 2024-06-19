using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponERP.Core.Models
{
    public abstract class WeaponBase
    {    public string Name { get; set; }
        public int BulletCapacity { get; set; }
        public int  RemainingBullet { get; set; }
        public int ID { get; set; }


    }
}
