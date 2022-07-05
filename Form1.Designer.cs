
namespace Launch_Epic_Games_with_Steam
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.epicUrl = new System.Windows.Forms.TextBox();
            this.exeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.debugBox = new System.Windows.Forms.TextBox();
            this.openExeFile = new System.Windows.Forms.OpenFileDialog();
            this.searchExe = new System.Windows.Forms.PictureBox();
            this.searchUrl = new System.Windows.Forms.PictureBox();
            this.openInkFile = new System.Windows.Forms.OpenFileDialog();
            this.bckPanel = new System.Windows.Forms.Panel();
            this.segundosLabel = new System.Windows.Forms.Label();
            this.timeToWaitLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchUrl)).BeginInit();
            this.bckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // epicUrl
            // 
            this.epicUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.epicUrl.BackColor = System.Drawing.SystemColors.Control;
            this.epicUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epicUrl.Location = new System.Drawing.Point(148, 114);
            this.epicUrl.Name = "epicUrl";
            this.epicUrl.Size = new System.Drawing.Size(537, 47);
            this.epicUrl.TabIndex = 0;
            // 
            // exeName
            // 
            this.exeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exeName.BackColor = System.Drawing.SystemColors.Control;
            this.exeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exeName.Location = new System.Drawing.Point(148, 239);
            this.exeName.Name = "exeName";
            this.exeName.Size = new System.Drawing.Size(537, 47);
            this.exeName.TabIndex = 1;
            this.exeName.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(537, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "SALVAR ATALHO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(328, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(511, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(174, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(17, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(113, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.BackColor = System.Drawing.Color.Navy;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(29, 239);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(113, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // debugBox
            // 
            this.debugBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugBox.BackColor = System.Drawing.Color.Navy;
            this.debugBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugBox.ForeColor = System.Drawing.Color.Lime;
            this.debugBox.Location = new System.Drawing.Point(0, 413);
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.Size = new System.Drawing.Size(776, 17);
            this.debugBox.TabIndex = 8;
            this.debugBox.TabStop = false;
            this.debugBox.Text = "Debug!";
            this.debugBox.Enter += new System.EventHandler(this.debugBox_Enter);
            // 
            // openExeFile
            // 
            this.openExeFile.Filter = "Exe Files (*.exe;)|*.exe;";
            this.openExeFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openExeFile_FileOk);
            // 
            // searchExe
            // 
            this.searchExe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchExe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchExe.Image = ((System.Drawing.Image)(resources.GetObject("searchExe.Image")));
            this.searchExe.Location = new System.Drawing.Point(688, 239);
            this.searchExe.Name = "searchExe";
            this.searchExe.Size = new System.Drawing.Size(55, 50);
            this.searchExe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchExe.TabIndex = 9;
            this.searchExe.TabStop = false;
            this.searchExe.Click += new System.EventHandler(this.searchExe_Click);
            // 
            // searchUrl
            // 
            this.searchUrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchUrl.Image = ((System.Drawing.Image)(resources.GetObject("searchUrl.Image")));
            this.searchUrl.Location = new System.Drawing.Point(691, 114);
            this.searchUrl.Name = "searchUrl";
            this.searchUrl.Size = new System.Drawing.Size(55, 50);
            this.searchUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchUrl.TabIndex = 10;
            this.searchUrl.TabStop = false;
            this.searchUrl.Click += new System.EventHandler(this.searchUrl_Click);
            // 
            // openInkFile
            // 
            this.openInkFile.Filter = "Atalhos (*.url;)|*.url;";
            this.openInkFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openInkFile_FileOk);
            // 
            // bckPanel
            // 
            this.bckPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bckPanel.Controls.Add(this.segundosLabel);
            this.bckPanel.Controls.Add(this.timeToWaitLabel);
            this.bckPanel.Controls.Add(this.debugBox);
            this.bckPanel.Controls.Add(this.pictureBox4);
            this.bckPanel.Controls.Add(this.timeBox);
            this.bckPanel.Controls.Add(this.linkLabel1);
            this.bckPanel.Controls.Add(this.pictureBox6);
            this.bckPanel.Location = new System.Drawing.Point(12, 8);
            this.bckPanel.Name = "bckPanel";
            this.bckPanel.Size = new System.Drawing.Size(776, 434);
            this.bckPanel.TabIndex = 11;
            // 
            // segundosLabel
            // 
            this.segundosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.segundosLabel.AutoSize = true;
            this.segundosLabel.ForeColor = System.Drawing.Color.White;
            this.segundosLabel.Location = new System.Drawing.Point(42, 381);
            this.segundosLabel.Name = "segundosLabel";
            this.segundosLabel.Size = new System.Drawing.Size(53, 13);
            this.segundosLabel.TabIndex = 4;
            this.segundosLabel.Text = "segundos";
            // 
            // timeToWaitLabel
            // 
            this.timeToWaitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeToWaitLabel.AutoSize = true;
            this.timeToWaitLabel.ForeColor = System.Drawing.Color.White;
            this.timeToWaitLabel.Location = new System.Drawing.Point(17, 339);
            this.timeToWaitLabel.Name = "timeToWaitLabel";
            this.timeToWaitLabel.Size = new System.Drawing.Size(93, 13);
            this.timeToWaitLabel.TabIndex = 3;
            this.timeToWaitLabel.Text = "Tempo de espera:";
            // 
            // timeBox
            // 
            this.timeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeBox.Location = new System.Drawing.Point(17, 358);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 20);
            this.timeBox.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(209, 18);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "KledsonZG (Youtube Channel)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox6
            // 
            this.pictureBox6.AccessibleName = "Sobre este programa";
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(722, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Sobre este programa";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchUrl);
            this.Controls.Add(this.searchExe);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exeName);
            this.Controls.Add(this.epicUrl);
            this.Controls.Add(this.bckPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open a Game (Epic Games) with Steam";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchExe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchUrl)).EndInit();
            this.bckPanel.ResumeLayout(false);
            this.bckPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox exeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.OpenFileDialog openExeFile;
        private System.Windows.Forms.PictureBox searchExe;
        public System.Windows.Forms.TextBox debugBox;
        private System.Windows.Forms.PictureBox searchUrl;
        private System.Windows.Forms.OpenFileDialog openInkFile;
        public System.Windows.Forms.TextBox epicUrl;
        private System.Windows.Forms.Panel bckPanel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label timeToWaitLabel;
        private System.Windows.Forms.Label segundosLabel;
    }
}

