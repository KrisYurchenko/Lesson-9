using System;

namespace ConsoleApp1
{
    public class Knight : Unit
    {
        public override void Attack()
        {
            Console.WriteLine($"Knight attacks: {Damage}");
        }
    }
}