using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP.SG.Player.Units
{
    public class UnitHandler : MonoBehaviour
    {
    public Unit _unit;

    void Start()
    {
        GameObject unit = Instantiate(_unit.unitPrefab, tramsform.position, Quaternion.identity);
    }

    }

}