using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_1
{
    enum CalcState
    {
        Zero,
        AccumulateDigit,
        Compute,
        Result
    }

    public delegate void MyDelegate(string text);

    class Brain
    {
        MyDelegate displayMsg; //Delegate->object that can links to methods
        CalcState calcState = CalcState.Zero;

        string tempNumber;
        string resultNumber;
        string operation;


        public Brain(MyDelegate dlg) //constructor
        {
            this.displayMsg = dlg;
            tempNumber = "";
            resultNumber = "";
            operation = "";
        }

        public void Process(string msg)
        {
            switch (calcState)
            {
                case CalcState.Zero:
                    Zero(false, msg);
                    break;
                case CalcState.AccumulateDigit:
                    AccumulateDigit(false, msg);
                    break;
                case CalcState.Compute:
                    Compute(false, msg);
                    break;
                case CalcState.Result:
                    Result(false, msg);
                    break;               
                default:
                    break;
            }
        }

        void Zero(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.Zero;
            }
            else
            {
                if (Rules.IsNonZeroDigit(msg))
                {
                    AccumulateDigit(true, msg);
                }
            }
        }
        void AccumulateDigit(bool isInput, string msg) //Накапливать цифру
        {
            if (isInput)
            {
                calcState = CalcState.AccumulateDigit;
                tempNumber += msg; //tempnumber->entered msg
                displayMsg(tempNumber); //Delegate is used
            }
            else
            {
                if (Rules.IsDigit(msg)) //digit
                {
                    AccumulateDigit(true, msg); //Накапливать цифру
                }
                else if (Rules.IsMonoOperator(msg))
                {
                    CalculateMonoOperation(msg);
                }
                /*else if (Rules.AdditionalOperator(msg))
                {
                    CalculateAdditionalOperator(msg);
                }*/
                else if (Rules.IsOperator(msg))//+,- etc
                {
                    Compute(true, msg);
                }
                else if (Rules.IsEqualSign(msg))
                {
                    Result(true, msg);
                }
            }
        }
        void Compute(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.Compute;

                if (operation.Length > 0)
                {
                    Calculate(); // method that do calculation
                    displayMsg(resultNumber);
                }
                else
                {
                    resultNumber = tempNumber; //Просто выводит цифру
                }

                tempNumber = "";
                operation = msg;
            }
            else
            {
                if (Rules.IsDigit(msg))
                {
                    AccumulateDigit(true, msg);
                }
            }
        }


        

        void Result(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.Result;
                Calculate();
               // CalculateMonoOperation(msg);
                displayMsg(resultNumber);
            }
            else
            {
                if (Rules.IsNonZeroDigit(msg))
                {
                    AccumulateDigit(true, msg);
                }
                else if (Rules.IsZero(msg))
                {
                    Zero(true, msg);
                }
                else if (Rules.IsOperator(msg))
                {
                    operation = "";
                    tempNumber = resultNumber;
                    Compute(true, msg);
                }
                else if (Rules.IsMonoOperator(msg))
                {

                    tempNumber = resultNumber;
                    CalculateMonoOperation(msg);
                }
            }
        }

        void Calculate()
        {
            if (operation == "+")
            {
                resultNumber = (double.Parse(resultNumber) + double.Parse(tempNumber)).ToString(); //first number+second entered number
            }
            else if (operation == "-")
            {
                resultNumber = (double.Parse(resultNumber) - double.Parse(tempNumber)).ToString();
            }
            else if (operation == "*")
            {
                resultNumber = (double.Parse(resultNumber) * double.Parse(tempNumber)).ToString();
            }
            else if (operation == "/")
            {
                resultNumber = (double.Parse(resultNumber) / double.Parse(tempNumber)).ToString();
            }
            /*
            else if (operation == "√")
            {
                resultNumber = Math.Sqrt(int.Parse(tempNumber)).ToString(); //again to string       
            }
            /*else if (operation == "x²")
            {
                resultNumber = Math.Pow(int.Parse(tempNumber)).ToString, 2;
            }*/
        }

        void CalculateMonoOperation(string msg)
        {

            if (msg == "√")
            {
                tempNumber = Math.Sqrt(double.Parse(tempNumber)).ToString();                               
                //tempNumber = Math.Sqrt(double.Parse(tempNumber)).ToString();
            }
            else if (msg == "x²")
            {
                tempNumber= Math.Pow(double.Parse(tempNumber), 2).ToString();
            }
            else if (msg == "1/x")
            {
                tempNumber = (1/double.Parse(tempNumber)).ToString();
            } //ask
            else if (msg == "+-")
            {
                tempNumber = ((-1)* double.Parse(tempNumber)).ToString();
            }


            displayMsg(tempNumber); //can also display tempNumber

        }

       /* void CalculateAdditionalOperator (string msg)
        {

            if (msg == "CE")
            {
                tempNumber = "0";
                resultNumber = "0";
                operation = "";

                calcState = CalcState.Zero;

            }
            displayMsg(resultNumber);
        }
        */

    }
}

