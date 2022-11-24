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
            this.dpCreationDateFrom = new System.Windows.Forms.DateTimePicker();
            this.cbCreatorFullName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dpCreationDateTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dpLastUpdateTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dpLastUpdateFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSeverity = new System.Windows.Forms.ComboBox();
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
            // dpCreationDateFrom
            // 
            this.dpCreationDateFrom.Location = new System.Drawing.Point(67, 121);
            this.dpCreationDateFrom.Name = "dpCreationDateFrom";
            this.dpCreationDateFrom.Size = new System.Drawing.Size(152, 23);
            this.dpCreationDateFrom.TabIndex = 1;
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
            // txtContains
            // 
            this.txtContains.Enabled = false;
            this.txtContains.Location = new System.Drawing.Point(67, 334);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(358, 23);
            this.txtContains.TabIndex = 6;
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
            // dpCreationDateTo
            // 
            this.dpCreationDateTo.Location = new System.Drawing.Point(264, 121);
            this.dpCreationDateTo.Name = "dpCreationDateTo";
            this.dpCreationDateTo.Size = new System.Drawing.Size(152, 23);
            this.dpCreationDateTo.TabIndex = 2;
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
            // dpLastUpdateTo
            // 
            this.dpLastUpdateTo.Location = new System.Drawing.Point(264, 202);
            this.dpLastUpdateTo.Name = "dpLastUpdateTo";
            this.dpLastUpdateTo.Size = new System.Drawing.Size(152, 23);
            this.dpLastUpdateTo.TabIndex = 4;
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
            // dpLastUpdateFrom
            // 
            this.dpLastUpdateFrom.Location = new System.Drawing.Point(67, 202);
            this.dpLastUpdateFrom.Name = "dpLastUpdateFrom";
            this.dpLastUpdateFrom.Size = new System.Drawing.Size(152, 23);
            this.dpLastUpdateFrom.TabIndex = 3;
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
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(67, 398);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(152, 23);
            this.cbPriority.TabIndex = 7;
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
            // cbSeverity
            // 
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Location = new System.Drawing.Point(67, 470);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(152, 23);
            this.cbSeverity.TabIndex = 8;
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
            this.Controls.Add(this.cbSeverity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dpLastUpdateTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpLastUpdateFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dpCreationDateTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dpCreationDateFrom);
            this.Controls.Add(this.cbCreatorFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContains);
            this.Name = "FilterForm";
            this.Text = "Filter Bugs By:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private DateTimePicker dpCreationDateFrom;
        private ComboBox cbCreatorFullName;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtContains;
        private Button btnSave;
        private DateTimePicker dpCreationDateTo;
        private Label label4;
        private DateTimePicker dpLastUpdateTo;
        private Label label6;
        private DateTimePicker dpLastUpdateFrom;
        private Label label7;
        private ComboBox cbPriority;
        private Label label8;
        private ComboBox cbSeverity;
        private Label label9;
        private CheckBox cbSolved;
    }
}