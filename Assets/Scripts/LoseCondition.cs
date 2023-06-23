using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float delayTime;

    bool hasCrashed = false; 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LevelSprite" && !hasCrashed)
        {   
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("reloadScene", delayTime);
        }

       
    }
    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
