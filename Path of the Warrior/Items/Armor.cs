﻿using Characters;
using Interfaces;
using System;
using System.Windows.Media;

namespace Items
{

    public class Armor : Item, IHealthUp
    {
        private int hp;

        public ImageSource Avatar { get; set; }

        public Armor(string Name, string Description, int hp)
            : base(Name, Description)
        {
            this.BonusHealth = hp;
        }

        public Armor(int hp) 
        {
            this.BonusHealth = hp;
        }

        public Armor() 
        {
        }


        public int BonusHealth { get; set; }

        public void AddHealth(Character character)
        {
            character.HP += BonusHealth;
        }
    }

}