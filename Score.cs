using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score
{
    int scoreNum;
    int addCompleteCellAmount = 10;
    int subtractMistakeAmount = 20;
    int addSecondsAmount = 1;

    public Score() {
        this.scoreNum = 0;
    }

    public int getScore() {
        return scoreNum;
    }

    public void addCompleteCell() {
        this.scoreNum += addCompleteCellAmount;
    }

    public void subtractMistake() {
        this.scoreNum -= subtractMistakeAmount;
    }

    public int addSeconds(int seconds) {
        return(seconds * addSecondsAmount) + scoreNum;
    }
}
