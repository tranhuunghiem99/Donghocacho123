using System;
using System.Windows.Forms;
using System.Media;
namespace Dong_Ho
{
    
    public partial class frmmain : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        ColorDialog colorDlg = new ColorDialog();
        public frmmain()
        {
            loadding lod = new loadding();
            lod.ShowDialog();
            InitializeComponent();
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn có muốn thoát ???","Hỏi Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(ret==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            
            if (numgio.Value==0 && numphut.Value == 0 && numgiay.Value == 0)
            {
                 MessageBox.Show(
                "Bạn phải nhập thời gian đếm ngược", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else { timer1.Start(); 
            grsettime.Enabled = false;}   
        }
       
        private void numgio_ValueChanged(object sender, EventArgs e)
        {
            if(numgio.Value<= 23 && numgio.Value>=0)
            {
                lbltime.Text = numgio.Value + ":" + numphut.Value + ":" + numgiay.Value;
            }
            else
            {
                DialogResult ret = MessageBox.Show(
                "Vui lòng nhập trong khoảng 0-23", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                if(ret==DialogResult.OK)
                {
                    numgio.Value = 0;
                }    
            }           
        }

        private void numphut_ValueChanged(object sender, EventArgs e)
        {
            lbltime.Text = numgio.Value + ":" + numphut.Value + ":" + numgiay.Value;
        }

        private void numgiay_ValueChanged(object sender, EventArgs e)
        {
            lbltime.Text = numgio.Value + ":" + numphut.Value + ":" + numgiay.Value;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                
            if (numgio.Value > 0)
            {
                if (numphut.Value > 0)
                {
                    if (numgiay.Value > 0)
                    {
                        numgiay.Value--;
                    }
                    else
                    {
                        numgiay.Value = 59;
                        numphut.Value--;
                    }
                }
                else
                {
                    numphut.Value = 59;
                    numgio.Value--;
                }

            }
            else
             if (numgio.Value == 0)
            {
                if (numphut.Value > 0)
                {
                    if (numgiay.Value > 0)
                    {
                        numgiay.Value--;
                    }
                    else
                    {
                        numgiay.Value = 59;
                        numphut.Value--;
                    }
                }
                else
                {
                    numgiay.Value--;
                }

            }
            if (numgio.Value == 0 && numphut.Value == 0 && numgiay.Value == 0)
            {
               
                timer1.Stop(); 
                using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Alarm01.wav"))
                {
                    soundPlayer.PlayLooping();
                } 
                DialogResult ret=MessageBox.Show(
                        "Hết thời gian rồi bro!", 
                        "Thông Báo!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                if (ret == DialogResult.OK) {
                    using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Alarm01.wav"))
                        {
                           soundPlayer.Stop();
                        }
                    
                    grsettime.Enabled = true;
                }
                        
                  
            }
        }
        private void btnstop_Click(object sender, EventArgs e)
        {
            if (numgio.Value == 0 && numphut.Value == 0 && numgiay.Value == 0)
            {
                MessageBox.Show(
               "Bro chưa nhập Time thì Sì tốp làm quái gì", "Error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            else { 
                timer1.Stop();
                grsettime.Enabled = true;
            }  
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            lbltime.Text = 00 + ":" + 00 + ":" + 00;
            numgio.Value = 0;
            numphut.Value = 0;
            numgiay.Value = 0;
            grsettime.Enabled = true;
        }

       

        private void radTime_CheckedChanged(object sender, EventArgs e)
        {
            //if (radTime.Checked == true)
            //{

            //    lbltimer.Text = DateTime.Now.ToLongTimeString();
            //}

            if (radTime.Checked==true)
            {

                timer2.Start();
                //lbltimer.Text = DateTime.Now.ToLongTimeString();
                grsettime.Visible = false;
                grcontrol.Visible = false;
                grluachon.Visible = false;
                grmonth.Visible = true;
                lbltime.Visible = false;
                lbltimer.Visible = true;
            }
            else { 
                grsettime.Visible = true;
                grcontrol.Visible = true;
                grluachon.Visible = true;
                grmonth.Visible = false;
                lbltime.Visible = true;
                lbltimer.Visible = false;
            }    
            
        }

        private void radTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheme.Checked == true)
            {
                grsettime.Visible = false;
                grcontrol.Visible = false;
                grluachon.Visible = false;
                grmonth.Visible = false;
                grcolor.Visible = true;
            }
            else
            {
                grsettime.Visible = true;
                grcontrol.Visible = true;
                grluachon.Visible = true;
                grmonth.Visible = true;
                grcolor.Visible = false;
            }
        }

        private void raddoinhac_CheckedChanged(object sender, EventArgs e)
        {
            if (raddoinhac.Checked == true)
            {
                lbltime.Visible = false;
                grsettime.Visible = false;
                grcontrol.Visible = false;
                grluachon.Visible = true;
            }
            else
            {
                grsettime.Visible = true;
                grcontrol.Visible = true;
                grluachon.Visible = false;
                lbltime.Visible = true;
            }
        }

        private void radCount_down_CheckedChanged(object sender, EventArgs e)
        {
            if (radCount_down.Checked == true)
            {
                grluachon.Visible = false;
            }
            else
            {
                grluachon.Visible = true;
            }
        }

        private void radDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radDefault.Checked == true)
            {
                lstchon.Enabled = true;  
            }
            else if (radother.Checked == true)
            {
                lstchon.Enabled = false;
            }
            
        }

        private void radother_CheckedChanged(object sender, EventArgs e)
        {
            if (radother.Checked == true)
            {
                txtlink.Enabled = true;
                btnfilechoise.Enabled = true;
            }
            else
            {
                txtlink.Enabled = false;
                btnfilechoise.Enabled = false;
            }
        }

        private void lstchon_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (lstchon.SelectedIndex == i)
                {
                    if (i < 9)
                    {
                        using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Alarm0" + (i + 1) + ".wav"))
                        {
                            soundPlayer.Play();
                        }
                    }
                    if (i == 9)
                    {

                        using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Alarm" + (i + 1) + ".wav"))
                        {
                            soundPlayer.Play();
                        }
                    }

                }
            }
        }

        public void btnfilechoise_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"c:\Windows\Media\",
                Title = "Music Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "wav",//|mp3
                Filter = "wav (*.wav)|*.wav",//|Mp3 (*.mp3)|*.mp3|All files (*.*)|*.* mp3 sẽ ko ngắt bài cho khi hết
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtlink.Text = openFileDialog1.FileName;
                WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                player.URL = openFileDialog1.FileName; // Đường dẫn đến file cần chơi
                player.controls.play();
                
            }

        }

        private void btnOki_Click(object sender, EventArgs e)
        {
            radCount_down.Checked = true;
        }

        private void btncan_Click(object sender, EventArgs e)
        {
            radCount_down.Checked = true;
        }

        private void btnchangecolor_Click(object sender, EventArgs e)
        {
            
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                splitContainer1.BackColor = colorDlg.Color;
                grcolor.BackColor = colorDlg.Color;
                grcontrol.BackColor = colorDlg.Color;
                grluachon.BackColor = colorDlg.Color;
                grmonth.BackColor = colorDlg.Color;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (radTime.Checked == true)
            {

                 lbltimer.Text = DateTime.Now.ToLongTimeString();
                //lbltimer.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }
    }
}
    
