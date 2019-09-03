using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationController : MonoBehaviour
{
    public GameObject[] Pokemons;
    public string[] GPSLocations;
    public Transform Trainer;
<<<<<<< HEAD:Scripts/MapScene/LocationController.cs
=======
    public GameObject[] ARLocations;
    public Vector3[] gamePositions;
    public Transform Map;
>>>>>>> parent of 3b0b0e4... replaced LBG with ZoomableMap:Scripts/LocationScene/LocationController.cs

    // Start is called before the first frame update
    void Start()
    {

    }

    // // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:Scripts/MapScene/LocationController.cs
        var ARTriggers = GameObject.FindGameObjectsWithTag("randomBigCharizard");
=======
        var ARTriggers = GameObject.FindGameObjectsWithTag("randomCharizard");
        print(ARTriggers);
        // var ARTriggers = GameObject.FindWithTag("randomCharizard");  //change this to list of possible GameObjects
>>>>>>> parent of 3b0b0e4... replaced LBG with ZoomableMap:Scripts/LocationScene/LocationController.cs

        foreach (var ARTrigger in ARTriggers)
        {
            var distance = Vector3.Distance(ARTrigger.transform.position, Trainer.position);
            if (distance <= 2f)
            // if (distance <= 2f)
            {
                SceneManager.LoadScene("TriggeredARScene");
            }
        }

    }
}
