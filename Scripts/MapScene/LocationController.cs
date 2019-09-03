using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationController : MonoBehaviour
{
    public Transform Trainer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // // Update is called once per frame
    void Update()
    {
        var ARTriggers = GameObject.FindGameObjectsWithTag("randomBigCharizard");

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
