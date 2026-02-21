using DesignPatternChallenge.Caretaker;
using DesignPatternChallenge.Originator;

Console.WriteLine("=== Editor de Imagens com Memento ===\n");

var editor = new ImageEditor(1920, 1080);
var history = new EditorHistory(editor);

history.Save();
editor.DisplayInfo();

editor.ApplyBrightness(20);
history.Save();

editor.ApplyFilter("Sepia");
history.Save();

editor.Rotate(90);
history.Save();

editor.Crop(1280, 720);
history.Save();

editor.DisplayInfo();

Console.WriteLine("=== Undo ===");
history.Undo();
editor.DisplayInfo();

history.Undo();
editor.DisplayInfo();

Console.WriteLine("=== Redo ===");
history.Redo();
editor.DisplayInfo();