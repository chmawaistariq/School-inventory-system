namespace School
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btn_Admission = new System.Windows.Forms.Button();
            this.btn_Tuition_Fees = new System.Windows.Forms.Button();
            this.btn_Teacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Admission
            // 
            this.btn_Admission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admission.Image = ((System.Drawing.Image)(resources.GetObject("btn_Admission.Image")));
            this.btn_Admission.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Admission.Location = new System.Drawing.Point(85, 61);
            this.btn_Admission.Name = "btn_Admission";
            this.btn_Admission.Size = new System.Drawing.Size(245, 300);
            this.btn_Admission.TabIndex = 0;
            this.btn_Admission.Text = "Admission Open";
            this.btn_Admission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Admission.UseVisualStyleBackColor = true;
            this.btn_Admission.Click += new System.EventHandler(this.btn_Admission_Click);
            // 
            // btn_Tuition_Fees
            // 
            this.btn_Tuition_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tuition_Fees.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tuition_Fees.Image")));
            this.btn_Tuition_Fees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Tuition_Fees.Location = new System.Drawing.Point(361, 61);
            this.btn_Tuition_Fees.Name = "btn_Tuition_Fees";
            this.btn_Tuition_Fees.Size = new System.Drawing.Size(245, 300);
            this.btn_Tuition_Fees.TabIndex = 1;
            this.btn_Tuition_Fees.Text = "School Fees";
            this.btn_Tuition_Fees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Tuition_Fees.UseVisualStyleBackColor = true;
            this.btn_Tuition_Fees.Click += new System.EventHandler(this.btn_Tuition_Fees_Click);
            // 
            // btn_Teacher
            // 
            this.btn_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Teacher.Image = ((System.Drawing.Image)(resources.GetObject("btn_Teacher.Image")));
            this.btn_Teacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Teacher.Location = new System.Drawing.Point(624, 61);
            this.btn_Teacher.Name = "btn_Teacher";
            this.btn_Teacher.Size = new System.Drawing.Size(245, 300);
            this.btn_Teacher.TabIndex = 2;
            this.btn_Teacher.Text = "Add Teacher";
            this.btn_Teacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Teacher.UseVisualStyleBackColor = true;
            this.btn_Teacher.Click += new System.EventHandler(this.btn_Teacher_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.btn_Teacher);
            this.Controls.Add(this.btn_Tuition_Fees);
            this.Controls.Add(this.btn_Admission);
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Admission;
        private System.Windows.Forms.Button btn_Tuition_Fees;
        private System.Windows.Forms.Button btn_Teacher;
    }
}