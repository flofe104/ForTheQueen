using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampedValue : SaveableMonoBehaviour
{

    [SerializeField]
    [Save]
    private float currentValue;
    
    protected override void OnFirstTimeBehaviourAwakend()
    {
        CurrentValue = maxValue;
    }

    public float CurrentValue
    {
        get
        {
            return currentValue;
        }
        set
        {
            if (value != currentValue)
            {
                float delta = value - currentValue;
                currentValue = value;
                OnValueChanged(delta);
            }
        }
    }
    
    public void Reduce(float value)
    {
        CurrentValue = Mathf.Max(0, CurrentValue - value);
    }

    public void Increase(float value)
    {
        CurrentValue = Mathf.Min(maxValue, CurrentValue + value);
    }

    protected virtual void OnValueChanged(float delta) { }
    
    
    public float maxValue;

}
