using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    //�ε��� ���
    private Slider slider;
    private float nowLoading = 0;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        StartCoroutine(LoadingUpdate());
    }

    private IEnumerator LoadingUpdate()
    {
        slider.value = nowLoading;
        nowLoading += 0.005f; // �ε��� �ӵ�
        yield return new WaitForSeconds(1f);
        if (slider.value == 1)
        {
            SceneManager.LoadScene("GamePlayerScene");
        }
    }
}