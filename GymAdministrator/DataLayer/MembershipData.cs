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
    public class MembershipData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable membresiaTable = new DataTable();

        public DataTable GetAllMembresias()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM membresia";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            membresiaTable.Load(_reader);

            _connection.CloseConnection();

            return membresiaTable;
        }

        public void AddMembresia(Membership membresia)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO membresia (tipo, precio) " +
                               "VALUES (@tipo, @precio)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@tipo", membresia.tipo);
            _cmd.Parameters.AddWithValue("@precio", membresia.precio);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateMembresia(Membership membresia)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE membresia SET tipo = @tipo, precio = @precio " +
                "WHERE idmembresia = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@tipo", membresia.tipo);
            _cmd.Parameters.AddWithValue("@precio", membresia.precio);
            _cmd.Parameters.AddWithValue("@id", membresia.idMembresia);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteMembresia(Membership membresia)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM membresia WHERE idmembresia = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id", membresia.idMembresia);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
