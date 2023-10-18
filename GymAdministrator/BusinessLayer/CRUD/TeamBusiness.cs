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
    public class TeamBusiness
    {
        TeamData teamData = new TeamData();

        public DataTable GetTeams()
        {
            DataTable teamsTable = new DataTable();

            teamsTable = teamData.GetAllEquipos();

            return teamsTable;
        }

        public void AddEquipo(Team equipo)
        {
            teamData.AddEquipo(equipo);
        }

        public void UpdateEquipo(Team equipo)
        {
            teamData.UpdateEquipo(equipo);
        }

        public void DeleteEquipo(Team equipo)
        {
            teamData.DeleteEquipo(equipo);
        }

    }
}
