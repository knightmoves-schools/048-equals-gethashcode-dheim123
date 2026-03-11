public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Car car)
        {
            return this.Make == car.Make && this.Model == car.Model;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (Make, Model).GetHashCode();
    }
}
