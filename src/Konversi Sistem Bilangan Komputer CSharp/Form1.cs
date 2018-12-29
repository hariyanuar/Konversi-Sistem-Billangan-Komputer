using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konversi_Sistem_Bilangan_Komputer_CSharp
{
    public partial class Form1 : Form
    {
        char cho = '2';
        public Form1()
        {
            InitializeComponent();
        }

        private string ConvertToBiner(string number)
        {
            ulong temp = Convert.ToUInt64(number);
            number = string.Empty;
            while (temp >= 2)
            {
                number = number.Insert(0, Convert.ToString(temp % 2));
                temp /= 2;
            }
            number = number.Insert(0, Convert.ToString(temp));
            return number;
        }

        private string ConvertToDecimal(string number, char cho)
        {
            ulong temp = 0;
            int pangkat = 0;

            if(number == "0")
            {
                return "0";
            }

            switch (cho)
            {
                case '1':
                    for (int a = number.Length - 1; a >= 0; a--)
                    {
                        if (number[a] == '1')
                        {
                            temp += Convert.ToUInt64(Math.Pow(2, Convert.ToDouble(pangkat)));
                        }
                        pangkat++;
                    }
                    break;

                case '2':
                    return number;

                case '3':
                    for (int a = number.Length - 1; a >= 0; a--)
                    {
                        temp += Convert.ToUInt64(number[a]) * Convert.ToUInt64(Math.Pow(8, Convert.ToDouble(pangkat)));
                        pangkat++;
                    }
                    break;

                case '4':
                    for (int a = number.Length - 1; a >= 0; a--)
                    {
                        temp += Convert.ToUInt64(number[a]) * Convert.ToUInt64(Math.Pow(16, Convert.ToDouble(pangkat)));
                        pangkat++;
                    }
                    break;
            }
            return Convert.ToString(temp);
        }

        private string ConvertToOctal(string number)
        {
           ulong temp = Convert.ToUInt64(number);
            number = string.Empty;
            while (temp >= 8)
            {
                number = number.Insert(0, Convert.ToString(temp % 8));
                temp /= 8;
            }
            number = number.Insert(0, Convert.ToString(temp));
            return number;
        }

        private string ConvertToHexa(string number)
        {
            ulong temp = Convert.ToUInt64(number);
            number = string.Empty;
            while (temp >= 16)
            {
                
                switch (temp % 16)
                {
                    case 10:
                        number = number.Insert(0, "A");
                        break;

                    case 11:
                        number = number.Insert(0, "B");
                        break;

                    case 12:
                        number = number.Insert(0, "C");
                        break;

                    case 13:
                        number = number.Insert(0, "D");
                        break;

                    case 14:
                        number = number.Insert(0, "E");
                        break;

                    case 15:
                        number = number.Insert(0, "F");
                        break;

                    default:
                        number = number.Insert(0, Convert.ToString(temp % 16));
                        break;
                }
                temp /= 16;
            }
            switch (temp)
            {
                case 10:
                    number = number.Insert(0, "A");
                    break;

                case 11:
                    number = number.Insert(0, "B");
                    break;

                case 12:
                    number = number.Insert(0, "C");
                    break;

                case 13:
                    number = number.Insert(0, "D");
                    break;

                case 14:
                    number = number.Insert(0, "E");
                    break;

                case 15:
                    number = number.Insert(0, "F");
                    break;

                default:
                    number = number.Insert(0, Convert.ToString(temp));
                    break;
            }
            return number;
        }

        private void refresh()
        {
            string number = result.Text;

            if (cho != '2')
            {
                number = ConvertToDecimal(number, cho);
            }

            if(cho == '4')
            {
                hex_result.Text = result.Text;
            }
            else
            {
                hex_result.Text = ConvertToHexa(number);
            }

            if (cho == '3')
            {
                oct_result.Text = result.Text;
            }
            else
            {
                oct_result.Text = ConvertToOctal(number);
            }

            dec_result.Text = number;

            if (cho == '1')
            {
                bin_result.Text = result.Text;
            }
            else
            {
                bin_result.Text = ConvertToBiner(number);
            }
        }

        private void hex_button_Click(object sender, EventArgs e)
        {
            cho = '4';
            if(hex_result.Text != "0")
            {
                result.Text = hex_result.Text;
            }
            buttona.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
            buttone.Enabled = true;
            buttonf.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void dec_button_Click(object sender, EventArgs e)
        {
            cho = '2';
            if (dec_result.Text != "0")
            {
                result.Text = dec_result.Text;
            }
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttone.Enabled = false;
            buttonf.Enabled = false;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void oct_button_Click(object sender, EventArgs e)
        {
            cho = '3';
            if (oct_result.Text != "0")
            {
                result.Text = oct_result.Text;
            }
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttone.Enabled = false;
            buttonf.Enabled = false;
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttone.Enabled = false;
            buttonf.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void bin_button_Click(object sender, EventArgs e)
        {
            cho = '1';
            if (bin_result.Text != "0")
            {
                result.Text = bin_result.Text;
            }
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttone.Enabled = false;
            buttonf.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(result.Text != "0" && Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
            {
                result.Text += "0";
            }
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "";
            }
            if(Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "1";
            
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }
            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "2";
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "3";
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "4";
            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "5";
            refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "6";
            refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "7";
            refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "8";
            refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "9";
            refresh();
        }

        private void buttona_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "A";
            refresh();
        }

        private void buttonb_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "B";
            refresh();
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "C";
            refresh();
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "D";
            refresh();
        }

        private void buttone_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "E";
            refresh();
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }

            if (Convert.ToUInt64(dec_result.Text) < 18446744073709551600 && dec_result.Text.Length < 19 && dec_result.Text.Length < 20)
                result.Text += "F";
            refresh();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(result.Text.Length == 1)
            {
                result.Text = "0";
            }
            else
            {
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
            }
            refresh();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            refresh();
        }
    }
}
