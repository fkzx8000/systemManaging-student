using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDD_work.Logic;



namespace TDD_work
{
    public partial class UserInfo : Form
    {
        public float RunTime;
        public bool Showflag;

        public UserInfo(bool flag)
        {
            InitializeComponent();
            Showflag = flag;
            if (!Showflag)
            {
                UserData[] arr = Sort.convertToArr(ControlCSV.getUser());
                RunTime = DateTime.Now.Millisecond;
                arr = Sort.quickSort(arr, 0, arr.Length - 1);
                RunTime= (DateTime.Now.Millisecond - RunTime)/1000;
                if (RunTime < 0) { RunTime *= -1; }

                DialogResult RunTimelog = new DialogResult();
 
                foreach (var element in arr)
                {
                    this.dataGridView1.Rows.Add(element.FirstName, element.LastName, element.ID, element.PhoneNumber, element.Email, element.AverageGrade);
                }
                Showflag = true;
                RunTimelog = MessageBox.Show(RunTime + " :הזמן שלוקח המיון בשניות", "quickSort", MessageBoxButtons.OK);
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home from2 = new Home(Showflag,this);
            from2.ShowDialog();
        }

        public void button1_Click(object value1, object value2)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
