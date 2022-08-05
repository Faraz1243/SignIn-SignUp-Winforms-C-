using MaterialSkin;
using MaterialSkin.Controls;
using SignInSignUp;

namespace SignInSignUp
{
    public partial class Form1 : Form
    {
        private Color themeColor = Color.FromArgb(255, 102, 90, 192);
        public Form1()
        {
            this.
            InitializeComponent();
            this.panel2.Visible = true;
            this.panel7.Visible = false;
            button2.BackColor = themeColor;
            label3.ForeColor = themeColor;
            button1.BackColor = themeColor;
            label2.ForeColor = themeColor;
            this.BackColor = themeColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            this.panel2.Visible = false;
            this.panel7.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            panel7.Visible = false;
            panel2.Visible = true;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            string username = textBox5.Text;
            string password1 = textBox4.Text;
            string password2 = textBox3.Text;
            if (username!=null&&password1!=null&&password2!=null)
            {
                if (password1 != password2)
                {
                    MessageBox.Show("Passwords Don't Match!");
                    textBox4.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    if (DL.UserCRUD.isUsernameAvailable(username))
                    {
                        BL.User u = new BL.User(username,password2);
                        DL.UserCRUD.addUser(u);
                        MessageBox.Show("User Added Successfuly!");
                        panel7.Visible = false;
                        panel2.Visible = true;
                    }
                    else { MessageBox.Show("Username not Available!"); textBox5.Text = ""; }
                }
            }
            else { MessageBox.Show("Enter Valid Data!"); }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;

            if(DL.UserCRUD.isUserExist(name,pass))
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Wrong Credentials!","Error!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}