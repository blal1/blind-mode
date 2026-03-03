using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x200044D")]
[RequireComponent(typeof(RectTransform))]
public class ContentSizeFilterForTMP : MonoBehaviour
{
	[Token(Token = "0x40014FE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 offset;

	[Token(Token = "0x40014FF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float minWidth;

	[Token(Token = "0x4001500")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float minHeight;

	[Token(Token = "0x4001501")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float maxWidth;

	[Token(Token = "0x4001502")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float maxHeight;

	[Token(Token = "0x4001503")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TextMeshProUGUI m_TargetTmp;

	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform rectTransform;

	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x48")]
	private bool m_UpdateSize;

	[Token(Token = "0x4001506")]
	[FieldOffset(Offset = "0x49")]
	public bool EnableWidthControl;

	[Token(Token = "0x4001507")]
	[FieldOffset(Offset = "0x4A")]
	public bool EnableHeightControl;

	[Token(Token = "0x14000018")]
	public event UnityAction onResized
	{
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x5E3690", Offset = "0x5E2890", VA = "0x1805E3690")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x5E3730", Offset = "0x5E2930", VA = "0x1805E3730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001B88")]
	[Address(RVA = "0x5E32F0", Offset = "0x5E24F0", VA = "0x1805E32F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B89")]
	[Address(RVA = "0x5E33D0", Offset = "0x5E25D0", VA = "0x1805E33D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B8A")]
	[Address(RVA = "0x5E3620", Offset = "0x5E2820", VA = "0x1805E3620")]
	public ContentSizeFilterForTMP()
	{
	}
}
