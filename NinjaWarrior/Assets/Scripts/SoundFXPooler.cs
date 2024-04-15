using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXPooler : MonoBehaviour
{
    //we make our class static, so we call it from anywhere by class name, without making an instance of it with new keyword
    //the object pooling is good for performance and optimization. 
    //the idea of this class is the instantiate some object and deactivate them, and then we activate them later,
    //so that we dont always always instantiate one new and one new so on... that is not good for game performance.
    //if you notice we will use always the same amount of the objects if we want more then we extend abit more.
    public static SoundFXPooler current;
    public GameObject pooledObject;
    public int pooledAmount = 10;
    public bool willGrow = true;

    public List<GameObject> pooledObjects;

    void Awake()
    {
        current = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //the idea here when when this pooling script starts, we instanctiate the pooledObjects list,
        //then we loop through pooledAmount we make 10 objects of pooledObject
        //and deactivate all the pooledObject and put them to our list.
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }

    }

    
    public GameObject GetPooledObject()
    {
        // here we loop through pooledObjects which are deactivate in the start.
        // we loop and we say get the one which is not active,
        // if all are active then willGrow is true which will extend more objects  
        for (int i = 0; i < pooledObjects.Count; i++)
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];

        if (willGrow)
        {
            GameObject obj = Instantiate(pooledObject);
            pooledObjects.Add(obj);
            return obj;
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}