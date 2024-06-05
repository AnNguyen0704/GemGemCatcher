using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private int totalTime;

    private int currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void doEndTime() 
    {
        Debug.Log("het gio");
        Time.timeScale = 0;
        
    }
    private IEnumerator countdown()
    {
        currentTime = totalTime;
        while (currentTime > 0) 
        {
            yield return new WaitForSeconds(1f);
            currentTime--;// currentTime = currentTime -1
            timeText.text = currentTime.ToString();
        }
        doEndTime();
    }
    public void StartCountDownTime()
    {
        StartCoroutine( countdown());
        

    }
}
