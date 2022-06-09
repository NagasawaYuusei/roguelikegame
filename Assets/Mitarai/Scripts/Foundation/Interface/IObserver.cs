using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 観察者
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IObserver<T>
{
    void NotifyUpdate(T obj);
}
