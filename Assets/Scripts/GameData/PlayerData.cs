﻿using UnityEngine;

namespace BBO.BBO.GameData
{
    public static class PlayerData
    {
        public const int DefaultHealth = 100;

        public static readonly int IdleTriggerHash = Animator.StringToHash("Idle");
        public static readonly int WalkFrontTriggerHash = Animator.StringToHash("WalkFront");
        public static readonly int WalkBackTriggerHash = Animator.StringToHash("WalkBack");
        public static readonly int WalkSideTriggerHash = Animator.StringToHash("WalkSide");
    }
}
