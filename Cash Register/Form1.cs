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



/*
 * 
   ____    _    ____  _   _   ____  _____ ____ ___ ____ _____ _____ ____  
  / ___|  / \  / ___|| | | | |  _ \| ____/ ___|_ _/ ___|_   _| ____|  _ \ 
 | |     / _ \ \___ \| |_| | | |_) |  _|| |  _ | |\___ \ | | |  _| | |_) |
 | |___ / ___ \ ___) |  _  | |  _ <| |__| |_| || | ___) || | | |___|  _ < 
  \____/_/   \_\____/|_| |_| |_| \_\_____\____|___|____/ |_| |_____|_| \_\
                                                                          
    Ewan Redgrift
    2024/03/06
    Cash Register for Store Store
 * 
 */

namespace Cash_Register
{

    public partial class totalLabel : Form
    {
       

        double item1PriceApple = 10.99;
        double item2PriceHuman = 5.45;
        double item3PriceChair = 0.99;

        int numItem1Apple;
        int numItem2Human;
        int numItem3Chair;

        double item1TotalApple;
        double item2TotalHuman;
        double item3TotalChair;

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

        public totalLabel()
        {
            InitializeComponent();
            this.Size = new Size(231, 574);
            storeLabel.Size = new Size(174, 49);

            //Setting up sizes on start
        }

        private void calcTotalButton_Click(object sender, EventArgs e)
        {
            if (appleInput.Text != "")
            {
                try
                {
                    numItem1Apple = Convert.ToInt16(appleInput.Text);
                    item1TotalApple = numItem1Apple * item1PriceApple;
                }
                catch
                {
                    appleInput.Text = "INT";
                }
            }
            else
            {
                appleInput.Text = "N/A";
            }

            if (humanInput.Text != "")
            {
                try
                {
                    numItem2Human = Convert.ToInt16(humanInput.Text);
                    item2TotalHuman = numItem2Human * item2PriceHuman;
                }
                catch
                {
                    humanInput.Text = "INT";
                }
            }
            else
            {
                humanInput.Text = "N/A";
            }

            if (chairInput.Text != "")
            {
                try
                {
                    numItem3Chair = Convert.ToInt16(chairInput.Text);
                    item3TotalChair = numItem3Chair * item3PriceChair;
                }
                catch
                {
                    chairInput.Text = "INT";
                }
            }
            else
            {
                chairInput.Text = "N/A";
            }

            //Figuring out numbers of orders

            if (numItem1Apple == 1 && numItem2Human == 3 && numItem3Chair == 3)
            {
                easterEgg = true;
            }

            //Easter egg!

            subtotal = item1PriceApple * (double)numItem1Apple + item2PriceHuman * (double)numItem2Human + item3PriceChair * (double)numItem3Chair;
            taxAmmount = (subtotal * hst);
            taxTotal = taxAmmount + subtotal;
            total = taxAmmount;

            //Calculations

            subTotalOutPut.Text = $"{subtotal.ToString("C")}";
            taxOutPut.Text = $"{taxAmmount.ToString("C")}";
            totalOutput.Text = $"{taxTotal.ToString("C")}";

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
                
                total = taxTotal + tipAmmount;
                tipOutput.Text = $"{total.ToString("C")} (+{tipAmmount.ToString("C")})";
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
                    change = ammountTendered - total;
                    changeOutput.Text = $"Change: {change.ToString("C")}";
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

        private void button2_Click(object sender, EventArgs e)
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

            storeLabel.Size = new Size(538, 49);
            this.Size = new Size(589, 574);

            //Changing size

            SoundPlayer print = new SoundPlayer(Properties.Resources.Cash_Register_Sound_FX);
            print.Play();

            //Audio

            receiptTitle.Text = $"Store Store";
            Thread.Sleep(250);
            this.Refresh();

            printReceiptButton.Enabled = false;

            if (numItem1Apple != 0)
            {
                receiptLeftColumn.Text += $"\nItem #1:";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\nx{numItem1Apple} ({item1TotalApple.ToString("C")})";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }
            if (numItem2Human != 0)
            {
                receiptLeftColumn.Text += $"\nItem #2:";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\nx{numItem2Human} ({item2TotalHuman.ToString("C")})";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }
            if (numItem3Chair != 0)
            {
                receiptLeftColumn.Text += $"\nItem #3: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\nx{numItem3Chair} ({item3TotalChair.ToString("C")})";
                Thread.Sleep(delayAmmount);
                this.Refresh();
            }


            receiptLeftColumn.Text += $"\n\nSubtotal: ";
            Thread.Sleep(delayAmmount);
            this.Refresh();
            receiptRightCollumn.Text += $"\n\n{subtotal.ToString("C")}";
            Thread.Sleep(delayAmmount);
            this.Refresh();

            receiptLeftColumn.Text += $"\nTax: ";
            Thread.Sleep(delayAmmount);
            this.Refresh();
            receiptRightCollumn.Text += $"\n{taxAmmount.ToString("C")}";
            Thread.Sleep(delayAmmount);
            this.Refresh();

            receiptLeftColumn.Text += $"\nTotal: ";
            Thread.Sleep(delayAmmount);
            this.Refresh();
            receiptRightCollumn.Text += $"\n{taxTotal.ToString("C")}";
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
                receiptRightCollumn.Text += $"\n{tipAmmount.ToString("C")}";
                Thread.Sleep(delayAmmount);
                this.Refresh();

                receiptLeftColumn.Text += $"\nTotal: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\n{total.ToString("C")}";
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
                receiptRightCollumn.Text += $"\n\n{ammountTendered.ToString("C")}";
                Thread.Sleep(delayAmmount);
                this.Refresh();

                receiptLeftColumn.Text += $"\n\nChange: ";
                Thread.Sleep(delayAmmount);
                this.Refresh();
                receiptRightCollumn.Text += $"\n\n{change.ToString("C")}";
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
            storeLabel.Size = new Size(174, 49);

            appleInput.Text = "";
            humanInput.Text = "";
            chairInput.Text = "";

            subTotalOutPut.Text = "";
            taxOutPut.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";

            tipInput.Text = "";
            amountTenderedInput.Text = "";

            numItem1Apple = 0;
            numItem2Human = 0;
            numItem3Chair = 0;

            item1TotalApple = 0;
            item2TotalHuman = 0;
            item3TotalChair = 0;

            subtotal = 0;
            taxAmmount = 0;
            taxTotal = 0;
            tip = 0;
            tipAmmount = 0;
            total = 0;

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
