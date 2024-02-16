using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Note
{
    TMP_Text noteText;
    string noteString;
    string str1;
    string str2;
    string str3;
    string str4;
    string str5;
    string str6;
    string str7;
    string str8;
    string str9;
    
    public Note(TMP_Text noteText) {
        str1 = "  ";
        str2 = "  ";
        str3 = "  ";
        str4 = "  ";
        str5 = "  ";
        str6 = "  ";
        str7 = "  ";
        str8 = "  ";
        str9 = "  ";
        noteString = str1 + str2 + str3 + str4 + str5 + str6 + str7 + str8 + str9;
        this.noteText = noteText;
        this.noteText.text = noteString;
    }

    public void fillNote(int strNum) {
        if (strNum == 1) {
            str1 = "1";
        }
        else if (strNum == 2) {
            str2 = "2";
        }
        else if (strNum == 3) {
            str3 = "3";
        }
        else if (strNum == 4) {
            str4 = "4";
        }
        else if (strNum == 5) {
            str5 = "5";
        }
        else if (strNum == 6) {
            str6 = "6";
        }
        else if (strNum == 7) {
            str7 = "7";
        }
        else if (strNum == 8) {
            str8 = "8";
        }
        else if (strNum == 9) {
            str9 = "9";
        }
        noteString = str1 + str2 + str3 + str4 + str5 + str6 + str7 + str8 + str9;
        noteText.text = noteString;
    }

    public void deleteNote(int strNum) {
        if (strNum == 1) {
            str1 = "  ";
        }
        else if (strNum == 2) {
            str2 = "  ";
        }
        else if (strNum == 3) {
            str3 = "  ";
        }
        else if (strNum == 4) {
            str4 = "  ";
        }
        else if (strNum == 5) {
            str5 = "  ";
        }
        else if (strNum == 6) {
            str6 = "  ";
        }
        else if (strNum == 7) {
            str7 = "  ";
        }
        else if (strNum == 8) {
            str8 = "  ";
        }
        else if (strNum == 9) {
            str9 = "  ";
        }
        noteString = str1 + str2 + str3 + str4 + str5 + str6 + str7 + str8 + str9;
        noteText.text = noteString;
    }

    public void hideNote() {
        noteText.text = "";
    }

    public void showNote() {
        noteText.text = noteString;
    }

    public void setText() {
        this.noteText.text = this.noteString;
    }

    public bool isNumNoted(int num) {
        if (num == 1 && isOneNoted()) {
            return true;
        }
        else if (num == 2 && isTwoNoted()) {
            return true;
        }
        else if (num == 3 && isThreeNoted()) {
            return true;
        }
        else if (num == 4 && isFourNoted()) {
            return true;
        }
        else if (num == 5 && isFiveNoted()) {
            return true;
        }
        else if (num == 6 && isSixNoted()) {
            return true;
        }
        else if (num == 7 && isSevenNoted()) {
            return true;
        }
        else if (num == 8 && isEightNoted()) {
            return true;
        }
        else if (num == 9 && isNineNoted()) {
            return true;
        }
        else {
            return false;
        }
    }

    public bool isOneNoted() {
        if (str1 == "1") {
            return true;
        }
        return false;
    }
    public bool isTwoNoted() {
        if (str2 == "2") {
            return true;
        }
        return false;
    }
    public bool isThreeNoted() {
        if (str3 == "3") {
            return true;
        }
        return false;
    }
    public bool isFourNoted() {
        if (str4 == "4") {
            return true;
        }
        return false;
    }
    public bool isFiveNoted() {
        if (str5 == "5") {
            return true;
        }
        return false;
    }
    public bool isSixNoted() {
        if (str6 == "6") {
            return true;
        }
        return false;
    }
    public bool isSevenNoted() {
        if (str7 == "7") {
            return true;
        }
        return false;
    }
    public bool isEightNoted() {
        if (str8 == "8") {
            return true;
        }
        return false;
    }
    public bool isNineNoted() {
        if (str9 == "9") {
            return true;
        }
        return false;
    }
}
