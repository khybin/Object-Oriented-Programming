namespace Enemy {
    public class Skill {
        public int level = 1;
        public double cooldown;
        public string name;
        public int manaCost;

        public Skill(string name, int manaCost, double cooldown) {
            if (name == null || name.Length == 0)
                this.name = "이름 미정";
            else
                this.name = name;

            if (manaCost >= 0)
                this.manaCost = manaCost;
            else
                this.manaCost = 0;

            if (cooldown >= 0)
                this.cooldown = cooldown;
            else
                this.cooldown = 0;
        }

        public Skill(string name) : this(name, 0, 0) { }

        public Skill(string name, int manaCost)
            : this(name, manaCost, 0) { }

        public Skill(string name, double cooldown)
            : this(name, 0, cooldown) { }

        public void ShowSkillInfo() {
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Cooldown: {cooldown}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"ManaCost: {manaCost}");
        }
    }
}