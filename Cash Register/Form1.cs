using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{

    public partial class totalLable : Form
    {
       

        double item1Price = 10.99;
        double item2Price = 5.45;
        double item3Price = 0.99;

        int numItem1;
        int numItem2;
        int numItem3;

        bool easterEgg;

        double hst = 0.13;

        double subtotal;
        double taxAmmount;
        double taxTotal;
        double tip;
        double tipAmmount;
        double total;

        bool tipBool;

        bool exactChange;
        double ammountTendered;
        double change;

        int orderNumber;

        //Varibles

        public totalLable()
        {
            InitializeComponent();
            this.Size = new Size(231, 574);
            storeLable.Size = new Size(174, 49);

            //Setting up sizes on start
        }

        private void calcTotalButton_Click(object sender, EventArgs e)
        {
            if (item1Input.Text != "")
            {
                try
                {
                    numItem1 = Convert.ToInt16(item1Input.Text);
                }
                catch
                {
                    item1Input.Text = "INT";
                }
            }
            else
            {
                item1Input.Text = "N/A";
            }

            if (item2Input.Text != "")
            {
                try
                {
                    numItem2 = Convert.ToInt16(item2Input.Text);
                }
                catch
                {
                    item2Input.Text = "INT";
                }
            }
            else
            {
                item2Input.Text = "N/A";
            }

            if (item3Input.Text != "")
            {
                try
                {
                    numItem3 = Convert.ToInt16(item3Input.Text);
                }
                catch
                {
                    item3Input.Text = "INT";
                }
            }
            else
            {
                item3Input.Text = "N/A";
            }

            //Figuring out numbers of orders

            if (numItem1 == 1 && numItem2 == 3 && numItem3 == 3)
            {
                easterEgg = true;
            }

            //Easter egg!

            subtotal = item1Price * (double)numItem1 + item2Price * (double)numItem2 + item3Price * (double)numItem3;
            taxAmmount = (subtotal * hst);
            taxTotal = taxAmmount + subtotal;
            total = taxAmmount;

            //Calculations

            subTotalOutPut.Text = $"${subtotal}";
            taxOutPut.Text = $"${taxAmmount}";
            totalOutput.Text = $"${taxTotal}";

            //Outputs

            if (total != 0)
            {
                calcChangeButton.Enabled = true;
                exactChangeButton.Enabled = true;
            }

            //Enabling buttons

        }

        private void tipInput_TextChanged(object sender, EventArgs e)
        {
            if (tipInput.Text != "")
            {
                try
                {
                    tip = Convert.ToDouble(tipInput.Text);

                    tipAmmount = subtotal * (tip / 100);
                    tipBool = true;
                }
                catch
                {
                    tipInput.Text = "INT";
                }

                tipOutput.Text = $"${taxTotal + tipAmmount} (+${tipAmmount})";
                total = taxTotal + tipAmmount;
            }
            else
            {
                tipOutput.Text = "";
            }

            //Tip
        }

        private void calcChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ammountTendered = Convert.ToDouble(amountTenderedInput.Text);

                if (ammountTendered < total)
                {
                    changeOutput.Text = "Must be >= total";
                }
                if (ammountTendered == total)
                {
                    changeOutput.Text = "No change";
                    exactChange = true;
                    printReceiptButton.Enabled = true;
                    exactChangeButton.Enabled = false;

                    SoundPlayer open = new SoundPlayer(Properties.Resources.cash_register_open);
                    open.Play();
                }
                if (ammountTendered > total)
                {
                    changeOutput.Text = $"Change: ${ammountTendered - total}";
                    exactChange = false;
                    printReceiptButton.Enabled = true;
                    exactChangeButton.Enabled = false;

                    SoundPlayer open = new SoundPlayer(Properties.Resources.cash_register_open);
                    open.Play();
                }

            }
            catch
            {
                amountTenderedInput.Text = "INT";
            }

            //Makin' change
        }

        private void button2_Click(object sender, EventArgs e) //
        {
            exactChange = true;
            changeOutput.Text = "No change";
            calcChangeButton.Enabled = false;
            printReceiptButton.Enabled = true;

            SoundPlayer open = new SoundPlayer(Properties.Resources.cash_register_open);
            open.Play();

            //Exact change
        }

        private void printReceiptButton_Click(object sender, EventArgs e) //Prints everything
        {
            int delayAmmount = 125;

            //Default delay time

            storeLable.Size = new Size(538, 49);
            this.Size = new Size(589, 574);

            //Changing size

            SoundPlayer print = new SoundPlayer(Properties.Resources.Cash_Register_Sound_FX);
            print.Play();

            //Audio

            receiptTitle.Text = $"Store Store";
            Thread.Sleep(250);
            this.Refresh();

            if (numItem1 != 0)
            {
                receiptLeftColumn.Text += $"\nItem #1:";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\nx{numItem1} (${numItem1 * item1Price})";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }
            if (numItem2 != 0)
            {
                receiptLeftColumn.Text += $"\nItem #2:";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\nx{numItem2} (${numItem2 * item2Price})";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }
            if (numItem3 != 0)
            {
                receiptLeftColumn.Text += $"\nItem #3: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\nx{numItem3} (${numItem3 * item3Price})";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }


            receiptLeftColumn.Text += $"\n\nSubtotal: ";
            Thread.Sleep(delayAmmount);
            this.Refresh();
            receiptRightCollumn.Text += $"\n\n${subtotal}";
            Thread.Sleep(delayAmmount);
            this.Refresh();

            receiptLeftColumn.Text += $"\nTax: ";
            Thread.Sleep(delayAmmount);
            this.Refresh();
            receiptRightCollumn.Text += $"\n${taxAmmount}";
            Thread.Sleep(delayAmmount);
            this.Refresh();

            receiptLeftColumn.Text += $"\nTotal: ";
            Thread.Sleep(delayAmmount);
            this.Refresh();
            receiptRightCollumn.Text += $"\n${taxTotal}";
            Thread.Sleep(delayAmmount);
            this.Refresh();

            if (tipBool == true)
            {
                receiptLeftColumn.Text += $"\n\nTip%: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\n\n{tip}%";
                Thread.Sleep(delayAmmount);
                this.Refresh();

                receiptLeftColumn.Text += $"\nTip: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\n${tipAmmount}";
                Thread.Sleep(delayAmmount);
                this.Refresh();

                receiptLeftColumn.Text += $"\nTotal: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\n${total}";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }

            if (exactChange == true)
            {
                receiptLeftColumn.Text += $"\n\nTendered: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\n\nEXACT CHANGE";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }
            if (exactChange == false)
            {
                receiptLeftColumn.Text += $"\n\nTendered: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\n\n${ammountTendered}";
                Thread.Sleep(delayAmmount);
                this.Refresh();

                receiptLeftColumn.Text += $"\n\nChange: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\n\n${ammountTendered - total}";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }

            orderNumber += 1;
            receiptFooter.Text = $"Order Number: {orderNumber}";

            if (easterEgg == true) //Easter Egg!
            {
                receiptFooter.Text += $"\n1, 2, 3!";
            }
            else
            {
                receiptFooter.Text += $"\nHave a great day!";
            }

            print.Stop();
            newOrderButton.Enabled = true;
        }

        private void newOrderButton_Click(object sender, EventArgs e) //Resets everything
        {
            newOrderButton.Enabled = false;

            this.Size = new Size(231, 574);
            storeLable.Size = new Size(174, 49);

            item1Input.Text = "";
            item2Input.Text = "";
            item3Input.Text = "";

            subTotalOutPut.Text = "";
            taxOutPut.Text = "";
            totalOutput.Text = "";

            tipInput.Text = "";
            amountTenderedInput.Text = "";

            calcChangeButton.Enabled = false;
            exactChangeButton.Enabled = false;
            printReceiptButton.Enabled = false;

            receiptTitle.Text = "";
            receiptLeftColumn.Text = "";
            receiptRightCollumn.Text = "";
            receiptFooter.Text = "";

            //Resets everything
        }
    }
}
