namespace PROJETO_FINAL_LC
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVídeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeiraVezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.últimaVezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.completarVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completarSessõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLastWatched = new System.Windows.Forms.DataGridView();
            this.lbGreetings = new System.Windows.Forms.Label();
            this.btnConsult = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddScreening = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diretor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastWatched)).BeginInit();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(690, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.adicionarVídeoToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultarToolStripMenuItem.Text = "Adicionar sessão";
            // 
            // adicionarVídeoToolStripMenuItem
            // 
            this.adicionarVídeoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarVídeoToolStripMenuItem.Image")));
            this.adicionarVídeoToolStripMenuItem.Name = "adicionarVídeoToolStripMenuItem";
            this.adicionarVídeoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.adicionarVídeoToolStripMenuItem.Text = "Adicionar vídeo";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indicaçãoToolStripMenuItem,
            this.topToolStripMenuItem,
            this.estatísticaToolStripMenuItem,
            this.primeiraVezToolStripMenuItem,
            this.últimaVezToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // indicaçãoToolStripMenuItem
            // 
            this.indicaçãoToolStripMenuItem.Name = "indicaçãoToolStripMenuItem";
            this.indicaçãoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.indicaçãoToolStripMenuItem.Text = "Indicação";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.topToolStripMenuItem.Text = "Top";
            // 
            // estatísticaToolStripMenuItem
            // 
            this.estatísticaToolStripMenuItem.Name = "estatísticaToolStripMenuItem";
            this.estatísticaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.estatísticaToolStripMenuItem.Text = "Estatística";
            // 
            // primeiraVezToolStripMenuItem
            // 
            this.primeiraVezToolStripMenuItem.Name = "primeiraVezToolStripMenuItem";
            this.primeiraVezToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.primeiraVezToolStripMenuItem.Text = "Primeira vez...";
            // 
            // últimaVezToolStripMenuItem
            // 
            this.últimaVezToolStripMenuItem.Name = "últimaVezToolStripMenuItem";
            this.últimaVezToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.últimaVezToolStripMenuItem.Text = "Última vez...";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.toolStripMenuItem1});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completarVideosToolStripMenuItem,
            this.completarSessõesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem1.Text = "Assistentes";
            // 
            // completarVideosToolStripMenuItem
            // 
            this.completarVideosToolStripMenuItem.Name = "completarVideosToolStripMenuItem";
            this.completarVideosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.completarVideosToolStripMenuItem.Text = "Completar videos";
            // 
            // completarSessõesToolStripMenuItem
            // 
            this.completarSessõesToolStripMenuItem.Name = "completarSessõesToolStripMenuItem";
            this.completarSessõesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.completarSessõesToolStripMenuItem.Text = "Completar sessões";
            // 
            // dgvLastWatched
            // 
            this.dgvLastWatched.AllowUserToAddRows = false;
            this.dgvLastWatched.AllowUserToDeleteRows = false;
            this.dgvLastWatched.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLastWatched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLastWatched.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDate,
            this.Code,
            this.clTitle,
            this.clType,
            this.clGrade,
            this.Diretor});
            this.dgvLastWatched.Location = new System.Drawing.Point(12, 201);
            this.dgvLastWatched.Name = "dgvLastWatched";
            this.dgvLastWatched.ReadOnly = true;
            this.dgvLastWatched.Size = new System.Drawing.Size(666, 130);
            this.dgvLastWatched.TabIndex = 1;
            this.dgvLastWatched.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLastWatched_CellContentDoubleClick);
            // 
            // lbGreetings
            // 
            this.lbGreetings.AutoSize = true;
            this.lbGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreetings.Location = new System.Drawing.Point(12, 46);
            this.lbGreetings.Name = "lbGreetings";
            this.lbGreetings.Size = new System.Drawing.Size(128, 16);
            this.lbGreetings.TabIndex = 2;
            this.lbGreetings.Text = "O que deseja fazer?";
            // 
            // btnConsult
            // 
            this.btnConsult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.Image = ((System.Drawing.Image)(resources.GetObject("btnConsult.Image")));
            this.btnConsult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsult.Location = new System.Drawing.Point(396, 90);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(211, 54);
            this.btnConsult.TabIndex = 4;
            this.btnConsult.Text = "Consultar";
            this.tt.SetToolTip(this.btnConsult, "Clique para ter opções de consulta entre tudo que assistiu.");
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnAddScreening
            // 
            this.btnAddScreening.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddScreening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScreening.Image = ((System.Drawing.Image)(resources.GetObject("btnAddScreening.Image")));
            this.btnAddScreening.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddScreening.Location = new System.Drawing.Point(84, 90);
            this.btnAddScreening.Name = "btnAddScreening";
            this.btnAddScreening.Size = new System.Drawing.Size(211, 54);
            this.btnAddScreening.TabIndex = 3;
            this.btnAddScreening.Text = "Adicionar sessão";
            this.tt.SetToolTip(this.btnAddScreening, "Clique para adicionar os dados sobre algum vídeo que tenha assitido.");
            this.btnAddScreening.UseVisualStyleBackColor = true;
            this.btnAddScreening.Click += new System.EventHandler(this.btnAddScreening_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "O que andou assitindo...";
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDate});
            this.ssMain.Location = new System.Drawing.Point(0, 344);
            this.ssMain.Name = "ssMain";
            this.ssMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ssMain.Size = new System.Drawing.Size(690, 22);
            this.ssMain.TabIndex = 6;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslDate
            // 
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(0, 17);
            // 
            // clDate
            // 
            this.clDate.DataPropertyName = "date";
            this.clDate.HeaderText = "Data";
            this.clDate.Name = "clDate";
            this.clDate.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "code";
            this.Code.HeaderText = "Código";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Visible = false;
            // 
            // clTitle
            // 
            this.clTitle.DataPropertyName = "nationalTitle";
            this.clTitle.HeaderText = "Título";
            this.clTitle.Name = "clTitle";
            this.clTitle.ReadOnly = true;
            // 
            // clType
            // 
            this.clType.DataPropertyName = "name";
            this.clType.HeaderText = "Tipo";
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            // 
            // clGrade
            // 
            this.clGrade.DataPropertyName = "evaluetion";
            this.clGrade.HeaderText = "Avaliação";
            this.clGrade.Name = "clGrade";
            this.clGrade.ReadOnly = true;
            // 
            // Diretor
            // 
            this.Diretor.DataPropertyName = "director";
            this.Diretor.HeaderText = "Diretor";
            this.Diretor.Name = "Diretor";
            this.Diretor.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 366);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnAddScreening);
            this.Controls.Add(this.lbGreetings);
            this.Controls.Add(this.dgvLastWatched);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O que andei vendo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastWatched)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.DataGridView dgvLastWatched;
        private System.Windows.Forms.Label lbGreetings;
        private System.Windows.Forms.Button btnAddScreening;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVídeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primeiraVezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem últimaVezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem completarVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completarSessõesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diretor;
    }
}

