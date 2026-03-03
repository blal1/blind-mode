using System;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000507")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal interface IVisualTreeUpdater : IDisposable
{
	[Token(Token = "0x1700096B")]
	long FrameCount
	{
		[Token(Token = "0x600241F")]
		get;
		[Token(Token = "0x6002420")]
		set;
	}

	[Token(Token = "0x1700096C")]
	BaseVisualElementPanel panel
	{
		[Token(Token = "0x6002421")]
		set;
	}

	[Token(Token = "0x1700096D")]
	ProfilerMarker profilerMarker
	{
		[Token(Token = "0x6002422")]
		get;
	}

	[Token(Token = "0x6002423")]
	void Update();

	[Token(Token = "0x6002424")]
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
}
