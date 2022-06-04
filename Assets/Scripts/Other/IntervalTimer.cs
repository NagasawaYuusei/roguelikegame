using UnityEngine;

public class IntervalTimer
{
    float _interval = 1;
    float _timer = 0;

    public void Setup(float inv)
    {
        _interval = inv;
    }

    /// <summary>
    /// Update�ŉ�
    /// </summary>
    /// <returns></returns>
    public bool RunTimer()
    {
        _timer += Time.deltaTime;
        if (_timer >= _interval)
        {
            _timer -= _interval;
            return true;
        }
        return false;
    }

    public bool RunTimerOneShot()
    {
        _timer += Time.deltaTime;
        if(_timer >= _interval)
        {
            _timer = 0;
            return true;
        }
        return false;
    }
}
