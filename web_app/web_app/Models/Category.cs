using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_app.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]  //checking some data input in the field "Name" below
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]  //checking data input
        //error message if input isn't greater than 0
        [Range(1,int.MaxValue,ErrorMessage ="Display order for category must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
