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
    public class FacilitiesBusiness
    {
        FacilitiesData facilitiesData = new FacilitiesData();

        public DataTable GetInstalaciones()
        {
            DataTable instalacionesTable = new DataTable();

            instalacionesTable = facilitiesData.GetAllInstalaciones();

            return instalacionesTable;
        }

        public void AddInstalacion(Facilities instalacion)
        {
            facilitiesData.AddInstalacion(instalacion);
        }

        public void UpdateInstalacion(Facilities instalacion)
        {
            facilitiesData.UpdateInstalacion(instalacion);
        }

        public void DeleteInstalacion(Facilities instalacion)
        {
            facilitiesData.DeleteInstalacion(instalacion);
        }
    }
}
