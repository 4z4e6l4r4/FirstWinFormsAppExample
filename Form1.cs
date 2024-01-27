using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsAppExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wellcome to Abyss..");
            label1.Text = "Your Future is Coming...";
            label1.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textValue = UserNameTxt.Text;
            MessageBox.Show(textValue);
            UserNameTxt.Clear();
            //butona tıkladıktan sonra yeniden text boxa bir şey yazmak için focus kullan.
            UserNameTxt.Focus();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //ekran her açıldığında focusu çalıştırmak için
            UserNameTxt.Focus();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = "Human";
            string password = "1453";

            if(username == UserNameTxt.Text && password == PasswordTxt.Text)
            {
                MessageBox.Show("Hi, innocent " + username,
                    "you signed ur death",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                createElement();
            }
            else
            {
                MessageBox.Show("Dont try to escape",
                        "Try again",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);
            }
        }


        public void createElement()
        {
            Label label = new Label();
            Button button = new Button();

            label.Name = "NewLabel";
            label.Text = "Game Starting...";
            label.ForeColor = Color.Red;
            label.Location = new Point(86, 200);

            this.Controls.Add(label);

            newButton = new Button();
            newButton.Name = "NewButton";
            newButton.Text =   "Open";
            newButton.Location = new Point(100, 200);
            newButton.Click += NewButton_Click;

            this.Controls.Add(newButton);


            UserNameTxt.Visible = false;
            PasswordTxt.Visible = false;
            login.Visible = false;
            button1.Visible = false;
            button2.Visible = false;


        }



    }
}
