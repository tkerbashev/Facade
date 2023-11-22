using Facade;

Console.WriteLine( "Facade Design Pattern example" );
Console.WriteLine();

TurnLeftFacade turnLeft = new();
turnLeft.TurnLeft();
