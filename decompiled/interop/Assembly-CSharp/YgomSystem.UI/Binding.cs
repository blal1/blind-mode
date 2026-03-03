using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000514")]
public abstract class Binding : MonoBehaviour
{
	[Token(Token = "0x2000515")]
	public enum Mode
	{
		[Token(Token = "0x40018E5")]
		OneTime,
		[Token(Token = "0x40018E6")]
		OneWay,
		[Token(Token = "0x40018E7")]
		OneWayToSource,
		[Token(Token = "0x40018E8")]
		TwoWay
	}

	[Token(Token = "0x40018E3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Mode mode;

	[Token(Token = "0x60020F0")]
	public abstract void OnRebind();

	[Token(Token = "0x60020F1")]
	public abstract bool OnBinding();

	[Token(Token = "0x60020F2")]
	[Address(RVA = "0x634640", Offset = "0x633840", VA = "0x180634640", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60020F3")]
	[Address(RVA = "0x634690", Offset = "0x633890", VA = "0x180634690")]
	private void Update()
	{
	}

	[Token(Token = "0x60020F4")]
	[Address(RVA = "0x634600", Offset = "0x633800", VA = "0x180634600")]
	public void SourceChanged()
	{
	}

	[Token(Token = "0x60020F5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void TargetChanged()
	{
	}

	[Token(Token = "0x60020F6")]
	[Address(RVA = "0x634690", Offset = "0x633890", VA = "0x180634690")]
	public void UpdateBinding()
	{
	}

	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected Binding()
	{
	}
}
