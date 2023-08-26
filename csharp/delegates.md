# Delegates

Delegates are objects that can reference methods with the same signature. They are used to pass methods as arguments to other methods.

```csharp
public class PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo);

    public void Process(string path, PhotoFilterHandler filterHandler)
    {
        var photo = Photo.Load(path);

        filterHandler(photo);

        photo.Save();
    }
}

class Program {
    static void Main(string[] args)
    {
        var processor = new PhotoProcessor();

        var filters = new PhotoFilters();

        PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
        filterHandler += filters.ApplyContrast;
        filterHandler += RemoveRedEyeFilter;

        processor.Process("photo.jpg", filterHandler);
    }

    static void RemoveRedEyeFilter(Photo photo)
    {
        Console.WriteLine("Apply RemoveRedEye");
    }
}
```