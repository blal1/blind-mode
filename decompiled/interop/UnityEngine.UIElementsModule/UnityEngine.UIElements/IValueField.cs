using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000159")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public interface IValueField<T>
{
	[Token(Token = "0x170001C8")]
	T value
	{
		[Token(Token = "0x6000A74")]
		get;
		[Token(Token = "0x6000A75")]
		set;
	}

	[Token(Token = "0x6000A76")]
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue);

	[Token(Token = "0x6000A77")]
	void StartDragging();

	[Token(Token = "0x6000A78")]
	void StopDragging();
}
