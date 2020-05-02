using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1, addend2;
        int minuend, subtrahend;
        int multiplicand, multiplier;
        int dividend, divisor;

        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldate.Text = string.Format("{0:dd MMM yyyy}", DateTime.Now);
        }

        private void answer_enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            multiplicand = randomizer.Next(1, 11);
            multiplier = randomizer.Next(1, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            divisor = randomizer.Next(2, 11);
            int temp = divisor * randomizer.Next(2, 11);
            dividend = temp;
            divisionLeftLabel.Text = dividend.ToString();
            divisionRightLabel.Text = divisor.ToString();
            quotient.Value = 0;


            timeLeft = 30;
            timeLeftLabel.Text = "30 seconds";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckForAnswer())
            {
                timer1.Stop();
                if (timeLeft < 6)
                {
                    timeLeftLabel.BackColor = DefaultBackColor;
                }
                MessageBox.Show("You answered all question correctly.", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLeftLabel.Text = timeLeft + " seconds";
                if (timeLeft<6)
                {
                    timeLeftLabel.BackColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                timeLeftLabel.BackColor = DefaultBackColor;
                timeLeftLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                startButton.Enabled = true;
            }
        }

        private bool CheckForAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }
    }
}
