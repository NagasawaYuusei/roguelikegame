using UnityEngine;

public class IntervalTimerNaga
{
    float _interval = 1;
    float _timer = 0;
    bool _isTimer = true;

    public void Setup(float inv)
    {
        _interval = inv;
    }

    /// <summary>
    /// Update‚Å‰ñ‚·
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
        if(!_isTimer)
            return false;
        _timer += Time.deltaTime;
        if(_timer >= _interval)
        {
            _timer = 0;
            return true;
        }
        return false;
    }

    public void TimerStopOrPlay(bool on)
    {
        _isTimer = on;
    }
}
