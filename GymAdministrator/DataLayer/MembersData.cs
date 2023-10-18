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
    public class MembersData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable miembrosTable = new DataTable();

        public DataTable GetAllMiembros()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM miembros";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            miembrosTable.Load(_reader);

            _connection.CloseConnection();

            return miembrosTable;
        }

        public void AddMiembro(Members miembro)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO miembros (idmembresia, idinstalacion, dui, nombre, apellido, telefono, correo, estado) " +
                               "VALUES (@idmembresia, @idinstalacion, @dui, @nombre, @apellido, @telefono, @correo, @estado)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@idmembresia", miembro.idMembresia);
            _cmd.Parameters.AddWithValue("@idinstalacion", miembro.idInstalacion);
            _cmd.Parameters.AddWithValue("@dui", miembro.dui);
            _cmd.Parameters.AddWithValue("@nombre", miembro.nombre);
            _cmd.Parameters.AddWithValue("@apellido", miembro.apellido);
            _cmd.Parameters.AddWithValue("@telefono", miembro.telefono);
            _cmd.Parameters.AddWithValue("@correo", miembro.correo);
            _cmd.Parameters.AddWithValue("@estado", miembro.estado);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateMiembro(Members miembro)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE miembros SET idmembresia = @idmembresia, idinstalacion = @idinstalacion, dui = @dui, " +
                "nombre = @nombre, apellido = @apellido, telefono = @telefono, correo = @correo, estado = @estado " +
                "WHERE idmiembro = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@idmembresia", miembro.idMembresia);
            _cmd.Parameters.AddWithValue("@idinstalacion", miembro.idInstalacion);
            _cmd.Parameters.AddWithValue("@dui", miembro.dui);
            _cmd.Parameters.AddWithValue("@nombre", miembro.nombre);
            _cmd.Parameters.AddWithValue("@apellido", miembro.apellido);
            _cmd.Parameters.AddWithValue("@telefono", miembro.telefono);
            _cmd.Parameters.AddWithValue("@correo", miembro.correo);
            _cmd.Parameters.AddWithValue("@estado", miembro.estado);
            _cmd.Parameters.AddWithValue("@id", miembro.idMiembro);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteMiembro(Members miembro)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM miembros WHERE idmiembro = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id", miembro.idMiembro);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
