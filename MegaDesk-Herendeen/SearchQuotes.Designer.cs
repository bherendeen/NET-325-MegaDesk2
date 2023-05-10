namespace MegaDesk2
{
    partial class SearchQuotes
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
            this.searchQuote_Return_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchQuote_Return_Btn
            // 
            this.searchQuote_Return_Btn.Location = new System.Drawing.Point(257, 308);
            this.searchQuote_Return_Btn.Name = "searchQuote_Return_Btn";
            this.searchQuote_Return_Btn.Size = new System.Drawing.Size(75, 23);
            this.searchQuote_Return_Btn.TabIndex = 0;
            this.searchQuote_Return_Btn.Text = "Return";
            this.searchQuote_Return_Btn.UseVisualStyleBackColor = true;
            this.searchQuote_Return_Btn.Click += new System.EventHandler(this.searchQuote_Return_Btn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.searchQuote_Return_Btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchQuote_Return_Btn;
    }
}