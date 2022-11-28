using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    class Questions
    {
        private string answer;
        private int dollarvalue;
        private string questions;
        private int diffcultyid;
        private string category;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public int DollarValue
        {
            get { return dollarvalue; }
            set { dollarvalue = value; }
        }
        public string Question
        {
            get { return questions; }
            set { questions = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int Diffuculty
        {
            get { return diffcultyid; }
            set { diffcultyid = value; }
        }
        public void showAnswers()
        {
            MessageBox.Show("The correct answer is..." + "\n" + answer);
        }
    }
}
