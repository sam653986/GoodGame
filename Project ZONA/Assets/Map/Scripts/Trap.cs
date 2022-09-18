using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public Sprite good;

    public bool Catch = false;
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        img.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && Catch == true)
        {
            img.gameObject.SetActive(true);
            Movement.moveSpeed += 2.5f;
            Destroy(gameObject);
            Catch = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Player"))
        {
            Catch = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = good;
            Movement.moveSpeed = 0f;
            source.PlayOneShot(clip);
        }
    }
}
