

namespace Asteroid.State
{
    public abstract class State
    {
        public abstract void Handle(PlayerMovementState playerMovementType);
    }
}
