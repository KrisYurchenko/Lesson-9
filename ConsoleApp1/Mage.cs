using System;

namespace ConsoleApp1
{
    public class Mage : Unit
    {
        public int Magic { get; set; }
        
        public override void Attack()
        {
            Console.WriteLine($"Mage make his {Magic} and damage is {Damage}");
        }
    }
}