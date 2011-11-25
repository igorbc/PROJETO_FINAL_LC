namespace PROJETO_FINAL_LC
{
    partial class AddScreeningForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScreeningForm));
            this.dtpSession = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.cbbVideoName = new System.Windows.Forms.ComboBox();
            this.btnSaveScreening = new System.Windows.Forms.Button();
            this.btnRegisterVideo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.cbbEvaluetion = new System.Windows.Forms.ComboBox();
            this.btnAddMode = new System.Windows.Forms.Button();
            this.gbVideoInfo = new System.Windows.Forms.GroupBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.lbOriginalTitle = new System.Windows.Forms.Label();
            this.lbNationalTitle = new System.Windows.Forms.Label();
            this.gbSeries = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditVideo = new System.Windows.Forms.Button();
            this.lbVideoTags = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbVideoInfo.SuspendLayout();
            this.gbSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSession
            // 
            this.dtpSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSession.Location = new System.Drawing.Point(34, 52);
            this.dtpSession.Name = "dtpSession";
            this.dtpSession.Size = new System.Drawing.Size(261, 22);
            this.dtpSession.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data da sessão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vídeo assistido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sua avaliação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observação / comentário / crítica";
            // 
            // rtbComment
            // 
            this.rtbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComment.Location = new System.Drawing.Point(34, 182);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(551, 137);
            this.rtbComment.TabIndex = 5;
            this.rtbComment.Text = "";
            // 
            // cbbVideoName
            // 
            this.cbbVideoName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbVideoName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbVideoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVideoName.FormattingEnabled = true;
            this.cbbVideoName.Location = new System.Drawing.Point(333, 51);
            this.cbbVideoName.Name = "cbbVideoName";
            this.cbbVideoName.Size = new System.Drawing.Size(252, 24);
            this.cbbVideoName.TabIndex = 6;
            this.cbbVideoName.SelectedValueChanged += new System.EventHandler(this.cbbVideoName_SelectedValueChanged);
            // 
            // btnSaveScreening
            // 
            this.btnSaveScreening.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveScreening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScreening.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveScreening.Image")));
            this.btnSaveScreening.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveScreening.Location = new System.Drawing.Point(591, 273);
            this.btnSaveScreening.Name = "btnSaveScreening";
            this.btnSaveScreening.Size = new System.Drawing.Size(176, 46);
            this.btnSaveScreening.TabIndex = 7;
            this.btnSaveScreening.Text = "Salvar sessão     ";
            this.btnSaveScreening.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveScreening.UseVisualStyleBackColor = true;
            this.btnSaveScreening.Click += new System.EventHandler(this.btnSaveScreening_Click);
            // 
            // btnRegisterVideo
            // 
            this.btnRegisterVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterVideo.Image")));
            this.btnRegisterVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterVideo.Location = new System.Drawing.Point(591, 36);
            this.btnRegisterVideo.Name = "btnRegisterVideo";
            this.btnRegisterVideo.Size = new System.Drawing.Size(176, 39);
            this.btnRegisterVideo.TabIndex = 8;
            this.btnRegisterVideo.Text = "Cadastrar Vídeo     ";
            this.btnRegisterVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegisterVideo.UseVisualStyleBackColor = true;
            this.btnRegisterVideo.Click += new System.EventHandler(this.btnRegisterVideo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modo";
            // 
            // cbbMode
            // 
            this.cbbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Location = new System.Drawing.Point(333, 112);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(252, 24);
            this.cbbMode.TabIndex = 10;
            // 
            // cbbEvaluetion
            // 
            this.cbbEvaluetion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEvaluetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEvaluetion.FormattingEnabled = true;
            this.cbbEvaluetion.Items.AddRange(new object[] {
            "0",
            "0,5",
            "1",
            "1,5",
            "2",
            "2,5",
            "3",
            "3,5",
            "4",
            "4,5",
            "5",
            "5,5",
            "6",
            "6,5",
            "7",
            "7,5",
            "8",
            "8,5",
            "9",
            "9,5",
            "10"});
            this.cbbEvaluetion.Location = new System.Drawing.Point(34, 112);
            this.cbbEvaluetion.Name = "cbbEvaluetion";
            this.cbbEvaluetion.Size = new System.Drawing.Size(261, 24);
            this.cbbEvaluetion.TabIndex = 11;
            // 
            // btnAddMode
            // 
            this.btnAddMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMode.Image")));
            this.btnAddMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMode.Location = new System.Drawing.Point(591, 104);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(28, 39);
            this.btnAddMode.TabIndex = 12;
            this.btnAddMode.UseVisualStyleBackColor = true;
            // 
            // gbVideoInfo
            // 
            this.gbVideoInfo.Controls.Add(this.lbCategory);
            this.gbVideoInfo.Controls.Add(this.lbDuration);
            this.gbVideoInfo.Controls.Add(this.lbYear);
            this.gbVideoInfo.Controls.Add(this.lbDirector);
            this.gbVideoInfo.Controls.Add(this.lbOriginalTitle);
            this.gbVideoInfo.Controls.Add(this.lbNationalTitle);
            this.gbVideoInfo.Controls.Add(this.gbSeries);
            this.gbVideoInfo.Controls.Add(this.label7);
            this.gbVideoInfo.Controls.Add(this.btnEditVideo);
            this.gbVideoInfo.Controls.Add(this.lbVideoTags);
            this.gbVideoInfo.Controls.Add(this.label6);
            this.gbVideoInfo.Controls.Add(this.label11);
            this.gbVideoInfo.Controls.Add(this.label12);
            this.gbVideoInfo.Controls.Add(this.label13);
            this.gbVideoInfo.Controls.Add(this.label14);
            this.gbVideoInfo.Controls.Add(this.label15);
            this.gbVideoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVideoInfo.Location = new System.Drawing.Point(34, 349);
            this.gbVideoInfo.Name = "gbVideoInfo";
            this.gbVideoInfo.Size = new System.Drawing.Size(733, 269);
            this.gbVideoInfo.TabIndex = 13;
            this.gbVideoInfo.TabStop = false;
            this.gbVideoInfo.Text = "Informações do Vídeo";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(444, 107);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(0, 16);
            this.lbCategory.TabIndex = 50;
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.Location = new System.Drawing.Point(437, 81);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(0, 16);
            this.lbDuration.TabIndex = 49;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(489, 55);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(0, 16);
            this.lbYear.TabIndex = 48;
            // 
            // lbDirector
            // 
            this.lbDirector.AutoSize = true;
            this.lbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirector.Location = new System.Drawing.Point(433, 29);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(0, 16);
            this.lbDirector.TabIndex = 47;
            // 
            // lbOriginalTitle
            // 
            this.lbOriginalTitle.AutoSize = true;
            this.lbOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginalTitle.Location = new System.Drawing.Point(100, 55);
            this.lbOriginalTitle.Name = "lbOriginalTitle";
            this.lbOriginalTitle.Size = new System.Drawing.Size(0, 16);
            this.lbOriginalTitle.TabIndex = 46;
            // 
            // lbNationalTitle
            // 
            this.lbNationalTitle.AutoSize = true;
            this.lbNationalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalTitle.Location = new System.Drawing.Point(107, 29);
            this.lbNationalTitle.Name = "lbNationalTitle";
            this.lbNationalTitle.Size = new System.Drawing.Size(0, 16);
            this.lbNationalTitle.TabIndex = 45;
            // 
            // gbSeries
            // 
            this.gbSeries.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbSeries.Controls.Add(this.label10);
            this.gbSeries.Controls.Add(this.label9);
            this.gbSeries.Controls.Add(this.label8);
            this.gbSeries.Enabled = false;
            this.gbSeries.Location = new System.Drawing.Point(216, 142);
            this.gbSeries.Name = "gbSeries";
            this.gbSeries.Size = new System.Drawing.Size(318, 118);
            this.gbSeries.TabIndex = 43;
            this.gbSeries.TabStop = false;
            this.gbSeries.Text = "Dados da série";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nome do episódio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Episódio (nº)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Temporada (nº)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Duração";
            // 
            // btnEditVideo
            // 
            this.btnEditVideo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditVideo.Enabled = false;
            this.btnEditVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditVideo.Image")));
            this.btnEditVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditVideo.Location = new System.Drawing.Point(572, 225);
            this.btnEditVideo.Name = "btnEditVideo";
            this.btnEditVideo.Size = new System.Drawing.Size(155, 35);
            this.btnEditVideo.TabIndex = 44;
            this.btnEditVideo.Text = "Editar";
            this.btnEditVideo.UseVisualStyleBackColor = true;
            this.btnEditVideo.Click += new System.EventHandler(this.btnEditVideo_Click);
            // 
            // lbVideoTags
            // 
            this.lbVideoTags.Enabled = false;
            this.lbVideoTags.FormattingEnabled = true;
            this.lbVideoTags.Location = new System.Drawing.Point(9, 100);
            this.lbVideoTags.Name = "lbVideoTags";
            this.lbVideoTags.Size = new System.Drawing.Size(160, 160);
            this.lbVideoTags.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Categoria";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Palávras-chave";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(371, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ano de produção";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(371, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Direção";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Título original";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Título nacional";
            // 
            // AddScreeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 650);
            this.Controls.Add(this.gbVideoInfo);
            this.Controls.Add(this.btnAddMode);
            this.Controls.Add(this.cbbEvaluetion);
            this.Controls.Add(this.cbbMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegisterVideo);
            this.Controls.Add(this.btnSaveScreening);
            this.Controls.Add(this.cbbVideoName);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSession);
            this.Name = "AddScreeningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar sessão";
            this.Load += new System.EventHandler(this.AddScreeningForm_Load);
            this.gbVideoInfo.ResumeLayout(false);
            this.gbVideoInfo.PerformLayout();
            this.gbSeries.ResumeLayout(false);
            this.gbSeries.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.ComboBox cbbVideoName;
        private System.Windows.Forms.Button btnSaveScreening;
        private System.Windows.Forms.Button btnRegisterVideo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMode;
        private System.Windows.Forms.ComboBox cbbEvaluetion;
        private System.Windows.Forms.Button btnAddMode;
        private System.Windows.Forms.GroupBox gbVideoInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbSeries;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditVideo;
        private System.Windows.Forms.ListBox lbVideoTags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Label lbOriginalTitle;
        private System.Windows.Forms.Label lbNationalTitle;
    }
}