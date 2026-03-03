using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Cache;

[OriginalName("System.dll", "System.Net.Cache", "RequestCacheLevel")]
public enum RequestCacheLevel
{
	Default,
	BypassCache,
	CacheOnly,
	CacheIfAvailable,
	Revalidate,
	Reload,
	NoCacheNoStore
}
