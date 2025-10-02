using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void RollDice() {
        DiceSpawner.Instance.SpawnDice(2);
    }
}
