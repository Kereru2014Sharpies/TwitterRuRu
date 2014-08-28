using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Mindscape.LightSpeed;
using Mindscape;
using Mindscape.LightSpeed.Linq;

namespace TwitterRuRu.Models
{
    public class CustomAccountModel
    {
        private PersistModel _persistModel = new PersistModel();
        public void AddTwitterRuRuAcc(string id)
        {
            Accounts AccObject = new Accounts();
            AccObject.AspNetUserId = id;


            _persistModel.Create(AccObject);
            
        }

        public List<Accounts> getShortUrls()
        {
            return _persistModel.ReadAll();
        }

        internal bool CheckURL(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }

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