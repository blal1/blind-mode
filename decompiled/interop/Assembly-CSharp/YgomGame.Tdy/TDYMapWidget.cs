using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Tdy;

[Token(Token = "0x2000868")]
public class TDYMapWidget
{
	[Token(Token = "0x2000869")]
	private class CountUpBehavior : Behavior
	{
		[Token(Token = "0x4008640")]
		[FieldOffset(Offset = "0x20")]
		private long[] _values;

		[Token(Token = "0x4008641")]
		[FieldOffset(Offset = "0x28")]
		private long _tmpValue;

		[Token(Token = "0x4008642")]
		[FieldOffset(Offset = "0x30")]
		private double _duration;

		[Token(Token = "0x4008643")]
		[FieldOffset(Offset = "0x38")]
		private double _elapseTime;

		[Token(Token = "0x4008645")]
		[FieldOffset(Offset = "0x48")]
		private float _dispTime;

		[Token(Token = "0x1700065B")]
		internal Action<long, long> onTextSet
		{
			[Token(Token = "0x6003318")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6003317")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6003319")]
		[Address(RVA = "0x74E5C0", Offset = "0x74D7C0", VA = "0x18074E5C0")]
		internal CountUpBehavior(long origin, long nextValue, double duration)
		{
		}

		[Token(Token = "0x600331A")]
		[Address(RVA = "0x74E410", Offset = "0x74D610", VA = "0x18074E410", Slot = "4")]
		public override void Update(float deltaTime)
		{
		}
	}

	[Token(Token = "0x4008634")]
	[FieldOffset(Offset = "0x10")]
	private readonly ElementObjectManager _eom;

	[Token(Token = "0x4008635")]
	[FieldOffset(Offset = "0x18")]
	private readonly ElementObjectManager _mapRoot;

	[Token(Token = "0x4008636")]
	[FieldOffset(Offset = "0x20")]
	private readonly ElementObjectManager _rewardRootEom;

	[Token(Token = "0x4008637")]
	[FieldOffset(Offset = "0x28")]
	private readonly ElementObjectManager[] _locatorEoms;

	[Token(Token = "0x4008638")]
	[FieldOffset(Offset = "0x30")]
	private readonly ElementObjectManager[] _regionDotEoms;

	[Token(Token = "0x4008639")]
	[FieldOffset(Offset = "0x38")]
	private readonly ElementObjectManager[] _rewardIconEoms;

	[Token(Token = "0x400863A")]
	[FieldOffset(Offset = "0x40")]
	private readonly ExtendedTextMeshProUGUI _totalCountText;

	[Token(Token = "0x400863B")]
	[FieldOffset(Offset = "0x48")]
	private readonly TdyTextAnimation[] _areaTextAnime;

	[Token(Token = "0x400863C")]
	[FieldOffset(Offset = "0x50")]
	private readonly TdyTextAnimation _totalTextAnime;

	[Token(Token = "0x400863D")]
	[FieldOffset(Offset = "0x58")]
	private readonly SelectionButton _helpButton;

	[Token(Token = "0x400863E")]
	[FieldOffset(Offset = "0x60")]
	private long _totalDuelCount;

	[Token(Token = "0x400863F")]
	[FieldOffset(Offset = "0x68")]
	private BehaviorList _behaviorList;

	[Token(Token = "0x6003305")]
	[Address(RVA = "0x753790", Offset = "0x752990", VA = "0x180753790")]
	private static string GetCountString(long count)
	{
		return null;
	}

	[Token(Token = "0x6003306")]
	[Address(RVA = "0x753D30", Offset = "0x752F30", VA = "0x180753D30")]
	public TDYMapWidget(ElementObjectManager eom, bool isDome)
	{
	}

	[Token(Token = "0x6003307")]
	[Address(RVA = "0x753CA0", Offset = "0x752EA0", VA = "0x180753CA0")]
	public void Update(float deltaTime)
	{
	}

	[Token(Token = "0x6003308")]
	[Address(RVA = "0x753A40", Offset = "0x752C40", VA = "0x180753A40")]
	public void Pause()
	{
	}

	[Token(Token = "0x6003309")]
	[Address(RVA = "0x753A60", Offset = "0x752C60", VA = "0x180753A60")]
	public void Resume()
	{
	}

	[Token(Token = "0x600330A")]
	[Address(RVA = "0x753A30", Offset = "0x752C30", VA = "0x180753A30")]
	public bool IsValidAreaId(int areaID)
	{
		return default(bool);
	}

	[Token(Token = "0x600330B")]
	[Address(RVA = "0x7537F0", Offset = "0x7529F0", VA = "0x1807537F0")]
	public void HideArea(int areaId)
	{
	}

	[Token(Token = "0x600330C")]
	[Address(RVA = "0x7538E0", Offset = "0x752AE0", VA = "0x1807538E0")]
	public bool IsAreaHidden(int areaId)
	{
		return default(bool);
	}

	[Token(Token = "0x600330D")]
	[Address(RVA = "0x753540", Offset = "0x752740", VA = "0x180753540")]
	public void DrawTotalDuelCountImmediately(long count, bool hidden)
	{
	}

	[Token(Token = "0x600330E")]
	[Address(RVA = "0x753670", Offset = "0x752870", VA = "0x180753670")]
	public void DrawTotalDuelCount(long count, double duration)
	{
	}

	[Token(Token = "0x600330F")]
	[Address(RVA = "0x7539E0", Offset = "0x752BE0", VA = "0x1807539E0")]
	public bool IsTotalDuelCountAnimePlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x6003310")]
	[Address(RVA = "0x752EE0", Offset = "0x7520E0", VA = "0x180752EE0")]
	public void DrawCountByRegionImmediate(int areaID, long count, bool hidden)
	{
	}

	[Token(Token = "0x6003311")]
	[Address(RVA = "0x753020", Offset = "0x752220", VA = "0x180753020")]
	public void DrawCountByRegion(int areaID, long prevCnt, long count, double duration)
	{
	}

	[Token(Token = "0x6003312")]
	[Address(RVA = "0x753940", Offset = "0x752B40", VA = "0x180753940")]
	public bool IsCountingUp(int areaID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003313")]
	[Address(RVA = "0x752C40", Offset = "0x751E40", VA = "0x180752C40")]
	public void DrawCircleEffect(int areaID, int level)
	{
	}

	[Token(Token = "0x6003314")]
	[Address(RVA = "0x7532D0", Offset = "0x7524D0", VA = "0x1807532D0")]
	public void DrawReward(int slotIndex, EntryItemListData.Context context, bool isAcquired)
	{
	}

	[Token(Token = "0x6003315")]
	[Address(RVA = "0x753230", Offset = "0x752430", VA = "0x180753230")]
	public void DrawKizunaIcon(Dictionary<string, object> cwKizuna)
	{
	}
}
