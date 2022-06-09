using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beem : MonoBehaviour, ISkill
{
    public SkillDef SkillId => SkillDef.ShotBullet;
    [Tooltip("インターバルタイマークラス")]IntervalTimer _intervalTimer = new IntervalTimer();
    [Tooltip("インターバルの時間設定"), SerializeField] float _interval;
    [Tooltip("反射回数"), SerializeField] int _reflect = 2;
    [Tooltip("減らすインターバルの値"), SerializeField] float _reduceInterval;
    [Tooltip("インターバルの最小値"), SerializeField] float _minimumInterval;
    [Tooltip("偶数かどうか")]bool _even;
    [Tooltip("攻撃中かどうか")]bool _isCurrentShot;
    public void Setup()
    {
        _intervalTimer.Setup(_interval);
    }

    public void Update()
    {
        _intervalTimer.RunTimerOneShot();
        
        if(_intervalTimer.RunTimerOneShot())
        {
            _isCurrentShot = true;
        }

        if(_isCurrentShot)
        {
            BeemMethod();
        }
    }

    void BeemMethod()
    {

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
}
