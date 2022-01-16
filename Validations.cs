public class ValidatorDTO{    
    // public static List<string> Errors=new List<string>();
    public static List<string> ErrorList {get;set; } = new List<string>();
    // private static bool isValid ;
    public static bool IsValid {get;set; }
   }
public class Validators
{
    

    public static async Task DateValidator()
    {
        await Task.Delay(5000);
        ValidatorDTO.ErrorList.Add("invalid");
        ValidatorDTO.IsValid = false;

    }
    public static async Task NameValidator()
    {

         await Task.Delay(4000);
        ValidatorDTO.ErrorList.Add("invalid");
        ValidatorDTO.IsValid = false;
    }
    public static async Task AgeValidator()
    {

         await Task.Delay(3000);
        ValidatorDTO.ErrorList.Add("invalid");
        ValidatorDTO.IsValid = false;
    }
    public static async Task MaritalStatusValidator()
    {

         await Task.Delay(2000);
        ValidatorDTO.ErrorList.Add("invalid");
        ValidatorDTO.IsValid = false;
    }
    public static async Task IdentityValidator()
    {

         await Task.Delay(1000);
        ValidatorDTO.ErrorList.Add("invalid");
        ValidatorDTO.IsValid = false;
    }
}