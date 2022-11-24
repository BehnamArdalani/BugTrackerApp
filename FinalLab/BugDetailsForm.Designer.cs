namespace GUILayer
{
    partial class BugDetailsForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbDescription = new System.Windows.Forms.RichTextBox();
            this.cbIsSolved = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.dpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.cbCreatorFullName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbSeverity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(420, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(324, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbDescription
            // 
            this.rbDescription.Location = new System.Drawing.Point(199, 278);
            this.rbDescription.Name = "rbDescription";
            this.rbDescription.Size = new System.Drawing.Size(495, 174);
            this.rbDescription.TabIndex = 4;
            this.rbDescription.Text = "";
            // 
            // cbIsSolved
            // 
            this.cbIsSolved.AutoSize = true;
            this.cbIsSolved.Location = new System.Drawing.Point(542, 217);
            this.cbIsSolved.Name = "cbIsSolved";
            this.cbIsSolved.Size = new System.Drawing.Size(61, 19);
            this.cbIsSolved.TabIndex = 8;
            this.cbIsSolved.Text = "Solved";
            this.cbIsSolved.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Status:";
            // 
            // dpLastUpdate
            // 
            this.dpLastUpdate.Location = new System.Drawing.Point(542, 159);
            this.dpLastUpdate.Name = "dpLastUpdate";
            this.dpLastUpdate.Size = new System.Drawing.Size(152, 23);
            this.dpLastUpdate.TabIndex = 7;
            // 
            // dpCreationDate
            // 
            this.dpCreationDate.Location = new System.Drawing.Point(542, 105);
            this.dpCreationDate.Name = "dpCreationDate";
            this.dpCreationDate.Size = new System.Drawing.Size(152, 23);
            this.dpCreationDate.TabIndex = 6;
            // 
            // cbCreatorFullName
            // 
            this.cbCreatorFullName.FormattingEnabled = true;
            this.cbCreatorFullName.Location = new System.Drawing.Point(199, 161);
            this.cbCreatorFullName.Name = "cbCreatorFullName";
            this.cbCreatorFullName.Size = new System.Drawing.Size(152, 23);
            this.cbCreatorFullName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 55;
            this.label8.Text = "Last Update:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(439, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 54;
            this.label13.Text = "Creation Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(439, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 53;
            this.label14.Text = "Severity:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(88, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 50;
            this.label15.Text = "Priority:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(88, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "Creator Full Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(88, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 46;
            this.label17.Text = "Description:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(88, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 15);
            this.label18.TabIndex = 45;
            this.label18.Text = "Bug Name:";
            // 
            // txtBugName
            // 
            this.txtBugName.Location = new System.Drawing.Point(199, 108);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(152, 23);
            this.txtBugName.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(88, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 15);
            this.label19.TabIndex = 43;
            this.label19.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(199, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(152, 23);
            this.txtId.TabIndex = 0;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(199, 218);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(152, 23);
            this.cbPriority.TabIndex = 3;
            // 
            // cbSeverity
            // 
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Location = new System.Drawing.Point(542, 52);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(152, 23);
            this.cbSeverity.TabIndex = 5;
            // 
            // BugDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 530);
            this.Controls.Add(this.cbSeverity);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbDescription);
            this.Controls.Add(this.cbIsSolved);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dpLastUpdate);
            this.Controls.Add(this.dpCreationDate);
            this.Controls.Add(this.cbCreatorFullName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBugName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtId);
            this.Name = "BugDetailsForm";
            this.Text = "Bug Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private RichTextBox rbDescription;
        private CheckBox cbIsSolved;
        private Label label7;
        private DateTimePicker dpLastUpdate;
        private DateTimePicker dpCreationDate;
        private ComboBox cbCreatorFullName;
        private Label label8;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txtBugName;
        private Label label19;
        private TextBox txtId;
        private ComboBox cbPriority;
        private ComboBox cbSeverity;
    }
}