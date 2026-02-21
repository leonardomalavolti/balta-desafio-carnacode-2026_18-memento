using DesignPatternChallenge.Originator;

namespace DesignPatternChallenge.Memento;

public interface IEditorMemento
{
    void Restore(ImageEditor editor);
}
