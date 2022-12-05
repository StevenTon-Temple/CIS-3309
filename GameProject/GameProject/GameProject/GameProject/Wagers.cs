using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Wagers
    {
        private int wageramount;
        private string question;
        private int player_id;

        public int WagerAmount
        {
            get { return wageramount; }
            set { wageramount = value; }
        }
        public int Player_ID
        {
            get { return player_id; }
            set { player_id = value; }
        }
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
    }
}
