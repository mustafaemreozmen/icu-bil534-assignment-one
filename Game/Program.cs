using Game.Concrete.Weapon;
using Game.Concrete.Character;

//TO-DO: Use factory pattern for this ugliest initialization
Ninja ninja = new(new Knife());
Soldier soldier = new(new AK47());

Console.WriteLine("********** NINJA REGION **********");
ninja.Fight();
ninja.Hide();
Console.WriteLine("*************************************");
Console.WriteLine("********** SOLDIER REGION **********");
soldier.Fight();
soldier.Hide();
Console.WriteLine("*************************************");

