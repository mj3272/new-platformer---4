using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private AudioSource goalSound;
    [SerializeField] private AudioSource music;

    private bool isComplete = false;

    private void Start()
    {
        goalSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !isComplete)
        {
            music.Stop();
            goalSound.Play();
            isComplete = true;
            Invoke("CompleteLevel", 6f);
        }
    }


    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
