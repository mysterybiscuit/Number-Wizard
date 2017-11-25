using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max, min;
    int guess = 500;

    // Use this for initialization
    void Start () {
        startGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("up"))
        {
            //Debug.Log("Up-arrow was pressed.");
            min = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown("down"))
        {
            //Debug.Log("Down-arrow was pressed.");
            max = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown("return"))
        {
            Debug.Log("I WON!");
            startGame();
        }
        
	}

    void startGame()
    {
        max = 1000;
        min = 1;
        Debug.Log("=========================");
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number in your head, but don't tell me!");

        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);

        Debug.Log("Is the number high or lower than " + guess + "?");
        Debug.Log("Up-arrow for higher. Down-arrow for lower. Enter for equal.");
        max++;
    }

    void nextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Higher or lower than " + guess);
        Debug.Log("Up-arrow for higher. Down-arrow for lower. Enter for equal.");
    }
}
