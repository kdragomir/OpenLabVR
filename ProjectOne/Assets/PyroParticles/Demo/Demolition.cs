using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demolition : MonoBehaviour
{
    public float delay = 3f; // similar to what a delay sounds like
    float countD; //The countdown of the explosion
    bool exploded = false;// We need one explosion not multiple

    public float force = 5; //The amount of force used to explode
    public float radius = 5; //The blast radius
    public GameObject explosionEff;// The explosion object

    /// <summary>
    /// The things that get initalized
    /// </summary>

    // Use this for initialization
    void Start()
    {
        countD = delay;
    }

    /// <summary>
    /// Updates the frames of enviorment
    /// </summary>
    // Update is called once per frame

    void Update()
    {
        countD = Time.deltaTime;
        if (countD <= 0f && !exploded)
        {
            explode();
            exploded = true;
        }
    }
    /// <summary>
    /// This method will be called for exploding purposes
    /// </summary>

    void explode()
    {
        Instantiate(explosionEff, transform.position, transform.rotation);
        //This will show the effect
        //For other objects
        //Adds the forces
        //Damage
        Collider[] colliderss = Physics.OverlapSphere(transform.position, radius); //Creates a vector of the colliding objects
        foreach (Collider nearbyObject in colliderss)
        { //Checks to see if any of the nearby objects are effected by the force
            Rigidbody ru = nearbyObject.GetComponent<Rigidbody>(); //The 
            if (ru != null)
            { ///Checks to see if the object exists
                ru.AddExplosionForce(force, transform.position, radius); //The exploding force
            }
            destrub destr = nearbyObject.GetComponent<destrub>();
            if (destr != null){
                destr.dest(); // The destruction of the object
            }
            //Removal of the stuff
            DestroyObject(gameObject); //Removes the chemical compound
        }
    }
}
