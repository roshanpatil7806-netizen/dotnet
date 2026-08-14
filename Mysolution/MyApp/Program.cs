using MyLibrary;

var name = args.Length > 0
    ? args[0]
    : "ROSHAN";

Console.WriteLine(Class1.Hello(name));
