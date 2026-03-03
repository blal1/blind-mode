using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Effect;

[Token(Token = "0x200031F")]
[RequireComponent(typeof(Graphic))]
[DisallowMultipleComponent]
public class MaterialSetterGraphWriter : MonoBehaviour, IMaterialModifier
{
	[Token(Token = "0x4001109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Assign by runtime")]
	[SerializeField]
	private Material m_SourceMaterial;

	[Token(Token = "0x400110A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material m_TargetMaterial;

	[Token(Token = "0x170001ED")]
	public Graphic targetGraph
	{
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170001EE")]
	public Material targetMaterial
	{
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001374")]
	[Address(RVA = "0x412B90", Offset = "0x411D90", VA = "0x180412B90")]
	public static MaterialSetterGraphWriter Assign(Graphic target)
	{
		return null;
	}

	[Token(Token = "0x6001375")]
	[Address(RVA = "0x412CF0", Offset = "0x411EF0", VA = "0x180412CF0", Slot = "4")]
	public Material GetModifiedMaterial(Material baseMaterial)
	{
		return null;
	}

	[Token(Token = "0x6001376")]
	[Address(RVA = "0x412DE0", Offset = "0x411FE0", VA = "0x180412DE0")]
	public bool Refresh([Optional] Material baseMaterial)
	{
		return default(bool);
	}

	[Token(Token = "0x6001377")]
	[Address(RVA = "0x412D30", Offset = "0x411F30", VA = "0x180412D30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001378")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public MaterialSetterGraphWriter()
	{
	}
}
