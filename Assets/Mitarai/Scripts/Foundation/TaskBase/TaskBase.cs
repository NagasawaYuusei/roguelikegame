using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// タスクのインターフェース
/// </summary>
interface ITaskBase
{
    int Update();
}

/// <summary>
/// タスクインターフェースを継承したベースクラス
/// </summary>
class TaskBase : ITaskBase
{
    public int Update()
    {
        return 0;
    }
}