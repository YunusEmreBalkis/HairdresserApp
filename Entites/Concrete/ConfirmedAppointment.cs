using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Entites.Concrete
{
    public class ConfirmedAppointment : IEntity
    {
        [Key]
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int SalonId { get; set; }
        public string SalonName { get; set; }
        public string CustomerFullName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentDetail { get; set; }


    }
}
