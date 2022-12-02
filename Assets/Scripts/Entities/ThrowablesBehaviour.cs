using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowablesBehaviour : MonoBehaviour
{
    [Header("References")]
    public ParticleSystem goodHitParticles, badHitParticles;
    public ScoreManager scoreManager;
    public ThrowingBehaviour throwingBehaviour;

    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == collision.collider.tag)
        {
            PlayGoodParticles();
            Destroy(this.gameObject);

            CalculateScore(collision.collider.name);
        }

        else
        {
            PlayBadParticles();
            Destroy(this.gameObject);
        }

        if (throwingBehaviour.amountOfPickups >= 20)
        {
            SceneLoader.Load(SceneLoader.Scene.EndScreenScene);
        }
    }

    private void PlayGoodParticles()
    {
        goodHitParticles.transform.position = this.transform.position;
        goodHitParticles.Play();
    }

    private void PlayBadParticles()
    {
        badHitParticles.transform.position = this.transform.position;
        badHitParticles.Play();
    }

    private void CalculateScore(string possibleScore)
    {
        switch (possibleScore)
        {
            case "Bullseye":
                scoreManager.AddScore(5);
                break;
            case "SecondRing":
                scoreManager.AddScore(3);
                break;
            case "ThirdRing":
                scoreManager.AddScore(2);
                break;
            case "CornerTarget":
                scoreManager.AddScore(8);
                break;
            case "Wall":
                scoreManager.AddScore(1);
                break;
            default:
                break;
        }
    }
}
