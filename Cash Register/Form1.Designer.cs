namespace Cash_Register
{
    partial class totalLable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(totalLable));
            this.storeLable = new System.Windows.Forms.Label();
            this.item1Lable = new System.Windows.Forms.Label();
            this.item2Lable = new System.Windows.Forms.Label();
            this.item3Lable = new System.Windows.Forms.Label();
            this.item1Input = new System.Windows.Forms.TextBox();
            this.item2Input = new System.Windows.Forms.TextBox();
            this.item3Input = new System.Windows.Forms.TextBox();
            this.calcTotalButton = new System.Windows.Forms.Button();
            this.subTotalLable = new System.Windows.Forms.Label();
            this.taxLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subTotalOutPut = new System.Windows.Forms.Label();
            this.taxOutPut = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipOutput = new System.Windows.Forms.Label();
            this.amountTenderedInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            // storeLable
            // 
            this.storeLable.BackColor = System.Drawing.Color.IndianRed;
            this.storeLable.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLable.Location = new System.Drawing.Point(17, 21);
            this.storeLable.Name = "storeLable";
            this.storeLable.Size = new System.Drawing.Size(174, 49);
            this.storeLable.TabIndex = 0;
            this.storeLable.Text = "Store Store";
            // 
            // item1Lable
            // 
            this.item1Lable.AutoSize = true;
            this.item1Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Lable.Location = new System.Drawing.Point(17, 93);
            this.item1Lable.Name = "item1Lable";
            this.item1Lable.Size = new System.Drawing.Size(60, 18);
            this.item1Lable.TabIndex = 1;
            this.item1Lable.Text = "Item #1:";
            // 
            // item2Lable
            // 
            this.item2Lable.AutoSize = true;
            this.item2Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2Lable.Location = new System.Drawing.Point(17, 128);
            this.item2Lable.Name = "item2Lable";
            this.item2Lable.Size = new System.Drawing.Size(60, 18);
            this.item2Lable.TabIndex = 2;
            this.item2Lable.Text = "Item #2:";
            // 
            // item3Lable
            // 
            this.item3Lable.AutoSize = true;
            this.item3Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3Lable.Location = new System.Drawing.Point(17, 164);
            this.item3Lable.Name = "item3Lable";
            this.item3Lable.Size = new System.Drawing.Size(60, 18);
            this.item3Lable.TabIndex = 3;
            this.item3Lable.Text = "Item #3:";
            // 
            // item1Input
            // 
            this.item1Input.Location = new System.Drawing.Point(84, 90);
            this.item1Input.Name = "item1Input";
            this.item1Input.Size = new System.Drawing.Size(38, 20);
            this.item1Input.TabIndex = 4;
            // 
            // item2Input
            // 
            this.item2Input.Location = new System.Drawing.Point(84, 126);
            this.item2Input.Name = "item2Input";
            this.item2Input.Size = new System.Drawing.Size(38, 20);
            this.item2Input.TabIndex = 5;
            // 
            // item3Input
            // 
            this.item3Input.Location = new System.Drawing.Point(84, 165);
            this.item3Input.Name = "item3Input";
            this.item3Input.Size = new System.Drawing.Size(38, 20);
            this.item3Input.TabIndex = 6;
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
            // taxLable
            // 
            this.taxLable.AutoSize = true;
            this.taxLable.Location = new System.Drawing.Point(20, 269);
            this.taxLable.Name = "taxLable";
            this.taxLable.Size = new System.Drawing.Size(28, 13);
            this.taxLable.TabIndex = 9;
            this.taxLable.Text = "Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total:";
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(23, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 11);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tip:";
            // 
            // tipInput
            // 
            this.tipInput.Location = new System.Drawing.Point(126, 350);
            this.tipInput.Name = "tipInput";
            this.tipInput.Size = new System.Drawing.Size(38, 20);
            this.tipInput.TabIndex = 16;
            this.tipInput.TextChanged += new System.EventHandler(this.tipInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "%";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tendered:";
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
            // totalLable
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tipOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutPut);
            this.Controls.Add(this.subTotalOutPut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taxLable);
            this.Controls.Add(this.subTotalLable);
            this.Controls.Add(this.calcTotalButton);
            this.Controls.Add(this.item3Input);
            this.Controls.Add(this.item2Input);
            this.Controls.Add(this.item1Input);
            this.Controls.Add(this.item3Lable);
            this.Controls.Add(this.item2Lable);
            this.Controls.Add(this.item1Lable);
            this.Controls.Add(this.storeLable);
            this.Controls.Add(this.receiptRightCollumn);
            this.Controls.Add(this.receiptLeftColumn);
            this.Controls.Add(this.receiptTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "totalLable";
            this.Text = "Store Store Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeLable;
        private System.Windows.Forms.Label item1Lable;
        private System.Windows.Forms.Label item2Lable;
        private System.Windows.Forms.Label item3Lable;
        private System.Windows.Forms.TextBox item1Input;
        private System.Windows.Forms.TextBox item2Input;
        private System.Windows.Forms.TextBox item3Input;
        private System.Windows.Forms.Button calcTotalButton;
        private System.Windows.Forms.Label subTotalLable;
        private System.Windows.Forms.Label taxLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label subTotalOutPut;
        private System.Windows.Forms.Label taxOutPut;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tipInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tipOutput;
        private System.Windows.Forms.TextBox amountTenderedInput;
        private System.Windows.Forms.Label label8;
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

