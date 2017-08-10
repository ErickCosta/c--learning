
public class Count
{
    public int count;
    public string name;
    public double total;
    public Address address;

    public Count()
    {
    }

    public double Transfer(double value, Count sub, Count sum)
    {
        sub.total -= value;
        sum.total += value;

        return sub.total;
    }
}
