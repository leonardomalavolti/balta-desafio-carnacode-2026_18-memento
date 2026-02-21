using DesignPatternChallenge.Originator;

namespace DesignPatternChallenge.Memento;

public class EditorMemento : IEditorMemento
{
    private readonly int _width;
    private readonly int _height;
    private readonly int _brightness;
    private readonly string _filterApplied;
    private readonly double _rotation;

    public EditorMemento(int width, int height, int brightness, string filter, double rotation)
    {
        _width = width;
        _height = height;
        _brightness = brightness;
        _filterApplied = filter;
        _rotation = rotation;
    }

    public void Restore(ImageEditor editor)
    {
        editor.SetState(_width, _height, _brightness, _filterApplied, _rotation);
    }
}
