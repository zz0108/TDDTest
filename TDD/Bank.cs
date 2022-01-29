using System.Collections;
using System.Net;

namespace TDD;

public class Bank
{
    private Dictionary<Pair,int> rates = new Dictionary<Pair,int>();
    private class Pair
    {
        private string _from { get; set; }
        private string _to { get; set; }

        public Pair(string from, string to)
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
    public Money Reduce(ISimpleExpression source, string to)
    {
        return source.Reduce(this,to);
    }

    public void AddRate(string from, string to,int rate)
    {
        rates.Add(new Pair(from,to), rate);
    }
    public int Rate(string from, string to)
    {
        if (from.Equals(to)) return 1;
        int rate = rates.GetValueOrDefault(new Pair(from, to));
        return rate;
    }
}