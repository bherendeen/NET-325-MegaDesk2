namespace MegaDesk2
{
    partial class AddQuote
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
            this.addQuoteHeader = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.deskWidthBox = new System.Windows.Forms.TextBox();
            this.deskWidthLabel = new System.Windows.Forms.Label();
            this.deskDepthBox = new System.Windows.Forms.TextBox();
            this.deskDepthLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialTypeBox = new System.Windows.Forms.ComboBox();
            this.materialTypeLabel = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            this.shipping = new System.Windows.Forms.Label();
            this.shippingBox = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.getQuoteBtn = new System.Windows.Forms.Button();
            this.numDrawersBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addQuoteHeader
            // 
            this.addQuoteHeader.AutoSize = true;
            this.addQuoteHeader.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteHeader.Location = new System.Drawing.Point(12, 9);
            this.addQuoteHeader.Name = "addQuoteHeader";
            this.addQuoteHeader.Size = new System.Drawing.Size(223, 33);
            this.addQuoteHeader.TabIndex = 0;
            this.addQuoteHeader.Text = "Add a New Quote";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(12, 118);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(145, 23);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameBox.Location = new System.Drawing.Point(199, 119);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(257, 30);
            this.customerNameBox.TabIndex = 1;
            this.customerNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.customerNameBox_Validating);
            // 
            // deskWidthBox
            // 
            this.deskWidthBox.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthBox.Location = new System.Drawing.Point(199, 178);
            this.deskWidthBox.Name = "deskWidthBox";
            this.deskWidthBox.Size = new System.Drawing.Size(257, 30);
            this.deskWidthBox.TabIndex = 2;
            this.deskWidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.deskWidthBox_Validating);
            // 
            // deskWidthLabel
            // 
            this.deskWidthLabel.AutoSize = true;
            this.deskWidthLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthLabel.Location = new System.Drawing.Point(12, 177);
            this.deskWidthLabel.Name = "deskWidthLabel";
            this.deskWidthLabel.Size = new System.Drawing.Size(104, 23);
            this.deskWidthLabel.TabIndex = 3;
            this.deskWidthLabel.Text = "Desk Width:";
            // 
            // deskDepthBox
            // 
            this.deskDepthBox.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthBox.Location = new System.Drawing.Point(199, 219);
            this.deskDepthBox.Name = "deskDepthBox";
            this.deskDepthBox.Size = new System.Drawing.Size(257, 30);
            this.deskDepthBox.TabIndex = 3;
            this.deskDepthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deskDepthBox_KeyPress);
            this.deskDepthBox.Validating += new System.ComponentModel.CancelEventHandler(this.deskDepthBox_Validating);
            // 
            // deskDepthLabel
            // 
            this.deskDepthLabel.AutoSize = true;
            this.deskDepthLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthLabel.Location = new System.Drawing.Point(12, 218);
            this.deskDepthLabel.Name = "deskDepthLabel";
            this.deskDepthLabel.Size = new System.Drawing.Size(106, 23);
            this.deskDepthLabel.TabIndex = 5;
            this.deskDepthLabel.Text = "Desk Depth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Drawers:";
            // 
            // materialTypeBox
            // 
            this.materialTypeBox.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTypeBox.FormattingEnabled = true;
            this.materialTypeBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialTypeBox.Location = new System.Drawing.Point(199, 338);
            this.materialTypeBox.Name = "materialTypeBox";
            this.materialTypeBox.Size = new System.Drawing.Size(257, 31);
            this.materialTypeBox.TabIndex = 5;
            this.materialTypeBox.Text = "Select a Martial Type";
            // 
            // materialTypeLabel
            // 
            this.materialTypeLabel.AutoSize = true;
            this.materialTypeLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTypeLabel.Location = new System.Drawing.Point(12, 336);
            this.materialTypeLabel.Name = "materialTypeLabel";
            this.materialTypeLabel.Size = new System.Drawing.Size(121, 23);
            this.materialTypeLabel.TabIndex = 10;
            this.materialTypeLabel.Text = "Material Type:";
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(14, 74);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(47, 23);
            this.currentDate.TabIndex = 11;
            this.currentDate.Text = "Date";
            // 
            // shipping
            // 
            this.shipping.AutoSize = true;
            this.shipping.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipping.Location = new System.Drawing.Point(12, 391);
            this.shipping.Name = "shipping";
            this.shipping.Size = new System.Drawing.Size(81, 23);
            this.shipping.TabIndex = 13;
            this.shipping.Text = "Shipping:";
            // 
            // shippingBox
            // 
            this.shippingBox.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingBox.FormattingEnabled = true;
            this.shippingBox.Items.AddRange(new object[] {
            "3 Days (Rush)",
            "5 Days (Rush)",
            "7 Days (Rush)",
            "14 Days (Standard)"});
            this.shippingBox.Location = new System.Drawing.Point(199, 393);
            this.shippingBox.Name = "shippingBox";
            this.shippingBox.Size = new System.Drawing.Size(257, 31);
            this.shippingBox.TabIndex = 6;
            this.shippingBox.Text = "Select a Shipping Method";
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = true;
            this.mainMenu.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(132, 509);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(114, 33);
            this.mainMenu.TabIndex = 8;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(13, 451);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 18);
            this.errorLabel.TabIndex = 0;
            // 
            // getQuoteBtn
            // 
            this.getQuoteBtn.AutoSize = true;
            this.getQuoteBtn.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteBtn.Location = new System.Drawing.Point(12, 509);
            this.getQuoteBtn.Name = "getQuoteBtn";
            this.getQuoteBtn.Size = new System.Drawing.Size(114, 33);
            this.getQuoteBtn.TabIndex = 7;
            this.getQuoteBtn.Text = "Get Quote";
            this.getQuoteBtn.UseVisualStyleBackColor = true;
            this.getQuoteBtn.Click += new System.EventHandler(this.getQuoteBtn_Click);
            // 
            // numDrawersBox
            // 
            this.numDrawersBox.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numDrawersBox.FormattingEnabled = true;
            this.numDrawersBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numDrawersBox.Location = new System.Drawing.Point(199, 280);
            this.numDrawersBox.Name = "numDrawersBox";
            this.numDrawersBox.Size = new System.Drawing.Size(257, 31);
            this.numDrawersBox.TabIndex = 4;
            this.numDrawersBox.Text = "Select Number of Drawers";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 554);
            this.Controls.Add(this.numDrawersBox);
            this.Controls.Add(this.getQuoteBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.shipping);
            this.Controls.Add(this.shippingBox);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.materialTypeLabel);
            this.Controls.Add(this.materialTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deskDepthBox);
            this.Controls.Add(this.deskDepthLabel);
            this.Controls.Add(this.deskWidthBox);
            this.Controls.Add(this.deskWidthLabel);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.addQuoteHeader);
            this.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addQuoteHeader;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox deskWidthBox;
        private System.Windows.Forms.Label deskWidthLabel;
        private System.Windows.Forms.TextBox deskDepthBox;
        private System.Windows.Forms.Label deskDepthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox materialTypeBox;
        private System.Windows.Forms.Label materialTypeLabel;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label shipping;
        private System.Windows.Forms.ComboBox shippingBox;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button getQuoteBtn;
        private System.Windows.Forms.ComboBox numDrawersBox;
    }
}