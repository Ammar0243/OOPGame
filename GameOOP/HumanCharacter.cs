using System;

public class HumanCharacter
{
    // Properties
    public float Speed { get; set; }
    public float Power { get; set; }
    public int Health { get; set; }

    // Constructor
    public HumanCharacter(float speed, float power, int health)
    {
        Speed = speed;
        Power = power;
        Health = health; // Initialize Health property
    }

    // Methods
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        if (Health != 0)
            Power -= (int)(Power * (damage / (float)Health));
        else
            Power = 0;
        if (Power < 0) Power = 0;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }

    public void IncreaseSpeed(float amount)
    {
        Speed += amount;
    }

    public void IncreasePower(float amount)
    {
        Power += amount;
    }
}

