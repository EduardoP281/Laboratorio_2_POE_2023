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
    public class EquipmentBusiness
    {
        EquipmentData equipmentData = new EquipmentData();

        public DataTable GetEquipos()
        {
            DataTable equiposTable = new DataTable();

            equiposTable = equipmentData.GetAllInstalacionesEquipos();

            return equiposTable;
        }

        public void AddInstalacionesEquipo(Equipment instalacionesEquipo)
        {
            equipmentData.AddInstalacionesEquipo(instalacionesEquipo);
        }

        public void UpdateInstalacionesEquipo(Equipment instalacionesEquipo)
        {
            equipmentData.UpdateInstalacionesEquipo(instalacionesEquipo);
        }

        public void DeleteInstalacionesEquipo(Equipment instalacionesEquipo)
        {
            equipmentData.DeleteInstalacionesEquipo(instalacionesEquipo);
        }

    }
}
