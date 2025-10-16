using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsAppCalculator
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string Input_Username = textBox1.Text;
            string Input_Password = textBox2.Text;
            string pathforaccaunt = @"C:\Users\Jiro\Desktop\AccauntData.txt";
            string pathforperson = @"C:\Users\Jiro\Desktop\PersonData.txt";


            bool found = false;
            Accaunt foundAccaunt = null;

            string[] lines = File.ReadAllLines(pathforaccaunt);
            var selectline = (from line in lines
                              let desaccaunt = JsonConvert.DeserializeObject<Accaunt>(line)
                              where (desaccaunt != null && desaccaunt.Login == Input_Username && desaccaunt.Password == Input_Password)
                              select desaccaunt).FirstOrDefault();
            if (selectline != null)
            {
                found = true;
                foundAccaunt = selectline;
                Form1 form1 = new Form1();
                form1.Show();
            };
   
        }

 
        public class Accaunt
        {
            public string Login { get; set; }
            public string Password { get; set; }

            public Guid Id { get; set; }
            public Accaunt(string login, string password, Guid id)
            {
                this.Login = login;
                this.Password = password;
                this.Id = id;

            }

        }
    }

}
