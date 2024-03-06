namespace Cash_Register
{
    partial class totalLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(totalLabel));
            this.storeLabel = new System.Windows.Forms.Label();
            this.item1Label = new System.Windows.Forms.Label();
            this.item2Label = new System.Windows.Forms.Label();
            this.item3Label = new System.Windows.Forms.Label();
            this.appleInput = new System.Windows.Forms.TextBox();
            this.humanInput = new System.Windows.Forms.TextBox();
            this.chairInput = new System.Windows.Forms.TextBox();
            this.calcTotalButton = new System.Windows.Forms.Button();
            this.subTotalLable = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalBeforeTaxLabel = new System.Windows.Forms.Label();
            this.subTotalOutPut = new System.Windows.Forms.Label();
            this.taxOutPut = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.stopperLable = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.tipInput = new System.Windows.Forms.TextBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.tipOutput = new System.Windows.Forms.Label();
            this.amountTenderedInput = new System.Windows.Forms.TextBox();
            this.TenderedLabel = new System.Windows.Forms.Label();
            this.calcChangeButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.exactChangeButton = new System.Windows.Forms.Button();
            this.receiptTitle = new System.Windows.Forms.Label();
            this.receiptLeftColumn = new System.Windows.Forms.Label();
            this.receiptRightCollumn = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.receiptFooter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storeLabel
            // 
            this.storeLabel.BackColor = System.Drawing.Color.IndianRed;
            this.storeLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.Location = new System.Drawing.Point(17, 21);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(174, 49);
            this.storeLabel.TabIndex = 0;
            this.storeLabel.Text = "Store Store";
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Label.Location = new System.Drawing.Point(17, 93);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(48, 18);
            this.item1Label.TabIndex = 1;
            this.item1Label.Text = "Apple:";
            // 
            // item2Label
            // 
            this.item2Label.AutoSize = true;
            this.item2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2Label.Location = new System.Drawing.Point(17, 128);
            this.item2Label.Name = "item2Label";
            this.item2Label.Size = new System.Drawing.Size(60, 18);
            this.item2Label.TabIndex = 2;
            this.item2Label.Text = "Human:";
            // 
            // item3Label
            // 
            this.item3Label.AutoSize = true;
            this.item3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3Label.Location = new System.Drawing.Point(17, 164);
            this.item3Label.Name = "item3Label";
            this.item3Label.Size = new System.Drawing.Size(47, 18);
            this.item3Label.TabIndex = 3;
            this.item3Label.Text = "Chair:";
            // 
            // appleInput
            // 
            this.appleInput.Location = new System.Drawing.Point(84, 90);
            this.appleInput.Name = "appleInput";
            this.appleInput.Size = new System.Drawing.Size(38, 20);
            this.appleInput.TabIndex = 4;
            // 
            // humanInput
            // 
            this.humanInput.Location = new System.Drawing.Point(84, 126);
            this.humanInput.Name = "humanInput";
            this.humanInput.Size = new System.Drawing.Size(38, 20);
            this.humanInput.TabIndex = 5;
            // 
            // chairInput
            // 
            this.chairInput.Location = new System.Drawing.Point(84, 165);
            this.chairInput.Name = "chairInput";
            this.chairInput.Size = new System.Drawing.Size(38, 20);
            this.chairInput.TabIndex = 6;
            // 
            // calcTotalButton
            // 
            this.calcTotalButton.AutoSize = true;
            this.calcTotalButton.Location = new System.Drawing.Point(20, 201);
            this.calcTotalButton.Name = "calcTotalButton";
            this.calcTotalButton.Size = new System.Drawing.Size(171, 23);
            this.calcTotalButton.TabIndex = 7;
            this.calcTotalButton.Text = "Calc Total";
            this.calcTotalButton.UseVisualStyleBackColor = true;
            this.calcTotalButton.Click += new System.EventHandler(this.calcTotalButton_Click);
            // 
            // subTotalLable
            // 
            this.subTotalLable.AutoSize = true;
            this.subTotalLable.Location = new System.Drawing.Point(20, 239);
            this.subTotalLable.Name = "subTotalLable";
            this.subTotalLable.Size = new System.Drawing.Size(49, 13);
            this.subTotalLable.TabIndex = 8;
            this.subTotalLable.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(20, 269);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // totalBeforeTaxLabel
            // 
            this.totalBeforeTaxLabel.AutoSize = true;
            this.totalBeforeTaxLabel.Location = new System.Drawing.Point(20, 300);
            this.totalBeforeTaxLabel.Name = "totalBeforeTaxLabel";
            this.totalBeforeTaxLabel.Size = new System.Drawing.Size(34, 13);
            this.totalBeforeTaxLabel.TabIndex = 10;
            this.totalBeforeTaxLabel.Text = "Total:";
            // 
            // subTotalOutPut
            // 
            this.subTotalOutPut.BackColor = System.Drawing.SystemColors.Control;
            this.subTotalOutPut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subTotalOutPut.Location = new System.Drawing.Point(105, 238);
            this.subTotalOutPut.Name = "subTotalOutPut";
            this.subTotalOutPut.Size = new System.Drawing.Size(86, 13);
            this.subTotalOutPut.TabIndex = 11;
            this.subTotalOutPut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxOutPut
            // 
            this.taxOutPut.BackColor = System.Drawing.SystemColors.Control;
            this.taxOutPut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taxOutPut.Location = new System.Drawing.Point(105, 269);
            this.taxOutPut.Name = "taxOutPut";
            this.taxOutPut.Size = new System.Drawing.Size(86, 13);
            this.taxOutPut.TabIndex = 12;
            this.taxOutPut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.totalOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalOutput.Location = new System.Drawing.Point(105, 300);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(86, 13);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stopperLable
            // 
            this.stopperLable.BackColor = System.Drawing.SystemColors.Desktop;
            this.stopperLable.Location = new System.Drawing.Point(23, 330);
            this.stopperLable.Name = "stopperLable";
            this.stopperLable.Size = new System.Drawing.Size(168, 11);
            this.stopperLable.TabIndex = 14;
            this.stopperLable.Text = "label3";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.Location = new System.Drawing.Point(23, 350);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(32, 18);
            this.tipLabel.TabIndex = 15;
            this.tipLabel.Text = "Tip:";
            // 
            // tipInput
            // 
            this.tipInput.Location = new System.Drawing.Point(126, 350);
            this.tipInput.Name = "tipInput";
            this.tipInput.Size = new System.Drawing.Size(38, 20);
            this.tipInput.TabIndex = 16;
            this.tipInput.TextChanged += new System.EventHandler(this.tipInput_TextChanged);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.Location = new System.Drawing.Point(170, 353);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(21, 18);
            this.percentLabel.TabIndex = 17;
            this.percentLabel.Text = "%";
            // 
            // tipOutput
            // 
            this.tipOutput.AutoSize = true;
            this.tipOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipOutput.Location = new System.Drawing.Point(26, 368);
            this.tipOutput.Name = "tipOutput";
            this.tipOutput.Size = new System.Drawing.Size(0, 13);
            this.tipOutput.TabIndex = 19;
            // 
            // amountTenderedInput
            // 
            this.amountTenderedInput.Location = new System.Drawing.Point(126, 388);
            this.amountTenderedInput.Name = "amountTenderedInput";
            this.amountTenderedInput.Size = new System.Drawing.Size(38, 20);
            this.amountTenderedInput.TabIndex = 21;
            // 
            // TenderedLabel
            // 
            this.TenderedLabel.AutoSize = true;
            this.TenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenderedLabel.Location = new System.Drawing.Point(23, 387);
            this.TenderedLabel.Name = "TenderedLabel";
            this.TenderedLabel.Size = new System.Drawing.Size(74, 18);
            this.TenderedLabel.TabIndex = 20;
            this.TenderedLabel.Text = "Tendered:";
            // 
            // calcChangeButton
            // 
            this.calcChangeButton.Enabled = false;
            this.calcChangeButton.Location = new System.Drawing.Point(25, 414);
            this.calcChangeButton.Name = "calcChangeButton";
            this.calcChangeButton.Size = new System.Drawing.Size(72, 22);
            this.calcChangeButton.TabIndex = 22;
            this.calcChangeButton.Text = "Calculate Change";
            this.calcChangeButton.UseVisualStyleBackColor = true;
            this.calcChangeButton.Click += new System.EventHandler(this.calcChangeButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(26, 443);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 13);
            this.changeOutput.TabIndex = 23;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Enabled = false;
            this.printReceiptButton.Location = new System.Drawing.Point(26, 472);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(165, 22);
            this.printReceiptButton.TabIndex = 24;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // exactChangeButton
            // 
            this.exactChangeButton.Enabled = false;
            this.exactChangeButton.Location = new System.Drawing.Point(108, 414);
            this.exactChangeButton.Name = "exactChangeButton";
            this.exactChangeButton.Size = new System.Drawing.Size(81, 22);
            this.exactChangeButton.TabIndex = 25;
            this.exactChangeButton.Text = "Exact change";
            this.exactChangeButton.UseVisualStyleBackColor = true;
            this.exactChangeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // receiptTitle
            // 
            this.receiptTitle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.receiptTitle.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTitle.Location = new System.Drawing.Point(239, 90);
            this.receiptTitle.Name = "receiptTitle";
            this.receiptTitle.Size = new System.Drawing.Size(320, 36);
            this.receiptTitle.TabIndex = 26;
            this.receiptTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptLeftColumn
            // 
            this.receiptLeftColumn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.receiptLeftColumn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLeftColumn.Location = new System.Drawing.Point(239, 126);
            this.receiptLeftColumn.Name = "receiptLeftColumn";
            this.receiptLeftColumn.Size = new System.Drawing.Size(159, 368);
            this.receiptLeftColumn.TabIndex = 27;
            // 
            // receiptRightCollumn
            // 
            this.receiptRightCollumn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.receiptRightCollumn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptRightCollumn.Location = new System.Drawing.Point(394, 126);
            this.receiptRightCollumn.Name = "receiptRightCollumn";
            this.receiptRightCollumn.Size = new System.Drawing.Size(165, 368);
            this.receiptRightCollumn.TabIndex = 28;
            this.receiptRightCollumn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Enabled = false;
            this.newOrderButton.Location = new System.Drawing.Point(329, 501);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(165, 22);
            this.newOrderButton.TabIndex = 29;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // receiptFooter
            // 
            this.receiptFooter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.receiptFooter.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptFooter.Location = new System.Drawing.Point(239, 443);
            this.receiptFooter.Name = "receiptFooter";
            this.receiptFooter.Size = new System.Drawing.Size(320, 51);
            this.receiptFooter.TabIndex = 30;
            this.receiptFooter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 535);
            this.Controls.Add(this.receiptFooter);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.exactChangeButton);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.calcChangeButton);
            this.Controls.Add(this.amountTenderedInput);
            this.Controls.Add(this.TenderedLabel);
            this.Controls.Add(this.tipOutput);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.tipInput);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.stopperLable);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutPut);
            this.Controls.Add(this.subTotalOutPut);
            this.Controls.Add(this.totalBeforeTaxLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLable);
            this.Controls.Add(this.calcTotalButton);
            this.Controls.Add(this.chairInput);
            this.Controls.Add(this.humanInput);
            this.Controls.Add(this.appleInput);
            this.Controls.Add(this.item3Label);
            this.Controls.Add(this.item2Label);
            this.Controls.Add(this.item1Label);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.receiptRightCollumn);
            this.Controls.Add(this.receiptLeftColumn);
            this.Controls.Add(this.receiptTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "totalLabel";
            this.Text = "Store Store Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.Label item1Label;
        private System.Windows.Forms.Label item2Label;
        private System.Windows.Forms.Label item3Label;
        private System.Windows.Forms.TextBox appleInput;
        private System.Windows.Forms.TextBox humanInput;
        private System.Windows.Forms.TextBox chairInput;
        private System.Windows.Forms.Button calcTotalButton;
        private System.Windows.Forms.Label subTotalLable;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalBeforeTaxLabel;
        private System.Windows.Forms.Label subTotalOutPut;
        private System.Windows.Forms.Label taxOutPut;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label stopperLable;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.TextBox tipInput;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label tipOutput;
        private System.Windows.Forms.TextBox amountTenderedInput;
        private System.Windows.Forms.Label TenderedLabel;
        private System.Windows.Forms.Button calcChangeButton;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button exactChangeButton;
        private System.Windows.Forms.Label receiptTitle;
        private System.Windows.Forms.Label receiptLeftColumn;
        private System.Windows.Forms.Label receiptRightCollumn;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label receiptFooter;
    }
}

