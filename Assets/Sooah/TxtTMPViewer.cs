using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TxtTMPViewer : MonoBehaviour
{
    [SerializeField] private TMP_Text _textPlayerHP;
    [SerializeField] private PlayerHP playerHP;

    private void Update()
    {
        _textPlayerHP.text = playerHP.CurrentHP + "/" + playerHP.MaxHP;
    }
}
