using Keyer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyer.Services
{
    public class FileDialogService : IFileDialogService
    {
        public string Browse()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open image";
                ofd.Filter = "Image files (*.png)|*.PNG";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var file = ofd.FileName;

                    return file;
                }
            }

            throw new Exception("Error when open file");
        }
    }
}
