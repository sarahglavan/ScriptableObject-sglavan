/* This is the simplest singleton implementation, but it has some issues:
 * 1) Singleton is not persistent across the Unity scenes.
 * 2) All the executable code must be attached to GameObject in the hierarchy.
 * 3) Whenever we need a class to be a singlton we have to copy the singleton mechanic in Awake().
 */
 using UnityEngine;

public class SingletonController : MonoBehaviour {

    public static SingletonController instance;

    private string name = "empty";

    public string Name
    {
        get
        {
            Debug.Log("singletoncontroller get name " + name);
            return name;
        }

        set
        {
            name = value;
            Debug.Log("singletoncontroller name set to " + name);
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Destroy SingeltonController " + gameObject.name);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Assign this instance SingeltonController " + gameObject.name);
            instance = this;
        }
    }
}
