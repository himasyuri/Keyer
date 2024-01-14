using Keyer.Services;
using Keyer.Services.Interfaces;
using Keyer.Views;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var oldColor = Color.FromArgb(255, 0, 205, 24);
            var newColor = Color.FromArgb(alpha, oldColor);

            Bitmap bitmap = new Bitmap(view.Image);

            LockBitmap lockBitmap = new LockBitmap(bitmap);
            lockBitmap.LockBits();

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0;  x < bitmap.Width; x++)
                {
                    var color = lockBitmap.GetPixel(1, 1);// 0 205 24 255
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
            saveFileService.Save();
        }

        private void ImportImage(object? sender, EventArgs e)
        {
            IFileDialogService fileDialogService = new FileDialogService();
            string file = fileDialogService.Browse();
            view.Image = new Bitmap(file);
        }
    }
}
