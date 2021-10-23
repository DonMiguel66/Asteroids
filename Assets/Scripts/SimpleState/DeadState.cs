namespace Asteroid.State
{
    public sealed class DeadlyState : State
    {
        public override void Handle(PlayerMovementState playerMovementType)
        {
            playerMovementType.State = new MoveState();
        }
    }
}
