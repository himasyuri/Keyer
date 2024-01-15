namespace Keyer.Views
{
    public interface IImageView
    {
        Image Image { get; set; }

        Color KeyerColor { get; set; }

        event EventHandler ImportImage;
        event EventHandler ExportImage;
        event EventHandler ChangeBackground;

        void SetImageBindingSource(BindingSource bindingSource);
        void Show();
    }
}
