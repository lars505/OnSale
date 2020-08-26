using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        //pasamos una coleccion de las ciudades, ya que cada departamento tiene muchas ciudades
        public ICollection<City> Cities { get; set; }

        //Recorremos las ciudades si la cantidad es Nula devolvemos 0 y si no devolvemos la cantidad de ciudades registradas
        [DisplayName("Cities Number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        [JsonIgnore] //
        [NotMapped] // le ponemos esta notacion para que nuestro campo no aparezca en la BD
        public int IdCountry { get; set; }

        



    }
}
