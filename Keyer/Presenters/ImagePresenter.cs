using Keyer.Services;
using Keyer.Services.Interfaces;
using Keyer.Views;

namespace Keyer.Presenters
{
    public class ImagePresenter
    {
        private readonly IImageView view;

        public ImagePresenter(IImageView view)
        {
            this.view = view;
            this.view.ImportImage += ImportImage;
            this.view.ExportImage += ExportImage;
            this.view.ChangeBackground += ChangeBackground;
            this.view.Show();
        }

        private void ChangeBackground(object? sender, EventArgs e)
        {
            //color settings
            var alpha = 0;
            var oldColor = Color.FromArgb(255, 0, 205, 24); // alpha 255 default value if imae without alpha
            var newColor = Color.FromArgb(alpha, oldColor);

            Bitmap bitmap = new Bitmap(view.Image);

            LockBitmap lockBitmap = new LockBitmap(bitmap);
            lockBitmap.LockBits();

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var color = lockBitmap.GetPixel(0, 0);
                    Console.WriteLine(color);
                    if (lockBitmap.GetPixel(x, y) == oldColor)
                    {
                        lockBitmap.SetPixel(x, y, newColor);
                    }
                }
            }

            lockBitmap.UnlockBits();

            view.Image = bitmap;
        }

        private void ExportImage(object? sender, EventArgs e)
        {
            ISaveFileDialogService saveFileService = new SaveFileDialogService();
            saveFileService.Save((Bitmap)view.Image);
        }

        private void ImportImage(object? sender, EventArgs e)
        {
            IFileDialogService fileDialogService = new FileDialogService();
            string file = fileDialogService.Browse();

            Bitmap bitmap = new Bitmap(file);

            //delete alpha channel 
            var result = new System.Drawing.Bitmap(bitmap.Size.Width, bitmap.Size.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            var g = System.Drawing.Graphics.FromImage(result);

            g.Clear(Color.White);
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            g.DrawImage(bitmap, 0, 0);

            //display image
            view.Image = result;
        }
    }
}
