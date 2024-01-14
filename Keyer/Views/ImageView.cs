using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyer.Views
{
    public partial class ImageView : Form, IImageView
    {
        public ImageView()
        {
            InitializeComponent();
            AssociatedAndRaiseViewEvents();
        }

        private void AssociatedAndRaiseViewEvents()
        {
            Export.Click += delegate { ExportImage?.Invoke(this, EventArgs.Empty); };
            Import.Click += delegate { ImportImage?.Invoke(this, EventArgs.Empty); };
            btnChangeBackground.Click += delegate { ChangeBackground?.Invoke(this, EventArgs.Empty); };
        }

        public Image Image { get => ImageWindow.Image; set => ImageWindow.Image = value; }
        public Color KeyerColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler ImportImage;
        public event EventHandler ExportImage;
        public event EventHandler ChangeBackground;

        public void SetImageBindingSource(BindingSource bindingSource)
        {
            throw new NotImplementedException();
        }
    }
}
