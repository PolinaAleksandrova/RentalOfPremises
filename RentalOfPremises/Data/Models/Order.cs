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
        [Display(Name = "Введіть ім'я:")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина імені не менше ніж 5 символів")]
        public string FirstName { get; set; }
        [Display(Name = "Введіть прізвище:")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина прізвища не менше ніж 5 символів")]
        public string LastName { get; set; }
        [Display(Name = "Введіть адресу електронної пошти:")]
        [DataType(DataType.EmailAddress)]
        [StringLength(35)]
        [Required(ErrorMessage = "Довжина адреси не менше ніж 15 символів")]
        public string Email { get; set; }
        [Display(Name = "Введіть номер мобільного телефону:")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина номеру не менше ніж 10 цифр")]
        public string Phone { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
