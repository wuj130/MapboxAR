using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RecenterController : MonoBehaviour
{
    public Camera cam;
    public Transform Player;
    public void Recenter()
    {
        cam.transform.position = Player.localPosition;
        // SceneManager.LoadScene("Location-basedGame");
    }
    
}
