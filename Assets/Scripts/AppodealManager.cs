using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class AppodealManager : MonoBehaviour
{

    private GameObject _cachad;

    protected async Task<T> LoadIntenal<T>(string assetID)
    {
        var handle = Addressables.InstantiateAsync(assetID);
        _cachad = await handle.Task;
        if (_cachad.TryGetComponent(out T SampleScene))
            Debug.Log("Warm");
        return SampleScene;
    }

    protected void UnloadInternal()
    {
        if (_cachad == false)
            return;
        _cachad.SetActive(false);
        Addressables.ReleaseInstance(_cachad);
        _cachad = null;
    }
}
