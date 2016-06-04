using UnityEngine;
using System.Collections;

public class ManagerMonster : MonoBehaviour 
    {
    /*
    This script is attatched to a Monster object that is a parent of
    Name, Feed, and Breed objects in the manager
    */

    //prefab of the monster model or sprite
    public GameObject monsterPrefab;
    
    //transform of the monster in the manager viewer
    private Transform monsterTransform;

    private MonsterManager monsterManager;

	void Start () 
    {
        monsterTransform = GameObject.Find("Monster Position").transform;
        monsterManager = GameObject.Find("Monster Manager").GetComponent<MonsterManager>();
	}
	
    //This is called when the monster name is clicked in the Manager.
	public void MonsterNameClicked() 
    {
        if (monsterManager.currentMonster != null) { Destroy(monsterManager.currentMonster); }

        monsterManager.currentMonster = GameObject.Instantiate(monsterPrefab);
        monsterManager.currentMonster.transform.position = monsterTransform.position;
        monsterManager.currentMonster.transform.localScale = monsterTransform.localScale;
    }
}
