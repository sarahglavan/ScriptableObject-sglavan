/* lazy singleton 
 * this fixes the persistency problem (across scenes) and in addition the singleton object must not be present in the hierarchy (lazy instantiation).  
 */
using UnityEngine;

public class SingeltonControllerFixIssue2and3 : MonoBehaviour {

    private static SingeltonControllerFixIssue2and3 instance = null;

    public static SingeltonControllerFixIssue2and3 Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SingeltonControllerFixIssue2and3>();
                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "SingeltonControllerFixIssue2and3";
                    instance = go.AddComponent<SingeltonControllerFixIssue2and3>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
