using Keyer.Services.Interfaces;
using System.Drawing.Imaging;

namespace Keyer.Services
{
    public class SaveFileDialogService : ISaveFileDialogService
    {
        public void Save(Bitmap bitmap)
        {
            using (SaveFileDialog svd = new SaveFileDialog())
            {
                svd.Filter = "Image files (*.png)|*.PNG";

                if (svd.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(svd.FileName, ImageFormat.Png);
                }
            }
        }
    }
}
