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
    public partial class AddScreeningForm : Form
    {
        private Video video = null;
        private User user = null;
        private Session session = null;

        public AddScreeningForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnRegisterVideo_Click(object sender, EventArgs e)
        {
            VideoRegistrationForm vrf = new VideoRegistrationForm();
            this.AddOwnedForm(vrf);
            vrf.ShowDialog();
            video = vrf.getVideo();
            if (video != null)
            {
                btnEditVideo.Enabled = true;
                fillVideoInfo(video);
            }
        }

        private void fillVideoInfo(Video video)
        {
            String[] tags = new String[0];
            lbNationalTitle.Text = video.getNationalTitle();
            lbOriginalTitle.Text = video.getOriginalTitle();
            lbDirector.Text = video.getDirector();
            lbYear.Text = video.getYear().ToString();
            lbDuration.Text = video.getDuration().ToString();
            lbCategory.Text = video.getCategory();
            tags = video.getTags();
            lbVideoTags.Items.Clear();
            foreach (String s in tags)
            {
                lbVideoTags.Items.Add(s);
            }
        }

        private void AddScreeningForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            fillCbbEvaluetion();
            loadModes();
        }

        private void loadModes()
        {
            // load all modes ever used by the user into the cbbMode
        }

        private void fillCbbEvaluetion()
        {
            float higherLimit, lowerLimit, steps;
            higherLimit = user.getEvaluetionMethodInfo().getHigherLimit();
            lowerLimit = user.getEvaluetionMethodInfo().getLowerLimit();
            steps = user.getEvaluetionMethodInfo().getStep();

            cbbEvaluetion.Items.Clear();
            for (float i = lowerLimit ; i <= higherLimit ; i += steps)
            {
                cbbEvaluetion.Items.Add(i);
            }
        }

        private Boolean verifyRequiredFields()
        {
            if (video != null)
                return true;
            else
                return false;
        }

        private void createSession()
        {
            float evaluetion;
            if(!float.TryParse(cbbEvaluetion.Text, out evaluetion))
                evaluetion = -1;

            session = new Session(video, evaluetion, cbbMode.Text, rtbComment.Text);
        }

        private void btnSaveScreening_Click(object sender, EventArgs e)
        {
            if (!verifyRequiredFields())
                MessageBox.Show("Preencha titulo nacional ou titulo original para poder registrar.");
            else
            {
                createSession();
                //TODO: insert session into database
                MessageBox.Show("Sessão criada (não foi inserida ainda...)");
                this.Close();
            }
        }

        private void btnEditVideo_Click(object sender, EventArgs e)
        {
            //TODO: prevent this redundance of code
            VideoRegistrationForm vrf = new VideoRegistrationForm(video);
            this.AddOwnedForm(vrf);
            vrf.ShowDialog();
            video = vrf.getVideo();
            if (video != null) fillVideoInfo(video);
        }

    }
}
