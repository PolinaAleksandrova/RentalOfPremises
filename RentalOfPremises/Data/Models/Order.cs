using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage ="Длина имени не менее 5 символов")]
        public string FirstName { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string LastName { get; set; }
        [Display(Name = "Почта")]
        [DataType(DataType.EmailAddress)]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина почты не менее 15 символов")]
        public string Email { get; set; }
        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина телефона не менее 10 символов")]
        public string Phone { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
