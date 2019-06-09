using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//[ExecuteInEditMode]
public class Post2 : MonoBehaviour {
    public Material water;
    public Camera cam;
    private int width;
    private int height;
    private RenderTexture rt;
    private Texture2D texture;
    //private void Start()
    //{
    //    width = cam.pixelWidth;
    //    height = cam.pixelHeight;
    //    rt = RenderTexture.GetTemporary(width, height, 0);
    //    cam.targetTexture = rt;

    //}
    [ImageEffectOpaque]
    private void OnRenderImage(RenderTexture source, RenderTexture dest)
    {

        Graphics.Blit(source, dest, water);

    }
    //private void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        texture = new Texture2D(width, height, TextureFormat.ARGB32, false);
    //        RenderTexture.active = rt;
    //        texture.ReadPixels(new Rect(0, 0, width, height), 0, 0);
    //        texture.Apply();
    //        // RenderTexture.ReleaseTemporary(rt);
    //        byte[] bytes = texture.EncodeToPNG();
    //        File.WriteAllBytes("D:\\water.PNG", bytes);
    //    }
    //}
}
