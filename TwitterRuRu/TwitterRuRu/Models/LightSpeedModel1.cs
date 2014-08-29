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
  
    [Column("AspNetUser_Id")]
    private string _aspNetUserId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the AspNetUserId entity attribute.</summary>
    public const string AspNetUserIdField = "AspNetUserId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Accounts")]
    private readonly EntityHolder<AspNetUser> _aspNetUser = new EntityHolder<AspNetUser>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public AspNetUser AspNetUser
    {
      get { return Get(_aspNetUser); }
      set { Set(_aspNetUser, value); }
    }


    /// <summary>Gets or sets the ID for the <see cref="AspNetUser" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public string AspNetUserId
    {
      get { return Get(ref _aspNetUserId, "AspNetUserId"); }
      set { Set(ref _aspNetUserId, value, "AspNetUserId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("AspNetUsers")]
  public partial class AspNetUser : Entity<string>
  {
    #region Fields
  
    private string _userName;
    private string _passwordHash;
    private string _securityStamp;
    [ValidatePresence]
    [ValidateLength(0, 128)]
    private string _discriminator;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the UserName entity attribute.</summary>
    public const string UserNameField = "UserName";
    /// <summary>Identifies the PasswordHash entity attribute.</summary>
    public const string PasswordHashField = "PasswordHash";
    /// <summary>Identifies the SecurityStamp entity attribute.</summary>
    public const string SecurityStampField = "SecurityStamp";
    /// <summary>Identifies the Discriminator entity attribute.</summary>
    public const string DiscriminatorField = "Discriminator";


    #endregion
    
    #region Relationships

    [ReverseAssociation("AspNetUser")]
    private readonly EntityCollection<Accounts> _accounts = new EntityCollection<Accounts>();
    [ReverseAssociation("AspNetUserTweet")]
    private readonly EntityCollection<Tweets> _tweets = new EntityCollection<Tweets>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Accounts> Accounts
    {
      get { return Get(_accounts); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Tweets> Tweets
    {
      get { return Get(_tweets); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string UserName
    {
      get { return Get(ref _userName, "UserName"); }
      set { Set(ref _userName, value, "UserName"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string PasswordHash
    {
      get { return Get(ref _passwordHash, "PasswordHash"); }
      set { Set(ref _passwordHash, value, "PasswordHash"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string SecurityStamp
    {
      get { return Get(ref _securityStamp, "SecurityStamp"); }
      set { Set(ref _securityStamp, value, "SecurityStamp"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Discriminator
    {
      get { return Get(ref _discriminator, "Discriminator"); }
      set { Set(ref _discriminator, value, "Discriminator"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table(IdentityMethod=IdentityMethod.IdentityColumn)]
  public partial class Tweets : Entity<int>
  {
    #region Fields
  
    private string _message;
    private System.DateTime _created_date;
    [Column("AspNetUser_TweetID")]
    private string _aspNetUserTweetId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the message entity attribute.</summary>
    public const string messageField = "message";
    /// <summary>Identifies the created_date entity attribute.</summary>
    public const string created_dateField = "created_date";
    /// <summary>Identifies the AspNetUserTweetId entity attribute.</summary>
    public const string AspNetUserTweetIdField = "AspNetUserTweetId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Tweets")]
    private readonly EntityHolder<AspNetUser> _aspNetUserTweet = new EntityHolder<AspNetUser>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public AspNetUser AspNetUserTweet
    {
      get { return Get(_aspNetUserTweet); }
      set { Set(_aspNetUserTweet, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string message
    {
      get { return Get(ref _message, "message"); }
      set { Set(ref _message, value, "message"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime created_date
    {
      get { return Get(ref _created_date, "created_date"); }
      set { Set(ref _created_date, value, "created_date"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="AspNetUserTweet" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public string AspNetUserTweetId
    {
      get { return Get(ref _aspNetUserTweetId, "AspNetUserTweetId"); }
      set { Set(ref _aspNetUserTweetId, value, "AspNetUserTweetId"); }
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
    
    public System.Linq.IQueryable<AspNetUser> AspNetUsers
    {
      get { return this.Query<AspNetUser>(); }
    }
    
    public System.Linq.IQueryable<Tweets> Tweets
    {
      get { return this.Query<Tweets>(); }
    }
    
  }

}
