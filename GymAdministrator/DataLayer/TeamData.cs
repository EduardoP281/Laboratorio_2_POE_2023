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
    public class TeamData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable equipoTable = new DataTable();

        public DataTable GetAllEquipos()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM equipo";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            equipoTable.Load(_reader);

            _connection.CloseConnection();

            return equipoTable;
        }

        public void AddEquipo(Team equipo)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO equipo (nombre, cantidad) " +
                               "VALUES (@nombre, @cantidad)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@nombre", equipo.nombre);
            _cmd.Parameters.AddWithValue("@cantidad", equipo.cantidad);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateEquipo(Team equipo)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE equipo SET nombre = @nombre, cantidad = @cantidad " +
                "WHERE idequipo = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@nombre", equipo.nombre);
            _cmd.Parameters.AddWithValue("@cantidad", equipo.cantidad);
            _cmd.Parameters.AddWithValue("@id", equipo.idEquipo);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteEquipo(Team equipo)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM equipo WHERE idequipo = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id", equipo.idEquipo);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}

