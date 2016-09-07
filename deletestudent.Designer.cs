namespace School
{
    partial class deletestudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteStudent = new System.Windows.Forms.Button();
            this.txt_deletestudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DeleteStudent);
            this.groupBox1.Controls.Add(this.txt_deletestudent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Student Details";
            // 
            // btn_DeleteStudent
            // 
            this.btn_DeleteStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DeleteStudent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DeleteStudent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DeleteStudent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DeleteStudent.Location = new System.Drawing.Point(125, 121);
            this.btn_DeleteStudent.Name = "btn_DeleteStudent";
            this.btn_DeleteStudent.Size = new System.Drawing.Size(115, 38);
            this.btn_DeleteStudent.TabIndex = 2;
            this.btn_DeleteStudent.Text = "Delete";
            this.btn_DeleteStudent.UseVisualStyleBackColor = false;
            // 
            // txt_deletestudent
            // 
            this.txt_deletestudent.Location = new System.Drawing.Point(171, 68);
            this.txt_deletestudent.Name = "txt_deletestudent";
            this.txt_deletestudent.Size = new System.Drawing.Size(180, 23);
            this.txt_deletestudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name | ID :";
            // 
            // deletestudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "deletestudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Student Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DeleteStudent;
        private System.Windows.Forms.TextBox txt_deletestudent;
        private System.Windows.Forms.Label label1;
    }
}