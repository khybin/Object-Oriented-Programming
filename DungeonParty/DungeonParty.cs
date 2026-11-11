namespace DungeonParty {
    // 실습을 진행하면서 접근 제한자, 메서드, 프로퍼티, static 멤버를 직접 추가하세요.
    public class DungeonParty {
        // 실습 1: 이 필드들의 접근 제한자를 검토하세요.
        private string partyName;
        private int memberCount;
        private int difficulty;

        public DungeonParty(string partyName, int difficulty) {
            this.partyName = partyName;
            memberCount = 1;
            this.difficulty = difficulty;
        }

        public void PrintPartyInfo() {
            Console.WriteLine($"파티: {partyName} / 인원: {memberCount}명 / 난이도: {difficulty}\n");
        }

        // 실습 1: AddMember(), RemoveMember()를 구현하세요.
        // 파티원 추가
        public void AddMember() {
            if (memberCount >= 4) {
                Console.WriteLine("파티원이 최대 인원입니다.");
                return;
            }

            memberCount++;
            Console.WriteLine("파티원이 추가되었습니다.");
        }

        // 파티원 제거
        public void RemoveMember() {
            if (memberCount <= 1) {
                Console.WriteLine("파티원은 최소 1명이어야 합니다.");
                return;
            }

            memberCount--;
            Console.WriteLine("파티원이 제외되었습니다.");
        }

        // 실습 2: PartyName, MemberCount, Difficulty 프로퍼티를 구현하세요.
        // PartyName 프로퍼티
        public string PartyName {
            get { return partyName; }
            set {
                if (!string.IsNullOrEmpty(value))
                    partyName = value;
            }
        }

        public int MemberCount {
            get { return MemberCount; }
        }

        public int Difficulty {
            get { return Difficulty; }
            set {
                if (value >= 1 && value <= 5) {
                    difficulty = value;
                }
            }
        }

        // 실습 3: 공통 정보를 위한 static 필드/프로퍼티/메서드를 구현하세요.
    }
}
