using Godot;
using MonoCustomResourceRegistry;
using System;

public partial class HealthComponent : Resource
{

    [Export]
    public int CurrentHealth { get; set; }

    [Export]
    public int MaxHealth { get; set; }

    public HealthComponent()
    {
        MaxHealth = 10;
        CurrentHealth = MaxHealth;
    }
}
