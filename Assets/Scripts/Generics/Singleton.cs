using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T instance;

    public static T Instance
    {
        get
        { 
            if(instance == null)
            {
                var singletonObject = new GameObject();
                instance = singletonObject.AddComponent<T>();
                singletonObject.name = typeof(T).ToString();
                DontDestroyOnLoad(singletonObject);
            }
            return instance;
        }
    }
}
