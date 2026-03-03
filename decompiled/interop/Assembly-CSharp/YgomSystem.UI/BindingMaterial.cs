using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200051B")]
[AddComponentMenu("Ygom/UI/Binding/Binding Material")]
public class BindingMaterial : MonoBehaviour
{
	[Token(Token = "0x4001901")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string materialPath;

	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool IsDone;

	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool immediate;

	[Token(Token = "0x4001904")]
	[FieldOffset(Offset = "0x2A")]
	[SerializeField]
	private bool StartOnAwake;

	[Token(Token = "0x17000359")]
	public string MaterialPath
	{
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x6002117")]
	[Address(RVA = "0x632D90", Offset = "0x631F90", VA = "0x180632D90")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002118")]
	[Address(RVA = "0x632DA0", Offset = "0x631FA0", VA = "0x180632DA0")]
	public void LoadMaterial()
	{
	}

	[Token(Token = "0x6002119")]
	[Address(RVA = "0x633000", Offset = "0x632200", VA = "0x180633000")]
	public BindingMaterial()
	{
	}
}
