﻿using BBO.BBO.GameData;

namespace BBO.BBO.PlayerManagement
{
    public class PlayerStats
    {
        public int Health => health;

        private readonly int playerID = default;
        private int health = default;

        public PlayerStats(int playerID)
        {
            this.playerID = playerID;
            Reset();
        }

        public void Reset()
        {
            health = PlayerData.DefaultHealth;
        }

        public void SetPlayerHealth(int value)
        {
            health = value;
        }

        public void DecreasePlayerHealth(int value)
        {
            health -= value;
        }

        public void IncreasePlayerHealth(int value)
        {
            health += value;
        }
    }
}
