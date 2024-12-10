using UnityEngine;

public class DefectHighlighter : MonoBehaviour
{
    private Renderer surfaceRenderer;

    void Start()
    {
        surfaceRenderer = GetComponent<Renderer>();
    }

    public void HighlightDefect()
    {
        // ��������� ����� ��������� ��� ��������� ��������
        surfaceRenderer.material.color = Color.red;  // ������� ���� ��� ������������ ��������
    }

    public void ResetHighlight()
    {
        // ����� ����� ��������� �� ����������� ���������
        surfaceRenderer.material.color = Color.white;
    }
}
