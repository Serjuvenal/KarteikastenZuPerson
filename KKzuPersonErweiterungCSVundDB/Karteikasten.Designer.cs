namespace KKzuPersonErweiterungCSVundDB
{
    partial class Karteikasten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karteikasten));
            toolStripContainer1 = new ToolStripContainer();
            toolStrip2 = new ToolStrip();
            tsl_status = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripProgressBar1 = new ToolStripProgressBar();
            label1 = new Label();
            lbl_liste = new Label();
            lbl_sortieren = new Label();
            btn_nachID = new Button();
            btn_nachname = new Button();
            btn_nachplz = new Button();
            btn_nachOrt = new Button();
            btn_loeschen = new Button();
            btn_updaten = new Button();
            dgv_personen = new DataGridView();
            btn_next = new Button();
            btn_previous = new Button();
            tb_telefonnummer = new TextBox();
            tb_land = new TextBox();
            tb_wohnort = new TextBox();
            tb_postleitzahl = new TextBox();
            tb_hausnummer = new TextBox();
            tb_strasse = new TextBox();
            tb_nachname = new TextBox();
            tb_id = new TextBox();
            tb_vorname = new TextBox();
            lbl_telefonnummer = new Label();
            lbl_land = new Label();
            lbl_Wohnort = new Label();
            lbl_postleitzahl = new Label();
            lbl_hausnummer = new Label();
            lbl_strasse = new Label();
            lbl_nachname = new Label();
            lbl_id = new Label();
            lbl_vorname = new Label();
            toolStrip1 = new ToolStrip();
            tsb_ListeLoadDB = new ToolStripButton();
            tsb_ListeSpeichernDB = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsb_ListeLoadCSV = new ToolStripButton();
            tsb_ListeSpeichernCSV = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsb_neuePerson = new ToolStripButton();
            tsb_Personhinzufuegen = new ToolStripButton();
            karteikastenBindingSource = new BindingSource(components);
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_personen).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)karteikastenBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(toolStrip2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = Color.LightSteelBlue;
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_liste);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_sortieren);
            toolStripContainer1.ContentPanel.Controls.Add(btn_nachID);
            toolStripContainer1.ContentPanel.Controls.Add(btn_nachname);
            toolStripContainer1.ContentPanel.Controls.Add(btn_nachplz);
            toolStripContainer1.ContentPanel.Controls.Add(btn_nachOrt);
            toolStripContainer1.ContentPanel.Controls.Add(btn_loeschen);
            toolStripContainer1.ContentPanel.Controls.Add(btn_updaten);
            toolStripContainer1.ContentPanel.Controls.Add(dgv_personen);
            toolStripContainer1.ContentPanel.Controls.Add(btn_next);
            toolStripContainer1.ContentPanel.Controls.Add(btn_previous);
            toolStripContainer1.ContentPanel.Controls.Add(tb_telefonnummer);
            toolStripContainer1.ContentPanel.Controls.Add(tb_land);
            toolStripContainer1.ContentPanel.Controls.Add(tb_wohnort);
            toolStripContainer1.ContentPanel.Controls.Add(tb_postleitzahl);
            toolStripContainer1.ContentPanel.Controls.Add(tb_hausnummer);
            toolStripContainer1.ContentPanel.Controls.Add(tb_strasse);
            toolStripContainer1.ContentPanel.Controls.Add(tb_nachname);
            toolStripContainer1.ContentPanel.Controls.Add(tb_id);
            toolStripContainer1.ContentPanel.Controls.Add(tb_vorname);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_telefonnummer);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_land);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_Wohnort);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_postleitzahl);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_hausnummer);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_strasse);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_nachname);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_id);
            toolStripContainer1.ContentPanel.Controls.Add(lbl_vorname);
            toolStripContainer1.ContentPanel.Size = new Size(1214, 535);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1214, 594);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsl_status, toolStripSeparator1, toolStripProgressBar1 });
            toolStrip2.Location = new Point(4, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(160, 28);
            toolStrip2.TabIndex = 0;
            // 
            // tsl_status
            // 
            tsl_status.Name = "tsl_status";
            tsl_status.Size = new Size(40, 25);
            tsl_status.Text = "Bereit.";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 25);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 10);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "von liste ";
            // 
            // lbl_liste
            // 
            lbl_liste.AutoSize = true;
            lbl_liste.Location = new Point(506, 10);
            lbl_liste.Name = "lbl_liste";
            lbl_liste.Size = new Size(41, 15);
            lbl_liste.TabIndex = 5;
            lbl_liste.Text = "in liste";
            // 
            // lbl_sortieren
            // 
            lbl_sortieren.AutoSize = true;
            lbl_sortieren.Location = new Point(838, 10);
            lbl_sortieren.Name = "lbl_sortieren";
            lbl_sortieren.Size = new Size(83, 15);
            lbl_sortieren.TabIndex = 5;
            lbl_sortieren.Text = "Sortieren nach";
            // 
            // btn_nachID
            // 
            btn_nachID.Location = new Point(927, 10);
            btn_nachID.Name = "btn_nachID";
            btn_nachID.Size = new Size(57, 51);
            btn_nachID.TabIndex = 14;
            btn_nachID.Text = "ID";
            btn_nachID.UseVisualStyleBackColor = true;
            btn_nachID.Click += btn_nachID_Click;
            // 
            // btn_nachname
            // 
            btn_nachname.Location = new Point(990, 10);
            btn_nachname.Name = "btn_nachname";
            btn_nachname.Size = new Size(77, 51);
            btn_nachname.TabIndex = 15;
            btn_nachname.Text = "Nachname";
            btn_nachname.UseVisualStyleBackColor = true;
            btn_nachname.Click += btn_nachname_Click;
            // 
            // btn_nachplz
            // 
            btn_nachplz.Location = new Point(1073, 10);
            btn_nachplz.Name = "btn_nachplz";
            btn_nachplz.Size = new Size(60, 51);
            btn_nachplz.TabIndex = 16;
            btn_nachplz.Text = "PLZ";
            btn_nachplz.UseVisualStyleBackColor = true;
            btn_nachplz.Click += btn_nachplz_Click;
            // 
            // btn_nachOrt
            // 
            btn_nachOrt.Location = new Point(1139, 10);
            btn_nachOrt.Name = "btn_nachOrt";
            btn_nachOrt.Size = new Size(63, 51);
            btn_nachOrt.TabIndex = 17;
            btn_nachOrt.Text = "Wohnort";
            btn_nachOrt.UseVisualStyleBackColor = true;
            btn_nachOrt.Click += btn_nachOrt_Click;
            // 
            // btn_loeschen
            // 
            btn_loeschen.Location = new Point(713, 5);
            btn_loeschen.Name = "btn_loeschen";
            btn_loeschen.Size = new Size(67, 56);
            btn_loeschen.TabIndex = 13;
            btn_loeschen.Text = "Löschen";
            btn_loeschen.UseVisualStyleBackColor = true;
            btn_loeschen.Click += btn_loeschen_Click;
            // 
            // btn_updaten
            // 
            btn_updaten.Location = new Point(563, 5);
            btn_updaten.Name = "btn_updaten";
            btn_updaten.Size = new Size(67, 56);
            btn_updaten.TabIndex = 12;
            btn_updaten.Text = "Ändern";
            btn_updaten.UseVisualStyleBackColor = true;
            btn_updaten.Click += btn_updaten_Click;
            // 
            // dgv_personen
            // 
            dgv_personen.AllowUserToAddRows = false;
            dgv_personen.AllowUserToDeleteRows = false;
            dgv_personen.AllowUserToResizeColumns = false;
            dgv_personen.AllowUserToResizeRows = false;
            dgv_personen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_personen.Location = new Point(244, 67);
            dgv_personen.MultiSelect = false;
            dgv_personen.Name = "dgv_personen";
            dgv_personen.ReadOnly = true;
            dgv_personen.RowHeadersWidth = 62;
            dgv_personen.RowTemplate.Height = 25;
            dgv_personen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_personen.Size = new Size(958, 457);
            dgv_personen.TabIndex = 18;
            dgv_personen.Click += dgv_personen_Click;
            // 
            // btn_next
            // 
            btn_next.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.Location = new Point(327, 13);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(66, 40);
            btn_next.TabIndex = 10;
            btn_next.Text = "|>";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_previous
            // 
            btn_previous.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_previous.Location = new Point(255, 13);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(66, 40);
            btn_previous.TabIndex = 9;
            btn_previous.Text = "<|";
            btn_previous.UseVisualStyleBackColor = true;
            btn_previous.Click += btn_previous_Click;
            // 
            // tb_telefonnummer
            // 
            tb_telefonnummer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_telefonnummer.Location = new Point(12, 497);
            tb_telefonnummer.Name = "tb_telefonnummer";
            tb_telefonnummer.Size = new Size(226, 27);
            tb_telefonnummer.TabIndex = 8;
            // 
            // tb_land
            // 
            tb_land.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_land.Location = new Point(12, 432);
            tb_land.Name = "tb_land";
            tb_land.Size = new Size(226, 27);
            tb_land.TabIndex = 7;
            // 
            // tb_wohnort
            // 
            tb_wohnort.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_wohnort.Location = new Point(12, 377);
            tb_wohnort.Name = "tb_wohnort";
            tb_wohnort.Size = new Size(226, 27);
            tb_wohnort.TabIndex = 6;
            // 
            // tb_postleitzahl
            // 
            tb_postleitzahl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_postleitzahl.Location = new Point(12, 321);
            tb_postleitzahl.Name = "tb_postleitzahl";
            tb_postleitzahl.Size = new Size(226, 27);
            tb_postleitzahl.TabIndex = 5;
            // 
            // tb_hausnummer
            // 
            tb_hausnummer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_hausnummer.Location = new Point(12, 263);
            tb_hausnummer.Name = "tb_hausnummer";
            tb_hausnummer.Size = new Size(226, 27);
            tb_hausnummer.TabIndex = 4;
            // 
            // tb_strasse
            // 
            tb_strasse.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_strasse.Location = new Point(12, 204);
            tb_strasse.Name = "tb_strasse";
            tb_strasse.Size = new Size(226, 27);
            tb_strasse.TabIndex = 3;
            // 
            // tb_nachname
            // 
            tb_nachname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nachname.Location = new Point(12, 144);
            tb_nachname.Name = "tb_nachname";
            tb_nachname.Size = new Size(226, 27);
            tb_nachname.TabIndex = 2;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id.Location = new Point(12, 34);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(226, 27);
            tb_id.TabIndex = 0;
            // 
            // tb_vorname
            // 
            tb_vorname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_vorname.Location = new Point(12, 91);
            tb_vorname.Name = "tb_vorname";
            tb_vorname.Size = new Size(226, 27);
            tb_vorname.TabIndex = 1;
            // 
            // lbl_telefonnummer
            // 
            lbl_telefonnummer.AutoSize = true;
            lbl_telefonnummer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_telefonnummer.Location = new Point(12, 473);
            lbl_telefonnummer.Name = "lbl_telefonnummer";
            lbl_telefonnummer.Size = new Size(122, 21);
            lbl_telefonnummer.TabIndex = 0;
            lbl_telefonnummer.Text = "Telefonnummer:";
            // 
            // lbl_land
            // 
            lbl_land.AutoSize = true;
            lbl_land.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_land.Location = new Point(12, 408);
            lbl_land.Name = "lbl_land";
            lbl_land.Size = new Size(47, 21);
            lbl_land.TabIndex = 0;
            lbl_land.Text = "Land:";
            // 
            // lbl_Wohnort
            // 
            lbl_Wohnort.AutoSize = true;
            lbl_Wohnort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Wohnort.Location = new Point(12, 353);
            lbl_Wohnort.Name = "lbl_Wohnort";
            lbl_Wohnort.Size = new Size(74, 21);
            lbl_Wohnort.TabIndex = 0;
            lbl_Wohnort.Text = "Wohnort:";
            // 
            // lbl_postleitzahl
            // 
            lbl_postleitzahl.AutoSize = true;
            lbl_postleitzahl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_postleitzahl.Location = new Point(12, 297);
            lbl_postleitzahl.Name = "lbl_postleitzahl";
            lbl_postleitzahl.Size = new Size(39, 21);
            lbl_postleitzahl.TabIndex = 0;
            lbl_postleitzahl.Text = "PLZ:";
            // 
            // lbl_hausnummer
            // 
            lbl_hausnummer.AutoSize = true;
            lbl_hausnummer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_hausnummer.Location = new Point(12, 239);
            lbl_hausnummer.Name = "lbl_hausnummer";
            lbl_hausnummer.Size = new Size(108, 21);
            lbl_hausnummer.TabIndex = 0;
            lbl_hausnummer.Text = "Hausnummer:";
            // 
            // lbl_strasse
            // 
            lbl_strasse.AutoSize = true;
            lbl_strasse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_strasse.Location = new Point(12, 180);
            lbl_strasse.Name = "lbl_strasse";
            lbl_strasse.Size = new Size(57, 21);
            lbl_strasse.TabIndex = 0;
            lbl_strasse.Text = "Straße:";
            // 
            // lbl_nachname
            // 
            lbl_nachname.AutoSize = true;
            lbl_nachname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nachname.Location = new Point(12, 120);
            lbl_nachname.Name = "lbl_nachname";
            lbl_nachname.Size = new Size(88, 21);
            lbl_nachname.TabIndex = 0;
            lbl_nachname.Text = "Nachname:";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.Location = new Point(12, 10);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(28, 21);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "ID:";
            // 
            // lbl_vorname
            // 
            lbl_vorname.AutoSize = true;
            lbl_vorname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_vorname.Location = new Point(12, 67);
            lbl_vorname.Name = "lbl_vorname";
            lbl_vorname.Size = new Size(91, 21);
            lbl_vorname.TabIndex = 0;
            lbl_vorname.Text = "Vorname/n:";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_ListeLoadDB, tsb_ListeSpeichernDB, toolStripSeparator2, tsb_ListeLoadCSV, tsb_ListeSpeichernCSV, toolStripSeparator3, tsb_neuePerson, tsb_Personhinzufuegen });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(192, 31);
            toolStrip1.TabIndex = 0;
            // 
            // tsb_ListeLoadDB
            // 
            tsb_ListeLoadDB.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_ListeLoadDB.Image = (Image)resources.GetObject("tsb_ListeLoadDB.Image");
            tsb_ListeLoadDB.ImageTransparentColor = Color.Magenta;
            tsb_ListeLoadDB.Name = "tsb_ListeLoadDB";
            tsb_ListeLoadDB.Size = new Size(28, 28);
            tsb_ListeLoadDB.ToolTipText = "Aus der DB lesen";
            tsb_ListeLoadDB.Click += tsb_ListeLoadDB_Click;
            // 
            // tsb_ListeSpeichernDB
            // 
            tsb_ListeSpeichernDB.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_ListeSpeichernDB.Image = (Image)resources.GetObject("tsb_ListeSpeichernDB.Image");
            tsb_ListeSpeichernDB.ImageTransparentColor = Color.Magenta;
            tsb_ListeSpeichernDB.Name = "tsb_ListeSpeichernDB";
            tsb_ListeSpeichernDB.Size = new Size(28, 28);
            tsb_ListeSpeichernDB.ToolTipText = "Liste in DB Speichern";
            tsb_ListeSpeichernDB.Click += tsb_ListeSpeichernDB_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // tsb_ListeLoadCSV
            // 
            tsb_ListeLoadCSV.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_ListeLoadCSV.Image = (Image)resources.GetObject("tsb_ListeLoadCSV.Image");
            tsb_ListeLoadCSV.ImageTransparentColor = Color.Magenta;
            tsb_ListeLoadCSV.Name = "tsb_ListeLoadCSV";
            tsb_ListeLoadCSV.Size = new Size(28, 28);
            tsb_ListeLoadCSV.ToolTipText = "Aus der CSV lesen";
            tsb_ListeLoadCSV.Click += tsb_ListeLoadCSV_Click;
            // 
            // tsb_ListeSpeichernCSV
            // 
            tsb_ListeSpeichernCSV.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_ListeSpeichernCSV.Image = (Image)resources.GetObject("tsb_ListeSpeichernCSV.Image");
            tsb_ListeSpeichernCSV.ImageTransparentColor = Color.Magenta;
            tsb_ListeSpeichernCSV.Name = "tsb_ListeSpeichernCSV";
            tsb_ListeSpeichernCSV.Size = new Size(28, 28);
            tsb_ListeSpeichernCSV.ToolTipText = "Liste in CSV speichern";
            tsb_ListeSpeichernCSV.Click += tsb_ListeSpeichernCSV_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 31);
            // 
            // tsb_neuePerson
            // 
            tsb_neuePerson.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_neuePerson.Image = (Image)resources.GetObject("tsb_neuePerson.Image");
            tsb_neuePerson.ImageTransparentColor = Color.Magenta;
            tsb_neuePerson.Name = "tsb_neuePerson";
            tsb_neuePerson.Size = new Size(28, 28);
            tsb_neuePerson.ToolTipText = "Neue Person";
            tsb_neuePerson.Click += tsb_neuePerson_Click;
            // 
            // tsb_Personhinzufuegen
            // 
            tsb_Personhinzufuegen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Personhinzufuegen.Image = (Image)resources.GetObject("tsb_Personhinzufuegen.Image");
            tsb_Personhinzufuegen.ImageTransparentColor = Color.Magenta;
            tsb_Personhinzufuegen.Name = "tsb_Personhinzufuegen";
            tsb_Personhinzufuegen.Size = new Size(28, 28);
            tsb_Personhinzufuegen.ToolTipText = "Person an die Liste hinzufügen";
            tsb_Personhinzufuegen.Click += tsb_Personhinzufuegen_Click;
            // 
            // Karteikasten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 594);
            Controls.Add(toolStripContainer1);
            Name = "Karteikasten";
            Text = "Person";
            Load += Karteikasten_Load;
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_personen).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)karteikastenBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip2;
        private ToolStripLabel tsl_status;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsb_ListeLoadDB;
        private ToolStripButton tsb_ListeLoadCSV;
        private ToolStripButton tsb_ListeSpeichernCSV;
        private ToolStripButton tsb_ListeSpeichernDB;
        private Label lbl_land;
        private Label lbl_Wohnort;
        private Label lbl_postleitzahl;
        private Label lbl_hausnummer;
        private Label lbl_strasse;
        private Label lbl_nachname;
        private Label lbl_vorname;
        private Label lbl_telefonnummer;
        private TextBox tb_telefonnummer;
        private TextBox tb_land;
        private TextBox tb_wohnort;
        private TextBox tb_postleitzahl;
        private TextBox tb_hausnummer;
        private TextBox tb_strasse;
        private TextBox tb_nachname;
        private TextBox tb_vorname;
        private TextBox tb_id;
        private Label lbl_id;
        private Button btn_next;
        private Button btn_previous;
        private DataGridView dgv_personen;
        private BindingSource karteikastenBindingSource;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsb_neuePerson;
        private Button btn_updaten;
        private ToolStripButton tsb_Personhinzufuegen;
        private Button btn_loeschen;
        private Label lbl_sortieren;
        private Button btn_nachname;
        private Button btn_nachplz;
        private Button btn_nachOrt;
        private Label label1;
        private Label lbl_liste;
        private Button btn_nachID;
    }
}