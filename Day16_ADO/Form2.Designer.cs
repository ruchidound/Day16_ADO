
namespace Day16_ADO
{
    partial class Form2
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
            this.DtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTToDate = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GridSalary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date:";
            // 
            // DtFromDate
            // 
            this.DtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFromDate.Location = new System.Drawing.Point(156, 65);
            this.DtFromDate.Name = "DtFromDate";
            this.DtFromDate.Size = new System.Drawing.Size(200, 26);
            this.DtFromDate.TabIndex = 1;
            this.DtFromDate.Value = new System.DateTime(1999, 7, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date:";
            // 
            // DTToDate
            // 
            this.DTToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTToDate.Location = new System.Drawing.Point(524, 64);
            this.DTToDate.Name = "DTToDate";
            this.DTToDate.Size = new System.Drawing.Size(200, 26);
            this.DTToDate.TabIndex = 3;
            this.DTToDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(759, 50);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(132, 51);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GridSalary
            // 
            this.GridSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSalary.Location = new System.Drawing.Point(33, 162);
            this.GridSalary.Name = "GridSalary";
            this.GridSalary.RowHeadersWidth = 62;
            this.GridSalary.RowTemplate.Height = 28;
            this.GridSalary.Size = new System.Drawing.Size(882, 366);
            this.GridSalary.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 577);
            this.Controls.Add(this.GridSalary);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DTToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtFromDate);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTToDate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView GridSalary;
    }
}