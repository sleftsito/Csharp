using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace capaData 
{
    public class Estudiante
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }
        public string NID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
    }
}
