using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI;

[Token(Token = "0x20000BE")]
[AddComponentMenu("UI/Effects/Text Vertex Limitter", 15)]
[RequireComponent(typeof(Text))]
public class TextVertexLimitter : BaseMeshEffect
{
	[Token(Token = "0x20000BF")]
	private struct TagInfo
	{
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x0")]
		public int Index;

		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x4")]
		public int Length;
	}

	[Token(Token = "0x40003D5")]
	private const string SupportedTagRegexPattern = "<b>|</b>|<i>|</i>|<size=.*?>|</size>|<color=.*?>|</color>|<material=.*?>|</material>";

	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool useRichText;

	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int startPos;

	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int length;

	[Token(Token = "0x40003D9")]
	protected const int VERTLEN = 6;

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x6823F0", Offset = "0x6815F0", VA = "0x1806823F0", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "21")]
	protected virtual void OnModifyMesh(VertexHelper vh, List<UIVertex> verts)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x6828B0", Offset = "0x681AB0", VA = "0x1806828B0")]
	private int RemoveRange(List<UIVertex> verts, int index, int count, List<TagInfo> tags)
	{
		return default(int);
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x682030", Offset = "0x681230", VA = "0x180682030")]
	private bool CheckTag(int index, List<TagInfo> tags, ref int tagIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x682130", Offset = "0x681330", VA = "0x180682130")]
	private IEnumerator GetRegexMatchedTagCollection(string line, out int lineLengthWithoutTags)
	{
		return null;
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x682A70", Offset = "0x681C70", VA = "0x180682A70")]
	public TextVertexLimitter()
	{
	}
}
