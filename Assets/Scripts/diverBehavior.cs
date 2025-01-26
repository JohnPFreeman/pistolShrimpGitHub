using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class diverBehavior : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject shrimp;
    public bool hit;
    Animator animator;

    [SerializeField] private AudioClip death1;
    [SerializeField] private AudioClip death2;
    [SerializeField] private AudioClip death3;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        hit = false;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //print("object has entered");
        if (other.gameObject.CompareTag("bubble"))
        {
            //print("bubble found");    
            
            StartCoroutine(Pause());
        }

    }

    IEnumerator Pause()
    {
        animator.SetTrigger("Hit");
        animator.SetBool("Hit", true);
        hit = true;
        audioSource.pitch = UnityEngine.Random.Range(0.6f, 1.4f);
        int rand = UnityEngine.Random.Range(0, 3);
        if (rand == 0)
        {
            //audioSource.clip = death1;
            AudioSource.PlayClipAtPoint(death1, transform.position, 1f);
        }
        else if (rand == 1)
        {
            //audioSource.clip = death2;
            AudioSource.PlayClipAtPoint(death2, transform.position, 1f);
        }
        else
        {
            //audioSource.clip = death3;
            AudioSource.PlayClipAtPoint(death3, transform.position, 1f);
        }

        //audioSource.Play();

        yield return new WaitForSeconds(5.0f);

        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if (!hit)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y, 0), speed * Time.deltaTime);
        } else
        {
           // transform.position = -1*Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y, 0), speed / 3 * Time.deltaTime);
        }
        
        //transform.position = new Vector3(transform.position.x, 1.435203f, transform.position.z);
        transform.LookAt(new Vector3(0.0f, transform.position.y, 0.0f));

        if (Vector3.Distance(transform.position, new Vector3(0.0f, 0.6553028f, 0.0f)) <= 0.5f)
        {
            //print("DIE");
            SceneManager.LoadScene(2);
        }
    }
}
