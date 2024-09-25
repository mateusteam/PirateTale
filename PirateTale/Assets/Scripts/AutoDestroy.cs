using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float timeToDie = 3;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyMyself", timeToDie);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestroyMyself()
    {
        Destroy(gameObject);
    }
}
