using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class calculator : Form
    {
        string ans = "0", viewNumber = "0";
        string viewString = "";
        bool isNewNumber = false;

        public calculator()
        {
            InitializeComponent();
           /* button1.MouseHover += button1_MouseHover;
            button1.MouseLeave += button1_MouseLeave;*/
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewNumber = "0";
            }

            int len = viewNumber.Length;
            bool hasDot = false;
            for(int i=len-1; i>=0; i--)
            {
                if(viewNumber[i] == '.')
                {
                    hasDot = true;
                    break;
                }
            }

            if(!hasDot) viewNumber += '.';

            bool hasDot2 = false;
            int len2 = ans.Length;
            for (int i = len2 - 1; i >= 0; i--)
            {
                if (ans[i] == '.')
                {
                    hasDot2 = true;
                    break;
                }
            }

            if (!hasDot2) ans += '.';

            Number.Text = viewNumber;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            viewNumber = "0";
            viewString = "";
            ans = "0";
            isNewNumber = false;
            String.Text = "";
            Number.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            viewNumber = "0";
            Number.Text = "0";
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            int len = viewNumber.Trim().Length;
            if (len == 1) viewNumber = "0";
            else viewNumber = viewNumber.Remove(len - 1, 1);
            if (!isNewNumber) Number.Text = viewNumber;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();
            int len = viewString.Length;
            bool check = true;

            for (int i=len-1; i>=0; i--)
            {
                if(viewString[i] == '+')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp += Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '-') {
                    double tmp = Convert.ToDouble(ans);
                    tmp -= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == 'x')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp *= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '/')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp /= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
            }

            if (check) ans = Number.Text;

            if (isNewNumber) viewString = "";
            viewString += " " + Number.Text + " + ";
            viewNumber = "0";
            isNewNumber = false;
            String.Text = viewString;
            Number.Text = ans;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();
            int len = viewString.Length;
            bool check = true;

            for (int i = len - 1; i >= 0; i--)
            {
                if (viewString[i] == '+')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp += Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '-')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp -= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == 'x')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp *= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '/')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp /= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
            }
            if (check) ans = Number.Text;

            if (isNewNumber) viewString = "";
            viewString += " " + Number.Text + " - ";
            viewNumber = "0";
            isNewNumber = false;
            String.Text = viewString;
            Number.Text = ans;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();
            int len = viewString.Length;
            bool check = true;

            for (int i = len - 1; i >= 0; i--)
            {
                if (viewString[i] == '+')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp += Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '-')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp -= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == 'x')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp *= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '/')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp /= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
            }
            if (check) ans = Number.Text;

            if (isNewNumber) viewString = "";
            viewString += " " + Number.Text + " x ";
            viewNumber = "0";
            isNewNumber = false;
            String.Text = viewString;
            Number.Text = ans;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();
            int len = viewString.Length;
            bool check = true;

            for (int i = len - 1; i >= 0; i--)
            {
                if (viewString[i] == '+')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp += Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '-')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp -= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == 'x')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp *= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '/')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp /= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
            }
            if (check) ans = Number.Text;

            if (isNewNumber) viewString = ""; 
            viewString += " " + Number.Text + " / ";
            viewNumber = "0";
            isNewNumber = false;
            String.Text = viewString;
            Number.Text = ans;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();
            int len = viewString.Length;
            bool check = true;

            for (int i = len - 1; i >= 0; i--)
            {
                if (viewString[i] == '+')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp += Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '-')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp -= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == 'x')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp *= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
                else if (viewString[i] == '/')
                {
                    double tmp = Convert.ToDouble(ans);
                    tmp /= Convert.ToDouble(Number.Text);
                    ans = Convert.ToString(tmp);
                    check = false;
                    break;
                }
            }
            if (check) ans = Number.Text;

            isNewNumber = true; 
            viewString = "";
            viewNumber = "0";

            String.Text = "";
            Number.Text = ans;
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            if (Number.Text.Trim() == "") return;
            if (Number.Text[0] >= '0' && Number.Text[0] <= '9') Number.Text = "-" + Number.Text;
            else Number.Text = Number.Text.Remove(0, 1);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                viewString = "sqrt(" + ans + ")";
                ans = Convert.ToString(Math.Sqrt(Convert.ToDouble(ans)));
                String.Text = viewString;
                Number.Text = ans;
            }
            if (!isNewNumber)
            {
                viewNumber = Convert.ToString(Math.Sqrt(Convert.ToDouble(viewNumber)));
               // String.Text += Convert.ToString(Math.Sqrt(Convert.ToDouble(Number.Text)));
                Number.Text = viewNumber;
            }
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                viewString = "sqr(" + ans + ")";
                ans = Convert.ToString(Math.Pow(Convert.ToDouble(ans), 2));
                String.Text = viewString;
                Number.Text = ans;
            }
            if (!isNewNumber)
            {
                viewNumber = Convert.ToString(Math.Pow(Convert.ToDouble(viewNumber), 2));
                Number.Text = viewNumber;
            }
        }

        private void btnLP_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                viewString = "cube(" + ans + ")";
                ans = Convert.ToString(Math.Pow(Convert.ToDouble(ans), 3));
                String.Text = viewString;
                Number.Text = ans;
            }
            if (!isNewNumber)
            {
                viewNumber = Convert.ToString(Math.Pow(Convert.ToDouble(viewNumber), 3));
                Number.Text = viewNumber;
            }
        }

        private void btnND_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                viewString = "1/" + ans;
                ans = Convert.ToString(1/Convert.ToDouble(ans));
                String.Text = viewString;
                Number.Text = ans;
            }
            if (!isNewNumber)
            {
                double tmp = 1.0 / double.Parse(viewNumber);
                viewNumber = Convert.ToString(tmp);
                Number.Text = viewNumber;
            }
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                ans = Convert.ToString(Convert.ToDouble(ans) / 100);
                //String.Text = viewString;
                String.Text = "";
                Number.Text = ans;
            }
            if (!isNewNumber)
            {
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber) / 100);
                Number.Text = viewNumber;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewNumber.Length;
            bool hasDot = false;
            for (int i = len - 1; i >= 0; i--)
            {
                if (viewNumber[i] == '.')
                {
                    hasDot = true;
                    break;
                }
            }

            if (hasDot || (Convert.ToDouble(viewNumber) != Convert.ToDouble(viewNumber + '0')))
            {
                viewNumber += '0';
                ans += '0';
            }

            if (len == 0)
            {
                ans += '0';
                //ans = Convert.ToString(Convert.ToDouble(ans));
               // viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            //ans = Convert.ToString(Convert.ToDouble(ans));
            //viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '1';

            if (len == 0)
            {
                ans += '1';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '2';

            if (len == 0)
            {
                ans += '2';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '3';

            if (len == 0)
            {
                ans += '3';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '4';

            if (len == 0)
            {
                ans += '4';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '5';

            if (len == 0)
            {
                ans += '5';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '6';

            if (len == 0)
            {
                ans += '6';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '7';

            if (len == 0)
            {
                ans += '7';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '8';

            if (len == 0)
            {
                ans += '8';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }

        int hour = 0, minute = 0, second = 0;

        private void tmrCal_Tick(object sender, EventArgs e)
        {
            string format = "HH:mm:ss";
            DateTime now = DateTime.Now;
            string s = now.ToString(format);

            /*tmrCal.Interval = 1000;
            second++;

            minute += second / 60;
            hour += minute / 60;
            second %= 60;

            if (hour < 10) lblTimer.Text = "0";
            lblTimer.Text += Convert.ToString(hour) + ":";
            if (minute < 10) lblTimer.Text += "0";
            lblTimer.Text += Convert.ToString(minute) + ":";
            if (second < 10) lblTimer.Text += "0";*/
            lblTimer.Text = Convert.ToString(s);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            viewString = viewString.Trim();

            if (isNewNumber)
            {
                isNewNumber = false;
                ans = "0";
                viewString = "";
            }
            int len = viewString.Length;
            viewNumber += '9';

            if (len == 0)
            {
                ans += '9';
                ans = Convert.ToString(Convert.ToDouble(ans));
                viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));
                Number.Text = viewNumber;
                String.Text = "";
                return;
            }
            ans = Convert.ToString(Convert.ToDouble(ans));
            viewNumber = Convert.ToString(Convert.ToDouble(viewNumber));

            Number.Text = viewNumber;
        }



        /*private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonHighlight;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonFace;
        }*/
    }

}
