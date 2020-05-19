using Factorial.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Factorial.Core.ViewModel
{
   public class FactorialViewModel:MvxViewModel
    {
        private readonly IFactorialService _factorialService;
        private int _n;
        private double _result;
        private MvxCommand  _calculateCommand;
        public FactorialViewModel(IFactorialService factorialService)
        {
            _factorialService = factorialService;
        }

        public int N
        {
            get => _n;
            set => SetProperty(ref _n, value);
        }

        public double Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            N = 0;
            Calculate();
        } 

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        private void Calculate()
        {
            Result = _factorialService.GetFactorial(N);
        }
    }
}
