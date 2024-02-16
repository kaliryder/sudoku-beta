using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class sudoku : MonoBehaviour
{
    /* SudokuGame variable */
    sudokugames sudokugames;
    SudokuGame sudokuGame;
    int selectedDifficulty;
    int arrayLength = 2;

    /* timer variables */
    float currentTime;
    float minutes;
    float seconds;
    int minutesLeft;
    int secondsLeft;
    public TMP_Text timeText;
    bool endTimer = false;
    bool clearDone = false;

    /* Score variable */
    Score score;
    public TMP_Text scoreText;
    bool secondsAdded = false;
    int initialScore;
    int timeBonus;
    int totalScore;
   
    /* mistakes variables */
    public TMP_Text mistakesText;
    //int mistakesCounter = 0;
    bool mistakeMade = false;
    bool isGameOver = false;
    string firstMistakeText = "x • •";
    string secondMistakeText = "x x •";
    string thirdMistakeText = "x x x";

    /* delete button variables */
    public Button deleteButton;
    public GameObject deletePanel;

    /* long select variables */
    public Button longSelectButton;
    public GameObject longSelectPanel;
    bool isLongSelected = false;
    int longSelectedDigit;
    Number longSelectedNumber;
    Cell longSelectedCell;
    Number highlightNumber;
    Cell hightlightCell;

    /* single select variables */
    public Button singleSelectButton;
    public GameObject singleSelectPanel;
    bool isSingleSelected = true;

    /* notes variables */
    public Button noteButton;
    public GameObject notePanel;
    bool isNoteMode = false;
    bool isNoteDeleteMode = false;
    bool isFillMode = true;
    public Button fillButton;
    public GameObject fillPanel;
    bool needsDeleting = false;
    bool hasBeenDeleted = false;
    bool needsFilling = false;
    bool hasBeenFilled = false;

    /* selected variables */
    Cell selectedCell;
    Number selectedNumber;

    /* cell complete variables */
    bool completeGoing = false;
    bool completeDone = false;
    int completeCounter = 0;

    /* Number variables */
    Number[] numbers;
    Number number1;
    Number number2;
    Number number3;
    Number number4;
    Number number5;
    Number number6;
    Number number7;
    Number number8;
    Number number9;
    Number delete;
    /* Number button variables */
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    /* Number panel variables */
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject panel7;
    public GameObject panel8;
    public GameObject panel9;
    /* Number secondary panel variables */
    public GameObject secPanel1;
    public GameObject secPanel2;
    public GameObject secPanel3;
    public GameObject secPanel4;
    public GameObject secPanel5;
    public GameObject secPanel6;
    public GameObject secPanel7;
    public GameObject secPanel8;
    public GameObject secPanel9;

    /* Cell array variable */
    Cell[] cells;
    /* column a Cell variables */
    public Cell a1;
    public Cell a2;
    public Cell a3;
    public Cell a4;
    public Cell a5;
    public Cell a6;
    public Cell a7;
    public Cell a8;
    public Cell a9;
    /* column b Cell variables */
    public Cell b1;
    public Cell b2;
    public Cell b3;
    public Cell b4;
    public Cell b5;
    public Cell b6;
    public Cell b7;
    public Cell b8;
    public Cell b9;
    /* column c Cell variables */
    public Cell c1;
    public Cell c2;
    public Cell c3;
    public Cell c4;
    public Cell c5;
    public Cell c6;
    public Cell c7;
    public Cell c8;
    public Cell c9;
    /* column d Cell variables */
    public Cell d1;
    public Cell d2;
    public Cell d3;
    public Cell d4;
    public Cell d5;
    public Cell d6;
    public Cell d7;
    public Cell d8;
    public Cell d9;
    /* column e Cell variables */
    public Cell e1;
    public Cell e2;
    public Cell e3;
    public Cell e4;
    public Cell e5;
    public Cell e6;
    public Cell e7;
    public Cell e8;
    public Cell e9;
    /* column f Cell variables */
    public Cell f1;
    public Cell f2;
    public Cell f3;
    public Cell f4;
    public Cell f5;
    public Cell f6;
    public Cell f7;
    public Cell f8;
    public Cell f9;
    /* column g Cell variables */
    public Cell g1;
    public Cell g2;
    public Cell g3;
    public Cell g4;
    public Cell g5;
    public Cell g6;
    public Cell g7;
    public Cell g8;
    public Cell g9;
    /* column h Cell variables */
    public Cell h1;
    public Cell h2;
    public Cell h3;
    public Cell h4;
    public Cell h5;
    public Cell h6;
    public Cell h7;
    public Cell h8;
    public Cell h9;
    /* column i Cell variables */
    public Cell i1;
    public Cell i2;
    public Cell i3;
    public Cell i4;
    public Cell i5;
    public Cell i6;
    public Cell i7;
    public Cell i8;
    public Cell i9;

    /* secondary row panel array variables */
    GameObject[] row1Panels;
    GameObject[] row2Panels;
    GameObject[] row3Panels;
    GameObject[] row4Panels;
    GameObject[] row5Panels;
    GameObject[] row6Panels;
    GameObject[] row7Panels;
    GameObject[] row8Panels;
    GameObject[] row9Panels;
    /* secondary column panel array variables */
    GameObject[] colAPanels;
    GameObject[] colBPanels;
    GameObject[] colCPanels;
    GameObject[] colDPanels;
    GameObject[] colEPanels;
    GameObject[] colFPanels;
    GameObject[] colGPanels;
    GameObject[] colHPanels;
    GameObject[] colIPanels;
    /* secondary box panel array variables */
    GameObject[] box1Panels;
    GameObject[] box2Panels;
    GameObject[] box3Panels;
    GameObject[] box4Panels;
    GameObject[] box5Panels;
    GameObject[] box6Panels;
    GameObject[] box7Panels;
    GameObject[] box8Panels;
    GameObject[] box9Panels;

    /* primary panels indicate selected Cell */
    /* row 1 panel variables */
    public GameObject a1panel;
    public GameObject b1panel;
    public GameObject c1panel;
    public GameObject d1panel;
    public GameObject e1panel;
    public GameObject f1panel;
    public GameObject g1panel;
    public GameObject h1panel;
    public GameObject i1panel;
    /* row 2 panel variables */
    public GameObject a2panel;
    public GameObject b2panel;
    public GameObject c2panel;
    public GameObject d2panel;
    public GameObject e2panel;
    public GameObject f2panel;
    public GameObject g2panel;
    public GameObject h2panel;
    public GameObject i2panel;
    /* row 3 panel variables */
    public GameObject a3panel;
    public GameObject b3panel;
    public GameObject c3panel;
    public GameObject d3panel;
    public GameObject e3panel;
    public GameObject f3panel;
    public GameObject g3panel;
    public GameObject h3panel;
    public GameObject i3panel;
    /* row 4 panel variables */
    public GameObject a4panel;
    public GameObject b4panel;
    public GameObject c4panel;
    public GameObject d4panel;
    public GameObject e4panel;
    public GameObject f4panel;
    public GameObject g4panel;
    public GameObject h4panel;
    public GameObject i4panel;
    /* row 5 panel variables */
    public GameObject a5panel;
    public GameObject b5panel;
    public GameObject c5panel;
    public GameObject d5panel;
    public GameObject e5panel;
    public GameObject f5panel;
    public GameObject g5panel;
    public GameObject h5panel;
    public GameObject i5panel;
    /* row 6 panel variables */
    public GameObject a6panel;
    public GameObject b6panel;
    public GameObject c6panel;
    public GameObject d6panel;
    public GameObject e6panel;
    public GameObject f6panel;
    public GameObject g6panel;
    public GameObject h6panel;
    public GameObject i6panel;
    /* row 7 panel variables */
    public GameObject a7panel;
    public GameObject b7panel;
    public GameObject c7panel;
    public GameObject d7panel;
    public GameObject e7panel;
    public GameObject f7panel;
    public GameObject g7panel;
    public GameObject h7panel;
    public GameObject i7panel;
    /* row 8 panel variables */
    public GameObject a8panel;
    public GameObject b8panel;
    public GameObject c8panel;
    public GameObject d8panel;
    public GameObject e8panel;
    public GameObject f8panel;
    public GameObject g8panel;
    public GameObject h8panel;
    public GameObject i8panel;
    /* row 9 panel variables */
    public GameObject a9panel;
    public GameObject b9panel;
    public GameObject c9panel;
    public GameObject d9panel;
    public GameObject e9panel;
    public GameObject f9panel;
    public GameObject g9panel;
    public GameObject h9panel;
    public GameObject i9panel;

    /* secondary panels indicate row, column and box of selected Cell */
    /* row 1 secondary panel variables */
    public GameObject a1panel2;
    public GameObject b1panel2;
    public GameObject c1panel2;
    public GameObject d1panel2;
    public GameObject e1panel2;
    public GameObject f1panel2;
    public GameObject g1panel2;
    public GameObject h1panel2;
    public GameObject i1panel2;
    /* row 2 secondary panel variables */
    public GameObject a2panel2;
    public GameObject b2panel2;
    public GameObject c2panel2;
    public GameObject d2panel2;
    public GameObject e2panel2;
    public GameObject f2panel2;
    public GameObject g2panel2;
    public GameObject h2panel2;
    public GameObject i2panel2;
    /* row 3 secondary panel variables */
    public GameObject a3panel2;
    public GameObject b3panel2;
    public GameObject c3panel2;
    public GameObject d3panel2;
    public GameObject e3panel2;
    public GameObject f3panel2;
    public GameObject g3panel2;
    public GameObject h3panel2;
    public GameObject i3panel2;
    /* row 4 secondary panel variables */
    public GameObject a4panel2;
    public GameObject b4panel2;
    public GameObject c4panel2;
    public GameObject d4panel2;
    public GameObject e4panel2;
    public GameObject f4panel2;
    public GameObject g4panel2;
    public GameObject h4panel2;
    public GameObject i4panel2;
    /* row 5 secondary panel variables */
    public GameObject a5panel2;
    public GameObject b5panel2;
    public GameObject c5panel2;
    public GameObject d5panel2;
    public GameObject e5panel2;
    public GameObject f5panel2;
    public GameObject g5panel2;
    public GameObject h5panel2;
    public GameObject i5panel2;
    /* row 6 secondary panel variables */
    public GameObject a6panel2;
    public GameObject b6panel2;
    public GameObject c6panel2;
    public GameObject d6panel2;
    public GameObject e6panel2;
    public GameObject f6panel2;
    public GameObject g6panel2;
    public GameObject h6panel2;
    public GameObject i6panel2;
    /* row 7 secondary panel variables */
    public GameObject a7panel2;
    public GameObject b7panel2;
    public GameObject c7panel2;
    public GameObject d7panel2;
    public GameObject e7panel2;
    public GameObject f7panel2;
    public GameObject g7panel2;
    public GameObject h7panel2;
    public GameObject i7panel2;
    /* row 8 secondary panel variables */
    public GameObject a8panel2;
    public GameObject b8panel2;
    public GameObject c8panel2;
    public GameObject d8panel2;
    public GameObject e8panel2;
    public GameObject f8panel2;
    public GameObject g8panel2;
    public GameObject h8panel2;
    public GameObject i8panel2;
    /* row 9 secondary panel variables */
    public GameObject a9panel2;
    public GameObject b9panel2;
    public GameObject c9panel2;
    public GameObject d9panel2;
    public GameObject e9panel2;
    public GameObject f9panel2;
    public GameObject g9panel2;
    public GameObject h9panel2;
    public GameObject i9panel2;

    /* tertiary panels indicate Cells that contain selected digit */
    /* row 1 tertiary panel variables */
    public GameObject a1panel3;
    public GameObject b1panel3;
    public GameObject c1panel3;
    public GameObject d1panel3;
    public GameObject e1panel3;
    public GameObject f1panel3;
    public GameObject g1panel3;
    public GameObject h1panel3;
    public GameObject i1panel3;
    /* row 2 tertiary panel variables */
    public GameObject a2panel3;
    public GameObject b2panel3;
    public GameObject c2panel3;
    public GameObject d2panel3;
    public GameObject e2panel3;
    public GameObject f2panel3;
    public GameObject g2panel3;
    public GameObject h2panel3;
    public GameObject i2panel3;
    /* row 3 tertiary panel variables */
    public GameObject a3panel3;
    public GameObject b3panel3;
    public GameObject c3panel3;
    public GameObject d3panel3;
    public GameObject e3panel3;
    public GameObject f3panel3;
    public GameObject g3panel3;
    public GameObject h3panel3;
    public GameObject i3panel3;
    /* row 4 tertiary panel variables */
    public GameObject a4panel3;
    public GameObject b4panel3;
    public GameObject c4panel3;
    public GameObject d4panel3;
    public GameObject e4panel3;
    public GameObject f4panel3;
    public GameObject g4panel3;
    public GameObject h4panel3;
    public GameObject i4panel3;
    /* row 5 tertiary panel variables */
    public GameObject a5panel3;
    public GameObject b5panel3;
    public GameObject c5panel3;
    public GameObject d5panel3;
    public GameObject e5panel3;
    public GameObject f5panel3;
    public GameObject g5panel3;
    public GameObject h5panel3;
    public GameObject i5panel3;
    /* row 6 tertiary panel variables */
    public GameObject a6panel3;
    public GameObject b6panel3;
    public GameObject c6panel3;
    public GameObject d6panel3;
    public GameObject e6panel3;
    public GameObject f6panel3;
    public GameObject g6panel3;
    public GameObject h6panel3;
    public GameObject i6panel3;
    /* row 7 tertiary panel variables */
    public GameObject a7panel3;
    public GameObject b7panel3;
    public GameObject c7panel3;
    public GameObject d7panel3;
    public GameObject e7panel3;
    public GameObject f7panel3;
    public GameObject g7panel3;
    public GameObject h7panel3;
    public GameObject i7panel3;
    /* row 8 tertiary panel variables */
    public GameObject a8panel3;
    public GameObject b8panel3;
    public GameObject c8panel3;
    public GameObject d8panel3;
    public GameObject e8panel3;
    public GameObject f8panel3;
    public GameObject g8panel3;
    public GameObject h8panel3;
    public GameObject i8panel3;
    /* row 9 tertiary panel variables */
    public GameObject a9panel3;
    public GameObject b9panel3;
    public GameObject c9panel3;
    public GameObject d9panel3;
    public GameObject e9panel3;
    public GameObject f9panel3;
    public GameObject g9panel3;
    public GameObject h9panel3;
    public GameObject i9panel3;

    /* Cell button variables */
    /* row 1 button variables */
    public Button a1button;
    public Button b1button;
    public Button c1button;
    public Button d1button;
    public Button e1button;
    public Button f1button;
    public Button g1button;
    public Button h1button;
    public Button i1button;
    /* row 2 button variables */
    public Button a2button;
    public Button b2button;
    public Button c2button;
    public Button d2button;
    public Button e2button;
    public Button f2button;
    public Button g2button;
    public Button h2button;
    public Button i2button;
    /* row 3 button variables */
    public Button a3button;
    public Button b3button;
    public Button c3button;
    public Button d3button;
    public Button e3button;
    public Button f3button;
    public Button g3button;
    public Button h3button;
    public Button i3button;
    /* row 4 button variables */
    public Button a4button;
    public Button b4button;
    public Button c4button;
    public Button d4button;
    public Button e4button;
    public Button f4button;
    public Button g4button;
    public Button h4button;
    public Button i4button;
    /* row 5 button variables */
    public Button a5button;
    public Button b5button;
    public Button c5button;
    public Button d5button;
    public Button e5button;
    public Button f5button;
    public Button g5button;
    public Button h5button;
    public Button i5button;
    /* row 6 button variables */
    public Button a6button;
    public Button b6button;
    public Button c6button;
    public Button d6button;
    public Button e6button;
    public Button f6button;
    public Button g6button;
    public Button h6button;
    public Button i6button;
    /* row 7 button variables */
    public Button a7button;
    public Button b7button;
    public Button c7button;
    public Button d7button;
    public Button e7button;
    public Button f7button;
    public Button g7button;
    public Button h7button;
    public Button i7button;
    /* row 8 button variables */
    public Button a8button;
    public Button b8button;
    public Button c8button;
    public Button d8button;
    public Button e8button;
    public Button f8button;
    public Button g8button;
    public Button h8button;
    public Button i8button;
    /* row 9 button variables */
    public Button a9button;
    public Button b9button;
    public Button c9button;
    public Button d9button;
    public Button e9button;
    public Button f9button;
    public Button g9button;
    public Button h9button;
    public Button i9button;

    /* Cell text variables */
    float redR = 255.0f;
    float redG = 0.0f;
    float redB = 0.0f;
    float redA = 25.0f;
    float blackR = 0.0f;
    float blackG = 0.0f;
    float blackB = 0.0f;
    float blackA = 25.0f;
    /* row 1 text variables */
    public TMP_Text a1text;
    public TMP_Text b1text;
    public TMP_Text c1text;
    public TMP_Text d1text;
    public TMP_Text e1text;
    public TMP_Text f1text;
    public TMP_Text g1text;
    public TMP_Text h1text;
    public TMP_Text i1text;
    /* row 2 text variables */
    public TMP_Text a2text;
    public TMP_Text b2text;
    public TMP_Text c2text;
    public TMP_Text d2text;
    public TMP_Text e2text;
    public TMP_Text f2text;
    public TMP_Text g2text;
    public TMP_Text h2text;
    public TMP_Text i2text;
    /* row 3 text variables */
    public TMP_Text a3text;
    public TMP_Text b3text;
    public TMP_Text c3text;
    public TMP_Text d3text;
    public TMP_Text e3text;
    public TMP_Text f3text;
    public TMP_Text g3text;
    public TMP_Text h3text;
    public TMP_Text i3text;
    /* row 4 text variables */
    public TMP_Text a4text;
    public TMP_Text b4text;
    public TMP_Text c4text;
    public TMP_Text d4text;
    public TMP_Text e4text;
    public TMP_Text f4text;
    public TMP_Text g4text;
    public TMP_Text h4text;
    public TMP_Text i4text;
    /* row 5 text variables */
    public TMP_Text a5text;
    public TMP_Text b5text;
    public TMP_Text c5text;
    public TMP_Text d5text;
    public TMP_Text e5text;
    public TMP_Text f5text;
    public TMP_Text g5text;
    public TMP_Text h5text;
    public TMP_Text i5text;
    /* row 6 text variables */
    public TMP_Text a6text;
    public TMP_Text b6text;
    public TMP_Text c6text;
    public TMP_Text d6text;
    public TMP_Text e6text;
    public TMP_Text f6text;
    public TMP_Text g6text;
    public TMP_Text h6text;
    public TMP_Text i6text;
    /* row 7 text variables */
    public TMP_Text a7text;
    public TMP_Text b7text;
    public TMP_Text c7text;
    public TMP_Text d7text;
    public TMP_Text e7text;
    public TMP_Text f7text;
    public TMP_Text g7text;
    public TMP_Text h7text;
    public TMP_Text i7text;
    /* row 8 text variables */
    public TMP_Text a8text;
    public TMP_Text b8text;
    public TMP_Text c8text;
    public TMP_Text d8text;
    public TMP_Text e8text;
    public TMP_Text f8text;
    public TMP_Text g8text;
    public TMP_Text h8text;
    public TMP_Text i8text;
    /* row 9 text variables */
    public TMP_Text a9text;
    public TMP_Text b9text;
    public TMP_Text c9text;
    public TMP_Text d9text;
    public TMP_Text e9text;
    public TMP_Text f9text;
    public TMP_Text g9text;
    public TMP_Text h9text;
    public TMP_Text i9text;

    /* row 1 Note variables */
    Note a1note;
    Note b1note;
    Note c1note;
    Note d1note;
    Note e1note;
    Note f1note;
    Note g1note;
    Note h1note;
    Note i1note;
    /* row 2 Note variables */
    Note a2note;
    Note b2note;
    Note c2note;
    Note d2note;
    Note e2note;
    Note f2note;
    Note g2note;
    Note h2note;
    Note i2note;
    /* row 3 Note variables */
    Note a3note;
    Note b3note;
    Note c3note;
    Note d3note;
    Note e3note;
    Note f3note;
    Note g3note;
    Note h3note;
    Note i3note;
    /* row 4 Note variables */
    Note a4note;
    Note b4note;
    Note c4note;
    Note d4note;
    Note e4note;
    Note f4note;
    Note g4note;
    Note h4note;
    Note i4note;
    /* row 5 Note variables */
    Note a5note;
    Note b5note;
    Note c5note;
    Note d5note;
    Note e5note;
    Note f5note;
    Note g5note;
    Note h5note;
    Note i5note;
    /* row 6 Note variables */
    Note a6note;
    Note b6note;
    Note c6note;
    Note d6note;
    Note e6note;
    Note f6note;
    Note g6note;
    Note h6note;
    Note i6note;
    /* row 7 Note variables */
    Note a7note;
    Note b7note;
    Note c7note;
    Note d7note;
    Note e7note;
    Note f7note;
    Note g7note;
    Note h7note;
    Note i7note;
    /* row 8 Note variables */
    Note a8note;
    Note b8note;
    Note c8note;
    Note d8note;
    Note e8note;
    Note f8note;
    Note g8note;
    Note h8note;
    Note i8note;
    /* row 9 Note variables */
    Note a9note;
    Note b9note;
    Note c9note;
    Note d9note;
    Note e9note;
    Note f9note;
    Note g9note;
    Note h9note;
    Note i9note;

    /* row 1 Note text variables */
    public TMP_Text a1noteText;
    public TMP_Text b1noteText;
    public TMP_Text c1noteText;
    public TMP_Text d1noteText;
    public TMP_Text e1noteText;
    public TMP_Text f1noteText;
    public TMP_Text g1noteText;
    public TMP_Text h1noteText;
    public TMP_Text i1noteText;
    /* row 2 Note text variables */
    public TMP_Text a2noteText;
    public TMP_Text b2noteText;
    public TMP_Text c2noteText;
    public TMP_Text d2noteText;
    public TMP_Text e2noteText;
    public TMP_Text f2noteText;
    public TMP_Text g2noteText;
    public TMP_Text h2noteText;
    public TMP_Text i2noteText;
    /* row 3 Note text variables */
    public TMP_Text a3noteText;
    public TMP_Text b3noteText;
    public TMP_Text c3noteText;
    public TMP_Text d3noteText;
    public TMP_Text e3noteText;
    public TMP_Text f3noteText;
    public TMP_Text g3noteText;
    public TMP_Text h3noteText;
    public TMP_Text i3noteText;
    /* row 4 Note text variables */
    public TMP_Text a4noteText;
    public TMP_Text b4noteText;
    public TMP_Text c4noteText;
    public TMP_Text d4noteText;
    public TMP_Text e4noteText;
    public TMP_Text f4noteText;
    public TMP_Text g4noteText;
    public TMP_Text h4noteText;
    public TMP_Text i4noteText;
    /* row 5 Note text variables */
    public TMP_Text a5noteText;
    public TMP_Text b5noteText;
    public TMP_Text c5noteText;
    public TMP_Text d5noteText;
    public TMP_Text e5noteText;
    public TMP_Text f5noteText;
    public TMP_Text g5noteText;
    public TMP_Text h5noteText;
    public TMP_Text i5noteText;
    /* row 6 Note text variables */
    public TMP_Text a6noteText;
    public TMP_Text b6noteText;
    public TMP_Text c6noteText;
    public TMP_Text d6noteText;
    public TMP_Text e6noteText;
    public TMP_Text f6noteText;
    public TMP_Text g6noteText;
    public TMP_Text h6noteText;
    public TMP_Text i6noteText;
    /* row 7 Note text variables */
    public TMP_Text a7noteText;
    public TMP_Text b7noteText;
    public TMP_Text c7noteText;
    public TMP_Text d7noteText;
    public TMP_Text e7noteText;
    public TMP_Text f7noteText;
    public TMP_Text g7noteText;
    public TMP_Text h7noteText;
    public TMP_Text i7noteText;
    /* row 8 Note text variables */
    public TMP_Text a8noteText;
    public TMP_Text b8noteText;
    public TMP_Text c8noteText;
    public TMP_Text d8noteText;
    public TMP_Text e8noteText;
    public TMP_Text f8noteText;
    public TMP_Text g8noteText;
    public TMP_Text h8noteText;
    public TMP_Text i8noteText;
    /* row 9 Note text variables */
    public TMP_Text a9noteText;
    public TMP_Text b9noteText;
    public TMP_Text c9noteText;
    public TMP_Text d9noteText;
    public TMP_Text e9noteText;
    public TMP_Text f9noteText;
    public TMP_Text g9noteText;
    public TMP_Text h9noteText;
    public TMP_Text i9noteText;

    // Start is called before the first frame update
    void Start()
    {
        isNoteMode = false;
        isNoteDeleteMode = false;
        notePanel.SetActive(false);
        isFillMode = true;
        fillPanel.SetActive(true);
        isLongSelected = false;
        longSelectPanel.SetActive(false);
        isSingleSelected = true;
        singleSelectPanel.SetActive(true);

        /* set random */
        sudokugames = new sudokugames();
        selectedDifficulty = updatevalues.difficulty;
        int randomIndex = Random.Range(0,arrayLength);
        if (selectedDifficulty == 0) {
            sudokuGame = sudokugames.getSudokuGameArray(0)[randomIndex];
        }
        else if (selectedDifficulty == 1) {
            sudokuGame = sudokugames.getSudokuGameArray(1)[randomIndex];
        }
        else if (selectedDifficulty == 2) {
            sudokuGame = sudokugames.getSudokuGameArray(2)[randomIndex];
        }
        else if (selectedDifficulty == 3) {
            sudokuGame = sudokugames.getSudokuGameArray(3)[randomIndex];
        }
        currentTime = sudokuGame.getTimer();

        /* initialize Score */
        score = new Score();

        initializeNumbers();
        initializeCells();

        initializeNumberPanels();
        initializeCellPanels();

        noteButton.onClick.AddListener(()=> {
            clearCellPanels();
            clearNumberPanels();
            isNoteMode = true;
            isFillMode = false;
            notePanel.SetActive(true);
            fillPanel.SetActive(false);
            if (isSingleSelected && !isLongSelected) {
                singleSelectNoteMode();
            }
            if (isLongSelected && !isSingleSelected) {
                longSelectNoteMode();
            }
        });

        fillButton.onClick.AddListener(()=> {
            clearCellPanels();
            clearNumberPanels();
            isFillMode = true;
            isNoteMode = false;
            fillPanel.SetActive(true);
            notePanel.SetActive(false);
            if (isSingleSelected && !isLongSelected) {
                singleSelectFillMode();
            }
            if (isLongSelected && !isSingleSelected) {
                longSelectFillMode();
            }
        });

        longSelectButton.onClick.AddListener(()=> {
            clearCellPanels();
            clearNumberPanels();
            isLongSelected = true;
            isSingleSelected = false;
            longSelectPanel.SetActive(true);
            singleSelectPanel.SetActive(false);
            if (isFillMode && !isNoteMode) {
                longSelectFillMode();
            }
            if (isNoteMode && !isFillMode) {
                longSelectNoteMode();
            }
        });

        singleSelectButton.onClick.AddListener(()=> {
            clearCellPanels();
            clearNumberPanels();
            isSingleSelected = true;
            isLongSelected = false;
            singleSelectPanel.SetActive(true);
            longSelectPanel.SetActive(false);
            if (isFillMode && !isNoteMode) {
                singleSelectFillMode();
            }
            if (isNoteMode && !isFillMode) {
                singleSelectNoteMode();
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        /* loop through Numbers */
        for (int i = 1; i < 10; i++) {
            /* if all Cells for a digit are correct and full, set secondary number panel to true */
            if (numbers[i].getCounter() == 9) {
                numbers[i].setComplete(true);
                numbers[i].setEnabled(false);
                numbers[i].getSecondaryPanel().SetActive(true);
                numbers[i].getPanel().SetActive(false);
                for (int cellStrIdx = 0; cellStrIdx < 81; cellStrIdx++) {
                    if (cells[cellStrIdx].getShowing() == false) {
                        cells[cellStrIdx].getNote().deleteNote(i);
                    }
                    else if (cells[cellStrIdx].getShowing() == true && cells[cellStrIdx].getCorrect() == false) {
                        cells[cellStrIdx].getNote().deleteNote(i);
                        cells[cellStrIdx].getNote().hideNote();
                    }
                }
            }
        }
        if (updatevalues.mistakesMade == 1) {
            mistakesText.text = firstMistakeText;
        }
        else if (updatevalues.mistakesMade == 2) {
            mistakesText.text = secondMistakeText;
        }
        else if (updatevalues.mistakesMade == 3) {
            mistakesText.text = thirdMistakeText;
        }

        bool allComplete = true;
        for (int i = 1; i < 10; i++) {
            if (numbers[i].getCounter() != 9) {
                allComplete = false;
            }
        }
        if (allComplete == true) {
            completeGoing = true;
        }
        if (completeGoing && !clearDone) {
            clearCellPanels();
            clearNumberPanels();
            clearDone = true;
        }
        if (currentTime == 0.0f) {
            endTimer = true;
            updatevalues.isTimeUpGameOver = true;
        }
        if (updatevalues.mistakesMade == 3) {
            endTimer = true;
            updatevalues.isMistakesGameOver = true;
        }
        if (completeGoing == true && completeCounter < 81) {
            cells[completeCounter].getSecondaryPanel().SetActive(true);
            if (completeCounter == 80) {
                completeDone = true;
                isGameOver = true;
            }
            else {
                completeCounter++;
            }
        }
        scoreText.text = score.getScore().ToString();
        if (endTimer == false) {
            currentTime -= Time.deltaTime;
            minutes = Mathf.FloorToInt(currentTime / 60);
            seconds = Mathf.FloorToInt(currentTime % 60);
        }
        timeText.text = (minutes.ToString() + ":" + seconds.ToString());
        if (isGameOver == true) {
            gameOver();
        }
        if (updatevalues.isTimeUpGameOver || updatevalues.isMistakesGameOver) {
            incompleteGameOver();
        }
    }

    void initializeCellPanels() {
        /* initialization loop through Cells */
        for (int ii = 0; ii < 81; ii++) {
            cells[ii].getPanel().SetActive(false);
            cells[ii].getSecondaryPanel().SetActive(false);
            cells[ii].getTertiaryPanel().SetActive(false);
            if (cells[ii].getShowing() == true) {
                cells[ii].getText().text = cells[ii].getNum().ToString();
            }
            for (int iii = 1; iii < 10; iii++) {
                if (cells[ii].getShowing() == true && cells[ii].getNum() == numbers[iii].getDigit()) {
                    numbers[iii].increaseCounter();
                }
            }
        }
    }

    void initializeNumberPanels() {
        /* initialization loop through Numbers */
        for (int i = 0; i < 10; i++) {
            numbers[i].getPanel().SetActive(false);
            numbers[i].getSecondaryPanel().SetActive(false);
            numbers[i].setEnabled(true);
            numbers[i].setComplete(false);
            numbers[i].setSelected(false);
        }
    }

    void clearCellPanels() {
        for (int i = 0; i < 81; i++) {
            Image image;
            image = cells[i].getTertiaryPanel().GetComponent<Image>();
            var tempColor = image.color;
            tempColor.a = 0.447f;
            cells[i].getPanel().SetActive(false);
            cells[i].getSecondaryPanel().SetActive(false);
            cells[i].getTertiaryPanel().SetActive(false);
            cells[i].getTertiaryPanel().GetComponent<Image>().color = tempColor;
        }
    }

    void clearNumberPanels() {
        for (int i = 0; i < 10; i++) {
            numbers[i].getPanel().SetActive(false);
            numbers[i].setSelected(false);
        }
    }

    void fillCellPanels(Number number) {
        clearCellPanels();
        for (int i = 0; i < 81; i++) {
            Image image;
            image = cells[i].getTertiaryPanel().GetComponent<Image>();
            var tempColor = image.color;
            tempColor.a = 0.2f;

            if (number.getDigit() == cells[i].getNum() && cells[i].getShowing() && cells[i].getCorrect()) {
                cells[i].getTertiaryPanel().SetActive(true);
            }
            if (number.getDigit() == 1 && cells[i].getNote().isOneNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
            if (number.getDigit() == 2 && cells[i].getNote().isTwoNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
            if (number.getDigit() == 3 && cells[i].getNote().isThreeNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
            if (number.getDigit() == 4 && cells[i].getNote().isFourNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
            if (number.getDigit() == 5 && cells[i].getNote().isFiveNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
            if (number.getDigit() == 6 && cells[i].getNote().isSixNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
            if (number.getDigit() == 7 && cells[i].getNote().isSevenNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
            if (number.getDigit() == 8 && cells[i].getNote().isEightNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
            if (number.getDigit() == 9 && cells[i].getNote().isNineNoted()) {
                cells[i].getTertiaryPanel().SetActive(true);
                image.color = tempColor;
            }
        }
    }

    void fillCellPanels(Cell cell) {
        clearCellPanels();
        cell.getPanel().SetActive(true);
        fillSecondaryPanels(cell);
        fillTertiaryPanels(cell);
    }

    void fillSecondaryPanels(Cell cell) {
        int digit = cell.getNum();
        if (cell.getShowing() && cell.getCorrect()) {
            for (int i = 0; i < 9; i++) {
                cell.getBox()[i].SetActive(true);
                cell.getRow()[i].SetActive(true);
                cell.getColumn()[i].SetActive(true);
            }
            cell.getSecondaryPanel().SetActive(false);
        }
    }

    void fillTertiaryPanels(Cell cell) {
        if (cell.getShowing() && cell.getCorrect()) {
            for (int i = 0; i < 81; i++) {
                Image image;
                image = cells[i].getTertiaryPanel().GetComponent<Image>();
                var tempColor = image.color;
                tempColor.a = 0.2f;
                if (cell != cells[i] && cells[i].getNum() == cell.getNum() && cells[i].getShowing()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    //image.color = tempColor;
                }
                if (cell.getNum() == 1 && cells[i].getNote().isOneNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
                if (cell.getNum() == 2 && cells[i].getNote().isTwoNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
                if (cell.getNum() == 3 && cells[i].getNote().isThreeNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
                if (cell.getNum() == 4 && cells[i].getNote().isFourNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
                if (cell.getNum() == 5 && cells[i].getNote().isFiveNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
                if (cell.getNum() == 6 && cells[i].getNote().isSixNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
                if (cell.getNum() == 7 && cells[i].getNote().isSevenNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
                if (cell.getNum() == 8 && cells[i].getNote().isEightNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
                if (cell.getNum() == 9 && cells[i].getNote().isNineNoted()) {
                    cells[i].getTertiaryPanel().SetActive(true);
                    image.color = tempColor;
                }
            }
        }
    }

    void clearIncorrectNotes(Cell cell) {
        int digit = cell.getNum();
        for (int i = 0; i < 81; i++) {
            if (cell.getBox() == cells[i].getBox() || cell.getRow() == cells[i].getRow() || cell.getColumn() == cells[i].getColumn()) {
                if (cell.inputNum(1) && cells[i].getNote().isOneNoted()) {
                    cells[i].getNote().deleteNote(1);
                }
                if (cell.inputNum(2) && cells[i].getNote().isTwoNoted()) {
                    cells[i].getNote().deleteNote(2);
                }
                if (cell.inputNum(3) && cells[i].getNote().isThreeNoted()) {
                    cells[i].getNote().deleteNote(3);
                }
                if (cell.inputNum(4) && cells[i].getNote().isFourNoted()) {
                    cells[i].getNote().deleteNote(4);
                }
                if (cell.inputNum(5) && cells[i].getNote().isFiveNoted()) {
                    cells[i].getNote().deleteNote(5);
                }
                if (cell.inputNum(6) && cells[i].getNote().isSixNoted()) {
                    cells[i].getNote().deleteNote(6);
                }
                if (cell.inputNum(7) && cells[i].getNote().isSevenNoted()) {
                    cells[i].getNote().deleteNote(7);
                }
                if (cell.inputNum(8) && cells[i].getNote().isEightNoted()) {
                    cells[i].getNote().deleteNote(8);
                }
                if (cell.inputNum(9) && cells[i].getNote().isNineNoted()) {
                    cells[i].getNote().deleteNote(9);
                }
            }
            clearCellPanels();
            fillTertiaryPanels(cell);
        }
    }
    
    void singleSelectFillMode() {
        if (isSingleSelected && !isLongSelected && isFillMode && !isNoteMode) {
            for (int iv = 0; iv < 81; iv++) {
                int indexiv = iv;
                /* single select fill mode*/
                cells[indexiv].getButton().onClick.AddListener(()=> {
                    if (isSingleSelected && !isLongSelected && isFillMode && !isNoteMode) {
                        selectedCell = cells[indexiv];
                        fillCellPanels(selectedCell);
                        /* loop through Numbers to set onClick functions */
                        for (int vii = 0; vii < 10; vii++) {
                            int indexvii = vii;
                            numbers[indexvii].getButton().onClick.AddListener(()=> {
                                if (isSingleSelected && !isLongSelected && isFillMode && !isNoteMode) {
                                    /* delete Number[0] onClick function */
                                    if (indexvii == 0) {
                                        /* clear all Number panels then activate delete */
                                        clearNumberPanels();
                                        numbers[indexvii].getPanel().SetActive(true);
                                        numbers[indexvii].setSelected(true);
                                        /* if Cell is showing and is incorrect, reset Cell */
                                        if (selectedCell.getShowing() == true && selectedCell.getCorrect() == false) {
                                            selectedCell.getText().text = numbers[indexvii].getOutput();
                                            selectedCell.setShowing(false);
                                            selectedCell.setCorrect(false);
                                            selectedCell.getNote().showNote();
                                        }
                                    }
                                    /* Numbers 1-9 onClick functions */
                                    else {
                                        /* if Number is enabled */
                                        if (numbers[indexvii].getEnabled() == true) {
                                            /* clear all Number panels then activate selected Number */
                                            clearNumberPanels();
                                            numbers[indexvii].getPanel().SetActive(true);
                                            numbers[indexvii].setSelected(true);
                                            /* if Number input is correct and Cell is empty */
                                            if (selectedCell.getShowing() == false && selectedCell.inputNum(numbers[indexvii].getDigit()) == true) {
                                                selectedCell.getText().text = numbers[indexvii].getOutput();
                                                selectedCell.getText().color = new Color(blackR, blackG, blackB, blackA);
                                                selectedCell.setShowing(true);
                                                selectedCell.setCorrect(true);
                                                clearIncorrectNotes(selectedCell);
                                                fillCellPanels(selectedCell);
                                                numbers[indexvii].increaseCounter();
                                                score.addCompleteCell();
                                                for (int strIdx = 1; strIdx < 10; strIdx++) {
                                                    selectedCell.getNote().deleteNote(strIdx);
                                                }
                                            }
                                            /* if Number input is incorrect and Cell is empty */
                                            else if (selectedCell.getShowing() == false && selectedCell.inputNum(numbers[indexvii].getDigit()) == false) {
                                                selectedCell.getText().text = numbers[indexvii].getOutput();
                                                selectedCell.getText().color = new Color(redR, redG, redB, redA);
                                                selectedCell.setShowing(true);
                                                selectedCell.setCorrect(false);
                                                if (mistakeMade == false) {
                                                    score.subtractMistake();
                                                    updatevalues.mistakesMade++;
                                                    mistakeMade = true;
                                                }
                                                selectedCell.getNote().hideNote();
                                            }
                                        }
                                        /* loop through numbers */
                                        for (int i = 1; i < 10; i++) {
                                            /* if all Cells for a digit are correct and full, set secondary number panel to true */
                                            if (numbers[i].getCounter() == 9) {
                                                numbers[i].setComplete(true);
                                                numbers[i].setEnabled(false);
                                                numbers[i].getSecondaryPanel().SetActive(true);
                                                numbers[i].getPanel().SetActive(false);
                                            }
                                        }
                                    }
                                    mistakeMade = false;
                                    clearNumberPanels();
                                }
                            });
                        }
                    }
                }); 
            }
        }
    }

    void longSelectFillMode() {
        if (isLongSelected && !isSingleSelected && isFillMode && !isNoteMode) {
            /* loop through Numbers */
            for (int a = 0; a < 10; a++) {
                int indexa = a;
                /* onClick for delete */
                if (indexa == 0) {
                    numbers[indexa].getButton().onClick.AddListener(()=> {
                        if (isLongSelected && !isSingleSelected && isFillMode && !isNoteMode) {
                            longSelectedNumber = numbers[indexa];
                            clearCellPanels();
                            clearNumberPanels();
                            longSelectedNumber.getPanel().SetActive(true);
                            for (int aa = 0; aa < 81; aa++) {
                                int indexaa = aa;
                                cells[indexaa].getButton().onClick.AddListener(()=> {
                                    if (isLongSelected && !isSingleSelected && isFillMode && !isNoteMode) {
                                        longSelectedCell = cells[indexaa];
                                        if (longSelectedCell.getCorrect() == false && longSelectedCell.getShowing() == true) {
                                            longSelectedCell.getText().text = "";
                                            longSelectedCell.setShowing(false);
                                            longSelectedCell.getNote().showNote();
                                        }
                                    }
                                });
                            }
                        }
                    });
                }
                /* onClick for Numbers */
                else {
                    numbers[indexa].getButton().onClick.AddListener(()=> {
                        if (isLongSelected && !isSingleSelected && isFillMode && !isNoteMode) {
                            longSelectedNumber = numbers[indexa];
                            longSelectedDigit = longSelectedNumber.getDigit();
                            if (longSelectedNumber.getEnabled() == true) {
                                clearNumberPanels();
                                fillCellPanels(longSelectedNumber);
                                longSelectedNumber.getPanel().SetActive(true);
                                for (int aaa = 0; aaa < 81; aaa++) {
                                    int indexaaa = aaa;
                                    cells[indexaaa].getButton().onClick.AddListener(()=> {
                                        if (isLongSelected && !isSingleSelected && isFillMode && !isNoteMode) {
                                            longSelectedCell = cells[indexaaa];
                                            /* correct */
                                            if (longSelectedCell.inputNum(longSelectedDigit) == true && longSelectedCell.getShowing() == false) {
                                                longSelectedCell.getText().text = longSelectedDigit.ToString();
                                                longSelectedCell.getText().color = new Color(blackR, blackG, blackB, blackA);
                                                longSelectedCell.setShowing(true);
                                                longSelectedCell.setCorrect(true);
                                                longSelectedNumber.increaseCounter();
                                                score.addCompleteCell();
                                                for (int strIdx = 1; strIdx < 10; strIdx++) {
                                                    longSelectedCell.getNote().deleteNote(strIdx);
                                                }
                                                clearIncorrectNotes(longSelectedCell);
                                                fillCellPanels(longSelectedNumber);
                                            }
                                            /* incorrect */
                                            else if (longSelectedCell.inputNum(longSelectedDigit) == false && longSelectedCell.getShowing() == false) {
                                                longSelectedCell.getText().text = longSelectedDigit.ToString();
                                                longSelectedCell.getText().color = new Color(redR, redG, redB, redA);
                                                longSelectedCell.setShowing(true);
                                                longSelectedCell.setCorrect(false);
                                                updatevalues.mistakesMade++;
                                                score.subtractMistake();
                                                longSelectedCell.getNote().hideNote();
                                            }
                                        }
                                    });
                                }
                            }
                        }
                    });
                }
            }
        }
    }

    void singleSelectNoteMode() {
        /* single select note mode */
        if (isSingleSelected && !isLongSelected && isNoteMode && !isFillMode) {
            for (int v = 0; v < 81; v++) {
                int indexv = v;
                cells[indexv].getButton().onClick.AddListener(()=> {
                    if (isSingleSelected && !isLongSelected && isNoteMode && !isFillMode) {
                        selectedCell = cells[indexv];
                        fillCellPanels(selectedCell);
                        numbers[0].getButton().onClick.AddListener(()=> {
                            if (isSingleSelected && !isLongSelected && isNoteMode && !isFillMode) {
                                isNoteDeleteMode = true;
                            }
                        });
                        /* loop through Numbers to set onClick functions */
                        for (int viii = 1; viii < 10; viii++) {
                            int indexviii = viii;
                            numbers[indexviii].getButton().onClick.AddListener(()=> {
                                if (isSingleSelected && !isLongSelected && isNoteMode && !isFillMode) {
                                    if (numbers[indexviii].getEnabled() == true && selectedCell.getShowing() == false) {
                                        clearNumberPanels();
                                        numbers[indexviii].getPanel().SetActive(true);
                                        numbers[indexviii].setSelected(true);
                                        if (!isNoteDeleteMode) {
                                            selectedCell.getNote().fillNote(numbers[indexviii].getDigit());
                                            fillCellPanels(selectedCell);
                                        }
                                        else if (isNoteDeleteMode) {
                                            selectedCell.getNote().deleteNote(numbers[indexviii].getDigit());
                                        }
                                    }
                                }
                            });
                        }
                    }                        
                });
            }
        }
    }

    void longSelectNoteMode() {
        // note mode and long select mode
        if (isLongSelected && !isSingleSelected && isNoteMode && !isFillMode) {
            clearCellPanels();
            clearNumberPanels();
            for (int i = 0; i < 10; i++) {
                int indexi = i;
                // delete button for long note mode
                if (indexi == 0) {
                    numbers[0].getButton().onClick.AddListener(()=> {
                        if (isLongSelected && !isSingleSelected && isNoteMode && !isFillMode) {
                            //clearNumberPanels();
                            numbers[0].getPanel().SetActive(true);
                            for (int numDelete = 1; numDelete < 10; numDelete++) {
                                int indexNumDelete = numDelete;
                                numbers[indexNumDelete].getButton().onClick.AddListener(()=> {
                                    longSelectedNumber = numbers[indexNumDelete];
                                    longSelectedDigit = longSelectedNumber.getDigit();
                                    longSelectedNumber.getPanel().SetActive(true);
                                });
                            }
                            fillCellPanels(longSelectedNumber);
                            for (int ii = 0; ii < 81; ii++) {
                                int indexii = ii;
                                cells[indexii].getButton().onClick.AddListener(()=> {
                                    if (isLongSelected && !isSingleSelected && isNoteMode && !isFillMode) {
                                        longSelectedCell = cells[indexii];
                                        //fillCellPanels(longSelectedCell);
                                        if (!longSelectedCell.getShowing() && longSelectedCell.getNote().isNumNoted(longSelectedDigit)) {
                                            longSelectedCell.getNote().deleteNote(longSelectedDigit);
                                        }
                                    }
                                });
                            }
                        }
                    });
                }
                // number buttons for long note mode
                else {
                    numbers[indexi].getButton().onClick.AddListener(()=> {
                        if (isLongSelected && !isSingleSelected && isNoteMode && !isFillMode) {
                            if (numbers[indexi].getEnabled() == true) {
                                longSelectedNumber = numbers[indexi];
                                longSelectedDigit = longSelectedNumber.getDigit();
                                clearNumberPanels();
                                longSelectedNumber.getPanel().SetActive(true);
                                fillCellPanels(longSelectedNumber);
                                for (int iv = 0; iv < 81; iv++) {
                                    int indexiv = iv;
                                    cells[indexiv].getButton().onClick.AddListener(()=> {
                                        bool isThisDeleteMode = false;
                                        if (isLongSelected && !isSingleSelected && isNoteMode && !isFillMode) {
                                            longSelectedCell = cells[indexiv];
                                            deleteButton.onClick.AddListener(()=> {
                                                isThisDeleteMode = true;
                                            });

                                            if (!isThisDeleteMode && !longSelectedCell.getShowing() && !longSelectedCell.getNote().isNumNoted(longSelectedDigit)) {
                                                longSelectedCell.getNote().fillNote(longSelectedDigit);
                                                fillCellPanels(longSelectedNumber);
                                                Debug.Log("Fill working!");
                                            }
                                            else if (isThisDeleteMode && !longSelectedCell.getShowing() && longSelectedCell.getNote().isNumNoted(longSelectedDigit)) {
                                                longSelectedCell.getNote().deleteNote(longSelectedDigit);
                                                fillCellPanels(longSelectedNumber);
                                                longSelectedCell.getTertiaryPanel().SetActive(false);
                                                longSelectedCell.getSecondaryPanel().SetActive(false);
                                                Debug.Log("Delete working!");
                                            }
                                        }
                                    });
                                }
                            }
                        }
                    });
                }
            }
        }
    }

    void incompleteGameOver() {
        initialScore = score.getScore();
        updatevalues.initialScore = this.initialScore;
        timeBonus = Mathf.FloorToInt(currentTime); // total seconds
        updatevalues.timeBonus = this.timeBonus;
        totalScore = score.addSeconds(Mathf.FloorToInt(currentTime));
        updatevalues.totalScore = this.totalScore;
        minutesLeft = Mathf.FloorToInt(minutes);
        updatevalues.minutesLeft = this.minutesLeft;
        secondsLeft = Mathf.FloorToInt(seconds); // displayed seconds
        updatevalues.secondsLeft = this.secondsLeft;
        SceneManager.LoadScene("Time Up");
    }

    void gameOver() {
        initialScore = score.getScore();
        updatevalues.initialScore = this.initialScore;
        timeBonus = Mathf.FloorToInt(currentTime); // total seconds
        updatevalues.timeBonus = this.timeBonus;
        totalScore = score.addSeconds(Mathf.FloorToInt(currentTime));
        updatevalues.totalScore = this.totalScore;
        minutesLeft = Mathf.FloorToInt(minutes);
        updatevalues.minutesLeft = this.minutesLeft;
        secondsLeft = Mathf.FloorToInt(seconds); // displayed seconds
        updatevalues.secondsLeft = this.secondsLeft;
        SceneManager.LoadScene("Trippy Score");
    }

    void initializeNumbers() {
        /* initialize Numbers */
        delete = new Number(0, " ", deleteButton, deletePanel, secPanel1);
        number1 = new Number(1, "1", button1, panel1, secPanel1);
        number2 = new Number(2, "2", button2, panel2, secPanel2);
        number3 = new Number(3, "3", button3, panel3, secPanel3);
        number4 = new Number(4, "4", button4, panel4, secPanel4);
        number5 = new Number(5, "5", button5, panel5, secPanel5);
        number6 = new Number(6, "6", button6, panel6, secPanel6);
        number7 = new Number(7, "7", button7, panel7, secPanel7);
        number8 = new Number(8, "8", button8, panel8, secPanel8);
        number9 = new Number(9, "9", button9, panel9, secPanel9);
        /* initialize Number array  */
        numbers = new Number[10];
        numbers[0] = delete;
        numbers[1] = number1;
        numbers[2] = number2;
        numbers[3] = number3;
        numbers[4] = number4;
        numbers[5] = number5;
        numbers[6] = number6;
        numbers[7] = number7;
        numbers[8] = number8;
        numbers[9] = number9;
    }

    void initializeCells() {
        /* initialize secondary row panel arrays */
        /* initialize row 1 secondary panel array */
        row1Panels = new GameObject[9];
        row1Panels[0] = a1panel2;
        row1Panels[1] = b1panel2;
        row1Panels[2] = c1panel2;
        row1Panels[3] = d1panel2;
        row1Panels[4] = e1panel2;
        row1Panels[5] = f1panel2;
        row1Panels[6] = g1panel2;
        row1Panels[7] = h1panel2;
        row1Panels[8] = i1panel2;
        /* initialize row 2 secondary panel array */
        row2Panels = new GameObject[9];
        row2Panels[0] = a2panel2;
        row2Panels[1] = b2panel2;
        row2Panels[2] = c2panel2;
        row2Panels[3] = d2panel2;
        row2Panels[4] = e2panel2;
        row2Panels[5] = f2panel2;
        row2Panels[6] = g2panel2;
        row2Panels[7] = h2panel2;
        row2Panels[8] = i2panel2;
        /* initialize row 3 secondary panel array */
        row3Panels = new GameObject[9];
        row3Panels[0] = a3panel2;
        row3Panels[1] = b3panel2;
        row3Panels[2] = c3panel2;
        row3Panels[3] = d3panel2;
        row3Panels[4] = e3panel2;
        row3Panels[5] = f3panel2;
        row3Panels[6] = g3panel2;
        row3Panels[7] = h3panel2;
        row3Panels[8] = i3panel2;
        /* initialize row 4 secondary panel array */
        row4Panels = new GameObject[9];
        row4Panels[0] = a4panel2;
        row4Panels[1] = b4panel2;
        row4Panels[2] = c4panel2;
        row4Panels[3] = d4panel2;
        row4Panels[4] = e4panel2;
        row4Panels[5] = f4panel2;
        row4Panels[6] = g4panel2;
        row4Panels[7] = h4panel2;
        row4Panels[8] = i4panel2;
        /* initialize row 5 secondary panel array */
        row5Panels = new GameObject[9];
        row5Panels[0] = a5panel2;
        row5Panels[1] = b5panel2;
        row5Panels[2] = c5panel2;
        row5Panels[3] = d5panel2;
        row5Panels[4] = e5panel2;
        row5Panels[5] = f5panel2;
        row5Panels[6] = g5panel2;
        row5Panels[7] = h5panel2;
        row5Panels[8] = i5panel2;
        /* initialize row 6 secondary panel array */
        row6Panels = new GameObject[9];
        row6Panels[0] = a6panel2;
        row6Panels[1] = b6panel2;
        row6Panels[2] = c6panel2;
        row6Panels[3] = d6panel2;
        row6Panels[4] = e6panel2;
        row6Panels[5] = f6panel2;
        row6Panels[6] = g6panel2;
        row6Panels[7] = h6panel2;
        row6Panels[8] = i6panel2;
        /* initialize row 7 secondary panel array */
        row7Panels = new GameObject[9];
        row7Panels[0] = a7panel2;
        row7Panels[1] = b7panel2;
        row7Panels[2] = c7panel2;
        row7Panels[3] = d7panel2;
        row7Panels[4] = e7panel2;
        row7Panels[5] = f7panel2;
        row7Panels[6] = g7panel2;
        row7Panels[7] = h7panel2;
        row7Panels[8] = i7panel2;
        /* initialize row 8 secondary panel array */
        row8Panels = new GameObject[9];
        row8Panels[0] = a8panel2;
        row8Panels[1] = b8panel2;
        row8Panels[2] = c8panel2;
        row8Panels[3] = d8panel2;
        row8Panels[4] = e8panel2;
        row8Panels[5] = f8panel2;
        row8Panels[6] = g8panel2;
        row8Panels[7] = h8panel2;
        row8Panels[8] = i8panel2;
        /* initialize row 9 secondary panel array */
        row9Panels = new GameObject[9];
        row9Panels[0] = a9panel2;
        row9Panels[1] = b9panel2;
        row9Panels[2] = c9panel2;
        row9Panels[3] = d9panel2;
        row9Panels[4] = e9panel2;
        row9Panels[5] = f9panel2;
        row9Panels[6] = g9panel2;
        row9Panels[7] = h9panel2;
        row9Panels[8] = i9panel2;

        /* initialize secondary column panel arrays */
        /* initialize column A secondary panel array */
        colAPanels = new GameObject[9];
        colAPanels[0] = a1panel2;
        colAPanels[1] = a2panel2;
        colAPanels[2] = a3panel2;
        colAPanels[3] = a4panel2;
        colAPanels[4] = a5panel2;
        colAPanels[5] = a6panel2;
        colAPanels[6] = a7panel2;
        colAPanels[7] = a8panel2;
        colAPanels[8] = a9panel2;
        /* initialize column B secondary panel array */
        colBPanels = new GameObject[9];
        colBPanels[0] = b1panel2;
        colBPanels[1] = b2panel2;
        colBPanels[2] = b3panel2;
        colBPanels[3] = b4panel2;
        colBPanels[4] = b5panel2;
        colBPanels[5] = b6panel2;
        colBPanels[6] = b7panel2;
        colBPanels[7] = b8panel2;
        colBPanels[8] = b9panel2;
        /* initialize column C secondary panel array */
        colCPanels = new GameObject[9];
        colCPanels[0] = c1panel2;
        colCPanels[1] = c2panel2;
        colCPanels[2] = c3panel2;
        colCPanels[3] = c4panel2;
        colCPanels[4] = c5panel2;
        colCPanels[5] = c6panel2;
        colCPanels[6] = c7panel2;
        colCPanels[7] = c8panel2;
        colCPanels[8] = c9panel2;
        /* initialize column D secondary panel array */
        colDPanels = new GameObject[9];
        colDPanels[0] = d1panel2;
        colDPanels[1] = d2panel2;
        colDPanels[2] = d3panel2;
        colDPanels[3] = d4panel2;
        colDPanels[4] = d5panel2;
        colDPanels[5] = d6panel2;
        colDPanels[6] = d7panel2;
        colDPanels[7] = d8panel2;
        colDPanels[8] = d9panel2;
        /* initialize column E secondary panel array */
        colEPanels = new GameObject[9];
        colEPanels[0] = e1panel2;
        colEPanels[1] = e2panel2;
        colEPanels[2] = e3panel2;
        colEPanels[3] = e4panel2;
        colEPanels[4] = e5panel2;
        colEPanels[5] = e6panel2;
        colEPanels[6] = e7panel2;
        colEPanels[7] = e8panel2;
        colEPanels[8] = e9panel2;
        /* initialize column F secondary panel array */
        colFPanels = new GameObject[9];
        colFPanels[0] = f1panel2;
        colFPanels[1] = f2panel2;
        colFPanels[2] = f3panel2;
        colFPanels[3] = f4panel2;
        colFPanels[4] = f5panel2;
        colFPanels[5] = f6panel2;
        colFPanels[6] = f7panel2;
        colFPanels[7] = f8panel2;
        colFPanels[8] = f9panel2;
        /* initialize column G secondary panel array */
        colGPanels = new GameObject[9];
        colGPanels[0] = g1panel2;
        colGPanels[1] = g2panel2;
        colGPanels[2] = g3panel2;
        colGPanels[3] = g4panel2;
        colGPanels[4] = g5panel2;
        colGPanels[5] = g6panel2;
        colGPanels[6] = g7panel2;
        colGPanels[7] = g8panel2;
        colGPanels[8] = g9panel2;
        /* initialize column H secondary panel array */
        colHPanels = new GameObject[9];
        colHPanels[0] = h1panel2;
        colHPanels[1] = h2panel2;
        colHPanels[2] = h3panel2;
        colHPanels[3] = h4panel2;
        colHPanels[4] = h5panel2;
        colHPanels[5] = h6panel2;
        colHPanels[6] = h7panel2;
        colHPanels[7] = h8panel2;
        colHPanels[8] = h9panel2;
        /* initialize column I secondary panel array */
        colIPanels = new GameObject[9];
        colIPanels[0] = i1panel2;
        colIPanels[1] = i2panel2;
        colIPanels[2] = i3panel2;
        colIPanels[3] = i4panel2;
        colIPanels[4] = i5panel2;
        colIPanels[5] = i6panel2;
        colIPanels[6] = i7panel2;
        colIPanels[7] = i8panel2;
        colIPanels[8] = i9panel2;

        /* initialize secondary box panel arrays */
        /* initialize box 1 secondary panel array */
        box1Panels = new GameObject[9];
        box1Panels[0] = a1panel2;
        box1Panels[1] = b1panel2;
        box1Panels[2] = c1panel2;
        box1Panels[3] = a2panel2;
        box1Panels[4] = b2panel2;
        box1Panels[5] = c2panel2;
        box1Panels[6] = a3panel2;
        box1Panels[7] = b3panel2;
        box1Panels[8] = c3panel2;
        /* initialize box 2 secondary panel array */
        box2Panels = new GameObject[9];
        box2Panels[0] = d1panel2;
        box2Panels[1] = e1panel2;
        box2Panels[2] = f1panel2;
        box2Panels[3] = d2panel2;
        box2Panels[4] = e2panel2;
        box2Panels[5] = f2panel2;
        box2Panels[6] = d3panel2;
        box2Panels[7] = e3panel2;
        box2Panels[8] = f3panel2;
        /* initialize box 3 secondary panel array */
        box3Panels = new GameObject[9];
        box3Panels[0] = g1panel2;
        box3Panels[1] = h1panel2;
        box3Panels[2] = i1panel2;
        box3Panels[3] = g2panel2;
        box3Panels[4] = h2panel2;
        box3Panels[5] = i2panel2;
        box3Panels[6] = g3panel2;
        box3Panels[7] = h3panel2;
        box3Panels[8] = i3panel2;
        /* initialize box 4 secondary panel array */
        box4Panels = new GameObject[9];
        box4Panels[0] = a4panel2;
        box4Panels[1] = b4panel2;
        box4Panels[2] = c4panel2;
        box4Panels[3] = a5panel2;
        box4Panels[4] = b5panel2;
        box4Panels[5] = c5panel2;
        box4Panels[6] = a6panel2;
        box4Panels[7] = b6panel2;
        box4Panels[8] = c6panel2;
        /* initialize box 5 secondary panel array */
        box5Panels = new GameObject[9];
        box5Panels[0] = d4panel2;
        box5Panels[1] = e4panel2;
        box5Panels[2] = f4panel2;
        box5Panels[3] = d5panel2;
        box5Panels[4] = e5panel2;
        box5Panels[5] = f5panel2;
        box5Panels[6] = d6panel2;
        box5Panels[7] = e6panel2;
        box5Panels[8] = f6panel2;
        /* initialize box 6 secondary panel array */
        box6Panels = new GameObject[9];
        box6Panels[0] = g4panel2;
        box6Panels[1] = h4panel2;
        box6Panels[2] = i4panel2;
        box6Panels[3] = g5panel2;
        box6Panels[4] = h5panel2;
        box6Panels[5] = i5panel2;
        box6Panels[6] = g6panel2;
        box6Panels[7] = h6panel2;
        box6Panels[8] = i6panel2;
        /* initialize box 7 secondary panel array */
        box7Panels = new GameObject[9];
        box7Panels[0] = a7panel2;
        box7Panels[1] = b7panel2;
        box7Panels[2] = c7panel2;
        box7Panels[3] = a8panel2;
        box7Panels[4] = b8panel2;
        box7Panels[5] = c8panel2;
        box7Panels[6] = a9panel2;
        box7Panels[7] = b9panel2;
        box7Panels[8] = c9panel2;
        /* initialize box 8 secondary panel array */
        box8Panels = new GameObject[9];
        box8Panels[0] = d7panel2;
        box8Panels[1] = e7panel2;
        box8Panels[2] = f7panel2;
        box8Panels[3] = d8panel2;
        box8Panels[4] = e8panel2;
        box8Panels[5] = f8panel2;
        box8Panels[6] = d9panel2;
        box8Panels[7] = e9panel2;
        box8Panels[8] = f9panel2;
        /* initialize box 9 secondary panel array */
        box9Panels = new GameObject[9];
        box9Panels[0] = g7panel2;
        box9Panels[1] = h7panel2;
        box9Panels[2] = i7panel2;
        box9Panels[3] = g8panel2;
        box9Panels[4] = h8panel2;
        box9Panels[5] = i8panel2;
        box9Panels[6] = g9panel2;
        box9Panels[7] = h9panel2;
        box9Panels[8] = i9panel2;

        /* initialize row 1 Notes */
        a1note = new Note(a1noteText);
        b1note = new Note(b1noteText);
        c1note = new Note(c1noteText);
        d1note = new Note(d1noteText);
        e1note = new Note(e1noteText);
        f1note = new Note(f1noteText);
        g1note = new Note(g1noteText);
        h1note = new Note(h1noteText);
        i1note = new Note(i1noteText);
        /* initialize row 2 Notes */
        a2note = new Note(a2noteText);
        b2note = new Note(b2noteText);
        c2note = new Note(c2noteText);
        d2note = new Note(d2noteText);
        e2note = new Note(e2noteText);
        f2note = new Note(f2noteText);
        g2note = new Note(g2noteText);
        h2note = new Note(h2noteText);
        i2note = new Note(i2noteText);
        /* initialize row 3 Notes */
        a3note = new Note(a3noteText);
        b3note = new Note(b3noteText);
        c3note = new Note(c3noteText);
        d3note = new Note(d3noteText);
        e3note = new Note(e3noteText);
        f3note = new Note(f3noteText);
        g3note = new Note(g3noteText);
        h3note = new Note(h3noteText);
        i3note = new Note(i3noteText);
        /* initialize row 4 Notes */
        a4note = new Note(a4noteText);
        b4note = new Note(b4noteText);
        c4note = new Note(c4noteText);
        d4note = new Note(d4noteText);
        e4note = new Note(e4noteText);
        f4note = new Note(f4noteText);
        g4note = new Note(g4noteText);
        h4note = new Note(h4noteText);
        i4note = new Note(i4noteText);
        /* initialize row 5 Notes */
        a5note = new Note(a5noteText);
        b5note = new Note(b5noteText);
        c5note = new Note(c5noteText);
        d5note = new Note(d5noteText);
        e5note = new Note(e5noteText);
        f5note = new Note(f5noteText);
        g5note = new Note(g5noteText);
        h5note = new Note(h5noteText);
        i5note = new Note(i5noteText);
        /* initialize row 6 Notes */
        a6note = new Note(a6noteText);
        b6note = new Note(b6noteText);
        c6note = new Note(c6noteText);
        d6note = new Note(d6noteText);
        e6note = new Note(e6noteText);
        f6note = new Note(f6noteText);
        g6note = new Note(g6noteText);
        h6note = new Note(h6noteText);
        i6note = new Note(i6noteText);
        /* initialize row 7 Notes */
        a7note = new Note(a7noteText);
        b7note = new Note(b7noteText);
        c7note = new Note(c7noteText);
        d7note = new Note(d7noteText);
        e7note = new Note(e7noteText);
        f7note = new Note(f7noteText);
        g7note = new Note(g7noteText);
        h7note = new Note(h7noteText);
        i7note = new Note(i7noteText);
        /* initialize row 8 Notes */
        a8note = new Note(a8noteText);
        b8note = new Note(b8noteText);
        c8note = new Note(c8noteText);
        d8note = new Note(d8noteText);
        e8note = new Note(e8noteText);
        f8note = new Note(f8noteText);
        g8note = new Note(g8noteText);
        h8note = new Note(h8noteText);
        i8note = new Note(i8noteText);
        /* initialize row 9 Notes */
        a9note = new Note(a9noteText);
        b9note = new Note(b9noteText);
        c9note = new Note(c9noteText);
        d9note = new Note(d9noteText);
        e9note = new Note(e9noteText);
        f9note = new Note(f9noteText);
        g9note = new Note(g9noteText);
        h9note = new Note(h9noteText);
        i9note = new Note(i9noteText);

        /* initializing 1 row variables */
        a1 = new Cell(sudokuGame.getDigit(0), sudokuGame.getShowingBool(0), a1panel, a1panel2, a1panel3, a1button, a1text, 1, row1Panels, colAPanels, box1Panels, a1note);
        b1 = new Cell(sudokuGame.getDigit(1), sudokuGame.getShowingBool(1), b1panel, b1panel2, b1panel3, b1button, b1text, 2, row1Panels, colBPanels, box1Panels, b1note);
        c1 = new Cell(sudokuGame.getDigit(2), sudokuGame.getShowingBool(2), c1panel, c1panel2, c1panel3, c1button, c1text, 3, row1Panels, colCPanels, box1Panels, c1note);
        d1 = new Cell(sudokuGame.getDigit(3), sudokuGame.getShowingBool(3), d1panel, d1panel2, d1panel3, d1button, d1text, 4, row1Panels, colDPanels, box2Panels, d1note);
        e1 = new Cell(sudokuGame.getDigit(4), sudokuGame.getShowingBool(4), e1panel, e1panel2, e1panel3, e1button, e1text, 5, row1Panels, colEPanels, box2Panels, e1note);
        f1 = new Cell(sudokuGame.getDigit(5), sudokuGame.getShowingBool(5), f1panel, f1panel2, f1panel3, f1button, f1text, 6, row1Panels, colFPanels, box2Panels, f1note);
        g1 = new Cell(sudokuGame.getDigit(6), sudokuGame.getShowingBool(6), g1panel, g1panel2, g1panel3, g1button, g1text, 7, row1Panels, colGPanels, box3Panels, g1note);
        h1 = new Cell(sudokuGame.getDigit(7), sudokuGame.getShowingBool(7), h1panel, h1panel2, h1panel3, h1button, h1text, 8, row1Panels, colHPanels, box3Panels, h1note);
        i1 = new Cell(sudokuGame.getDigit(8), sudokuGame.getShowingBool(8), i1panel, i1panel2, i1panel3, i1button, i1text, 9, row1Panels, colIPanels, box3Panels, i1note);
        /* initializing 2 row variables */
        a2 = new Cell(sudokuGame.getDigit(9), sudokuGame.getShowingBool(9), a2panel, a2panel2, a2panel3, a2button, a2text, 10, row2Panels, colAPanels, box1Panels, a2note);
        b2 = new Cell(sudokuGame.getDigit(10), sudokuGame.getShowingBool(10), b2panel, b2panel2, b2panel3, b2button, b2text, 11, row2Panels, colBPanels, box1Panels, b2note);
        c2 = new Cell(sudokuGame.getDigit(11), sudokuGame.getShowingBool(11), c2panel, c2panel2, c2panel3, c2button, c2text, 12, row2Panels, colCPanels, box1Panels, c2note);
        d2 = new Cell(sudokuGame.getDigit(12), sudokuGame.getShowingBool(12), d2panel, d2panel2, d2panel3, d2button, d2text, 13, row2Panels, colDPanels, box2Panels, d2note);
        e2 = new Cell(sudokuGame.getDigit(13), sudokuGame.getShowingBool(13), e2panel, e2panel2, e2panel3, e2button, e2text, 14, row2Panels, colEPanels, box2Panels, e2note);
        f2 = new Cell(sudokuGame.getDigit(14), sudokuGame.getShowingBool(14), f2panel, f2panel2, f2panel3, f2button, f2text, 15, row2Panels, colFPanels, box2Panels, f2note);
        g2 = new Cell(sudokuGame.getDigit(15), sudokuGame.getShowingBool(15), g2panel, g2panel2, g2panel3, g2button, g2text, 16, row2Panels, colGPanels, box3Panels, g2note);
        h2 = new Cell(sudokuGame.getDigit(16), sudokuGame.getShowingBool(16), h2panel, h2panel2, h2panel3, h2button, h2text, 17, row2Panels, colHPanels, box3Panels, h2note);
        i2 = new Cell(sudokuGame.getDigit(17), sudokuGame.getShowingBool(17), i2panel, i2panel2, i2panel3, i2button, i2text, 18, row2Panels, colIPanels, box3Panels, i2note);
        /* initializing 3 row variables */
        a3 = new Cell(sudokuGame.getDigit(18), sudokuGame.getShowingBool(18), a3panel, a3panel2, a3panel3, a3button, a3text, 19, row3Panels, colAPanels, box1Panels, a3note);
        b3 = new Cell(sudokuGame.getDigit(19), sudokuGame.getShowingBool(19), b3panel, b3panel2, b3panel3, b3button, b3text, 20, row3Panels, colBPanels, box1Panels, b3note);
        c3 = new Cell(sudokuGame.getDigit(20), sudokuGame.getShowingBool(20), c3panel, c3panel2, c3panel3, c3button, c3text, 21, row3Panels, colCPanels, box1Panels, c3note);
        d3 = new Cell(sudokuGame.getDigit(21), sudokuGame.getShowingBool(21), d3panel, d3panel2, d3panel3, d3button, d3text, 22, row3Panels, colDPanels, box2Panels, d3note);
        e3 = new Cell(sudokuGame.getDigit(22), sudokuGame.getShowingBool(22), e3panel, e3panel2, e3panel3, e3button, e3text, 23, row3Panels, colEPanels, box2Panels, e3note);
        f3 = new Cell(sudokuGame.getDigit(23), sudokuGame.getShowingBool(23), f3panel, f3panel2, f3panel3, f3button, f3text, 24, row3Panels, colFPanels, box2Panels, f3note);
        g3 = new Cell(sudokuGame.getDigit(24), sudokuGame.getShowingBool(24), g3panel, g3panel2, g3panel3, g3button, g3text, 25, row3Panels, colGPanels, box3Panels, g3note);
        h3 = new Cell(sudokuGame.getDigit(25), sudokuGame.getShowingBool(25), h3panel, h3panel2, h3panel3, h3button, h3text, 26, row3Panels, colHPanels, box3Panels, h3note);
        i3 = new Cell(sudokuGame.getDigit(26), sudokuGame.getShowingBool(26), i3panel, i3panel2, i3panel3, i3button, i3text, 27, row3Panels, colIPanels, box3Panels, i3note);
        /* initializing 4 row variables */
        a4 = new Cell(sudokuGame.getDigit(27), sudokuGame.getShowingBool(27), a4panel, a4panel2, a4panel3, a4button, a4text, 28, row4Panels, colAPanels, box4Panels, a4note);
        b4 = new Cell(sudokuGame.getDigit(28), sudokuGame.getShowingBool(28), b4panel, b4panel2, b4panel3, b4button, b4text, 29, row4Panels, colBPanels, box4Panels, b4note);
        c4 = new Cell(sudokuGame.getDigit(29), sudokuGame.getShowingBool(29), c4panel, c4panel2, c4panel3, c4button, c4text, 30, row4Panels, colCPanels, box4Panels, c4note);
        d4 = new Cell(sudokuGame.getDigit(30), sudokuGame.getShowingBool(30), d4panel, d4panel2, d4panel3, d4button, d4text, 31, row4Panels, colDPanels, box5Panels, d4note);
        e4 = new Cell(sudokuGame.getDigit(31), sudokuGame.getShowingBool(31), e4panel, e4panel2, e4panel3, e4button, e4text, 32, row4Panels, colEPanels, box5Panels, e4note);
        f4 = new Cell(sudokuGame.getDigit(32), sudokuGame.getShowingBool(32), f4panel, f4panel2, f4panel3, f4button, f4text, 33, row4Panels, colFPanels, box5Panels, f4note);
        g4 = new Cell(sudokuGame.getDigit(33), sudokuGame.getShowingBool(33), g4panel, g4panel2, g4panel3, g4button, g4text, 34, row4Panels, colGPanels, box6Panels, g4note);
        h4 = new Cell(sudokuGame.getDigit(34), sudokuGame.getShowingBool(34), h4panel, h4panel2, h4panel3, h4button, h4text, 35, row4Panels, colHPanels, box6Panels, h4note);
        i4 = new Cell(sudokuGame.getDigit(35), sudokuGame.getShowingBool(35), i4panel, i4panel2, i4panel3, i4button, i4text, 36, row4Panels, colIPanels, box6Panels, i4note);
        /* initializing 5 row variables */
        a5 = new Cell(sudokuGame.getDigit(36), sudokuGame.getShowingBool(36), a5panel, a5panel2, a5panel3, a5button, a5text, 37, row5Panels, colAPanels, box4Panels, a5note);
        b5 = new Cell(sudokuGame.getDigit(37), sudokuGame.getShowingBool(37), b5panel, b5panel2, b5panel3, b5button, b5text, 38, row5Panels, colBPanels, box4Panels, b5note);
        c5 = new Cell(sudokuGame.getDigit(38), sudokuGame.getShowingBool(38), c5panel, c5panel2, c5panel3, c5button, c5text, 39, row5Panels, colCPanels, box4Panels, c5note);
        d5 = new Cell(sudokuGame.getDigit(39), sudokuGame.getShowingBool(39), d5panel, d5panel2, d5panel3, d5button, d5text, 40, row5Panels, colDPanels, box5Panels, d5note);
        e5 = new Cell(sudokuGame.getDigit(40), sudokuGame.getShowingBool(40), e5panel, e5panel2, e5panel3, e5button, e5text, 41, row5Panels, colEPanels, box5Panels, e5note);
        f5 = new Cell(sudokuGame.getDigit(41), sudokuGame.getShowingBool(41), f5panel, f5panel2, f5panel3, f5button, f5text, 42, row5Panels, colFPanels, box5Panels, f5note);
        g5 = new Cell(sudokuGame.getDigit(42), sudokuGame.getShowingBool(42), g5panel, g5panel2, g5panel3, g5button, g5text, 43, row5Panels, colGPanels, box6Panels, g5note);
        h5 = new Cell(sudokuGame.getDigit(43), sudokuGame.getShowingBool(43), h5panel, h5panel2, h5panel3, h5button, h5text, 44, row5Panels, colHPanels, box6Panels, h5note);
        i5 = new Cell(sudokuGame.getDigit(44), sudokuGame.getShowingBool(44), i5panel, i5panel2, i5panel3, i5button, i5text, 45, row5Panels, colIPanels, box6Panels, i5note);
        /* initializing 6 row variables */
        a6 = new Cell(sudokuGame.getDigit(45), sudokuGame.getShowingBool(45), a6panel, a6panel2, a6panel3, a6button, a6text, 46, row6Panels, colAPanels, box4Panels, a6note);
        b6 = new Cell(sudokuGame.getDigit(46), sudokuGame.getShowingBool(46), b6panel, b6panel2, b6panel3, b6button, b6text, 47, row6Panels, colBPanels, box4Panels, b6note);
        c6 = new Cell(sudokuGame.getDigit(47), sudokuGame.getShowingBool(47), c6panel, c6panel2, c6panel3, c6button, c6text, 48, row6Panels, colCPanels, box4Panels, c6note);
        d6 = new Cell(sudokuGame.getDigit(48), sudokuGame.getShowingBool(48), d6panel, d6panel2, d6panel3, d6button, d6text, 49, row6Panels, colDPanels, box5Panels, d6note);
        e6 = new Cell(sudokuGame.getDigit(49), sudokuGame.getShowingBool(49), e6panel, e6panel2, e6panel3, e6button, e6text, 50, row6Panels, colEPanels, box5Panels, e6note);
        f6 = new Cell(sudokuGame.getDigit(50), sudokuGame.getShowingBool(50), f6panel, f6panel2, f6panel3, f6button, f6text, 51, row6Panels, colFPanels, box5Panels, f6note);
        g6 = new Cell(sudokuGame.getDigit(51), sudokuGame.getShowingBool(51), g6panel, g6panel2, g6panel3, g6button, g6text, 52, row6Panels, colGPanels, box6Panels, g6note);
        h6 = new Cell(sudokuGame.getDigit(52), sudokuGame.getShowingBool(52), h6panel, h6panel2, h6panel3, h6button, h6text, 53, row6Panels, colHPanels, box6Panels, h6note);
        i6 = new Cell(sudokuGame.getDigit(53), sudokuGame.getShowingBool(53), i6panel, i6panel2, i6panel3, i6button, i6text, 54, row6Panels, colIPanels, box6Panels, i6note);
        /* initializing 7 row variables */
        a7 = new Cell(sudokuGame.getDigit(54), sudokuGame.getShowingBool(54), a7panel, a7panel2, a7panel3, a7button, a7text, 55, row7Panels, colAPanels, box7Panels, a7note);
        b7 = new Cell(sudokuGame.getDigit(55), sudokuGame.getShowingBool(55), b7panel, b7panel2, b7panel3, b7button, b7text, 56, row7Panels, colBPanels, box7Panels, b7note);
        c7 = new Cell(sudokuGame.getDigit(56), sudokuGame.getShowingBool(56), c7panel, c7panel2, c7panel3, c7button, c7text, 57, row7Panels, colCPanels, box7Panels, c7note);
        d7 = new Cell(sudokuGame.getDigit(57), sudokuGame.getShowingBool(57), d7panel, d7panel2, d7panel3, d7button, d7text, 58, row7Panels, colDPanels, box8Panels, d7note);
        e7 = new Cell(sudokuGame.getDigit(58), sudokuGame.getShowingBool(58), e7panel, e7panel2, e7panel3, e7button, e7text, 59, row7Panels, colEPanels, box8Panels, e7note);
        f7 = new Cell(sudokuGame.getDigit(59), sudokuGame.getShowingBool(59), f7panel, f7panel2, f7panel3, f7button, f7text, 60, row7Panels, colFPanels, box8Panels, f7note);
        g7 = new Cell(sudokuGame.getDigit(60), sudokuGame.getShowingBool(60), g7panel, g7panel2, g7panel3, g7button, g7text, 61, row7Panels, colGPanels, box9Panels, g7note);
        h7 = new Cell(sudokuGame.getDigit(61), sudokuGame.getShowingBool(61), h7panel, h7panel2, h7panel3, h7button, h7text, 62, row7Panels, colHPanels, box9Panels, h7note);
        i7 = new Cell(sudokuGame.getDigit(62), sudokuGame.getShowingBool(62), i7panel, i7panel2, i7panel3, i7button, i7text, 63, row7Panels, colIPanels, box9Panels, i7note);
        /* initializing 8 row variables */
        a8 = new Cell(sudokuGame.getDigit(63), sudokuGame.getShowingBool(63), a8panel, a8panel2, a8panel3, a8button, a8text, 64, row8Panels, colAPanels, box7Panels, a8note);
        b8 = new Cell(sudokuGame.getDigit(64), sudokuGame.getShowingBool(64), b8panel, b8panel2, b8panel3, b8button, b8text, 65, row8Panels, colBPanels, box7Panels, b8note);
        c8 = new Cell(sudokuGame.getDigit(65), sudokuGame.getShowingBool(65), c8panel, c8panel2, c8panel3, c8button, c8text, 66, row8Panels, colCPanels, box7Panels, c8note);
        d8 = new Cell(sudokuGame.getDigit(66), sudokuGame.getShowingBool(66), d8panel, d8panel2, d8panel3, d8button, d8text, 67, row8Panels, colDPanels, box8Panels, d8note);
        e8 = new Cell(sudokuGame.getDigit(67), sudokuGame.getShowingBool(67), e8panel, e8panel2, e8panel3, e8button, e8text, 68, row8Panels, colEPanels, box8Panels, e8note);
        f8 = new Cell(sudokuGame.getDigit(68), sudokuGame.getShowingBool(68), f8panel, f8panel2, f8panel3, f8button, f8text, 69, row8Panels, colFPanels, box8Panels, f8note);
        g8 = new Cell(sudokuGame.getDigit(69), sudokuGame.getShowingBool(69), g8panel, g8panel2, g8panel3, g8button, g8text, 70, row8Panels, colGPanels, box9Panels, g8note);
        h8 = new Cell(sudokuGame.getDigit(70), sudokuGame.getShowingBool(70), h8panel, h8panel2, h8panel3, h8button, h8text, 71, row8Panels, colHPanels, box9Panels, h8note);
        i8 = new Cell(sudokuGame.getDigit(71), sudokuGame.getShowingBool(71), i8panel, i8panel2, i8panel3, i8button, i8text, 72, row8Panels, colIPanels, box9Panels, i8note);
        /* initializing 9 row variables */
        a9 = new Cell(sudokuGame.getDigit(72), sudokuGame.getShowingBool(72), a9panel, a9panel2, a9panel3, a9button, a9text, 73, row9Panels, colAPanels, box7Panels, a9note);
        b9 = new Cell(sudokuGame.getDigit(73), sudokuGame.getShowingBool(73), b9panel, b9panel2, b9panel3, b9button, b9text, 74, row9Panels, colBPanels, box7Panels, b9note);
        c9 = new Cell(sudokuGame.getDigit(74), sudokuGame.getShowingBool(74), c9panel, c9panel2, c9panel3, c9button, c9text, 75, row9Panels, colCPanels, box7Panels, c9note);
        d9 = new Cell(sudokuGame.getDigit(75), sudokuGame.getShowingBool(75), d9panel, d9panel2, d9panel3, d9button, d9text, 76, row9Panels, colDPanels, box8Panels, d9note);
        e9 = new Cell(sudokuGame.getDigit(76), sudokuGame.getShowingBool(76), e9panel, e9panel2, e9panel3, e9button, e9text, 77, row9Panels, colEPanels, box8Panels, e9note);
        f9 = new Cell(sudokuGame.getDigit(77), sudokuGame.getShowingBool(77), f9panel, f9panel2, f9panel3, f9button, f9text, 78, row9Panels, colFPanels, box8Panels, f9note);
        g9 = new Cell(sudokuGame.getDigit(78), sudokuGame.getShowingBool(78), g9panel, g9panel2, g9panel3, g9button, g9text, 79, row9Panels, colGPanels, box9Panels, g9note);
        h9 = new Cell(sudokuGame.getDigit(79), sudokuGame.getShowingBool(79), h9panel, h9panel2, h9panel3, h9button, h9text, 80, row9Panels, colHPanels, box9Panels, h9note);
        i9 = new Cell(sudokuGame.getDigit(80), sudokuGame.getShowingBool(80), i9panel, i9panel2, i9panel3, i9button, i9text, 81, row9Panels, colIPanels, box9Panels, i9note);

        /* initialize Cell array */
        cells = new Cell[81];
        /* initialize row 1 of Cell array */
        cells[0] = a1;
        cells[1] = b1;
        cells[2] = c1;
        cells[3] = d1;
        cells[4] = e1;
        cells[5] = f1;
        cells[6] = g1;
        cells[7] = h1;
        cells[8] = i1;
        /* initialize row 2 of Cell array */
        cells[9] = a2;
        cells[10] = b2;
        cells[11] = c2;
        cells[12] = d2;
        cells[13] = e2;
        cells[14] = f2;
        cells[15] = g2;
        cells[16] = h2;
        cells[17] = i2;
        /* initialize row 3 of Cell array */
        cells[18] = a3;
        cells[19] = b3;
        cells[20] = c3;
        cells[21] = d3;
        cells[22] = e3;
        cells[23] = f3;
        cells[24] = g3;
        cells[25] = h3;
        cells[26] = i3;
        /* initialize row 4 of Cell array */
        cells[27] = a4;
        cells[28] = b4;
        cells[29] = c4;
        cells[30] = d4;
        cells[31] = e4;
        cells[32] = f4;
        cells[33] = g4;
        cells[34] = h4;
        cells[35] = i4;
        /* initialize row 5 of Cell array */
        cells[36] = a5;
        cells[37] = b5;
        cells[38] = c5;
        cells[39] = d5;
        cells[40] = e5;
        cells[41] = f5;
        cells[42] = g5;
        cells[43] = h5;
        cells[44] = i5;
        /* initialize row 6 of Cell array */
        cells[45] = a6;
        cells[46] = b6;
        cells[47] = c6;
        cells[48] = d6;
        cells[49] = e6;
        cells[50] = f6;
        cells[51] = g6;
        cells[52] = h6;
        cells[53] = i6;
        /* initialize column G of Cell array */
        cells[54] = a7;
        cells[55] = b7;
        cells[56] = c7;
        cells[57] = d7;
        cells[58] = e7;
        cells[59] = f7;
        cells[60] = g7;
        cells[61] = h7;
        cells[62] = i7;
        /* initialize column H of Cell array */
        cells[63] = a8;
        cells[64] = b8;
        cells[65] = c8;
        cells[66] = d8;
        cells[67] = e8;
        cells[68] = f8;
        cells[69] = g8;
        cells[70] = h8;
        cells[71] = i8;
        /* initialize column I of Cell array */
        cells[72] = a9;
        cells[73] = b9;
        cells[74] = c9;
        cells[75] = d9;
        cells[76] = e9;
        cells[77] = f9;
        cells[78] = g9;
        cells[79] = h9;
        cells[80] = i9;
    }
}