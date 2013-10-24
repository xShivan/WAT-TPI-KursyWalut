namespace Kursy_Walut
{
    partial class windowMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobierzKursyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewKursy = new System.Windows.Forms.ListView();
            this.colJednostka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWartosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(502, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pobierzKursyToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // pobierzKursyToolStripMenuItem
            // 
            this.pobierzKursyToolStripMenuItem.Name = "pobierzKursyToolStripMenuItem";
            this.pobierzKursyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pobierzKursyToolStripMenuItem.Text = "Pobierz kursy";
            this.pobierzKursyToolStripMenuItem.Click += new System.EventHandler(this.pobierzKursyToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // listViewKursy
            // 
            this.listViewKursy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewKursy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colJednostka,
            this.colWartosc});
            this.listViewKursy.Location = new System.Drawing.Point(12, 27);
            this.listViewKursy.Name = "listViewKursy";
            this.listViewKursy.Size = new System.Drawing.Size(478, 365);
            this.listViewKursy.TabIndex = 1;
            this.listViewKursy.UseCompatibleStateImageBehavior = false;
            this.listViewKursy.View = System.Windows.Forms.View.Details;
            // 
            // colJednostka
            // 
            this.colJednostka.Text = "Jednostka";
            this.colJednostka.Width = 120;
            // 
            // colWartosc
            // 
            this.colWartosc.Text = "Wartość";
            // 
            // windowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 404);
            this.Controls.Add(this.listViewKursy);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "windowMain";
            this.Text = "Kursy walut";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pobierzKursyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ListView listViewKursy;
        private System.Windows.Forms.ColumnHeader colJednostka;
        private System.Windows.Forms.ColumnHeader colWartosc;
    }
}

