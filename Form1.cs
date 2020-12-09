using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Taxophone
{
    public partial class Taxophone : Form
    {

        class Phone
        {

            class Microphone { }
            class SoundOut { }
        }
        class AuthTelephStation
        {
            public List<int> PNumberList = new List<int>();
            public int time;
            public int timeMin;

        }

        AuthTelephStation ATS1 = new AuthTelephStation();

        class Card
        {
            public double Money { get; set; }
            public int CardId { get; set; }
            public bool access = false;
        }
        Card crd1 = new Card();
        Card crd2 = new Card();
        Card crd3 = new Card();

        class Display
        {

        }
        public Taxophone()
        {
            crd1.Money = 564.5;
            crd1.CardId = 000111;
            crd2.Money = 0.4;
            crd2.CardId = 000222;
            crd3.Money = 0;
            crd3.CardId = 000333;

            ATS1.PNumberList.Add(0000006);
            ATS1.PNumberList.Add(0000001);
            ATS1.PNumberList.Add(0000002);
            ATS1.PNumberList.Add(0000003);
            ATS1.PNumberList.Add(0000004);
            ATS1.PNumberList.Add(0000005);
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "3";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons3.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void Taxophone_Load(object sender, EventArgs e)
        {

        }

        private void PhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        MediaPlayer SoundButton = new MediaPlayer();
        private void button1_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "1";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons1.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "2";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons2.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "4";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons4.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "5";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons5.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "6";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons6.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "7";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons7.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "8";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons8.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "9";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons9.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (crd1.access == true && PhoneNum.Text.Length < 7)
            {
                PhoneNum.Text += "0";
                SoundButton.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\SoundButtons3.mp3", UriKind.Absolute));
                SoundButton.Play();
            }
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            if (PhoneNum.TextLength > 0)
                PhoneNum.Text = PhoneNum.Text.Remove(PhoneNum.TextLength - 1, 1);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            crd1.access = false;
            MoneyTimer.Stop();
            MoneyAmount.Text = Convert.ToString(crd1.Money);
            DisableButtons();
        }

        private void MoneyAmount_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(MoneyAmount.Text.Length) > 16)
            { MoneyAmount.Text = "0"; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            crd2.access = false;
            MoneyAmount.Text = Convert.ToString(crd2.Money);
            MoneyTimer.Stop();
            DisableButtons();

        }

        public void CardCheck()
        {
            if (MoneyAmount.Text.Length == 0)
            { InfoBar.Text = "Hello! Pick up the phone"; }
            else if (Convert.ToDouble(MoneyAmount.Text) <= 0)
            { InfoBar.Text = "Not enough money!"; }
            else if (Convert.ToDouble(MoneyAmount.Text) > 0)
            { InfoBar.Text = "Enter phone number"; crd1.access = true; }
        }
        MediaPlayer LongSound = new MediaPlayer();
        private void UseCard_Click(object sender, EventArgs e)
        {
            MoneyTimer.Stop();
            PhoneNum.Text = "";
            if (radioButton1.Checked)
            { 
                CardCheck();
                if (crd1.Money <= 0)
                { DisableButtons(); }
                else {
                    EnableButtons();
                    LongSound.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\LongSound.mp3", UriKind.Absolute));
                    LongSound.Play();
                }
            }
            else if (radioButton2.Checked)
            { 
                CardCheck();
                if (crd2.Money <= 0)
                { DisableButtons(); }
                else
                {
                    EnableButtons();
                    LongSound.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\LongSound.mp3", UriKind.Absolute));
                    LongSound.Play();
                }
            }
            else if (radioButton3.Checked)
            {
                CardCheck();
                if (crd3.Money <= 0)
                { DisableButtons(); }
                else
                {
                    EnableButtons();
                    LongSound.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\LongSound.mp3", UriKind.Absolute));
                    LongSound.Play();
                }
            }
            else if (radioButton4.Checked)
            { 
                CardCheck();
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            crd3.access = false;
            MoneyAmount.Text = Convert.ToString(crd3.Money);
            MoneyTimer.Stop();
            DisableButtons();
            
        }
        public void EnableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            Erase.Enabled = true;
            PhoneNum.Enabled = true;
            CallButton.Enabled = true;
        }

        public void DisableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            Erase.Enabled = false;
            PhoneNum.Enabled = false;
            CallButton.Enabled = false;
        }

        MediaPlayer CallSound = new MediaPlayer();
        MediaPlayer BreakSound = new MediaPlayer();

        private void CallButton_Click(object sender, EventArgs e)
        {
            if (PhoneNum.TextLength > 0)
            {
                if (ATS1.PNumberList.Contains(Convert.ToInt32(PhoneNum.Text)))
                {
                    CallTimer.Enabled = true;
                    LongSound.Stop();
                    InfoBar.Text = "Calling";
                    CallSound.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\CallSound.mp3", UriKind.Absolute));
                    CallSound.Play();
                    CallButton.Visible = false;
                    EndButton.Visible = true;
                    if (radioButton1.Checked)
                    {
                        TextLabel.Text = "Calling Card ID:" + crd1.CardId.ToString();
                    }
                    else if (radioButton2.Checked)
                    {
                        TextLabel.Text = "Calling Card ID:" + crd2.CardId.ToString();
                    }
                    else if (radioButton3.Checked)
                    {
                        TextLabel.Text = "Calling Card ID:" + crd3.CardId.ToString();
                    }
                }
                else
                {
                    LongSound.Stop();
                    InfoBar.Text = "Number is not found";
                    BreakSound.Open(new Uri(@"C:\Users\Eisenpunk\source\repos\Taxophone\Sound\BreakSound.mp3", UriKind.Absolute));
                    BreakSound.Play();
                    MoneyTimer.Enabled = false;
                    CallButton.Visible = false;
                    EndButton.Visible = true;
                }
            }
        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DisableButtons();
            crd1.access = false;
            MoneyAmount.Text = "0";
            MoneyTimer.Stop(); 
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                crd1.Money -= 0.1;
                MoneyAmount.Text = crd1.Money.ToString();
                if (crd1.Money <= 0 || crd1.Money > 1000) { NoMoney(); }
            }
            else if (radioButton2.Checked)
            {
                crd2.Money -= 0.1;
                MoneyAmount.Text = crd2.Money.ToString();
                if (crd2.Money <= 0 || crd2.Money > 1000) { NoMoney(); }
            }
            else if (radioButton3.Checked)
            {
                crd3.Money -= 0.1;
                MoneyAmount.Text = crd3.Money.ToString();
                if (crd3.Money <= 0|| crd3.Money>1000) { NoMoney(); }
            }
        }
        
        private void PullOutCard_Click(object sender, EventArgs e)
        {
            CallSound.Stop();
            BreakSound.Stop();
            LongSound.Stop();
            DisableButtons();
            EndCallEvent();
            crd1.access = false;
            crd2.access = false;
            crd3.access = false;
            InfoBar.Text = "Input your card!";
            MoneyAmount.Text = "0";
            PhoneNum.Text = "";
        }

        public void NoMoney()
        {
            MoneyTimer.Stop();
            MoneyAmount.Text = "0";
            EndCallEvent();
            InfoBar.Text = "Call ended. Not Enough Money!";
        }
        private void PhoneButton_Click(object sender, EventArgs e)
        {
            MoneyTimer.Stop();
            InfoBar.Text = "Please insert your card.";
            UseCard.Enabled = true;
            PullOutCard.Enabled = true;
            if (radioButton1.Enabled == true)
            {
                InfoBar.Text = "Hello! Pick up the phone";
                DisableButtons();
                PhoneNum.Text = "";
                MoneyTimer.Enabled = false;
                CallButton.Visible = true;
                EndButton.Visible = false;
                CallSound.Stop();
                BreakSound.Stop();
                LongSound.Stop();
                MoneyAmount.Text = "";
                radioButton4.Checked = true;
                UseCard.Enabled = false;
                PullOutCard.Enabled = false;
            }
            
            radioButton1.Enabled = !radioButton1.Enabled;
            radioButton2.Enabled = !radioButton2.Enabled;
            radioButton3.Enabled = !radioButton3.Enabled;
            radioButton4.Enabled = !radioButton4.Enabled;
        }
        
        public void EndCallEvent()
        {
            MoneyTimer.Stop();
            CallTimer.Stop();
            CallButton.Visible = true;
            EndButton.Visible = false;
            CallSound.Stop();
            BreakSound.Stop();
            LongSound.Stop();
            InfoBar.Text = "Call Ended";
            TextLabel.Text = "Waiting..";
            CallJournal.Text += CallTimeMin.Text + " Min, " + CallTimeSec.Text + " Seconds, Ended: " + DateTime.Now+ "\n";
            CallTimeSec.Text = "00";
            CallTimeMin.Text = "00";
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            EndCallEvent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
        private void Taxophone_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void AcceptCall_Click(object sender, EventArgs e)
        {
            if (InfoBar.Text == "Calling")
            {
                MoneyTimer.Enabled = true;
                if (radioButton1.Checked)
                {
                    TextLabel.Text = "Speaking with ID:" + crd1.CardId.ToString();
                }
                else if (radioButton2.Checked)
                {
                    TextLabel.Text = "Speaking with ID:" + crd2.CardId.ToString();
                }
                else if (radioButton3.Checked)
                {
                    TextLabel.Text = "Speaking with ID:" + crd3.CardId.ToString();
                }
            }
        }

        private void DismissCall_Click(object sender, EventArgs e)
        {
            if (EndButton.Visible == true)
            {
                EndCallEvent();
            }
        }
        private void CallTimer_Tick(object sender, EventArgs e)
        {
            ATS1.time = Convert.ToInt32(CallTimeSec.Text);
            ATS1.time++;
            CallTimeSec.Text = ATS1.time.ToString();
            ATS1.timeMin = Convert.ToInt32(CallTimeMin.Text);

            if (Convert.ToInt32(CallTimeSec.Text) >= 60)
            { 
                CallTimeSec.Text = "0";
                ATS1.timeMin ++;
                CallTimeMin.Text = ATS1.timeMin.ToString();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
