using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiseaseTimer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 10f;
    float timeLeft;
    private ParticleSystem particleSys;
    public GameObject GameOverText;
    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive (false);
        timerBar = GetComponent<Image> ();
        timeLeft = maxTime;
        particleSys = GameObject.Find("Diseasebar Particles").GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
            if (!particleSys.isPlaying)
            particleSys.Play();
        } else {
            GameOverText.SetActive (true);
            Time.timeScale = 0;
            particleSys.Stop();
        }

        }
    }

