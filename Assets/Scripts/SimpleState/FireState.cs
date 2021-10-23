

namespace Asteroids.SimpleState
{
    public sealed class FireState : State
    {
        public override void Handle(CharacterMovementState characterMovement)
        {
            characterMovement.State = new DeadState();
        }
    }
}
