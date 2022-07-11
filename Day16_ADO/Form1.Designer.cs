
namespace Day16_ADO
{
    partial class Form1
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
            this.comboTestScore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GridCandidates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTestScore
            // 
            this.comboTestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTestScore.FormattingEnabled = true;
            this.comboTestScore.Location = new System.Drawing.Point(409, 60);
            this.comboTestScore.Name = "comboTestScore";
            this.comboTestScore.Size = new System.Drawing.Size(256, 33);
            this.comboTestScore.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Test Score Range:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(714, 51);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(131, 42);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GridCandidates
            // 
            this.GridCandidates.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCandidates.Location = new System.Drawing.Point(36, 139);
            this.GridCandidates.Name = "GridCandidates";
            this.GridCandidates.RowHeadersWidth = 62;
            this.GridCandidates.RowTemplate.Height = 28;
            this.GridCandidates.Size = new System.Drawing.Size(841, 327);
            this.GridCandidates.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(965, 520);
            this.Controls.Add(this.GridCandidates);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTestScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCandidates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTestScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView GridCandidates;
    }
}

