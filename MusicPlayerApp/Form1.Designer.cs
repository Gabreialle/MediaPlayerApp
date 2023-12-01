namespace MusicPlayerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btn_next = new Button();
            lbl_volume = new Label();
            label1 = new Label();
            trackBar1 = new TrackBar();
            track_list = new ListBox();
            btn_open = new Button();
            btn_stop = new Button();
            btn_pause = new Button();
            btn_play = new Button();
            btn_prev = new Button();
            progressBar1 = new ProgressBar();
            lbl_track_start = new Label();
            lbl_track_end = new Label();
            player = new AxWMPLib.AxWindowsMediaPlayer();
            lbl_msg = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btn_next);
            groupBox1.Controls.Add(lbl_volume);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Controls.Add(track_list);
            groupBox1.Controls.Add(btn_open);
            groupBox1.Controls.Add(btn_stop);
            groupBox1.Controls.Add(btn_pause);
            groupBox1.Controls.Add(btn_play);
            groupBox1.Controls.Add(btn_prev);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.PeachPuff;
            groupBox1.Location = new Point(12, 398);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(975, 226);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls";
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Black;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.ForeColor = Color.PaleGreen;
            btn_next.Location = new Point(309, 34);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(135, 30);
            btn_next.TabIndex = 9;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // lbl_volume
            // 
            lbl_volume.AutoSize = true;
            lbl_volume.BackColor = Color.Black;
            lbl_volume.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_volume.ForeColor = Color.PaleGreen;
            lbl_volume.Location = new Point(934, 103);
            lbl_volume.Name = "lbl_volume";
            lbl_volume.Size = new Size(26, 17);
            lbl_volume.TabIndex = 8;
            lbl_volume.Text = "0%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(873, 184);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 8;
            label1.Text = "Volume";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(883, 34);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 147);
            trackBar1.TabIndex = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // track_list
            // 
            track_list.BackColor = Color.Gray;
            track_list.ForeColor = Color.PeachPuff;
            track_list.FormattingEnabled = true;
            track_list.ItemHeight = 17;
            track_list.Location = new Point(27, 70);
            track_list.Name = "track_list";
            track_list.Size = new Size(840, 106);
            track_list.TabIndex = 5;
            track_list.SelectedIndexChanged += track_list_SelectedIndexChanged;
            // 
            // btn_open
            // 
            btn_open.BackColor = Color.Black;
            btn_open.FlatStyle = FlatStyle.Flat;
            btn_open.ForeColor = Color.PaleGreen;
            btn_open.Location = new Point(732, 34);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(135, 30);
            btn_open.TabIndex = 4;
            btn_open.Text = "Open";
            btn_open.UseVisualStyleBackColor = false;
            btn_open.Click += btn_open_Click;
            // 
            // btn_stop
            // 
            btn_stop.BackColor = Color.Black;
            btn_stop.FlatStyle = FlatStyle.Flat;
            btn_stop.ForeColor = Color.PaleGreen;
            btn_stop.Location = new Point(591, 34);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(135, 30);
            btn_stop.TabIndex = 3;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = false;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_pause
            // 
            btn_pause.BackColor = Color.Black;
            btn_pause.FlatStyle = FlatStyle.Flat;
            btn_pause.ForeColor = Color.PaleGreen;
            btn_pause.Location = new Point(450, 34);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(135, 30);
            btn_pause.TabIndex = 2;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = false;
            btn_pause.Click += btn_pause_Click;
            // 
            // btn_play
            // 
            btn_play.BackColor = Color.Black;
            btn_play.FlatStyle = FlatStyle.Flat;
            btn_play.ForeColor = Color.PaleGreen;
            btn_play.Location = new Point(168, 34);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(135, 30);
            btn_play.TabIndex = 1;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = false;
            btn_play.Click += btn_play_Click;
            // 
            // btn_prev
            // 
            btn_prev.BackColor = Color.Black;
            btn_prev.FlatStyle = FlatStyle.Flat;
            btn_prev.ForeColor = Color.PaleGreen;
            btn_prev.Location = new Point(27, 34);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new Size(135, 30);
            btn_prev.TabIndex = 0;
            btn_prev.Text = "Previous";
            btn_prev.UseVisualStyleBackColor = false;
            btn_prev.Click += button_prev_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(67, 381);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(859, 11);
            progressBar1.TabIndex = 8;
            // 
            // lbl_track_start
            // 
            lbl_track_start.AutoSize = true;
            lbl_track_start.BackColor = Color.Black;
            lbl_track_start.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_track_start.ForeColor = Color.PaleGreen;
            lbl_track_start.Location = new Point(21, 378);
            lbl_track_start.Name = "lbl_track_start";
            lbl_track_start.Size = new Size(40, 17);
            lbl_track_start.TabIndex = 9;
            lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            lbl_track_end.AutoSize = true;
            lbl_track_end.BackColor = Color.Black;
            lbl_track_end.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_track_end.ForeColor = Color.PaleGreen;
            lbl_track_end.Location = new Point(932, 375);
            lbl_track_end.Name = "lbl_track_end";
            lbl_track_end.Size = new Size(40, 17);
            lbl_track_end.TabIndex = 10;
            lbl_track_end.Text = "00:00";
            // 
            // player
            // 
            player.Enabled = true;
            player.Location = new Point(21, 12);
            player.Name = "player";
            player.OcxState = (AxHost.State)resources.GetObject("player.OcxState");
            player.Size = new Size(951, 350);
            player.TabIndex = 11;
            // 
            // lbl_msg
            // 
            lbl_msg.AutoSize = true;
            lbl_msg.BackColor = Color.Black;
            lbl_msg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_msg.ForeColor = Color.PaleGreen;
            lbl_msg.Location = new Point(21, 12);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(88, 17);
            lbl_msg.TabIndex = 7;
            lbl_msg.Text = "Media Player";
            lbl_msg.Click += lbl_msg_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(999, 636);
            Controls.Add(lbl_msg);
            Controls.Add(lbl_track_end);
            Controls.Add(lbl_track_start);
            Controls.Add(progressBar1);
            Controls.Add(groupBox1);
            Controls.Add(player);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //Created buttons for GUI Design

        private AxWMPLib.AxWindowsMediaPlayer player;
        private GroupBox groupBox1;
        private Button btn_prev;
        private Button btn_play;
        private Button btn_next;
        private Button btn_pause;
        private Button btn_stop;
        private Button btn_open;
        private TrackBar trackBar1;
        private ListBox track_list;
        private Label lbl_volume;
        private Label label1;
        private ProgressBar progressBar1;
        private Label lbl_track_start;
        private Label lbl_track_end;
        private Label lbl_msg;
        private System.Windows.Forms.Timer timer1;
        
    }
}
