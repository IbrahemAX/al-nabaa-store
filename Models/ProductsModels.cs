using System.ComponentModel.DataAnnotations;

namespace al_nabaa_store.Models
{
    public class ProductsModels
    {
        [key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string GraphicCard { get; set; }

        [Required]
        public string RAM { get; set; }

        [Required]
        public string Cpu { get; set; }

        [Required]
        public string Hard { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public decimal Price { get; set; }



    }
}
