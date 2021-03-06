# AliceToolsProxy.InvokeAsync method (1 of 3)

Invokes specified operation.

```csharp
public Task<AliceToolsOutput> InvokeAsync(IAliceToolsOperation operation)
```

| parameter | description |
| --- | --- |
| operation | The operation to be invoked. |

## Return Value

The invoking result.

## Exceptions

| exception | condition |
| --- | --- |
| ObjectDisposedException | This instance has been disposed. |

## See Also

* class [AliceToolsOutput](../AliceToolsOutput.md)
* interface [IAliceToolsOperation](../../AliceToolsProxies.Abstracts/IAliceToolsOperation.md)
* class [AliceToolsProxy](../AliceToolsProxy.md)
* namespace [AliceToolsProxies](../../AliceToolsProxies.md)

---

# AliceToolsProxy.InvokeAsync&lt;TOutput&gt; method (2 of 3)

Invokes specified operation, and convert the output to the wapper of specified *TOutput* by *converter*.

```csharp
public Task<OutputConvertionResult<TOutput>> InvokeAsync<TOutput>(IAliceToolsOperation operation, 
    AliceToolsOutputConverter<TOutput> converter)
```

| parameter | description |
| --- | --- |
| TOutput | Output type. |
| operation | The operation to be invoked. |
| converter | The convert for output convertion. |

## Return Value

The wapper of *TOutput* result.

## Exceptions

| exception | condition |
| --- | --- |
| ObjectDisposedException | This instance has been disposed. |

## See Also

* class [OutputConvertionResult&lt;TOutput&gt;](../OutputConvertionResult-1.md)
* interface [IAliceToolsOperation](../../AliceToolsProxies.Abstracts/IAliceToolsOperation.md)
* class [AliceToolsOutputConverter&lt;TOutput&gt;](../../AliceToolsProxies.Abstracts/AliceToolsOutputConverter-1.md)
* class [AliceToolsProxy](../AliceToolsProxy.md)
* namespace [AliceToolsProxies](../../AliceToolsProxies.md)

---

# AliceToolsProxy.InvokeAsync&lt;TOutput&gt; method (3 of 3)

Invokes specified operation, and convert the output to the specified *TOutput* by *converter*.

```csharp
public Task<TOutput> InvokeAsync<TOutput>(IAliceToolsOperation operation, 
    AliceToolsOutputConverter<TOutput> converter, bool allowPartlySuccessful = false)
```

| parameter | description |
| --- | --- |
| TOutput | Output type. |
| operation | The operation to be invoked. |
| converter | The convert for output convertion. |
| allowPartlySuccessful | Specifies that whether the *converter* should convert the partly successful result. |

## Return Value

The *TOutput* result.

## Exceptions

| exception | condition |
| --- | --- |
| ObjectDisposedException | This instance has been disposed. |

## See Also

* interface [IAliceToolsOperation](../../AliceToolsProxies.Abstracts/IAliceToolsOperation.md)
* class [AliceToolsOutputConverter&lt;TOutput&gt;](../../AliceToolsProxies.Abstracts/AliceToolsOutputConverter-1.md)
* class [AliceToolsProxy](../AliceToolsProxy.md)
* namespace [AliceToolsProxies](../../AliceToolsProxies.md)

<!-- DO NOT EDIT: generated by xmldocmd for AliceToolsProxies.dll -->
