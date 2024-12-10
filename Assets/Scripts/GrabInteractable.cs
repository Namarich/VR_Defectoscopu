using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class GrabInteractable : XRGrabInteractable
{
    // ���� ����� ����������, ����� ������ ����
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        // ����� ����� �������� �������������� �������� ��� ������ �������
        Debug.Log("������ ����: " + gameObject.name);
    }

    // ���� ����� ����������, ����� ������ �������
    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);

        // ���������, �� ���� �� �������������� ��������
        if (!args.isCanceled)
        {
            // �������� ��� ���������� �������
            Debug.Log("������ �������: " + gameObject.name);
        }
    }
}
