using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Quest
{
    [field: SerializeField] public string Id { get; protected set; }
    [field: SerializeField] public string Title { get; protected set; }
    [field: SerializeField] public int Required { get; protected set; }
    //[field: SerializeField] public MoneyType RewardType { get; protected set; }
    [field: SerializeField] public int Reward { get; protected set; }
    public int Current { get; protected set; }
    public bool Clearable => Current >= Required;
    public virtual bool Performable { get { return true; } }

    public UnityAction<Quest> onValueChanged;    

    public void Perform()
    {
        if (Performable)
        {
            Current++;
            onValueChanged?.Invoke(this);
        }
    }

    public abstract void ReceiveReward();
}
