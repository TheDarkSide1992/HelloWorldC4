namespace Repository;

public class GreetingRepository
{
    public string GetGreeting(string language)
    {
        var output = "";
        output = language switch
        {
            "en" => "Greetings",
            "dk" => "Goddag",
            _ => "not found"
        };
        return output;
    }
}