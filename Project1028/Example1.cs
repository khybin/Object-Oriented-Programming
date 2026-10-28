using System;

namespace Project1028
{
    internal class Example1
    {
        // 1. 기본 데미지 계산
        static int CalculateDamage(int attack, int defense) {
            int damage = attack - defense;

            if (damage < 0) {
                damage = 0;
            }

            return damage;
        }

        // 2. 피해 감소 버프 적용
        static int CalculateDamage(int attack, int defense, int damageReduction) {
            int damage = CalculateDamage(attack, defense);

            damage = damage * (100 - damageReduction) / 100;

            return damage;
        }

        // 3. 피해 감소 버프 + 방어력 감소 디버프 적용
        static int CalculateDamage(int attack, int defense, int damageReduction, int defenseReduction) {
            int effectiveDefense = defense * (100 - defenseReduction) / 100;

            int damage = CalculateDamage(attack, effectiveDefense, damageReduction);

            return damage;
        }

        static void Main(string[] args) {
            Console.WriteLine("기본 데미지: " + CalculateDamage(100, 40));

            Console.WriteLine("피해 감소 적용: " + CalculateDamage(100, 40, 20));

            Console.WriteLine("모든 효과 적용: " + CalculateDamage(100, 40, 20, 50));
        }
    }
}
