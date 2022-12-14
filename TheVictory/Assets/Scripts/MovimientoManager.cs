using UnityEngine;
using UnityEngine.AI;


public class MovimientoManager : MonoBehaviour
{
    public AudioSource _audio;
    public LayerMask capaTransitable;
    private NavMeshAgent miAgente;
    private Ray miRayo;
    private RaycastHit infomacionDelRayo;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        miAgente = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            miRayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(miRayo, out infomacionDelRayo, 100, capaTransitable))
            {
                //animator.SetInteger("Bool", 0);
                animator.SetTrigger("Caminar");
                miAgente.SetDestination(infomacionDelRayo.point);
                _audio.Play();
            }
        }
        //animator.SetInteger("Bool", 1);
        
    }
}
