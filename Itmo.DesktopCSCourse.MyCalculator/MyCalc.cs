using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfcacl
{
    internal class MyCalc
    {
        public enum Operator : int
        {
            eUnknown = 0,
            eAdd = 1,
            eSubtract = 2,
            eMultiply = 3,
            eDivide = 4,
            ePower = 5,
            eSqrt = 6,
            eReciprocal =7,
            ePowerSquared = 8
        }







        private static double numericAnswer;
        private static string stringAnswer;
        private static Operator calcOperation;
        private static double firstNumber;
        private static double secondNumber;
        private static bool secondNumberAdded;
        private static bool decimalAdded;


        public MyCalc()
        {
            decimalAdded = false;
            secondNumberAdded = false;
        }




        public static string CalcNumber(string KeyNumber)
        {
            stringAnswer = stringAnswer + KeyNumber;
            return (stringAnswer);
        }

        public static string CalcSign()
        {
            double numHold;

            if (stringAnswer != "")
            {
                numHold = System.Convert.ToDouble(stringAnswer);
                stringAnswer = System.Convert.ToString(numHold * -1);
            }

            return (stringAnswer);
        }

        public static string CalcDecimal()
        {
            if (!decimalAdded && !secondNumberAdded)
            {
                if (stringAnswer != null)
                    stringAnswer = stringAnswer + ".";
                else
                    stringAnswer = "0.";
               
                decimalAdded = true;
            }

            return (stringAnswer);
        }


        public static void CalcOperation(Operator calcOper)
        {
            if (stringAnswer != "" && !secondNumberAdded)
            {
                firstNumber = System.Convert.ToDouble(stringAnswer);
                calcOperation = calcOper;
                stringAnswer = null ;
                decimalAdded = false;
            }
        }

        public static string CalcEqual()
        {
            bool validEquation = false;

            if (stringAnswer != null)
            {
                secondNumber = System.Convert.ToDouble(stringAnswer);
                secondNumberAdded = true;

                switch (calcOperation)
                {
                    case Operator.eUnknown:
                        validEquation = false;
                        break;

                    case Operator.eAdd:
                        numericAnswer = firstNumber + secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eSubtract:
                        numericAnswer = firstNumber - secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eMultiply:
                        numericAnswer = firstNumber * secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eDivide:
                        numericAnswer = firstNumber / secondNumber;
                        validEquation = true;
                        break;

                    case Operator.ePower:
                        numericAnswer = Math.Pow(firstNumber,secondNumber);
                        validEquation = true;
                        break;
                    
                    
                    default:
                        validEquation = false;
                        break;
                }

                if (validEquation)
                {
                    secondNumberAdded = false;
                    stringAnswer = System.Convert.ToString(numericAnswer);
                }
            }

            return (stringAnswer);
        }


        public static void CalcReset()
        {
            numericAnswer = 0;
            firstNumber = 0;
            secondNumber = 0;
            stringAnswer = null;
            calcOperation = Operator.eUnknown;
            decimalAdded = false;
            secondNumberAdded = false;
        }

        public static string CalcSpecial(Operator calcOper)
        {
            bool validEquation = false;

            if (stringAnswer != null)
            {
                firstNumber = System.Convert.ToDouble(stringAnswer);
                calcOperation = calcOper;

                switch (calcOperation)
                {
                    case Operator.eUnknown:
                        validEquation = false;
                        break;

                    case Operator.ePowerSquared:
                        numericAnswer = Math.Pow(firstNumber, 2);
                        validEquation = true;
                        break;

                    case Operator.eSqrt:
                        numericAnswer = Math.Sqrt(firstNumber);
                        validEquation = true;
                        break;

                    case Operator.eReciprocal:
                        numericAnswer = 1/firstNumber ;
                        validEquation = true;
                        break;

                    

                    default:
                        validEquation = false;
                        break;
                }

                if (validEquation)
                {
                    secondNumberAdded = false;
                    stringAnswer = System.Convert.ToString(numericAnswer);
                }
            }

            return (stringAnswer);
        }
       

    
    }
}
