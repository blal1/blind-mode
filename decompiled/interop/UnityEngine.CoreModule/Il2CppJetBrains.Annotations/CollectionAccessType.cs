using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppJetBrains.Annotations;

[OriginalName("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "CollectionAccessType")]
[Flags]
public enum CollectionAccessType
{
	None = 0,
	Read = 1,
	ModifyExistingContent = 2,
	UpdatedContent = 6
}
