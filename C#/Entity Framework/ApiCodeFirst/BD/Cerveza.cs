using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Cerveza
    {
        [ForeignKey("BrandId")]
        public int BrandId { get; set; }
        public string Name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CervezaId { get; set; }

        public virtual Brand brand { get; set; }

    }
}
