using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROJETO_FINAL_LC
{
    public partial class LoginForm : Form
    {
        Boolean valid = false;
        User user = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DaoUser daoUser = new DaoUser();
            daoUser.openConnection(this.GetType(), "sqlErrorHandler");
            daoUser.createTable(this.GetType(), "sqlErrorHandler");
            daoUser.closeConnection();
            this.MinimumSize = this.Size;
        }

        public void sqlErrorHandler(Object obj, String message)
        {
            String errorString = "Um erro aconteceu.";
            if (obj is Exception)
            {
                Exception ex = (Exception)obj;
                errorString += message + " " + ex.Message;
            }
            MessageBox.Show(errorString);
        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

        private Boolean checksIfUserAlreadyExists(String name)
        {
            //TODO: check on DB if user already exists
            if(name.Equals("igor")) return true;
            return false;
        }

        private void emptyFieldsWarning()
        {
            if (tbLogIn.Text.Length == 0)
                if (tbPassword.Text.Length == 0)
                    MessageBox.Show("Digite um login e uma senha antes de tentar se cadastrar.");
                else
                    MessageBox.Show("Digite um login antes de tentar se cadastrar.");
            else
                MessageBox.Show("Digite uma senha antes de tentar se cadastrar.");
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (tbLogIn.Text.Length != 0 && tbPassword.Text.Length != 0)
            {
                if (checksIfUserAlreadyExists(tbLogIn.Text))
                {
                    MessageBox.Show("O login escolhido já existe, " +
                                    "escolha outro (ou faça login, caso seja você mesmo)");
                    tbLogIn.Focus();
                }
                else
                {
                    RegistrationForm rf = new RegistrationForm(tbLogIn.Text, tbPassword.Text);
                    this.AddOwnedForm(rf);
                    rf.ShowDialog(this);
                }
            }
            else
            {
                emptyFieldsWarning();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            tryToLogIn();
        }

        private void tryToLogIn()
        {
            
            if (tbLogIn.Text.Length != 0 && tbPassword.Text.Length != 0)
            {
                DaoUser daoUser = new DaoUser();
                daoUser.openConnection(this.GetType(), "sqlErrorHandler");
                user = daoUser.getUserByLogin(tbLogIn.Text, this.GetType(), "sqlErrorHandler");
                daoUser.closeConnection();

                if (user != null && user.getPassword().Equals(tbPassword.Text))
                {
                    valid = true;
                }

                if (valid)
                    this.Close();
                else
                {
                    MessageBox.Show("Usuário ou senha não encontrados. " +
                                    "Tente novamente ou cadastre-se");
                    tbLogIn.Focus();
                }
            }
            else
                emptyFieldsWarning();
        }

        public User getUser()
        {
            if (valid)
                return user;
            else
                return null;
        }

        private void tbLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryToLogIn(); 
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryToLogIn(); 
        }

    }
}
