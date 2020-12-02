using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _spawnPosition;
    private float _waitTime;
    public void Start()
    {
        StartCoroutine(Spawn());
    }
    private void Update()
    {
        _spawnPosition.position = new Vector2(Random.Range(-2.15f, 2.15f), 5.57f);
        _waitTime = Random.Range(.3f, 1.4f);
    }
    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(_waitTime);
        _enemy.SetActive(true);
        Instantiate(_enemy, _spawnPosition.position, Quaternion.identity);
        Start();
    }
}
