namespace Battleships.Interface
{
    using Battleships.Ships;

    public interface IAttack
    {
        string Attack(Ship targetShip);
    }
}
