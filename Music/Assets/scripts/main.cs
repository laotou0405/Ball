using UnityEngine;
using System.Collections;
using System;

public class main : MonoBehaviour {

	// Use this for initialization
	GameObject prefab;
	UISprite bg;
    UIButton startBtn;

    void Start()
    {
        //		Instantiate(Resources.Load("main"), position, rotation)

        prefab = (GameObject)Instantiate(Resources.Load("main"), new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));

        bg = (UISprite) gameObject.AddComponent("UISprite");

        UIAtlas atlas = (UIAtlas)Resources.Load("Wooden Atlas", typeof(UIAtlas));

        bg.atlas = atlas;

        bg.spriteName = "sprite2";


        UITexture texture = (UITexture) gameObject.AddComponent("UITexture");
        texture.color = Color.red;

    }


    // Update is called once per frame
    void Update () {
	
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0,0,100,100),)
    }

}
