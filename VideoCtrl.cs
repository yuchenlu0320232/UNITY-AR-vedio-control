using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoCtrl : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.prepareCompleted += OnVideoPrepareCompleted;
    }

    public void SetFirstFrame()
    {
        videoPlayer.renderMode = VideoRenderMode.APIOnly;
        videoPlayer.playOnAwake = false;
        videoPlayer.Prepare();
    }
    private void OnVideoPrepareCompleted(VideoPlayer source)
    {
        source.Pause();
        
        // Set the current time of the video to the first frame
        source.frame = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayVideo()
    {
        videoPlayer.renderMode = VideoRenderMode.RenderTexture;
        videoPlayer.Play();
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
    }

    public void StopVideo()
    {
        videoPlayer.Stop();
    }
}
