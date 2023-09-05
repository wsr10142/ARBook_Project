using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_control : MonoBehaviour
{
    public Vector3 go = new Vector3(0, 0, 0);
    public AudioSource audioSource;
    public AudioClip[] Audios;
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    bool flag4 = false;
    bool flag5 = false;
    bool flag6 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Color color = new Color(255.0f, 0.0f, 1.0f);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawLine(Camera.main.transform.position, hit.transform.position, color);
                go = hit.transform.position;

                if (hit.transform.name == "play_pause_one" && flag1 == false)
                {
                    audioSource.clip = Audios[0];
                    audioSource.Play();
                    flag1 = true;
                }
                else if(hit.transform.name == "play_pause_one" && flag1 == true)
                {
                    audioSource.clip = Audios[0];
                    audioSource.Stop();
                    flag1 = false;
                }

                if (hit.transform.name == "play_pause_two" && flag2 == false)
                {
                    audioSource.clip = Audios[1];
                    audioSource.Play();
                    flag2 = true;
                }
                else if (hit.transform.name == "play_pause_two" && flag2 == true)
                {
                    audioSource.clip = Audios[1];
                    audioSource.Stop();
                    flag2 = false;
                }

                if (hit.transform.name == "play_pause_three" && flag3 == false)
                {
                    audioSource.clip = Audios[2];
                    audioSource.Play();
                    flag3 = true;
                }
                else if (hit.transform.name == "play_pause_three" && flag3 == true)
                {
                    audioSource.clip = Audios[2];
                    audioSource.Stop();
                    flag3 = false;
                }

                if (hit.transform.name == "play_pause_four" && flag4 == false)
                {
                    audioSource.clip = Audios[3];
                    audioSource.Play();
                    flag4 = true;
                }
                else if (hit.transform.name == "play_pause_four" && flag4 == true)
                {
                    audioSource.clip = Audios[3];
                    audioSource.Stop();
                    flag4 = false;
                }

                if (hit.transform.name == "play_pause_five" && flag5 == false)
                {
                    audioSource.clip = Audios[4];
                    audioSource.Play();
                    flag5 = true;
                }
                else if (hit.transform.name == "play_pause_five" && flag5 == true)
                {
                    audioSource.clip = Audios[4];
                    audioSource.Stop();
                    flag5 = false;
                }

                if (hit.transform.name == "play_pause_six" && flag6 == false)
                {
                    audioSource.clip = Audios[5];
                    audioSource.Play();
                    flag6 = true;
                }
                else if (hit.transform.name == "play_pause_six" && flag6 == true)
                {
                    audioSource.clip = Audios[5];
                    audioSource.Stop();
                    flag6 = false;
                }

            }
        }

        Debug.DrawLine(Camera.main.transform.position, go, color);
    }
}
