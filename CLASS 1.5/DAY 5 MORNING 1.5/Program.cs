/* Create a C# program to manage a photo book using object-oriented programming.

To start, create a class called PhotoBook with a protected attribute numPages of type int. It must also have a public method GetNumberPages that will return the number of photo book pages.

The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.

There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

IN  main program perform the following

Create a default photo book and show the number of pages
Create a photo book with 24 pages and show the number of pages
Create a Bigphotobook and show the number of pages
 */
using System;

namespace Day_5_Morning_1._4
{
    class GrandPhotoBookPhotobook
    {
        static void Main(string[] args)
        {
            PhotoBook myAlbum1 = new PhotoBook();
            Console.WriteLine(myAlbum1.GetNumberPages());

            PhotoBook myAlbum2 = new PhotoBook(24);
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
}