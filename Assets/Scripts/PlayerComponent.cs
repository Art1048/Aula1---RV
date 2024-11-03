using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerComponent : MonoBehaviour
{
    private int placar;
    private Rigidbody rb;
    public float speed;
    public Text txVitoria1;
    public Text txVitoria2;

    public Text Placar;
    public Button btnReiniciar;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        placar = 0;
        txVitoria1.gameObject.SetActive(false);
        txVitoria2.gameObject.SetActive(false);
        btnReiniciar.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void FixedUpdate()
    {
        float MovimentoHorizontal = Input.GetAxis("Horizontal");
        float MovimentoVertical = Input.GetAxis("Vertical");

        Vector3 forca = new Vector3(MovimentoHorizontal,0,MovimentoVertical);

        rb.AddForce(forca * speed);
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Coletavel")){
            other.gameObject.SetActive(false);
            placar++;
            Placar.text = "Placar: " + placar;
            ExibeFimDeJogo();
        }  
    }

    public void ReiniciarFase() {
        Scene cena = SceneManager.GetActiveScene();
        SceneManager.LoadScene(cena.name);
    }

    private void ExibeFimDeJogo(){
        if (placar == 16){
            txVitoria1.gameObject.SetActive(true);
            txVitoria2.gameObject.SetActive(true);
            btnReiniciar.gameObject.SetActive(true);
        }
    }
}
