using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace UnoTemplate.Entities
{
  public partial class User : GenericPrincipal
  {
    public User(string userName, params string[] roles) : base(new GenericIdentity(userName), roles)
    {
    }

    public User(IIdentity identity, string[] roles) : base(identity, roles)
    {
    }

    public int Id { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

  }  
}
