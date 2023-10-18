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
    public class ClassesData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable clasesTable = new DataTable();

        public DataTable GetAllClases()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM clases";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            clasesTable.Load(_reader);

            _connection.CloseConnection();

            return clasesTable;
        }

        public void AddClases(Classes clases)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO clases (idinstructor, nombre, espacio_disponible) " +
                               "VALUES (@idinstructor, @nombre, @espacio_disponible)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@idinstructor", clases.idInstructor);
            _cmd.Parameters.AddWithValue("@nombre", clases.nombre);
            _cmd.Parameters.AddWithValue("@espacio_disponible", clases.espacioDisponible);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateClases(Classes clases)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE clases SET idinstructor = @idinstructor, nombre = @nombre, " +
                "espacio_disponible = @espacio_disponible " +
                "WHERE idclases = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@idinstructor", clases.idInstructor);
            _cmd.Parameters.AddWithValue("@nombre", clases.nombre);
            _cmd.Parameters.AddWithValue("@espacio_disponible", clases.espacioDisponible);
            _cmd.Parameters.AddWithValue("@id", clases.idClases);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteClases(Classes clases)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM clases WHERE idclases = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id", clases.idClases);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
