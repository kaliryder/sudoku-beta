using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudokuGame
{
    public string nums;
    public string isShowingBools;
    public int difficulty; //0-easy 1-medium 2-hard 3-expert
    public float timer; //300sec-easy 600sec-medium 900sec-hard 1200sec-expert

    public SudokuGame(string nums, string isShowingBools, int difficulty, float timer) {
        this.nums = nums;
        this.isShowingBools = isShowingBools;
        this.difficulty = difficulty;
        this.timer = timer;
    }

    public string getNums() {
        return this.nums;
    }

    public string getIsShowingBools() {
        return this.isShowingBools;
    }

    public int getDifficulty() {
        return this.difficulty;
    }

    public float getTimer() {
        return this.timer;
    }

    public bool getShowingBool(int index) {
        int digit = int.Parse(isShowingBools[index].ToString());
        if (digit == 0) {
            return false;
        }
        else {
            return true;
        }
    }

    public int getDigit(int index) {
        int digit = int.Parse(nums[index].ToString());
        return digit;
    }
}
