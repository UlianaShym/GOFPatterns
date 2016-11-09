using GofPatternsFun.Behavioral.Observer.Objects;

namespace GofPatternsFun.Behavioral.Observer.Observers
{
    public interface IInvestor
    {
        void Update(Subject stock);
    }
}