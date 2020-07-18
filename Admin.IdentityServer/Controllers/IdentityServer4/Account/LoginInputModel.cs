// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.ComponentModel.DataAnnotations;

namespace Admin.IdentityServer
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "�������˺�")]
        [Display(Name = "�û�����")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "����������")]
        [Display(Name = "��¼���룺")]
        public string Password { get; set; }
        [Display(Name = "��ס��")]
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}