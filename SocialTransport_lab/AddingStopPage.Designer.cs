namespace SocialTransport_lab
{
    partial class AddingStopPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addRecordToStopTable = new System.Windows.Forms.Button();
            this.stopNameTextBox = new System.Windows.Forms.TextBox();
            this.emptyLine = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addRecordToStopTable
            // 
            this.addRecordToStopTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addRecordToStopTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.addRecordToStopTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addRecordToStopTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRecordToStopTable.FlatAppearance.BorderSize = 0;
            this.addRecordToStopTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecordToStopTable.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRecordToStopTable.ForeColor = System.Drawing.Color.Black;
            this.addRecordToStopTable.Location = new System.Drawing.Point(250, 273);
            this.addRecordToStopTable.Name = "addRecordToStopTable";
            this.addRecordToStopTable.Size = new System.Drawing.Size(100, 30);
            this.addRecordToStopTable.TabIndex = 16;
            this.addRecordToStopTable.Text = "Добавить";
            this.addRecordToStopTable.UseVisualStyleBackColor = false;
            this.addRecordToStopTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addRecordToStopTable_MouseClick);
            // 
            // stopNameTextBox
            // 
            this.stopNameTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.stopNameTextBox.Location = new System.Drawing.Point(233, 226);
            this.stopNameTextBox.Name = "stopNameTextBox";
            this.stopNameTextBox.Size = new System.Drawing.Size(282, 27);
            this.stopNameTextBox.TabIndex = 13;
            // 
            // emptyLine
            // 
            this.emptyLine.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.emptyLine.ForeColor = System.Drawing.Color.Red;
            this.emptyLine.Location = new System.Drawing.Point(0, 316);
            this.emptyLine.Name = "emptyLine";
            this.emptyLine.Size = new System.Drawing.Size(600, 20);
            this.emptyLine.TabIndex = 15;
            this.emptyLine.Text = "ВВЕДИТЕ НЕПУСТУЮ СТРОКУ!";
            this.emptyLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emptyLine.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(86, 216);
            this.label4.MaximumSize = new System.Drawing.Size(150, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите название остановки";
            // 
            // AddingStopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addRecordToStopTable);
            this.Controls.Add(this.stopNameTextBox);
            this.Controls.Add(this.emptyLine);
            this.Controls.Add(this.label4);
            this.Name = "AddingStopPage";
            this.Size = new System.Drawing.Size(600, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRecordToStopTable;
        private System.Windows.Forms.TextBox stopNameTextBox;
        private System.Windows.Forms.Label emptyLine;
        private System.Windows.Forms.Label label4;
    }
}
