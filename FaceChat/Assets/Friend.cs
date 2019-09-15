using UnityEngine;
using UnityEngine.Networking;

public class Friend : NetworkBehaviour
{
    //Assign the prefab in the Inspector
    public GameObject m_MyGameObject;
    GameObject m_MyInstantiated;

    void Start()
    {
        //Instantiate the prefab
        m_MyInstantiated = Instantiate(m_MyGameObject);
        NetworkServer.Spawn(m_MyInstantiated);
    }
}