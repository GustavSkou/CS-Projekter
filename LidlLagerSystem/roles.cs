class User 
{
    public string username;
    private string password;
    public bool 
        canLookUp = false, 
        canChangePrice = false, 
        canChangeName = false, 
        CanChangeUnitCount = false;

    public User (string username, string password)
    {
        this.username = username;
        this.password = password;
        this.canLookUp = true;
    }
    
}

class Admin : User 
{
    public Admin(string username, string password) : base(username, password)
    {
        canChangePrice = true; 
        canChangeName = true; 
        CanChangeUnitCount = true;
    }
}