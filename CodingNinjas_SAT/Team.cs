using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingNinjas_SAT
{
    class Team
    {
        List<CodingNinja> teamList = new List<CodingNinja>();

        public Team()
        {

        }
        public Team( string[] names)
        {
            foreach(string n in names)
            {
                CodingNinja cn = new CodingNinja(n);
                teamList.Add(cn);
            }
        }
        public bool checkMaxTeamRank()
        {
            foreach(CodingNinja cn in this.teamList)
            {
                if (cn.gotToMaxRank())
                    return true;
            }
            return false;
        }
        public void printTeamStatus()
        {
            foreach(CodingNinja cn in teamList)
            {
                cn.print();
            }
        }
        private void completeProject(List<CodingNinja> cn)
        {
            for(int i = 1; i < cn.Count; i++)
            {
                cn[i].helpedPeer();
            }
            cn[0].programCorrect();
        }
        public void completeProjectByID(int[] ids)
        {
            List<CodingNinja> ourList = new List<CodingNinja>();

            foreach( int i in ids)
            {
                ourList.Add(this.teamList[i]);
            }
            this.completeProject(ourList);
        }
    }
}
