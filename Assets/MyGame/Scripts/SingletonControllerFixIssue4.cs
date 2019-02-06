/* concrete singelton
 * this inherits from the GenericSingleton (a singleton without copying code),   
 * the GenericSingleton fixes the persistency problem and allows lazy instantiation.  
 */
using UnityEngine;

public class SingletonControllerFixIssue4 : GenericSingletonClass<SingletonControllerFixIssue4> {

    private string name = "";

    public string Name
    {
        get
        {
            Debug.Log("get name " + name);
            return name;
        }

        set
        {
            name = value;
            Debug.Log("name set to " + name);
        }
    }
}
