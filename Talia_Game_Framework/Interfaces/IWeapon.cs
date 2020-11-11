namespace Talia_Game_Framework
{
    public interface IWeapon : IEquiptment
    {
        int Attackpoints { get; set; }


        //public override string ToString()
        //{
        //    string s = $"{Name} has {Attackpoints} points of Attack force!";
        //    return s;
        //}
    }
}