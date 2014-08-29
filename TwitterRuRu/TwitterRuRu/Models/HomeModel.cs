using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Mindscape.LightSpeed;
using Mindscape;
using Mindscape.LightSpeed.Linq;

namespace TwitterRuRu.Models
{
    public class HomeModel
    {
        private PersistAccountModel _persistAccountModel = new PersistAccountModel();
        private PersistTweetModel _persistTweetModel = new PersistTweetModel();

        #region Account profiles Methods
        public void AddTwitterRuRuAcc(string id)
        {
            Accounts AccObject = new Accounts();
            AccObject.AspNetUserId = id;
            _persistAccountModel.Create(AccObject);
        }

        #endregion

        #region Tweets Methods
        public void AddTweet(string inmessage, string CurrentId)
        {
            if (CheckTweetLength(inmessage) == true)
            {
                Tweets tweetObject = new Tweets();
                tweetObject.AspNetUserTweetId = CurrentId;
                tweetObject.message = inmessage;
                tweetObject.created_date = DateTime.Now;
                _persistTweetModel.Create(tweetObject);
            }
            else
            {
                //TODO - investigate adding error message to main page
            }
        }

       internal bool CheckTweetLength(string tweetMessage)
        {
            int tweetLength = tweetMessage.Count();
            if (tweetLength > 140)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        public List<Tweets> getTweets()
        {
            return _persistTweetModel.ReadAll();
        }

        public List<Tweets> getTweetsUser(string currentUser)
        {
            return _persistTweetModel.ReadAll().Where(w => w.AspNetUserTweetId == currentUser).OrderByDescending(o => o.created_date).ToList();
        }
        #endregion

 

        //public string getLongURL(int id)
        //{
        //    return _persistModel.ReadRow(id);
        //}

        //public void Counter(int id)
        //{
        //    Accounts account = _persistModel.GetObject(id);
        //    url.Counter++;
        //}
    }
}