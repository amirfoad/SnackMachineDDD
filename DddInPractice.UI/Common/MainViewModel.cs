﻿using DddInPractice.Logic;
using DddInPractice.Logic.SnackMachines;
using DddInPractice.UI.SnackMachines;
using NHibernate;

namespace DddInPractice.UI.Common
{
    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {

            SnackMachine snackMachine = new SnackMachineRepository().GetById(1);;
            var viewModel = new SnackMachineViewModel(snackMachine);
            _dialogService.ShowDialog(viewModel);
        }
    }
}
