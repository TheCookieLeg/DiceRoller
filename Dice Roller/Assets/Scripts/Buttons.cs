using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    private int numberOfDice = 1;
    [SerializeField] private TMP_Text diceText;
    [SerializeField] private Button plusButton, minusButton;
    
    public void RollDice() {
        DiceSpawner.Instance.SpawnDice(numberOfDice);
    }

    public void IncreaseDice() {
        numberOfDice++;

    }

    public void DecreaseDice() {
        numberOfDice--;
    }
}
