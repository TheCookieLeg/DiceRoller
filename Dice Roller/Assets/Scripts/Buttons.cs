using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    private int numberOfDice = 2;
    [SerializeField] private TMP_Text diceText;
    [SerializeField] private Button plusButton, minusButton;

    void Start() {
        diceText.text = numberOfDice + " dice";
    }

    public void RollDice() {
        DiceSpawner.Instance.SpawnDice(numberOfDice);
    }

    public void IncreaseDice() {
        numberOfDice++;
        ButtonInteractable();
        UpdateText();
    }

    public void DecreaseDice() {
        numberOfDice--;
        ButtonInteractable();
        UpdateText();
    }

    public void ButtonInteractable() {
        if (numberOfDice <= 1) {
            minusButton.interactable = false;
        } else {
            minusButton.interactable = true;
        }

        if (numberOfDice >= 8) {
            plusButton.interactable = false;
        } else {
            plusButton.interactable = true;
        }
    }

    public void UpdateText() {
        diceText.text = numberOfDice + " dice";
    }
}
