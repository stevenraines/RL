using Godot;
using System;

public partial class Item : Resource
{
    [Export]
    public string Name { get; set; } = "";

    [Export(PropertyHint.MultilineText)]
    public string Description { get; set; } = "";

    [Export]
    public bool Stackable { get; set; } = false;

    [Export]
    public AtlasTexture Texture { get; set; }

    public Item()
    {

    }


}
