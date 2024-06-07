using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public static void AddScore(int amount) //(int amount) ngh?a là hàm s? ch? nh?n giá tr? là integer, và giá tr? này s? ???c gán vào bi?n có tên amount
    {
        score += amount; //t?ng ?i?m theo giá tr? c?a amount ???c truy?n vào t?i s? ki?n g?i AddScore
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
