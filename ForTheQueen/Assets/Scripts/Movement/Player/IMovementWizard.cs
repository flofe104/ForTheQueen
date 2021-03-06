using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementWizard
{

    Vector3 Direction(DirectionMode directionMode);

    void AddForce(Vector3 dir, ForceMode forceMode);

    MonoBehaviour Behaviour { get; }

    bool IsWizardFlying { get; }

}
