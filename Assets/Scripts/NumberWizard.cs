using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    // Use this for initialization
    int max, min, guess;

    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        print("-------------------------");
        print("Welcome to Number Wizzzzard!");
        print("Pick a number in your head hbut don't tell me!");
        print("The highest number you can pick is " + max.ToString());
        print("The lowest number you can pick is " + min.ToString());
        max++;
        print("Is the number higher or lower than " + guess.ToString() + "?");
        print("Up = higher, down = lower, return = equal");
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Is it higher or lower than " + guess.ToString() + "?");
        print("Up = higher, down = lower, return = equal");
    }
}
