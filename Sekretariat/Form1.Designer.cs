namespace Sekretariat
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
            this.user_txt = new System.Windows.Forms.Label();
            this.haslo_txt = new System.Windows.Forms.Label();
            this.verification_txt = new System.Windows.Forms.Label();
            this.tresc_weryfikacja_txt = new System.Windows.Forms.Label();
            this.user_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.weryfikacja_img = new System.Windows.Forms.PictureBox();
            this.kod_inp = new System.Windows.Forms.TextBox();
            this.losuj_link = new System.Windows.Forms.LinkLabel();
            this.zaloguj_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weryfikacja_img)).BeginInit();
            this.SuspendLayout();
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_txt.Location = new System.Drawing.Point(29, 32);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(153, 35);
            this.user_txt.TabIndex = 0;
            this.user_txt.Text = "Użytkownik";
            // 
            // haslo_txt
            // 
            this.haslo_txt.AutoSize = true;
            this.haslo_txt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.haslo_txt.Location = new System.Drawing.Point(101, 76);
            this.haslo_txt.Name = "haslo_txt";
            this.haslo_txt.Size = new System.Drawing.Size(81, 35);
            this.haslo_txt.TabIndex = 1;
            this.haslo_txt.Text = "Hasło";
            // 
            // verification_txt
            // 
            this.verification_txt.AutoSize = true;
            this.verification_txt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verification_txt.Location = new System.Drawing.Point(12, 128);
            this.verification_txt.Name = "verification_txt";
            this.verification_txt.Size = new System.Drawing.Size(208, 46);
            this.verification_txt.TabIndex = 2;
            this.verification_txt.Text = "Weryfikacja";
            // 
            // tresc_weryfikacja_txt
            // 
            this.tresc_weryfikacja_txt.AutoSize = true;
            this.tresc_weryfikacja_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tresc_weryfikacja_txt.Location = new System.Drawing.Point(44, 184);
            this.tresc_weryfikacja_txt.Name = "tresc_weryfikacja_txt";
            this.tresc_weryfikacja_txt.Size = new System.Drawing.Size(437, 23);
            this.tresc_weryfikacja_txt.TabIndex = 3;
            this.tresc_weryfikacja_txt.Text = "Wpisz znaki, które widzisz na obrazku, aby kontynuować";
            // 
            // user_input
            // 
            this.user_input.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_input.Location = new System.Drawing.Point(188, 26);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(293, 41);
            this.user_input.TabIndex = 4;
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_input.Location = new System.Drawing.Point(188, 76);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(293, 41);
            this.password_input.TabIndex = 5;
            // 
            // weryfikacja_img
            // 
            this.weryfikacja_img.Location = new System.Drawing.Point(12, 233);
            this.weryfikacja_img.Name = "weryfikacja_img";
            this.weryfikacja_img.Size = new System.Drawing.Size(137, 89);
            this.weryfikacja_img.TabIndex = 6;
            this.weryfikacja_img.TabStop = false;
            // 
            // kod_inp
            // 
            this.kod_inp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kod_inp.Location = new System.Drawing.Point(168, 233);
            this.kod_inp.Name = "kod_inp";
            this.kod_inp.Size = new System.Drawing.Size(313, 41);
            this.kod_inp.TabIndex = 7;
            // 
            // losuj_link
            // 
            this.losuj_link.AutoSize = true;
            this.losuj_link.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.losuj_link.LinkColor = System.Drawing.Color.Black;
            this.losuj_link.Location = new System.Drawing.Point(168, 287);
            this.losuj_link.Name = "losuj_link";
            this.losuj_link.Size = new System.Drawing.Size(77, 20);
            this.losuj_link.TabIndex = 8;
            this.losuj_link.TabStop = true;
            this.losuj_link.Text = "losuj nowy";
            this.losuj_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.losuj_link_LinkClicked);
            // 
            // zaloguj_btn
            // 
            this.zaloguj_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zaloguj_btn.Location = new System.Drawing.Point(401, 300);
            this.zaloguj_btn.Name = "zaloguj_btn";
            this.zaloguj_btn.Size = new System.Drawing.Size(151, 48);
            this.zaloguj_btn.TabIndex = 9;
            this.zaloguj_btn.Text = "Zaloguj";
            this.zaloguj_btn.UseVisualStyleBackColor = true;
            this.zaloguj_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 374);
            this.Controls.Add(this.zaloguj_btn);
            this.Controls.Add(this.losuj_link);
            this.Controls.Add(this.kod_inp);
            this.Controls.Add(this.weryfikacja_img);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.tresc_weryfikacja_txt);
            this.Controls.Add(this.verification_txt);
            this.Controls.Add(this.haslo_txt);
            this.Controls.Add(this.user_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.weryfikacja_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label user_txt;
        private Label haslo_txt;
        private Label verification_txt;
        private Label tresc_weryfikacja_txt;
        private TextBox user_input;
        private TextBox password_input;
        private PictureBox weryfikacja_img;
        private TextBox kod_inp;
        private LinkLabel losuj_link;
        private Button zaloguj_btn;
    }
}