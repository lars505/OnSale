using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace OnSale.Common.Entities
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo no puede contener mas de 50 caracteres")]
        [Required]
        public string Name { get; set; }

        [JsonIgnore] //
        [NotMapped] // le ponemos esta notacion para que nuestro campo no aparezca en la BD
        public int IdDepartment { get; set; }


    }

}
