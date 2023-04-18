using Models;
using Services;

namespace Controllers
{
    public class StoreController
    {
        private StoreService storeService;

        public StoreController()
        {
            storeService = new StoreService();
        }

        public bool Insert(Store store)
        {
            return storeService.Insert(store);
        }

        public List<Store> GetAll()
        {
            return storeService.GetAll();
        }
    }
}