using LearningDiff.Concrete.Human;
using LearningDiff.Concrete.Learning;

//TO-DO: Use factory pattern for this ugliest initialization
Emre emre = new(new Read());
Mustafa mustafa = new(new Write());

Console.WriteLine("****** EMRE ******");
emre.LearnAnything();
Console.WriteLine("*******************");
Console.WriteLine("***** MUSTAFA *****");
mustafa.LearnAnything();
Console.WriteLine("*******************");

