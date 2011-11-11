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
        public ConsultForm()
        {
            InitializeComponent();
            this.rbtnIndication.CheckedChanged += new EventHandler(rbtnConsultType_CheckedChanged);
            this.rbtnTop.CheckedChanged += new EventHandler(rbtnConsultType_CheckedChanged);
            this.rbtnStatistics.CheckedChanged += new EventHandler(rbtnConsultType_CheckedChanged);
            this.rbtnLastFirstTime.CheckedChanged += new EventHandler(rbtnConsultType_CheckedChanged);
        }

        private void ConsultForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            rbtnIndication.Checked = true;
        }

        private void UpdateConsultTypeInfo(RadioButton selected)
        {
            String strConsultTypeInfo = "";
            if (selected.Equals(rbtnLastFirstTime))
            {
                strConsultTypeInfo = "Com esta opção você pode descobrir quando "
                                   + "foi a última ou a primeira vez que assistiu à um vídeo "
                                   + "que atenda as caracteristicas especificadas nos filtros.";
            }
            if (selected.Equals(rbtnIndication))
            {
                strConsultTypeInfo = "Use este tipo de consulta para indicar filmes "
                                   + "para conhecidos. Utilize os filtros disponíveis para ter como "
                                   + "resultado os melhores filmes para indicar.";
            }
            if (selected.Equals(rbtnTop))
            {
                strConsultTypeInfo = "Use esta consulta para ter um top que atenda às restrições "
                                  + "que você pode colocar utilizando os filtros disponíveis.";
            }
            if (selected.Equals(rbtnStatistics)) 
            {
                strConsultTypeInfo = "Os resultados deste tipo de consulta são números. "
                                  + "Pode ser uma média das notas dos filmes que atendam às restrições "
                                  + "dos filtros ou simplesmente a quandidade de resultados retornados.";
            }
            rtbConsultTypeInfo.Text = strConsultTypeInfo;
        }

        void rbtnConsultType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

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
    }
}
