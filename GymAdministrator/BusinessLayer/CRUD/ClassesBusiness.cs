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
    public class ClassesBusiness
    {
        ClassesData classesData = new ClassesData();

        public DataTable GetClasses()
        {
            DataTable clasesTable = new DataTable();

            clasesTable = classesData.GetAllClases();

            return clasesTable;
        }

        public void AddClases(Classes clases)
        {
            classesData.AddClases(clases);
        }

        public void UpdateClases(Classes clases)
        {
            classesData.UpdateClases(clases);
        }

        public void DeleteClases(Classes clases)
        {
            classesData.DeleteClases(clases);
        }
    }
}
