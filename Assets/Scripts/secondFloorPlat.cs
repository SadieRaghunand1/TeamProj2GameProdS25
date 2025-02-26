using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondFloorPlat : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            this.gameObject.GetComponent<Collider>().isTrigger = false;
        }
    }
}
