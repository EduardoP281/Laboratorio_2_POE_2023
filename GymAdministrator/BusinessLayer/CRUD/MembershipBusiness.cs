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
    public class MembershipBusiness
    {
        MembershipData membershipData = new MembershipData();

        public DataTable GetMembers()
        {
            DataTable membresiaTable = new DataTable();

            membresiaTable = membershipData.GetAllMembresias();

            return membresiaTable;
        }

        public void AddMembers(Membership membresia)
        {
            membershipData.AddMembresia(membresia);
        }

        public void UpdateMiembro(Membership membresia)
        {
            membershipData.UpdateMembresia(membresia);
        }

        public void DeleteMiembro(Membership membresia)
        {
            membershipData.DeleteMembresia(membresia);
        }

    }
}
