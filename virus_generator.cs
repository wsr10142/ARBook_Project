using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus_generator : MonoBehaviour
{
    Dictionary<string, int> virus_dic = new Dictionary<string, int>();
    public GameObject gameobject;
    public GameObject virus;
    public GameObject virusPrefab_toilet;
    public GameObject virusPrefab_faucet;
    public GameObject virusPrefab_keyboard;
    public GameObject virusPrefab_refrigerator;
    public GameObject virusPrefab_towel;
    public GameObject virusPrefab_bed;
    public Vector3 go = new Vector3(0, 0, 0);
    float span = 0.5f;
    float delta = 0;
    int count = 0;
    int virus_count = 50;
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    bool flag4 = false;
    bool flag5 = false;
    bool flag6 = false;

    /*
    //«Ø¥ß¦r¨å
    private void CreateDictionary()
    {
        virus_dic.Add("toilet", 20);
        virus_dic.Add("faucet", 10);
        virus_dic.Add("keyboard", 25);
        virus_dic.Add("refrigerator", 20);
        virus_dic.Add("towel", 30);
        virus_dic.Add("bed", 20);
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        //CreateDictionary();

        gameobject = GameObject.Find("Toilet");

        //virus_count = virus_dic["toilet"];
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("count:" + virus_count);

        this.delta += Time.deltaTime;

        if (this.delta > this.span && count <= virus_count)
        {
            this.delta = 0;
            virus = Instantiate(virusPrefab_toilet) as GameObject;
            float px = Random.Range(gameobject.transform.position.x - 300.0f, gameobject.transform.position.x + 300.0f);
            float py = Random.Range(gameobject.transform.position.y - 150.0f, gameobject.transform.position.y + 300.0f);
            float pz = Random.Range(0, gameobject.transform.position.z + 50.0f);
            virus.transform.position = new Vector3(px, py, pz);
            count += 1;
        }

        /*
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
                    flag1 = true;
                }
                else if (hit.transform.name == "play_pause_one" && flag1 == true)
                {
                    flag1 = false;
                }

                
                if (hit.transform.name == "play_pause_two" && flag2 == false)
                {
                    flag2 = true;
                }
                else if (hit.transform.name == "play_pause_two" && flag2 == true)
                {
                    flag2 = false;
                }

                if (hit.transform.name == "play_pause_three" && flag3 == false)
                {
                    flag3 = true;
                }
                else if (hit.transform.name == "play_pause_three" && flag3 == true)
                {
                    flag3 = false;
                }

                if (hit.transform.name == "play_pause_four" && flag4 == false)
                {
                    flag4 = true;
                }
                else if (hit.transform.name == "play_pause_four" && flag4 == true)
                {
                    flag4 = false;
                }

                if (hit.transform.name == "play_pause_five" && flag5 == false)
                {
                    flag5 = true;
                }
                else if (hit.transform.name == "play_pause_five" && flag5 == true)
                {
                    flag5 = false;
                }

                if (hit.transform.name == "play_pause_six" && flag6 == false)
                {
                    flag6 = true;
                }
                else if (hit.transform.name == "play_pause_six" && flag6 == true)
                {
                    flag6 = false;
                }
                
            }
        }
        
        if(flag1 == true)
        {
            gameobject = GameObject.Find("Toilet");

            Debug.Log("count:" + virus_count);

            this.delta += Time.deltaTime;

            if (this.delta > this.span && count <= virus_count)
            {
                this.delta = 0;
                virus = Instantiate(virusPrefab_toilet) as GameObject;
                float px = Random.Range(gameobject.transform.position.x - 100.0f, gameobject.transform.position.x + 100.0f);
                float py = Random.Range(gameobject.transform.position.y - 200.0f, gameobject.transform.position.y + 200.0f);
                float pz = Random.Range(0, gameobject.transform.position.z + 50.0f);
                virus.transform.position = new Vector3(px, py, pz);
                count += 1;
            }
        }

        if(flag1 == false)
        {
            Destroy(virus.gameObject);
        }

        if (flag2 == true)
        {
            gameobject = GameObject.Find("Faucet");

            Debug.Log("count:" + virus_count);

            this.delta += Time.deltaTime;

            if (this.delta > this.span && count <= virus_count)
            {
                this.delta = 0;
                virus = Instantiate(virusPrefab_faucet) as GameObject;
                float px = Random.Range(gameobject.transform.position.x - 100.0f, gameobject.transform.position.x + 100.0f);
                float py = Random.Range(gameobject.transform.position.y - 200.0f, gameobject.transform.position.y + 200.0f);
                float pz = Random.Range(0, gameobject.transform.position.z + 50.0f);
                virus.transform.position = new Vector3(px, py, pz);
                count += 1;
            }
        }

        if (flag3 == true)
        {
            gameobject = GameObject.Find("Keyboard");

            Debug.Log("count:" + virus_count);

            this.delta += Time.deltaTime;

            if (this.delta > this.span && count <= virus_count)
            {
                this.delta = 0;
                virus = Instantiate(virusPrefab_keyboard) as GameObject;
                float px = Random.Range(gameobject.transform.position.x - 100.0f, gameobject.transform.position.x + 100.0f);
                float py = Random.Range(gameobject.transform.position.y - 200.0f, gameobject.transform.position.y + 200.0f);
                float pz = Random.Range(0, gameobject.transform.position.z + 50.0f);
                virus.transform.position = new Vector3(px, py, pz);
                count += 1;
            }
        }

        if (flag4 == true)
        {
            gameobject = GameObject.Find("Refrigerator");

            Debug.Log("count:" + virus_count);

            this.delta += Time.deltaTime;

            if (this.delta > this.span && count <= virus_count)
            {
                this.delta = 0;
                virus = Instantiate(virusPrefab_refrigerator) as GameObject;
                float px = Random.Range(gameobject.transform.position.x - 100.0f, gameobject.transform.position.x + 100.0f);
                float py = Random.Range(gameobject.transform.position.y - 200.0f, gameobject.transform.position.y + 200.0f);
                float pz = Random.Range(0, gameobject.transform.position.z + 50.0f);
                virus.transform.position = new Vector3(px, py, pz);
                count += 1;
            }
        }

        if (flag5 == true)
        {
            gameobject = GameObject.Find("Towel");

            Debug.Log("count:" + virus_count);

            this.delta += Time.deltaTime;

            if (this.delta > this.span && count <= virus_count)
            {
                this.delta = 0;
                virus = Instantiate(virusPrefab_towel) as GameObject;
                float px = Random.Range(gameobject.transform.position.x - 100.0f, gameobject.transform.position.x + 100.0f);
                float py = Random.Range(gameobject.transform.position.y - 200.0f, gameobject.transform.position.y + 200.0f);
                float pz = Random.Range(0, gameobject.transform.position.z + 50.0f);
                virus.transform.position = new Vector3(px, py, pz);
                count += 1;
            }
        }

        if (flag6 == true)
        {
            gameobject = GameObject.Find("Bed");

            Debug.Log("count:" + virus_count);

            this.delta += Time.deltaTime;

            if (this.delta > this.span && count <= virus_count)
            {
                this.delta = 0;
                virus = Instantiate(virusPrefab_bed) as GameObject;
                float px = Random.Range(gameobject.transform.position.x - 100.0f, gameobject.transform.position.x + 100.0f);
                float py = Random.Range(gameobject.transform.position.y - 200.0f, gameobject.transform.position.y + 200.0f);
                float pz = Random.Range(0, gameobject.transform.position.z + 50.0f);
                virus.transform.position = new Vector3(px, py, pz);
                count += 1;
            }
        }

        Debug.DrawLine(Camera.main.transform.position, go, color);
        */
    }
}
