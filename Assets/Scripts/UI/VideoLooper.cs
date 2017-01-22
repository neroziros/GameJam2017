using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VideoLooper : MonoBehaviour
{
    public RawImage Image;

	// Use this for initialization
	void OnEnable () {
        var video = (MovieTexture)this.Image.mainTexture;
        video.Stop();
        video.Play();
	}
	

}
