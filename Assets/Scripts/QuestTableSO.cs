using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestTable", menuName = "ScriptableObject/QuestTable")]
public class QuestTableSO : ScriptableObject
{
    [field: SerializeField] public List<DailyQuest> DailyQuests { get; private set; }
    [field: SerializeField] public List<RepeatableQuest> RepeatableQuests { get; private set; }
    [field: SerializeField] public List<AchievementQuest> AchievementQuests { get; private set; }

    private Dictionary<string, DailyQuest> dailyQuestDic;
    private Dictionary<string, RepeatableQuest> repeatableQuestDic;
    private Dictionary<string, AchievementQuest> achievementQuestDic;

    public void Load()
    {
        // ���̺�� ���� �ε�

        // NOTE :
        // Daily�� cleared�� true��� ���� ��¥�� ����� clearedDate�� ���ؼ� Ŭ���� �������� ����
    }

    public void Save()
    {
        // Quest�� Current, Cleared, Executable ����
    }

    public void Perform(string id)
    {
        if (dailyQuestDic.TryGetValue(id, out DailyQuest dailyQuest)) dailyQuest.Perform();
        if (repeatableQuestDic.TryGetValue(id, out RepeatableQuest repeatableQuest)) repeatableQuest.Perform();
        if (achievementQuestDic.TryGetValue(id, out AchievementQuest achievementQuest)) achievementQuest.Perform();
    }
}
