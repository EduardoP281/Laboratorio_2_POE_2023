using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;

namespace DataLayer
{
    public class AttendanceData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable asistenciaTable = new DataTable();

        public DataTable GetAllAsistencias()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM asistencia";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            asistenciaTable.Load(_reader);

            _connection.CloseConnection();

            return asistenciaTable;
        }

        public void AddAsistencia(Attendance asistencia)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO asistencia (idclases, idmiembro, fecha_asistencia, estado) " +
                               "VALUES (@idclases, @idmiembro, @fecha_asistencia, @estado)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@idclases", asistencia.idClases);
            _cmd.Parameters.AddWithValue("@idmiembro", asistencia.idMiembro);
            _cmd.Parameters.AddWithValue("@fecha_asistencia", asistencia.fechaAsistencia);
            _cmd.Parameters.AddWithValue("@estado", asistencia.estado);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateAsistencia(Attendance asistencia)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE asistencia SET idclases = @idclases, idmiembro = @idmiembro, " +
                "fecha_asistencia = @fecha_asistencia, estado = @estado " +
                "WHERE idasistencia = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@idclases", asistencia.idClases);
            _cmd.Parameters.AddWithValue("@idmiembro", asistencia.idMiembro);
            _cmd.Parameters.AddWithValue("@fecha_asistencia", asistencia.fechaAsistencia);
            _cmd.Parameters.AddWithValue("@estado", asistencia.estado);
            _cmd.Parameters.AddWithValue("@id", asistencia.idAsistencia);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteAsistencia(Attendance asistencia)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM asistencia WHERE idasistencia = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id", asistencia.idAsistencia);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
