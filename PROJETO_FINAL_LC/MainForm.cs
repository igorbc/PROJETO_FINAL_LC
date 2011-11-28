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
    public partial class MainForm : Form
    {

        private User user = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            DateTime now = DateTime.Now;
            tsslDate.Text = "Hoje é " + now.Day + "/" + now.Month + "/" + now.Year;
        }

        private void btnAddScreening_Click(object sender, EventArgs e)
        {
            AddScreeningForm asf = new AddScreeningForm(user);
            this.AddOwnedForm(asf);
            asf.Show(this);
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            ConsultForm cf = new ConsultForm(user);
            this.AddOwnedForm(cf);
            cf.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.AddOwnedForm(lf);
            lf.ShowDialog(this);
            user = lf.getUser();
            if (user == null)
                Application.Exit();
            else
            {
                ssMain.Items.Add("Usuário: " + user.getName());

            }
        }

    }
}
