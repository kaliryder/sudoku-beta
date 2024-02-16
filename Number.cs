using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Number
{
    public int digit;
    public int counter;
    public string output;
    public Button button;
    public GameObject panel;
    public GameObject secondaryPanel;
    public bool isEnabled;
    public bool isComplete;
    public bool isSelected;

    public Number(int digit, string output, Button button, GameObject panel, GameObject secPanel) {
        this.digit = digit;
        this.output = output;
        this.button = button;
        this.panel = panel;
        this.secondaryPanel = secPanel;
        this.isEnabled = true;
        this.isComplete = false;
        this.isSelected = false;
        this.counter = 0;
    }

    public int getDigit() {
        return digit;
    }

    public string getOutput() {
        return output;
    }

    public Button getButton() {
        return button;
    }

    public GameObject getPanel() {
        return panel;
    }

    public GameObject getSecondaryPanel() {
        return secondaryPanel;
    }

    public void setEnabled(bool enabled) {
        isEnabled = enabled;
    }

    public bool getEnabled() {
        return isEnabled;
    }

    public void setComplete(bool complete) {
        isComplete = complete;
    }

    public bool getComplete() {
        return isComplete;
    }

    public void setSelected(bool selected) {
        isSelected = selected;
    }

    public bool getSelected() {
        return isSelected;
    }

    public void increaseCounter() {
        this.counter++;
    }

    public int getCounter() {
        return counter;
    }
}
