using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class scorescreen : MonoBehaviour
{
    public TMP_Text initialScoreText;
    public TMP_Text timeBonusText;
    public TMP_Text totalScoreText;

    public Button doneButton;

    int initialScore;
    int timeBonus;
    int totalScore;
    int minutesLeft;
    int secondsLeft;

    int initialScoreCounter = 0;
    int timeBonusCounter = 0;
    int totalScoreCounter = 0;

    bool initialScoreStarted = false;
    bool timeBonusStarted = false;
    bool totalScoreStarted = false;

    int counterIncrement = 3;

    string tracker = "initialscore";

    // Start is called before the first frame update
    void Start()
    {
        this.initialScore = updatevalues.initialScore;
        this.timeBonus = updatevalues.timeBonus;
        this.totalScore = updatevalues.totalScore;
        this.minutesLeft = updatevalues.minutesLeft;
        this.secondsLeft = updatevalues.secondsLeft;
       
        initialScoreText.text = initialScoreCounter.ToString();
        timeBonusText.text = timeBonusCounter.ToString();
        totalScoreText.text = totalScoreCounter.ToString();

        doneButton.onClick.AddListener(()=> {
            SceneManager.LoadScene("Trippy Home");
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (tracker == "initialscore") {
            increaseInitialScore();
        }
        else if (tracker == "timebonus") {
            increaseTimeBonus();
        }
        else if (tracker == "totalscore") {
            increaseTotalScore();
        }
    }

    void increaseInitialScore() {
        if (initialScoreCounter < initialScore) {
            initialScoreCounter += counterIncrement;
            initialScoreText.text = initialScoreCounter.ToString();
        }
        else if (initialScoreCounter >= initialScore) {
            initialScoreText.text = initialScore.ToString();
            tracker = "timebonus";
        }
    }

    void increaseTimeBonus() {
        if (timeBonusCounter < timeBonus) {
            timeBonusCounter += counterIncrement;
            timeBonusText.text = timeBonusCounter.ToString();
        }
        else if (timeBonusCounter >= timeBonus) {
            timeBonusText.text = timeBonus.ToString();
            tracker = "totalscore";
        }
    }

    void increaseTotalScore() {
        if (totalScoreCounter < totalScore) {
            totalScoreCounter += counterIncrement;
            totalScoreText.text = totalScoreCounter.ToString();
        }
        else if (totalScoreCounter >= totalScore) {
            totalScoreText.text = totalScore.ToString();
            tracker = "done";
        }
    }
}
