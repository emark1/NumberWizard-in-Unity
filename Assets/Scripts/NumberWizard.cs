using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int maximumGuess;
    [SerializeField] int minimumGuess;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    void Start() {
        StartGame();
    }

    void NextGuess() {
        guess = Random.Range(minimumGuess, maximumGuess + 1);
        guessText.text = guess.ToString();
    }
    void StartGame() {
        guess = Random.Range(minimumGuess, maximumGuess + 1);
        guessText.text = guess.ToString();
        maximumGuess = maximumGuess+1;
    }
    public void OnPressHigher() {
        maximumGuess = guess;
        NextGuess();
    }

    public void OnPressLower() {
        minimumGuess = guess;
        NextGuess();
    }
}

        // if (Input.GetKeyDown(KeyCode.DownArrow)) {
        //     maximumGuess = guess;
        //     NextGuess();
        // }

                // Debug.Log("Welcome to NUMBER WIZARD!");
        // Debug.Log("-------------");
        // Debug.Log("Pick a number, any number... ");
        // Debug.Log("Highest possible number is " + maximumGuess + ": ");
        // Debug.Log("Lowest number is " + minimumGuess + ": ");
        // Debug.Log("Tell me if your number is higher or lower than " + guess);
        // Debug.Log("Push Up Key for Higher, Push Down Key for Lower. Push enter if the number is correct!");