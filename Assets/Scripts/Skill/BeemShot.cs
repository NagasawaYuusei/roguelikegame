using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeemShot : MonoBehaviour, ISkill
{
    public SkillDef SkillId => SkillDef.ShotBullet;
    [Tooltip("�C���^�[�o���^�C�}�[�N���X")] IntervalTimerNaga _intervalTimer = new IntervalTimerNaga();
    [Tooltip("�C���^�[�o���̎��Ԑݒ�"), SerializeField] float _interval;
    [Tooltip("���ˉ�"), SerializeField] int _reflect = 2;
    [Tooltip("���炷�C���^�[�o���̒l"), SerializeField] float _reduceInterval;
    [Tooltip("�C���^�[�o���̍ŏ��l"), SerializeField] float _minimumInterval;
    [Tooltip("�������ǂ���")] bool _even;
    public void Setup()
    {
        _intervalTimer.Setup(_interval);
    }

    public void Update()
    {
        _intervalTimer.RunTimerOneShot();

        if (_intervalTimer.RunTimerOneShot())
        {
            _intervalTimer.TimerStopOrPlay(false);
            BeemMethod();
        }
    }

    void BeemMethod()
    {

    }

    public void Levelup()
    {
        if (!_even || _minimumInterval > _interval)
        {
            _reflect++;
        }
        else if (_even && _minimumInterval <= _interval)
        {
            _interval -= _reduceInterval;
        }
        else
        {
            Debug.LogError("��O���x���A�b�v");
        }
    }
}
