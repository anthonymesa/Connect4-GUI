namespace Connect4
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
            this.move_col_1 = new System.Windows.Forms.Button();
            this.mov_col_2 = new System.Windows.Forms.Button();
            this.mov_col_3 = new System.Windows.Forms.Button();
            this.mov_col_4 = new System.Windows.Forms.Button();
            this.mov_col_5 = new System.Windows.Forms.Button();
            this.mov_col_6 = new System.Windows.Forms.Button();
            this.mov_col_7 = new System.Windows.Forms.Button();
            this.player_1_name = new System.Windows.Forms.TextBox();
            this.player_2_name = new System.Windows.Forms.TextBox();
            this.new_game = new System.Windows.Forms.Button();
            this.quit_game = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.game_view = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.game_view)).BeginInit();
            this.SuspendLayout();
            // 
            // move_col_1
            // 
            this.move_col_1.Location = new System.Drawing.Point(80, 103);
            this.move_col_1.Name = "move_col_1";
            this.move_col_1.Size = new System.Drawing.Size(50, 25);
            this.move_col_1.TabIndex = 3;
            this.move_col_1.Text = "V";
            this.move_col_1.UseVisualStyleBackColor = true;
            this.move_col_1.Click += new System.EventHandler(this.mov_col_1_Click);
            // 
            // mov_col_2
            // 
            this.mov_col_2.Location = new System.Drawing.Point(180, 103);
            this.mov_col_2.Name = "mov_col_2";
            this.mov_col_2.Size = new System.Drawing.Size(50, 25);
            this.mov_col_2.TabIndex = 4;
            this.mov_col_2.Text = "V";
            this.mov_col_2.UseVisualStyleBackColor = true;
            this.mov_col_2.Click += new System.EventHandler(this.mov_col_2_Click);
            // 
            // mov_col_3
            // 
            this.mov_col_3.Location = new System.Drawing.Point(280, 103);
            this.mov_col_3.Name = "mov_col_3";
            this.mov_col_3.Size = new System.Drawing.Size(50, 25);
            this.mov_col_3.TabIndex = 5;
            this.mov_col_3.Text = "V";
            this.mov_col_3.UseVisualStyleBackColor = true;
            this.mov_col_3.Click += new System.EventHandler(this.mov_col_3_Click);
            // 
            // mov_col_4
            // 
            this.mov_col_4.Location = new System.Drawing.Point(380, 103);
            this.mov_col_4.Name = "mov_col_4";
            this.mov_col_4.Size = new System.Drawing.Size(50, 25);
            this.mov_col_4.TabIndex = 6;
            this.mov_col_4.Text = "V";
            this.mov_col_4.UseVisualStyleBackColor = true;
            this.mov_col_4.Click += new System.EventHandler(this.mov_col_4_Click);
            // 
            // mov_col_5
            // 
            this.mov_col_5.Location = new System.Drawing.Point(480, 103);
            this.mov_col_5.Name = "mov_col_5";
            this.mov_col_5.Size = new System.Drawing.Size(50, 25);
            this.mov_col_5.TabIndex = 7;
            this.mov_col_5.Text = "V";
            this.mov_col_5.UseVisualStyleBackColor = true;
            this.mov_col_5.Click += new System.EventHandler(this.mov_col_5_Click);
            // 
            // mov_col_6
            // 
            this.mov_col_6.Location = new System.Drawing.Point(580, 103);
            this.mov_col_6.Name = "mov_col_6";
            this.mov_col_6.Size = new System.Drawing.Size(50, 25);
            this.mov_col_6.TabIndex = 8;
            this.mov_col_6.Text = "V";
            this.mov_col_6.UseVisualStyleBackColor = true;
            this.mov_col_6.Click += new System.EventHandler(this.mov_col_6_Click);
            // 
            // mov_col_7
            // 
            this.mov_col_7.Location = new System.Drawing.Point(680, 103);
            this.mov_col_7.Name = "mov_col_7";
            this.mov_col_7.Size = new System.Drawing.Size(50, 25);
            this.mov_col_7.TabIndex = 9;
            this.mov_col_7.Text = "V";
            this.mov_col_7.UseVisualStyleBackColor = true;
            this.mov_col_7.Click += new System.EventHandler(this.mov_col_7_Click);
            // 
            // player_1_name
            // 
            this.player_1_name.Location = new System.Drawing.Point(79, 28);
            this.player_1_name.Name = "player_1_name";
            this.player_1_name.Size = new System.Drawing.Size(175, 20);
            this.player_1_name.TabIndex = 7;
            // 
            // player_2_name
            // 
            this.player_2_name.Location = new System.Drawing.Point(279, 28);
            this.player_2_name.Name = "player_2_name";
            this.player_2_name.Size = new System.Drawing.Size(176, 20);
            this.player_2_name.TabIndex = 7;
            // 
            // new_game
            // 
            this.new_game.Location = new System.Drawing.Point(479, 25);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(74, 23);
            this.new_game.TabIndex = 1;
            this.new_game.Text = "New Game";
            this.new_game.UseVisualStyleBackColor = true;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // quit_game
            // 
            this.quit_game.Location = new System.Drawing.Point(654, 26);
            this.quit_game.Name = "quit_game";
            this.quit_game.Size = new System.Drawing.Size(75, 23);
            this.quit_game.TabIndex = 2;
            this.quit_game.Text = "Quit Game";
            this.quit_game.UseVisualStyleBackColor = true;
            this.quit_game.Click += new System.EventHandler(this.quit_game_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Red Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yellow Player Name";
            // 
            // status_label
            // 
            this.status_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.status_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.status_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.status_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status_label.Location = new System.Drawing.Point(79, 63);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(653, 24);
            this.status_label.TabIndex = 9;
            this.status_label.Text = "~ Click \'New Game\' to begin.";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // game_view
            // 
            this.game_view.Location = new System.Drawing.Point(79, 157);
            this.game_view.Name = "game_view";
            this.game_view.Size = new System.Drawing.Size(653, 557);
            this.game_view.TabIndex = 10;
            this.game_view.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(806, 781);
            this.Controls.Add(this.game_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quit_game);
            this.Controls.Add(this.new_game);
            this.Controls.Add(this.player_2_name);
            this.Controls.Add(this.player_1_name);
            this.Controls.Add(this.mov_col_7);
            this.Controls.Add(this.mov_col_6);
            this.Controls.Add(this.mov_col_5);
            this.Controls.Add(this.mov_col_4);
            this.Controls.Add(this.mov_col_3);
            this.Controls.Add(this.mov_col_2);
            this.Controls.Add(this.move_col_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Connect 4 - Anthony";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.game_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button move_col_1;
        private System.Windows.Forms.Button mov_col_2;
        private System.Windows.Forms.Button mov_col_3;
        private System.Windows.Forms.Button mov_col_4;
        private System.Windows.Forms.Button mov_col_5;
        private System.Windows.Forms.Button mov_col_6;
        private System.Windows.Forms.Button mov_col_7;
        private System.Windows.Forms.TextBox player_1_name;
        private System.Windows.Forms.TextBox player_2_name;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Button quit_game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.PictureBox game_view;
    }
}

