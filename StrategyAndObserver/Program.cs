using System;
using System.Collections.Generic;

namespace StrategyAndObserver
{
    class Context
    {
        private TaxiUser _user = new TaxiUser();
        private TaxiDriver _driver = new TaxiDriver();
        
        public void Perfomance()
        {
            _user.Add(_driver);
            _driver.Decide(new DeclineRequest());
            _user.Notify();
            _driver.Decide(new AcceptRequest());
            _user.Notify();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Context cnt = new Context();
            cnt.Perfomance();
        }
    }
}
