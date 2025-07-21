public class Budget
{
    public decimal Balance;
    public List<Damage> Damages;

    public Budget()
    {
        Balance = 0;
        Damages = new List<Damage>();
    }

    public void AddDamage(Damage damage)
    {
        Damages.Add(damage);
        damage.ApplyToBalance(this);
    }
}
