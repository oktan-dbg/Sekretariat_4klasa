namespace Sekretariat
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.search_btn = new System.Windows.Forms.Button();
            this.kryteria_inp = new System.Windows.Forms.TextBox();
            this.zadanie_cmbbox = new System.Windows.Forms.ComboBox();
            this.kategoria_cmbbox = new System.Windows.Forms.ComboBox();
            this.wynik_rich = new System.Windows.Forms.RichTextBox();
            this.wczytanie_txt = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_btn = new System.Windows.Forms.Button();
            this.klasa_inp = new System.Windows.Forms.TextBox();
            this.klasa_txt = new System.Windows.Forms.Label();
            this.nazwisko_inp = new System.Windows.Forms.TextBox();
            this.imie_inp = new System.Windows.Forms.TextBox();
            this.nazwisko_txt = new System.Windows.Forms.Label();
            this.imie_txt = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.search_btn);
            this.tabPage1.Controls.Add(this.kryteria_inp);
            this.tabPage1.Controls.Add(this.zadanie_cmbbox);
            this.tabPage1.Controls.Add(this.kategoria_cmbbox);
            this.tabPage1.Controls.Add(this.wynik_rich);
            this.tabPage1.Controls.Add(this.wczytanie_txt);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "wyczukaj ucznia/uczniów";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(675, 113);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(94, 29);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "Wyszukaj";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // kryteria_inp
            // 
            this.kryteria_inp.Location = new System.Drawing.Point(418, 81);
            this.kryteria_inp.Name = "kryteria_inp";
            this.kryteria_inp.Size = new System.Drawing.Size(283, 27);
            this.kryteria_inp.TabIndex = 5;
            // 
            // zadanie_cmbbox
            // 
            this.zadanie_cmbbox.AutoCompleteCustomSource.AddRange(new string[] {
            "zaczyna się od",
            "kończy się na ",
            "jest równe"});
            this.zadanie_cmbbox.FormattingEnabled = true;
            this.zadanie_cmbbox.Items.AddRange(new object[] {
            "zaczyna się od",
            "zawiera",
            "jest równe"});
            this.zadanie_cmbbox.Location = new System.Drawing.Point(236, 80);
            this.zadanie_cmbbox.Name = "zadanie_cmbbox";
            this.zadanie_cmbbox.Size = new System.Drawing.Size(151, 28);
            this.zadanie_cmbbox.TabIndex = 4;
            // 
            // kategoria_cmbbox
            // 
            this.kategoria_cmbbox.AutoCompleteCustomSource.AddRange(new string[] {
            "imie",
            "nazwisko",
            "klasa",
            "id"});
            this.kategoria_cmbbox.FormattingEnabled = true;
            this.kategoria_cmbbox.Items.AddRange(new object[] {
            "Imie",
            "Nazwisko",
            "Klasa"});
            this.kategoria_cmbbox.Location = new System.Drawing.Point(30, 80);
            this.kategoria_cmbbox.Name = "kategoria_cmbbox";
            this.kategoria_cmbbox.Size = new System.Drawing.Size(151, 28);
            this.kategoria_cmbbox.TabIndex = 3;
            // 
            // wynik_rich
            // 
            this.wynik_rich.Location = new System.Drawing.Point(9, 145);
            this.wynik_rich.Name = "wynik_rich";
            this.wynik_rich.Size = new System.Drawing.Size(776, 264);
            this.wynik_rich.TabIndex = 2;
            this.wynik_rich.Text = "";
            // 
            // wczytanie_txt
            // 
            this.wczytanie_txt.AutoSize = true;
            this.wczytanie_txt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wczytanie_txt.Location = new System.Drawing.Point(30, 32);
            this.wczytanie_txt.Name = "wczytanie_txt";
            this.wczytanie_txt.Size = new System.Drawing.Size(372, 35);
            this.wczytanie_txt.TabIndex = 1;
            this.wczytanie_txt.Text = "Wczytaj kryteria wyszukiwania";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_btn);
            this.tabPage2.Controls.Add(this.klasa_inp);
            this.tabPage2.Controls.Add(this.klasa_txt);
            this.tabPage2.Controls.Add(this.nazwisko_inp);
            this.tabPage2.Controls.Add(this.imie_inp);
            this.tabPage2.Controls.Add(this.nazwisko_txt);
            this.tabPage2.Controls.Add(this.imie_txt);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj ucznia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(517, 253);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(156, 39);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Dodaj";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // klasa_inp
            // 
            this.klasa_inp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.klasa_inp.Location = new System.Drawing.Point(262, 173);
            this.klasa_inp.Name = "klasa_inp";
            this.klasa_inp.Size = new System.Drawing.Size(293, 41);
            this.klasa_inp.TabIndex = 11;
            // 
            // klasa_txt
            // 
            this.klasa_txt.AutoSize = true;
            this.klasa_txt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.klasa_txt.Location = new System.Drawing.Point(115, 173);
            this.klasa_txt.Name = "klasa_txt";
            this.klasa_txt.Size = new System.Drawing.Size(75, 35);
            this.klasa_txt.TabIndex = 10;
            this.klasa_txt.Text = "Klasa";
            // 
            // nazwisko_inp
            // 
            this.nazwisko_inp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwisko_inp.Location = new System.Drawing.Point(262, 106);
            this.nazwisko_inp.Name = "nazwisko_inp";
            this.nazwisko_inp.Size = new System.Drawing.Size(293, 41);
            this.nazwisko_inp.TabIndex = 9;
            // 
            // imie_inp
            // 
            this.imie_inp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imie_inp.Location = new System.Drawing.Point(262, 35);
            this.imie_inp.Name = "imie_inp";
            this.imie_inp.Size = new System.Drawing.Size(293, 41);
            this.imie_inp.TabIndex = 8;
            // 
            // nazwisko_txt
            // 
            this.nazwisko_txt.AutoSize = true;
            this.nazwisko_txt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nazwisko_txt.Location = new System.Drawing.Point(115, 106);
            this.nazwisko_txt.Name = "nazwisko_txt";
            this.nazwisko_txt.Size = new System.Drawing.Size(127, 35);
            this.nazwisko_txt.TabIndex = 7;
            this.nazwisko_txt.Text = "Nazwisko";
            // 
            // imie_txt
            // 
            this.imie_txt.AutoSize = true;
            this.imie_txt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imie_txt.Location = new System.Drawing.Point(115, 35);
            this.imie_txt.Name = "imie_txt";
            this.imie_txt.Size = new System.Drawing.Size(67, 35);
            this.imie_txt.TabIndex = 6;
            this.imie_txt.Text = "Imie";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button search_btn;
        private TextBox kryteria_inp;
        private ComboBox zadanie_cmbbox;
        private ComboBox kategoria_cmbbox;
        private RichTextBox wynik_rich;
        private Label wczytanie_txt;
        private Button add_btn;
        private TextBox klasa_inp;
        private Label klasa_txt;
        private TextBox nazwisko_inp;
        private TextBox imie_inp;
        private Label nazwisko_txt;
        private Label imie_txt;
    }
}