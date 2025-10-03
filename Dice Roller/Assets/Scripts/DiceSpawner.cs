using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class DiceSpawner : MonoBehaviour
{
    //Dice should spawn between (-2.5, 17, 9.5) and (5.2, 17, -6.6)
    [SerializeField] private GameObject[] diceObject;
    private List<GameObject> currentDice = new List<GameObject>();
    public static DiceSpawner Instance { get; private set; }
    private int numberOfDice = 0;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject); // optional safeguard
        }
    }


    public void SpawnDice(int numberOfDice) {
        if (currentDice.Count != 0) {DestroyDice();}
        this.numberOfDice = numberOfDice;
        for (int i = 0; i < numberOfDice; i++) {
        // pick a prefab
        GameObject diePrefab = diceObject[Random.Range(0, diceObject.Length)];

        // figure out spawn location
        Vector3 spawnLocation = new Vector3(Random.Range(-2.5f, 5.2f), 17, Random.Range(-6.6f, 9.5f));

        // figure out spawn rotation
        Quaternion spawnRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));

        // Instantiate the object and store the instance in the variable dieInstance
        GameObject dieInstance = Instantiate(diePrefab, spawnLocation, spawnRotation);
        currentDice.Add(dieInstance);
    }
    }

    public void DestroyDice() {
        foreach (GameObject die in currentDice) {
            if (die != null)
                Destroy(die);
        }
        currentDice.Clear();
    }

    public int getNumberOfDice() {return this.numberOfDice;}

}
