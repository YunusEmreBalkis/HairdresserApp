using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ConfirmedAppointmentManager : IConfirmedAppointmentService
    {
        IConfirmedAppointmentDal _confirmedAppointmentDal;
        public ConfirmedAppointmentManager(IConfirmedAppointmentDal confirmedAppointmentDal)
        {
            _confirmedAppointmentDal = confirmedAppointmentDal;
        }

        [SecuredOperation("customer")]
        public IResult Add(ConfirmedAppointment confirmedAppointment)
        {
            _confirmedAppointmentDal.Add(confirmedAppointment);
            return new SuccessResult(Messages.AppointmentAdded);
        }

        public IResult Delete(ConfirmedAppointment confirmedAppointment)
        {
            _confirmedAppointmentDal.Delete(confirmedAppointment);
            return new SuccessResult(Messages.AppointmentDeleted);
        }

        public IDataResult<List<ConfirmedAppointment>> GetAllBySalonId(int salonId)
        {

            return new SuccessDataResult<List<ConfirmedAppointment>>(_confirmedAppointmentDal.GetAll(co => co.SalonId == salonId));
        }

        public IDataResult<List<ConfirmedAppointment>> GetAllByUserId(int userId)
        {

            return new SuccessDataResult<List<ConfirmedAppointment>>(_confirmedAppointmentDal.GetAll(co => co.CustomerId == userId));
        }

        public IDataResult<ConfirmedAppointment> GetById(int Id)
        {
            return new SuccessDataResult<ConfirmedAppointment>(_confirmedAppointmentDal.Get(co => co.AppointmentId == Id));
        }

        public IResult Update(ConfirmedAppointment confirmedAppointment)
        {
            _confirmedAppointmentDal.Update(confirmedAppointment);
            return new SuccessResult(Messages.AppointmentUpdated);
        }
    }
}
