using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public static void AddScore(int amount) //(int amount) ngh?a l� h�m s? ch? nh?n gi� tr? l� integer, v� gi� tr? n�y s? ???c g�n v�o bi?n c� t�n amount
    {
        score += amount; //t?ng ?i?m theo gi� tr? c?a amount ???c truy?n v�o t?i s? ki?n g?i AddScore
    }
    public static void MinusScore(int amount)
    {
        score -= amount;
    }
    // Start is called before the first frame update
    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

    }
}
