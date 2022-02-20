using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfConfirmedAppointmentDal : EfEntityRepositoryBase<ConfirmedAppointment,HDContext>, IConfirmedAppointmentDal
    {

    }
}
