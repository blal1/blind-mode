using Il2CppInterop.Common.Attributes;

namespace Il2CppSpine.Unity;

[OriginalName("spine-unity.dll", "Spine.Unity", "UpdateTiming")]
public enum UpdateTiming
{
	ManualUpdate,
	InUpdate,
	InFixedUpdate,
	InLateUpdate
}
