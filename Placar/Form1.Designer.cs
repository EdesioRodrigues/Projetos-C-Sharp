namespace Placar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_time1 = new System.Windows.Forms.PictureBox();
            this.pb_time2 = new System.Windows.Forms.PictureBox();
            this.lb_timer = new System.Windows.Forms.Label();
            this.lb_time1 = new System.Windows.Forms.Label();
            this.lb_result1 = new System.Windows.Forms.Label();
            this.lb_result2 = new System.Windows.Forms.Label();
            this.lb_time2 = new System.Windows.Forms.Label();
            this.bt_maisTime1 = new System.Windows.Forms.Button();
            this.bt_menosTime1 = new System.Windows.Forms.Button();
            this.bt_maisTime2 = new System.Windows.Forms.Button();
            this.bt_menosTime2 = new System.Windows.Forms.Button();
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            this.initgame = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_time1
            // 
            this.pb_time1.Location = new System.Drawing.Point(12, 12);
            this.pb_time1.Name = "pb_time1";
            this.pb_time1.Size = new System.Drawing.Size(182, 183);
            this.pb_time1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_time1.TabIndex = 0;
            this.pb_time1.TabStop = false;
            // 
            // pb_time2
            // 
            this.pb_time2.Location = new System.Drawing.Point(404, 12);
            this.pb_time2.Name = "pb_time2";
            this.pb_time2.Size = new System.Drawing.Size(183, 183);
            this.pb_time2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_time2.TabIndex = 1;
            this.pb_time2.TabStop = false;
            this.pb_time2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timer.Location = new System.Drawing.Point(219, 63);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(162, 63);
            this.lb_timer.TabIndex = 2;
            this.lb_timer.Text = "00:00";
            // 
            // lb_time1
            // 
            this.lb_time1.AutoSize = true;
            this.lb_time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time1.Location = new System.Drawing.Point(54, 216);
            this.lb_time1.Name = "lb_time1";
            this.lb_time1.Size = new System.Drawing.Size(89, 20);
            this.lb_time1.TabIndex = 3;
            this.lb_time1.Text = "Corinthians";
            this.lb_time1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_result1
            // 
            this.lb_result1.AutoSize = true;
            this.lb_result1.BackColor = System.Drawing.Color.White;
            this.lb_result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result1.Location = new System.Drawing.Point(91, 256);
            this.lb_result1.Name = "lb_result1";
            this.lb_result1.Size = new System.Drawing.Size(18, 20);
            this.lb_result1.TabIndex = 4;
            this.lb_result1.Text = "0";
            // 
            // lb_result2
            // 
            this.lb_result2.AutoSize = true;
            this.lb_result2.BackColor = System.Drawing.Color.White;
            this.lb_result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result2.Location = new System.Drawing.Point(494, 256);
            this.lb_result2.Name = "lb_result2";
            this.lb_result2.Size = new System.Drawing.Size(18, 20);
            this.lb_result2.TabIndex = 5;
            this.lb_result2.Text = "0";
            // 
            // lb_time2
            // 
            this.lb_time2.AutoSize = true;
            this.lb_time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time2.Location = new System.Drawing.Point(463, 216);
            this.lb_time2.Name = "lb_time2";
            this.lb_time2.Size = new System.Drawing.Size(46, 20);
            this.lb_time2.TabIndex = 6;
            this.lb_time2.Text = "Torre";
            // 
            // bt_maisTime1
            // 
            this.bt_maisTime1.Enabled = false;
            this.bt_maisTime1.Location = new System.Drawing.Point(58, 300);
            this.bt_maisTime1.Name = "bt_maisTime1";
            this.bt_maisTime1.Size = new System.Drawing.Size(30, 30);
            this.bt_maisTime1.TabIndex = 7;
            this.bt_maisTime1.Text = "+";
            this.bt_maisTime1.UseVisualStyleBackColor = true;
            this.bt_maisTime1.Click += new System.EventHandler(this.bt_maisTime1_Click);
            // 
            // bt_menosTime1
            // 
            this.bt_menosTime1.Enabled = false;
            this.bt_menosTime1.Location = new System.Drawing.Point(118, 300);
            this.bt_menosTime1.Name = "bt_menosTime1";
            this.bt_menosTime1.Size = new System.Drawing.Size(30, 30);
            this.bt_menosTime1.TabIndex = 8;
            this.bt_menosTime1.Text = "-";
            this.bt_menosTime1.UseVisualStyleBackColor = true;
            this.bt_menosTime1.Click += new System.EventHandler(this.bt_menosTime1_Click);
            // 
            // bt_maisTime2
            // 
            this.bt_maisTime2.Enabled = false;
            this.bt_maisTime2.Location = new System.Drawing.Point(458, 300);
            this.bt_maisTime2.Name = "bt_maisTime2";
            this.bt_maisTime2.Size = new System.Drawing.Size(30, 30);
            this.bt_maisTime2.TabIndex = 9;
            this.bt_maisTime2.Text = "+";
            this.bt_maisTime2.UseVisualStyleBackColor = true;
            this.bt_maisTime2.Click += new System.EventHandler(this.bt_maisTime2_Click);
            // 
            // bt_menosTime2
            // 
            this.bt_menosTime2.Enabled = false;
            this.bt_menosTime2.Location = new System.Drawing.Point(520, 300);
            this.bt_menosTime2.Name = "bt_menosTime2";
            this.bt_menosTime2.Size = new System.Drawing.Size(30, 30);
            this.bt_menosTime2.TabIndex = 10;
            this.bt_menosTime2.Text = "-";
            this.bt_menosTime2.UseVisualStyleBackColor = true;
            this.bt_menosTime2.Click += new System.EventHandler(this.bt_menosTime2_Click);
            // 
            // cronometro
            // 
            this.cronometro.Interval = 1000;
            this.cronometro.Tick += new System.EventHandler(this.cronometro_Tick);
            // 
            // initgame
            // 
            this.initgame.AutoSize = true;
            this.initgame.Location = new System.Drawing.Point(271, 163);
            this.initgame.Name = "initgame";
            this.initgame.Size = new System.Drawing.Size(53, 13);
            this.initgame.TabIndex = 11;
            this.initgame.Text = "1º Tempo";
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(249, 209);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(96, 37);
            this.iniciar.TabIndex = 12;
            this.iniciar.Text = "Iniciar Jogo";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 391);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.initgame);
            this.Controls.Add(this.bt_menosTime2);
            this.Controls.Add(this.bt_maisTime2);
            this.Controls.Add(this.bt_menosTime1);
            this.Controls.Add(this.bt_maisTime1);
            this.Controls.Add(this.lb_time2);
            this.Controls.Add(this.lb_result2);
            this.Controls.Add(this.lb_result1);
            this.Controls.Add(this.lb_time1);
            this.Controls.Add(this.lb_timer);
            this.Controls.Add(this.pb_time2);
            this.Controls.Add(this.pb_time1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_time1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_time1;
        private System.Windows.Forms.PictureBox pb_time2;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Label lb_time1;
        private System.Windows.Forms.Label lb_result1;
        private System.Windows.Forms.Label lb_result2;
        private System.Windows.Forms.Label lb_time2;
        private System.Windows.Forms.Button bt_maisTime1;
        private System.Windows.Forms.Button bt_menosTime1;
        private System.Windows.Forms.Button bt_maisTime2;
        private System.Windows.Forms.Button bt_menosTime2;
        private System.Windows.Forms.Timer cronometro;
        private System.Windows.Forms.Label initgame;
        private System.Windows.Forms.Button iniciar;
    }
}

