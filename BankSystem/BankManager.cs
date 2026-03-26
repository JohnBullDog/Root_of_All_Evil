using Godot;
using System;

// declares the data structures for bank system
public partial class BankManager : Node
{
    public int timeRemaining = 100;

    private float capital = 99.0f;
    private float shiftThreshold = 50f;
    private float reputation = 1f;
	public bool bankrupt = false;

    private void UpdateState()
    {
        // USED FOR UI AND OTHER UPDATES
    }

    public override void _Ready()
    {
    }

    public override void _Process(double delta)
    {
    }

    public float Capital
    {
        get => capital;
        set
        {
			if (value < 0) bankrupt = true;
            capital = Mathf.Max(value, 0); // prevent negative values
            UpdateState();
        }
    }

    
    public float Reputation
    {
        get => reputation;
        set
        {
            reputation = Mathf.Clamp(value, 0, 100); // example limits
            UpdateState();
        }
    }

    
    public float ShiftThreshold
    {
        get => shiftThreshold;
        set
        {
            shiftThreshold = value;
            UpdateState();
        }
    }
}