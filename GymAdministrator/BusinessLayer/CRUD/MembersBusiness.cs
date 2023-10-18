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
    public class MembersBusiness
    {
        MembersData membersData = new MembersData();

        public DataTable GetMembers()
        {
            DataTable miembrosTable = new DataTable();

            miembrosTable = membersData.GetAllMiembros();

            return miembrosTable;
        }

        public void AddMembers(Members miembro)
        {
            membersData.AddMiembro(miembro);
        }

        public void UpdateMiembro(Members miembro)
        {
            membersData.UpdateMiembro(miembro);
        }

        public void DeleteMiembro(Members miembro)
        {
            membersData.DeleteMiembro(miembro);
        }

    }
}
