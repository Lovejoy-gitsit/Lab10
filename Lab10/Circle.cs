using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab10
{
    class Circle
    {
        const double pi = Math.PI;
        #region DataMembers
        //data members
        private double _radius;
        #endregion

        #region Properties
        //properties
        public double Radius
        {
            set //give a value to _radius
            {
                _radius = value;
            }
            get //give a value to _radius
            {
                return _radius;
            }
        }
        #endregion

        #region CalculateCircumference
        public double CalculateCircumference()
        {
            double circumference = 2*(pi * Radius);
            return circumference;
        }
        #endregion

        #region CalculateArea
        public double CalculateArea()
        {
            double area = (Radius * Radius) * pi;
            return area;
        }
        #endregion

        #region CalculateFormattedCircumference
        public string CalculateFormattedCircumference()
        {
            double circumference = 2 * (pi * Radius);
            return($"{circumference, 0:N2}");
        }
        #endregion

        #region CalculateFormattedArea
        public string CalculateFormattedArea()
        {
            double area = (Radius * Radius) * pi;
            return ($"{area,0:N2}");
        }
        #endregion


    }
}
