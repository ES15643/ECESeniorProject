using System.Drawing;

namespace DavinciBotView
{
    public class RecentPictureObject
    {
        public Image Image;
        public string Filepath;

        public RecentPictureObject(Image _Image, string _Filepath)
        {
            this.Image = _Image;
            this.Filepath = _Filepath;
        }
    }
}
