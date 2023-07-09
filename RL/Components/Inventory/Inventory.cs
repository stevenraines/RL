using Godot;
using MonoCustomResourceRegistry;
using Godot.Collections;
using System.Collections.Generic;
using System;

[RegisteredTypeAttribute("Item")]
public partial class Inventory : Resource
{

    [Export]
    public Godot.Collections.Array<ItemSlot> Slots { get; set; } = new Godot.Collections.Array<ItemSlot>();

    public Inventory()
    {

    }
}
