using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Views
{
    public class Order
    {
        [Key]
        [Display(Name ="Mã đơn")]
        [Required]
        public int OrderId { get; set; }   
        [Display(Name ="Ngày Giao")]
        [Required]
        public DateTime OrderDate { get; set; }
        [Display(Name ="Tên khách")]
        [Required]
        public string Name { get; set; }
        [Display(Name="Địa chỉ")]
        [Required]
        public string DiaChi { get; set; }
        [Display(Name ="Số điện thoại")]
        [Required]
        public string Phone { get; set; }
        public Boolean isConfirm { get; set; }

        public List<Product> Products { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
