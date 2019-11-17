namespace DoAnCK_TTA.GUI
{
    partial class frmSaoLuu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pgbBackup = new System.Windows.Forms.ProgressBar();
            this.txtFIle = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnCLose = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcute = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(159, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sao lưu dự phòng dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiến trình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tập tin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đường dẫn:";
            // 
            // pgbBackup
            // 
            this.pgbBackup.Location = new System.Drawing.Point(123, 52);
            this.pgbBackup.Name = "pgbBackup";
            this.pgbBackup.Size = new System.Drawing.Size(336, 23);
            this.pgbBackup.TabIndex = 2;
            // 
            // txtFIle
            // 
            this.txtFIle.Location = new System.Drawing.Point(123, 81);
            this.txtFIle.Name = "txtFIle";
            this.txtFIle.Size = new System.Drawing.Size(336, 22);
            this.txtFIle.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(123, 109);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(336, 22);
            this.txtPath.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(123, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Ghi đè tập tin cũ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnCLose
            // 
            this.btnCLose.ImageOptions.Image = global::DoAnCK_TTA.Properties.Resources.cancel_32x321;
            this.btnCLose.ImageOptions.ImageUri.Uri = "Apply";
            this.btnCLose.Location = new System.Drawing.Point(361, 145);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(98, 32);
            this.btnCLose.TabIndex = 6;
            this.btnCLose.Text = "Đóng";
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnExcute
            // 
            this.btnExcute.ImageOptions.Image = global::DoAnCK_TTA.Properties.Resources.apply_32x321;
            this.btnExcute.ImageOptions.ImageUri.Uri = "Apply";
            this.btnExcute.Location = new System.Drawing.Point(248, 145);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(102, 32);
            this.btnExcute.TabIndex = 7;
            this.btnExcute.Text = "Thực hiện";
            // 
            // frmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 189);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtFIle);
            this.Controls.Add(this.pgbBackup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaoLuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pgbBackup;
        private System.Windows.Forms.TextBox txtFIle;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SimpleButton btnCLose;
        private DevExpress.XtraEditors.SimpleButton btnExcute;
    }
}