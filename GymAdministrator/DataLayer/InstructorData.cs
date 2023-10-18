using CommonLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class InstructorData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable instructorTable = new DataTable();

        public DataTable GetAllInstructores()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM instructor";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            instructorTable.Load(_reader);

            _connection.CloseConnection();

            return instructorTable;
        }

        public void AddInstructor(Instructor instructor)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO instructor (nombre, apellido, telefono, correo, sueldo, estado) " +
                               "VALUES (@nombre, @apellido, @telefono, @correo, @sueldo, @estado)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@nombre", instructor.nombre);
            _cmd.Parameters.AddWithValue("@apellido", instructor.apellido);
            _cmd.Parameters.AddWithValue("@telefono", instructor.telefono);
            _cmd.Parameters.AddWithValue("@correo", instructor.correo);
            _cmd.Parameters.AddWithValue("@sueldo", instructor.sueldo);
            _cmd.Parameters.AddWithValue("@estado", instructor.estado);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE instructor SET nombre = @nombre, apellido = @apellido, " +
                "telefono = @telefono, correo = @correo, sueldo = @sueldo, estado = @estado " +
                "WHERE idinstructor = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@nombre", instructor.nombre);
            _cmd.Parameters.AddWithValue("@apellido", instructor.apellido);
            _cmd.Parameters.AddWithValue("@telefono", instructor.telefono);
            _cmd.Parameters.AddWithValue("@correo", instructor.correo);
            _cmd.Parameters.AddWithValue("@sueldo", instructor.sueldo);
            _cmd.Parameters.AddWithValue("@estado", instructor.estado);
            _cmd.Parameters.AddWithValue("@id", instructor.idInstructor);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteInstructor(Instructor instructor)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM instructor WHERE idinstructor = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id", instructor.idInstructor);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
