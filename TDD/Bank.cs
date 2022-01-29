using System.Collections;
using System.Net;

namespace TDD;

public class Bank
{
    private Dictionary<Pair,int> rates = new Dictionary<Pair,int>();
    private class Pair
    {
        private CurrencyType _from { get; set; }
        private CurrencyType _to { get; set; }

        public Pair(CurrencyType from, CurrencyType to)
        {
            _from = from;
            _to = to;
        }

        public override bool Equals(object? obj)
        {
            Pair pair = (Pair)obj;
            return _from.Equals(pair._from) && _to.Equals(pair._to);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
    public Money Reduce(ISimpleExpression source, CurrencyType to)
    {
        return source.Reduce(this,to);
    }

    public void AddRate(CurrencyType from, CurrencyType to,int rate)
    {
        rates.Add(new Pair(from,to), rate);
    }
    public int Rate(CurrencyType from, CurrencyType to)
    {
        if (from.Equals(to)) return 1;
        int rate = rates.GetValueOrDefault(new Pair(from, to));
        return rate;
    }
}