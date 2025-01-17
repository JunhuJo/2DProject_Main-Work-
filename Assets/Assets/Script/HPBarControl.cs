using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class HPBarControl : MonoBehaviour
{
    private Slider slider;
    
    private int maxHp = GameManager.PlayerMaxHP;
    public int nowHp = GameManager.PlayerNowHP;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        slider.value = (float)nowHp / maxHp;
        if (nowHp > 100)
        {
            nowHp = 100;
        }
    }

}
