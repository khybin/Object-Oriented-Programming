
namespace Enemy {
    public class Enemy {
        public string Name;
        public int Hp = 0;
        public bool IsElite;
        public bool IsBoss;

        public Enemy(string Name, bool IsElite, bool IsBoss) {
            if (Name == null || Name.Length <= 0) {
                this.Name = "INVALID ENEMY NAME";
            }
            else {
                this.Name = Name;
            }

            this.IsElite = IsElite;
            this.IsBoss = IsBoss;
        }

        // HP 회복
        public bool Heal(int amount) {
            if (amount <= 0) {
                return false;
            }

            Hp += amount;
            return true;
        }

        // HP 감소
        public bool TakeDamage(int amount) {
            if (amount <= 0 || Hp < amount) {
                return false;
            }

            Hp -= amount;
            return true;
        }

        // 몬스터 종류에 따른 피해
        public void ReceiveHit() {
            int damage;

            if (IsBoss) {
                damage = 5;
            }
            else if (IsElite) {
                damage = 10;
            }
            else {
                damage = 15;
            }

            if (!TakeDamage(damage)) {
                Console.WriteLine("HP가 부족합니다.");
            }
        }
    }
}
