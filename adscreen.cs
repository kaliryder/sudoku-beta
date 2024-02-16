using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class adscreen : MonoBehaviour
{
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(()=> {
            if (updatevalues.isMistakesGameOver) {
                updatevalues.mistakesMade = 2;
                updatevalues.initialScore = updatevalues.totalScore;
                updatevalues.timeBonus = 0;
                updatevalues.totalScore = 0;
                updatevalues.isMistakesGameOver = false;
                SceneManager.LoadScene("Trippy Sudoku");
            }
            else if (updatevalues.isTimeUpGameOver) {
                updatevalues.minutesLeft = 1;
                updatevalues.secondsLeft = 0;
                updatevalues.initialScore = updatevalues.totalScore;
                updatevalues.timeBonus = 0;
                updatevalues.totalScore = 0;
                updatevalues.isTimeUpGameOver = false;
                SceneManager.LoadScene("Trippy Sudoku");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
