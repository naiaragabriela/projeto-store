using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using Models;

namespace Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private string Conn { get; set; }


        public StoreRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }
        public List<Store> GetAll()
        {
            using(var db = new SqlConnection(Conn))
            {
                var stores = db.Query<Store>(Store.GETALL);
                return (List<Store>)stores;
            }
        }

        public bool Insert(Store store)
        {
            var status = false;
            using(var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Store.INSERT, store);
                status = true;
                return status; 
            }
        }
    }
}