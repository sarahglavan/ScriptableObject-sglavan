using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {

    private InputField objName;
    private TextMeshProUGUI tmpName;


    public NameData nameData;
    public SceneLoader sceneLoader;

    private void Start()
    {
        objName = FindObjectOfType<InputField>();
    }

    public void SaveName()
    {
        //SingletonControllerFixIssue4.Instance.Name =  objName.text;
        //SingletonController.instance.Name = objName.text;
        nameData.name = objName.text;
        sceneLoader.LoadNextScene();

    }

    public void LoadName()
    {
        if(tmpName == null)
        {
            tmpName = GameObject.Find("TMPName").GetComponent<TextMeshProUGUI>();
        }

        //tmproName.text = SingletonControllerFixIssue4.Instance.Name;
        tmpName.text = SingletonController.instance.Name;
        tmpName.text = nameData.name;
        //switch (singletonType)
        //{
        //    case SingletonTypes.SINGLETONSIMPLE:
        //        Debug.Log("Singleton simple is choosen");
        //        break;
        //    case SingletonTypes.SINGLETONFIX4:
        //        Debug.Log("Singleton FIX4 is choosen");
        //        tmproName.text = SingletonControllerFixIssue4.Instance.Name;
        //        break;

        //}
    }
}
