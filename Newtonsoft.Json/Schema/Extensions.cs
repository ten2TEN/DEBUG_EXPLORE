using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Schema
{
	public static class Extensions
	{
		public static bool IsValid(this JToken source, JsonSchema schema)
		{
			bool flag = true;
			source.Validate(schema, (object sender, ValidationEventArgs args) => flag = false);
			return flag;
		}

		public static bool IsValid(this JToken source, JsonSchema schema, out IList<string> errorMessages)
		{
			IList<string> strs = new List<string>();
			source.Validate(schema, (object sender, ValidationEventArgs args) => strs.Add(args.Message));
			errorMessages = strs;
			return errorMessages.Count == 0;
		}

		public static void Validate(this JToken source, JsonSchema schema)
		{
			source.Validate(schema, null);
		}

		public static void Validate(this JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
		{
			ValidationUtils.ArgumentNotNull(source, "source");
			ValidationUtils.ArgumentNotNull(schema, "schema");
			using (JsonValidatingReader jsonValidatingReader = new JsonValidatingReader(source.CreateReader()))
			{
				jsonValidatingReader.Schema = schema;
				if (validationEventHandler != null)
				{
					jsonValidatingReader.ValidationEventHandler += validationEventHandler;
				}
				while (jsonValidatingReader.Read())
				{
				}
			}
		}
	}
}