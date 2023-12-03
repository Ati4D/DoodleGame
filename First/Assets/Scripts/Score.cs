using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreTxt;
    [SerializeField] private TMP_Text gameOverTxt;
    [SerializeField] private Transform camera;
    [SerializeField] private Transform doodler;

    private int yCamera, yDoodler, maxScore = 0;
    [SerializeField] private int yPositionDeath;


    void Start()
    {
        gameOverTxt.gameObject.SetActive(false);
    }

    void LateUpdate()
    {
        yDoodler = (int)doodler.position.y;
        yCamera = (int)camera.position.y;

        if(yDoodler < (yCamera - yPositionDeath))
        {
            gameOverTxt.gameObject.SetActive(true);

            if(Input.GetKeyUp(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if(Input.GetKeyUp(KeyCode.Q))
            {
                Application.Quit();
            }
        }

        if(maxScore < yDoodler)
        {
            maxScore = yDoodler;
            scoreTxt.text = maxScore.ToString();
        }
        
    }
}
