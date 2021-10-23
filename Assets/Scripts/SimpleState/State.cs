

namespace Asteroids.SimpleState
{
    public abstract class State
    {
        public abstract void Handle(CharacterMovementState characterMovementType);
    }
}
