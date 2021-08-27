using System;

namespace Asteroids
{
    public interface IMove
    {       
        float Speed { get; }
        void Moving(float horizontal, float vertical, float deltaTime);
    }
}
