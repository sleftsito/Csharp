using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;
using static LinqToDB.Common.Configuration;

namespace capaData
{
    public class Coneccion : DataConnection
    {
        public Coneccion() : base("SqlServer") { }

        public ITable<Estudiante> SqlEstudiantes
        {
            get { return this.GetTable<Estudiante>(); }
        }
    }
}
