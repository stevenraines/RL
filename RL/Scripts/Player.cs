using Godot;
using System;

public partial class Player : CharacterBody2D
{

    [Export]
    public int Speed { get; set; } = 50;

    private AnimatedSprite2D _animatedSprite;

    public override void _Ready()
    {
        _animatedSprite = GetNode<AnimatedSprite2D>("PlayerSprite");
        _animatedSprite.Play("Idle");
    }


    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {

        var velocity = Velocity;
        var animation = "Idle";
        velocity.Y = 0;
        velocity.X = 0;

        if (Input.IsActionPressed("ui_left"))
        {
            velocity.X = -Speed;
            animation = "Walk Side";
            _animatedSprite.FlipH = true;
        }
        else if (Input.IsActionPressed("ui_right"))
        {
            velocity.X = Speed;
            animation = "Walk Side";
            _animatedSprite.FlipH = false;
        }
        if (Input.IsActionPressed("ui_up"))
        {
            velocity.Y = -Speed;
            animation = "Walk Up";
        }
        else if (Input.IsActionPressed("ui_down"))
        {
            velocity.Y = Speed;
            animation = "Walk Down";
        }

        Velocity = velocity;
        if (animation != _animatedSprite.Animation)
        {
            _animatedSprite.Play(animation);
        }


        // "MoveAndSlide" already takes delta time into account.
        MoveAndSlide();
    }

}

