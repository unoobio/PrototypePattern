using PrototypePattern;

List<Automobile> automobiles = new List<Automobile>()
{
     new Automobile(1, 2, TypeOfDrive.All),
     new Automobile(3, 4, TypeOfDrive.All),
     new Automobile(1, 2, TypeOfDrive.All)
};

// Предположим есть две коллекции, которые нам возвращает сторонний метод.
List<ICloneable> input1 = automobiles.Cast<ICloneable>()
    .ToList();

List<IMyCloneable<Automobile>> input2 = automobiles.Cast<IMyCloneable<Automobile>>()
    .ToList();


// В случае стандартной реализации не будет понимания к какому типу приводить полученный при клонировании объект.
// Да и в прицнипе приведение object к конкретному типу плохая практика.
List<object> clones1 = input1.Select(transport => transport.Clone())
    .ToList();


// Тут же всё очевидно и по другому быть не может.
List<Automobile> clones2 = input2.Select(transport => transport.MyClone())
    .ToList();

Console.ReadLine();