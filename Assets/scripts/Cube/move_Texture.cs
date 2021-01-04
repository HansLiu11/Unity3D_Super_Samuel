using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_Texture : MonoBehaviour {
    [SerializeField] private float scrollspeed = 0.1f;
    Renderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveThis = Time.time * scrollspeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(moveThis, 0));
	}
}
