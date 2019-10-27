using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject gameOverText, restartButton;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void OnCollisionEnter3D (Collision col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
