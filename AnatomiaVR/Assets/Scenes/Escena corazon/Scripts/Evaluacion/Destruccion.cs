using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("DestrucCol"))
        {
            Destroy(collision.gameObject);
        }

        void OntriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("DestrucTrig"))

            {
                Destroy(other.gameObject);
            }
        }

        
    }

}
