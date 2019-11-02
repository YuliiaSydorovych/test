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
using System.Configuration;

namespace WindowsFormsApplication26
{
    public partial class Form1 : Form
    {
        TestDb db;
         
        public Form1()
        {
           
            InitializeComponent();
            db = new TestDb();
            Admin defoltAdmin = new Admin();     //Створюю 
            defoltAdmin.Login = "Admin";        //дефолтного 
            defoltAdmin.Password = "Admin";    //юзера (Адміна)
            if (db.Admins.Any(Admin => Admin.Login == "Admin"))//Перевірка на унікальність логіна Admin
            {

            }
            else
            {
                db.Admins.Add(defoltAdmin);//Якщо нема то добавляю в БД
                db.SaveChanges();
            }
            //db.Questions.Load();
            //dataGridView1.DataSource = db.Questions.Local.ToBindingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test test = new Test();

            test.NameTest = "Volodia";

            db.Tests.Add(test);

            db.SaveChanges();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void створитиТестToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var order = db.Admins.Where(Admin => Admin.Login == textBox1.Text && Admin.Password==textBox2.Text).FirstOrDefault();//Перевірка чи є такий логін та пароль в базі данних
            if (order!=null)
            {
                MessageBox.Show("Entering..");//Вірний логін та пароль
            }
            else
            {
                MessageBox.Show("Wrong Login or Password");//Не вірний
            }
        }

        private void створитиТестToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Test test = new Test();
            //Question question = new Question();
            //Answer answer = new Answer();

            //TeacherPageCreateTest create = new TeacherPageCreateTest();

            //DialogResult result = create.ShowDialog(this);

            //if (result == DialogResult.Cancel)
            //    return;

            //AddNewQuestion add = new AddNewQuestion();

            //int index = create.dataGridView1.SelectedRows[0].Index;

            //int id = 0;

            //bool converted = Int32.TryParse(create.dataGridView1[0, index].Value.ToString(), out id);

            //if (converted == false)
            //    return;

            //test.NameTest = add.textBox1.Text;
            //test.ID = index;

            //question.NameQuestion = add.textBox2.Text;
            //question.IDTest = test.ID;

            //answer.IDQuestion = 




            //question.IDTest = index;
            //question.NameQuestion = add.textBox4.Text;
            
            //db.SaveChanges();

            MessageBox.Show("It's ok");
        }
    }
}
