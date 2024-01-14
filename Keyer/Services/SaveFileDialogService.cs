using Keyer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyer.Services
{
    public class SaveFileDialogService : ISaveFileDialogService
    {
        public void Save()
        {
            Stream myStream;
            using (SaveFileDialog svd = new SaveFileDialog())
            {
                svd.Filter = "Image files (*.png)|*.PNG";

                if (svd.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = svd.OpenFile()) != null)
                    {
                        myStream.Close();
                    }
                }
            }
        }
    }
}
