using UnityEngine;
using System.Collections;
using System;

public class main : MonoBehaviour {

	// Use this for initialization
	UISprite bg;
    UIButton startBtn;

    void Start()
    {
        bg = (UISprite) gameObject.AddComponent("UISprite");
        bg.width = 640;
        bg.height = 500;
        UIAtlas atlas = (UIAtlas)Resources.Load("music", typeof(UIAtlas));

        bg.atlas = atlas;

        bg.spriteName = "bg";


        UITexture texture = (UITexture) gameObject.AddComponent("UITexture");
        texture.color = Color.red;

    }


    // Update is called once per frame
    void Update () {
	
	}

    void OnGUI()
    {

    }

}
