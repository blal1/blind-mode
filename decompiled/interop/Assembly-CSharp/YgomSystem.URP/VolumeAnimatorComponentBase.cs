using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace YgomSystem.URP;

[Token(Token = "0x2000313")]
[ExecuteAlways]
[RequireComponent(typeof(VolumeAnimator))]
public abstract class VolumeAnimatorComponentBase<TARGET> : MonoBehaviour, IVolumeAnimatorComponent where TARGET : VolumeComponent
{
	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0x0")]
	public bool active;

	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x0")]
	private TARGET m_BindedComponent;

	[Token(Token = "0x170001E5")]
	public TARGET bindedComponent
	{
		[Token(Token = "0x600132E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E6")]
	private VolumeComponent YgomSystem_002EURP_002EIVolumeAnimatorComponent_002EbindedComponent
	{
		[Token(Token = "0x600132F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001330")]
	public bool TryBind(VolumeComponent component)
	{
		return default(bool);
	}

	[Token(Token = "0x6001331")]
	public void Import()
	{
	}

	[Token(Token = "0x6001332")]
	public void Import(VolumeComponent component)
	{
	}

	[Token(Token = "0x6001333")]
	public void Import(TARGET component)
	{
	}

	[Token(Token = "0x6001334")]
	protected abstract void ExecuteImport(TARGET component);

	[Token(Token = "0x6001335")]
	public void Export()
	{
	}

	[Token(Token = "0x6001336")]
	public void Export(VolumeComponent component)
	{
	}

	[Token(Token = "0x6001337")]
	public void Export(TARGET component)
	{
	}

	[Token(Token = "0x6001338")]
	protected abstract void ExecuteExport(TARGET component);

	[Token(Token = "0x6001339")]
	protected VolumeAnimatorComponentBase()
	{
	}
}
