using DesignPatternChallenge.Memento;
using DesignPatternChallenge.Originator;

namespace DesignPatternChallenge.Caretaker;

public class EditorHistory
{
    private readonly Stack<IEditorMemento> _undoStack = new();
    private readonly Stack<IEditorMemento> _redoStack = new();

    private readonly ImageEditor _editor;

    public EditorHistory(ImageEditor editor)
    {
        _editor = editor;
    }

    public void Save()
    {
        _undoStack.Push(_editor.SaveState());
        _redoStack.Clear(); // Redo inválido após nova operação
        Console.WriteLine($"[Histórico] Estado salvo (Undo: {_undoStack.Count})");
    }

    public void Undo()
    {
        if (_undoStack.Count > 0)
        {
            var memento = _undoStack.Pop();
            _redoStack.Push(_editor.SaveState());
            memento.Restore(_editor);
            Console.WriteLine("[Histórico] Undo aplicado");
        }
        else
        {
            Console.WriteLine("[Histórico] Nada para desfazer");
        }
    }

    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            var memento = _redoStack.Pop();
            _undoStack.Push(_editor.SaveState());
            memento.Restore(_editor);
            Console.WriteLine("[Histórico] Redo aplicado");
        }
        else
        {
            Console.WriteLine("[Histórico] Nada para refazer");
        }
    }
}
