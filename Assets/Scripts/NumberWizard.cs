using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        NextGuess();
    }

    // Called by HigherButton On Click Unity Event
    public void OnPressHigher()
    {
        if (min >= max) return;
        min = guess + 1;
        NextGuess();
    }

    // Called by LowerButton On Click Unity Event
    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        // guess = (min + max) / 2; // Can use this if you want to use binary search.
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}