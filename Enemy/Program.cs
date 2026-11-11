
namespace Enemy;

class Program {
    static void Main(string[] args) {
        // 기존 Skill 테스트
        TestSkill();

        // Enemy 테스트
        TestHeal();
        TestTakeDamage();
        TestReceiveHit();
        TestInsufficientHp();
    }

    static void TestSkill() {
        Console.WriteLine("\n===== Skill 테스트 =====");

        Skill skill1 = new Skill("Fireball", 20);
        Skill skill2 = new Skill("Lightning Bolt", 15);

        skill1.ShowSkillInfo();
        Console.WriteLine();
        skill2.ShowSkillInfo();
    }

    // Heal() 테스트
    static void TestHeal() {
        Console.WriteLine("\n===== Heal() 테스트 =====");

        Enemy enemy = new Enemy("슬라임", false, false);

        Console.WriteLine(enemy.Heal(100));
        Console.WriteLine("HP: " + enemy.Hp);

        Console.WriteLine(enemy.Heal(-10));
        Console.WriteLine("HP: " + enemy.Hp);
    }

    // TakeDamage() 테스트
    static void TestTakeDamage() {
        Console.WriteLine("\n===== TakeDamage() 테스트 =====");

        Enemy enemy = new Enemy("고블린", false, false);

        enemy.Heal(100);

        Console.WriteLine(enemy.TakeDamage(30));
        Console.WriteLine("HP: " + enemy.Hp);

        Console.WriteLine(enemy.TakeDamage(80));
        Console.WriteLine("HP: " + enemy.Hp);
    }

    // ReceiveHit() 테스트
    static void TestReceiveHit() {
        Console.WriteLine("\n===== ReceiveHit() 테스트 =====");

        Enemy normal = new Enemy("고블린(일반 몬스터)", false, false);
        Enemy elite = new Enemy("붉은 늑대(정예 몬스터)", true, false);
        Enemy boss = new Enemy("드래곤(보스 몬스터)", false, true);

        normal.Heal(100);
        elite.Heal(100);
        boss.Heal(100);

        normal.ReceiveHit();
        elite.ReceiveHit();
        boss.ReceiveHit();

        Console.WriteLine("고블린(일반 몬스터) HP: " + normal.Hp);
        Console.WriteLine("붉은 늑대(정예 몬스터) HP: " + elite.Hp);
        Console.WriteLine("드래곤(보스 몬스터) HP: " + boss.Hp);
    }

    // HP 부족 테스트
    static void TestInsufficientHp() {
        Console.WriteLine("\n===== HP 부족 테스트 =====");

        Enemy enemy = new Enemy("약한 몬스터", false, false);

        enemy.Heal(3);
        enemy.ReceiveHit();

        Console.WriteLine("HP: " + enemy.Hp);
    }
}
