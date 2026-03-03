using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DiceRallyMapEditor;

[Token(Token = "0x200013D")]
public class MapEditorUtil
{
	[Token(Token = "0x200013E")]
	public enum ClickMode
	{
		[Token(Token = "0x40007A6")]
		Change,
		[Token(Token = "0x40007A7")]
		Connect
	}

	[Token(Token = "0x200013F")]
	public enum MaptipType
	{
		[Token(Token = "0x40007A9")]
		CardN,
		[Token(Token = "0x40007AA")]
		CardR,
		[Token(Token = "0x40007AB")]
		CardSR,
		[Token(Token = "0x40007AC")]
		CardUR,
		[Token(Token = "0x40007AD")]
		RarityUp,
		[Token(Token = "0x40007AE")]
		LifeHalf,
		[Token(Token = "0x40007AF")]
		HandAdd1,
		[Token(Token = "0x40007B0")]
		Move1,
		[Token(Token = "0x40007B1")]
		Move2,
		[Token(Token = "0x40007B2")]
		Start,
		[Token(Token = "0x40007B3")]
		Goal
	}

	[Serializable]
	[Token(Token = "0x2000140")]
	public class MaptipPositoin
	{
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x10")]
		public int x;

		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x14")]
		public int y;

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public MaptipPositoin()
		{
		}
	}

	[Token(Token = "0x600080B")]
	[Address(RVA = "0x9DB090", Offset = "0x9DA290", VA = "0x1809DB090")]
	public static int MaptipType2ID(MaptipType type)
	{
		return default(int);
	}

	[Token(Token = "0x600080C")]
	[Address(RVA = "0x9DAF70", Offset = "0x9DA170", VA = "0x1809DAF70")]
	public static (int, int) MaptipType2Category(MaptipType type)
	{
		return default((int, int));
	}

	[Token(Token = "0x600080D")]
	[Address(RVA = "0x9DAC40", Offset = "0x9D9E40", VA = "0x1809DAC40")]
	public static MaptipType ID2MaptipType(int id)
	{
		return default(MaptipType);
	}

	[Token(Token = "0x600080E")]
	[Address(RVA = "0x9DAAD0", Offset = "0x9D9CD0", VA = "0x1809DAAD0")]
	public static Dictionary<MaptipType, int> GetMaptipCountEmptyDictionary()
	{
		return null;
	}

	[Token(Token = "0x600080F")]
	[Address(RVA = "0x9DAA20", Offset = "0x9D9C20", VA = "0x1809DAA20")]
	public static Tuple<float, float> CartesianToPolar(Vector2 vect)
	{
		return null;
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0x9DAD60", Offset = "0x9D9F60", VA = "0x1809DAD60")]
	public static bool IsOverlappingObject(RectTransform target, RectTransform area, Camera camera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x9DADC0", Offset = "0x9D9FC0", VA = "0x1809DADC0")]
	public static bool IsOverlappingObject(Vector3 target, RectTransform area, Camera camera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MapEditorUtil()
	{
	}
}
