using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum Type
    {
        Coin,
        ExtraLife,
        MagicMushroom,
        Starpower,
    }

    public Type type;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect(other.gameObject);
        }
    }

    private void Collect(GameObject player)
    {
        switch (type)
        {
            case Type.Coin:
                // TODO
                break;

            case Type.ExtraLife:
                // TODO
                break;

            case Type.MagicMushroom:
                // TODO
                break;

            case Type.Starpower:
                // TODO
                break;
        }

        Destroy(gameObject);
    }
}
