public class Car
{
    public string Make { get; }
    public string Model { get; }

    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public override bool Equals(object obj)
    {
        return obj is Car other &&
               Make == other.Make &&
               Model == other.Model;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Make, Model);
    }
}

