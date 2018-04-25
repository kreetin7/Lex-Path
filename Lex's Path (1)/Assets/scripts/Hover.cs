using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour {
    public Texture2D defaultTexture;
    public Texture2D hoverTexture;

    public CursorMode curMode = CursorMode.Auto;
    public Vector2 hotspot = Vector2.zero;
    // Use this for initialization
    void Start () {
        Cursor.SetCursor(defaultTexture, hotspot, curMode);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseEnter()
    {
        if (gameObject.tag == "PathPiece")
        {
            Cursor.SetCursor(hoverTexture, hotspot, curMode);
        }

        if (gameObject.tag == "BouncyPiece")
        {
            Cursor.SetCursor(hoverTexture, hotspot, curMode);
        }
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(defaultTexture, hotspot, curMode);
    }
}
