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
    public class EquipmentData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable instalacionesEquipoTable = new DataTable();

        public DataTable GetAllInstalacionesEquipos()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM instalaciones_equipo";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            instalacionesEquipoTable.Load(_reader);

            _connection.CloseConnection();

            return instalacionesEquipoTable;
        }

        public void AddInstalacionesEquipo(Equipment instalacionesEquipo)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO instalaciones_equipo (id_instalacion, id_equipo) " +
                               "VALUES (@id_instalacion, @id_equipo)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id_instalacion", instalacionesEquipo.idInstalacion);
            _cmd.Parameters.AddWithValue("@id_equipo", instalacionesEquipo.idEquipo);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateInstalacionesEquipo(Equipment instalacionesEquipo)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE instalaciones_equipo SET id_instalacion = @id_instalacion, id_equipo = @id_equipo " +
                "WHERE id_instalacion = @idInstalacion AND id_equipo = @idEquipo";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id_instalacion", instalacionesEquipo.idInstalacion);
            _cmd.Parameters.AddWithValue("@id_equipo", instalacionesEquipo.idEquipo);
            _cmd.Parameters.AddWithValue("@idInstalacion", instalacionesEquipo.idInstalacionOriginal);
            _cmd.Parameters.AddWithValue("@idEquipo", instalacionesEquipo.idEquipoOriginal);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteInstalacionesEquipo(Equipment instalacionesEquipo)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM instalaciones_equipo WHERE id_instalacion = @idInstalacion AND id_equipo = @idEquipo";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@idInstalacion", instalacionesEquipo.idInstalacion);
            _cmd.Parameters.AddWithValue("@idEquipo", instalacionesEquipo.idEquipo);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
