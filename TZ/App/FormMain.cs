﻿using Geometry.Figures;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class FormMain : Form
    {
        private IFigure _figure;

        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnSquareForCircleOnClick(object sender, EventArgs e)
        {
            try
            {
                var parsed = double.TryParse(txtCircleRadius.Text, out var radius);
                if (!parsed)
                {
                    throw new Exception("Указан некорректный радиус");
                }

                _figure = new Circle(radius);
                var circleSquare = _figure.CalculateSquare();

                MessageBox.Show($"Площадь окружности с радиусом {radius} равна {circleSquare}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnTriangleForSquareOnClick(object sender, EventArgs e)
        {
            try
            {
                var firstSideParsed = double.TryParse(txtFirstTriangleSide.Text, out var firstSide);
                var secondSideParsed = double.TryParse(txtSecondTriangleSide.Text, out var secondSide);
                var thirdSideParsed = double.TryParse(txtThirdTriangleSide.Text, out var thirdSide);

                if (!firstSideParsed ||
                    !secondSideParsed ||
                    !thirdSideParsed)
                {
                    throw new Exception("Одна или более сторон треугольника указаны некорректно");
                }

                _figure = new Triangle(firstSide, secondSide, thirdSide);
                var triangleSquare = _figure.CalculateSquare();

                MessageBox.Show($"Площадь треугольника со сторонами {firstSide}, {secondSide}, {thirdSide} равна {triangleSquare}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
