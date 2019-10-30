using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication26
{
    public partial class Form1 : Form
    {
        TestDb db;
        public Form1()
        {
           
            InitializeComponent();
            db = new TestDb();
            //db.Questions.Load();
            //dataGridView1.DataSource = db.Questions.Local.ToBindingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test test = new Test();

            test.NameTest = "Yuliia";

            db.Tests.Add(test);

            db.SaveChanges();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
