namespace HexGame
{
    partial class new_game_form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_game_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.red_player_type_prompt = new System.Windows.Forms.ComboBox();
            this.blue_player_type_prompt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_size_prompt = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_size_prompt)).BeginInit();
            this.SuspendLayout();
            // 
            // start_game_button
            // 
            this.start_game_button.Location = new System.Drawing.Point(12, 242);
            this.start_game_button.Name = "start_game_button";
            this.start_game_button.Size = new System.Drawing.Size(261, 51);
            this.start_game_button.TabIndex = 0;
            this.start_game_button.Text = "Nouvelle partie";
            this.start_game_button.UseVisualStyleBackColor = true;
            this.start_game_button.Click += new System.EventHandler(this.start_game_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.red_player_type_prompt);
            this.groupBox1.Controls.Add(this.blue_player_type_prompt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joueurs";
            // 
            // red_player_type_prompt
            // 
            this.red_player_type_prompt.BackColor = System.Drawing.Color.Red;
            this.red_player_type_prompt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.red_player_type_prompt.ForeColor = System.Drawing.SystemColors.Window;
            this.red_player_type_prompt.FormattingEnabled = true;
            this.red_player_type_prompt.Items.AddRange(new object[] {
            "Joueur",
            "AI BruteForce (1)"});
            this.red_player_type_prompt.Location = new System.Drawing.Point(19, 76);
            this.red_player_type_prompt.Name = "red_player_type_prompt";
            this.red_player_type_prompt.Size = new System.Drawing.Size(220, 21);
            this.red_player_type_prompt.TabIndex = 5;
            this.red_player_type_prompt.SelectedIndexChanged += new System.EventHandler(this.red_player_type_prompt_SelectedIndexChanged);
            // 
            // blue_player_type_prompt
            // 
            this.blue_player_type_prompt.BackColor = System.Drawing.Color.Blue;
            this.blue_player_type_prompt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blue_player_type_prompt.ForeColor = System.Drawing.SystemColors.Window;
            this.blue_player_type_prompt.FormattingEnabled = true;
            this.blue_player_type_prompt.Items.AddRange(new object[] {
            "Joueur",
            "AI BruteForce (1)"});
            this.blue_player_type_prompt.Location = new System.Drawing.Point(19, 36);
            this.blue_player_type_prompt.Name = "blue_player_type_prompt";
            this.blue_player_type_prompt.Size = new System.Drawing.Size(220, 21);
            this.blue_player_type_prompt.TabIndex = 4;
            this.blue_player_type_prompt.SelectedIndexChanged += new System.EventHandler(this.blue_player_type_prompt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONTRE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.grid_size_prompt);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paramètres de partie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taille de la grille (n x n) :";
            // 
            // grid_size_prompt
            // 
            this.grid_size_prompt.Location = new System.Drawing.Point(19, 53);
            this.grid_size_prompt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.grid_size_prompt.Name = "grid_size_prompt";
            this.grid_size_prompt.Size = new System.Drawing.Size(220, 20);
            this.grid_size_prompt.TabIndex = 3;
            this.grid_size_prompt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // new_game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.start_game_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "new_game_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HEX - Nouvelle Partie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_size_prompt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_game_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox red_player_type_prompt;
        private System.Windows.Forms.ComboBox blue_player_type_prompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown grid_size_prompt;
    }
}

