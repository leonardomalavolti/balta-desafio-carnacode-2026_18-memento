using DesignPatternChallenge.Memento;

namespace DesignPatternChallenge.Originator;

public class ImageEditor
{
    private int _width;
    private int _height;
    private int _brightness;
    private string _filterApplied;
    private double _rotation;

    public ImageEditor(int width, int height)
    {
        _width = width;
        _height = height;
        _brightness = 0;
        _filterApplied = "None";
        _rotation = 0;

        Console.WriteLine($"[Editor] Imagem criada: {width}x{height}");
    }

    public void ApplyBrightness(int value)
    {
        _brightness += value;
        Console.WriteLine($"[Editor] Brilho ajustado para {_brightness}");
    }

    public void ApplyFilter(string filter)
    {
        _filterApplied = filter;
        Console.WriteLine($"[Editor] Filtro aplicado: {filter}");
    }

    public void Rotate(double degrees)
    {
        _rotation += degrees;
        Console.WriteLine($"[Editor] Rotação: {_rotation}°");
    }

    public void Crop(int newWidth, int newHeight)
    {
        _width = newWidth;
        _height = newHeight;
        Console.WriteLine($"[Editor] Imagem cortada para {newWidth}x{newHeight}");
    }

    // Cria um memento do estado atual
    public IEditorMemento SaveState()
    {
        return new EditorMemento(_width, _height, _brightness, _filterApplied, _rotation);
    }

    // Permite que o memento restaure o estado
    internal void SetState(int width, int height, int brightness, string filter, double rotation)
    {
        _width = width;
        _height = height;
        _brightness = brightness;
        _filterApplied = filter;
        _rotation = rotation;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\n=== Estado Atual ===");
        Console.WriteLine($"Dimensões: {_width}x{_height}");
        Console.WriteLine($"Brilho: {_brightness}");
        Console.WriteLine($"Filtro: {_filterApplied}");
        Console.WriteLine($"Rotação: {_rotation}°\n");
    }
}