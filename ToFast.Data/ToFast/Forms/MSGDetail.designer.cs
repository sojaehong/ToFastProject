﻿namespace ToFast
{
    partial class MSGDetail
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
            this.components = new System.ComponentModel.Container();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbContext = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.questionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluation = new ToFast.Controls.Evaluation();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Location = new System.Drawing.Point(490, 315);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 24);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "내보내기(.txt)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(490, 275);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 24);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "확 인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbContext
            // 
            this.tbContext.Location = new System.Drawing.Point(19, 63);
            this.tbContext.Margin = new System.Windows.Forms.Padding(2);
            this.tbContext.Multiline = true;
            this.tbContext.Name = "tbContext";
            this.tbContext.Size = new System.Drawing.Size(449, 277);
            this.tbContext.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToFast.Properties.Resources.KakaoTalk_20180424_150106837;
            this.pictureBox1.Location = new System.Drawing.Point(19, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(83, 35);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 12);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "lbName";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(197, 35);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTime.Size = new System.Drawing.Size(30, 12);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Date";
            // 
            // questionViewBindingSource
            // 
            this.questionViewBindingSource.DataSource = typeof(ToFast.Data.QuestionView);
            // 
            // evaluation
            // 
            this.evaluation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.evaluation.Location = new System.Drawing.Point(477, 63);
            this.evaluation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaluation.Name = "evaluation";
            this.evaluation.Size = new System.Drawing.Size(136, 103);
            this.evaluation.TabIndex = 0;
            // 
            // MSGDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 363);
            this.Controls.Add(this.evaluation);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbContext);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MSGDetail";
            this.Text = "MSGDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.BindingSource questionViewBindingSource;
        private System.Windows.Forms.TextBox tbContext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTime;
        private Controls.Evaluation evaluation;
    }
}