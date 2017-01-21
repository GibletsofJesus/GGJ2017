using UnityEngine;
using System.Collections;



public class Movement_script : MonoBehaviour
{
    [System.Serializable]
    public class LightClass
    {

        public Light LightObject;
        [HideInInspector]
        public Vector3 startPosition;
        public Vector3 movement;
    }

    [SerializeField]
    public LightClass[] AlltheLights;
    
    public float seconds = 2f;
    
    public bool Active=true;
    
    void Start()
    {
        foreach(LightClass l in AlltheLights)
        {
            l.startPosition = l.LightObject.transform.position;
        }
    }

    void OnTriggerEnter()
    {
        Debug.Log(Active);
        if (Active)
        {
            MovementManager.instance.EnableTriggers();
            Active = false;
            StartCoroutine(newThingy(seconds));
        }
    }

    void OnTriggerExit()
    {
        
    }

    bool running;

    IEnumerator newThingy(float duration)
    {
        running = true;
        foreach (LightClass l in AlltheLights)
        {
            l.LightObject.intensity = 8;
        }

        float lerpy = 0;
        while (lerpy < duration)
        {
            lerpy += Time.deltaTime;
            //do things
            foreach (LightClass l in AlltheLights)
            {
                l.LightObject.transform.position = Vector3.Lerp(l.startPosition, l.startPosition +  l.movement, lerpy / duration);
            }
            yield return new WaitForEndOfFrame();
        }

        foreach (LightClass l in AlltheLights)
        {
            l.LightObject.intensity = 0;
            l.LightObject.transform.position = l.startPosition;
        }
        
        running = false;
    }
}








        