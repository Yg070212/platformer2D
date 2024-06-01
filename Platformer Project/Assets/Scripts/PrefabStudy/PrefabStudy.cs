using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabStudy : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody2D;
    public CircleCollider2D circleCollider2D;
    public Animator animator;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        // GetComponent �ڵ� �ۼ�
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        circleCollider2D = GetComponent<CircleCollider2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
