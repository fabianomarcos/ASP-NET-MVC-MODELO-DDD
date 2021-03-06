﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC
{
    public class EditUserViewModel
    {

        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        public IEnumerable<ClienteViewModel> Cliente { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}