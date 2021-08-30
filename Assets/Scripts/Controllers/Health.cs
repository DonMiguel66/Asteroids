namespace Asteroids
{
    internal sealed class Health :IDamagable
    {
        public float MaxHP { get; }
        public float CurrentHP { get; private set; }
        public Health(float max, float current)
        {
            MaxHP = max;
            CurrentHP = current;
        }

        public void ChangeCurrentHealth(float hp)
        {
            if (CurrentHP < MaxHP && CurrentHP > 0)
            { 
                CurrentHP += hp; 
            }
            if (CurrentHP > MaxHP)
            {
                CurrentHP = MaxHP;
            }
            else if (CurrentHP < 0)
            { 
                CurrentHP = 0; 
            }
        }
    }
      
}