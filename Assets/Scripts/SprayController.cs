//using UnityEngine;
//using UnityEngine.InputSystem;
//using UnityEngine.XR.Interaction.Toolkit;

//public class SprayController : MonoBehaviour
//{
//    public Animator animator;  // ������ �� ��������� Animator
//    public InputActionProperty sprayAction;  // ������ �� Input Action ��� ����������

//    private bool isSpraying = false;

//    void Update()
//    {
//        // �������� ������� ������ ����� Input Action
//        if (sprayAction.action.ReadValue<float>() > 0.1f && !isSpraying)
//        {
//            StartSpray();
//        }
//        else if (sprayAction.action.ReadValue<float>() <= 0.1f && isSpraying)
//        {
//            StopSpray();
//        }
//    }

//    // ������ �������� ����������
//    void StartSpray()
//    {
//        animator.SetTrigger("SprayTrigger");
//        isSpraying = true;
//    }

//    // ��������� �������� ����������
//    void StopSpray()
//    {
//        isSpraying = false;
//    }
//}

using HTC.UnityPlugin.Vive;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class SprayController : MonoBehaviour
{
    //public Animator animator;  // ������ �� ��������� Animator
    public ParticleSystem sprayParticles;  // ������ �� ��������� Particle System
    public InputActionProperty sprayAction;  // ������ �� Input Action ��� ����������

    public bool isSpraying = false;


    void Start()
    {
        // ���������, ��� �������� � ������� �� �������� ��� ������
        //animator.ResetTrigger("SprayTrigger");
        if (sprayParticles.isPlaying)
        {
            sprayParticles.Stop();  // ������������� ������� ������, ���� ��� ��������
        }
        isSpraying = false;

        Debug.Log("��������� ���������: �������� � ������� �� ������ ���� ���������");
    }

    void Update()
    {
        
    }

    public void Spray()
    {
            Debug.Log("������ ������: �������� ����������");
            StartSpray();
            isSpraying = true;
    }

    public void DontSpray()
    {
        Debug.Log("������ ��������: ������������� ����������");
        StopSpray();
        isSpraying = false;
    }

    public void SetRotation()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
    }

    // ������ �������� ���������� � ������� ������
    void StartSpray()
    {
        //animator.SetTrigger("SprayTrigger");  // ��������� ��������
        sprayParticles.Play();  // ��������� ������� ������
        Debug.Log("�������� � ������� ��������");
    }

    // ��������� �������� ���������� � ������� ������
    void StopSpray()
    {
        sprayParticles.Stop();  // ������������� ������� ������
        Debug.Log("�������� � ������� �����������");
    }
}
