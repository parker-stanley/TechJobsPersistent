﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;


namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public List<Skill> Skills { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        public Employer Employer { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();

            foreach (Employer employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

            Skills = skills;
        }

        public AddJobViewModel() { }

    }
}
