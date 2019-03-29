namespace SocialTransport_lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.openLoginPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sideBtnPanel = new System.Windows.Forms.Panel();
            this.getRoute = new System.Windows.Forms.Button();
            this.getStop = new System.Windows.Forms.Button();
            this.getTransportToRoute = new System.Windows.Forms.Button();
            this.getTransport = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewPage1 = new SocialTransport_lab.DataGridViewPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPage = new SocialTransport_lab.LoginPage();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.openLoginPage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sideBtnPanel);
            this.panel1.Controls.Add(this.getRoute);
            this.panel1.Controls.Add(this.getStop);
            this.panel1.Controls.Add(this.getTransportToRoute);
            this.panel1.Controls.Add(this.getTransport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 550);
            this.panel1.TabIndex = 0;
            // 
            // openLoginPage
            // 
            this.openLoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.openLoginPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openLoginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openLoginPage.FlatAppearance.BorderSize = 0;
            this.openLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openLoginPage.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openLoginPage.ForeColor = System.Drawing.Color.White;
            this.openLoginPage.Location = new System.Drawing.Point(12, 504);
            this.openLoginPage.Name = "openLoginPage";
            this.openLoginPage.Size = new System.Drawing.Size(188, 36);
            this.openLoginPage.TabIndex = 16;
            this.openLoginPage.Text = "Войти";
            this.openLoginPage.UseVisualStyleBackColor = false;
            this.openLoginPage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openLoginPage_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 86);
            this.label1.TabIndex = 15;
            this.label1.Text = "Система общественного транспорта";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // sideBtnPanel
            // 
            this.sideBtnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.sideBtnPanel.Location = new System.Drawing.Point(0, 504);
            this.sideBtnPanel.Name = "sideBtnPanel";
            this.sideBtnPanel.Size = new System.Drawing.Size(13, 36);
            this.sideBtnPanel.TabIndex = 14;
            // 
            // getRoute
            // 
            this.getRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getRoute.FlatAppearance.BorderSize = 0;
            this.getRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getRoute.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getRoute.ForeColor = System.Drawing.Color.White;
            this.getRoute.Location = new System.Drawing.Point(12, 114);
            this.getRoute.Name = "getRoute";
            this.getRoute.Size = new System.Drawing.Size(188, 36);
            this.getRoute.TabIndex = 10;
            this.getRoute.Text = "Маршруты";
            this.getRoute.UseVisualStyleBackColor = false;
            this.getRoute.Visible = false;
            this.getRoute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getRoute_MouseClick);
            // 
            // getStop
            // 
            this.getStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getStop.FlatAppearance.BorderSize = 0;
            this.getStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getStop.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getStop.ForeColor = System.Drawing.Color.White;
            this.getStop.Location = new System.Drawing.Point(12, 161);
            this.getStop.Name = "getStop";
            this.getStop.Size = new System.Drawing.Size(188, 36);
            this.getStop.TabIndex = 11;
            this.getStop.Text = "Остановки";
            this.getStop.UseVisualStyleBackColor = false;
            this.getStop.Visible = false;
            this.getStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getStop_MouseClick);
            // 
            // getTransportToRoute
            // 
            this.getTransportToRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getTransportToRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getTransportToRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getTransportToRoute.FlatAppearance.BorderSize = 0;
            this.getTransportToRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTransportToRoute.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getTransportToRoute.ForeColor = System.Drawing.Color.White;
            this.getTransportToRoute.Location = new System.Drawing.Point(12, 255);
            this.getTransportToRoute.Name = "getTransportToRoute";
            this.getTransportToRoute.Size = new System.Drawing.Size(188, 36);
            this.getTransportToRoute.TabIndex = 13;
            this.getTransportToRoute.Text = "Транспорт-Маршрут";
            this.getTransportToRoute.UseVisualStyleBackColor = false;
            this.getTransportToRoute.Visible = false;
            this.getTransportToRoute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getTransportToRoute_MouseClick);
            // 
            // getTransport
            // 
            this.getTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getTransport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getTransport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getTransport.FlatAppearance.BorderSize = 0;
            this.getTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTransport.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getTransport.ForeColor = System.Drawing.Color.White;
            this.getTransport.Location = new System.Drawing.Point(12, 208);
            this.getTransport.Name = "getTransport";
            this.getTransport.Size = new System.Drawing.Size(188, 36);
            this.getTransport.TabIndex = 12;
            this.getTransport.Text = "Транспорт";
            this.getTransport.UseVisualStyleBackColor = false;
            this.getTransport.Visible = false;
            this.getTransport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getTransport_MouseClick);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(564, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitButton_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 36);
            this.panel3.TabIndex = 1;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // dataGridViewPage1
            // 
            this.dataGridViewPage1.Location = new System.Drawing.Point(200, 36);
            this.dataGridViewPage1.Name = "dataGridViewPage1";
            this.dataGridViewPage1.Size = new System.Drawing.Size(600, 514);
            this.dataGridViewPage1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 514);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.White;
            this.loginPage.Location = new System.Drawing.Point(200, 36);
            this.loginPage.Login = "";
            this.loginPage.Name = "loginPage";
            this.loginPage.Password = "";
            this.loginPage.Size = new System.Drawing.Size(600, 514);
            this.loginPage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.loginPage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewPage1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openLoginPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sideBtnPanel;
        private System.Windows.Forms.Button getRoute;
        private System.Windows.Forms.Button getStop;
        private System.Windows.Forms.Button getTransportToRoute;
        private System.Windows.Forms.Button getTransport;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel3;
        private DataGridViewPage dataGridViewPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LoginPage loginPage;
    }
}

