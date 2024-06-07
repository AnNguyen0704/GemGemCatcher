using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GemMover : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource audioSource = GetComponent<AudioSource>();

        //play âm thanh t? component ?ó
        audioSource.Play();

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            if (gameObject.CompareTag("gem"))
            {
                ScoreManger.AddScore(1);
            }

            else if (gameObject.CompareTag("EVILGEM"))
            {
                ScoreManger.MinusScore(1);
            }


        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }

    }
}

