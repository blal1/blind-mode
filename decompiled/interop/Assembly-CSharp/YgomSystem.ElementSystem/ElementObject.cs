using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.ElementSystem;

[Token(Token = "0x20002FD")]
public class ElementObject : MonoBehaviour
{
	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x20")]
	public string label;

	[Token(Token = "0x4001026")]
	[FieldOffset(Offset = "0x30")]
	public UnityAction callbackVoid;

	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x38")]
	public UnityAction<int> callbackInt;

	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x40")]
	public UnityAction<float> callbackFloat;

	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x48")]
	public UnityAction<Vector2> callbackVector2;

	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0x50")]
	public UnityAction<string> callbackString;

	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x58")]
	public UnityAction<bool> callbackBool;

	[Token(Token = "0x170001E0")]
	public ElementObjectManager parentManager
	{
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x406FD0", Offset = "0x4061D0", VA = "0x180406FD0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x407030", Offset = "0x406230", VA = "0x180407030")]
	public void Setup()
	{
	}

	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x406F10", Offset = "0x406110", VA = "0x180406F10")]
	public void ElementCallback()
	{
	}

	[Token(Token = "0x60012C7")]
	[Address(RVA = "0x406E90", Offset = "0x406090", VA = "0x180406E90")]
	public void ElementCallback(float value)
	{
	}

	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x406F30", Offset = "0x406130", VA = "0x180406F30")]
	public void ElementCallback(int value)
	{
	}

	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x406ED0", Offset = "0x4060D0", VA = "0x180406ED0")]
	public void ElementCallback(Vector2 value)
	{
	}

	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x406EB0", Offset = "0x4060B0", VA = "0x180406EB0")]
	public void ElementCallback(string value)
	{
	}

	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x406EF0", Offset = "0x4060F0", VA = "0x180406EF0")]
	public void ElementCallback(bool value)
	{
	}

	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x406F50", Offset = "0x406150", VA = "0x180406F50")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ElementObject()
	{
	}
}
