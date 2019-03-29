namespace SocialTransport_lab
{
    partial class AddingTransportToRoutePage
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
            this.typeOfTransportComboBox = new System.Windows.Forms.ComboBox();
            this.routeNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emptyInput = new System.Windows.Forms.Label();
            this.addingRecordToTransportToRouteTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeOfTransportComboBox
            // 
            this.typeOfTransportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfTransportComboBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.typeOfTransportComboBox.ForeColor = System.Drawing.Color.Black;
            this.typeOfTransportComboBox.FormattingEnabled = true;
            this.typeOfTransportComboBox.Location = new System.Drawing.Point(273, 150);
            this.typeOfTransportComboBox.Name = "typeOfTransportComboBox";
            this.typeOfTransportComboBox.Size = new System.Drawing.Size(229, 28);
            this.typeOfTransportComboBox.TabIndex = 0;
            // 
            // routeNameComboBox
            // 
            this.routeNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.routeNameComboBox.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.routeNameComboBox.ForeColor = System.Drawing.Color.Black;
            this.routeNameComboBox.FormattingEnabled = true;
            this.routeNameComboBox.Location = new System.Drawing.Point(273, 200);
            this.routeNameComboBox.Name = "routeNameComboBox";
            this.routeNameComboBox.Size = new System.Drawing.Size(229, 28);
            this.routeNameComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите транспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите маршрут";
            // 
            // emptyInput
            // 
            this.emptyInput.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.emptyInput.ForeColor = System.Drawing.Color.Red;
            this.emptyInput.Location = new System.Drawing.Point(0, 262);
            this.emptyInput.Name = "emptyInput";
            this.emptyInput.Size = new System.Drawing.Size(600, 23);
            this.emptyInput.TabIndex = 4;
            this.emptyInput.Text = "ВСЕ ПОЛЯ ДОЛЖНЫ БЫТЬ ЗАПОЛНЕНЫ!";
            this.emptyInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addingRecordToTransportToRouteTable
            // 
            this.addingRecordToTransportToRouteTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.addingRecordToTransportToRouteTable.FlatAppearance.BorderSize = 0;
            this.addingRecordToTransportToRouteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addingRecordToTransportToRouteTable.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.addingRecordToTransportToRouteTable.ForeColor = System.Drawing.Color.Black;
            this.addingRecordToTransportToRouteTable.Location = new System.Drawing.Point(250, 318);
            this.addingRecordToTransportToRouteTable.Name = "addingRecordToTransportToRouteTable";
            this.addingRecordToTransportToRouteTable.Size = new System.Drawing.Size(100, 30);
            this.addingRecordToTransportToRouteTable.TabIndex = 5;
            this.addingRecordToTransportToRouteTable.Text = "Добавить";
            this.addingRecordToTransportToRouteTable.UseVisualStyleBackColor = false;
            this.addingRecordToTransportToRouteTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addingRecordToTransportToRouteTable_MouseClick);
            // 
            // AddingTransportToRoutePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addingRecordToTransportToRouteTable);
            this.Controls.Add(this.emptyInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.routeNameComboBox);
            this.Controls.Add(this.typeOfTransportComboBox);
            this.Name = "AddingTransportToRoutePage";
            this.Size = new System.Drawing.Size(600, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeOfTransportComboBox;
        private System.Windows.Forms.ComboBox routeNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emptyInput;
        private System.Windows.Forms.Button addingRecordToTransportToRouteTable;
    }
}
