using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount
    {
        int _pointsBalance;

        public int PointsBalance
        {
            get
            {
                return _pointsBalance;
            }
            private set
            {
                ValueValidator.AssertOnPositiveValue(value, nameof(PointsBalance));
                _pointsBalance = value;
            }
        }

        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            if (PointsBalance > amount * 0.3)
            {
                return Math.Floor(amount * 0.3);
            }
            else
            {
                return PointsBalance;
            }
        }

        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            PointsBalance-=(int)discountAmount;
            return discountAmount;
        }

        public void Update(List<Item> items)
        {
            double amount = GetAmount(items);
            PointsBalance += (int)Math.Ceiling(amount * 0.1);

        }

        public double GetAmount(List<Item> items)
        {
            double sum = 0;
            items.ForEach(x => { sum += x.Cost; });
            return Math.Round(sum, 2);
        }

        public string Info
        {
            get
            {
                return $"Накопительная - {PointsBalance} баллов";
            }
        }

        public PointsDiscount(int pointsBalance)
        {
            PointsBalance = pointsBalance;
        }

        public override string ToString()
        {
            return Info;
        }
    }
}

