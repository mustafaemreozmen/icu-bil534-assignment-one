using Duck.Concrete.Duck;
using Duck.Concrete.Fly;

//TO-DO: Use factory pattern for this ugliest initialization
ToyDuck toyDuck = new(new FlyNoWay(), new MuteQuack());
FlyAndLoudlyDuck flyAndLoudlyDuck = new(new FlyWithWings(), new QuackLoudly());

Console.WriteLine("********** TOY DUCK REGION **********");
toyDuck.PerformFly();
toyDuck.PerformQuack();
Console.WriteLine("*************************************");
Console.WriteLine("***** FLY & LOUDLY DUCK REGION *****");
flyAndLoudlyDuck.PerformFly();
flyAndLoudlyDuck.PerformQuack();
Console.WriteLine("*************************************");

