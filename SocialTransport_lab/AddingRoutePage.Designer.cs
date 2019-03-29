namespace SocialTransport_lab
{
    partial class AddingRoutePage
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
            this.addingRecordToRouteTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.routeNameTextBox = new System.Windows.Forms.TextBox();
            this.numOfStopsTextBox = new System.Windows.Forms.TextBox();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.finishComboBox = new System.Windows.Forms.ComboBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.fareTextBox = new System.Windows.Forms.TextBox();
            this.emptyTextBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addingRecordToRouteTable
            // 
            this.addingRecordToRouteTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.addingRecordToRouteTable.FlatAppearance.BorderSize = 0;
            this.addingRecordToRouteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addingRecordToRouteTable.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.addingRecordToRouteTable.Location = new System.Drawing.Point(250, 425);
            this.addingRecordToRouteTable.Name = "addingRecordToRouteTable";
            this.addingRecordToRouteTable.Size = new System.Drawing.Size(100, 30);
            this.addingRecordToRouteTable.TabIndex = 0;
            this.addingRecordToRouteTable.Text = "Добавить";
            this.addingRecordToRouteTable.UseVisualStyleBackColor = false;
            this.addingRecordToRouteTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addingRecordToRouteTable_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(80, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название маршрута";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(96, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кол-во остановок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(69, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Начальная остановка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(77, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Конечная остановка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label5.Location = new System.Drawing.Point(103, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Длина маршрута";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label6.Location = new System.Drawing.Point(85, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Стоимость проезда";
            // 
            // routeNameTextBox
            // 
            this.routeNameTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.routeNameTextBox.Location = new System.Drawing.Point(256, 65);
            this.routeNameTextBox.Name = "routeNameTextBox";
            this.routeNameTextBox.Size = new System.Drawing.Size(257, 27);
            this.routeNameTextBox.TabIndex = 7;
            // 
            // numOfStopsTextBox
            // 
            this.numOfStopsTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.numOfStopsTextBox.Location = new System.Drawing.Point(256, 115);
            this.numOfStopsTextBox.Name = "numOfStopsTextBox";
            this.numOfStopsTextBox.Size = new System.Drawing.Size(257, 27);
            this.numOfStopsTextBox.TabIndex = 8;
            this.numOfStopsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOfStopsTextBox_KeyPress);
            // 
            // startComboBox
            // 
            this.startComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startComboBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(256, 165);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(257, 28);
            this.startComboBox.TabIndex = 9;
            // 
            // finishComboBox
            // 
            this.finishComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishComboBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.finishComboBox.FormattingEnabled = true;
            this.finishComboBox.Location = new System.Drawing.Point(256, 215);
            this.finishComboBox.Name = "finishComboBox";
            this.finishComboBox.Size = new System.Drawing.Size(257, 28);
            this.finishComboBox.TabIndex = 10;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.distanceTextBox.Location = new System.Drawing.Point(256, 265);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(257, 27);
            this.distanceTextBox.TabIndex = 11;
            this.distanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distanceTextBox_KeyPress);
            // 
            // fareTextBox
            // 
            this.fareTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.fareTextBox.Location = new System.Drawing.Point(256, 315);
            this.fareTextBox.Name = "fareTextBox";
            this.fareTextBox.Size = new System.Drawing.Size(257, 27);
            this.fareTextBox.TabIndex = 12;
            this.fareTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fareTextBox_KeyPress);
            // 
            // emptyTextBoxLabel
            // 
            this.emptyTextBoxLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.emptyTextBoxLabel.ForeColor = System.Drawing.Color.Red;
            this.emptyTextBoxLabel.Location = new System.Drawing.Point(0, 374);
            this.emptyTextBoxLabel.Name = "emptyTextBoxLabel";
            this.emptyTextBoxLabel.Size = new System.Drawing.Size(600, 21);
            this.emptyTextBoxLabel.TabIndex = 13;
            this.emptyTextBoxLabel.Text = "ВСЕ ПОЛЯ ДОЛЖНЫ БЫТЬ ЗАПОЛНЕНЫ!";
            this.emptyTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emptyTextBoxLabel.Visible = false;
            // 
            // AddingRoutePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.emptyTextBoxLabel);
            this.Controls.Add(this.fareTextBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.finishComboBox);
            this.Controls.Add(this.startComboBox);
            this.Controls.Add(this.numOfStopsTextBox);
            this.Controls.Add(this.routeNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addingRecordToRouteTable);
            this.Name = "AddingRoutePage";
            this.Size = new System.Drawing.Size(600, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addingRecordToRouteTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox routeNameTextBox;
        private System.Windows.Forms.TextBox numOfStopsTextBox;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.ComboBox finishComboBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox fareTextBox;
        private System.Windows.Forms.Label emptyTextBoxLabel;
    }
}
