namespace Sandbox;

public sealed class MyComponent : Component, Component.ICollisionListener
{
	public void OnCollisionStart( Collision collision )
	{
		Log.Info( "Start" );
	}

	public void OnCollisionUpdate( Collision collision )
	{
		// This won't be ran.
		Log.Error( "Update" );
	}

	public void OnCollisionStop( CollisionStop collision )
	{
		Log.Info( "Stop" );
	}
}
