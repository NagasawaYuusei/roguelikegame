using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beem : MonoBehaviour, ISkill
{
    public SkillDef SkillId => SkillDef.ShotBullet;
    IntervalTimer _intervalTimer = new IntervalTimer();
    [SerializeField] float _interval;
    [SerializeField] int _reflect = 2;
    [SerializeField] float _reduceInterval;
    [SerializeField] float _minimumInterval;
    bool _even;
    bool _isCurrentShot;
    public void Setup()
    {
        _intervalTimer.Setup(_interval);
    }

    public void Update()
    {
        if(!_isCurrentShot)
        {
            _intervalTimer.RunTimerOneShot();
        }
        
        if(_intervalTimer.RunTimerOneShot())
        {
            _isCurrentShot = true;
        }

        if(_isCurrentShot)
        {

        }
    }

    public void Levelup()
    {
        if(!_even || _minimumInterval > _interval)
        {
            _reflect++;
        }
        else if(_even && _minimumInterval <= _interval)
        {
            _interval -= _reduceInterval;
        }
        else
        {
            Debug.LogError("例外レベルアップ");
        }
    }

    void BeemMethod()
    {

    }
}
