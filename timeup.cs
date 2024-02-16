using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class timeup : MonoBehaviour
{
    public Button playAdButton;
    public Button endGameButton;

    // Start is called before the first frame update
    void Start()
    {
        playAdButton.onClick.AddListener(()=> {
            SceneManager.LoadScene("Advertisement");
        });

        endGameButton.onClick.AddListener(()=> {
            SceneManager.LoadScene("Trippy Score");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
