using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_app.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required]  //checking some data input in the field "Name" below
        public string Name { get; set; }
    }
}
