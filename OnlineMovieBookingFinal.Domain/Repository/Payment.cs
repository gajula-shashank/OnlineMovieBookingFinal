using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Domain.Repository.Entities
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }
        [DisplayName("Discout Coupon Id")]

        public ICollection<Seat> Seats { get; set; }

    }
}