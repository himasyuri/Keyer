namespace Keyer.Views
{
    partial class ImageView
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
            Import = new Button();
            Export = new Button();
            label1 = new Label();
            btnChangeBackground = new Button();
            Back = new Button();
            ImageWindow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImageWindow).BeginInit();
            SuspendLayout();
            // 
            // Import
            // 
            Import.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Import.Location = new Point(894, 12);
            Import.Name = "Import";
            Import.Size = new Size(98, 39);
            Import.TabIndex = 0;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            Export.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Export.Location = new Point(998, 12);
            Export.Name = "Export";
            Export.Size = new Size(98, 39);
            Export.TabIndex = 1;
            Export.Text = "Export";
            Export.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Location = new Point(894, 70);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Colour of keyer";
            // 
            // btnChangeBackground
            // 
            btnChangeBackground.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeBackground.Location = new Point(894, 101);
            btnChangeBackground.Name = "btnChangeBackground";
            btnChangeBackground.Size = new Size(98, 39);
            btnChangeBackground.TabIndex = 3;
            btnChangeBackground.Text = "Change colour background";
            btnChangeBackground.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Back.Location = new Point(998, 101);
            Back.Name = "Back";
            Back.Size = new Size(98, 39);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            // 
            // ImageWindow
            // 
            ImageWindow.Anchor = AnchorStyles.None;
            ImageWindow.ImageLocation = "";
            ImageWindow.Location = new Point(3, 12);
            ImageWindow.Name = "ImageWindow";
            ImageWindow.Size = new Size(885, 588);
            ImageWindow.SizeMode = PictureBoxSizeMode.AutoSize;
            ImageWindow.TabIndex = 5;
            ImageWindow.TabStop = false;
            // 
            // ImageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1101, 612);
            Controls.Add(ImageWindow);
            Controls.Add(Back);
            Controls.Add(btnChangeBackground);
            Controls.Add(label1);
            Controls.Add(Export);
            Controls.Add(Import);
            Name = "ImageView";
            Text = "ImageView";
            ((System.ComponentModel.ISupportInitialize)ImageWindow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Import;
        private Button Export;
        private Label label1;
        private Button btnChangeBackground;
        private Button Back;
        private PictureBox ImageWindow;
    }
}