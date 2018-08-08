namespace RadwagPrint
{
    partial class AppForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.Settings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(253, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(245, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Drukowanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.CloseButton);
            this.Settings.Controls.Add(this.OpenButton);
            this.Settings.Controls.Add(this.PortComboBox);
            this.Settings.Controls.Add(this.PortLabel);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(245, 302);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Ustawienia";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(99, 40);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(11, 40);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // PortComboBox
            // 
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(53, 13);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(121, 21);
            this.PortComboBox.TabIndex = 2;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(8, 16);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnected,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(254, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConnected
            // 
            this.toolStripStatusLabelConnected.Name = "toolStripStatusLabelConnected";
            this.toolStripStatusLabelConnected.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 350);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppForm";
            this.Text = "RADWAG Barcode Print";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.Label PortLabel;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnected;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

