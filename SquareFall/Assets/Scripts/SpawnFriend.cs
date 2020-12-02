using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFriend : MonoBehaviour
{
    [SerializeField] private GameObject _friend;
    [SerializeField] private Transform _spawnPosition;
    private float _waitTime;
    public void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private void Update()
    {
        _spawnPosition.position = new Vector2(Random.Range(-2.15f, 2.15f), 5.57f);
        _waitTime = Random.Range(4f, 5f);
    }
    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(_waitTime);
        _friend.SetActive(true);
        Instantiate(_friend, _spawnPosition.position, Quaternion.identity);
        Start();
    }
}
