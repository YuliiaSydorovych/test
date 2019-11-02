using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApplication26
{
    public class Test
    {
        public int ID { get; set; }
        public string NameTest { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public Test()
        {
            Questions = new List<Question>();
            Answers = new List<Answer>();
        }


    }

    public class Question
    {
        public int ID { get; set; }
        public string NameQuestion { get; set; }
        public int IDTest { get; set; }
    }

    public class Answer
    {
        public int ID { get; set; }
        public string NameAnswer { get; set; }
        public int IDQuestion { get; set; }
        public bool TrueAnswer { get; set; }
    }

    public class Admin
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
    public class TestDb : DbContext
    {
        public TestDb() : base("TestDb")//Юля Для тебе TestDb // TestDb2 це для мене.
        { }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Test> Tests { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
