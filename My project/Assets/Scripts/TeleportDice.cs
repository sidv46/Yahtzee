using UnityEngine;

public class TeleportDice : MonoBehaviour
{
    public Transform destination;

    public void Teleport()
    {
        GameObject[] diceObjects = GameObject.FindGameObjectsWithTag("Dice");

        foreach (GameObject dice in diceObjects)
        {
            dice.transform.position = destination.position;
        }
    }
}
