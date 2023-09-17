using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class RandomNumberGenerator : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    public void GenerateRandomNumbers()
    {
        List<int> randomNumbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            int randomNumber = Random.Range(1, 7); 
            randomNumbers.Add(randomNumber);
        }

        string numbersText = "You got: ";

        foreach (int number in randomNumbers)
        {
            numbersText += number.ToString() + ", ";
        }

        displayText.text = numbersText.TrimEnd(',', ' '); 
    }
}
