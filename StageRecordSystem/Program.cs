
namespace StageRecordSystem;

class Program {
    // 두 스테이지 최고 점수 비교
    static void CompareStages(StageRecord stage1, StageRecord stage2) {
        if (stage1.BestScore > stage2.BestScore) {
            Console.WriteLine(
                $"최고 점수: {stage1.StageName} ({stage1.BestScore}점)"
            );
        }
        else if (stage1.BestScore < stage2.BestScore) {
            Console.WriteLine(
                $"최고 점수: {stage2.StageName} ({stage2.BestScore}점)"
            );
        }
        else {
            Console.WriteLine("두 스테이지의 최고 점수가 같습니다.");
        }
    }

    static void Main(string[] args) {
        // 객체 생성
        StageRecord forest = new StageRecord("Forest");
        StageRecord dungeon = new StageRecord("Dungeon");
        StageRecord unknown = new StageRecord("");

        // 초기값 확인
        Console.WriteLine("=== 객체 생성 및 초기값 확인 ===");

        forest.ShowInfo();
        dungeon.ShowInfo();
        unknown.ShowInfo();

        // Forest 플레이 기록
        Console.WriteLine("\n=== Forest 플레이 기록 ===");

        Console.WriteLine($"1회차: {forest.RecordPlay(1200, false)}");
        Console.WriteLine($"2회차: {forest.RecordPlay(1800, true)}");
        Console.WriteLine($"3회차: {forest.RecordPlay(900, true)}");
        Console.WriteLine($"4회차: {forest.RecordPlay(-100, true)}");

        forest.ShowInfo();

        // Dungeon 플레이 기록
        dungeon.RecordPlay(1800, false);

        // 최고 점수 비교
        Console.WriteLine("\n=== 최고 점수 동점 비교 ===");

        /// 최고 점수 동점 비교
        CompareStages(forest, dungeon);

        dungeon.RecordPlay(2500, true);

        Console.WriteLine("\n=== 최고 점수 갱신 후 비교 ===");

        CompareStages(forest, dungeon);

        // 최종 스테이지 기록
        Console.WriteLine("\n=== 최종 스테이지 기록 ===");

        forest.ShowInfo();
        dungeon.ShowInfo();
    }
}
