using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationController : MonoBehaviour
{
    public Transform Trainer;
<<<<<<< HEAD:Scripts/MapScene/LocationController.cs
<<<<<<< HEAD:Scripts/MapScene/LocationController.cs
    public Transform Map;
=======
>>>>>>> parent of 8b06867... merge fix:Scripts/MapScene/LocationController.cs
=======
>>>>>>> parent of 8b06867... merge fix:Scripts/MapScene/LocationController.cs

    // Start is called before the first frame update
    void Start()
    {

    }

    // // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:Scripts/MapScene/LocationController.cs
<<<<<<< HEAD:Scripts/MapScene/LocationController.cs
        var ARTriggers = GameObject.FindGameObjectsWithTag("randomCharizard");
=======
        var ARTriggers = GameObject.FindGameObjectsWithTag("randomBigCharizard");
>>>>>>> parent of 8b06867... merge fix:Scripts/MapScene/LocationController.cs
=======
        var ARTriggers = GameObject.FindGameObjectsWithTag("randomBigCharizard");
>>>>>>> parent of 8b06867... merge fix:Scripts/MapScene/LocationController.cs

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
