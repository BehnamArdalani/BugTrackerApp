namespace GUILayer
{
    partial class MessageForm
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
            this.cbCreatorFullName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.rbText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbCreatorFullName
            // 
            this.cbCreatorFullName.FormattingEnabled = true;
            this.cbCreatorFullName.Location = new System.Drawing.Point(461, 39);
            this.cbCreatorFullName.Name = "cbCreatorFullName";
            this.cbCreatorFullName.Size = new System.Drawing.Size(152, 23);
            this.cbCreatorFullName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Created Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Creator Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bug Name:";
            // 
            // txtBugName
            // 
            this.txtBugName.Enabled = false;
            this.txtBugName.Location = new System.Drawing.Point(129, 98);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(152, 23);
            this.txtBugName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(277, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dpCreatedDate
            // 
            this.dpCreatedDate.Location = new System.Drawing.Point(461, 95);
            this.dpCreatedDate.Name = "dpCreatedDate";
            this.dpCreatedDate.Size = new System.Drawing.Size(152, 23);
            this.dpCreatedDate.TabIndex = 4;
            // 
            // rbText
            // 
            this.rbText.Location = new System.Drawing.Point(129, 161);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(484, 175);
            this.rbText.TabIndex = 2;
            this.rbText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(129, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(152, 23);
            this.txtId.TabIndex = 0;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.rbText);
            this.Controls.Add(this.dpCreatedDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCreatorFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBugName);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbCreatorFullName;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox txtBugName;
        private Button btnSave;
        private DateTimePicker dpCreatedDate;
        private RichTextBox rbText;
        private Label label1;
        private TextBox txtId;
    }
}