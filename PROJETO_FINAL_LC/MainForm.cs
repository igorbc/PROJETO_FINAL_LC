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
        private List<Session> sessions = null;

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

                DaoSession daoSession = new DaoSession();
                daoSession.openConnection(this.GetType(), "sqlErrorHandler");
                daoSession.createTable(this.GetType(), "sqlErrorHandler");
                daoSession.closeConnection();

                fillDataGridView();
            }
        }

        private void fillDataGridView()
        {
            DaoSession daoSession = new DaoSession();
            daoSession.openConnection();
            daoSession.populateDataGridView(dgvLastWatched, user.getLogin());
            daoSession.closeConnection();
        }

        public void sqlErrorHandler(Object obj, String message)
        {
            String errorString = "Um erro aconteceu.";
            if (obj is Exception)
            {
                Exception ex = (Exception)obj;
                errorString += " " + message + " " + ex.Message;
            }
            MessageBox.Show(errorString);
        }

        private void dgvLastWatched_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String codeString = dgvLastWatched.Rows[e.RowIndex].Cells["code"].FormattedValue.ToString();
            
            DaoSession daoSession = new DaoSession();
            daoSession.openConnection();
            Session s = daoSession.getSessionByCode(int.Parse(codeString));
            daoSession.closeConnection();

            if (s != null)
            {
                AddScreeningForm asf = new AddScreeningForm(user, s);
                asf.ShowDialog();
                asf.Dispose();
            }
        }

    }
}
