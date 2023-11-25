using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

        velocity.X = 0.0f;
        velocity.Y = 0.0f;

        if (Input.IsKeyPressed(Key.Left))
		{
            velocity.X = -Speed;
        }
        if (Input.IsKeyPressed(Key.Right))
		{
            velocity.X = Speed;
        }
        if (Input.IsKeyPressed(Key.Up))
        {
            velocity.Y = -Speed;
        }
        if (Input.IsKeyPressed(Key.Down))
        {
            velocity.Y = Speed;
        }
        
        Velocity = velocity;
		MoveAndSlide();
	}
}
