using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace PPWCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            sellerSelectedStateChange(0);
        }
        
        public void sellerSelectedStateChange(int i = 0)
        {
            switch (i)
            {
                case 0:
                    {
                        cez.Checked = epro.Checked = false;
                        nightHoursBox.Text = "8";
                        dayPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "2066";
                        nightPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "11734";
                        break;
                    }

                case 1:
                    {
                        evn.Checked = epro.Checked = false;
                        nightHoursBox.Text = "8";
                        dayPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "22000";
                        nightPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "13000";
                        break;
                    }

                case 2:
                    {
                        evn.Checked = cez.Checked = false;
                        nightHoursBox.Text = "8";
                        dayPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "21948";
                        nightPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "121404";
                        break;
                    }

                case 3:
                    {
                        evn.Checked = cez.Checked = epro.Checked = false;
                        break;
                    }
            }
        }

        private void evn_MouseClick(object sender, MouseEventArgs e)
        {
            sellerSelectedStateChange();
            powerBox_TextChanged(sender, e);
        }

        private void cez_MouseClick(object sender, MouseEventArgs e)
        {
            sellerSelectedStateChange(1);
            powerBox_TextChanged(sender, e);
        }

        private void epro_MouseClick(object sender, MouseEventArgs e)
        {
            sellerSelectedStateChange(2);
            powerBox_TextChanged(sender, e);
        }

        private void powerBox_TextChanged(object sender, EventArgs e)
        {
            double power = 0, nightPrice, dayPrice;
            bool validPower = true;            

            try
            {
                power = Convert.ToDouble(powerBox.Text);
            }
            catch (Exception exception)
            {
                validPower = false;
                powerBox.Text = "0";
                validPower = true;
            }

            double.TryParse(dayPriceBox.Text, out dayPrice);
            double.TryParse(nightPriceBox.Text, out nightPrice);

            if (power > 99999 || power < 0)
            {
                power = 0;
                powerBox.Text = "0";
            }

            if (validPower && power > 1)
            {
                double sum = 0;

                if (oneScale.Checked)
                {
                    sum = (power / 1000) * dayPrice * 24;
                    equation.Text = "(" + power.ToString() + "/1000) * " + dayPrice.ToString() + " * 24 =";
                }
                else
                {
                    sum = (power / 1000) * dayPrice * (24 - Convert.ToInt32(nightHoursBox.Text)) + (power / 1000) * nightPrice * Convert.ToInt32(nightHoursBox.Text);
                    equation.Text = "(" + power.ToString() + "/1000) * " + dayPrice.ToString() + " * (24-" + nightHoursBox.Text + ") + (" + power.ToString() + "/1000) * " + nightPrice.ToString() + " * " + nightHoursBox.Text + " =";
                }
                
                priceDay.Text = sum.ToString("0.00");
                priceWeek.Text = (sum * 7).ToString("0.00");
                priceMonth.Text = (sum * 30).ToString("0.00");
            }
        }

        private void oneScale_MouseClick(object sender, MouseEventArgs e)
        {
            powerBox_TextChanged(sender, e);
        }

        private void nightHoursBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(nightHoursBox.Text);
            }
            catch (Exception exception)
            {
                nightHoursBox.Text = "8";
            }

            if (Convert.ToInt32(nightHoursBox.Text) > 23 || Convert.ToInt32(nightHoursBox.Text) < 1)
            {
                nightHoursBox.Text = "8";
            }

            powerBox_TextChanged(sender, e);
        }

        private void dayPriceBox_TextChanged(object sender, EventArgs e)
        {
            double dayPrice = 0;

            try
            {
                double.TryParse(dayPriceBox.Text, out dayPrice);                
            }
            catch (Exception exception)
            {
                dayPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "1";
            }

            if (dayPrice > 100 || dayPrice < 0.00000001)
            {
                dayPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "1";
            }

            powerBox_TextChanged(sender, e);
        }

        private void nightPriceBox_TextChanged(object sender, EventArgs e)
        {
            double nightPrice = 0;

            try
            {
                double.TryParse(nightPriceBox.Text, out nightPrice);
            }
            catch (Exception exception)
            {
                nightPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "1";
            }

            if (nightPrice > 100 || nightPrice < 0.00000001)
            {
                nightPriceBox.Text = "0" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "1";
            }

            powerBox_TextChanged(sender, e);
        }

        private void EVNLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.evn.bg/Chastni_klienti/Elektricheska-energia/Ceni-el-energia/Kraini_ceni.aspx?listnode=/Chastni_klienti/Elektricheska-energia/Ceni-el-energia");
        }

        private void CEZpricesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.cez.bg/bg/za-klienta/bitovi-i-nebitovi-klienti/calculator-konsumacia.html");
        }

        private void EnergoProPricesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.energo-pro.bg/bg/Dejstvashti-ceni-na-elektroenergiyata-Bitovi-klienti");
        }
    }
}
