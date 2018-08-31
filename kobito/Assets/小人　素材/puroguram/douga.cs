using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(RawImage), typeof(VideoPlayer), typeof(AudioSource))]
public class douga : MonoBehaviour
{
    RawImage image;
    VideoPlayer player;
    float a;

    void Awake()
    {
        image = GetComponent<RawImage>();
        player = GetComponent<VideoPlayer>();
        var source = GetComponent<AudioSource>();
        player.EnableAudioTrack(0, true);
        player.SetTargetAudioSource(0, source);
    }
    
    void Update()
    {
        this.a += Time.deltaTime;
        if (player.isPrepared)
        {
            image.texture = player.texture;
        }
        if (this.a > 25)
        {
            SceneManager.LoadScene("Gameseen");
        }
    }
}