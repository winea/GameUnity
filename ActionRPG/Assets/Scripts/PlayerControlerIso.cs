using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlerIso : MonoBehaviour {

    public float moveSpeed;

    private Animator anim;

    // Use this for initialization
    void Start()
    {
        //recebe a animacao
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //eixo horizontal se for negativo ira esq positivo direita
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //faz se mover declarei o x
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));

        }
        //eixo vertical
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //faz se mover declarei o y
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));

        }
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }
}
