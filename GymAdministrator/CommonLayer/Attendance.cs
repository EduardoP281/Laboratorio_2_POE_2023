using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class Attendance
    {
        public int idAsistencia { get; set; }
        public int idClases { get; set; }
        public int idMiembro { get; set; }
        public DateTime fechaAsistencia { get; set; }
        public string estado { get; set; }
    }
}
