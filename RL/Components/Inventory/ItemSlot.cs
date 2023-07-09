using Godot;
using MonoCustomResourceRegistry;
using System;

[RegisteredTypeAttribute("ItemSlot")]
public partial class ItemSlot : Resource
{
    //  public const int MaxStackSize = 99;

    [Export]
    public Item Item { get; set; }

    [Export(PropertyHint.Range, "1,99,1")]
    public int Quantity { get; set; }

    public ItemSlot() { }

}
