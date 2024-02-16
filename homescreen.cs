using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class homescreen : MonoBehaviour
{
    public Button playButton;
    public Button easyButton;
    public Button mediumButton;
    public Button hardButton;
    public Button expertButton;

    public GameObject easyPanel;
    public GameObject mediumPanel;
    public GameObject hardPanel;
    public GameObject expertPanel;

    // Start is called before the first frame update
    void Start()
    {
        clearPanels();
        easyButton.onClick.AddListener(()=> {
            clearPanels();
            easyPanel.SetActive(true);
            playButton.onClick.AddListener(()=> {
                SceneManager.LoadScene("Trippy Sudoku");
                updatevalues.difficulty = 0;
            });
        });
        mediumButton.onClick.AddListener(()=> {
            clearPanels();
            mediumPanel.SetActive(true);
            playButton.onClick.AddListener(()=> {
                SceneManager.LoadScene("Trippy Sudoku");
                updatevalues.difficulty = 1;
            });
        });
        hardButton.onClick.AddListener(()=> {
            clearPanels();
            hardPanel.SetActive(true);
            playButton.onClick.AddListener(()=> {
                SceneManager.LoadScene("Trippy Sudoku");
                updatevalues.difficulty = 2;
            });
        });
        expertButton.onClick.AddListener(()=> {
            clearPanels();
            expertPanel.SetActive(true);
            playButton.onClick.AddListener(()=> {
                SceneManager.LoadScene("Trippy Sudoku");
                updatevalues.difficulty = 3;
            });
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void clearPanels() {
        easyPanel.SetActive(false);
        mediumPanel.SetActive(false);
        hardPanel.SetActive(false);
        expertPanel.SetActive(false);
    }
}
