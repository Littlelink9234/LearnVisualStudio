using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Jason";
            hero.Health = 35;
            hero.DamageMaximum = 20;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Monster";
            monster.Health = 21;
            monster.DamageMaximum = 25;
            monster.AttackBonus = true;

            Dice dice = new Dice();

            // Bonus
            if (hero.AttackBonus)
                monster.Defend(hero.Attack(dice));
            

            if (monster.AttackBonus)
                hero.Defend(monster.Attack(dice));

            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(dice));
                hero.Defend(monster.Attack(dice));

                printStats(hero);
                printStats(monster);
            }

            displayResult(hero, monster);
        }

        private void printStats(Character character)
        {
            resultLabel.InnerHtml += String.Format("<p>Name: {0} - Health: {1} - DamageMax: {2} - Attack Bonus: {3}</>", character.Name, character.Health.ToString(), character.DamageMaximum.ToString(), character.AttackBonus);
        }

        private void displayResult(Character opp1, Character opp2)
        {
            if (opp1.Health <= 0 && opp2.Health <= 0)
                resultLabel.InnerHtml += String.Format("<p>Both {0} and {1} died.</p>", opp1.Name, opp2.Name);
            else if (opp1.Health <= 0)
                resultLabel.InnerHtml += String.Format("<p>{0} defeats {1}.</p>", opp2.Name, opp1.Name);
            else
                resultLabel.InnerHtml += String.Format("<p>{0} defeats {1}.</p>", opp1.Name, opp2.Name);
        }
    }

    class Dice
    {
        public int Sides { get; set; }
        Random random = new Random();

        public int Roll()
        {
            return random.Next(this.Sides);
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            //Random random = new Random();
            //int damage = random.Next(this.DamageMaximum);
            dice.Sides = this.DamageMaximum;            
            return dice.Roll();
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
}