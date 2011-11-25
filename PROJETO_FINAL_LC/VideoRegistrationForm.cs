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
    public partial class VideoRegistrationForm : Form
    {
        private String[] tags;
        private String hoursMask = "90:00";
        private String minutesMask = "9999";
        private Video video = null;
        private int duration;
        private Boolean updating = false;
        private int videoCode = 0;


        public VideoRegistrationForm()
        {
            InitializeComponent();
        }

        public VideoRegistrationForm(Video video)
            : this()
        {
            if (video != null)
            {
                videoCode = video.getCode();
                this.video = video;
                fillFields();
                updating = true;
                btnRegisterVideo.TextAlign = ContentAlignment.MiddleCenter;
                btnRegisterVideo.Text = "Salvar";
            }
        }

        private void fillFields()
        {
            tbNationalTitle.Text = video.getNationalTitle();
            tbOriginalTitle.Text = video.getOriginalTitle();
            tbDirector.Text = video.getDirector();
            mtbDuration.Text = video.getDuration().ToString();
            mtbYear.Text = video.getYear().ToString();
            tags = video.getTags();
            cbbCategory.Text = video.getCategory();
            foreach (String s in tags)
            {
                lbVideoTags.Items.Add(s);
            }
        }

        private void VideoRegistrationForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            DaoVideo daoVideo = new DaoVideo();
            daoVideo.openConnection(this.GetType(), "sqlErrorHandler");
            daoVideo.createTable(this.GetType(), "sqlErrorHandler");
            daoVideo.closeConnection();

            setMtbDurationMask();
            loadItemsIntoCbbVideoTags();
            loadCategories();
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

        public Video getVideo()
        {
            return video;
        }

        private void loadCategories()
        {
            DaoVideo daoVideo = new DaoVideo();
            daoVideo.openConnection(this.GetType(), "sqlErrorHandler");
            cbbCategory.Items.Clear();
            cbbCategory.Items.AddRange(daoVideo.retrieveAllCategories().ToArray());
            daoVideo.closeConnection();
        }

        private void setMtbDurationMask()
        {
            if (rbInHours.Checked)
            {
                mtbDuration.Mask = hoursMask;
            }
            else 
            {
                mtbDuration.Mask = minutesMask;
            }
        }

        private Boolean verifyRequiredFields()
        {
            if (tbNationalTitle.Text.Length == 0 && tbOriginalTitle.Text.Length == 0)
                return false;
            else
                return true;
        }

        private void getTags()
        {

            if (lbVideoTags.Items.Count > 0)
            {
                int i = 0;
                tags = new String[lbVideoTags.Items.Count];
                foreach (String s in lbVideoTags.Items)
                {
                    tags[i++] = s;
                }
            }
            else
                tags = new String[0];
        }

        private void createVideo()
        {
            int year;
            if(!int.TryParse(mtbYear.Text, out year))
                year = 0;
            updateDuration();
            getTags();
            video = new Video(videoCode, tbOriginalTitle.Text, tbNationalTitle.Text, tbDirector.Text,
                    year, duration, cbbCategory.Text, tags);
        }

        private void btnRegisterVideo_Click(object sender, EventArgs e)
        {
            if (!verifyRequiredFields())
                MessageBox.Show("Preencha titulo nacional ou titulo original para poder registrar.");
            else
            {
                createVideo();
                DaoVideo daoVideo = new DaoVideo();
                daoVideo.openConnection(this.GetType(), "sqlErrorHandler");
                
                if (updating)
                {
                    
                    if (daoVideo.updateVideo(video, this.GetType(), "sqlErrorHandler"))
                        MessageBox.Show("Atualizações salvas!");
                }
                else
                {
                    if (daoVideo.insertVideo(video, this.GetType(), "sqlErrorHandler"))
                        MessageBox.Show("Video registrado!");
                }

                daoVideo.closeConnection();
                this.Close();
            }
            
        }

        private void rbInHours_CheckedChanged(object sender, EventArgs e)
        {
            setMtbDurationMask();
        }

        private void updateDuration()
        {
            if (mtbDuration.Text.Length != 0)
                if (rbInMinutes.Checked)
                    duration = int.Parse(mtbDuration.Text);
                else
                {
                    String[] durationStrings;
                    durationStrings = mtbDuration.Text.Split(new Char[] { ':' });
                    duration = int.Parse(durationStrings[0]) * 60;
                    duration += int.Parse(durationStrings[1]);
                }
            else
                duration = 0;
        }

        private Boolean verifyStringToBeAdded(String toBeAdded, IEnumerable<String> alreadyAdded)
        {
            if (toBeAdded.Length == 0)
                return false;
            foreach (String s in alreadyAdded)
            {
                if (s.Equals(toBeAdded)) return false;
            }
            return true;
        }

        private void loadItemsIntoCbbVideoTags()
        {
            DaoVideo daoVideo = new DaoVideo();
            daoVideo.openConnection(this.GetType(), "sqlErrorHandler");
            cbbVideoTags.Items.Clear();
            cbbVideoTags.Items.AddRange(daoVideo.retrieveAllTags().ToArray());
            daoVideo.closeConnection();
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            if (verifyStringToBeAdded(cbbVideoTags.Text,lbVideoTags.Items.Cast<String>()))
            {
                if(!cbbVideoTags.Items.Contains(cbbVideoTags.Text))
                {
                    DaoVideo daoVideo = new DaoVideo();
                    daoVideo.openConnection(this.GetType(), "sqlErrorHandler");
                    daoVideo.insertTag(cbbVideoTags.Text, this.GetType(), "sqlErrorHandler");
                    daoVideo.closeConnection();
                    
                }
                lbVideoTags.Items.Add(cbbVideoTags.Text);
                cbbVideoTags.Text = "";
                loadItemsIntoCbbVideoTags();
                
            }
            cbbVideoTags.Focus();
        }

        private void removeFromLbTags()
        {
            if(lbVideoTags.SelectedIndex >= 0)
                lbVideoTags.Items.RemoveAt(lbVideoTags.SelectedIndex);
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            removeFromLbTags();
        }

        private void mtbYear_MouseClick(object sender, MouseEventArgs e)
        {
            mtbYear.SelectAll();
        }

        private void mtbDuration_MouseClick(object sender, MouseEventArgs e)
        {
            mtbDuration.SelectAll();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (verifyStringToBeAdded(cbbCategory.Text, cbbCategory.Items.Cast<String>()))
            {
                DaoVideo daoVideo = new DaoVideo();
                daoVideo.openConnection(this.GetType(), "sqlErrorHandler");
                daoVideo.insertCategory(cbbCategory.Text, this.GetType(), "sqlErrorHandler");
                daoVideo.closeConnection();
                loadCategories();
                updateLbCategory();
            }
            cbbCategory.Focus();
        }

        private Boolean validCategory()
        {
            foreach (String s in cbbCategory.Items)
            {
                if(cbbCategory.Text.Equals(s))
                    return true;
            }
            return false;
        }

        private void updateLbCategory()
        {
            if (validCategory())
            {
                lbValidCategory.Text = "ok";
                lbValidCategory.ForeColor = Color.ForestGreen;
            }
            else
            {
                lbValidCategory.Text = "x";
                lbValidCategory.ForeColor = Color.DarkRed;
            }
        }

        private void cbbCategory_TextChanged(object sender, EventArgs e)
        {
            updateLbCategory();
        }
    }
}
