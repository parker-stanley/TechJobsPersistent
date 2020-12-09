using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public int EmployerId { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public Employer Employer { get; set; }

        public AddJobViewModel(string name, Employer employer)
        {
            Name = name;
            Employer = employer;
        }
    }
}
