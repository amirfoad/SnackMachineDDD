﻿using DddInPractice.Logic.Common;

namespace DddInPractice.Logic.SnackMachines;

public class Slot:Entity
{
    public virtual SnackPile  SnackPile { get;  set; }
    public virtual SnackMachine SnackMachine { get; protected set; }
    public virtual int Position { get; protected set; }
    
    protected Slot(){}

    public Slot(SnackMachine snackMachine,
        int position) : this()
    {
        SnackPile = SnackPile.Empty;
        SnackMachine = snackMachine;
        Position = position;
    }
}