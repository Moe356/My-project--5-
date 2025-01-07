using System;
using UnityEngine;

namespace Assignment18
{
    public struct Position
    {
        public float X, Y, Z;

        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void PrintPosition()
        {
            Debug.Log("Position: X = " + X + ", Y = " + Y + ", Z = " + Z);
        }
    }

    public class Character
    {
        public string Name;
        private int _health;
        protected Position Position;

        public int Health
        {
            get { return _health; }
            set
            {
                if (value > 100) _health = 100;
                else if (value < 0) _health = 0;
                else _health = value;
            }
        }

        public Character(string name, int health, Position position)
        {
            Name = name;
            Health = health;
            Position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log("Name: " + Name);
            Debug.Log("Health: " + Health);
            Position.PrintPosition();
        }

        public void Attack(int damage, Character target, string attackType = null)
        {
            target.Health -= damage;
            if (attackType != null)
            {
                Debug.Log(Name + " performed a " + attackType + " attack on " + target.Name + ", dealing " + damage + " damage.");
            }
            else
            {
                Debug.Log(Name + " attacked " + target.Name + ", dealing " + damage + " damage.");
            }
        }
    }

    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) : base(name, health, position)
        {
        }

        public Soldier() : base()
        {
        }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }

    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position) { }

        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}
