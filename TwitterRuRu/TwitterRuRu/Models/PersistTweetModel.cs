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
    public class PersistTweetModel
    {
        //redundant
        //public List<Accounts>AccountsList { get; set; }

        public void Create(Tweets persistObject)
        {
            using (Repository<Tweets> DataAccessHelper = new Repository<Tweets>())
            {
                DataAccessHelper.Add(persistObject);
                DataAccessHelper.SaveChanges();
            }
        }

        public List<Tweets> ReadAll()
        {
            using (Repository<Tweets> DataAccessHelper = new Repository<Tweets>())
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

        public Tweets GetObject(int id)
        {
            using (Repository<Tweets> DataAccessHelper = new Repository<Tweets>())
            {
                return DataAccessHelper.FindById(id);
            }
        }

        public void SaveObject(Tweets tweet)
        {
            using (Repository<Tweets> DataAccessHelper = new Repository<Tweets>())
            {
                DataAccessHelper.Add(tweet);
                DataAccessHelper.SaveChanges();
            }
        }
    }
}