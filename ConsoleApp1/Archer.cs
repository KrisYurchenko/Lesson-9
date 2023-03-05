using System;
using ConsoleApp1;

namespace ConsoleApp1
{
    public class Archer : Unit 
    {
        public string Shoot { get; set; }
        
        public override void Attack()
        {
            Console.WriteLine($"Archer shoots {Shoot} and damage is {Damage}");
        }
    }
}