using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    private void OnCollisionEnter (Collision other)
    {
        RestartLevel(other);
    }

    void RestartLevel(Collision _other)
    {
        if(_other.gameObject.layer == 7)
        {
            int _scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(_scene);
        }
    }
}
