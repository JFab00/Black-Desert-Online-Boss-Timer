using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Media;
using System.IO;

namespace WinFormsApp1
{

    public partial class FormInterface : Form
    {



        //   array used to decide which day of the week we're in... line 104
        public string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        //   matrix 7x8 that has the names of the bosses based on the day they spawn...
        // f.e. row 0 would be Monday, so at 00:15 of monday Karanda/Ancient Kutum will spawn
        public string[,] bossNames = new string[,]
        {
            { "Karanda / Ancient Kutum", "Karanda", "Kzarka", "Kzarka", "Mirumok", "Ancient Kutum", "Nouver", "Kzarka"},
            { "Karanda", "Ancient Kutum", "Kzarka", "Nouver", "Ancient Kutum", "Nouver", "Karanda", "Garmoth"},
            { "Kzarka / Ancient Kutum", "Karanda", "Kzarka", "Karanda", "Ancient Kutum / Mirumok", "Vell", "Kzarka / Karanda", "Muraka / Quint"},
            { "Nouver", "Ancient Kutum", "Nouver", "Ancient Kutum", "Nouver", "Kzarka", "Ancient Kutum", "Garmoth"},
            { "Kzarka / Karanda", "Nouver", "Karanda", "Ancient Kutum", "Karanda", "Nouver", "Kzarka", "Karanda / Ancient Kutum"},
            { "Karanda", "Mirumok", "Nouver", "Ancient Kutum", "Nouver", "Muraka / Quint", "Kzarka / Karanda", "Conquest Wars"},
            { "Nouver / Ancient Kutum", "Kzarka", "Ancient Kutum", "Nouver", "Kzarka", "Vell", "Garmoth", "Nouver/Kzarka"}
        };

        //   matrix the same dimension as the other one that has the names of the images to display...
        public string[,] bossImages = new string[,]
        {
            { "Karanda_Ancient_Kutum", "Karanda", "Kzarka", "Kzarka", "Mirumok", "Ancient_kutum", "Nouver", "Kzarka"},
            { "Karanda", "Ancient_kutum", "Kzarka", "Nouver", "Ancient_kutum", "Nouver", "Karanda", "Garmoth"},
            { "Kzarka_Ancient_Kutum", "Karanda", "Kzarka", "Karanda", "Ancient_kutum_Mirumok", "Vell", "Kzarka_Karanda", "Muraka_Quint"},
            { "Nouver", "Ancient_kutum", "Nouver", "Ancient_kutum", "Nouver", "Kzarka", "Ancient_kutum", "Garmoth"},
            { "Kzarka_Karanda", "Nouver", "Karanda", "Ancient_kutum", "Karanda", "Nouver", "Kzarka", "Karanda_Ancient_Kutum"},
            { "Karanda", "Mirumok", "Nouver", "Ancient_kutum", "Nouver", "Muraka_Quint", "Kzarka_Karanda", "Conquest_war"},
            { "Nouver_Ancient_Kutum", "Kzarka", "Ancient_kutum", "Nouver", "Kzarka", "Vell", "Garmoth", "Nouver_Kzarka"}
        };


        //   matrix 7x8 that has the hours at which the bosses will spawn TimeSpan(hh,mm,ss)
        public TimeSpan[,] hours = new TimeSpan[,]
        {
            { new TimeSpan(0, 15, 0), new TimeSpan(2, 0, 0), new TimeSpan(5, 0, 0), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(19, 0, 0), new TimeSpan(22, 15, 0) },
            { new TimeSpan(0, 15, 0), new TimeSpan(2, 0, 0), new TimeSpan(5, 0, 0), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(19, 0, 0), new TimeSpan(22, 15, 0) },
            { new TimeSpan(0, 15, 0), new TimeSpan(2, 0, 0), new TimeSpan(5, 0, 0), new TimeSpan(9, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(19, 0, 0), new TimeSpan(22, 15, 0), new TimeSpan(23, 15, 0) },
            { new TimeSpan(0, 15, 0), new TimeSpan(2, 0, 0), new TimeSpan(5, 0, 0), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(19, 0, 0), new TimeSpan(22, 15, 0) },
            { new TimeSpan(0, 15, 0), new TimeSpan(2, 0, 0), new TimeSpan(5, 0, 0), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(19, 0, 0), new TimeSpan(22, 15, 0) },
            { new TimeSpan(0, 15, 0), new TimeSpan(2, 0, 0), new TimeSpan(5, 0, 0), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(19, 0, 0), new TimeSpan(22, 15, 0) },
            { new TimeSpan(0, 15, 0), new TimeSpan(2, 0, 0), new TimeSpan(5, 0, 0), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(19, 0, 0), new TimeSpan(22, 15, 0) }
        };

        //   DateTime variable used to decide the current time later on the code
        public DateTime now;
        public FormInterface()
        {
            
            //   allows the transparency on the project
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            //   cut off the windows form's border
            this.FormBorderStyle = FormBorderStyle.None;

            //   display over everything
            this.TopMost = true;        

            // Makes the background transparent (it makes it green and then it turns transparent... like a green screen)
            this.BackColor = Color.Gray;
            this.TransparencyKey = BackColor;

            InitializeComponent();
            Reverse.Visible = false;
            timer.Start();
        }
        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
            closeButton.BackColor = Color.Transparent;
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }
        private void lbJFab_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe","https://www.instagram.com/fabianjrt.rar/");
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.White;
            minimizeButton.ForeColor = Color.Black;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.ForeColor = Color.White;
            minimizeButton.BackColor = Color.Transparent;
        }


        private void timer_Tick(object sender, EventArgs e)
        {


            int index = 0, day = 0;
            now = DateTime.Now.AddHours(0).AddMinutes(0);

            //checking where current time is located in the week, so days[0] would be Monday...
            for (int i = 0; i < 7; i++)
                if (Convert.ToString(now.DayOfWeek) == days[i])
                    day = i;
            
            // checking where current time is located in the hours array
            for (int i = 0; i <= hours.Length; i++) {
                //lbConsole.Text = hours[day, i].Hours.ToString();

                //   if all the bosses due have been surpassed then the day shall pass to the next one and the
                // index should be reset... the story continues at line 144
                if (i == 8){
                    day++;
                    index = 0;
                    break;
                }

                //   convert the hours and now into seconds so it will be easier to find the difference in time between them
                int hoursSec = (hours[day,i].Hours * 3600) + (hours[day,i].Minutes * 60) + (hours[day,i].Seconds);
                int nowSec = (now.Hour * 3600) + (now.Minute * 60) + now.Second;
                //lbConsole.Text = Convert.ToString(now.Hour) + "/" + Convert.ToString(hours[day, i].Hour) + "               " + Convert.ToString(now.Minute) + "/" + Convert.ToString(hours[day, i].Minute) + "           " + Convert.ToString(now.Second) + "/" + Convert.ToString(hours[day, i].Second) + "\n";
                //lbConsole.Text = hoursSec + "    " + nowSec;

                // ?
                if (now.Hour <= hours[day,i].Hours)
                    if(hoursSec >= nowSec){
                        index = i;
                        break;
                    }
                
            }
            
            
            lbWorldBoss.Text = bossNames[day,index];
            pbBossImage.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(bossImages[day, index]);
            //lbConsole.Text = day+"  "+index+"  "+bossImages[day, index]+"  "+Convert.ToString((Bitmap)Properties.Resources.ResourceManager.GetObject(bossImages[day, index]));

            //   all we gotta do now is to subtract from the assigned time, the current time
            int t = (hours[day, index].Hours * 3600) + (hours[day, index].Minutes * 60) + (hours[day, index].Seconds);
            int t2 = (now.Hour * 3600) + (now.Minute * 60) + now.Second;
            //lbConsole.Text = t.ToString() + "     " + t2.ToString();

            //   if time is for example 22:30 and the next boss is at 2:00 the next day... 
            // I'm subtracting a "day" (86400) from the current time so that it won't be buggy and instead
            // of getting an increment 23:00:something I'll get the actual countdown
            if (t < t2)
                t2 -= 86400;
            t -= t2;

            //   converts the seconds into timespan
            TimeSpan time = TimeSpan.FromSeconds(t);
            lbTimer.Text = time.ToString(@"hh\:mm\:ss");
            SoundPlayer sp = new SoundPlayer("Sounds/20_mins.wav");

            notifyIcon.BalloonTipTitle = "World Boss Timer | BDO";
            notifyIcon.BalloonTipText = "Boss spawns in "+ time.ToString(@"hh\:mm\:ss") +" mins";
            if (t == 1200)
            {
                sp.Play();
                //notifyIcon.ShowBalloonTip(100000);
            }
            else if (t == 600)
            {
                sp = new SoundPlayer("Sounds/10_mins.wav");
                sp.Play();
                //notifyIcon.ShowBalloonTip(100000);
            }
            else if (t == 300)
            {
                sp = new SoundPlayer("Sounds/5_mins.wav");
                sp.Play();
                //notifyIcon.ShowBalloonTip(100000);
            }
            notifyIcon.Text = time.ToString(@"hh\:mm\:ss")+" time remaining till boss spawn";

            // DEV'S NOTE:
            // I don't know if it works when the week ends.. so I should test it

            // Possible next features:
            // + button that opens another form which says the boss drops
            // + when boss's name is clicked, you'll get redirected to the respective bdodatabase page of that boss
            // + button that opens another form with a table that contains the full schedule of the bosses
            // / when Kzarka/Karanda/Ancient Kutum is scheduled, an eventual Note that says the boss can be awakened
        }

        private void Reverse_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Switch to new interface", Reverse);
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            FormInterfaceNew fin = new FormInterfaceNew();
            fin.Show();
            this.Hide();
        }

        private void lbWorldBoss_Click(object sender, EventArgs e)
        {
            string[,] links = new string[,]
            {
                {"Ancient Kutum", "ancient-kutum"},
                {"Nouver", "nouver"},
                {"Garmoth", "garmoth"},
                {"Kzarka", "kzarka"},
                {"Karanda", "karanda"},
                {"Quint", "quint"},
                {"Mirumok", "offin-tett"},
                {"Vell", "vell"}
            };
            string app = "https://www.somethinglovely.net/bdo/#worldbosses/";
            for (int i = 0; i < 8; i++)
                if (lbWorldBoss.Text == links[i, 0])
                    app += links[i, 1];
            System.Diagnostics.Process.Start("explorer.exe", app);

        }

        private void lbWorldBoss_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Click to see boss' location", lbWorldBoss);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void FormInterface_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
                notifyIcon.Visible = false;
        }
    }
}
