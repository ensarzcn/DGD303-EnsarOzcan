using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Fuel":
                Debug.Log("Fuelinyo");
                break;
            case "LaunchPad":
                Debug.Log("Launch");
                break;
            case "Engel":
                Debug.Log("Engel");
                break;
        }


    }
}
