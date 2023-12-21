using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TxtTMPViewer : MonoBehaviour
{
    [SerializeField] private TMP_Text _textPlayerHP;
    [SerializeField] private TMP_Text _textPlayerGold;
    [SerializeField] private PlayerHP playerHP;
    [SerializeField] private PlayerGold playerGold;

    private void Update()
    {
        _textPlayerHP.text = playerHP.CurrentHP + "/" + playerHP.MaxHP;
        _textPlayerGold.text = playerGold.CurrentGold.ToString();
    }
}
