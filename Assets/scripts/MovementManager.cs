using UnityEngine;
using System.Collections;

public class MovementManager : MonoBehaviour
{
    public static MovementManager instance;

    [SerializeField]
    Movement_script[] scriptsToManage;

    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    //For reach time a thing is triggered, disable that object
    //Enable all other objects


    public void EnableTriggers()
    {
        foreach(Movement_script ms in scriptsToManage)
        {
            ms.Active = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
