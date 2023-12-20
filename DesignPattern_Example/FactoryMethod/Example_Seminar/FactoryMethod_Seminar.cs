namespace DesignPattern_Example.FactoryMethod.Example_Seminar;

// Bước 1: Định nghĩa giao diện sản phẩm
public interface IImage
{
    public void Display();
}

// Bước 2: Triển khai các sản phẩm cụ thể
public class JpegImage : IImage
{
    public void Display()
    {
        Console.WriteLine("Jpeg Image displayed");
    }
}
public class PngImage : IImage
{
    public void Display()
    {
        Console.WriteLine("Png Image displayed");
    }
}

// Bước 3: Định nghĩa lớp tạo đối tượng (Creator) và Factory Method
public abstract class ImageCreator
{
    public void ShowImage()
    {
        var image = LoadImage();
        image.Display();
    }
    public abstract IImage LoadImage();
}
// Bước 4: Triển khai các tạo đối tượng cụ thể (Concrete Creator)
public class JpegCreator : ImageCreator
{
    public override IImage LoadImage()
    {
        return new JpegImage();
    }
}
public class PngCreator : ImageCreator
{
    public override IImage LoadImage()
    {
        return new PngImage();
    }
}
