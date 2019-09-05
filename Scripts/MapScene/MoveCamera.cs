using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveCamera : MonoBehaviour
{
    public Camera cam;
    public Transform Player;
    public void Recenter()
    {
        cam.ScreenToWorldPoint(Player.localPosition);
        // SceneManager.LoadScene("Location-basedGame");
    }
    
}
