using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationController : MonoBehaviour
{
    public GameObject[] Pokemons;
    public string[] GPSLocations;
    public Transform Trainer;
    public GameObject[] ARLocations;
    public Vector3[] gamePositions;
    public Transform Map;

    // Start is called before the first frame update
    void Start()
    {

    }

    // // Update is called once per frame
    void Update()
    {
        var ARTriggers = GameObject.FindGameObjectsWithTag("randomCharizard");
        print(ARTriggers);
        // var ARTriggers = GameObject.FindWithTag("randomCharizard");  //change this to list of possible GameObjects

        foreach (var ARTrigger in ARTriggers)
        {
            var distance = Vector3.Distance(ARTrigger.transform.position, Trainer.position);
            if (distance <= 2f)
            {
                SceneManager.LoadScene("TriggeredARScene");
            }
        }

    }
}
