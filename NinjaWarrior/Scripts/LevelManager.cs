using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;
    public Transform player;

    public int score;
    public int levelItems;
    public AudioClip[] levelSounds; 
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(AudioClip sound, Vector3 ownerPos)
    {
        //now we play the sounds
        GameObject obj = SoundFXPooler.current.GetPooledObject();
        AudioSource audio = obj.GetComponent<AudioSource>();

        obj.transform.position = ownerPos;
        obj.SetActive(true);
        audio.PlayOneShot(sound);


        //hang on how would we knoe the audio clip is finished? 
        //that is why we use StartCoroutine to check every 0.5f sec
        StartCoroutine(DisableSound(audio));    


    }

    IEnumerator DisableSound(AudioSource audio)
    {
        
        while (audio.isPlaying)
            yield return new WaitForSeconds(0.5f);
        audio.gameObject.SetActive(false);  
    }
}
