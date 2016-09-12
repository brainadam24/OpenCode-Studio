namespace OpenCode_Studio
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Berichte = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompilierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausführenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompilierenUndAusführenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eingabeaufforderungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taschenrechnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionsinformationenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Quelltext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mainProgress = new System.Windows.Forms.ProgressBar();
            this.noParamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Berichte);
            this.groupBox1.Location = new System.Drawing.Point(12, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Berichte";
            // 
            // Berichte
            // 
            this.Berichte.Location = new System.Drawing.Point(6, 19);
            this.Berichte.Name = "Berichte";
            this.Berichte.ReadOnly = true;
            this.Berichte.Size = new System.Drawing.Size(574, 106);
            this.Berichte.TabIndex = 0;
            this.Berichte.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.projektToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.überToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // projektToolStripMenuItem
            // 
            this.projektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kompilierenToolStripMenuItem,
            this.ausführenToolStripMenuItem,
            this.kompilierenUndAusführenToolStripMenuItem});
            this.projektToolStripMenuItem.Name = "projektToolStripMenuItem";
            this.projektToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projektToolStripMenuItem.Text = "Projekt";
            // 
            // kompilierenToolStripMenuItem
            // 
            this.kompilierenToolStripMenuItem.Name = "kompilierenToolStripMenuItem";
            this.kompilierenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.kompilierenToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.kompilierenToolStripMenuItem.Text = "Kompilieren";
            // 
            // ausführenToolStripMenuItem
            // 
            this.ausführenToolStripMenuItem.Name = "ausführenToolStripMenuItem";
            this.ausführenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.ausführenToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.ausführenToolStripMenuItem.Text = "Ausführen";
            this.ausführenToolStripMenuItem.Click += new System.EventHandler(this.ausführenToolStripMenuItem_Click);
            // 
            // kompilierenUndAusführenToolStripMenuItem
            // 
            this.kompilierenUndAusführenToolStripMenuItem.Name = "kompilierenUndAusführenToolStripMenuItem";
            this.kompilierenUndAusführenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.kompilierenUndAusführenToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.kompilierenUndAusführenToolStripMenuItem.Text = "Kompilieren und Ausführen";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explorerToolStripMenuItem,
            this.eingabeaufforderungToolStripMenuItem,
            this.taschenrechnerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noParamToolStripMenuItem});
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.explorerToolStripMenuItem.Text = "Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // eingabeaufforderungToolStripMenuItem
            // 
            this.eingabeaufforderungToolStripMenuItem.Name = "eingabeaufforderungToolStripMenuItem";
            this.eingabeaufforderungToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.eingabeaufforderungToolStripMenuItem.Text = "Eingabeaufforderung";
            this.eingabeaufforderungToolStripMenuItem.Click += new System.EventHandler(this.eingabeaufforderungToolStripMenuItem_Click);
            // 
            // taschenrechnerToolStripMenuItem
            // 
            this.taschenrechnerToolStripMenuItem.Name = "taschenrechnerToolStripMenuItem";
            this.taschenrechnerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.taschenrechnerToolStripMenuItem.Text = "Taschenrechner";
            this.taschenrechnerToolStripMenuItem.Click += new System.EventHandler(this.taschenrechnerToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentationToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // dokumentationToolStripMenuItem
            // 
            this.dokumentationToolStripMenuItem.Name = "dokumentationToolStripMenuItem";
            this.dokumentationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.dokumentationToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dokumentationToolStripMenuItem.Text = "Dokumentation";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionsinformationenToolStripMenuItem});
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.überToolStripMenuItem.Text = "Über";
            // 
            // versionsinformationenToolStripMenuItem
            // 
            this.versionsinformationenToolStripMenuItem.Name = "versionsinformationenToolStripMenuItem";
            this.versionsinformationenToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.versionsinformationenToolStripMenuItem.Text = "Versionsinformationen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Quelltext);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 276);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quelltext";
            // 
            // Quelltext
            // 
            this.Quelltext.Location = new System.Drawing.Point(6, 19);
            this.Quelltext.Multiline = true;
            this.Quelltext.Name = "Quelltext";
            this.Quelltext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Quelltext.Size = new System.Drawing.Size(574, 251);
            this.Quelltext.TabIndex = 0;
            this.Quelltext.Text = "Ausgabe(\"Test1234\"); //Testkommentar\r\n$string = Eingabe(\"Bitte etwas eingeben\") ;" +
    "\r\n/* multiline\r\n    comment\r\n*/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainProgress
            // 
            this.mainProgress.Location = new System.Drawing.Point(0, 481);
            this.mainProgress.Name = "mainProgress";
            this.mainProgress.Size = new System.Drawing.Size(910, 12);
            this.mainProgress.TabIndex = 4;
            // 
            // noParamToolStripMenuItem
            // 
            this.noParamToolStripMenuItem.Name = "noParamToolStripMenuItem";
            this.noParamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noParamToolStripMenuItem.Text = "no param";
            this.noParamToolStripMenuItem.Click += new System.EventHandler(this.noParamToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(910, 505);
            this.Controls.Add(this.mainProgress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OpenCode Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox Berichte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompilierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausführenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionsinformationenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taschenrechnerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Quelltext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar mainProgress;
        private System.Windows.Forms.ToolStripMenuItem kompilierenUndAusführenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eingabeaufforderungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noParamToolStripMenuItem;
    }
}

