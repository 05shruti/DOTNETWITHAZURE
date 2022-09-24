using System;

namespace Day_5_Morning_1._4
{
    class GrandPhotoBookPhotobook
    {
        static void Main(string[] args)
        {
            PhotoBook myAlbum1 = new PhotoBook();
            Console.WriteLine(myAlbum1.GetNumberPages());

            PhotoBook myAlbum2 = new PhotoBook();
            Console.WriteLine(myAlbum2.GetNumberPages());

            GrandPhotoBook myBigPhotoAlbum1 = new GrandPhotoBook();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
        }
    }
    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class GrandPhotoBook : PhotoBook
    {
        public GrandPhotoBook()
        {
            numPages = 64;
        }
    }