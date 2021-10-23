namespace Asteroid.State
{
    public sealed class FireState : State
    {
        public override void Handle(PlayerMovementState playerMovement)
        {
            playerMovement.State = new DeadlyState();
        }
    }
}
