﻿namespace Task5
{
    partial class Form3
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
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.labelAvg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(29, 30);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(218, 13);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Номер максимального елемента масива";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(269, 27);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(419, 24);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Генерувати";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(19, 83);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(526, 116);
            this.dataGridViewArray.TabIndex = 3;
            // 
            // buttonAvg
            // 
            this.buttonAvg.Location = new System.Drawing.Point(19, 205);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Size = new System.Drawing.Size(526, 23);
            this.buttonAvg.TabIndex = 4;
            this.buttonAvg.Text = "Розв\'язок максимального елемента";
            this.buttonAvg.UseVisualStyleBackColor = true;
            this.buttonAvg.Click += new System.EventHandler(this.buttonAvg_Click);
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(19, 337);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(58, 13);
            this.labelAvg.TabIndex = 5;
            this.labelAvg.Text = "Розв\'язок";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 362);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.buttonAvg);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Label labelAvg;
    }
}