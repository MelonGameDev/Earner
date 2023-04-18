using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace BuutonSourse
{
    public class MoneyButton
    {
        private int _money = 100;
        public int Money
        {
            get
            {
                if (_money <= 0)
                    return _money = 0;
                else
                    return _money;
            }
            set
            {
                _money = value;
            }
        }

        public virtual int Add(int value)
        {
            Money += value;
            return Money;
        }

        public virtual int TakeAway(int value)
        {
            Money -= value;
            return Money;
        }
    }

    public class FoodButton
    {
        private int _food = 100;
        public int Food
        {
            get
            {
                if (_food <= 0)
                    return _food = 0;
                else if (_food >= 300)
                    return _food = 300;
                else
                    return _food;
            }
            set
            {
                _food = value;
            }
        }

        public virtual int Add(int value)
        {
            Food += value;
            return Food;
        }

        public virtual int TakeAway(int value)
        {
            Food -= value;
            return Food;
        }
    }

    public class ElectricityButton
    {
        private int _electricity = 100;
        public int Electricity
        {
            get
            {
                if (_electricity <= 0)
                    return _electricity = 0;
                else if (_electricity >= 100)
                    return _electricity = 100;
                else
                    return _electricity;
            }
            set
            {
                _electricity = value;
            }
        }

        public virtual int Add(int value)
        {
            Electricity += value;
            return Electricity;
        }

        public virtual int TakeAway(int value)
        {
            Electricity -= value;
            return Electricity;
        }
    }
}