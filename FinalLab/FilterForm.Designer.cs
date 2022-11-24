namespace GUILayer
{
    partial class FilterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.cbCreatorFullName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSolved = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bug Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(67, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(152, 23);
            this.txtId.TabIndex = 0;
            // 
            // dpCreatedDate
            // 
            this.dpCreatedDate.Location = new System.Drawing.Point(67, 121);
            this.dpCreatedDate.Name = "dpCreatedDate";
            this.dpCreatedDate.Size = new System.Drawing.Size(152, 23);
            this.dpCreatedDate.TabIndex = 1;
            // 
            // cbCreatorFullName
            // 
            this.cbCreatorFullName.FormattingEnabled = true;
            this.cbCreatorFullName.Location = new System.Drawing.Point(67, 270);
            this.cbCreatorFullName.Name = "cbCreatorFullName";
            this.cbCreatorFullName.Size = new System.Drawing.Size(152, 23);
            this.cbCreatorFullName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Creation Date (From):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Creator Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contains (Names and Description):";
            // 
            // txtBugName
            // 
            this.txtBugName.Enabled = false;
            this.txtBugName.Location = new System.Drawing.Point(67, 334);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(358, 23);
            this.txtBugName.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(191, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 37);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Creation Date (To):";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(264, 202);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Last Update Date (To):";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(67, 202);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Last Update Date (From):";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 398);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Priority:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(67, 470);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Severity:";
            // 
            // cbSolved
            // 
            this.cbSolved.AutoSize = true;
            this.cbSolved.Location = new System.Drawing.Point(308, 472);
            this.cbSolved.Name = "cbSolved";
            this.cbSolved.Size = new System.Drawing.Size(61, 19);
            this.cbSolved.TabIndex = 9;
            this.cbSolved.Text = "Solved";
            this.cbSolved.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 591);
            this.Controls.Add(this.cbSolved);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dpCreatedDate);
            this.Controls.Add(this.cbCreatorFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBugName);
            this.Name = "FilterForm";
            this.Text = "Filter Bugs By:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private DateTimePicker dpCreatedDate;
        private ComboBox cbCreatorFullName;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtBugName;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox comboBox2;
        private Label label9;
        private CheckBox cbSolved;
    }
}