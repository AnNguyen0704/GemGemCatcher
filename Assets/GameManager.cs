using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Button playButton;
    [SerializeField] private Gemfall GemFall;
    [SerializeField] private TimeController TimeController;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(onClickPlayButton);
    }

    // Update is called once per frame
    private void onClickPlayButton()
    {
        GemFall.setIsAllowFall(true);
        
        TimeController.StartCountDownTime();
        playButton.gameObject.SetActive(false);
    }
}
