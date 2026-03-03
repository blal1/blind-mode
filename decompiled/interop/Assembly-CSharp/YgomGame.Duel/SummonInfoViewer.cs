using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001AAC")]
public class SummonInfoViewer : MonoBehaviour
{
	[Token(Token = "0x2001AAD")]
	private class Info
	{
		[Token(Token = "0x400F53A")]
		[FieldOffset(Offset = "0x10")]
		public GameObject root;

		[Token(Token = "0x400F53B")]
		[FieldOffset(Offset = "0x18")]
		public GameObject spSummonNG;

		[Token(Token = "0x400F53C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject summonNG;

		[Token(Token = "0x400F53D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject spSummonNGIcon;

		[Token(Token = "0x400F53E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject summonNGIcon;

		[Token(Token = "0x400F53F")]
		[FieldOffset(Offset = "0x38")]
		public TMP_Text textSummonNum;

		[Token(Token = "0x400F540")]
		[FieldOffset(Offset = "0x40")]
		public TMP_Text textTotalAtk;

		[Token(Token = "0x400F541")]
		[FieldOffset(Offset = "0x48")]
		public bool isSpSummonNG;

		[Token(Token = "0x400F542")]
		[FieldOffset(Offset = "0x49")]
		public bool isSummonNG;

		[Token(Token = "0x400F543")]
		[FieldOffset(Offset = "0x4C")]
		public int summonNum;

		[Token(Token = "0x400F544")]
		[FieldOffset(Offset = "0x50")]
		public int totalAtk;

		[Token(Token = "0x600AD8B")]
		[Address(RVA = "0x442100", Offset = "0x441300", VA = "0x180442100")]
		public void InitParams()
		{
		}

		[Token(Token = "0x600AD8C")]
		[Address(RVA = "0x442110", Offset = "0x441310", VA = "0x180442110")]
		public Info()
		{
		}
	}

	[Token(Token = "0x400F531")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400F532")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager ui;

	[Token(Token = "0x400F533")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<SharedDefinition.Location, Info> infoList;

	[Token(Token = "0x400F534")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<SharedDefinition.Location, bool> dispDict;

	[Token(Token = "0x400F535")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<SharedDefinition.Location, int> hideLockCounterDict;

	[Token(Token = "0x400F536")]
	private const string prefabPath = "Prefabs/Duel/SummonInfoViewer";

	[Token(Token = "0x400F537")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<GameObject, Queue<TweenConductor>> tweenConductors;

	[Token(Token = "0x400F538")]
	[FieldOffset(Offset = "0x50")]
	private ElementObjectManager m_RootNearEom;

	[Token(Token = "0x400F539")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_RootFarEom;

	[Token(Token = "0x600AD7B")]
	[Address(RVA = "0x449860", Offset = "0x448A60", VA = "0x180449860")]
	public static void Create(Transform parent, Action<SummonInfoViewer, BattlePhaseInfoViewer> onLoaded)
	{
	}

	[Token(Token = "0x600AD7C")]
	[Address(RVA = "0x44A020", Offset = "0x449220", VA = "0x18044A020")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600AD7D")]
	[Address(RVA = "0x44B310", Offset = "0x44A510", VA = "0x18044B310")]
	private void SetupInfo(SharedDefinition.Location location, ElementObjectManager root)
	{
	}

	[Token(Token = "0x600AD7E")]
	[Address(RVA = "0x449AB0", Offset = "0x448CB0", VA = "0x180449AB0")]
	public void ForceClear()
	{
	}

	[Token(Token = "0x600AD7F")]
	[Address(RVA = "0x449E30", Offset = "0x449030", VA = "0x180449E30")]
	public void ForceUpdate(SharedDefinition.Location location)
	{
	}

	[Token(Token = "0x600AD80")]
	[Address(RVA = "0x44ACE0", Offset = "0x449EE0", VA = "0x18044ACE0")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x600AD81")]
	[Address(RVA = "0x44ABF0", Offset = "0x449DF0", VA = "0x18044ABF0")]
	private void SetDisp(SharedDefinition.Location location, bool disp)
	{
	}

	[Token(Token = "0x600AD82")]
	[Address(RVA = "0x44A1C0", Offset = "0x4493C0", VA = "0x18044A1C0")]
	private bool IsHideLock(SharedDefinition.Location location)
	{
		return default(bool);
	}

	[Token(Token = "0x600AD83")]
	[Address(RVA = "0x44AD20", Offset = "0x449F20", VA = "0x18044AD20")]
	public void SetInitializeParams(SharedDefinition.Location location, bool spSummonNG, bool summonNG, int summonNum)
	{
	}

	[Token(Token = "0x600AD84")]
	[Address(RVA = "0x44A370", Offset = "0x449570", VA = "0x18044A370")]
	public void SetDispSPSummonNG(SharedDefinition.Location location, bool disp)
	{
	}

	[Token(Token = "0x600AD85")]
	[Address(RVA = "0x44A7B0", Offset = "0x4499B0", VA = "0x18044A7B0")]
	public void SetDispSummonNG(SharedDefinition.Location location, bool disp)
	{
	}

	[Token(Token = "0x600AD86")]
	[Address(RVA = "0x44AEB0", Offset = "0x44A0B0", VA = "0x18044AEB0")]
	public void SetSummonNum(SharedDefinition.Location location, int num, bool showIfChanged)
	{
	}

	[Token(Token = "0x600AD87")]
	[Address(RVA = "0x44B250", Offset = "0x44A450", VA = "0x18044B250")]
	public void SetTotalAtk(SharedDefinition.Location location, int totalAtk)
	{
	}

	[Token(Token = "0x600AD88")]
	[Address(RVA = "0x449950", Offset = "0x448B50", VA = "0x180449950")]
	private void EnqueueTweenConductor(GameObject gameObject, TweenConductor tweenConductor)
	{
	}

	[Token(Token = "0x600AD89")]
	[Address(RVA = "0x44A220", Offset = "0x449420", VA = "0x18044A220")]
	private void PlayQueuedTweenConductor(GameObject gameObject)
	{
	}

	[Token(Token = "0x600AD8A")]
	[Address(RVA = "0x44B640", Offset = "0x44A840", VA = "0x18044B640")]
	public SummonInfoViewer()
	{
	}
}
