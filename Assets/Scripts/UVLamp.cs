using UnityEngine;

public class UVLamp : MonoBehaviour
{
    public DefectoscopyProcess defectoscopyProcess;

    public Transform ra;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TargetSurface"))  // ���������, ��� ����� ���������� �� ������ �����������
        {
            defectoscopyProcess.UseUVLamp();  // ���������� �������� � ������� ��-�����
        }
    }

    private void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(ra.position, transform.right);
        if (Physics.Raycast(ra.position, transform.right, out hit))
        {
            Debug.Log(hit.transform.gameObject.tag);
            if (hit.transform.gameObject.tag == "Finish" && gameObject.GetComponent<SprayController>().isSpraying)
            {
                Debug.Log("Yahoo");
                defectoscopyProcess.UseUVLamp();
            }
        }
    }
}
