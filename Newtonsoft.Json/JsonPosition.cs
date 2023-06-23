using System;
using System.Collections.Generic;
using System.Text;

namespace Newtonsoft.Json
{
	internal struct JsonPosition
	{
		internal JsonContainerType Type;

		internal int? Position;

		internal string PropertyName;

		internal static string BuildPath(IEnumerable<JsonPosition> positions)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (JsonPosition position in positions)
			{
				position.WriteTo(stringBuilder);
			}
			return stringBuilder.ToString();
		}

		internal bool InsideContainer()
		{
			switch (this.Type)
			{
				case JsonContainerType.Object:
				{
					return this.PropertyName != null;
				}
				case JsonContainerType.Array:
				case JsonContainerType.Constructor:
				{
					return this.Position.HasValue;
				}
			}
			return false;
		}

		internal void WriteTo(StringBuilder sb)
		{
			switch (this.Type)
			{
				case JsonContainerType.Object:
				{
					if (this.PropertyName == null)
					{
						break;
					}
					if (sb.Length > 0)
					{
						sb.Append(".");
					}
					sb.Append(this.PropertyName);
					return;
				}
				case JsonContainerType.Array:
				case JsonContainerType.Constructor:
				{
					if (!this.Position.HasValue)
					{
						break;
					}
					sb.Append("[");
					sb.Append(this.Position);
					sb.Append("]");
					break;
				}
				default:
				{
					return;
				}
			}
		}
	}
}