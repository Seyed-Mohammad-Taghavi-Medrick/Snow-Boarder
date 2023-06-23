using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem skiEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "LevelSprite")
        {
            skiEffect.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "LevelSprite")
        {
            skiEffect.Stop();
        }
    }
}
