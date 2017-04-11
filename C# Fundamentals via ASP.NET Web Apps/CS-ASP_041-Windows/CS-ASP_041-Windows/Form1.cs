using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroMonster;

namespace CS_ASP_041_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            resultLabel.Text += String.Format("\r\nName: {0} - Health: {1} - DamageMax: {2} - Attack Bonus: {3}", character.Name, character.Health.ToString(), character.DamageMaximum.ToString(), character.AttackBonus);
        }

        private void displayResult(Character opp1, Character opp2)
        {
            if (opp1.Health <= 0 && opp2.Health <= 0)
                resultLabel.Text += String.Format("\r\nBoth {0} and {1} died.", opp1.Name, opp2.Name);
            else if (opp1.Health <= 0)
                resultLabel.Text += String.Format("\r\n{0} defeats {1}.", opp2.Name, opp1.Name);
            else
                resultLabel.Text += String.Format("\r\n{0} defeats {1}.", opp1.Name, opp2.Name);
        }
    }
}
