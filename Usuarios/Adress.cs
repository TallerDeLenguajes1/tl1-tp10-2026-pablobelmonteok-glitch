  public class Geo
{
     public string? lat {get;set;}

    public string? lng {get;set;}

}

public class Usuarios
{
    public int? id {get;set;}
    public string? name {get;set;}
    public string? username {get;set;}
    public string? email {get;set;}
    public Adress? address {get;set;}
}
public class Adress
{
     public string? street {get;set;}

     public string? suite {get;set;}    

      public string? city {get;set;}
       public string? zipcode {get;set;}
       public  Geo? geo {get;set;}
}
