using UnityEngine;
using System.Collections;

/// <summary>
/// Replace the given texture (usually our own) with a texture to be rendered by the given camera.
/// You may supply a renderTexture to use, or one will be ceated.
///
/// by Matt "Trip" Maker, Monstrous Company :: http://monstro.us
///
/// </summary>
public class TextureFromCamera : MonoBehaviour
{

    public Camera cam;
    public Transform target;
    public RenderTexture renderTexture;
    public Vector2 textureSize = new Vector2(512, 512);
    public int depth = 16;

    void Reset()
    {
        if (!cam) cam = Camera.main;
        if (!target) target = transform;
    }

    void Awake()
    {
        Reset();
    }

    IEnumerator Start()
    {
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;

        if ((depth != 0) && (depth != 16) && (depth != 24))
        {
            //Debug.LogError(this + " depth must be one of 0, 16, 24");
        }
        if (!renderTexture)
        {
            renderTexture = new RenderTexture((int)textureSize.x, (int)textureSize.y, depth);//depth must be one of 0, 16, 24
            renderTexture.name = "TextureFromCamera_" + cam.name; //optional, but nice
            renderTexture.Create();
            //Debug.Log(renderTexture.depth + " width " + renderTexture.width + " height " + renderTexture.height);
        }
        cam.targetTexture = renderTexture;
        target.GetComponent<Renderer>().material.mainTexture = renderTexture;
    }

    void OnEnable()
    {
        Reset();
    }

    void OnDisable()
    {
        renderTexture.DiscardContents();
        renderTexture.Release();
    }
}