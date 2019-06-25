using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{   
    //En instanse av denne klassen
    private static ManagerScript instance;
    public Vector2 lastCheckPoint;

    //Awake kalles rett før start (før noe skjer)
    private void Awake()
    {
       if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
