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
            this.rtxtLogs = new System.Windows.Forms.RichTextBox();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.btnNewMessage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(799, 667);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 49);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbDescription
            // 
            this.rbDescription.Location = new System.Drawing.Point(178, 343);
            this.rbDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDescription.Name = "rbDescription";
            this.rbDescription.Size = new System.Drawing.Size(592, 229);
            this.rbDescription.TabIndex = 4;
            this.rbDescription.Text = "";
            // 
            // cbIsSolved
            // 
            this.cbIsSolved.AutoSize = true;
            this.cbIsSolved.Location = new System.Drawing.Point(562, 266);
            this.cbIsSolved.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIsSolved.Name = "cbIsSolved";
            this.cbIsSolved.Size = new System.Drawing.Size(82, 27);
            this.cbIsSolved.TabIndex = 8;
            this.cbIsSolved.Text = "Solved";
            this.cbIsSolved.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Status:";
            // 
            // dpLastUpdate
            // 
            this.dpLastUpdate.Location = new System.Drawing.Point(562, 188);
            this.dpLastUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpLastUpdate.Name = "dpLastUpdate";
            this.dpLastUpdate.Size = new System.Drawing.Size(208, 30);
            this.dpLastUpdate.TabIndex = 7;
            // 
            // dpCreationDate
            // 
            this.dpCreationDate.Location = new System.Drawing.Point(562, 116);
            this.dpCreationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpCreationDate.Name = "dpCreationDate";
            this.dpCreationDate.Size = new System.Drawing.Size(208, 30);
            this.dpCreationDate.TabIndex = 6;
            // 
            // cbCreatorFullName
            // 
            this.cbCreatorFullName.FormattingEnabled = true;
            this.cbCreatorFullName.Location = new System.Drawing.Point(178, 187);
            this.cbCreatorFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCreatorFullName.Name = "cbCreatorFullName";
            this.cbCreatorFullName.Size = new System.Drawing.Size(206, 31);
            this.cbCreatorFullName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 55;
            this.label8.Text = "Last Update:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 23);
            this.label13.TabIndex = 54;
            this.label13.Text = "Creation Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(437, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 23);
            this.label14.TabIndex = 53;
            this.label14.Text = "Severity:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 23);
            this.label15.TabIndex = 50;
            this.label15.Text = "Priority:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 23);
            this.label16.TabIndex = 48;
            this.label16.Text = "Creator Full Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 347);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 46;
            this.label17.Text = "Description:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 23);
            this.label18.TabIndex = 45;
            this.label18.Text = "Bug Name:";
            // 
            // txtBugName
            // 
            this.txtBugName.Location = new System.Drawing.Point(178, 116);
            this.txtBugName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(206, 30);
            this.txtBugName.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 23);
            this.label19.TabIndex = 43;
            this.label19.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(178, 41);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 30);
            this.txtId.TabIndex = 0;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(178, 263);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(206, 31);
            this.cbPriority.TabIndex = 3;
            // 
            // cbSeverity
            // 
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Location = new System.Drawing.Point(562, 41);
            this.cbSeverity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(208, 31);
            this.cbSeverity.TabIndex = 5;
            // 
            // rtxtLogs
            // 
            this.rtxtLogs.Location = new System.Drawing.Point(30, 44);
            this.rtxtLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtLogs.Name = "rtxtLogs";
            this.rtxtLogs.Size = new System.Drawing.Size(556, 188);
            this.rtxtLogs.TabIndex = 59;
            this.rtxtLogs.Text = "";
            // 
            // dgvMessages
            // 
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(28, 41);
            this.dgvMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.RowHeadersWidth = 51;
            this.dgvMessages.RowTemplate.Height = 25;
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(556, 260);
            this.dgvMessages.TabIndex = 61;
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.Location = new System.Drawing.Point(908, 667);
            this.btnNewMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(115, 49);
            this.btnNewMessage.TabIndex = 62;
            this.btnNewMessage.Text = "New Message";
            this.btnNewMessage.UseVisualStyleBackColor = true;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(581, 667);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 49);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Text = "New Bug";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(690, 667);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 49);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtBugName);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbSeverity);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbPriority);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbDescription);
            this.groupBox1.Controls.Add(this.cbCreatorFullName);
            this.groupBox1.Controls.Add(this.cbIsSolved);
            this.groupBox1.Controls.Add(this.dpCreationDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dpLastUpdate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(38, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 595);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bug Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMessages);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(885, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 326);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Messages";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxtLogs);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(885, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 255);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // BugDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 747);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNewMessage);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BugDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Details";
            this.Load += new System.EventHandler(this.BugDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private RichTextBox rtxtLogs;
        private DataGridView dgvMessages;
        private Button btnNewMessage;
        private Button btnAdd;
        private Button btnEdit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}