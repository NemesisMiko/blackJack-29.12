namespace WindowsFormsApp2
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
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_stand = new System.Windows.Forms.Button();
            this.btn_split = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_25 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.txt_chips = new System.Windows.Forms.RichTextBox();
            this.btn_allIn = new System.Windows.Forms.Button();
            this.btn_deal = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_curent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_dealer = new System.Windows.Forms.ListBox();
            this.lst_player = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lst_split = new System.Windows.Forms.ListBox();
            this.lst_display = new System.Windows.Forms.ListBox();
            this.lst_dealer_display = new System.Windows.Forms.ListBox();
            this.lst_split_display = new System.Windows.Forms.ListBox();
            this.lbl_player_points_1 = new System.Windows.Forms.Label();
            this.lst_dealer_points = new System.Windows.Forms.Label();
            this.lbl_player_hand_1 = new System.Windows.Forms.Label();
            this.lbl_dealer_hand = new System.Windows.Forms.Label();
            this.lbl_player_hand_2 = new System.Windows.Forms.Label();
            this.lbl_player_points_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hit
            // 
            this.btn_hit.Location = new System.Drawing.Point(279, 334);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(93, 35);
            this.btn_hit.TabIndex = 1;
            this.btn_hit.Text = "Hit";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Visible = false;
            this.btn_hit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.Location = new System.Drawing.Point(387, 334);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(93, 35);
            this.btn_stand.TabIndex = 2;
            this.btn_stand.Text = "Stand";
            this.btn_stand.UseVisualStyleBackColor = true;
            this.btn_stand.Visible = false;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // btn_split
            // 
            this.btn_split.Location = new System.Drawing.Point(496, 334);
            this.btn_split.Name = "btn_split";
            this.btn_split.Size = new System.Drawing.Size(93, 35);
            this.btn_split.TabIndex = 3;
            this.btn_split.Text = "Split";
            this.btn_split.UseVisualStyleBackColor = true;
            this.btn_split.Visible = false;
            this.btn_split.Click += new System.EventHandler(this.btn_split_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(173, 97);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(40, 40);
            this.btn_1.TabIndex = 8;
            this.btn_1.Text = "1€";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(171, 153);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(40, 40);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5€";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_10
            // 
            this.btn_10.Location = new System.Drawing.Point(171, 214);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(40, 40);
            this.btn_10.TabIndex = 10;
            this.btn_10.Text = "10€";
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_25
            // 
            this.btn_25.Location = new System.Drawing.Point(226, 97);
            this.btn_25.Name = "btn_25";
            this.btn_25.Size = new System.Drawing.Size(40, 40);
            this.btn_25.TabIndex = 11;
            this.btn_25.Text = "25€";
            this.btn_25.UseVisualStyleBackColor = true;
            this.btn_25.Click += new System.EventHandler(this.btn_25_Click);
            // 
            // btn_50
            // 
            this.btn_50.Location = new System.Drawing.Point(226, 153);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(40, 40);
            this.btn_50.TabIndex = 12;
            this.btn_50.Text = "50€";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_100
            // 
            this.btn_100.Location = new System.Drawing.Point(226, 214);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(40, 40);
            this.btn_100.TabIndex = 13;
            this.btn_100.Text = "100€";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // txt_chips
            // 
            this.txt_chips.Location = new System.Drawing.Point(171, 35);
            this.txt_chips.Name = "txt_chips";
            this.txt_chips.ReadOnly = true;
            this.txt_chips.Size = new System.Drawing.Size(95, 40);
            this.txt_chips.TabIndex = 17;
            this.txt_chips.Text = "";
            // 
            // btn_allIn
            // 
            this.btn_allIn.Location = new System.Drawing.Point(171, 270);
            this.btn_allIn.Name = "btn_allIn";
            this.btn_allIn.Size = new System.Drawing.Size(95, 40);
            this.btn_allIn.TabIndex = 15;
            this.btn_allIn.Text = "All in";
            this.btn_allIn.UseVisualStyleBackColor = true;
            this.btn_allIn.Click += new System.EventHandler(this.btn_allIn_Click);
            // 
            // btn_deal
            // 
            this.btn_deal.Location = new System.Drawing.Point(34, 165);
            this.btn_deal.Name = "btn_deal";
            this.btn_deal.Size = new System.Drawing.Size(95, 89);
            this.btn_deal.TabIndex = 16;
            this.btn_deal.Text = "Deal";
            this.btn_deal.UseVisualStyleBackColor = true;
            this.btn_deal.Click += new System.EventHandler(this.button13_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txt_curent
            // 
            this.txt_curent.Location = new System.Drawing.Point(34, 35);
            this.txt_curent.Name = "txt_curent";
            this.txt_curent.ReadOnly = true;
            this.txt_curent.Size = new System.Drawing.Size(95, 40);
            this.txt_curent.TabIndex = 17;
            this.txt_curent.Text = "";
            this.txt_curent.TextChanged += new System.EventHandler(this.txt_curent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total Chips";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Curently betting";
            // 
            // lst_dealer
            // 
            this.lst_dealer.Location = new System.Drawing.Point(376, 35);
            this.lst_dealer.Name = "lst_dealer";
            this.lst_dealer.Size = new System.Drawing.Size(120, 95);
            this.lst_dealer.TabIndex = 0;
            // 
            // lst_player
            // 
            this.lst_player.Location = new System.Drawing.Point(376, 177);
            this.lst_player.Name = "lst_player";
            this.lst_player.Size = new System.Drawing.Size(120, 95);
            this.lst_player.TabIndex = 20;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(34, 270);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 39);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear bet";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lst_split
            // 
            this.lst_split.Location = new System.Drawing.Point(513, 177);
            this.lst_split.Name = "lst_split";
            this.lst_split.Size = new System.Drawing.Size(120, 95);
            this.lst_split.TabIndex = 22;
            this.lst_split.Visible = false;
            // 
            // lst_display
            // 
            this.lst_display.FormattingEnabled = true;
            this.lst_display.Location = new System.Drawing.Point(681, 177);
            this.lst_display.Name = "lst_display";
            this.lst_display.Size = new System.Drawing.Size(120, 95);
            this.lst_display.TabIndex = 23;
            // 
            // lst_dealer_display
            // 
            this.lst_dealer_display.FormattingEnabled = true;
            this.lst_dealer_display.Location = new System.Drawing.Point(681, 35);
            this.lst_dealer_display.Name = "lst_dealer_display";
            this.lst_dealer_display.Size = new System.Drawing.Size(120, 95);
            this.lst_dealer_display.TabIndex = 24;
            // 
            // lst_split_display
            // 
            this.lst_split_display.FormattingEnabled = true;
            this.lst_split_display.Location = new System.Drawing.Point(799, 177);
            this.lst_split_display.Name = "lst_split_display";
            this.lst_split_display.Size = new System.Drawing.Size(120, 95);
            this.lst_split_display.TabIndex = 25;
            this.lst_split_display.Visible = false;
            // 
            // lbl_player_points_1
            // 
            this.lbl_player_points_1.AutoSize = true;
            this.lbl_player_points_1.Location = new System.Drawing.Point(710, 153);
            this.lbl_player_points_1.Name = "lbl_player_points_1";
            this.lbl_player_points_1.Size = new System.Drawing.Size(67, 13);
            this.lbl_player_points_1.TabIndex = 26;
            this.lbl_player_points_1.Text = "Player points";
            // 
            // lst_dealer_points
            // 
            this.lst_dealer_points.AutoSize = true;
            this.lst_dealer_points.Location = new System.Drawing.Point(710, 9);
            this.lst_dealer_points.Name = "lst_dealer_points";
            this.lst_dealer_points.Size = new System.Drawing.Size(69, 13);
            this.lst_dealer_points.TabIndex = 27;
            this.lst_dealer_points.Text = "Dealer points";
            // 
            // lbl_player_hand_1
            // 
            this.lbl_player_hand_1.AutoSize = true;
            this.lbl_player_hand_1.Location = new System.Drawing.Point(405, 153);
            this.lbl_player_hand_1.Name = "lbl_player_hand_1";
            this.lbl_player_hand_1.Size = new System.Drawing.Size(66, 13);
            this.lbl_player_hand_1.TabIndex = 28;
            this.lbl_player_hand_1.Text = "Player hand ";
            // 
            // lbl_dealer_hand
            // 
            this.lbl_dealer_hand.AutoSize = true;
            this.lbl_dealer_hand.Location = new System.Drawing.Point(405, 9);
            this.lbl_dealer_hand.Name = "lbl_dealer_hand";
            this.lbl_dealer_hand.Size = new System.Drawing.Size(65, 13);
            this.lbl_dealer_hand.TabIndex = 29;
            this.lbl_dealer_hand.Text = "Dealer hand";
            // 
            // lbl_player_hand_2
            // 
            this.lbl_player_hand_2.AutoSize = true;
            this.lbl_player_hand_2.Location = new System.Drawing.Point(651, 334);
            this.lbl_player_hand_2.Name = "lbl_player_hand_2";
            this.lbl_player_hand_2.Size = new System.Drawing.Size(72, 13);
            this.lbl_player_hand_2.TabIndex = 30;
            this.lbl_player_hand_2.Text = "Player hand 2";
            this.lbl_player_hand_2.Visible = false;
            // 
            // lbl_player_points_2
            // 
            this.lbl_player_points_2.AutoSize = true;
            this.lbl_player_points_2.Location = new System.Drawing.Point(761, 334);
            this.lbl_player_points_2.Name = "lbl_player_points_2";
            this.lbl_player_points_2.Size = new System.Drawing.Size(76, 13);
            this.lbl_player_points_2.TabIndex = 31;
            this.lbl_player_points_2.Text = "Player points 2";
            this.lbl_player_points_2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.lbl_player_points_2);
            this.Controls.Add(this.lbl_player_hand_2);
            this.Controls.Add(this.lbl_dealer_hand);
            this.Controls.Add(this.lbl_player_hand_1);
            this.Controls.Add(this.lst_dealer_points);
            this.Controls.Add(this.lbl_player_points_1);
            this.Controls.Add(this.lst_split_display);
            this.Controls.Add(this.lst_dealer_display);
            this.Controls.Add(this.lst_display);
            this.Controls.Add(this.lst_split);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lst_player);
            this.Controls.Add(this.lst_dealer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_curent);
            this.Controls.Add(this.btn_deal);
            this.Controls.Add(this.btn_allIn);
            this.Controls.Add(this.txt_chips);
            this.Controls.Add(this.btn_100);
            this.Controls.Add(this.btn_50);
            this.Controls.Add(this.btn_25);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_split);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.btn_hit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_hit;
        private System.Windows.Forms.Button btn_stand;
        private System.Windows.Forms.Button btn_split;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_25;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.RichTextBox txt_chips;
        private System.Windows.Forms.Button btn_allIn;
        private System.Windows.Forms.Button btn_deal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox txt_curent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_dealer;
        private System.Windows.Forms.ListBox lst_player;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox lst_split;
        private System.Windows.Forms.ListBox lst_display;
        private System.Windows.Forms.ListBox lst_dealer_display;
        private System.Windows.Forms.ListBox lst_split_display;
        private System.Windows.Forms.Label lbl_player_points_1;
        private System.Windows.Forms.Label lst_dealer_points;
        private System.Windows.Forms.Label lbl_player_hand_1;
        private System.Windows.Forms.Label lbl_dealer_hand;
        private System.Windows.Forms.Label lbl_player_hand_2;
        private System.Windows.Forms.Label lbl_player_points_2;
    }
}

