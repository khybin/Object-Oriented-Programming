// 1. Enemy 객체 생성
Enemy enemy = new Enemy("Goblin", true, false);

// 4. 수정 후 값 출력
Console.WriteLine($"Name    : {enemy.Name}");
Console.WriteLine($"Hp      : {enemy.Hp}");
Console.WriteLine($"IsElite : {enemy.IsElite}");
Console.WriteLine($"IsBoss  : {enemy.IsBoss}");