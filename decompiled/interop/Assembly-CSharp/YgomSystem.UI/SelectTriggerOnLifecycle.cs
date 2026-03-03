using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004C5")]
public class SelectTriggerOnLifecycle : MonoBehaviour
{
	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SelectionItem m_SelectedCheckItem;

	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<SelectionItem> m_OnEnableTargets;

	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<SelectionItem> m_OnDisableTargets;

	[Token(Token = "0x17000332")]
	public SelectionItem selectedCheckItem
	{
		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x17000333")]
	public List<SelectionItem> onEnableTargets
	{
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000334")]
	public List<SelectionItem> onDisableTargets
	{
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x615CC0", Offset = "0x614EC0", VA = "0x180615CC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x615B20", Offset = "0x614D20", VA = "0x180615B20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x615E30", Offset = "0x615030", VA = "0x180615E30")]
	public SelectTriggerOnLifecycle()
	{
	}
}
