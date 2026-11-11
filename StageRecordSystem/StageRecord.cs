
namespace StageRecordSystem;

class StageRecord {
    public string StageName;
    public int BestScore;
    public int PlayCount;
    public int ClearCount;

    // 생성자
    public StageRecord(string stageName) {
        if (string.IsNullOrEmpty(stageName))
            StageName = "UNKNOWN STAGE";
        else
            StageName = stageName;

        BestScore = 0;
        PlayCount = 0;
        ClearCount = 0;
    }

    // 플레이 결과 기록
    public bool RecordPlay(int score, bool isCleared) {
        if (score < 0)
            return false;

        PlayCount++;

        if (isCleared)
            ClearCount++;

        if (score > BestScore)
            BestScore = score;

        return true;
    }

    // 스테이지 정보 출력
    public void ShowInfo() {
        Console.WriteLine(
            $"[{StageName}] 최고 점수: {BestScore}, 플레이: {PlayCount}회, 클리어: {ClearCount}회"
        );
    }
}
