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
        
        // 将视频的当前时间设置为第一帧
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
