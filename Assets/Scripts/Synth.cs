using UnityEngine;

public class Synth : MonoBehaviour
{
    public float frequency;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>(); 
        
        var clip = AudioClip.Create("Sin",44100 * 3,1,44100,false);
        var samples = new float[44100 * 3];

        for (int i = 0; i < samples.Length; i++)
        {
            samples[i] = Mathf.Sin(i / 44100f * Mathf.PI * 2f * frequency);
        }

        clip.SetData(samples, 0);

        source.clip = clip;
        source.Play();
    }
}