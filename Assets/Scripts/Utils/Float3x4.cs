﻿using UnityEngine;

namespace Utils
{
	public struct Float3x4
	{
		public static Float3x4 Identity
			=> new Float3x4
			{
				m00 = 1f, m01 = 0f, m02 = 0f,
				m10 = 0f, m11 = 1f, m12 = 0f,
				m20 = 0f, m21 = 0f, m22 = 1f,
				m30 = 0f, m31 = 0f, m32 = 0f
			};

		public Vector3 Position
		{
			get { return new Vector3(m30, m31, m32); }
			set { m30 = value.x; m31 = value.y; m32 = value.z; }
		}

		public float m00, m01, m02;
		public float m10, m11, m12;
		public float m20, m21, m22;
		public float m30, m31, m32;

		public static Float3x4 FromPosition(Vector3 position)
			=> new Float3x4
			{
				m00 = 1f, m01 = 0f, m02 = 0f,
				m10 = 0f, m11 = 1f, m12 = 0f,
				m20 = 0f, m21 = 0f, m22 = 1f,
				m30 = position.x, m31 = position.y, m32 = position.z
			};

		public static Float3x4 FromPositionAndAxis(Vector3 position, Vector3 right, Vector3 up, Vector3 forward)
			=> new Float3x4
			{
				m00 = right.x, m01 = right.y, m02 = right.z,
				m10 = up.x, m11 = up.y, m12 = up.z,
				m20 = forward.x, m21 = forward.y, m22 = forward.z,
				m30 = position.x, m31 = position.y, m32 = position.z
			};
	}
}