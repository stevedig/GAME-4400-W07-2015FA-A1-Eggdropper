using UnityEngine;
using System.Collections;

public class EggCollecter : MonoBehaviour 
{
    PlayerScript myPlayerScript;

		
    void Awake()
    {
        myPlayerScript = transform.parent.GetComponent<PlayerScript>();
    }

	void OnTriggerEnter(Collider col)
    {
        GameObject Egg = col.gameObject;
        Destroy(Egg);

        myPlayerScript.theScore++; //Increase Score


    }
}