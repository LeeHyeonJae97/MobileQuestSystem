using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RepeatableQuest : Quest
{
    public override void ReceiveReward()
    {
        if (Clearable)
        {
            Current -= Required;
            onValueChanged?.Invoke(this);
        }
    }
}
