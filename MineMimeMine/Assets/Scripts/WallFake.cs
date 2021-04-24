using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFake : MonoBehaviour
{
    private float duration;
    private float timeStep;
    // Start is called before the first frame update
    void Start()
    {
        timeStep = duration;
    }

    // Update is called once per frame
    void Update()
    {
        timeStep -= Time.deltaTime;
        if (timeStep <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetDuration(float _dur)
    {
        duration = _dur;
    }    
}
