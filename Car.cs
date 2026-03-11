public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Car car)
        {
            return string.Equals(this.Make, car.Make) && 
                   string.Equals(this.Model, car.Model);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Make, Model);
    }
}

