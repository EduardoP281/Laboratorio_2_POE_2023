using System;
using CommonLayer;
using DataLayer;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CRUD
{
    public class AttendanceBusiness
    {
        AttendanceData attendanceData = new AttendanceData();

        public DataTable GetAsistencias()
        {
            DataTable asistenciaTable = new DataTable();

            asistenciaTable = attendanceData.GetAllAsistencias();

            return asistenciaTable;
        }

        public void AddAsistencia(Attendance asistencia)
        {
            attendanceData.AddAsistencia(asistencia);
        }

        public void UpdateAsistencia(Attendance asistencia)
        {
            attendanceData.UpdateAsistencia(asistencia);
        }

        public void DeleteAsistencia(Attendance asistencia)
        {
            attendanceData.DeleteAsistencia(asistencia);
        }
    }
}
