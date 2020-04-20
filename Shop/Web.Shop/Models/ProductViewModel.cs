﻿namespace Web.Shop.Models
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;
    using Web.Shop.Data.Entities;


    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
