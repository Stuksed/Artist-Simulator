using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Work 
{
    protected Work(string name, int energyCostPerHour, int satietyCostPerHour, int happinessCoef)
    {
        EnergyCostPerHour = energyCostPerHour;
        SatietyCostPerHour = satietyCostPerHour;
        HappinessCoef = happinessCoef;
        Name = name;
    }

    public int EnergyCostPerHour { get => energyCostPerHour; 
        private set => energyCostPerHour = value; }
    public int SatietyCostPerHour { get => satietyCostPerHour; 
        private set => satietyCostPerHour = value; }
    public int HappinessCoef { get => happinessCoef; 
        private set => happinessCoef = value; }
    public string Name { get => name; private set => name = value; }

    public abstract void DoWork(int hoursOfWork);
    protected abstract int GetXPInc(int hoursOfWork);

    [SerializeField]
    private int happinessCoef, energyCostPerHour, satietyCostPerHour;
    [SerializeField]
    private string name;
}
