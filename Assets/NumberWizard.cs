using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int maximumGuess;
    int minimumGuess;
    int guess;
    void Start() {
        StartGame();
    }

    void NextGuess() {
        guess = (maximumGuess + minimumGuess) /2;
        Debug.Log("Is it higher, or lower than " + guess);

    }
    void StartGame() {
        maximumGuess = 1000;
        minimumGuess = 1;
        guess = 500;

        Debug.Log("Welcome to NUMBER WIZARD!");
        Debug.Log("-------------");
        Debug.Log("Pick a number, any number... ");
        Debug.Log("Highest possible number is " + maximumGuess + ": ");
        Debug.Log("Lowest number is " + minimumGuess + ": ");
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up Key for Higher, Push Down Key for Lower. Push enter if the number is correct!");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            minimumGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            maximumGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("I got it!");
            StartGame();
        }
    }
}
