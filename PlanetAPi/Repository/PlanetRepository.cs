namespace Repository;

public class PlanetRepository
{
    public List<String> getPlanets(string language)
    {
        List<String> PLanets;
        PLanets = language switch
        {
            "EN" => ["Mercury", "venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"],
            "DK" => ["Merkur", "Venus", "Jorden", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun"]
        };

        return PLanets;
    }
}