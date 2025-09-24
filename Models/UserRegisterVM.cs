using System.Collections.Generic;

public class UserRegisterVM 
{
    public string UserName { get; set; } = "phi";
    public string Email { get; set; }
    public string Password { get; set; }
    public bool Gender { get; set; } = false;
    public string City { get; set; }
    public List<string> Hobbies { get; set; } = new List<string>() {"Ngủ" };
}