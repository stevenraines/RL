using Godot;
using System;

public partial class SlotUI : PanelContainer
{

    [Export]
    public TextureRect ItemTexture { get; set; }

    [Export]
    public Label ItemQuantityLabel { get; set; }

    public SlotUI()
    {
    }

    public void SetSlotData(ItemSlot slot)
    {
        ItemQuantityLabel.Visible = false;
        ItemTexture.Texture = slot.Item.Texture;
        TooltipText = $"{slot.Item.Name}\n{slot.Item.Description}";

        if (slot.Quantity > 1)
        {
            ItemQuantityLabel.Visible = true;
            ItemQuantityLabel.Text = $"x{slot.Quantity}";
        }


    }

}
