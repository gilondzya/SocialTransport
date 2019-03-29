namespace SocialTransport_lab
{
    partial class AddingTransportPage
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
            this.addingRecordToTransportTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.typeOfTransportTextBox = new System.Windows.Forms.TextBox();
            this.averageSpeedTextBox = new System.Windows.Forms.TextBox();
            this.numOfPassengersPerTripTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addingRecordToTransportTable
            // 
            this.addingRecordToTransportTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.addingRecordToTransportTable.FlatAppearance.BorderSize = 0;
            this.addingRecordToTransportTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addingRecordToTransportTable.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.addingRecordToTransportTable.Location = new System.Drawing.Point(250, 343);
            this.addingRecordToTransportTable.Name = "addingRecordToTransportTable";
            this.addingRecordToTransportTable.Size = new System.Drawing.Size(100, 30);
            this.addingRecordToTransportTable.TabIndex = 0;
            this.addingRecordToTransportTable.Text = "Добавить";
            this.addingRecordToTransportTable.UseVisualStyleBackColor = false;
            this.addingRecordToTransportTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addingRecordToTransportTable_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(127, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид транспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(110, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Средняя скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(147, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вместимость";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(0, 287);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(600, 30);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // typeOfTransportTextBox
            // 
            this.typeOfTransportTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.typeOfTransportTextBox.Location = new System.Drawing.Point(263, 135);
            this.typeOfTransportTextBox.Name = "typeOfTransportTextBox";
            this.typeOfTransportTextBox.Size = new System.Drawing.Size(204, 27);
            this.typeOfTransportTextBox.TabIndex = 5;
            // 
            // averageSpeedTextBox
            // 
            this.averageSpeedTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.averageSpeedTextBox.Location = new System.Drawing.Point(263, 185);
            this.averageSpeedTextBox.Name = "averageSpeedTextBox";
            this.averageSpeedTextBox.Size = new System.Drawing.Size(204, 27);
            this.averageSpeedTextBox.TabIndex = 6;
            this.averageSpeedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.averageSpeedTextBox_KeyPress);
            // 
            // numOfPassengersPerTripTextBox
            // 
            this.numOfPassengersPerTripTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.numOfPassengersPerTripTextBox.Location = new System.Drawing.Point(263, 235);
            this.numOfPassengersPerTripTextBox.Name = "numOfPassengersPerTripTextBox";
            this.numOfPassengersPerTripTextBox.Size = new System.Drawing.Size(204, 27);
            this.numOfPassengersPerTripTextBox.TabIndex = 7;
            this.numOfPassengersPerTripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOfPassengersPerTripTextBox_KeyPress);
            // 
            // AddingTransportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.numOfPassengersPerTripTextBox);
            this.Controls.Add(this.averageSpeedTextBox);
            this.Controls.Add(this.typeOfTransportTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addingRecordToTransportTable);
            this.Name = "AddingTransportPage";
            this.Size = new System.Drawing.Size(600, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addingRecordToTransportTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox typeOfTransportTextBox;
        private System.Windows.Forms.TextBox averageSpeedTextBox;
        private System.Windows.Forms.TextBox numOfPassengersPerTripTextBox;
    }
}
