using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFromFile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AssetBundle ab = AssetBundle.LoadFromFile("AssetBundles/scene/ball.unity3d");
        
        string[] names = ab.GetAllAssetNames();
        
        Debug.Log(names);
        foreach (string name in names)
        {
            Debug.Log(name);
        }
        GameObject o = ab.LoadAsset<GameObject>("ball");
        Instantiate(o);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
