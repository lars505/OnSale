using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo no puede contener mas de 50 caracteres")]
        [Required]
        public string Name { get; set; }
    }


}
