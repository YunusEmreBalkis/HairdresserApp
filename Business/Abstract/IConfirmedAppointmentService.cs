using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IConfirmedAppointmentService
    {
        IDataResult<List<ConfirmedAppointment>> GetAllBySalonId(int salonId);
        IDataResult<List<ConfirmedAppointment>> GetAllByUserId(int userId);
        IDataResult<ConfirmedAppointment> GetById(int salonId);
        IResult Add(ConfirmedAppointment confirmedAppointment);
        IResult Update(ConfirmedAppointment confirmedAppointment);
        IResult Delete(ConfirmedAppointment confirmedAppointment);

    }
}
