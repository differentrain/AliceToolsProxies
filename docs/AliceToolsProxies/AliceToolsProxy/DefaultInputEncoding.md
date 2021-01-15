# AliceToolsProxy.DefaultInputEncoding property

Gets or set default input encoding.

```csharp
public static Encoding DefaultInputEncoding { get; set; }
```

## Exceptions

| exception | condition |
| --- | --- |
| NotSupportedException | The Encoding instance set to this property does not have libiconv friendly name. |

## Remarks

Some Encoding may not be supported, uses [`IsLibiconvSupported`](../AliceToolsProxiesExtensions/IsLibiconvSupported.md) extension method to check.

This property influences the initial value of `InputEncoding` of the class derived form [`AliceFileOperation`](../../AliceToolsProxies.Abstracts/AliceFileOperation.md).

## See Also

* class [AliceToolsProxy](../AliceToolsProxy.md)
* namespace [AliceToolsProxies](../../AliceToolsProxies.md)

<!-- DO NOT EDIT: generated by xmldocmd for AliceToolsProxies.dll -->