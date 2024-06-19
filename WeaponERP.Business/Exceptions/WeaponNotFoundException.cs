using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponERP.Business.Exceptions
{
    public class WeaponNotFoundException : Exception
    {
        public WeaponNotFoundException()
        {
        }

        public WeaponNotFoundException(string? message) : base(message)
        {
        }
    }
}
