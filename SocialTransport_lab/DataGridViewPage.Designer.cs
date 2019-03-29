namespace SocialTransport_lab
{
    partial class DataGridViewPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.addingRoutePage1 = new SocialTransport_lab.AddingRoutePage();
            this.addingStopPage1 = new SocialTransport_lab.AddingStopPage();
            this.addingTransportPage1 = new SocialTransport_lab.AddingTransportPage();
            this.addingTransportToRoutePage1 = new SocialTransport_lab.AddingTransportToRoutePage();
            this.inputError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 460);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.Add.Location = new System.Drawing.Point(80, 472);
            this.Add.Name = "Add";
            this.Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Add.Size = new System.Drawing.Size(100, 30);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Visible = false;
            this.Add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Add_MouseClick);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.Edit.Location = new System.Drawing.Point(250, 472);
            this.Edit.Name = "Edit";
            this.Edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Edit.Size = new System.Drawing.Size(100, 30);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Visible = false;
            this.Edit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Edit_MouseClick);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.Delete.Location = new System.Drawing.Point(420, 472);
            this.Delete.Name = "Delete";
            this.Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Delete.Size = new System.Drawing.Size(100, 30);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Visible = false;
            this.Delete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Delete_MouseClick);
            // 
            // addingRoutePage1
            // 
            this.addingRoutePage1.BackColor = System.Drawing.Color.White;
            this.addingRoutePage1.Location = new System.Drawing.Point(0, 0);
            this.addingRoutePage1.Name = "addingRoutePage1";
            this.addingRoutePage1.Size = new System.Drawing.Size(600, 514);
            this.addingRoutePage1.TabIndex = 4;
            // 
            // addingStopPage1
            // 
            this.addingStopPage1.BackColor = System.Drawing.Color.White;
            this.addingStopPage1.Location = new System.Drawing.Point(0, 0);
            this.addingStopPage1.Name = "addingStopPage1";
            this.addingStopPage1.Size = new System.Drawing.Size(600, 514);
            this.addingStopPage1.TabIndex = 5;
            // 
            // addingTransportPage1
            // 
            this.addingTransportPage1.BackColor = System.Drawing.Color.White;
            this.addingTransportPage1.Location = new System.Drawing.Point(0, 0);
            this.addingTransportPage1.Name = "addingTransportPage1";
            this.addingTransportPage1.Size = new System.Drawing.Size(600, 514);
            this.addingTransportPage1.TabIndex = 6;
            // 
            // addingTransportToRoutePage1
            // 
            this.addingTransportToRoutePage1.BackColor = System.Drawing.Color.White;
            this.addingTransportToRoutePage1.Location = new System.Drawing.Point(0, 0);
            this.addingTransportToRoutePage1.Name = "addingTransportToRoutePage1";
            this.addingTransportToRoutePage1.Size = new System.Drawing.Size(600, 514);
            this.addingTransportToRoutePage1.TabIndex = 7;
            // 
            // inputError
            // 
            this.inputError.BackColor = System.Drawing.Color.White;
            this.inputError.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.inputError.ForeColor = System.Drawing.Color.Red;
            this.inputError.Location = new System.Drawing.Point(216, 200);
            this.inputError.Name = "inputError";
            this.inputError.Size = new System.Drawing.Size(168, 24);
            this.inputError.TabIndex = 8;
            this.inputError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputError);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addingRoutePage1);
            this.Controls.Add(this.addingStopPage1);
            this.Controls.Add(this.addingTransportPage1);
            this.Controls.Add(this.addingTransportToRoutePage1);
            this.Name = "DataGridViewPage";
            this.Size = new System.Drawing.Size(600, 514);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private AddingRoutePage addingRoutePage1;
        private AddingStopPage addingStopPage1;
        private AddingTransportPage addingTransportPage1;
        private AddingTransportToRoutePage addingTransportToRoutePage1;
        private System.Windows.Forms.Label inputError;
    }
}
