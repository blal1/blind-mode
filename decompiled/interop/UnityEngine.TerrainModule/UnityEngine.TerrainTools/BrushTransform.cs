namespace UnityEngine.TerrainTools;

public struct BrushTransform
{
	public readonly Vector2 _003CbrushOrigin_003Ek__BackingField;

	public readonly Vector2 _003CbrushU_003Ek__BackingField;

	public readonly Vector2 _003CbrushV_003Ek__BackingField;

	public readonly Vector2 _003CtargetOrigin_003Ek__BackingField;

	public readonly Vector2 _003CtargetX_003Ek__BackingField;

	public readonly Vector2 _003CtargetY_003Ek__BackingField;

	public Vector2 brushOrigin => _003CbrushOrigin_003Ek__BackingField;

	public Vector2 brushU => _003CbrushU_003Ek__BackingField;

	public Vector2 brushV => _003CbrushV_003Ek__BackingField;

	public Vector2 targetOrigin => _003CtargetOrigin_003Ek__BackingField;

	public Vector2 targetX => _003CtargetX_003Ek__BackingField;

	public Vector2 targetY => _003CtargetY_003Ek__BackingField;

	public Rect GetBrushXYBounds()
	{
		Vector2 vector = brushOrigin + brushU;
		Vector2 vector2 = brushOrigin + brushV;
		Vector2 vector3 = brushOrigin + brushU + brushV;
		float xmin = Mathf.Min(Mathf.Min(brushOrigin.x, vector.x), Mathf.Min(vector2.x, vector3.x));
		float xmax = Mathf.Max(Mathf.Max(brushOrigin.x, vector.x), Mathf.Max(vector2.x, vector3.x));
		float ymin = Mathf.Min(Mathf.Min(brushOrigin.y, vector.y), Mathf.Min(vector2.y, vector3.y));
		float ymax = Mathf.Max(Mathf.Max(brushOrigin.y, vector.y), Mathf.Max(vector2.y, vector3.y));
		return Rect.MinMaxRect(xmin, ymin, xmax, ymax);
	}

	public static BrushTransform FromRect(Rect brushRect)
	{
		Vector2 min = brushRect.min;
		Vector2 vector = new Vector2(brushRect.width, 0f);
		Vector2 vector2 = new Vector2(0f, brushRect.height);
		return new BrushTransform(min, vector, vector2);
	}

	public Vector2 ToBrushUV(Vector2 targetXY)
	{
		return targetXY.x * targetX + targetXY.y * targetY + targetOrigin;
	}

	public Vector2 FromBrushUV(Vector2 brushUV)
	{
		return brushUV.x * brushU + brushUV.y * brushV + brushOrigin;
	}
}
