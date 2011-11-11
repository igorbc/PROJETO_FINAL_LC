namespace PROJETO_FINAL_LC
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinishRegistration = new System.Windows.Forms.Button();
            this.gbEvaluetionMethod = new System.Windows.Forms.GroupBox();
            this.cbbSteps = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbHigherLimit = new System.Windows.Forms.ComboBox();
            this.cbbLowerLimit = new System.Windows.Forms.ComboBox();
            this.rbtnStars = new System.Windows.Forms.RadioButton();
            this.rbtnGrade = new System.Windows.Forms.RadioButton();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.gbEvaluetionMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preencha seu nome (opcional)";
            // 
            // btnFinishRegistration
            // 
            this.btnFinishRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnFinishRegistration.Image")));
            this.btnFinishRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinishRegistration.Location = new System.Drawing.Point(412, 282);
            this.btnFinishRegistration.Name = "btnFinishRegistration";
            this.btnFinishRegistration.Size = new System.Drawing.Size(104, 39);
            this.btnFinishRegistration.TabIndex = 6;
            this.btnFinishRegistration.Text = "Concluir";
            this.btnFinishRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinishRegistration.UseVisualStyleBackColor = true;
            this.btnFinishRegistration.Click += new System.EventHandler(this.btnFinishRegistration_Click);
            // 
            // gbEvaluetionMethod
            // 
            this.gbEvaluetionMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEvaluetionMethod.Controls.Add(this.cbbSteps);
            this.gbEvaluetionMethod.Controls.Add(this.label5);
            this.gbEvaluetionMethod.Controls.Add(this.label4);
            this.gbEvaluetionMethod.Controls.Add(this.label2);
            this.gbEvaluetionMethod.Controls.Add(this.cbbHigherLimit);
            this.gbEvaluetionMethod.Controls.Add(this.cbbLowerLimit);
            this.gbEvaluetionMethod.Controls.Add(this.rbtnStars);
            this.gbEvaluetionMethod.Controls.Add(this.rbtnGrade);
            this.gbEvaluetionMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvaluetionMethod.Location = new System.Drawing.Point(106, 101);
            this.gbEvaluetionMethod.Name = "gbEvaluetionMethod";
            this.gbEvaluetionMethod.Size = new System.Drawing.Size(298, 173);
            this.gbEvaluetionMethod.TabIndex = 6;
            this.gbEvaluetionMethod.TabStop = false;
            this.gbEvaluetionMethod.Text = "Como deseja avaliar os vídeos?";
            // 
            // cbbSteps
            // 
            this.cbbSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSteps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSteps.FormattingEnabled = true;
            this.cbbSteps.Items.AddRange(new object[] {
            "0,1",
            "0,5",
            "1",
            "5",
            "10"});
            this.cbbSteps.Location = new System.Drawing.Point(139, 131);
            this.cbbSteps.Name = "cbbSteps";
            this.cbbSteps.Size = new System.Drawing.Size(129, 24);
            this.cbbSteps.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Em passos de";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Limite superior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limite inferior";
            // 
            // cbbHigherLimit
            // 
            this.cbbHigherLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbHigherLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHigherLimit.FormattingEnabled = true;
            this.cbbHigherLimit.Items.AddRange(new object[] {
            "1",
            "4",
            "5",
            "10",
            "100"});
            this.cbbHigherLimit.Location = new System.Drawing.Point(139, 99);
            this.cbbHigherLimit.Name = "cbbHigherLimit";
            this.cbbHigherLimit.Size = new System.Drawing.Size(129, 24);
            this.cbbHigherLimit.TabIndex = 4;
            this.cbbHigherLimit.SelectedIndexChanged += new System.EventHandler(this.cbbHigherLimit_SelectedIndexChanged);
            // 
            // cbbLowerLimit
            // 
            this.cbbLowerLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLowerLimit.DisplayMember = "1";
            this.cbbLowerLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLowerLimit.FormattingEnabled = true;
            this.cbbLowerLimit.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbLowerLimit.Location = new System.Drawing.Point(139, 64);
            this.cbbLowerLimit.Name = "cbbLowerLimit";
            this.cbbLowerLimit.Size = new System.Drawing.Size(129, 24);
            this.cbbLowerLimit.TabIndex = 3;
            // 
            // rbtnStars
            // 
            this.rbtnStars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnStars.AutoSize = true;
            this.rbtnStars.Location = new System.Drawing.Point(193, 34);
            this.rbtnStars.Name = "rbtnStars";
            this.rbtnStars.Size = new System.Drawing.Size(75, 20);
            this.rbtnStars.TabIndex = 2;
            this.rbtnStars.Text = "Estrelas";
            this.rbtnStars.UseVisualStyleBackColor = true;
            // 
            // rbtnGrade
            // 
            this.rbtnGrade.AutoSize = true;
            this.rbtnGrade.Checked = true;
            this.rbtnGrade.Location = new System.Drawing.Point(43, 34);
            this.rbtnGrade.Name = "rbtnGrade";
            this.rbtnGrade.Size = new System.Drawing.Size(55, 20);
            this.rbtnGrade.TabIndex = 1;
            this.rbtnGrade.TabStop = true;
            this.rbtnGrade.Text = "Nota";
            this.rbtnGrade.UseVisualStyleBackColor = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Enabled = false;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(38, 52);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 22);
            this.tbLogin.TabIndex = 7;
            this.tbLogin.Text = "login aqui";
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(168, 52);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(295, 22);
            this.tbUserName.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 333);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.gbEvaluetionMethod);
            this.Controls.Add(this.btnFinishRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de cadastro";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.Shown += new System.EventHandler(this.RegistrationForm_Shown);
            this.gbEvaluetionMethod.ResumeLayout(false);
            this.gbEvaluetionMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinishRegistration;
        private System.Windows.Forms.GroupBox gbEvaluetionMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbHigherLimit;
        private System.Windows.Forms.ComboBox cbbLowerLimit;
        private System.Windows.Forms.RadioButton rbtnStars;
        private System.Windows.Forms.RadioButton rbtnGrade;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSteps;
        private System.Windows.Forms.TextBox tbUserName;
    }
}