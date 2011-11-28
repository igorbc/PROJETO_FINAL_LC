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
    public partial class ConsultForm : Form
    {
        RadioButton rbtnSelectedType = new RadioButton();
        User user = null;

        public ConsultForm()
        {
            InitializeComponent();
            this.rbtnSimple.CheckedChanged += new EventHandler(rbtnConsultType_CheckedChanged);
            this.rbtnTopRecomendation.CheckedChanged += new EventHandler(rbtnConsultType_CheckedChanged);
            this.rbtnStatistics.CheckedChanged += new EventHandler(rbtnConsultType_CheckedChanged);
            this.rbtnLastFirstTime.CheckedChanged += new EventHandler(rbtnConsultType_CheckedChanged);
        }

        public ConsultForm(User user)
            : this()
        {
            if (user != null)
                this.user = user;
        }

        private void ConsultForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            rbtnSimple.Checked = true;
        }

        private void UpdateConsultTypeInfo(RadioButton selected)
        {
            String strConsultTypeInfo = "";
            if (selected.Equals(rbtnLastFirstTime))
            {
                lastFirstTimeChosen();
            }
            if (selected.Equals(rbtnSimple))
            {
                strConsultTypeInfo = "Com esta opção você preenche um único campo tem como resultado "
                                   + "uma pesquisa geral que tenha a ver com o que foi preenchido.";
                simpleChosen();
            }
            if (selected.Equals(rbtnTopRecomendation))
            {
                strConsultTypeInfo = "Use este tipo de consulta para indicar filmes para conhecidos e "
                                    + " tops. Utilize os filtros disponíveis para ter como "
                                    + "resultado os melhores filmes para indicar.";
                topRecomedationChosen();
            }
            if (selected.Equals(rbtnStatistics)) 
            {
                strConsultTypeInfo = "Os resultados deste tipo de consulta são números. "
                                  + "Pode ser uma média das notas dos filmes que atendam às restrições "
                                  + "dos filtros ou simplesmente a quandidade de resultados retornados.";
                statisticsChosen();

            }
            rtbConsultTypeInfo.Text = strConsultTypeInfo;
        }

        private void rbtnConsultType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            rbtnSelectedType = rb;
            if (rb == null)
            {
                MessageBox.Show("Objeto não é um RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                rbtnSelectedType = rb;
                UpdateConsultTypeInfo(rb);   
            }
        }

        private void topRecomedationChosen()
        {
            pnSimple.Visible = false;
        }

        private void statisticsChosen()
        {
            pnSimple.Visible = false;
        }

        private void lastFirstTimeChosen()
        {
            pnSimple.Visible = false;
        }

        private void simpleChosen()
        {
            pnSimple.Visible = true;
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (rbtnSelectedType.Equals(rbtnLastFirstTime))
            {
                lastFirstTimeQuery();
            }
            if (rbtnSelectedType.Equals(rbtnSimple))
            {
                simpleQuery();
            }
            if (rbtnSelectedType.Equals(rbtnTopRecomendation))
            {
                topRecomedationQuery();
            }
            if (rbtnSelectedType.Equals(rbtnStatistics))
            {
                statisticsQuery();
            }
        }

        private void topRecomedationQuery()
        {
        }

        private void lastFirstTimeQuery()
        {
        }

        private void statisticsQuery()
        { 
        }

        private void simpleQuery() 
        {
            DaoSession daoSession = new DaoSession();
            daoSession.openConnection();
            List<Session> sessions = daoSession.simpleQuery(tbSimple.Text);
            daoSession.closeConnection();

            String output = "";
            if (sessions != null)
                foreach (Session s in sessions)
                {
                    Video v = s.getVideo();
                    output += s.getDate() + " " + v.getNationalTitle() + " " + v.getDirector() + " " + s.getEvaluetion() + " " + s.getMode() + " " + s.getComment() + Environment.NewLine;
                    AddScreeningForm asf = new AddScreeningForm(user, s);
                    asf.ShowDialog();
                    asf.Dispose();
                }
            MessageBox.Show(output);
        }

    }
}
