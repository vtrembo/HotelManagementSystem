using HotelManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services.DamageReportCreator
{
    public interface IDamageReportCreator
    {
        Task CreateDamageReport (DamageReport damageReport);
    }
}
