using System;
using Banks.Banks.Limits;

namespace Banks.Banks.Factory
{
    public class SimpleBankFactory : IBankFactory
    {
        public IBank CreateBank(Limit limit)
        {
            var id = Guid.NewGuid();
            return new Bank(id, limit);
        }
    }
}