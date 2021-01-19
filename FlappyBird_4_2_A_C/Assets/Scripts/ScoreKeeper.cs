using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField]
    private int _currentScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        //_currentScore + 1
        //_currentScore += 1
        _currentScore++;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + _currentScore.ToString();
    }
}
