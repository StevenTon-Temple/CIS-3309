using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class PlayerAnswers
    {
        private int player_id;
        private string player_answer;
        private string answer;

        public int Player_Id
        {
            get { return player_id; }
            set { player_id = value; }
        }
        public string Player_Answer
        {
            get { return player_answer; }
            set { player_answer = value; }
        }
        public string Real_Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        private void GetPlayerAnswers()
        {

        }

    }
}
