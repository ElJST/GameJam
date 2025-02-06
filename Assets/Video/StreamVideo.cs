using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;
    private GameManager manager;
    void Start()
    {
        manager = GameManager.instance;
        StartCoroutine(PlayVideo());
        
    }
    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);

        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
        }

        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
        audioSource.Play();

        // Espera hasta que el video termine
        while (videoPlayer.isPlaying)
        {
            yield return null;
        }

        // Llama a manager.openMainMenu() al finalizar el video
        manager.openMainMenu();
    }
}
