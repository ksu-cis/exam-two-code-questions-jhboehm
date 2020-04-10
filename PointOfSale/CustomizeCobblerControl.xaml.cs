using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;
using FruitFilling = ExamTwoCodeQuestions.Data.FruitFilling;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }
        private void FruitRadioButton_Click(object sender, RoutedEventArgs e)
        {
            FruitFilling fruit;

            switch (((RadioButton)sender).Name)
            {
                case "BlueberryButton":
                    fruit = FruitFilling.Blueberry;
                    break;
             
                case "CherryButton":
                    fruit = FruitFilling.Cherry;
                    break;

                case "PeachButton":
                    fruit = FruitFilling.Peach;
                    break;

                default:
                    throw new NotImplementedException("Invalid Choice");
            }

            if (DataContext is Cobbler)
            {
                Cobbler cobbler = (Cobbler)DataContext;
                cobbler.Fruit = fruit;
            }
            else
                throw new NotImplementedException("Only Jerked soda should be the datacontext");
        }
    }
}
