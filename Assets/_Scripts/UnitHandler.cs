using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP.SG.Player.Units
{
    public class UnitHandler : MonoBehaviour
    {
    public Unit _unit;

    public transform workers;

    void Start()
    {
        GameObject unit = Instantiate(_unit.unitPrefab, transform.position, Quaternion.identity, workers);
    }

    }

}