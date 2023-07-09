using Godot;
using System;

public partial class InventoryUI : PanelContainer
{
    private PackedScene Slot = ResourceLoader.Load<PackedScene>("res://UI/slotui.tscn");

    [Export]
    public GridContainer ItemGrid { get; set; }


    public override void _Ready()
    {

        var playerInventory = ResourceLoader.Load<Inventory>("res://Resources/PlayerInventory.tres");
        PopulateItemGrid(playerInventory.Slots);
    }

    public InventoryUI()
    {
        //    ItemGrid = GetNode<GridContainer>("MarginContainer/ItemGrid");
        GD.Print(ItemGrid);
    }

    public void PopulateItemGrid(Godot.Collections.Array<ItemSlot> slots)
    {

        GD.Print(slots);
        GD.Print(ItemGrid);
        foreach (var child in ItemGrid.GetChildren())
        {
            child.QueueFree();
        }

        foreach (var slotData in slots)
        {


            var slotUI = (SlotUI)Slot.Instantiate();

            ItemGrid.AddChild(slotUI);
            if (slotData != null)
                slotUI.SetSlotData(slotData);


        }
    }

}
