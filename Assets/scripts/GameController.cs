using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public player player;
    public float resetTimer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.holdBall == false)
        {
            resetTimer-=Time.deltaTime;
            if (resetTimer <= 0) {
                SceneManager.LoadScene("game");
            }
        }
        
    }
}
