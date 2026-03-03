using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Effect;

[Token(Token = "0x2000320")]
[RequireComponent(typeof(Image))]
public class MaterialSetterSpriteUVMinMax : MonoBehaviour
{
	[Token(Token = "0x400110C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_MinMaxLabel;

	[Token(Token = "0x400110D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_SetTexLabel;

	[Token(Token = "0x400110E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite m_SourceSpriteDefault;

	[Token(Token = "0x400110F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite m_SourceSpriteMobile;

	[Token(Token = "0x4001110")]
	[FieldOffset(Offset = "0x40")]
	private Image m_TargetImage;

	[Token(Token = "0x4001111")]
	[FieldOffset(Offset = "0x48")]
	private MaterialSetterGraphWriter m_TargetWriter;

	[Token(Token = "0x170001EF")]
	public Sprite sourceSpritePlatformValue
	{
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x413B90", Offset = "0x412D90", VA = "0x180413B90")]
		get
		{
			return null;
		}
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x413BF0", Offset = "0x412DF0", VA = "0x180413BF0")]
		set
		{
		}
	}

	[Token(Token = "0x600137B")]
	[Address(RVA = "0x413390", Offset = "0x412590", VA = "0x180413390")]
	private Sprite GetTargetSprite()
	{
		return null;
	}

	[Token(Token = "0x600137C")]
	[Address(RVA = "0x413240", Offset = "0x412440", VA = "0x180413240")]
	private void Awake()
	{
	}

	[Token(Token = "0x600137D")]
	[Address(RVA = "0x413460", Offset = "0x412660", VA = "0x180413460")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600137E")]
	[Address(RVA = "0x413460", Offset = "0x412660", VA = "0x180413460")]
	private void Update()
	{
	}

	[Token(Token = "0x600137F")]
	[Address(RVA = "0x413600", Offset = "0x412800", VA = "0x180413600")]
	private void Progress()
	{
	}

	[Token(Token = "0x6001380")]
	[Address(RVA = "0x413960", Offset = "0x412B60", VA = "0x180413960")]
	private void Setup()
	{
	}

	[Token(Token = "0x6001381")]
	[Address(RVA = "0x4130E0", Offset = "0x4122E0", VA = "0x1804130E0")]
	private Sprite AssignSprite()
	{
		return null;
	}

	[Token(Token = "0x6001382")]
	[Address(RVA = "0x413470", Offset = "0x412670", VA = "0x180413470")]
	private bool ProgressSetSpriteUvMinMax(Sprite assignedSprite)
	{
		return default(bool);
	}

	[Token(Token = "0x6001383")]
	[Address(RVA = "0x413930", Offset = "0x412B30", VA = "0x180413930")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6001384")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public MaterialSetterSpriteUVMinMax()
	{
	}
}
