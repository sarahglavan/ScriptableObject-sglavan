/* persistent singleton 
 * this fixes the persistency problem (across scenes)
 */
using UnityEngine;

public class SingeltonControllerFixIssue1 : MonoBehaviour {

    public static SingeltonControllerFixIssue1 instance;

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
