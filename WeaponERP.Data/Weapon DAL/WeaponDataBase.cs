using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponERP.Core.Models.Weapons;

namespace WeaponERP.Data.Weapon_DAL
{
    public class WeaponDataBase<T>
    {
        public static List<T> Weapons=new List<T> ();
    }
}
