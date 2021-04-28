Create a C# program to manage a photo book using object-oriented programming.

1.To start, create a class called PhotoBook with a private attribute numPages of type int.
2 It must also have a public method GetNumberPages that will return the number of photo book pages.
3.The default constructor will create an album with 16 pages. 
4.There will be an additional constructor, with which we can specify the number of pages we want in the album.
5.There is also a BigPhotoBook class whose constructor will create an album with 64 pages.
6.Finally create a PhotoBookTest class to perform the following actions:
7.Create a default photo book and show the number of pages
8.Create a photo book with 24 pages and show the number of pages
9.Create a large photo book and show the number of pages



using System;
 
public class PhotoBookTest
{
    public static void Main()
    {
        PhotoBook myAlbum1 = new PhotoBook();
        Console.WriteLine(myAlbum1.GetNumberPages());
 
        PhotoBook myAlbum2 = new PhotoBook(24);
        Console.WriteLine(myAlbum2.GetNumberPages());
 
        SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
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
 
public class SuperPhotoBook : PhotoBook
{
    public SuperPhotoBook()
    {
        numPages = 64;
    }
}