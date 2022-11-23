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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewMessage = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllBugs
            // 
            this.dgvAllBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBugs.Location = new System.Drawing.Point(35, 72);
            this.dgvAllBugs.MultiSelect = false;
            this.dgvAllBugs.Name = "dgvAllBugs";
            this.dgvAllBugs.ReadOnly = true;
            this.dgvAllBugs.RowTemplate.Height = 25;
            this.dgvAllBugs.Size = new System.Drawing.Size(724, 488);
            this.dgvAllBugs.TabIndex = 0;
            this.dgvAllBugs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBugs_CellClick);
            this.dgvAllBugs.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBugs_CellMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "All reported bugs:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(342, 579);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(438, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(534, 579);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(778, 72);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.RowTemplate.Height = 25;
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(307, 217);
            this.dgvMessages.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(778, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Related messages:";
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.Location = new System.Drawing.Point(630, 579);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(90, 37);
            this.btnNewMessage.TabIndex = 7;
            this.btnNewMessage.Text = "New Message";
            this.btnNewMessage.UseVisualStyleBackColor = true;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(778, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(307, 218);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(778, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Logs:";
            // 
            // BugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 648);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnNewMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllBugs);
            this.Name = "BugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bugs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAllBugs;
        private Label label1;
        private Button btnEdit;
        private Button btnSave;
        private Button btnCancel;
        private DataGridView dgvMessages;
        private Label label2;
        private Button btnNewMessage;
        private RichTextBox richTextBox1;
        private Label label3;
    }
}