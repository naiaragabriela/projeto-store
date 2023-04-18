using Models;
using Repositories;

namespace Services
{
    public class StoreService
    {

        private IStoreRepository storeRepository;
        
        public StoreService()
        {
            storeRepository = new StoreRepository();
        }
        public bool Insert(Store store)
        {
            return storeRepository.Insert(store) ;
        }

        public List<Store> GetAll()
        {
            return storeRepository.GetAll();

        }
    }
}