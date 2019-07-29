using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreApp.Models
{
    public class Client
    {
        public int ID { get; set; }
        [Display(Name = "Prénom")]
        public string FirstName { get; set; }
        [Display(Name = "Nom")]
        public string LastName { get; set; }

        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
    }
}
