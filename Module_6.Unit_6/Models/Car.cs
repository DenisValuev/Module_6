using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Unit_6.Models
{
    enum TurnDirection
    {
        None = 0,
        Left,
        Rigth
    }
    internal class Car
    {
        private double Fuel;
        private int Mileage;
        private string color;
        private TurnDirection turn;
        public Car()
        {
            Fuel = 50;
            Mileage = 0;
            color = "White";
        }
        private void Move()
        {
            //Move a kilometer
            Mileage++;
            Fuel -= 0.5;
        }
        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
        public string GetColor()
        {
            return color;
        }
        public void ChangeColor(string newColor)
        {
            if (color != newColor)
            {
                color = newColor;
            }
        }
        public bool IsTurningLeft()
        {
            return turn == TurnDirection.Left;
        }
        public bool IsTurningRight()
        {
            return turn == TurnDirection.Rigth;
        }
    }
}
