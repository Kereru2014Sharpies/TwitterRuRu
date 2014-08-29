using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;
using Mindscape.LightSpeed.Logging;
using TwitterRuRu.Plumbing;


namespace TwitterRuRu.Models
{
    public class PersistAccountModel
    {
        //redundant
        //public List<Accounts>AccountsList { get; set; }

        public void Create(Accounts persistObject)
        {
            using (Repository<Accounts> DataAccessHelper = new Repository<Accounts>())
            {
                DataAccessHelper.Add(persistObject);
                DataAccessHelper.SaveChanges();
            }
        }

        public List<Accounts> ReadAll()
        {
            using (Repository<Accounts> DataAccessHelper = new Repository<Accounts>())
            {
                return DataAccessHelper.GetAll().ToList();
            }
        }

        //public string ReadRow(int id)
        //{
        //    using (Repository<Accounts> DataAccessHelper = new Repository<Accounts>())
        //    {
        //        Accounts temp = DataAccessHelper.FindById(id);
        //        return temp.LongAccounts;
        //    }
        //}

        public Accounts GetObject(int id)
        {
            using (Repository<Accounts> DataAccessHelper = new Repository<Accounts>())
            {
                return DataAccessHelper.FindById(id);
            }
        }

        public void SaveObject(Accounts Accounts)
        {
            using (Repository<Accounts> DataAccessHelper = new Repository<Accounts>())
            {
                DataAccessHelper.Add(Accounts);
                DataAccessHelper.SaveChanges();
            }
        }
    }
}