namespace SNEJK1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            timer1 = new System.Windows.Forms.Timer(components);
            labelScore = new Label();
            labelLevel = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelScore.Location = new Point(720, 35);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(65, 17);
            labelScore.TabIndex = 0;
            labelScore.Text = "Punkty: 0";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelLevel.Location = new Point(720, 9);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(66, 19);
            labelLevel.TabIndex = 1;
            labelLevel.Text = "Level: 1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(labelLevel);
            Controls.Add(labelScore);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelScore;
        private Label labelLevel;
    }
}