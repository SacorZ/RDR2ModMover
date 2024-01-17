namespace RDR2ModMover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            modStatusLabel = new Label();
            modButton = new Button();
            SuspendLayout();
            // 
            // modStatusLabel
            // 
            modStatusLabel.BackColor = SystemColors.ActiveCaptionText;
            modStatusLabel.BorderStyle = BorderStyle.FixedSingle;
            modStatusLabel.Dock = DockStyle.Top;
            modStatusLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            modStatusLabel.ForeColor = Color.Goldenrod;
            modStatusLabel.Location = new Point(0, 0);
            modStatusLabel.Name = "modStatusLabel";
            modStatusLabel.Size = new Size(1008, 30);
            modStatusLabel.TabIndex = 0;
            modStatusLabel.Text = "\"Mod Status: \" + (FileManager.IsModStatus() ? \"Modded\" : \"Unmodded\");\r\n";
            modStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            modStatusLabel.Click += modStatus_Click;
            // 
            // modButton
            // 
            modButton.Anchor = AnchorStyles.Top;
            modButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            modButton.BackColor = SystemColors.ActiveCaptionText;
            modButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            modButton.ForeColor = Color.Red;
            modButton.Location = new Point(412, 35);
            modButton.Name = "modButton";
            modButton.RightToLeft = RightToLeft.Yes;
            modButton.Size = new Size(200, 40);
            modButton.TabIndex = 1;
            modButton.Text = "MOD / UNMOD";
            modButton.TextAlign = ContentAlignment.TopCenter;
            modButton.UseVisualStyleBackColor = false;
            modButton.Click += modButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 985);
            Controls.Add(modButton);
            Controls.Add(modStatusLabel);
            Name = "Form1";
            Text = "RDR2 ModMover";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label modStatusLabel;
        private Button modButton;
    }
}