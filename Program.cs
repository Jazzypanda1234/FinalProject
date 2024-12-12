using FinalProject.Program;

ICreature[]? playerTeam = [null, null, null, null, null];
ICreature[]? tempPlayerTeam = playerTeam;
ICreature[]? enemyTeam;
GameEngine? gameEngine = new GameEngine();
Player? player = new Player(10, playerTeam);
Shop? shop = new Shop(gameEngine);




for (int i = 0; i < 4; i++)
{
    shop.ShopEngine(player);
    enemyTeam = [null, null, null, null, null];
    enemyTeam = gameEngine?.CreateEnemyTeam(enemyTeam, i);
    gameEngine?.Combat(player, enemyTeam);
}
shop.ShopEngine(player);
enemyTeam = [null, null, null, null, null];
enemyTeam = gameEngine?.CreateEnemyTeam(enemyTeam, 2);
enemyTeam[4] = gameEngine.randomBoss();
gameEngine?.Combat(player, enemyTeam);
Console.WriteLine("Game Over");
