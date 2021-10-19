using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanCode
{
    public interface ICharacterStats
    {
        int characterValue { get; set; }
        bool isCurrentPlayer { get; set; }

        void ApplyCharacterStats(int value, bool isCurrentPlayer);
    }
}