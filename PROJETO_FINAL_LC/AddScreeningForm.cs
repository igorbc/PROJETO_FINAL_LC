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
        private Boolean updating = false;

        public AddScreeningForm()
        {
            InitializeComponent();
        }
        
        public AddScreeningForm(User user)
            : this()
        {
            if(user != null ) this.user = user;
        }

        public AddScreeningForm(User user, Session session)
            : this (user)
        {
            if (session != null)
            {
                this.session = session;
                this.video = session.getVideo();
                updating = true;
                rtbComment.Text = session.getComment();
                fillVideoInfo(video);
                btnSaveScreening.Text = "Alterar";
                btnSaveScreening.TextAlign = ContentAlignment.MiddleCenter;
            }
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
//                MessageBox.Show("registro do vídeo");
                fillCbbVideoName();
                fillVideoInfo(video);
            }
            vrf.Dispose();
        }

        private void btnEditVideo_Click(object sender, EventArgs e)
        {
            //TODO: prevent this redundance of code
            VideoRegistrationForm vrf = new VideoRegistrationForm(video);
            this.AddOwnedForm(vrf);
            vrf.ShowDialog();
            video = vrf.getVideo();
            if (video != null)
            {
//                MessageBox.Show("edição de vídeo");
                fillCbbVideoName();
                fillVideoInfo(video);
            }
            vrf.Dispose();
        }

        private void fillVideoInfo(Video video)
        {
            //MessageBox.Show("atualizando labels.");
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
            fillCbbVideoName();
            loadModes();
        }

        private void fillCbbVideoName()
        {
            DaoVideo daoVideo = new DaoVideo();
            daoVideo.openConnection(this.GetType(), "sqlErrorHandler");
            daoVideo.populateComboBox(cbbVideoName, (video != null)? video.getCode(): 0);
            daoVideo.closeConnection();
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

            session = new Session(user.getLogin(), video, dtpSession.Value,
                                  evaluetion, cbbMode.Text, rtbComment.Text);
        }

        private void btnSaveScreening_Click(object sender, EventArgs e)
        {
            if (!verifyRequiredFields())
                MessageBox.Show("Preencha titulo nacional ou titulo original para poder registrar.");
            else
            {
                createSession();
                DaoSession daoSession = new DaoSession();
                daoSession.openConnection(this.GetType(), "sqlErrorHandler");
                
                if (updating)
                {
                    if (daoSession.updateSession(session, this.GetType(), "sqlErrorHandler"))
                    {
                        //                        MessageBox.Show("Atualizações salvas!");
                    }
                }
                else
                {
                    if (daoSession.insertSession(session, this.GetType(), "sqlErrorHandler"))
                    {
                        //                        MessageBox.Show("Video registrado!");
                    }
                }
                daoSession.closeConnection();
                this.Close();
            }
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

        private void cbbVideoName_SelectedValueChanged(object sender, EventArgs e)
        {
            DaoVideo daoVideo = new DaoVideo();
            daoVideo.openConnection();
            if (cbbVideoName.SelectedValue != null)
            {
                if (cbbVideoName.SelectedValue is int)
                {
                    int selectedVideoCode = (int)cbbVideoName.SelectedValue;
                    if(!updating)
                        video = daoVideo.getVideoByCode((int)cbbVideoName.SelectedValue);
                    if (video != null)
                    {
                        btnEditVideo.Enabled = true;
 //                       MessageBox.Show("selected ... changed");
                        fillVideoInfo(video);
                    }
                }
            }
            daoVideo.closeConnection();
        }

        private Boolean verifyStringToBeAdded(String toBeAdded, IEnumerable<String> alreadyAdded)
        {
            if (toBeAdded.Length == 0)
            {
                // TODO: take the next line out of here and put them somewher else somehow
                btnAddMode.Enabled = false;
                return false;
            }
            foreach (String s in alreadyAdded)
            {
                if (s.Equals(toBeAdded)) return false;
            }
            return true;
        }

        private Boolean validMode()
        {
            foreach (String s in cbbMode.Items)
            {
                if (cbbMode.Text.Equals(s))
                    return true;
            }
            return false;
        }

        private void updateLbMode()
        {
            if (validMode())
            {
                lbValidMode.Text = "ok";
                lbValidMode.ForeColor = Color.ForestGreen;
                btnAddMode.Enabled = false;
            }
            else
            {
                lbValidMode.Text = "x";
                lbValidMode.ForeColor = Color.DarkRed;
                btnAddMode.Enabled = true;
            }
        }

        private void btnAddMode_Click(object sender, EventArgs e)
        {
            if (verifyStringToBeAdded(cbbMode.Text, cbbMode.Items.Cast<String>()))
            {
                DaoSession daoSession = new DaoSession();
                daoSession.openConnection(this.GetType(), "sqlErrorHandler");
                daoSession.insertMode(cbbMode.Text, this.GetType(), "sqlErrorHandler");
                daoSession.closeConnection();
                loadModes();
                updateLbMode();
            }
            cbbMode.Focus();
        }
        
        private void loadModes()
        {
            DaoSession daoSession = new DaoSession();
            daoSession.openConnection(this.GetType(), "sqlErrorHandler");
            cbbMode.Items.Clear();
            cbbMode.Items.AddRange(daoSession.retrieveAllModes().ToArray());
            daoSession.closeConnection();
        }

        private void cbbMode_TextChanged(object sender, EventArgs e)
        {
            updateLbMode();
        }

    }
}
