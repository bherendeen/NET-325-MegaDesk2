namespace MegaDesk2
{
    partial class AllQuotes
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
            this.allQuote_Return_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // allQuote_Return_Btn
            // 
            this.allQuote_Return_Btn.Location = new System.Drawing.Point(302, 408);
            this.allQuote_Return_Btn.Name = "allQuote_Return_Btn";
            this.allQuote_Return_Btn.Size = new System.Drawing.Size(75, 23);
            this.allQuote_Return_Btn.TabIndex = 0;
            this.allQuote_Return_Btn.Text = "Back";
            this.allQuote_Return_Btn.UseVisualStyleBackColor = true;
            this.allQuote_Return_Btn.Click += new System.EventHandler(this.allQuote_Return_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 339);
            this.dataGridView1.TabIndex = 1;
            // 
            // AllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.allQuote_Return_Btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allQuote_Return_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}