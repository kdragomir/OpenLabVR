using UnityEngine;
using System.Collections;

public class destrub : MonoBehaviour
{
    //Particle systems
    public ParticleSystem particles;
    public ParticleSystem particle2;

    //The destroyed version of the enviorment
    public GameObject destoyed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void dest()
    {
        //Spawns the shattering effectg h  
        Instantiate(destoyed, transform.position, transform.rotation);
        //Removes the current object
        Destroy(gameObject);

    }
}
