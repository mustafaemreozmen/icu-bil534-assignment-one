using Trip.Concrete.Human;
using Trip.Concrete.Trip;

//TO-DO: Use factory pattern for this ugliest initialization
Emre emre = new(new CarTrip());
Mustafa mustafa = new(new ShipTrip());

Console.WriteLine("****** EMRE ******");
emre.Reach();
Console.WriteLine("*******************");
Console.WriteLine("***** MUSTAFA *****");
mustafa.Reach();
Console.WriteLine("*******************");

