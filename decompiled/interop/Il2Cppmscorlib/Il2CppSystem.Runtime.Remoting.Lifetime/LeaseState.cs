using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime;

[System.Serializable]
[OriginalName("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseState")]
public enum LeaseState
{
	Null,
	Initial,
	Active,
	Renewing,
	Expired
}
