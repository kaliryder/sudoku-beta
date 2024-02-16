using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cell
{
    bool isShowing;
    bool isFull;
    bool isCorrect;
    int correctNum;
    int input;
    int index;

    GameObject panel;
    GameObject secondaryPanel;
    GameObject tertiaryPanel;
    Button button;
    TMP_Text text;
    GameObject[] row;
    GameObject[] column;
    GameObject[] box;
    Note note;

    public Cell(int correct, bool showing, GameObject panel, GameObject secPanel, GameObject terPanel, Button button, TMP_Text text, int index, GameObject[] row, GameObject[] column, GameObject[] box, Note note) {
        this.correctNum = correct;
        this.isShowing = showing;
        this.panel = panel;
        this.secondaryPanel = secPanel;
        this.tertiaryPanel = terPanel;
        this.button = button;
        this.text = text;
        this.index = index;
        this.row = row;
        this.column = column;
        this.box = box;
        this.note = note;

        if (showing == true) {
            this.isCorrect = true;
        }
        else {
            this.isCorrect = false;
        }
    }

    public bool inputNum(int num) {
        this.input = num;
        if (input == correctNum) {
            return true;
        }
        else {
            return false;
        }
    }

    public int getNum() {
        return correctNum;
    }

    public void setShowing(bool show) {
        this.isShowing = show;
    }

    public bool getShowing() {
        return isShowing;
    }

    public void setCorrect(bool correct) {
        this.isCorrect = correct;
    }

    public bool getCorrect() {
        return isCorrect;
    }

    public GameObject getPanel() {
        return panel;
    }

    public GameObject getSecondaryPanel() {
        return secondaryPanel;
    }
    public GameObject getTertiaryPanel() {
        return tertiaryPanel;
    }

    public Button getButton() {
        return button;
    }

    public TMP_Text getText() {
        return text;
    }

    public int getIndex() {
        return index;
    }

    public GameObject[] getRow() {
        return row;
    }

    public GameObject[] getColumn() {
        return column;
    }

    public GameObject[] getBox() {
        return box;
    }

    public Note getNote() {
        return note;
    }
}
