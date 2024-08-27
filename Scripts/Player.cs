using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    private Animator playerAnim;
    private Rigidbody2D rbPlayer;
    public float speed;
    public int lixo = 5;
    public int lixo2 = 5;
    public int lixo3 = 10;
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        rbPlayer = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalMoviment = Input.GetAxisRaw("Horizontal");
        rbPlayer.velocity = new Vector2(horizontalMoviment * speed, rbPlayer.velocity.y);
        //Debug.Log(horizontalMoviment);
        //transform.position += new Vector3(horizontalMoviment * Time.deltaTime * speed, 0, 0);

        float verticalMoviment = Input.GetAxisRaw("Vertical");
        rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, verticalMoviment * speed);
        //Debug.Log(horizontalMoviment);
        //transform.position += new Vector3(0, verticalMoviment * Time.deltaTime * speed , 0);

        // Animar a caminhada com base no movimento horizontal
        if (horizontalMoviment != 0)
        {
            playerAnim.SetBool("Walk", true);
        }
        else
        {
            playerAnim.SetBool("Walk", false);
        }

        // Animar a caminhada com base no movimento vertical
        if (verticalMoviment != 0)
        {
            playerAnim.SetBool("Walk2", true);
        }
        else
        {
            playerAnim.SetBool("Walk2", false);
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("lixo")) // Verifica se o objeto colidido é uma nota
        {
            Destroy(other.gameObject); // Destrói a nota
            lixo--; // Decrementa o contador de notas
            Debug.Log("Lixo restantes: " + lixo);

            if (lixo == -5) // Verifica se todas as notas foram coletadas
            {
                SceneManager.LoadScene("Fase1.5"); // Carrega a cena final
            }
        }

        if (other.CompareTag("lixo2")) // Verifica se o objeto colidido é uma nota
        {
            Destroy(other.gameObject); // Destrói a nota
            lixo2--; // Decrementa o contador de notas
            Debug.Log("Lixo2 restantes: " + lixo2); 

            if (lixo2 == 0) // Verifica se todas as notas foram coletadas 
            {
                SceneManager.LoadScene("Fase2.5"); // Carrega a cena final
            }  

        }

        if (other.CompareTag("lixo3"))
        {
            Destroy(other.gameObject); // Destrói a nota
            lixo3--; // Decrementa o contador de notas
            Debug.Log("Lixo3 restantes: " + lixo3);

            if (lixo3 == -5)
            {
                SceneManager.LoadScene("Fase3.5");
            }

        }



    }
  

}
