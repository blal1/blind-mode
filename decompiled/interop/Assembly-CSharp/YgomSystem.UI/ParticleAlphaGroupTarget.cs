using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomSystem.UI;

[Token(Token = "0x2000542")]
[RequireComponent(typeof(ParticleSystem))]
public class ParticleAlphaGroupTarget : UIBehaviour
{
	[Token(Token = "0x400198F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_AlphaParamName;

	[Token(Token = "0x4001990")]
	[FieldOffset(Offset = "0x28")]
	private ParticleAlphaGroup m_Group;

	[Token(Token = "0x4001991")]
	[FieldOffset(Offset = "0x30")]
	private Renderer m_TargetCache;

	[Token(Token = "0x1700039E")]
	private Renderer target
	{
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x64BD70", Offset = "0x64AF70", VA = "0x18064BD70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002231")]
	[Address(RVA = "0x6352D0", Offset = "0x6344D0", VA = "0x1806352D0", Slot = "11")]
	protected override void OnBeforeTransformParentChanged()
	{
	}

	[Token(Token = "0x6002232")]
	[Address(RVA = "0x6352D0", Offset = "0x6344D0", VA = "0x1806352D0", Slot = "14")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x6002233")]
	[Address(RVA = "0x6352D0", Offset = "0x6344D0", VA = "0x1806352D0", Slot = "15")]
	protected override void OnCanvasHierarchyChanged()
	{
	}

	[Token(Token = "0x6002234")]
	[Address(RVA = "0x6352D0", Offset = "0x6344D0", VA = "0x1806352D0", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x6002235")]
	[Address(RVA = "0x6352D0", Offset = "0x6344D0", VA = "0x1806352D0", Slot = "12")]
	protected override void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x6002236")]
	[Address(RVA = "0x6346D0", Offset = "0x6338D0", VA = "0x1806346D0")]
	private void SetGroupDirty()
	{
	}

	[Token(Token = "0x6002237")]
	[Address(RVA = "0x64B890", Offset = "0x64AA90", VA = "0x18064B890")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002238")]
	[Address(RVA = "0x64BAD0", Offset = "0x64ACD0", VA = "0x18064BAD0")]
	public void OnChangeGroupAlpha(float alpha)
	{
	}

	[Token(Token = "0x6002239")]
	[Address(RVA = "0x64BAE0", Offset = "0x64ACE0", VA = "0x18064BAE0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600223A")]
	[Address(RVA = "0x64B790", Offset = "0x64A990", VA = "0x18064B790")]
	private float CollectCanvasGroupAlpha()
	{
		return default(float);
	}

	[Token(Token = "0x600223B")]
	[Address(RVA = "0x64BB90", Offset = "0x64AD90", VA = "0x18064BB90")]
	private void SetTargetAlpha(float alpha)
	{
	}

	[Token(Token = "0x600223C")]
	[Address(RVA = "0x64BD20", Offset = "0x64AF20", VA = "0x18064BD20")]
	public ParticleAlphaGroupTarget()
	{
	}
}
