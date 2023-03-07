using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MessegeCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator.ViewModels
{
    public partial class CalculatorVM : ObservableObject
    {
        [ObservableProperty]
        private  int buttonOne = 1;

        [ObservableProperty]
        private  int buttonTwo = 2;

        [ObservableProperty]
        private  int buttonThree = 3;

        [ObservableProperty]
        private  int buttonFour = 4;

        [ObservableProperty]
        private  int buttonFive = 5;

        [ObservableProperty]
        private  int buttonSix = 6;

        [ObservableProperty]
        private  int buttonSeven = 7;

        [ObservableProperty]
        private  int buttonEight = 8;

        [ObservableProperty]
        private  int buttonNine = 9;

        [ObservableProperty]
        private double result, lastNumber;

        [ObservableProperty]
        SelectedOperator selectedOperator;

        [ObservableProperty]
        private int clickedNumber;

        [ObservableProperty]
        private Label resultLabel;



        //[RelayCommand]
        //public void NumbercClicked(int number)
        //{
        //    var selectedNumber = number switch
        //    {
        //         1 => ButtonOne,
        //         2=> ButtonTwo,
        //         3=> ButtonThree,
        //         4=> ButtonFour,
        //         5=> ButtonFive,
        //         6=> ButtonSix,
        //         7=> ButtonSeven,
        //         8=> ButtonEight,
        //         9=> ButtonNine,
                 
        //    } ;
        //    ClickedNumber = selectedNumber;
        //    if (ClickedNumber == 0) Result = 0;
        //    else Result = Result + selectedNumber;


        //}


        [RelayCommand]
        public void CalculateAndSave()
        {
            double newNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Sustraction:
                        result = SimpleMath.Sustraction(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Divide(lastNumber, newNumber);
                        break;
                }

                resultLabel.Content = result.ToString();
            }

            WeakReferenceMessenger.Default.Send(new SaveMessege(newNumber.ToString()));
        }
    }
}
