

using System.ComponentModel.DataAnnotations;

namespace Backend_wt15.Models
{
    public class Product
    {
        /// <summary>
        /// Klucz główny w EF
        /// </summary>
        /// I sposób: Id
        public int Id { get; set; }

        /// II sposób: [nazwaKlasy]Id // ProductId
        /// III sposób: własna nazwa + atrybut [Key]
        ///  <summary>
        /// II sposób: [nazwaKlasy]Id // ProductId
        /// </summary>
        //[Key]
        //public int IdProd { get; set; }

        [Required]
        public string Name { get; set; }

        public float? Price { get; set; }
    }
}
