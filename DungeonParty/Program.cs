
namespace DungeonParty {
    class Program {
        // 실습 1 테스트 함수
        static void TestDungeonParty() {
            // 파티 생성
            DungeonParty party = new DungeonParty("용사 파티", 3);

            Console.WriteLine("=== 초기 파티 정보 ===");
            party.PrintPartyInfo();

            // 파티원 반복 추가
            Console.WriteLine("\n=== 파티원 추가 ===");

            for (int i = 0; i < 5; i++) {
                party.AddMember();
                party.PrintPartyInfo();
            }

            // 파티원 반복 제거
            Console.WriteLine("\n=== 파티원 제거 ===");

            for (int i = 0; i < 5; i++) {
                party.RemoveMember();
                party.PrintPartyInfo();
            }
        }

        // DungeonParty 테스트
        static void TestProperty() {
            // 객체 생성
            DungeonParty party = new DungeonParty("용사 파티", 3);

            Console.WriteLine("=== 초기 파티 정보 ===");
            party.PrintPartyInfo();

            // PartyName 테스트
            Console.WriteLine("\n=== PartyName 테스트 ===");

            party.PartyName = "기사단 파티";
            party.PrintPartyInfo();

            party.PartyName = "";
            Console.WriteLine("빈 문자열 대입 후:");
            party.PrintPartyInfo();

            // Difficulty 테스트
            Console.WriteLine("\n=== Difficulty 테스트 ===");

            party.Difficulty = 5;
            party.PrintPartyInfo();

            party.Difficulty = 10;
            Console.WriteLine("잘못된 난이도 대입 후:");
            party.PrintPartyInfo();

            // MemberCount 테스트
            Console.WriteLine("\n=== MemberCount 테스트 ===");

            party.AddMember();
            party.AddMember();
            party.AddMember();
            party.AddMember();

            party.PrintPartyInfo();

            party.RemoveMember();
            party.PrintPartyInfo();

            // party.MemberCount = 10;
            // 직접 수정할 수 없으므로 컴파일 오류 발생
        }

        static void Main(string[] args) {
            Console.WriteLine("=== 실습1 테스트 ===");
            TestDungeonParty();
            Console.WriteLine("\n=== 실습2 테스트 ===");
            TestProperty();
        }
    }
}
