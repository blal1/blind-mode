using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Home;

[Token(Token = "0x2000375")]
public abstract class ActiveFalseTarget<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Tooltip("非表示にしたいGameObject")]
	private GameObject targetGameObject;

	[Token(Token = "0x40011E9")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Tooltip("2つ以上ある場合はこちら")]
	private GameObject[] additionalTargets;

	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0x0")]
	protected T component;

	[Token(Token = "0x6001573")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001574")]
	protected abstract bool IsActive();

	[Token(Token = "0x6001575")]
	protected ActiveFalseTarget()
	{
	}
}
