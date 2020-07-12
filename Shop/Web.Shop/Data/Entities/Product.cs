

namespace Web.Shop.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product : IEntity
    {
        public int Id { get; set; }
       
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener como máximo {1} caracteres")]
        [Required]
        public string Name { get; set; }

        public string Apellidos { get; set; }
        
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "Fecha Nascimiento")]
        public DateTime? LastPurchase { get; set; }
        
        [Display(Name = "Fecha de Defunción")]
        public DateTime LastSale { get; set; }
        
        [Display(Name = "Localización")]
        public string IsAvailabe { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }
                return $"https://webshopgil.azurewebsites.net{this.ImageUrl.Substring(1)}";
            }
        }

    }
}
