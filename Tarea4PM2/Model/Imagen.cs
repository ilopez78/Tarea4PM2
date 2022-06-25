using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Tarea4PM2.Model
{
    public class Imagen
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(250)]
        public string nombre { get; set; }

        [MaxLength(250)]
        public string descripcion { get; set; }

        public Byte[] foto { get; set; }
    }
}
