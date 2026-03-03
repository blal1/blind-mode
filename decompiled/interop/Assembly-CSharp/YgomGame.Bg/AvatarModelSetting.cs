using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D7F")]
public class AvatarModelSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001D80")]
	public class ChangeCondition
	{
		[Token(Token = "0x401041F")]
		[FieldOffset(Offset = "0x10")]
		public Character.SubAvatarChange condition;

		[Token(Token = "0x4010420")]
		[FieldOffset(Offset = "0x18")]
		public List<int> param;

		[Token(Token = "0x4010421")]
		[FieldOffset(Offset = "0x20")]
		public bool useChangeMotion;

		[Token(Token = "0x4010422")]
		[FieldOffset(Offset = "0x24")]
		public float changeDelay;

		[Token(Token = "0x4010423")]
		[FieldOffset(Offset = "0x28")]
		public bool useSubAvatarConditionParam;

		[Token(Token = "0x600BD4D")]
		[Address(RVA = "0x588B30", Offset = "0x587D30", VA = "0x180588B30")]
		public ChangeCondition(Character.SubAvatarChange condition)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001D81")]
	public class AvatarModelInfo
	{
		[Token(Token = "0x4010424")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4010425")]
		[FieldOffset(Offset = "0x18")]
		public string path;

		[Token(Token = "0x4010426")]
		[FieldOffset(Offset = "0x20")]
		public string seLabel;

		[Token(Token = "0x4010427")]
		[FieldOffset(Offset = "0x28")]
		public bool isResources;

		[Token(Token = "0x4010428")]
		[FieldOffset(Offset = "0x30")]
		public List<SubAvatarInfo> subAvatarInfoList;

		[Token(Token = "0x600BD4E")]
		[Address(RVA = "0x5807C0", Offset = "0x57F9C0", VA = "0x1805807C0")]
		public AvatarModelInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600BD4F")]
		[Address(RVA = "0x580840", Offset = "0x57FA40", VA = "0x180580840")]
		public List<int> GetSubAvatarIdList()
		{
			return null;
		}

		[Token(Token = "0x600BD50")]
		[Address(RVA = "0x5809B0", Offset = "0x57FBB0", VA = "0x1805809B0")]
		public SubAvatarInfo GetSubAvatarInfo(Character.SubAvatarChange condition = Character.SubAvatarChange.None)
		{
			return null;
		}

		[Token(Token = "0x600BD51")]
		[Address(RVA = "0x580970", Offset = "0x57FB70", VA = "0x180580970")]
		public int GetSubAvatarInfoCount()
		{
			return default(int);
		}

		[Token(Token = "0x600BD52")]
		[Address(RVA = "0x580AD0", Offset = "0x57FCD0", VA = "0x180580AD0")]
		public bool HasChangeCondition(Character.SubAvatarChange condition)
		{
			return default(bool);
		}

		[Token(Token = "0x600BD53")]
		[Address(RVA = "0x580BF0", Offset = "0x57FDF0", VA = "0x180580BF0")]
		public AvatarModelInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001D85")]
	public class SubAvatarInfo
	{
		[Token(Token = "0x401042D")]
		[FieldOffset(Offset = "0x10")]
		public int subAvatarId;

		[Token(Token = "0x401042E")]
		[FieldOffset(Offset = "0x18")]
		public string changeEffectPath;

		[Token(Token = "0x401042F")]
		[FieldOffset(Offset = "0x20")]
		public List<ChangeCondition> conditionList;

		[Token(Token = "0x600BD5B")]
		[Address(RVA = "0x58F3E0", Offset = "0x58E5E0", VA = "0x18058F3E0")]
		public void Copy(SubAvatarInfo info)
		{
		}

		[Token(Token = "0x600BD5C")]
		[Address(RVA = "0x58F490", Offset = "0x58E690", VA = "0x18058F490")]
		public bool HasChangeCondition(Character.SubAvatarChange condition)
		{
			return default(bool);
		}

		[Token(Token = "0x600BD5D")]
		[Address(RVA = "0x58F590", Offset = "0x58E790", VA = "0x18058F590")]
		public SubAvatarInfo()
		{
		}
	}

	[Token(Token = "0x401041C")]
	private const string avatarModelSettingPath = "Duel/ScriptableObject/AvatarModelSetting";

	[Token(Token = "0x401041D")]
	[FieldOffset(Offset = "0x0")]
	private static AvatarModelSetting modelSetting;

	[Token(Token = "0x401041E")]
	[FieldOffset(Offset = "0x18")]
	public List<AvatarModelInfo> infoList;

	[Token(Token = "0x17001C22")]
	public static AvatarModelSetting ModelSetting
	{
		[Token(Token = "0x600BD3E")]
		[Address(RVA = "0x582060", Offset = "0x581260", VA = "0x180582060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BD3F")]
	[Address(RVA = "0x5810A0", Offset = "0x5802A0", VA = "0x1805810A0")]
	public string GetPath(int id)
	{
		return null;
	}

	[Token(Token = "0x600BD40")]
	[Address(RVA = "0x580EC0", Offset = "0x5800C0", VA = "0x180580EC0")]
	public string GetPath(int id, Character.SubAvatarChange condition)
	{
		return null;
	}

	[Token(Token = "0x600BD41")]
	[Address(RVA = "0x5811B0", Offset = "0x5803B0", VA = "0x1805811B0")]
	public string GetSeLabel(int id)
	{
		return null;
	}

	[Token(Token = "0x600BD42")]
	[Address(RVA = "0x580DB0", Offset = "0x57FFB0", VA = "0x180580DB0")]
	public string GetMateId(int id)
	{
		return null;
	}

	[Token(Token = "0x600BD43")]
	[Address(RVA = "0x581620", Offset = "0x580820", VA = "0x180581620")]
	public int GetSubAvatarId(int id, Character.SubAvatarChange condition = Character.SubAvatarChange.None)
	{
		return default(int);
	}

	[Token(Token = "0x600BD44")]
	[Address(RVA = "0x580C70", Offset = "0x57FE70", VA = "0x180580C70")]
	public int ConvertSubAvatarId(int id, Character.SubAvatarChange condition = Character.SubAvatarChange.None)
	{
		return default(int);
	}

	[Token(Token = "0x600BD45")]
	[Address(RVA = "0x581810", Offset = "0x580A10", VA = "0x180581810")]
	public string GetSubAvatarPath(int id)
	{
		return null;
	}

	[Token(Token = "0x600BD46")]
	[Address(RVA = "0x580CA0", Offset = "0x57FEA0", VA = "0x180580CA0")]
	public string GetChangeEffectPath(int id, Character.SubAvatarChange condition = Character.SubAvatarChange.None)
	{
		return null;
	}

	[Token(Token = "0x600BD47")]
	[Address(RVA = "0x5812E0", Offset = "0x5804E0", VA = "0x1805812E0")]
	public Dictionary<Character.SubAvatarChange, List<int>> GetSubAvatarChangeCondition(int id)
	{
		return null;
	}

	[Token(Token = "0x600BD48")]
	[Address(RVA = "0x581720", Offset = "0x580920", VA = "0x180581720")]
	public SubAvatarInfo GetSubAvatarInfo(int id, Character.SubAvatarChange condition = Character.SubAvatarChange.None)
	{
		return null;
	}

	[Token(Token = "0x600BD49")]
	[Address(RVA = "0x5819E0", Offset = "0x580BE0", VA = "0x1805819E0")]
	public string LoadSoundXml(int id)
	{
		return null;
	}

	[Token(Token = "0x600BD4A")]
	[Address(RVA = "0x581840", Offset = "0x580A40", VA = "0x180581840")]
	public static AvatarModelSetting LoadImmediate(bool reset = false)
	{
		return null;
	}

	[Token(Token = "0x600BD4B")]
	[Address(RVA = "0x581E50", Offset = "0x581050", VA = "0x180581E50")]
	public static void Load(Action<AvatarModelSetting> onFinish, bool reset = false)
	{
	}

	[Token(Token = "0x600BD4C")]
	[Address(RVA = "0x581FE0", Offset = "0x5811E0", VA = "0x180581FE0")]
	public AvatarModelSetting()
	{
	}
}
