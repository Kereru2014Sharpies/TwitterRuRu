using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace TwitterRuRu
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table(IdentityMethod=IdentityMethod.IdentityColumn)]
  public partial class Accounts : Entity<int>
  {
    #region Fields
  
    [ValidateLength(0, 50)]
    [ValidateUnique]
    private string _user_login;
    [ValidateLength(0, 50)]
    private string _password_hash;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the user_login entity attribute.</summary>
    public const string user_loginField = "user_login";
    /// <summary>Identifies the password_hash entity attribute.</summary>
    public const string password_hashField = "password_hash";


    #endregion
    
    #region Properties



    [System.Diagnostics.DebuggerNonUserCode]
    public string user_login
    {
      get { return Get(ref _user_login, "user_login"); }
      set { Set(ref _user_login, value, "user_login"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string password_hash
    {
      get { return Get(ref _password_hash, "password_hash"); }
      set { Set(ref _password_hash, value, "password_hash"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the LightSpeedModel1 model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class LightSpeedModel1UnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<Accounts> Accounts
    {
      get { return this.Query<Accounts>(); }
    }
    
  }

}
