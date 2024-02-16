using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sudokugames
{
    public SudokuGame[] easyGames;
    public SudokuGame[] mediumGames;
    public SudokuGame[] hardGames;
    public SudokuGame[] expertGames;

    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int expertDifficulty = 3;

    public float easyTimer = 300.0f; //in seconds
    public float mediumTimer = 600.0f;
    public float hardTimer = 900.0f;
    public float expertTimer = 1200.0f;

    public SudokuGame easy1;
    public string easy1nums = "649831257531672984827549613218396745496157832753284196962415378185763429374928561";
    public string easy1bools = "000101001100011111100100111100000001111010100000001101111110100110011010010010100";

    public SudokuGame easy2;
    public string easy2nums = "742891536983645271651273498238967145574138962169452783316729854895314627427586319";
    public string easy2bools = "110100011010110100000000000001100001111001111101101100011001110100110010100001101";

    public SudokuGame medium1;
    public string medium1nums = "815927436462315978739864215983451627156732894274698351341589762627143589598276143";
    public string medium1bools = "000001101100100001000000111010001000111010001110001010100010000101000111000011001";

    public SudokuGame medium2;
    public string medium2nums = "684935712371642985259781346192567834865413297743829561536178429427396158918254673";
    public string medium2bools = "100100010010011000001000011000100011000011000000000100000011110001010100001001000";

    public SudokuGame hard1;
    public string hard1nums = "468315792537429168129786435713862549846597321952134876271948653395671284684253917";
    public string hard1bools = "001100011000100000000000000110101000000001010000101000101100010010001110001111000";

    public SudokuGame hard2;
    public string hard2nums = "657298143231475698489136572364712985728659314195843726916384257873521469542967831";
    public string hard2bools = "010000100000000100000000000000110101100111110010000010100001100010010000000100000";

    public SudokuGame expert1;
    public string expert1nums = "125934687983276451647815923459627138236581794871493265764352819518769342392148576";
    public string expert1bools = "100001000110001000110101011000000000001100000000000100001111000000001100000000011";

    public SudokuGame expert2;
    public string expert2nums = "549172386763984125281563794435728961698351247127496853376849512914235678852617439";
    public string expert2bools = "011010110100000011000100001000010000001001100010000000010000000010001000001000010";

    public sudokugames() {
        setUp();
    }

    public void setUp() {
        easy1 = new SudokuGame(easy1nums, easy1bools, easyDifficulty, easyTimer);
        easy2 = new SudokuGame(easy2nums, easy2bools, easyDifficulty, easyTimer);
        medium1 = new SudokuGame(medium1nums, medium1bools, mediumDifficulty, mediumTimer);
        medium2 = new SudokuGame(medium2nums, medium2bools, mediumDifficulty, mediumTimer);
        hard1 = new SudokuGame(hard1nums, hard1bools, hardDifficulty, hardTimer);
        hard2 = new SudokuGame(hard2nums, hard2bools, hardDifficulty, hardTimer);
        expert1 = new SudokuGame(expert1nums, expert1bools, expertDifficulty, expertTimer);
        expert2 = new SudokuGame(expert2nums, expert2bools, expertDifficulty, expertTimer);

        easyGames = new SudokuGame[2];
        hardGames = new SudokuGame[2];
        mediumGames = new SudokuGame[2];
        expertGames = new SudokuGame[2];

        easyGames[0] = easy1;
        easyGames[1] = easy2;

        mediumGames[0] = medium1;
        mediumGames[1] = medium2;

        hardGames[0] = hard1;
        hardGames[1] = hard2;

        expertGames[0] = expert1;
        expertGames[1] = expert2;
    }

    public SudokuGame[] getSudokuGameArray(int difficulty) {
        if (difficulty == 0) {
            return this.easyGames;
        }
        else if (difficulty == 1) {
            return this.mediumGames;
        }
        else if (difficulty == 2) {
            return this.hardGames;
        }
        else {
            return this.expertGames;
        }
    }
}
