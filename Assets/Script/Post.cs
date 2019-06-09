using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Post : MonoBehaviour {
    public Material mat;
    private Camera cam;
    private Vector2 pos;
	void Start () {
        cam = this.GetComponent<Camera>();
	}
    private void Update()
    {
        pos = new Vector2(Input.mousePosition.x / cam.pixelWidth, Input.mousePosition.y / cam.pixelHeight);
    }
    [ImageEffectOpaque]
    private void OnRenderImage(RenderTexture source, RenderTexture dest)
    {
        mat.SetVector("pos1", pos);
        Graphics.Blit(source, dest, mat);
    }
}
