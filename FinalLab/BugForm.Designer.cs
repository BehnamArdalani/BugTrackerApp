namespace FinalLab
{
    partial class BugForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAllBugs = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbSolved = new System.Windows.Forms.CheckBox();
            this.cbSeverity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dpLastUpdateTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dpLastUpdateFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dpCreationDateTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dpCreationDateFrom = new System.Windows.Forms.DateTimePicker();
            this.cbCreatorFullName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.gbBugs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBugs)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.gbBugs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllBugs
            // 
            this.dgvAllBugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAllBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBugs.Location = new System.Drawing.Point(39, 42);
            this.dgvAllBugs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllBugs.MultiSelect = false;
            this.dgvAllBugs.Name = "dgvAllBugs";
            this.dgvAllBugs.ReadOnly = true;
            this.dgvAllBugs.RowHeadersWidth = 51;
            this.dgvAllBugs.RowTemplate.Height = 25;
            this.dgvAllBugs.Size = new System.Drawing.Size(1246, 293);
            this.dgvAllBugs.TabIndex = 10;
            this.dgvAllBugs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBugs_CellClick);
            this.dgvAllBugs.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBugs_CellMouseEnter);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(699, 669);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(103, 49);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open Bug";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(1187, 160);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Reset";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(589, 669);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 49);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "New Bug";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(1078, 160);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(103, 49);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbSolved
            // 
            this.cbSolved.AutoSize = true;
            this.cbSolved.Location = new System.Drawing.Point(972, 173);
            this.cbSolved.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSolved.Name = "cbSolved";
            this.cbSolved.Size = new System.Drawing.Size(82, 27);
            this.cbSolved.TabIndex = 51;
            this.cbSolved.Text = "Solved";
            this.cbSolved.UseVisualStyleBackColor = true;
            // 
            // cbSeverity
            // 
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Items.AddRange(new object[] {
            "Any"});
            this.cbSeverity.Location = new System.Drawing.Point(838, 170);
            this.cbSeverity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(103, 31);
            this.cbSeverity.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(838, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 60;
            this.label9.Text = "Severity:";
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Any"});
            this.cbPriority.Location = new System.Drawing.Point(686, 170);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(101, 31);
            this.cbPriority.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 59;
            this.label8.Text = "Priority:";
            // 
            // dpLastUpdateTo
            // 
            this.dpLastUpdateTo.Location = new System.Drawing.Point(1054, 76);
            this.dpLastUpdateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpLastUpdateTo.Name = "dpLastUpdateTo";
            this.dpLastUpdateTo.Size = new System.Drawing.Size(227, 30);
            this.dpLastUpdateTo.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1054, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Last Update Date (To):";
            // 
            // dpLastUpdateFrom
            // 
            this.dpLastUpdateFrom.Location = new System.Drawing.Point(783, 76);
            this.dpLastUpdateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpLastUpdateFrom.Name = "dpLastUpdateFrom";
            this.dpLastUpdateFrom.Size = new System.Drawing.Size(239, 30);
            this.dpLastUpdateFrom.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(783, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Last Update Date (From):";
            // 
            // dpCreationDateTo
            // 
            this.dpCreationDateTo.Location = new System.Drawing.Point(505, 76);
            this.dpCreationDateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpCreationDateTo.Name = "dpCreationDateTo";
            this.dpCreationDateTo.Size = new System.Drawing.Size(240, 30);
            this.dpCreationDateTo.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Creation Date (To):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Bug Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(39, 75);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(142, 30);
            this.txtId.TabIndex = 42;
            // 
            // dpCreationDateFrom
            // 
            this.dpCreationDateFrom.Location = new System.Drawing.Point(225, 76);
            this.dpCreationDateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpCreationDateFrom.Name = "dpCreationDateFrom";
            this.dpCreationDateFrom.Size = new System.Drawing.Size(236, 30);
            this.dpCreationDateFrom.TabIndex = 43;
            // 
            // cbCreatorFullName
            // 
            this.cbCreatorFullName.FormattingEnabled = true;
            this.cbCreatorFullName.Items.AddRange(new object[] {
            "Any"});
            this.cbCreatorFullName.Location = new System.Drawing.Point(420, 169);
            this.cbCreatorFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCreatorFullName.Name = "cbCreatorFullName";
            this.cbCreatorFullName.Size = new System.Drawing.Size(238, 31);
            this.cbCreatorFullName.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Creation Date (From):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Creator Full Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 23);
            this.label10.TabIndex = 52;
            this.label10.Text = "Contains (Names and Description):";
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(39, 171);
            this.txtContains.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(344, 30);
            this.txtContains.TabIndex = 48;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Controls.Add(this.cbSolved);
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.btnCancel);
            this.gbFilter.Controls.Add(this.txtContains);
            this.gbFilter.Controls.Add(this.cbSeverity);
            this.gbFilter.Controls.Add(this.label10);
            this.gbFilter.Controls.Add(this.label9);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Controls.Add(this.cbPriority);
            this.gbFilter.Controls.Add(this.label5);
            this.gbFilter.Controls.Add(this.label8);
            this.gbFilter.Controls.Add(this.cbCreatorFullName);
            this.gbFilter.Controls.Add(this.dpLastUpdateTo);
            this.gbFilter.Controls.Add(this.dpCreationDateFrom);
            this.gbFilter.Controls.Add(this.label6);
            this.gbFilter.Controls.Add(this.txtId);
            this.gbFilter.Controls.Add(this.dpLastUpdateFrom);
            this.gbFilter.Controls.Add(this.label4);
            this.gbFilter.Controls.Add(this.label7);
            this.gbFilter.Controls.Add(this.dpCreationDateTo);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbFilter.Location = new System.Drawing.Point(58, 29);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1315, 223);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter:";
            this.gbFilter.Enter += new System.EventHandler(this.gbFilter_Enter);
            // 
            // gbBugs
            // 
            this.gbBugs.Controls.Add(this.dgvAllBugs);
            this.gbBugs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBugs.Location = new System.Drawing.Point(58, 285);
            this.gbBugs.Name = "gbBugs";
            this.gbBugs.Size = new System.Drawing.Size(1315, 365);
            this.gbBugs.TabIndex = 13;
            this.gbBugs.TabStop = false;
            this.gbBugs.Text = "Bugs:";
            // 
            // BugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 740);
            this.Controls.Add(this.gbBugs);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bugs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBugs)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbBugs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAllBugs;
        private Button btnOpen;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnFilter;
        private CheckBox cbSolved;
        private ComboBox cbSeverity;
        private Label label9;
        private ComboBox cbPriority;
        private Label label8;
        private DateTimePicker dpLastUpdateTo;
        private Label label6;
        private DateTimePicker dpLastUpdateFrom;
        private Label label7;
        private DateTimePicker dpCreationDateTo;
        private Label label4;
        private Label label2;
        private TextBox txtId;
        private DateTimePicker dpCreationDateFrom;
        private ComboBox cbCreatorFullName;
        private Label label5;
        private Label label3;
        private Label label10;
        private TextBox txtContains;
        private GroupBox gbFilter;
        private GroupBox gbBugs;
    }
}