using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UiManager : MonoBehaviour {

	// Use this for initialization
    private Dictionary<string, UIAtlas> uiDic;
    private static UiManager instance;

    public static UiManager GetInstance {
        get {
            if (instance == null) {
                instance = new UiManager();
            }
            return instance;
        }
    }

    public UIAtlas GetUIAtlas(string atlasName) {
        if (uiDic == null) {
           uiDic = new Dictionary<string, UIAtlas>();  

           UIAtlas atlas = (UIAtlas) Resources.Load(atlasName, typeof(UIAtlas));

           uiDic.Add(atlasName, atlas);
        }

        return uiDic[atlasName];
    }

}
