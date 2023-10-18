using CommonLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CRUD
{
    public class IntructorBusiness
    {
        InstructorData instructorData = new InstructorData();

        public DataTable GetIntructores() 
        {
            DataTable instructoresTable = new DataTable();

            instructoresTable = instructorData.GetAllInstructores();

            return instructoresTable;
        }

        public void AddInstructor(Instructor instructor)
        {
            instructorData.AddInstructor(instructor);
        }

        public void UpdateInstructor(Instructor instructor)
        {
            instructorData.UpdateInstructor(instructor);
        }

        public void DeleteInstructor(Instructor instructor)
        {
            instructorData.DeleteInstructor(instructor);
        }

    }
}
