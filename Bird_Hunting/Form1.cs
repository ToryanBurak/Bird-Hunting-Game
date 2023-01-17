using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Hunting
{
   
    public partial class Form1 : Form
    {
        //EVRENSEL ALANDA HER YERDE KULLANILABİLECEK DEĞİŞKENLER
        SoundPlayer gun = new SoundPlayer();
        SoundPlayer snd = new SoundPlayer();
        SoundPlayer fail = new SoundPlayer();
        bool oyun_baslama = false;
        bool ses_acik = true;
        bool oyun_durum = false;
        int game_start_sayac = 0;
        int silah_sayac = 0;
        Image[] images_right = new Image[2];
        Image[] images_left = new Image[3];
        Random rnd=new Random();
        int score=0;
        int levels=1;
        bool game_level = false;
        int heart = 3;
        public Form1()
        {
            InitializeComponent();
            if (ses_acik == true)
            {
                string ses_dizin = Application.StartupPath + "\\files\\ses.wav";
                snd.SoundLocation = ses_dizin;
                snd.Play();
                
            }
            images_right[0] = Properties.Resources.BIRD_1;
            images_right[1] = Properties.Resources.BIRD_5;
            images_left[0] = Properties.Resources.BIRD_2;
            images_left[1] = Properties.Resources.BIRD_3;
            images_left[2] = Properties.Resources.BIRD_4;
            //level();
            difficulty();
           
        }
       
        
        //Oyuna Başlama butonu ile önceki oyunun verilerini sıfırlama ve ardından oyuna başlanacak işlemleri yapma
        private void play_btn_Click(object sender, EventArgs e)
        {
            levels = 1;
            score = 0;
            heart = 3;
            score_text_lbl.Visible = true;
            score_lbl.Visible = true;
            play_btn.Visible = false;
            title_lbl.Visible=false;
            panel1.Visible = true;
            pistol_pic.Visible = true;
            heart_1_pic.Visible = true;
            heart_2_pic.Visible = true;
            heart_3_pic.Visible = true;
            game_start_lbl.Visible = true;
            game_start_timer.Start();
            Cursor = Cursors.Cross;
            sound_btn.Visible = true;
            stop_btn.Visible = true;
            pic_1.Image = images_left[rnd.Next(0, 3)];
            pic_2.Image = images_left[rnd.Next(0, 3)];
            pic_3.Image = images_right[rnd.Next(0, 2)];
            pic_4.Image = images_right[rnd.Next(0, 2)];
            question_btn.Visible = false;
        }

        //SİLAH PNG SİNİN MOUSE'UN LOKASYONUNA GÖRE HAREKETİ
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (oyun_baslama == true)
            {
                pistol_pic.Location = new Point(MousePosition.X - 130, 247);
            }
        }
        //fare ile tıklandığındaki olaylar
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pistol_fire();
        }
        //Play Butonuna Bastıktan sonraki sayacın çalışması için timer ve timerdan sonra oyun startının verilmesi
        private void game_start_timer_Tick_1(object sender, EventArgs e)
        {
            game_start_sayac++;
            switch (game_start_sayac)
            {
                case 1: game_start_lbl.Text = "3"; break;
                case 2: game_start_lbl.Text = "2"; break;
                case 3: game_start_lbl.Text = "1"; break;
                case 4: game_start_lbl.Visible = false; game_start_timer.Stop(); game_start_sayac = 0; oyun_baslama = true; oyun_durum = true; game_timer.Start(); break;

            }
        }
        ////MOUSE TIKLAMA OLAYI İLE SİLAH ATIŞININ GÖZÜKMESİ VE SİLAH SESİNİN ÇIKMASI
        public void pistol_fire()
        {
            if (oyun_baslama == true)
            {
                silah_atis_timer.Start();
                pistol_pic.Enabled = true;
                silah_atis_timer.Enabled = true;
                if (ses_acik == true)
                {
                    string gun_fire_dizin = Application.StartupPath + "\\files\\gun_fire.wav";
                    gun.SoundLocation = gun_fire_dizin;
                    gun.Play();
                }
            }
        }
        //SİLAH ATIŞ Animasyonunun GÖZÜKMESİ İÇİN EDİNİLEN TİMER
        private void silah_atis_timer_Tick_1(object sender, EventArgs e)
        {
            silah_sayac++;
            if (silah_sayac == 1)
            {
                pistol_pic.Enabled = false;
                silah_atis_timer.Stop();
                silah_sayac = 0;
            }
        }
        //bool türü ile ses kontrolünü yukarıda ses play komutlarında kullanma.Ayrıca ses butonu resimlerini değiştirme
        private void sound_btn_Click(object sender, EventArgs e)
        {
            if (ses_acik == true)
            {
                ses_acik = false;
                sound_btn.BackgroundImage = Properties.Resources.SOUND_OFF;

            }
            else
            {
                ses_acik = true;
                sound_btn.BackgroundImage = Properties.Resources.SOUND_ON;
            }
        }
        //Oyun Durdurma
        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (oyun_durum == false)
            {
                oyun_durum = true;
            }
            else
            {
                oyun_durum = false;
                
                
                DialogResult durdur = MessageBox.Show("Oyun Durduruldu.", "Oyun Durduruldu", MessageBoxButtons.OK);

                if (durdur == DialogResult.OK)
                {
                    oyun_durum = true;
                }

            }
        }
        //stop btn üzerinde cursor değiştirme
        private void stop_btn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        //oyun üzerinde cursoru cross yapma
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (oyun_baslama == true)
            {
                Cursor = Cursors.Cross;
            }
        }
        //sound btn üzerinde cursor değiştirme
        private void sound_btn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        //picturebox lokasyonlarını ayarlama
        private void Form1_Load(object sender, EventArgs e)
        {
            pic_1.Left = -120;
            pic_2.Left = -120;
            pic_3.Left = 1620;
            pic_4.Left = 1620;
            
        }
        //levele göre zorluk ayarlama ve level atlama
        public void difficulty()
        {
            if (game_level == false && oyun_durum==true )
            {
                if (levels==1)
                {
                    pic_1.Left += 10; pic_2.Left += 10; pic_3.Left -= 10; pic_4.Left -= 10;
                }
                else if (levels==2)
                {
                    pic_1.Left += 20; pic_2.Left += 20; pic_3.Left -= 20; pic_4.Left -= 20;
                }
                else if (levels==3)
                {
                    pic_1.Left += 30; pic_2.Left += 30; pic_3.Left -= 30; pic_4.Left -= 30;
                }
                else if (score <= 40)
                {
                    pic_1.Left += 40; pic_2.Left += 40; pic_3.Left -= 40; pic_4.Left -= 40;
                }
                else if(score <= 50)
                {
                    pic_1.Left += 50; pic_2.Left += 50; pic_3.Left -= 50; pic_4.Left -= 50;
                }
                else if (score <= 60)
                {
                    pic_1.Left += 60; pic_2.Left += 60; pic_3.Left -= 60; pic_4.Left -= 60;
                }
            }
                
            switch (score)
            {
                
                case 10:
                    levels = 2;
                    levels_timer.Start();
                    break;
                case 20:
                    levels = 3;
                    levels_timer.Start();
                    break;
                case 30:
                    levels = 4;
                    levels_timer.Start();
                    break;
                case 40:
                    levels = 5;
                    levels_timer.Start();
                    break;
                case 50:
                    levels = 6;
                    levels_timer.Start();
                    break;
            }
        }
        
        //Oyun timerı
        private void game_timer_Tick(object sender, EventArgs e)
        {
            
            score_lbl.Text = score.ToString();
            if (oyun_baslama = true)
            {

                
                difficulty();
                kacirma();
                can();
                

            }
        }
        //Kuşları vuramama durumunda olacak olaylar
        public void kacirma()
        {
            if (pic_1.Location.X >= 1625)
            {
                pic_1.Location = new Point(-120, 68);
                heart--;
            }
            else if(pic_2.Location.X >= 1625)
            {
                pic_2.Location = new Point(-120, 201);
                heart--;
            }
            else if (pic_3.Location.X <= -125)
            {
                pic_3.Location = new Point(1620, 68);
                heart--;
            }
            else if (pic_4.Location.X <= -125)
            {
                pic_4.Location = new Point(1620, 201);
                heart--;
            }
        }
        //Can durumuna göre oyunu kaybetme olayı ve oyunu tekrar başlatma
        public void can()
        {
            if (heart == 2)
            {
                heart_3_pic.Visible = false;
            }
            else if (heart == 2)
            {
                heart_2_pic.Visible = false;
            }
            else if(heart == 0)
            {
                if (ses_acik = true)
                {
                    string fail_dizn = Application.StartupPath + "\\files\\fail_sound.wav";
                    fail.SoundLocation = fail_dizn;
                    fail.Play();
                }
                heart_1_pic.Visible = false;
                game_timer.Stop();
                MessageBox.Show("Oyunu Kaybettiniz.\n Skorunuz:" + score);
                spawn();
                score = 0;
                score_lbl.Visible = false;
                score_text_lbl.Visible = false;
                stop_btn.Visible = false;
                sound_btn.Visible = false;
                oyun_baslama = false;
                oyun_durum = false;
                panel1.Visible = false;
                pistol_pic.Visible = false;
                heart_1_pic.Visible = false;
                heart_2_pic.Visible = false;
                heart_3_pic.Visible = false;
                title_lbl.Visible = true;
                play_btn.Visible = true;
                question_btn.Visible = true;
                
            }
            
        }
        //Kuşların Level başında spawn yerlerine geri gelmesi
        public void spawn()
        {
            pic_1.Location = new Point(-120, 68);
            pic_2.Location = new Point(-120, 201);
            pic_3.Location = new Point(1620, 68);
            pic_4.Location = new Point(1620, 201);
            
        }
        //Kuş_1 e tıklandığındaki olaylar
        private void pic_1_Click(object sender, EventArgs e)
        {
            pistol_fire();
            pic_1.Location = new Point(-120, 68);
            pic_1.Image = images_left[rnd.Next(0, 3)];
            score++;
        }
        //Kuş 2 ye tıklandığındaki olaylar
        private void pic_2_Click(object sender, EventArgs e)
        {
            pistol_fire();
            pic_2.Location = new Point(-120, 201);
            pic_2.Image = images_left[rnd.Next(0, 3)];
            score++;
        }
        //Kuş 3 e tıklandığındaki olaylar
        private void pic_3_Click(object sender, EventArgs e)
        {
            pistol_fire();
            pic_3.Location = new Point(1620, 68);
            pic_3.Image = images_right[rnd.Next(0, 2)];
            score++;
        }
        //Kuş 4 e tıklandığındaki olaylar
        private void pic_4_Click(object sender, EventArgs e)
        {
            pistol_fire();
            pic_4.Location = new Point(1620, 201);
            pic_4.Image = images_right[rnd.Next(0, 2)];
            score++;
        }
        //Level aralarında olan geçiş uygulaması
        int levels_timer_sayac=0;
        private void levels_timer_Tick(object sender, EventArgs e)
        {
           
            levels_timer_sayac++;
            
            switch (levels_timer_sayac)
            {
                case 1: game_level = true; game_start_lbl.Visible = true; game_start_lbl.Text = (levels.ToString()+".Level..."); break;
                case 2: game_start_lbl.Text = "3"; break;
                case 3: game_start_lbl.Text = "2"; break;
                case 4: game_start_lbl.Text = "1"; break;
                case 5: game_start_lbl.Visible = false; levels_timer.Enabled=false; game_level = false; levels_timer_sayac = 0; break;
            }
        }
        //Nasıl Oynanır Butonu
        private void question_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Silah Muhimmatı Serbest.\n" + "2.Kuşları istediğin gibi vurabilirsin.\n" + "3.Kuşları Kaçırırsan Canın Azalır.\n" + "4. 3 Canın Da gittiğinde Oyunu Kaybedersin.\n" + "                        İyi Şanslar :)");
        }
    }
}
