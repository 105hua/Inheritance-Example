using Example;

Car standardCar = new Car("Ford", "Focus", "OH58 LSK");
AdvancedCar advancedCar = new AdvancedCar("Ford", "Focus", "OH58 LSK", DateTime.Parse("31/10/2022"), DateTime.Parse("29/10/2022"));
Car blankStandardCar = new Car();
AdvancedCar blankAdvancedCar = new AdvancedCar();

Console.WriteLine(standardCar.ToString());
Console.WriteLine(advancedCar.ToString());
Console.WriteLine(blankStandardCar.ToString());
Console.WriteLine(blankAdvancedCar.ToString());