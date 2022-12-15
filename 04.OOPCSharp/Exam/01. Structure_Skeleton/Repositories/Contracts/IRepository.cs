
namespace ChristmasPastryShop.Repositories.Contracts
{
    using System.Collections.Generic;
    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> Models { get; }
        object Select { get; }

        void AddModel(T model);
    }
}
