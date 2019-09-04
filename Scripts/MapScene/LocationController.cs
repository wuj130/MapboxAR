using System.Collections;
using System.Collections.Generic;
using Mapbox.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;

public class LocationController : MonoBehaviour
{
    public Transform Player;

    public AbstractMap Map;
    // public string[] _locationStrings;
    // public float _spawnScale = 5f;
    // public GameObject _markerPrefab;


    // // Unsure
	// Vector2d[] _locations;
	// List<GameObject> _spawnedObjects;

    
    // void PlaceARMarkers()
	// {
	// 	void Update()
	// 	{
	// 		int count = _spawnedObjects.Count;
	// 		for (int i = 0; i < count; i++)
	// 		{
	// 			var spawnedObject = _spawnedObjects[i];
	// 			var location = _locations[i];
	// 			spawnedObject.transform.localPosition = _map.GeoToWorldPosition(location, true);
	// 			spawnedObject.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
	// 		}
	// 	}
    // }

    void Start()
    {
        // _locations = new Vector2d[_locationStrings.Length];
        // _spawnedObjects = new List<GameObject>();
        // for (int i = 0; i < _locationStrings.Length; i++)
        // {
        //     var locationString = _locationStrings[i];
        //     _locations[i] = Conversions.StringToLatLon(locationString);
        //     var pos = Map.GeoToWorldPosition(_locations[i], true);
        //     var instance = Instantiate(_markerPrefab, pos, new Quaternion());
        //     // instance.transform.localPosition = Map.GeoToWorldPosition(_locations[i], true);
        //     instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
        //   _spawnedObjects.Add(instance);
		// } 
    }

    // // Update is called once per frame
    void Update()
    {
        var ARTriggers = GameObject.FindGameObjectsWithTag("randomCharizard");
        foreach (var ARTrigger in ARTriggers)
        {
            var distance = Vector3.Distance(ARTrigger.transform.position, Player.position);
            if (distance <= 3f)
            {
                SceneManager.LoadScene("TriggeredARScene");
            }
        }

    }
}
