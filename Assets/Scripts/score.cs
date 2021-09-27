using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public static score instance;

    public Text scoreText;
    public int scores = 0;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = scores.ToString();
    }

    public void AddPoints()
    {
        scores ++;
        scoreText.text = scores.ToString();
    }
}
