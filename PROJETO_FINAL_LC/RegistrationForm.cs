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
    public partial class RegistrationForm : Form
    {
        private User user;
        private String password;

        public RegistrationForm(String login, String password)
        {
            InitializeComponent();
            tbLogin.Text = login;
            this.password = password;
        }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            cbbLowerLimit.SelectedIndex = 0;
            cbbHigherLimit.SelectedIndex = 3;
            cbbSteps.SelectedIndex = 1;
        }

        private Boolean createTheUser()
        {
            EvaluetionMethod em;
            float lowerLimit, higherLimit, step;

            user = new User(tbLogin.Text, password, tbUserName.Text);
            
            if (!(float.TryParse(cbbLowerLimit.Text, out lowerLimit) &&
                  float.TryParse(cbbHigherLimit.Text, out higherLimit) &&
                  float.TryParse(cbbSteps.Text, out step)))
            {
                MessageBox.Show("Preencha todos os campos relativos a como avaliar os vídeos");
                return false;
            }

            if (higherLimit < step)
            {
                MessageBox.Show("Assim a avaliação não vai funcionar. " + 
                                "Diminua os passos ou aumente o limite superior");
                return false;
            }
            
            if (rbtnGrade.Checked)
                em = EvaluetionMethod.Grade;
            else
                em = EvaluetionMethod.Stars;

            user.setEvaluetionMethodInfo(em, lowerLimit, higherLimit, step);
            return true;
        }

        private void btnFinishRegistration_Click(object sender, EventArgs e)
        {
            if (createTheUser())
            {
                DaoUser daoUser = new DaoUser();
                daoUser.openConnection();
                if (!daoUser.insertUser(user, this.GetType(), "errorHandler"))
                {
                    MessageBox.Show("Problema ao gravar usuário no banco de dados. " +
                                    "A aplicação irá se encerrar...");
                    daoUser.closeConnection();
                    Application.Exit();
                }
                daoUser.closeConnection();
                MessageBox.Show("Usuário criado com sucesso! Agora é só fazer o login.");
                this.Close();
            }
        }

        public void errorHandler(Object obj, String message)
        {
            if (obj is Exception)
            {
                Exception ex = (Exception)obj;
                MessageBox.Show("Um erro aconteceu. " + message + " " + ex.Message);
            }
        }


        private void cbbHigherLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHigherLimit.SelectedIndex == 0)
            {
                cbbLowerLimit.SelectedIndex = 0;
                cbbLowerLimit.Items.RemoveAt(1);
            }
            else
            {
                if (cbbLowerLimit.Items.Count == 1) cbbLowerLimit.Items.Add("1");
            }
        }

    }
}
