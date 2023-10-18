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
    public class FacilitiesData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable instalacionesTable = new DataTable();

        public DataTable GetAllInstalaciones()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM instalaciones";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            instalacionesTable.Load(_reader);

            _connection.CloseConnection();

            return instalacionesTable;
        }

        public void AddInstalacion(Facilities instalacion)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO instalaciones (nombre, direccion, capacidad) " +
                               "VALUES (@nombre, @direccion, @capacidad)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@nombre", instalacion.nombre);
            _cmd.Parameters.AddWithValue("@direccion", instalacion.direccion);
            _cmd.Parameters.AddWithValue("@capacidad", instalacion.capacidad);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateInstalacion(Facilities instalacion)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE instalaciones SET nombre = @nombre, direccion = @direccion, " +
                "capacidad = @capacidad " +
                "WHERE idinstalacion = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@nombre", instalacion.nombre);
            _cmd.Parameters.AddWithValue("@direccion", instalacion.direccion);
            _cmd.Parameters.AddWithValue("@capacidad", instalacion.capacidad);
            _cmd.Parameters.AddWithValue("@id", instalacion.idInstalacion);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteInstalacion(Facilities instalacion)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM instalaciones WHERE idinstalacion = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id", instalacion.idInstalacion);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
