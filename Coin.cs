using Godot;
using System;

public partial class Coin : Area2D
{
    public void _on_body_entered(Node2D body)
    {
        GD.Print("Coin collected!");
        body.Scale = new Vector2(body.Scale.X + 0.2f, body.Scale.Y + 0.2f);
        QueueFree();
    }
}
