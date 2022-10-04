//Exercise Vin Fletcher Arrow 


Console.WriteLine("        Welcome to Vin Fletcher's Arrow      ");
Console.WriteLine("   Fletcher is the best arrow maker in town  ");
Console.WriteLine("     Arrow made to order, to fit your bow    "); 

FletchersArrow arrow = GetArrow(); 
Console.WriteLine($"Your arrow costs {arrow.GetCost()} gold. "); 

FletchersArrow GetArrow()
{
    TheArrowHead arrowHead = GetArrowHead();
    TheFletching fletching = GetFletching();
    float length = GetLength();

    return new FletchersArrow(arrowHead, fletching, length);  
}

TheArrowHead GetArrowHead()
{
    Console.Write("Choose your prefer arrow head (steel, wood, obsidian): ");
    string inputHead = Console.ReadLine();
    return inputHead switch
    {
        "steel" => TheArrowHead.Steel,
        "wood" => TheArrowHead.Wood,
        "obsidian" => TheArrowHead.Obsidian
    }; 
}
TheFletching GetFletching()
{
    Console.Write("Choose your prefer fletching (plastic, turkey feathers, goose feathers): ");
    string inputFletching = Console.ReadLine();
    return inputFletching switch
    {
        "plastic" => TheFletching.Plastic,
        "turkey feathers" => TheFletching.TurkerFeathers,
        "goose feathers" => TheFletching.GooseFeathers
    };
}

float GetLength()
{
    float length = 0;   
    while (length < 60 || length > 100)
    {
        Console.Write("Arrow length (between 60 and 100): ");
        length = Convert.ToSingle(Console.ReadLine());
    }
    return length;   
}

class FletchersArrow
{
    public TheArrowHead _arrowHead;
    public TheFletching _fletching;
    public float _length; 

    public FletchersArrow(TheArrowHead arrowHead, TheFletching fletching, float length)
    {
        _arrowHead = arrowHead; 
        _fletching = fletching; 
        _length = length;   
    }
    public float GetCost()
    {
        float arrowheadCost = _arrowHead switch
        {
            TheArrowHead.Steel => 10,
            TheArrowHead.Wood => 3,
            TheArrowHead.Obsidian => 5
        };
        float fletchingCost = _fletching switch
        {
            TheFletching.Plastic => 10,
            TheFletching.TurkerFeathers => 5,
            TheFletching.GooseFeathers => 3
        };
        float shaftCost = 0.05f * _length; //0.05float

        return arrowheadCost + fletchingCost + shaftCost;   
    }
}
enum TheArrowHead { Steel, Wood, Obsidian }
enum TheFletching { Plastic, TurkerFeathers, GooseFeathers } 