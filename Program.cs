using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine();
            Heister teamMember;

            // List<Heister> heistTeam = new List<Heister>();

            Console.WriteLine("What is the team member's name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is the team member's skill level?");
            string skillLevelString = Console.ReadLine();
            int skillLevel;

            try
            {
                skillLevel = int.Parse(skillLevelString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{skillLevelString} is not a valid skill level. Skill level now set to 10.");
                skillLevel = 10;
            }

            Console.WriteLine("What is the team member's courage factor?");
            string courageFactorString = Console.ReadLine();
            decimal courageFactor;

            try
            {
                courageFactor = decimal.Parse(courageFactorString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{courageFactorString} is not a valid courage factor. Courage Factor now set to 10.");
                // Console.WriteLine(ex.Message);
                courageFactor = 1.1M;
            }

            teamMember = new Heister()
            {
                Name = name,
                SkillLevel = skillLevel,
                CourageFactor = courageFactor
            };

            Console.WriteLine($"Name: {teamMember.Name}");
            Console.WriteLine($"Skill Level: {teamMember.SkillLevel}");
            Console.WriteLine($"Courage Factor: {teamMember.CourageFactor}");

        }
    }
}