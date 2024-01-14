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
            Import.Location = new Point(880, 12);
            Import.Name = "Import";
            Import.Size = new Size(98, 39);
            Import.TabIndex = 0;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            Export.Location = new Point(984, 12);
            Export.Name = "Export";
            Export.Size = new Size(98, 39);
            Export.TabIndex = 1;
            Export.Text = "Export";
            Export.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(880, 70);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Colour of keyer";
            // 
            // btnChangeBackground
            // 
            btnChangeBackground.Location = new Point(880, 101);
            btnChangeBackground.Name = "btnChangeBackground";
            btnChangeBackground.Size = new Size(98, 39);
            btnChangeBackground.TabIndex = 3;
            btnChangeBackground.Text = "Change colour background";
            btnChangeBackground.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            Back.Location = new Point(984, 101);
            Back.Name = "Back";
            Back.Size = new Size(98, 39);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            // 
            // ImageWindow
            // 
            ImageWindow.Location = new Point(12, 12);
            ImageWindow.Name = "ImageWindow";
            ImageWindow.Size = new Size(862, 535);
            ImageWindow.TabIndex = 5;
            ImageWindow.TabStop = false;
            // 
            // ImageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 559);
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