using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public static int scoreAmount;
    private Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
          scoreText = GetComponent<Text>();
          scoreAmount = 0;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = "Score: " + scoreAmount;
    }
}
