using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesSample
{
    class Numbers
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _thirdNumber;

        public Numbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
            _thirdNumber = thirdNumber;
        }

        public Numbers()
        {
            _firstNumber = 5;
            _secondNumber = 10;
            _thirdNumber = 25;
        }

        public int firstNumber
        {
            set
            {
                _firstNumber = value;
            }
            get
            {
                return _firstNumber;
            }
        }
        public int secondNumber
        {
            set
            {
                _secondNumber = value;
            }
            get
            {
                return _secondNumber;
            }
        }
        public int thirdNumber
        {
            set
            {
                _thirdNumber = value;
            }
            get
            {
                return _thirdNumber;
            }
        }
        public int multiply()
        {
            return _firstNumber * _secondNumber;
        }
        public int multiplyTwo()
        {
            return _secondNumber * _secondNumber;
        }
        public int multiplyThree()
        {
            return _thirdNumber * _secondNumber;
        }

    }
}

