using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Abstracts
{
    public interface IObserver
    {
        void Update(float temperature, float hunidity, float pressure);
    }
}
