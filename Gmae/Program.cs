using Gmae;

//Connect classes
GameMechanics _gameMechanics = new GameMechanics();
Characters_statistic _statistic = new Characters_statistic();
User_interaction _interact = new User_interaction();
Items _items = new Items();

//Start programm
Console.WriteLine("Welcome to my game)");

void Main()
{
    //_interact.Show_help();
    //_gameMechanics.Enemy_randomizer();
    _gameMechanics.Fight();
    //_interact.Choose_item();
}

Main();