namespace Bird_Hunting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.score_text_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.game_start_timer = new System.Windows.Forms.Timer(this.components);
            this.game_start_lbl = new System.Windows.Forms.Label();
            this.silah_atis_timer = new System.Windows.Forms.Timer(this.components);
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.levels_timer = new System.Windows.Forms.Timer(this.components);
            this.pic_4 = new System.Windows.Forms.PictureBox();
            this.pic_3 = new System.Windows.Forms.PictureBox();
            this.pic_2 = new System.Windows.Forms.PictureBox();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.play_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pistol_pic = new System.Windows.Forms.PictureBox();
            this.sound_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.heart_3_pic = new System.Windows.Forms.PictureBox();
            this.heart_2_pic = new System.Windows.Forms.PictureBox();
            this.heart_1_pic = new System.Windows.Forms.PictureBox();
            this.question_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistol_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_3_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_1_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // score_text_lbl
            // 
            this.score_text_lbl.AutoSize = true;
            this.score_text_lbl.Location = new System.Drawing.Point(15, 9);
            this.score_text_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.score_text_lbl.Name = "score_text_lbl";
            this.score_text_lbl.Size = new System.Drawing.Size(75, 25);
            this.score_text_lbl.TabIndex = 0;
            this.score_text_lbl.Text = "Score:";
            this.score_text_lbl.Visible = false;
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Location = new System.Drawing.Point(102, 9);
            this.score_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(24, 25);
            this.score_lbl.TabIndex = 0;
            this.score_lbl.Text = "0";
            this.score_lbl.Visible = false;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Chiller", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(472, 29);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(521, 111);
            this.title_lbl.TabIndex = 4;
            this.title_lbl.Text = "BIRD HUNTİNG";
            // 
            // game_start_timer
            // 
            this.game_start_timer.Interval = 1000;
            this.game_start_timer.Tick += new System.EventHandler(this.game_start_timer_Tick_1);
            // 
            // game_start_lbl
            // 
            this.game_start_lbl.AutoSize = true;
            this.game_start_lbl.BackColor = System.Drawing.Color.White;
            this.game_start_lbl.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.game_start_lbl.Location = new System.Drawing.Point(737, 268);
            this.game_start_lbl.Name = "game_start_lbl";
            this.game_start_lbl.Size = new System.Drawing.Size(0, 77);
            this.game_start_lbl.TabIndex = 1;
            // 
            // silah_atis_timer
            // 
            this.silah_atis_timer.Interval = 1000;
            this.silah_atis_timer.Tick += new System.EventHandler(this.silah_atis_timer_Tick_1);
            // 
            // game_timer
            // 
            this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
            // 
            // levels_timer
            // 
            this.levels_timer.Interval = 1000;
            this.levels_timer.Tick += new System.EventHandler(this.levels_timer_Tick);
            // 
            // pic_4
            // 
            this.pic_4.Location = new System.Drawing.Point(1324, 201);
            this.pic_4.Name = "pic_4";
            this.pic_4.Size = new System.Drawing.Size(100, 100);
            this.pic_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_4.TabIndex = 6;
            this.pic_4.TabStop = false;
            this.pic_4.Click += new System.EventHandler(this.pic_4_Click);
            // 
            // pic_3
            // 
            this.pic_3.Location = new System.Drawing.Point(1324, 68);
            this.pic_3.Name = "pic_3";
            this.pic_3.Size = new System.Drawing.Size(100, 100);
            this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_3.TabIndex = 6;
            this.pic_3.TabStop = false;
            this.pic_3.Click += new System.EventHandler(this.pic_3_Click);
            // 
            // pic_2
            // 
            this.pic_2.Location = new System.Drawing.Point(26, 201);
            this.pic_2.Name = "pic_2";
            this.pic_2.Size = new System.Drawing.Size(100, 100);
            this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_2.TabIndex = 6;
            this.pic_2.TabStop = false;
            this.pic_2.Click += new System.EventHandler(this.pic_2_Click);
            // 
            // pic_1
            // 
            this.pic_1.Location = new System.Drawing.Point(26, 68);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(100, 100);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_1.TabIndex = 6;
            this.pic_1.TabStop = false;
            this.pic_1.Click += new System.EventHandler(this.pic_1_Click);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_btn.BackgroundImage = global::Bird_Hunting.Properties.Resources.PLAY;
            this.play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_btn.Location = new System.Drawing.Point(671, 201);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(150, 144);
            this.play_btn.TabIndex = 5;
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bird_Hunting.Properties.Resources.cattails;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pistol_pic);
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1485, 361);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // pistol_pic
            // 
            this.pistol_pic.BackColor = System.Drawing.Color.Transparent;
            this.pistol_pic.Enabled = false;
            this.pistol_pic.Image = global::Bird_Hunting.Properties.Resources.PİSTOL;
            this.pistol_pic.Location = new System.Drawing.Point(690, 215);
            this.pistol_pic.Name = "pistol_pic";
            this.pistol_pic.Size = new System.Drawing.Size(120, 146);
            this.pistol_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pistol_pic.TabIndex = 0;
            this.pistol_pic.TabStop = false;
            this.pistol_pic.Visible = false;
            // 
            // sound_btn
            // 
            this.sound_btn.BackgroundImage = global::Bird_Hunting.Properties.Resources.SOUND_ON;
            this.sound_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound_btn.Location = new System.Drawing.Point(1411, 12);
            this.sound_btn.Name = "sound_btn";
            this.sound_btn.Size = new System.Drawing.Size(60, 60);
            this.sound_btn.TabIndex = 2;
            this.sound_btn.UseVisualStyleBackColor = true;
            this.sound_btn.Visible = false;
            this.sound_btn.Click += new System.EventHandler(this.sound_btn_Click);
            this.sound_btn.MouseEnter += new System.EventHandler(this.sound_btn_MouseEnter);
            // 
            // stop_btn
            // 
            this.stop_btn.BackgroundImage = global::Bird_Hunting.Properties.Resources.STOP;
            this.stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop_btn.Location = new System.Drawing.Point(1345, 12);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(60, 60);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Visible = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            this.stop_btn.MouseEnter += new System.EventHandler(this.stop_btn_MouseEnter);
            // 
            // heart_3_pic
            // 
            this.heart_3_pic.Image = global::Bird_Hunting.Properties.Resources.HEART;
            this.heart_3_pic.Location = new System.Drawing.Point(245, 9);
            this.heart_3_pic.Name = "heart_3_pic";
            this.heart_3_pic.Size = new System.Drawing.Size(50, 50);
            this.heart_3_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart_3_pic.TabIndex = 1;
            this.heart_3_pic.TabStop = false;
            this.heart_3_pic.Visible = false;
            // 
            // heart_2_pic
            // 
            this.heart_2_pic.Image = global::Bird_Hunting.Properties.Resources.HEART;
            this.heart_2_pic.Location = new System.Drawing.Point(190, 9);
            this.heart_2_pic.Name = "heart_2_pic";
            this.heart_2_pic.Size = new System.Drawing.Size(50, 50);
            this.heart_2_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart_2_pic.TabIndex = 1;
            this.heart_2_pic.TabStop = false;
            this.heart_2_pic.Visible = false;
            // 
            // heart_1_pic
            // 
            this.heart_1_pic.Image = global::Bird_Hunting.Properties.Resources.HEART;
            this.heart_1_pic.Location = new System.Drawing.Point(135, 9);
            this.heart_1_pic.Name = "heart_1_pic";
            this.heart_1_pic.Size = new System.Drawing.Size(50, 50);
            this.heart_1_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart_1_pic.TabIndex = 1;
            this.heart_1_pic.TabStop = false;
            this.heart_1_pic.Visible = false;
            // 
            // question_btn
            // 
            this.question_btn.Location = new System.Drawing.Point(671, 126);
            this.question_btn.Name = "question_btn";
            this.question_btn.Size = new System.Drawing.Size(150, 60);
            this.question_btn.TabIndex = 1;
            this.question_btn.Text = "Nasıl Oynanır?";
            this.question_btn.UseVisualStyleBackColor = true;
            this.question_btn.Click += new System.EventHandler(this.question_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.question_btn);
            this.Controls.Add(this.pic_4);
            this.Controls.Add(this.pic_3);
            this.Controls.Add(this.pic_2);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.game_start_lbl);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sound_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.heart_3_pic);
            this.Controls.Add(this.heart_2_pic);
            this.Controls.Add(this.heart_1_pic);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.score_text_lbl);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pistol_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_3_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_2_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_1_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score_text_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox heart_1_pic;
        private System.Windows.Forms.PictureBox heart_2_pic;
        private System.Windows.Forms.PictureBox heart_3_pic;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button sound_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pistol_pic;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Timer game_start_timer;
        private System.Windows.Forms.Label game_start_lbl;
        private System.Windows.Forms.Timer silah_atis_timer;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.PictureBox pic_3;
        private System.Windows.Forms.PictureBox pic_4;
        private System.Windows.Forms.PictureBox pic_2;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Timer levels_timer;
        private System.Windows.Forms.Button question_btn;
    }
}

