using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public GameObject targets;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.text = "score = "+score;
    } 

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnTriggerEnter2D(Collider2D targets){
        if(targets.tag == "Enemy"){
            score--;
            ScoreText.text = " score = "+score;
            Destroy(targets.gameObject);
        }
        else if (targets.tag == "Heart"){
            score ++;
            ScoreText.text = " score = "+score;
            Destroy(targets.gameObject);
        }
    }

}
